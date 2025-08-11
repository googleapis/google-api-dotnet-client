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

namespace Google.Apis.FirebaseAppDistribution.v1
{
    /// <summary>The FirebaseAppDistribution Service.</summary>
    public class FirebaseAppDistributionService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public FirebaseAppDistributionService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public FirebaseAppDistributionService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Media = new MediaResource(this);
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://firebaseappdistribution.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://firebaseappdistribution.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "firebaseappdistribution";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Firebase App Distribution API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Firebase App Distribution API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Media resource.</summary>
        public virtual MediaResource Media { get; }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for FirebaseAppDistribution requests.</summary>
    public abstract class FirebaseAppDistributionBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new FirebaseAppDistributionBaseServiceRequest instance.</summary>
        protected FirebaseAppDistributionBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes FirebaseAppDistribution parameter list.</summary>
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
        /// Uploads a binary. Uploading a binary can result in a new release being created, an update to an existing
        /// release, or a no-op if a release with the same binary already exists.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="app">
        /// Required. The name of the app resource. Format: `projects/{project_number}/apps/{app_id}`
        /// </param>
        public virtual UploadRequest Upload(Google.Apis.FirebaseAppDistribution.v1.Data.GoogleFirebaseAppdistroV1UploadReleaseRequest body, string app)
        {
            return new UploadRequest(this.service, body, app);
        }

