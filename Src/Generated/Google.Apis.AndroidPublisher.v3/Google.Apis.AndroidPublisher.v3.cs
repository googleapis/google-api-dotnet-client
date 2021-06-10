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

namespace Google.Apis.AndroidPublisher.v3
{
    /// <summary>The AndroidPublisher Service.</summary>
    public class AndroidPublisherService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v3";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public AndroidPublisherService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public AndroidPublisherService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Edits = new EditsResource(this);
            Inappproducts = new InappproductsResource(this);
            Internalappsharingartifacts = new InternalappsharingartifactsResource(this);
            Orders = new OrdersResource(this);
            Purchases = new PurchasesResource(this);
            Reviews = new ReviewsResource(this);
            Systemapks = new SystemapksResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "androidpublisher";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://androidpublisher.googleapis.com/";
        #else
            "https://androidpublisher.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://androidpublisher.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Google Play Android Developer API.</summary>
        public class Scope
        {
            /// <summary>View and manage your Google Play Developer account</summary>
            public static string Androidpublisher = "https://www.googleapis.com/auth/androidpublisher";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Google Play Android Developer API.</summary>
        public static class ScopeConstants
        {
            /// <summary>View and manage your Google Play Developer account</summary>
            public const string Androidpublisher = "https://www.googleapis.com/auth/androidpublisher";
        }

        /// <summary>Gets the Edits resource.</summary>
        public virtual EditsResource Edits { get; }

        /// <summary>Gets the Inappproducts resource.</summary>
        public virtual InappproductsResource Inappproducts { get; }

        /// <summary>Gets the Internalappsharingartifacts resource.</summary>
        public virtual InternalappsharingartifactsResource Internalappsharingartifacts { get; }

        /// <summary>Gets the Orders resource.</summary>
        public virtual OrdersResource Orders { get; }

        /// <summary>Gets the Purchases resource.</summary>
        public virtual PurchasesResource Purchases { get; }

        /// <summary>Gets the Reviews resource.</summary>
        public virtual ReviewsResource Reviews { get; }

        /// <summary>Gets the Systemapks resource.</summary>
        public virtual SystemapksResource Systemapks { get; }
    }

    /// <summary>A base abstract class for AndroidPublisher requests.</summary>
    public abstract class AndroidPublisherBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new AndroidPublisherBaseServiceRequest instance.</summary>
        protected AndroidPublisherBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes AndroidPublisher parameter list.</summary>
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

    /// <summary>The "edits" collection of methods.</summary>
    public class EditsResource
    {
        private const string Resource = "edits";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public EditsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Apks = new ApksResource(service);
            Bundles = new BundlesResource(service);
            Deobfuscationfiles = new DeobfuscationfilesResource(service);
            Details = new DetailsResource(service);
            Expansionfiles = new ExpansionfilesResource(service);
            Images = new ImagesResource(service);
            Listings = new ListingsResource(service);
            Testers = new TestersResource(service);
            Tracks = new TracksResource(service);
        }

        /// <summary>Gets the Apks resource.</summary>
        public virtual ApksResource Apks { get; }

        /// <summary>The "apks" collection of methods.</summary>
        public class ApksResource
        {
            private const string Resource = "apks";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ApksResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Creates a new APK without uploading the APK itself to Google Play, instead hosting the APK at a
            /// specified URL. This function is only available to organizations using Managed Play whose application is
            /// configured to restrict distribution to the organizations.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            public virtual AddexternallyhostedRequest Addexternallyhosted(Google.Apis.AndroidPublisher.v3.Data.ApksAddExternallyHostedRequest body, string packageName, string editId)
            {
                return new AddexternallyhostedRequest(service, body, packageName, editId);
            }

            /// <summary>
            /// Creates a new APK without uploading the APK itself to Google Play, instead hosting the APK at a
            /// specified URL. This function is only available to organizations using Managed Play whose application is
            /// configured to restrict distribution to the organizations.
            /// </summary>
            public class AddexternallyhostedRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.ApksAddExternallyHostedResponse>
            {
                /// <summary>Constructs a new Addexternallyhosted request.</summary>
                public AddexternallyhostedRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.ApksAddExternallyHostedRequest body, string packageName, string editId) : base(service)
                {
                    PackageName = packageName;
                    EditId = editId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AndroidPublisher.v3.Data.ApksAddExternallyHostedRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "addexternallyhosted";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}/apks/externallyHosted";

                /// <summary>Initializes Addexternallyhosted parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "editId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Lists all current APKs of the app and edit.</summary>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            public virtual ListRequest List(string packageName, string editId)
            {
                return new ListRequest(service, packageName, editId);
            }

            /// <summary>Lists all current APKs of the app and edit.</summary>
            public class ListRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.ApksListResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string packageName, string editId) : base(service)
                {
                    PackageName = packageName;
                    EditId = editId;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}/apks";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "editId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Uploads an APK and adds to the current edit.</summary>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            public virtual UploadRequest Upload(string packageName, string editId)
            {
                return new UploadRequest(service, packageName, editId);
            }

            /// <summary>Uploads an APK and adds to the current edit.</summary>
            public class UploadRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.Apk>
            {
                /// <summary>Constructs a new Upload request.</summary>
                public UploadRequest(Google.Apis.Services.IClientService service, string packageName, string editId) : base(service)
                {
                    PackageName = packageName;
                    EditId = editId;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "upload";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}/apks";

                /// <summary>Initializes Upload parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "editId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Uploads an APK and adds to the current edit.</summary>
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
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            /// <param name="stream">The stream to upload. See remarks for further information.</param>
            /// <param name="contentType">The content type of the stream to upload.</param>
            public virtual UploadMediaUpload Upload(string packageName, string editId, System.IO.Stream stream, string contentType)
            {
                return new UploadMediaUpload(service, packageName, editId, stream, contentType);
            }

            /// <summary>Upload media upload which supports resumable upload.</summary>
            public class UploadMediaUpload : Google.Apis.Upload.ResumableUpload<string, Google.Apis.AndroidPublisher.v3.Data.Apk>
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
                /// Available to use for quota purposes for server-side applications. Can be any arbitrary string
                /// assigned to a user, but should not exceed 40 characters.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string QuotaUser { get; set; }

                /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
                [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string UploadType { get; set; }

                /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
                [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string UploadProtocol { get; set; }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>Constructs a new Upload media upload instance.</summary>
                /// <remarks>
                /// Considerations regarding <paramref name="stream"/>:
                /// <list type="bullet">
                /// <item>
                /// <description>
                /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c> before
                /// reading commences. If <paramref name="stream"/> is not seekable, then it will be read from its
                /// current position
                /// </description>
                /// </item>
                /// <item>
                /// <description>
                /// Caller is responsible for maintaining the <paramref name="stream"/> open until the upload is
                /// completed
                /// </description>
                /// </item>
                /// <item>
                /// <description>Caller is responsible for closing the <paramref name="stream"/></description>
                /// </item>
                /// </list>
                /// </remarks>
                public UploadMediaUpload(Google.Apis.Services.IClientService service, string packageName, string editId, System.IO.Stream stream, string contentType)
                    : base(service, string.Format("/{0}/{1}{2}", "upload", service.BasePath, "androidpublisher/v3/applications/{packageName}/edits/{editId}/apks"), "POST", stream, contentType)
                {
                    PackageName = packageName;
                    EditId = editId;
                }
            }
        }

        /// <summary>Gets the Bundles resource.</summary>
        public virtual BundlesResource Bundles { get; }

        /// <summary>The "bundles" collection of methods.</summary>
        public class BundlesResource
        {
            private const string Resource = "bundles";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public BundlesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Lists all current Android App Bundles of the app and edit.</summary>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            public virtual ListRequest List(string packageName, string editId)
            {
                return new ListRequest(service, packageName, editId);
            }

            /// <summary>Lists all current Android App Bundles of the app and edit.</summary>
            public class ListRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.BundlesListResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string packageName, string editId) : base(service)
                {
                    PackageName = packageName;
                    EditId = editId;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}/bundles";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "editId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Uploads a new Android App Bundle to this edit. If you are using the Google API client libraries, please
            /// increase the timeout of the http request before calling this endpoint (a timeout of 2 minutes is
            /// recommended). See [Timeouts and
            /// Errors](https://developers.google.com/api-client-library/java/google-api-java-client/errors) for an
            /// example in java.
            /// </summary>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            public virtual UploadRequest Upload(string packageName, string editId)
            {
                return new UploadRequest(service, packageName, editId);
            }

