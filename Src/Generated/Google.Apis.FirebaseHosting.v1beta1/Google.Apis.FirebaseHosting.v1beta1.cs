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

namespace Google.Apis.FirebaseHosting.v1beta1
{
    /// <summary>The FirebaseHosting Service.</summary>
    public class FirebaseHostingService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1beta1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public FirebaseHostingService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public FirebaseHostingService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
            Sites = new SitesResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "firebasehosting";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://firebasehosting.googleapis.com/";
        #else
            "https://firebasehosting.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://firebasehosting.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Firebase Hosting API.</summary>
        public class Scope
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>View your data across Google Cloud Platform services</summary>
            public static string CloudPlatformReadOnly = "https://www.googleapis.com/auth/cloud-platform.read-only";

            /// <summary>View and administer all your Firebase data and settings</summary>
            public static string Firebase = "https://www.googleapis.com/auth/firebase";

            /// <summary>View all your Firebase data and settings</summary>
            public static string FirebaseReadonly = "https://www.googleapis.com/auth/firebase.readonly";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Firebase Hosting API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>View your data across Google Cloud Platform services</summary>
            public const string CloudPlatformReadOnly = "https://www.googleapis.com/auth/cloud-platform.read-only";

            /// <summary>View and administer all your Firebase data and settings</summary>
            public const string Firebase = "https://www.googleapis.com/auth/firebase";