        /// <summary>
        /// Uploads a binary. Uploading a binary can result in a new release being created, an update to an existing
        /// release, or a no-op if a release with the same binary already exists.
        /// </summary>
        public class UploadRequest : FirebaseAppDistributionBaseServiceRequest<Google.Apis.FirebaseAppDistribution.v1.Data.GoogleLongrunningOperation>
        {
            /// <summary>Constructs a new Upload request.</summary>
            public UploadRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseAppDistribution.v1.Data.GoogleFirebaseAppdistroV1UploadReleaseRequest body, string app) : base(service)
            {
                App = app;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the app resource. Format: `projects/{project_number}/apps/{app_id}`
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("app", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string App { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.FirebaseAppDistribution.v1.Data.GoogleFirebaseAppdistroV1UploadReleaseRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "upload";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+app}/releases:upload";

            /// <summary>Initializes Upload parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("app", new Google.Apis.Discovery.Parameter
                {
                    Name = "app",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+/apps/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Uploads a binary. Uploading a binary can result in a new release being created, an update to an existing
        /// release, or a no-op if a release with the same binary already exists.
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
        /// <param name="body">The body of the request.</param>
        /// <param name="app">
        /// Required. The name of the app resource. Format: `projects/{project_number}/apps/{app_id}`
        /// </param>
        /// <param name="stream">The stream to upload. See remarks for further information.</param>
        /// <param name="contentType">The content type of the stream to upload.</param>
        public virtual UploadMediaUpload Upload(Google.Apis.FirebaseAppDistribution.v1.Data.GoogleFirebaseAppdistroV1UploadReleaseRequest body, string app, System.IO.Stream stream, string contentType)
        {
            return new UploadMediaUpload(service, body, app, stream, contentType);
        }

        /// <summary>Upload media upload which supports resumable upload.</summary>
        public class UploadMediaUpload : Google.Apis.Upload.ResumableUpload<Google.Apis.FirebaseAppDistribution.v1.Data.GoogleFirebaseAppdistroV1UploadReleaseRequest, Google.Apis.FirebaseAppDistribution.v1.Data.GoogleLongrunningOperation>
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

            /// <summary>
            /// Required. The name of the app resource. Format: `projects/{project_number}/apps/{app_id}`
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("app", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string App { get; private set; }

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
            public UploadMediaUpload(Google.Apis.Services.IClientService service, Google.Apis.FirebaseAppDistribution.v1.Data.GoogleFirebaseAppdistroV1UploadReleaseRequest body, string app, System.IO.Stream stream, string contentType)
                : base(service, string.Format("/{0}/{1}{2}", "upload", service.BasePath, "v1/{+app}/releases:upload"), "POST", stream, contentType)
            {
                App = app;
                Body = body;
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
            Apps = new AppsResource(service);
            Groups = new GroupsResource(service);
            Testers = new TestersResource(service);
        }

        /// <summary>Gets the Apps resource.</summary>
        public virtual AppsResource Apps { get; }

        /// <summary>The "apps" collection of methods.</summary>
        public class AppsResource
        {
            private const string Resource = "apps";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AppsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Releases = new ReleasesResource(service);
            }

            /// <summary>Gets the Releases resource.</summary>
            public virtual ReleasesResource Releases { get; }

            /// <summary>The "releases" collection of methods.</summary>
            public class ReleasesResource
            {
                private const string Resource = "releases";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ReleasesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    FeedbackReports = new FeedbackReportsResource(service);
                    Operations = new OperationsResource(service);
                }

                /// <summary>Gets the FeedbackReports resource.</summary>
                public virtual FeedbackReportsResource FeedbackReports { get; }

                /// <summary>The "feedbackReports" collection of methods.</summary>
                public class FeedbackReportsResource
                {
                    private const string Resource = "feedbackReports";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public FeedbackReportsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Deletes a feedback report.</summary>
                    /// <param name="name">
                    /// Required. The name of the feedback report to delete. Format:
                    /// projects/{project_number}/apps/{app}/releases/{release}/feedbackReports/{feedback_report}
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Deletes a feedback report.</summary>
                    public class DeleteRequest : FirebaseAppDistributionBaseServiceRequest<Google.Apis.FirebaseAppDistribution.v1.Data.GoogleProtobufEmpty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the feedback report to delete. Format:
                        /// projects/{project_number}/apps/{app}/releases/{release}/feedbackReports/{feedback_report}
                        /// </summary>
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
                                Pattern = @"^projects/[^/]+/apps/[^/]+/releases/[^/]+/feedbackReports/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets a feedback report.</summary>
                    /// <param name="name">
                    /// Required. The name of the feedback report to retrieve. Format:
                    /// projects/{project_number}/apps/{app}/releases/{release}/feedbackReports/{feedback_report}
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets a feedback report.</summary>
                    public class GetRequest : FirebaseAppDistributionBaseServiceRequest<Google.Apis.FirebaseAppDistribution.v1.Data.GoogleFirebaseAppdistroV1FeedbackReport>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the feedback report to retrieve. Format:
                        /// projects/{project_number}/apps/{app}/releases/{release}/feedbackReports/{feedback_report}
                        /// </summary>
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
                                Pattern = @"^projects/[^/]+/apps/[^/]+/releases/[^/]+/feedbackReports/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Lists feedback reports. By default, sorts by `createTime` in descending order.
                    /// </summary>
                    /// <param name="parent">
                    /// Required. The name of the release resource, which is the parent of the feedback report
                    /// resources. Format: `projects/{project_number}/apps/{app}/releases/{release}`
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>
                    /// Lists feedback reports. By default, sorts by `createTime` in descending order.
                    /// </summary>
                    public class ListRequest : FirebaseAppDistributionBaseServiceRequest<Google.Apis.FirebaseAppDistribution.v1.Data.GoogleFirebaseAppdistroV1ListFeedbackReportsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the release resource, which is the parent of the feedback report
                        /// resources. Format: `projects/{project_number}/apps/{app}/releases/{release}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Output only. The maximum number of feedback reports to return. The service may return fewer
                        /// than this value. The valid range is [1-100]; If unspecified (0), at most 25 feedback reports
                        /// are returned. Values above 100 are coerced to 100.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Output only. A page token, received from a previous `ListFeedbackReports` call. Provide this
                        /// to retrieve the subsequent page. When paginating, all other parameters provided to
                        /// `ListFeedbackReports` must match the call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/feedbackReports";

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
                                Pattern = @"^projects/[^/]+/apps/[^/]+/releases/[^/]+$",
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
                    /// cancel the operation, but success is not guaranteed. If the server doesn't support this method,
                    /// it returns `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other
                    /// methods to check whether the cancellation succeeded or whether the operation completed despite
                    /// cancellation. On successful cancellation, the operation is not deleted; instead, it becomes an
                    /// operation with an Operation.error value with a google.rpc.Status.code of `1`, corresponding to
                    /// `Code.CANCELLED`.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">The name of the operation resource to be cancelled.</param>
                    public virtual CancelRequest Cancel(Google.Apis.FirebaseAppDistribution.v1.Data.GoogleLongrunningCancelOperationRequest body, string name)
                    {
                        return new CancelRequest(this.service, body, name);
                    }

                    /// <summary>
                    /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to
                    /// cancel the operation, but success is not guaranteed. If the server doesn't support this method,
                    /// it returns `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other
                    /// methods to check whether the cancellation succeeded or whether the operation completed despite
                    /// cancellation. On successful cancellation, the operation is not deleted; instead, it becomes an
                    /// operation with an Operation.error value with a google.rpc.Status.code of `1`, corresponding to
                    /// `Code.CANCELLED`.
                    /// </summary>
                    public class CancelRequest : FirebaseAppDistributionBaseServiceRequest<Google.Apis.FirebaseAppDistribution.v1.Data.GoogleProtobufEmpty>
                    {
                        /// <summary>Constructs a new Cancel request.</summary>
                        public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseAppDistribution.v1.Data.GoogleLongrunningCancelOperationRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>The name of the operation resource to be cancelled.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.FirebaseAppDistribution.v1.Data.GoogleLongrunningCancelOperationRequest Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/apps/[^/]+/releases/[^/]+/operations/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Deletes a long-running operation. This method indicates that the client is no longer interested
                    /// in the operation result. It does not cancel the operation. If the server doesn't support this
                    /// method, it returns `google.rpc.Code.UNIMPLEMENTED`.
                    /// </summary>
                    /// <param name="name">The name of the operation resource to be deleted.</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>
                    /// Deletes a long-running operation. This method indicates that the client is no longer interested
                    /// in the operation result. It does not cancel the operation. If the server doesn't support this
                    /// method, it returns `google.rpc.Code.UNIMPLEMENTED`.
                    /// </summary>
                    public class DeleteRequest : FirebaseAppDistributionBaseServiceRequest<Google.Apis.FirebaseAppDistribution.v1.Data.GoogleProtobufEmpty>
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
                                Pattern = @"^projects/[^/]+/apps/[^/]+/releases/[^/]+/operations/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Gets the latest state of a long-running operation. Clients can use this method to poll the
                    /// operation result at intervals as recommended by the API service.
                    /// </summary>
                    /// <param name="name">The name of the operation resource.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>
                    /// Gets the latest state of a long-running operation. Clients can use this method to poll the
                    /// operation result at intervals as recommended by the API service.
                    /// </summary>
                    public class GetRequest : FirebaseAppDistributionBaseServiceRequest<Google.Apis.FirebaseAppDistribution.v1.Data.GoogleLongrunningOperation>
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
                                Pattern = @"^projects/[^/]+/apps/[^/]+/releases/[^/]+/operations/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Lists operations that match the specified filter in the request. If the server doesn't support
                    /// this method, it returns `UNIMPLEMENTED`.
                    /// </summary>
                    /// <param name="name">The name of the operation's parent resource.</param>
                    public virtual ListRequest List(string name)
                    {
                        return new ListRequest(this.service, name);
                    }

                    /// <summary>
                    /// Lists operations that match the specified filter in the request. If the server doesn't support
                    /// this method, it returns `UNIMPLEMENTED`.
                    /// </summary>
                    public class ListRequest : FirebaseAppDistributionBaseServiceRequest<Google.Apis.FirebaseAppDistribution.v1.Data.GoogleLongrunningListOperationsResponse>
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
                        public override string RestPath => "v1/{+name}/operations";

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
                                Pattern = @"^projects/[^/]+/apps/[^/]+/releases/[^/]+$",
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
                    /// `google.rpc.Code.UNIMPLEMENTED`. Note that this method is on a best-effort basis. It may return
                    /// the latest state before the specified timeout (including immediately), meaning even an immediate
                    /// response is no guarantee that the operation is done.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">The name of the operation resource to wait on.</param>
                    public virtual WaitRequest Wait(Google.Apis.FirebaseAppDistribution.v1.Data.GoogleLongrunningWaitOperationRequest body, string name)
                    {
                        return new WaitRequest(this.service, body, name);
                    }

                    /// <summary>
                    /// Waits until the specified long-running operation is done or reaches at most a specified timeout,
                    /// returning the latest state. If the operation is already done, the latest state is immediately
                    /// returned. If the timeout specified is greater than the default HTTP/RPC timeout, the HTTP/RPC
                    /// timeout is used. If the server does not support this method, it returns
                    /// `google.rpc.Code.UNIMPLEMENTED`. Note that this method is on a best-effort basis. It may return
                    /// the latest state before the specified timeout (including immediately), meaning even an immediate
                    /// response is no guarantee that the operation is done.
                    /// </summary>
                    public class WaitRequest : FirebaseAppDistributionBaseServiceRequest<Google.Apis.FirebaseAppDistribution.v1.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new Wait request.</summary>
                        public WaitRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseAppDistribution.v1.Data.GoogleLongrunningWaitOperationRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>The name of the operation resource to wait on.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.FirebaseAppDistribution.v1.Data.GoogleLongrunningWaitOperationRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "wait";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:wait";

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
                                Pattern = @"^projects/[^/]+/apps/[^/]+/releases/[^/]+/operations/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>Deletes releases. A maximum of 100 releases can be deleted per request.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The name of the app resource, which is the parent of the release resources. Format:
                /// `projects/{project_number}/apps/{app_id}`
                /// </param>
                public virtual BatchDeleteRequest BatchDelete(Google.Apis.FirebaseAppDistribution.v1.Data.GoogleFirebaseAppdistroV1BatchDeleteReleasesRequest body, string parent)
                {
                    return new BatchDeleteRequest(this.service, body, parent);
                }

                /// <summary>Deletes releases. A maximum of 100 releases can be deleted per request.</summary>
                public class BatchDeleteRequest : FirebaseAppDistributionBaseServiceRequest<Google.Apis.FirebaseAppDistribution.v1.Data.GoogleProtobufEmpty>
                {
                    /// <summary>Constructs a new BatchDelete request.</summary>
                    public BatchDeleteRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseAppDistribution.v1.Data.GoogleFirebaseAppdistroV1BatchDeleteReleasesRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the app resource, which is the parent of the release resources. Format:
                    /// `projects/{project_number}/apps/{app_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.FirebaseAppDistribution.v1.Data.GoogleFirebaseAppdistroV1BatchDeleteReleasesRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "batchDelete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/releases:batchDelete";

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
                            Pattern = @"^projects/[^/]+/apps/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Distributes a release to testers. This call does the following: 1. Creates testers for the specified
                /// emails, if none exist. 2. Adds the testers and groups to the release. 3. Sends new testers an
                /// invitation email. 4. Sends existing testers a new release email. The request will fail with a
                /// `INVALID_ARGUMENT` if it contains a group that doesn't exist.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The name of the release resource to distribute. Format:
                /// `projects/{project_number}/apps/{app_id}/releases/{release_id}`
                /// </param>
                public virtual DistributeRequest Distribute(Google.Apis.FirebaseAppDistribution.v1.Data.GoogleFirebaseAppdistroV1DistributeReleaseRequest body, string name)
                {
                    return new DistributeRequest(this.service, body, name);
                }

                /// <summary>
                /// Distributes a release to testers. This call does the following: 1. Creates testers for the specified
                /// emails, if none exist. 2. Adds the testers and groups to the release. 3. Sends new testers an
                /// invitation email. 4. Sends existing testers a new release email. The request will fail with a
                /// `INVALID_ARGUMENT` if it contains a group that doesn't exist.
                /// </summary>
                public class DistributeRequest : FirebaseAppDistributionBaseServiceRequest<Google.Apis.FirebaseAppDistribution.v1.Data.GoogleFirebaseAppdistroV1DistributeReleaseResponse>
                {
                    /// <summary>Constructs a new Distribute request.</summary>
                    public DistributeRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseAppDistribution.v1.Data.GoogleFirebaseAppdistroV1DistributeReleaseRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the release resource to distribute. Format:
                    /// `projects/{project_number}/apps/{app_id}/releases/{release_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.FirebaseAppDistribution.v1.Data.GoogleFirebaseAppdistroV1DistributeReleaseRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "distribute";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:distribute";

                    /// <summary>Initializes Distribute parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/apps/[^/]+/releases/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets a release.</summary>
                /// <param name="name">
                /// Required. The name of the release resource to retrieve. Format:
                /// projects/{project_number}/apps/{app_id}/releases/{release_id}
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets a release.</summary>
                public class GetRequest : FirebaseAppDistributionBaseServiceRequest<Google.Apis.FirebaseAppDistribution.v1.Data.GoogleFirebaseAppdistroV1Release>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the release resource to retrieve. Format:
                    /// projects/{project_number}/apps/{app_id}/releases/{release_id}
                    /// </summary>
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
                            Pattern = @"^projects/[^/]+/apps/[^/]+/releases/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists releases. By default, sorts by `createTime` in descending order.</summary>
                /// <param name="parent">
                /// Required. The name of the app resource, which is the parent of the release resources. Format:
                /// `projects/{project_number}/apps/{app_id}`
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists releases. By default, sorts by `createTime` in descending order.</summary>
                public class ListRequest : FirebaseAppDistributionBaseServiceRequest<Google.Apis.FirebaseAppDistribution.v1.Data.GoogleFirebaseAppdistroV1ListReleasesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the app resource, which is the parent of the release resources. Format:
                    /// `projects/{project_number}/apps/{app_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. The expression to filter releases listed in the response. To learn more about
                    /// filtering, refer to [Google's AIP-160 standard](http://aip.dev/160). Supported fields: -
                    /// `releaseNotes.text` supports `=` (can contain a wildcard character (`*`) at the beginning or end
                    /// of the string) - `createTime` supports `&amp;lt;`, `&amp;lt;=`, `&amp;gt;` and `&amp;gt;=`, and
                    /// expects an RFC-3339 formatted string Examples: - `createTime &amp;lt;=
                    /// "2021-09-08T00:00:00+04:00"` - `releaseNotes.text="fixes" AND createTime &amp;gt;=
                    /// "2021-09-08T00:00:00.0Z"` - `releaseNotes.text="*v1.0.0-rc*"`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Optional. The fields used to order releases. Supported fields: - `createTime` To specify
                    /// descending order for a field, append a "desc" suffix, for example, `createTime desc`. If this
                    /// parameter is not set, releases are ordered by `createTime` in descending order.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Optional. The maximum number of releases to return. The service may return fewer than this
                    /// value. The valid range is [1-100]; If unspecified (0), at most 25 releases are returned. Values
                    /// above 100 are coerced to 100.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A page token, received from a previous `ListReleases` call. Provide this to retrieve
                    /// the subsequent page. When paginating, all other parameters provided to `ListReleases` must match
                    /// the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/releases";

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
                            Pattern = @"^projects/[^/]+/apps/[^/]+$",
                        });
                        RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filter",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("orderBy", new Google.Apis.Discovery.Parameter
                        {
                            Name = "orderBy",
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

                /// <summary>Updates a release.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The name of the release resource. Format:
                /// `projects/{project_number}/apps/{app_id}/releases/{release_id}`
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.FirebaseAppDistribution.v1.Data.GoogleFirebaseAppdistroV1Release body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates a release.</summary>
                public class PatchRequest : FirebaseAppDistributionBaseServiceRequest<Google.Apis.FirebaseAppDistribution.v1.Data.GoogleFirebaseAppdistroV1Release>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseAppDistribution.v1.Data.GoogleFirebaseAppdistroV1Release body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The name of the release resource. Format:
                    /// `projects/{project_number}/apps/{app_id}/releases/{release_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Optional. The list of fields to update.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.FirebaseAppDistribution.v1.Data.GoogleFirebaseAppdistroV1Release Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}";

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
                            Pattern = @"^projects/[^/]+/apps/[^/]+/releases/[^/]+$",
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

            /// <summary>Gets Android App Bundle (AAB) information for a Firebase app.</summary>
            /// <param name="name">
            /// Required. The name of the `AabInfo` resource to retrieve. Format:
            /// `projects/{project_number}/apps/{app_id}/aabInfo`
            /// </param>
            public virtual GetAabInfoRequest GetAabInfo(string name)
            {
                return new GetAabInfoRequest(this.service, name);
            }

            /// <summary>Gets Android App Bundle (AAB) information for a Firebase app.</summary>
            public class GetAabInfoRequest : FirebaseAppDistributionBaseServiceRequest<Google.Apis.FirebaseAppDistribution.v1.Data.GoogleFirebaseAppdistroV1AabInfo>
            {
                /// <summary>Constructs a new GetAabInfo request.</summary>
                public GetAabInfoRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the `AabInfo` resource to retrieve. Format:
                /// `projects/{project_number}/apps/{app_id}/aabInfo`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getAabInfo";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes GetAabInfo parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/apps/[^/]+/aabInfo$",
                    });
                }
            }
        }

        /// <summary>Gets the Groups resource.</summary>
        public virtual GroupsResource Groups { get; }

        /// <summary>The "groups" collection of methods.</summary>
        public class GroupsResource
        {
            private const string Resource = "groups";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public GroupsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Batch adds members to a group. The testers will gain access to all releases that the groups have access
            /// to.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="group">
            /// Required. The name of the group resource to which testers are added. Format:
            /// `projects/{project_number}/groups/{group_alias}`
            /// </param>
            public virtual BatchJoinRequest BatchJoin(Google.Apis.FirebaseAppDistribution.v1.Data.GoogleFirebaseAppdistroV1BatchJoinGroupRequest body, string group)
            {
                return new BatchJoinRequest(this.service, body, group);
            }

            /// <summary>
            /// Batch adds members to a group. The testers will gain access to all releases that the groups have access
            /// to.
            /// </summary>
            public class BatchJoinRequest : FirebaseAppDistributionBaseServiceRequest<Google.Apis.FirebaseAppDistribution.v1.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new BatchJoin request.</summary>
                public BatchJoinRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseAppDistribution.v1.Data.GoogleFirebaseAppdistroV1BatchJoinGroupRequest body, string group) : base(service)
                {
                    Group = group;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the group resource to which testers are added. Format:
                /// `projects/{project_number}/groups/{group_alias}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("group", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Group { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.FirebaseAppDistribution.v1.Data.GoogleFirebaseAppdistroV1BatchJoinGroupRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "batchJoin";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+group}:batchJoin";

                /// <summary>Initializes BatchJoin parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("group", new Google.Apis.Discovery.Parameter
                    {
                        Name = "group",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/groups/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Batch removed members from a group. The testers will lose access to all releases that the groups have
            /// access to.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="group">
            /// Required. The name of the group resource from which testers are removed. Format:
            /// `projects/{project_number}/groups/{group_alias}`
            /// </param>
            public virtual BatchLeaveRequest BatchLeave(Google.Apis.FirebaseAppDistribution.v1.Data.GoogleFirebaseAppdistroV1BatchLeaveGroupRequest body, string group)
            {
                return new BatchLeaveRequest(this.service, body, group);
            }

            /// <summary>
            /// Batch removed members from a group. The testers will lose access to all releases that the groups have
            /// access to.
            /// </summary>
            public class BatchLeaveRequest : FirebaseAppDistributionBaseServiceRequest<Google.Apis.FirebaseAppDistribution.v1.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new BatchLeave request.</summary>
                public BatchLeaveRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseAppDistribution.v1.Data.GoogleFirebaseAppdistroV1BatchLeaveGroupRequest body, string group) : base(service)
                {
                    Group = group;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the group resource from which testers are removed. Format:
                /// `projects/{project_number}/groups/{group_alias}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("group", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Group { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.FirebaseAppDistribution.v1.Data.GoogleFirebaseAppdistroV1BatchLeaveGroupRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "batchLeave";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+group}:batchLeave";

                /// <summary>Initializes BatchLeave parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("group", new Google.Apis.Discovery.Parameter
                    {
                        Name = "group",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/groups/[^/]+$",
                    });
                }
            }

            /// <summary>Create a group.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The name of the project resource, which is the parent of the group resource. Format:
            /// `projects/{project_number}`
            /// </param>
            public virtual CreateRequest Create(Google.Apis.FirebaseAppDistribution.v1.Data.GoogleFirebaseAppdistroV1Group body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>Create a group.</summary>
            public class CreateRequest : FirebaseAppDistributionBaseServiceRequest<Google.Apis.FirebaseAppDistribution.v1.Data.GoogleFirebaseAppdistroV1Group>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseAppDistribution.v1.Data.GoogleFirebaseAppdistroV1Group body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the project resource, which is the parent of the group resource. Format:
                /// `projects/{project_number}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. The "alias" to use for the group, which will become the final component of the group's
                /// resource name. This value must be unique per project. The field is named `groupId` to comply with
                /// AIP guidance for user-specified IDs. This value should be 4-63 characters, and valid characters are
                /// `/a-z-/`. If not set, it will be generated based on the display name.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("groupId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string GroupId { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.FirebaseAppDistribution.v1.Data.GoogleFirebaseAppdistroV1Group Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/groups";

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
                    RequestParameters.Add("groupId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "groupId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Delete a group.</summary>
            /// <param name="name">
            /// Required. The name of the group resource. Format: `projects/{project_number}/groups/{group_alias}`
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>Delete a group.</summary>
            public class DeleteRequest : FirebaseAppDistributionBaseServiceRequest<Google.Apis.FirebaseAppDistribution.v1.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the group resource. Format: `projects/{project_number}/groups/{group_alias}`
                /// </summary>
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
                        Pattern = @"^projects/[^/]+/groups/[^/]+$",
                    });
                }
            }

