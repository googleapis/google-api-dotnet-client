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

namespace Google.Apis.Drive.v2
{
    /// <summary>The Drive Service.</summary>
    public class DriveService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v2";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public DriveService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public DriveService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            About = new AboutResource(this);
            Apps = new AppsResource(this);
            Changes = new ChangesResource(this);
            Channels = new ChannelsResource(this);
            Children = new ChildrenResource(this);
            Comments = new CommentsResource(this);
            Drives = new DrivesResource(this);
            Files = new FilesResource(this);
            Parents = new ParentsResource(this);
            Permissions = new PermissionsResource(this);
            Properties = new PropertiesResource(this);
            Replies = new RepliesResource(this);
            Revisions = new RevisionsResource(this);
            Teamdrives = new TeamdrivesResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://www.googleapis.com/drive/v2/");
            BatchUri = GetEffectiveUri(null, "https://www.googleapis.com/batch/drive/v2");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "drive";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "drive/v2/";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch/drive/v2";

        /// <summary>Available OAuth 2.0 scopes for use with the Google Drive API.</summary>
        public class Scope
        {
            /// <summary>See, edit, create, and delete all of your Google Drive files</summary>
            public static string Drive = "https://www.googleapis.com/auth/drive";

            /// <summary>See, create, and delete its own configuration data in your Google Drive</summary>
            public static string DriveAppdata = "https://www.googleapis.com/auth/drive.appdata";

            /// <summary>View your Google Drive apps</summary>
            public static string DriveAppsReadonly = "https://www.googleapis.com/auth/drive.apps.readonly";

            /// <summary>
            /// See, edit, create, and delete only the specific Google Drive files you use with this app
            /// </summary>
            public static string DriveFile = "https://www.googleapis.com/auth/drive.file";

            /// <summary>See and download your Google Drive files that were created or edited by Google Meet.</summary>
            public static string DriveMeetReadonly = "https://www.googleapis.com/auth/drive.meet.readonly";

            /// <summary>View and manage metadata of files in your Google Drive</summary>
            public static string DriveMetadata = "https://www.googleapis.com/auth/drive.metadata";

            /// <summary>See information about your Google Drive files</summary>
            public static string DriveMetadataReadonly = "https://www.googleapis.com/auth/drive.metadata.readonly";

            /// <summary>View the photos, videos and albums in your Google Photos</summary>
            public static string DrivePhotosReadonly = "https://www.googleapis.com/auth/drive.photos.readonly";

            /// <summary>See and download all your Google Drive files</summary>
            public static string DriveReadonly = "https://www.googleapis.com/auth/drive.readonly";

            /// <summary>Modify your Google Apps Script scripts' behavior</summary>
            public static string DriveScripts = "https://www.googleapis.com/auth/drive.scripts";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Google Drive API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, create, and delete all of your Google Drive files</summary>
            public const string Drive = "https://www.googleapis.com/auth/drive";

            /// <summary>See, create, and delete its own configuration data in your Google Drive</summary>
            public const string DriveAppdata = "https://www.googleapis.com/auth/drive.appdata";

            /// <summary>View your Google Drive apps</summary>
            public const string DriveAppsReadonly = "https://www.googleapis.com/auth/drive.apps.readonly";

            /// <summary>
            /// See, edit, create, and delete only the specific Google Drive files you use with this app
            /// </summary>
            public const string DriveFile = "https://www.googleapis.com/auth/drive.file";

            /// <summary>See and download your Google Drive files that were created or edited by Google Meet.</summary>
            public const string DriveMeetReadonly = "https://www.googleapis.com/auth/drive.meet.readonly";

            /// <summary>View and manage metadata of files in your Google Drive</summary>
            public const string DriveMetadata = "https://www.googleapis.com/auth/drive.metadata";

            /// <summary>See information about your Google Drive files</summary>
            public const string DriveMetadataReadonly = "https://www.googleapis.com/auth/drive.metadata.readonly";

            /// <summary>View the photos, videos and albums in your Google Photos</summary>
            public const string DrivePhotosReadonly = "https://www.googleapis.com/auth/drive.photos.readonly";

            /// <summary>See and download all your Google Drive files</summary>
            public const string DriveReadonly = "https://www.googleapis.com/auth/drive.readonly";

            /// <summary>Modify your Google Apps Script scripts' behavior</summary>
            public const string DriveScripts = "https://www.googleapis.com/auth/drive.scripts";
        }

        /// <summary>Gets the About resource.</summary>
        public virtual AboutResource About { get; }

        /// <summary>Gets the Apps resource.</summary>
        public virtual AppsResource Apps { get; }

        /// <summary>Gets the Changes resource.</summary>
        public virtual ChangesResource Changes { get; }

        /// <summary>Gets the Channels resource.</summary>
        public virtual ChannelsResource Channels { get; }

        /// <summary>Gets the Children resource.</summary>
        public virtual ChildrenResource Children { get; }

        /// <summary>Gets the Comments resource.</summary>
        public virtual CommentsResource Comments { get; }

        /// <summary>Gets the Drives resource.</summary>
        public virtual DrivesResource Drives { get; }

        /// <summary>Gets the Files resource.</summary>
        public virtual FilesResource Files { get; }

        /// <summary>Gets the Parents resource.</summary>
        public virtual ParentsResource Parents { get; }

        /// <summary>Gets the Permissions resource.</summary>
        public virtual PermissionsResource Permissions { get; }

        /// <summary>Gets the Properties resource.</summary>
        public virtual PropertiesResource Properties { get; }

        /// <summary>Gets the Replies resource.</summary>
        public virtual RepliesResource Replies { get; }

        /// <summary>Gets the Revisions resource.</summary>
        public virtual RevisionsResource Revisions { get; }