            /// <summary>View all your Firebase data and settings</summary>
            public const string FirebaseReadonly = "https://www.googleapis.com/auth/firebase.readonly";
        }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }

        /// <summary>Gets the Sites resource.</summary>
        public virtual SitesResource Sites { get; }
    }

    /// <summary>A base abstract class for FirebaseHosting requests.</summary>
    public abstract class FirebaseHostingBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new FirebaseHostingBaseServiceRequest instance.</summary>
        protected FirebaseHostingBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes FirebaseHosting parameter list.</summary>
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
            Operations = new OperationsResource(service);
            Sites = new SitesResource(service);
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
            public class GetRequest : FirebaseHostingBaseServiceRequest<Google.Apis.FirebaseHosting.v1beta1.Data.Operation>
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
        }

        /// <summary>Gets the Sites resource.</summary>
        public virtual SitesResource Sites { get; }

        /// <summary>The "sites" collection of methods.</summary>
        public class SitesResource
        {
            private const string Resource = "sites";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public SitesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Channels = new ChannelsResource(service);
                Domains = new DomainsResource(service);
                Releases = new ReleasesResource(service);
                Versions = new VersionsResource(service);
            }

            /// <summary>Gets the Channels resource.</summary>
            public virtual ChannelsResource Channels { get; }

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
                    }

                    /// <summary>
                    /// Creates a new release, which makes the content of the specified version actively display on the
                    /// appropriate URL(s).
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The site or channel to which the release belongs, in either of the following formats:
                    /// - sites/SITE_ID - sites/SITE_ID/channels/CHANNEL_ID
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.FirebaseHosting.v1beta1.Data.Release body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>
                    /// Creates a new release, which makes the content of the specified version actively display on the
                    /// appropriate URL(s).
                    /// </summary>
                    public class CreateRequest : FirebaseHostingBaseServiceRequest<Google.Apis.FirebaseHosting.v1beta1.Data.Release>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseHosting.v1beta1.Data.Release body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The site or channel to which the release belongs, in either of the following
                        /// formats: - sites/SITE_ID - sites/SITE_ID/channels/CHANNEL_ID
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        ///  The unique identifier for a version, in the format: sites/SITE_ID/versions/ VERSION_ID The
                        /// SITE_ID in this version identifier must match the SITE_ID in the `parent` parameter. This
                        /// query parameter must be empty if the `type` field in the request body is `SITE_DISABLE`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("versionName", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string VersionName { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.FirebaseHosting.v1beta1.Data.Release Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+parent}/releases";

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
                                Pattern = @"^projects/[^/]+/sites/[^/]+/channels/[^/]+$",
                            });
                            RequestParameters.Add("versionName", new Google.Apis.Discovery.Parameter
                            {
                                Name = "versionName",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>
                    /// Lists the releases that have been created for the specified site or channel. When used to list
                    /// releases for a site, this list includes releases for both the default `live` channel and any
                    /// active preview channels for the specified site.
                    /// </summary>
                    /// <param name="parent">
                    /// Required. The site or channel for which to list releases, in either of the following formats: -
                    /// sites/SITE_ID - sites/SITE_ID/channels/CHANNEL_ID
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>
                    /// Lists the releases that have been created for the specified site or channel. When used to list
                    /// releases for a site, this list includes releases for both the default `live` channel and any
                    /// active preview channels for the specified site.
                    /// </summary>
                    public class ListRequest : FirebaseHostingBaseServiceRequest<Google.Apis.FirebaseHosting.v1beta1.Data.ListReleasesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The site or channel for which to list releases, in either of the following
                        /// formats: - sites/SITE_ID - sites/SITE_ID/channels/CHANNEL_ID
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// The maximum number of releases to return. The service may return a lower number if fewer
                        /// releases exist than this maximum number. If unspecified, defaults to 100.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// A token from a previous call to `releases.list` or `channels.releases.list` that tells the
                        /// server where to resume listing.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+parent}/releases";

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
                                Pattern = @"^projects/[^/]+/sites/[^/]+/channels/[^/]+$",
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

                /// <summary>Creates a new channel in the specified site.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The site in which to create this channel, in the format: sites/ SITE_ID
                /// </param>
                public virtual CreateRequest Create(Google.Apis.FirebaseHosting.v1beta1.Data.Channel body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Creates a new channel in the specified site.</summary>
                public class CreateRequest : FirebaseHostingBaseServiceRequest<Google.Apis.FirebaseHosting.v1beta1.Data.Channel>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseHosting.v1beta1.Data.Channel body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The site in which to create this channel, in the format: sites/ SITE_ID
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Required. Immutable. A unique ID within the site that identifies the channel.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("channelId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ChannelId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.FirebaseHosting.v1beta1.Data.Channel Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/channels";

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
                            Pattern = @"^projects/[^/]+/sites/[^/]+$",
                        });
                        RequestParameters.Add("channelId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "channelId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Deletes the specified channel of the specified site. The `live` channel cannot be deleted.
                /// </summary>
                /// <param name="name">
                /// Required. The fully-qualified resource name for the channel, in the format:
                /// sites/SITE_ID/channels/CHANNEL_ID
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>
                /// Deletes the specified channel of the specified site. The `live` channel cannot be deleted.
                /// </summary>
                public class DeleteRequest : FirebaseHostingBaseServiceRequest<Google.Apis.FirebaseHosting.v1beta1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The fully-qualified resource name for the channel, in the format:
                    /// sites/SITE_ID/channels/CHANNEL_ID
                    /// </summary>
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
                            Pattern = @"^projects/[^/]+/sites/[^/]+/channels/[^/]+$",
                        });
                    }
                }

                /// <summary>Retrieves information for the specified channel of the specified site.</summary>
                /// <param name="name">
                /// Required. The fully-qualified resource name for the channel, in the format:
                /// sites/SITE_ID/channels/CHANNEL_ID
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Retrieves information for the specified channel of the specified site.</summary>
                public class GetRequest : FirebaseHostingBaseServiceRequest<Google.Apis.FirebaseHosting.v1beta1.Data.Channel>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The fully-qualified resource name for the channel, in the format:
                    /// sites/SITE_ID/channels/CHANNEL_ID
                    /// </summary>
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
                            Pattern = @"^projects/[^/]+/sites/[^/]+/channels/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists the channels for the specified site. All sites have a default `live` channel.
                /// </summary>
                /// <param name="parent">
                /// Required. The site for which to list channels, in the format: sites/SITE_ID
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>
                /// Lists the channels for the specified site. All sites have a default `live` channel.
                /// </summary>
                public class ListRequest : FirebaseHostingBaseServiceRequest<Google.Apis.FirebaseHosting.v1beta1.Data.ListChannelsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. The site for which to list channels, in the format: sites/SITE_ID</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// The maximum number of channels to return. The service may return a lower number if fewer
                    /// channels exist than this maximum number. If unspecified, defaults to 10. The maximum value is
                    /// 100; values above 100 will be coerced to 100.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A token from a previous call to `ListChannels` that tells the server where to resume listing.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/channels";

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
                            Pattern = @"^projects/[^/]+/sites/[^/]+$",
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
                /// Updates information for the specified channel of the specified site. Implicitly creates the channel
                /// if it doesn't already exist.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The fully-qualified resource name for the channel, in the format: sites/ SITE_ID/channels/CHANNEL_ID
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.FirebaseHosting.v1beta1.Data.Channel body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>
                /// Updates information for the specified channel of the specified site. Implicitly creates the channel
                /// if it doesn't already exist.
                /// </summary>
                public class PatchRequest : FirebaseHostingBaseServiceRequest<Google.Apis.FirebaseHosting.v1beta1.Data.Channel>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseHosting.v1beta1.Data.Channel body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The fully-qualified resource name for the channel, in the format: sites/
                    /// SITE_ID/channels/CHANNEL_ID
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>A comma-separated list of fields to be updated in this request.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.FirebaseHosting.v1beta1.Data.Channel Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/sites/[^/]+/channels/[^/]+$",
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

            /// <summary>Gets the Domains resource.</summary>
            public virtual DomainsResource Domains { get; }

            /// <summary>The "domains" collection of methods.</summary>
            public class DomainsResource
            {
                private const string Resource = "domains";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public DomainsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a domain mapping on the specified site.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent to create the domain association for, in the format: sites/site-name
                /// </param>
                public virtual CreateRequest Create(Google.Apis.FirebaseHosting.v1beta1.Data.Domain body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Creates a domain mapping on the specified site.</summary>
                public class CreateRequest : FirebaseHostingBaseServiceRequest<Google.Apis.FirebaseHosting.v1beta1.Data.Domain>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseHosting.v1beta1.Data.Domain body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent to create the domain association for, in the format: sites/site-name
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.FirebaseHosting.v1beta1.Data.Domain Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/domains";

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
                            Pattern = @"^projects/[^/]+/sites/[^/]+$",
                        });
                    }
                }

                /// <summary>Deletes the existing domain mapping on the specified site.</summary>
                /// <param name="name">Required. The name of the domain association to delete.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>Deletes the existing domain mapping on the specified site.</summary>
                public class DeleteRequest : FirebaseHostingBaseServiceRequest<Google.Apis.FirebaseHosting.v1beta1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the domain association to delete.</summary>
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
                            Pattern = @"^projects/[^/]+/sites/[^/]+/domains/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets a domain mapping on the specified site.</summary>
                /// <param name="name">Required. The name of the domain configuration to get.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Gets a domain mapping on the specified site.</summary>
                public class GetRequest : FirebaseHostingBaseServiceRequest<Google.Apis.FirebaseHosting.v1beta1.Data.Domain>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the domain configuration to get.</summary>
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
                            Pattern = @"^projects/[^/]+/sites/[^/]+/domains/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists the domains for the specified site.</summary>
                /// <param name="parent">
                /// Required. The parent for which to list domains, in the format: sites/ site-name
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists the domains for the specified site.</summary>
                public class ListRequest : FirebaseHostingBaseServiceRequest<Google.Apis.FirebaseHosting.v1beta1.Data.ListDomainsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent for which to list domains, in the format: sites/ site-name
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>The page size to return. Defaults to 50.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>The next_page_token from a previous request, if provided.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/domains";

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
                            Pattern = @"^projects/[^/]+/sites/[^/]+$",
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
                /// Updates the specified domain mapping, creating the mapping as if it does not exist.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The name of the domain association to update or create, if an association doesn't already
                /// exist.
                /// </param>
                public virtual UpdateRequest Update(Google.Apis.FirebaseHosting.v1beta1.Data.Domain body, string name)
                {
                    return new UpdateRequest(service, body, name);
                }

                /// <summary>
                /// Updates the specified domain mapping, creating the mapping as if it does not exist.
                /// </summary>
                public class UpdateRequest : FirebaseHostingBaseServiceRequest<Google.Apis.FirebaseHosting.v1beta1.Data.Domain>
                {
                    /// <summary>Constructs a new Update request.</summary>
                    public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseHosting.v1beta1.Data.Domain body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the domain association to update or create, if an association doesn't
                    /// already exist.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.FirebaseHosting.v1beta1.Data.Domain Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "update";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PUT";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+name}";

                    /// <summary>Initializes Update parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/sites/[^/]+/domains/[^/]+$",
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
                }

                /// <summary>
                /// Creates a new release, which makes the content of the specified version actively display on the
                /// appropriate URL(s).
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The site or channel to which the release belongs, in either of the following formats: -
                /// sites/SITE_ID - sites/SITE_ID/channels/CHANNEL_ID
                /// </param>
                public virtual CreateRequest Create(Google.Apis.FirebaseHosting.v1beta1.Data.Release body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>
                /// Creates a new release, which makes the content of the specified version actively display on the
                /// appropriate URL(s).
                /// </summary>
                public class CreateRequest : FirebaseHostingBaseServiceRequest<Google.Apis.FirebaseHosting.v1beta1.Data.Release>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseHosting.v1beta1.Data.Release body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The site or channel to which the release belongs, in either of the following formats:
                    /// - sites/SITE_ID - sites/SITE_ID/channels/CHANNEL_ID
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    ///  The unique identifier for a version, in the format: sites/SITE_ID/versions/ VERSION_ID The
                    /// SITE_ID in this version identifier must match the SITE_ID in the `parent` parameter. This query
                    /// parameter must be empty if the `type` field in the request body is `SITE_DISABLE`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("versionName", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string VersionName { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.FirebaseHosting.v1beta1.Data.Release Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/releases";

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
                            Pattern = @"^projects/[^/]+/sites/[^/]+$",
                        });
                        RequestParameters.Add("versionName", new Google.Apis.Discovery.Parameter
                        {
                            Name = "versionName",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Lists the releases that have been created for the specified site or channel. When used to list
                /// releases for a site, this list includes releases for both the default `live` channel and any active
                /// preview channels for the specified site.
                /// </summary>
                /// <param name="parent">
                /// Required. The site or channel for which to list releases, in either of the following formats: -
                /// sites/SITE_ID - sites/SITE_ID/channels/CHANNEL_ID
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>
                /// Lists the releases that have been created for the specified site or channel. When used to list
                /// releases for a site, this list includes releases for both the default `live` channel and any active
                /// preview channels for the specified site.
                /// </summary>
                public class ListRequest : FirebaseHostingBaseServiceRequest<Google.Apis.FirebaseHosting.v1beta1.Data.ListReleasesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The site or channel for which to list releases, in either of the following formats: -
                    /// sites/SITE_ID - sites/SITE_ID/channels/CHANNEL_ID
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// The maximum number of releases to return. The service may return a lower number if fewer
                    /// releases exist than this maximum number. If unspecified, defaults to 100.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A token from a previous call to `releases.list` or `channels.releases.list` that tells the
                    /// server where to resume listing.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/releases";

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
                            Pattern = @"^projects/[^/]+/sites/[^/]+$",
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

            /// <summary>Gets the Versions resource.</summary>
            public virtual VersionsResource Versions { get; }

            /// <summary>The "versions" collection of methods.</summary>
            public class VersionsResource
            {
                private const string Resource = "versions";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public VersionsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Files = new FilesResource(service);
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

                    /// <summary>Lists the remaining files to be uploaded for the specified version.</summary>
                    /// <param name="parent">
                    /// Required. The version for which to list files, in the format: sites/SITE_ID /versions/VERSION_ID
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Lists the remaining files to be uploaded for the specified version.</summary>
                    public class ListRequest : FirebaseHostingBaseServiceRequest<Google.Apis.FirebaseHosting.v1beta1.Data.ListVersionFilesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The version for which to list files, in the format: sites/SITE_ID
                        /// /versions/VERSION_ID
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// The maximum number of version files to return. The service may return a lower number if
                        /// fewer version files exist than this maximum number. If unspecified, defaults to 1000.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// A token from a previous call to `ListVersionFiles` that tells the server where to resume
                        /// listing.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary> The type of files that should be listed for the specified version.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("status", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<StatusEnum> Status { get; set; }

                        /// <summary> The type of files that should be listed for the specified version.</summary>
                        public enum StatusEnum
                        {
                            /// <summary>The default status; should not be intentionally used.</summary>
                            [Google.Apis.Util.StringValueAttribute("STATUS_UNSPECIFIED")]
                            STATUSUNSPECIFIED = 0,

                            /// <summary>
                            /// The file has been included in the version and is expected to be uploaded in the near
                            /// future.
                            /// </summary>
                            [Google.Apis.Util.StringValueAttribute("EXPECTED")]
                            EXPECTED = 1,

                            /// <summary>The file has already been uploaded to Firebase Hosting.</summary>
                            [Google.Apis.Util.StringValueAttribute("ACTIVE")]
                            ACTIVE = 2,
                        }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+parent}/files";

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
                                Pattern = @"^projects/[^/]+/sites/[^/]+/versions/[^/]+$",
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
                            RequestParameters.Add("status", new Google.Apis.Discovery.Parameter
                            {
                                Name = "status",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }
                }

                /// <summary>
                /// Creates a new version on the specified target site using the content of the specified version.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The target site for the cloned version, in the format: sites/ SITE_ID
                /// </param>
                public virtual CloneRequest Clone(Google.Apis.FirebaseHosting.v1beta1.Data.CloneVersionRequest body, string parent)
                {
                    return new CloneRequest(service, body, parent);
                }

                /// <summary>
                /// Creates a new version on the specified target site using the content of the specified version.
                /// </summary>
                public class CloneRequest : FirebaseHostingBaseServiceRequest<Google.Apis.FirebaseHosting.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new Clone request.</summary>
                    public CloneRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseHosting.v1beta1.Data.CloneVersionRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The target site for the cloned version, in the format: sites/ SITE_ID
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.FirebaseHosting.v1beta1.Data.CloneVersionRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "clone";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/versions:clone";

                    /// <summary>Initializes Clone parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/sites/[^/]+$",
                        });
                    }
                }

                /// <summary>Creates a new version for the specified site.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The site in which to create the version, in the format: sites/ SITE_ID
                /// </param>
                public virtual CreateRequest Create(Google.Apis.FirebaseHosting.v1beta1.Data.Version body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Creates a new version for the specified site.</summary>
                public class CreateRequest : FirebaseHostingBaseServiceRequest<Google.Apis.FirebaseHosting.v1beta1.Data.Version>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseHosting.v1beta1.Data.Version body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The site in which to create the version, in the format: sites/ SITE_ID
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// The self-reported size of the version. This value is used for a pre-emptive quota check for
                    /// legacy version uploads.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("sizeBytes", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<long> SizeBytes { get; set; }

                    /// <summary>
                    /// A unique id for the new version. This is was only specified for legacy version creations, and
                    /// should be blank.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("versionId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string VersionId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.FirebaseHosting.v1beta1.Data.Version Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/versions";

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
                            Pattern = @"^projects/[^/]+/sites/[^/]+$",
                        });
                        RequestParameters.Add("sizeBytes", new Google.Apis.Discovery.Parameter
                        {
                            Name = "sizeBytes",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("versionId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "versionId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes the specified version.</summary>
                /// <param name="name">
                /// Required. The fully-qualified resource name for the version, in the format:
                /// sites/SITE_ID/versions/VERSION_ID
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>Deletes the specified version.</summary>
                public class DeleteRequest : FirebaseHostingBaseServiceRequest<Google.Apis.FirebaseHosting.v1beta1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The fully-qualified resource name for the version, in the format:
                    /// sites/SITE_ID/versions/VERSION_ID
                    /// </summary>
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
                            Pattern = @"^projects/[^/]+/sites/[^/]+/versions/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists the versions that have been created for the specified site. This list includes versions for
                /// both the default `live` channel and any active preview channels for the specified site.
                /// </summary>
                /// <param name="parent">
                /// Required. The site or channel for which to list versions, in either of the following formats: -
                /// sites/SITE_ID - sites/SITE_ID/channels/CHANNEL_ID
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>
                /// Lists the versions that have been created for the specified site. This list includes versions for
                /// both the default `live` channel and any active preview channels for the specified site.
                /// </summary>
                public class ListRequest : FirebaseHostingBaseServiceRequest<Google.Apis.FirebaseHosting.v1beta1.Data.ListVersionsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The site or channel for which to list versions, in either of the following formats: -
                    /// sites/SITE_ID - sites/SITE_ID/channels/CHANNEL_ID
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// A filter string used to return a subset of versions in the response. The currently supported
                    /// fields for filtering are: `name`, `status`, and `create_time`. Learn more about filtering in
                    /// Google's [AIP 160 standard](https://google.aip.dev/160).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// The maximum number of versions to return. The service may return a lower number if fewer
                    /// versions exist than this maximum number. If unspecified, defaults to 25. The maximum value is
                    /// 100; values above 100 will be coerced to 100.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A token from a previous call to `ListVersions` that tells the server where to resume listing.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/versions";

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
                            Pattern = @"^projects/[^/]+/sites/[^/]+$",
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
                ///  Updates the specified metadata for the specified version. This method will fail with
                /// `FAILED_PRECONDITION` in the event of an invalid state transition. The supported
                /// [state](../sites.versions#versionstatus) transitions for a version are from `CREATED` to
                /// `FINALIZED`. Use [`DeleteVersion`](delete) to set the status of a version to `DELETED`.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The fully-qualified resource name for the version, in the format: sites/ SITE_ID/versions/VERSION_ID
                /// This name is provided in the response body when you call [`CreateVersion`](sites.versions/create).
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.FirebaseHosting.v1beta1.Data.Version body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>
                ///  Updates the specified metadata for the specified version. This method will fail with
                /// `FAILED_PRECONDITION` in the event of an invalid state transition. The supported
                /// [state](../sites.versions#versionstatus) transitions for a version are from `CREATED` to
                /// `FINALIZED`. Use [`DeleteVersion`](delete) to set the status of a version to `DELETED`.
                /// </summary>
                public class PatchRequest : FirebaseHostingBaseServiceRequest<Google.Apis.FirebaseHosting.v1beta1.Data.Version>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseHosting.v1beta1.Data.Version body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The fully-qualified resource name for the version, in the format: sites/
                    /// SITE_ID/versions/VERSION_ID This name is provided in the response body when you call
                    /// [`CreateVersion`](sites.versions/create).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// A set of field names from your [version](../sites.versions) that you want to update. A field
                    /// will be overwritten if, and only if, it's in the mask. If a mask is not provided then a default
                    /// mask of only [`status`](../sites.versions#Version.FIELDS.status) will be used.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.FirebaseHosting.v1beta1.Data.Version Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/sites/[^/]+/versions/[^/]+$",
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

                /// <summary> Adds content files to the specified version. Each file must be under 2 GB.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The version to which to add files, in the format: sites/SITE_ID /versions/VERSION_ID
                /// </param>
                public virtual PopulateFilesRequest PopulateFiles(Google.Apis.FirebaseHosting.v1beta1.Data.PopulateVersionFilesRequest body, string parent)
                {
                    return new PopulateFilesRequest(service, body, parent);
                }

                /// <summary> Adds content files to the specified version. Each file must be under 2 GB.</summary>
                public class PopulateFilesRequest : FirebaseHostingBaseServiceRequest<Google.Apis.FirebaseHosting.v1beta1.Data.PopulateVersionFilesResponse>
                {
                    /// <summary>Constructs a new PopulateFiles request.</summary>
                    public PopulateFilesRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseHosting.v1beta1.Data.PopulateVersionFilesRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The version to which to add files, in the format: sites/SITE_ID /versions/VERSION_ID
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.FirebaseHosting.v1beta1.Data.PopulateVersionFilesRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "populateFiles";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}:populateFiles";

                    /// <summary>Initializes PopulateFiles parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/sites/[^/]+/versions/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>
            /// Creates a new Hosting Site in the specified parent Firebase project. Note that Hosting sites can take
            /// several minutes to propagate through Firebase systems.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The Firebase project in which to create a Hosting site, in the format:
            /// projects/PROJECT_IDENTIFIER Refer to the `Site` [`name`](../projects#Site.FIELDS.name) field for details
            /// about PROJECT_IDENTIFIER values.
            /// </param>
            public virtual CreateRequest Create(Google.Apis.FirebaseHosting.v1beta1.Data.Site body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>
            /// Creates a new Hosting Site in the specified parent Firebase project. Note that Hosting sites can take
            /// several minutes to propagate through Firebase systems.
            /// </summary>
            public class CreateRequest : FirebaseHostingBaseServiceRequest<Google.Apis.FirebaseHosting.v1beta1.Data.Site>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseHosting.v1beta1.Data.Site body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The Firebase project in which to create a Hosting site, in the format:
                /// projects/PROJECT_IDENTIFIER Refer to the `Site` [`name`](../projects#Site.FIELDS.name) field for
                /// details about PROJECT_IDENTIFIER values.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Required. Immutable. A globally unique identifier for the Hosting site. This identifier is used to
                /// construct the Firebase-provisioned subdomains for the site, so it must also be a valid domain name
                /// label.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("siteId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string SiteId { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.FirebaseHosting.v1beta1.Data.Site Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+parent}/sites";

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
                    RequestParameters.Add("siteId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "siteId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Deletes the specified Hosting Site from the specified parent Firebase project.</summary>
            /// <param name="name">
            /// Required. The fully-qualified resource name for the Hosting site, in the format:
            /// projects/PROJECT_IDENTIFIER/sites/SITE_ID Refer to the `Site` [`name`](../projects#Site.FIELDS.name)
            /// field for details about PROJECT_IDENTIFIER values.
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>Deletes the specified Hosting Site from the specified parent Firebase project.</summary>
            public class DeleteRequest : FirebaseHostingBaseServiceRequest<Google.Apis.FirebaseHosting.v1beta1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The fully-qualified resource name for the Hosting site, in the format:
                /// projects/PROJECT_IDENTIFIER/sites/SITE_ID Refer to the `Site` [`name`](../projects#Site.FIELDS.name)
                /// field for details about PROJECT_IDENTIFIER values.
                /// </summary>
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
                        Pattern = @"^projects/[^/]+/sites/[^/]+$",
                    });
                }
            }

            /// <summary>Gets the specified Hosting Site.</summary>
            /// <param name="name">
            /// Required. The fully-qualified resource name for the Hosting site, in the format:
            /// projects/PROJECT_IDENTIFIER/sites/SITE_ID Refer to the `Site` [`name`](../projects#Site.FIELDS.name)
            /// field for details about PROJECT_IDENTIFIER values. Since a SITE_ID is a globally unique identifier, you
            /// can also use the unique sub-collection resource access pattern, in the format: projects/-/sites/SITE_ID
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets the specified Hosting Site.</summary>
            public class GetRequest : FirebaseHostingBaseServiceRequest<Google.Apis.FirebaseHosting.v1beta1.Data.Site>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The fully-qualified resource name for the Hosting site, in the format:
                /// projects/PROJECT_IDENTIFIER/sites/SITE_ID Refer to the `Site` [`name`](../projects#Site.FIELDS.name)
                /// field for details about PROJECT_IDENTIFIER values. Since a SITE_ID is a globally unique identifier,
                /// you can also use the unique sub-collection resource access pattern, in the format:
                /// projects/-/sites/SITE_ID
                /// </summary>
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
                        Pattern = @"^projects/[^/]+/sites/[^/]+$",
                    });
                }
            }

            /// <summary>Gets the Hosting metadata for a specific site.</summary>
            /// <param name="name">
            /// Required. The site for which to get the SiteConfig, in the format: sites/ site-name/config
            /// </param>
            public virtual GetConfigRequest GetConfig(string name)
            {
                return new GetConfigRequest(service, name);
            }

            /// <summary>Gets the Hosting metadata for a specific site.</summary>
            public class GetConfigRequest : FirebaseHostingBaseServiceRequest<Google.Apis.FirebaseHosting.v1beta1.Data.SiteConfig>
            {
                /// <summary>Constructs a new GetConfig request.</summary>
                public GetConfigRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The site for which to get the SiteConfig, in the format: sites/ site-name/config
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getConfig";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}";

                /// <summary>Initializes GetConfig parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/sites/[^/]+/config$",
                    });
                }
            }

            /// <summary>Lists each Hosting Site associated with the specified parent Firebase project.</summary>
            /// <param name="parent">
            /// Required. The Firebase project for which to list sites, in the format: projects/PROJECT_IDENTIFIER Refer
            /// to the `Site` [`name`](../projects#Site.FIELDS.name) field for details about PROJECT_IDENTIFIER values.
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists each Hosting Site associated with the specified parent Firebase project.</summary>
            public class ListRequest : FirebaseHostingBaseServiceRequest<Google.Apis.FirebaseHosting.v1beta1.Data.ListSitesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The Firebase project for which to list sites, in the format: projects/PROJECT_IDENTIFIER
                /// Refer to the `Site` [`name`](../projects#Site.FIELDS.name) field for details about
                /// PROJECT_IDENTIFIER values.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. The maximum number of sites to return. The service may return a lower number if fewer
                /// sites exist than this maximum number. If unspecified, defaults to 40.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. A token from a previous call to `ListSites` that tells the server where to resume listing.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+parent}/sites";

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

            /// <summary>Updates attributes of the specified Hosting Site.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Output only. The fully-qualified resource name of the Hosting site, in the format:
            /// projects/PROJECT_IDENTIFIER/sites/SITE_ID PROJECT_IDENTIFIER: the Firebase project's
            /// [`ProjectNumber`](https://firebase.google.com/docs/projects/api/reference/rest/v1beta1/projects#FirebaseProject.FIELDS.project_number)
            /// ***(recommended)*** or its
            /// [`ProjectId`](https://firebase.google.com/docs/projects/api/reference/rest/v1beta1/projects#FirebaseProject.FIELDS.project_id).
            /// Learn more about using project identifiers in Google's [AIP 2510
            /// standard](https://google.aip.dev/cloud/2510).
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.FirebaseHosting.v1beta1.Data.Site body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>Updates attributes of the specified Hosting Site.</summary>
            public class PatchRequest : FirebaseHostingBaseServiceRequest<Google.Apis.FirebaseHosting.v1beta1.Data.Site>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseHosting.v1beta1.Data.Site body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Output only. The fully-qualified resource name of the Hosting site, in the format:
                /// projects/PROJECT_IDENTIFIER/sites/SITE_ID PROJECT_IDENTIFIER: the Firebase project's
                /// [`ProjectNumber`](https://firebase.google.com/docs/projects/api/reference/rest/v1beta1/projects#FirebaseProject.FIELDS.project_number)
                /// ***(recommended)*** or its
                /// [`ProjectId`](https://firebase.google.com/docs/projects/api/reference/rest/v1beta1/projects#FirebaseProject.FIELDS.project_id).
                /// Learn more about using project identifiers in Google's [AIP 2510
                /// standard](https://google.aip.dev/cloud/2510).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>A set of field names from your Site that you want to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.FirebaseHosting.v1beta1.Data.Site Body { get; set; }

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
                        Pattern = @"^projects/[^/]+/sites/[^/]+$",
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

            /// <summary>Sets the Hosting metadata for a specific site.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The site for which to update the SiteConfig, in the format: sites/ site-name/config
            /// </param>
            public virtual UpdateConfigRequest UpdateConfig(Google.Apis.FirebaseHosting.v1beta1.Data.SiteConfig body, string name)
            {
                return new UpdateConfigRequest(service, body, name);
            }

            /// <summary>Sets the Hosting metadata for a specific site.</summary>
            public class UpdateConfigRequest : FirebaseHostingBaseServiceRequest<Google.Apis.FirebaseHosting.v1beta1.Data.SiteConfig>
            {
                /// <summary>Constructs a new UpdateConfig request.</summary>
                public UpdateConfigRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseHosting.v1beta1.Data.SiteConfig body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The site for which to update the SiteConfig, in the format: sites/ site-name/config
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// A set of field names from your [site configuration](../sites.SiteConfig) that you want to update. A
                /// field will be overwritten if, and only if, it's in the mask. If a mask is not provided then a
                /// default mask of only [`max_versions`](../sites.SiteConfig.max_versions) will be used.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.FirebaseHosting.v1beta1.Data.SiteConfig Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "updateConfig";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}";

                /// <summary>Initializes UpdateConfig parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/sites/[^/]+/config$",
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

    /// <summary>The "sites" collection of methods.</summary>
    public class SitesResource
    {
        private const string Resource = "sites";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public SitesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Channels = new ChannelsResource(service);
            Domains = new DomainsResource(service);
            Releases = new ReleasesResource(service);
            Versions = new VersionsResource(service);
        }

        /// <summary>Gets the Channels resource.</summary>
        public virtual ChannelsResource Channels { get; }

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
                }

                /// <summary>
                /// Creates a new release, which makes the content of the specified version actively display on the
                /// appropriate URL(s).
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The site or channel to which the release belongs, in either of the following formats: -
                /// sites/SITE_ID - sites/SITE_ID/channels/CHANNEL_ID
                /// </param>
                public virtual CreateRequest Create(Google.Apis.FirebaseHosting.v1beta1.Data.Release body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>
                /// Creates a new release, which makes the content of the specified version actively display on the
                /// appropriate URL(s).
                /// </summary>
                public class CreateRequest : FirebaseHostingBaseServiceRequest<Google.Apis.FirebaseHosting.v1beta1.Data.Release>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseHosting.v1beta1.Data.Release body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The site or channel to which the release belongs, in either of the following formats:
                    /// - sites/SITE_ID - sites/SITE_ID/channels/CHANNEL_ID
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    ///  The unique identifier for a version, in the format: sites/SITE_ID/versions/ VERSION_ID The
                    /// SITE_ID in this version identifier must match the SITE_ID in the `parent` parameter. This query
                    /// parameter must be empty if the `type` field in the request body is `SITE_DISABLE`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("versionName", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string VersionName { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.FirebaseHosting.v1beta1.Data.Release Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/releases";

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
                            Pattern = @"^sites/[^/]+/channels/[^/]+$",
                        });
                        RequestParameters.Add("versionName", new Google.Apis.Discovery.Parameter
                        {
                            Name = "versionName",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Lists the releases that have been created for the specified site or channel. When used to list
                /// releases for a site, this list includes releases for both the default `live` channel and any active
                /// preview channels for the specified site.
                /// </summary>
                /// <param name="parent">
                /// Required. The site or channel for which to list releases, in either of the following formats: -
                /// sites/SITE_ID - sites/SITE_ID/channels/CHANNEL_ID
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>
                /// Lists the releases that have been created for the specified site or channel. When used to list
                /// releases for a site, this list includes releases for both the default `live` channel and any active
                /// preview channels for the specified site.
                /// </summary>
                public class ListRequest : FirebaseHostingBaseServiceRequest<Google.Apis.FirebaseHosting.v1beta1.Data.ListReleasesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The site or channel for which to list releases, in either of the following formats: -
                    /// sites/SITE_ID - sites/SITE_ID/channels/CHANNEL_ID
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// The maximum number of releases to return. The service may return a lower number if fewer
                    /// releases exist than this maximum number. If unspecified, defaults to 100.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A token from a previous call to `releases.list` or `channels.releases.list` that tells the
                    /// server where to resume listing.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/releases";

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
                            Pattern = @"^sites/[^/]+/channels/[^/]+$",
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

            /// <summary>Creates a new channel in the specified site.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The site in which to create this channel, in the format: sites/ SITE_ID
            /// </param>
            public virtual CreateRequest Create(Google.Apis.FirebaseHosting.v1beta1.Data.Channel body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>Creates a new channel in the specified site.</summary>
            public class CreateRequest : FirebaseHostingBaseServiceRequest<Google.Apis.FirebaseHosting.v1beta1.Data.Channel>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseHosting.v1beta1.Data.Channel body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The site in which to create this channel, in the format: sites/ SITE_ID</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Required. Immutable. A unique ID within the site that identifies the channel.</summary>
                [Google.Apis.Util.RequestParameterAttribute("channelId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string ChannelId { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.FirebaseHosting.v1beta1.Data.Channel Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+parent}/channels";

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
                        Pattern = @"^sites/[^/]+$",
                    });
                    RequestParameters.Add("channelId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "channelId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Deletes the specified channel of the specified site. The `live` channel cannot be deleted.
            /// </summary>
            /// <param name="name">
            /// Required. The fully-qualified resource name for the channel, in the format:
            /// sites/SITE_ID/channels/CHANNEL_ID
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>
            /// Deletes the specified channel of the specified site. The `live` channel cannot be deleted.
            /// </summary>
            public class DeleteRequest : FirebaseHostingBaseServiceRequest<Google.Apis.FirebaseHosting.v1beta1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The fully-qualified resource name for the channel, in the format:
                /// sites/SITE_ID/channels/CHANNEL_ID
                /// </summary>
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
                        Pattern = @"^sites/[^/]+/channels/[^/]+$",
                    });
                }
            }

            /// <summary>Retrieves information for the specified channel of the specified site.</summary>
            /// <param name="name">
            /// Required. The fully-qualified resource name for the channel, in the format:
            /// sites/SITE_ID/channels/CHANNEL_ID
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Retrieves information for the specified channel of the specified site.</summary>
            public class GetRequest : FirebaseHostingBaseServiceRequest<Google.Apis.FirebaseHosting.v1beta1.Data.Channel>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The fully-qualified resource name for the channel, in the format:
                /// sites/SITE_ID/channels/CHANNEL_ID
                /// </summary>
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
                        Pattern = @"^sites/[^/]+/channels/[^/]+$",
                    });
                }
            }

            /// <summary>Lists the channels for the specified site. All sites have a default `live` channel.</summary>
            /// <param name="parent">Required. The site for which to list channels, in the format: sites/SITE_ID</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists the channels for the specified site. All sites have a default `live` channel.</summary>
            public class ListRequest : FirebaseHostingBaseServiceRequest<Google.Apis.FirebaseHosting.v1beta1.Data.ListChannelsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. The site for which to list channels, in the format: sites/SITE_ID</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The maximum number of channels to return. The service may return a lower number if fewer channels
                /// exist than this maximum number. If unspecified, defaults to 10. The maximum value is 100; values
                /// above 100 will be coerced to 100.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A token from a previous call to `ListChannels` that tells the server where to resume listing.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+parent}/channels";

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
                        Pattern = @"^sites/[^/]+$",
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
            /// Updates information for the specified channel of the specified site. Implicitly creates the channel if
            /// it doesn't already exist.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// The fully-qualified resource name for the channel, in the format: sites/ SITE_ID/channels/CHANNEL_ID
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.FirebaseHosting.v1beta1.Data.Channel body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>
            /// Updates information for the specified channel of the specified site. Implicitly creates the channel if
            /// it doesn't already exist.
            /// </summary>
            public class PatchRequest : FirebaseHostingBaseServiceRequest<Google.Apis.FirebaseHosting.v1beta1.Data.Channel>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseHosting.v1beta1.Data.Channel body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The fully-qualified resource name for the channel, in the format: sites/ SITE_ID/channels/CHANNEL_ID
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>A comma-separated list of fields to be updated in this request.</summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.FirebaseHosting.v1beta1.Data.Channel Body { get; set; }

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
                        Pattern = @"^sites/[^/]+/channels/[^/]+$",
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

        /// <summary>Gets the Domains resource.</summary>
        public virtual DomainsResource Domains { get; }

        /// <summary>The "domains" collection of methods.</summary>
        public class DomainsResource
        {
            private const string Resource = "domains";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public DomainsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Creates a domain mapping on the specified site.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The parent to create the domain association for, in the format: sites/site-name
            /// </param>
            public virtual CreateRequest Create(Google.Apis.FirebaseHosting.v1beta1.Data.Domain body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>Creates a domain mapping on the specified site.</summary>
            public class CreateRequest : FirebaseHostingBaseServiceRequest<Google.Apis.FirebaseHosting.v1beta1.Data.Domain>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseHosting.v1beta1.Data.Domain body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent to create the domain association for, in the format: sites/site-name
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.FirebaseHosting.v1beta1.Data.Domain Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+parent}/domains";

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
                        Pattern = @"^sites/[^/]+$",
                    });
                }
            }

            /// <summary>Deletes the existing domain mapping on the specified site.</summary>
            /// <param name="name">Required. The name of the domain association to delete.</param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>Deletes the existing domain mapping on the specified site.</summary>
            public class DeleteRequest : FirebaseHostingBaseServiceRequest<Google.Apis.FirebaseHosting.v1beta1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. The name of the domain association to delete.</summary>
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
                        Pattern = @"^sites/[^/]+/domains/[^/]+$",
                    });
                }
            }

            /// <summary>Gets a domain mapping on the specified site.</summary>
            /// <param name="name">Required. The name of the domain configuration to get.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets a domain mapping on the specified site.</summary>
            public class GetRequest : FirebaseHostingBaseServiceRequest<Google.Apis.FirebaseHosting.v1beta1.Data.Domain>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. The name of the domain configuration to get.</summary>
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
                        Pattern = @"^sites/[^/]+/domains/[^/]+$",
                    });
                }
            }

            /// <summary>Lists the domains for the specified site.</summary>
            /// <param name="parent">
            /// Required. The parent for which to list domains, in the format: sites/ site-name
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists the domains for the specified site.</summary>
            public class ListRequest : FirebaseHostingBaseServiceRequest<Google.Apis.FirebaseHosting.v1beta1.Data.ListDomainsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. The parent for which to list domains, in the format: sites/ site-name</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>The page size to return. Defaults to 50.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>The next_page_token from a previous request, if provided.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+parent}/domains";

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
                        Pattern = @"^sites/[^/]+$",
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

            /// <summary>Updates the specified domain mapping, creating the mapping as if it does not exist.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The name of the domain association to update or create, if an association doesn't already
            /// exist.
            /// </param>
            public virtual UpdateRequest Update(Google.Apis.FirebaseHosting.v1beta1.Data.Domain body, string name)
            {
                return new UpdateRequest(service, body, name);
            }

            /// <summary>Updates the specified domain mapping, creating the mapping as if it does not exist.</summary>
            public class UpdateRequest : FirebaseHostingBaseServiceRequest<Google.Apis.FirebaseHosting.v1beta1.Data.Domain>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseHosting.v1beta1.Data.Domain body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the domain association to update or create, if an association doesn't already
                /// exist.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.FirebaseHosting.v1beta1.Data.Domain Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "update";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}";

                /// <summary>Initializes Update parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^sites/[^/]+/domains/[^/]+$",
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
            }

            /// <summary>
            /// Creates a new release, which makes the content of the specified version actively display on the
            /// appropriate URL(s).
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The site or channel to which the release belongs, in either of the following formats: -
            /// sites/SITE_ID - sites/SITE_ID/channels/CHANNEL_ID
            /// </param>
            public virtual CreateRequest Create(Google.Apis.FirebaseHosting.v1beta1.Data.Release body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>
            /// Creates a new release, which makes the content of the specified version actively display on the
            /// appropriate URL(s).
            /// </summary>
            public class CreateRequest : FirebaseHostingBaseServiceRequest<Google.Apis.FirebaseHosting.v1beta1.Data.Release>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseHosting.v1beta1.Data.Release body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The site or channel to which the release belongs, in either of the following formats: -
                /// sites/SITE_ID - sites/SITE_ID/channels/CHANNEL_ID
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                ///  The unique identifier for a version, in the format: sites/SITE_ID/versions/ VERSION_ID The SITE_ID
                /// in this version identifier must match the SITE_ID in the `parent` parameter. This query parameter
                /// must be empty if the `type` field in the request body is `SITE_DISABLE`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("versionName", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string VersionName { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.FirebaseHosting.v1beta1.Data.Release Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+parent}/releases";

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
                        Pattern = @"^sites/[^/]+$",
                    });
                    RequestParameters.Add("versionName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "versionName",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Lists the releases that have been created for the specified site or channel. When used to list releases
            /// for a site, this list includes releases for both the default `live` channel and any active preview
            /// channels for the specified site.
            /// </summary>
            /// <param name="parent">
            /// Required. The site or channel for which to list releases, in either of the following formats: -
            /// sites/SITE_ID - sites/SITE_ID/channels/CHANNEL_ID
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>
            /// Lists the releases that have been created for the specified site or channel. When used to list releases
            /// for a site, this list includes releases for both the default `live` channel and any active preview
            /// channels for the specified site.
            /// </summary>
            public class ListRequest : FirebaseHostingBaseServiceRequest<Google.Apis.FirebaseHosting.v1beta1.Data.ListReleasesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The site or channel for which to list releases, in either of the following formats: -
                /// sites/SITE_ID - sites/SITE_ID/channels/CHANNEL_ID
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The maximum number of releases to return. The service may return a lower number if fewer releases
                /// exist than this maximum number. If unspecified, defaults to 100.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A token from a previous call to `releases.list` or `channels.releases.list` that tells the server
                /// where to resume listing.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+parent}/releases";

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
                        Pattern = @"^sites/[^/]+$",
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

        /// <summary>Gets the Versions resource.</summary>
        public virtual VersionsResource Versions { get; }

        /// <summary>The "versions" collection of methods.</summary>
        public class VersionsResource
        {
            private const string Resource = "versions";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public VersionsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Files = new FilesResource(service);
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

                /// <summary>Lists the remaining files to be uploaded for the specified version.</summary>
                /// <param name="parent">
                /// Required. The version for which to list files, in the format: sites/SITE_ID /versions/VERSION_ID
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists the remaining files to be uploaded for the specified version.</summary>
                public class ListRequest : FirebaseHostingBaseServiceRequest<Google.Apis.FirebaseHosting.v1beta1.Data.ListVersionFilesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The version for which to list files, in the format: sites/SITE_ID /versions/VERSION_ID
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// The maximum number of version files to return. The service may return a lower number if fewer
                    /// version files exist than this maximum number. If unspecified, defaults to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A token from a previous call to `ListVersionFiles` that tells the server where to resume
                    /// listing.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary> The type of files that should be listed for the specified version.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("status", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<StatusEnum> Status { get; set; }

                    /// <summary> The type of files that should be listed for the specified version.</summary>
                    public enum StatusEnum
                    {
                        /// <summary>The default status; should not be intentionally used.</summary>
                        [Google.Apis.Util.StringValueAttribute("STATUS_UNSPECIFIED")]
                        STATUSUNSPECIFIED = 0,

                        /// <summary>
                        /// The file has been included in the version and is expected to be uploaded in the near future.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("EXPECTED")]
                        EXPECTED = 1,

                        /// <summary>The file has already been uploaded to Firebase Hosting.</summary>
                        [Google.Apis.Util.StringValueAttribute("ACTIVE")]
                        ACTIVE = 2,
                    }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/files";

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
                            Pattern = @"^sites/[^/]+/versions/[^/]+$",
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
                        RequestParameters.Add("status", new Google.Apis.Discovery.Parameter
                        {
                            Name = "status",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
            }

            /// <summary>
            /// Creates a new version on the specified target site using the content of the specified version.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The target site for the cloned version, in the format: sites/ SITE_ID
            /// </param>
            public virtual CloneRequest Clone(Google.Apis.FirebaseHosting.v1beta1.Data.CloneVersionRequest body, string parent)
            {
                return new CloneRequest(service, body, parent);
            }

            /// <summary>
            /// Creates a new version on the specified target site using the content of the specified version.
            /// </summary>
            public class CloneRequest : FirebaseHostingBaseServiceRequest<Google.Apis.FirebaseHosting.v1beta1.Data.Operation>
            {
                /// <summary>Constructs a new Clone request.</summary>
                public CloneRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseHosting.v1beta1.Data.CloneVersionRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The target site for the cloned version, in the format: sites/ SITE_ID</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.FirebaseHosting.v1beta1.Data.CloneVersionRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "clone";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+parent}/versions:clone";

                /// <summary>Initializes Clone parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^sites/[^/]+$",
                    });
                }
            }

            /// <summary>Creates a new version for the specified site.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The site in which to create the version, in the format: sites/ SITE_ID
            /// </param>
            public virtual CreateRequest Create(Google.Apis.FirebaseHosting.v1beta1.Data.Version body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>Creates a new version for the specified site.</summary>
            public class CreateRequest : FirebaseHostingBaseServiceRequest<Google.Apis.FirebaseHosting.v1beta1.Data.Version>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseHosting.v1beta1.Data.Version body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The site in which to create the version, in the format: sites/ SITE_ID</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The self-reported size of the version. This value is used for a pre-emptive quota check for legacy
                /// version uploads.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("sizeBytes", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<long> SizeBytes { get; set; }

                /// <summary>
                /// A unique id for the new version. This is was only specified for legacy version creations, and should
                /// be blank.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("versionId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string VersionId { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.FirebaseHosting.v1beta1.Data.Version Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+parent}/versions";

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
                        Pattern = @"^sites/[^/]+$",
                    });
                    RequestParameters.Add("sizeBytes", new Google.Apis.Discovery.Parameter
                    {
                        Name = "sizeBytes",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("versionId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "versionId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Deletes the specified version.</summary>
            /// <param name="name">
            /// Required. The fully-qualified resource name for the version, in the format:
            /// sites/SITE_ID/versions/VERSION_ID
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>Deletes the specified version.</summary>
            public class DeleteRequest : FirebaseHostingBaseServiceRequest<Google.Apis.FirebaseHosting.v1beta1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The fully-qualified resource name for the version, in the format:
                /// sites/SITE_ID/versions/VERSION_ID
                /// </summary>
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
                        Pattern = @"^sites/[^/]+/versions/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Lists the versions that have been created for the specified site. This list includes versions for both
            /// the default `live` channel and any active preview channels for the specified site.
            /// </summary>
            /// <param name="parent">
            /// Required. The site or channel for which to list versions, in either of the following formats: -
            /// sites/SITE_ID - sites/SITE_ID/channels/CHANNEL_ID
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>
            /// Lists the versions that have been created for the specified site. This list includes versions for both
            /// the default `live` channel and any active preview channels for the specified site.
            /// </summary>
            public class ListRequest : FirebaseHostingBaseServiceRequest<Google.Apis.FirebaseHosting.v1beta1.Data.ListVersionsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The site or channel for which to list versions, in either of the following formats: -
                /// sites/SITE_ID - sites/SITE_ID/channels/CHANNEL_ID
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// A filter string used to return a subset of versions in the response. The currently supported fields
                /// for filtering are: `name`, `status`, and `create_time`. Learn more about filtering in Google's [AIP
                /// 160 standard](https://google.aip.dev/160).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// The maximum number of versions to return. The service may return a lower number if fewer versions
                /// exist than this maximum number. If unspecified, defaults to 25. The maximum value is 100; values
                /// above 100 will be coerced to 100.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A token from a previous call to `ListVersions` that tells the server where to resume listing.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+parent}/versions";

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
                        Pattern = @"^sites/[^/]+$",
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
            ///  Updates the specified metadata for the specified version. This method will fail with
            /// `FAILED_PRECONDITION` in the event of an invalid state transition. The supported
            /// [state](../sites.versions#versionstatus) transitions for a version are from `CREATED` to `FINALIZED`.
            /// Use [`DeleteVersion`](delete) to set the status of a version to `DELETED`.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// The fully-qualified resource name for the version, in the format: sites/ SITE_ID/versions/VERSION_ID
            /// This name is provided in the response body when you call [`CreateVersion`](sites.versions/create).
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.FirebaseHosting.v1beta1.Data.Version body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>
            ///  Updates the specified metadata for the specified version. This method will fail with
            /// `FAILED_PRECONDITION` in the event of an invalid state transition. The supported
            /// [state](../sites.versions#versionstatus) transitions for a version are from `CREATED` to `FINALIZED`.
            /// Use [`DeleteVersion`](delete) to set the status of a version to `DELETED`.
            /// </summary>
            public class PatchRequest : FirebaseHostingBaseServiceRequest<Google.Apis.FirebaseHosting.v1beta1.Data.Version>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseHosting.v1beta1.Data.Version body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The fully-qualified resource name for the version, in the format: sites/ SITE_ID/versions/VERSION_ID
                /// This name is provided in the response body when you call [`CreateVersion`](sites.versions/create).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// A set of field names from your [version](../sites.versions) that you want to update. A field will be
                /// overwritten if, and only if, it's in the mask. If a mask is not provided then a default mask of only
                /// [`status`](../sites.versions#Version.FIELDS.status) will be used.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.FirebaseHosting.v1beta1.Data.Version Body { get; set; }

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
                        Pattern = @"^sites/[^/]+/versions/[^/]+$",
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

            /// <summary> Adds content files to the specified version. Each file must be under 2 GB.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The version to which to add files, in the format: sites/SITE_ID /versions/VERSION_ID
            /// </param>
            public virtual PopulateFilesRequest PopulateFiles(Google.Apis.FirebaseHosting.v1beta1.Data.PopulateVersionFilesRequest body, string parent)
            {
                return new PopulateFilesRequest(service, body, parent);
            }

            /// <summary> Adds content files to the specified version. Each file must be under 2 GB.</summary>
            public class PopulateFilesRequest : FirebaseHostingBaseServiceRequest<Google.Apis.FirebaseHosting.v1beta1.Data.PopulateVersionFilesResponse>
            {
                /// <summary>Constructs a new PopulateFiles request.</summary>
                public PopulateFilesRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseHosting.v1beta1.Data.PopulateVersionFilesRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The version to which to add files, in the format: sites/SITE_ID /versions/VERSION_ID
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.FirebaseHosting.v1beta1.Data.PopulateVersionFilesRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "populateFiles";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+parent}:populateFiles";

                /// <summary>Initializes PopulateFiles parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^sites/[^/]+/versions/[^/]+$",
                    });
                }
            }
        }

        /// <summary>Gets the Hosting metadata for a specific site.</summary>
        /// <param name="name">
        /// Required. The site for which to get the SiteConfig, in the format: sites/ site-name/config
        /// </param>
        public virtual GetConfigRequest GetConfig(string name)
        {
            return new GetConfigRequest(service, name);
        }

        /// <summary>Gets the Hosting metadata for a specific site.</summary>
        public class GetConfigRequest : FirebaseHostingBaseServiceRequest<Google.Apis.FirebaseHosting.v1beta1.Data.SiteConfig>
        {
            /// <summary>Constructs a new GetConfig request.</summary>
            public GetConfigRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The site for which to get the SiteConfig, in the format: sites/ site-name/config
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getConfig";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta1/{+name}";

            /// <summary>Initializes GetConfig parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^sites/[^/]+/config$",
                });
            }
        }

        /// <summary>Sets the Hosting metadata for a specific site.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// Required. The site for which to update the SiteConfig, in the format: sites/ site-name/config
        /// </param>
        public virtual UpdateConfigRequest UpdateConfig(Google.Apis.FirebaseHosting.v1beta1.Data.SiteConfig body, string name)
        {
            return new UpdateConfigRequest(service, body, name);
        }

        /// <summary>Sets the Hosting metadata for a specific site.</summary>
        public class UpdateConfigRequest : FirebaseHostingBaseServiceRequest<Google.Apis.FirebaseHosting.v1beta1.Data.SiteConfig>
        {
            /// <summary>Constructs a new UpdateConfig request.</summary>
            public UpdateConfigRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseHosting.v1beta1.Data.SiteConfig body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. The site for which to update the SiteConfig, in the format: sites/ site-name/config
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>
            /// A set of field names from your [site configuration](../sites.SiteConfig) that you want to update. A
            /// field will be overwritten if, and only if, it's in the mask. If a mask is not provided then a default
            /// mask of only [`max_versions`](../sites.SiteConfig.max_versions) will be used.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.FirebaseHosting.v1beta1.Data.SiteConfig Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateConfig";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta1/{+name}";

            /// <summary>Initializes UpdateConfig parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^sites/[^/]+/config$",
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
namespace Google.Apis.FirebaseHosting.v1beta1.Data
{
    /// <summary>
    /// Contains metadata about the user who performed an action, such as creating a release or finalizing a version.
    /// </summary>
    public class ActingUser : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The email address of the user when the user performed the action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>
        /// A profile image URL for the user. May not be present if the user has changed their email address or deleted
        /// their account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageUrl")]
        public virtual string ImageUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a DNS certificate challenge.</summary>
    public class CertDnsChallenge : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The domain name upon which the DNS challenge must be satisfied.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domainName")]
        public virtual string DomainName { get; set; }

        /// <summary>
        /// The value that must be present as a TXT record on the domain name to satisfy the challenge.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("token")]
        public virtual string Token { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an HTTP certificate challenge.</summary>
    public class CertHttpChallenge : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The URL path on which to serve the specified token to satisfy the certificate challenge.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>The token to serve at the specified URL path to satisfy the certificate challenge.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("token")]
        public virtual string Token { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A `Channel` represents a stream of releases for a site. All sites have a default `live` channel that serves
    /// content to the Firebase-provided subdomains and any connected custom domains.
    /// </summary>
    public class Channel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The time at which the channel was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// The time at which the channel will be automatically deleted. If null, the channel will not be automatically
        /// deleted. This field is present in the output whether it's set directly or via the `ttl` field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expireTime")]
        public virtual object ExpireTime { get; set; }

        /// <summary>Text labels used for extra metadata and/or filtering.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// The fully-qualified resource name for the channel, in the format: sites/ SITE_ID/channels/CHANNEL_ID
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The current release for the channel, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("release")]
        public virtual Release Release { get; set; }

        /// <summary>
        /// The number of previous releases to retain on the channel for rollback or other purposes. Must be a number
        /// between 1-100. Defaults to 10 for new channels.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retainedReleaseCount")]
        public virtual System.Nullable<int> RetainedReleaseCount { get; set; }

        /// <summary>
        /// Input only. A time-to-live for this channel. Sets `expire_time` to the provided duration past the time of
        /// the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ttl")]
        public virtual object Ttl { get; set; }

        /// <summary>Output only. The time at which the channel was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>
        /// Output only. The URL at which the content of this channel's current release can be viewed. This URL is a
        /// Firebase-provided subdomain of `web.app`. The content of this channel's current release can also be viewed
        /// at the Firebase-provided subdomain of `firebaseapp.com`. If this channel is the `live` channel for the
        /// Hosting site, then the content of this channel's current release can also be viewed at any connected custom
        /// domains.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class CloneVersionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If provided, only paths that do not match any of the RegEx values in this list will be included in the new
        /// version.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exclude")]
        public virtual PathFilter Exclude { get; set; }

        /// <summary>
        /// If true, the call to `CloneVersion` immediately finalizes the version after cloning is complete. If false,
        /// the cloned version will have a status of `CREATED`. Use [`UpdateVersion`](patch) to set the status of the
        /// version to `FINALIZED`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finalize")]
        public virtual System.Nullable<bool> Finalize { get; set; }

        /// <summary>
        /// If provided, only paths that match one or more RegEx values in this list will be included in the new
        /// version.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("include")]
        public virtual PathFilter Include { get; set; }

        /// <summary>
        /// Required. The unique identifier for the version to be cloned, in the format:
        /// sites/SITE_ID/versions/VERSION_ID
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceVersion")]
        public virtual string SourceVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A configured rewrite that directs requests to a Cloud Run service. If the Cloud Run service does not exist when
    /// setting or updating your Firebase Hosting configuration, then the request fails. Any errors from the Cloud Run
    /// service are passed to the end user (for example, if you delete a service, any requests directed to that service
    /// receive a `404` error).
    /// </summary>
    public class CloudRunRewrite : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. User-provided region where the Cloud Run service is hosted. Defaults to `us-central1` if not
        /// supplied.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual string Region { get; set; }

        /// <summary>Required. User-defined ID of the Cloud Run service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceId")]
        public virtual string ServiceId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The intended behavior and status information of a domain.</summary>
    public class Domain : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The domain name of the association.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domainName")]
        public virtual string DomainName { get; set; }

        /// <summary>If set, the domain should redirect with the provided parameters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domainRedirect")]
        public virtual DomainRedirect DomainRedirect { get; set; }

        /// <summary>
        /// Output only. Information about the provisioning of certificates and the health of the DNS resolution for the
        /// domain.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provisioning")]
        public virtual DomainProvisioning Provisioning { get; set; }

        /// <summary>Required. The site name of the association.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("site")]
        public virtual string Site { get; set; }

        /// <summary>Output only. Additional status of the domain association.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>Output only. The time at which the domain was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The current certificate provisioning status information for a domain.</summary>
    public class DomainProvisioning : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The TXT records (for the certificate challenge) that were found at the last DNS fetch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certChallengeDiscoveredTxt")]
        public virtual System.Collections.Generic.IList<string> CertChallengeDiscoveredTxt { get; set; }

        /// <summary>The DNS challenge for generating a certificate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certChallengeDns")]
        public virtual CertDnsChallenge CertChallengeDns { get; set; }

        /// <summary>The HTTP challenge for generating a certificate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certChallengeHttp")]
        public virtual CertHttpChallenge CertChallengeHttp { get; set; }

        /// <summary>
        /// The certificate provisioning status; updated when Firebase Hosting provisions an SSL certificate for the
        /// domain.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certStatus")]
        public virtual string CertStatus { get; set; }

        /// <summary>The IPs found at the last DNS fetch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("discoveredIps")]
        public virtual System.Collections.Generic.IList<string> DiscoveredIps { get; set; }

        /// <summary>The time at which the last DNS fetch occurred.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dnsFetchTime")]
        public virtual object DnsFetchTime { get; set; }

        /// <summary>The DNS record match status as of the last DNS fetch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dnsStatus")]
        public virtual string DnsStatus { get; set; }

        /// <summary>The list of IPs to which the domain is expected to resolve.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expectedIps")]
        public virtual System.Collections.Generic.IList<string> ExpectedIps { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Defines the behavior of a domain-level redirect. Domain redirects preserve the path of the redirect but replace
    /// the requested domain with the one specified in the redirect configuration.
    /// </summary>
    public class DomainRedirect : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The domain name to redirect to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domainName")]
        public virtual string DomainName { get; set; }

        /// <summary>Required. The redirect status code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

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

    /// <summary>
    /// A [`Header`](https://firebase.google.com/docs/hosting/full-config#headers) specifies a URL pattern that, if
    /// matched to the request URL path, triggers Hosting to apply the specified custom response headers.
    /// </summary>
    public class Header : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The user-supplied [glob](https://firebase.google.com/docs/hosting/full-config#glob_pattern_matching) to
        /// match against the request URL path.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("glob")]
        public virtual string Glob { get; set; }

        /// <summary>Required. The additional headers to add to the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headers")]
        public virtual System.Collections.Generic.IDictionary<string, string> Headers { get; set; }

        /// <summary>The user-supplied RE2 regular expression to match against the request URL path.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regex")]
        public virtual string Regex { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>If provided, i18n rewrites are enabled.</summary>
    public class I18nConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The user-supplied path where country and language specific content will be looked for within the
        /// public directory.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("root")]
        public virtual string Root { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ListChannelsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of channels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channels")]
        public virtual System.Collections.Generic.IList<Channel> Channels { get; set; }

        /// <summary>
        /// The pagination token, if more results exist beyond the ones in this response. Include this token in your
        /// next call to `ListChannels`. Page tokens are short-lived and should not be stored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response to listing Domains.</summary>
    public class ListDomainsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of domains, if any exist.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domains")]
        public virtual System.Collections.Generic.IList<Domain> Domains { get; set; }

        /// <summary>The pagination token, if more results exist.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ListReleasesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The pagination token, if more results exist beyond the ones in this response. Include this token in your
        /// next call to `ListReleases`. Page tokens are short-lived and should not be stored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of hashes of files that still need to be uploaded, if any exist.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("releases")]
        public virtual System.Collections.Generic.IList<Release> Releases { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ListSitesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The pagination token, if more results exist beyond the ones in this response. Include this token in your
        /// next call to `ListSites`. Page tokens are short-lived and should not be stored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A list of Site objects associated with the specified Firebase project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sites")]
        public virtual System.Collections.Generic.IList<Site> Sites { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ListVersionFilesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary> The list of paths to the hashes of the files in the specified version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("files")]
        public virtual System.Collections.Generic.IList<VersionFile> Files { get; set; }

        /// <summary>
        /// The pagination token, if more results exist beyond the ones in this response. Include this token in your
        /// next call to `ListVersionFiles`. Page tokens are short-lived and should not be stored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ListVersionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The pagination token, if more results exist beyond the ones in this response. Include this token in your
        /// next call to `ListVersions`. Page tokens are short-lived and should not be stored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of versions, if any exist.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versions")]
        public virtual System.Collections.Generic.IList<Version> Versions { get; set; }

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

    /// <summary>A representation of filter path.</summary>
    public class PathFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An array of RegEx values by which to filter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regexes")]
        public virtual System.Collections.Generic.IList<string> Regexes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class PopulateVersionFilesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A set of file paths to the hashes corresponding to assets that should be added to the version. A file path
        /// to an empty hash will remove the path from the version. Calculate a hash by Gzipping the file then taking
        /// the SHA256 hash of the newly compressed file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("files")]
        public virtual System.Collections.Generic.IDictionary<string, string> Files { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class PopulateVersionFilesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The content hashes of the specified files that need to be uploaded to the specified URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uploadRequiredHashes")]
        public virtual System.Collections.Generic.IList<string> UploadRequiredHashes { get; set; }

        /// <summary>
        /// The URL to which the files should be uploaded, in the format:
        /// "https://upload-firebasehosting.googleapis.com/upload/sites/SITE_ID /versions/VERSION_ID/files" Perform a
        /// multipart `POST` of the Gzipped file contents to the URL using a forward slash and the hash of the file
        /// appended to the end.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uploadUrl")]
        public virtual string UploadUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A [`Redirect`](https://firebase.google.com/docs/hosting/full-config#redirects) specifies a URL pattern that, if
    /// matched to the request URL path, triggers Hosting to respond with a redirect to the specified destination path.
    /// </summary>
    public class Redirect : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The user-supplied [glob](https://firebase.google.com/docs/hosting/full-config#glob_pattern_matching) to
        /// match against the request URL path.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("glob")]
        public virtual string Glob { get; set; }

        /// <summary>
        /// Required. The value to put in the HTTP location header of the response. The location can contain capture
        /// group values from the pattern using a `:` prefix to identify the segment and an optional `*` to capture the
        /// rest of the URL. For example: "glob": "/:capture*", "statusCode": 301, "location":
        /// "https://example.com/foo/:capture"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>The user-supplied RE2 regular expression to match against the request URL path.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regex")]
        public virtual string Regex { get; set; }

        /// <summary>
        /// Required. The status HTTP code to return in the response. It must be a valid 3xx status code.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusCode")]
        public virtual System.Nullable<int> StatusCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    ///  A `Release` is a particular [collection of configurations and files](sites.versions) that is set to be public
    /// at a particular time.
    /// </summary>
    public class Release : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The deploy description when the release was created. The value can be up to 512 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>
        /// Output only. The unique identifier for the release, in either of the following formats: -
        /// sites/SITE_ID/releases/RELEASE_ID - sites/SITE_ID/channels/CHANNEL_ID/releases/RELEASE_ID This name is
        /// provided in the response body when you call [`releases.create`](sites.releases/create) or
        /// [`channels.releases.create`](sites.channels.releases/create).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The time at which the version is set to be public.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("releaseTime")]
        public virtual object ReleaseTime { get; set; }

        /// <summary>Output only. Identifies the user who created the release.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("releaseUser")]
        public virtual ActingUser ReleaseUser { get; set; }

        /// <summary>
        /// Explains the reason for the release. Specify a value for this field only when creating a `SITE_DISABLE` type
        /// release.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>Output only. The configuration and content that was released.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual Version Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A [`Rewrite`](https://firebase.google.com/docs/hosting/full-config#rewrites) specifies a URL pattern that, if
    /// matched to the request URL path, triggers Hosting to respond as if the service were given the specified
    /// destination URL.
    /// </summary>
    public class Rewrite : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The request will be forwarded to Firebase Dynamic Links.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dynamicLinks")]
        public virtual System.Nullable<bool> DynamicLinks { get; set; }

        /// <summary>The function to proxy requests to. Must match the exported function name exactly.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("function")]
        public virtual string Function { get; set; }

        /// <summary>
        /// The user-supplied [glob](https://firebase.google.com/docs/hosting/full-config#glob_pattern_matching) to
        /// match against the request URL path.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("glob")]
        public virtual string Glob { get; set; }

        /// <summary>The URL path to rewrite the request to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>The user-supplied RE2 regular expression to match against the request URL path.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regex")]
        public virtual string Regex { get; set; }

        /// <summary>The request will be forwarded to Cloud Run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("run")]
        public virtual CloudRunRewrite Run { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The configuration for how incoming requests to a site should be routed and processed before serving content. The
    /// URL request paths are matched against the specified URL patterns in the configuration, then Hosting applies the
    /// applicable configuration according to a specific [priority
    /// order](https://firebase.google.com/docs/hosting/full-config#hosting_priority_order).
    /// </summary>
    public class ServingConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>How to handle well known App Association files.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appAssociation")]
        public virtual string AppAssociation { get; set; }

        /// <summary>Defines whether to drop the file extension from uploaded files.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cleanUrls")]
        public virtual System.Nullable<bool> CleanUrls { get; set; }

        /// <summary>
        /// An array of objects, where each object specifies a URL pattern that, if matched to the request URL path,
        /// triggers Hosting to apply the specified custom response headers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headers")]
        public virtual System.Collections.Generic.IList<Header> Headers { get; set; }

        /// <summary>Optional. Defines i18n rewrite behavior.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("i18n")]
        public virtual I18nConfig I18n { get; set; }

        /// <summary>
        /// An array of objects (called redirect rules), where each rule specifies a URL pattern that, if matched to the
        /// request URL path, triggers Hosting to respond with a redirect to the specified destination path.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("redirects")]
        public virtual System.Collections.Generic.IList<Redirect> Redirects { get; set; }

        /// <summary>
        /// An array of objects (called rewrite rules), where each rule specifies a URL pattern that, if matched to the
        /// request URL path, triggers Hosting to respond as if the service were given the specified destination URL.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rewrites")]
        public virtual System.Collections.Generic.IList<Rewrite> Rewrites { get; set; }

        /// <summary>Defines how to handle a trailing slash in the URL path.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trailingSlashBehavior")]
        public virtual string TrailingSlashBehavior { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A `Site` represents a Firebase Hosting site.</summary>
    public class Site : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The [ID of a Web
        /// App](https://firebase.google.com/docs/projects/api/reference/rest/v1beta1/projects.webApps#WebApp.FIELDS.app_id)
        /// associated with the Hosting site.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appId")]
        public virtual string AppId { get; set; }

        /// <summary>Output only. The default URL for the Hosting site.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultUrl")]
        public virtual string DefaultUrl { get; set; }

        /// <summary>Optional. User-specified labels for the Hosting site.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Output only. The fully-qualified resource name of the Hosting site, in the format:
        /// projects/PROJECT_IDENTIFIER/sites/SITE_ID PROJECT_IDENTIFIER: the Firebase project's
        /// [`ProjectNumber`](https://firebase.google.com/docs/projects/api/reference/rest/v1beta1/projects#FirebaseProject.FIELDS.project_number)
        /// ***(recommended)*** or its
        /// [`ProjectId`](https://firebase.google.com/docs/projects/api/reference/rest/v1beta1/projects#FirebaseProject.FIELDS.project_id).
        /// Learn more about using project identifiers in Google's [AIP 2510
        /// standard](https://google.aip.dev/cloud/2510).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The type of Hosting site. Every Firebase project has a `DEFAULT_SITE`, which is created when
        /// Hosting is provisioned for the project. All additional sites are `USER_SITE`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A `SiteConfig` contains metadata associated with a specific site that controls Firebase Hosting serving behavior
    /// </summary>
    public class SiteConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether or not web requests made by site visitors are logged via Cloud Logging.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudLoggingEnabled")]
        public virtual System.Nullable<bool> CloudLoggingEnabled { get; set; }

        /// <summary>
        /// The number of FINALIZED versions that will be held for a site before automatic deletion. When a new version
        /// is deployed, content for versions in storage in excess of this number will be deleted, and will no longer be
        /// billed for storage usage. Oldest versions will be deleted first; sites are created with an unlimited number
        /// of max_versions by default.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxVersions")]
        public virtual System.Nullable<long> MaxVersions { get; set; }

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
    /// A `Version` is a configuration and a collection of static files which determine how a site is displayed.
    /// </summary>
    public class Version : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The configuration for the behavior of the site. This configuration exists in the
        /// [`firebase.json`](https://firebase.google.com/docs/cli/#the_firebasejson_file) file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual ServingConfig Config { get; set; }

        /// <summary>Output only. The time at which the version was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. Identifies the user who created the version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createUser")]
        public virtual ActingUser CreateUser { get; set; }

        /// <summary>Output only. The time at which the version was `DELETED`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteTime")]
        public virtual object DeleteTime { get; set; }

        /// <summary>Output only. Identifies the user who `DELETED` the version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteUser")]
        public virtual ActingUser DeleteUser { get; set; }

        /// <summary>
        /// Output only. The total number of files associated with the version. This value is calculated after a version
        /// is `FINALIZED`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileCount")]
        public virtual System.Nullable<long> FileCount { get; set; }

        /// <summary>Output only. The time at which the version was `FINALIZED`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finalizeTime")]
        public virtual object FinalizeTime { get; set; }

        /// <summary>Output only. Identifies the user who `FINALIZED` the version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finalizeUser")]
        public virtual ActingUser FinalizeUser { get; set; }

        /// <summary>The labels used for extra metadata and/or filtering.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// The fully-qualified resource name for the version, in the format: sites/ SITE_ID/versions/VERSION_ID This
        /// name is provided in the response body when you call [`CreateVersion`](sites.versions/create).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The deploy status of the version. For a successful deploy, call [`CreateVersion`](sites.versions/create) to
        /// make a new version (`CREATED` status), [upload all desired files](sites.versions/populateFiles) to the
        /// version, then [update](sites.versions/patch) the version to the `FINALIZED` status. Note that if you leave
        /// the version in the `CREATED` state for more than 12 hours, the system will automatically mark the version as
        /// `ABANDONED`. You can also change the status of a version to `DELETED` by calling
        /// [`DeleteVersion`](sites.versions/delete).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>
        /// Output only. The total stored bytesize of the version. This value is calculated after a version is
        /// `FINALIZED`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionBytes")]
        public virtual System.Nullable<long> VersionBytes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A static content file that is part of a version.</summary>
    public class VersionFile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The SHA256 content hash of the file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hash")]
        public virtual string Hash { get; set; }

        /// <summary>The URI at which the file's content should display.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>
        /// Output only. The current status of a particular file in the specified version. The value will be either
        /// `pending upload` or `uploaded`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