            /// <summary>Get a group.</summary>
            /// <param name="name">
            /// Required. The name of the group resource to retrieve. Format:
            /// `projects/{project_number}/groups/{group_alias}`
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Get a group.</summary>
            public class GetRequest : FirebaseAppDistributionBaseServiceRequest<Google.Apis.FirebaseAppDistribution.v1.Data.GoogleFirebaseAppdistroV1Group>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the group resource to retrieve. Format:
                /// `projects/{project_number}/groups/{group_alias}`
                /// </summary>
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
                        Pattern = @"^projects/[^/]+/groups/[^/]+$",
                    });
                }
            }

            /// <summary>List groups.</summary>
            /// <param name="parent">
            /// Required. The name of the project resource, which is the parent of the group resources. Format:
            /// `projects/{project_number}`
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>List groups.</summary>
            public class ListRequest : FirebaseAppDistributionBaseServiceRequest<Google.Apis.FirebaseAppDistribution.v1.Data.GoogleFirebaseAppdistroV1ListGroupsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the project resource, which is the parent of the group resources. Format:
                /// `projects/{project_number}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. The maximum number of groups to return. The service may return fewer than this value. The
                /// valid range is [1-1000]; If unspecified (0), at most 25 groups are returned. Values above 1000 are
                /// coerced to 1000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. A page token, received from a previous `ListGroups` call. Provide this to retrieve the
                /// subsequent page. When paginating, all other parameters provided to `ListGroups` must match the call
                /// that provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/groups";

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

            /// <summary>Update a group.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// The name of the group resource. Format: `projects/{project_number}/groups/{group_alias}`
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.FirebaseAppDistribution.v1.Data.GoogleFirebaseAppdistroV1Group body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>Update a group.</summary>
            public class PatchRequest : FirebaseAppDistributionBaseServiceRequest<Google.Apis.FirebaseAppDistribution.v1.Data.GoogleFirebaseAppdistroV1Group>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseAppDistribution.v1.Data.GoogleFirebaseAppdistroV1Group body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The name of the group resource. Format: `projects/{project_number}/groups/{group_alias}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Optional. The list of fields to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.FirebaseAppDistribution.v1.Data.GoogleFirebaseAppdistroV1Group Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

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
                        Pattern = @"^projects/[^/]+/groups/[^/]+$",
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

            /// <summary>
            /// Batch adds testers. This call adds testers for the specified emails if they don't already exist. Returns
            /// all testers specified in the request, including newly created and previously existing testers. This
            /// action is idempotent.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="project">
            /// Required. The name of the project resource. Format: `projects/{project_number}`
            /// </param>
            public virtual BatchAddRequest BatchAdd(Google.Apis.FirebaseAppDistribution.v1.Data.GoogleFirebaseAppdistroV1BatchAddTestersRequest body, string project)
            {
                return new BatchAddRequest(this.service, body, project);
            }

            /// <summary>
            /// Batch adds testers. This call adds testers for the specified emails if they don't already exist. Returns
            /// all testers specified in the request, including newly created and previously existing testers. This
            /// action is idempotent.
            /// </summary>
            public class BatchAddRequest : FirebaseAppDistributionBaseServiceRequest<Google.Apis.FirebaseAppDistribution.v1.Data.GoogleFirebaseAppdistroV1BatchAddTestersResponse>
            {
                /// <summary>Constructs a new BatchAdd request.</summary>
                public BatchAddRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseAppDistribution.v1.Data.GoogleFirebaseAppdistroV1BatchAddTestersRequest body, string project) : base(service)
                {
                    Project = project;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The name of the project resource. Format: `projects/{project_number}`</summary>
                [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Project { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.FirebaseAppDistribution.v1.Data.GoogleFirebaseAppdistroV1BatchAddTestersRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "batchAdd";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+project}/testers:batchAdd";

                /// <summary>Initializes BatchAdd parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                    {
                        Name = "project",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Batch removes testers. If found, this call deletes testers for the specified emails. Returns all deleted
            /// testers.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="project">
            /// Required. The name of the project resource. Format: `projects/{project_number}`
            /// </param>
            public virtual BatchRemoveRequest BatchRemove(Google.Apis.FirebaseAppDistribution.v1.Data.GoogleFirebaseAppdistroV1BatchRemoveTestersRequest body, string project)
            {
                return new BatchRemoveRequest(this.service, body, project);
            }

            /// <summary>
            /// Batch removes testers. If found, this call deletes testers for the specified emails. Returns all deleted
            /// testers.
            /// </summary>
            public class BatchRemoveRequest : FirebaseAppDistributionBaseServiceRequest<Google.Apis.FirebaseAppDistribution.v1.Data.GoogleFirebaseAppdistroV1BatchRemoveTestersResponse>
            {
                /// <summary>Constructs a new BatchRemove request.</summary>
                public BatchRemoveRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseAppDistribution.v1.Data.GoogleFirebaseAppdistroV1BatchRemoveTestersRequest body, string project) : base(service)
                {
                    Project = project;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The name of the project resource. Format: `projects/{project_number}`</summary>
                [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Project { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.FirebaseAppDistribution.v1.Data.GoogleFirebaseAppdistroV1BatchRemoveTestersRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "batchRemove";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+project}/testers:batchRemove";

                /// <summary>Initializes BatchRemove parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                    {
                        Name = "project",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+$",
                    });
                }
            }

            /// <summary>Lists testers and their resource ids.</summary>
            /// <param name="parent">
            /// Required. The name of the project resource, which is the parent of the tester resources. Format:
            /// `projects/{project_number}`
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Lists testers and their resource ids.</summary>
            public class ListRequest : FirebaseAppDistributionBaseServiceRequest<Google.Apis.FirebaseAppDistribution.v1.Data.GoogleFirebaseAppdistroV1ListTestersResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the project resource, which is the parent of the tester resources. Format:
                /// `projects/{project_number}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. The expression to filter testers listed in the response. To learn more about filtering,
                /// refer to [Google's AIP-160 standard](http://aip.dev/160). Supported fields: - `name` - `displayName`
                /// - `groups` Example: - `name = "projects/-/testers/*@example.com"` - `displayName = "Joe Sixpack"` -
                /// `groups = "projects/*/groups/qa-team"`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// Optional. The maximum number of testers to return. The service may return fewer than this value. The
                /// valid range is [1-1000]; If unspecified (0), at most 10 testers are returned. Values above 1000 are
                /// coerced to 1000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. A page token, received from a previous `ListTesters` call. Provide this to retrieve the
                /// subsequent page. When paginating, all other parameters provided to `ListTesters` must match the call
                /// that provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/testers";

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

            /// <summary>
            /// Update a tester. If the testers joins a group they gain access to all releases that the group has access
            /// to.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// The name of the tester resource. Format: `projects/{project_number}/testers/{email_address}`
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.FirebaseAppDistribution.v1.Data.GoogleFirebaseAppdistroV1Tester body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>
            /// Update a tester. If the testers joins a group they gain access to all releases that the group has access
            /// to.
            /// </summary>
            public class PatchRequest : FirebaseAppDistributionBaseServiceRequest<Google.Apis.FirebaseAppDistribution.v1.Data.GoogleFirebaseAppdistroV1Tester>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseAppDistribution.v1.Data.GoogleFirebaseAppdistroV1Tester body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The name of the tester resource. Format: `projects/{project_number}/testers/{email_address}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Optional. The list of fields to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.FirebaseAppDistribution.v1.Data.GoogleFirebaseAppdistroV1Tester Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

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
                        Pattern = @"^projects/[^/]+/testers/[^/]+$",
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
    }
}
namespace Google.Apis.FirebaseAppDistribution.v1.Data
{
    /// <summary>Information to read/write to blobstore2.</summary>
    public class GdataBlobstore2Info : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The blob generation id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blobGeneration")]
        public virtual System.Nullable<long> BlobGeneration { get; set; }

        /// <summary>The blob id, e.g., /blobstore/prod/playground/scotty</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blobId")]
        public virtual string BlobId { get; set; }

        /// <summary>
        /// Read handle passed from Bigstore -&amp;gt; Scotty for a GCS download. This is a signed, serialized
        /// blobstore2.ReadHandle proto which must never be set outside of Bigstore, and is not applicable to non-GCS
        /// media downloads.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("downloadReadHandle")]
        public virtual string DownloadReadHandle { get; set; }

        /// <summary>
        /// The blob read token. Needed to read blobs that have not been replicated. Might not be available until the
        /// final call.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readToken")]
        public virtual string ReadToken { get; set; }

        /// <summary>
        /// Metadata passed from Blobstore -&amp;gt; Scotty for a new GCS upload. This is a signed, serialized
        /// blobstore2.BlobMetadataContainer proto which must never be consumed outside of Bigstore, and is not
        /// applicable to non-GCS media uploads.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uploadMetadataContainer")]
        public virtual string UploadMetadataContainer { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A sequence of media data references representing composite data. Introduced to support Bigstore composite
    /// objects. For details, visit http://go/bigstore-composites.
    /// </summary>
    public class GdataCompositeMedia : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Blobstore v1 reference, set if reference_type is BLOBSTORE_REF This should be the byte representation of a
        /// blobstore.BlobRef. Since Blobstore is deprecating v1, use blobstore2_info instead. For now, any v2 blob will
        /// also be represented in this field as v1 BlobRef.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blobRef")]
        public virtual string BlobRef { get; set; }

        /// <summary>Blobstore v2 info, set if reference_type is BLOBSTORE_REF and it refers to a v2 blob.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blobstore2Info")]
        public virtual GdataBlobstore2Info Blobstore2Info { get; set; }

        /// <summary>
        /// A binary data reference for a media download. Serves as a technology-agnostic binary reference in some
        /// Google infrastructure. This value is a serialized storage_cosmo.BinaryReference proto. Storing it as bytes
        /// is a hack to get around the fact that the cosmo proto (as well as others it includes) doesn't support
        /// JavaScript. This prevents us from including the actual type of this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cosmoBinaryReference")]
        public virtual string CosmoBinaryReference { get; set; }

        /// <summary>crc32.c hash for the payload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crc32cHash")]
        public virtual System.Nullable<long> Crc32cHash { get; set; }

        /// <summary>Media data, set if reference_type is INLINE</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inline")]
        public virtual string Inline { get; set; }

        /// <summary>Size of the data, in bytes</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("length")]
        public virtual System.Nullable<long> Length { get; set; }

        /// <summary>MD5 hash for the payload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("md5Hash")]
        public virtual string Md5Hash { get; set; }

        /// <summary>Reference to a TI Blob, set if reference_type is BIGSTORE_REF.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual GdataObjectId ObjectId { get; set; }

        /// <summary>Path to the data, set if reference_type is PATH</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>Describes what the field reference contains.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referenceType")]
        public virtual string ReferenceType { get; set; }

        /// <summary>SHA-1 hash for the payload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sha1Hash")]
        public virtual string Sha1Hash { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Detailed Content-Type information from Scotty. The Content-Type of the media will typically be filled in by the
    /// header or Scotty's best_guess, but this extended information provides the backend with more information so that
    /// it can make a better decision if needed. This is only used on media upload requests from Scotty.
    /// </summary>
    public class GdataContentTypeInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Scotty's best guess of what the content type of the file is.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bestGuess")]
        public virtual string BestGuess { get; set; }

        /// <summary>
        /// The content type of the file derived by looking at specific bytes (i.e. "magic bytes") of the actual file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fromBytes")]
        public virtual string FromBytes { get; set; }

        /// <summary>
        /// The content type of the file derived from the file extension of the original file name used by the client.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fromFileName")]
        public virtual string FromFileName { get; set; }

        /// <summary>
        /// The content type of the file as specified in the request headers, multipart headers, or RUPIO start request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fromHeader")]
        public virtual string FromHeader { get; set; }

        /// <summary>
        /// The content type of the file derived from the file extension of the URL path. The URL path is assumed to
        /// represent a file name (which is typically only true for agents that are providing a REST API).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fromUrlPath")]
        public virtual string FromUrlPath { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Backend response for a Diff get checksums response. For details on the Scotty Diff protocol, visit
    /// http://go/scotty-diff-protocol.
    /// </summary>
    public class GdataDiffChecksumsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Exactly one of these fields must be populated. If checksums_location is filled, the server will return the
        /// corresponding contents to the user. If object_location is filled, the server will calculate the checksums
        /// based on the content there and return that to the user. For details on the format of the checksums, see
        /// http://go/scotty-diff-protocol.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("checksumsLocation")]
        public virtual GdataCompositeMedia ChecksumsLocation { get; set; }

        /// <summary>The chunk size of checksums. Must be a multiple of 256KB.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chunkSizeBytes")]
        public virtual System.Nullable<long> ChunkSizeBytes { get; set; }

        /// <summary>If set, calculate the checksums based on the contents and return them to the caller.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectLocation")]
        public virtual GdataCompositeMedia ObjectLocation { get; set; }

        /// <summary>The total size of the server object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectSizeBytes")]
        public virtual System.Nullable<long> ObjectSizeBytes { get; set; }

        /// <summary>The object version of the object the checksums are being returned for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectVersion")]
        public virtual string ObjectVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Backend response for a Diff download response. For details on the Scotty Diff protocol, visit
    /// http://go/scotty-diff-protocol.
    /// </summary>
    public class GdataDiffDownloadResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The original object location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectLocation")]
        public virtual GdataCompositeMedia ObjectLocation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A Diff upload request. For details on the Scotty Diff protocol, visit http://go/scotty-diff-protocol.
    /// </summary>
    public class GdataDiffUploadRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The location of the checksums for the new object. Agents must clone the object located here, as the upload
        /// server will delete the contents once a response is received. For details on the format of the checksums, see
        /// http://go/scotty-diff-protocol.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("checksumsInfo")]
        public virtual GdataCompositeMedia ChecksumsInfo { get; set; }

        /// <summary>
        /// The location of the new object. Agents must clone the object located here, as the upload server will delete
        /// the contents once a response is received.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectInfo")]
        public virtual GdataCompositeMedia ObjectInfo { get; set; }

        /// <summary>
        /// The object version of the object that is the base version the incoming diff script will be applied to. This
        /// field will always be filled in.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectVersion")]
        public virtual string ObjectVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Backend response for a Diff upload request. For details on the Scotty Diff protocol, visit
    /// http://go/scotty-diff-protocol.
    /// </summary>
    public class GdataDiffUploadResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The object version of the object at the server. Must be included in the end notification response. The
        /// version in the end notification response must correspond to the new version of the object that is now stored
        /// at the server, after the upload.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectVersion")]
        public virtual string ObjectVersion { get; set; }

        /// <summary>
        /// The location of the original file for a diff upload request. Must be filled in if responding to an upload
        /// start notification.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalObject")]
        public virtual GdataCompositeMedia OriginalObject { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Backend response for a Diff get version response. For details on the Scotty Diff protocol, visit
    /// http://go/scotty-diff-protocol.
    /// </summary>
    public class GdataDiffVersionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The total size of the server object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectSizeBytes")]
        public virtual System.Nullable<long> ObjectSizeBytes { get; set; }

        /// <summary>The version of the object stored at the server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectVersion")]
        public virtual string ObjectVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Parameters specific to media downloads.</summary>
    public class GdataDownloadParameters : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A boolean to be returned in the response to Scotty. Allows/disallows gzip encoding of the payload content
        /// when the server thinks it's advantageous (hence, does not guarantee compression) which allows Scotty to GZip
        /// the response to the client.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowGzipCompression")]
        public virtual System.Nullable<bool> AllowGzipCompression { get; set; }

        /// <summary>
        /// Determining whether or not Apiary should skip the inclusion of any Content-Range header on its response to
        /// Scotty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ignoreRange")]
        public virtual System.Nullable<bool> IgnoreRange { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A reference to data stored on the filesystem, on GFS or in blobstore.</summary>
    public class GdataMedia : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Deprecated, use one of explicit hash type fields instead. Algorithm used for calculating the hash. As of
        /// 2011/01/21, "MD5" is the only possible value for this field. New values may be added at any time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("algorithm")]
        public virtual string Algorithm { get; set; }

        /// <summary>Use object_id instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bigstoreObjectRef")]
        public virtual string BigstoreObjectRef { get; set; }

        /// <summary>
        /// Blobstore v1 reference, set if reference_type is BLOBSTORE_REF This should be the byte representation of a
        /// blobstore.BlobRef. Since Blobstore is deprecating v1, use blobstore2_info instead. For now, any v2 blob will
        /// also be represented in this field as v1 BlobRef.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blobRef")]
        public virtual string BlobRef { get; set; }

        /// <summary>Blobstore v2 info, set if reference_type is BLOBSTORE_REF and it refers to a v2 blob.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blobstore2Info")]
        public virtual GdataBlobstore2Info Blobstore2Info { get; set; }

        /// <summary>
        /// A composite media composed of one or more media objects, set if reference_type is COMPOSITE_MEDIA. The media
        /// length field must be set to the sum of the lengths of all composite media objects. Note: All composite media
        /// must have length specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compositeMedia")]
        public virtual System.Collections.Generic.IList<GdataCompositeMedia> CompositeMedia { get; set; }

        /// <summary>MIME type of the data</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentType")]
        public virtual string ContentType { get; set; }

        /// <summary>Extended content type information provided for Scotty uploads.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentTypeInfo")]
        public virtual GdataContentTypeInfo ContentTypeInfo { get; set; }

        /// <summary>
        /// A binary data reference for a media download. Serves as a technology-agnostic binary reference in some
        /// Google infrastructure. This value is a serialized storage_cosmo.BinaryReference proto. Storing it as bytes
        /// is a hack to get around the fact that the cosmo proto (as well as others it includes) doesn't support
        /// JavaScript. This prevents us from including the actual type of this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cosmoBinaryReference")]
        public virtual string CosmoBinaryReference { get; set; }

        /// <summary>
        /// For Scotty Uploads: Scotty-provided hashes for uploads For Scotty Downloads: (WARNING: DO NOT USE WITHOUT
        /// PERMISSION FROM THE SCOTTY TEAM.) A Hash provided by the agent to be used to verify the data being
        /// downloaded. Currently only supported for inline payloads. Further, only crc32c_hash is currently supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crc32cHash")]
        public virtual System.Nullable<long> Crc32cHash { get; set; }

        /// <summary>Set if reference_type is DIFF_CHECKSUMS_RESPONSE.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diffChecksumsResponse")]
        public virtual GdataDiffChecksumsResponse DiffChecksumsResponse { get; set; }

        /// <summary>Set if reference_type is DIFF_DOWNLOAD_RESPONSE.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diffDownloadResponse")]
        public virtual GdataDiffDownloadResponse DiffDownloadResponse { get; set; }

        /// <summary>Set if reference_type is DIFF_UPLOAD_REQUEST.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diffUploadRequest")]
        public virtual GdataDiffUploadRequest DiffUploadRequest { get; set; }

        /// <summary>Set if reference_type is DIFF_UPLOAD_RESPONSE.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diffUploadResponse")]
        public virtual GdataDiffUploadResponse DiffUploadResponse { get; set; }

        /// <summary>Set if reference_type is DIFF_VERSION_RESPONSE.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diffVersionResponse")]
        public virtual GdataDiffVersionResponse DiffVersionResponse { get; set; }

        /// <summary>Parameters for a media download.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("downloadParameters")]
        public virtual GdataDownloadParameters DownloadParameters { get; set; }

        /// <summary>Original file name</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filename")]
        public virtual string Filename { get; set; }

        /// <summary>
        /// Deprecated, use one of explicit hash type fields instead. These two hash related fields will only be
        /// populated on Scotty based media uploads and will contain the content of the hash group in the
        /// NotificationRequest:
        /// http://cs/#google3/blobstore2/api/scotty/service/proto/upload_listener.proto&amp;amp;q=class:Hash Hex
        /// encoded hash value of the uploaded media.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hash")]
        public virtual string Hash { get; set; }

        /// <summary>
        /// For Scotty uploads only. If a user sends a hash code and the backend has requested that Scotty verify the
        /// upload against the client hash, Scotty will perform the check on behalf of the backend and will reject it if
        /// the hashes don't match. This is set to true if Scotty performed this verification.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hashVerified")]
        public virtual System.Nullable<bool> HashVerified { get; set; }

        /// <summary>Media data, set if reference_type is INLINE</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inline")]
        public virtual string Inline { get; set; }

        /// <summary>
        /// |is_potential_retry| is set false only when Scotty is certain that it has not sent the request before. When
        /// a client resumes an upload, this field must be set true in agent calls, because Scotty cannot be certain
        /// that it has never sent the request before due to potential failure in the session state persistence.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isPotentialRetry")]
        public virtual System.Nullable<bool> IsPotentialRetry { get; set; }

        /// <summary>Size of the data, in bytes</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("length")]
        public virtual System.Nullable<long> Length { get; set; }

        /// <summary>Scotty-provided MD5 hash for an upload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("md5Hash")]
        public virtual string Md5Hash { get; set; }

        /// <summary>Media id to forward to the operation GetMedia. Can be set if reference_type is GET_MEDIA.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mediaId")]
        public virtual string MediaId { get; set; }

        /// <summary>Reference to a TI Blob, set if reference_type is BIGSTORE_REF.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual GdataObjectId ObjectId { get; set; }

        /// <summary>Path to the data, set if reference_type is PATH</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>Describes what the field reference contains.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referenceType")]
        public virtual string ReferenceType { get; set; }

        /// <summary>Scotty-provided SHA1 hash for an upload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sha1Hash")]
        public virtual string Sha1Hash { get; set; }

        /// <summary>Scotty-provided SHA256 hash for an upload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sha256Hash")]
        public virtual string Sha256Hash { get; set; }

        /// <summary>Time at which the media data was last updated, in milliseconds since UNIX epoch</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timestamp")]
        public virtual System.Nullable<ulong> Timestamp { get; set; }

        /// <summary>A unique fingerprint/version id for the media data</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("token")]
        public virtual string Token { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// This is a copy of the tech.blob.ObjectId proto, which could not be used directly here due to transitive closure
    /// issues with JavaScript support; see http://b/8801763.
    /// </summary>
    public class GdataObjectId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the bucket to which this object belongs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucketName")]
        public virtual string BucketName { get; set; }

        /// <summary>
        /// Generation of the object. Generations are monotonically increasing across writes, allowing them to be be
        /// compared to determine which generation is newer. If this is omitted in a request, then you are requesting
        /// the live object. See http://go/bigstore-versions
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generation")]
        public virtual System.Nullable<long> Generation { get; set; }

        /// <summary>The name of the object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectName")]
        public virtual string ObjectName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Android App Bundle (AAB) information for a Firebase app.</summary>
    public class GoogleFirebaseAppdistroV1AabInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>App bundle integration state. Only valid for android apps.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("integrationState")]
        public virtual string IntegrationState { get; set; }

        /// <summary>
        /// The name of the `AabInfo` resource. Format: `projects/{project_number}/apps/{app}/aabInfo`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// App bundle test certificate generated for the app. Set after the first app bundle is uploaded for this app.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testCertificate")]
        public virtual GoogleFirebaseAppdistroV1TestCertificate TestCertificate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The Request message for batch adding testers</summary>
    public class GoogleFirebaseAppdistroV1BatchAddTestersRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The email addresses of the tester resources to create. A maximum of 999 and a minimum of 1 tester
        /// can be created in a batch.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emails")]
        public virtual System.Collections.Generic.IList<string> Emails { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The Response message for `BatchAddTesters`.</summary>
    public class GoogleFirebaseAppdistroV1BatchAddTestersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The testers which are created and/or already exist</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testers")]
        public virtual System.Collections.Generic.IList<GoogleFirebaseAppdistroV1Tester> Testers { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for `BatchDeleteReleases`.</summary>
    public class GoogleFirebaseAppdistroV1BatchDeleteReleasesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The names of the release resources to delete. Format:
        /// `projects/{project_number}/apps/{app_id}/releases/{release_id}` A maximum of 100 releases can be deleted per
        /// request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("names")]
        public virtual System.Collections.Generic.IList<string> Names { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for `BatchJoinGroup`</summary>
    public class GoogleFirebaseAppdistroV1BatchJoinGroupRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicates whether to create tester resources based on `emails` if they don't exist yet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createMissingTesters")]
        public virtual System.Nullable<bool> CreateMissingTesters { get; set; }

        /// <summary>
        /// Required. The emails of the testers to be added to the group. A maximum of 999 and a minimum of 1 tester can
        /// be created in a batch.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emails")]
        public virtual System.Collections.Generic.IList<string> Emails { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for `BatchLeaveGroup`</summary>
    public class GoogleFirebaseAppdistroV1BatchLeaveGroupRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The email addresses of the testers to be removed from the group. A maximum of 999 and a minimum of
        /// 1 testers can be removed in a batch.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emails")]
        public virtual System.Collections.Generic.IList<string> Emails { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for `BatchRemoveTesters`.</summary>
    public class GoogleFirebaseAppdistroV1BatchRemoveTestersRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The email addresses of the tester resources to removed. A maximum of 999 and a minimum of 1
        /// testers can be deleted in a batch.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emails")]
        public virtual System.Collections.Generic.IList<string> Emails { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for `BatchRemoveTesters`</summary>
    public class GoogleFirebaseAppdistroV1BatchRemoveTestersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of deleted tester emails</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emails")]
        public virtual System.Collections.Generic.IList<string> Emails { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for `DistributeRelease`.</summary>
    public class GoogleFirebaseAppdistroV1DistributeReleaseRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A list of group aliases (IDs) to be given access to this release. A combined maximum of 999
        /// `testerEmails` and `groupAliases` can be specified in a single request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupAliases")]
        public virtual System.Collections.Generic.IList<string> GroupAliases { get; set; }

        /// <summary>
        /// Optional. A list of tester email addresses to be given access to this release. A combined maximum of 999
        /// `testerEmails` and `groupAliases` can be specified in a single request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testerEmails")]
        public virtual System.Collections.Generic.IList<string> TesterEmails { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for `DistributeRelease`.</summary>
    public class GoogleFirebaseAppdistroV1DistributeReleaseResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A feedback report submitted by a tester for a release.</summary>
    public class GoogleFirebaseAppdistroV1FeedbackReport : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time when the feedback report was created.</summary>
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

        /// <summary>Output only. A link to the Firebase console displaying the feedback report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firebaseConsoleUri")]
        public virtual string FirebaseConsoleUri { get; set; }

        /// <summary>
        /// The name of the feedback report resource. Format:
        /// `projects/{project_number}/apps/{app}/releases/{release}/feedbackReports/{feedback_report}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. A signed link (which expires in one hour) that lets you directly download the screenshot.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("screenshotUri")]
        public virtual string ScreenshotUri { get; set; }

        /// <summary>Output only. The resource name of the tester who submitted the feedback report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tester")]
        public virtual string Tester { get; set; }

        /// <summary>Output only. The text of the feedback report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A group which can contain testers. A group can be invited to test apps in a Firebase project.</summary>
    public class GoogleFirebaseAppdistroV1Group : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The display name of the group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Output only. The number of invite links for this group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inviteLinkCount")]
        public virtual System.Nullable<int> InviteLinkCount { get; set; }

        /// <summary>The name of the group resource. Format: `projects/{project_number}/groups/{group_alias}`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The number of releases this group is permitted to access.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("releaseCount")]
        public virtual System.Nullable<int> ReleaseCount { get; set; }

        /// <summary>Output only. The number of testers who are members of this group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testerCount")]
        public virtual System.Nullable<int> TesterCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for `ListFeedbackReports`.</summary>
    public class GoogleFirebaseAppdistroV1ListFeedbackReportsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The feedback reports</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("feedbackReports")]
        public virtual System.Collections.Generic.IList<GoogleFirebaseAppdistroV1FeedbackReport> FeedbackReports { get; set; }

        /// <summary>
        /// A short-lived token, which can be sent as `pageToken` to retrieve the next page. If this field is omitted,
        /// there are no subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for `ListGroups`.</summary>
    public class GoogleFirebaseAppdistroV1ListGroupsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The groups listed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groups")]
        public virtual System.Collections.Generic.IList<GoogleFirebaseAppdistroV1Group> Groups { get; set; }

        /// <summary>
        /// A short-lived token, which can be sent as `pageToken` to retrieve the next page. If this field is omitted,
        /// there are no subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for `ListReleases`.</summary>
    public class GoogleFirebaseAppdistroV1ListReleasesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A short-lived token, which can be sent as `pageToken` to retrieve the next page. If this field is omitted,
        /// there are no subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The releases</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("releases")]
        public virtual System.Collections.Generic.IList<GoogleFirebaseAppdistroV1Release> Releases { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for `ListTesters`.</summary>
    public class GoogleFirebaseAppdistroV1ListTestersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A short-lived token, which can be sent as `pageToken` to retrieve the next page. If this field is omitted,
        /// there are no subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The testers listed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testers")]
        public virtual System.Collections.Generic.IList<GoogleFirebaseAppdistroV1Tester> Testers { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A release of a Firebase app.</summary>
    public class GoogleFirebaseAppdistroV1Release : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. A signed link (which expires in one hour) to directly download the app binary (IPA/APK/AAB)
        /// file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("binaryDownloadUri")]
        public virtual string BinaryDownloadUri { get; set; }

        /// <summary>
        /// Output only. Build version of the release. For an Android release, the build version is the `versionCode`.
        /// For an iOS release, the build version is the `CFBundleVersion`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildVersion")]
        public virtual string BuildVersion { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time the release was created.</summary>
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
        /// Output only. Display version of the release. For an Android release, the display version is the
        /// `versionName`. For an iOS release, the display version is the `CFBundleShortVersionString`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayVersion")]
        public virtual string DisplayVersion { get; set; }

        /// <summary>Output only. A link to the Firebase console displaying a single release.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firebaseConsoleUri")]
        public virtual string FirebaseConsoleUri { get; set; }

        /// <summary>
        /// The name of the release resource. Format: `projects/{project_number}/apps/{app_id}/releases/{release_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Notes of the release.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("releaseNotes")]
        public virtual GoogleFirebaseAppdistroV1ReleaseNotes ReleaseNotes { get; set; }

        /// <summary>
        /// Output only. A link to the release in the tester web clip or Android app that lets testers (which were
        /// granted access to the app) view release notes and install the app onto their devices.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testingUri")]
        public virtual string TestingUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Notes that belong to a release.</summary>
    public class GoogleFirebaseAppdistroV1ReleaseNotes : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The text of the release notes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>App bundle test certificate</summary>
    public class GoogleFirebaseAppdistroV1TestCertificate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Hex string of MD5 hash of the test certificate used to resign the AAB</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hashMd5")]
        public virtual string HashMd5 { get; set; }

        /// <summary>Hex string of SHA1 hash of the test certificate used to resign the AAB</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hashSha1")]
        public virtual string HashSha1 { get; set; }

        /// <summary>Hex string of SHA256 hash of the test certificate used to resign the AAB</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hashSha256")]
        public virtual string HashSha256 { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A person that can be invited to test apps in a Firebase project.</summary>
    public class GoogleFirebaseAppdistroV1Tester : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The name of the tester associated with the Google account used to accept the tester invitation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The resource names of the groups this tester belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groups")]
        public virtual System.Collections.Generic.IList<string> Groups { get; set; }

        private string _lastActivityTimeRaw;

        private object _lastActivityTime;

        /// <summary>
        /// Output only. The time the tester was last active. This is the most recent time the tester installed one of
        /// the apps. If they've never installed one or if the release no longer exists, this is the time the tester was
        /// added to the project.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastActivityTime")]
        public virtual string LastActivityTimeRaw
        {
            get => _lastActivityTimeRaw;
            set
            {
                _lastActivityTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lastActivityTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LastActivityTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LastActivityTimeDateTimeOffset instead.")]
        public virtual object LastActivityTime
        {
            get => _lastActivityTime;
            set
            {
                _lastActivityTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lastActivityTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="LastActivityTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LastActivityTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LastActivityTimeRaw);
            set => LastActivityTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// The name of the tester resource. Format: `projects/{project_number}/testers/{email_address}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Operation metadata for `UploadRelease`.</summary>
    public class GoogleFirebaseAppdistroV1UploadReleaseMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for `UploadRelease`.</summary>
    public class GoogleFirebaseAppdistroV1UploadReleaseRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Binary to upload</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blob")]
        public virtual GdataMedia Blob { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for `UploadRelease`.</summary>
    public class GoogleFirebaseAppdistroV1UploadReleaseResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Release associated with the uploaded binary.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("release")]
        public virtual GoogleFirebaseAppdistroV1Release Release { get; set; }

        /// <summary>Result of upload release.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("result")]
        public virtual string Result { get; set; }

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

    /// <summary>The request message for Operations.WaitOperation.</summary>
    public class GoogleLongrunningWaitOperationRequest : Google.Apis.Requests.IDirectResponseSchema
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
}
