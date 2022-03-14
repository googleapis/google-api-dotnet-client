// Copyright 2022 Google LLC
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

namespace Google.Apis.Datastream.v1
{
    /// <summary>The Datastream Service.</summary>
    public class DatastreamService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public DatastreamService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public DatastreamService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "datastream";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://datastream.googleapis.com/";
        #else
            "https://datastream.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://datastream.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Datastream API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Datastream API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for Datastream requests.</summary>
    public abstract class DatastreamBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new DatastreamBaseServiceRequest instance.</summary>
        protected DatastreamBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Datastream parameter list.</summary>
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
                ConnectionProfiles = new ConnectionProfilesResource(service);
                Operations = new OperationsResource(service);
                PrivateConnections = new PrivateConnectionsResource(service);
                Streams = new StreamsResource(service);
            }

            /// <summary>Gets the ConnectionProfiles resource.</summary>
            public virtual ConnectionProfilesResource ConnectionProfiles { get; }

            /// <summary>The "connectionProfiles" collection of methods.</summary>
            public class ConnectionProfilesResource
            {
                private const string Resource = "connectionProfiles";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ConnectionProfilesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Use this method to create a connection profile in a project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. The parent that owns the collection of ConnectionProfiles.</param>
                public virtual CreateRequest Create(Google.Apis.Datastream.v1.Data.ConnectionProfile body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Use this method to create a connection profile in a project and location.</summary>
                public class CreateRequest : DatastreamBaseServiceRequest<Google.Apis.Datastream.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Datastream.v1.Data.ConnectionProfile body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The parent that owns the collection of ConnectionProfiles.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Required. The connection profile identifier.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("connectionProfileId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ConnectionProfileId { get; set; }

                    /// <summary>Optional. Create the connection profile without validating it.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("force", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> Force { get; set; }

                    /// <summary>
                    /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server will know to ignore the request if it has already been completed.
                    /// The server will guarantee that for at least 60 minutes since the first request. For example,
                    /// consider a situation where you make an initial request and the request times out. If you make
                    /// the request again with the same request ID, the server can check if original operation with the
                    /// same request ID was received, and if so, will ignore the second request. This prevents clients
                    /// from accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// Optional. Only validate the connection profile, but don't create any resources. The default is
                    /// false.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Datastream.v1.Data.ConnectionProfile Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/connectionProfiles";

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
                        RequestParameters.Add("connectionProfileId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "connectionProfileId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("force", new Google.Apis.Discovery.Parameter
                        {
                            Name = "force",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("validateOnly", new Google.Apis.Discovery.Parameter
                        {
                            Name = "validateOnly",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Use this method to delete a connection profile.</summary>
                /// <param name="name">Required. The name of the connection profile resource to delete.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>Use this method to delete a connection profile.</summary>
                public class DeleteRequest : DatastreamBaseServiceRequest<Google.Apis.Datastream.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the connection profile resource to delete.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server will know to ignore the request if it has already been completed.
                    /// The server will guarantee that for at least 60 minutes after the first request. For example,
                    /// consider a situation where you make an initial request and the request times out. If you make
                    /// the request again with the same request ID, the server can check if original operation with the
                    /// same request ID was received, and if so, will ignore the second request. This prevents clients
                    /// from accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/connectionProfiles/[^/]+$",
                        });
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Use this method to discover a connection profile. The discover API call exposes the data objects and
                /// metadata belonging to the profile. Typically, a request returns children data objects of a parent
                /// data object that's optionally supplied in the request.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource of the connection profile type. Must be in the format
                /// `projects/*/locations/*`.
                /// </param>
                public virtual DiscoverRequest Discover(Google.Apis.Datastream.v1.Data.DiscoverConnectionProfileRequest body, string parent)
                {
                    return new DiscoverRequest(service, body, parent);
                }

                /// <summary>
                /// Use this method to discover a connection profile. The discover API call exposes the data objects and
                /// metadata belonging to the profile. Typically, a request returns children data objects of a parent
                /// data object that's optionally supplied in the request.
                /// </summary>
                public class DiscoverRequest : DatastreamBaseServiceRequest<Google.Apis.Datastream.v1.Data.DiscoverConnectionProfileResponse>
                {
                    /// <summary>Constructs a new Discover request.</summary>
                    public DiscoverRequest(Google.Apis.Services.IClientService service, Google.Apis.Datastream.v1.Data.DiscoverConnectionProfileRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource of the connection profile type. Must be in the format
                    /// `projects/*/locations/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Datastream.v1.Data.DiscoverConnectionProfileRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "discover";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/connectionProfiles:discover";

                    /// <summary>Initializes Discover parameter list.</summary>
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

                /// <summary>Use this method to get details about a connection profile.</summary>
                /// <param name="name">Required. The name of the connection profile resource to get.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Use this method to get details about a connection profile.</summary>
                public class GetRequest : DatastreamBaseServiceRequest<Google.Apis.Datastream.v1.Data.ConnectionProfile>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the connection profile resource to get.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/connectionProfiles/[^/]+$",
                        });
                    }
                }

                /// <summary>Use this method to list connection profiles created in a project and location.</summary>
                /// <param name="parent">Required. The parent that owns the collection of connection profiles.</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Use this method to list connection profiles created in a project and location.</summary>
                public class ListRequest : DatastreamBaseServiceRequest<Google.Apis.Datastream.v1.Data.ListConnectionProfilesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. The parent that owns the collection of connection profiles.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Filter request.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Order by fields for the result.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Maximum number of connection profiles to return. If unspecified, at most 50 connection profiles
                    /// will be returned. The maximum value is 1000; values above 1000 will be coerced to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Page token received from a previous `ListConnectionProfiles` call. Provide this to retrieve the
                    /// subsequent page. When paginating, all other parameters provided to `ListConnectionProfiles` must
                    /// match the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/connectionProfiles";

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

                /// <summary>Use this method to update the parameters of a connection profile.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Output only. The resource's name.</param>
                public virtual PatchRequest Patch(Google.Apis.Datastream.v1.Data.ConnectionProfile body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>Use this method to update the parameters of a connection profile.</summary>
                public class PatchRequest : DatastreamBaseServiceRequest<Google.Apis.Datastream.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Datastream.v1.Data.ConnectionProfile body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Output only. The resource's name.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Optional. Update the connection profile without validating it.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("force", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> Force { get; set; }

                    /// <summary>
                    /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server will know to ignore the request if it has already been completed.
                    /// The server will guarantee that for at least 60 minutes since the first request. For example,
                    /// consider a situation where you make an initial request and the request times out. If you make
                    /// the request again with the same request ID, the server can check if original operation with the
                    /// same request ID was received, and if so, will ignore the second request. This prevents clients
                    /// from accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// Optional. Field mask is used to specify the fields to be overwritten in the ConnectionProfile
                    /// resource by the update. The fields specified in the update_mask are relative to the resource,
                    /// not the full request. A field will be overwritten if it is in the mask. If the user does not
                    /// provide a mask then all fields will be overwritten.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>
                    /// Optional. Only validate the connection profile, but don't update any resources. The default is
                    /// false.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Datastream.v1.Data.ConnectionProfile Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/connectionProfiles/[^/]+$",
                        });
                        RequestParameters.Add("force", new Google.Apis.Discovery.Parameter
                        {
                            Name = "force",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                        {
                            Name = "updateMask",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("validateOnly", new Google.Apis.Discovery.Parameter
                        {
                            Name = "validateOnly",
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
                /// Operation.error value with a google.rpc.Status.code of 1, corresponding to `Code.CANCELLED`.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">The name of the operation resource to be cancelled.</param>
                public virtual CancelRequest Cancel(Google.Apis.Datastream.v1.Data.CancelOperationRequest body, string name)
                {
                    return new CancelRequest(service, body, name);
                }

                /// <summary>
                /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to
                /// cancel the operation, but success is not guaranteed. If the server doesn't support this method, it
                /// returns `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other methods to
                /// check whether the cancellation succeeded or whether the operation completed despite cancellation. On
                /// successful cancellation, the operation is not deleted; instead, it becomes an operation with an
                /// Operation.error value with a google.rpc.Status.code of 1, corresponding to `Code.CANCELLED`.
                /// </summary>
                public class CancelRequest : DatastreamBaseServiceRequest<Google.Apis.Datastream.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.Datastream.v1.Data.CancelOperationRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to be cancelled.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Datastream.v1.Data.CancelOperationRequest Body { get; set; }

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
                    return new DeleteRequest(service, name);
                }

                /// <summary>
                /// Deletes a long-running operation. This method indicates that the client is no longer interested in
                /// the operation result. It does not cancel the operation. If the server doesn't support this method,
                /// it returns `google.rpc.Code.UNIMPLEMENTED`.
                /// </summary>
                public class DeleteRequest : DatastreamBaseServiceRequest<Google.Apis.Datastream.v1.Data.Empty>
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
                    return new GetRequest(service, name);
                }

                /// <summary>
                /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation
                /// result at intervals as recommended by the API service.
                /// </summary>
                public class GetRequest : DatastreamBaseServiceRequest<Google.Apis.Datastream.v1.Data.Operation>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/operations/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists operations that match the specified filter in the request. If the server doesn't support this
                /// method, it returns `UNIMPLEMENTED`. NOTE: the `name` binding allows API services to override the
                /// binding to use different resource name schemes, such as `users/*/operations`. To override the
                /// binding, API services can add a binding such as `"/v1/{name=users/*}/operations"` to their service
                /// configuration. For backwards compatibility, the default name includes the operations collection id,
                /// however overriding users must ensure the name binding is the parent resource, without the operations
                /// collection id.
                /// </summary>
                /// <param name="name">The name of the operation's parent resource.</param>
                public virtual ListRequest List(string name)
                {
                    return new ListRequest(service, name);
                }

                /// <summary>
                /// Lists operations that match the specified filter in the request. If the server doesn't support this
                /// method, it returns `UNIMPLEMENTED`. NOTE: the `name` binding allows API services to override the
                /// binding to use different resource name schemes, such as `users/*/operations`. To override the
                /// binding, API services can add a binding such as `"/v1/{name=users/*}/operations"` to their service
                /// configuration. For backwards compatibility, the default name includes the operations collection id,
                /// however overriding users must ensure the name binding is the parent resource, without the operations
                /// collection id.
                /// </summary>
                public class ListRequest : DatastreamBaseServiceRequest<Google.Apis.Datastream.v1.Data.ListOperationsResponse>
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

            /// <summary>Gets the PrivateConnections resource.</summary>
            public virtual PrivateConnectionsResource PrivateConnections { get; }

            /// <summary>The "privateConnections" collection of methods.</summary>
            public class PrivateConnectionsResource
            {
                private const string Resource = "privateConnections";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public PrivateConnectionsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Routes = new RoutesResource(service);
                }

                /// <summary>Gets the Routes resource.</summary>
                public virtual RoutesResource Routes { get; }

                /// <summary>The "routes" collection of methods.</summary>
                public class RoutesResource
                {
                    private const string Resource = "routes";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public RoutesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Use this method to create a route for a private connectivity configuration in a project and
                    /// location.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">Required. The parent that owns the collection of Routes.</param>
                    public virtual CreateRequest Create(Google.Apis.Datastream.v1.Data.Route body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>
                    /// Use this method to create a route for a private connectivity configuration in a project and
                    /// location.
                    /// </summary>
                    public class CreateRequest : DatastreamBaseServiceRequest<Google.Apis.Datastream.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Datastream.v1.Data.Route body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The parent that owns the collection of Routes.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must
                        /// retry your request, the server will know to ignore the request if it has already been
                        /// completed. The server will guarantee that for at least 60 minutes since the first request.
                        /// For example, consider a situation where you make an initial request and the request times
                        /// out. If you make the request again with the same request ID, the server can check if
                        /// original operation with the same request ID was received, and if so, will ignore the second
                        /// request. This prevents clients from accidentally creating duplicate commitments. The request
                        /// ID must be a valid UUID with the exception that zero UUID is not supported
                        /// (00000000-0000-0000-0000-000000000000).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RequestId { get; set; }

                        /// <summary>Required. The Route identifier.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("routeId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RouteId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Datastream.v1.Data.Route Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/routes";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/privateConnections/[^/]+$",
                            });
                            RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "requestId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("routeId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "routeId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Use this method to delete a route.</summary>
                    /// <param name="name">Required. The name of the Route resource to delete.</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>Use this method to delete a route.</summary>
                    public class DeleteRequest : DatastreamBaseServiceRequest<Google.Apis.Datastream.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the Route resource to delete.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must
                        /// retry your request, the server will know to ignore the request if it has already been
                        /// completed. The server will guarantee that for at least 60 minutes after the first request.
                        /// For example, consider a situation where you make an initial request and the request times
                        /// out. If you make the request again with the same request ID, the server can check if
                        /// original operation with the same request ID was received, and if so, will ignore the second
                        /// request. This prevents clients from accidentally creating duplicate commitments. The request
                        /// ID must be a valid UUID with the exception that zero UUID is not supported
                        /// (00000000-0000-0000-0000-000000000000).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RequestId { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/privateConnections/[^/]+/routes/[^/]+$",
                            });
                            RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "requestId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Use this method to get details about a route.</summary>
                    /// <param name="name">Required. The name of the Route resource to get.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Use this method to get details about a route.</summary>
                    public class GetRequest : DatastreamBaseServiceRequest<Google.Apis.Datastream.v1.Data.Route>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the Route resource to get.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/privateConnections/[^/]+/routes/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Use this method to list routes created for a private connectivity configuration in a project and
                    /// location.
                    /// </summary>
                    /// <param name="parent">Required. The parent that owns the collection of Routess.</param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>
                    /// Use this method to list routes created for a private connectivity configuration in a project and
                    /// location.
                    /// </summary>
                    public class ListRequest : DatastreamBaseServiceRequest<Google.Apis.Datastream.v1.Data.ListRoutesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>Required. The parent that owns the collection of Routess.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Filter request.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>Order by fields for the result.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>
                        /// Maximum number of Routes to return. The service may return fewer than this value. If
                        /// unspecified, at most 50 Routes will be returned. The maximum value is 1000; values above
                        /// 1000 will be coerced to 1000.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Page token received from a previous `ListRoutes` call. Provide this to retrieve the
                        /// subsequent page. When paginating, all other parameters provided to `ListRoutes` must match
                        /// the call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/routes";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/privateConnections/[^/]+$",
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
                }

                /// <summary>Use this method to create a private connectivity configuration.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. The parent that owns the collection of PrivateConnections.</param>
                public virtual CreateRequest Create(Google.Apis.Datastream.v1.Data.PrivateConnection body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Use this method to create a private connectivity configuration.</summary>
                public class CreateRequest : DatastreamBaseServiceRequest<Google.Apis.Datastream.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Datastream.v1.Data.PrivateConnection body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The parent that owns the collection of PrivateConnections.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Required. The private connectivity identifier.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("privateConnectionId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PrivateConnectionId { get; set; }

                    /// <summary>
                    /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server will know to ignore the request if it has already been completed.
                    /// The server will guarantee that for at least 60 minutes since the first request. For example,
                    /// consider a situation where you make an initial request and the request times out. If you make
                    /// the request again with the same request ID, the server can check if original operation with the
                    /// same request ID was received, and if so, will ignore the second request. This prevents clients
                    /// from accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Datastream.v1.Data.PrivateConnection Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/privateConnections";

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
                        RequestParameters.Add("privateConnectionId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "privateConnectionId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Use this method to delete a private connectivity configuration.</summary>
                /// <param name="name">Required. The name of the private connectivity configuration to delete.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>Use this method to delete a private connectivity configuration.</summary>
                public class DeleteRequest : DatastreamBaseServiceRequest<Google.Apis.Datastream.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the private connectivity configuration to delete.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. If set to true, any child routes that belong to this PrivateConnection will also be
                    /// deleted.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("force", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> Force { get; set; }

                    /// <summary>
                    /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server will know to ignore the request if it has already been completed.
                    /// The server will guarantee that for at least 60 minutes after the first request. For example,
                    /// consider a situation where you make an initial request and the request times out. If you make
                    /// the request again with the same request ID, the server can check if original operation with the
                    /// same request ID was received, and if so, will ignore the second request. This prevents clients
                    /// from accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/privateConnections/[^/]+$",
                        });
                        RequestParameters.Add("force", new Google.Apis.Discovery.Parameter
                        {
                            Name = "force",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Use this method to get details about a private connectivity configuration.</summary>
                /// <param name="name">Required. The name of the private connectivity configuration to get.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Use this method to get details about a private connectivity configuration.</summary>
                public class GetRequest : DatastreamBaseServiceRequest<Google.Apis.Datastream.v1.Data.PrivateConnection>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the private connectivity configuration to get.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/privateConnections/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Use this method to list private connectivity configurations in a project and location.
                /// </summary>
                /// <param name="parent">
                /// Required. The parent that owns the collection of private connectivity configurations.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>
                /// Use this method to list private connectivity configurations in a project and location.
                /// </summary>
                public class ListRequest : DatastreamBaseServiceRequest<Google.Apis.Datastream.v1.Data.ListPrivateConnectionsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent that owns the collection of private connectivity configurations.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Filter request.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Order by fields for the result.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Maximum number of private connectivity configurations to return. If unspecified, at most 50
                    /// private connectivity configurations that will be returned. The maximum value is 1000; values
                    /// above 1000 will be coerced to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Page token received from a previous `ListPrivateConnections` call. Provide this to retrieve the
                    /// subsequent page. When paginating, all other parameters provided to `ListPrivateConnections` must
                    /// match the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/privateConnections";

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
            }

            /// <summary>Gets the Streams resource.</summary>
            public virtual StreamsResource Streams { get; }

            /// <summary>The "streams" collection of methods.</summary>
            public class StreamsResource
            {
                private const string Resource = "streams";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public StreamsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Objects = new ObjectsResource(service);
                }

                /// <summary>Gets the Objects resource.</summary>
                public virtual ObjectsResource Objects { get; }

                /// <summary>The "objects" collection of methods.</summary>
                public class ObjectsResource
                {
                    private const string Resource = "objects";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ObjectsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Use this method to get details about a stream object.</summary>
                    /// <param name="name">Required. The name of the stream object resource to get.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Use this method to get details about a stream object.</summary>
                    public class GetRequest : DatastreamBaseServiceRequest<Google.Apis.Datastream.v1.Data.StreamObject>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the stream object resource to get.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/streams/[^/]+/objects/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Use this method to list the objects of a specific stream.</summary>
                    /// <param name="parent">Required. The parent stream that owns the collection of objects.</param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Use this method to list the objects of a specific stream.</summary>
                    public class ListRequest : DatastreamBaseServiceRequest<Google.Apis.Datastream.v1.Data.ListStreamObjectsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>Required. The parent stream that owns the collection of objects.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Maximum number of objects to return. Default is 50. The maximum value is 1000; values above
                        /// 1000 will be coerced to 1000.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Page token received from a previous `ListStreamObjectsRequest` call. Provide this to
                        /// retrieve the subsequent page. When paginating, all other parameters provided to
                        /// `ListStreamObjectsRequest` must match the call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/objects";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/streams/[^/]+$",
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

                    /// <summary>Use this method to look up a stream object by its source object identifier.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">Required. The parent stream that owns the collection of objects.</param>
                    public virtual LookupRequest Lookup(Google.Apis.Datastream.v1.Data.LookupStreamObjectRequest body, string parent)
                    {
                        return new LookupRequest(service, body, parent);
                    }

                    /// <summary>Use this method to look up a stream object by its source object identifier.</summary>
                    public class LookupRequest : DatastreamBaseServiceRequest<Google.Apis.Datastream.v1.Data.StreamObject>
                    {
                        /// <summary>Constructs a new Lookup request.</summary>
                        public LookupRequest(Google.Apis.Services.IClientService service, Google.Apis.Datastream.v1.Data.LookupStreamObjectRequest body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The parent stream that owns the collection of objects.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Datastream.v1.Data.LookupStreamObjectRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "lookup";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/objects:lookup";

                        /// <summary>Initializes Lookup parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/streams/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Use this method to start a backfill job for the specified stream object.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="datastreamObject">
                    /// Required. The name of the stream object resource to start a backfill job for.
                    /// </param>
                    public virtual StartBackfillJobRequest StartBackfillJob(Google.Apis.Datastream.v1.Data.StartBackfillJobRequest body, string datastreamObject)
                    {
                        return new StartBackfillJobRequest(service, body, datastreamObject);
                    }

                    /// <summary>Use this method to start a backfill job for the specified stream object.</summary>
                    public class StartBackfillJobRequest : DatastreamBaseServiceRequest<Google.Apis.Datastream.v1.Data.StartBackfillJobResponse>
                    {
                        /// <summary>Constructs a new StartBackfillJob request.</summary>
                        public StartBackfillJobRequest(Google.Apis.Services.IClientService service, Google.Apis.Datastream.v1.Data.StartBackfillJobRequest body, string datastreamObject) : base(service)
                        {
                            Object = datastreamObject;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the stream object resource to start a backfill job for.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("object", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Object { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Datastream.v1.Data.StartBackfillJobRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "startBackfillJob";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+object}:startBackfillJob";

                        /// <summary>Initializes StartBackfillJob parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("object", new Google.Apis.Discovery.Parameter
                            {
                                Name = "object",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/streams/[^/]+/objects/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Use this method to stop a backfill job for the specified stream object.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="datastreamObject">
                    /// Required. The name of the stream object resource to stop the backfill job for.
                    /// </param>
                    public virtual StopBackfillJobRequest StopBackfillJob(Google.Apis.Datastream.v1.Data.StopBackfillJobRequest body, string datastreamObject)
                    {
                        return new StopBackfillJobRequest(service, body, datastreamObject);
                    }

                    /// <summary>Use this method to stop a backfill job for the specified stream object.</summary>
                    public class StopBackfillJobRequest : DatastreamBaseServiceRequest<Google.Apis.Datastream.v1.Data.StopBackfillJobResponse>
                    {
                        /// <summary>Constructs a new StopBackfillJob request.</summary>
                        public StopBackfillJobRequest(Google.Apis.Services.IClientService service, Google.Apis.Datastream.v1.Data.StopBackfillJobRequest body, string datastreamObject) : base(service)
                        {
                            Object = datastreamObject;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the stream object resource to stop the backfill job for.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("object", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Object { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Datastream.v1.Data.StopBackfillJobRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "stopBackfillJob";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+object}:stopBackfillJob";

                        /// <summary>Initializes StopBackfillJob parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("object", new Google.Apis.Discovery.Parameter
                            {
                                Name = "object",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/streams/[^/]+/objects/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>Use this method to create a stream.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. The parent that owns the collection of streams.</param>
                public virtual CreateRequest Create(Google.Apis.Datastream.v1.Data.Stream body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Use this method to create a stream.</summary>
                public class CreateRequest : DatastreamBaseServiceRequest<Google.Apis.Datastream.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Datastream.v1.Data.Stream body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The parent that owns the collection of streams.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Optional. Create the stream without validating it.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("force", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> Force { get; set; }

                    /// <summary>
                    /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server will know to ignore the request if it has already been completed.
                    /// The server will guarantee that for at least 60 minutes since the first request. For example,
                    /// consider a situation where you make an initial request and the request times out. If you make
                    /// the request again with the same request ID, the server can check if original operation with the
                    /// same request ID was received, and if so, will ignore the second request. This prevents clients
                    /// from accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Required. The stream identifier.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("streamId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string StreamId { get; set; }

                    /// <summary>
                    /// Optional. Only validate the stream, but don't create any resources. The default is false.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Datastream.v1.Data.Stream Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/streams";

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
                        RequestParameters.Add("force", new Google.Apis.Discovery.Parameter
                        {
                            Name = "force",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("streamId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "streamId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("validateOnly", new Google.Apis.Discovery.Parameter
                        {
                            Name = "validateOnly",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Use this method to delete a stream.</summary>
                /// <param name="name">Required. The name of the stream resource to delete.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>Use this method to delete a stream.</summary>
                public class DeleteRequest : DatastreamBaseServiceRequest<Google.Apis.Datastream.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the stream resource to delete.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server will know to ignore the request if it has already been completed.
                    /// The server will guarantee that for at least 60 minutes after the first request. For example,
                    /// consider a situation where you make an initial request and the request times out. If you make
                    /// the request again with the same request ID, the server can check if original operation with the
                    /// same request ID was received, and if so, will ignore the second request. This prevents clients
                    /// from accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/streams/[^/]+$",
                        });
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Use this method to get details about a stream.</summary>
                /// <param name="name">Required. The name of the stream resource to get.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Use this method to get details about a stream.</summary>
                public class GetRequest : DatastreamBaseServiceRequest<Google.Apis.Datastream.v1.Data.Stream>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the stream resource to get.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/streams/[^/]+$",
                        });
                    }
                }

                /// <summary>Use this method to list streams in a project and location.</summary>
                /// <param name="parent">Required. The parent that owns the collection of streams.</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Use this method to list streams in a project and location.</summary>
                public class ListRequest : DatastreamBaseServiceRequest<Google.Apis.Datastream.v1.Data.ListStreamsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. The parent that owns the collection of streams.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Filter request.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Order by fields for the result.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Maximum number of streams to return. If unspecified, at most 50 streams will be returned. The
                    /// maximum value is 1000; values above 1000 will be coerced to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Page token received from a previous `ListStreams` call. Provide this to retrieve the subsequent
                    /// page. When paginating, all other parameters provided to `ListStreams` must match the call that
                    /// provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/streams";

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

                /// <summary>Use this method to update the configuration of a stream.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Output only. The stream's name.</param>
                public virtual PatchRequest Patch(Google.Apis.Datastream.v1.Data.Stream body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>Use this method to update the configuration of a stream.</summary>
                public class PatchRequest : DatastreamBaseServiceRequest<Google.Apis.Datastream.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Datastream.v1.Data.Stream body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Output only. The stream's name.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Optional. Update the stream without validating it.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("force", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> Force { get; set; }

                    /// <summary>
                    /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server will know to ignore the request if it has already been completed.
                    /// The server will guarantee that for at least 60 minutes since the first request. For example,
                    /// consider a situation where you make an initial request and the request times out. If you make
                    /// the request again with the same request ID, the server can check if original operation with the
                    /// same request ID was received, and if so, will ignore the second request. This prevents clients
                    /// from accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// Optional. Field mask is used to specify the fields to be overwritten in the stream resource by
                    /// the update. The fields specified in the update_mask are relative to the resource, not the full
                    /// request. A field will be overwritten if it is in the mask. If the user does not provide a mask
                    /// then all fields will be overwritten.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>
                    /// Optional. Only validate the stream with the changes, without actually updating it. The default
                    /// is false.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Datastream.v1.Data.Stream Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/streams/[^/]+$",
                        });
                        RequestParameters.Add("force", new Google.Apis.Discovery.Parameter
                        {
                            Name = "force",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                        {
                            Name = "updateMask",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("validateOnly", new Google.Apis.Discovery.Parameter
                        {
                            Name = "validateOnly",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
            }

            /// <summary>The FetchStaticIps API call exposes the static IP addresses used by Datastream.</summary>
            /// <param name="name">
            /// Required. The resource name for the location for which static IPs should be returned. Must be in the
            /// format `projects/*/locations/*`.
            /// </param>
            public virtual FetchStaticIpsRequest FetchStaticIps(string name)
            {
                return new FetchStaticIpsRequest(service, name);
            }

            /// <summary>The FetchStaticIps API call exposes the static IP addresses used by Datastream.</summary>
            public class FetchStaticIpsRequest : DatastreamBaseServiceRequest<Google.Apis.Datastream.v1.Data.FetchStaticIpsResponse>
            {
                /// <summary>Constructs a new FetchStaticIps request.</summary>
                public FetchStaticIpsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name for the location for which static IPs should be returned. Must be in the
                /// format `projects/*/locations/*`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Maximum number of Ips to return, will likely not be specified.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A page token, received from a previous `ListStaticIps` call. will likely not be specified.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "fetchStaticIps";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:fetchStaticIps";

                /// <summary>Initializes FetchStaticIps parameter list.</summary>
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

            /// <summary>Gets information about a location.</summary>
            /// <param name="name">Resource name for the location.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets information about a location.</summary>
            public class GetRequest : DatastreamBaseServiceRequest<Google.Apis.Datastream.v1.Data.Location>
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
                        Pattern = @"^projects/[^/]+/locations/[^/]+$",
                    });
                }
            }

            /// <summary>Lists information about the supported locations for this service.</summary>
            /// <param name="name">The resource that owns the locations collection, if applicable.</param>
            public virtual ListRequest List(string name)
            {
                return new ListRequest(service, name);
            }

            /// <summary>Lists information about the supported locations for this service.</summary>
            public class ListRequest : DatastreamBaseServiceRequest<Google.Apis.Datastream.v1.Data.ListLocationsResponse>
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
                /// A filter to narrow down results to a preferred subset. The filtering language accepts strings like
                /// "displayName=tokyo", and is documented in more detail in [AIP-160](https://google.aip.dev/160).
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
                public override string RestPath => "v1/{+name}/locations";

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
namespace Google.Apis.Datastream.v1.Data
{
    /// <summary>AVRO file format configuration.</summary>
    public class AvroFileFormat : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Backfill strategy to automatically backfill the Stream's objects. Specific objects can be excluded.
    /// </summary>
    public class BackfillAllStrategy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>MySQL data source objects to avoid backfilling.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mysqlExcludedObjects")]
        public virtual MysqlRdbms MysqlExcludedObjects { get; set; }

        /// <summary>Oracle data source objects to avoid backfilling.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oracleExcludedObjects")]
        public virtual OracleRdbms OracleExcludedObjects { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a backfill job on a specific stream object.</summary>
    public class BackfillJob : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Errors which caused the backfill job to fail.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual System.Collections.Generic.IList<Error> Errors { get; set; }

        /// <summary>Output only. Backfill job's end time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastEndTime")]
        public virtual object LastEndTime { get; set; }

        /// <summary>Output only. Backfill job's start time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastStartTime")]
        public virtual object LastStartTime { get; set; }

        /// <summary>Backfill job state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Backfill job's triggering reason.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trigger")]
        public virtual string Trigger { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Backfill strategy to disable automatic backfill for the Stream's objects.</summary>
    public class BackfillNoneStrategy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for Operations.CancelOperation.</summary>
    public class CancelOperationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A set of reusable connection configurations to be used as a source or destination for a stream.
    /// </summary>
    public class ConnectionProfile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The create time of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Required. Display name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Forward SSH tunnel connectivity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("forwardSshConnectivity")]
        public virtual ForwardSshTunnelConnectivity ForwardSshConnectivity { get; set; }

        /// <summary>Cloud Storage ConnectionProfile configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsProfile")]
        public virtual GcsProfile GcsProfile { get; set; }

        /// <summary>Labels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>MySQL ConnectionProfile configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mysqlProfile")]
        public virtual MysqlProfile MysqlProfile { get; set; }

        /// <summary>Output only. The resource's name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Oracle ConnectionProfile configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oracleProfile")]
        public virtual OracleProfile OracleProfile { get; set; }

        /// <summary>Private connectivity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateConnectivity")]
        public virtual PrivateConnectivity PrivateConnectivity { get; set; }

        /// <summary>Static Service IP connectivity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("staticServiceIpConnectivity")]
        public virtual StaticServiceIpConnectivity StaticServiceIpConnectivity { get; set; }

        /// <summary>Output only. The update time of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The configuration of the stream destination.</summary>
    public class DestinationConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Destination connection profile resource. Format:
        /// `projects/{project}/locations/{location}/connectionProfiles/{name}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationConnectionProfile")]
        public virtual string DestinationConnectionProfile { get; set; }

        /// <summary>A configuration for how data should be loaded to Cloud Storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsDestinationConfig")]
        public virtual GcsDestinationConfig GcsDestinationConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for 'discover' ConnectionProfile request.</summary>
    public class DiscoverConnectionProfileRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An ad-hoc connection profile configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectionProfile")]
        public virtual ConnectionProfile ConnectionProfile { get; set; }

        /// <summary>A reference to an existing connection profile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectionProfileName")]
        public virtual string ConnectionProfileName { get; set; }

        /// <summary>
        /// Whether to retrieve the full hierarchy of data objects (TRUE) or only the current level (FALSE).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullHierarchy")]
        public virtual System.Nullable<bool> FullHierarchy { get; set; }

        /// <summary>The number of hierarchy levels below the current level to be retrieved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hierarchyDepth")]
        public virtual System.Nullable<int> HierarchyDepth { get; set; }

        /// <summary>MySQL RDBMS to enrich with child data objects and metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mysqlRdbms")]
        public virtual MysqlRdbms MysqlRdbms { get; set; }

        /// <summary>Oracle RDBMS to enrich with child data objects and metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oracleRdbms")]
        public virtual OracleRdbms OracleRdbms { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response from a discover request.</summary>
    public class DiscoverConnectionProfileResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Enriched MySQL RDBMS object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mysqlRdbms")]
        public virtual MysqlRdbms MysqlRdbms { get; set; }

        /// <summary>Enriched Oracle RDBMS object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oracleRdbms")]
        public virtual OracleRdbms OracleRdbms { get; set; }

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

    /// <summary>Represent a user-facing Error.</summary>
    public class Error : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Additional information about the error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual System.Collections.Generic.IDictionary<string, string> Details { get; set; }

        /// <summary>The time when the error occurred.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorTime")]
        public virtual object ErrorTime { get; set; }

        /// <summary>
        /// A unique identifier for this specific error, allowing it to be traced throughout the system in logs and API
        /// responses.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorUuid")]
        public virtual string ErrorUuid { get; set; }

        /// <summary>A message containing more information about the error that occurred.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>A title that explains the reason for the error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for a 'FetchStaticIps' response.</summary>
    public class FetchStaticIpsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token that can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>list of static ips by account</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("staticIps")]
        public virtual System.Collections.Generic.IList<string> StaticIps { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Forward SSH Tunnel connectivity.</summary>
    public class ForwardSshTunnelConnectivity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Hostname for the SSH tunnel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostname")]
        public virtual string Hostname { get; set; }

        /// <summary>Input only. SSH password.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual string Password { get; set; }

        /// <summary>Port for the SSH tunnel, default value is 22.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("port")]
        public virtual System.Nullable<int> Port { get; set; }

        /// <summary>Input only. SSH private key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateKey")]
        public virtual string PrivateKey { get; set; }

        /// <summary>Required. Username for the SSH tunnel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Google Cloud Storage destination configuration</summary>
    public class GcsDestinationConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>AVRO file format configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("avroFileFormat")]
        public virtual AvroFileFormat AvroFileFormat { get; set; }

        /// <summary>
        /// The maximum duration for which new events are added before a file is closed and a new file is created.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileRotationInterval")]
        public virtual object FileRotationInterval { get; set; }

        /// <summary>The maximum file size to be saved in the bucket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileRotationMb")]
        public virtual System.Nullable<int> FileRotationMb { get; set; }

        /// <summary>JSON file format configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jsonFileFormat")]
        public virtual JsonFileFormat JsonFileFormat { get; set; }

        /// <summary>Path inside the Cloud Storage bucket to write data to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Cloud Storage bucket profile.</summary>
    public class GcsProfile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The Cloud Storage bucket name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucket")]
        public virtual string Bucket { get; set; }

        /// <summary>The root path inside the Cloud Storage bucket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rootPath")]
        public virtual string RootPath { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>JSON file format configuration.</summary>
    public class JsonFileFormat : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Compression of the loaded JSON file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compression")]
        public virtual string Compression { get; set; }

        /// <summary>The schema file format along JSON data files.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schemaFileFormat")]
        public virtual string SchemaFileFormat { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for listing connection profiles.</summary>
    public class ListConnectionProfilesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of connection profiles.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectionProfiles")]
        public virtual System.Collections.Generic.IList<ConnectionProfile> ConnectionProfiles { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

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

    /// <summary>Response containing a list of private connection configurations.</summary>
    public class ListPrivateConnectionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of private connectivity configurations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateConnections")]
        public virtual System.Collections.Generic.IList<PrivateConnection> PrivateConnections { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Route list response.</summary>
    public class ListRoutesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of Routes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("routes")]
        public virtual System.Collections.Generic.IList<Route> Routes { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response containing the objects for a stream.</summary>
    public class ListStreamObjectsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A token, which can be sent as `page_token` to retrieve the next page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of stream objects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("streamObjects")]
        public virtual System.Collections.Generic.IList<StreamObject> StreamObjects { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for listing streams.</summary>
    public class ListStreamsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of streams</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("streams")]
        public virtual System.Collections.Generic.IList<Stream> Streams { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A resource that represents Google Cloud Platform location.</summary>
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

    /// <summary>Request for looking up a specific stream object by its source object identifier.</summary>
    public class LookupStreamObjectRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The source object identifier which maps to the stream object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceObjectIdentifier")]
        public virtual SourceObjectIdentifier SourceObjectIdentifier { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>MySQL Column.</summary>
    public class MysqlColumn : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Column collation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("collation")]
        public virtual string Collation { get; set; }

        /// <summary>Column name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("column")]
        public virtual string Column { get; set; }

        /// <summary>
        /// The MySQL data type. Full data types list can be found here:
        /// https://dev.mysql.com/doc/refman/8.0/en/data-types.html
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataType")]
        public virtual string DataType { get; set; }

        /// <summary>Column length.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("length")]
        public virtual System.Nullable<int> Length { get; set; }

        /// <summary>Whether or not the column can accept a null value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nullable")]
        public virtual System.Nullable<bool> Nullable { get; set; }

        /// <summary>The ordinal position of the column in the table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ordinalPosition")]
        public virtual System.Nullable<int> OrdinalPosition { get; set; }

        /// <summary>Whether or not the column represents a primary key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryKey")]
        public virtual System.Nullable<bool> PrimaryKey { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>MySQL database.</summary>
    public class MysqlDatabase : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Database name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("database")]
        public virtual string Database { get; set; }

        /// <summary>Tables in the database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mysqlTables")]
        public virtual System.Collections.Generic.IList<MysqlTable> MysqlTables { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Mysql data source object identifier.</summary>
    public class MysqlObjectIdentifier : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The database name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("database")]
        public virtual string Database { get; set; }

        /// <summary>Required. The table name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("table")]
        public virtual string Table { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>MySQL database profile.</summary>
    public class MysqlProfile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Hostname for the MySQL connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostname")]
        public virtual string Hostname { get; set; }

        /// <summary>Required. Input only. Password for the MySQL connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual string Password { get; set; }

        /// <summary>Port for the MySQL connection, default value is 3306.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("port")]
        public virtual System.Nullable<int> Port { get; set; }

        /// <summary>SSL configuration for the MySQL connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sslConfig")]
        public virtual MysqlSslConfig SslConfig { get; set; }

        /// <summary>Required. Username for the MySQL connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>MySQL database structure</summary>
    public class MysqlRdbms : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Mysql databases on the server</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mysqlDatabases")]
        public virtual System.Collections.Generic.IList<MysqlDatabase> MysqlDatabases { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>MySQL source configuration</summary>
    public class MysqlSourceConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>MySQL objects to exclude from the stream.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludeObjects")]
        public virtual MysqlRdbms ExcludeObjects { get; set; }

        /// <summary>MySQL objects to retrieve from the source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeObjects")]
        public virtual MysqlRdbms IncludeObjects { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>MySQL SSL configuration information.</summary>
    public class MysqlSslConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Input only. PEM-encoded certificate of the CA that signed the source database server's certificate.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caCertificate")]
        public virtual string CaCertificate { get; set; }

        /// <summary>Output only. Indicates whether the ca_certificate field is set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caCertificateSet")]
        public virtual System.Nullable<bool> CaCertificateSet { get; set; }

        /// <summary>
        /// Input only. PEM-encoded certificate that will be used by the replica to authenticate against the source
        /// database server. If this field is used then the 'client_key' and the 'ca_certificate' fields are mandatory.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientCertificate")]
        public virtual string ClientCertificate { get; set; }

        /// <summary>Output only. Indicates whether the client_certificate field is set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientCertificateSet")]
        public virtual System.Nullable<bool> ClientCertificateSet { get; set; }

        /// <summary>
        /// Input only. PEM-encoded private key associated with the Client Certificate. If this field is used then the
        /// 'client_certificate' and the 'ca_certificate' fields are mandatory.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientKey")]
        public virtual string ClientKey { get; set; }

        /// <summary>Output only. Indicates whether the client_key field is set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientKeySet")]
        public virtual System.Nullable<bool> ClientKeySet { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>MySQL table.</summary>
    public class MysqlTable : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// MySQL columns in the database. When unspecified as part of include/exclude objects, includes/excludes
        /// everything.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mysqlColumns")]
        public virtual System.Collections.Generic.IList<MysqlColumn> MysqlColumns { get; set; }

        /// <summary>Table name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("table")]
        public virtual string Table { get; set; }

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

    /// <summary>Represents the metadata of the long-running operation.</summary>
    public class OperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. API version used to start the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; }

        /// <summary>Output only. The time the operation was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. The time the operation finished running.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>
        /// Output only. Identifies whether the user has requested cancellation of the operation. Operations that have
        /// successfully been cancelled have Operation.error value with a google.rpc.Status.code of 1, corresponding to
        /// `Code.CANCELLED`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedCancellation")]
        public virtual System.Nullable<bool> RequestedCancellation { get; set; }

        /// <summary>Output only. Human-readable status of the operation, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusMessage")]
        public virtual string StatusMessage { get; set; }

        /// <summary>Output only. Server-defined resource path for the target of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual string Target { get; set; }

        /// <summary>Output only. Results of executed validations if there are any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validationResult")]
        public virtual ValidationResult ValidationResult { get; set; }

        /// <summary>Output only. Name of the verb executed by the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verb")]
        public virtual string Verb { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Oracle Column.</summary>
    public class OracleColumn : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Column name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("column")]
        public virtual string Column { get; set; }

        /// <summary>The Oracle data type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataType")]
        public virtual string DataType { get; set; }

        /// <summary>Column encoding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encoding")]
        public virtual string Encoding { get; set; }

        /// <summary>Column length.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("length")]
        public virtual System.Nullable<int> Length { get; set; }

        /// <summary>Whether or not the column can accept a null value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nullable")]
        public virtual System.Nullable<bool> Nullable { get; set; }

        /// <summary>The ordinal position of the column in the table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ordinalPosition")]
        public virtual System.Nullable<int> OrdinalPosition { get; set; }

        /// <summary>Column precision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("precision")]
        public virtual System.Nullable<int> Precision { get; set; }

        /// <summary>Whether or not the column represents a primary key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryKey")]
        public virtual System.Nullable<bool> PrimaryKey { get; set; }

        /// <summary>Column scale.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scale")]
        public virtual System.Nullable<int> Scale { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Oracle data source object identifier.</summary>
    public class OracleObjectIdentifier : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The schema name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schema")]
        public virtual string Schema { get; set; }

        /// <summary>Required. The table name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("table")]
        public virtual string Table { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Oracle database profile.</summary>
    public class OracleProfile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Connection string attributes</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectionAttributes")]
        public virtual System.Collections.Generic.IDictionary<string, string> ConnectionAttributes { get; set; }

        /// <summary>Required. Database for the Oracle connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseService")]
        public virtual string DatabaseService { get; set; }

        /// <summary>Required. Hostname for the Oracle connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostname")]
        public virtual string Hostname { get; set; }

        /// <summary>Required. Password for the Oracle connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual string Password { get; set; }

        /// <summary>Port for the Oracle connection, default value is 1521.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("port")]
        public virtual System.Nullable<int> Port { get; set; }

        /// <summary>Required. Username for the Oracle connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Oracle database structure.</summary>
    public class OracleRdbms : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Oracle schemas/databases in the database server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oracleSchemas")]
        public virtual System.Collections.Generic.IList<OracleSchema> OracleSchemas { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Oracle schema.</summary>
    public class OracleSchema : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Tables in the schema.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oracleTables")]
        public virtual System.Collections.Generic.IList<OracleTable> OracleTables { get; set; }

        /// <summary>Schema name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schema")]
        public virtual string Schema { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Oracle data source configuration</summary>
    public class OracleSourceConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Oracle objects to exclude from the stream.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludeObjects")]
        public virtual OracleRdbms ExcludeObjects { get; set; }

        /// <summary>Oracle objects to include in the stream.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeObjects")]
        public virtual OracleRdbms IncludeObjects { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Oracle table.</summary>
    public class OracleTable : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Oracle columns in the schema. When unspecified as part of include/exclude objects, includes/excludes
        /// everything.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oracleColumns")]
        public virtual System.Collections.Generic.IList<OracleColumn> OracleColumns { get; set; }

        /// <summary>Table name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("table")]
        public virtual string Table { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The PrivateConnection resource is used to establish private connectivity between Datastream and a customer's
    /// network.
    /// </summary>
    public class PrivateConnection : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The create time of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Required. Display name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Output only. In case of error, the details of the error in a user-friendly format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Error Error { get; set; }

        /// <summary>Labels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Output only. The resource's name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The state of the Private Connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. The update time of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>VPC Peering Config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vpcPeeringConfig")]
        public virtual VpcPeeringConfig VpcPeeringConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Private Connectivity</summary>
    public class PrivateConnectivity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. A reference to a private connection resource. Format:
        /// `projects/{project}/locations/{location}/privateConnections/{name}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateConnection")]
        public virtual string PrivateConnection { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The route resource is the child of the private connection resource, used for defining a route for a private
    /// connection.
    /// </summary>
    public class Route : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The create time of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Required. Destination address for connection</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationAddress")]
        public virtual string DestinationAddress { get; set; }

        /// <summary>Destination port for connection</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationPort")]
        public virtual System.Nullable<int> DestinationPort { get; set; }

        /// <summary>Required. Display name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Labels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Output only. The resource's name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The update time of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The configuration of the stream source.</summary>
    public class SourceConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>MySQL data source configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mysqlSourceConfig")]
        public virtual MysqlSourceConfig MysqlSourceConfig { get; set; }

        /// <summary>Oracle data source configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oracleSourceConfig")]
        public virtual OracleSourceConfig OracleSourceConfig { get; set; }

        /// <summary>
        /// Required. Source connection profile resoource. Format:
        /// `projects/{project}/locations/{location}/connectionProfiles/{name}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceConnectionProfile")]
        public virtual string SourceConnectionProfile { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an identifier of an object in the data source.</summary>
    public class SourceObjectIdentifier : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Mysql data source object identifier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mysqlIdentifier")]
        public virtual MysqlObjectIdentifier MysqlIdentifier { get; set; }

        /// <summary>Oracle data source object identifier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oracleIdentifier")]
        public virtual OracleObjectIdentifier OracleIdentifier { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for manually initiating a backfill job for a specific stream object.</summary>
    public class StartBackfillJobRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for manually initiating a backfill job for a specific stream object.</summary>
    public class StartBackfillJobResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The stream object resource a backfill job was started for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("object")]
        public virtual StreamObject Object__ { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Static IP address connectivity.</summary>
    public class StaticServiceIpConnectivity : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>Request for manually stopping a running backfill job for a specific stream object.</summary>
    public class StopBackfillJobRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for manually stop a backfill job for a specific stream object.</summary>
    public class StopBackfillJobResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The stream object resource the backfill job was stopped for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("object")]
        public virtual StreamObject Object__ { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A resource representing streaming data from a source to a destination.</summary>
    public class Stream : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Automatically backfill objects included in the stream source configuration. Specific objects can be
        /// excluded.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backfillAll")]
        public virtual BackfillAllStrategy BackfillAll { get; set; }

        /// <summary>Do not automatically backfill any objects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backfillNone")]
        public virtual BackfillNoneStrategy BackfillNone { get; set; }

        /// <summary>Output only. The creation time of the stream.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Immutable. A reference to a KMS encryption key. If provided, it will be used to encrypt the data. If left
        /// blank, data will be encrypted using an internal Stream-specific encryption key provisioned through KMS.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerManagedEncryptionKey")]
        public virtual string CustomerManagedEncryptionKey { get; set; }

        /// <summary>Required. Destination connection profile configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationConfig")]
        public virtual DestinationConfig DestinationConfig { get; set; }

        /// <summary>Required. Display name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Output only. Errors on the Stream.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual System.Collections.Generic.IList<Error> Errors { get; set; }

        /// <summary>Labels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Output only. The stream's name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. Source connection profile configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceConfig")]
        public virtual SourceConfig SourceConfig { get; set; }

        /// <summary>The state of the stream.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. The last update time of the stream.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A specific stream object (e.g a specific DB table).</summary>
    public class StreamObject : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The latest backfill job that was initiated for the stream object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backfillJob")]
        public virtual BackfillJob BackfillJob { get; set; }

        /// <summary>Output only. The creation time of the object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Required. Display name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Output only. Active errors on the object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual System.Collections.Generic.IList<Error> Errors { get; set; }

        /// <summary>Output only. The object resource's name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The object identifier in the data source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceObject")]
        public virtual SourceObjectIdentifier SourceObject { get; set; }

        /// <summary>Output only. The last update time of the object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A validation to perform on a stream.</summary>
    public class Validation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A custom code identifying this validation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>A short description of the validation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Messages reflecting the validation results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual System.Collections.Generic.IList<ValidationMessage> Message { get; set; }

        /// <summary>Validation execution status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represent user-facing validation result message.</summary>
    public class ValidationMessage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A custom code identifying this specific message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>Message severity level (warning or error).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("level")]
        public virtual string Level { get; set; }

        /// <summary>The result of the validation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>Additional metadata related to the result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, string> Metadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains the current validation results.</summary>
    public class ValidationResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of validations (includes both executed as well as not executed validations).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validations")]
        public virtual System.Collections.Generic.IList<Validation> Validations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The VPC Peering configuration is used to create VPC peering between Datastream and the consumer's VPC.
    /// </summary>
    public class VpcPeeringConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. A free subnet for peering. (CIDR of /29) TODO(b/172995841) add validators.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subnet")]
        public virtual string Subnet { get; set; }

        /// <summary>
        /// Required. Fully qualified name of the VPC that Datastream will peer to. Format:
        /// `projects/{project}/global/{networks}/{name}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vpc")]
        public virtual string Vpc { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