        /// <summary>Gets the Teamdrives resource.</summary>
        public virtual TeamdrivesResource Teamdrives { get; }
    }

    /// <summary>A base abstract class for Drive requests.</summary>
    public abstract class DriveBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new DriveBaseServiceRequest instance.</summary>
        protected DriveBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Drive parameter list.</summary>
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

    /// <summary>The "about" collection of methods.</summary>
    public class AboutResource
    {
        private const string Resource = "about";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public AboutResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Gets the information about the current user along with Drive API settings</summary>
        public virtual GetRequest Get()
        {
            return new GetRequest(this.service);
        }

        /// <summary>Gets the information about the current user along with Drive API settings</summary>
        public class GetRequest : DriveBaseServiceRequest<Google.Apis.Drive.v2.Data.About>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Whether to count changes outside the My Drive hierarchy. When set to false, changes to files such as
            /// those in the Application Data folder or shared files which have not been added to My Drive will be
            /// omitted from the `maxChangeIdCount`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("includeSubscribed", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> IncludeSubscribed { get; set; }

            /// <summary>Maximum number of remaining change IDs to count</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxChangeIdCount", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxChangeIdCount { get; set; }

            /// <summary>Change ID to start counting from when calculating number of remaining change IDs</summary>
            [Google.Apis.Util.RequestParameterAttribute("startChangeId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> StartChangeId { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "about";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("includeSubscribed", new Google.Apis.Discovery.Parameter
                {
                    Name = "includeSubscribed",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "true",
                    Pattern = null,
                });
                RequestParameters.Add("maxChangeIdCount", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxChangeIdCount",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "1",
                    Pattern = null,
                });
                RequestParameters.Add("startChangeId", new Google.Apis.Discovery.Parameter
                {
                    Name = "startChangeId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
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
        }

        /// <summary>Gets a specific app.</summary>
        /// <param name="appId">The ID of the app.</param>
        public virtual GetRequest Get(string appId)
        {
            return new GetRequest(this.service, appId);
        }

        /// <summary>Gets a specific app.</summary>
        public class GetRequest : DriveBaseServiceRequest<Google.Apis.Drive.v2.Data.App>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string appId) : base(service)
            {
                AppId = appId;
                InitParameters();
            }

            /// <summary>The ID of the app.</summary>
            [Google.Apis.Util.RequestParameterAttribute("appId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string AppId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "apps/{appId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("appId", new Google.Apis.Discovery.Parameter
                {
                    Name = "appId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Lists a user's installed apps.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>Lists a user's installed apps.</summary>
        public class ListRequest : DriveBaseServiceRequest<Google.Apis.Drive.v2.Data.AppList>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// A comma-separated list of file extensions for open with filtering. All apps within the given app query
            /// scope which can open any of the given file extensions will be included in the response. If
            /// `appFilterMimeTypes` are provided as well, the result is a union of the two resulting app lists.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("appFilterExtensions", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string AppFilterExtensions { get; set; }

            /// <summary>
            /// A comma-separated list of MIME types for open with filtering. All apps within the given app query scope
            /// which can open any of the given MIME types will be included in the response. If `appFilterExtensions`
            /// are provided as well, the result is a union of the two resulting app lists.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("appFilterMimeTypes", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string AppFilterMimeTypes { get; set; }

            /// <summary>
            /// A language or locale code, as defined by BCP 47, with some extensions from Unicode's LDML format
            /// (http://www.unicode.org/reports/tr35/).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("languageCode", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string LanguageCode { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "apps";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("appFilterExtensions", new Google.Apis.Discovery.Parameter
                {
                    Name = "appFilterExtensions",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("appFilterMimeTypes", new Google.Apis.Discovery.Parameter
                {
                    Name = "appFilterMimeTypes",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("languageCode", new Google.Apis.Discovery.Parameter
                {
                    Name = "languageCode",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "changes" collection of methods.</summary>
    public class ChangesResource
    {
        private const string Resource = "changes";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ChangesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Deprecated: Use `changes.getStartPageToken` and `changes.list` to retrieve recent changes.
        /// </summary>
        /// <param name="changeId">The ID of the change.</param>
        public virtual GetRequest Get(string changeId)
        {
            return new GetRequest(this.service, changeId);
        }

        /// <summary>
        /// Deprecated: Use `changes.getStartPageToken` and `changes.list` to retrieve recent changes.
        /// </summary>
        public class GetRequest : DriveBaseServiceRequest<Google.Apis.Drive.v2.Data.Change>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string changeId) : base(service)
            {
                ChangeId = changeId;
                InitParameters();
            }

            /// <summary>The ID of the change.</summary>
            [Google.Apis.Util.RequestParameterAttribute("changeId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ChangeId { get; private set; }

            /// <summary>The shared drive from which the change will be returned.</summary>
            [Google.Apis.Util.RequestParameterAttribute("driveId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string DriveId { get; set; }

            /// <summary>Whether the requesting application supports both My Drives and shared drives.</summary>
            [Google.Apis.Util.RequestParameterAttribute("supportsAllDrives", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> SupportsAllDrives { get; set; }

            /// <summary>Deprecated: Use `supportsAllDrives` instead.</summary>
            [Google.Apis.Util.RequestParameterAttribute("supportsTeamDrives", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> SupportsTeamDrives { get; set; }

            /// <summary>Deprecated: Use `driveId` instead.</summary>
            [Google.Apis.Util.RequestParameterAttribute("teamDriveId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string TeamDriveId { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "changes/{changeId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("changeId", new Google.Apis.Discovery.Parameter
                {
                    Name = "changeId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("driveId", new Google.Apis.Discovery.Parameter
                {
                    Name = "driveId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("supportsAllDrives", new Google.Apis.Discovery.Parameter
                {
                    Name = "supportsAllDrives",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("supportsTeamDrives", new Google.Apis.Discovery.Parameter
                {
                    Name = "supportsTeamDrives",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("teamDriveId", new Google.Apis.Discovery.Parameter
                {
                    Name = "teamDriveId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Gets the starting pageToken for listing future changes.</summary>
        public virtual GetStartPageTokenRequest GetStartPageToken()
        {
            return new GetStartPageTokenRequest(this.service);
        }

        /// <summary>Gets the starting pageToken for listing future changes.</summary>
        public class GetStartPageTokenRequest : DriveBaseServiceRequest<Google.Apis.Drive.v2.Data.StartPageToken>
        {
            /// <summary>Constructs a new GetStartPageToken request.</summary>
            public GetStartPageTokenRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// The ID of the shared drive for which the starting pageToken for listing future changes from that shared
            /// drive will be returned.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("driveId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string DriveId { get; set; }

            /// <summary>Whether the requesting application supports both My Drives and shared drives.</summary>
            [Google.Apis.Util.RequestParameterAttribute("supportsAllDrives", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> SupportsAllDrives { get; set; }

            /// <summary>Deprecated: Use `supportsAllDrives` instead.</summary>
            [Google.Apis.Util.RequestParameterAttribute("supportsTeamDrives", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> SupportsTeamDrives { get; set; }

            /// <summary>Deprecated: Use `driveId` instead.</summary>
            [Google.Apis.Util.RequestParameterAttribute("teamDriveId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string TeamDriveId { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getStartPageToken";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "changes/startPageToken";

            /// <summary>Initializes GetStartPageToken parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("driveId", new Google.Apis.Discovery.Parameter
                {
                    Name = "driveId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("supportsAllDrives", new Google.Apis.Discovery.Parameter
                {
                    Name = "supportsAllDrives",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("supportsTeamDrives", new Google.Apis.Discovery.Parameter
                {
                    Name = "supportsTeamDrives",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("teamDriveId", new Google.Apis.Discovery.Parameter
                {
                    Name = "teamDriveId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Lists the changes for a user or shared drive.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>Lists the changes for a user or shared drive.</summary>
        public class ListRequest : DriveBaseServiceRequest<Google.Apis.Drive.v2.Data.ChangeList>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// The shared drive from which changes will be returned. If specified the change IDs will be reflective of
            /// the shared drive; use the combined drive ID and change ID as an identifier.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("driveId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string DriveId { get; set; }

            /// <summary>
            /// Whether changes should include the file resource if the file is still accessible by the user at the time
            /// of the request, even when a file was removed from the list of changes and there will be no further
            /// change entries for this file.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("includeCorpusRemovals", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> IncludeCorpusRemovals { get; set; }

            /// <summary>
            /// Whether to include changes indicating that items have been removed from the list of changes, for example
            /// by deletion or loss of access.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("includeDeleted", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> IncludeDeleted { get; set; }

            /// <summary>Whether both My Drive and shared drive items should be included in results.</summary>
            [Google.Apis.Util.RequestParameterAttribute("includeItemsFromAllDrives", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> IncludeItemsFromAllDrives { get; set; }

            /// <summary>
            /// A comma-separated list of IDs of labels to include in the `labelInfo` part of the response.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("includeLabels", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string IncludeLabels { get; set; }

            /// <summary>
            /// Specifies which additional view's permissions to include in the response. Only `published` is supported.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("includePermissionsForView", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string IncludePermissionsForView { get; set; }

            /// <summary>
            /// Whether to include changes outside the My Drive hierarchy in the result. When set to false, changes to
            /// files such as those in the Application Data folder or shared files which have not been added to My Drive
            /// will be omitted from the result.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("includeSubscribed", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> IncludeSubscribed { get; set; }

            /// <summary>Deprecated: Use `includeItemsFromAllDrives` instead.</summary>
            [Google.Apis.Util.RequestParameterAttribute("includeTeamDriveItems", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> IncludeTeamDriveItems { get; set; }

            /// <summary>Maximum number of changes to return.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>
            /// The token for continuing a previous list request on the next page. This should be set to the value of
            /// `nextPageToken` from the previous response or to the response from the getStartPageToken method.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// A comma-separated list of spaces to query. Supported values are `drive`, `appDataFolder` and `photos`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("spaces", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Spaces { get; set; }

            /// <summary>Deprecated: Use `pageToken` instead.</summary>
            [Google.Apis.Util.RequestParameterAttribute("startChangeId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> StartChangeId { get; set; }

            /// <summary>Whether the requesting application supports both My Drives and shared drives.</summary>
            [Google.Apis.Util.RequestParameterAttribute("supportsAllDrives", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> SupportsAllDrives { get; set; }

            /// <summary>Deprecated: Use `supportsAllDrives` instead.</summary>
            [Google.Apis.Util.RequestParameterAttribute("supportsTeamDrives", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> SupportsTeamDrives { get; set; }

            /// <summary>Deprecated: Use `driveId` instead.</summary>
            [Google.Apis.Util.RequestParameterAttribute("teamDriveId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string TeamDriveId { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "changes";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("driveId", new Google.Apis.Discovery.Parameter
                {
                    Name = "driveId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("includeCorpusRemovals", new Google.Apis.Discovery.Parameter
                {
                    Name = "includeCorpusRemovals",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("includeDeleted", new Google.Apis.Discovery.Parameter
                {
                    Name = "includeDeleted",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "true",
                    Pattern = null,
                });
                RequestParameters.Add("includeItemsFromAllDrives", new Google.Apis.Discovery.Parameter
                {
                    Name = "includeItemsFromAllDrives",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("includeLabels", new Google.Apis.Discovery.Parameter
                {
                    Name = "includeLabels",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("includePermissionsForView", new Google.Apis.Discovery.Parameter
                {
                    Name = "includePermissionsForView",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("includeSubscribed", new Google.Apis.Discovery.Parameter
                {
                    Name = "includeSubscribed",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "true",
                    Pattern = null,
                });
                RequestParameters.Add("includeTeamDriveItems", new Google.Apis.Discovery.Parameter
                {
                    Name = "includeTeamDriveItems",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "100",
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
                RequestParameters.Add("spaces", new Google.Apis.Discovery.Parameter
                {
                    Name = "spaces",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("startChangeId", new Google.Apis.Discovery.Parameter
                {
                    Name = "startChangeId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("supportsAllDrives", new Google.Apis.Discovery.Parameter
                {
                    Name = "supportsAllDrives",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("supportsTeamDrives", new Google.Apis.Discovery.Parameter
                {
                    Name = "supportsTeamDrives",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("teamDriveId", new Google.Apis.Discovery.Parameter
                {
                    Name = "teamDriveId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Subscribe to changes for a user.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual WatchRequest Watch(Google.Apis.Drive.v2.Data.Channel body)
        {
            return new WatchRequest(this.service, body);
        }

        /// <summary>Subscribe to changes for a user.</summary>
        public class WatchRequest : DriveBaseServiceRequest<Google.Apis.Drive.v2.Data.Channel>
        {
            /// <summary>Constructs a new Watch request.</summary>
            public WatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Drive.v2.Data.Channel body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The shared drive from which changes will be returned. If specified the change IDs will be reflective of
            /// the shared drive; use the combined drive ID and change ID as an identifier.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("driveId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string DriveId { get; set; }

            /// <summary>
            /// Whether changes should include the file resource if the file is still accessible by the user at the time
            /// of the request, even when a file was removed from the list of changes and there will be no further
            /// change entries for this file.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("includeCorpusRemovals", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> IncludeCorpusRemovals { get; set; }

            /// <summary>
            /// Whether to include changes indicating that items have been removed from the list of changes, for example
            /// by deletion or loss of access.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("includeDeleted", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> IncludeDeleted { get; set; }

            /// <summary>Whether both My Drive and shared drive items should be included in results.</summary>
            [Google.Apis.Util.RequestParameterAttribute("includeItemsFromAllDrives", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> IncludeItemsFromAllDrives { get; set; }

            /// <summary>
            /// A comma-separated list of IDs of labels to include in the `labelInfo` part of the response.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("includeLabels", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string IncludeLabels { get; set; }

            /// <summary>
            /// Specifies which additional view's permissions to include in the response. Only `published` is supported.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("includePermissionsForView", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string IncludePermissionsForView { get; set; }

            /// <summary>
            /// Whether to include changes outside the My Drive hierarchy in the result. When set to false, changes to
            /// files such as those in the Application Data folder or shared files which have not been added to My Drive
            /// will be omitted from the result.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("includeSubscribed", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> IncludeSubscribed { get; set; }

            /// <summary>Deprecated: Use `includeItemsFromAllDrives` instead.</summary>
            [Google.Apis.Util.RequestParameterAttribute("includeTeamDriveItems", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> IncludeTeamDriveItems { get; set; }

            /// <summary>Maximum number of changes to return.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>
            /// The token for continuing a previous list request on the next page. This should be set to the value of
            /// `nextPageToken` from the previous response or to the response from the getStartPageToken method.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// A comma-separated list of spaces to query. Supported values are `drive`, `appDataFolder` and `photos`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("spaces", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Spaces { get; set; }

            /// <summary>Deprecated: Use `pageToken` instead.</summary>
            [Google.Apis.Util.RequestParameterAttribute("startChangeId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> StartChangeId { get; set; }

            /// <summary>Whether the requesting application supports both My Drives and shared drives.</summary>
            [Google.Apis.Util.RequestParameterAttribute("supportsAllDrives", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> SupportsAllDrives { get; set; }

            /// <summary>Deprecated: Use `supportsAllDrives` instead.</summary>
            [Google.Apis.Util.RequestParameterAttribute("supportsTeamDrives", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> SupportsTeamDrives { get; set; }

            /// <summary>Deprecated: Use `driveId` instead.</summary>
            [Google.Apis.Util.RequestParameterAttribute("teamDriveId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string TeamDriveId { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Drive.v2.Data.Channel Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "watch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "changes/watch";

            /// <summary>Initializes Watch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("driveId", new Google.Apis.Discovery.Parameter
                {
                    Name = "driveId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("includeCorpusRemovals", new Google.Apis.Discovery.Parameter
                {
                    Name = "includeCorpusRemovals",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("includeDeleted", new Google.Apis.Discovery.Parameter
                {
                    Name = "includeDeleted",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "true",
                    Pattern = null,
                });
                RequestParameters.Add("includeItemsFromAllDrives", new Google.Apis.Discovery.Parameter
                {
                    Name = "includeItemsFromAllDrives",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("includeLabels", new Google.Apis.Discovery.Parameter
                {
                    Name = "includeLabels",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("includePermissionsForView", new Google.Apis.Discovery.Parameter
                {
                    Name = "includePermissionsForView",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("includeSubscribed", new Google.Apis.Discovery.Parameter
                {
                    Name = "includeSubscribed",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "true",
                    Pattern = null,
                });
                RequestParameters.Add("includeTeamDriveItems", new Google.Apis.Discovery.Parameter
                {
                    Name = "includeTeamDriveItems",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "100",
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
                RequestParameters.Add("spaces", new Google.Apis.Discovery.Parameter
                {
                    Name = "spaces",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("startChangeId", new Google.Apis.Discovery.Parameter
                {
                    Name = "startChangeId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("supportsAllDrives", new Google.Apis.Discovery.Parameter
                {
                    Name = "supportsAllDrives",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("supportsTeamDrives", new Google.Apis.Discovery.Parameter
                {
                    Name = "supportsTeamDrives",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("teamDriveId", new Google.Apis.Discovery.Parameter
                {
                    Name = "teamDriveId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "channels" collection of methods.</summary>
    public class ChannelsResource
    {
        private const string Resource = "channels";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ChannelsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Stops watching resources through this channel.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual StopRequest Stop(Google.Apis.Drive.v2.Data.Channel body)
        {
            return new StopRequest(this.service, body);
        }

        /// <summary>Stops watching resources through this channel.</summary>
        public class StopRequest : DriveBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Stop request.</summary>
            public StopRequest(Google.Apis.Services.IClientService service, Google.Apis.Drive.v2.Data.Channel body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Drive.v2.Data.Channel Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "stop";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "channels/stop";

            /// <summary>Initializes Stop parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }

    /// <summary>The "children" collection of methods.</summary>
    public class ChildrenResource
    {
        private const string Resource = "children";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ChildrenResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Removes a child from a folder.</summary>
        /// <param name="folderId">The ID of the folder.</param>
        /// <param name="childId">The ID of the child.</param>
        public virtual DeleteRequest Delete(string folderId, string childId)
        {
            return new DeleteRequest(this.service, folderId, childId);
        }

        /// <summary>Removes a child from a folder.</summary>
        public class DeleteRequest : DriveBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string folderId, string childId) : base(service)
            {
                FolderId = folderId;
                ChildId = childId;
                InitParameters();
            }

            /// <summary>The ID of the folder.</summary>
            [Google.Apis.Util.RequestParameterAttribute("folderId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string FolderId { get; private set; }

            /// <summary>The ID of the child.</summary>
            [Google.Apis.Util.RequestParameterAttribute("childId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ChildId { get; private set; }

            /// <summary>
            /// Deprecated: If an item is not in a shared drive and its last parent is removed, the item is placed under
            /// its owner's root.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("enforceSingleParent", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> EnforceSingleParent { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "files/{folderId}/children/{childId}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("folderId", new Google.Apis.Discovery.Parameter
                {
                    Name = "folderId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("childId", new Google.Apis.Discovery.Parameter
                {
                    Name = "childId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("enforceSingleParent", new Google.Apis.Discovery.Parameter
                {
                    Name = "enforceSingleParent",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
            }
        }

        /// <summary>Gets a specific child reference.</summary>
        /// <param name="folderId">The ID of the folder.</param>
        /// <param name="childId">The ID of the child.</param>
        public virtual GetRequest Get(string folderId, string childId)
        {
            return new GetRequest(this.service, folderId, childId);
        }

        /// <summary>Gets a specific child reference.</summary>
        public class GetRequest : DriveBaseServiceRequest<Google.Apis.Drive.v2.Data.ChildReference>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string folderId, string childId) : base(service)
            {
                FolderId = folderId;
                ChildId = childId;
                InitParameters();
            }

            /// <summary>The ID of the folder.</summary>
            [Google.Apis.Util.RequestParameterAttribute("folderId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string FolderId { get; private set; }

            /// <summary>The ID of the child.</summary>
            [Google.Apis.Util.RequestParameterAttribute("childId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ChildId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "files/{folderId}/children/{childId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("folderId", new Google.Apis.Discovery.Parameter
                {
                    Name = "folderId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("childId", new Google.Apis.Discovery.Parameter
                {
                    Name = "childId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Inserts a file into a folder.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="folderId">The ID of the folder.</param>
        public virtual InsertRequest Insert(Google.Apis.Drive.v2.Data.ChildReference body, string folderId)
        {
            return new InsertRequest(this.service, body, folderId);
        }

        /// <summary>Inserts a file into a folder.</summary>
        public class InsertRequest : DriveBaseServiceRequest<Google.Apis.Drive.v2.Data.ChildReference>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Drive.v2.Data.ChildReference body, string folderId) : base(service)
            {
                FolderId = folderId;
                Body = body;
                InitParameters();
            }

            /// <summary>The ID of the folder.</summary>
            [Google.Apis.Util.RequestParameterAttribute("folderId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string FolderId { get; private set; }

            /// <summary>
            /// Deprecated: Adding files to multiple folders is no longer supported. Use `shortcuts` instead.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("enforceSingleParent", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> EnforceSingleParent { get; set; }

            /// <summary>Whether the requesting application supports both My Drives and shared drives.</summary>
            [Google.Apis.Util.RequestParameterAttribute("supportsAllDrives", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> SupportsAllDrives { get; set; }

            /// <summary>Deprecated: Use `supportsAllDrives` instead.</summary>
            [Google.Apis.Util.RequestParameterAttribute("supportsTeamDrives", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> SupportsTeamDrives { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Drive.v2.Data.ChildReference Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "files/{folderId}/children";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("folderId", new Google.Apis.Discovery.Parameter
                {
                    Name = "folderId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("enforceSingleParent", new Google.Apis.Discovery.Parameter
                {
                    Name = "enforceSingleParent",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("supportsAllDrives", new Google.Apis.Discovery.Parameter
                {
                    Name = "supportsAllDrives",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("supportsTeamDrives", new Google.Apis.Discovery.Parameter
                {
                    Name = "supportsTeamDrives",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
            }
        }

        /// <summary>Lists a folder's children.</summary>
        /// <param name="folderId">The ID of the folder.</param>
        public virtual ListRequest List(string folderId)
        {
            return new ListRequest(this.service, folderId);
        }

        /// <summary>Lists a folder's children.</summary>
        public class ListRequest : DriveBaseServiceRequest<Google.Apis.Drive.v2.Data.ChildList>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string folderId) : base(service)
            {
                FolderId = folderId;
                InitParameters();
            }

            /// <summary>The ID of the folder.</summary>
            [Google.Apis.Util.RequestParameterAttribute("folderId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string FolderId { get; private set; }

            /// <summary>Maximum number of children to return.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>
            /// A comma-separated list of sort keys. Valid keys are `createdDate`, `folder`, `lastViewedByMeDate`,
            /// `modifiedByMeDate`, `modifiedDate`, `quotaBytesUsed`, `recency`, `sharedWithMeDate`, `starred`, and
            /// `title`. Each key sorts ascending by default, but may be reversed with the `desc` modifier. Example
            /// usage: ?orderBy=folder,modifiedDate desc,title. Please note that there is a current limitation for users
            /// with approximately one million files in which the requested sort order is ignored.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OrderBy { get; set; }

            /// <summary>Page token for children.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Query string for searching children.</summary>
            [Google.Apis.Util.RequestParameterAttribute("q", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Q { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "files/{folderId}/children";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("folderId", new Google.Apis.Discovery.Parameter
                {
                    Name = "folderId",
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
                    DefaultValue = "100",
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
                RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageToken",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("q", new Google.Apis.Discovery.Parameter
                {
                    Name = "q",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "comments" collection of methods.</summary>
    public class CommentsResource
    {
        private const string Resource = "comments";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public CommentsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Deletes a comment.</summary>
        /// <param name="fileId">The ID of the file.</param>
        /// <param name="commentId">The ID of the comment.</param>
        public virtual DeleteRequest Delete(string fileId, string commentId)
        {
            return new DeleteRequest(this.service, fileId, commentId);
        }

        /// <summary>Deletes a comment.</summary>
        public class DeleteRequest : DriveBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string fileId, string commentId) : base(service)
            {
                FileId = fileId;
                CommentId = commentId;
                InitParameters();
            }

            /// <summary>The ID of the file.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fileId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string FileId { get; private set; }

            /// <summary>The ID of the comment.</summary>
            [Google.Apis.Util.RequestParameterAttribute("commentId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CommentId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "files/{fileId}/comments/{commentId}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("fileId", new Google.Apis.Discovery.Parameter
                {
                    Name = "fileId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("commentId", new Google.Apis.Discovery.Parameter
                {
                    Name = "commentId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Gets a comment by ID.</summary>
        /// <param name="fileId">The ID of the file.</param>
        /// <param name="commentId">The ID of the comment.</param>
        public virtual GetRequest Get(string fileId, string commentId)
        {
            return new GetRequest(this.service, fileId, commentId);
        }

        /// <summary>Gets a comment by ID.</summary>
        public class GetRequest : DriveBaseServiceRequest<Google.Apis.Drive.v2.Data.Comment>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string fileId, string commentId) : base(service)
            {
                FileId = fileId;
                CommentId = commentId;
                InitParameters();
            }

            /// <summary>The ID of the file.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fileId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string FileId { get; private set; }

            /// <summary>The ID of the comment.</summary>
            [Google.Apis.Util.RequestParameterAttribute("commentId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CommentId { get; private set; }

            /// <summary>
            /// If set, this will succeed when retrieving a deleted comment, and will include any deleted replies.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("includeDeleted", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> IncludeDeleted { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "files/{fileId}/comments/{commentId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("fileId", new Google.Apis.Discovery.Parameter
                {
                    Name = "fileId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("commentId", new Google.Apis.Discovery.Parameter
                {
                    Name = "commentId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("includeDeleted", new Google.Apis.Discovery.Parameter
                {
                    Name = "includeDeleted",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
            }
        }

        /// <summary>Creates a new comment on the given file.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="fileId">The ID of the file.</param>
        public virtual InsertRequest Insert(Google.Apis.Drive.v2.Data.Comment body, string fileId)
        {
            return new InsertRequest(this.service, body, fileId);
        }

        /// <summary>Creates a new comment on the given file.</summary>
        public class InsertRequest : DriveBaseServiceRequest<Google.Apis.Drive.v2.Data.Comment>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Drive.v2.Data.Comment body, string fileId) : base(service)
            {
                FileId = fileId;
                Body = body;
                InitParameters();
            }

            /// <summary>The ID of the file.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fileId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string FileId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Drive.v2.Data.Comment Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "files/{fileId}/comments";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("fileId", new Google.Apis.Discovery.Parameter
                {
                    Name = "fileId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Lists a file's comments.</summary>
        /// <param name="fileId">The ID of the file.</param>
        public virtual ListRequest List(string fileId)
        {
            return new ListRequest(this.service, fileId);
        }

        /// <summary>Lists a file's comments.</summary>
        public class ListRequest : DriveBaseServiceRequest<Google.Apis.Drive.v2.Data.CommentList>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string fileId) : base(service)
            {
                FileId = fileId;
                InitParameters();
            }

            /// <summary>The ID of the file.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fileId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string FileId { get; private set; }

            /// <summary>
            /// If set, all comments and replies, including deleted comments and replies (with content stripped) will be
            /// returned.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("includeDeleted", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> IncludeDeleted { get; set; }

            /// <summary>The maximum number of discussions to include in the response, used for paging.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>
            /// The continuation token, used to page through large result sets. To get the next page of results, set
            /// this parameter to the value of "nextPageToken" from the previous response.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// Only discussions that were updated after this timestamp will be returned. Formatted as an RFC 3339
            /// timestamp.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("updatedMin", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UpdatedMin { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "files/{fileId}/comments";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("fileId", new Google.Apis.Discovery.Parameter
                {
                    Name = "fileId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("includeDeleted", new Google.Apis.Discovery.Parameter
                {
                    Name = "includeDeleted",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "20",
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
                RequestParameters.Add("updatedMin", new Google.Apis.Discovery.Parameter
                {
                    Name = "updatedMin",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates an existing comment.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="fileId">The ID of the file.</param>
        /// <param name="commentId">The ID of the comment.</param>
        public virtual PatchRequest Patch(Google.Apis.Drive.v2.Data.Comment body, string fileId, string commentId)
        {
            return new PatchRequest(this.service, body, fileId, commentId);
        }

        /// <summary>Updates an existing comment.</summary>
        public class PatchRequest : DriveBaseServiceRequest<Google.Apis.Drive.v2.Data.Comment>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Drive.v2.Data.Comment body, string fileId, string commentId) : base(service)
            {
                FileId = fileId;
                CommentId = commentId;
                Body = body;
                InitParameters();
            }

            /// <summary>The ID of the file.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fileId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string FileId { get; private set; }

            /// <summary>The ID of the comment.</summary>
            [Google.Apis.Util.RequestParameterAttribute("commentId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CommentId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Drive.v2.Data.Comment Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "files/{fileId}/comments/{commentId}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("fileId", new Google.Apis.Discovery.Parameter
                {
                    Name = "fileId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("commentId", new Google.Apis.Discovery.Parameter
                {
                    Name = "commentId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates an existing comment.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="fileId">The ID of the file.</param>
        /// <param name="commentId">The ID of the comment.</param>
        public virtual UpdateRequest Update(Google.Apis.Drive.v2.Data.Comment body, string fileId, string commentId)
        {
            return new UpdateRequest(this.service, body, fileId, commentId);
        }

        /// <summary>Updates an existing comment.</summary>
        public class UpdateRequest : DriveBaseServiceRequest<Google.Apis.Drive.v2.Data.Comment>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Drive.v2.Data.Comment body, string fileId, string commentId) : base(service)
            {
                FileId = fileId;
                CommentId = commentId;
                Body = body;
                InitParameters();
            }

            /// <summary>The ID of the file.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fileId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string FileId { get; private set; }

            /// <summary>The ID of the comment.</summary>
            [Google.Apis.Util.RequestParameterAttribute("commentId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CommentId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Drive.v2.Data.Comment Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "files/{fileId}/comments/{commentId}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("fileId", new Google.Apis.Discovery.Parameter
                {
                    Name = "fileId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("commentId", new Google.Apis.Discovery.Parameter
                {
                    Name = "commentId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "drives" collection of methods.</summary>
    public class DrivesResource
    {
        private const string Resource = "drives";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public DrivesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Permanently deletes a shared drive for which the user is an `organizer`. The shared drive cannot contain any
        /// untrashed items.
        /// </summary>
        /// <param name="driveId">The ID of the shared drive.</param>
        public virtual DeleteRequest Delete(string driveId)
        {
            return new DeleteRequest(this.service, driveId);
        }

        /// <summary>
        /// Permanently deletes a shared drive for which the user is an `organizer`. The shared drive cannot contain any
        /// untrashed items.
        /// </summary>
        public class DeleteRequest : DriveBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string driveId) : base(service)
            {
                DriveId = driveId;
                InitParameters();
            }

            /// <summary>The ID of the shared drive.</summary>
            [Google.Apis.Util.RequestParameterAttribute("driveId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DriveId { get; private set; }

            /// <summary>
            /// Whether any items inside the shared drive should also be deleted. This option is only supported when
            /// `useDomainAdminAccess` is also set to `true`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("allowItemDeletion", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> AllowItemDeletion { get; set; }

            /// <summary>
            /// Issue the request as a domain administrator; if set to true, then the requester will be granted access
            /// if they are an administrator of the domain to which the shared drive belongs.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("useDomainAdminAccess", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> UseDomainAdminAccess { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "drives/{driveId}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("driveId", new Google.Apis.Discovery.Parameter
                {
                    Name = "driveId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("allowItemDeletion", new Google.Apis.Discovery.Parameter
                {
                    Name = "allowItemDeletion",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("useDomainAdminAccess", new Google.Apis.Discovery.Parameter
                {
                    Name = "useDomainAdminAccess",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
            }
        }

        /// <summary>Gets a shared drive's metadata by ID.</summary>
        /// <param name="driveId">The ID of the shared drive.</param>
        public virtual GetRequest Get(string driveId)
        {
            return new GetRequest(this.service, driveId);
        }

        /// <summary>Gets a shared drive's metadata by ID.</summary>
        public class GetRequest : DriveBaseServiceRequest<Google.Apis.Drive.v2.Data.Drive>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string driveId) : base(service)
            {
                DriveId = driveId;
                InitParameters();
            }

            /// <summary>The ID of the shared drive.</summary>
            [Google.Apis.Util.RequestParameterAttribute("driveId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DriveId { get; private set; }

            /// <summary>
            /// Issue the request as a domain administrator; if set to true, then the requester will be granted access
            /// if they are an administrator of the domain to which the shared drive belongs.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("useDomainAdminAccess", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> UseDomainAdminAccess { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "drives/{driveId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("driveId", new Google.Apis.Discovery.Parameter
                {
                    Name = "driveId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("useDomainAdminAccess", new Google.Apis.Discovery.Parameter
                {
                    Name = "useDomainAdminAccess",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
            }
        }

        /// <summary>Hides a shared drive from the default view.</summary>
        /// <param name="driveId">The ID of the shared drive.</param>
        public virtual HideRequest Hide(string driveId)
        {
            return new HideRequest(this.service, driveId);
        }

        /// <summary>Hides a shared drive from the default view.</summary>
        public class HideRequest : DriveBaseServiceRequest<Google.Apis.Drive.v2.Data.Drive>
        {
            /// <summary>Constructs a new Hide request.</summary>
            public HideRequest(Google.Apis.Services.IClientService service, string driveId) : base(service)
            {
                DriveId = driveId;
                InitParameters();
            }

            /// <summary>The ID of the shared drive.</summary>
            [Google.Apis.Util.RequestParameterAttribute("driveId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DriveId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "hide";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "drives/{driveId}/hide";

            /// <summary>Initializes Hide parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("driveId", new Google.Apis.Discovery.Parameter
                {
                    Name = "driveId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Creates a new shared drive.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="requestId">
        /// Required. An ID, such as a random UUID, which uniquely identifies this user's request for idempotent
        /// creation of a shared drive. A repeated request by the same user and with the same request ID will avoid
        /// creating duplicates by attempting to create the same shared drive. If the shared drive already exists a 409
        /// error will be returned.
        /// </param>
        public virtual InsertRequest Insert(Google.Apis.Drive.v2.Data.Drive body, string requestId)
        {
            return new InsertRequest(this.service, body, requestId);
        }

        /// <summary>Creates a new shared drive.</summary>
        public class InsertRequest : DriveBaseServiceRequest<Google.Apis.Drive.v2.Data.Drive>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Drive.v2.Data.Drive body, string requestId) : base(service)
            {
                RequestId = requestId;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. An ID, such as a random UUID, which uniquely identifies this user's request for idempotent
            /// creation of a shared drive. A repeated request by the same user and with the same request ID will avoid
            /// creating duplicates by attempting to create the same shared drive. If the shared drive already exists a
            /// 409 error will be returned.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string RequestId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Drive.v2.Data.Drive Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "drives";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                {
                    Name = "requestId",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        ///  Lists the user's shared drives. This method accepts the `q` parameter, which is a search query combining
        /// one or more search terms. For more information, see the [Search for shared
        /// drives](/workspace/drive/api/guides/search-shareddrives) guide.
        /// </summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>
        ///  Lists the user's shared drives. This method accepts the `q` parameter, which is a search query combining
        /// one or more search terms. For more information, see the [Search for shared
        /// drives](/workspace/drive/api/guides/search-shareddrives) guide.
        /// </summary>
        public class ListRequest : DriveBaseServiceRequest<Google.Apis.Drive.v2.Data.DriveList>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>Maximum number of shared drives to return per page.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>Page token for shared drives.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Query string for searching shared drives.</summary>
            [Google.Apis.Util.RequestParameterAttribute("q", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Q { get; set; }

            /// <summary>
            /// Issue the request as a domain administrator; if set to true, then all shared drives of the domain in
            /// which the requester is an administrator are returned.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("useDomainAdminAccess", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> UseDomainAdminAccess { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "drives";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "10",
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
                RequestParameters.Add("q", new Google.Apis.Discovery.Parameter
                {
                    Name = "q",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("useDomainAdminAccess", new Google.Apis.Discovery.Parameter
                {
                    Name = "useDomainAdminAccess",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
            }
        }

        /// <summary>Restores a shared drive to the default view.</summary>
        /// <param name="driveId">The ID of the shared drive.</param>
        public virtual UnhideRequest Unhide(string driveId)
        {
            return new UnhideRequest(this.service, driveId);
        }

        /// <summary>Restores a shared drive to the default view.</summary>
        public class UnhideRequest : DriveBaseServiceRequest<Google.Apis.Drive.v2.Data.Drive>
        {
            /// <summary>Constructs a new Unhide request.</summary>
            public UnhideRequest(Google.Apis.Services.IClientService service, string driveId) : base(service)
            {
                DriveId = driveId;
                InitParameters();
            }

            /// <summary>The ID of the shared drive.</summary>
            [Google.Apis.Util.RequestParameterAttribute("driveId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DriveId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "unhide";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "drives/{driveId}/unhide";

            /// <summary>Initializes Unhide parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("driveId", new Google.Apis.Discovery.Parameter
                {
                    Name = "driveId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates the metadata for a shared drive.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="driveId">The ID of the shared drive.</param>
        public virtual UpdateRequest Update(Google.Apis.Drive.v2.Data.Drive body, string driveId)
        {
            return new UpdateRequest(this.service, body, driveId);
        }

        /// <summary>Updates the metadata for a shared drive.</summary>
        public class UpdateRequest : DriveBaseServiceRequest<Google.Apis.Drive.v2.Data.Drive>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Drive.v2.Data.Drive body, string driveId) : base(service)
            {
                DriveId = driveId;
                Body = body;
                InitParameters();
            }

            /// <summary>The ID of the shared drive.</summary>
            [Google.Apis.Util.RequestParameterAttribute("driveId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DriveId { get; private set; }

            /// <summary>
            /// Issue the request as a domain administrator; if set to true, then the requester will be granted access
            /// if they are an administrator of the domain to which the shared drive belongs.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("useDomainAdminAccess", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> UseDomainAdminAccess { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Drive.v2.Data.Drive Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "drives/{driveId}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("driveId", new Google.Apis.Discovery.Parameter
                {
                    Name = "driveId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("useDomainAdminAccess", new Google.Apis.Discovery.Parameter
                {
                    Name = "useDomainAdminAccess",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
            }
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

        /// <summary>Creates a copy of the specified file.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="fileId">The ID of the file to copy.</param>
        public virtual CopyRequest Copy(Google.Apis.Drive.v2.Data.File body, string fileId)
        {
            return new CopyRequest(this.service, body, fileId);
        }

        /// <summary>Creates a copy of the specified file.</summary>
        public class CopyRequest : DriveBaseServiceRequest<Google.Apis.Drive.v2.Data.File>
        {
            /// <summary>Constructs a new Copy request.</summary>
            public CopyRequest(Google.Apis.Services.IClientService service, Google.Apis.Drive.v2.Data.File body, string fileId) : base(service)
            {
                FileId = fileId;
                Body = body;
                InitParameters();
            }

            /// <summary>The ID of the file to copy.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fileId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string FileId { get; private set; }

            /// <summary>Whether to convert this file to the corresponding Docs Editors format.</summary>
            [Google.Apis.Util.RequestParameterAttribute("convert", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Convert { get; set; }

            /// <summary>
            /// Deprecated: Copying files into multiple folders is no longer supported. Use shortcuts instead.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("enforceSingleParent", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> EnforceSingleParent { get; set; }

            /// <summary>
            /// A comma-separated list of IDs of labels to include in the `labelInfo` part of the response.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("includeLabels", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string IncludeLabels { get; set; }

            /// <summary>
            /// Specifies which additional view's permissions to include in the response. Only `published` is supported.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("includePermissionsForView", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string IncludePermissionsForView { get; set; }

            /// <summary>Whether to attempt OCR on .jpg, .png, .gif, or .pdf uploads.</summary>
            [Google.Apis.Util.RequestParameterAttribute("ocr", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Ocr { get; set; }

            /// <summary>If `ocr` is true, hints at the language to use. Valid values are BCP 47 codes.</summary>
            [Google.Apis.Util.RequestParameterAttribute("ocrLanguage", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OcrLanguage { get; set; }

            /// <summary>
            /// Whether to pin the head revision of the new copy. A file can have a maximum of 200 pinned revisions.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pinned", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Pinned { get; set; }

            /// <summary>Whether the requesting application supports both My Drives and shared drives.</summary>
            [Google.Apis.Util.RequestParameterAttribute("supportsAllDrives", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> SupportsAllDrives { get; set; }

            /// <summary>Deprecated: Use `supportsAllDrives` instead.</summary>
            [Google.Apis.Util.RequestParameterAttribute("supportsTeamDrives", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> SupportsTeamDrives { get; set; }

            /// <summary>The language of the timed text.</summary>
            [Google.Apis.Util.RequestParameterAttribute("timedTextLanguage", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string TimedTextLanguage { get; set; }

            /// <summary>The timed text track name.</summary>
            [Google.Apis.Util.RequestParameterAttribute("timedTextTrackName", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string TimedTextTrackName { get; set; }

            /// <summary>
            /// The visibility of the new file. This parameter is only relevant when the source is not a native Google
            /// Doc and convert=false.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("visibility", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<VisibilityEnum> Visibility { get; set; }

            /// <summary>
            /// The visibility of the new file. This parameter is only relevant when the source is not a native Google
            /// Doc and convert=false.
            /// </summary>
            public enum VisibilityEnum
            {
                /// <summary>
                /// The visibility of the new file is determined by the user's default visibility/sharing policies.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("DEFAULT")]
                DEFAULT__ = 0,

                /// <summary>The new file will be visible to only the owner.</summary>
                [Google.Apis.Util.StringValueAttribute("PRIVATE")]
                PRIVATE__ = 1,
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Drive.v2.Data.File Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "copy";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "files/{fileId}/copy";

            /// <summary>Initializes Copy parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("fileId", new Google.Apis.Discovery.Parameter
                {
                    Name = "fileId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("convert", new Google.Apis.Discovery.Parameter
                {
                    Name = "convert",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("enforceSingleParent", new Google.Apis.Discovery.Parameter
                {
                    Name = "enforceSingleParent",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("includeLabels", new Google.Apis.Discovery.Parameter
                {
                    Name = "includeLabels",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("includePermissionsForView", new Google.Apis.Discovery.Parameter
                {
                    Name = "includePermissionsForView",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ocr", new Google.Apis.Discovery.Parameter
                {
                    Name = "ocr",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("ocrLanguage", new Google.Apis.Discovery.Parameter
                {
                    Name = "ocrLanguage",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("pinned", new Google.Apis.Discovery.Parameter
                {
                    Name = "pinned",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("supportsAllDrives", new Google.Apis.Discovery.Parameter
                {
                    Name = "supportsAllDrives",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("supportsTeamDrives", new Google.Apis.Discovery.Parameter
                {
                    Name = "supportsTeamDrives",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("timedTextLanguage", new Google.Apis.Discovery.Parameter
                {
                    Name = "timedTextLanguage",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("timedTextTrackName", new Google.Apis.Discovery.Parameter
                {
                    Name = "timedTextTrackName",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("visibility", new Google.Apis.Discovery.Parameter
                {
                    Name = "visibility",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "DEFAULT",
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Permanently deletes a file owned by the user without moving it to the trash. If the file belongs to a shared
        /// drive, the user must be an `organizer` on the parent folder. If the target is a folder, all descendants
        /// owned by the user are also deleted.
        /// </summary>
        /// <param name="fileId">The ID of the file to delete.</param>
        public virtual DeleteRequest Delete(string fileId)
        {
            return new DeleteRequest(this.service, fileId);
        }

        /// <summary>
        /// Permanently deletes a file owned by the user without moving it to the trash. If the file belongs to a shared
        /// drive, the user must be an `organizer` on the parent folder. If the target is a folder, all descendants
        /// owned by the user are also deleted.
        /// </summary>
        public class DeleteRequest : DriveBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string fileId) : base(service)
            {
                FileId = fileId;
                InitParameters();
            }

            /// <summary>The ID of the file to delete.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fileId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string FileId { get; private set; }

            /// <summary>
            /// Deprecated: If an item is not in a shared drive and its last parent is deleted but the item itself is
            /// not, the item is placed under its owner's root.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("enforceSingleParent", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> EnforceSingleParent { get; set; }

            /// <summary>Whether the requesting application supports both My Drives and shared drives.</summary>
            [Google.Apis.Util.RequestParameterAttribute("supportsAllDrives", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> SupportsAllDrives { get; set; }

            /// <summary>Deprecated: Use `supportsAllDrives` instead.</summary>
            [Google.Apis.Util.RequestParameterAttribute("supportsTeamDrives", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> SupportsTeamDrives { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "files/{fileId}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("fileId", new Google.Apis.Discovery.Parameter
                {
                    Name = "fileId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("enforceSingleParent", new Google.Apis.Discovery.Parameter
                {
                    Name = "enforceSingleParent",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("supportsAllDrives", new Google.Apis.Discovery.Parameter
                {
                    Name = "supportsAllDrives",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("supportsTeamDrives", new Google.Apis.Discovery.Parameter
                {
                    Name = "supportsTeamDrives",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
            }
        }

        /// <summary>Permanently deletes all of the user's trashed files.</summary>
        public virtual EmptyTrashRequest EmptyTrash()
        {
            return new EmptyTrashRequest(this.service);
        }

        /// <summary>Permanently deletes all of the user's trashed files.</summary>
        public class EmptyTrashRequest : DriveBaseServiceRequest<string>
        {
            /// <summary>Constructs a new EmptyTrash request.</summary>
            public EmptyTrashRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>If set, empties the trash of the provided shared drive.</summary>
            [Google.Apis.Util.RequestParameterAttribute("driveId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string DriveId { get; set; }

            /// <summary>
            /// Deprecated: If an item is not in a shared drive and its last parent is deleted but the item itself is
            /// not, the item is placed under its owner's root.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("enforceSingleParent", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> EnforceSingleParent { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "emptyTrash";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "files/trash";

            /// <summary>Initializes EmptyTrash parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("driveId", new Google.Apis.Discovery.Parameter
                {
                    Name = "driveId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("enforceSingleParent", new Google.Apis.Discovery.Parameter
                {
                    Name = "enforceSingleParent",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Exports a Google Workspace document to the requested MIME type and returns exported byte content. Note that
        /// the exported content is limited to 10MB.
        /// </summary>
        /// <param name="fileId">The ID of the file.</param>
        /// <param name="mimeType">Required. The MIME type of the format requested for this export.</param>
        public virtual ExportRequest Export(string fileId, string mimeType)
        {
            return new ExportRequest(this.service, fileId, mimeType);
        }

        /// <summary>
        /// Exports a Google Workspace document to the requested MIME type and returns exported byte content. Note that
        /// the exported content is limited to 10MB.
        /// </summary>
        public class ExportRequest : DriveBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Export request.</summary>
            public ExportRequest(Google.Apis.Services.IClientService service, string fileId, string mimeType) : base(service)
            {
                FileId = fileId;
                MimeType = mimeType;
                MediaDownloader = new Google.Apis.Download.MediaDownloader(service);
                InitParameters();
            }

            /// <summary>The ID of the file.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fileId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string FileId { get; private set; }

            /// <summary>Required. The MIME type of the format requested for this export.</summary>
            [Google.Apis.Util.RequestParameterAttribute("mimeType", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string MimeType { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "export";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "files/{fileId}/export";

            /// <summary>Initializes Export parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("fileId", new Google.Apis.Discovery.Parameter
                {
                    Name = "fileId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("mimeType", new Google.Apis.Discovery.Parameter
                {
                    Name = "mimeType",
                    IsRequired = true,
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
                mediaDownloader.Range = null;
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
                mediaDownloader.Range = null;
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
                mediaDownloader.Range = null;
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
                mediaDownloader.Range = null;
                return mediaDownloader.DownloadAsync(this.GenerateRequestUri(), stream, cancellationToken);
            }

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
        }

        /// <summary>Generates a set of file IDs which can be provided in insert or copy requests.</summary>
        public virtual GenerateIdsRequest GenerateIds()
        {
            return new GenerateIdsRequest(this.service);
        }

        /// <summary>Generates a set of file IDs which can be provided in insert or copy requests.</summary>
        public class GenerateIdsRequest : DriveBaseServiceRequest<Google.Apis.Drive.v2.Data.GeneratedIds>
        {
            /// <summary>Constructs a new GenerateIds request.</summary>
            public GenerateIdsRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>Maximum number of IDs to return.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>
            /// The space in which the IDs can be used to create new files. Supported values are `drive` and
            /// `appDataFolder`. (Default: `drive`)
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("space", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Space { get; set; }

            /// <summary>
            /// The type of items which the IDs can be used for. Supported values are `files` and `shortcuts`. Note that
            /// `shortcuts` are only supported in the `drive` `space`. (Default: `files`)
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("type", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Type { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "generateIds";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "files/generateIds";

            /// <summary>Initializes GenerateIds parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "10",
                    Pattern = null,
                });
                RequestParameters.Add("space", new Google.Apis.Discovery.Parameter
                {
                    Name = "space",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "drive",
                    Pattern = null,
                });
                RequestParameters.Add("type", new Google.Apis.Discovery.Parameter
                {
                    Name = "type",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "files",
                    Pattern = null,
                });
            }
        }

        /// <summary>
        ///  Gets a file's metadata or content by ID. If you provide the URL parameter `alt=media`, then the response
        /// includes the file contents in the response body. Downloading content with `alt=media` only works if the file
        /// is stored in Drive. To download Google Docs, Sheets, and Slides use
        /// [`files.export`](/workspace/drive/api/reference/rest/v2/files/export) instead. For more information, see
        /// [Download &amp;amp; export files](/workspace/drive/api/guides/manage-downloads).
        /// </summary>
        /// <param name="fileId">The ID for the file in question.</param>
        public virtual GetRequest Get(string fileId)
        {
            return new GetRequest(this.service, fileId);
        }

        /// <summary>
        ///  Gets a file's metadata or content by ID. If you provide the URL parameter `alt=media`, then the response
        /// includes the file contents in the response body. Downloading content with `alt=media` only works if the file
        /// is stored in Drive. To download Google Docs, Sheets, and Slides use
        /// [`files.export`](/workspace/drive/api/reference/rest/v2/files/export) instead. For more information, see
        /// [Download &amp;amp; export files](/workspace/drive/api/guides/manage-downloads).
        /// </summary>
        public class GetRequest : DriveBaseServiceRequest<Google.Apis.Drive.v2.Data.File>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string fileId) : base(service)
            {
                FileId = fileId;
                MediaDownloader = new Google.Apis.Download.MediaDownloader(service);
                InitParameters();
            }

            /// <summary>The ID for the file in question.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fileId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string FileId { get; private set; }

            /// <summary>
            /// Whether the user is acknowledging the risk of downloading known malware or other abusive files. This is
            /// only applicable when the `alt` parameter is set to `media` and the user is the owner of the file or an
            /// organizer of the shared drive in which the file resides.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("acknowledgeAbuse", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> AcknowledgeAbuse { get; set; }

            /// <summary>
            /// A comma-separated list of IDs of labels to include in the `labelInfo` part of the response.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("includeLabels", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string IncludeLabels { get; set; }

            /// <summary>
            /// Specifies which additional view's permissions to include in the response. Only `published` is supported.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("includePermissionsForView", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string IncludePermissionsForView { get; set; }

            /// <summary>Deprecated: This parameter has no function.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projection", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ProjectionEnum> Projection { get; set; }

            /// <summary>Deprecated: This parameter has no function.</summary>
            public enum ProjectionEnum
            {
                /// <summary>Deprecated.</summary>
                [Google.Apis.Util.StringValueAttribute("BASIC")]
                BASIC = 0,

                /// <summary>Deprecated.</summary>
                [Google.Apis.Util.StringValueAttribute("FULL")]
                FULL = 1,
            }

            /// <summary>
            /// Specifies the Revision ID that should be downloaded. Ignored unless alt=media is specified.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("revisionId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string RevisionId { get; set; }

            /// <summary>Whether the requesting application supports both My Drives and shared drives.</summary>
            [Google.Apis.Util.RequestParameterAttribute("supportsAllDrives", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> SupportsAllDrives { get; set; }

            /// <summary>Deprecated: Use `supportsAllDrives` instead.</summary>
            [Google.Apis.Util.RequestParameterAttribute("supportsTeamDrives", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> SupportsTeamDrives { get; set; }

            /// <summary>
            /// Deprecated: Use `files.update` with `modifiedDateBehavior=noChange, updateViewedDate=true` and an empty
            /// request body.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("updateViewedDate", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> UpdateViewedDate { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "files/{fileId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("fileId", new Google.Apis.Discovery.Parameter
                {
                    Name = "fileId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("acknowledgeAbuse", new Google.Apis.Discovery.Parameter
                {
                    Name = "acknowledgeAbuse",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("includeLabels", new Google.Apis.Discovery.Parameter
                {
                    Name = "includeLabels",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("includePermissionsForView", new Google.Apis.Discovery.Parameter
                {
                    Name = "includePermissionsForView",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("projection", new Google.Apis.Discovery.Parameter
                {
                    Name = "projection",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("revisionId", new Google.Apis.Discovery.Parameter
                {
                    Name = "revisionId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("supportsAllDrives", new Google.Apis.Discovery.Parameter
                {
                    Name = "supportsAllDrives",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("supportsTeamDrives", new Google.Apis.Discovery.Parameter
                {
                    Name = "supportsTeamDrives",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("updateViewedDate", new Google.Apis.Discovery.Parameter
                {
                    Name = "updateViewedDate",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
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
                mediaDownloader.Range = null;
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
                mediaDownloader.Range = null;
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
                mediaDownloader.Range = null;
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
                mediaDownloader.Range = null;
                return mediaDownloader.DownloadAsync(this.GenerateRequestUri(), stream, cancellationToken);
            }

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
        }

        /// <summary>
        ///  Inserts a new file. This method supports an */upload* URI and accepts uploaded media with the following
        /// characteristics: - *Maximum file size:* 5,120 GB - *Accepted Media MIME types:*`*/*` Note: Specify a valid
        /// MIME type, rather than the literal `*/*` value. The literal `*/*` is only used to indicate that any valid
        /// MIME type can be uploaded. For more information on uploading files, see [Upload file
        /// data](/workspace/drive/api/guides/manage-uploads). Apps creating shortcuts with `files.insert` must specify
        /// the MIME type `application/vnd.google-apps.shortcut`. Apps should specify a file extension in the `title`
        /// property when inserting files with the API. For example, an operation to insert a JPEG file should specify
        /// something like `"title": "cat.jpg"` in the metadata. Subsequent `GET` requests include the read-only
        /// `fileExtension` property populated with the extension originally specified in the `title` property. When a
        /// Google Drive user requests to download a file, or when the file is downloaded through the sync client, Drive
        /// builds a full filename (with extension) based on the title. In cases where the extension is missing, Drive
        /// attempts to determine the extension based on the file's MIME type.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual InsertRequest Insert(Google.Apis.Drive.v2.Data.File body)
        {
            return new InsertRequest(this.service, body);
        }

        /// <summary>
        ///  Inserts a new file. This method supports an */upload* URI and accepts uploaded media with the following
        /// characteristics: - *Maximum file size:* 5,120 GB - *Accepted Media MIME types:*`*/*` Note: Specify a valid
        /// MIME type, rather than the literal `*/*` value. The literal `*/*` is only used to indicate that any valid
        /// MIME type can be uploaded. For more information on uploading files, see [Upload file
        /// data](/workspace/drive/api/guides/manage-uploads). Apps creating shortcuts with `files.insert` must specify
        /// the MIME type `application/vnd.google-apps.shortcut`. Apps should specify a file extension in the `title`
        /// property when inserting files with the API. For example, an operation to insert a JPEG file should specify
        /// something like `"title": "cat.jpg"` in the metadata. Subsequent `GET` requests include the read-only
        /// `fileExtension` property populated with the extension originally specified in the `title` property. When a
        /// Google Drive user requests to download a file, or when the file is downloaded through the sync client, Drive
        /// builds a full filename (with extension) based on the title. In cases where the extension is missing, Drive
        /// attempts to determine the extension based on the file's MIME type.
        /// </summary>
        public class InsertRequest : DriveBaseServiceRequest<Google.Apis.Drive.v2.Data.File>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Drive.v2.Data.File body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Whether to convert this file to the corresponding Docs Editors format.</summary>
            [Google.Apis.Util.RequestParameterAttribute("convert", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Convert { get; set; }

            /// <summary>Deprecated: Creating files in multiple folders is no longer supported.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enforceSingleParent", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> EnforceSingleParent { get; set; }

            /// <summary>
            /// A comma-separated list of IDs of labels to include in the `labelInfo` part of the response.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("includeLabels", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string IncludeLabels { get; set; }

            /// <summary>
            /// Specifies which additional view's permissions to include in the response. Only `published` is supported.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("includePermissionsForView", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string IncludePermissionsForView { get; set; }

            /// <summary>Whether to attempt OCR on .jpg, .png, .gif, or .pdf uploads.</summary>
            [Google.Apis.Util.RequestParameterAttribute("ocr", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Ocr { get; set; }

            /// <summary>If ocr is true, hints at the language to use. Valid values are BCP 47 codes.</summary>
            [Google.Apis.Util.RequestParameterAttribute("ocrLanguage", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OcrLanguage { get; set; }

            /// <summary>
            /// Whether to pin the head revision of the uploaded file. A file can have a maximum of 200 pinned
            /// revisions.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pinned", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Pinned { get; set; }

            /// <summary>Whether the requesting application supports both My Drives and shared drives.</summary>
            [Google.Apis.Util.RequestParameterAttribute("supportsAllDrives", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> SupportsAllDrives { get; set; }

            /// <summary>Deprecated: Use `supportsAllDrives` instead.</summary>
            [Google.Apis.Util.RequestParameterAttribute("supportsTeamDrives", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> SupportsTeamDrives { get; set; }

            /// <summary>The language of the timed text.</summary>
            [Google.Apis.Util.RequestParameterAttribute("timedTextLanguage", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string TimedTextLanguage { get; set; }

            /// <summary>The timed text track name.</summary>
            [Google.Apis.Util.RequestParameterAttribute("timedTextTrackName", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string TimedTextTrackName { get; set; }

            /// <summary>Whether to use the content as indexable text.</summary>
            [Google.Apis.Util.RequestParameterAttribute("useContentAsIndexableText", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> UseContentAsIndexableText { get; set; }

            /// <summary>The visibility of the new file. This parameter is only relevant when convert=false.</summary>
            [Google.Apis.Util.RequestParameterAttribute("visibility", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<VisibilityEnum> Visibility { get; set; }

            /// <summary>The visibility of the new file. This parameter is only relevant when convert=false.</summary>
            public enum VisibilityEnum
            {
                /// <summary>
                /// The visibility of the new file is determined by the user's default visibility/sharing policies.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("DEFAULT")]
                DEFAULT__ = 0,

                /// <summary>The new file will be visible to only the owner.</summary>
                [Google.Apis.Util.StringValueAttribute("PRIVATE")]
                PRIVATE__ = 1,
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Drive.v2.Data.File Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "files";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("convert", new Google.Apis.Discovery.Parameter
                {
                    Name = "convert",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("enforceSingleParent", new Google.Apis.Discovery.Parameter
                {
                    Name = "enforceSingleParent",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("includeLabels", new Google.Apis.Discovery.Parameter
                {
                    Name = "includeLabels",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("includePermissionsForView", new Google.Apis.Discovery.Parameter
                {
                    Name = "includePermissionsForView",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ocr", new Google.Apis.Discovery.Parameter
                {
                    Name = "ocr",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("ocrLanguage", new Google.Apis.Discovery.Parameter
                {
                    Name = "ocrLanguage",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("pinned", new Google.Apis.Discovery.Parameter
                {
                    Name = "pinned",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("supportsAllDrives", new Google.Apis.Discovery.Parameter
                {
                    Name = "supportsAllDrives",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("supportsTeamDrives", new Google.Apis.Discovery.Parameter
                {
                    Name = "supportsTeamDrives",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("timedTextLanguage", new Google.Apis.Discovery.Parameter
                {
                    Name = "timedTextLanguage",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("timedTextTrackName", new Google.Apis.Discovery.Parameter
                {
                    Name = "timedTextTrackName",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("useContentAsIndexableText", new Google.Apis.Discovery.Parameter
                {
                    Name = "useContentAsIndexableText",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("visibility", new Google.Apis.Discovery.Parameter
                {
                    Name = "visibility",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "DEFAULT",
                    Pattern = null,
                });
            }
        }

        /// <summary>
        ///  Inserts a new file. This method supports an */upload* URI and accepts uploaded media with the following
        /// characteristics: - *Maximum file size:* 5,120 GB - *Accepted Media MIME types:*`*/*` Note: Specify a valid
        /// MIME type, rather than the literal `*/*` value. The literal `*/*` is only used to indicate that any valid
        /// MIME type can be uploaded. For more information on uploading files, see [Upload file
        /// data](/workspace/drive/api/guides/manage-uploads). Apps creating shortcuts with `files.insert` must specify
        /// the MIME type `application/vnd.google-apps.shortcut`. Apps should specify a file extension in the `title`
        /// property when inserting files with the API. For example, an operation to insert a JPEG file should specify
        /// something like `"title": "cat.jpg"` in the metadata. Subsequent `GET` requests include the read-only
        /// `fileExtension` property populated with the extension originally specified in the `title` property. When a
        /// Google Drive user requests to download a file, or when the file is downloaded through the sync client, Drive
        /// builds a full filename (with extension) based on the title. In cases where the extension is missing, Drive
        /// attempts to determine the extension based on the file's MIME type.
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
        /// <param name="stream">The stream to upload. See remarks for further information.</param>
        /// <param name="contentType">The content type of the stream to upload.</param>
        public virtual InsertMediaUpload Insert(Google.Apis.Drive.v2.Data.File body, System.IO.Stream stream, string contentType)
        {
            return new InsertMediaUpload(service, body, stream, contentType);
        }

        /// <summary>Insert media upload which supports resumable upload.</summary>
        public class InsertMediaUpload : Google.Apis.Upload.ResumableUpload<Google.Apis.Drive.v2.Data.File, Google.Apis.Drive.v2.Data.File>
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

            /// <summary>Whether to convert this file to the corresponding Docs Editors format.</summary>
            [Google.Apis.Util.RequestParameterAttribute("convert", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Convert { get; set; }

            /// <summary>Deprecated: Creating files in multiple folders is no longer supported.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enforceSingleParent", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> EnforceSingleParent { get; set; }

            /// <summary>
            /// A comma-separated list of IDs of labels to include in the `labelInfo` part of the response.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("includeLabels", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string IncludeLabels { get; set; }

            /// <summary>
            /// Specifies which additional view's permissions to include in the response. Only `published` is supported.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("includePermissionsForView", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string IncludePermissionsForView { get; set; }

            /// <summary>Whether to attempt OCR on .jpg, .png, .gif, or .pdf uploads.</summary>
            [Google.Apis.Util.RequestParameterAttribute("ocr", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Ocr { get; set; }

            /// <summary>If ocr is true, hints at the language to use. Valid values are BCP 47 codes.</summary>
            [Google.Apis.Util.RequestParameterAttribute("ocrLanguage", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OcrLanguage { get; set; }

            /// <summary>
            /// Whether to pin the head revision of the uploaded file. A file can have a maximum of 200 pinned
            /// revisions.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pinned", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Pinned { get; set; }

            /// <summary>Whether the requesting application supports both My Drives and shared drives.</summary>
            [Google.Apis.Util.RequestParameterAttribute("supportsAllDrives", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> SupportsAllDrives { get; set; }

            /// <summary>Deprecated: Use `supportsAllDrives` instead.</summary>
            [Google.Apis.Util.RequestParameterAttribute("supportsTeamDrives", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> SupportsTeamDrives { get; set; }

            /// <summary>The language of the timed text.</summary>
            [Google.Apis.Util.RequestParameterAttribute("timedTextLanguage", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string TimedTextLanguage { get; set; }

            /// <summary>The timed text track name.</summary>
            [Google.Apis.Util.RequestParameterAttribute("timedTextTrackName", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string TimedTextTrackName { get; set; }

            /// <summary>Whether to use the content as indexable text.</summary>
            [Google.Apis.Util.RequestParameterAttribute("useContentAsIndexableText", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> UseContentAsIndexableText { get; set; }

            /// <summary>The visibility of the new file. This parameter is only relevant when convert=false.</summary>
            [Google.Apis.Util.RequestParameterAttribute("visibility", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<VisibilityEnum> Visibility { get; set; }

            /// <summary>The visibility of the new file. This parameter is only relevant when convert=false.</summary>
            public enum VisibilityEnum
            {
                /// <summary>
                /// The visibility of the new file is determined by the user's default visibility/sharing policies.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("DEFAULT")]
                DEFAULT__ = 0,

                /// <summary>The new file will be visible to only the owner.</summary>
                [Google.Apis.Util.StringValueAttribute("PRIVATE")]
                PRIVATE__ = 1,
            }

            /// <summary>Constructs a new Insert media upload instance.</summary>
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
            public InsertMediaUpload(Google.Apis.Services.IClientService service, Google.Apis.Drive.v2.Data.File body, System.IO.Stream stream, string contentType)
                : base(service, string.Format("/{0}/{1}{2}", "upload", service.BasePath, "files"), "POST", stream, contentType)
            {
                Body = body;
            }
        }

        /// <summary>
        ///  Lists the user's files. This method accepts the `q` parameter, which is a search query combining one or
        /// more search terms. For more information, see the [Search for files &amp;amp;
        /// folders](/workspace/drive/api/guides/search-files) guide. *Note:* This method returns *all* files by
        /// default, including trashed files. If you don't want trashed files to appear in the list, use the
        /// `trashed=false` query parameter to remove trashed files from the results.
        /// </summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>
        ///  Lists the user's files. This method accepts the `q` parameter, which is a search query combining one or
        /// more search terms. For more information, see the [Search for files &amp;amp;
        /// folders](/workspace/drive/api/guides/search-files) guide. *Note:* This method returns *all* files by
        /// default, including trashed files. If you don't want trashed files to appear in the list, use the
        /// `trashed=false` query parameter to remove trashed files from the results.
        /// </summary>
        public class ListRequest : DriveBaseServiceRequest<Google.Apis.Drive.v2.Data.FileList>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Bodies of items (files/documents) to which the query applies. Supported bodies are `default`, `domain`,
            /// `drive` and `allDrives`. Prefer `default` or `drive` to `allDrives` for efficiency.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("corpora", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Corpora { get; set; }

            /// <summary>
            /// Deprecated: The body of items (files/documents) to which the query applies. Use `corpora` instead.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("corpus", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<CorpusEnum> Corpus { get; set; }

            /// <summary>
            /// Deprecated: The body of items (files/documents) to which the query applies. Use `corpora` instead.
            /// </summary>
            public enum CorpusEnum
            {
                /// <summary>The items that the user has accessed.</summary>
                [Google.Apis.Util.StringValueAttribute("DEFAULT")]
                DEFAULT__ = 0,

                /// <summary>Items shared to the user's domain.</summary>
                [Google.Apis.Util.StringValueAttribute("DOMAIN")]
                DOMAIN = 1,
            }

            /// <summary>ID of the shared drive to search.</summary>
            [Google.Apis.Util.RequestParameterAttribute("driveId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string DriveId { get; set; }

            /// <summary>Whether both My Drive and shared drive items should be included in results.</summary>
            [Google.Apis.Util.RequestParameterAttribute("includeItemsFromAllDrives", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> IncludeItemsFromAllDrives { get; set; }

            /// <summary>
            /// A comma-separated list of IDs of labels to include in the `labelInfo` part of the response.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("includeLabels", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string IncludeLabels { get; set; }

            /// <summary>
            /// Specifies which additional view's permissions to include in the response. Only `published` is supported.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("includePermissionsForView", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string IncludePermissionsForView { get; set; }

            /// <summary>Deprecated: Use `includeItemsFromAllDrives` instead.</summary>
            [Google.Apis.Util.RequestParameterAttribute("includeTeamDriveItems", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> IncludeTeamDriveItems { get; set; }

            /// <summary>
            /// The maximum number of files to return per page. Partial or empty result pages are possible even before
            /// the end of the files list has been reached.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>
            /// A comma-separated list of sort keys. Valid keys are: * `createdDate`: When the file was created. *
            /// `folder`: The folder ID. This field is sorted using alphabetical ordering. * `lastViewedByMeDate`: The
            /// last time the file was viewed by the user. * `modifiedByMeDate`: The last time the file was modified by
            /// the user. * `modifiedDate`: The last time the file was modified by anyone. * `quotaBytesUsed`: The
            /// number of storage quota bytes used by the file. * `recency`: The most recent timestamp from the file's
            /// date-time fields. * `sharedWithMeDate`: When the file was shared with the user, if applicable. *
            /// `starred`: Whether the user has starred the file. * `title`: The title of the file. This field is sorted
            /// using alphabetical ordering, so 1, 12, 2, 22. * `title_natural`: The title of the file. This field is
            /// sorted using natural sort ordering, so 1, 2, 12, 22. Each key sorts ascending by default, but can be
            /// reversed with the 'desc' modifier. Example usage: `?orderBy=folder,modifiedDate desc,title`. Note that
            /// there's a current limitation for users with approximately one million files in which the requested sort
            /// order is ignored.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OrderBy { get; set; }

            /// <summary>Page token for files.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Deprecated: This parameter has no function.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projection", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ProjectionEnum> Projection { get; set; }

            /// <summary>Deprecated: This parameter has no function.</summary>
            public enum ProjectionEnum
            {
                /// <summary>Deprecated.</summary>
                [Google.Apis.Util.StringValueAttribute("BASIC")]
                BASIC = 0,

                /// <summary>Deprecated.</summary>
                [Google.Apis.Util.StringValueAttribute("FULL")]
                FULL = 1,
            }

            /// <summary>Query string for searching files.</summary>
            [Google.Apis.Util.RequestParameterAttribute("q", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Q { get; set; }

            /// <summary>
            /// A comma-separated list of spaces to query. Supported values are `drive`, and `appDataFolder`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("spaces", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Spaces { get; set; }

            /// <summary>Whether the requesting application supports both My Drives and shared drives.</summary>
            [Google.Apis.Util.RequestParameterAttribute("supportsAllDrives", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> SupportsAllDrives { get; set; }

            /// <summary>Deprecated: Use `supportsAllDrives` instead.</summary>
            [Google.Apis.Util.RequestParameterAttribute("supportsTeamDrives", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> SupportsTeamDrives { get; set; }

            /// <summary>Deprecated: Use `driveId` instead.</summary>
            [Google.Apis.Util.RequestParameterAttribute("teamDriveId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string TeamDriveId { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "files";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("corpora", new Google.Apis.Discovery.Parameter
                {
                    Name = "corpora",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("corpus", new Google.Apis.Discovery.Parameter
                {
                    Name = "corpus",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("driveId", new Google.Apis.Discovery.Parameter
                {
                    Name = "driveId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("includeItemsFromAllDrives", new Google.Apis.Discovery.Parameter
                {
                    Name = "includeItemsFromAllDrives",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("includeLabels", new Google.Apis.Discovery.Parameter
                {
                    Name = "includeLabels",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("includePermissionsForView", new Google.Apis.Discovery.Parameter
                {
                    Name = "includePermissionsForView",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("includeTeamDriveItems", new Google.Apis.Discovery.Parameter
                {
                    Name = "includeTeamDriveItems",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "100",
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
                RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageToken",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("projection", new Google.Apis.Discovery.Parameter
                {
                    Name = "projection",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("q", new Google.Apis.Discovery.Parameter
                {
                    Name = "q",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("spaces", new Google.Apis.Discovery.Parameter
                {
                    Name = "spaces",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("supportsAllDrives", new Google.Apis.Discovery.Parameter
                {
                    Name = "supportsAllDrives",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("supportsTeamDrives", new Google.Apis.Discovery.Parameter
                {
                    Name = "supportsTeamDrives",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("teamDriveId", new Google.Apis.Discovery.Parameter
                {
                    Name = "teamDriveId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Lists the labels on a file.</summary>
        /// <param name="fileId">The ID for the file.</param>
        public virtual ListLabelsRequest ListLabels(string fileId)
        {
            return new ListLabelsRequest(this.service, fileId);
        }

        /// <summary>Lists the labels on a file.</summary>
        public class ListLabelsRequest : DriveBaseServiceRequest<Google.Apis.Drive.v2.Data.LabelList>
        {
            /// <summary>Constructs a new ListLabels request.</summary>
            public ListLabelsRequest(Google.Apis.Services.IClientService service, string fileId) : base(service)
            {
                FileId = fileId;
                InitParameters();
            }

            /// <summary>The ID for the file.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fileId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string FileId { get; private set; }

            /// <summary>The maximum number of labels to return per page. When not set, defaults to 100.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>
            /// The token for continuing a previous list request on the next page. This should be set to the value of
            /// `nextPageToken` from the previous response.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "listLabels";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "files/{fileId}/listLabels";

            /// <summary>Initializes ListLabels parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("fileId", new Google.Apis.Discovery.Parameter
                {
                    Name = "fileId",
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
                    DefaultValue = "100",
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
        /// Modifies the set of labels applied to a file. Returns a list of the labels that were added or modified.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="fileId">The ID of the file to which the labels belong.</param>
        public virtual ModifyLabelsRequest ModifyLabels(Google.Apis.Drive.v2.Data.ModifyLabelsRequest body, string fileId)
        {
            return new ModifyLabelsRequest(this.service, body, fileId);
        }

        /// <summary>
        /// Modifies the set of labels applied to a file. Returns a list of the labels that were added or modified.
        /// </summary>
        public class ModifyLabelsRequest : DriveBaseServiceRequest<Google.Apis.Drive.v2.Data.ModifyLabelsResponse>
        {
            /// <summary>Constructs a new ModifyLabels request.</summary>
            public ModifyLabelsRequest(Google.Apis.Services.IClientService service, Google.Apis.Drive.v2.Data.ModifyLabelsRequest body, string fileId) : base(service)
            {
                FileId = fileId;
                Body = body;
                InitParameters();
            }

            /// <summary>The ID of the file to which the labels belong.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fileId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string FileId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Drive.v2.Data.ModifyLabelsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "modifyLabels";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "files/{fileId}/modifyLabels";

            /// <summary>Initializes ModifyLabels parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("fileId", new Google.Apis.Discovery.Parameter
                {
                    Name = "fileId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Updates a file's metadata and/or content. When calling this method, only populate fields in the request that
        /// you want to modify. When updating fields, some fields might change automatically, such as modifiedDate. This
        /// method supports patch semantics.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="fileId">The ID of the file to update.</param>
        public virtual PatchRequest Patch(Google.Apis.Drive.v2.Data.File body, string fileId)
        {
            return new PatchRequest(this.service, body, fileId);
        }

        /// <summary>
        /// Updates a file's metadata and/or content. When calling this method, only populate fields in the request that
        /// you want to modify. When updating fields, some fields might change automatically, such as modifiedDate. This
        /// method supports patch semantics.
        /// </summary>
        public class PatchRequest : DriveBaseServiceRequest<Google.Apis.Drive.v2.Data.File>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Drive.v2.Data.File body, string fileId) : base(service)
            {
                FileId = fileId;
                Body = body;
                InitParameters();
            }

            /// <summary>The ID of the file to update.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fileId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string FileId { get; private set; }

            /// <summary>Comma-separated list of parent IDs to add.</summary>
            [Google.Apis.Util.RequestParameterAttribute("addParents", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string AddParents { get; set; }

            /// <summary>Deprecated: This parameter has no function.</summary>
            [Google.Apis.Util.RequestParameterAttribute("convert", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Convert { get; set; }

            /// <summary>
            /// Deprecated: Adding files to multiple folders is no longer supported. Use `shortcuts` instead.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("enforceSingleParent", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> EnforceSingleParent { get; set; }

            /// <summary>
            /// A comma-separated list of IDs of labels to include in the `labelInfo` part of the response.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("includeLabels", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string IncludeLabels { get; set; }

            /// <summary>
            /// Specifies which additional view's permissions to include in the response. Only `published` is supported.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("includePermissionsForView", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string IncludePermissionsForView { get; set; }

            /// <summary>
            /// Determines the behavior in which `modifiedDate` is updated. This overrides `setModifiedDate`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("modifiedDateBehavior", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ModifiedDateBehaviorEnum> ModifiedDateBehavior { get; set; }

            /// <summary>
            /// Determines the behavior in which `modifiedDate` is updated. This overrides `setModifiedDate`.
            /// </summary>
            public enum ModifiedDateBehaviorEnum
            {
                /// <summary>
                /// Set `modifiedDate` to the value provided in the body of the request. No change if no value was
                /// provided.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("fromBody")]
                FromBody = 0,

                /// <summary>
                /// Set `modifiedDate` to the value provided in the body of the request depending on other contents of
                /// the update.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("fromBodyIfNeeded")]
                FromBodyIfNeeded = 1,

                /// <summary>
                /// Set modifiedDate to the value provided in the body of the request, or to the current time if no
                /// value was provided.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("fromBodyOrNow")]
                FromBodyOrNow = 2,

                /// <summary>Maintain the previous value of `modifiedDate`.</summary>
                [Google.Apis.Util.StringValueAttribute("noChange")]
                NoChange = 3,

                /// <summary>Set `modifiedDate` to the current time.</summary>
                [Google.Apis.Util.StringValueAttribute("now")]
                Now = 4,

                /// <summary>Set `modifiedDate` to the current time depending on contents of the update.</summary>
                [Google.Apis.Util.StringValueAttribute("nowIfNeeded")]
                NowIfNeeded = 5,
            }

            /// <summary>
            /// Whether a blob upload should create a new revision. If false, the blob data in the current head revision
            /// is replaced. If true or not set, a new blob is created as head revision, and previous unpinned revisions
            /// are preserved for a short period of time. Pinned revisions are stored indefinitely, using additional
            /// storage quota, up to a maximum of 200 revisions. For details on how revisions are retained, see the
            /// [Drive Help Center](https://support.google.com/drive/answer/2409045). Note that this field is ignored if
            /// there is no payload in the request.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("newRevision", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> NewRevision { get; set; }

            /// <summary>Whether to attempt OCR on .jpg, .png, .gif, or .pdf uploads.</summary>
            [Google.Apis.Util.RequestParameterAttribute("ocr", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Ocr { get; set; }

            /// <summary>If ocr is true, hints at the language to use. Valid values are BCP 47 codes.</summary>
            [Google.Apis.Util.RequestParameterAttribute("ocrLanguage", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OcrLanguage { get; set; }

            /// <summary>
            /// Whether to pin the new revision. A file can have a maximum of 200 pinned revisions. Note that this field
            /// is ignored if there is no payload in the request.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pinned", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Pinned { get; set; }

            /// <summary>Comma-separated list of parent IDs to remove.</summary>
            [Google.Apis.Util.RequestParameterAttribute("removeParents", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string RemoveParents { get; set; }

            /// <summary>
            /// Whether to set the modified date using the value supplied in the request body. Setting this field to
            /// `true` is equivalent to `modifiedDateBehavior=fromBodyOrNow`, and `false` is equivalent to
            /// `modifiedDateBehavior=now`. To prevent any changes to the modified date set
            /// `modifiedDateBehavior=noChange`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("setModifiedDate", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> SetModifiedDate { get; set; }

            /// <summary>Whether the requesting application supports both My Drives and shared drives.</summary>
            [Google.Apis.Util.RequestParameterAttribute("supportsAllDrives", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> SupportsAllDrives { get; set; }

            /// <summary>Deprecated: Use `supportsAllDrives` instead.</summary>
            [Google.Apis.Util.RequestParameterAttribute("supportsTeamDrives", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> SupportsTeamDrives { get; set; }

            /// <summary>The language of the timed text.</summary>
            [Google.Apis.Util.RequestParameterAttribute("timedTextLanguage", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string TimedTextLanguage { get; set; }

            /// <summary>The timed text track name.</summary>
            [Google.Apis.Util.RequestParameterAttribute("timedTextTrackName", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string TimedTextTrackName { get; set; }

            /// <summary>Whether to update the view date after successfully updating the file.</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateViewedDate", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> UpdateViewedDate { get; set; }

            /// <summary>Whether to use the content as indexable text.</summary>
            [Google.Apis.Util.RequestParameterAttribute("useContentAsIndexableText", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> UseContentAsIndexableText { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Drive.v2.Data.File Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "files/{fileId}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("fileId", new Google.Apis.Discovery.Parameter
                {
                    Name = "fileId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("addParents", new Google.Apis.Discovery.Parameter
                {
                    Name = "addParents",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("convert", new Google.Apis.Discovery.Parameter
                {
                    Name = "convert",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("enforceSingleParent", new Google.Apis.Discovery.Parameter
                {
                    Name = "enforceSingleParent",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("includeLabels", new Google.Apis.Discovery.Parameter
                {
                    Name = "includeLabels",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("includePermissionsForView", new Google.Apis.Discovery.Parameter
                {
                    Name = "includePermissionsForView",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("modifiedDateBehavior", new Google.Apis.Discovery.Parameter
                {
                    Name = "modifiedDateBehavior",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("newRevision", new Google.Apis.Discovery.Parameter
                {
                    Name = "newRevision",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "true",
                    Pattern = null,
                });
                RequestParameters.Add("ocr", new Google.Apis.Discovery.Parameter
                {
                    Name = "ocr",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("ocrLanguage", new Google.Apis.Discovery.Parameter
                {
                    Name = "ocrLanguage",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("pinned", new Google.Apis.Discovery.Parameter
                {
                    Name = "pinned",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("removeParents", new Google.Apis.Discovery.Parameter
                {
                    Name = "removeParents",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("setModifiedDate", new Google.Apis.Discovery.Parameter
                {
                    Name = "setModifiedDate",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("supportsAllDrives", new Google.Apis.Discovery.Parameter
                {
                    Name = "supportsAllDrives",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("supportsTeamDrives", new Google.Apis.Discovery.Parameter
                {
                    Name = "supportsTeamDrives",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("timedTextLanguage", new Google.Apis.Discovery.Parameter
                {
                    Name = "timedTextLanguage",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("timedTextTrackName", new Google.Apis.Discovery.Parameter
                {
                    Name = "timedTextTrackName",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("updateViewedDate", new Google.Apis.Discovery.Parameter
                {
                    Name = "updateViewedDate",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "true",
                    Pattern = null,
                });
                RequestParameters.Add("useContentAsIndexableText", new Google.Apis.Discovery.Parameter
                {
                    Name = "useContentAsIndexableText",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
            }
        }

        /// <summary>Set the file's updated time to the current server time.</summary>
        /// <param name="fileId">The ID of the file to update.</param>
        public virtual TouchRequest Touch(string fileId)
        {
            return new TouchRequest(this.service, fileId);
        }

        /// <summary>Set the file's updated time to the current server time.</summary>
        public class TouchRequest : DriveBaseServiceRequest<Google.Apis.Drive.v2.Data.File>
        {
            /// <summary>Constructs a new Touch request.</summary>
            public TouchRequest(Google.Apis.Services.IClientService service, string fileId) : base(service)
            {
                FileId = fileId;
                InitParameters();
            }

            /// <summary>The ID of the file to update.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fileId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string FileId { get; private set; }

            /// <summary>
            /// A comma-separated list of IDs of labels to include in the `labelInfo` part of the response.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("includeLabels", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string IncludeLabels { get; set; }

            /// <summary>
            /// Specifies which additional view's permissions to include in the response. Only `published` is supported.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("includePermissionsForView", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string IncludePermissionsForView { get; set; }

            /// <summary>Whether the requesting application supports both My Drives and shared drives.</summary>
            [Google.Apis.Util.RequestParameterAttribute("supportsAllDrives", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> SupportsAllDrives { get; set; }

            /// <summary>Deprecated: Use `supportsAllDrives` instead.</summary>
            [Google.Apis.Util.RequestParameterAttribute("supportsTeamDrives", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> SupportsTeamDrives { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "touch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "files/{fileId}/touch";

            /// <summary>Initializes Touch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("fileId", new Google.Apis.Discovery.Parameter
                {
                    Name = "fileId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("includeLabels", new Google.Apis.Discovery.Parameter
                {
                    Name = "includeLabels",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("includePermissionsForView", new Google.Apis.Discovery.Parameter
                {
                    Name = "includePermissionsForView",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("supportsAllDrives", new Google.Apis.Discovery.Parameter
                {
                    Name = "supportsAllDrives",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("supportsTeamDrives", new Google.Apis.Discovery.Parameter
                {
                    Name = "supportsTeamDrives",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Moves a file to the trash. The currently authenticated user must own the file or be at least a
        /// `fileOrganizer` on the parent for shared drive files.
        /// </summary>
        /// <param name="fileId">The ID of the file to trash.</param>
        public virtual TrashRequest Trash(string fileId)
        {
            return new TrashRequest(this.service, fileId);
        }

        /// <summary>
        /// Moves a file to the trash. The currently authenticated user must own the file or be at least a
        /// `fileOrganizer` on the parent for shared drive files.
        /// </summary>
        public class TrashRequest : DriveBaseServiceRequest<Google.Apis.Drive.v2.Data.File>
        {
            /// <summary>Constructs a new Trash request.</summary>
            public TrashRequest(Google.Apis.Services.IClientService service, string fileId) : base(service)
            {
                FileId = fileId;
                InitParameters();
            }

            /// <summary>The ID of the file to trash.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fileId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string FileId { get; private set; }

            /// <summary>
            /// A comma-separated list of IDs of labels to include in the `labelInfo` part of the response.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("includeLabels", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string IncludeLabels { get; set; }

            /// <summary>
            /// Specifies which additional view's permissions to include in the response. Only `published` is supported.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("includePermissionsForView", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string IncludePermissionsForView { get; set; }

            /// <summary>Whether the requesting application supports both My Drives and shared drives.</summary>
            [Google.Apis.Util.RequestParameterAttribute("supportsAllDrives", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> SupportsAllDrives { get; set; }

            /// <summary>Deprecated: Use `supportsAllDrives` instead.</summary>
            [Google.Apis.Util.RequestParameterAttribute("supportsTeamDrives", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> SupportsTeamDrives { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "trash";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "files/{fileId}/trash";

            /// <summary>Initializes Trash parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("fileId", new Google.Apis.Discovery.Parameter
                {
                    Name = "fileId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("includeLabels", new Google.Apis.Discovery.Parameter
                {
                    Name = "includeLabels",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("includePermissionsForView", new Google.Apis.Discovery.Parameter
                {
                    Name = "includePermissionsForView",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("supportsAllDrives", new Google.Apis.Discovery.Parameter
                {
                    Name = "supportsAllDrives",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("supportsTeamDrives", new Google.Apis.Discovery.Parameter
                {
                    Name = "supportsTeamDrives",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Restores a file from the trash. The currently authenticated user must own the file or be at least a
        /// `fileOrganizer` on the parent for shared drive files.
        /// </summary>
        /// <param name="fileId">The ID of the file to untrash.</param>
        public virtual UntrashRequest Untrash(string fileId)
        {
            return new UntrashRequest(this.service, fileId);
        }

        /// <summary>
        /// Restores a file from the trash. The currently authenticated user must own the file or be at least a
        /// `fileOrganizer` on the parent for shared drive files.
        /// </summary>
        public class UntrashRequest : DriveBaseServiceRequest<Google.Apis.Drive.v2.Data.File>
        {
            /// <summary>Constructs a new Untrash request.</summary>
            public UntrashRequest(Google.Apis.Services.IClientService service, string fileId) : base(service)
            {
                FileId = fileId;
                InitParameters();
            }

            /// <summary>The ID of the file to untrash.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fileId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string FileId { get; private set; }

            /// <summary>
            /// A comma-separated list of IDs of labels to include in the `labelInfo` part of the response.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("includeLabels", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string IncludeLabels { get; set; }

            /// <summary>
            /// Specifies which additional view's permissions to include in the response. Only `published` is supported.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("includePermissionsForView", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string IncludePermissionsForView { get; set; }

            /// <summary>Whether the requesting application supports both My Drives and shared drives.</summary>
            [Google.Apis.Util.RequestParameterAttribute("supportsAllDrives", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> SupportsAllDrives { get; set; }

            /// <summary>Deprecated: Use `supportsAllDrives` instead.</summary>
            [Google.Apis.Util.RequestParameterAttribute("supportsTeamDrives", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> SupportsTeamDrives { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "untrash";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "files/{fileId}/untrash";

            /// <summary>Initializes Untrash parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("fileId", new Google.Apis.Discovery.Parameter
                {
                    Name = "fileId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("includeLabels", new Google.Apis.Discovery.Parameter
                {
                    Name = "includeLabels",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("includePermissionsForView", new Google.Apis.Discovery.Parameter
                {
                    Name = "includePermissionsForView",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("supportsAllDrives", new Google.Apis.Discovery.Parameter
                {
                    Name = "supportsAllDrives",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("supportsTeamDrives", new Google.Apis.Discovery.Parameter
                {
                    Name = "supportsTeamDrives",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
            }
        }

        /// <summary>
        ///  Updates a file's metadata and/or content. When calling this method, only populate fields in the request
        /// that you want to modify. When updating fields, some fields might be changed automatically, such as
        /// `modifiedDate`. This method supports patch semantics. This method supports an */upload* URI and accepts
        /// uploaded media with the following characteristics: - *Maximum file size:* 5,120 GB - *Accepted Media MIME
        /// types:*`*/*` Note: Specify a valid MIME type, rather than the literal `*/*` value. The literal `*/*` is only
        /// used to indicate that any valid MIME type can be uploaded. For more information on uploading files, see
        /// [Upload file data](/workspace/drive/api/guides/manage-uploads).
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="fileId">The ID of the file to update.</param>
        public virtual UpdateRequest Update(Google.Apis.Drive.v2.Data.File body, string fileId)
        {
            return new UpdateRequest(this.service, body, fileId);
        }

        /// <summary>
        ///  Updates a file's metadata and/or content. When calling this method, only populate fields in the request
        /// that you want to modify. When updating fields, some fields might be changed automatically, such as
        /// `modifiedDate`. This method supports patch semantics. This method supports an */upload* URI and accepts
        /// uploaded media with the following characteristics: - *Maximum file size:* 5,120 GB - *Accepted Media MIME
        /// types:*`*/*` Note: Specify a valid MIME type, rather than the literal `*/*` value. The literal `*/*` is only
        /// used to indicate that any valid MIME type can be uploaded. For more information on uploading files, see
        /// [Upload file data](/workspace/drive/api/guides/manage-uploads).
        /// </summary>
        public class UpdateRequest : DriveBaseServiceRequest<Google.Apis.Drive.v2.Data.File>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Drive.v2.Data.File body, string fileId) : base(service)
            {
                FileId = fileId;
                Body = body;
                InitParameters();
            }

            /// <summary>The ID of the file to update.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fileId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string FileId { get; private set; }

            /// <summary>Comma-separated list of parent IDs to add.</summary>
            [Google.Apis.Util.RequestParameterAttribute("addParents", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string AddParents { get; set; }

            /// <summary>Deprecated: This parameter has no function.</summary>
            [Google.Apis.Util.RequestParameterAttribute("convert", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Convert { get; set; }

            /// <summary>
            /// Deprecated: Adding files to multiple folders is no longer supported. Use `shortcuts` instead.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("enforceSingleParent", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> EnforceSingleParent { get; set; }

            /// <summary>
            /// A comma-separated list of IDs of labels to include in the `labelInfo` part of the response.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("includeLabels", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string IncludeLabels { get; set; }

            /// <summary>
            /// Specifies which additional view's permissions to include in the response. Only `published` is supported.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("includePermissionsForView", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string IncludePermissionsForView { get; set; }

            /// <summary>
            /// Determines the behavior in which `modifiedDate` is updated. This overrides `setModifiedDate`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("modifiedDateBehavior", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ModifiedDateBehaviorEnum> ModifiedDateBehavior { get; set; }

            /// <summary>
            /// Determines the behavior in which `modifiedDate` is updated. This overrides `setModifiedDate`.
            /// </summary>
            public enum ModifiedDateBehaviorEnum
            {
                /// <summary>
                /// Set `modifiedDate` to the value provided in the body of the request. No change if no value was
                /// provided.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("fromBody")]
                FromBody = 0,

                /// <summary>
                /// Set `modifiedDate` to the value provided in the body of the request depending on other contents of
                /// the update.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("fromBodyIfNeeded")]
                FromBodyIfNeeded = 1,

                /// <summary>
                /// Set modifiedDate to the value provided in the body of the request, or to the current time if no
                /// value was provided.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("fromBodyOrNow")]
                FromBodyOrNow = 2,

                /// <summary>Maintain the previous value of `modifiedDate`.</summary>
                [Google.Apis.Util.StringValueAttribute("noChange")]
                NoChange = 3,

                /// <summary>Set `modifiedDate` to the current time.</summary>
                [Google.Apis.Util.StringValueAttribute("now")]
                Now = 4,

                /// <summary>Set `modifiedDate` to the current time depending on contents of the update.</summary>
                [Google.Apis.Util.StringValueAttribute("nowIfNeeded")]
                NowIfNeeded = 5,
            }

            /// <summary>
            /// Whether a blob upload should create a new revision. If false, the blob data in the current head revision
            /// is replaced. If true or not set, a new blob is created as head revision, and previous unpinned revisions
            /// are preserved for a short period of time. Pinned revisions are stored indefinitely, using additional
            /// storage quota, up to a maximum of 200 revisions. For details on how revisions are retained, see the
            /// [Drive Help Center](https://support.google.com/drive/answer/2409045).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("newRevision", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> NewRevision { get; set; }

            /// <summary>Whether to attempt OCR on .jpg, .png, .gif, or .pdf uploads.</summary>
            [Google.Apis.Util.RequestParameterAttribute("ocr", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Ocr { get; set; }

            /// <summary>If ocr is true, hints at the language to use. Valid values are BCP 47 codes.</summary>
            [Google.Apis.Util.RequestParameterAttribute("ocrLanguage", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OcrLanguage { get; set; }

            /// <summary>Whether to pin the new revision. A file can have a maximum of 200 pinned revisions.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pinned", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Pinned { get; set; }

            /// <summary>Comma-separated list of parent IDs to remove.</summary>
            [Google.Apis.Util.RequestParameterAttribute("removeParents", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string RemoveParents { get; set; }

            /// <summary>
            /// Whether to set the modified date using the value supplied in the request body. Setting this field to
            /// `true` is equivalent to `modifiedDateBehavior=fromBodyOrNow`, and `false` is equivalent to
            /// `modifiedDateBehavior=now`. To prevent any changes to the modified date set
            /// `modifiedDateBehavior=noChange`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("setModifiedDate", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> SetModifiedDate { get; set; }

            /// <summary>Whether the requesting application supports both My Drives and shared drives.</summary>
            [Google.Apis.Util.RequestParameterAttribute("supportsAllDrives", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> SupportsAllDrives { get; set; }

            /// <summary>Deprecated: Use `supportsAllDrives` instead.</summary>
            [Google.Apis.Util.RequestParameterAttribute("supportsTeamDrives", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> SupportsTeamDrives { get; set; }

            /// <summary>The language of the timed text.</summary>
            [Google.Apis.Util.RequestParameterAttribute("timedTextLanguage", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string TimedTextLanguage { get; set; }

            /// <summary>The timed text track name.</summary>
            [Google.Apis.Util.RequestParameterAttribute("timedTextTrackName", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string TimedTextTrackName { get; set; }

            /// <summary>Whether to update the view date after successfully updating the file.</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateViewedDate", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> UpdateViewedDate { get; set; }

            /// <summary>Whether to use the content as indexable text.</summary>
            [Google.Apis.Util.RequestParameterAttribute("useContentAsIndexableText", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> UseContentAsIndexableText { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Drive.v2.Data.File Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "files/{fileId}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("fileId", new Google.Apis.Discovery.Parameter
                {
                    Name = "fileId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("addParents", new Google.Apis.Discovery.Parameter
                {
                    Name = "addParents",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("convert", new Google.Apis.Discovery.Parameter
                {
                    Name = "convert",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("enforceSingleParent", new Google.Apis.Discovery.Parameter
                {
                    Name = "enforceSingleParent",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("includeLabels", new Google.Apis.Discovery.Parameter
                {
                    Name = "includeLabels",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("includePermissionsForView", new Google.Apis.Discovery.Parameter
                {
                    Name = "includePermissionsForView",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("modifiedDateBehavior", new Google.Apis.Discovery.Parameter
                {
                    Name = "modifiedDateBehavior",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("newRevision", new Google.Apis.Discovery.Parameter
                {
                    Name = "newRevision",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "true",
                    Pattern = null,
                });
                RequestParameters.Add("ocr", new Google.Apis.Discovery.Parameter
                {
                    Name = "ocr",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("ocrLanguage", new Google.Apis.Discovery.Parameter
                {
                    Name = "ocrLanguage",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("pinned", new Google.Apis.Discovery.Parameter
                {
                    Name = "pinned",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("removeParents", new Google.Apis.Discovery.Parameter
                {
                    Name = "removeParents",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("setModifiedDate", new Google.Apis.Discovery.Parameter
                {
                    Name = "setModifiedDate",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("supportsAllDrives", new Google.Apis.Discovery.Parameter
                {
                    Name = "supportsAllDrives",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("supportsTeamDrives", new Google.Apis.Discovery.Parameter
                {
                    Name = "supportsTeamDrives",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("timedTextLanguage", new Google.Apis.Discovery.Parameter
                {
                    Name = "timedTextLanguage",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("timedTextTrackName", new Google.Apis.Discovery.Parameter
                {
                    Name = "timedTextTrackName",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("updateViewedDate", new Google.Apis.Discovery.Parameter
                {
                    Name = "updateViewedDate",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "true",
                    Pattern = null,
                });
                RequestParameters.Add("useContentAsIndexableText", new Google.Apis.Discovery.Parameter
                {
                    Name = "useContentAsIndexableText",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
            }
        }

        /// <summary>
        ///  Updates a file's metadata and/or content. When calling this method, only populate fields in the request
        /// that you want to modify. When updating fields, some fields might be changed automatically, such as
        /// `modifiedDate`. This method supports patch semantics. This method supports an */upload* URI and accepts
        /// uploaded media with the following characteristics: - *Maximum file size:* 5,120 GB - *Accepted Media MIME
        /// types:*`*/*` Note: Specify a valid MIME type, rather than the literal `*/*` value. The literal `*/*` is only
        /// used to indicate that any valid MIME type can be uploaded. For more information on uploading files, see
        /// [Upload file data](/workspace/drive/api/guides/manage-uploads).
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
        /// <param name="fileId">The ID of the file to update.</param>
        /// <param name="stream">The stream to upload. See remarks for further information.</param>
        /// <param name="contentType">The content type of the stream to upload.</param>
        public virtual UpdateMediaUpload Update(Google.Apis.Drive.v2.Data.File body, string fileId, System.IO.Stream stream, string contentType)
        {
            return new UpdateMediaUpload(service, body, fileId, stream, contentType);
        }

        /// <summary>Update media upload which supports resumable upload.</summary>
        public class UpdateMediaUpload : Google.Apis.Upload.ResumableUpload<Google.Apis.Drive.v2.Data.File, Google.Apis.Drive.v2.Data.File>
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

            /// <summary>The ID of the file to update.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fileId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string FileId { get; private set; }

            /// <summary>Comma-separated list of parent IDs to add.</summary>
            [Google.Apis.Util.RequestParameterAttribute("addParents", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string AddParents { get; set; }

            /// <summary>Deprecated: This parameter has no function.</summary>
            [Google.Apis.Util.RequestParameterAttribute("convert", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Convert { get; set; }

            /// <summary>
            /// Deprecated: Adding files to multiple folders is no longer supported. Use `shortcuts` instead.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("enforceSingleParent", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> EnforceSingleParent { get; set; }

            /// <summary>
            /// A comma-separated list of IDs of labels to include in the `labelInfo` part of the response.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("includeLabels", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string IncludeLabels { get; set; }

            /// <summary>
            /// Specifies which additional view's permissions to include in the response. Only `published` is supported.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("includePermissionsForView", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string IncludePermissionsForView { get; set; }

            /// <summary>
            /// Determines the behavior in which `modifiedDate` is updated. This overrides `setModifiedDate`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("modifiedDateBehavior", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ModifiedDateBehaviorEnum> ModifiedDateBehavior { get; set; }

            /// <summary>
            /// Determines the behavior in which `modifiedDate` is updated. This overrides `setModifiedDate`.
            /// </summary>
            public enum ModifiedDateBehaviorEnum
            {
                /// <summary>
                /// Set `modifiedDate` to the value provided in the body of the request. No change if no value was
                /// provided.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("fromBody")]
                FromBody = 0,

                /// <summary>
                /// Set `modifiedDate` to the value provided in the body of the request depending on other contents of
                /// the update.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("fromBodyIfNeeded")]
                FromBodyIfNeeded = 1,

                /// <summary>
                /// Set modifiedDate to the value provided in the body of the request, or to the current time if no
                /// value was provided.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("fromBodyOrNow")]
                FromBodyOrNow = 2,

                /// <summary>Maintain the previous value of `modifiedDate`.</summary>
                [Google.Apis.Util.StringValueAttribute("noChange")]
                NoChange = 3,

                /// <summary>Set `modifiedDate` to the current time.</summary>
                [Google.Apis.Util.StringValueAttribute("now")]
                Now = 4,

                /// <summary>Set `modifiedDate` to the current time depending on contents of the update.</summary>
                [Google.Apis.Util.StringValueAttribute("nowIfNeeded")]
                NowIfNeeded = 5,
            }

            /// <summary>
            /// Whether a blob upload should create a new revision. If false, the blob data in the current head revision
            /// is replaced. If true or not set, a new blob is created as head revision, and previous unpinned revisions
            /// are preserved for a short period of time. Pinned revisions are stored indefinitely, using additional
            /// storage quota, up to a maximum of 200 revisions. For details on how revisions are retained, see the
            /// [Drive Help Center](https://support.google.com/drive/answer/2409045).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("newRevision", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> NewRevision { get; set; }

            /// <summary>Whether to attempt OCR on .jpg, .png, .gif, or .pdf uploads.</summary>
            [Google.Apis.Util.RequestParameterAttribute("ocr", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Ocr { get; set; }

            /// <summary>If ocr is true, hints at the language to use. Valid values are BCP 47 codes.</summary>
            [Google.Apis.Util.RequestParameterAttribute("ocrLanguage", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OcrLanguage { get; set; }

            /// <summary>Whether to pin the new revision. A file can have a maximum of 200 pinned revisions.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pinned", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Pinned { get; set; }

            /// <summary>Comma-separated list of parent IDs to remove.</summary>
            [Google.Apis.Util.RequestParameterAttribute("removeParents", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string RemoveParents { get; set; }

            /// <summary>
            /// Whether to set the modified date using the value supplied in the request body. Setting this field to
            /// `true` is equivalent to `modifiedDateBehavior=fromBodyOrNow`, and `false` is equivalent to
            /// `modifiedDateBehavior=now`. To prevent any changes to the modified date set
            /// `modifiedDateBehavior=noChange`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("setModifiedDate", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> SetModifiedDate { get; set; }

            /// <summary>Whether the requesting application supports both My Drives and shared drives.</summary>
            [Google.Apis.Util.RequestParameterAttribute("supportsAllDrives", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> SupportsAllDrives { get; set; }

            /// <summary>Deprecated: Use `supportsAllDrives` instead.</summary>
            [Google.Apis.Util.RequestParameterAttribute("supportsTeamDrives", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> SupportsTeamDrives { get; set; }

            /// <summary>The language of the timed text.</summary>
            [Google.Apis.Util.RequestParameterAttribute("timedTextLanguage", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string TimedTextLanguage { get; set; }

            /// <summary>The timed text track name.</summary>
            [Google.Apis.Util.RequestParameterAttribute("timedTextTrackName", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string TimedTextTrackName { get; set; }

            /// <summary>Whether to update the view date after successfully updating the file.</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateViewedDate", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> UpdateViewedDate { get; set; }

            /// <summary>Whether to use the content as indexable text.</summary>
            [Google.Apis.Util.RequestParameterAttribute("useContentAsIndexableText", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> UseContentAsIndexableText { get; set; }

            /// <summary>Constructs a new Update media upload instance.</summary>
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
            public UpdateMediaUpload(Google.Apis.Services.IClientService service, Google.Apis.Drive.v2.Data.File body, string fileId, System.IO.Stream stream, string contentType)
                : base(service, string.Format("/{0}/{1}{2}", "upload", service.BasePath, "files/{fileId}"), "PUT", stream, contentType)
            {
                FileId = fileId;
                Body = body;
            }
        }

        /// <summary>Subscribes to changes to a file.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="fileId">The ID for the file in question.</param>
        public virtual WatchRequest Watch(Google.Apis.Drive.v2.Data.Channel body, string fileId)
        {
            return new WatchRequest(this.service, body, fileId);
        }

        /// <summary>Subscribes to changes to a file.</summary>
        public class WatchRequest : DriveBaseServiceRequest<Google.Apis.Drive.v2.Data.Channel>
        {
            /// <summary>Constructs a new Watch request.</summary>
            public WatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Drive.v2.Data.Channel body, string fileId) : base(service)
            {
                FileId = fileId;
                Body = body;
                InitParameters();
            }

            /// <summary>The ID for the file in question.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fileId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string FileId { get; private set; }

            /// <summary>
            /// Whether the user is acknowledging the risk of downloading known malware or other abusive files. This is
            /// only applicable when the `alt` parameter is set to `media` and the user is the owner of the file or an
            /// organizer of the shared drive in which the file resides.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("acknowledgeAbuse", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> AcknowledgeAbuse { get; set; }

            /// <summary>
            /// A comma-separated list of IDs of labels to include in the `labelInfo` part of the response.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("includeLabels", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string IncludeLabels { get; set; }

            /// <summary>
            /// Specifies which additional view's permissions to include in the response. Only `published` is supported.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("includePermissionsForView", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string IncludePermissionsForView { get; set; }

            /// <summary>Deprecated: This parameter has no function.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projection", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ProjectionEnum> Projection { get; set; }

            /// <summary>Deprecated: This parameter has no function.</summary>
            public enum ProjectionEnum
            {
                /// <summary>Deprecated.</summary>
                [Google.Apis.Util.StringValueAttribute("BASIC")]
                BASIC = 0,

                /// <summary>Deprecated.</summary>
                [Google.Apis.Util.StringValueAttribute("FULL")]
                FULL = 1,
            }

            /// <summary>
            /// Specifies the Revision ID that should be downloaded. Ignored unless alt=media is specified.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("revisionId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string RevisionId { get; set; }

            /// <summary>Whether the requesting application supports both My Drives and shared drives.</summary>
            [Google.Apis.Util.RequestParameterAttribute("supportsAllDrives", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> SupportsAllDrives { get; set; }

            /// <summary>Deprecated: Use `supportsAllDrives` instead.</summary>
            [Google.Apis.Util.RequestParameterAttribute("supportsTeamDrives", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> SupportsTeamDrives { get; set; }

            /// <summary>
            /// Deprecated: Use files.update with modifiedDateBehavior=noChange, updateViewedDate=true and an empty
            /// request body.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("updateViewedDate", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> UpdateViewedDate { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Drive.v2.Data.Channel Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "watch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "files/{fileId}/watch";

            /// <summary>Initializes Watch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("fileId", new Google.Apis.Discovery.Parameter
                {
                    Name = "fileId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("acknowledgeAbuse", new Google.Apis.Discovery.Parameter
                {
                    Name = "acknowledgeAbuse",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("includeLabels", new Google.Apis.Discovery.Parameter
                {
                    Name = "includeLabels",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("includePermissionsForView", new Google.Apis.Discovery.Parameter
                {
                    Name = "includePermissionsForView",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("projection", new Google.Apis.Discovery.Parameter
                {
                    Name = "projection",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("revisionId", new Google.Apis.Discovery.Parameter
                {
                    Name = "revisionId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("supportsAllDrives", new Google.Apis.Discovery.Parameter
                {
                    Name = "supportsAllDrives",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("supportsTeamDrives", new Google.Apis.Discovery.Parameter
                {
                    Name = "supportsTeamDrives",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("updateViewedDate", new Google.Apis.Discovery.Parameter
                {
                    Name = "updateViewedDate",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "parents" collection of methods.</summary>
    public class ParentsResource
    {
        private const string Resource = "parents";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ParentsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Removes a parent from a file.</summary>
        /// <param name="fileId">The ID of the file.</param>
        /// <param name="parentId">The ID of the parent.</param>
        public virtual DeleteRequest Delete(string fileId, string parentId)
        {
            return new DeleteRequest(this.service, fileId, parentId);
        }

        /// <summary>Removes a parent from a file.</summary>
        public class DeleteRequest : DriveBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string fileId, string parentId) : base(service)
            {
                FileId = fileId;
                ParentId = parentId;
                InitParameters();
            }

            /// <summary>The ID of the file.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fileId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string FileId { get; private set; }

            /// <summary>The ID of the parent.</summary>
            [Google.Apis.Util.RequestParameterAttribute("parentId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ParentId { get; private set; }

            /// <summary>
            /// Deprecated: If an item is not in a shared drive and its last parent is removed, the item is placed under
            /// its owner's root.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("enforceSingleParent", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> EnforceSingleParent { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "files/{fileId}/parents/{parentId}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("fileId", new Google.Apis.Discovery.Parameter
                {
                    Name = "fileId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("parentId", new Google.Apis.Discovery.Parameter
                {
                    Name = "parentId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("enforceSingleParent", new Google.Apis.Discovery.Parameter
                {
                    Name = "enforceSingleParent",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
            }
        }

        /// <summary>Gets a specific parent reference.</summary>
        /// <param name="fileId">The ID of the file.</param>
        /// <param name="parentId">The ID of the parent.</param>
        public virtual GetRequest Get(string fileId, string parentId)
        {
            return new GetRequest(this.service, fileId, parentId);
        }

        /// <summary>Gets a specific parent reference.</summary>
        public class GetRequest : DriveBaseServiceRequest<Google.Apis.Drive.v2.Data.ParentReference>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string fileId, string parentId) : base(service)
            {
                FileId = fileId;
                ParentId = parentId;
                InitParameters();
            }

            /// <summary>The ID of the file.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fileId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string FileId { get; private set; }

            /// <summary>The ID of the parent.</summary>
            [Google.Apis.Util.RequestParameterAttribute("parentId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ParentId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "files/{fileId}/parents/{parentId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("fileId", new Google.Apis.Discovery.Parameter
                {
                    Name = "fileId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("parentId", new Google.Apis.Discovery.Parameter
                {
                    Name = "parentId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Adds a parent folder for a file.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="fileId">The ID of the file.</param>
        public virtual InsertRequest Insert(Google.Apis.Drive.v2.Data.ParentReference body, string fileId)
        {
            return new InsertRequest(this.service, body, fileId);
        }

        /// <summary>Adds a parent folder for a file.</summary>
        public class InsertRequest : DriveBaseServiceRequest<Google.Apis.Drive.v2.Data.ParentReference>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Drive.v2.Data.ParentReference body, string fileId) : base(service)
            {
                FileId = fileId;
                Body = body;
                InitParameters();
            }

            /// <summary>The ID of the file.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fileId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string FileId { get; private set; }

            /// <summary>
            /// Deprecated: Adding files to multiple folders is no longer supported. Use `shortcuts` instead.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("enforceSingleParent", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> EnforceSingleParent { get; set; }

            /// <summary>Whether the requesting application supports both My Drives and shared drives.</summary>
            [Google.Apis.Util.RequestParameterAttribute("supportsAllDrives", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> SupportsAllDrives { get; set; }

            /// <summary>Deprecated: Use `supportsAllDrives` instead.</summary>
            [Google.Apis.Util.RequestParameterAttribute("supportsTeamDrives", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> SupportsTeamDrives { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Drive.v2.Data.ParentReference Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "files/{fileId}/parents";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("fileId", new Google.Apis.Discovery.Parameter
                {
                    Name = "fileId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("enforceSingleParent", new Google.Apis.Discovery.Parameter
                {
                    Name = "enforceSingleParent",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("supportsAllDrives", new Google.Apis.Discovery.Parameter
                {
                    Name = "supportsAllDrives",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("supportsTeamDrives", new Google.Apis.Discovery.Parameter
                {
                    Name = "supportsTeamDrives",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
            }
        }

        /// <summary>Lists a file's parents.</summary>
        /// <param name="fileId">The ID of the file.</param>
        public virtual ListRequest List(string fileId)
        {
            return new ListRequest(this.service, fileId);
        }

        /// <summary>Lists a file's parents.</summary>
        public class ListRequest : DriveBaseServiceRequest<Google.Apis.Drive.v2.Data.ParentList>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string fileId) : base(service)
            {
                FileId = fileId;
                InitParameters();
            }

            /// <summary>The ID of the file.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fileId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string FileId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "files/{fileId}/parents";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("fileId", new Google.Apis.Discovery.Parameter
                {
                    Name = "fileId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

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
        /// Deletes a permission from a file or shared drive. **Warning:** Concurrent permissions operations on the same
        /// file are not supported; only the last update is applied.
        /// </summary>
        /// <param name="fileId">The ID for the file or shared drive.</param>
        /// <param name="permissionId">The ID for the permission.</param>
        public virtual DeleteRequest Delete(string fileId, string permissionId)
        {
            return new DeleteRequest(this.service, fileId, permissionId);
        }

        /// <summary>
        /// Deletes a permission from a file or shared drive. **Warning:** Concurrent permissions operations on the same
        /// file are not supported; only the last update is applied.
        /// </summary>
        public class DeleteRequest : DriveBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string fileId, string permissionId) : base(service)
            {
                FileId = fileId;
                PermissionId = permissionId;
                InitParameters();
            }

            /// <summary>The ID for the file or shared drive.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fileId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string FileId { get; private set; }

            /// <summary>The ID for the permission.</summary>
            [Google.Apis.Util.RequestParameterAttribute("permissionId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PermissionId { get; private set; }

            /// <summary>Whether the request should enforce expansive access rules.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enforceExpansiveAccess", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> EnforceExpansiveAccess { get; set; }

            /// <summary>Whether the requesting application supports both My Drives and shared drives.</summary>
            [Google.Apis.Util.RequestParameterAttribute("supportsAllDrives", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> SupportsAllDrives { get; set; }

            /// <summary>Deprecated: Use `supportsAllDrives` instead.</summary>
            [Google.Apis.Util.RequestParameterAttribute("supportsTeamDrives", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> SupportsTeamDrives { get; set; }

            /// <summary>
            /// Issue the request as a domain administrator; if set to true, then the requester will be granted access
            /// if the file ID parameter refers to a shared drive and the requester is an administrator of the domain to
            /// which the shared drive belongs.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("useDomainAdminAccess", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> UseDomainAdminAccess { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "files/{fileId}/permissions/{permissionId}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("fileId", new Google.Apis.Discovery.Parameter
                {
                    Name = "fileId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("permissionId", new Google.Apis.Discovery.Parameter
                {
                    Name = "permissionId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("enforceExpansiveAccess", new Google.Apis.Discovery.Parameter
                {
                    Name = "enforceExpansiveAccess",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("supportsAllDrives", new Google.Apis.Discovery.Parameter
                {
                    Name = "supportsAllDrives",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("supportsTeamDrives", new Google.Apis.Discovery.Parameter
                {
                    Name = "supportsTeamDrives",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("useDomainAdminAccess", new Google.Apis.Discovery.Parameter
                {
                    Name = "useDomainAdminAccess",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
            }
        }

        /// <summary>Gets a permission by ID.</summary>
        /// <param name="fileId">The ID for the file or shared drive.</param>
        /// <param name="permissionId">The ID for the permission.</param>
        public virtual GetRequest Get(string fileId, string permissionId)
        {
            return new GetRequest(this.service, fileId, permissionId);
        }

        /// <summary>Gets a permission by ID.</summary>
        public class GetRequest : DriveBaseServiceRequest<Google.Apis.Drive.v2.Data.Permission>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string fileId, string permissionId) : base(service)
            {
                FileId = fileId;
                PermissionId = permissionId;
                InitParameters();
            }

            /// <summary>The ID for the file or shared drive.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fileId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string FileId { get; private set; }

            /// <summary>The ID for the permission.</summary>
            [Google.Apis.Util.RequestParameterAttribute("permissionId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PermissionId { get; private set; }

            /// <summary>Whether the requesting application supports both My Drives and shared drives.</summary>
            [Google.Apis.Util.RequestParameterAttribute("supportsAllDrives", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> SupportsAllDrives { get; set; }

            /// <summary>Deprecated: Use `supportsAllDrives` instead.</summary>
            [Google.Apis.Util.RequestParameterAttribute("supportsTeamDrives", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> SupportsTeamDrives { get; set; }

            /// <summary>
            /// Issue the request as a domain administrator; if set to true, then the requester will be granted access
            /// if the file ID parameter refers to a shared drive and the requester is an administrator of the domain to
            /// which the shared drive belongs.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("useDomainAdminAccess", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> UseDomainAdminAccess { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "files/{fileId}/permissions/{permissionId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("fileId", new Google.Apis.Discovery.Parameter
                {
                    Name = "fileId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("permissionId", new Google.Apis.Discovery.Parameter
                {
                    Name = "permissionId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("supportsAllDrives", new Google.Apis.Discovery.Parameter
                {
                    Name = "supportsAllDrives",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("supportsTeamDrives", new Google.Apis.Discovery.Parameter
                {
                    Name = "supportsTeamDrives",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("useDomainAdminAccess", new Google.Apis.Discovery.Parameter
                {
                    Name = "useDomainAdminAccess",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
            }
        }

        /// <summary>Returns the permission ID for an email address.</summary>
        /// <param name="email">The email address for which to return a permission ID</param>
        public virtual GetIdForEmailRequest GetIdForEmail(string email)
        {
            return new GetIdForEmailRequest(this.service, email);
        }

        /// <summary>Returns the permission ID for an email address.</summary>
        public class GetIdForEmailRequest : DriveBaseServiceRequest<Google.Apis.Drive.v2.Data.PermissionId>
        {
            /// <summary>Constructs a new GetIdForEmail request.</summary>
            public GetIdForEmailRequest(Google.Apis.Services.IClientService service, string email) : base(service)
            {
                Email = email;
                InitParameters();
            }

            /// <summary>The email address for which to return a permission ID</summary>
            [Google.Apis.Util.RequestParameterAttribute("email", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Email { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getIdForEmail";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "permissionIds/{email}";

            /// <summary>Initializes GetIdForEmail parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("email", new Google.Apis.Discovery.Parameter
                {
                    Name = "email",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Inserts a permission for a file or shared drive. **Warning:** Concurrent permissions operations on the same
        /// file are not supported; only the last update is applied.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="fileId">The ID for the file or shared drive.</param>
        public virtual InsertRequest Insert(Google.Apis.Drive.v2.Data.Permission body, string fileId)
        {
            return new InsertRequest(this.service, body, fileId);
        }

        /// <summary>
        /// Inserts a permission for a file or shared drive. **Warning:** Concurrent permissions operations on the same
        /// file are not supported; only the last update is applied.
        /// </summary>
        public class InsertRequest : DriveBaseServiceRequest<Google.Apis.Drive.v2.Data.Permission>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Drive.v2.Data.Permission body, string fileId) : base(service)
            {
                FileId = fileId;
                Body = body;
                InitParameters();
            }

            /// <summary>The ID for the file or shared drive.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fileId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string FileId { get; private set; }

            /// <summary>A plain text custom message to include in notification emails.</summary>
            [Google.Apis.Util.RequestParameterAttribute("emailMessage", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string EmailMessage { get; set; }

            /// <summary>Deprecated: See `moveToNewOwnersRoot` for details.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enforceSingleParent", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> EnforceSingleParent { get; set; }

            /// <summary>
            /// This parameter will only take effect if the item is not in a shared drive and the request is attempting
            /// to transfer the ownership of the item. If set to `true`, the item will be moved to the new owner's My
            /// Drive root folder and all prior parents removed. If set to `false`, parents are not changed.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("moveToNewOwnersRoot", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> MoveToNewOwnersRoot { get; set; }

            /// <summary>
            /// Whether to send notification emails when sharing to users or groups. This parameter is ignored and an
            /// email is sent if the `role` is `owner`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("sendNotificationEmails", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> SendNotificationEmails { get; set; }

            /// <summary>Whether the requesting application supports both My Drives and shared drives.</summary>
            [Google.Apis.Util.RequestParameterAttribute("supportsAllDrives", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> SupportsAllDrives { get; set; }

            /// <summary>Deprecated: Use `supportsAllDrives` instead.</summary>
            [Google.Apis.Util.RequestParameterAttribute("supportsTeamDrives", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> SupportsTeamDrives { get; set; }

            /// <summary>
            /// Issue the request as a domain administrator; if set to true, then the requester will be granted access
            /// if the file ID parameter refers to a shared drive and the requester is an administrator of the domain to
            /// which the shared drive belongs.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("useDomainAdminAccess", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> UseDomainAdminAccess { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Drive.v2.Data.Permission Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "files/{fileId}/permissions";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("fileId", new Google.Apis.Discovery.Parameter
                {
                    Name = "fileId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("emailMessage", new Google.Apis.Discovery.Parameter
                {
                    Name = "emailMessage",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("enforceSingleParent", new Google.Apis.Discovery.Parameter
                {
                    Name = "enforceSingleParent",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("moveToNewOwnersRoot", new Google.Apis.Discovery.Parameter
                {
                    Name = "moveToNewOwnersRoot",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("sendNotificationEmails", new Google.Apis.Discovery.Parameter
                {
                    Name = "sendNotificationEmails",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "true",
                    Pattern = null,
                });
                RequestParameters.Add("supportsAllDrives", new Google.Apis.Discovery.Parameter
                {
                    Name = "supportsAllDrives",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("supportsTeamDrives", new Google.Apis.Discovery.Parameter
                {
                    Name = "supportsTeamDrives",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("useDomainAdminAccess", new Google.Apis.Discovery.Parameter
                {
                    Name = "useDomainAdminAccess",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
            }
        }

        /// <summary>Lists a file's or shared drive's permissions.</summary>
        /// <param name="fileId">The ID for the file or shared drive.</param>
        public virtual ListRequest List(string fileId)
        {
            return new ListRequest(this.service, fileId);
        }

        /// <summary>Lists a file's or shared drive's permissions.</summary>
        public class ListRequest : DriveBaseServiceRequest<Google.Apis.Drive.v2.Data.PermissionList>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string fileId) : base(service)
            {
                FileId = fileId;
                InitParameters();
            }

            /// <summary>The ID for the file or shared drive.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fileId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string FileId { get; private set; }

            /// <summary>
            /// Specifies which additional view's permissions to include in the response. Only `published` is supported.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("includePermissionsForView", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string IncludePermissionsForView { get; set; }

            /// <summary>
            /// The maximum number of permissions to return per page. When not set for files in a shared drive, at most
            /// 100 results will be returned. When not set for files that are not in a shared drive, the entire list
            /// will be returned.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>
            /// The token for continuing a previous list request on the next page. This should be set to the value of
            /// `nextPageToken` from the previous response.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Whether the requesting application supports both My Drives and shared drives.</summary>
            [Google.Apis.Util.RequestParameterAttribute("supportsAllDrives", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> SupportsAllDrives { get; set; }

            /// <summary>Deprecated: Use `supportsAllDrives` instead.</summary>
            [Google.Apis.Util.RequestParameterAttribute("supportsTeamDrives", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> SupportsTeamDrives { get; set; }

            /// <summary>
            /// Issue the request as a domain administrator; if set to true, then the requester will be granted access
            /// if the file ID parameter refers to a shared drive and the requester is an administrator of the domain to
            /// which the shared drive belongs.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("useDomainAdminAccess", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> UseDomainAdminAccess { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "files/{fileId}/permissions";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("fileId", new Google.Apis.Discovery.Parameter
                {
                    Name = "fileId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("includePermissionsForView", new Google.Apis.Discovery.Parameter
                {
                    Name = "includePermissionsForView",
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
                RequestParameters.Add("supportsAllDrives", new Google.Apis.Discovery.Parameter
                {
                    Name = "supportsAllDrives",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("supportsTeamDrives", new Google.Apis.Discovery.Parameter
                {
                    Name = "supportsTeamDrives",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("useDomainAdminAccess", new Google.Apis.Discovery.Parameter
                {
                    Name = "useDomainAdminAccess",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Updates a permission using patch semantics. **Warning:** Concurrent permissions operations on the same file
        /// are not supported; only the last update is applied.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="fileId">The ID for the file or shared drive.</param>
        /// <param name="permissionId">The ID for the permission.</param>
        public virtual PatchRequest Patch(Google.Apis.Drive.v2.Data.Permission body, string fileId, string permissionId)
        {
            return new PatchRequest(this.service, body, fileId, permissionId);
        }

        /// <summary>
        /// Updates a permission using patch semantics. **Warning:** Concurrent permissions operations on the same file
        /// are not supported; only the last update is applied.
        /// </summary>
        public class PatchRequest : DriveBaseServiceRequest<Google.Apis.Drive.v2.Data.Permission>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Drive.v2.Data.Permission body, string fileId, string permissionId) : base(service)
            {
                FileId = fileId;
                PermissionId = permissionId;
                Body = body;
                InitParameters();
            }

            /// <summary>The ID for the file or shared drive.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fileId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string FileId { get; private set; }

            /// <summary>The ID for the permission.</summary>
            [Google.Apis.Util.RequestParameterAttribute("permissionId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PermissionId { get; private set; }

            /// <summary>Whether the request should enforce expansive access rules.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enforceExpansiveAccess", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> EnforceExpansiveAccess { get; set; }

            /// <summary>Whether to remove the expiration date.</summary>
            [Google.Apis.Util.RequestParameterAttribute("removeExpiration", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> RemoveExpiration { get; set; }

            /// <summary>Whether the requesting application supports both My Drives and shared drives.</summary>
            [Google.Apis.Util.RequestParameterAttribute("supportsAllDrives", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> SupportsAllDrives { get; set; }

            /// <summary>Deprecated: Use `supportsAllDrives` instead.</summary>
            [Google.Apis.Util.RequestParameterAttribute("supportsTeamDrives", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> SupportsTeamDrives { get; set; }

            /// <summary>
            /// Whether changing a role to `owner` downgrades the current owners to writers. Does nothing if the
            /// specified role is not `owner`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("transferOwnership", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> TransferOwnership { get; set; }

            /// <summary>
            /// Issue the request as a domain administrator; if set to true, then the requester will be granted access
            /// if the file ID parameter refers to a shared drive and the requester is an administrator of the domain to
            /// which the shared drive belongs.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("useDomainAdminAccess", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> UseDomainAdminAccess { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Drive.v2.Data.Permission Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "files/{fileId}/permissions/{permissionId}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("fileId", new Google.Apis.Discovery.Parameter
                {
                    Name = "fileId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("permissionId", new Google.Apis.Discovery.Parameter
                {
                    Name = "permissionId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("enforceExpansiveAccess", new Google.Apis.Discovery.Parameter
                {
                    Name = "enforceExpansiveAccess",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("removeExpiration", new Google.Apis.Discovery.Parameter
                {
                    Name = "removeExpiration",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("supportsAllDrives", new Google.Apis.Discovery.Parameter
                {
                    Name = "supportsAllDrives",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("supportsTeamDrives", new Google.Apis.Discovery.Parameter
                {
                    Name = "supportsTeamDrives",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("transferOwnership", new Google.Apis.Discovery.Parameter
                {
                    Name = "transferOwnership",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("useDomainAdminAccess", new Google.Apis.Discovery.Parameter
                {
                    Name = "useDomainAdminAccess",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Updates a permission. **Warning:** Concurrent permissions operations on the same file are not supported;
        /// only the last update is applied.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="fileId">The ID for the file or shared drive.</param>
        /// <param name="permissionId">The ID for the permission.</param>
        public virtual UpdateRequest Update(Google.Apis.Drive.v2.Data.Permission body, string fileId, string permissionId)
        {
            return new UpdateRequest(this.service, body, fileId, permissionId);
        }

        /// <summary>
        /// Updates a permission. **Warning:** Concurrent permissions operations on the same file are not supported;
        /// only the last update is applied.
        /// </summary>
        public class UpdateRequest : DriveBaseServiceRequest<Google.Apis.Drive.v2.Data.Permission>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Drive.v2.Data.Permission body, string fileId, string permissionId) : base(service)
            {
                FileId = fileId;
                PermissionId = permissionId;
                Body = body;
                InitParameters();
            }

            /// <summary>The ID for the file or shared drive.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fileId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string FileId { get; private set; }

            /// <summary>The ID for the permission.</summary>
            [Google.Apis.Util.RequestParameterAttribute("permissionId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PermissionId { get; private set; }

            /// <summary>Whether the request should enforce expansive access rules.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enforceExpansiveAccess", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> EnforceExpansiveAccess { get; set; }

            /// <summary>Whether to remove the expiration date.</summary>
            [Google.Apis.Util.RequestParameterAttribute("removeExpiration", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> RemoveExpiration { get; set; }

            /// <summary>Whether the requesting application supports both My Drives and shared drives.</summary>
            [Google.Apis.Util.RequestParameterAttribute("supportsAllDrives", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> SupportsAllDrives { get; set; }

            /// <summary>Deprecated: Use `supportsAllDrives` instead.</summary>
            [Google.Apis.Util.RequestParameterAttribute("supportsTeamDrives", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> SupportsTeamDrives { get; set; }

            /// <summary>
            /// Whether changing a role to `owner` downgrades the current owners to writers. Does nothing if the
            /// specified role is not `owner`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("transferOwnership", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> TransferOwnership { get; set; }

            /// <summary>
            /// Issue the request as a domain administrator; if set to true, then the requester will be granted access
            /// if the file ID parameter refers to a shared drive and the requester is an administrator of the domain to
            /// which the shared drive belongs.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("useDomainAdminAccess", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> UseDomainAdminAccess { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Drive.v2.Data.Permission Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "files/{fileId}/permissions/{permissionId}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("fileId", new Google.Apis.Discovery.Parameter
                {
                    Name = "fileId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("permissionId", new Google.Apis.Discovery.Parameter
                {
                    Name = "permissionId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("enforceExpansiveAccess", new Google.Apis.Discovery.Parameter
                {
                    Name = "enforceExpansiveAccess",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("removeExpiration", new Google.Apis.Discovery.Parameter
                {
                    Name = "removeExpiration",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("supportsAllDrives", new Google.Apis.Discovery.Parameter
                {
                    Name = "supportsAllDrives",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("supportsTeamDrives", new Google.Apis.Discovery.Parameter
                {
                    Name = "supportsTeamDrives",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("transferOwnership", new Google.Apis.Discovery.Parameter
                {
                    Name = "transferOwnership",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("useDomainAdminAccess", new Google.Apis.Discovery.Parameter
                {
                    Name = "useDomainAdminAccess",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "properties" collection of methods.</summary>
    public class PropertiesResource
    {
        private const string Resource = "properties";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public PropertiesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Deletes a property.</summary>
        /// <param name="fileId">The ID of the file.</param>
        /// <param name="propertyKey">The key of the property.</param>
        public virtual DeleteRequest Delete(string fileId, string propertyKey)
        {
            return new DeleteRequest(this.service, fileId, propertyKey);
        }

        /// <summary>Deletes a property.</summary>
        public class DeleteRequest : DriveBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string fileId, string propertyKey) : base(service)
            {
                FileId = fileId;
                PropertyKey = propertyKey;
                InitParameters();
            }

            /// <summary>The ID of the file.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fileId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string FileId { get; private set; }

            /// <summary>The key of the property.</summary>
            [Google.Apis.Util.RequestParameterAttribute("propertyKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PropertyKey { get; private set; }

            /// <summary>The visibility of the property.</summary>
            [Google.Apis.Util.RequestParameterAttribute("visibility", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Visibility { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "files/{fileId}/properties/{propertyKey}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("fileId", new Google.Apis.Discovery.Parameter
                {
                    Name = "fileId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("propertyKey", new Google.Apis.Discovery.Parameter
                {
                    Name = "propertyKey",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("visibility", new Google.Apis.Discovery.Parameter
                {
                    Name = "visibility",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "private",
                    Pattern = null,
                });
            }
        }

        /// <summary>Gets a property by its key.</summary>
        /// <param name="fileId">The ID of the file.</param>
        /// <param name="propertyKey">The key of the property.</param>
        public virtual GetRequest Get(string fileId, string propertyKey)
        {
            return new GetRequest(this.service, fileId, propertyKey);
        }

        /// <summary>Gets a property by its key.</summary>
        public class GetRequest : DriveBaseServiceRequest<Google.Apis.Drive.v2.Data.Property>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string fileId, string propertyKey) : base(service)
            {
                FileId = fileId;
                PropertyKey = propertyKey;
                InitParameters();
            }

            /// <summary>The ID of the file.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fileId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string FileId { get; private set; }

            /// <summary>The key of the property.</summary>
            [Google.Apis.Util.RequestParameterAttribute("propertyKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PropertyKey { get; private set; }

            /// <summary>The visibility of the property.</summary>
            [Google.Apis.Util.RequestParameterAttribute("visibility", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Visibility { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "files/{fileId}/properties/{propertyKey}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("fileId", new Google.Apis.Discovery.Parameter
                {
                    Name = "fileId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("propertyKey", new Google.Apis.Discovery.Parameter
                {
                    Name = "propertyKey",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("visibility", new Google.Apis.Discovery.Parameter
                {
                    Name = "visibility",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "private",
                    Pattern = null,
                });
            }
        }

        /// <summary>Adds a property to a file, or updates it if it already exists.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="fileId">The ID of the file.</param>
        public virtual InsertRequest Insert(Google.Apis.Drive.v2.Data.Property body, string fileId)
        {
            return new InsertRequest(this.service, body, fileId);
        }

        /// <summary>Adds a property to a file, or updates it if it already exists.</summary>
        public class InsertRequest : DriveBaseServiceRequest<Google.Apis.Drive.v2.Data.Property>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Drive.v2.Data.Property body, string fileId) : base(service)
            {
                FileId = fileId;
                Body = body;
                InitParameters();
            }

            /// <summary>The ID of the file.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fileId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string FileId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Drive.v2.Data.Property Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "files/{fileId}/properties";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("fileId", new Google.Apis.Discovery.Parameter
                {
                    Name = "fileId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Lists a file's properties.</summary>
        /// <param name="fileId">The ID of the file.</param>
        public virtual ListRequest List(string fileId)
        {
            return new ListRequest(this.service, fileId);
        }

        /// <summary>Lists a file's properties.</summary>
        public class ListRequest : DriveBaseServiceRequest<Google.Apis.Drive.v2.Data.PropertyList>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string fileId) : base(service)
            {
                FileId = fileId;
                InitParameters();
            }

            /// <summary>The ID of the file.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fileId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string FileId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "files/{fileId}/properties";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("fileId", new Google.Apis.Discovery.Parameter
                {
                    Name = "fileId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates a property.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="fileId">The ID of the file.</param>
        /// <param name="propertyKey">The key of the property.</param>
        public virtual PatchRequest Patch(Google.Apis.Drive.v2.Data.Property body, string fileId, string propertyKey)
        {
            return new PatchRequest(this.service, body, fileId, propertyKey);
        }

        /// <summary>Updates a property.</summary>
        public class PatchRequest : DriveBaseServiceRequest<Google.Apis.Drive.v2.Data.Property>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Drive.v2.Data.Property body, string fileId, string propertyKey) : base(service)
            {
                FileId = fileId;
                PropertyKey = propertyKey;
                Body = body;
                InitParameters();
            }

            /// <summary>The ID of the file.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fileId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string FileId { get; private set; }

            /// <summary>The key of the property.</summary>
            [Google.Apis.Util.RequestParameterAttribute("propertyKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PropertyKey { get; private set; }

            /// <summary>
            /// The visibility of the property. Allowed values are PRIVATE and PUBLIC. (Default: PRIVATE)
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("visibility", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Visibility { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Drive.v2.Data.Property Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "files/{fileId}/properties/{propertyKey}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("fileId", new Google.Apis.Discovery.Parameter
                {
                    Name = "fileId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("propertyKey", new Google.Apis.Discovery.Parameter
                {
                    Name = "propertyKey",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("visibility", new Google.Apis.Discovery.Parameter
                {
                    Name = "visibility",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "private",
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates a property.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="fileId">The ID of the file.</param>
        /// <param name="propertyKey">The key of the property.</param>
        public virtual UpdateRequest Update(Google.Apis.Drive.v2.Data.Property body, string fileId, string propertyKey)
        {
            return new UpdateRequest(this.service, body, fileId, propertyKey);
        }

        /// <summary>Updates a property.</summary>
        public class UpdateRequest : DriveBaseServiceRequest<Google.Apis.Drive.v2.Data.Property>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Drive.v2.Data.Property body, string fileId, string propertyKey) : base(service)
            {
                FileId = fileId;
                PropertyKey = propertyKey;
                Body = body;
                InitParameters();
            }

            /// <summary>The ID of the file.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fileId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string FileId { get; private set; }

            /// <summary>The key of the property.</summary>
            [Google.Apis.Util.RequestParameterAttribute("propertyKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PropertyKey { get; private set; }

            /// <summary>
            /// The visibility of the property. Allowed values are PRIVATE and PUBLIC. (Default: PRIVATE)
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("visibility", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Visibility { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Drive.v2.Data.Property Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "files/{fileId}/properties/{propertyKey}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("fileId", new Google.Apis.Discovery.Parameter
                {
                    Name = "fileId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("propertyKey", new Google.Apis.Discovery.Parameter
                {
                    Name = "propertyKey",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("visibility", new Google.Apis.Discovery.Parameter
                {
                    Name = "visibility",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "private",
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "replies" collection of methods.</summary>
    public class RepliesResource
    {
        private const string Resource = "replies";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public RepliesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Deletes a reply.</summary>
        /// <param name="fileId">The ID of the file.</param>
        /// <param name="commentId">The ID of the comment.</param>
        /// <param name="replyId">The ID of the reply.</param>
        public virtual DeleteRequest Delete(string fileId, string commentId, string replyId)
        {
            return new DeleteRequest(this.service, fileId, commentId, replyId);
        }

        /// <summary>Deletes a reply.</summary>
        public class DeleteRequest : DriveBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string fileId, string commentId, string replyId) : base(service)
            {
                FileId = fileId;
                CommentId = commentId;
                ReplyId = replyId;
                InitParameters();
            }

            /// <summary>The ID of the file.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fileId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string FileId { get; private set; }

            /// <summary>The ID of the comment.</summary>
            [Google.Apis.Util.RequestParameterAttribute("commentId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CommentId { get; private set; }

            /// <summary>The ID of the reply.</summary>
            [Google.Apis.Util.RequestParameterAttribute("replyId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ReplyId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "files/{fileId}/comments/{commentId}/replies/{replyId}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("fileId", new Google.Apis.Discovery.Parameter
                {
                    Name = "fileId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("commentId", new Google.Apis.Discovery.Parameter
                {
                    Name = "commentId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("replyId", new Google.Apis.Discovery.Parameter
                {
                    Name = "replyId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Gets a reply.</summary>
        /// <param name="fileId">The ID of the file.</param>
        /// <param name="commentId">The ID of the comment.</param>
        /// <param name="replyId">The ID of the reply.</param>
        public virtual GetRequest Get(string fileId, string commentId, string replyId)
        {
            return new GetRequest(this.service, fileId, commentId, replyId);
        }

        /// <summary>Gets a reply.</summary>
        public class GetRequest : DriveBaseServiceRequest<Google.Apis.Drive.v2.Data.CommentReply>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string fileId, string commentId, string replyId) : base(service)
            {
                FileId = fileId;
                CommentId = commentId;
                ReplyId = replyId;
                InitParameters();
            }

            /// <summary>The ID of the file.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fileId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string FileId { get; private set; }

            /// <summary>The ID of the comment.</summary>
            [Google.Apis.Util.RequestParameterAttribute("commentId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CommentId { get; private set; }

            /// <summary>The ID of the reply.</summary>
            [Google.Apis.Util.RequestParameterAttribute("replyId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ReplyId { get; private set; }

            /// <summary>If set, this will succeed when retrieving a deleted reply.</summary>
            [Google.Apis.Util.RequestParameterAttribute("includeDeleted", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> IncludeDeleted { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "files/{fileId}/comments/{commentId}/replies/{replyId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("fileId", new Google.Apis.Discovery.Parameter
                {
                    Name = "fileId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("commentId", new Google.Apis.Discovery.Parameter
                {
                    Name = "commentId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("replyId", new Google.Apis.Discovery.Parameter
                {
                    Name = "replyId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("includeDeleted", new Google.Apis.Discovery.Parameter
                {
                    Name = "includeDeleted",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
            }
        }

        /// <summary>Creates a new reply to the given comment.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="fileId">The ID of the file.</param>
        /// <param name="commentId">The ID of the comment.</param>
        public virtual InsertRequest Insert(Google.Apis.Drive.v2.Data.CommentReply body, string fileId, string commentId)
        {
            return new InsertRequest(this.service, body, fileId, commentId);
        }

        /// <summary>Creates a new reply to the given comment.</summary>
        public class InsertRequest : DriveBaseServiceRequest<Google.Apis.Drive.v2.Data.CommentReply>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Drive.v2.Data.CommentReply body, string fileId, string commentId) : base(service)
            {
                FileId = fileId;
                CommentId = commentId;
                Body = body;
                InitParameters();
            }

            /// <summary>The ID of the file.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fileId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string FileId { get; private set; }

            /// <summary>The ID of the comment.</summary>
            [Google.Apis.Util.RequestParameterAttribute("commentId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CommentId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Drive.v2.Data.CommentReply Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "files/{fileId}/comments/{commentId}/replies";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("fileId", new Google.Apis.Discovery.Parameter
                {
                    Name = "fileId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("commentId", new Google.Apis.Discovery.Parameter
                {
                    Name = "commentId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Lists all of the replies to a comment.</summary>
        /// <param name="fileId">The ID of the file.</param>
        /// <param name="commentId">The ID of the comment.</param>
        public virtual ListRequest List(string fileId, string commentId)
        {
            return new ListRequest(this.service, fileId, commentId);
        }

        /// <summary>Lists all of the replies to a comment.</summary>
        public class ListRequest : DriveBaseServiceRequest<Google.Apis.Drive.v2.Data.CommentReplyList>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string fileId, string commentId) : base(service)
            {
                FileId = fileId;
                CommentId = commentId;
                InitParameters();
            }

            /// <summary>The ID of the file.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fileId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string FileId { get; private set; }

            /// <summary>The ID of the comment.</summary>
            [Google.Apis.Util.RequestParameterAttribute("commentId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CommentId { get; private set; }

            /// <summary>
            /// If set, all replies, including deleted replies (with content stripped) will be returned.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("includeDeleted", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> IncludeDeleted { get; set; }

            /// <summary>The maximum number of replies to include in the response, used for paging.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>
            /// The continuation token, used to page through large result sets. To get the next page of results, set
            /// this parameter to the value of "nextPageToken" from the previous response.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "files/{fileId}/comments/{commentId}/replies";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("fileId", new Google.Apis.Discovery.Parameter
                {
                    Name = "fileId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("commentId", new Google.Apis.Discovery.Parameter
                {
                    Name = "commentId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("includeDeleted", new Google.Apis.Discovery.Parameter
                {
                    Name = "includeDeleted",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "20",
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

        /// <summary>Updates an existing reply.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="fileId">The ID of the file.</param>
        /// <param name="commentId">The ID of the comment.</param>
        /// <param name="replyId">The ID of the reply.</param>
        public virtual PatchRequest Patch(Google.Apis.Drive.v2.Data.CommentReply body, string fileId, string commentId, string replyId)
        {
            return new PatchRequest(this.service, body, fileId, commentId, replyId);
        }

        /// <summary>Updates an existing reply.</summary>
        public class PatchRequest : DriveBaseServiceRequest<Google.Apis.Drive.v2.Data.CommentReply>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Drive.v2.Data.CommentReply body, string fileId, string commentId, string replyId) : base(service)
            {
                FileId = fileId;
                CommentId = commentId;
                ReplyId = replyId;
                Body = body;
                InitParameters();
            }

            /// <summary>The ID of the file.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fileId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string FileId { get; private set; }

            /// <summary>The ID of the comment.</summary>
            [Google.Apis.Util.RequestParameterAttribute("commentId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CommentId { get; private set; }

            /// <summary>The ID of the reply.</summary>
            [Google.Apis.Util.RequestParameterAttribute("replyId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ReplyId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Drive.v2.Data.CommentReply Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "files/{fileId}/comments/{commentId}/replies/{replyId}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("fileId", new Google.Apis.Discovery.Parameter
                {
                    Name = "fileId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("commentId", new Google.Apis.Discovery.Parameter
                {
                    Name = "commentId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("replyId", new Google.Apis.Discovery.Parameter
                {
                    Name = "replyId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates an existing reply.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="fileId">The ID of the file.</param>
        /// <param name="commentId">The ID of the comment.</param>
        /// <param name="replyId">The ID of the reply.</param>
        public virtual UpdateRequest Update(Google.Apis.Drive.v2.Data.CommentReply body, string fileId, string commentId, string replyId)
        {
            return new UpdateRequest(this.service, body, fileId, commentId, replyId);
        }

        /// <summary>Updates an existing reply.</summary>
        public class UpdateRequest : DriveBaseServiceRequest<Google.Apis.Drive.v2.Data.CommentReply>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Drive.v2.Data.CommentReply body, string fileId, string commentId, string replyId) : base(service)
            {
                FileId = fileId;
                CommentId = commentId;
                ReplyId = replyId;
                Body = body;
                InitParameters();
            }

            /// <summary>The ID of the file.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fileId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string FileId { get; private set; }

            /// <summary>The ID of the comment.</summary>
            [Google.Apis.Util.RequestParameterAttribute("commentId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CommentId { get; private set; }

            /// <summary>The ID of the reply.</summary>
            [Google.Apis.Util.RequestParameterAttribute("replyId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ReplyId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Drive.v2.Data.CommentReply Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "files/{fileId}/comments/{commentId}/replies/{replyId}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("fileId", new Google.Apis.Discovery.Parameter
                {
                    Name = "fileId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("commentId", new Google.Apis.Discovery.Parameter
                {
                    Name = "commentId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("replyId", new Google.Apis.Discovery.Parameter
                {
                    Name = "replyId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "revisions" collection of methods.</summary>
    public class RevisionsResource
    {
        private const string Resource = "revisions";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public RevisionsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Permanently deletes a file version. You can only delete revisions for files with binary content, like images
        /// or videos. Revisions for other files, like Google Docs or Sheets, and the last remaining file version can't
        /// be deleted.
        /// </summary>
        /// <param name="fileId">The ID of the file.</param>
        /// <param name="revisionId">The ID of the revision.</param>
        public virtual DeleteRequest Delete(string fileId, string revisionId)
        {
            return new DeleteRequest(this.service, fileId, revisionId);
        }

        /// <summary>
        /// Permanently deletes a file version. You can only delete revisions for files with binary content, like images
        /// or videos. Revisions for other files, like Google Docs or Sheets, and the last remaining file version can't
        /// be deleted.
        /// </summary>
        public class DeleteRequest : DriveBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string fileId, string revisionId) : base(service)
            {
                FileId = fileId;
                RevisionId = revisionId;
                InitParameters();
            }

            /// <summary>The ID of the file.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fileId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string FileId { get; private set; }

            /// <summary>The ID of the revision.</summary>
            [Google.Apis.Util.RequestParameterAttribute("revisionId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string RevisionId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "files/{fileId}/revisions/{revisionId}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("fileId", new Google.Apis.Discovery.Parameter
                {
                    Name = "fileId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("revisionId", new Google.Apis.Discovery.Parameter
                {
                    Name = "revisionId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Gets a specific revision.</summary>
        /// <param name="fileId">The ID of the file.</param>
        /// <param name="revisionId">The ID of the revision.</param>
        public virtual GetRequest Get(string fileId, string revisionId)
        {
            return new GetRequest(this.service, fileId, revisionId);
        }

        /// <summary>Gets a specific revision.</summary>
        public class GetRequest : DriveBaseServiceRequest<Google.Apis.Drive.v2.Data.Revision>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string fileId, string revisionId) : base(service)
            {
                FileId = fileId;
                RevisionId = revisionId;
                InitParameters();
            }

            /// <summary>The ID of the file.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fileId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string FileId { get; private set; }

            /// <summary>The ID of the revision.</summary>
            [Google.Apis.Util.RequestParameterAttribute("revisionId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string RevisionId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "files/{fileId}/revisions/{revisionId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("fileId", new Google.Apis.Discovery.Parameter
                {
                    Name = "fileId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("revisionId", new Google.Apis.Discovery.Parameter
                {
                    Name = "revisionId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Lists a file's revisions.</summary>
        /// <param name="fileId">The ID of the file.</param>
        public virtual ListRequest List(string fileId)
        {
            return new ListRequest(this.service, fileId);
        }

        /// <summary>Lists a file's revisions.</summary>
        public class ListRequest : DriveBaseServiceRequest<Google.Apis.Drive.v2.Data.RevisionList>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string fileId) : base(service)
            {
                FileId = fileId;
                InitParameters();
            }

            /// <summary>The ID of the file.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fileId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string FileId { get; private set; }

            /// <summary>Maximum number of revisions to return.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>
            /// Page token for revisions. To get the next page of results, set this parameter to the value of
            /// "nextPageToken" from the previous response.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "files/{fileId}/revisions";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("fileId", new Google.Apis.Discovery.Parameter
                {
                    Name = "fileId",
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
                    DefaultValue = "200",
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

        /// <summary>Updates a revision.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="fileId">The ID for the file.</param>
        /// <param name="revisionId">The ID for the revision.</param>
        public virtual PatchRequest Patch(Google.Apis.Drive.v2.Data.Revision body, string fileId, string revisionId)
        {
            return new PatchRequest(this.service, body, fileId, revisionId);
        }

        /// <summary>Updates a revision.</summary>
        public class PatchRequest : DriveBaseServiceRequest<Google.Apis.Drive.v2.Data.Revision>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Drive.v2.Data.Revision body, string fileId, string revisionId) : base(service)
            {
                FileId = fileId;
                RevisionId = revisionId;
                Body = body;
                InitParameters();
            }

            /// <summary>The ID for the file.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fileId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string FileId { get; private set; }

            /// <summary>The ID for the revision.</summary>
            [Google.Apis.Util.RequestParameterAttribute("revisionId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string RevisionId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Drive.v2.Data.Revision Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "files/{fileId}/revisions/{revisionId}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("fileId", new Google.Apis.Discovery.Parameter
                {
                    Name = "fileId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("revisionId", new Google.Apis.Discovery.Parameter
                {
                    Name = "revisionId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates a revision.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="fileId">The ID for the file.</param>
        /// <param name="revisionId">The ID for the revision.</param>
        public virtual UpdateRequest Update(Google.Apis.Drive.v2.Data.Revision body, string fileId, string revisionId)
        {
            return new UpdateRequest(this.service, body, fileId, revisionId);
        }

        /// <summary>Updates a revision.</summary>
        public class UpdateRequest : DriveBaseServiceRequest<Google.Apis.Drive.v2.Data.Revision>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Drive.v2.Data.Revision body, string fileId, string revisionId) : base(service)
            {
                FileId = fileId;
                RevisionId = revisionId;
                Body = body;
                InitParameters();
            }

            /// <summary>The ID for the file.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fileId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string FileId { get; private set; }

            /// <summary>The ID for the revision.</summary>
            [Google.Apis.Util.RequestParameterAttribute("revisionId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string RevisionId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Drive.v2.Data.Revision Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "files/{fileId}/revisions/{revisionId}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("fileId", new Google.Apis.Discovery.Parameter
                {
                    Name = "fileId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("revisionId", new Google.Apis.Discovery.Parameter
                {
                    Name = "revisionId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "teamdrives" collection of methods.</summary>
    public class TeamdrivesResource
    {
        private const string Resource = "teamdrives";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public TeamdrivesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Deprecated: Use `drives.delete` instead.</summary>
        /// <param name="teamDriveId">The ID of the Team Drive</param>
        public virtual DeleteRequest Delete(string teamDriveId)
        {
            return new DeleteRequest(this.service, teamDriveId);
        }

        /// <summary>Deprecated: Use `drives.delete` instead.</summary>
        public class DeleteRequest : DriveBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string teamDriveId) : base(service)
            {
                TeamDriveId = teamDriveId;
                InitParameters();
            }

            /// <summary>The ID of the Team Drive</summary>
            [Google.Apis.Util.RequestParameterAttribute("teamDriveId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string TeamDriveId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "teamdrives/{teamDriveId}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("teamDriveId", new Google.Apis.Discovery.Parameter
                {
                    Name = "teamDriveId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Deprecated: Use `drives.get` instead.</summary>
        /// <param name="teamDriveId">The ID of the Team Drive</param>
        public virtual GetRequest Get(string teamDriveId)
        {
            return new GetRequest(this.service, teamDriveId);
        }

        /// <summary>Deprecated: Use `drives.get` instead.</summary>
        public class GetRequest : DriveBaseServiceRequest<Google.Apis.Drive.v2.Data.TeamDrive>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string teamDriveId) : base(service)
            {
                TeamDriveId = teamDriveId;
                InitParameters();
            }

            /// <summary>The ID of the Team Drive</summary>
            [Google.Apis.Util.RequestParameterAttribute("teamDriveId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string TeamDriveId { get; private set; }

            /// <summary>
            /// Issue the request as a domain administrator; if set to true, then the requester will be granted access
            /// if they are an administrator of the domain to which the Team Drive belongs.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("useDomainAdminAccess", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> UseDomainAdminAccess { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "teamdrives/{teamDriveId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("teamDriveId", new Google.Apis.Discovery.Parameter
                {
                    Name = "teamDriveId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("useDomainAdminAccess", new Google.Apis.Discovery.Parameter
                {
                    Name = "useDomainAdminAccess",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
            }
        }

        /// <summary>Deprecated: Use `drives.insert` instead.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="requestId">
        /// Required. An ID, such as a random UUID, which uniquely identifies this user's request for idempotent
        /// creation of a Team Drive. A repeated request by the same user and with the same request ID will avoid
        /// creating duplicates by attempting to create the same Team Drive. If the Team Drive already exists a 409
        /// error will be returned.
        /// </param>
        public virtual InsertRequest Insert(Google.Apis.Drive.v2.Data.TeamDrive body, string requestId)
        {
            return new InsertRequest(this.service, body, requestId);
        }

        /// <summary>Deprecated: Use `drives.insert` instead.</summary>
        public class InsertRequest : DriveBaseServiceRequest<Google.Apis.Drive.v2.Data.TeamDrive>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Drive.v2.Data.TeamDrive body, string requestId) : base(service)
            {
                RequestId = requestId;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. An ID, such as a random UUID, which uniquely identifies this user's request for idempotent
            /// creation of a Team Drive. A repeated request by the same user and with the same request ID will avoid
            /// creating duplicates by attempting to create the same Team Drive. If the Team Drive already exists a 409
            /// error will be returned.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string RequestId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Drive.v2.Data.TeamDrive Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "teamdrives";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                {
                    Name = "requestId",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Deprecated: Use `drives.list` instead.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>Deprecated: Use `drives.list` instead.</summary>
        public class ListRequest : DriveBaseServiceRequest<Google.Apis.Drive.v2.Data.TeamDriveList>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>Maximum number of Team Drives to return.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>Page token for Team Drives.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Query string for searching Team Drives.</summary>
            [Google.Apis.Util.RequestParameterAttribute("q", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Q { get; set; }

            /// <summary>
            /// Issue the request as a domain administrator; if set to true, then all Team Drives of the domain in which
            /// the requester is an administrator are returned.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("useDomainAdminAccess", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> UseDomainAdminAccess { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "teamdrives";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "10",
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
                RequestParameters.Add("q", new Google.Apis.Discovery.Parameter
                {
                    Name = "q",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("useDomainAdminAccess", new Google.Apis.Discovery.Parameter
                {
                    Name = "useDomainAdminAccess",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
            }
        }

        /// <summary>Deprecated: Use `drives.update` instead.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="teamDriveId">The ID of the Team Drive</param>
        public virtual UpdateRequest Update(Google.Apis.Drive.v2.Data.TeamDrive body, string teamDriveId)
        {
            return new UpdateRequest(this.service, body, teamDriveId);
        }

        /// <summary>Deprecated: Use `drives.update` instead.</summary>
        public class UpdateRequest : DriveBaseServiceRequest<Google.Apis.Drive.v2.Data.TeamDrive>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Drive.v2.Data.TeamDrive body, string teamDriveId) : base(service)
            {
                TeamDriveId = teamDriveId;
                Body = body;
                InitParameters();
            }

            /// <summary>The ID of the Team Drive</summary>
            [Google.Apis.Util.RequestParameterAttribute("teamDriveId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string TeamDriveId { get; private set; }

            /// <summary>
            /// Issue the request as a domain administrator; if set to true, then the requester will be granted access
            /// if they are an administrator of the domain to which the Team Drive belongs.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("useDomainAdminAccess", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> UseDomainAdminAccess { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Drive.v2.Data.TeamDrive Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "teamdrives/{teamDriveId}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("teamDriveId", new Google.Apis.Discovery.Parameter
                {
                    Name = "teamDriveId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("useDomainAdminAccess", new Google.Apis.Discovery.Parameter
                {
                    Name = "useDomainAdminAccess",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
            }
        }
    }
}
namespace Google.Apis.Drive.v2.Data
{
    /// <summary>An item with user information and settings.</summary>
    public class About : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Information about supported additional roles per file type. The most specific type takes precedence.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalRoleInfo")]
        public virtual System.Collections.Generic.IList<AdditionalRoleInfoData> AdditionalRoleInfo { get; set; }

        /// <summary>Whether the user can create shared drives.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canCreateDrives")]
        public virtual System.Nullable<bool> CanCreateDrives { get; set; }

        /// <summary>Deprecated: Use `canCreateDrives` instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canCreateTeamDrives")]
        public virtual System.Nullable<bool> CanCreateTeamDrives { get; set; }

        /// <summary>
        /// The domain sharing policy for the current user. Possible values are: * `allowed` * `allowedWithWarning` *
        /// `incomingOnly` * `disallowed`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domainSharingPolicy")]
        public virtual string DomainSharingPolicy { get; set; }

        /// <summary>A list of themes that are supported for shared drives.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("driveThemes")]
        public virtual System.Collections.Generic.IList<DriveThemesData> DriveThemes { get; set; }

        /// <summary>The ETag of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The allowable export formats.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exportFormats")]
        public virtual System.Collections.Generic.IList<ExportFormatsData> ExportFormats { get; set; }

        /// <summary>List of additional features enabled on this account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("features")]
        public virtual System.Collections.Generic.IList<FeaturesData> Features { get; set; }

        /// <summary>The palette of allowable folder colors as RGB hex strings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("folderColorPalette")]
        public virtual System.Collections.Generic.IList<string> FolderColorPalette { get; set; }

        /// <summary>The allowable import formats.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("importFormats")]
        public virtual System.Collections.Generic.IList<ImportFormatsData> ImportFormats { get; set; }

        /// <summary>
        /// A boolean indicating whether the authenticated app is installed by the authenticated user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isCurrentAppInstalled")]
        public virtual System.Nullable<bool> IsCurrentAppInstalled { get; set; }

        /// <summary>This is always `drive#about`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The user's language or locale code, as defined by BCP 47, with some extensions from Unicode's LDML format
        /// (http://www.unicode.org/reports/tr35/).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>The largest change id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("largestChangeId")]
        public virtual System.Nullable<long> LargestChangeId { get; set; }

        /// <summary>List of max upload sizes for each file type. The most specific type takes precedence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxUploadSizes")]
        public virtual System.Collections.Generic.IList<MaxUploadSizesData> MaxUploadSizes { get; set; }

        /// <summary>The name of the current user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The current user's ID as visible in the permissions collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissionId")]
        public virtual string PermissionId { get; set; }

        /// <summary>The amount of storage quota used by different Google services.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quotaBytesByService")]
        public virtual System.Collections.Generic.IList<QuotaBytesByServiceData> QuotaBytesByService { get; set; }

        /// <summary>The total number of quota bytes. This is only relevant when quotaType is LIMITED.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quotaBytesTotal")]
        public virtual System.Nullable<long> QuotaBytesTotal { get; set; }

        /// <summary>The number of quota bytes used by Google Drive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quotaBytesUsed")]
        public virtual System.Nullable<long> QuotaBytesUsed { get; set; }

        /// <summary>The number of quota bytes used by all Google apps (Drive, Picasa, etc.).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quotaBytesUsedAggregate")]
        public virtual System.Nullable<long> QuotaBytesUsedAggregate { get; set; }

        /// <summary>The number of quota bytes used by trashed items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quotaBytesUsedInTrash")]
        public virtual System.Nullable<long> QuotaBytesUsedInTrash { get; set; }

        /// <summary>The type of the user's storage quota. Possible values are: * `LIMITED` * `UNLIMITED`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quotaType")]
        public virtual string QuotaType { get; set; }

        /// <summary>The number of remaining change ids, limited to no more than 2500.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("remainingChangeIds")]
        public virtual System.Nullable<long> RemainingChangeIds { get; set; }

        /// <summary>The id of the root folder.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rootFolderId")]
        public virtual string RootFolderId { get; set; }

        /// <summary>A link back to this item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>Deprecated: Use `driveThemes` instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("teamDriveThemes")]
        public virtual System.Collections.Generic.IList<TeamDriveThemesData> TeamDriveThemes { get; set; }

        /// <summary>The authenticated user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("user")]
        public virtual User User { get; set; }

        /// <summary>
        /// Information about supported additional roles per file type. The most specific type takes precedence.
        /// </summary>
        public class AdditionalRoleInfoData
        {
            /// <summary>The supported additional roles per primary role.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("roleSets")]
            public virtual System.Collections.Generic.IList<RoleSetsData> RoleSets { get; set; }

            /// <summary>The content type that this additional role info applies to.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("type")]
            public virtual string Type { get; set; }

            /// <summary>The supported additional roles per primary role.</summary>
            public class RoleSetsData
            {
                /// <summary>The supported additional roles with the primary role.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("additionalRoles")]
                public virtual System.Collections.Generic.IList<string> AdditionalRoles { get; set; }

                /// <summary>A primary permission role.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("primaryRole")]
                public virtual string PrimaryRole { get; set; }
            }
        }

        /// <summary>A list of themes that are supported for shared drives.</summary>
        public class DriveThemesData
        {
            /// <summary>A link to this theme's background image.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("backgroundImageLink")]
            public virtual string BackgroundImageLink { get; set; }

            /// <summary>The color of this theme as an RGB hex string.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("colorRgb")]
            public virtual string ColorRgb { get; set; }

            /// <summary>The ID of the theme.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("id")]
            public virtual string Id { get; set; }
        }

        /// <summary>The allowable export formats.</summary>
        public class ExportFormatsData
        {
            /// <summary>The content type to convert from.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("source")]
            public virtual string Source { get; set; }

            /// <summary>The possible content types to convert to.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("targets")]
            public virtual System.Collections.Generic.IList<string> Targets { get; set; }
        }

        /// <summary>List of additional features enabled on this account.</summary>
        public class FeaturesData
        {
            /// <summary>The name of the feature.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("featureName")]
            public virtual string FeatureName { get; set; }

            /// <summary>The request limit rate for this feature, in queries per second.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("featureRate")]
            public virtual System.Nullable<double> FeatureRate { get; set; }
        }

        /// <summary>The allowable import formats.</summary>
        public class ImportFormatsData
        {
            /// <summary>The imported file's content type to convert from.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("source")]
            public virtual string Source { get; set; }

            /// <summary>The possible content types to convert to.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("targets")]
            public virtual System.Collections.Generic.IList<string> Targets { get; set; }
        }

        /// <summary>List of max upload sizes for each file type. The most specific type takes precedence.</summary>
        public class MaxUploadSizesData
        {
            /// <summary>The max upload size for this type.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("size")]
            public virtual System.Nullable<long> Size { get; set; }

            /// <summary>The file type.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("type")]
            public virtual string Type { get; set; }
        }

        /// <summary>The amount of storage quota used by different Google services.</summary>
        public class QuotaBytesByServiceData
        {
            /// <summary>The storage quota bytes used by the service.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("bytesUsed")]
            public virtual System.Nullable<long> BytesUsed { get; set; }

            /// <summary>The service's name, e.g. DRIVE, GMAIL, or PHOTOS.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("serviceName")]
            public virtual string ServiceName { get; set; }
        }

        /// <summary>Deprecated: Use `driveThemes` instead.</summary>
        public class TeamDriveThemesData
        {
            /// <summary>Deprecated: Use `driveThemes/backgroundImageLink` instead.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("backgroundImageLink")]
            public virtual string BackgroundImageLink { get; set; }

            /// <summary>Deprecated: Use `driveThemes/colorRgb` instead.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("colorRgb")]
            public virtual string ColorRgb { get; set; }

            /// <summary>Deprecated: Use `driveThemes/id` instead.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("id")]
            public virtual string Id { get; set; }
        }
    }

    /// <summary>
    /// The apps resource provides a list of the apps that a user has installed, with information about each app's
    /// supported MIME types, file extensions, and other details. Some resource methods (such as `apps.get`) require an
    /// `appId`. Use the `apps.list` method to retrieve the ID for an installed application.
    /// </summary>
    public class App : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether the app is authorized to access data on the user's Drive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authorized")]
        public virtual System.Nullable<bool> Authorized { get; set; }

        /// <summary>
        /// The template url to create a new file with this app in a given folder. The template will contain {folderId}
        /// to be replaced by the folder to create the new file in.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createInFolderTemplate")]
        public virtual string CreateInFolderTemplate { get; set; }

        /// <summary>The url to create a new file with this app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createUrl")]
        public virtual string CreateUrl { get; set; }

        /// <summary>
        /// Whether the app has drive-wide scope. An app with drive-wide scope can access all files in the user's drive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasDriveWideScope")]
        public virtual System.Nullable<bool> HasDriveWideScope { get; set; }

        /// <summary>The various icons for the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("icons")]
        public virtual System.Collections.Generic.IList<IconsData> Icons { get; set; }

        /// <summary>The ID of the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Whether the app is installed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("installed")]
        public virtual System.Nullable<bool> Installed { get; set; }

        /// <summary>This is always `drive#app`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>A long description of the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("longDescription")]
        public virtual string LongDescription { get; set; }

        /// <summary>The name of the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The type of object this app creates (e.g. Chart). If empty, the app name should be used instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectType")]
        public virtual string ObjectType { get; set; }

        /// <summary>
        /// The template url for opening files with this app. The template will contain `{ids}` and/or `{exportIds}` to
        /// be replaced by the actual file ids. See Open Files for the full documentation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("openUrlTemplate")]
        public virtual string OpenUrlTemplate { get; set; }

        /// <summary>The list of primary file extensions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryFileExtensions")]
        public virtual System.Collections.Generic.IList<string> PrimaryFileExtensions { get; set; }

        /// <summary>The list of primary mime types.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryMimeTypes")]
        public virtual System.Collections.Generic.IList<string> PrimaryMimeTypes { get; set; }

        /// <summary>The ID of the product listing for this app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productId")]
        public virtual string ProductId { get; set; }

        /// <summary>A link to the product listing for this app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productUrl")]
        public virtual string ProductUrl { get; set; }

        /// <summary>The list of secondary file extensions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secondaryFileExtensions")]
        public virtual System.Collections.Generic.IList<string> SecondaryFileExtensions { get; set; }

        /// <summary>The list of secondary mime types.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secondaryMimeTypes")]
        public virtual System.Collections.Generic.IList<string> SecondaryMimeTypes { get; set; }

        /// <summary>A short description of the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shortDescription")]
        public virtual string ShortDescription { get; set; }

        /// <summary>Whether this app supports creating new objects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportsCreate")]
        public virtual System.Nullable<bool> SupportsCreate { get; set; }

        /// <summary>Whether this app supports importing from Docs Editors.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportsImport")]
        public virtual System.Nullable<bool> SupportsImport { get; set; }

        /// <summary>Whether this app supports opening more than one file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportsMultiOpen")]
        public virtual System.Nullable<bool> SupportsMultiOpen { get; set; }

        /// <summary>Whether this app supports creating new files when offline.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportsOfflineCreate")]
        public virtual System.Nullable<bool> SupportsOfflineCreate { get; set; }

        /// <summary>Whether the app is selected as the default handler for the types it supports.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useByDefault")]
        public virtual System.Nullable<bool> UseByDefault { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>The various icons for the app.</summary>
        public class IconsData
        {
            /// <summary>
            /// Category of the icon. Allowed values are: * `application` - icon for the application * `document` - icon
            /// for a file associated with the app * `documentShared` - icon for a shared file associated with the app
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("category")]
            public virtual string Category { get; set; }

            /// <summary>URL for the icon.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("iconUrl")]
            public virtual string IconUrl { get; set; }

            /// <summary>Size of the icon. Represented as the maximum of the width and height.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("size")]
            public virtual System.Nullable<int> Size { get; set; }
        }
    }

    /// <summary>
    /// A list of third-party applications which the user has installed or given access to Google Drive.
    /// </summary>
    public class AppList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// List of app IDs that the user has specified to use by default. The list is in reverse-priority order (lowest
        /// to highest).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultAppIds")]
        public virtual System.Collections.Generic.IList<string> DefaultAppIds { get; set; }

        /// <summary>The ETag of the list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The list of apps.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<App> Items { get; set; }

        /// <summary>This is always `drive#appList`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>A link back to this list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }
    }

    /// <summary>Representation of a change to a file or shared drive.</summary>
    public class Change : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of the change. Possible values are `file` and `drive`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("changeType")]
        public virtual string ChangeType { get; set; }

        /// <summary>
        /// Whether the file or shared drive has been removed from this list of changes, for example by deletion or loss
        /// of access.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleted")]
        public virtual System.Nullable<bool> Deleted { get; set; }

        /// <summary>
        /// The updated state of the shared drive. Present if the changeType is drive, the user is still a member of the
        /// shared drive, and the shared drive has not been deleted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("drive")]
        public virtual Drive Drive { get; set; }

        /// <summary>The ID of the shared drive associated with this change.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("driveId")]
        public virtual string DriveId { get; set; }

        /// <summary>
        /// The updated state of the file. Present if the type is file and the file has not been removed from this list
        /// of changes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("file")]
        public virtual File File { get; set; }

        /// <summary>The ID of the file associated with this change.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileId")]
        public virtual string FileId { get; set; }

        /// <summary>The ID of the change.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<long> Id { get; set; }

        /// <summary>This is always `drive#change`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The time of this modification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modificationDate")]
        public virtual string ModificationDateRaw { get; set; }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="ModificationDateRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ModificationDateDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(ModificationDateRaw);
            set => ModificationDateRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="ModificationDateRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ModificationDateDateTimeOffset instead.")]
        public virtual System.DateTime? ModificationDate
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(ModificationDateRaw);
            set => ModificationDateRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>A link back to this change.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>Deprecated: Use `drive` instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("teamDrive")]
        public virtual TeamDrive TeamDrive { get; set; }

        /// <summary>Deprecated: Use `driveId` instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("teamDriveId")]
        public virtual string TeamDriveId { get; set; }

        /// <summary>Deprecated: Use `changeType` instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A list of changes for a user.</summary>
    public class ChangeList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// The list of changes. If nextPageToken is populated, then this list may be incomplete and an additional page
        /// of results should be fetched.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Change> Items { get; set; }

        /// <summary>This is always `drive#changeList`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The current largest change ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("largestChangeId")]
        public virtual System.Nullable<long> LargestChangeId { get; set; }

        /// <summary>
        /// The starting page token for future changes. This will be present only if the end of the current changes list
        /// has been reached.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newStartPageToken")]
        public virtual string NewStartPageToken { get; set; }

        /// <summary>A link to the next page of changes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextLink")]
        public virtual string NextLink { get; set; }

        /// <summary>
        /// The page token for the next page of changes. This will be absent if the end of the changes list has been
        /// reached. If the token is rejected for any reason, it should be discarded, and pagination should be restarted
        /// from the first page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A link back to this list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }
    }

    /// <summary>A notification channel used to watch for resource changes.</summary>
    public class Channel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The address where notifications are delivered for this channel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("address")]
        public virtual string Address { get; set; }

        /// <summary>
        /// Date and time of notification channel expiration, expressed as a Unix timestamp, in milliseconds. Optional.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expiration")]
        public virtual System.Nullable<long> Expiration { get; set; }

        /// <summary>A UUID or similar unique string that identifies this channel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Identifies this as a notification channel used to watch for changes to a resource, which is `api#channel`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Additional parameters controlling delivery channel behavior. Optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("params")]
        public virtual System.Collections.Generic.IDictionary<string, string> Params__ { get; set; }

        /// <summary>A Boolean value to indicate whether payload is wanted. Optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("payload")]
        public virtual System.Nullable<bool> Payload { get; set; }

        /// <summary>
        /// An opaque ID that identifies the resource being watched on this channel. Stable across different API
        /// versions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceId")]
        public virtual string ResourceId { get; set; }

        /// <summary>A version-specific identifier for the watched resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceUri")]
        public virtual string ResourceUri { get; set; }

        /// <summary>
        /// An arbitrary string delivered to the target address with each notification delivered over this channel.
        /// Optional.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("token")]
        public virtual string Token { get; set; }

        /// <summary>
        /// The type of delivery mechanism used for this channel. Valid values are "web_hook" or "webhook".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A list of children of a file.</summary>
    public class ChildList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// The list of children. If nextPageToken is populated, then this list may be incomplete and an additional page
        /// of results should be fetched.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<ChildReference> Items { get; set; }

        /// <summary>This is always `drive#childList`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>A link to the next page of children.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextLink")]
        public virtual string NextLink { get; set; }

        /// <summary>
        /// The page token for the next page of children. This will be absent if the end of the children list has been
        /// reached. If the token is rejected for any reason, it should be discarded, and pagination should be restarted
        /// from the first page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A link back to this list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }
    }

    /// <summary>
    /// A reference to a folder's child. Some resource methods (such as `children.get`) require a `childId`. Use the
    /// `children.list` method to retrieve the ID of the child.
    /// </summary>
    public class ChildReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. A link to the child.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("childLink")]
        public virtual string ChildLink { get; set; }

        /// <summary>The ID of the child.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Output only. This is always `drive#childReference`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Output only. A link back to this reference.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A comment on a file in Google Drive. Some resource methods (such as `comments.update`) require a `commentId`.
    /// Use the `comments.list` method to retrieve the ID for a comment in a file.
    /// </summary>
    public class Comment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A region of the document represented as a JSON string. For details on defining anchor properties, refer to
        /// [Add comments and replies](https://developers.google.com/workspace/drive/api/v2/manage-comments).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("anchor")]
        public virtual string Anchor { get; set; }

        /// <summary>
        /// Output only. The author of the comment. The author's email address and permission ID will not be populated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("author")]
        public virtual User Author { get; set; }

        /// <summary>Output only. The ID of the comment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commentId")]
        public virtual string CommentId { get; set; }

        /// <summary>
        /// The plain text content used to create this comment. This is not HTML safe and should only be used as a
        /// starting point to make edits to a comment's content.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>The context of the file which is being commented on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("context")]
        public virtual ContextData Context { get; set; }

        /// <summary>The date when this comment was first created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createdDate")]
        public virtual string CreatedDateRaw { get; set; }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CreatedDateRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreatedDateDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(CreatedDateRaw);
            set => CreatedDateRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="CreatedDateRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreatedDateDateTimeOffset instead.")]
        public virtual System.DateTime? CreatedDate
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(CreatedDateRaw);
            set => CreatedDateRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>
        /// Output only. Whether this comment has been deleted. If a comment has been deleted the content will be
        /// cleared and this will only represent a comment that once existed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleted")]
        public virtual System.Nullable<bool> Deleted { get; set; }

        /// <summary>Output only. The file which this comment is addressing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileId")]
        public virtual string FileId { get; set; }

        /// <summary>Output only. The title of the file which this comment is addressing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileTitle")]
        public virtual string FileTitle { get; set; }

        /// <summary>Output only. HTML formatted content for this comment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("htmlContent")]
        public virtual string HtmlContent { get; set; }

        /// <summary>Output only. This is always `drive#comment`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The date when this comment or any of its replies were last modified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modifiedDate")]
        public virtual string ModifiedDateRaw { get; set; }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ModifiedDateRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ModifiedDateDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(ModifiedDateRaw);
            set => ModifiedDateRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="ModifiedDateRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ModifiedDateDateTimeOffset instead.")]
        public virtual System.DateTime? ModifiedDate
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(ModifiedDateRaw);
            set => ModifiedDateRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>Output only. Replies to this post.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replies")]
        public virtual System.Collections.Generic.IList<CommentReply> Replies { get; set; }

        /// <summary>Output only. A link back to this comment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>
        /// Output only. The status of this comment. Status can be changed by posting a reply to a comment with the
        /// desired status. * `open` - The comment is still open. * `resolved` - The comment has been resolved by one of
        /// its replies.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>The context of the file which is being commented on.</summary>
        public class ContextData
        {
            /// <summary>The MIME type of the context snippet.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("type")]
            public virtual string Type { get; set; }

            /// <summary>
            /// Data representation of the segment of the file being commented on. In the case of a text file for
            /// example, this would be the actual text that the comment is about.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("value")]
            public virtual string Value { get; set; }
        }
    }

    /// <summary>A list of comments on a file in Google Drive.</summary>
    public class CommentList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The list of comments. If nextPageToken is populated, then this list may be incomplete and an additional page
        /// of results should be fetched.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Comment> Items { get; set; }

        /// <summary>This is always `drive#commentList`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>A link to the next page of comments.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextLink")]
        public virtual string NextLink { get; set; }

        /// <summary>
        /// The page token for the next page of comments. This will be absent if the end of the comments list has been
        /// reached. If the token is rejected for any reason, it should be discarded, and pagination should be restarted
        /// from the first page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A link back to this list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A comment on a file in Google Drive. Some resource methods (such as `replies.update`) require a `replyId`. Use
    /// the `replies.list` method to retrieve the ID for a reply.
    /// </summary>
    public class CommentReply : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The author of the reply. The author's email address and permission ID will not be populated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("author")]
        public virtual User Author { get; set; }

        /// <summary>
        /// The plain text content used to create this reply. This is not HTML safe and should only be used as a
        /// starting point to make edits to a reply's content. This field is required on inserts if no verb is specified
        /// (resolve/reopen).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>The date when this reply was first created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createdDate")]
        public virtual string CreatedDateRaw { get; set; }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CreatedDateRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreatedDateDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(CreatedDateRaw);
            set => CreatedDateRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="CreatedDateRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreatedDateDateTimeOffset instead.")]
        public virtual System.DateTime? CreatedDate
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(CreatedDateRaw);
            set => CreatedDateRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>
        /// Output only. Whether this reply has been deleted. If a reply has been deleted the content will be cleared
        /// and this will only represent a reply that once existed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleted")]
        public virtual System.Nullable<bool> Deleted { get; set; }

        /// <summary>Output only. HTML formatted content for this reply.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("htmlContent")]
        public virtual string HtmlContent { get; set; }

        /// <summary>Output only. This is always `drive#commentReply`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The date when this reply was last modified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modifiedDate")]
        public virtual string ModifiedDateRaw { get; set; }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ModifiedDateRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ModifiedDateDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(ModifiedDateRaw);
            set => ModifiedDateRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="ModifiedDateRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ModifiedDateDateTimeOffset instead.")]
        public virtual System.DateTime? ModifiedDate
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(ModifiedDateRaw);
            set => ModifiedDateRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>Output only. The ID of the reply.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replyId")]
        public virtual string ReplyId { get; set; }

        /// <summary>
        /// The action this reply performed to the parent comment. When creating a new reply this is the action to be
        /// perform to the parent comment. Possible values are: * `resolve` - To resolve a comment. * `reopen` - To
        /// reopen (un-resolve) a comment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verb")]
        public virtual string Verb { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A list of replies to a comment on a file in Google Drive.</summary>
    public class CommentReplyList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The list of replies. If nextPageToken is populated, then this list may be incomplete and an additional page
        /// of results should be fetched.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<CommentReply> Items { get; set; }

        /// <summary>This is always `drive#commentReplyList`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>A link to the next page of replies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextLink")]
        public virtual string NextLink { get; set; }

        /// <summary>
        /// The page token for the next page of replies. This will be absent if the end of the replies list has been
        /// reached. If the token is rejected for any reason, it should be discarded, and pagination should be restarted
        /// from the first page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A link back to this list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A restriction for accessing the content of the file.</summary>
    public class ContentRestriction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether the content restriction can only be modified or removed by a user who owns the file. For files in
        /// shared drives, any user with `organizer` capabilities can modify or remove this content restriction.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ownerRestricted")]
        public virtual System.Nullable<bool> OwnerRestricted { get; set; }

        /// <summary>
        /// Whether the content of the file is read-only. If a file is read-only, a new revision of the file may not be
        /// added, comments may not be added or modified, and the title of the file may not be modified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readOnly")]
        public virtual System.Nullable<bool> ReadOnly__ { get; set; }

        /// <summary>
        /// Reason for why the content of the file is restricted. This is only mutable on requests that also set
        /// `readOnly=true`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>
        /// Output only. The user who set the content restriction. Only populated if `readOnly` is true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restrictingUser")]
        public virtual User RestrictingUser { get; set; }

        /// <summary>
        /// The time at which the content restriction was set (formatted RFC 3339 timestamp). Only populated if readOnly
        /// is true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restrictionDate")]
        public virtual string RestrictionDateRaw { get; set; }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="RestrictionDateRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? RestrictionDateDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(RestrictionDateRaw);
            set => RestrictionDateRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="RestrictionDateRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use RestrictionDateDateTimeOffset instead.")]
        public virtual System.DateTime? RestrictionDate
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(RestrictionDateRaw);
            set => RestrictionDateRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>
        /// Output only. Whether the content restriction was applied by the system, for example due to an esignature.
        /// Users cannot modify or remove system restricted content restrictions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("systemRestricted")]
        public virtual System.Nullable<bool> SystemRestricted { get; set; }

        /// <summary>
        /// Output only. The type of the content restriction. Currently the only possible value is
        /// `globalContentRestriction`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Representation of a shared drive. Some resource methods (such as `drives.update`) require a `driveId`. Use the
    /// `drives.list` method to retrieve the ID for a shared drive.
    /// </summary>
    public class Drive : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An image file and cropping parameters from which a background image for this shared drive is set. This is a
        /// write only field; it can only be set on `drive.drives.update` requests that don't set `themeId`. When
        /// specified, all fields of the `backgroundImageFile` must be set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backgroundImageFile")]
        public virtual BackgroundImageFileData BackgroundImageFile { get; set; }

        /// <summary>Output only. A short-lived link to this shared drive's background image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backgroundImageLink")]
        public virtual string BackgroundImageLink { get; set; }

        /// <summary>Output only. Capabilities the current user has on this shared drive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("capabilities")]
        public virtual CapabilitiesData Capabilities { get; set; }

        /// <summary>
        /// The color of this shared drive as an RGB hex string. It can only be set on a `drive.drives.update` request
        /// that does not set `themeId`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("colorRgb")]
        public virtual string ColorRgb { get; set; }

        /// <summary>The time at which the shared drive was created (RFC 3339 date-time).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createdDate")]
        public virtual string CreatedDateRaw { get; set; }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CreatedDateRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreatedDateDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(CreatedDateRaw);
            set => CreatedDateRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="CreatedDateRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreatedDateDateTimeOffset instead.")]
        public virtual System.DateTime? CreatedDate
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(CreatedDateRaw);
            set => CreatedDateRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>Whether the shared drive is hidden from default view.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hidden")]
        public virtual System.Nullable<bool> Hidden { get; set; }

        /// <summary>
        /// Output only. The ID of this shared drive which is also the ID of the top level folder of this shared drive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Output only. This is always `drive#drive`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The name of this shared drive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The organizational unit of this shared drive. This field is only populated on `drives.list`
        /// responses when the `useDomainAdminAccess` parameter is set to `true`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orgUnitId")]
        public virtual string OrgUnitId { get; set; }

        /// <summary>A set of restrictions that apply to this shared drive or items inside this shared drive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restrictions")]
        public virtual RestrictionsData Restrictions { get; set; }

        /// <summary>
        /// The ID of the theme from which the background image and color will be set. The set of possible `driveThemes`
        /// can be retrieved from a `drive.about.get` response. When not specified on a `drive.drives.insert` request, a
        /// random theme is chosen from which the background image and color are set. This is a write-only field; it can
        /// only be set on requests that don't set `colorRgb` or `backgroundImageFile`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("themeId")]
        public virtual string ThemeId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>
        /// An image file and cropping parameters from which a background image for this shared drive is set. This is a
        /// write only field; it can only be set on `drive.drives.update` requests that don't set `themeId`. When
        /// specified, all fields of the `backgroundImageFile` must be set.
        /// </summary>
        public class BackgroundImageFileData
        {
            /// <summary>The ID of an image file in Google Drive to use for the background image.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("id")]
            public virtual string Id { get; set; }

            /// <summary>
            /// The width of the cropped image in the closed range of 0 to 1. This value represents the width of the
            /// cropped image divided by the width of the entire image. The height is computed by applying a width to
            /// height aspect ratio of 80 to 9. The resulting image must be at least 1280 pixels wide and 144 pixels
            /// high.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("width")]
            public virtual System.Nullable<float> Width { get; set; }

            /// <summary>
            /// The X coordinate of the upper left corner of the cropping area in the background image. This is a value
            /// in the closed range of 0 to 1. This value represents the horizontal distance from the left side of the
            /// entire image to the left side of the cropping area divided by the width of the entire image.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("xCoordinate")]
            public virtual System.Nullable<float> XCoordinate { get; set; }

            /// <summary>
            /// The Y coordinate of the upper left corner of the cropping area in the background image. This is a value
            /// in the closed range of 0 to 1. This value represents the vertical distance from the top side of the
            /// entire image to the top side of the cropping area divided by the height of the entire image.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("yCoordinate")]
            public virtual System.Nullable<float> YCoordinate { get; set; }
        }

        /// <summary>Output only. Capabilities the current user has on this shared drive.</summary>
        public class CapabilitiesData
        {
            /// <summary>
            /// Output only. Whether the current user can add children to folders in this shared drive.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canAddChildren")]
            public virtual System.Nullable<bool> CanAddChildren { get; set; }

            /// <summary>
            /// Output only. Whether the current user can change the `copyRequiresWriterPermission` restriction of this
            /// shared drive.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canChangeCopyRequiresWriterPermissionRestriction")]
            public virtual System.Nullable<bool> CanChangeCopyRequiresWriterPermissionRestriction { get; set; }

            /// <summary>
            /// Output only. Whether the current user can change the `domainUsersOnly` restriction of this shared drive.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canChangeDomainUsersOnlyRestriction")]
            public virtual System.Nullable<bool> CanChangeDomainUsersOnlyRestriction { get; set; }

            /// <summary>Output only. Whether the current user can change the background of this shared drive.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canChangeDriveBackground")]
            public virtual System.Nullable<bool> CanChangeDriveBackground { get; set; }

            /// <summary>
            /// Output only. Whether the current user can change the `driveMembersOnly` restriction of this shared
            /// drive.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canChangeDriveMembersOnlyRestriction")]
            public virtual System.Nullable<bool> CanChangeDriveMembersOnlyRestriction { get; set; }

            /// <summary>
            /// Output only. Whether the current user can change the `sharingFoldersRequiresOrganizerPermission`
            /// restriction of this shared drive.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canChangeSharingFoldersRequiresOrganizerPermissionRestriction")]
            public virtual System.Nullable<bool> CanChangeSharingFoldersRequiresOrganizerPermissionRestriction { get; set; }

            /// <summary>Output only. Whether the current user can comment on files in this shared drive.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canComment")]
            public virtual System.Nullable<bool> CanComment { get; set; }

            /// <summary>Output only. Whether the current user can copy files in this shared drive.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canCopy")]
            public virtual System.Nullable<bool> CanCopy { get; set; }

            /// <summary>
            /// Output only. Whether the current user can delete children from folders in this shared drive.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canDeleteChildren")]
            public virtual System.Nullable<bool> CanDeleteChildren { get; set; }

            /// <summary>
            /// Output only. Whether the current user can delete this shared drive. Attempting to delete the shared
            /// drive may still fail if there are untrashed items inside the shared drive.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canDeleteDrive")]
            public virtual System.Nullable<bool> CanDeleteDrive { get; set; }

            /// <summary>Output only. Whether the current user can download files in this shared drive.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canDownload")]
            public virtual System.Nullable<bool> CanDownload { get; set; }

            /// <summary>Output only. Whether the current user can edit files in this shared drive</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canEdit")]
            public virtual System.Nullable<bool> CanEdit { get; set; }

            /// <summary>
            /// Output only. Whether the current user can list the children of folders in this shared drive.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canListChildren")]
            public virtual System.Nullable<bool> CanListChildren { get; set; }

            /// <summary>
            /// Output only. Whether the current user can add members to this shared drive or remove them or change
            /// their role.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canManageMembers")]
            public virtual System.Nullable<bool> CanManageMembers { get; set; }

            /// <summary>
            /// Output only. Whether the current user can read the revisions resource of files in this shared drive.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canReadRevisions")]
            public virtual System.Nullable<bool> CanReadRevisions { get; set; }

            /// <summary>
            /// Output only. Whether the current user can rename files or folders in this shared drive.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canRename")]
            public virtual System.Nullable<bool> CanRename { get; set; }

            /// <summary>Output only. Whether the current user can rename this shared drive.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canRenameDrive")]
            public virtual System.Nullable<bool> CanRenameDrive { get; set; }

            /// <summary>
            /// Output only. Whether the current user can reset the shared drive restrictions to defaults.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canResetDriveRestrictions")]
            public virtual System.Nullable<bool> CanResetDriveRestrictions { get; set; }

            /// <summary>
            /// Output only. Whether the current user can share files or folders in this shared drive.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canShare")]
            public virtual System.Nullable<bool> CanShare { get; set; }

            /// <summary>
            /// Output only. Whether the current user can trash children from folders in this shared drive.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canTrashChildren")]
            public virtual System.Nullable<bool> CanTrashChildren { get; set; }
        }

        /// <summary>A set of restrictions that apply to this shared drive or items inside this shared drive.</summary>
        public class RestrictionsData
        {
            /// <summary>
            /// Whether administrative privileges on this shared drive are required to modify restrictions.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("adminManagedRestrictions")]
            public virtual System.Nullable<bool> AdminManagedRestrictions { get; set; }

            /// <summary>
            /// Whether the options to copy, print, or download files inside this shared drive, should be disabled for
            /// readers and commenters. When this restriction is set to `true`, it will override the similarly named
            /// field to `true` for any file inside this shared drive.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("copyRequiresWriterPermission")]
            public virtual System.Nullable<bool> CopyRequiresWriterPermission { get; set; }

            /// <summary>
            /// Whether access to this shared drive and items inside this shared drive is restricted to users of the
            /// domain to which this shared drive belongs. This restriction may be overridden by other sharing policies
            /// controlled outside of this shared drive.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("domainUsersOnly")]
            public virtual System.Nullable<bool> DomainUsersOnly { get; set; }

            /// <summary>Whether access to items inside this shared drive is restricted to its members.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("driveMembersOnly")]
            public virtual System.Nullable<bool> DriveMembersOnly { get; set; }

            /// <summary>
            /// If true, only users with the organizer role can share folders. If false, users with either the organizer
            /// role or the file organizer role can share folders.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("sharingFoldersRequiresOrganizerPermission")]
            public virtual System.Nullable<bool> SharingFoldersRequiresOrganizerPermission { get; set; }
        }
    }

    /// <summary>A list of shared drives.</summary>
    public class DriveList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The list of shared drives. If nextPageToken is populated, then this list may be incomplete and an additional
        /// page of results should be fetched.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Drive> Items { get; set; }

        /// <summary>This is always `drive#driveList`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The page token for the next page of shared drives. This will be absent if the end of the list has been
        /// reached. If the token is rejected for any reason, it should be discarded, and pagination should be restarted
        /// from the first page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The metadata for a file. Some resource methods (such as `files.update`) require a `fileId`. Use the `files.list`
    /// method to retrieve the ID for a file.
    /// </summary>
    public class File : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. A link for opening the file in a relevant Google editor or viewer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alternateLink")]
        public virtual string AlternateLink { get; set; }

        /// <summary>Output only. Whether this file is in the Application Data folder.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appDataContents")]
        public virtual System.Nullable<bool> AppDataContents { get; set; }

        /// <summary>Output only. Deprecated: Use `capabilities/canComment` instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canComment")]
        public virtual System.Nullable<bool> CanComment { get; set; }

        /// <summary>Output only. Deprecated: Use `capabilities/canReadRevisions` instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canReadRevisions")]
        public virtual System.Nullable<bool> CanReadRevisions { get; set; }

        /// <summary>
        /// Output only. Capabilities the current user has on this file. Each capability corresponds to a fine-grained
        /// action that a user may take.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("capabilities")]
        public virtual CapabilitiesData Capabilities { get; set; }

        /// <summary>
        /// Restrictions for accessing the content of the file. Only populated if such a restriction exists.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentRestrictions")]
        public virtual System.Collections.Generic.IList<ContentRestriction> ContentRestrictions { get; set; }

        /// <summary>
        /// Whether the options to copy, print, or download this file, should be disabled for readers and commenters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("copyRequiresWriterPermission")]
        public virtual System.Nullable<bool> CopyRequiresWriterPermission { get; set; }

        /// <summary>Output only. Deprecated: Use `capabilities/canCopy` instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("copyable")]
        public virtual System.Nullable<bool> Copyable { get; set; }

        /// <summary>Create time for this file (formatted RFC 3339 timestamp).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createdDate")]
        public virtual string CreatedDateRaw { get; set; }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CreatedDateRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreatedDateDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(CreatedDateRaw);
            set => CreatedDateRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="CreatedDateRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreatedDateDateTimeOffset instead.")]
        public virtual System.DateTime? CreatedDate
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(CreatedDateRaw);
            set => CreatedDateRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>
        /// Output only. A link to open this file with the user's default app for this file. Only populated when the
        /// drive.apps.readonly scope is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultOpenWithLink")]
        public virtual string DefaultOpenWithLink { get; set; }

        /// <summary>A short description of the file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Output only. Short lived download URL for the file. This field is only populated for files with content
        /// stored in Google Drive; it is not populated for Google Docs or shortcut files.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("downloadUrl")]
        public virtual string DownloadUrl { get; set; }

        /// <summary>
        /// Output only. ID of the shared drive the file resides in. Only populated for items in shared drives.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("driveId")]
        public virtual string DriveId { get; set; }

        /// <summary>Output only. Deprecated: Use `capabilities/canEdit` instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("editable")]
        public virtual System.Nullable<bool> Editable { get; set; }

        /// <summary>Output only. A link for embedding the file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("embedLink")]
        public virtual string EmbedLink { get; set; }

        /// <summary>Output only. ETag of the file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Output only. Whether this file has been explicitly trashed, as opposed to recursively trashed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("explicitlyTrashed")]
        public virtual System.Nullable<bool> ExplicitlyTrashed { get; set; }

        /// <summary>Output only. Links for exporting Docs Editors files to specific formats.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exportLinks")]
        public virtual System.Collections.Generic.IDictionary<string, string> ExportLinks { get; set; }

        /// <summary>
        /// Output only. The final component of `fullFileExtension` with trailing text that does not appear to be part
        /// of the extension removed. This field is only populated for files with content stored in Google Drive; it is
        /// not populated for Docs Editors or shortcut files.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileExtension")]
        public virtual string FileExtension { get; set; }

        /// <summary>
        /// Output only. Size in bytes of blobs and first party editor files. Won't be populated for files that have no
        /// size, like shortcuts and folders.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileSize")]
        public virtual System.Nullable<long> FileSize { get; set; }

        /// <summary>
        /// Folder color as an RGB hex string if the file is a folder or a shortcut to a folder. The list of supported
        /// colors is available in the folderColorPalette field of the About resource. If an unsupported color is
        /// specified, it will be changed to the closest color in the palette.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("folderColorRgb")]
        public virtual string FolderColorRgb { get; set; }

        /// <summary>
        /// Output only. The full file extension; extracted from the title. May contain multiple concatenated
        /// extensions, such as "tar.gz". Removing an extension from the title does not clear this field; however,
        /// changing the extension on the title does update this field. This field is only populated for files with
        /// content stored in Google Drive; it is not populated for Docs Editors or shortcut files.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullFileExtension")]
        public virtual string FullFileExtension { get; set; }

        /// <summary>
        /// Output only. Whether there are permissions directly on this file. This field is only populated for items in
        /// shared drives.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasAugmentedPermissions")]
        public virtual System.Nullable<bool> HasAugmentedPermissions { get; set; }

        /// <summary>
        /// Output only. Whether this file has a thumbnail. This does not indicate whether the requesting app has access
        /// to the thumbnail. To check access, look for the presence of the thumbnailLink field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasThumbnail")]
        public virtual System.Nullable<bool> HasThumbnail { get; set; }

        /// <summary>
        /// Output only. The ID of the file's head revision. This field is only populated for files with content stored
        /// in Google Drive; it is not populated for Docs Editors or shortcut files.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headRevisionId")]
        public virtual string HeadRevisionId { get; set; }

        /// <summary>Output only. A link to the file's icon.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iconLink")]
        public virtual string IconLink { get; set; }

        /// <summary>The ID of the file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Output only. Metadata about image media. This will only be present for image types, and its contents will
        /// depend on what can be parsed from the image content.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageMediaMetadata")]
        public virtual ImageMediaMetadataData ImageMediaMetadata { get; set; }

        /// <summary>Indexable text attributes for the file (can only be written)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indexableText")]
        public virtual IndexableTextData IndexableText { get; set; }

        /// <summary>
        /// Whether this file has inherited permissions disabled. Inherited permissions are enabled by default.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inheritedPermissionsDisabled")]
        public virtual System.Nullable<bool> InheritedPermissionsDisabled { get; set; }

        /// <summary>Output only. Whether the file was created or opened by the requesting app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isAppAuthorized")]
        public virtual System.Nullable<bool> IsAppAuthorized { get; set; }

        /// <summary>Output only. The type of file. This is always `drive#file`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Output only. An overview of the labels on the file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelInfo")]
        public virtual LabelInfoData LabelInfo { get; set; }

        /// <summary>A group of labels for the file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual LabelsData Labels { get; set; }

        /// <summary>
        /// Output only. The last user to modify this file. This field is only populated when the last modification was
        /// performed by a signed-in user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastModifyingUser")]
        public virtual User LastModifyingUser { get; set; }

        /// <summary>Output only. Name of the last user to modify this file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastModifyingUserName")]
        public virtual string LastModifyingUserName { get; set; }

        /// <summary>Last time this file was viewed by the user (formatted RFC 3339 timestamp).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastViewedByMeDate")]
        public virtual string LastViewedByMeDateRaw { get; set; }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="LastViewedByMeDateRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LastViewedByMeDateDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(LastViewedByMeDateRaw);
            set => LastViewedByMeDateRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="LastViewedByMeDateRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LastViewedByMeDateDateTimeOffset instead.")]
        public virtual System.DateTime? LastViewedByMeDate
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(LastViewedByMeDateRaw);
            set => LastViewedByMeDateRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>Contains details about the link URLs that clients are using to refer to this item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkShareMetadata")]
        public virtual LinkShareMetadataData LinkShareMetadata { get; set; }

        /// <summary>Deprecated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("markedViewedByMeDate")]
        public virtual string MarkedViewedByMeDateRaw { get; set; }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="MarkedViewedByMeDateRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? MarkedViewedByMeDateDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(MarkedViewedByMeDateRaw);
            set => MarkedViewedByMeDateRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary>
        /// <seealso cref="System.DateTime"/> representation of <see cref="MarkedViewedByMeDateRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use MarkedViewedByMeDateDateTimeOffset instead.")]
        public virtual System.DateTime? MarkedViewedByMeDate
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(MarkedViewedByMeDateRaw);
            set => MarkedViewedByMeDateRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>
        /// Output only. An MD5 checksum for the content of this file. This field is only populated for files with
        /// content stored in Google Drive; it is not populated for Docs Editors or shortcut files.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("md5Checksum")]
        public virtual string Md5Checksum { get; set; }

        /// <summary>
        /// The MIME type of the file. This is only mutable on update when uploading new content. This field can be left
        /// blank, and the mimetype will be determined from the uploaded content's MIME type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>
        /// Last time this file was modified by the user (formatted RFC 3339 timestamp). Note that setting modifiedDate
        /// will also update the modifiedByMe date for the user which set the date.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modifiedByMeDate")]
        public virtual string ModifiedByMeDateRaw { get; set; }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="ModifiedByMeDateRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ModifiedByMeDateDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(ModifiedByMeDateRaw);
            set => ModifiedByMeDateRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="ModifiedByMeDateRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ModifiedByMeDateDateTimeOffset instead.")]
        public virtual System.DateTime? ModifiedByMeDate
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(ModifiedByMeDateRaw);
            set => ModifiedByMeDateRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>
        /// Last time this file was modified by anyone (formatted RFC 3339 timestamp). This is only mutable on update
        /// when the setModifiedDate parameter is set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modifiedDate")]
        public virtual string ModifiedDateRaw { get; set; }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ModifiedDateRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ModifiedDateDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(ModifiedDateRaw);
            set => ModifiedDateRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="ModifiedDateRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ModifiedDateDateTimeOffset instead.")]
        public virtual System.DateTime? ModifiedDate
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(ModifiedDateRaw);
            set => ModifiedDateRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>
        /// Output only. A map of the id of each of the user's apps to a link to open this file with that app. Only
        /// populated when the drive.apps.readonly scope is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("openWithLinks")]
        public virtual System.Collections.Generic.IDictionary<string, string> OpenWithLinks { get; set; }

        /// <summary>
        /// The original filename of the uploaded content if available, or else the original value of the `title` field.
        /// This is only available for files with binary content in Google Drive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalFilename")]
        public virtual string OriginalFilename { get; set; }

        /// <summary>
        /// Output only. Whether the file is owned by the current user. Not populated for items in shared drives.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ownedByMe")]
        public virtual System.Nullable<bool> OwnedByMe { get; set; }

        /// <summary>
        /// Output only. Name(s) of the owner(s) of this file. Not populated for items in shared drives.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ownerNames")]
        public virtual System.Collections.Generic.IList<string> OwnerNames { get; set; }

        /// <summary>
        /// Output only. The owner of this file. Only certain legacy files may have more than one owner. This field
        /// isn't populated for items in shared drives.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("owners")]
        public virtual System.Collections.Generic.IList<User> Owners { get; set; }

        /// <summary>
        /// The ID of the parent folder containing the file. A file can only have one parent folder; specifying multiple
        /// parents isn't supported. If not specified as part of an insert request, the file is placed directly in the
        /// user's My Drive folder. If not specified as part of a copy request, the file inherits any discoverable
        /// parent of the source file. Update requests must use the `addParents` and `removeParents` parameters to
        /// modify the parents list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parents")]
        public virtual System.Collections.Generic.IList<ParentReference> Parents { get; set; }

        /// <summary>Output only. List of permission IDs for users with access to this file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissionIds")]
        public virtual System.Collections.Generic.IList<string> PermissionIds { get; set; }

        /// <summary>
        /// Output only. The list of permissions for users with access to this file. Not populated for items in shared
        /// drives.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<Permission> Permissions { get; set; }

        /// <summary>The list of properties.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual System.Collections.Generic.IList<Property> Properties { get; set; }

        /// <summary>Output only. The number of quota bytes used by this file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quotaBytesUsed")]
        public virtual System.Nullable<long> QuotaBytesUsed { get; set; }

        /// <summary>Output only. A key needed to access the item via a shared link.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceKey")]
        public virtual string ResourceKey { get; set; }

        /// <summary>Output only. A link back to this file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>
        /// Output only. The SHA1 checksum associated with this file, if available. This field is only populated for
        /// files with content stored in Google Drive; it is not populated for Docs Editors or shortcut files.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sha1Checksum")]
        public virtual string Sha1Checksum { get; set; }

        /// <summary>
        /// Output only. The SHA256 checksum associated with this file, if available. This field is only populated for
        /// files with content stored in Google Drive; it is not populated for Docs Editors or shortcut files.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sha256Checksum")]
        public virtual string Sha256Checksum { get; set; }

        /// <summary>Output only. Deprecated: Use `capabilities/canShare` instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shareable")]
        public virtual System.Nullable<bool> Shareable { get; set; }

        /// <summary>Output only. Whether the file has been shared. Not populated for items in shared drives.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shared")]
        public virtual System.Nullable<bool> Shared { get; set; }

        /// <summary>Time at which this file was shared with the user (formatted RFC 3339 timestamp).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sharedWithMeDate")]
        public virtual string SharedWithMeDateRaw { get; set; }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="SharedWithMeDateRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? SharedWithMeDateDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(SharedWithMeDateRaw);
            set => SharedWithMeDateRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="SharedWithMeDateRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use SharedWithMeDateDateTimeOffset instead.")]
        public virtual System.DateTime? SharedWithMeDate
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(SharedWithMeDateRaw);
            set => SharedWithMeDateRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>Output only. User that shared the item with the current user, if available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sharingUser")]
        public virtual User SharingUser { get; set; }

        /// <summary>
        /// Shortcut file details. Only populated for shortcut files, which have the mimeType field set to
        /// `application/vnd.google-apps.shortcut`. Can only be set on `files.insert` requests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shortcutDetails")]
        public virtual ShortcutDetailsData ShortcutDetails { get; set; }

        /// <summary>
        /// Output only. The list of spaces which contain the file. Supported values are `drive`, `appDataFolder` and
        /// `photos`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spaces")]
        public virtual System.Collections.Generic.IList<string> Spaces { get; set; }

        /// <summary>Output only. Deprecated: Use `driveId` instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("teamDriveId")]
        public virtual string TeamDriveId { get; set; }

        /// <summary>
        /// A thumbnail for the file. This will only be used if a standard thumbnail cannot be generated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thumbnail")]
        public virtual ThumbnailData Thumbnail { get; set; }

        /// <summary>
        /// Output only. A short-lived link to the file's thumbnail, if available. Typically lasts on the order of
        /// hours. Not intended for direct usage on web applications due to [Cross-Origin Resource Sharing
        /// (CORS)](https://developer.mozilla.org/en-US/docs/Web/HTTP/CORS), consider using a proxy server. Only
        /// populated when the requesting app can access the file's content. If the file isn't shared publicly, the URL
        /// returned in `Files.thumbnailLink` must be fetched using a credentialed request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thumbnailLink")]
        public virtual string ThumbnailLink { get; set; }

        /// <summary>Output only. The thumbnail version for use in thumbnail cache invalidation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thumbnailVersion")]
        public virtual System.Nullable<long> ThumbnailVersion { get; set; }

        /// <summary>
        /// The title of this file. Note that for immutable items such as the top level folders of shared drives, My
        /// Drive root folder, and Application Data folder the title is constant.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>
        /// The time that the item was trashed (formatted RFC 3339 timestamp). Only populated for items in shared
        /// drives.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trashedDate")]
        public virtual string TrashedDateRaw { get; set; }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="TrashedDateRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? TrashedDateDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(TrashedDateRaw);
            set => TrashedDateRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="TrashedDateRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use TrashedDateDateTimeOffset instead.")]
        public virtual System.DateTime? TrashedDate
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(TrashedDateRaw);
            set => TrashedDateRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>
        /// Output only. If the file has been explicitly trashed, the user who trashed it. Only populated for items in
        /// shared drives.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trashingUser")]
        public virtual User TrashingUser { get; set; }

        /// <summary>Output only. The permissions for the authenticated user on this file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userPermission")]
        public virtual Permission UserPermission { get; set; }

        /// <summary>
        /// Output only. A monotonically increasing version number for the file. This reflects every change made to the
        /// file on the server, even those not visible to the requesting user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual System.Nullable<long> Version { get; set; }

        /// <summary>Output only. Metadata about video media. This will only be present for video types.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoMediaMetadata")]
        public virtual VideoMediaMetadataData VideoMediaMetadata { get; set; }

        /// <summary>
        /// Output only. A link for downloading the content of the file in a browser using cookie based authentication.
        /// In cases where the content is shared publicly, the content can be downloaded without any credentials.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webContentLink")]
        public virtual string WebContentLink { get; set; }

        /// <summary>
        /// Output only. A link only available on public folders for viewing their static web assets (HTML, CSS, JS,
        /// etc) via Google Drive's Website Hosting.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webViewLink")]
        public virtual string WebViewLink { get; set; }

        /// <summary>
        /// Whether writers can share the document with other users. Not populated for items in shared drives.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("writersCanShare")]
        public virtual System.Nullable<bool> WritersCanShare { get; set; }

        /// <summary>
        /// Output only. Capabilities the current user has on this file. Each capability corresponds to a fine-grained
        /// action that a user may take.
        /// </summary>
        public class CapabilitiesData
        {
            /// <summary>
            /// Output only. Whether the current user is the pending owner of the file. Not populated for shared drive
            /// files.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canAcceptOwnership")]
            public virtual System.Nullable<bool> CanAcceptOwnership { get; set; }

            /// <summary>
            /// Output only. Whether the current user can add children to this folder. This is always false when the
            /// item is not a folder.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canAddChildren")]
            public virtual System.Nullable<bool> CanAddChildren { get; set; }

            /// <summary>
            /// Output only. Whether the current user can add a folder from another drive (different shared drive or My
            /// Drive) to this folder. This is false when the item is not a folder. Only populated for items in shared
            /// drives.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canAddFolderFromAnotherDrive")]
            public virtual System.Nullable<bool> CanAddFolderFromAnotherDrive { get; set; }

            /// <summary>
            /// Output only. Whether the current user can add a parent for the item without removing an existing parent
            /// in the same request. Not populated for shared drive files.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canAddMyDriveParent")]
            public virtual System.Nullable<bool> CanAddMyDriveParent { get; set; }

            /// <summary>
            /// Output only. Whether the current user can change the `copyRequiresWriterPermission` restriction of this
            /// file.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canChangeCopyRequiresWriterPermission")]
            public virtual System.Nullable<bool> CanChangeCopyRequiresWriterPermission { get; set; }

            /// <summary>Output only. Deprecated.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canChangeRestrictedDownload")]
            public virtual System.Nullable<bool> CanChangeRestrictedDownload { get; set; }

            /// <summary>
            /// Output only. Whether the current user can change the securityUpdateEnabled field on link share metadata.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canChangeSecurityUpdateEnabled")]
            public virtual System.Nullable<bool> CanChangeSecurityUpdateEnabled { get; set; }

            /// <summary>Output only. Whether the current user can comment on this file.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canComment")]
            public virtual System.Nullable<bool> CanComment { get; set; }

            /// <summary>
            /// Output only. Whether the current user can copy this file. For an item in a shared drive, whether the
            /// current user can copy non-folder descendants of this item, or this item itself if it is not a folder.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canCopy")]
            public virtual System.Nullable<bool> CanCopy { get; set; }

            /// <summary>Output only. Whether the current user can delete this file.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canDelete")]
            public virtual System.Nullable<bool> CanDelete { get; set; }

            /// <summary>
            /// Output only. Whether the current user can delete children of this folder. This is false when the item is
            /// not a folder. Only populated for items in shared drives.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canDeleteChildren")]
            public virtual System.Nullable<bool> CanDeleteChildren { get; set; }

            /// <summary>Output only. Whether a user can disable inherited permissions.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canDisableInheritedPermissions")]
            public virtual System.Nullable<bool> CanDisableInheritedPermissions { get; set; }

            /// <summary>Output only. Whether the current user can download this file.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canDownload")]
            public virtual System.Nullable<bool> CanDownload { get; set; }

            /// <summary>
            /// Output only. Whether the current user can edit this file. Other factors may limit the type of changes a
            /// user can make to a file. For example, see `canChangeCopyRequiresWriterPermission` or `canModifyContent`.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canEdit")]
            public virtual System.Nullable<bool> CanEdit { get; set; }

            /// <summary>Output only. Whether a user can re-enable inherited permissions.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canEnableInheritedPermissions")]
            public virtual System.Nullable<bool> CanEnableInheritedPermissions { get; set; }

            /// <summary>
            /// Output only. Whether the current user can list the children of this folder. This is always false when
            /// the item is not a folder.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canListChildren")]
            public virtual System.Nullable<bool> CanListChildren { get; set; }

            /// <summary>Output only. Whether the current user can modify the content of this file.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canModifyContent")]
            public virtual System.Nullable<bool> CanModifyContent { get; set; }

            /// <summary>
            /// Deprecated: Output only. Use one of `canModifyEditorContentRestriction`,
            /// `canModifyOwnerContentRestriction` or `canRemoveContentRestriction`.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canModifyContentRestriction")]
            public virtual System.Nullable<bool> CanModifyContentRestriction { get; set; }

            /// <summary>
            /// Output only. Whether the current user can add or modify content restrictions on the file which are
            /// editor restricted.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canModifyEditorContentRestriction")]
            public virtual System.Nullable<bool> CanModifyEditorContentRestriction { get; set; }

            /// <summary>Output only. Whether the current user can modify the labels on the file.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canModifyLabels")]
            public virtual System.Nullable<bool> CanModifyLabels { get; set; }

            /// <summary>
            /// Output only. Whether the current user can add or modify content restrictions which are owner restricted.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canModifyOwnerContentRestriction")]
            public virtual System.Nullable<bool> CanModifyOwnerContentRestriction { get; set; }

            /// <summary>
            /// Output only. Whether the current user can move children of this folder outside of the shared drive. This
            /// is false when the item is not a folder. Only populated for items in shared drives.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canMoveChildrenOutOfDrive")]
            public virtual System.Nullable<bool> CanMoveChildrenOutOfDrive { get; set; }

            /// <summary>Output only. Deprecated: Use `canMoveChildrenOutOfDrive` instead.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canMoveChildrenOutOfTeamDrive")]
            public virtual System.Nullable<bool> CanMoveChildrenOutOfTeamDrive { get; set; }

            /// <summary>
            /// Output only. Whether the current user can move children of this folder within this drive. This is false
            /// when the item is not a folder. Note that a request to move the child may still fail depending on the
            /// current user's access to the child and to the destination folder.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canMoveChildrenWithinDrive")]
            public virtual System.Nullable<bool> CanMoveChildrenWithinDrive { get; set; }

            /// <summary>Output only. Deprecated: Use `canMoveChildrenWithinDrive` instead.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canMoveChildrenWithinTeamDrive")]
            public virtual System.Nullable<bool> CanMoveChildrenWithinTeamDrive { get; set; }

            /// <summary>Output only. Deprecated: Use `canMoveItemOutOfDrive` instead.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canMoveItemIntoTeamDrive")]
            public virtual System.Nullable<bool> CanMoveItemIntoTeamDrive { get; set; }

            /// <summary>
            /// Output only. Whether the current user can move this item outside of this drive by changing its parent.
            /// Note that a request to change the parent of the item may still fail depending on the new parent that is
            /// being added.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canMoveItemOutOfDrive")]
            public virtual System.Nullable<bool> CanMoveItemOutOfDrive { get; set; }

            /// <summary>Output only. Deprecated: Use `canMoveItemOutOfDrive` instead.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canMoveItemOutOfTeamDrive")]
            public virtual System.Nullable<bool> CanMoveItemOutOfTeamDrive { get; set; }

            /// <summary>
            /// Output only. Whether the current user can move this item within this drive. Note that a request to
            /// change the parent of the item may still fail depending on the new parent that is being added and the
            /// parent that is being removed.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canMoveItemWithinDrive")]
            public virtual System.Nullable<bool> CanMoveItemWithinDrive { get; set; }

            /// <summary>Output only. Deprecated: Use `canMoveItemWithinDrive` instead.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canMoveItemWithinTeamDrive")]
            public virtual System.Nullable<bool> CanMoveItemWithinTeamDrive { get; set; }

            /// <summary>
            /// Output only. Deprecated: Use `canMoveItemWithinDrive` or `canMoveItemOutOfDrive` instead.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canMoveTeamDriveItem")]
            public virtual System.Nullable<bool> CanMoveTeamDriveItem { get; set; }

            /// <summary>
            /// Output only. Whether the current user can read the shared drive to which this file belongs. Only
            /// populated for items in shared drives.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canReadDrive")]
            public virtual System.Nullable<bool> CanReadDrive { get; set; }

            /// <summary>Output only. Whether the current user can read the labels on the file.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canReadLabels")]
            public virtual System.Nullable<bool> CanReadLabels { get; set; }

            /// <summary>
            /// Output only. Whether the current user can read the revisions resource of this file. For a shared drive
            /// item, whether revisions of non-folder descendants of this item, or this item itself if it is not a
            /// folder, can be read.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canReadRevisions")]
            public virtual System.Nullable<bool> CanReadRevisions { get; set; }

            /// <summary>Output only. Deprecated: Use `canReadDrive` instead.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canReadTeamDrive")]
            public virtual System.Nullable<bool> CanReadTeamDrive { get; set; }

            /// <summary>
            /// Output only. Whether the current user can remove children from this folder. This is always false when
            /// the item is not a folder. For a folder in a shared drive, use `canDeleteChildren` or `canTrashChildren`
            /// instead.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canRemoveChildren")]
            public virtual System.Nullable<bool> CanRemoveChildren { get; set; }

            /// <summary>
            /// Output only. Whether there is a content restriction on the file that can be removed by the current user.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canRemoveContentRestriction")]
            public virtual System.Nullable<bool> CanRemoveContentRestriction { get; set; }

            /// <summary>
            /// Output only. Whether the current user can remove a parent from the item without adding another parent in
            /// the same request. Not populated for shared drive files.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canRemoveMyDriveParent")]
            public virtual System.Nullable<bool> CanRemoveMyDriveParent { get; set; }

            /// <summary>Output only. Whether the current user can rename this file.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canRename")]
            public virtual System.Nullable<bool> CanRename { get; set; }

            /// <summary>Output only. Whether the current user can modify the sharing settings for this file.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canShare")]
            public virtual System.Nullable<bool> CanShare { get; set; }

            /// <summary>Output only. Whether the current user can move this file to trash.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canTrash")]
            public virtual System.Nullable<bool> CanTrash { get; set; }

            /// <summary>
            /// Output only. Whether the current user can trash children of this folder. This is false when the item is
            /// not a folder. Only populated for items in shared drives.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canTrashChildren")]
            public virtual System.Nullable<bool> CanTrashChildren { get; set; }

            /// <summary>Output only. Whether the current user can restore this file from trash.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canUntrash")]
            public virtual System.Nullable<bool> CanUntrash { get; set; }
        }

        /// <summary>
        /// Output only. Metadata about image media. This will only be present for image types, and its contents will
        /// depend on what can be parsed from the image content.
        /// </summary>
        public class ImageMediaMetadataData
        {
            /// <summary>Output only. The aperture used to create the photo (f-number).</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("aperture")]
            public virtual System.Nullable<float> Aperture { get; set; }

            /// <summary>Output only. The make of the camera used to create the photo.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("cameraMake")]
            public virtual string CameraMake { get; set; }

            /// <summary>Output only. The model of the camera used to create the photo.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("cameraModel")]
            public virtual string CameraModel { get; set; }

            /// <summary>Output only. The color space of the photo.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("colorSpace")]
            public virtual string ColorSpace { get; set; }

            /// <summary>Output only. The date and time the photo was taken (EXIF format timestamp).</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("date")]
            public virtual string Date { get; set; }

            /// <summary>Output only. The exposure bias of the photo (APEX value).</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("exposureBias")]
            public virtual System.Nullable<float> ExposureBias { get; set; }

            /// <summary>Output only. The exposure mode used to create the photo.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("exposureMode")]
            public virtual string ExposureMode { get; set; }

            /// <summary>Output only. The length of the exposure, in seconds.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("exposureTime")]
            public virtual System.Nullable<float> ExposureTime { get; set; }

            /// <summary>Output only. Whether a flash was used to create the photo.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("flashUsed")]
            public virtual System.Nullable<bool> FlashUsed { get; set; }

            /// <summary>Output only. The focal length used to create the photo, in millimeters.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("focalLength")]
            public virtual System.Nullable<float> FocalLength { get; set; }

            /// <summary>Output only. The height of the image in pixels.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("height")]
            public virtual System.Nullable<int> Height { get; set; }

            /// <summary>Output only. The ISO speed used to create the photo.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("isoSpeed")]
            public virtual System.Nullable<int> IsoSpeed { get; set; }

            /// <summary>Output only. The lens used to create the photo.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("lens")]
            public virtual string Lens { get; set; }

            /// <summary>Output only. Geographic location information stored in the image.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("location")]
            public virtual LocationData Location { get; set; }

            /// <summary>
            /// Output only. The smallest f-number of the lens at the focal length used to create the photo (APEX
            /// value).
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("maxApertureValue")]
            public virtual System.Nullable<float> MaxApertureValue { get; set; }

            /// <summary>Output only. The metering mode used to create the photo.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("meteringMode")]
            public virtual string MeteringMode { get; set; }

            /// <summary>
            /// Output only. The number of clockwise 90 degree rotations applied from the image's original orientation.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("rotation")]
            public virtual System.Nullable<int> Rotation { get; set; }

            /// <summary>Output only. The type of sensor used to create the photo.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("sensor")]
            public virtual string Sensor { get; set; }

            /// <summary>Output only. The distance to the subject of the photo, in meters.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("subjectDistance")]
            public virtual System.Nullable<int> SubjectDistance { get; set; }

            /// <summary>Output only. The white balance mode used to create the photo.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("whiteBalance")]
            public virtual string WhiteBalance { get; set; }

            /// <summary>Output only. The width of the image in pixels.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("width")]
            public virtual System.Nullable<int> Width { get; set; }

            /// <summary>Output only. Geographic location information stored in the image.</summary>
            public class LocationData
            {
                /// <summary>Output only. The altitude stored in the image.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("altitude")]
                public virtual System.Nullable<double> Altitude { get; set; }

                /// <summary>Output only. The latitude stored in the image.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("latitude")]
                public virtual System.Nullable<double> Latitude { get; set; }

                /// <summary>Output only. The longitude stored in the image.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("longitude")]
                public virtual System.Nullable<double> Longitude { get; set; }
            }
        }

        /// <summary>Indexable text attributes for the file (can only be written)</summary>
        public class IndexableTextData
        {
            /// <summary>The text to be indexed for this file.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("text")]
            public virtual string Text { get; set; }
        }

        /// <summary>Output only. An overview of the labels on the file.</summary>
        public class LabelInfoData
        {
            /// <summary>
            /// Output only. The set of labels on the file as requested by the label IDs in the `includeLabels`
            /// parameter. By default, no labels are returned.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("labels")]
            public virtual System.Collections.Generic.IList<Label> Labels { get; set; }
        }

        /// <summary>A group of labels for the file.</summary>
        public class LabelsData
        {
            /// <summary>Output only. Deprecated.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("hidden")]
            public virtual System.Nullable<bool> Hidden { get; set; }

            /// <summary>Output only. Whether the file has been modified by this user.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("modified")]
            public virtual System.Nullable<bool> Modified { get; set; }

            /// <summary>Output only. Deprecated: Use `copyRequiresWriterPermission` instead.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("restricted")]
            public virtual System.Nullable<bool> Restricted { get; set; }

            /// <summary>Whether this file is starred by the user.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("starred")]
            public virtual System.Nullable<bool> Starred { get; set; }

            /// <summary>
            /// Whether this file has been trashed. This label applies to all users accessing the file; however, only
            /// owners are allowed to see and untrash files.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("trashed")]
            public virtual System.Nullable<bool> Trashed { get; set; }

            /// <summary>Whether this file has been viewed by this user.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("viewed")]
            public virtual System.Nullable<bool> Viewed { get; set; }
        }

        /// <summary>Contains details about the link URLs that clients are using to refer to this item.</summary>
        public class LinkShareMetadataData
        {
            /// <summary>Output only. Whether the file is eligible for security update.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("securityUpdateEligible")]
            public virtual System.Nullable<bool> SecurityUpdateEligible { get; set; }

            /// <summary>Output only. Whether the security update is enabled for this file.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("securityUpdateEnabled")]
            public virtual System.Nullable<bool> SecurityUpdateEnabled { get; set; }
        }

        /// <summary>
        /// Shortcut file details. Only populated for shortcut files, which have the mimeType field set to
        /// `application/vnd.google-apps.shortcut`. Can only be set on `files.insert` requests.
        /// </summary>
        public class ShortcutDetailsData
        {
            /// <summary>
            /// The ID of the file that this shortcut points to. Can only be set on `files.insert` requests.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("targetId")]
            public virtual string TargetId { get; set; }

            /// <summary>
            /// Output only. The MIME type of the file that this shortcut points to. The value of this field is a
            /// snapshot of the target's MIME type, captured when the shortcut is created.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("targetMimeType")]
            public virtual string TargetMimeType { get; set; }

            /// <summary>Output only. The ResourceKey for the target file.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("targetResourceKey")]
            public virtual string TargetResourceKey { get; set; }
        }

        /// <summary>
        /// A thumbnail for the file. This will only be used if a standard thumbnail cannot be generated.
        /// </summary>
        public class ThumbnailData
        {
            /// <summary>
            /// The URL-safe Base64 encoded bytes of the thumbnail image. It should conform to RFC 4648 section 5.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("image")]
            public virtual string Image { get; set; }

            /// <summary>The MIME type of the thumbnail.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
            public virtual string MimeType { get; set; }
        }

        /// <summary>Output only. Metadata about video media. This will only be present for video types.</summary>
        public class VideoMediaMetadataData
        {
            /// <summary>Output only. The duration of the video in milliseconds.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("durationMillis")]
            public virtual System.Nullable<long> DurationMillis { get; set; }

            /// <summary>Output only. The height of the video in pixels.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("height")]
            public virtual System.Nullable<int> Height { get; set; }

            /// <summary>Output only. The width of the video in pixels.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("width")]
            public virtual System.Nullable<int> Width { get; set; }
        }
    }

    /// <summary>A list of files.</summary>
    public class FileList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Whether the search process was incomplete. If true, then some search results may be missing, since all
        /// documents were not searched. This may occur when searching multiple drives with the "allDrives" corpora, but
        /// all corpora could not be searched. When this happens, it is suggested that clients narrow their query by
        /// choosing a different corpus such as "default" or "drive".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("incompleteSearch")]
        public virtual System.Nullable<bool> IncompleteSearch { get; set; }

        /// <summary>
        /// The list of files. If nextPageToken is populated, then this list may be incomplete and an additional page of
        /// results should be fetched.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<File> Items { get; set; }

        /// <summary>This is always `drive#fileList`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>A link to the next page of files.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextLink")]
        public virtual string NextLink { get; set; }

        /// <summary>
        /// The page token for the next page of files. This will be absent if the end of the files list has been
        /// reached. If the token is rejected for any reason, it should be discarded, and pagination should be restarted
        /// from the first page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A link back to this list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }
    }

    /// <summary>A list of generated IDs which can be provided in insert requests</summary>
    public class GeneratedIds : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The IDs generated for the requesting user in the specified space.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ids")]
        public virtual System.Collections.Generic.IList<string> Ids { get; set; }

        /// <summary>This is always `drive#generatedIds`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The type of file that can be created with these IDs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("space")]
        public virtual string Space { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Representation of a label and label fields.</summary>
    public class Label : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A map of the fields on the label, keyed by the field's ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual System.Collections.Generic.IDictionary<string, LabelField> Fields { get; set; }

        /// <summary>The ID of the label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>This is always `drive#label`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The revision ID of the label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionId")]
        public virtual string RevisionId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Representation of field, which is a typed key-value pair.</summary>
    public class LabelField : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Only present if valueType is dateString. RFC 3339 formatted date: YYYY-MM-DD.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateString")]
        public virtual System.Collections.Generic.IList<string> DateString { get; set; }

        /// <summary>The identifier of this label field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Only present if `valueType` is `integer`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("integer")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> Integer { get; set; }

        /// <summary>This is always `drive#labelField`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Only present if `valueType` is `selection`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selection")]
        public virtual System.Collections.Generic.IList<string> Selection { get; set; }

        /// <summary>Only present if `valueType` is `text`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual System.Collections.Generic.IList<string> Text { get; set; }

        /// <summary>Only present if `valueType` is `user`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("user")]
        public virtual System.Collections.Generic.IList<User> User { get; set; }

        /// <summary>
        /// The field type. While new values may be supported in the future, the following are currently allowed: *
        /// `dateString` * `integer` * `selection` * `text` * `user`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueType")]
        public virtual string ValueType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A modification to a label's field.</summary>
    public class LabelFieldModification : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the field to be modified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldId")]
        public virtual string FieldId { get; set; }

        /// <summary>This is always `drive#labelFieldModification`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Replaces the value of a dateString Field with these new values. The string must be in the RFC 3339 full-date
        /// format: YYYY-MM-DD.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("setDateValues")]
        public virtual System.Collections.Generic.IList<string> SetDateValues { get; set; }

        /// <summary>Replaces the value of an `integer` field with these new values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("setIntegerValues")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> SetIntegerValues { get; set; }

        /// <summary>Replaces a `selection` field with these new values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("setSelectionValues")]
        public virtual System.Collections.Generic.IList<string> SetSelectionValues { get; set; }

        /// <summary>Sets the value of a `text` field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("setTextValues")]
        public virtual System.Collections.Generic.IList<string> SetTextValues { get; set; }

        /// <summary>Replaces a `user` field with these new values. The values must be valid email addresses.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("setUserValues")]
        public virtual System.Collections.Generic.IList<string> SetUserValues { get; set; }

        /// <summary>Unsets the values for this field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unsetValues")]
        public virtual System.Nullable<bool> UnsetValues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A list of labels applied to a file.</summary>
    public class LabelList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of labels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Label> Items { get; set; }

        /// <summary>This is always `drive#labelList`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The page token for the next page of labels. This field will be absent if the end of the list has been
        /// reached. If the token is rejected for any reason, it should be discarded, and pagination should be restarted
        /// from the first page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A modification to a label on a file. A LabelModification can be used to apply a label to a file, update an
    /// existing label on a file, or remove a label from a file.
    /// </summary>
    public class LabelModification : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of modifications to this label's fields.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldModifications")]
        public virtual System.Collections.Generic.IList<LabelFieldModification> FieldModifications { get; set; }

        /// <summary>This is always `drive#labelModification`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ID of the label to modify.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelId")]
        public virtual string LabelId { get; set; }

        /// <summary>If true, the label will be removed from the file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("removeLabel")]
        public virtual System.Nullable<bool> RemoveLabel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A request to modify the set of labels on a file. This request may contain many modifications that will either
    /// all succeed or all fail atomically.
    /// </summary>
    public class ModifyLabelsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>This is always `drive#modifyLabelsRequest`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The list of modifications to apply to the labels on the file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelModifications")]
        public virtual System.Collections.Generic.IList<LabelModification> LabelModifications { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response to a ModifyLabels request. This contains only those labels which were added or updated by the request.
    /// </summary>
    public class ModifyLabelsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>This is always `drive#modifyLabelsResponse`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The list of labels which were added or updated by the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modifiedLabels")]
        public virtual System.Collections.Generic.IList<Label> ModifiedLabels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A list of a file's parents.</summary>
    public class ParentList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The list of parents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<ParentReference> Items { get; set; }

        /// <summary>This is always `drive#parentList`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>A link back to this list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }
    }

    /// <summary>
    /// A reference to a file's parent. A file can only have one parent folder; specifying multiple parents isn't
    /// supported. Some resource methods (such as `parents.get`) require a `parentId`. Use the `parents.list` method to
    /// retrieve the ID for a parent.
    /// </summary>
    public class ParentReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the parent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Output only. Whether or not the parent is the root folder.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isRoot")]
        public virtual System.Nullable<bool> IsRoot { get; set; }

        /// <summary>Output only. This is always `drive#parentReference`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Output only. A link to the parent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentLink")]
        public virtual string ParentLink { get; set; }

        /// <summary>Output only. A link back to this reference.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A permission for a file. A permission grants a user, group, domain, or the world access to a file or a folder
    /// hierarchy. Some resource methods (such as `permissions.update`) require a `permissionId`. Use the
    /// `permissions.list` method to retrieve the ID for a file, folder, or shared drive.
    /// </summary>
    public class Permission : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Additional roles for this user. Only `commenter` is currently allowed, though more may be supported in the
        /// future.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalRoles")]
        public virtual System.Collections.Generic.IList<string> AdditionalRoles { get; set; }

        /// <summary>Output only. Deprecated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authKey")]
        public virtual string AuthKey { get; set; }

        /// <summary>
        /// Output only. Whether the account associated with this permission has been deleted. This field only pertains
        /// to user and group permissions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleted")]
        public virtual System.Nullable<bool> Deleted { get; set; }

        /// <summary>
        /// Output only. The domain name of the entity this permission refers to. This is an output-only field which is
        /// present when the permission type is `user`, `group` or `domain`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domain")]
        public virtual string Domain { get; set; }

        /// <summary>
        /// Output only. The email address of the user or group this permission refers to. This is an output-only field
        /// which is present when the permission type is `user` or `group`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emailAddress")]
        public virtual string EmailAddress { get; set; }

        /// <summary>Output only. The ETag of the permission.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// The time at which this permission will expire (RFC 3339 date-time). Expiration dates have the following
        /// restrictions: - They can only be set on user and group permissions - The date must be in the future - The
        /// date cannot be more than a year in the future - The date can only be set on drive.permissions.update or
        /// drive.permissions.patch requests
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expirationDate")]
        public virtual string ExpirationDateRaw { get; set; }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="ExpirationDateRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ExpirationDateDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(ExpirationDateRaw);
            set => ExpirationDateRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="ExpirationDateRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ExpirationDateDateTimeOffset instead.")]
        public virtual System.DateTime? ExpirationDate
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(ExpirationDateRaw);
            set => ExpirationDateRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>
        /// The ID of the user this permission refers to, and identical to the `permissionId` in the About and Files
        /// resources. When making a `drive.permissions.insert` request, exactly one of the `id` or `value` fields must
        /// be specified unless the permission type is `anyone`, in which case both `id` and `value` are ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// When true, only organizers, owners, and users with permissions added directly on the item can access it.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inheritedPermissionsDisabled")]
        public virtual System.Nullable<bool> InheritedPermissionsDisabled { get; set; }

        /// <summary>Output only. This is always `drive#permission`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Output only. The name for this permission.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Whether the account associated with this permission is a pending owner. Only populated for `user` type
        /// permissions for files that are not in a shared drive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pendingOwner")]
        public virtual System.Nullable<bool> PendingOwner { get; set; }

        /// <summary>
        /// Output only. Details of whether the permissions on this item are inherited or directly on this item.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissionDetails")]
        public virtual System.Collections.Generic.IList<PermissionDetailsData> PermissionDetails { get; set; }

        /// <summary>Output only. A link to the profile photo, if available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("photoLink")]
        public virtual string PhotoLink { get; set; }

        /// <summary>
        /// The primary role for this user. While new values may be supported in the future, the following are currently
        /// allowed: * `owner` * `organizer` * `fileOrganizer` * `writer` * `reader`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>Output only. A link back to this permission.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>Output only. Deprecated: Use `permissionDetails` instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("teamDrivePermissionDetails")]
        public virtual System.Collections.Generic.IList<TeamDrivePermissionDetailsData> TeamDrivePermissionDetails { get; set; }

        /// <summary>The account type. Allowed values are: * `user` * `group` * `domain` * `anyone`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>
        /// The email address or domain name for the entity. This is used during inserts and is not populated in
        /// responses. When making a `drive.permissions.insert` request, exactly one of the `id` or `value` fields must
        /// be specified unless the permission type is `anyone`, in which case both `id` and `value` are ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>
        /// Indicates the view for this permission. Only populated for permissions that belong to a view. published and
        /// metadata are the only supported values. - published: The permission's role is published_reader. - metadata:
        /// The item is only visible to the metadata view because the item has limited access and the scope has at least
        /// read access to the parent. Note: The metadata view is currently only supported on folders.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("view")]
        public virtual string View { get; set; }

        /// <summary>Whether the link is required for this permission.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("withLink")]
        public virtual System.Nullable<bool> WithLink { get; set; }

        /// <summary>
        /// Output only. Details of whether the permissions on this item are inherited or directly on this item.
        /// </summary>
        public class PermissionDetailsData
        {
            /// <summary>
            /// Output only. Additional roles for this user. Only `commenter` is currently possible, though more may be
            /// supported in the future.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("additionalRoles")]
            public virtual System.Collections.Generic.IList<string> AdditionalRoles { get; set; }

            /// <summary>Output only. Whether this permission is inherited. This field is always populated.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("inherited")]
            public virtual System.Nullable<bool> Inherited { get; set; }

            /// <summary>
            /// Output only. The ID of the item from which this permission is inherited. This is only populated for
            /// items in shared drives.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("inheritedFrom")]
            public virtual string InheritedFrom { get; set; }

            /// <summary>
            /// Output only. The permission type for this user. While new values may be added in future, the following
            /// are currently possible: * `file` * `member`
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("permissionType")]
            public virtual string PermissionType { get; set; }

            /// <summary>
            /// Output only. The primary role for this user. While new values may be added in the future, the following
            /// are currently possible: * `organizer` * `fileOrganizer` * `writer` * `reader`
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("role")]
            public virtual string Role { get; set; }
        }

        /// <summary>Output only. Deprecated: Use `permissionDetails` instead.</summary>
        public class TeamDrivePermissionDetailsData
        {
            /// <summary>Output only. Deprecated: Use `permissionDetails/additionalRoles` instead.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("additionalRoles")]
            public virtual System.Collections.Generic.IList<string> AdditionalRoles { get; set; }

            /// <summary>Output only. Deprecated: Use `permissionDetails/inherited` instead.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("inherited")]
            public virtual System.Nullable<bool> Inherited { get; set; }

            /// <summary>Output only. Deprecated: Use `permissionDetails/inheritedFrom` instead.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("inheritedFrom")]
            public virtual string InheritedFrom { get; set; }

            /// <summary>Output only. Deprecated: Use `permissionDetails/role` instead.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("role")]
            public virtual string Role { get; set; }

            /// <summary>Output only. Deprecated: Use `permissionDetails/permissionType` instead.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("teamDrivePermissionType")]
            public virtual string TeamDrivePermissionType { get; set; }
        }
    }

    /// <summary>An ID for a user or group as seen in Permission items.</summary>
    public class PermissionId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The permission ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>This is always `drive#permissionId`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A list of permissions associated with a file.</summary>
    public class PermissionList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The list of permissions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Permission> Items { get; set; }

        /// <summary>This is always `drive#permissionList`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The page token for the next page of permissions. This field will be absent if the end of the permissions
        /// list has been reached. If the token is rejected for any reason, it should be discarded, and pagination
        /// should be restarted from the first page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A link back to this list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }
    }

    /// <summary>
    /// A key-value pair attached to a file that is either public or private to an application. The following limits
    /// apply to file properties: * Maximum of 100 properties total per file * Maximum of 30 private properties per app
    /// * Maximum of 30 public properties * Maximum of 124 bytes size limit on (key + value) string in UTF-8 encoding
    /// for a single property Some resource methods (such as `properties.update`) require a `propertyKey`. Use the
    /// `properties.list` method to retrieve the key for a property.
    /// </summary>
    public class Property : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. ETag of the property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The key of this property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>Output only. This is always `drive#property`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Output only. The link back to this property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>The value of this property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>
        /// The visibility of this property. Allowed values are PRIVATE (default) and PUBLIC. Private properties can
        /// only be retrieved using an authenticated request. An authenticated request uses an access token obtained
        /// with a OAuth 2 client ID. You cannot use an API key to retrieve private properties.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visibility")]
        public virtual string Visibility { get; set; }
    }

    /// <summary>
    /// A collection of properties, key-value pairs that are either public or private to an application.
    /// </summary>
    public class PropertyList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The list of properties.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Property> Items { get; set; }

        /// <summary>This is always `drive#propertyList`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The link back to this list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }
    }

    /// <summary>
    /// A revision of a file. Some resource methods (such as `revisions.update`) require a `revisionId`. Use the
    /// `revisions.list` method to retrieve the ID for a revision.
    /// </summary>
    public class Revision : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Short term download URL for the file. This will only be populated on files with content stored
        /// in Drive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("downloadUrl")]
        public virtual string DownloadUrl { get; set; }

        /// <summary>Output only. The ETag of the revision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Output only. Links for exporting Docs Editors files to specific formats.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exportLinks")]
        public virtual System.Collections.Generic.IDictionary<string, string> ExportLinks { get; set; }

        /// <summary>
        /// Output only. The size of the revision in bytes. This will only be populated on files with content stored in
        /// Drive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileSize")]
        public virtual System.Nullable<long> FileSize { get; set; }

        /// <summary>Output only. The ID of the revision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Output only. This is always `drive#revision`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Output only. The last user to modify this revision. This field is only populated when the last modification
        /// was performed by a signed-in user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastModifyingUser")]
        public virtual User LastModifyingUser { get; set; }

        /// <summary>Output only. Name of the last user to modify this revision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastModifyingUserName")]
        public virtual string LastModifyingUserName { get; set; }

        /// <summary>
        /// Output only. An MD5 checksum for the content of this revision. This will only be populated on files with
        /// content stored in Drive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("md5Checksum")]
        public virtual string Md5Checksum { get; set; }

        /// <summary>Output only. The MIME type of the revision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>Last time this revision was modified (formatted RFC 3339 timestamp).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modifiedDate")]
        public virtual string ModifiedDateRaw { get; set; }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ModifiedDateRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ModifiedDateDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(ModifiedDateRaw);
            set => ModifiedDateRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="ModifiedDateRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ModifiedDateDateTimeOffset instead.")]
        public virtual System.DateTime? ModifiedDate
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(ModifiedDateRaw);
            set => ModifiedDateRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>
        /// Output only. The original filename when this revision was created. This will only be populated on files with
        /// content stored in Drive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalFilename")]
        public virtual string OriginalFilename { get; set; }

        /// <summary>
        /// Whether this revision is pinned to prevent automatic purging. If not set, the revision is automatically
        /// purged 30 days after newer content is uploaded. This field can only be modified on files with content stored
        /// in Drive, excluding Docs Editors files. Revisions can also be pinned when they are created through the
        /// drive.files.insert/update/copy by using the pinned query parameter. Pinned revisions are stored indefinitely
        /// using additional storage quota, up to a maximum of 200 revisions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pinned")]
        public virtual System.Nullable<bool> Pinned { get; set; }

        /// <summary>
        /// Whether subsequent revisions will be automatically republished. This is only populated and can only be
        /// modified for Docs Editors files.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publishAuto")]
        public virtual System.Nullable<bool> PublishAuto { get; set; }

        /// <summary>
        /// Whether this revision is published. This is only populated and can only be modified for Docs Editors files.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("published")]
        public virtual System.Nullable<bool> Published { get; set; }

        /// <summary>
        /// Output only. A link to the published revision. This is only populated for Docs Editors files.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publishedLink")]
        public virtual string PublishedLink { get; set; }

        /// <summary>
        /// Whether this revision is published outside the domain. This is only populated and can only be modified for
        /// Docs Editors files.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publishedOutsideDomain")]
        public virtual System.Nullable<bool> PublishedOutsideDomain { get; set; }

        /// <summary>Output only. A link back to this revision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }
    }

    /// <summary>A list of revisions of a file.</summary>
    public class RevisionList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// The list of revisions. If nextPageToken is populated, then this list may be incomplete and an additional
        /// page of results should be fetched.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Revision> Items { get; set; }

        /// <summary>This is always `drive#revisionList`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The page token for the next page of revisions. This field will be absent if the end of the revisions list
        /// has been reached. If the token is rejected for any reason, it should be discarded and pagination should be
        /// restarted from the first page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A link back to this list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }
    }

    public class StartPageToken : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string `"drive#startPageToken"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The starting page token for listing changes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startPageToken")]
        public virtual string StartPageTokenValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Deprecated: Use the `drive` collection instead.</summary>
    public class TeamDrive : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An image file and cropping parameters from which a background image for this Team Drive is set. This is a
        /// write only field; it can only be set on `drive.teamdrives.update` requests that don't set `themeId`. When
        /// specified, all fields of the `backgroundImageFile` must be set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backgroundImageFile")]
        public virtual BackgroundImageFileData BackgroundImageFile { get; set; }

        /// <summary>A short-lived link to this Team Drive's background image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backgroundImageLink")]
        public virtual string BackgroundImageLink { get; set; }

        /// <summary>Capabilities the current user has on this Team Drive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("capabilities")]
        public virtual CapabilitiesData Capabilities { get; set; }

        /// <summary>
        /// The color of this Team Drive as an RGB hex string. It can only be set on a `drive.teamdrives.update` request
        /// that does not set `themeId`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("colorRgb")]
        public virtual string ColorRgb { get; set; }

        /// <summary>The time at which the Team Drive was created (RFC 3339 date-time).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createdDate")]
        public virtual string CreatedDateRaw { get; set; }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CreatedDateRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreatedDateDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(CreatedDateRaw);
            set => CreatedDateRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="CreatedDateRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreatedDateDateTimeOffset instead.")]
        public virtual System.DateTime? CreatedDate
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(CreatedDateRaw);
            set => CreatedDateRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>
        /// The ID of this Team Drive which is also the ID of the top level folder of this Team Drive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>This is always `drive#teamDrive`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The name of this Team Drive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The organizational unit of this shared drive. This field is only populated on `drives.list` responses when
        /// the `useDomainAdminAccess` parameter is set to `true`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orgUnitId")]
        public virtual string OrgUnitId { get; set; }

        /// <summary>A set of restrictions that apply to this Team Drive or items inside this Team Drive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restrictions")]
        public virtual RestrictionsData Restrictions { get; set; }

        /// <summary>
        /// The ID of the theme from which the background image and color will be set. The set of possible
        /// `teamDriveThemes` can be retrieved from a `drive.about.get` response. When not specified on a
        /// `drive.teamdrives.insert` request, a random theme is chosen from which the background image and color are
        /// set. This is a write-only field; it can only be set on requests that don't set `colorRgb` or
        /// `backgroundImageFile`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("themeId")]
        public virtual string ThemeId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>
        /// An image file and cropping parameters from which a background image for this Team Drive is set. This is a
        /// write only field; it can only be set on `drive.teamdrives.update` requests that don't set `themeId`. When
        /// specified, all fields of the `backgroundImageFile` must be set.
        /// </summary>
        public class BackgroundImageFileData
        {
            /// <summary>The ID of an image file in Drive to use for the background image.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("id")]
            public virtual string Id { get; set; }

            /// <summary>
            /// The width of the cropped image in the closed range of 0 to 1. This value represents the width of the
            /// cropped image divided by the width of the entire image. The height is computed by applying a width to
            /// height aspect ratio of 80 to 9. The resulting image must be at least 1280 pixels wide and 144 pixels
            /// high.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("width")]
            public virtual System.Nullable<float> Width { get; set; }

            /// <summary>
            /// The X coordinate of the upper left corner of the cropping area in the background image. This is a value
            /// in the closed range of 0 to 1. This value represents the horizontal distance from the left side of the
            /// entire image to the left side of the cropping area divided by the width of the entire image.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("xCoordinate")]
            public virtual System.Nullable<float> XCoordinate { get; set; }

            /// <summary>
            /// The Y coordinate of the upper left corner of the cropping area in the background image. This is a value
            /// in the closed range of 0 to 1. This value represents the vertical distance from the top side of the
            /// entire image to the top side of the cropping area divided by the height of the entire image.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("yCoordinate")]
            public virtual System.Nullable<float> YCoordinate { get; set; }
        }

        /// <summary>Capabilities the current user has on this Team Drive.</summary>
        public class CapabilitiesData
        {
            /// <summary>Whether the current user can add children to folders in this Team Drive.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canAddChildren")]
            public virtual System.Nullable<bool> CanAddChildren { get; set; }

            /// <summary>
            /// Whether the current user can change the `copyRequiresWriterPermission` restriction of this Team Drive.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canChangeCopyRequiresWriterPermissionRestriction")]
            public virtual System.Nullable<bool> CanChangeCopyRequiresWriterPermissionRestriction { get; set; }

            /// <summary>
            /// Whether the current user can change the `domainUsersOnly` restriction of this Team Drive.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canChangeDomainUsersOnlyRestriction")]
            public virtual System.Nullable<bool> CanChangeDomainUsersOnlyRestriction { get; set; }

            /// <summary>
            /// Whether the current user can change the `sharingFoldersRequiresOrganizerPermission` restriction of this
            /// Team Drive.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canChangeSharingFoldersRequiresOrganizerPermissionRestriction")]
            public virtual System.Nullable<bool> CanChangeSharingFoldersRequiresOrganizerPermissionRestriction { get; set; }

            /// <summary>Whether the current user can change the background of this Team Drive.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canChangeTeamDriveBackground")]
            public virtual System.Nullable<bool> CanChangeTeamDriveBackground { get; set; }

            /// <summary>
            /// Whether the current user can change the `teamMembersOnly` restriction of this Team Drive.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canChangeTeamMembersOnlyRestriction")]
            public virtual System.Nullable<bool> CanChangeTeamMembersOnlyRestriction { get; set; }

            /// <summary>Whether the current user can comment on files in this Team Drive.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canComment")]
            public virtual System.Nullable<bool> CanComment { get; set; }

            /// <summary>Whether the current user can copy files in this Team Drive.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canCopy")]
            public virtual System.Nullable<bool> CanCopy { get; set; }

            /// <summary>Whether the current user can delete children from folders in this Team Drive.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canDeleteChildren")]
            public virtual System.Nullable<bool> CanDeleteChildren { get; set; }

            /// <summary>
            /// Whether the current user can delete this Team Drive. Attempting to delete the Team Drive may still fail
            /// if there are untrashed items inside the Team Drive.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canDeleteTeamDrive")]
            public virtual System.Nullable<bool> CanDeleteTeamDrive { get; set; }

            /// <summary>Whether the current user can download files in this Team Drive.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canDownload")]
            public virtual System.Nullable<bool> CanDownload { get; set; }

            /// <summary>Whether the current user can edit files in this Team Drive</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canEdit")]
            public virtual System.Nullable<bool> CanEdit { get; set; }

            /// <summary>Whether the current user can list the children of folders in this Team Drive.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canListChildren")]
            public virtual System.Nullable<bool> CanListChildren { get; set; }

            /// <summary>
            /// Whether the current user can add members to this Team Drive or remove them or change their role.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canManageMembers")]
            public virtual System.Nullable<bool> CanManageMembers { get; set; }

            /// <summary>Whether the current user can read the revisions resource of files in this Team Drive.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canReadRevisions")]
            public virtual System.Nullable<bool> CanReadRevisions { get; set; }

            /// <summary>Deprecated: Use `canDeleteChildren` or `canTrashChildren` instead.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canRemoveChildren")]
            public virtual System.Nullable<bool> CanRemoveChildren { get; set; }

            /// <summary>Whether the current user can rename files or folders in this Team Drive.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canRename")]
            public virtual System.Nullable<bool> CanRename { get; set; }

            /// <summary>Whether the current user can rename this Team Drive.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canRenameTeamDrive")]
            public virtual System.Nullable<bool> CanRenameTeamDrive { get; set; }

            /// <summary>Whether the current user can reset the Team Drive restrictions to defaults.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canResetTeamDriveRestrictions")]
            public virtual System.Nullable<bool> CanResetTeamDriveRestrictions { get; set; }

            /// <summary>Whether the current user can share files or folders in this Team Drive.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canShare")]
            public virtual System.Nullable<bool> CanShare { get; set; }

            /// <summary>Whether the current user can trash children from folders in this Team Drive.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canTrashChildren")]
            public virtual System.Nullable<bool> CanTrashChildren { get; set; }
        }

        /// <summary>A set of restrictions that apply to this Team Drive or items inside this Team Drive.</summary>
        public class RestrictionsData
        {
            /// <summary>
            /// Whether administrative privileges on this Team Drive are required to modify restrictions.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("adminManagedRestrictions")]
            public virtual System.Nullable<bool> AdminManagedRestrictions { get; set; }

            /// <summary>
            /// Whether the options to copy, print, or download files inside this Team Drive, should be disabled for
            /// readers and commenters. When this restriction is set to `true`, it will override the similarly named
            /// field to `true` for any file inside this Team Drive.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("copyRequiresWriterPermission")]
            public virtual System.Nullable<bool> CopyRequiresWriterPermission { get; set; }

            /// <summary>
            /// Whether access to this Team Drive and items inside this Team Drive is restricted to users of the domain
            /// to which this Team Drive belongs. This restriction may be overridden by other sharing policies
            /// controlled outside of this Team Drive.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("domainUsersOnly")]
            public virtual System.Nullable<bool> DomainUsersOnly { get; set; }

            /// <summary>
            /// If true, only users with the organizer role can share folders. If false, users with either the organizer
            /// role or the file organizer role can share folders.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("sharingFoldersRequiresOrganizerPermission")]
            public virtual System.Nullable<bool> SharingFoldersRequiresOrganizerPermission { get; set; }

            /// <summary>
            /// Whether access to items inside this Team Drive is restricted to members of this Team Drive.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("teamMembersOnly")]
            public virtual System.Nullable<bool> TeamMembersOnly { get; set; }
        }
    }

    /// <summary>A list of Team Drives.</summary>
    public class TeamDriveList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of Team Drives.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<TeamDrive> Items { get; set; }

        /// <summary>This is always `drive#teamDriveList`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The page token for the next page of Team Drives.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a Drive user.</summary>
    public class User : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. A plain text displayable name for this user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Output only. The email address of the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emailAddress")]
        public virtual string EmailAddress { get; set; }

        /// <summary>
        /// Output only. Whether this user is the same as the authenticated user for whom the request was made.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isAuthenticatedUser")]
        public virtual System.Nullable<bool> IsAuthenticatedUser { get; set; }

        /// <summary>Output only. This is always `drive#user`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Output only. The user's ID as visible in the permissions collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissionId")]
        public virtual string PermissionId { get; set; }

        /// <summary>Output only. The user's profile picture.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("picture")]
        public virtual PictureData Picture { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>Output only. The user's profile picture.</summary>
        public class PictureData
        {
            /// <summary>Output Only. A URL that points to a profile picture of this user.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("url")]
            public virtual string Url { get; set; }
        }
    }
}