            /// <summary>
            /// Uploads a new Android App Bundle to this edit. If you are using the Google API client libraries, please
            /// increase the timeout of the http request before calling this endpoint (a timeout of 2 minutes is
            /// recommended). See [Timeouts and
            /// Errors](https://developers.google.com/api-client-library/java/google-api-java-client/errors) for an
            /// example in java.
            /// </summary>
            public class UploadRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.Bundle>
            {
                /// <summary>Constructs a new Upload request.</summary>
                public UploadRequest(Google.Apis.Services.IClientService service, string packageName, string editId) : base(service)
                {
                    PackageName = packageName;
                    EditId = editId;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>
                /// Must be set to true if the bundle installation may trigger a warning on user devices (for example,
                /// if installation size may be over a threshold, typically 100 MB).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("ackBundleInstallationWarning", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> AckBundleInstallationWarning { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "upload";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}/bundles";

                /// <summary>Initializes Upload parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "editId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("ackBundleInstallationWarning", new Google.Apis.Discovery.Parameter
                    {
                        Name = "ackBundleInstallationWarning",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Uploads a new Android App Bundle to this edit. If you are using the Google API client libraries, please
            /// increase the timeout of the http request before calling this endpoint (a timeout of 2 minutes is
            /// recommended). See [Timeouts and
            /// Errors](https://developers.google.com/api-client-library/java/google-api-java-client/errors) for an
            /// example in java.
            /// </summary>
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
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            /// <param name="stream">The stream to upload. See remarks for further information.</param>
            /// <param name="contentType">The content type of the stream to upload.</param>
            public virtual UploadMediaUpload Upload(string packageName, string editId, System.IO.Stream stream, string contentType)
            {
                return new UploadMediaUpload(service, packageName, editId, stream, contentType);
            }

            /// <summary>Upload media upload which supports resumable upload.</summary>
            public class UploadMediaUpload : Google.Apis.Upload.ResumableUpload<string, Google.Apis.AndroidPublisher.v3.Data.Bundle>
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
                /// Available to use for quota purposes for server-side applications. Can be any arbitrary string
                /// assigned to a user, but should not exceed 40 characters.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string QuotaUser { get; set; }

                /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
                [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string UploadType { get; set; }

                /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
                [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string UploadProtocol { get; set; }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>
                /// Must be set to true if the bundle installation may trigger a warning on user devices (for example,
                /// if installation size may be over a threshold, typically 100 MB).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("ackBundleInstallationWarning", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> AckBundleInstallationWarning { get; set; }

                /// <summary>Constructs a new Upload media upload instance.</summary>
                /// <remarks>
                /// Considerations regarding <paramref name="stream"/>:
                /// <list type="bullet">
                /// <item>
                /// <description>
                /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c> before
                /// reading commences. If <paramref name="stream"/> is not seekable, then it will be read from its
                /// current position
                /// </description>
                /// </item>
                /// <item>
                /// <description>
                /// Caller is responsible for maintaining the <paramref name="stream"/> open until the upload is
                /// completed
                /// </description>
                /// </item>
                /// <item>
                /// <description>Caller is responsible for closing the <paramref name="stream"/></description>
                /// </item>
                /// </list>
                /// </remarks>
                public UploadMediaUpload(Google.Apis.Services.IClientService service, string packageName, string editId, System.IO.Stream stream, string contentType)
                    : base(service, string.Format("/{0}/{1}{2}", "upload", service.BasePath, "androidpublisher/v3/applications/{packageName}/edits/{editId}/bundles"), "POST", stream, contentType)
                {
                    PackageName = packageName;
                    EditId = editId;
                }
            }
        }

        /// <summary>Gets the Deobfuscationfiles resource.</summary>
        public virtual DeobfuscationfilesResource Deobfuscationfiles { get; }

        /// <summary>The "deobfuscationfiles" collection of methods.</summary>
        public class DeobfuscationfilesResource
        {
            private const string Resource = "deobfuscationfiles";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public DeobfuscationfilesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Uploads a new deobfuscation file and attaches to the specified APK.</summary>
            /// <param name="packageName">Unique identifier for the Android app.</param>
            /// <param name="editId">Unique identifier for this edit.</param>
            /// <param name="apkVersionCode">
            /// The version code of the APK whose Deobfuscation File is being uploaded.
            /// </param>
            /// <param name="deobfuscationFileType">The type of the deobfuscation file.</param>
            public virtual UploadRequest Upload(string packageName, string editId, int apkVersionCode, UploadRequest.DeobfuscationFileTypeEnum deobfuscationFileType)
            {
                return new UploadRequest(service, packageName, editId, apkVersionCode, deobfuscationFileType);
            }

            /// <summary>Uploads a new deobfuscation file and attaches to the specified APK.</summary>
            public class UploadRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.DeobfuscationFilesUploadResponse>
            {
                /// <summary>Constructs a new Upload request.</summary>
                public UploadRequest(Google.Apis.Services.IClientService service, string packageName, string editId, int apkVersionCode, DeobfuscationFileTypeEnum deobfuscationFileType) : base(service)
                {
                    PackageName = packageName;
                    EditId = editId;
                    ApkVersionCode = apkVersionCode;
                    DeobfuscationFileType = deobfuscationFileType;
                    InitParameters();
                }

                /// <summary>Unique identifier for the Android app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Unique identifier for this edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>The version code of the APK whose Deobfuscation File is being uploaded.</summary>
                [Google.Apis.Util.RequestParameterAttribute("apkVersionCode", Google.Apis.Util.RequestParameterType.Path)]
                public virtual int ApkVersionCode { get; private set; }

                /// <summary>The type of the deobfuscation file.</summary>
                [Google.Apis.Util.RequestParameterAttribute("deobfuscationFileType", Google.Apis.Util.RequestParameterType.Path)]
                public virtual DeobfuscationFileTypeEnum DeobfuscationFileType { get; private set; }

                /// <summary>The type of the deobfuscation file.</summary>
                public enum DeobfuscationFileTypeEnum
                {
                    /// <summary>Unspecified deobfuscation file type.</summary>
                    [Google.Apis.Util.StringValueAttribute("deobfuscationFileTypeUnspecified")]
                    DeobfuscationFileTypeUnspecified = 0,

                    /// <summary>Proguard deobfuscation file type.</summary>
                    [Google.Apis.Util.StringValueAttribute("proguard")]
                    Proguard = 1,

                    /// <summary>Native debugging symbols file type.</summary>
                    [Google.Apis.Util.StringValueAttribute("nativeCode")]
                    NativeCode = 2,
                }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "upload";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}/apks/{apkVersionCode}/deobfuscationFiles/{deobfuscationFileType}";

                /// <summary>Initializes Upload parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "editId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("apkVersionCode", new Google.Apis.Discovery.Parameter
                    {
                        Name = "apkVersionCode",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("deobfuscationFileType", new Google.Apis.Discovery.Parameter
                    {
                        Name = "deobfuscationFileType",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Uploads a new deobfuscation file and attaches to the specified APK.</summary>
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
            /// <param name="packageName">Unique identifier for the Android app.</param>
            /// <param name="editId">Unique identifier for this edit.</param>
            /// <param name="apkVersionCode">
            /// The version code of the APK whose Deobfuscation File is being uploaded.
            /// </param>
            /// <param name="deobfuscationFileType">The type of the deobfuscation file.</param>
            /// <param name="stream">The stream to upload. See remarks for further information.</param>
            /// <param name="contentType">The content type of the stream to upload.</param>
            public virtual UploadMediaUpload Upload(string packageName, string editId, int apkVersionCode, UploadMediaUpload.DeobfuscationFileTypeEnum deobfuscationFileType, System.IO.Stream stream, string contentType)
            {
                return new UploadMediaUpload(service, packageName, editId, apkVersionCode, deobfuscationFileType, stream, contentType);
            }

            /// <summary>Upload media upload which supports resumable upload.</summary>
            public class UploadMediaUpload : Google.Apis.Upload.ResumableUpload<string, Google.Apis.AndroidPublisher.v3.Data.DeobfuscationFilesUploadResponse>
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
                /// Available to use for quota purposes for server-side applications. Can be any arbitrary string
                /// assigned to a user, but should not exceed 40 characters.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string QuotaUser { get; set; }

                /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
                [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string UploadType { get; set; }

                /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
                [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string UploadProtocol { get; set; }

                /// <summary>Unique identifier for the Android app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Unique identifier for this edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>The version code of the APK whose Deobfuscation File is being uploaded.</summary>
                [Google.Apis.Util.RequestParameterAttribute("apkVersionCode", Google.Apis.Util.RequestParameterType.Path)]
                public virtual int ApkVersionCode { get; private set; }

                /// <summary>The type of the deobfuscation file.</summary>
                [Google.Apis.Util.RequestParameterAttribute("deobfuscationFileType", Google.Apis.Util.RequestParameterType.Path)]
                public virtual DeobfuscationFileTypeEnum DeobfuscationFileType { get; private set; }

                /// <summary>The type of the deobfuscation file.</summary>
                public enum DeobfuscationFileTypeEnum
                {
                    /// <summary>Unspecified deobfuscation file type.</summary>
                    [Google.Apis.Util.StringValueAttribute("deobfuscationFileTypeUnspecified")]
                    DeobfuscationFileTypeUnspecified = 0,

                    /// <summary>Proguard deobfuscation file type.</summary>
                    [Google.Apis.Util.StringValueAttribute("proguard")]
                    Proguard = 1,

                    /// <summary>Native debugging symbols file type.</summary>
                    [Google.Apis.Util.StringValueAttribute("nativeCode")]
                    NativeCode = 2,
                }

                /// <summary>Constructs a new Upload media upload instance.</summary>
                /// <remarks>
                /// Considerations regarding <paramref name="stream"/>:
                /// <list type="bullet">
                /// <item>
                /// <description>
                /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c> before
                /// reading commences. If <paramref name="stream"/> is not seekable, then it will be read from its
                /// current position
                /// </description>
                /// </item>
                /// <item>
                /// <description>
                /// Caller is responsible for maintaining the <paramref name="stream"/> open until the upload is
                /// completed
                /// </description>
                /// </item>
                /// <item>
                /// <description>Caller is responsible for closing the <paramref name="stream"/></description>
                /// </item>
                /// </list>
                /// </remarks>
                public UploadMediaUpload(Google.Apis.Services.IClientService service, string packageName, string editId, int apkVersionCode, UploadMediaUpload.DeobfuscationFileTypeEnum deobfuscationFileType, System.IO.Stream stream, string contentType)
                    : base(service, string.Format("/{0}/{1}{2}", "upload", service.BasePath, "androidpublisher/v3/applications/{packageName}/edits/{editId}/apks/{apkVersionCode}/deobfuscationFiles/{deobfuscationFileType}"), "POST", stream, contentType)
                {
                    PackageName = packageName;
                    EditId = editId;
                    ApkVersionCode = apkVersionCode;
                    DeobfuscationFileType = deobfuscationFileType;
                }
            }
        }

        /// <summary>Gets the Details resource.</summary>
        public virtual DetailsResource Details { get; }

        /// <summary>The "details" collection of methods.</summary>
        public class DetailsResource
        {
            private const string Resource = "details";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public DetailsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Gets details of an app.</summary>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            public virtual GetRequest Get(string packageName, string editId)
            {
                return new GetRequest(service, packageName, editId);
            }

            /// <summary>Gets details of an app.</summary>
            public class GetRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.AppDetails>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string packageName, string editId) : base(service)
                {
                    PackageName = packageName;
                    EditId = editId;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}/details";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "editId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Patches details of an app.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            public virtual PatchRequest Patch(Google.Apis.AndroidPublisher.v3.Data.AppDetails body, string packageName, string editId)
            {
                return new PatchRequest(service, body, packageName, editId);
            }

            /// <summary>Patches details of an app.</summary>
            public class PatchRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.AppDetails>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.AppDetails body, string packageName, string editId) : base(service)
                {
                    PackageName = packageName;
                    EditId = editId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AndroidPublisher.v3.Data.AppDetails Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}/details";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "editId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Updates details of an app.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            public virtual UpdateRequest Update(Google.Apis.AndroidPublisher.v3.Data.AppDetails body, string packageName, string editId)
            {
                return new UpdateRequest(service, body, packageName, editId);
            }

            /// <summary>Updates details of an app.</summary>
            public class UpdateRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.AppDetails>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.AppDetails body, string packageName, string editId) : base(service)
                {
                    PackageName = packageName;
                    EditId = editId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AndroidPublisher.v3.Data.AppDetails Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "update";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}/details";

                /// <summary>Initializes Update parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "editId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the Expansionfiles resource.</summary>
        public virtual ExpansionfilesResource Expansionfiles { get; }

        /// <summary>The "expansionfiles" collection of methods.</summary>
        public class ExpansionfilesResource
        {
            private const string Resource = "expansionfiles";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ExpansionfilesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Fetches the expansion file configuration for the specified APK.</summary>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            /// <param name="apkVersionCode">
            /// The version code of the APK whose expansion file configuration is being read or modified.
            /// </param>
            /// <param name="expansionFileType">
            /// The file type of the file configuration which is being read or modified.
            /// </param>
            public virtual GetRequest Get(string packageName, string editId, int apkVersionCode, GetRequest.ExpansionFileTypeEnum expansionFileType)
            {
                return new GetRequest(service, packageName, editId, apkVersionCode, expansionFileType);
            }

            /// <summary>Fetches the expansion file configuration for the specified APK.</summary>
            public class GetRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.ExpansionFile>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string packageName, string editId, int apkVersionCode, ExpansionFileTypeEnum expansionFileType) : base(service)
                {
                    PackageName = packageName;
                    EditId = editId;
                    ApkVersionCode = apkVersionCode;
                    ExpansionFileType = expansionFileType;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>
                /// The version code of the APK whose expansion file configuration is being read or modified.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("apkVersionCode", Google.Apis.Util.RequestParameterType.Path)]
                public virtual int ApkVersionCode { get; private set; }

                /// <summary>The file type of the file configuration which is being read or modified.</summary>
                [Google.Apis.Util.RequestParameterAttribute("expansionFileType", Google.Apis.Util.RequestParameterType.Path)]
                public virtual ExpansionFileTypeEnum ExpansionFileType { get; private set; }

                /// <summary>The file type of the file configuration which is being read or modified.</summary>
                public enum ExpansionFileTypeEnum
                {
                    /// <summary>Unspecified expansion file type.</summary>
                    [Google.Apis.Util.StringValueAttribute("expansionFileTypeUnspecified")]
                    ExpansionFileTypeUnspecified = 0,

                    /// <summary>Main expansion file.</summary>
                    [Google.Apis.Util.StringValueAttribute("main")]
                    Main = 1,

                    /// <summary>Patch expansion file.</summary>
                    [Google.Apis.Util.StringValueAttribute("patch")]
                    Patch = 2,
                }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}/apks/{apkVersionCode}/expansionFiles/{expansionFileType}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "editId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("apkVersionCode", new Google.Apis.Discovery.Parameter
                    {
                        Name = "apkVersionCode",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("expansionFileType", new Google.Apis.Discovery.Parameter
                    {
                        Name = "expansionFileType",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Patches the APK's expansion file configuration to reference another APK's expansion file. To add a new
            /// expansion file use the Upload method.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            /// <param name="apkVersionCode">
            /// The version code of the APK whose expansion file configuration is being read or modified.
            /// </param>
            /// <param name="expansionFileType">
            /// The file type of the expansion file configuration which is being updated.
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.AndroidPublisher.v3.Data.ExpansionFile body, string packageName, string editId, int apkVersionCode, PatchRequest.ExpansionFileTypeEnum expansionFileType)
            {
                return new PatchRequest(service, body, packageName, editId, apkVersionCode, expansionFileType);
            }

            /// <summary>
            /// Patches the APK's expansion file configuration to reference another APK's expansion file. To add a new
            /// expansion file use the Upload method.
            /// </summary>
            public class PatchRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.ExpansionFile>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.ExpansionFile body, string packageName, string editId, int apkVersionCode, ExpansionFileTypeEnum expansionFileType) : base(service)
                {
                    PackageName = packageName;
                    EditId = editId;
                    ApkVersionCode = apkVersionCode;
                    ExpansionFileType = expansionFileType;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>
                /// The version code of the APK whose expansion file configuration is being read or modified.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("apkVersionCode", Google.Apis.Util.RequestParameterType.Path)]
                public virtual int ApkVersionCode { get; private set; }

                /// <summary>The file type of the expansion file configuration which is being updated.</summary>
                [Google.Apis.Util.RequestParameterAttribute("expansionFileType", Google.Apis.Util.RequestParameterType.Path)]
                public virtual ExpansionFileTypeEnum ExpansionFileType { get; private set; }

                /// <summary>The file type of the expansion file configuration which is being updated.</summary>
                public enum ExpansionFileTypeEnum
                {
                    /// <summary>Unspecified expansion file type.</summary>
                    [Google.Apis.Util.StringValueAttribute("expansionFileTypeUnspecified")]
                    ExpansionFileTypeUnspecified = 0,

                    /// <summary>Main expansion file.</summary>
                    [Google.Apis.Util.StringValueAttribute("main")]
                    Main = 1,

                    /// <summary>Patch expansion file.</summary>
                    [Google.Apis.Util.StringValueAttribute("patch")]
                    Patch = 2,
                }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AndroidPublisher.v3.Data.ExpansionFile Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}/apks/{apkVersionCode}/expansionFiles/{expansionFileType}";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "editId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("apkVersionCode", new Google.Apis.Discovery.Parameter
                    {
                        Name = "apkVersionCode",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("expansionFileType", new Google.Apis.Discovery.Parameter
                    {
                        Name = "expansionFileType",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Updates the APK's expansion file configuration to reference another APK's expansion file. To add a new
            /// expansion file use the Upload method.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            /// <param name="apkVersionCode">
            /// The version code of the APK whose expansion file configuration is being read or modified.
            /// </param>
            /// <param name="expansionFileType">
            /// The file type of the file configuration which is being read or modified.
            /// </param>
            public virtual UpdateRequest Update(Google.Apis.AndroidPublisher.v3.Data.ExpansionFile body, string packageName, string editId, int apkVersionCode, UpdateRequest.ExpansionFileTypeEnum expansionFileType)
            {
                return new UpdateRequest(service, body, packageName, editId, apkVersionCode, expansionFileType);
            }

            /// <summary>
            /// Updates the APK's expansion file configuration to reference another APK's expansion file. To add a new
            /// expansion file use the Upload method.
            /// </summary>
            public class UpdateRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.ExpansionFile>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.ExpansionFile body, string packageName, string editId, int apkVersionCode, ExpansionFileTypeEnum expansionFileType) : base(service)
                {
                    PackageName = packageName;
                    EditId = editId;
                    ApkVersionCode = apkVersionCode;
                    ExpansionFileType = expansionFileType;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>
                /// The version code of the APK whose expansion file configuration is being read or modified.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("apkVersionCode", Google.Apis.Util.RequestParameterType.Path)]
                public virtual int ApkVersionCode { get; private set; }

                /// <summary>The file type of the file configuration which is being read or modified.</summary>
                [Google.Apis.Util.RequestParameterAttribute("expansionFileType", Google.Apis.Util.RequestParameterType.Path)]
                public virtual ExpansionFileTypeEnum ExpansionFileType { get; private set; }

                /// <summary>The file type of the file configuration which is being read or modified.</summary>
                public enum ExpansionFileTypeEnum
                {
                    /// <summary>Unspecified expansion file type.</summary>
                    [Google.Apis.Util.StringValueAttribute("expansionFileTypeUnspecified")]
                    ExpansionFileTypeUnspecified = 0,

                    /// <summary>Main expansion file.</summary>
                    [Google.Apis.Util.StringValueAttribute("main")]
                    Main = 1,

                    /// <summary>Patch expansion file.</summary>
                    [Google.Apis.Util.StringValueAttribute("patch")]
                    Patch = 2,
                }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AndroidPublisher.v3.Data.ExpansionFile Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "update";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}/apks/{apkVersionCode}/expansionFiles/{expansionFileType}";

                /// <summary>Initializes Update parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "editId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("apkVersionCode", new Google.Apis.Discovery.Parameter
                    {
                        Name = "apkVersionCode",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("expansionFileType", new Google.Apis.Discovery.Parameter
                    {
                        Name = "expansionFileType",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Uploads a new expansion file and attaches to the specified APK.</summary>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            /// <param name="apkVersionCode">
            /// The version code of the APK whose expansion file configuration is being read or modified.
            /// </param>
            /// <param name="expansionFileType">
            /// The file type of the expansion file configuration which is being updated.
            /// </param>
            public virtual UploadRequest Upload(string packageName, string editId, int apkVersionCode, UploadRequest.ExpansionFileTypeEnum expansionFileType)
            {
                return new UploadRequest(service, packageName, editId, apkVersionCode, expansionFileType);
            }

            /// <summary>Uploads a new expansion file and attaches to the specified APK.</summary>
            public class UploadRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.ExpansionFilesUploadResponse>
            {
                /// <summary>Constructs a new Upload request.</summary>
                public UploadRequest(Google.Apis.Services.IClientService service, string packageName, string editId, int apkVersionCode, ExpansionFileTypeEnum expansionFileType) : base(service)
                {
                    PackageName = packageName;
                    EditId = editId;
                    ApkVersionCode = apkVersionCode;
                    ExpansionFileType = expansionFileType;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>
                /// The version code of the APK whose expansion file configuration is being read or modified.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("apkVersionCode", Google.Apis.Util.RequestParameterType.Path)]
                public virtual int ApkVersionCode { get; private set; }

                /// <summary>The file type of the expansion file configuration which is being updated.</summary>
                [Google.Apis.Util.RequestParameterAttribute("expansionFileType", Google.Apis.Util.RequestParameterType.Path)]
                public virtual ExpansionFileTypeEnum ExpansionFileType { get; private set; }

                /// <summary>The file type of the expansion file configuration which is being updated.</summary>
                public enum ExpansionFileTypeEnum
                {
                    /// <summary>Unspecified expansion file type.</summary>
                    [Google.Apis.Util.StringValueAttribute("expansionFileTypeUnspecified")]
                    ExpansionFileTypeUnspecified = 0,

                    /// <summary>Main expansion file.</summary>
                    [Google.Apis.Util.StringValueAttribute("main")]
                    Main = 1,

                    /// <summary>Patch expansion file.</summary>
                    [Google.Apis.Util.StringValueAttribute("patch")]
                    Patch = 2,
                }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "upload";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}/apks/{apkVersionCode}/expansionFiles/{expansionFileType}";

                /// <summary>Initializes Upload parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "editId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("apkVersionCode", new Google.Apis.Discovery.Parameter
                    {
                        Name = "apkVersionCode",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("expansionFileType", new Google.Apis.Discovery.Parameter
                    {
                        Name = "expansionFileType",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Uploads a new expansion file and attaches to the specified APK.</summary>
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
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            /// <param name="apkVersionCode">
            /// The version code of the APK whose expansion file configuration is being read or modified.
            /// </param>
            /// <param name="expansionFileType">
            /// The file type of the expansion file configuration which is being updated.
            /// </param>
            /// <param name="stream">The stream to upload. See remarks for further information.</param>
            /// <param name="contentType">The content type of the stream to upload.</param>
            public virtual UploadMediaUpload Upload(string packageName, string editId, int apkVersionCode, UploadMediaUpload.ExpansionFileTypeEnum expansionFileType, System.IO.Stream stream, string contentType)
            {
                return new UploadMediaUpload(service, packageName, editId, apkVersionCode, expansionFileType, stream, contentType);
            }

            /// <summary>Upload media upload which supports resumable upload.</summary>
            public class UploadMediaUpload : Google.Apis.Upload.ResumableUpload<string, Google.Apis.AndroidPublisher.v3.Data.ExpansionFilesUploadResponse>
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
                /// Available to use for quota purposes for server-side applications. Can be any arbitrary string
                /// assigned to a user, but should not exceed 40 characters.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string QuotaUser { get; set; }

                /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
                [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string UploadType { get; set; }

                /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
                [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string UploadProtocol { get; set; }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>
                /// The version code of the APK whose expansion file configuration is being read or modified.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("apkVersionCode", Google.Apis.Util.RequestParameterType.Path)]
                public virtual int ApkVersionCode { get; private set; }

                /// <summary>The file type of the expansion file configuration which is being updated.</summary>
                [Google.Apis.Util.RequestParameterAttribute("expansionFileType", Google.Apis.Util.RequestParameterType.Path)]
                public virtual ExpansionFileTypeEnum ExpansionFileType { get; private set; }

                /// <summary>The file type of the expansion file configuration which is being updated.</summary>
                public enum ExpansionFileTypeEnum
                {
                    /// <summary>Unspecified expansion file type.</summary>
                    [Google.Apis.Util.StringValueAttribute("expansionFileTypeUnspecified")]
                    ExpansionFileTypeUnspecified = 0,

                    /// <summary>Main expansion file.</summary>
                    [Google.Apis.Util.StringValueAttribute("main")]
                    Main = 1,

                    /// <summary>Patch expansion file.</summary>
                    [Google.Apis.Util.StringValueAttribute("patch")]
                    Patch = 2,
                }

                /// <summary>Constructs a new Upload media upload instance.</summary>
                /// <remarks>
                /// Considerations regarding <paramref name="stream"/>:
                /// <list type="bullet">
                /// <item>
                /// <description>
                /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c> before
                /// reading commences. If <paramref name="stream"/> is not seekable, then it will be read from its
                /// current position
                /// </description>
                /// </item>
                /// <item>
                /// <description>
                /// Caller is responsible for maintaining the <paramref name="stream"/> open until the upload is
                /// completed
                /// </description>
                /// </item>
                /// <item>
                /// <description>Caller is responsible for closing the <paramref name="stream"/></description>
                /// </item>
                /// </list>
                /// </remarks>
                public UploadMediaUpload(Google.Apis.Services.IClientService service, string packageName, string editId, int apkVersionCode, UploadMediaUpload.ExpansionFileTypeEnum expansionFileType, System.IO.Stream stream, string contentType)
                    : base(service, string.Format("/{0}/{1}{2}", "upload", service.BasePath, "androidpublisher/v3/applications/{packageName}/edits/{editId}/apks/{apkVersionCode}/expansionFiles/{expansionFileType}"), "POST", stream, contentType)
                {
                    PackageName = packageName;
                    EditId = editId;
                    ApkVersionCode = apkVersionCode;
                    ExpansionFileType = expansionFileType;
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

            /// <summary>Deletes the image (specified by id) from the edit.</summary>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            /// <param name="language">
            /// Language localization code (a BCP-47 language tag; for example, "de-AT" for Austrian German).
            /// </param>
            /// <param name="imageType">Type of the Image.</param>
            /// <param name="imageId">Unique identifier an image within the set of images attached to this edit.</param>
            public virtual DeleteRequest Delete(string packageName, string editId, string language, DeleteRequest.ImageTypeEnum imageType, string imageId)
            {
                return new DeleteRequest(service, packageName, editId, language, imageType, imageId);
            }

            /// <summary>Deletes the image (specified by id) from the edit.</summary>
            public class DeleteRequest : AndroidPublisherBaseServiceRequest<string>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string packageName, string editId, string language, ImageTypeEnum imageType, string imageId) : base(service)
                {
                    PackageName = packageName;
                    EditId = editId;
                    Language = language;
                    ImageType = imageType;
                    ImageId = imageId;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>
                /// Language localization code (a BCP-47 language tag; for example, "de-AT" for Austrian German).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("language", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Language { get; private set; }

                /// <summary>Type of the Image.</summary>
                [Google.Apis.Util.RequestParameterAttribute("imageType", Google.Apis.Util.RequestParameterType.Path)]
                public virtual ImageTypeEnum ImageType { get; private set; }

                /// <summary>Type of the Image.</summary>
                public enum ImageTypeEnum
                {
                    /// <summary>Unspecified type. Do not use.</summary>
                    [Google.Apis.Util.StringValueAttribute("appImageTypeUnspecified")]
                    AppImageTypeUnspecified = 0,

                    /// <summary>Phone screenshot.</summary>
                    [Google.Apis.Util.StringValueAttribute("phoneScreenshots")]
                    PhoneScreenshots = 1,

                    /// <summary>Seven inch screenshot.</summary>
                    [Google.Apis.Util.StringValueAttribute("sevenInchScreenshots")]
                    SevenInchScreenshots = 2,

                    /// <summary>Ten inch screenshot.</summary>
                    [Google.Apis.Util.StringValueAttribute("tenInchScreenshots")]
                    TenInchScreenshots = 3,

                    /// <summary>TV screenshot.</summary>
                    [Google.Apis.Util.StringValueAttribute("tvScreenshots")]
                    TvScreenshots = 4,

                    /// <summary>Wear screenshot.</summary>
                    [Google.Apis.Util.StringValueAttribute("wearScreenshots")]
                    WearScreenshots = 5,

                    /// <summary>Icon.</summary>
                    [Google.Apis.Util.StringValueAttribute("icon")]
                    Icon = 6,

                    /// <summary>Feature graphic.</summary>
                    [Google.Apis.Util.StringValueAttribute("featureGraphic")]
                    FeatureGraphic = 7,

                    /// <summary>TV banner.</summary>
                    [Google.Apis.Util.StringValueAttribute("tvBanner")]
                    TvBanner = 8,
                }

                /// <summary>Unique identifier an image within the set of images attached to this edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("imageId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ImageId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}/listings/{language}/{imageType}/{imageId}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "editId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("language", new Google.Apis.Discovery.Parameter
                    {
                        Name = "language",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("imageType", new Google.Apis.Discovery.Parameter
                    {
                        Name = "imageType",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("imageId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "imageId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Deletes all images for the specified language and image type. Returns an empty response if no images are
            /// found.
            /// </summary>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            /// <param name="language">
            /// Language localization code (a BCP-47 language tag; for example, "de-AT" for Austrian German). Providing
            /// a language that is not supported by the App is a no-op.
            /// </param>
            /// <param name="imageType">
            /// Type of the Image. Providing an image type that refers to no images is a no-op.
            /// </param>
            public virtual DeleteallRequest Deleteall(string packageName, string editId, string language, DeleteallRequest.ImageTypeEnum imageType)
            {
                return new DeleteallRequest(service, packageName, editId, language, imageType);
            }

            /// <summary>
            /// Deletes all images for the specified language and image type. Returns an empty response if no images are
            /// found.
            /// </summary>
            public class DeleteallRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.ImagesDeleteAllResponse>
            {
                /// <summary>Constructs a new Deleteall request.</summary>
                public DeleteallRequest(Google.Apis.Services.IClientService service, string packageName, string editId, string language, ImageTypeEnum imageType) : base(service)
                {
                    PackageName = packageName;
                    EditId = editId;
                    Language = language;
                    ImageType = imageType;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>
                /// Language localization code (a BCP-47 language tag; for example, "de-AT" for Austrian German).
                /// Providing a language that is not supported by the App is a no-op.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("language", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Language { get; private set; }

                /// <summary>Type of the Image. Providing an image type that refers to no images is a no-op.</summary>
                [Google.Apis.Util.RequestParameterAttribute("imageType", Google.Apis.Util.RequestParameterType.Path)]
                public virtual ImageTypeEnum ImageType { get; private set; }

                /// <summary>Type of the Image. Providing an image type that refers to no images is a no-op.</summary>
                public enum ImageTypeEnum
                {
                    /// <summary>Unspecified type. Do not use.</summary>
                    [Google.Apis.Util.StringValueAttribute("appImageTypeUnspecified")]
                    AppImageTypeUnspecified = 0,

                    /// <summary>Phone screenshot.</summary>
                    [Google.Apis.Util.StringValueAttribute("phoneScreenshots")]
                    PhoneScreenshots = 1,

                    /// <summary>Seven inch screenshot.</summary>
                    [Google.Apis.Util.StringValueAttribute("sevenInchScreenshots")]
                    SevenInchScreenshots = 2,

                    /// <summary>Ten inch screenshot.</summary>
                    [Google.Apis.Util.StringValueAttribute("tenInchScreenshots")]
                    TenInchScreenshots = 3,

                    /// <summary>TV screenshot.</summary>
                    [Google.Apis.Util.StringValueAttribute("tvScreenshots")]
                    TvScreenshots = 4,

                    /// <summary>Wear screenshot.</summary>
                    [Google.Apis.Util.StringValueAttribute("wearScreenshots")]
                    WearScreenshots = 5,

                    /// <summary>Icon.</summary>
                    [Google.Apis.Util.StringValueAttribute("icon")]
                    Icon = 6,

                    /// <summary>Feature graphic.</summary>
                    [Google.Apis.Util.StringValueAttribute("featureGraphic")]
                    FeatureGraphic = 7,

                    /// <summary>TV banner.</summary>
                    [Google.Apis.Util.StringValueAttribute("tvBanner")]
                    TvBanner = 8,
                }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "deleteall";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}/listings/{language}/{imageType}";

                /// <summary>Initializes Deleteall parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "editId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("language", new Google.Apis.Discovery.Parameter
                    {
                        Name = "language",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("imageType", new Google.Apis.Discovery.Parameter
                    {
                        Name = "imageType",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Lists all images. The response may be empty.</summary>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            /// <param name="language">
            /// Language localization code (a BCP-47 language tag; for example, "de-AT" for Austrian German). There must
            /// be a store listing for the specified language.
            /// </param>
            /// <param name="imageType">
            /// Type of the Image. Providing an image type that refers to no images will return an empty response.
            /// </param>
            public virtual ListRequest List(string packageName, string editId, string language, ListRequest.ImageTypeEnum imageType)
            {
                return new ListRequest(service, packageName, editId, language, imageType);
            }

            /// <summary>Lists all images. The response may be empty.</summary>
            public class ListRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.ImagesListResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string packageName, string editId, string language, ImageTypeEnum imageType) : base(service)
                {
                    PackageName = packageName;
                    EditId = editId;
                    Language = language;
                    ImageType = imageType;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>
                /// Language localization code (a BCP-47 language tag; for example, "de-AT" for Austrian German). There
                /// must be a store listing for the specified language.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("language", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Language { get; private set; }

                /// <summary>
                /// Type of the Image. Providing an image type that refers to no images will return an empty response.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("imageType", Google.Apis.Util.RequestParameterType.Path)]
                public virtual ImageTypeEnum ImageType { get; private set; }

                /// <summary>
                /// Type of the Image. Providing an image type that refers to no images will return an empty response.
                /// </summary>
                public enum ImageTypeEnum
                {
                    /// <summary>Unspecified type. Do not use.</summary>
                    [Google.Apis.Util.StringValueAttribute("appImageTypeUnspecified")]
                    AppImageTypeUnspecified = 0,

                    /// <summary>Phone screenshot.</summary>
                    [Google.Apis.Util.StringValueAttribute("phoneScreenshots")]
                    PhoneScreenshots = 1,

                    /// <summary>Seven inch screenshot.</summary>
                    [Google.Apis.Util.StringValueAttribute("sevenInchScreenshots")]
                    SevenInchScreenshots = 2,

                    /// <summary>Ten inch screenshot.</summary>
                    [Google.Apis.Util.StringValueAttribute("tenInchScreenshots")]
                    TenInchScreenshots = 3,

                    /// <summary>TV screenshot.</summary>
                    [Google.Apis.Util.StringValueAttribute("tvScreenshots")]
                    TvScreenshots = 4,

                    /// <summary>Wear screenshot.</summary>
                    [Google.Apis.Util.StringValueAttribute("wearScreenshots")]
                    WearScreenshots = 5,

                    /// <summary>Icon.</summary>
                    [Google.Apis.Util.StringValueAttribute("icon")]
                    Icon = 6,

                    /// <summary>Feature graphic.</summary>
                    [Google.Apis.Util.StringValueAttribute("featureGraphic")]
                    FeatureGraphic = 7,

                    /// <summary>TV banner.</summary>
                    [Google.Apis.Util.StringValueAttribute("tvBanner")]
                    TvBanner = 8,
                }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}/listings/{language}/{imageType}";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "editId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("language", new Google.Apis.Discovery.Parameter
                    {
                        Name = "language",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("imageType", new Google.Apis.Discovery.Parameter
                    {
                        Name = "imageType",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Uploads an image of the specified language and image type, and adds to the edit.</summary>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            /// <param name="language">
            /// Language localization code (a BCP-47 language tag; for example, "de-AT" for Austrian German). Providing
            /// a language that is not supported by the App is a no-op.
            /// </param>
            /// <param name="imageType">Type of the Image.</param>
            public virtual UploadRequest Upload(string packageName, string editId, string language, UploadRequest.ImageTypeEnum imageType)
            {
                return new UploadRequest(service, packageName, editId, language, imageType);
            }

            /// <summary>Uploads an image of the specified language and image type, and adds to the edit.</summary>
            public class UploadRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.ImagesUploadResponse>
            {
                /// <summary>Constructs a new Upload request.</summary>
                public UploadRequest(Google.Apis.Services.IClientService service, string packageName, string editId, string language, ImageTypeEnum imageType) : base(service)
                {
                    PackageName = packageName;
                    EditId = editId;
                    Language = language;
                    ImageType = imageType;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>
                /// Language localization code (a BCP-47 language tag; for example, "de-AT" for Austrian German).
                /// Providing a language that is not supported by the App is a no-op.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("language", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Language { get; private set; }

                /// <summary>Type of the Image.</summary>
                [Google.Apis.Util.RequestParameterAttribute("imageType", Google.Apis.Util.RequestParameterType.Path)]
                public virtual ImageTypeEnum ImageType { get; private set; }

                /// <summary>Type of the Image.</summary>
                public enum ImageTypeEnum
                {
                    /// <summary>Unspecified type. Do not use.</summary>
                    [Google.Apis.Util.StringValueAttribute("appImageTypeUnspecified")]
                    AppImageTypeUnspecified = 0,

                    /// <summary>Phone screenshot.</summary>
                    [Google.Apis.Util.StringValueAttribute("phoneScreenshots")]
                    PhoneScreenshots = 1,

                    /// <summary>Seven inch screenshot.</summary>
                    [Google.Apis.Util.StringValueAttribute("sevenInchScreenshots")]
                    SevenInchScreenshots = 2,

                    /// <summary>Ten inch screenshot.</summary>
                    [Google.Apis.Util.StringValueAttribute("tenInchScreenshots")]
                    TenInchScreenshots = 3,

                    /// <summary>TV screenshot.</summary>
                    [Google.Apis.Util.StringValueAttribute("tvScreenshots")]
                    TvScreenshots = 4,

                    /// <summary>Wear screenshot.</summary>
                    [Google.Apis.Util.StringValueAttribute("wearScreenshots")]
                    WearScreenshots = 5,

                    /// <summary>Icon.</summary>
                    [Google.Apis.Util.StringValueAttribute("icon")]
                    Icon = 6,

                    /// <summary>Feature graphic.</summary>
                    [Google.Apis.Util.StringValueAttribute("featureGraphic")]
                    FeatureGraphic = 7,

                    /// <summary>TV banner.</summary>
                    [Google.Apis.Util.StringValueAttribute("tvBanner")]
                    TvBanner = 8,
                }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "upload";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}/listings/{language}/{imageType}";

                /// <summary>Initializes Upload parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "editId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("language", new Google.Apis.Discovery.Parameter
                    {
                        Name = "language",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("imageType", new Google.Apis.Discovery.Parameter
                    {
                        Name = "imageType",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Uploads an image of the specified language and image type, and adds to the edit.</summary>
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
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            /// <param name="language">
            /// Language localization code (a BCP-47 language tag; for example, "de-AT" for Austrian German). Providing
            /// a language that is not supported by the App is a no-op.
            /// </param>
            /// <param name="imageType">Type of the Image.</param>
            /// <param name="stream">The stream to upload. See remarks for further information.</param>
            /// <param name="contentType">The content type of the stream to upload.</param>
            public virtual UploadMediaUpload Upload(string packageName, string editId, string language, UploadMediaUpload.ImageTypeEnum imageType, System.IO.Stream stream, string contentType)
            {
                return new UploadMediaUpload(service, packageName, editId, language, imageType, stream, contentType);
            }

            /// <summary>Upload media upload which supports resumable upload.</summary>
            public class UploadMediaUpload : Google.Apis.Upload.ResumableUpload<string, Google.Apis.AndroidPublisher.v3.Data.ImagesUploadResponse>
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
                /// Available to use for quota purposes for server-side applications. Can be any arbitrary string
                /// assigned to a user, but should not exceed 40 characters.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string QuotaUser { get; set; }

                /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
                [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string UploadType { get; set; }

                /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
                [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string UploadProtocol { get; set; }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>
                /// Language localization code (a BCP-47 language tag; for example, "de-AT" for Austrian German).
                /// Providing a language that is not supported by the App is a no-op.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("language", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Language { get; private set; }

                /// <summary>Type of the Image.</summary>
                [Google.Apis.Util.RequestParameterAttribute("imageType", Google.Apis.Util.RequestParameterType.Path)]
                public virtual ImageTypeEnum ImageType { get; private set; }

                /// <summary>Type of the Image.</summary>
                public enum ImageTypeEnum
                {
                    /// <summary>Unspecified type. Do not use.</summary>
                    [Google.Apis.Util.StringValueAttribute("appImageTypeUnspecified")]
                    AppImageTypeUnspecified = 0,

                    /// <summary>Phone screenshot.</summary>
                    [Google.Apis.Util.StringValueAttribute("phoneScreenshots")]
                    PhoneScreenshots = 1,

                    /// <summary>Seven inch screenshot.</summary>
                    [Google.Apis.Util.StringValueAttribute("sevenInchScreenshots")]
                    SevenInchScreenshots = 2,

                    /// <summary>Ten inch screenshot.</summary>
                    [Google.Apis.Util.StringValueAttribute("tenInchScreenshots")]
                    TenInchScreenshots = 3,

                    /// <summary>TV screenshot.</summary>
                    [Google.Apis.Util.StringValueAttribute("tvScreenshots")]
                    TvScreenshots = 4,

                    /// <summary>Wear screenshot.</summary>
                    [Google.Apis.Util.StringValueAttribute("wearScreenshots")]
                    WearScreenshots = 5,

                    /// <summary>Icon.</summary>
                    [Google.Apis.Util.StringValueAttribute("icon")]
                    Icon = 6,

                    /// <summary>Feature graphic.</summary>
                    [Google.Apis.Util.StringValueAttribute("featureGraphic")]
                    FeatureGraphic = 7,

                    /// <summary>TV banner.</summary>
                    [Google.Apis.Util.StringValueAttribute("tvBanner")]
                    TvBanner = 8,
                }

                /// <summary>Constructs a new Upload media upload instance.</summary>
                /// <remarks>
                /// Considerations regarding <paramref name="stream"/>:
                /// <list type="bullet">
                /// <item>
                /// <description>
                /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c> before
                /// reading commences. If <paramref name="stream"/> is not seekable, then it will be read from its
                /// current position
                /// </description>
                /// </item>
                /// <item>
                /// <description>
                /// Caller is responsible for maintaining the <paramref name="stream"/> open until the upload is
                /// completed
                /// </description>
                /// </item>
                /// <item>
                /// <description>Caller is responsible for closing the <paramref name="stream"/></description>
                /// </item>
                /// </list>
                /// </remarks>
                public UploadMediaUpload(Google.Apis.Services.IClientService service, string packageName, string editId, string language, UploadMediaUpload.ImageTypeEnum imageType, System.IO.Stream stream, string contentType)
                    : base(service, string.Format("/{0}/{1}{2}", "upload", service.BasePath, "androidpublisher/v3/applications/{packageName}/edits/{editId}/listings/{language}/{imageType}"), "POST", stream, contentType)
                {
                    PackageName = packageName;
                    EditId = editId;
                    Language = language;
                    ImageType = imageType;
                }
            }
        }

        /// <summary>Gets the Listings resource.</summary>
        public virtual ListingsResource Listings { get; }

        /// <summary>The "listings" collection of methods.</summary>
        public class ListingsResource
        {
            private const string Resource = "listings";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ListingsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Deletes a localized store listing.</summary>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            /// <param name="language">
            /// Language localization code (a BCP-47 language tag; for example, "de-AT" for Austrian German).
            /// </param>
            public virtual DeleteRequest Delete(string packageName, string editId, string language)
            {
                return new DeleteRequest(service, packageName, editId, language);
            }

            /// <summary>Deletes a localized store listing.</summary>
            public class DeleteRequest : AndroidPublisherBaseServiceRequest<string>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string packageName, string editId, string language) : base(service)
                {
                    PackageName = packageName;
                    EditId = editId;
                    Language = language;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>
                /// Language localization code (a BCP-47 language tag; for example, "de-AT" for Austrian German).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("language", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Language { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}/listings/{language}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "editId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("language", new Google.Apis.Discovery.Parameter
                    {
                        Name = "language",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Deletes all store listings.</summary>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            public virtual DeleteallRequest Deleteall(string packageName, string editId)
            {
                return new DeleteallRequest(service, packageName, editId);
            }

            /// <summary>Deletes all store listings.</summary>
            public class DeleteallRequest : AndroidPublisherBaseServiceRequest<string>
            {
                /// <summary>Constructs a new Deleteall request.</summary>
                public DeleteallRequest(Google.Apis.Services.IClientService service, string packageName, string editId) : base(service)
                {
                    PackageName = packageName;
                    EditId = editId;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "deleteall";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}/listings";

                /// <summary>Initializes Deleteall parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "editId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Gets a localized store listing.</summary>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            /// <param name="language">
            /// Language localization code (a BCP-47 language tag; for example, "de-AT" for Austrian German).
            /// </param>
            public virtual GetRequest Get(string packageName, string editId, string language)
            {
                return new GetRequest(service, packageName, editId, language);
            }

            /// <summary>Gets a localized store listing.</summary>
            public class GetRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.Listing>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string packageName, string editId, string language) : base(service)
                {
                    PackageName = packageName;
                    EditId = editId;
                    Language = language;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>
                /// Language localization code (a BCP-47 language tag; for example, "de-AT" for Austrian German).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("language", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Language { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}/listings/{language}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "editId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("language", new Google.Apis.Discovery.Parameter
                    {
                        Name = "language",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Lists all localized store listings.</summary>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            public virtual ListRequest List(string packageName, string editId)
            {
                return new ListRequest(service, packageName, editId);
            }

            /// <summary>Lists all localized store listings.</summary>
            public class ListRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.ListingsListResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string packageName, string editId) : base(service)
                {
                    PackageName = packageName;
                    EditId = editId;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}/listings";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "editId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Patches a localized store listing.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            /// <param name="language">
            /// Language localization code (a BCP-47 language tag; for example, "de-AT" for Austrian German).
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.AndroidPublisher.v3.Data.Listing body, string packageName, string editId, string language)
            {
                return new PatchRequest(service, body, packageName, editId, language);
            }

            /// <summary>Patches a localized store listing.</summary>
            public class PatchRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.Listing>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.Listing body, string packageName, string editId, string language) : base(service)
                {
                    PackageName = packageName;
                    EditId = editId;
                    Language = language;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>
                /// Language localization code (a BCP-47 language tag; for example, "de-AT" for Austrian German).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("language", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Language { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AndroidPublisher.v3.Data.Listing Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}/listings/{language}";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "editId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("language", new Google.Apis.Discovery.Parameter
                    {
                        Name = "language",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Creates or updates a localized store listing.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            /// <param name="language">
            /// Language localization code (a BCP-47 language tag; for example, "de-AT" for Austrian German).
            /// </param>
            public virtual UpdateRequest Update(Google.Apis.AndroidPublisher.v3.Data.Listing body, string packageName, string editId, string language)
            {
                return new UpdateRequest(service, body, packageName, editId, language);
            }

            /// <summary>Creates or updates a localized store listing.</summary>
            public class UpdateRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.Listing>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.Listing body, string packageName, string editId, string language) : base(service)
                {
                    PackageName = packageName;
                    EditId = editId;
                    Language = language;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>
                /// Language localization code (a BCP-47 language tag; for example, "de-AT" for Austrian German).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("language", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Language { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AndroidPublisher.v3.Data.Listing Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "update";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}/listings/{language}";

                /// <summary>Initializes Update parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "editId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("language", new Google.Apis.Discovery.Parameter
                    {
                        Name = "language",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the Testers resource.</summary>
        public virtual TestersResource Testers { get; }

        /// <summary>The "testers" collection of methods.</summary>
        public class TestersResource
        {
            private const string Resource = "testers";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public TestersResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Gets testers.</summary>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            /// <param name="track">The track to read from.</param>
            public virtual GetRequest Get(string packageName, string editId, string track)
            {
                return new GetRequest(service, packageName, editId, track);
            }

            /// <summary>Gets testers.</summary>
            public class GetRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.Testers>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string packageName, string editId, string track) : base(service)
                {
                    PackageName = packageName;
                    EditId = editId;
                    Track = track;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>The track to read from.</summary>
                [Google.Apis.Util.RequestParameterAttribute("track", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Track { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}/testers/{track}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "editId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("track", new Google.Apis.Discovery.Parameter
                    {
                        Name = "track",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Patches testers.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            /// <param name="track">The track to update.</param>
            public virtual PatchRequest Patch(Google.Apis.AndroidPublisher.v3.Data.Testers body, string packageName, string editId, string track)
            {
                return new PatchRequest(service, body, packageName, editId, track);
            }

            /// <summary>Patches testers.</summary>
            public class PatchRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.Testers>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.Testers body, string packageName, string editId, string track) : base(service)
                {
                    PackageName = packageName;
                    EditId = editId;
                    Track = track;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>The track to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("track", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Track { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AndroidPublisher.v3.Data.Testers Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}/testers/{track}";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "editId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("track", new Google.Apis.Discovery.Parameter
                    {
                        Name = "track",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Updates testers.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            /// <param name="track">The track to update.</param>
            public virtual UpdateRequest Update(Google.Apis.AndroidPublisher.v3.Data.Testers body, string packageName, string editId, string track)
            {
                return new UpdateRequest(service, body, packageName, editId, track);
            }

            /// <summary>Updates testers.</summary>
            public class UpdateRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.Testers>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.Testers body, string packageName, string editId, string track) : base(service)
                {
                    PackageName = packageName;
                    EditId = editId;
                    Track = track;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>The track to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("track", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Track { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AndroidPublisher.v3.Data.Testers Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "update";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}/testers/{track}";

                /// <summary>Initializes Update parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "editId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("track", new Google.Apis.Discovery.Parameter
                    {
                        Name = "track",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the Tracks resource.</summary>
        public virtual TracksResource Tracks { get; }

        /// <summary>The "tracks" collection of methods.</summary>
        public class TracksResource
        {
            private const string Resource = "tracks";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public TracksResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Gets a track.</summary>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            /// <param name="track">Identifier of the track.</param>
            public virtual GetRequest Get(string packageName, string editId, string track)
            {
                return new GetRequest(service, packageName, editId, track);
            }

            /// <summary>Gets a track.</summary>
            public class GetRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.Track>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string packageName, string editId, string track) : base(service)
                {
                    PackageName = packageName;
                    EditId = editId;
                    Track = track;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>Identifier of the track.</summary>
                [Google.Apis.Util.RequestParameterAttribute("track", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Track { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}/tracks/{track}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "editId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("track", new Google.Apis.Discovery.Parameter
                    {
                        Name = "track",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Lists all tracks.</summary>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            public virtual ListRequest List(string packageName, string editId)
            {
                return new ListRequest(service, packageName, editId);
            }

            /// <summary>Lists all tracks.</summary>
            public class ListRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.TracksListResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string packageName, string editId) : base(service)
                {
                    PackageName = packageName;
                    EditId = editId;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}/tracks";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "editId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Patches a track.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            /// <param name="track">Identifier of the track.</param>
            public virtual PatchRequest Patch(Google.Apis.AndroidPublisher.v3.Data.Track body, string packageName, string editId, string track)
            {
                return new PatchRequest(service, body, packageName, editId, track);
            }

            /// <summary>Patches a track.</summary>
            public class PatchRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.Track>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.Track body, string packageName, string editId, string track) : base(service)
                {
                    PackageName = packageName;
                    EditId = editId;
                    Track = track;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>Identifier of the track.</summary>
                [Google.Apis.Util.RequestParameterAttribute("track", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Track { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AndroidPublisher.v3.Data.Track Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}/tracks/{track}";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "editId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("track", new Google.Apis.Discovery.Parameter
                    {
                        Name = "track",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Updates a track.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            /// <param name="track">Identifier of the track.</param>
            public virtual UpdateRequest Update(Google.Apis.AndroidPublisher.v3.Data.Track body, string packageName, string editId, string track)
            {
                return new UpdateRequest(service, body, packageName, editId, track);
            }

            /// <summary>Updates a track.</summary>
            public class UpdateRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.Track>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.Track body, string packageName, string editId, string track) : base(service)
                {
                    PackageName = packageName;
                    EditId = editId;
                    Track = track;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>Identifier of the track.</summary>
                [Google.Apis.Util.RequestParameterAttribute("track", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Track { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AndroidPublisher.v3.Data.Track Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "update";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}/tracks/{track}";

                /// <summary>Initializes Update parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "editId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("track", new Google.Apis.Discovery.Parameter
                    {
                        Name = "track",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Commits an app edit.</summary>
        /// <param name="packageName">Package name of the app.</param>
        /// <param name="editId">Identifier of the edit.</param>
        public virtual CommitRequest Commit(string packageName, string editId)
        {
            return new CommitRequest(service, packageName, editId);
        }

        /// <summary>Commits an app edit.</summary>
        public class CommitRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.AppEdit>
        {
            /// <summary>Constructs a new Commit request.</summary>
            public CommitRequest(Google.Apis.Services.IClientService service, string packageName, string editId) : base(service)
            {
                PackageName = packageName;
                EditId = editId;
                InitParameters();
            }

            /// <summary>Package name of the app.</summary>
            [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PackageName { get; private set; }

            /// <summary>Identifier of the edit.</summary>
            [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EditId { get; private set; }

            /// <summary>
            /// Indicates that the changes in this edit will not be reviewed until they are explicitly sent for review
            /// from the Google Play Console UI. These changes will be added to any other changes that are not yet sent
            /// for review.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("changesNotSentForReview", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> ChangesNotSentForReview { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "commit";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}:commit";

            /// <summary>Initializes Commit parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                {
                    Name = "packageName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                {
                    Name = "editId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("changesNotSentForReview", new Google.Apis.Discovery.Parameter
                {
                    Name = "changesNotSentForReview",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Deletes an app edit.</summary>
        /// <param name="packageName">Package name of the app.</param>
        /// <param name="editId">Identifier of the edit.</param>
        public virtual DeleteRequest Delete(string packageName, string editId)
        {
            return new DeleteRequest(service, packageName, editId);
        }

        /// <summary>Deletes an app edit.</summary>
        public class DeleteRequest : AndroidPublisherBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string packageName, string editId) : base(service)
            {
                PackageName = packageName;
                EditId = editId;
                InitParameters();
            }

            /// <summary>Package name of the app.</summary>
            [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PackageName { get; private set; }

            /// <summary>Identifier of the edit.</summary>
            [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EditId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                {
                    Name = "packageName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                {
                    Name = "editId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Gets an app edit.</summary>
        /// <param name="packageName">Package name of the app.</param>
        /// <param name="editId">Identifier of the edit.</param>
        public virtual GetRequest Get(string packageName, string editId)
        {
            return new GetRequest(service, packageName, editId);
        }

        /// <summary>Gets an app edit.</summary>
        public class GetRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.AppEdit>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string packageName, string editId) : base(service)
            {
                PackageName = packageName;
                EditId = editId;
                InitParameters();
            }

            /// <summary>Package name of the app.</summary>
            [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PackageName { get; private set; }

            /// <summary>Identifier of the edit.</summary>
            [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EditId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                {
                    Name = "packageName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                {
                    Name = "editId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Creates a new edit for an app.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="packageName">Package name of the app.</param>
        public virtual InsertRequest Insert(Google.Apis.AndroidPublisher.v3.Data.AppEdit body, string packageName)
        {
            return new InsertRequest(service, body, packageName);
        }

        /// <summary>Creates a new edit for an app.</summary>
        public class InsertRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.AppEdit>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.AppEdit body, string packageName) : base(service)
            {
                PackageName = packageName;
                Body = body;
                InitParameters();
            }

            /// <summary>Package name of the app.</summary>
            [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PackageName { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AndroidPublisher.v3.Data.AppEdit Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                {
                    Name = "packageName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Validates an app edit.</summary>
        /// <param name="packageName">Package name of the app.</param>
        /// <param name="editId">Identifier of the edit.</param>
        public virtual ValidateRequest Validate(string packageName, string editId)
        {
            return new ValidateRequest(service, packageName, editId);
        }

        /// <summary>Validates an app edit.</summary>
        public class ValidateRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.AppEdit>
        {
            /// <summary>Constructs a new Validate request.</summary>
            public ValidateRequest(Google.Apis.Services.IClientService service, string packageName, string editId) : base(service)
            {
                PackageName = packageName;
                EditId = editId;
                InitParameters();
            }

            /// <summary>Package name of the app.</summary>
            [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PackageName { get; private set; }

            /// <summary>Identifier of the edit.</summary>
            [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EditId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "validate";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}:validate";

            /// <summary>Initializes Validate parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                {
                    Name = "packageName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                {
                    Name = "editId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "inappproducts" collection of methods.</summary>
    public class InappproductsResource
    {
        private const string Resource = "inappproducts";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public InappproductsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Deletes an in-app product (i.e. a managed product or a subscriptions).</summary>
        /// <param name="packageName">Package name of the app.</param>
        /// <param name="sku">Unique identifier for the in-app product.</param>
        public virtual DeleteRequest Delete(string packageName, string sku)
        {
            return new DeleteRequest(service, packageName, sku);
        }

        /// <summary>Deletes an in-app product (i.e. a managed product or a subscriptions).</summary>
        public class DeleteRequest : AndroidPublisherBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string packageName, string sku) : base(service)
            {
                PackageName = packageName;
                Sku = sku;
                InitParameters();
            }

            /// <summary>Package name of the app.</summary>
            [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PackageName { get; private set; }

            /// <summary>Unique identifier for the in-app product.</summary>
            [Google.Apis.Util.RequestParameterAttribute("sku", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Sku { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidpublisher/v3/applications/{packageName}/inappproducts/{sku}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                {
                    Name = "packageName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("sku", new Google.Apis.Discovery.Parameter
                {
                    Name = "sku",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Gets an in-app product, which can be a managed product or a subscription.</summary>
        /// <param name="packageName">Package name of the app.</param>
        /// <param name="sku">Unique identifier for the in-app product.</param>
        public virtual GetRequest Get(string packageName, string sku)
        {
            return new GetRequest(service, packageName, sku);
        }

        /// <summary>Gets an in-app product, which can be a managed product or a subscription.</summary>
        public class GetRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.InAppProduct>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string packageName, string sku) : base(service)
            {
                PackageName = packageName;
                Sku = sku;
                InitParameters();
            }

            /// <summary>Package name of the app.</summary>
            [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PackageName { get; private set; }

            /// <summary>Unique identifier for the in-app product.</summary>
            [Google.Apis.Util.RequestParameterAttribute("sku", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Sku { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidpublisher/v3/applications/{packageName}/inappproducts/{sku}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                {
                    Name = "packageName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("sku", new Google.Apis.Discovery.Parameter
                {
                    Name = "sku",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Creates an in-app product (i.e. a managed product or a subscriptions).</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="packageName">Package name of the app.</param>
        public virtual InsertRequest Insert(Google.Apis.AndroidPublisher.v3.Data.InAppProduct body, string packageName)
        {
            return new InsertRequest(service, body, packageName);
        }

        /// <summary>Creates an in-app product (i.e. a managed product or a subscriptions).</summary>
        public class InsertRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.InAppProduct>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.InAppProduct body, string packageName) : base(service)
            {
                PackageName = packageName;
                Body = body;
                InitParameters();
            }

            /// <summary>Package name of the app.</summary>
            [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PackageName { get; private set; }

            /// <summary>
            /// If true the prices for all regions targeted by the parent app that don't have a price specified for this
            /// in-app product will be auto converted to the target currency based on the default price. Defaults to
            /// false.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("autoConvertMissingPrices", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> AutoConvertMissingPrices { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AndroidPublisher.v3.Data.InAppProduct Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidpublisher/v3/applications/{packageName}/inappproducts";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                {
                    Name = "packageName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("autoConvertMissingPrices", new Google.Apis.Discovery.Parameter
                {
                    Name = "autoConvertMissingPrices",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Lists all in-app products - both managed products and subscriptions.</summary>
        /// <param name="packageName">Package name of the app.</param>
        public virtual ListRequest List(string packageName)
        {
            return new ListRequest(service, packageName);
        }

        /// <summary>Lists all in-app products - both managed products and subscriptions.</summary>
        public class ListRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.InappproductsListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string packageName) : base(service)
            {
                PackageName = packageName;
                InitParameters();
            }

            /// <summary>Package name of the app.</summary>
            [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PackageName { get; private set; }

            /// <summary>How many results the list operation should return.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>The index of the first element to return.</summary>
            [Google.Apis.Util.RequestParameterAttribute("startIndex", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> StartIndex { get; set; }

            /// <summary>Pagination token. If empty, list starts at the first product.</summary>
            [Google.Apis.Util.RequestParameterAttribute("token", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Token { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidpublisher/v3/applications/{packageName}/inappproducts";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                {
                    Name = "packageName",
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
                RequestParameters.Add("startIndex", new Google.Apis.Discovery.Parameter
                {
                    Name = "startIndex",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("token", new Google.Apis.Discovery.Parameter
                {
                    Name = "token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Patches an in-app product (i.e. a managed product or a subscriptions).</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="packageName">Package name of the app.</param>
        /// <param name="sku">Unique identifier for the in-app product.</param>
        public virtual PatchRequest Patch(Google.Apis.AndroidPublisher.v3.Data.InAppProduct body, string packageName, string sku)
        {
            return new PatchRequest(service, body, packageName, sku);
        }

        /// <summary>Patches an in-app product (i.e. a managed product or a subscriptions).</summary>
        public class PatchRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.InAppProduct>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.InAppProduct body, string packageName, string sku) : base(service)
            {
                PackageName = packageName;
                Sku = sku;
                Body = body;
                InitParameters();
            }

            /// <summary>Package name of the app.</summary>
            [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PackageName { get; private set; }

            /// <summary>Unique identifier for the in-app product.</summary>
            [Google.Apis.Util.RequestParameterAttribute("sku", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Sku { get; private set; }

            /// <summary>
            /// If true the prices for all regions targeted by the parent app that don't have a price specified for this
            /// in-app product will be auto converted to the target currency based on the default price. Defaults to
            /// false.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("autoConvertMissingPrices", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> AutoConvertMissingPrices { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AndroidPublisher.v3.Data.InAppProduct Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidpublisher/v3/applications/{packageName}/inappproducts/{sku}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                {
                    Name = "packageName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("sku", new Google.Apis.Discovery.Parameter
                {
                    Name = "sku",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("autoConvertMissingPrices", new Google.Apis.Discovery.Parameter
                {
                    Name = "autoConvertMissingPrices",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates an in-app product (i.e. a managed product or a subscriptions).</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="packageName">Package name of the app.</param>
        /// <param name="sku">Unique identifier for the in-app product.</param>
        public virtual UpdateRequest Update(Google.Apis.AndroidPublisher.v3.Data.InAppProduct body, string packageName, string sku)
        {
            return new UpdateRequest(service, body, packageName, sku);
        }

        /// <summary>Updates an in-app product (i.e. a managed product or a subscriptions).</summary>
        public class UpdateRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.InAppProduct>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.InAppProduct body, string packageName, string sku) : base(service)
            {
                PackageName = packageName;
                Sku = sku;
                Body = body;
                InitParameters();
            }

            /// <summary>Package name of the app.</summary>
            [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PackageName { get; private set; }

            /// <summary>Unique identifier for the in-app product.</summary>
            [Google.Apis.Util.RequestParameterAttribute("sku", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Sku { get; private set; }

            /// <summary>
            /// If true the prices for all regions targeted by the parent app that don't have a price specified for this
            /// in-app product will be auto converted to the target currency based on the default price. Defaults to
            /// false.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("autoConvertMissingPrices", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> AutoConvertMissingPrices { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AndroidPublisher.v3.Data.InAppProduct Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidpublisher/v3/applications/{packageName}/inappproducts/{sku}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                {
                    Name = "packageName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("sku", new Google.Apis.Discovery.Parameter
                {
                    Name = "sku",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("autoConvertMissingPrices", new Google.Apis.Discovery.Parameter
                {
                    Name = "autoConvertMissingPrices",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "internalappsharingartifacts" collection of methods.</summary>
    public class InternalappsharingartifactsResource
    {
        private const string Resource = "internalappsharingartifacts";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public InternalappsharingartifactsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Uploads an APK to internal app sharing. If you are using the Google API client libraries, please increase
        /// the timeout of the http request before calling this endpoint (a timeout of 2 minutes is recommended). See
        /// [Timeouts and Errors](https://developers.google.com/api-client-library/java/google-api-java-client/errors)
        /// for an example in java.
        /// </summary>
        /// <param name="packageName">Package name of the app.</param>
        public virtual UploadapkRequest Uploadapk(string packageName)
        {
            return new UploadapkRequest(service, packageName);
        }

        /// <summary>
        /// Uploads an APK to internal app sharing. If you are using the Google API client libraries, please increase
        /// the timeout of the http request before calling this endpoint (a timeout of 2 minutes is recommended). See
        /// [Timeouts and Errors](https://developers.google.com/api-client-library/java/google-api-java-client/errors)
        /// for an example in java.
        /// </summary>
        public class UploadapkRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.InternalAppSharingArtifact>
        {
            /// <summary>Constructs a new Uploadapk request.</summary>
            public UploadapkRequest(Google.Apis.Services.IClientService service, string packageName) : base(service)
            {
                PackageName = packageName;
                InitParameters();
            }

            /// <summary>Package name of the app.</summary>
            [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PackageName { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "uploadapk";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidpublisher/v3/applications/internalappsharing/{packageName}/artifacts/apk";

            /// <summary>Initializes Uploadapk parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                {
                    Name = "packageName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Uploads an APK to internal app sharing. If you are using the Google API client libraries, please increase
        /// the timeout of the http request before calling this endpoint (a timeout of 2 minutes is recommended). See
        /// [Timeouts and Errors](https://developers.google.com/api-client-library/java/google-api-java-client/errors)
        /// for an example in java.
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
        /// <param name="packageName">Package name of the app.</param>
        /// <param name="stream">The stream to upload. See remarks for further information.</param>
        /// <param name="contentType">The content type of the stream to upload.</param>
        public virtual UploadapkMediaUpload Uploadapk(string packageName, System.IO.Stream stream, string contentType)
        {
            return new UploadapkMediaUpload(service, packageName, stream, contentType);
        }

        /// <summary>Uploadapk media upload which supports resumable upload.</summary>
        public class UploadapkMediaUpload : Google.Apis.Upload.ResumableUpload<string, Google.Apis.AndroidPublisher.v3.Data.InternalAppSharingArtifact>
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

            /// <summary>Package name of the app.</summary>
            [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PackageName { get; private set; }

            /// <summary>Constructs a new Uploadapk media upload instance.</summary>
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
            public UploadapkMediaUpload(Google.Apis.Services.IClientService service, string packageName, System.IO.Stream stream, string contentType)
                : base(service, string.Format("/{0}/{1}{2}", "upload", service.BasePath, "androidpublisher/v3/applications/internalappsharing/{packageName}/artifacts/apk"), "POST", stream, contentType)
            {
                PackageName = packageName;
            }
        }

        /// <summary>
        /// Uploads an app bundle to internal app sharing. If you are using the Google API client libraries, please
        /// increase the timeout of the http request before calling this endpoint (a timeout of 2 minutes is
        /// recommended). See [Timeouts and
        /// Errors](https://developers.google.com/api-client-library/java/google-api-java-client/errors) for an example
        /// in java.
        /// </summary>
        /// <param name="packageName">Package name of the app.</param>
        public virtual UploadbundleRequest Uploadbundle(string packageName)
        {
            return new UploadbundleRequest(service, packageName);
        }

        /// <summary>
        /// Uploads an app bundle to internal app sharing. If you are using the Google API client libraries, please
        /// increase the timeout of the http request before calling this endpoint (a timeout of 2 minutes is
        /// recommended). See [Timeouts and
        /// Errors](https://developers.google.com/api-client-library/java/google-api-java-client/errors) for an example
        /// in java.
        /// </summary>
        public class UploadbundleRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.InternalAppSharingArtifact>
        {
            /// <summary>Constructs a new Uploadbundle request.</summary>
            public UploadbundleRequest(Google.Apis.Services.IClientService service, string packageName) : base(service)
            {
                PackageName = packageName;
                InitParameters();
            }

            /// <summary>Package name of the app.</summary>
            [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PackageName { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "uploadbundle";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidpublisher/v3/applications/internalappsharing/{packageName}/artifacts/bundle";

            /// <summary>Initializes Uploadbundle parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                {
                    Name = "packageName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Uploads an app bundle to internal app sharing. If you are using the Google API client libraries, please
        /// increase the timeout of the http request before calling this endpoint (a timeout of 2 minutes is
        /// recommended). See [Timeouts and
        /// Errors](https://developers.google.com/api-client-library/java/google-api-java-client/errors) for an example
        /// in java.
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
        /// <param name="packageName">Package name of the app.</param>
        /// <param name="stream">The stream to upload. See remarks for further information.</param>
        /// <param name="contentType">The content type of the stream to upload.</param>
        public virtual UploadbundleMediaUpload Uploadbundle(string packageName, System.IO.Stream stream, string contentType)
        {
            return new UploadbundleMediaUpload(service, packageName, stream, contentType);
        }

        /// <summary>Uploadbundle media upload which supports resumable upload.</summary>
        public class UploadbundleMediaUpload : Google.Apis.Upload.ResumableUpload<string, Google.Apis.AndroidPublisher.v3.Data.InternalAppSharingArtifact>
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

            /// <summary>Package name of the app.</summary>
            [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PackageName { get; private set; }

            /// <summary>Constructs a new Uploadbundle media upload instance.</summary>
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
            public UploadbundleMediaUpload(Google.Apis.Services.IClientService service, string packageName, System.IO.Stream stream, string contentType)
                : base(service, string.Format("/{0}/{1}{2}", "upload", service.BasePath, "androidpublisher/v3/applications/internalappsharing/{packageName}/artifacts/bundle"), "POST", stream, contentType)
            {
                PackageName = packageName;
            }
        }
    }

    /// <summary>The "orders" collection of methods.</summary>
    public class OrdersResource
    {
        private const string Resource = "orders";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public OrdersResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Refund a user's subscription or in-app purchase order.</summary>
        /// <param name="packageName">
        /// The package name of the application for which this subscription or in-app item was purchased (for example,
        /// 'com.some.thing').
        /// </param>
        /// <param name="orderId">
        /// The order ID provided to the user when the subscription or in-app order was purchased.
        /// </param>
        public virtual RefundRequest Refund(string packageName, string orderId)
        {
            return new RefundRequest(service, packageName, orderId);
        }

        /// <summary>Refund a user's subscription or in-app purchase order.</summary>
        public class RefundRequest : AndroidPublisherBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Refund request.</summary>
            public RefundRequest(Google.Apis.Services.IClientService service, string packageName, string orderId) : base(service)
            {
                PackageName = packageName;
                OrderId = orderId;
                InitParameters();
            }

            /// <summary>
            /// The package name of the application for which this subscription or in-app item was purchased (for
            /// example, 'com.some.thing').
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PackageName { get; private set; }

            /// <summary>
            /// The order ID provided to the user when the subscription or in-app order was purchased.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("orderId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string OrderId { get; private set; }

            /// <summary>
            /// Whether to revoke the purchased item. If set to true, access to the subscription or in-app item will be
            /// terminated immediately. If the item is a recurring subscription, all future payments will also be
            /// terminated. Consumed in-app items need to be handled by developer's app. (optional).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("revoke", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Revoke { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "refund";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidpublisher/v3/applications/{packageName}/orders/{orderId}:refund";

            /// <summary>Initializes Refund parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                {
                    Name = "packageName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("orderId", new Google.Apis.Discovery.Parameter
                {
                    Name = "orderId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("revoke", new Google.Apis.Discovery.Parameter
                {
                    Name = "revoke",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "purchases" collection of methods.</summary>
    public class PurchasesResource
    {
        private const string Resource = "purchases";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public PurchasesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Products = new ProductsResource(service);
            Subscriptions = new SubscriptionsResource(service);
            Voidedpurchases = new VoidedpurchasesResource(service);
        }

        /// <summary>Gets the Products resource.</summary>
        public virtual ProductsResource Products { get; }

        /// <summary>The "products" collection of methods.</summary>
        public class ProductsResource
        {
            private const string Resource = "products";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ProductsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Acknowledges a purchase of an inapp item.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="packageName">
            /// The package name of the application the inapp product was sold in (for example, 'com.some.thing').
            /// </param>
            /// <param name="productId">The inapp product SKU (for example, 'com.some.thing.inapp1').</param>
            /// <param name="token">
            /// The token provided to the user's device when the inapp product was purchased.
            /// </param>
            public virtual AcknowledgeRequest Acknowledge(Google.Apis.AndroidPublisher.v3.Data.ProductPurchasesAcknowledgeRequest body, string packageName, string productId, string token)
            {
                return new AcknowledgeRequest(service, body, packageName, productId, token);
            }

            /// <summary>Acknowledges a purchase of an inapp item.</summary>
            public class AcknowledgeRequest : AndroidPublisherBaseServiceRequest<string>
            {
                /// <summary>Constructs a new Acknowledge request.</summary>
                public AcknowledgeRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.ProductPurchasesAcknowledgeRequest body, string packageName, string productId, string token) : base(service)
                {
                    PackageName = packageName;
                    ProductId = productId;
                    Token = token;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The package name of the application the inapp product was sold in (for example, 'com.some.thing').
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>The inapp product SKU (for example, 'com.some.thing.inapp1').</summary>
                [Google.Apis.Util.RequestParameterAttribute("productId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProductId { get; private set; }

                /// <summary>The token provided to the user's device when the inapp product was purchased.</summary>
                [Google.Apis.Util.RequestParameterAttribute("token", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Token { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AndroidPublisher.v3.Data.ProductPurchasesAcknowledgeRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "acknowledge";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/purchases/products/{productId}/tokens/{token}:acknowledge";

                /// <summary>Initializes Acknowledge parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("productId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "productId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("token", new Google.Apis.Discovery.Parameter
                    {
                        Name = "token",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Checks the purchase and consumption status of an inapp item.</summary>
            /// <param name="packageName">
            /// The package name of the application the inapp product was sold in (for example, 'com.some.thing').
            /// </param>
            /// <param name="productId">The inapp product SKU (for example, 'com.some.thing.inapp1').</param>
            /// <param name="token">
            /// The token provided to the user's device when the inapp product was purchased.
            /// </param>
            public virtual GetRequest Get(string packageName, string productId, string token)
            {
                return new GetRequest(service, packageName, productId, token);
            }

            /// <summary>Checks the purchase and consumption status of an inapp item.</summary>
            public class GetRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.ProductPurchase>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string packageName, string productId, string token) : base(service)
                {
                    PackageName = packageName;
                    ProductId = productId;
                    Token = token;
                    InitParameters();
                }

                /// <summary>
                /// The package name of the application the inapp product was sold in (for example, 'com.some.thing').
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>The inapp product SKU (for example, 'com.some.thing.inapp1').</summary>
                [Google.Apis.Util.RequestParameterAttribute("productId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProductId { get; private set; }

                /// <summary>The token provided to the user's device when the inapp product was purchased.</summary>
                [Google.Apis.Util.RequestParameterAttribute("token", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Token { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/purchases/products/{productId}/tokens/{token}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("productId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "productId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("token", new Google.Apis.Discovery.Parameter
                    {
                        Name = "token",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the Subscriptions resource.</summary>
        public virtual SubscriptionsResource Subscriptions { get; }

        /// <summary>The "subscriptions" collection of methods.</summary>
        public class SubscriptionsResource
        {
            private const string Resource = "subscriptions";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public SubscriptionsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Acknowledges a subscription purchase.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="packageName">
            /// The package name of the application for which this subscription was purchased (for example,
            /// 'com.some.thing').
            /// </param>
            /// <param name="subscriptionId">The purchased subscription ID (for example, 'monthly001').</param>
            /// <param name="token">The token provided to the user's device when the subscription was purchased.</param>
            public virtual AcknowledgeRequest Acknowledge(Google.Apis.AndroidPublisher.v3.Data.SubscriptionPurchasesAcknowledgeRequest body, string packageName, string subscriptionId, string token)
            {
                return new AcknowledgeRequest(service, body, packageName, subscriptionId, token);
            }

            /// <summary>Acknowledges a subscription purchase.</summary>
            public class AcknowledgeRequest : AndroidPublisherBaseServiceRequest<string>
            {
                /// <summary>Constructs a new Acknowledge request.</summary>
                public AcknowledgeRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.SubscriptionPurchasesAcknowledgeRequest body, string packageName, string subscriptionId, string token) : base(service)
                {
                    PackageName = packageName;
                    SubscriptionId = subscriptionId;
                    Token = token;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The package name of the application for which this subscription was purchased (for example,
                /// 'com.some.thing').
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>The purchased subscription ID (for example, 'monthly001').</summary>
                [Google.Apis.Util.RequestParameterAttribute("subscriptionId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string SubscriptionId { get; private set; }

                /// <summary>The token provided to the user's device when the subscription was purchased.</summary>
                [Google.Apis.Util.RequestParameterAttribute("token", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Token { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AndroidPublisher.v3.Data.SubscriptionPurchasesAcknowledgeRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "acknowledge";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/purchases/subscriptions/{subscriptionId}/tokens/{token}:acknowledge";

                /// <summary>Initializes Acknowledge parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("subscriptionId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "subscriptionId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("token", new Google.Apis.Discovery.Parameter
                    {
                        Name = "token",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Cancels a user's subscription purchase. The subscription remains valid until its expiration time.
            /// </summary>
            /// <param name="packageName">
            /// The package name of the application for which this subscription was purchased (for example,
            /// 'com.some.thing').
            /// </param>
            /// <param name="subscriptionId">The purchased subscription ID (for example, 'monthly001').</param>
            /// <param name="token">The token provided to the user's device when the subscription was purchased.</param>
            public virtual CancelRequest Cancel(string packageName, string subscriptionId, string token)
            {
                return new CancelRequest(service, packageName, subscriptionId, token);
            }

            /// <summary>
            /// Cancels a user's subscription purchase. The subscription remains valid until its expiration time.
            /// </summary>
            public class CancelRequest : AndroidPublisherBaseServiceRequest<string>
            {
                /// <summary>Constructs a new Cancel request.</summary>
                public CancelRequest(Google.Apis.Services.IClientService service, string packageName, string subscriptionId, string token) : base(service)
                {
                    PackageName = packageName;
                    SubscriptionId = subscriptionId;
                    Token = token;
                    InitParameters();
                }

                /// <summary>
                /// The package name of the application for which this subscription was purchased (for example,
                /// 'com.some.thing').
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>The purchased subscription ID (for example, 'monthly001').</summary>
                [Google.Apis.Util.RequestParameterAttribute("subscriptionId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string SubscriptionId { get; private set; }

                /// <summary>The token provided to the user's device when the subscription was purchased.</summary>
                [Google.Apis.Util.RequestParameterAttribute("token", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Token { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "cancel";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/purchases/subscriptions/{subscriptionId}/tokens/{token}:cancel";

                /// <summary>Initializes Cancel parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("subscriptionId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "subscriptionId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("token", new Google.Apis.Discovery.Parameter
                    {
                        Name = "token",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Defers a user's subscription purchase until a specified future expiration time.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="packageName">
            /// The package name of the application for which this subscription was purchased (for example,
            /// 'com.some.thing').
            /// </param>
            /// <param name="subscriptionId">The purchased subscription ID (for example, 'monthly001').</param>
            /// <param name="token">The token provided to the user's device when the subscription was purchased.</param>
            public virtual DeferRequest Defer(Google.Apis.AndroidPublisher.v3.Data.SubscriptionPurchasesDeferRequest body, string packageName, string subscriptionId, string token)
            {
                return new DeferRequest(service, body, packageName, subscriptionId, token);
            }

            /// <summary>Defers a user's subscription purchase until a specified future expiration time.</summary>
            public class DeferRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.SubscriptionPurchasesDeferResponse>
            {
                /// <summary>Constructs a new Defer request.</summary>
                public DeferRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.SubscriptionPurchasesDeferRequest body, string packageName, string subscriptionId, string token) : base(service)
                {
                    PackageName = packageName;
                    SubscriptionId = subscriptionId;
                    Token = token;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The package name of the application for which this subscription was purchased (for example,
                /// 'com.some.thing').
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>The purchased subscription ID (for example, 'monthly001').</summary>
                [Google.Apis.Util.RequestParameterAttribute("subscriptionId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string SubscriptionId { get; private set; }

                /// <summary>The token provided to the user's device when the subscription was purchased.</summary>
                [Google.Apis.Util.RequestParameterAttribute("token", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Token { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AndroidPublisher.v3.Data.SubscriptionPurchasesDeferRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "defer";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/purchases/subscriptions/{subscriptionId}/tokens/{token}:defer";

                /// <summary>Initializes Defer parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("subscriptionId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "subscriptionId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("token", new Google.Apis.Discovery.Parameter
                    {
                        Name = "token",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Checks whether a user's subscription purchase is valid and returns its expiry time.</summary>
            /// <param name="packageName">
            /// The package name of the application for which this subscription was purchased (for example,
            /// 'com.some.thing').
            /// </param>
            /// <param name="subscriptionId">The purchased subscription ID (for example, 'monthly001').</param>
            /// <param name="token">The token provided to the user's device when the subscription was purchased.</param>
            public virtual GetRequest Get(string packageName, string subscriptionId, string token)
            {
                return new GetRequest(service, packageName, subscriptionId, token);
            }

            /// <summary>Checks whether a user's subscription purchase is valid and returns its expiry time.</summary>
            public class GetRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.SubscriptionPurchase>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string packageName, string subscriptionId, string token) : base(service)
                {
                    PackageName = packageName;
                    SubscriptionId = subscriptionId;
                    Token = token;
                    InitParameters();
                }

                /// <summary>
                /// The package name of the application for which this subscription was purchased (for example,
                /// 'com.some.thing').
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>The purchased subscription ID (for example, 'monthly001').</summary>
                [Google.Apis.Util.RequestParameterAttribute("subscriptionId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string SubscriptionId { get; private set; }

                /// <summary>The token provided to the user's device when the subscription was purchased.</summary>
                [Google.Apis.Util.RequestParameterAttribute("token", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Token { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/purchases/subscriptions/{subscriptionId}/tokens/{token}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("subscriptionId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "subscriptionId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("token", new Google.Apis.Discovery.Parameter
                    {
                        Name = "token",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Refunds a user's subscription purchase, but the subscription remains valid until its expiration time and
            /// it will continue to recur.
            /// </summary>
            /// <param name="packageName">
            /// The package name of the application for which this subscription was purchased (for example,
            /// 'com.some.thing').
            /// </param>
            /// <param name="subscriptionId">"The purchased subscription ID (for example, 'monthly001').</param>
            /// <param name="token">The token provided to the user's device when the subscription was purchased.</param>
            public virtual RefundRequest Refund(string packageName, string subscriptionId, string token)
            {
                return new RefundRequest(service, packageName, subscriptionId, token);
            }

            /// <summary>
            /// Refunds a user's subscription purchase, but the subscription remains valid until its expiration time and
            /// it will continue to recur.
            /// </summary>
            public class RefundRequest : AndroidPublisherBaseServiceRequest<string>
            {
                /// <summary>Constructs a new Refund request.</summary>
                public RefundRequest(Google.Apis.Services.IClientService service, string packageName, string subscriptionId, string token) : base(service)
                {
                    PackageName = packageName;
                    SubscriptionId = subscriptionId;
                    Token = token;
                    InitParameters();
                }

                /// <summary>
                /// The package name of the application for which this subscription was purchased (for example,
                /// 'com.some.thing').
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>"The purchased subscription ID (for example, 'monthly001').</summary>
                [Google.Apis.Util.RequestParameterAttribute("subscriptionId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string SubscriptionId { get; private set; }

                /// <summary>The token provided to the user's device when the subscription was purchased.</summary>
                [Google.Apis.Util.RequestParameterAttribute("token", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Token { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "refund";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/purchases/subscriptions/{subscriptionId}/tokens/{token}:refund";

                /// <summary>Initializes Refund parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("subscriptionId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "subscriptionId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("token", new Google.Apis.Discovery.Parameter
                    {
                        Name = "token",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Refunds and immediately revokes a user's subscription purchase. Access to the subscription will be
            /// terminated immediately and it will stop recurring.
            /// </summary>
            /// <param name="packageName">
            /// The package name of the application for which this subscription was purchased (for example,
            /// 'com.some.thing').
            /// </param>
            /// <param name="subscriptionId">The purchased subscription ID (for example, 'monthly001').</param>
            /// <param name="token">The token provided to the user's device when the subscription was purchased.</param>
            public virtual RevokeRequest Revoke(string packageName, string subscriptionId, string token)
            {
                return new RevokeRequest(service, packageName, subscriptionId, token);
            }

            /// <summary>
            /// Refunds and immediately revokes a user's subscription purchase. Access to the subscription will be
            /// terminated immediately and it will stop recurring.
            /// </summary>
            public class RevokeRequest : AndroidPublisherBaseServiceRequest<string>
            {
                /// <summary>Constructs a new Revoke request.</summary>
                public RevokeRequest(Google.Apis.Services.IClientService service, string packageName, string subscriptionId, string token) : base(service)
                {
                    PackageName = packageName;
                    SubscriptionId = subscriptionId;
                    Token = token;
                    InitParameters();
                }

                /// <summary>
                /// The package name of the application for which this subscription was purchased (for example,
                /// 'com.some.thing').
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>The purchased subscription ID (for example, 'monthly001').</summary>
                [Google.Apis.Util.RequestParameterAttribute("subscriptionId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string SubscriptionId { get; private set; }

                /// <summary>The token provided to the user's device when the subscription was purchased.</summary>
                [Google.Apis.Util.RequestParameterAttribute("token", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Token { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "revoke";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/purchases/subscriptions/{subscriptionId}/tokens/{token}:revoke";

                /// <summary>Initializes Revoke parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("subscriptionId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "subscriptionId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("token", new Google.Apis.Discovery.Parameter
                    {
                        Name = "token",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the Voidedpurchases resource.</summary>
        public virtual VoidedpurchasesResource Voidedpurchases { get; }

        /// <summary>The "voidedpurchases" collection of methods.</summary>
        public class VoidedpurchasesResource
        {
            private const string Resource = "voidedpurchases";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public VoidedpurchasesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Lists the purchases that were canceled, refunded or charged-back.</summary>
            /// <param name="packageName">
            /// The package name of the application for which voided purchases need to be returned (for example,
            /// 'com.some.thing').
            /// </param>
            public virtual ListRequest List(string packageName)
            {
                return new ListRequest(service, packageName);
            }

            /// <summary>Lists the purchases that were canceled, refunded or charged-back.</summary>
            public class ListRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.VoidedPurchasesListResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string packageName) : base(service)
                {
                    PackageName = packageName;
                    InitParameters();
                }

                /// <summary>
                /// The package name of the application for which voided purchases need to be returned (for example,
                /// 'com.some.thing').
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>
                /// The time, in milliseconds since the Epoch, of the newest voided purchase that you want to see in the
                /// response. The value of this parameter cannot be greater than the current time and is ignored if a
                /// pagination token is set. Default value is current time. Note: This filter is applied on the time at
                /// which the record is seen as voided by our systems and not the actual voided time returned in the
                /// response.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("endTime", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<long> EndTime { get; set; }

                /// <summary>
                /// Defines how many results the list operation should return. The default number depends on the
                /// resource collection.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<long> MaxResults { get; set; }

                /// <summary>
                /// Defines the index of the first element to return. This can only be used if indexed paging is
                /// enabled.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("startIndex", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<long> StartIndex { get; set; }

                /// <summary>
                /// The time, in milliseconds since the Epoch, of the oldest voided purchase that you want to see in the
                /// response. The value of this parameter cannot be older than 30 days and is ignored if a pagination
                /// token is set. Default value is current time minus 30 days. Note: This filter is applied on the time
                /// at which the record is seen as voided by our systems and not the actual voided time returned in the
                /// response.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("startTime", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<long> StartTime { get; set; }

                /// <summary>
                /// Defines the token of the page to return, usually taken from TokenPagination. This can only be used
                /// if token paging is enabled.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("token", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Token { get; set; }

                /// <summary>
                /// The type of voided purchases that you want to see in the response. Possible values are: 0. Only
                /// voided in-app product purchases will be returned in the response. This is the default value. 1. Both
                /// voided in-app purchases and voided subscription purchases will be returned in the response. Note:
                /// Before requesting to receive voided subscription purchases, you must switch to use orderId in the
                /// response which uniquely identifies one-time purchases and subscriptions. Otherwise, you will receive
                /// multiple subscription orders with the same PurchaseToken, because subscription renewal orders share
                /// the same PurchaseToken.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("type", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> Type { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/purchases/voidedpurchases";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("endTime", new Google.Apis.Discovery.Parameter
                    {
                        Name = "endTime",
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
                    RequestParameters.Add("startIndex", new Google.Apis.Discovery.Parameter
                    {
                        Name = "startIndex",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("startTime", new Google.Apis.Discovery.Parameter
                    {
                        Name = "startTime",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("token", new Google.Apis.Discovery.Parameter
                    {
                        Name = "token",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("type", new Google.Apis.Discovery.Parameter
                    {
                        Name = "type",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }
    }

    /// <summary>The "reviews" collection of methods.</summary>
    public class ReviewsResource
    {
        private const string Resource = "reviews";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ReviewsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Gets a single review.</summary>
        /// <param name="packageName">Package name of the app.</param>
        /// <param name="reviewId">Unique identifier for a review.</param>
        public virtual GetRequest Get(string packageName, string reviewId)
        {
            return new GetRequest(service, packageName, reviewId);
        }

        /// <summary>Gets a single review.</summary>
        public class GetRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.Review>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string packageName, string reviewId) : base(service)
            {
                PackageName = packageName;
                ReviewId = reviewId;
                InitParameters();
            }

            /// <summary>Package name of the app.</summary>
            [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PackageName { get; private set; }

            /// <summary>Unique identifier for a review.</summary>
            [Google.Apis.Util.RequestParameterAttribute("reviewId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ReviewId { get; private set; }

            /// <summary>Language localization code.</summary>
            [Google.Apis.Util.RequestParameterAttribute("translationLanguage", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string TranslationLanguage { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidpublisher/v3/applications/{packageName}/reviews/{reviewId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                {
                    Name = "packageName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("reviewId", new Google.Apis.Discovery.Parameter
                {
                    Name = "reviewId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("translationLanguage", new Google.Apis.Discovery.Parameter
                {
                    Name = "translationLanguage",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Lists all reviews.</summary>
        /// <param name="packageName">Package name of the app.</param>
        public virtual ListRequest List(string packageName)
        {
            return new ListRequest(service, packageName);
        }

        /// <summary>Lists all reviews.</summary>
        public class ListRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.ReviewsListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string packageName) : base(service)
            {
                PackageName = packageName;
                InitParameters();
            }

            /// <summary>Package name of the app.</summary>
            [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PackageName { get; private set; }

            /// <summary>How many results the list operation should return.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>The index of the first element to return.</summary>
            [Google.Apis.Util.RequestParameterAttribute("startIndex", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> StartIndex { get; set; }

            /// <summary>Pagination token. If empty, list starts at the first review.</summary>
            [Google.Apis.Util.RequestParameterAttribute("token", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Token { get; set; }

            /// <summary>Language localization code.</summary>
            [Google.Apis.Util.RequestParameterAttribute("translationLanguage", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string TranslationLanguage { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidpublisher/v3/applications/{packageName}/reviews";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                {
                    Name = "packageName",
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
                RequestParameters.Add("startIndex", new Google.Apis.Discovery.Parameter
                {
                    Name = "startIndex",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("token", new Google.Apis.Discovery.Parameter
                {
                    Name = "token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("translationLanguage", new Google.Apis.Discovery.Parameter
                {
                    Name = "translationLanguage",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Replies to a single review, or updates an existing reply.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="packageName">Package name of the app.</param>
        /// <param name="reviewId">Unique identifier for a review.</param>
        public virtual ReplyRequest Reply(Google.Apis.AndroidPublisher.v3.Data.ReviewsReplyRequest body, string packageName, string reviewId)
        {
            return new ReplyRequest(service, body, packageName, reviewId);
        }

        /// <summary>Replies to a single review, or updates an existing reply.</summary>
        public class ReplyRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.ReviewsReplyResponse>
        {
            /// <summary>Constructs a new Reply request.</summary>
            public ReplyRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.ReviewsReplyRequest body, string packageName, string reviewId) : base(service)
            {
                PackageName = packageName;
                ReviewId = reviewId;
                Body = body;
                InitParameters();
            }

            /// <summary>Package name of the app.</summary>
            [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PackageName { get; private set; }

            /// <summary>Unique identifier for a review.</summary>
            [Google.Apis.Util.RequestParameterAttribute("reviewId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ReviewId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AndroidPublisher.v3.Data.ReviewsReplyRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "reply";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidpublisher/v3/applications/{packageName}/reviews/{reviewId}:reply";

            /// <summary>Initializes Reply parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                {
                    Name = "packageName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("reviewId", new Google.Apis.Discovery.Parameter
                {
                    Name = "reviewId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "systemapks" collection of methods.</summary>
    public class SystemapksResource
    {
        private const string Resource = "systemapks";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public SystemapksResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Variants = new VariantsResource(service);
        }

        /// <summary>Gets the Variants resource.</summary>
        public virtual VariantsResource Variants { get; }

        /// <summary>The "variants" collection of methods.</summary>
        public class VariantsResource
        {
            private const string Resource = "variants";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public VariantsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Creates an APK which is suitable for inclusion in a system image from an already uploaded Android App
            /// Bundle.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="versionCode">The version code of the App Bundle.</param>
            public virtual CreateRequest Create(Google.Apis.AndroidPublisher.v3.Data.Variant body, string packageName, long versionCode)
            {
                return new CreateRequest(service, body, packageName, versionCode);
            }

            /// <summary>
            /// Creates an APK which is suitable for inclusion in a system image from an already uploaded Android App
            /// Bundle.
            /// </summary>
            public class CreateRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.Variant>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.Variant body, string packageName, long versionCode) : base(service)
                {
                    PackageName = packageName;
                    VersionCode = versionCode;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>The version code of the App Bundle.</summary>
                [Google.Apis.Util.RequestParameterAttribute("versionCode", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long VersionCode { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AndroidPublisher.v3.Data.Variant Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/systemApks/{versionCode}/variants";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("versionCode", new Google.Apis.Discovery.Parameter
                    {
                        Name = "versionCode",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Downloads a previously created system APK which is suitable for inclusion in a system image.
            /// </summary>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="versionCode">The version code of the App Bundle.</param>
            /// <param name="variantId">The ID of a previously created system APK variant.</param>
            public virtual DownloadRequest Download(string packageName, long versionCode, long variantId)
            {
                return new DownloadRequest(service, packageName, versionCode, variantId);
            }

            /// <summary>
            /// Downloads a previously created system APK which is suitable for inclusion in a system image.
            /// </summary>
            public class DownloadRequest : AndroidPublisherBaseServiceRequest<string>
            {
                /// <summary>Constructs a new Download request.</summary>
                public DownloadRequest(Google.Apis.Services.IClientService service, string packageName, long versionCode, long variantId) : base(service)
                {
                    PackageName = packageName;
                    VersionCode = versionCode;
                    VariantId = variantId;
                    MediaDownloader = new Google.Apis.Download.MediaDownloader(service);
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>The version code of the App Bundle.</summary>
                [Google.Apis.Util.RequestParameterAttribute("versionCode", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long VersionCode { get; private set; }

                /// <summary>The ID of a previously created system APK variant.</summary>
                [Google.Apis.Util.RequestParameterAttribute("variantId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long VariantId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "download";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/systemApks/{versionCode}/variants/{variantId}:download";

                /// <summary>Initializes Download parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("versionCode", new Google.Apis.Discovery.Parameter
                    {
                        Name = "versionCode",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("variantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "variantId",
                        IsRequired = true,
                        ParameterType = "path",
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
                /// <returns>
                /// The final status of the download; including whether the download succeeded or failed.
                /// </returns>
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

            /// <summary>Returns a previously created system APK variant.</summary>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="versionCode">The version code of the App Bundle.</param>
            /// <param name="variantId">The ID of a previously created system APK variant.</param>
            public virtual GetRequest Get(string packageName, long versionCode, long variantId)
            {
                return new GetRequest(service, packageName, versionCode, variantId);
            }

            /// <summary>Returns a previously created system APK variant.</summary>
            public class GetRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.Variant>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string packageName, long versionCode, long variantId) : base(service)
                {
                    PackageName = packageName;
                    VersionCode = versionCode;
                    VariantId = variantId;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>The version code of the App Bundle.</summary>
                [Google.Apis.Util.RequestParameterAttribute("versionCode", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long VersionCode { get; private set; }

                /// <summary>The ID of a previously created system APK variant.</summary>
                [Google.Apis.Util.RequestParameterAttribute("variantId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long VariantId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/systemApks/{versionCode}/variants/{variantId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("versionCode", new Google.Apis.Discovery.Parameter
                    {
                        Name = "versionCode",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("variantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "variantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Returns the list of previously created system APK variants.</summary>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="versionCode">The version code of the App Bundle.</param>
            public virtual ListRequest List(string packageName, long versionCode)
            {
                return new ListRequest(service, packageName, versionCode);
            }

            /// <summary>Returns the list of previously created system APK variants.</summary>
            public class ListRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.SystemApksListResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string packageName, long versionCode) : base(service)
                {
                    PackageName = packageName;
                    VersionCode = versionCode;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>The version code of the App Bundle.</summary>
                [Google.Apis.Util.RequestParameterAttribute("versionCode", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long VersionCode { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/systemApks/{versionCode}/variants";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("versionCode", new Google.Apis.Discovery.Parameter
                    {
                        Name = "versionCode",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }
    }
}
namespace Google.Apis.AndroidPublisher.v3.Data
{
    /// <summary>Information about an APK. The resource for ApksService.</summary>
    public class Apk : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Information about the binary payload of this APK.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("binary")]
        public virtual ApkBinary Binary { get; set; }

        /// <summary>The version code of the APK, as specified in the manifest file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionCode")]
        public virtual System.Nullable<int> VersionCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the binary payload of an APK.</summary>
    public class ApkBinary : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A sha1 hash of the APK payload, encoded as a hex string and matching the output of the sha1sum command.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sha1")]
        public virtual string Sha1 { get; set; }

        /// <summary>
        /// A sha256 hash of the APK payload, encoded as a hex string and matching the output of the sha256sum command.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sha256")]
        public virtual string Sha256 { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to create a new externally hosted APK.</summary>
    public class ApksAddExternallyHostedRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The definition of the externally-hosted APK and where it is located.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externallyHostedApk")]
        public virtual ExternallyHostedApk ExternallyHostedApk { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for creating a new externally hosted APK.</summary>
    public class ApksAddExternallyHostedResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The definition of the externally-hosted APK and where it is located.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externallyHostedApk")]
        public virtual ExternallyHostedApk ExternallyHostedApk { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response listing all APKs.</summary>
    public class ApksListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>All APKs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apks")]
        public virtual System.Collections.Generic.IList<Apk> Apks { get; set; }

        /// <summary>The kind of this response ("androidpublisher#apksListResponse").</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The app details. The resource for DetailsService.</summary>
    public class AppDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The user-visible support email for this app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contactEmail")]
        public virtual string ContactEmail { get; set; }

        /// <summary>The user-visible support telephone number for this app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contactPhone")]
        public virtual string ContactPhone { get; set; }

        /// <summary>The user-visible website for this app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contactWebsite")]
        public virtual string ContactWebsite { get; set; }

        /// <summary>Default language code, in BCP 47 format (eg "en-US").</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultLanguage")]
        public virtual string DefaultLanguage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An app edit. The resource for EditsService.</summary>
    public class AppEdit : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The time (as seconds since Epoch) at which the edit will expire and will be no longer valid for
        /// use.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expiryTimeSeconds")]
        public virtual string ExpiryTimeSeconds { get; set; }

        /// <summary>Output only. Identifier of the edit. Can be used in subsequent API calls.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a bundle. The resource for BundlesService.</summary>
    public class Bundle : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A sha1 hash of the upload payload, encoded as a hex string and matching the output of the sha1sum command.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sha1")]
        public virtual string Sha1 { get; set; }

        /// <summary>
        /// A sha256 hash of the upload payload, encoded as a hex string and matching the output of the sha256sum
        /// command.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sha256")]
        public virtual string Sha256 { get; set; }

        /// <summary>
        /// The version code of the Android App Bundle, as specified in the Android App Bundle's base module APK
        /// manifest file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionCode")]
        public virtual System.Nullable<int> VersionCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response listing all bundles.</summary>
    public class BundlesListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>All bundles.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bundles")]
        public virtual System.Collections.Generic.IList<Bundle> Bundles { get; set; }

        /// <summary>The kind of this response ("androidpublisher#bundlesListResponse").</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An entry of conversation between user and developer.</summary>
    public class Comment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A comment from a developer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("developerComment")]
        public virtual DeveloperComment DeveloperComment { get; set; }

        /// <summary>A comment from a user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userComment")]
        public virtual UserComment UserComment { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Country targeting specification.</summary>
    public class CountryTargeting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Countries to target, specified as two letter [CLDR
        /// codes](https://unicode.org/cldr/charts/latest/supplemental/territory_containment_un_m_49.html).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("countries")]
        public virtual System.Collections.Generic.IList<string> Countries { get; set; }

        /// <summary>Include "rest of world" as well as explicitly targeted countries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeRestOfWorld")]
        public virtual System.Nullable<bool> IncludeRestOfWorld { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a deobfuscation file.</summary>
    public class DeobfuscationFile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of the deobfuscation file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("symbolType")]
        public virtual string SymbolType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Responses for the upload.</summary>
    public class DeobfuscationFilesUploadResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The uploaded Deobfuscation File configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deobfuscationFile")]
        public virtual DeobfuscationFile DeobfuscationFile { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Developer entry from conversation between user and developer.</summary>
    public class DeveloperComment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The last time at which this comment was updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastModified")]
        public virtual Timestamp LastModified { get; set; }

        /// <summary>The content of the comment, i.e. reply body.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Characteristics of the user's device.</summary>
    public class DeviceMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Device CPU make, e.g. "Qualcomm"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpuMake")]
        public virtual string CpuMake { get; set; }

        /// <summary>Device CPU model, e.g. "MSM8974"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpuModel")]
        public virtual string CpuModel { get; set; }

        /// <summary>Device class (e.g. tablet)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceClass")]
        public virtual string DeviceClass { get; set; }

        /// <summary>OpenGL version</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("glEsVersion")]
        public virtual System.Nullable<int> GlEsVersion { get; set; }

        /// <summary>Device manufacturer (e.g. Motorola)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manufacturer")]
        public virtual string Manufacturer { get; set; }

        /// <summary>Comma separated list of native platforms (e.g. "arm", "arm7")</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nativePlatform")]
        public virtual string NativePlatform { get; set; }

        /// <summary>Device model name (e.g. Droid)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productName")]
        public virtual string ProductName { get; set; }

        /// <summary>Device RAM in Megabytes, e.g. "2048"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ramMb")]
        public virtual System.Nullable<int> RamMb { get; set; }

        /// <summary>Screen density in DPI</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("screenDensityDpi")]
        public virtual System.Nullable<int> ScreenDensityDpi { get; set; }

        /// <summary>Screen height in pixels</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("screenHeightPx")]
        public virtual System.Nullable<int> ScreenHeightPx { get; set; }

        /// <summary>Screen width in pixels</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("screenWidthPx")]
        public virtual System.Nullable<int> ScreenWidthPx { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The device spec used to generate a system APK.</summary>
    public class DeviceSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Screen dpi.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("screenDensity")]
        public virtual System.Nullable<long> ScreenDensity { get; set; }

        /// <summary>
        /// Supported ABI architectures in the order of preference. The values should be the string as reported by the
        /// platform, e.g. "armeabi-v7a", "x86_64".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportedAbis")]
        public virtual System.Collections.Generic.IList<string> SupportedAbis { get; set; }

        /// <summary>All installed locales represented as BCP-47 strings, e.g. "en-US".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportedLocales")]
        public virtual System.Collections.Generic.IList<string> SupportedLocales { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An expansion file. The resource for ExpansionFilesService.</summary>
    public class ExpansionFile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If set, this field indicates that this APK has an expansion file uploaded to it: this APK does not reference
        /// another APK's expansion file. The field's value is the size of the uploaded expansion file in bytes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileSize")]
        public virtual System.Nullable<long> FileSize { get; set; }

        /// <summary>
        /// If set, this APK's expansion file references another APK's expansion file. The file_size field will not be
        /// set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referencesVersion")]
        public virtual System.Nullable<int> ReferencesVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for uploading an expansion file.</summary>
    public class ExpansionFilesUploadResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The uploaded expansion file configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expansionFile")]
        public virtual ExpansionFile ExpansionFile { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Defines an APK available for this application that is hosted externally and not uploaded to Google Play. This
    /// function is only available to organizations using Managed Play whose application is configured to restrict
    /// distribution to the organizations.
    /// </summary>
    public class ExternallyHostedApk : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The application label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applicationLabel")]
        public virtual string ApplicationLabel { get; set; }

        /// <summary>
        /// A certificate (or array of certificates if a certificate-chain is used) used to sign this APK, represented
        /// as a base64 encoded byte array.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certificateBase64s")]
        public virtual System.Collections.Generic.IList<string> CertificateBase64s { get; set; }

        /// <summary>The URL at which the APK is hosted. This must be an https URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externallyHostedUrl")]
        public virtual string ExternallyHostedUrl { get; set; }

        /// <summary>The sha1 checksum of this APK, represented as a base64 encoded byte array.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileSha1Base64")]
        public virtual string FileSha1Base64 { get; set; }

        /// <summary>The sha256 checksum of this APK, represented as a base64 encoded byte array.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileSha256Base64")]
        public virtual string FileSha256Base64 { get; set; }

        /// <summary>The file size in bytes of this APK.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileSize")]
        public virtual System.Nullable<long> FileSize { get; set; }

        /// <summary>The icon image from the APK, as a base64 encoded byte array.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iconBase64")]
        public virtual string IconBase64 { get; set; }

        /// <summary>The maximum SDK supported by this APK (optional).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maximumSdk")]
        public virtual System.Nullable<int> MaximumSdk { get; set; }

        /// <summary>The minimum SDK targeted by this APK.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minimumSdk")]
        public virtual System.Nullable<int> MinimumSdk { get; set; }

        /// <summary>The native code environments supported by this APK (optional).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nativeCodes")]
        public virtual System.Collections.Generic.IList<string> NativeCodes { get; set; }

        /// <summary>The package name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageName")]
        public virtual string PackageName { get; set; }

        /// <summary>The features required by this APK (optional).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("usesFeatures")]
        public virtual System.Collections.Generic.IList<string> UsesFeatures { get; set; }

        /// <summary>The permissions requested by this APK.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("usesPermissions")]
        public virtual System.Collections.Generic.IList<UsesPermission> UsesPermissions { get; set; }

        /// <summary>The version code of this APK.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionCode")]
        public virtual System.Nullable<int> VersionCode { get; set; }

        /// <summary>The version name of this APK.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionName")]
        public virtual string VersionName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An uploaded image. The resource for ImagesService.</summary>
    public class Image : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A unique id representing this image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>A sha1 hash of the image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sha1")]
        public virtual string Sha1 { get; set; }

        /// <summary>A sha256 hash of the image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sha256")]
        public virtual string Sha256 { get; set; }

        /// <summary>A URL that will serve a preview of the image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for deleting all images.</summary>
    public class ImagesDeleteAllResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The deleted images.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleted")]
        public virtual System.Collections.Generic.IList<Image> Deleted { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response listing all images.</summary>
    public class ImagesListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>All listed Images.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("images")]
        public virtual System.Collections.Generic.IList<Image> Images { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for uploading an image.</summary>
    public class ImagesUploadResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The uploaded image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual Image Image { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An in-app product. The resource for InappproductsService.</summary>
    public class InAppProduct : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Default language of the localized data, as defined by BCP-47. e.g. "en-US".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultLanguage")]
        public virtual string DefaultLanguage { get; set; }

        /// <summary>
        /// Default price. Cannot be zero, as in-app products are never free. Always in the developer's Checkout
        /// merchant currency.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultPrice")]
        public virtual Price DefaultPrice { get; set; }

        /// <summary>
        /// Grace period of the subscription, specified in ISO 8601 format. Allows developers to give their subscribers
        /// a grace period when the payment for the new recurrence period is declined. Acceptable values are P0D (zero
        /// days), P3D (three days), P7D (seven days), P14D (14 days), and P30D (30 days).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gracePeriod")]
        public virtual string GracePeriod { get; set; }

        /// <summary>
        /// List of localized title and description data. Map key is the language of the localized data, as defined by
        /// BCP-47, e.g. "en-US".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listings")]
        public virtual System.Collections.Generic.IDictionary<string, InAppProductListing> Listings { get; set; }

        /// <summary>Package name of the parent app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageName")]
        public virtual string PackageName { get; set; }

        /// <summary>
        /// Prices per buyer region. None of these can be zero, as in-app products are never free. Map key is region
        /// code, as defined by ISO 3166-2.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prices")]
        public virtual System.Collections.Generic.IDictionary<string, Price> Prices { get; set; }

        /// <summary>The type of the product, e.g. a recurring subscription.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("purchaseType")]
        public virtual string PurchaseType { get; set; }

        /// <summary>Stock-keeping-unit (SKU) of the product, unique within an app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sku")]
        public virtual string Sku { get; set; }

        /// <summary>The status of the product, e.g. whether it's active.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>
        /// Subscription period, specified in ISO 8601 format. Acceptable values are P1W (one week), P1M (one month),
        /// P3M (three months), P6M (six months), and P1Y (one year).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscriptionPeriod")]
        public virtual string SubscriptionPeriod { get; set; }

        /// <summary>
        /// Trial period, specified in ISO 8601 format. Acceptable values are anything between P7D (seven days) and
        /// P999D (999 days).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trialPeriod")]
        public virtual string TrialPeriod { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Store listing of a single in-app product.</summary>
    public class InAppProductListing : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Localized entitlement benefits for a subscription.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("benefits")]
        public virtual System.Collections.Generic.IList<string> Benefits { get; set; }

        /// <summary>Description for the store listing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Title for the store listing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response listing all in-app products.</summary>
    public class InappproductsListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>All in-app products.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inappproduct")]
        public virtual System.Collections.Generic.IList<InAppProduct> Inappproduct { get; set; }

        /// <summary>The kind of this response ("androidpublisher#inappproductsListResponse").</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Information about the current page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageInfo")]
        public virtual PageInfo PageInfo { get; set; }

        /// <summary>Pagination token, to handle a number of products that is over one page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tokenPagination")]
        public virtual TokenPagination TokenPagination { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An artifact resource which gets created when uploading an APK or Android App Bundle through internal app
    /// sharing.
    /// </summary>
    public class InternalAppSharingArtifact : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The sha256 fingerprint of the certificate used to sign the generated artifact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certificateFingerprint")]
        public virtual string CertificateFingerprint { get; set; }

        /// <summary>
        /// The download URL generated for the uploaded artifact. Users that are authorized to download can follow the
        /// link to the Play Store app to install it.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("downloadUrl")]
        public virtual string DownloadUrl { get; set; }

        /// <summary>
        /// The sha256 hash of the artifact represented as a lowercase hexadecimal number, matching the output of the
        /// sha256sum command.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sha256")]
        public virtual string Sha256 { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains the introductory price information for a subscription.</summary>
    public class IntroductoryPriceInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Introductory price of the subscription, not including tax. The currency is the same as price_currency_code.
        /// Price is expressed in micro-units, where 1,000,000 micro-units represents one unit of the currency. For
        /// example, if the subscription price is €1.99, price_amount_micros is 1990000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("introductoryPriceAmountMicros")]
        public virtual System.Nullable<long> IntroductoryPriceAmountMicros { get; set; }

        /// <summary>
        /// ISO 4217 currency code for the introductory subscription price. For example, if the price is specified in
        /// British pounds sterling, price_currency_code is "GBP".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("introductoryPriceCurrencyCode")]
        public virtual string IntroductoryPriceCurrencyCode { get; set; }

        /// <summary>The number of billing period to offer introductory pricing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("introductoryPriceCycles")]
        public virtual System.Nullable<int> IntroductoryPriceCycles { get; set; }

        /// <summary>
        /// Introductory price period, specified in ISO 8601 format. Common values are (but not limited to) "P1W" (one
        /// week), "P1M" (one month), "P3M" (three months), "P6M" (six months), and "P1Y" (one year).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("introductoryPricePeriod")]
        public virtual string IntroductoryPricePeriod { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A localized store listing. The resource for ListingsService.</summary>
    public class Listing : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Full description of the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullDescription")]
        public virtual string FullDescription { get; set; }

        /// <summary>
        /// Language localization code (a BCP-47 language tag; for example, "de-AT" for Austrian German).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("language")]
        public virtual string Language { get; set; }

        /// <summary>Short description of the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shortDescription")]
        public virtual string ShortDescription { get; set; }

        /// <summary>Localized title of the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>URL of a promotional YouTube video for the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("video")]
        public virtual string Video { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response listing all localized listings.</summary>
    public class ListingsListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The kind of this response ("androidpublisher#listingsListResponse").</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>All localized listings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listings")]
        public virtual System.Collections.Generic.IList<Listing> Listings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Release notes specification, i.e. language and text.</summary>
    public class LocalizedText : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Language localization code (a BCP-47 language tag; for example, "de-AT" for Austrian German).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("language")]
        public virtual string Language { get; set; }

        /// <summary>The text in the given language.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Information about the current page. List operations that supports paging return only one "page" of results. This
    /// protocol buffer message describes the page that has been returned.
    /// </summary>
    public class PageInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Maximum number of results returned in one page. ! The number of results included in the API response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resultPerPage")]
        public virtual System.Nullable<int> ResultPerPage { get; set; }

        /// <summary>Index of the first result returned in the current page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startIndex")]
        public virtual System.Nullable<int> StartIndex { get; set; }

        /// <summary>
        /// Total number of results available on the backend ! The total number of results in the result set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalResults")]
        public virtual System.Nullable<int> TotalResults { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Definition of a price, i.e. currency and units.</summary>
    public class Price : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// 3 letter Currency code, as defined by ISO 4217. See java/com/google/common/money/CurrencyCode.java
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currency")]
        public virtual string Currency { get; set; }

        /// <summary>Price in 1/million of the currency base unit, represented as a string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priceMicros")]
        public virtual string PriceMicros { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A ProductPurchase resource indicates the status of a user's inapp product purchase.</summary>
    public class ProductPurchase : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The acknowledgement state of the inapp product. Possible values are: 0. Yet to be acknowledged 1.
        /// Acknowledged
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("acknowledgementState")]
        public virtual System.Nullable<int> AcknowledgementState { get; set; }

        /// <summary>
        /// The consumption state of the inapp product. Possible values are: 0. Yet to be consumed 1. Consumed
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consumptionState")]
        public virtual System.Nullable<int> ConsumptionState { get; set; }

        /// <summary>A developer-specified string that contains supplemental information about an order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("developerPayload")]
        public virtual string DeveloperPayload { get; set; }

        /// <summary>This kind represents an inappPurchase object in the androidpublisher service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// An obfuscated version of the id that is uniquely associated with the user's account in your app. Only
        /// present if specified using
        /// https://developer.android.com/reference/com/android/billingclient/api/BillingFlowParams.Builder#setobfuscatedaccountid
        /// when the purchase was made.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("obfuscatedExternalAccountId")]
        public virtual string ObfuscatedExternalAccountId { get; set; }

        /// <summary>
        /// An obfuscated version of the id that is uniquely associated with the user's profile in your app. Only
        /// present if specified using
        /// https://developer.android.com/reference/com/android/billingclient/api/BillingFlowParams.Builder#setobfuscatedprofileid
        /// when the purchase was made.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("obfuscatedExternalProfileId")]
        public virtual string ObfuscatedExternalProfileId { get; set; }

        /// <summary>The order id associated with the purchase of the inapp product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orderId")]
        public virtual string OrderId { get; set; }

        /// <summary>The inapp product SKU.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productId")]
        public virtual string ProductId { get; set; }

        /// <summary>The purchase state of the order. Possible values are: 0. Purchased 1. Canceled 2. Pending</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("purchaseState")]
        public virtual System.Nullable<int> PurchaseState { get; set; }

        /// <summary>The time the product was purchased, in milliseconds since the epoch (Jan 1, 1970).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("purchaseTimeMillis")]
        public virtual System.Nullable<long> PurchaseTimeMillis { get; set; }

        /// <summary>The purchase token generated to identify this purchase.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("purchaseToken")]
        public virtual string PurchaseToken { get; set; }

        /// <summary>
        /// The type of purchase of the inapp product. This field is only set if this purchase was not made using the
        /// standard in-app billing flow. Possible values are: 0. Test (i.e. purchased from a license testing account)
        /// 1. Promo (i.e. purchased using a promo code) 2. Rewarded (i.e. from watching a video ad instead of paying)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("purchaseType")]
        public virtual System.Nullable<int> PurchaseType { get; set; }

        /// <summary>The quantity associated with the purchase of the inapp product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quantity")]
        public virtual System.Nullable<int> Quantity { get; set; }

        /// <summary>ISO 3166-1 alpha-2 billing region code of the user at the time the product was granted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for the product.purchases.acknowledge API.</summary>
    public class ProductPurchasesAcknowledgeRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Payload to attach to the purchase.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("developerPayload")]
        public virtual string DeveloperPayload { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An Android app review.</summary>
    public class Review : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the user who wrote the review.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authorName")]
        public virtual string AuthorName { get; set; }

        /// <summary>A repeated field containing comments for the review.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("comments")]
        public virtual System.Collections.Generic.IList<Comment> Comments { get; set; }

        /// <summary>Unique identifier for this review.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reviewId")]
        public virtual string ReviewId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The result of replying/updating a reply to review.</summary>
    public class ReviewReplyResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The time at which the reply took effect.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastEdited")]
        public virtual Timestamp LastEdited { get; set; }

        /// <summary>The reply text that was applied.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replyText")]
        public virtual string ReplyText { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response listing reviews.</summary>
    public class ReviewsListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Information about the current page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageInfo")]
        public virtual PageInfo PageInfo { get; set; }

        /// <summary>List of reviews.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reviews")]
        public virtual System.Collections.Generic.IList<Review> Reviews { get; set; }

        /// <summary>Pagination token, to handle a number of products that is over one page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tokenPagination")]
        public virtual TokenPagination TokenPagination { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to reply to review or update existing reply.</summary>
    public class ReviewsReplyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The text to set as the reply. Replies of more than approximately 350 characters will be rejected. HTML tags
        /// will be stripped.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replyText")]
        public virtual string ReplyText { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response on status of replying to a review.</summary>
    public class ReviewsReplyResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The result of replying/updating a reply to review.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("result")]
        public virtual ReviewReplyResult Result { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Information provided by the user when they complete the subscription cancellation flow (cancellation reason
    /// survey).
    /// </summary>
    public class SubscriptionCancelSurveyResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The cancellation reason the user chose in the survey. Possible values are: 0. Other 1. I don't use this
        /// service enough 2. Technical issues 3. Cost-related reasons 4. I found a better app
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cancelSurveyReason")]
        public virtual System.Nullable<int> CancelSurveyReason { get; set; }

        /// <summary>The customized input cancel reason from the user. Only present when cancelReason is 0.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userInputCancelReason")]
        public virtual string UserInputCancelReason { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A SubscriptionDeferralInfo contains the data needed to defer a subscription purchase to a future expiry time.
    /// </summary>
    public class SubscriptionDeferralInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The desired next expiry time to assign to the subscription, in milliseconds since the Epoch. The given time
        /// must be later/greater than the current expiry time for the subscription.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("desiredExpiryTimeMillis")]
        public virtual System.Nullable<long> DesiredExpiryTimeMillis { get; set; }

        /// <summary>
        /// The expected expiry time for the subscription. If the current expiry time for the subscription is not the
        /// value specified here, the deferral will not occur.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expectedExpiryTimeMillis")]
        public virtual System.Nullable<long> ExpectedExpiryTimeMillis { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Contains the price change information for a subscription that can be used to control the user journey for the
    /// price change in the app. This can be in the form of seeking confirmation from the user or tailoring the
    /// experience for a successful conversion.
    /// </summary>
    public class SubscriptionPriceChange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The new price the subscription will renew with if the price change is accepted by the user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newPrice")]
        public virtual Price NewPrice { get; set; }

        /// <summary>
        /// The current state of the price change. Possible values are: 0. Outstanding: State for a pending price change
        /// waiting for the user to agree. In this state, you can optionally seek confirmation from the user using the
        /// In-App API. 1. Accepted: State for an accepted price change that the subscription will renew with unless
        /// it's canceled. The price change takes effect on a future date when the subscription renews. Note that the
        /// change might not occur when the subscription is renewed next.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual System.Nullable<int> State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A SubscriptionPurchase resource indicates the status of a user's subscription purchase.</summary>
    public class SubscriptionPurchase : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The acknowledgement state of the subscription product. Possible values are: 0. Yet to be acknowledged 1.
        /// Acknowledged
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("acknowledgementState")]
        public virtual System.Nullable<int> AcknowledgementState { get; set; }

        /// <summary>
        /// Whether the subscription will automatically be renewed when it reaches its current expiry time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoRenewing")]
        public virtual System.Nullable<bool> AutoRenewing { get; set; }

        /// <summary>
        /// Time at which the subscription will be automatically resumed, in milliseconds since the Epoch. Only present
        /// if the user has requested to pause the subscription.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoResumeTimeMillis")]
        public virtual System.Nullable<long> AutoResumeTimeMillis { get; set; }

        /// <summary>
        /// The reason why a subscription was canceled or is not auto-renewing. Possible values are: 0. User canceled
        /// the subscription 1. Subscription was canceled by the system, for example because of a billing problem 2.
        /// Subscription was replaced with a new subscription 3. Subscription was canceled by the developer
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cancelReason")]
        public virtual System.Nullable<int> CancelReason { get; set; }

        /// <summary>
        /// Information provided by the user when they complete the subscription cancellation flow (cancellation reason
        /// survey).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cancelSurveyResult")]
        public virtual SubscriptionCancelSurveyResult CancelSurveyResult { get; set; }

        /// <summary>
        /// ISO 3166-1 alpha-2 billing country/region code of the user at the time the subscription was granted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("countryCode")]
        public virtual string CountryCode { get; set; }

        /// <summary>A developer-specified string that contains supplemental information about an order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("developerPayload")]
        public virtual string DeveloperPayload { get; set; }

        /// <summary>
        /// The email address of the user when the subscription was purchased. Only present for purchases made with
        /// 'Subscribe with Google'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emailAddress")]
        public virtual string EmailAddress { get; set; }

        /// <summary>Time at which the subscription will expire, in milliseconds since the Epoch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expiryTimeMillis")]
        public virtual System.Nullable<long> ExpiryTimeMillis { get; set; }

        /// <summary>
        /// User account identifier in the third-party service. Only present if account linking happened as part of the
        /// subscription purchase flow.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalAccountId")]
        public virtual string ExternalAccountId { get; set; }

        /// <summary>
        /// The family name of the user when the subscription was purchased. Only present for purchases made with
        /// 'Subscribe with Google'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("familyName")]
        public virtual string FamilyName { get; set; }

        /// <summary>
        /// The given name of the user when the subscription was purchased. Only present for purchases made with
        /// 'Subscribe with Google'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("givenName")]
        public virtual string GivenName { get; set; }

        /// <summary>
        /// Introductory price information of the subscription. This is only present when the subscription was purchased
        /// with an introductory price. This field does not indicate the subscription is currently in introductory price
        /// period.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("introductoryPriceInfo")]
        public virtual IntroductoryPriceInfo IntroductoryPriceInfo { get; set; }

        /// <summary>This kind represents a subscriptionPurchase object in the androidpublisher service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The purchase token of the originating purchase if this subscription is one of the following: 0. Re-signup of
        /// a canceled but non-lapsed subscription 1. Upgrade/downgrade from a previous subscription For example,
        /// suppose a user originally signs up and you receive purchase token X, then the user cancels and goes through
        /// the resignup flow (before their subscription lapses) and you receive purchase token Y, and finally the user
        /// upgrades their subscription and you receive purchase token Z. If you call this API with purchase token Z,
        /// this field will be set to Y. If you call this API with purchase token Y, this field will be set to X. If you
        /// call this API with purchase token X, this field will not be set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkedPurchaseToken")]
        public virtual string LinkedPurchaseToken { get; set; }

        /// <summary>
        /// An obfuscated version of the id that is uniquely associated with the user's account in your app. Present for
        /// the following purchases: * If account linking happened as part of the subscription purchase flow. * It was
        /// specified using
        /// https://developer.android.com/reference/com/android/billingclient/api/BillingFlowParams.Builder#setobfuscatedaccountid
        /// when the purchase was made.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("obfuscatedExternalAccountId")]
        public virtual string ObfuscatedExternalAccountId { get; set; }

        /// <summary>
        /// An obfuscated version of the id that is uniquely associated with the user's profile in your app. Only
        /// present if specified using
        /// https://developer.android.com/reference/com/android/billingclient/api/BillingFlowParams.Builder#setobfuscatedprofileid
        /// when the purchase was made.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("obfuscatedExternalProfileId")]
        public virtual string ObfuscatedExternalProfileId { get; set; }

        /// <summary>
        /// The order id of the latest recurring order associated with the purchase of the subscription. If the
        /// subscription was canceled because payment was declined, this will be the order id from the payment declined
        /// order.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orderId")]
        public virtual string OrderId { get; set; }

        /// <summary>
        /// The payment state of the subscription. Possible values are: 0. Payment pending 1. Payment received 2. Free
        /// trial 3. Pending deferred upgrade/downgrade Not present for canceled, expired subscriptions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paymentState")]
        public virtual System.Nullable<int> PaymentState { get; set; }

        /// <summary>
        /// Price of the subscription, For tax exclusive countries, the price doesn't include tax. For tax inclusive
        /// countries, the price includes tax. Price is expressed in micro-units, where 1,000,000 micro-units represents
        /// one unit of the currency. For example, if the subscription price is €1.99, price_amount_micros is 1990000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priceAmountMicros")]
        public virtual System.Nullable<long> PriceAmountMicros { get; set; }

        /// <summary>
        /// The latest price change information available. This is present only when there is an upcoming price change
        /// for the subscription yet to be applied. Once the subscription renews with the new price or the subscription
        /// is canceled, no price change information will be returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priceChange")]
        public virtual SubscriptionPriceChange PriceChange { get; set; }

        /// <summary>
        /// ISO 4217 currency code for the subscription price. For example, if the price is specified in British pounds
        /// sterling, price_currency_code is "GBP".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priceCurrencyCode")]
        public virtual string PriceCurrencyCode { get; set; }

        /// <summary>
        /// The Google profile id of the user when the subscription was purchased. Only present for purchases made with
        /// 'Subscribe with Google'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("profileId")]
        public virtual string ProfileId { get; set; }

        /// <summary>
        /// The profile name of the user when the subscription was purchased. Only present for purchases made with
        /// 'Subscribe with Google'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("profileName")]
        public virtual string ProfileName { get; set; }

        /// <summary>
        /// The promotion code applied on this purchase. This field is only set if a vanity code promotion is applied
        /// when the subscription was purchased.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("promotionCode")]
        public virtual string PromotionCode { get; set; }

        /// <summary>
        /// The type of promotion applied on this purchase. This field is only set if a promotion is applied when the
        /// subscription was purchased. Possible values are: 0. One time code 1. Vanity code
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("promotionType")]
        public virtual System.Nullable<int> PromotionType { get; set; }

        /// <summary>
        /// The type of purchase of the subscription. This field is only set if this purchase was not made using the
        /// standard in-app billing flow. Possible values are: 0. Test (i.e. purchased from a license testing account)
        /// 1. Promo (i.e. purchased using a promo code)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("purchaseType")]
        public virtual System.Nullable<int> PurchaseType { get; set; }

        /// <summary>Time at which the subscription was granted, in milliseconds since the Epoch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTimeMillis")]
        public virtual System.Nullable<long> StartTimeMillis { get; set; }

        /// <summary>
        /// The time at which the subscription was canceled by the user, in milliseconds since the epoch. Only present
        /// if cancelReason is 0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userCancellationTimeMillis")]
        public virtual System.Nullable<long> UserCancellationTimeMillis { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for the purchases.subscriptions.acknowledge API.</summary>
    public class SubscriptionPurchasesAcknowledgeRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Payload to attach to the purchase.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("developerPayload")]
        public virtual string DeveloperPayload { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for the purchases.subscriptions.defer API.</summary>
    public class SubscriptionPurchasesDeferRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The information about the new desired expiry time for the subscription.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deferralInfo")]
        public virtual SubscriptionDeferralInfo DeferralInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for the purchases.subscriptions.defer API.</summary>
    public class SubscriptionPurchasesDeferResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The new expiry time for the subscription in milliseconds since the Epoch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newExpiryTimeMillis")]
        public virtual System.Nullable<long> NewExpiryTimeMillis { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response to list previously created system APK variants.</summary>
    public class SystemApksListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>All system APK variants created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("variants")]
        public virtual System.Collections.Generic.IList<Variant> Variants { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The testers of an app. The resource for TestersService.</summary>
    public class Testers : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>All testing Google Groups, as email addresses.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleGroups")]
        public virtual System.Collections.Generic.IList<string> GoogleGroups { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A Timestamp represents a point in time independent of any time zone or local calendar, encoded as a count of
    /// seconds and fractions of seconds at nanosecond resolution. The count is relative to an epoch at UTC midnight on
    /// January 1, 1970.
    /// </summary>
    public class Timestamp : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Non-negative fractions of a second at nanosecond resolution. Must be from 0 to 999,999,999 inclusive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nanos")]
        public virtual System.Nullable<int> Nanos { get; set; }

        /// <summary>Represents seconds of UTC time since Unix epoch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seconds")]
        public virtual System.Nullable<long> Seconds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Pagination information returned by a List operation when token pagination is enabled. List operations that
    /// supports paging return only one "page" of results. This protocol buffer message describes the page that has been
    /// returned. When using token pagination, clients should use the next/previous token to get another page of the
    /// result. The presence or absence of next/previous token indicates whether a next/previous page is available and
    /// provides a mean of accessing this page. ListRequest.page_token should be set to either next_page_token or
    /// previous_page_token to access another page.
    /// </summary>
    public class TokenPagination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Tokens to pass to the standard list field 'page_token'. Whenever available, tokens are preferred over
        /// manipulating start_index.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("previousPageToken")]
        public virtual string PreviousPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A track configuration. The resource for TracksService.</summary>
    public class Track : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// In a read request, represents all active releases in the track. In an update request, represents desired
        /// changes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("releases")]
        public virtual System.Collections.Generic.IList<TrackRelease> Releases { get; set; }

        /// <summary>Identifier of the track.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("track")]
        public virtual string TrackValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A release within a track.</summary>
    public class TrackRelease : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Restricts a release to a specific set of countries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("countryTargeting")]
        public virtual CountryTargeting CountryTargeting { get; set; }

        /// <summary>
        /// In-app update priority of the release. All newly added APKs in the release will be considered at this
        /// priority. Can take values in the range [0, 5], with 5 the highest priority. Defaults to 0.
        /// in_app_update_priority can not be updated once the release is rolled out. See
        /// https://developer.android.com/guide/playcore/in-app-updates.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inAppUpdatePriority")]
        public virtual System.Nullable<int> InAppUpdatePriority { get; set; }

        /// <summary>
        /// The release name. Not required to be unique. If not set, the name is generated from the APK's version_name.
        /// If the release contains multiple APKs, the name is generated from the date.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>A description of what is new in this release.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("releaseNotes")]
        public virtual System.Collections.Generic.IList<LocalizedText> ReleaseNotes { get; set; }

        /// <summary>The status of the release.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>
        /// Fraction of users who are eligible for a staged release. 0 &amp;lt; fraction &amp;lt; 1. Can only be set
        /// when status is "inProgress" or "halted".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userFraction")]
        public virtual System.Nullable<double> UserFraction { get; set; }

        /// <summary>
        /// Version codes of all APKs in the release. Must include version codes to retain from previous releases.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionCodes")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> VersionCodes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response listing all tracks.</summary>
    public class TracksListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The kind of this response ("androidpublisher#tracksListResponse").</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>All tracks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tracks")]
        public virtual System.Collections.Generic.IList<Track> Tracks { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>User entry from conversation between user and developer.</summary>
    public class UserComment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Integer Android SDK version of the user's device at the time the review was written, e.g. 23 is Marshmallow.
        /// May be absent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidOsVersion")]
        public virtual System.Nullable<int> AndroidOsVersion { get; set; }

        /// <summary>
        /// Integer version code of the app as installed at the time the review was written. May be absent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appVersionCode")]
        public virtual System.Nullable<int> AppVersionCode { get; set; }

        /// <summary>
        /// String version name of the app as installed at the time the review was written. May be absent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appVersionName")]
        public virtual string AppVersionName { get; set; }

        /// <summary>Codename for the reviewer's device, e.g. klte, flounder. May be absent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("device")]
        public virtual string Device { get; set; }

        /// <summary>Information about the characteristics of the user's device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceMetadata")]
        public virtual DeviceMetadata DeviceMetadata { get; set; }

        /// <summary>The last time at which this comment was updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastModified")]
        public virtual Timestamp LastModified { get; set; }

        /// <summary>
        /// Untranslated text of the review, where the review was translated. If the review was not translated this is
        /// left blank.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalText")]
        public virtual string OriginalText { get; set; }

        /// <summary>
        /// Language code for the reviewer. This is taken from the device settings so is not guaranteed to match the
        /// language the review is written in. May be absent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reviewerLanguage")]
        public virtual string ReviewerLanguage { get; set; }

        /// <summary>The star rating associated with the review, from 1 to 5.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("starRating")]
        public virtual System.Nullable<int> StarRating { get; set; }

        /// <summary>
        /// The content of the comment, i.e. review body. In some cases users have been able to write a review with
        /// separate title and body; in those cases the title and body are concatenated and separated by a tab
        /// character.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>Number of users who have given this review a thumbs down.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thumbsDownCount")]
        public virtual System.Nullable<int> ThumbsDownCount { get; set; }

        /// <summary>Number of users who have given this review a thumbs up.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thumbsUpCount")]
        public virtual System.Nullable<int> ThumbsUpCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A permission used by this APK.</summary>
    public class UsesPermission : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optionally, the maximum SDK version for which the permission is required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxSdkVersion")]
        public virtual System.Nullable<int> MaxSdkVersion { get; set; }

        /// <summary>The name of the permission requested.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>APK that is suitable for inclusion in a system image. The resource of SystemApksService.</summary>
    public class Variant : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The device spec used to generate the APK.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceSpec")]
        public virtual DeviceSpec DeviceSpec { get; set; }

        /// <summary>Output only. The ID of a previously created system APK variant.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("variantId")]
        public virtual System.Nullable<long> VariantId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A VoidedPurchase resource indicates a purchase that was either canceled/refunded/charged-back.
    /// </summary>
    public class VoidedPurchase : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>This kind represents a voided purchase object in the androidpublisher service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The order id which uniquely identifies a one-time purchase, subscription purchase, or subscription renewal.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orderId")]
        public virtual string OrderId { get; set; }

        /// <summary>The time at which the purchase was made, in milliseconds since the epoch (Jan 1, 1970).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("purchaseTimeMillis")]
        public virtual System.Nullable<long> PurchaseTimeMillis { get; set; }

        /// <summary>
        /// The token which uniquely identifies a one-time purchase or subscription. To uniquely identify subscription
        /// renewals use order_id (available starting from version 3 of the API).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("purchaseToken")]
        public virtual string PurchaseToken { get; set; }

        /// <summary>
        /// The reason why the purchase was voided, possible values are: 0. Other 1. Remorse 2. Not_received 3.
        /// Defective 4. Accidental_purchase 5. Fraud 6. Friendly_fraud 7. Chargeback
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("voidedReason")]
        public virtual System.Nullable<int> VoidedReason { get; set; }

        /// <summary>The initiator of voided purchase, possible values are: 0. User 1. Developer 2. Google</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("voidedSource")]
        public virtual System.Nullable<int> VoidedSource { get; set; }

        /// <summary>
        /// The time at which the purchase was canceled/refunded/charged-back, in milliseconds since the epoch (Jan 1,
        /// 1970).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("voidedTimeMillis")]
        public virtual System.Nullable<long> VoidedTimeMillis { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for the voidedpurchases.list API.</summary>
    public class VoidedPurchasesListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>General pagination information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageInfo")]
        public virtual PageInfo PageInfo { get; set; }

        /// <summary>Pagination information for token pagination.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tokenPagination")]
        public virtual TokenPagination TokenPagination { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("voidedPurchases")]
        public virtual System.Collections.Generic.IList<VoidedPurchase> VoidedPurchases { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
