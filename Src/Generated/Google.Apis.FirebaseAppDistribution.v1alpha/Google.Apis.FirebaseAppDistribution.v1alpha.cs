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

namespace Google.Apis.FirebaseAppDistribution.v1alpha
{
    /// <summary>The FirebaseAppDistribution Service.</summary>
    public class FirebaseAppDistributionService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1alpha";

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
            Apps = new AppsResource(this);
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

        /// <summary>Gets the Apps resource.</summary>
        public virtual AppsResource Apps { get; }

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
            ReleaseByHash = new ReleaseByHashResource(service);
            Releases = new ReleasesResource(service);
            Testers = new TestersResource(service);
            UploadStatus = new UploadStatusResource(service);
        }

        /// <summary>Gets the ReleaseByHash resource.</summary>
        public virtual ReleaseByHashResource ReleaseByHash { get; }

        /// <summary>The "release_by_hash" collection of methods.</summary>
        public class ReleaseByHashResource
        {
            private const string Resource = "releaseByHash";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ReleaseByHashResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>GET Release by binary upload hash</summary>
            /// <param name="mobilesdkAppId">
            /// Unique id for a Firebase app of the format: {version}:{project_number}:{platform}:{hash(bundle_id)}
            /// Example: 1:581234567376:android:aa0a3c7b135e90289
            /// </param>
            /// <param name="uploadHash">The hash for the upload</param>
            public virtual GetRequest Get(string mobilesdkAppId, string uploadHash)
            {
                return new GetRequest(this.service, mobilesdkAppId, uploadHash);
            }

            /// <summary>GET Release by binary upload hash</summary>
            public class GetRequest : FirebaseAppDistributionBaseServiceRequest<Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaGetReleaseByUploadHashResponse>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string mobilesdkAppId, string uploadHash) : base(service)
                {
                    MobilesdkAppId = mobilesdkAppId;
                    UploadHash = uploadHash;
                    InitParameters();
                }

                /// <summary>
                /// Unique id for a Firebase app of the format: {version}:{project_number}:{platform}:{hash(bundle_id)}
                /// Example: 1:581234567376:android:aa0a3c7b135e90289
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("mobilesdkAppId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string MobilesdkAppId { get; private set; }

                /// <summary>The hash for the upload</summary>
                [Google.Apis.Util.RequestParameterAttribute("uploadHash", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UploadHash { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/apps/{mobilesdkAppId}/release_by_hash/{uploadHash}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("mobilesdkAppId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "mobilesdkAppId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("uploadHash", new Google.Apis.Discovery.Parameter
                    {
                        Name = "uploadHash",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
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
                Notes = new NotesResource(service);
            }

            /// <summary>Gets the Notes resource.</summary>
            public virtual NotesResource Notes { get; }

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
                }

                /// <summary>Create release notes on a release.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="mobilesdkAppId">
                /// Unique id for a Firebase app of the format: {version}:{project_number}:{platform}:{hash(bundle_id)}
                /// Example: 1:581234567376:android:aa0a3c7b135e90289
                /// </param>
                /// <param name="releaseId">Release identifier</param>
                public virtual CreateRequest Create(Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaCreateReleaseNotesRequest body, string mobilesdkAppId, string releaseId)
                {
                    return new CreateRequest(this.service, body, mobilesdkAppId, releaseId);
                }

                /// <summary>Create release notes on a release.</summary>
                public class CreateRequest : FirebaseAppDistributionBaseServiceRequest<Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaCreateReleaseNotesResponse>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaCreateReleaseNotesRequest body, string mobilesdkAppId, string releaseId) : base(service)
                    {
                        MobilesdkAppId = mobilesdkAppId;
                        ReleaseId = releaseId;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Unique id for a Firebase app of the format:
                    /// {version}:{project_number}:{platform}:{hash(bundle_id)} Example:
                    /// 1:581234567376:android:aa0a3c7b135e90289
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("mobilesdkAppId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string MobilesdkAppId { get; private set; }

                    /// <summary>Release identifier</summary>
                    [Google.Apis.Util.RequestParameterAttribute("releaseId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ReleaseId { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaCreateReleaseNotesRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/apps/{mobilesdkAppId}/releases/{releaseId}/notes";

                    /// <summary>Initializes Create parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("mobilesdkAppId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "mobilesdkAppId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("releaseId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "releaseId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
            }

            /// <summary>Enable access on a release for testers.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="mobilesdkAppId">
            /// Unique id for a Firebase app of the format: {version}:{project_number}:{platform}:{hash(bundle_id)}
            /// Example: 1:581234567376:android:aa0a3c7b135e90289
            /// </param>
            /// <param name="releaseId">Release identifier</param>
            public virtual EnableAccessRequest EnableAccess(Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaEnableAccessOnReleaseRequest body, string mobilesdkAppId, string releaseId)
            {
                return new EnableAccessRequest(this.service, body, mobilesdkAppId, releaseId);
            }

            /// <summary>Enable access on a release for testers.</summary>
            public class EnableAccessRequest : FirebaseAppDistributionBaseServiceRequest<Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaEnableAccessOnReleaseResponse>
            {
                /// <summary>Constructs a new EnableAccess request.</summary>
                public EnableAccessRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaEnableAccessOnReleaseRequest body, string mobilesdkAppId, string releaseId) : base(service)
                {
                    MobilesdkAppId = mobilesdkAppId;
                    ReleaseId = releaseId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Unique id for a Firebase app of the format: {version}:{project_number}:{platform}:{hash(bundle_id)}
                /// Example: 1:581234567376:android:aa0a3c7b135e90289
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("mobilesdkAppId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string MobilesdkAppId { get; private set; }

                /// <summary>Release identifier</summary>
                [Google.Apis.Util.RequestParameterAttribute("releaseId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ReleaseId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaEnableAccessOnReleaseRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "enable_access";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/apps/{mobilesdkAppId}/releases/{releaseId}/enable_access";

                /// <summary>Initializes EnableAccess parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("mobilesdkAppId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "mobilesdkAppId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("releaseId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "releaseId",
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

            /// <summary>Get UDIDs of tester iOS devices in a project</summary>
            /// <param name="mobilesdkAppId">
            /// Unique id for a Firebase app of the format: {version}:{project_number}:{platform}:{hash(bundle_id)}
            /// Example: 1:581234567376:android:aa0a3c7b135e90289
            /// </param>
            public virtual GetTesterUdidsRequest GetTesterUdids(string mobilesdkAppId)
            {
                return new GetTesterUdidsRequest(this.service, mobilesdkAppId);
            }

            /// <summary>Get UDIDs of tester iOS devices in a project</summary>
            public class GetTesterUdidsRequest : FirebaseAppDistributionBaseServiceRequest<Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaGetTesterUdidsResponse>
            {
                /// <summary>Constructs a new GetTesterUdids request.</summary>
                public GetTesterUdidsRequest(Google.Apis.Services.IClientService service, string mobilesdkAppId) : base(service)
                {
                    MobilesdkAppId = mobilesdkAppId;
                    InitParameters();
                }

                /// <summary>
                /// Unique id for a Firebase app of the format: {version}:{project_number}:{platform}:{hash(bundle_id)}
                /// Example: 1:581234567376:android:aa0a3c7b135e90289
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("mobilesdkAppId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string MobilesdkAppId { get; private set; }

                /// <summary>
                /// The name of the project, which is the parent of testers Format: `projects/{project_number}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Project { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getTesterUdids";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/apps/{mobilesdkAppId}/testers:getTesterUdids";

                /// <summary>Initializes GetTesterUdids parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("mobilesdkAppId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "mobilesdkAppId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                    {
                        Name = "project",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the UploadStatus resource.</summary>
        public virtual UploadStatusResource UploadStatus { get; }

        /// <summary>The "upload_status" collection of methods.</summary>
        public class UploadStatusResource
        {
            private const string Resource = "uploadStatus";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public UploadStatusResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>GET Binary upload status by token</summary>
            /// <param name="mobilesdkAppId">
            /// Unique id for a Firebase app of the format: {version}:{project_number}:{platform}:{hash(bundle_id)}
            /// Example: 1:581234567376:android:aa0a3c7b135e90289
            /// </param>
            /// <param name="uploadToken">The token for the upload</param>
            public virtual GetRequest Get(string mobilesdkAppId, string uploadToken)
            {
                return new GetRequest(this.service, mobilesdkAppId, uploadToken);
            }

            /// <summary>GET Binary upload status by token</summary>
            public class GetRequest : FirebaseAppDistributionBaseServiceRequest<Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaGetUploadStatusResponse>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string mobilesdkAppId, string uploadToken) : base(service)
                {
                    MobilesdkAppId = mobilesdkAppId;
                    UploadToken = uploadToken;
                    InitParameters();
                }

                /// <summary>
                /// Unique id for a Firebase app of the format: {version}:{project_number}:{platform}:{hash(bundle_id)}
                /// Example: 1:581234567376:android:aa0a3c7b135e90289
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("mobilesdkAppId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string MobilesdkAppId { get; private set; }

                /// <summary>The token for the upload</summary>
                [Google.Apis.Util.RequestParameterAttribute("uploadToken", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UploadToken { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/apps/{mobilesdkAppId}/upload_status/{uploadToken}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("mobilesdkAppId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "mobilesdkAppId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("uploadToken", new Google.Apis.Discovery.Parameter
                    {
                        Name = "uploadToken",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Get the app, if it exists</summary>
        /// <param name="mobilesdkAppId">
        /// Unique id for a Firebase app of the format: {version}:{project_number}:{platform}:{hash(bundle_id)} Example:
        /// 1:581234567376:android:aa0a3c7b135e90289
        /// </param>
        public virtual GetRequest Get(string mobilesdkAppId)
        {
            return new GetRequest(this.service, mobilesdkAppId);
        }

        /// <summary>Get the app, if it exists</summary>
        public class GetRequest : FirebaseAppDistributionBaseServiceRequest<Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaApp>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string mobilesdkAppId) : base(service)
            {
                MobilesdkAppId = mobilesdkAppId;
                InitParameters();
            }

            /// <summary>
            /// Unique id for a Firebase app of the format: {version}:{project_number}:{platform}:{hash(bundle_id)}
            /// Example: 1:581234567376:android:aa0a3c7b135e90289
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("mobilesdkAppId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string MobilesdkAppId { get; private set; }

            /// <summary>
            /// App view. When unset or set to BASIC, returns an App with everything set except for aab_state. When set
            /// to FULL, returns an App with aab_state set.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("appView", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<AppViewEnum> AppView { get; set; }

            /// <summary>
            /// App view. When unset or set to BASIC, returns an App with everything set except for aab_state. When set
            /// to FULL, returns an App with aab_state set.
            /// </summary>
            public enum AppViewEnum
            {
                /// <summary>The default / unset value. The API will default to the BASIC view.</summary>
                [Google.Apis.Util.StringValueAttribute("APP_VIEW_UNSPECIFIED")]
                APPVIEWUNSPECIFIED = 0,

                /// <summary>Include everything except aab_state.</summary>
                [Google.Apis.Util.StringValueAttribute("BASIC")]
                BASIC = 1,

                /// <summary>Include everything.</summary>
                [Google.Apis.Util.StringValueAttribute("FULL")]
                FULL = 2,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1alpha/apps/{mobilesdkAppId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("mobilesdkAppId", new Google.Apis.Discovery.Parameter
                {
                    Name = "mobilesdkAppId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("appView", new Google.Apis.Discovery.Parameter
                {
                    Name = "appView",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Get a JWT token</summary>
        /// <param name="mobilesdkAppId">
        /// Unique id for a Firebase app of the format: {version}:{project_number}:{platform}:{hash(bundle_id)} Example:
        /// 1:581234567376:android:aa0a3c7b135e90289
        /// </param>
        public virtual GetJwtRequest GetJwt(string mobilesdkAppId)
        {
            return new GetJwtRequest(this.service, mobilesdkAppId);
        }

        /// <summary>Get a JWT token</summary>
        public class GetJwtRequest : FirebaseAppDistributionBaseServiceRequest<Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaJwt>
        {
            /// <summary>Constructs a new GetJwt request.</summary>
            public GetJwtRequest(Google.Apis.Services.IClientService service, string mobilesdkAppId) : base(service)
            {
                MobilesdkAppId = mobilesdkAppId;
                InitParameters();
            }

            /// <summary>
            /// Unique id for a Firebase app of the format: {version}:{project_number}:{platform}:{hash(bundle_id)}
            /// Example: 1:581234567376:android:aa0a3c7b135e90289
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("mobilesdkAppId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string MobilesdkAppId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getJwt";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1alpha/apps/{mobilesdkAppId}/jwt";

            /// <summary>Initializes GetJwt parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("mobilesdkAppId", new Google.Apis.Discovery.Parameter
                {
                    Name = "mobilesdkAppId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Provision app distribution for an existing Firebase app, enabling it to subsequently be used by appdistro.
        /// </summary>
        /// <param name="mobilesdkAppId">
        /// Unique id for a Firebase app of the format: {version}:{project_number}:{platform}:{hash(bundle_id)} Example:
        /// 1:581234567376:android:aa0a3c7b135e90289
        /// </param>
        public virtual ProvisionAppRequest ProvisionApp(string mobilesdkAppId)
        {
            return new ProvisionAppRequest(this.service, mobilesdkAppId);
        }

        /// <summary>
        /// Provision app distribution for an existing Firebase app, enabling it to subsequently be used by appdistro.
        /// </summary>
        public class ProvisionAppRequest : FirebaseAppDistributionBaseServiceRequest<Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaProvisionAppResponse>
        {
            /// <summary>Constructs a new ProvisionApp request.</summary>
            public ProvisionAppRequest(Google.Apis.Services.IClientService service, string mobilesdkAppId) : base(service)
            {
                MobilesdkAppId = mobilesdkAppId;
                InitParameters();
            }

            /// <summary>
            /// Unique id for a Firebase app of the format: {version}:{project_number}:{platform}:{hash(bundle_id)}
            /// Example: 1:581234567376:android:aa0a3c7b135e90289
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("mobilesdkAppId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string MobilesdkAppId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "provisionApp";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1alpha/apps/{mobilesdkAppId}";

            /// <summary>Initializes ProvisionApp parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("mobilesdkAppId", new Google.Apis.Discovery.Parameter
                {
                    Name = "mobilesdkAppId",
                    IsRequired = true,
                    ParameterType = "path",
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
            Apps = new AppsResource(service);
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
                TestCases = new TestCasesResource(service);
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
                    Tests = new TestsResource(service);
                }

                /// <summary>Gets the Tests resource.</summary>
                public virtual TestsResource Tests { get; }

                /// <summary>The "tests" collection of methods.</summary>
                public class TestsResource
                {
                    private const string Resource = "tests";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public TestsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Abort automated test run on release.</summary>
                    /// <param name="name">
                    /// Required. The name of the release test resource. Format:
                    /// `projects/{project_number}/apps/{app_id}/releases/{release_id}/tests/{test_id}`
                    /// </param>
                    public virtual CancelRequest Cancel(string name)
                    {
                        return new CancelRequest(this.service, name);
                    }

                    /// <summary>Abort automated test run on release.</summary>
                    public class CancelRequest : FirebaseAppDistributionBaseServiceRequest<Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaCancelReleaseTestResponse>
                    {
                        /// <summary>Constructs a new Cancel request.</summary>
                        public CancelRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the release test resource. Format:
                        /// `projects/{project_number}/apps/{app_id}/releases/{release_id}/tests/{test_id}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "cancel";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+name}:cancel";

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
                                Pattern = @"^projects/[^/]+/apps/[^/]+/releases/[^/]+/tests/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Run automated test(s) on release.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The name of the release resource, which is the parent of the test Format:
                    /// `projects/{project_number}/apps/{app_id}/releases/{release_id}`
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaReleaseTest body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>Run automated test(s) on release.</summary>
                    public class CreateRequest : FirebaseAppDistributionBaseServiceRequest<Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaReleaseTest>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaReleaseTest body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the release resource, which is the parent of the test Format:
                        /// `projects/{project_number}/apps/{app_id}/releases/{release_id}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. The ID to use for the test, which will become the final component of the test's
                        /// resource name. This value should be 4-63 characters, and valid characters are /a-z-/. If it
                        /// is not provided one will be automatically generated.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("releaseTestId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string ReleaseTestId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaReleaseTest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+parent}/tests";

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
                                Pattern = @"^projects/[^/]+/apps/[^/]+/releases/[^/]+$",
                            });
                            RequestParameters.Add("releaseTestId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "releaseTestId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Get results for automated test run on release.</summary>
                    /// <param name="name">
                    /// Required. The name of the release test resource. Format:
                    /// `projects/{project_number}/apps/{app_id}/releases/{release_id}/tests/{test_id}`
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Get results for automated test run on release.</summary>
                    public class GetRequest : FirebaseAppDistributionBaseServiceRequest<Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaReleaseTest>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the release test resource. Format:
                        /// `projects/{project_number}/apps/{app_id}/releases/{release_id}/tests/{test_id}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+name}";

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
                                Pattern = @"^projects/[^/]+/apps/[^/]+/releases/[^/]+/tests/[^/]+$",
                            });
                        }
                    }

                    /// <summary>List results for automated tests run on release.</summary>
                    /// <param name="parent">
                    /// Required. The name of the release resource, which is the parent of the tests Format:
                    /// `projects/{project_number}/apps/{app_id}/releases/{release_id}`
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>List results for automated tests run on release.</summary>
                    public class ListRequest : FirebaseAppDistributionBaseServiceRequest<Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaListReleaseTestsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the release resource, which is the parent of the tests Format:
                        /// `projects/{project_number}/apps/{app_id}/releases/{release_id}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. The maximum number of tests to return. The service may return fewer than this
                        /// value.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. A page token, received from a previous `ListReleaseTests` call. Provide this to
                        /// retrieve the subsequent page.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>
                        /// Optional. The requested view on the returned ReleaseTests. Defaults to the basic view.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<ViewEnum> View { get; set; }

                        /// <summary>
                        /// Optional. The requested view on the returned ReleaseTests. Defaults to the basic view.
                        /// </summary>
                        public enum ViewEnum
                        {
                            /// <summary>The default / unset value. The default view depends on the RPC.</summary>
                            [Google.Apis.Util.StringValueAttribute("RELEASE_TEST_VIEW_UNSPECIFIED")]
                            RELEASETESTVIEWUNSPECIFIED = 0,

                            /// <summary>
                            /// Include basic metadata about the release test and its status, but not the full result
                            /// details. This is the default value for ListReleaseTests.
                            /// </summary>
                            [Google.Apis.Util.StringValueAttribute("RELEASE_TEST_VIEW_BASIC")]
                            RELEASETESTVIEWBASIC = 1,

                            /// <summary>Include everything.</summary>
                            [Google.Apis.Util.StringValueAttribute("RELEASE_TEST_VIEW_FULL")]
                            RELEASETESTVIEWFULL = 2,
                        }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+parent}/tests";

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
                            RequestParameters.Add("view", new Google.Apis.Discovery.Parameter
                            {
                                Name = "view",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }
                }
            }

            /// <summary>Gets the TestCases resource.</summary>
            public virtual TestCasesResource TestCases { get; }

            /// <summary>The "testCases" collection of methods.</summary>
            public class TestCasesResource
            {
                private const string Resource = "testCases";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public TestCasesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Delete test cases.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource where these test cases will be deleted. Format:
                /// `projects/{project_number}/apps/{app_id}`
                /// </param>
                public virtual BatchDeleteRequest BatchDelete(Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaBatchDeleteTestCasesRequest body, string parent)
                {
                    return new BatchDeleteRequest(this.service, body, parent);
                }

                /// <summary>Delete test cases.</summary>
                public class BatchDeleteRequest : FirebaseAppDistributionBaseServiceRequest<Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleProtobufEmpty>
                {
                    /// <summary>Constructs a new BatchDelete request.</summary>
                    public BatchDeleteRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaBatchDeleteTestCasesRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource where these test cases will be deleted. Format:
                    /// `projects/{project_number}/apps/{app_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaBatchDeleteTestCasesRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "batchDelete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+parent}/testCases:batchDelete";

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

                /// <summary>Create a new test case.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource where this test case will be created. Format:
                /// `projects/{project_number}/apps/{app_id}`
                /// </param>
                public virtual CreateRequest Create(Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaTestCase body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Create a new test case.</summary>
                public class CreateRequest : FirebaseAppDistributionBaseServiceRequest<Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaTestCase>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaTestCase body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource where this test case will be created. Format:
                    /// `projects/{project_number}/apps/{app_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. The ID to use for the test case, which will become the final component of the test
                    /// case's resource name. This value should be 4-63 characters, and valid characters are /a-z-/.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("testCaseId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string TestCaseId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaTestCase Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+parent}/testCases";

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
                            Pattern = @"^projects/[^/]+/apps/[^/]+$",
                        });
                        RequestParameters.Add("testCaseId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "testCaseId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Delete a test case.</summary>
                /// <param name="name">
                /// Required. The name of the test case resource to delete. Format:
                /// `projects/{project_number}/apps/{app_id}/testCases/{test_case_id}`
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Delete a test case.</summary>
                public class DeleteRequest : FirebaseAppDistributionBaseServiceRequest<Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleProtobufEmpty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the test case resource to delete. Format:
                    /// `projects/{project_number}/apps/{app_id}/testCases/{test_case_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+name}";

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
                            Pattern = @"^projects/[^/]+/apps/[^/]+/testCases/[^/]+$",
                        });
                    }
                }

                /// <summary>Get a test case.</summary>
                /// <param name="name">
                /// Required. The name of the test case resource to retrieve. Format:
                /// `projects/{project_number}/apps/{app_id}/testCases/{test_case_id}`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Get a test case.</summary>
                public class GetRequest : FirebaseAppDistributionBaseServiceRequest<Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaTestCase>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the test case resource to retrieve. Format:
                    /// `projects/{project_number}/apps/{app_id}/testCases/{test_case_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+name}";

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
                            Pattern = @"^projects/[^/]+/apps/[^/]+/testCases/[^/]+$",
                        });
                    }
                }

                /// <summary>List test cases.</summary>
                /// <param name="parent">
                /// Required. The parent resource from which to list test cases. Format:
                /// `projects/{project_number}/apps/{app_id}`
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>List test cases.</summary>
                public class ListRequest : FirebaseAppDistributionBaseServiceRequest<Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaListTestCasesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource from which to list test cases. Format:
                    /// `projects/{project_number}/apps/{app_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. The maximum number of test cases to return. The service may return fewer than this
                    /// value. If unspecified, at most 50 test cases will be returned. The maximum value is 1000; values
                    /// above 1000 will be coerced to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A page token, received from a previous `ListTestCases` call. Provide this to retrieve
                    /// the subsequent page. When paginating, all other parameters provided to `ListTestCases` must
                    /// match the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+parent}/testCases";

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

                /// <summary>Update a test case.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Identifier. The name of the test case resource. Format:
                /// `projects/{project_number}/apps/{app_id}/testCases/{test_case_id}`
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaTestCase body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Update a test case.</summary>
                public class PatchRequest : FirebaseAppDistributionBaseServiceRequest<Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaTestCase>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaTestCase body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Identifier. The name of the test case resource. Format:
                    /// `projects/{project_number}/apps/{app_id}/testCases/{test_case_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaTestCase Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+name}";

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
                            Pattern = @"^projects/[^/]+/apps/[^/]+/testCases/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets configuration for automated tests.</summary>
            /// <param name="name">
            /// Required. The name of the `TestConfig` resource to retrieve. Format:
            /// `projects/{project_number}/apps/{app_id}/testConfig`
            /// </param>
            public virtual GetTestConfigRequest GetTestConfig(string name)
            {
                return new GetTestConfigRequest(this.service, name);
            }

            /// <summary>Gets configuration for automated tests.</summary>
            public class GetTestConfigRequest : FirebaseAppDistributionBaseServiceRequest<Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaTestConfig>
            {
                /// <summary>Constructs a new GetTestConfig request.</summary>
                public GetTestConfigRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the `TestConfig` resource to retrieve. Format:
                /// `projects/{project_number}/apps/{app_id}/testConfig`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getTestConfig";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+name}";

                /// <summary>Initializes GetTestConfig parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/apps/[^/]+/testConfig$",
                    });
                }
            }

            /// <summary>Updates automated test configuration.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Identifier. The name of the test configuration resource. Format:
            /// `projects/{project_number}/apps/{app_id}/testConfig`
            /// </param>
            public virtual UpdateTestConfigRequest UpdateTestConfig(Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaTestConfig body, string name)
            {
                return new UpdateTestConfigRequest(this.service, body, name);
            }

            /// <summary>Updates automated test configuration.</summary>
            public class UpdateTestConfigRequest : FirebaseAppDistributionBaseServiceRequest<Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaTestConfig>
            {
                /// <summary>Constructs a new UpdateTestConfig request.</summary>
                public UpdateTestConfigRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaTestConfig body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Identifier. The name of the test configuration resource. Format:
                /// `projects/{project_number}/apps/{app_id}/testConfig`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Optional. The list of fields to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaTestConfig Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "updateTestConfig";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+name}";

                /// <summary>Initializes UpdateTestConfig parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/apps/[^/]+/testConfig$",
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

            /// <summary>Get UDIDs of tester iOS devices in a project</summary>
            /// <param name="project">
            /// The name of the project, which is the parent of testers Format: `projects/{project_number}`
            /// </param>
            public virtual GetUdidsRequest GetUdids(string project)
            {
                return new GetUdidsRequest(this.service, project);
            }

            /// <summary>Get UDIDs of tester iOS devices in a project</summary>
            public class GetUdidsRequest : FirebaseAppDistributionBaseServiceRequest<Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaGetTesterUdidsResponse>
            {
                /// <summary>Constructs a new GetUdids request.</summary>
                public GetUdidsRequest(Google.Apis.Services.IClientService service, string project) : base(service)
                {
                    Project = project;
                    InitParameters();
                }

                /// <summary>
                /// The name of the project, which is the parent of testers Format: `projects/{project_number}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Project { get; private set; }

                /// <summary>
                /// Unique id for a Firebase app of the format: {version}:{project_number}:{platform}:{hash(bundle_id)}
                /// Example: 1:581234567376:android:aa0a3c7b135e90289
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("mobilesdkAppId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string MobilesdkAppId { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getUdids";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+project}/testers:udids";

                /// <summary>Initializes GetUdids parameter list.</summary>
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
                    RequestParameters.Add("mobilesdkAppId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "mobilesdkAppId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Get information about the quota for `ReleaseTests`.</summary>
        /// <param name="name">
        /// Required. The name of the `TestQuota` resource to retrieve. Format: `projects/{project_number}/testQuota`
        /// </param>
        public virtual GetTestQuotaRequest GetTestQuota(string name)
        {
            return new GetTestQuotaRequest(this.service, name);
        }

        /// <summary>Get information about the quota for `ReleaseTests`.</summary>
        public class GetTestQuotaRequest : FirebaseAppDistributionBaseServiceRequest<Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaTestQuota>
        {
            /// <summary>Constructs a new GetTestQuota request.</summary>
            public GetTestQuotaRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the `TestQuota` resource to retrieve. Format:
            /// `projects/{project_number}/testQuota`
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getTestQuota";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1alpha/{+name}";

            /// <summary>Initializes GetTestQuota parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+/testQuota$",
                });
            }
        }
    }
}
namespace Google.Apis.FirebaseAppDistribution.v1alpha.Data
{
    /// <summary>Point for describing bounding boxes tap locations Top left is 0,0</summary>
    public class AndroidxCrawlerOutputPoint : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("xCoordinate")]
        public virtual System.Nullable<int> XCoordinate { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("yCoordinate")]
        public virtual System.Nullable<int> YCoordinate { get; set; }

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

    /// <summary>Operation metadata for `UploadRelease`.</summary>
    public class GoogleFirebaseAppdistroV1UploadReleaseMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
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

    /// <summary>App bundle test certificate</summary>
    public class GoogleFirebaseAppdistroV1alphaAabCertificate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>MD5 hash of the certificate used to resign the AAB</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certificateHashMd5")]
        public virtual string CertificateHashMd5 { get; set; }

        /// <summary>SHA1 hash of the certificate used to resign the AAB</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certificateHashSha1")]
        public virtual string CertificateHashSha1 { get; set; }

        /// <summary>SHA256 hash of the certificate used to resign the AAB</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certificateHashSha256")]
        public virtual string CertificateHashSha256 { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleFirebaseAppdistroV1alphaAiInstructions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Steps to be accomplished by the AI</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("steps")]
        public virtual System.Collections.Generic.IList<GoogleFirebaseAppdistroV1alphaAiStep> Steps { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A step to be accomplished by the AI</summary>
    public class GoogleFirebaseAppdistroV1alphaAiStep : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An assertion to be checked by the AI</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assertion")]
        public virtual string Assertion { get; set; }

        /// <summary>A goal to be accomplished by the AI</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("goal")]
        public virtual string Goal { get; set; }

        /// <summary>Optional. Hint text containing suggestions to help the agent accomplish the goal</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hint")]
        public virtual string Hint { get; set; }

        /// <summary>
        /// Optional. A description of criteria the agent should use to determine if the goal has been successfully
        /// completed
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("successCriteria")]
        public virtual string SuccessCriteria { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Captures the results of an AiStep</summary>
    public class GoogleFirebaseAppdistroV1alphaAiStepResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Details for an assertion step.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assertionDetails")]
        public virtual GoogleFirebaseAppdistroV1alphaAssertionDetails AssertionDetails { get; set; }

        /// <summary>Output only. Details for a goal step.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("goalDetails")]
        public virtual GoogleFirebaseAppdistroV1alphaGoalDetails GoalDetails { get; set; }

        /// <summary>Output only. The current state of the step</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Required. The step performed by the AI</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("step")]
        public virtual GoogleFirebaseAppdistroV1alphaAiStep Step { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An app.</summary>
    public class GoogleFirebaseAppdistroV1alphaApp : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>App bundle test certificate generated for the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aabCertificate")]
        public virtual GoogleFirebaseAppdistroV1alphaAabCertificate AabCertificate { get; set; }

        /// <summary>
        /// App bundle state. Only valid for android apps. The app_view field in the request must be set to FULL in
        /// order for this to be populated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aabState")]
        public virtual string AabState { get; set; }

        /// <summary>Firebase gmp app id</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appId")]
        public virtual string AppId { get; set; }

        /// <summary>Bundle identifier</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bundleId")]
        public virtual string BundleId { get; set; }

        /// <summary>Developer contact email for testers to reach out to about privacy or support issues.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contactEmail")]
        public virtual string ContactEmail { get; set; }

        /// <summary>iOS or Android</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("platform")]
        public virtual string Platform { get; set; }

        /// <summary>Project number of the Firebase project, for example 300830567303.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectNumber")]
        public virtual string ProjectNumber { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An app crash that occurred during an automated test.</summary>
    public class GoogleFirebaseAppdistroV1alphaAppCrash : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The message associated with the crash.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>Output only. The raw stack trace.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stackTrace")]
        public virtual string StackTrace { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details for an assertion step.</summary>
    public class GoogleFirebaseAppdistroV1alphaAssertionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. An explanation justifying the assertion result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("explanation")]
        public virtual string Explanation { get; set; }

        /// <summary>Output only. The result of the assertion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("result")]
        public virtual System.Nullable<bool> Result { get; set; }

        /// <summary>Output only. The screenshot used in the context of this assertion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("screenshot")]
        public virtual GoogleFirebaseAppdistroV1alphaScreenshot Screenshot { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for `DeleteTestCase`.</summary>
    public class GoogleFirebaseAppdistroV1alphaBatchDeleteTestCasesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The name of the test cases to delete. A maximum number of 1000 test cases can be deleted in one
        /// batch Format: `projects/{project_number}/apps/{app_id}/testCases/{test_case_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("names")]
        public virtual System.Collections.Generic.IList<string> Names { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The (empty) response message for `CancelReleaseTest`.</summary>
    public class GoogleFirebaseAppdistroV1alphaCancelReleaseTestResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for `CreateReleaseNotes`.</summary>
    public class GoogleFirebaseAppdistroV1alphaCreateReleaseNotesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The actual release notes body from the user</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("releaseNotes")]
        public virtual GoogleFirebaseAppdistroV1alphaReleaseNotes ReleaseNotes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for `CreateReleaseNotes`.</summary>
    public class GoogleFirebaseAppdistroV1alphaCreateReleaseNotesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A high level action taken by the AI on the device, potentially involving multiple taps, text entries, waits,
    /// etc.
    /// </summary>
    public class GoogleFirebaseAppdistroV1alphaDeviceAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. A short description of the high level action taken by the AI agent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Output only. The interactions made with the device as part of this higher level action taken by the agent,
        /// such as taps, text entries, waits, etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceInteractions")]
        public virtual System.Collections.Generic.IList<GoogleFirebaseAppdistroV1alphaDeviceInteraction> DeviceInteractions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The results of running an automated test on a particular device.</summary>
    public class GoogleFirebaseAppdistroV1alphaDeviceExecution : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Results of the AI steps if passed in</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aiStepResults")]
        public virtual System.Collections.Generic.IList<GoogleFirebaseAppdistroV1alphaAiStepResult> AiStepResults { get; set; }

        /// <summary>Output only. An app crash, if any occurred during the test.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appCrash")]
        public virtual GoogleFirebaseAppdistroV1alphaAppCrash AppCrash { get; set; }

        /// <summary>Output only. A URI to an image of the Robo crawl graph.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crawlGraphUri")]
        public virtual string CrawlGraphUri { get; set; }

        /// <summary>Required. The device that the test was run on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("device")]
        public virtual GoogleFirebaseAppdistroV1alphaTestDevice Device { get; set; }

        /// <summary>Output only. The reason why the test failed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failedReason")]
        public virtual string FailedReason { get; set; }

        /// <summary>Output only. The reason why the test was inconclusive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inconclusiveReason")]
        public virtual string InconclusiveReason { get; set; }

        /// <summary>
        /// Output only. The path to a directory in Cloud Storage that will eventually contain the results for this
        /// execution. For example, gs://bucket/Nexus5-18-en-portrait.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resultsStoragePath")]
        public virtual string ResultsStoragePath { get; set; }

        /// <summary>Output only. The statistics collected during the Robo test.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roboStats")]
        public virtual GoogleFirebaseAppdistroV1alphaRoboStats RoboStats { get; set; }

        /// <summary>
        /// Output only. A list of screenshot image URIs taken from the Robo crawl. The file names are numbered by the
        /// order in which they were taken.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("screenshotUris")]
        public virtual System.Collections.Generic.IList<string> ScreenshotUris { get; set; }

        /// <summary>Output only. The state of the test.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. A URI to a video of the test run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoUri")]
        public virtual string VideoUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An interaction with the device, such as a tap, text entry, wait, etc.</summary>
    public class GoogleFirebaseAppdistroV1alphaDeviceInteraction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Key code for a key event action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyCode")]
        public virtual string KeyCode { get; set; }

        /// <summary>
        /// Output only. The screenshot used in the context of this action. The screen may have changed before the
        /// action was actually taken.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("screenshot")]
        public virtual GoogleFirebaseAppdistroV1alphaScreenshot Screenshot { get; set; }

        /// <summary>Output only. A swipe action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("swipe")]
        public virtual GoogleFirebaseAppdistroV1alphaDeviceInteractionSwipe Swipe { get; set; }

        /// <summary>Output only. A tap action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tap")]
        public virtual AndroidxCrawlerOutputPoint Tap { get; set; }

        /// <summary>Output only. Text entered for a text entry action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textInput")]
        public virtual string TextInput { get; set; }

        /// <summary>Output only. A wait action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wait")]
        public virtual GoogleFirebaseAppdistroV1alphaDeviceInteractionWait Wait { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A swipe action.</summary>
    public class GoogleFirebaseAppdistroV1alphaDeviceInteractionSwipe : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The end point of the swipe.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("end")]
        public virtual AndroidxCrawlerOutputPoint End { get; set; }

        /// <summary>Output only. The start point of the swipe.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("start")]
        public virtual AndroidxCrawlerOutputPoint Start { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A wait action.</summary>
    public class GoogleFirebaseAppdistroV1alphaDeviceInteractionWait : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The duration of the wait.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual object Duration { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for `EnableAccessOnRelease`.</summary>
    public class GoogleFirebaseAppdistroV1alphaEnableAccessOnReleaseRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Ignored. Used to be build version of the app release if an instance identifier was provided for
        /// the release_id.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildVersion")]
        public virtual string BuildVersion { get; set; }

        /// <summary>
        /// Optional. Ignored. Used to be display version of the app release if an instance identifier was provided for
        /// the release_id.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayVersion")]
        public virtual string DisplayVersion { get; set; }

        /// <summary>
        /// Optional. An email address which should get access to this release, for example rebeccahe@google.com
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emails")]
        public virtual System.Collections.Generic.IList<string> Emails { get; set; }

        /// <summary>
        /// Optional. A repeated list of group aliases to enable access to a release for Note: This field is misnamed,
        /// but can't be changed because we need to maintain compatibility with old build tools
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupIds")]
        public virtual System.Collections.Generic.IList<string> GroupIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for `EnableAccessOnRelease`.</summary>
    public class GoogleFirebaseAppdistroV1alphaEnableAccessOnReleaseResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response object to get the release given a upload hash</summary>
    public class GoogleFirebaseAppdistroV1alphaGetReleaseByUploadHashResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Release object</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("release")]
        public virtual GoogleFirebaseAppdistroV1alphaRelease Release { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response containing the UDIDs of tester iOS devices in a project</summary>
    public class GoogleFirebaseAppdistroV1alphaGetTesterUdidsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The UDIDs of tester iOS devices in a project</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testerUdids")]
        public virtual System.Collections.Generic.IList<GoogleFirebaseAppdistroV1alphaTesterUdid> TesterUdids { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for `GetUploadStatus`.</summary>
    public class GoogleFirebaseAppdistroV1alphaGetUploadStatusResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The error code associated with (only set on "FAILURE")</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorCode")]
        public virtual string ErrorCode { get; set; }

        /// <summary>
        /// Any additional context for the given upload status (e.g. error message) Meant to be displayed to the client
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>The release that was created from the upload (only set on "SUCCESS")</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("release")]
        public virtual GoogleFirebaseAppdistroV1alphaRelease Release { get; set; }

        /// <summary>The status of the upload</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An action taken by the AI agent while attempting to accomplish a goal.</summary>
    public class GoogleFirebaseAppdistroV1alphaGoalAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Debug information explaining why the agent to the specific action</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("debugInfo")]
        public virtual GoogleFirebaseAppdistroV1alphaGoalActionDebugInfo DebugInfo { get; set; }

        /// <summary>Output only. A high level action taken by the AI on the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceAction")]
        public virtual GoogleFirebaseAppdistroV1alphaDeviceAction DeviceAction { get; set; }

        /// <summary>Output only. An explanation justifying why the action was taken.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("explanation")]
        public virtual string Explanation { get; set; }

        /// <summary>Output only. An action taken by the AI to end the goal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("terminalAction")]
        public virtual GoogleFirebaseAppdistroV1alphaTerminalAction TerminalAction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information to help the customer understand why the agent took this action</summary>
    public class GoogleFirebaseAppdistroV1alphaGoalActionDebugInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. URI of the screenshot with elements labeled which was used by the agent</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotatedScreenshotUri")]
        public virtual string AnnotatedScreenshotUri { get; set; }

        /// <summary>Output only. Structured data explaining the agent's choice</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jsonUri")]
        public virtual string JsonUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details for a goal step.</summary>
    public class GoogleFirebaseAppdistroV1alphaGoalDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The actions taken by the AI while attempting to accomplish the goal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("goalActions")]
        public virtual System.Collections.Generic.IList<GoogleFirebaseAppdistroV1alphaGoalAction> GoalActions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A JWT token.</summary>
    public class GoogleFirebaseAppdistroV1alphaJwt : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The JWT token (three Base64URL-encoded strings joined by dots).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("token")]
        public virtual string Token { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for `ListReleaseTests`.</summary>
    public class GoogleFirebaseAppdistroV1alphaListReleaseTestsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A short-lived token, which can be sent as `pageToken` to retrieve the next page. If this field is omitted,
        /// there are no subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The tests listed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("releaseTests")]
        public virtual System.Collections.Generic.IList<GoogleFirebaseAppdistroV1alphaReleaseTest> ReleaseTests { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for `ListTestCases`.</summary>
    public class GoogleFirebaseAppdistroV1alphaListTestCasesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The test cases from the specified app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testCases")]
        public virtual System.Collections.Generic.IList<GoogleFirebaseAppdistroV1alphaTestCase> TestCases { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Login credential for automated tests</summary>
    public class GoogleFirebaseAppdistroV1alphaLoginCredential : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Hints to the crawler for identifying input fields</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldHints")]
        public virtual GoogleFirebaseAppdistroV1alphaLoginCredentialFieldHints FieldHints { get; set; }

        /// <summary>Optional. Are these credentials for Google?</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("google")]
        public virtual System.Nullable<bool> Google { get; set; }

        /// <summary>Optional. Password for automated tests</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual string Password { get; set; }

        /// <summary>Optional. Username for automated tests</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Hints to the crawler for identifying input fields</summary>
    public class GoogleFirebaseAppdistroV1alphaLoginCredentialFieldHints : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The Android resource name of the password UI element. For example, in Java: R.string.foo in xml:
        /// @string/foo Only the "foo" part is needed. Reference doc:
        /// https://developer.android.com/guide/topics/resources/accessing-resources.html
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passwordResourceName")]
        public virtual string PasswordResourceName { get; set; }

        /// <summary>
        /// Required. The Android resource name of the username UI element. For example, in Java: R.string.foo in xml:
        /// @string/foo Only the "foo" part is needed. Reference doc:
        /// https://developer.android.com/guide/topics/resources/accessing-resources.html
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("usernameResourceName")]
        public virtual string UsernameResourceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for `ProvisionApp`.</summary>
    public class GoogleFirebaseAppdistroV1alphaProvisionAppResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Proto defining a release object</summary>
    public class GoogleFirebaseAppdistroV1alphaRelease : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Release build version</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildVersion")]
        public virtual string BuildVersion { get; set; }

        /// <summary>Release version</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayVersion")]
        public virtual string DisplayVersion { get; set; }

        private string _distributedAtRaw;

        private object _distributedAt;

        /// <summary>Timestamp when the release was created</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("distributedAt")]
        public virtual string DistributedAtRaw
        {
            get => _distributedAtRaw;
            set
            {
                _distributedAt = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _distributedAtRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="DistributedAtRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use DistributedAtDateTimeOffset instead.")]
        public virtual object DistributedAt
        {
            get => _distributedAt;
            set
            {
                _distributedAtRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _distributedAt = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="DistributedAtRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? DistributedAtDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(DistributedAtRaw);
            set => DistributedAtRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Release Id</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Instance id of the release</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceId")]
        public virtual string InstanceId { get; set; }

        private string _lastActivityAtRaw;

        private object _lastActivityAt;

        /// <summary>Last activity timestamp</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastActivityAt")]
        public virtual string LastActivityAtRaw
        {
            get => _lastActivityAtRaw;
            set
            {
                _lastActivityAt = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lastActivityAtRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LastActivityAtRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LastActivityAtDateTimeOffset instead.")]
        public virtual object LastActivityAt
        {
            get => _lastActivityAt;
            set
            {
                _lastActivityAtRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lastActivityAt = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="LastActivityAtRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LastActivityAtDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LastActivityAtRaw);
            set => LastActivityAtRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Number of testers who have open invitations for the release</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("openInvitationCount")]
        public virtual System.Nullable<int> OpenInvitationCount { get; set; }

        private string _receivedAtRaw;

        private object _receivedAt;

        /// <summary>unused. </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("receivedAt")]
        public virtual string ReceivedAtRaw
        {
            get => _receivedAtRaw;
            set
            {
                _receivedAt = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _receivedAtRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ReceivedAtRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ReceivedAtDateTimeOffset instead.")]
        public virtual object ReceivedAt
        {
            get => _receivedAt;
            set
            {
                _receivedAtRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _receivedAt = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ReceivedAtRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ReceivedAtDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ReceivedAtRaw);
            set => ReceivedAtRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Release notes summary</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("releaseNotesSummary")]
        public virtual string ReleaseNotesSummary { get; set; }

        /// <summary>Count of testers added to the release</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testerCount")]
        public virtual System.Nullable<int> TesterCount { get; set; }

        /// <summary>Number of testers who have installed the release</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testerWithInstallCount")]
        public virtual System.Nullable<int> TesterWithInstallCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Release notes for a release.</summary>
    public class GoogleFirebaseAppdistroV1alphaReleaseNotes : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The actual release notes text from the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("releaseNotes")]
        public virtual string ReleaseNotes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The results of running an automated test on a release.</summary>
    public class GoogleFirebaseAppdistroV1alphaReleaseTest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Instructions for AI driven test.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aiInstructions")]
        public virtual GoogleFirebaseAppdistroV1alphaAiInstructions AiInstructions { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Timestamp when the test was run.</summary>
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

        /// <summary>Required. The results of the test on each device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceExecutions")]
        public virtual System.Collections.Generic.IList<GoogleFirebaseAppdistroV1alphaDeviceExecution> DeviceExecutions { get; set; }

        /// <summary>
        /// Optional. Display name of the release test. Required if the release test is created with multiple goals.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Optional. Input only. Login credentials for the test. Input only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loginCredential")]
        public virtual GoogleFirebaseAppdistroV1alphaLoginCredential LoginCredential { get; set; }

        /// <summary>
        /// The name of the release test resource. Format:
        /// `projects/{project_number}/apps/{app_id}/releases/{release_id}/tests/{test_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. The test case that was used to generate this release test. Note: The test case may have changed or
        /// been deleted since the release test was created. Format:
        /// `projects/{project_number}/apps/{app}/testCases/{test_case}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testCase")]
        public virtual string TestCase { get; set; }

        /// <summary>Output only. The state of the release test.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testState")]
        public virtual string TestState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for Robo crawler</summary>
    public class GoogleFirebaseAppdistroV1alphaRoboCrawler : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Instructions for AI driven test</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aiInstructions")]
        public virtual GoogleFirebaseAppdistroV1alphaAiInstructions AiInstructions { get; set; }

        /// <summary>Optional. Login credential for automated tests</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loginCredential")]
        public virtual GoogleFirebaseAppdistroV1alphaLoginCredential LoginCredential { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Statistics collected during a Robo test.</summary>
    public class GoogleFirebaseAppdistroV1alphaRoboStats : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Number of actions that crawler performed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionsPerformed")]
        public virtual System.Nullable<int> ActionsPerformed { get; set; }

        /// <summary>Output only. Duration of crawl.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crawlDuration")]
        public virtual object CrawlDuration { get; set; }

        /// <summary>Output only. Number of distinct screens visited.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("distinctVisitedScreens")]
        public virtual System.Nullable<int> DistinctVisitedScreens { get; set; }

        /// <summary>Output only. Whether the main activity crawl timed out.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mainActivityCrawlTimedOut")]
        public virtual System.Nullable<bool> MainActivityCrawlTimedOut { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A device screenshot taken during a test.</summary>
    public class GoogleFirebaseAppdistroV1alphaScreenshot : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The height of the screenshot, in pixels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("height")]
        public virtual System.Nullable<int> Height { get; set; }

        /// <summary>Output only. The URI of the screenshot.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>Output only. The width of the screenshot, in pixels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("width")]
        public virtual System.Nullable<int> Width { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An action taken by the AI to end the goal.</summary>
    public class GoogleFirebaseAppdistroV1alphaTerminalAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The reason why this goal was ended.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>Output only. The screenshot used in the context of this terminal action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("screenshot")]
        public virtual GoogleFirebaseAppdistroV1alphaScreenshot Screenshot { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>AI test cases</summary>
    public class GoogleFirebaseAppdistroV1alphaTestCase : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Instructions for AI driven test.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aiInstructions")]
        public virtual GoogleFirebaseAppdistroV1alphaAiInstructions AiInstructions { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Timestamp when the test case was created</summary>
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

        /// <summary>Required. Display name of the test case.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Identifier. The name of the test case resource. Format:
        /// `projects/{project_number}/apps/{app_id}/testCases/{test_case_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for automated tests</summary>
    public class GoogleFirebaseAppdistroV1alphaTestConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Display name of the AI driven test. Required if the release test is created with multiple goals.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Identifier. The name of the test configuration resource. Format:
        /// `projects/{project_number}/apps/{app_id}/testConfig`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. Configuration for Robo crawler</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roboCrawler")]
        public virtual GoogleFirebaseAppdistroV1alphaRoboCrawler RoboCrawler { get; set; }

        /// <summary>Optional. Tests will be run on this list of devices</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testDevices")]
        public virtual System.Collections.Generic.IList<GoogleFirebaseAppdistroV1alphaTestDevice> TestDevices { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A device on which automated tests can be run.</summary>
    public class GoogleFirebaseAppdistroV1alphaTestDevice : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The locale of the device (e.g. "en_US" for US English) during the test.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locale")]
        public virtual string Locale { get; set; }

        /// <summary>Required. The device model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("model")]
        public virtual string Model { get; set; }

        /// <summary>Optional. The orientation of the device during the test.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orientation")]
        public virtual string Orientation { get; set; }

        /// <summary>Required. The version of the device (API level on Android).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Customer quota information for `ReleaseTests`. Note: This quota only applies to tests with `AiInstructions` and
    /// is separate from the quota which might apply to the device time used by any tests.
    /// </summary>
    public class GoogleFirebaseAppdistroV1alphaTestQuota : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Maximum number of `ReleaseTests` allotted for the current month.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("limit")]
        public virtual System.Nullable<long> Limit { get; set; }

        /// <summary>
        /// Identifier. The name of the `TestQuota` resource. Format: `projects/{project_number}/testQuota`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Number of `ReleaseTests` run in the current month</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("usage")]
        public virtual System.Nullable<long> Usage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The UDIDs of a tester's iOS device</summary>
    public class GoogleFirebaseAppdistroV1alphaTesterUdid : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the tester's device</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The platform of the tester's device</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("platform")]
        public virtual string Platform { get; set; }

        /// <summary>The UDID of the tester's device</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("udid")]
        public virtual string Udid { get; set; }

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
}
