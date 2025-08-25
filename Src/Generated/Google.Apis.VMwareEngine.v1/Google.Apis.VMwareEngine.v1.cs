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

namespace Google.Apis.VMwareEngine.v1
{
    /// <summary>The VMwareEngine Service.</summary>
    public class VMwareEngineService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public VMwareEngineService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public VMwareEngineService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://vmwareengine.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://vmwareengine.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "vmwareengine";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the VMware Engine API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the VMware Engine API.</summary>
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

    /// <summary>A base abstract class for VMwareEngine requests.</summary>
    public abstract class VMwareEngineBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new VMwareEngineBaseServiceRequest instance.</summary>
        protected VMwareEngineBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes VMwareEngine parameter list.</summary>
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
                Announcements = new AnnouncementsResource(service);
                DnsBindPermission = new DnsBindPermissionResource(service);
                NetworkPeerings = new NetworkPeeringsResource(service);
                NetworkPolicies = new NetworkPoliciesResource(service);
                NodeTypes = new NodeTypesResource(service);
                Operations = new OperationsResource(service);
                PrivateClouds = new PrivateCloudsResource(service);
                PrivateConnections = new PrivateConnectionsResource(service);
                VmwareEngineNetworks = new VmwareEngineNetworksResource(service);
            }

            /// <summary>Gets the Announcements resource.</summary>
            public virtual AnnouncementsResource Announcements { get; }

            /// <summary>The "announcements" collection of methods.</summary>
            public class AnnouncementsResource
            {
                private const string Resource = "announcements";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public AnnouncementsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Retrieves a `Announcement` by its resource name.</summary>
                /// <param name="name">
                /// Required. The resource name of the announcement to retrieve. Resource names are schemeless URIs that
                /// follow the conventions in https://cloud.google.com/apis/design/resource_names. For example:
                /// `projects/my-project/locations/us-west1-a/announcements/announcement-uuid`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Retrieves a `Announcement` by its resource name.</summary>
                public class GetRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.Announcement>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the announcement to retrieve. Resource names are schemeless URIs
                    /// that follow the conventions in https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-project/locations/us-west1-a/announcements/announcement-uuid`
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/announcements/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists `Announcements` for a given region and project</summary>
                /// <param name="parent">
                /// Required. The resource name of the location to be queried for announcements. Resource names are
                /// schemeless URIs that follow the conventions in https://cloud.google.com/apis/design/resource_names.
                /// For example: `projects/my-project/locations/us-west1-a`
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists `Announcements` for a given region and project</summary>
                public class ListRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.ListAnnouncementsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the location to be queried for announcements. Resource names are
                    /// schemeless URIs that follow the conventions in
                    /// https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-project/locations/us-west1-a`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// A filter expression that matches resources returned in the response. The expression must specify
                    /// the field name, a comparison operator, and the value that you want to use for filtering. The
                    /// value must be a string, a number, or a boolean. The comparison operator must be `=`, `!=`,
                    /// `&amp;gt;`, or `&amp;lt;`. For example, if you are filtering a list of announcement runs, you
                    /// can exclude the ones named `example-announcement` by specifying `name !=
                    /// "example-announcement"`. You can also filter nested fields. To filter on multiple expressions,
                    /// provide each separate expression within parentheses. For example:
                    /// ```
                    /// (name =
                    /// "example-announcement") (createTime &amp;gt; "2021-04-12T08:15:10.40Z")
                    /// ```
                    /// By default, each
                    /// expression is an `AND` expression. However, you can include `AND` and `OR` expressions
                    /// explicitly. For example:
                    /// ```
                    /// (name = "announcement-1") AND (createTime &amp;gt;
                    /// "2021-04-12T08:15:10.40Z") OR (name = "announcement-2")
                    /// ```
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Sorts list results by a certain order. By default, returned results are ordered by `name` in
                    /// ascending order. You can also sort results in descending order based on the `name` value using
                    /// `orderBy="name desc"`. Currently, only ordering by `name` is supported.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// The maximum number of announcements to return in one page. The service may return fewer than
                    /// this value. The maximum value is coerced to 1000. The default value of this field is 500.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A page token, received from a previous `ListAnnouncements` call. Provide this to retrieve the
                    /// subsequent page. When paginating, all other parameters provided to `ListAnnouncements` must
                    /// match the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/announcements";

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

            /// <summary>Gets the DnsBindPermission resource.</summary>
            public virtual DnsBindPermissionResource DnsBindPermission { get; }

            /// <summary>The "dnsBindPermission" collection of methods.</summary>
            public class DnsBindPermissionResource
            {
                private const string Resource = "dnsBindPermission";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public DnsBindPermissionResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Grants the bind permission to the customer provided principal(user / service account) to bind their
                /// DNS zone with the intranet VPC associated with the project. DnsBindPermission is a global resource
                /// and location can only be global.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The name of the resource which stores the users/service accounts having the permission to
                /// bind to the corresponding intranet VPC of the consumer project. DnsBindPermission is a global
                /// resource. Resource names are schemeless URIs that follow the conventions in
                /// https://cloud.google.com/apis/design/resource_names. For example:
                /// `projects/my-project/locations/global/dnsBindPermission`
                /// </param>
                public virtual GrantRequest Grant(Google.Apis.VMwareEngine.v1.Data.GrantDnsBindPermissionRequest body, string name)
                {
                    return new GrantRequest(this.service, body, name);
                }

                /// <summary>
                /// Grants the bind permission to the customer provided principal(user / service account) to bind their
                /// DNS zone with the intranet VPC associated with the project. DnsBindPermission is a global resource
                /// and location can only be global.
                /// </summary>
                public class GrantRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Grant request.</summary>
                    public GrantRequest(Google.Apis.Services.IClientService service, Google.Apis.VMwareEngine.v1.Data.GrantDnsBindPermissionRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the resource which stores the users/service accounts having the permission
                    /// to bind to the corresponding intranet VPC of the consumer project. DnsBindPermission is a global
                    /// resource. Resource names are schemeless URIs that follow the conventions in
                    /// https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-project/locations/global/dnsBindPermission`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.VMwareEngine.v1.Data.GrantDnsBindPermissionRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "grant";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:grant";

                    /// <summary>Initializes Grant parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/dnsBindPermission$",
                        });
                    }
                }

                /// <summary>
                /// Revokes the bind permission from the customer provided principal(user / service account) on the
                /// intranet VPC associated with the consumer project. DnsBindPermission is a global resource and
                /// location can only be global.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The name of the resource which stores the users/service accounts having the permission to
                /// bind to the corresponding intranet VPC of the consumer project. DnsBindPermission is a global
                /// resource. Resource names are schemeless URIs that follow the conventions in
                /// https://cloud.google.com/apis/design/resource_names. For example:
                /// `projects/my-project/locations/global/dnsBindPermission`
                /// </param>
                public virtual RevokeRequest Revoke(Google.Apis.VMwareEngine.v1.Data.RevokeDnsBindPermissionRequest body, string name)
                {
                    return new RevokeRequest(this.service, body, name);
                }

                /// <summary>
                /// Revokes the bind permission from the customer provided principal(user / service account) on the
                /// intranet VPC associated with the consumer project. DnsBindPermission is a global resource and
                /// location can only be global.
                /// </summary>
                public class RevokeRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Revoke request.</summary>
                    public RevokeRequest(Google.Apis.Services.IClientService service, Google.Apis.VMwareEngine.v1.Data.RevokeDnsBindPermissionRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the resource which stores the users/service accounts having the permission
                    /// to bind to the corresponding intranet VPC of the consumer project. DnsBindPermission is a global
                    /// resource. Resource names are schemeless URIs that follow the conventions in
                    /// https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-project/locations/global/dnsBindPermission`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.VMwareEngine.v1.Data.RevokeDnsBindPermissionRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "revoke";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:revoke";

                    /// <summary>Initializes Revoke parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/dnsBindPermission$",
                        });
                    }
                }
            }

            /// <summary>Gets the NetworkPeerings resource.</summary>
            public virtual NetworkPeeringsResource NetworkPeerings { get; }

            /// <summary>The "networkPeerings" collection of methods.</summary>
            public class NetworkPeeringsResource
            {
                private const string Resource = "networkPeerings";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public NetworkPeeringsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    PeeringRoutes = new PeeringRoutesResource(service);
                }

                /// <summary>Gets the PeeringRoutes resource.</summary>
                public virtual PeeringRoutesResource PeeringRoutes { get; }

                /// <summary>The "peeringRoutes" collection of methods.</summary>
                public class PeeringRoutesResource
                {
                    private const string Resource = "peeringRoutes";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public PeeringRoutesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Lists the network peering routes exchanged over a peering connection. NetworkPeering is a global
                    /// resource and location can only be global.
                    /// </summary>
                    /// <param name="parent">
                    /// Required. The resource name of the network peering to retrieve peering routes from. Resource
                    /// names are schemeless URIs that follow the conventions in
                    /// https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-project/locations/global/networkPeerings/my-peering`
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>
                    /// Lists the network peering routes exchanged over a peering connection. NetworkPeering is a global
                    /// resource and location can only be global.
                    /// </summary>
                    public class ListRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.ListPeeringRoutesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the network peering to retrieve peering routes from. Resource
                        /// names are schemeless URIs that follow the conventions in
                        /// https://cloud.google.com/apis/design/resource_names. For example:
                        /// `projects/my-project/locations/global/networkPeerings/my-peering`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// A filter expression that matches resources returned in the response. Currently, only
                        /// filtering on the `direction` field is supported. To return routes imported from the peer
                        /// network, provide "direction=INCOMING". To return routes exported from the VMware Engine
                        /// network, provide "direction=OUTGOING". Other filter expressions return an error.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// The maximum number of peering routes to return in one page. The service may return fewer
                        /// than this value. The maximum value is coerced to 1000. The default value of this field is
                        /// 500.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// A page token, received from a previous `ListPeeringRoutes` call. Provide this to retrieve
                        /// the subsequent page. When paginating, all other parameters provided to `ListPeeringRoutes`
                        /// must match the call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/peeringRoutes";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/networkPeerings/[^/]+$",
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

                /// <summary>
                /// Creates a new network peering between the peer network and VMware Engine network provided in a
                /// `NetworkPeering` resource. NetworkPeering is a global resource and location can only be global.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The resource name of the location to create the new network peering in. This value is
                /// always `global`, because `NetworkPeering` is a global resource. Resource names are schemeless URIs
                /// that follow the conventions in https://cloud.google.com/apis/design/resource_names. For example:
                /// `projects/my-project/locations/global`
                /// </param>
                public virtual CreateRequest Create(Google.Apis.VMwareEngine.v1.Data.NetworkPeering body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>
                /// Creates a new network peering between the peer network and VMware Engine network provided in a
                /// `NetworkPeering` resource. NetworkPeering is a global resource and location can only be global.
                /// </summary>
                public class CreateRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.VMwareEngine.v1.Data.NetworkPeering body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the location to create the new network peering in. This value is
                    /// always `global`, because `NetworkPeering` is a global resource. Resource names are schemeless
                    /// URIs that follow the conventions in https://cloud.google.com/apis/design/resource_names. For
                    /// example: `projects/my-project/locations/global`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The user-provided identifier of the new `NetworkPeering`. This identifier must be
                    /// unique among `NetworkPeering` resources within the parent and becomes the final token in the
                    /// name URI. The identifier must meet the following requirements: * Only contains 1-63 alphanumeric
                    /// characters and hyphens * Begins with an alphabetical character * Ends with a non-hyphen
                    /// character * Not formatted as a UUID * Complies with [RFC
                    /// 1034](https://datatracker.ietf.org/doc/html/rfc1034) (section 3.5)
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("networkPeeringId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string NetworkPeeringId { get; set; }

                    /// <summary>
                    /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server will know to ignore the request if it has already been completed.
                    /// The server guarantees that a request doesn't result in creation of duplicate commitments for at
                    /// least 60 minutes. For example, consider a situation where you make an initial request and the
                    /// request times out. If you make the request again with the same request ID, the server can check
                    /// if original operation with the same request ID was received, and if so, will ignore the second
                    /// request. This prevents clients from accidentally creating duplicate commitments. The request ID
                    /// must be a valid UUID with the exception that zero UUID is not supported
                    /// (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.VMwareEngine.v1.Data.NetworkPeering Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/networkPeerings";

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
                        RequestParameters.Add("networkPeeringId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "networkPeeringId",
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

                /// <summary>
                /// Deletes a `NetworkPeering` resource. When a network peering is deleted for a VMware Engine network,
                /// the peer network becomes inaccessible to that VMware Engine network. NetworkPeering is a global
                /// resource and location can only be global.
                /// </summary>
                /// <param name="name">
                /// Required. The resource name of the network peering to be deleted. Resource names are schemeless URIs
                /// that follow the conventions in https://cloud.google.com/apis/design/resource_names. For example:
                /// `projects/my-project/locations/global/networkPeerings/my-peering`
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>
                /// Deletes a `NetworkPeering` resource. When a network peering is deleted for a VMware Engine network,
                /// the peer network becomes inaccessible to that VMware Engine network. NetworkPeering is a global
                /// resource and location can only be global.
                /// </summary>
                public class DeleteRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the network peering to be deleted. Resource names are schemeless
                    /// URIs that follow the conventions in https://cloud.google.com/apis/design/resource_names. For
                    /// example: `projects/my-project/locations/global/networkPeerings/my-peering`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server will know to ignore the request if it has already been completed.
                    /// The server guarantees that a request doesn't result in creation of duplicate commitments for at
                    /// least 60 minutes. For example, consider a situation where you make an initial request and the
                    /// request times out. If you make the request again with the same request ID, the server can check
                    /// if original operation with the same request ID was received, and if so, will ignore the second
                    /// request. This prevents clients from accidentally creating duplicate commitments. The request ID
                    /// must be a valid UUID with the exception that zero UUID is not supported
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/networkPeerings/[^/]+$",
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
                /// Retrieves a `NetworkPeering` resource by its resource name. The resource contains details of the
                /// network peering, such as peered networks, import and export custom route configurations, and peering
                /// state. NetworkPeering is a global resource and location can only be global.
                /// </summary>
                /// <param name="name">
                /// Required. The resource name of the network peering to retrieve. Resource names are schemeless URIs
                /// that follow the conventions in https://cloud.google.com/apis/design/resource_names. For example:
                /// `projects/my-project/locations/global/networkPeerings/my-peering`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>
                /// Retrieves a `NetworkPeering` resource by its resource name. The resource contains details of the
                /// network peering, such as peered networks, import and export custom route configurations, and peering
                /// state. NetworkPeering is a global resource and location can only be global.
                /// </summary>
                public class GetRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.NetworkPeering>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the network peering to retrieve. Resource names are schemeless
                    /// URIs that follow the conventions in https://cloud.google.com/apis/design/resource_names. For
                    /// example: `projects/my-project/locations/global/networkPeerings/my-peering`
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/networkPeerings/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists `NetworkPeering` resources in a given project. NetworkPeering is a global resource and
                /// location can only be global.
                /// </summary>
                /// <param name="parent">
                /// Required. The resource name of the location (global) to query for network peerings. Resource names
                /// are schemeless URIs that follow the conventions in
                /// https://cloud.google.com/apis/design/resource_names. For example:
                /// `projects/my-project/locations/global`
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>
                /// Lists `NetworkPeering` resources in a given project. NetworkPeering is a global resource and
                /// location can only be global.
                /// </summary>
                public class ListRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.ListNetworkPeeringsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the location (global) to query for network peerings. Resource
                    /// names are schemeless URIs that follow the conventions in
                    /// https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-project/locations/global`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// A filter expression that matches resources returned in the response. The expression must specify
                    /// the field name, a comparison operator, and the value that you want to use for filtering. The
                    /// value must be a string, a number, or a boolean. The comparison operator must be `=`, `!=`,
                    /// `&amp;gt;`, or `&amp;lt;`. For example, if you are filtering a list of network peerings, you can
                    /// exclude the ones named `example-peering` by specifying `name != "example-peering"`. To filter on
                    /// multiple expressions, provide each separate expression within parentheses. For example:
                    /// ```
                    /// (name = "example-peering") (createTime &amp;gt; "2021-04-12T08:15:10.40Z")
                    /// ```
                    /// By default, each
                    /// expression is an `AND` expression. However, you can include `AND` and `OR` expressions
                    /// explicitly. For example:
                    /// ```
                    /// (name = "example-peering-1") AND (createTime &amp;gt;
                    /// "2021-04-12T08:15:10.40Z") OR (name = "example-peering-2")
                    /// ```
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Sorts list results by a certain order. By default, returned results are ordered by `name` in
                    /// ascending order. You can also sort results in descending order based on the `name` value using
                    /// `orderBy="name desc"`. Currently, only ordering by `name` is supported.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// The maximum number of network peerings to return in one page. The maximum value is coerced to
                    /// 1000. The default value of this field is 500.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A page token, received from a previous `ListNetworkPeerings` call. Provide this to retrieve the
                    /// subsequent page. When paginating, all other parameters provided to `ListNetworkPeerings` must
                    /// match the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/networkPeerings";

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

                /// <summary>
                /// Modifies a `NetworkPeering` resource. Only the `description` field can be updated. Only fields
                /// specified in `updateMask` are applied. NetworkPeering is a global resource and location can only be
                /// global.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Output only. Identifier. The resource name of the network peering. NetworkPeering is a global
                /// resource and location can only be global. Resource names are scheme-less URIs that follow the
                /// conventions in https://cloud.google.com/apis/design/resource_names. For example:
                /// `projects/my-project/locations/global/networkPeerings/my-peering`
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.VMwareEngine.v1.Data.NetworkPeering body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>
                /// Modifies a `NetworkPeering` resource. Only the `description` field can be updated. Only fields
                /// specified in `updateMask` are applied. NetworkPeering is a global resource and location can only be
                /// global.
                /// </summary>
                public class PatchRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.VMwareEngine.v1.Data.NetworkPeering body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Output only. Identifier. The resource name of the network peering. NetworkPeering is a global
                    /// resource and location can only be global. Resource names are scheme-less URIs that follow the
                    /// conventions in https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-project/locations/global/networkPeerings/my-peering`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server will know to ignore the request if it has already been completed.
                    /// The server guarantees that a request doesn't result in creation of duplicate commitments for at
                    /// least 60 minutes. For example, consider a situation where you make an initial request and the
                    /// request times out. If you make the request again with the same request ID, the server can check
                    /// if original operation with the same request ID was received, and if so, will ignore the second
                    /// request. This prevents clients from accidentally creating duplicate commitments. The request ID
                    /// must be a valid UUID with the exception that zero UUID is not supported
                    /// (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// Required. Field mask is used to specify the fields to be overwritten in the `NetworkPeering`
                    /// resource by the update. The fields specified in the `update_mask` are relative to the resource,
                    /// not the full request. A field will be overwritten if it is in the mask. If the user does not
                    /// provide a mask then all fields will be overwritten.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.VMwareEngine.v1.Data.NetworkPeering Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/networkPeerings/[^/]+$",
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
                    }
                }
            }

            /// <summary>Gets the NetworkPolicies resource.</summary>
            public virtual NetworkPoliciesResource NetworkPolicies { get; }

            /// <summary>The "networkPolicies" collection of methods.</summary>
            public class NetworkPoliciesResource
            {
                private const string Resource = "networkPolicies";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public NetworkPoliciesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    ExternalAccessRules = new ExternalAccessRulesResource(service);
                }

                /// <summary>Gets the ExternalAccessRules resource.</summary>
                public virtual ExternalAccessRulesResource ExternalAccessRules { get; }

                /// <summary>The "externalAccessRules" collection of methods.</summary>
                public class ExternalAccessRulesResource
                {
                    private const string Resource = "externalAccessRules";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ExternalAccessRulesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Creates a new external access rule in a given network policy.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The resource name of the network policy to create a new external access firewall rule
                    /// in. Resource names are schemeless URIs that follow the conventions in
                    /// https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-project/locations/us-central1/networkPolicies/my-policy`
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.VMwareEngine.v1.Data.ExternalAccessRule body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>Creates a new external access rule in a given network policy.</summary>
                    public class CreateRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.VMwareEngine.v1.Data.ExternalAccessRule body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the network policy to create a new external access firewall
                        /// rule in. Resource names are schemeless URIs that follow the conventions in
                        /// https://cloud.google.com/apis/design/resource_names. For example:
                        /// `projects/my-project/locations/us-central1/networkPolicies/my-policy`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. The user-provided identifier of the `ExternalAccessRule` to be created. This
                        /// identifier must be unique among `ExternalAccessRule` resources within the parent and becomes
                        /// the final token in the name URI. The identifier must meet the following requirements: * Only
                        /// contains 1-63 alphanumeric characters and hyphens * Begins with an alphabetical character *
                        /// Ends with a non-hyphen character * Not formatted as a UUID * Complies with [RFC
                        /// 1034](https://datatracker.ietf.org/doc/html/rfc1034) (section 3.5)
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("externalAccessRuleId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string ExternalAccessRuleId { get; set; }

                        /// <summary>
                        /// A request ID to identify requests. Specify a unique request ID so that if you must retry
                        /// your request, the server will know to ignore the request if it has already been completed.
                        /// The server guarantees that a request doesn't result in creation of duplicate commitments for
                        /// at least 60 minutes. For example, consider a situation where you make an initial request and
                        /// the request times out. If you make the request again with the same request ID, the server
                        /// can check if the original operation with the same request ID was received, and if so, will
                        /// ignore the second request. This prevents clients from accidentally creating duplicate
                        /// commitments. The request ID must be a valid UUID with the exception that zero UUID is not
                        /// supported (00000000-0000-0000-0000-000000000000).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RequestId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.VMwareEngine.v1.Data.ExternalAccessRule Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/externalAccessRules";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/networkPolicies/[^/]+$",
                            });
                            RequestParameters.Add("externalAccessRuleId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "externalAccessRuleId",
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

                    /// <summary>Deletes a single external access rule.</summary>
                    /// <param name="name">
                    /// Required. The resource name of the external access firewall rule to delete. Resource names are
                    /// schemeless URIs that follow the conventions in
                    /// https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-project/locations/us-central1/networkPolicies/my-policy/externalAccessRules/my-rule`
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Deletes a single external access rule.</summary>
                    public class DeleteRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the external access firewall rule to delete. Resource names
                        /// are schemeless URIs that follow the conventions in
                        /// https://cloud.google.com/apis/design/resource_names. For example:
                        /// `projects/my-project/locations/us-central1/networkPolicies/my-policy/externalAccessRules/my-rule`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must
                        /// retry your request, the server will know to ignore the request if it has already been
                        /// completed. The server guarantees that a request doesn't result in creation of duplicate
                        /// commitments for at least 60 minutes. For example, consider a situation where you make an
                        /// initial request and the request times out. If you make the request again with the same
                        /// request ID, the server can check if the original operation with the same request ID was
                        /// received, and if so, will ignore the second request. This prevents clients from accidentally
                        /// creating duplicate commitments. The request ID must be a valid UUID with the exception that
                        /// zero UUID is not supported (00000000-0000-0000-0000-000000000000).
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/networkPolicies/[^/]+/externalAccessRules/[^/]+$",
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

                    /// <summary>Gets details of a single external access rule.</summary>
                    /// <param name="name">
                    /// Required. The resource name of the external access firewall rule to retrieve. Resource names are
                    /// schemeless URIs that follow the conventions in
                    /// https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-project/locations/us-central1/networkPolicies/my-policy/externalAccessRules/my-rule`
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets details of a single external access rule.</summary>
                    public class GetRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.ExternalAccessRule>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the external access firewall rule to retrieve. Resource names
                        /// are schemeless URIs that follow the conventions in
                        /// https://cloud.google.com/apis/design/resource_names. For example:
                        /// `projects/my-project/locations/us-central1/networkPolicies/my-policy/externalAccessRules/my-rule`
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/networkPolicies/[^/]+/externalAccessRules/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists `ExternalAccessRule` resources in the specified network policy.</summary>
                    /// <param name="parent">
                    /// Required. The resource name of the network policy to query for external access firewall rules.
                    /// Resource names are schemeless URIs that follow the conventions in
                    /// https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-project/locations/us-central1/networkPolicies/my-policy`
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists `ExternalAccessRule` resources in the specified network policy.</summary>
                    public class ListRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.ListExternalAccessRulesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the network policy to query for external access firewall
                        /// rules. Resource names are schemeless URIs that follow the conventions in
                        /// https://cloud.google.com/apis/design/resource_names. For example:
                        /// `projects/my-project/locations/us-central1/networkPolicies/my-policy`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// A filter expression that matches resources returned in the response. The expression must
                        /// specify the field name, a comparison operator, and the value that you want to use for
                        /// filtering. The value must be a string, a number, or a boolean. The comparison operator must
                        /// be `=`, `!=`, `&amp;gt;`, or `&amp;lt;`. For example, if you are filtering a list of
                        /// external access rules, you can exclude the ones named `example-rule` by specifying `name !=
                        /// "example-rule"`. To filter on multiple expressions, provide each separate expression within
                        /// parentheses. For example:
                        /// ```
                        /// (name = "example-rule") (createTime &amp;gt;
                        /// "2021-04-12T08:15:10.40Z")
                        /// ```
                        /// By default, each expression is an `AND` expression. However,
                        /// you can include `AND` and `OR` expressions explicitly. For example:
                        /// ```
                        /// (name =
                        /// "example-rule-1") AND (createTime &amp;gt; "2021-04-12T08:15:10.40Z") OR (name =
                        /// "example-rule-2")
                        /// ```
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// Sorts list results by a certain order. By default, returned results are ordered by `name` in
                        /// ascending order. You can also sort results in descending order based on the `name` value
                        /// using `orderBy="name desc"`. Currently, only ordering by `name` is supported.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>
                        /// The maximum number of external access rules to return in one page. The service may return
                        /// fewer than this value. The maximum value is coerced to 1000. The default value of this field
                        /// is 500.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// A page token, received from a previous `ListExternalAccessRulesRequest` call. Provide this
                        /// to retrieve the subsequent page. When paginating, all other parameters provided to
                        /// `ListExternalAccessRulesRequest` must match the call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/externalAccessRules";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/networkPolicies/[^/]+$",
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

                    /// <summary>
                    /// Updates the parameters of a single external access rule. Only fields specified in `update_mask`
                    /// are applied.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Output only. The resource name of this external access rule. Resource names are schemeless URIs
                    /// that follow the conventions in https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-project/locations/us-central1/networkPolicies/my-policy/externalAccessRules/my-rule`
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.VMwareEngine.v1.Data.ExternalAccessRule body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>
                    /// Updates the parameters of a single external access rule. Only fields specified in `update_mask`
                    /// are applied.
                    /// </summary>
                    public class PatchRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.VMwareEngine.v1.Data.ExternalAccessRule body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Output only. The resource name of this external access rule. Resource names are schemeless
                        /// URIs that follow the conventions in https://cloud.google.com/apis/design/resource_names. For
                        /// example:
                        /// `projects/my-project/locations/us-central1/networkPolicies/my-policy/externalAccessRules/my-rule`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must
                        /// retry your request, the server will know to ignore the request if it has already been
                        /// completed. The server guarantees that a request doesn't result in creation of duplicate
                        /// commitments for at least 60 minutes. For example, consider a situation where you make an
                        /// initial request and the request times out. If you make the request again with the same
                        /// request ID, the server can check if the original operation with the same request ID was
                        /// received, and if so, will ignore the second request. This prevents clients from accidentally
                        /// creating duplicate commitments. The request ID must be a valid UUID with the exception that
                        /// zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RequestId { get; set; }

                        /// <summary>
                        /// Required. Field mask is used to specify the fields to be overwritten in the
                        /// `ExternalAccessRule` resource by the update. The fields specified in the `update_mask` are
                        /// relative to the resource, not the full request. A field will be overwritten if it is in the
                        /// mask. If the user does not provide a mask then all fields will be overwritten.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.VMwareEngine.v1.Data.ExternalAccessRule Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/networkPolicies/[^/]+/externalAccessRules/[^/]+$",
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
                        }
                    }
                }

                /// <summary>
                /// Creates a new network policy in a given VMware Engine network of a project and location (region). A
                /// new network policy cannot be created if another network policy already exists in the same scope.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The resource name of the location (region) to create the new network policy in. Resource
                /// names are schemeless URIs that follow the conventions in
                /// https://cloud.google.com/apis/design/resource_names. For example:
                /// `projects/my-project/locations/us-central1`
                /// </param>
                public virtual CreateRequest Create(Google.Apis.VMwareEngine.v1.Data.NetworkPolicy body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>
                /// Creates a new network policy in a given VMware Engine network of a project and location (region). A
                /// new network policy cannot be created if another network policy already exists in the same scope.
                /// </summary>
                public class CreateRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.VMwareEngine.v1.Data.NetworkPolicy body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the location (region) to create the new network policy in.
                    /// Resource names are schemeless URIs that follow the conventions in
                    /// https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-project/locations/us-central1`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The user-provided identifier of the network policy to be created. This identifier must
                    /// be unique within parent `projects/{my-project}/locations/{us-central1}/networkPolicies` and
                    /// becomes the final token in the name URI. The identifier must meet the following requirements: *
                    /// Only contains 1-63 alphanumeric characters and hyphens * Begins with an alphabetical character *
                    /// Ends with a non-hyphen character * Not formatted as a UUID * Complies with [RFC
                    /// 1034](https://datatracker.ietf.org/doc/html/rfc1034) (section 3.5)
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("networkPolicyId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string NetworkPolicyId { get; set; }

                    /// <summary>
                    /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server will know to ignore the request if it has already been completed.
                    /// The server guarantees that a request doesn't result in creation of duplicate commitments for at
                    /// least 60 minutes. For example, consider a situation where you make an initial request and the
                    /// request times out. If you make the request again with the same request ID, the server can check
                    /// if original operation with the same request ID was received, and if so, will ignore the second
                    /// request. This prevents clients from accidentally creating duplicate commitments. The request ID
                    /// must be a valid UUID with the exception that zero UUID is not supported
                    /// (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.VMwareEngine.v1.Data.NetworkPolicy Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/networkPolicies";

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
                        RequestParameters.Add("networkPolicyId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "networkPolicyId",
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

                /// <summary>
                /// Deletes a `NetworkPolicy` resource. A network policy cannot be deleted when `NetworkService.state`
                /// is set to `RECONCILING` for either its external IP or internet access service.
                /// </summary>
                /// <param name="name">
                /// Required. The resource name of the network policy to delete. Resource names are schemeless URIs that
                /// follow the conventions in https://cloud.google.com/apis/design/resource_names. For example:
                /// `projects/my-project/locations/us-central1/networkPolicies/my-network-policy`
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>
                /// Deletes a `NetworkPolicy` resource. A network policy cannot be deleted when `NetworkService.state`
                /// is set to `RECONCILING` for either its external IP or internet access service.
                /// </summary>
                public class DeleteRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the network policy to delete. Resource names are schemeless URIs
                    /// that follow the conventions in https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-project/locations/us-central1/networkPolicies/my-network-policy`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server will know to ignore the request if it has already been completed.
                    /// The server guarantees that a request doesn't result in creation of duplicate commitments for at
                    /// least 60 minutes. For example, consider a situation where you make an initial request and the
                    /// request times out. If you make the request again with the same request ID, the server can check
                    /// if original operation with the same request ID was received, and if so, will ignore the second
                    /// request. This prevents clients from accidentally creating duplicate commitments. The request ID
                    /// must be a valid UUID with the exception that zero UUID is not supported
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/networkPolicies/[^/]+$",
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
                /// Lists external IP addresses assigned to VMware workload VMs within the scope of the given network
                /// policy.
                /// </summary>
                /// <param name="networkPolicy">
                /// Required. The resource name of the network policy to query for assigned external IP addresses.
                /// Resource names are schemeless URIs that follow the conventions in
                /// https://cloud.google.com/apis/design/resource_names. For example:
                /// `projects/my-project/locations/us-central1/networkPolicies/my-policy`
                /// </param>
                public virtual FetchExternalAddressesRequest FetchExternalAddresses(string networkPolicy)
                {
                    return new FetchExternalAddressesRequest(this.service, networkPolicy);
                }

                /// <summary>
                /// Lists external IP addresses assigned to VMware workload VMs within the scope of the given network
                /// policy.
                /// </summary>
                public class FetchExternalAddressesRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.FetchNetworkPolicyExternalAddressesResponse>
                {
                    /// <summary>Constructs a new FetchExternalAddresses request.</summary>
                    public FetchExternalAddressesRequest(Google.Apis.Services.IClientService service, string networkPolicy) : base(service)
                    {
                        NetworkPolicy = networkPolicy;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the network policy to query for assigned external IP addresses.
                    /// Resource names are schemeless URIs that follow the conventions in
                    /// https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-project/locations/us-central1/networkPolicies/my-policy`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("networkPolicy", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string NetworkPolicy { get; private set; }

                    /// <summary>
                    /// The maximum number of external IP addresses to return in one page. The service may return fewer
                    /// than this value. The maximum value is coerced to 1000. The default value of this field is 500.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A page token, received from a previous `FetchNetworkPolicyExternalAddresses` call. Provide this
                    /// to retrieve the subsequent page. When paginating, all parameters provided to
                    /// `FetchNetworkPolicyExternalAddresses`, except for `page_size` and `page_token`, must match the
                    /// call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "fetchExternalAddresses";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+networkPolicy}:fetchExternalAddresses";

                    /// <summary>Initializes FetchExternalAddresses parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("networkPolicy", new Google.Apis.Discovery.Parameter
                        {
                            Name = "networkPolicy",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/networkPolicies/[^/]+$",
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

                /// <summary>Retrieves a `NetworkPolicy` resource by its resource name.</summary>
                /// <param name="name">
                /// Required. The resource name of the network policy to retrieve. Resource names are schemeless URIs
                /// that follow the conventions in https://cloud.google.com/apis/design/resource_names. For example:
                /// `projects/my-project/locations/us-central1/networkPolicies/my-network-policy`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Retrieves a `NetworkPolicy` resource by its resource name.</summary>
                public class GetRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.NetworkPolicy>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the network policy to retrieve. Resource names are schemeless
                    /// URIs that follow the conventions in https://cloud.google.com/apis/design/resource_names. For
                    /// example: `projects/my-project/locations/us-central1/networkPolicies/my-network-policy`
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/networkPolicies/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists `NetworkPolicy` resources in a specified project and location.</summary>
                /// <param name="parent">
                /// Required. The resource name of the location (region) to query for network policies. Resource names
                /// are schemeless URIs that follow the conventions in
                /// https://cloud.google.com/apis/design/resource_names. For example:
                /// `projects/my-project/locations/us-central1`
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists `NetworkPolicy` resources in a specified project and location.</summary>
                public class ListRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.ListNetworkPoliciesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the location (region) to query for network policies. Resource
                    /// names are schemeless URIs that follow the conventions in
                    /// https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-project/locations/us-central1`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// A filter expression that matches resources returned in the response. The expression must specify
                    /// the field name, a comparison operator, and the value that you want to use for filtering. The
                    /// value must be a string, a number, or a boolean. The comparison operator must be `=`, `!=`,
                    /// `&amp;gt;`, or `&amp;lt;`. For example, if you are filtering a list of network policies, you can
                    /// exclude the ones named `example-policy` by specifying `name != "example-policy"`. To filter on
                    /// multiple expressions, provide each separate expression within parentheses. For example:
                    /// ```
                    /// (name = "example-policy") (createTime &amp;gt; "2021-04-12T08:15:10.40Z")
                    /// ```
                    /// By default, each
                    /// expression is an `AND` expression. However, you can include `AND` and `OR` expressions
                    /// explicitly. For example:
                    /// ```
                    /// (name = "example-policy-1") AND (createTime &amp;gt;
                    /// "2021-04-12T08:15:10.40Z") OR (name = "example-policy-2")
                    /// ```
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Sorts list results by a certain order. By default, returned results are ordered by `name` in
                    /// ascending order. You can also sort results in descending order based on the `name` value using
                    /// `orderBy="name desc"`. Currently, only ordering by `name` is supported.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// The maximum number of network policies to return in one page. The service may return fewer than
                    /// this value. The maximum value is coerced to 1000. The default value of this field is 500.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A page token, received from a previous `ListNetworkPolicies` call. Provide this to retrieve the
                    /// subsequent page. When paginating, all other parameters provided to `ListNetworkPolicies` must
                    /// match the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/networkPolicies";

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

                /// <summary>
                /// Modifies a `NetworkPolicy` resource. Only the following fields can be updated: `internet_access`,
                /// `external_ip`, `edge_services_cidr`. Only fields specified in `updateMask` are applied. When
                /// updating a network policy, the external IP network service can only be disabled if there are no
                /// external IP addresses present in the scope of the policy. Also, a `NetworkService` cannot be updated
                /// when `NetworkService.state` is set to `RECONCILING`. During operation processing, the resource is
                /// temporarily in the `ACTIVE` state before the operation fully completes. For that period of time, you
                /// can't update the resource. Use the operation status to determine when the processing fully
                /// completes.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Output only. Identifier. The resource name of this network policy. Resource names are schemeless
                /// URIs that follow the conventions in https://cloud.google.com/apis/design/resource_names. For
                /// example: `projects/my-project/locations/us-central1/networkPolicies/my-network-policy`
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.VMwareEngine.v1.Data.NetworkPolicy body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>
                /// Modifies a `NetworkPolicy` resource. Only the following fields can be updated: `internet_access`,
                /// `external_ip`, `edge_services_cidr`. Only fields specified in `updateMask` are applied. When
                /// updating a network policy, the external IP network service can only be disabled if there are no
                /// external IP addresses present in the scope of the policy. Also, a `NetworkService` cannot be updated
                /// when `NetworkService.state` is set to `RECONCILING`. During operation processing, the resource is
                /// temporarily in the `ACTIVE` state before the operation fully completes. For that period of time, you
                /// can't update the resource. Use the operation status to determine when the processing fully
                /// completes.
                /// </summary>
                public class PatchRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.VMwareEngine.v1.Data.NetworkPolicy body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Output only. Identifier. The resource name of this network policy. Resource names are schemeless
                    /// URIs that follow the conventions in https://cloud.google.com/apis/design/resource_names. For
                    /// example: `projects/my-project/locations/us-central1/networkPolicies/my-network-policy`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server will know to ignore the request if it has already been completed.
                    /// The server guarantees that a request doesn't result in creation of duplicate commitments for at
                    /// least 60 minutes. For example, consider a situation where you make an initial request and the
                    /// request times out. If you make the request again with the same request ID, the server can check
                    /// if original operation with the same request ID was received, and if so, will ignore the second
                    /// request. This prevents clients from accidentally creating duplicate commitments. The request ID
                    /// must be a valid UUID with the exception that zero UUID is not supported
                    /// (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// Required. Field mask is used to specify the fields to be overwritten in the `NetworkPolicy`
                    /// resource by the update. The fields specified in the `update_mask` are relative to the resource,
                    /// not the full request. A field will be overwritten if it is in the mask. If the user does not
                    /// provide a mask then all fields will be overwritten.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.VMwareEngine.v1.Data.NetworkPolicy Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/networkPolicies/[^/]+$",
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
                    }
                }
            }

            /// <summary>Gets the NodeTypes resource.</summary>
            public virtual NodeTypesResource NodeTypes { get; }

            /// <summary>The "nodeTypes" collection of methods.</summary>
            public class NodeTypesResource
            {
                private const string Resource = "nodeTypes";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public NodeTypesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Gets details of a single `NodeType`.</summary>
                /// <param name="name">
                /// Required. The resource name of the node type to retrieve. Resource names are schemeless URIs that
                /// follow the conventions in https://cloud.google.com/apis/design/resource_names. For example:
                /// `projects/my-proj/locations/us-central1-a/nodeTypes/standard-72`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of a single `NodeType`.</summary>
                public class GetRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.NodeType>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the node type to retrieve. Resource names are schemeless URIs
                    /// that follow the conventions in https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-proj/locations/us-central1-a/nodeTypes/standard-72`
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/nodeTypes/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists node types</summary>
                /// <param name="parent">
                /// Required. The resource name of the location to be queried for node types. Resource names are
                /// schemeless URIs that follow the conventions in https://cloud.google.com/apis/design/resource_names.
                /// For example: `projects/my-project/locations/us-central1-a`
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists node types</summary>
                public class ListRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.ListNodeTypesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the location to be queried for node types. Resource names are
                    /// schemeless URIs that follow the conventions in
                    /// https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-project/locations/us-central1-a`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// A filter expression that matches resources returned in the response. The expression must specify
                    /// the field name, a comparison operator, and the value that you want to use for filtering. The
                    /// value must be a string, a number, or a boolean. The comparison operator must be `=`, `!=`,
                    /// `&amp;gt;`, or `&amp;lt;`. For example, if you are filtering a list of node types, you can
                    /// exclude the ones named `standard-72` by specifying `name != "standard-72"`. To filter on
                    /// multiple expressions, provide each separate expression within parentheses. For example:
                    /// ```
                    /// (name = "standard-72") (virtual_cpu_count &amp;gt; 2)
                    /// ```
                    /// By default, each expression is an
                    /// `AND` expression. However, you can include `AND` and `OR` expressions explicitly. For example:
                    /// ```
                    /// (name = "standard-96") AND (virtual_cpu_count &amp;gt; 2) OR (name = "standard-72")
                    /// ```
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// The maximum number of node types to return in one page. The service may return fewer than this
                    /// value. The maximum value is coerced to 1000. The default value of this field is 500.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A page token, received from a previous `ListNodeTypes` call. Provide this to retrieve the
                    /// subsequent page. When paginating, all other parameters provided to `ListNodeTypes` must match
                    /// the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/nodeTypes";

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
                public class DeleteRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.Empty>
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
                    return new GetRequest(this.service, name);
                }

                /// <summary>
                /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation
                /// result at intervals as recommended by the API service.
                /// </summary>
                public class GetRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.Operation>
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
                public class ListRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.ListOperationsResponse>
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

            /// <summary>Gets the PrivateClouds resource.</summary>
            public virtual PrivateCloudsResource PrivateClouds { get; }

            /// <summary>The "privateClouds" collection of methods.</summary>
            public class PrivateCloudsResource
            {
                private const string Resource = "privateClouds";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public PrivateCloudsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Clusters = new ClustersResource(service);
                    ExternalAddresses = new ExternalAddressesResource(service);
                    HcxActivationKeys = new HcxActivationKeysResource(service);
                    LoggingServers = new LoggingServersResource(service);
                    ManagementDnsZoneBindings = new ManagementDnsZoneBindingsResource(service);
                    Subnets = new SubnetsResource(service);
                    Upgrades = new UpgradesResource(service);
                }

                /// <summary>Gets the Clusters resource.</summary>
                public virtual ClustersResource Clusters { get; }

                /// <summary>The "clusters" collection of methods.</summary>
                public class ClustersResource
                {
                    private const string Resource = "clusters";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ClustersResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                        Nodes = new NodesResource(service);
                    }

                    /// <summary>Gets the Nodes resource.</summary>
                    public virtual NodesResource Nodes { get; }

                    /// <summary>The "nodes" collection of methods.</summary>
                    public class NodesResource
                    {
                        private const string Resource = "nodes";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public NodesResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                        }

                        /// <summary>Gets details of a single node.</summary>
                        /// <param name="name">
                        /// Required. The resource name of the node to retrieve. For example:
                        /// `projects/{project}/locations/{location}/privateClouds/{private_cloud}/clusters/{cluster}/nodes/{node}`
                        /// </param>
                        public virtual GetRequest Get(string name)
                        {
                            return new GetRequest(this.service, name);
                        }

                        /// <summary>Gets details of a single node.</summary>
                        public class GetRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.Node>
                        {
                            /// <summary>Constructs a new Get request.</summary>
                            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The resource name of the node to retrieve. For example:
                            /// `projects/{project}/locations/{location}/privateClouds/{private_cloud}/clusters/{cluster}/nodes/{node}`
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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/privateClouds/[^/]+/clusters/[^/]+/nodes/[^/]+$",
                                });
                            }
                        }

                        /// <summary>Lists nodes in a given cluster.</summary>
                        /// <param name="parent">
                        /// Required. The resource name of the cluster to be queried for nodes. Resource names are
                        /// schemeless URIs that follow the conventions in
                        /// https://cloud.google.com/apis/design/resource_names. For example:
                        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud/clusters/my-cluster`
                        /// </param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(this.service, parent);
                        }

                        /// <summary>Lists nodes in a given cluster.</summary>
                        public class ListRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.ListNodesResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The resource name of the cluster to be queried for nodes. Resource names are
                            /// schemeless URIs that follow the conventions in
                            /// https://cloud.google.com/apis/design/resource_names. For example:
                            /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud/clusters/my-cluster`
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// The maximum number of nodes to return in one page. The service may return fewer than
                            /// this value. The maximum value is coerced to 1000. The default value of this field is
                            /// 500.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>
                            /// A page token, received from a previous `ListNodes` call. Provide this to retrieve the
                            /// subsequent page. When paginating, all other parameters provided to `ListNodes` must
                            /// match the call that provided the page token.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/nodes";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/privateClouds/[^/]+/clusters/[^/]+$",
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

                    /// <summary>
                    /// Creates a new cluster in a given private cloud. Creating a new cluster provides additional nodes
                    /// for use in the parent private cloud and requires sufficient [node
                    /// quota](https://cloud.google.com/vmware-engine/quotas).
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The resource name of the private cloud to create a new cluster in. Resource names are
                    /// schemeless URIs that follow the conventions in
                    /// https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.VMwareEngine.v1.Data.Cluster body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>
                    /// Creates a new cluster in a given private cloud. Creating a new cluster provides additional nodes
                    /// for use in the parent private cloud and requires sufficient [node
                    /// quota](https://cloud.google.com/vmware-engine/quotas).
                    /// </summary>
                    public class CreateRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.VMwareEngine.v1.Data.Cluster body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the private cloud to create a new cluster in. Resource names
                        /// are schemeless URIs that follow the conventions in
                        /// https://cloud.google.com/apis/design/resource_names. For example:
                        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. The user-provided identifier of the new `Cluster`. This identifier must be unique
                        /// among clusters within the parent and becomes the final token in the name URI. The identifier
                        /// must meet the following requirements: * Only contains 1-63 alphanumeric characters and
                        /// hyphens * Begins with an alphabetical character * Ends with a non-hyphen character * Not
                        /// formatted as a UUID * Complies with [RFC
                        /// 1034](https://datatracker.ietf.org/doc/html/rfc1034) (section 3.5)
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("clusterId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string ClusterId { get; set; }

                        /// <summary>
                        /// Optional. The request ID must be a valid UUID with the exception that zero UUID is not
                        /// supported (00000000-0000-0000-0000-000000000000).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RequestId { get; set; }

                        /// <summary>
                        /// Optional. True if you want the request to be validated and not executed; false otherwise.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> ValidateOnly { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.VMwareEngine.v1.Data.Cluster Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/clusters";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/privateClouds/[^/]+$",
                            });
                            RequestParameters.Add("clusterId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "clusterId",
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

                    /// <summary>
                    /// Deletes a `Cluster` resource. To avoid unintended data loss, migrate or gracefully shut down any
                    /// workloads running on the cluster before deletion. You cannot delete the management cluster of a
                    /// private cloud using this method.
                    /// </summary>
                    /// <param name="name">
                    /// Required. The resource name of the cluster to delete. Resource names are schemeless URIs that
                    /// follow the conventions in https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud/clusters/my-cluster`
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>
                    /// Deletes a `Cluster` resource. To avoid unintended data loss, migrate or gracefully shut down any
                    /// workloads running on the cluster before deletion. You cannot delete the management cluster of a
                    /// private cloud using this method.
                    /// </summary>
                    public class DeleteRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the cluster to delete. Resource names are schemeless URIs
                        /// that follow the conventions in https://cloud.google.com/apis/design/resource_names. For
                        /// example:
                        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud/clusters/my-cluster`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. The request ID must be a valid UUID with the exception that zero UUID is not
                        /// supported (00000000-0000-0000-0000-000000000000).
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/privateClouds/[^/]+/clusters/[^/]+$",
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

                    /// <summary>Retrieves a `Cluster` resource by its resource name.</summary>
                    /// <param name="name">
                    /// Required. The cluster resource name to retrieve. Resource names are schemeless URIs that follow
                    /// the conventions in https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud/clusters/my-cluster`
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Retrieves a `Cluster` resource by its resource name.</summary>
                    public class GetRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.Cluster>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The cluster resource name to retrieve. Resource names are schemeless URIs that
                        /// follow the conventions in https://cloud.google.com/apis/design/resource_names. For example:
                        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud/clusters/my-cluster`
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/privateClouds/[^/]+/clusters/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Gets the access control policy for a resource. Returns an empty policy if the resource exists
                    /// and does not have a policy set.
                    /// </summary>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy is being requested. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </param>
                    public virtual GetIamPolicyRequest GetIamPolicy(string resource)
                    {
                        return new GetIamPolicyRequest(this.service, resource);
                    }

                    /// <summary>
                    /// Gets the access control policy for a resource. Returns an empty policy if the resource exists
                    /// and does not have a policy set.
                    /// </summary>
                    public class GetIamPolicyRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.Policy>
                    {
                        /// <summary>Constructs a new GetIamPolicy request.</summary>
                        public GetIamPolicyRequest(Google.Apis.Services.IClientService service, string resource) : base(service)
                        {
                            Resource = resource;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy is being requested. See [Resource
                        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for
                        /// this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>
                        /// Optional. The maximum policy version that will be used to format the policy. Valid values
                        /// are 0, 1, and 3. Requests specifying an invalid value will be rejected. Requests for
                        /// policies with any conditional role bindings must specify version 3. Policies with no
                        /// conditional role bindings may specify any valid value or leave the field unset. The policy
                        /// in the response might use the policy version that you specified, or it might use a lower
                        /// policy version. For example, if you specify version 3, but the policy has no conditional
                        /// role bindings, the response uses version 1. To learn which resources support conditions in
                        /// their IAM policies, see the [IAM
                        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("options.requestedPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> OptionsRequestedPolicyVersion { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "getIamPolicy";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+resource}:getIamPolicy";

                        /// <summary>Initializes GetIamPolicy parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                            {
                                Name = "resource",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/privateClouds/[^/]+/clusters/[^/]+$",
                            });
                            RequestParameters.Add("options.requestedPolicyVersion", new Google.Apis.Discovery.Parameter
                            {
                                Name = "options.requestedPolicyVersion",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Lists `Cluster` resources in a given private cloud.</summary>
                    /// <param name="parent">
                    /// Required. The resource name of the private cloud to query for clusters. Resource names are
                    /// schemeless URIs that follow the conventions in
                    /// https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists `Cluster` resources in a given private cloud.</summary>
                    public class ListRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.ListClustersResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the private cloud to query for clusters. Resource names are
                        /// schemeless URIs that follow the conventions in
                        /// https://cloud.google.com/apis/design/resource_names. For example:
                        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        ///  To filter on multiple expressions, provide each separate expression within parentheses. For
                        /// example:
                        /// ```
                        /// (name = "example-cluster") (nodeCount = "3")
                        /// ```
                        /// By default, each expression is
                        /// an `AND` expression. However, you can include `AND` and `OR` expressions explicitly. For
                        /// example:
                        /// ```
                        /// (name = "example-cluster-1") AND (createTime &amp;gt;
                        /// "2021-04-12T08:15:10.40Z") OR (name = "example-cluster-2")
                        /// ```
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// Sorts list results by a certain order. By default, returned results are ordered by `name` in
                        /// ascending order. You can also sort results in descending order based on the `name` value
                        /// using `orderBy="name desc"`. Currently, only ordering by `name` is supported.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>
                        /// The maximum number of clusters to return in one page. The service may return fewer than this
                        /// value. The maximum value is coerced to 1000. The default value of this field is 500.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// A page token, received from a previous `ListClusters` call. Provide this to retrieve the
                        /// subsequent page. When paginating, all other parameters provided to `ListClusters` must match
                        /// the call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/clusters";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/privateClouds/[^/]+$",
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

                    /// <summary>
                    /// Modifies a `Cluster` resource. Only fields specified in `updateMask` are applied. During
                    /// operation processing, the resource is temporarily in the `ACTIVE` state before the operation
                    /// fully completes. For that period of time, you can't update the resource. Use the operation
                    /// status to determine when the processing fully completes.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Output only. Identifier. The resource name of this cluster. Resource names are schemeless URIs
                    /// that follow the conventions in https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud/clusters/my-cluster`
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.VMwareEngine.v1.Data.Cluster body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>
                    /// Modifies a `Cluster` resource. Only fields specified in `updateMask` are applied. During
                    /// operation processing, the resource is temporarily in the `ACTIVE` state before the operation
                    /// fully completes. For that period of time, you can't update the resource. Use the operation
                    /// status to determine when the processing fully completes.
                    /// </summary>
                    public class PatchRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.VMwareEngine.v1.Data.Cluster body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Output only. Identifier. The resource name of this cluster. Resource names are schemeless
                        /// URIs that follow the conventions in https://cloud.google.com/apis/design/resource_names. For
                        /// example:
                        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud/clusters/my-cluster`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. The request ID must be a valid UUID with the exception that zero UUID is not
                        /// supported (00000000-0000-0000-0000-000000000000).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RequestId { get; set; }

                        /// <summary>
                        /// Required. Field mask is used to specify the fields to be overwritten in the `Cluster`
                        /// resource by the update. The fields specified in the `updateMask` are relative to the
                        /// resource, not the full request. A field will be overwritten if it is in the mask. If the
                        /// user does not provide a mask then all fields will be overwritten.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>
                        /// Optional. True if you want the request to be validated and not executed; false otherwise.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> ValidateOnly { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.VMwareEngine.v1.Data.Cluster Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/privateClouds/[^/]+/clusters/[^/]+$",
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

                    /// <summary>
                    /// Sets the access control policy on the specified resource. Replaces any existing policy. Can
                    /// return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy is being specified. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </param>
                    public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.VMwareEngine.v1.Data.SetIamPolicyRequest body, string resource)
                    {
                        return new SetIamPolicyRequest(this.service, body, resource);
                    }

                    /// <summary>
                    /// Sets the access control policy on the specified resource. Replaces any existing policy. Can
                    /// return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                    /// </summary>
                    public class SetIamPolicyRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.Policy>
                    {
                        /// <summary>Constructs a new SetIamPolicy request.</summary>
                        public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.VMwareEngine.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
                        {
                            Resource = resource;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy is being specified. See [Resource
                        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for
                        /// this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.VMwareEngine.v1.Data.SetIamPolicyRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "setIamPolicy";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+resource}:setIamPolicy";

                        /// <summary>Initializes SetIamPolicy parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                            {
                                Name = "resource",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/privateClouds/[^/]+/clusters/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                    /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                    /// designed to be used for building permission-aware UIs and command-line tools, not for
                    /// authorization checking. This operation may "fail open" without warning.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </param>
                    public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.VMwareEngine.v1.Data.TestIamPermissionsRequest body, string resource)
                    {
                        return new TestIamPermissionsRequest(this.service, body, resource);
                    }

                    /// <summary>
                    /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                    /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                    /// designed to be used for building permission-aware UIs and command-line tools, not for
                    /// authorization checking. This operation may "fail open" without warning.
                    /// </summary>
                    public class TestIamPermissionsRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.TestIamPermissionsResponse>
                    {
                        /// <summary>Constructs a new TestIamPermissions request.</summary>
                        public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.VMwareEngine.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
                        {
                            Resource = resource;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for
                        /// this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.VMwareEngine.v1.Data.TestIamPermissionsRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "testIamPermissions";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+resource}:testIamPermissions";

                        /// <summary>Initializes TestIamPermissions parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                            {
                                Name = "resource",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/privateClouds/[^/]+/clusters/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>Gets the ExternalAddresses resource.</summary>
                public virtual ExternalAddressesResource ExternalAddresses { get; }

                /// <summary>The "externalAddresses" collection of methods.</summary>
                public class ExternalAddressesResource
                {
                    private const string Resource = "externalAddresses";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ExternalAddressesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Creates a new `ExternalAddress` resource in a given private cloud. The network policy that
                    /// corresponds to the private cloud must have the external IP address network service enabled
                    /// (`NetworkPolicy.external_ip`).
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The resource name of the private cloud to create a new external IP address in.
                    /// Resource names are schemeless URIs that follow the conventions in
                    /// https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.VMwareEngine.v1.Data.ExternalAddress body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>
                    /// Creates a new `ExternalAddress` resource in a given private cloud. The network policy that
                    /// corresponds to the private cloud must have the external IP address network service enabled
                    /// (`NetworkPolicy.external_ip`).
                    /// </summary>
                    public class CreateRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.VMwareEngine.v1.Data.ExternalAddress body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the private cloud to create a new external IP address in.
                        /// Resource names are schemeless URIs that follow the conventions in
                        /// https://cloud.google.com/apis/design/resource_names. For example:
                        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. The user-provided identifier of the `ExternalAddress` to be created. This
                        /// identifier must be unique among `ExternalAddress` resources within the parent and becomes
                        /// the final token in the name URI. The identifier must meet the following requirements: * Only
                        /// contains 1-63 alphanumeric characters and hyphens * Begins with an alphabetical character *
                        /// Ends with a non-hyphen character * Not formatted as a UUID * Complies with [RFC
                        /// 1034](https://datatracker.ietf.org/doc/html/rfc1034) (section 3.5)
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("externalAddressId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string ExternalAddressId { get; set; }

                        /// <summary>
                        /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must
                        /// retry your request, the server will know to ignore the request if it has already been
                        /// completed. The server guarantees that a request doesn't result in creation of duplicate
                        /// commitments for at least 60 minutes. For example, consider a situation where you make an
                        /// initial request and the request times out. If you make the request again with the same
                        /// request ID, the server can check if the original operation with the same request ID was
                        /// received, and if so, will ignore the second request. This prevents clients from accidentally
                        /// creating duplicate commitments. The request ID must be a valid UUID with the exception that
                        /// zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RequestId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.VMwareEngine.v1.Data.ExternalAddress Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/externalAddresses";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/privateClouds/[^/]+$",
                            });
                            RequestParameters.Add("externalAddressId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "externalAddressId",
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

                    /// <summary>
                    /// Deletes a single external IP address. When you delete an external IP address, connectivity
                    /// between the external IP address and the corresponding internal IP address is lost.
                    /// </summary>
                    /// <param name="name">
                    /// Required. The resource name of the external IP address to delete. Resource names are schemeless
                    /// URIs that follow the conventions in https://cloud.google.com/apis/design/resource_names. For
                    /// example:
                    /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud/externalAddresses/my-ip`
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>
                    /// Deletes a single external IP address. When you delete an external IP address, connectivity
                    /// between the external IP address and the corresponding internal IP address is lost.
                    /// </summary>
                    public class DeleteRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the external IP address to delete. Resource names are
                        /// schemeless URIs that follow the conventions in
                        /// https://cloud.google.com/apis/design/resource_names. For example:
                        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud/externalAddresses/my-ip`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must
                        /// retry your request, the server will know to ignore the request if it has already been
                        /// completed. The server guarantees that a request doesn't result in creation of duplicate
                        /// commitments for at least 60 minutes. For example, consider a situation where you make an
                        /// initial request and the request times out. If you make the request again with the same
                        /// request ID, the server can check if the original operation with the same request ID was
                        /// received, and if so, will ignore the second request. This prevents clients from accidentally
                        /// creating duplicate commitments. The request ID must be a valid UUID with the exception that
                        /// zero UUID is not supported (00000000-0000-0000-0000-000000000000).
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/privateClouds/[^/]+/externalAddresses/[^/]+$",
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

                    /// <summary>Gets details of a single external IP address.</summary>
                    /// <param name="name">
                    /// Required. The resource name of the external IP address to retrieve. Resource names are
                    /// schemeless URIs that follow the conventions in
                    /// https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud/externalAddresses/my-ip`
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets details of a single external IP address.</summary>
                    public class GetRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.ExternalAddress>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the external IP address to retrieve. Resource names are
                        /// schemeless URIs that follow the conventions in
                        /// https://cloud.google.com/apis/design/resource_names. For example:
                        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud/externalAddresses/my-ip`
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/privateClouds/[^/]+/externalAddresses/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Lists external IP addresses assigned to VMware workload VMs in a given private cloud.
                    /// </summary>
                    /// <param name="parent">
                    /// Required. The resource name of the private cloud to be queried for external IP addresses.
                    /// Resource names are schemeless URIs that follow the conventions in
                    /// https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>
                    /// Lists external IP addresses assigned to VMware workload VMs in a given private cloud.
                    /// </summary>
                    public class ListRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.ListExternalAddressesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the private cloud to be queried for external IP addresses.
                        /// Resource names are schemeless URIs that follow the conventions in
                        /// https://cloud.google.com/apis/design/resource_names. For example:
                        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// A filter expression that matches resources returned in the response. The expression must
                        /// specify the field name, a comparison operator, and the value that you want to use for
                        /// filtering. The value must be a string, a number, or a boolean. The comparison operator must
                        /// be `=`, `!=`, `&amp;gt;`, or `&amp;lt;`. For example, if you are filtering a list of IP
                        /// addresses, you can exclude the ones named `example-ip` by specifying `name != "example-ip"`.
                        /// To filter on multiple expressions, provide each separate expression within parentheses. For
                        /// example:
                        /// ```
                        /// (name = "example-ip") (createTime &amp;gt; "2021-04-12T08:15:10.40Z")
                        /// ```
                        /// By
                        /// default, each expression is an `AND` expression. However, you can include `AND` and `OR`
                        /// expressions explicitly. For example:
                        /// ```
                        /// (name = "example-ip-1") AND (createTime &amp;gt;
                        /// "2021-04-12T08:15:10.40Z") OR (name = "example-ip-2")
                        /// ```
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// Sorts list results by a certain order. By default, returned results are ordered by `name` in
                        /// ascending order. You can also sort results in descending order based on the `name` value
                        /// using `orderBy="name desc"`. Currently, only ordering by `name` is supported.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>
                        /// The maximum number of external IP addresses to return in one page. The service may return
                        /// fewer than this value. The maximum value is coerced to 1000. The default value of this field
                        /// is 500.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// A page token, received from a previous `ListExternalAddresses` call. Provide this to
                        /// retrieve the subsequent page. When paginating, all other parameters provided to
                        /// `ListExternalAddresses` must match the call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/externalAddresses";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/privateClouds/[^/]+$",
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

                    /// <summary>
                    /// Updates the parameters of a single external IP address. Only fields specified in `update_mask`
                    /// are applied. During operation processing, the resource is temporarily in the `ACTIVE` state
                    /// before the operation fully completes. For that period of time, you can't update the resource.
                    /// Use the operation status to determine when the processing fully completes.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Output only. Identifier. The resource name of this external IP address. Resource names are
                    /// schemeless URIs that follow the conventions in
                    /// https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud/externalAddresses/my-address`
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.VMwareEngine.v1.Data.ExternalAddress body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>
                    /// Updates the parameters of a single external IP address. Only fields specified in `update_mask`
                    /// are applied. During operation processing, the resource is temporarily in the `ACTIVE` state
                    /// before the operation fully completes. For that period of time, you can't update the resource.
                    /// Use the operation status to determine when the processing fully completes.
                    /// </summary>
                    public class PatchRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.VMwareEngine.v1.Data.ExternalAddress body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Output only. Identifier. The resource name of this external IP address. Resource names are
                        /// schemeless URIs that follow the conventions in
                        /// https://cloud.google.com/apis/design/resource_names. For example:
                        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud/externalAddresses/my-address`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must
                        /// retry your request, the server will know to ignore the request if it has already been
                        /// completed. The server guarantees that a request doesn't result in creation of duplicate
                        /// commitments for at least 60 minutes. For example, consider a situation where you make an
                        /// initial request and the request times out. If you make the request again with the same
                        /// request ID, the server can check if the original operation with the same request ID was
                        /// received, and if so, will ignore the second request. This prevents clients from accidentally
                        /// creating duplicate commitments. The request ID must be a valid UUID with the exception that
                        /// zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RequestId { get; set; }

                        /// <summary>
                        /// Required. Field mask is used to specify the fields to be overwritten in the
                        /// `ExternalAddress` resource by the update. The fields specified in the `update_mask` are
                        /// relative to the resource, not the full request. A field will be overwritten if it is in the
                        /// mask. If the user does not provide a mask then all fields will be overwritten.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.VMwareEngine.v1.Data.ExternalAddress Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/privateClouds/[^/]+/externalAddresses/[^/]+$",
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
                        }
                    }
                }

                /// <summary>Gets the HcxActivationKeys resource.</summary>
                public virtual HcxActivationKeysResource HcxActivationKeys { get; }

                /// <summary>The "hcxActivationKeys" collection of methods.</summary>
                public class HcxActivationKeysResource
                {
                    private const string Resource = "hcxActivationKeys";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public HcxActivationKeysResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Creates a new HCX activation key in a given private cloud.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The resource name of the private cloud to create the key for. Resource names are
                    /// schemeless URIs that follow the conventions in
                    /// https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-project/locations/us-central1/privateClouds/my-cloud`
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.VMwareEngine.v1.Data.HcxActivationKey body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>Creates a new HCX activation key in a given private cloud.</summary>
                    public class CreateRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.VMwareEngine.v1.Data.HcxActivationKey body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the private cloud to create the key for. Resource names are
                        /// schemeless URIs that follow the conventions in
                        /// https://cloud.google.com/apis/design/resource_names. For example:
                        /// `projects/my-project/locations/us-central1/privateClouds/my-cloud`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. The user-provided identifier of the `HcxActivationKey` to be created. This
                        /// identifier must be unique among `HcxActivationKey` resources within the parent and becomes
                        /// the final token in the name URI. The identifier must meet the following requirements: * Only
                        /// contains 1-63 alphanumeric characters and hyphens * Begins with an alphabetical character *
                        /// Ends with a non-hyphen character * Not formatted as a UUID * Complies with [RFC
                        /// 1034](https://datatracker.ietf.org/doc/html/rfc1034) (section 3.5)
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("hcxActivationKeyId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string HcxActivationKeyId { get; set; }

                        /// <summary>
                        /// A request ID to identify requests. Specify a unique request ID so that if you must retry
                        /// your request, the server will know to ignore the request if it has already been completed.
                        /// The server guarantees that a request doesn't result in creation of duplicate commitments for
                        /// at least 60 minutes. For example, consider a situation where you make an initial request and
                        /// the request times out. If you make the request again with the same request ID, the server
                        /// can check if original operation with the same request ID was received, and if so, will
                        /// ignore the second request. This prevents clients from accidentally creating duplicate
                        /// commitments. The request ID must be a valid UUID with the exception that zero UUID is not
                        /// supported (00000000-0000-0000-0000-000000000000).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RequestId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.VMwareEngine.v1.Data.HcxActivationKey Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/hcxActivationKeys";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/privateClouds/[^/]+$",
                            });
                            RequestParameters.Add("hcxActivationKeyId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "hcxActivationKeyId",
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

                    /// <summary>Retrieves a `HcxActivationKey` resource by its resource name.</summary>
                    /// <param name="name">
                    /// Required. The resource name of the HCX activation key to retrieve. Resource names are schemeless
                    /// URIs that follow the conventions in https://cloud.google.com/apis/design/resource_names. For
                    /// example:
                    /// `projects/my-project/locations/us-central1/privateClouds/my-cloud/hcxActivationKeys/my-key`
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Retrieves a `HcxActivationKey` resource by its resource name.</summary>
                    public class GetRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.HcxActivationKey>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the HCX activation key to retrieve. Resource names are
                        /// schemeless URIs that follow the conventions in
                        /// https://cloud.google.com/apis/design/resource_names. For example:
                        /// `projects/my-project/locations/us-central1/privateClouds/my-cloud/hcxActivationKeys/my-key`
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/privateClouds/[^/]+/hcxActivationKeys/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Gets the access control policy for a resource. Returns an empty policy if the resource exists
                    /// and does not have a policy set.
                    /// </summary>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy is being requested. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </param>
                    public virtual GetIamPolicyRequest GetIamPolicy(string resource)
                    {
                        return new GetIamPolicyRequest(this.service, resource);
                    }

                    /// <summary>
                    /// Gets the access control policy for a resource. Returns an empty policy if the resource exists
                    /// and does not have a policy set.
                    /// </summary>
                    public class GetIamPolicyRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.Policy>
                    {
                        /// <summary>Constructs a new GetIamPolicy request.</summary>
                        public GetIamPolicyRequest(Google.Apis.Services.IClientService service, string resource) : base(service)
                        {
                            Resource = resource;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy is being requested. See [Resource
                        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for
                        /// this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>
                        /// Optional. The maximum policy version that will be used to format the policy. Valid values
                        /// are 0, 1, and 3. Requests specifying an invalid value will be rejected. Requests for
                        /// policies with any conditional role bindings must specify version 3. Policies with no
                        /// conditional role bindings may specify any valid value or leave the field unset. The policy
                        /// in the response might use the policy version that you specified, or it might use a lower
                        /// policy version. For example, if you specify version 3, but the policy has no conditional
                        /// role bindings, the response uses version 1. To learn which resources support conditions in
                        /// their IAM policies, see the [IAM
                        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("options.requestedPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> OptionsRequestedPolicyVersion { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "getIamPolicy";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+resource}:getIamPolicy";

                        /// <summary>Initializes GetIamPolicy parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                            {
                                Name = "resource",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/privateClouds/[^/]+/hcxActivationKeys/[^/]+$",
                            });
                            RequestParameters.Add("options.requestedPolicyVersion", new Google.Apis.Discovery.Parameter
                            {
                                Name = "options.requestedPolicyVersion",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Lists `HcxActivationKey` resources in a given private cloud.</summary>
                    /// <param name="parent">
                    /// Required. The resource name of the private cloud to be queried for HCX activation keys. Resource
                    /// names are schemeless URIs that follow the conventions in
                    /// https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-project/locations/us-central1/privateClouds/my-cloud`
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists `HcxActivationKey` resources in a given private cloud.</summary>
                    public class ListRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.ListHcxActivationKeysResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the private cloud to be queried for HCX activation keys.
                        /// Resource names are schemeless URIs that follow the conventions in
                        /// https://cloud.google.com/apis/design/resource_names. For example:
                        /// `projects/my-project/locations/us-central1/privateClouds/my-cloud`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// The maximum number of HCX activation keys to return in one page. The service may return
                        /// fewer than this value. The maximum value is coerced to 1000. The default value of this field
                        /// is 500.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// A page token, received from a previous `ListHcxActivationKeys` call. Provide this to
                        /// retrieve the subsequent page. When paginating, all other parameters provided to
                        /// `ListHcxActivationKeys` must match the call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/hcxActivationKeys";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/privateClouds/[^/]+$",
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
                    /// Sets the access control policy on the specified resource. Replaces any existing policy. Can
                    /// return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy is being specified. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </param>
                    public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.VMwareEngine.v1.Data.SetIamPolicyRequest body, string resource)
                    {
                        return new SetIamPolicyRequest(this.service, body, resource);
                    }

                    /// <summary>
                    /// Sets the access control policy on the specified resource. Replaces any existing policy. Can
                    /// return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                    /// </summary>
                    public class SetIamPolicyRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.Policy>
                    {
                        /// <summary>Constructs a new SetIamPolicy request.</summary>
                        public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.VMwareEngine.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
                        {
                            Resource = resource;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy is being specified. See [Resource
                        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for
                        /// this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.VMwareEngine.v1.Data.SetIamPolicyRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "setIamPolicy";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+resource}:setIamPolicy";

                        /// <summary>Initializes SetIamPolicy parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                            {
                                Name = "resource",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/privateClouds/[^/]+/hcxActivationKeys/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                    /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                    /// designed to be used for building permission-aware UIs and command-line tools, not for
                    /// authorization checking. This operation may "fail open" without warning.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </param>
                    public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.VMwareEngine.v1.Data.TestIamPermissionsRequest body, string resource)
                    {
                        return new TestIamPermissionsRequest(this.service, body, resource);
                    }

                    /// <summary>
                    /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                    /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                    /// designed to be used for building permission-aware UIs and command-line tools, not for
                    /// authorization checking. This operation may "fail open" without warning.
                    /// </summary>
                    public class TestIamPermissionsRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.TestIamPermissionsResponse>
                    {
                        /// <summary>Constructs a new TestIamPermissions request.</summary>
                        public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.VMwareEngine.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
                        {
                            Resource = resource;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for
                        /// this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.VMwareEngine.v1.Data.TestIamPermissionsRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "testIamPermissions";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+resource}:testIamPermissions";

                        /// <summary>Initializes TestIamPermissions parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                            {
                                Name = "resource",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/privateClouds/[^/]+/hcxActivationKeys/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>Gets the LoggingServers resource.</summary>
                public virtual LoggingServersResource LoggingServers { get; }

                /// <summary>The "loggingServers" collection of methods.</summary>
                public class LoggingServersResource
                {
                    private const string Resource = "loggingServers";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public LoggingServersResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Create a new logging server for a given private cloud.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The resource name of the private cloud to create a new Logging Server in. Resource
                    /// names are schemeless URIs that follow the conventions in
                    /// https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.VMwareEngine.v1.Data.LoggingServer body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>Create a new logging server for a given private cloud.</summary>
                    public class CreateRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.VMwareEngine.v1.Data.LoggingServer body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the private cloud to create a new Logging Server in. Resource
                        /// names are schemeless URIs that follow the conventions in
                        /// https://cloud.google.com/apis/design/resource_names. For example:
                        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. The user-provided identifier of the `LoggingServer` to be created. This identifier
                        /// must be unique among `LoggingServer` resources within the parent and becomes the final token
                        /// in the name URI. The identifier must meet the following requirements: * Only contains 1-63
                        /// alphanumeric characters and hyphens * Begins with an alphabetical character * Ends with a
                        /// non-hyphen character * Not formatted as a UUID * Complies with [RFC
                        /// 1034](https://datatracker.ietf.org/doc/html/rfc1034) (section 3.5)
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("loggingServerId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string LoggingServerId { get; set; }

                        /// <summary>
                        /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must
                        /// retry your request, the server will know to ignore the request if it has already been
                        /// completed. The server guarantees that a request doesn't result in creation of duplicate
                        /// commitments for at least 60 minutes. For example, consider a situation where you make an
                        /// initial request and the request times out. If you make the request again with the same
                        /// request ID, the server can check if original operation with the same request ID was
                        /// received, and if so, will ignore the second request. This prevents clients from accidentally
                        /// creating duplicate commitments. The request ID must be a valid UUID with the exception that
                        /// zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RequestId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.VMwareEngine.v1.Data.LoggingServer Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/loggingServers";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/privateClouds/[^/]+$",
                            });
                            RequestParameters.Add("loggingServerId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "loggingServerId",
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

                    /// <summary>Deletes a single logging server.</summary>
                    /// <param name="name">
                    /// Required. The resource name of the logging server to delete. Resource names are schemeless URIs
                    /// that follow the conventions in https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud/loggingServers/my-logging-server`
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Deletes a single logging server.</summary>
                    public class DeleteRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the logging server to delete. Resource names are schemeless
                        /// URIs that follow the conventions in https://cloud.google.com/apis/design/resource_names. For
                        /// example:
                        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud/loggingServers/my-logging-server`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must
                        /// retry your request, the server will know to ignore the request if it has already been
                        /// completed. The server guarantees that a request doesn't result in creation of duplicate
                        /// commitments for at least 60 minutes. For example, consider a situation where you make an
                        /// initial request and the request times out. If you make the request again with the same
                        /// request ID, the server can check if original operation with the same request ID was
                        /// received, and if so, will ignore the second request. This prevents clients from accidentally
                        /// creating duplicate commitments. The request ID must be a valid UUID with the exception that
                        /// zero UUID is not supported (00000000-0000-0000-0000-000000000000).
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/privateClouds/[^/]+/loggingServers/[^/]+$",
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

                    /// <summary>Gets details of a logging server.</summary>
                    /// <param name="name">
                    /// Required. The resource name of the Logging Server to retrieve. Resource names are schemeless
                    /// URIs that follow the conventions in https://cloud.google.com/apis/design/resource_names. For
                    /// example:
                    /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud/loggingServers/my-logging-server`
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets details of a logging server.</summary>
                    public class GetRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.LoggingServer>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the Logging Server to retrieve. Resource names are schemeless
                        /// URIs that follow the conventions in https://cloud.google.com/apis/design/resource_names. For
                        /// example:
                        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud/loggingServers/my-logging-server`
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/privateClouds/[^/]+/loggingServers/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists logging servers configured for a given private cloud.</summary>
                    /// <param name="parent">
                    /// Required. The resource name of the private cloud to be queried for logging servers. Resource
                    /// names are schemeless URIs that follow the conventions in
                    /// https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists logging servers configured for a given private cloud.</summary>
                    public class ListRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.ListLoggingServersResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the private cloud to be queried for logging servers. Resource
                        /// names are schemeless URIs that follow the conventions in
                        /// https://cloud.google.com/apis/design/resource_names. For example:
                        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// A filter expression that matches resources returned in the response. The expression must
                        /// specify the field name, a comparison operator, and the value that you want to use for
                        /// filtering. The value must be a string, a number, or a boolean. The comparison operator must
                        /// be `=`, `!=`, `&amp;gt;`, or `&amp;lt;`. For example, if you are filtering a list of logging
                        /// servers, you can exclude the ones named `example-server` by specifying `name !=
                        /// "example-server"`. To filter on multiple expressions, provide each separate expression
                        /// within parentheses. For example:
                        /// ```
                        /// (name = "example-server") (createTime &amp;gt;
                        /// "2021-04-12T08:15:10.40Z")
                        /// ```
                        /// By default, each expression is an `AND` expression. However,
                        /// you can include `AND` and `OR` expressions explicitly. For example:
                        /// ```
                        /// (name =
                        /// "example-server-1") AND (createTime &amp;gt; "2021-04-12T08:15:10.40Z") OR (name =
                        /// "example-server-2")
                        /// ```
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// Sorts list results by a certain order. By default, returned results are ordered by `name` in
                        /// ascending order. You can also sort results in descending order based on the `name` value
                        /// using `orderBy="name desc"`. Currently, only ordering by `name` is supported.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>
                        /// The maximum number of logging servers to return in one page. The service may return fewer
                        /// than this value. The maximum value is coerced to 1000. The default value of this field is
                        /// 500.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// A page token, received from a previous `ListLoggingServersRequest` call. Provide this to
                        /// retrieve the subsequent page. When paginating, all other parameters provided to
                        /// `ListLoggingServersRequest` must match the call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/loggingServers";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/privateClouds/[^/]+$",
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

                    /// <summary>
                    /// Updates the parameters of a single logging server. Only fields specified in `update_mask` are
                    /// applied.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Output only. The resource name of this logging server. Resource names are schemeless URIs that
                    /// follow the conventions in https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud/loggingServers/my-logging-server`
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.VMwareEngine.v1.Data.LoggingServer body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>
                    /// Updates the parameters of a single logging server. Only fields specified in `update_mask` are
                    /// applied.
                    /// </summary>
                    public class PatchRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.VMwareEngine.v1.Data.LoggingServer body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Output only. The resource name of this logging server. Resource names are schemeless URIs
                        /// that follow the conventions in https://cloud.google.com/apis/design/resource_names. For
                        /// example:
                        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud/loggingServers/my-logging-server`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must
                        /// retry your request, the server will know to ignore the request if it has already been
                        /// completed. The server guarantees that a request doesn't result in creation of duplicate
                        /// commitments for at least 60 minutes. For example, consider a situation where you make an
                        /// initial request and the request times out. If you make the request again with the same
                        /// request ID, the server can check if original operation with the same request ID was
                        /// received, and if so, will ignore the second request. This prevents clients from accidentally
                        /// creating duplicate commitments. The request ID must be a valid UUID with the exception that
                        /// zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RequestId { get; set; }

                        /// <summary>
                        /// Required. Field mask is used to specify the fields to be overwritten in the `LoggingServer`
                        /// resource by the update. The fields specified in the `update_mask` are relative to the
                        /// resource, not the full request. A field will be overwritten if it is in the mask. If the
                        /// user does not provide a mask then all fields will be overwritten.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.VMwareEngine.v1.Data.LoggingServer Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/privateClouds/[^/]+/loggingServers/[^/]+$",
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
                        }
                    }
                }

                /// <summary>Gets the ManagementDnsZoneBindings resource.</summary>
                public virtual ManagementDnsZoneBindingsResource ManagementDnsZoneBindings { get; }

                /// <summary>The "managementDnsZoneBindings" collection of methods.</summary>
                public class ManagementDnsZoneBindingsResource
                {
                    private const string Resource = "managementDnsZoneBindings";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ManagementDnsZoneBindingsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Creates a new `ManagementDnsZoneBinding` resource in a private cloud. This RPC creates the DNS
                    /// binding and the resource that represents the DNS binding of the consumer VPC network to the
                    /// management DNS zone. A management DNS zone is the Cloud DNS cross-project binding zone that
                    /// VMware Engine creates for each private cloud. It contains FQDNs and corresponding IP addresses
                    /// for the private cloud's ESXi hosts and management VM appliances like vCenter and NSX Manager.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The resource name of the private cloud to create a new management DNS zone binding
                    /// for. Resource names are schemeless URIs that follow the conventions in
                    /// https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.VMwareEngine.v1.Data.ManagementDnsZoneBinding body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>
                    /// Creates a new `ManagementDnsZoneBinding` resource in a private cloud. This RPC creates the DNS
                    /// binding and the resource that represents the DNS binding of the consumer VPC network to the
                    /// management DNS zone. A management DNS zone is the Cloud DNS cross-project binding zone that
                    /// VMware Engine creates for each private cloud. It contains FQDNs and corresponding IP addresses
                    /// for the private cloud's ESXi hosts and management VM appliances like vCenter and NSX Manager.
                    /// </summary>
                    public class CreateRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.VMwareEngine.v1.Data.ManagementDnsZoneBinding body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the private cloud to create a new management DNS zone binding
                        /// for. Resource names are schemeless URIs that follow the conventions in
                        /// https://cloud.google.com/apis/design/resource_names. For example:
                        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. The user-provided identifier of the `ManagementDnsZoneBinding` resource to be
                        /// created. This identifier must be unique among `ManagementDnsZoneBinding` resources within
                        /// the parent and becomes the final token in the name URI. The identifier must meet the
                        /// following requirements: * Only contains 1-63 alphanumeric characters and hyphens * Begins
                        /// with an alphabetical character * Ends with a non-hyphen character * Not formatted as a UUID
                        /// * Complies with [RFC 1034](https://datatracker.ietf.org/doc/html/rfc1034) (section 3.5)
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("managementDnsZoneBindingId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string ManagementDnsZoneBindingId { get; set; }

                        /// <summary>
                        /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must
                        /// retry your request, the server will know to ignore the request if it has already been
                        /// completed. The server guarantees that a request doesn't result in creation of duplicate
                        /// commitments for at least 60 minutes. For example, consider a situation where you make an
                        /// initial request and the request times out. If you make the request again with the same
                        /// request ID, the server can check if the original operation with the same request ID was
                        /// received, and if so, will ignore the second request. This prevents clients from accidentally
                        /// creating duplicate commitments. The request ID must be a valid UUID with the exception that
                        /// zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RequestId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.VMwareEngine.v1.Data.ManagementDnsZoneBinding Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/managementDnsZoneBindings";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/privateClouds/[^/]+$",
                            });
                            RequestParameters.Add("managementDnsZoneBindingId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "managementDnsZoneBindingId",
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

                    /// <summary>
                    /// Deletes a `ManagementDnsZoneBinding` resource. When a management DNS zone binding is deleted,
                    /// the corresponding consumer VPC network is no longer bound to the management DNS zone.
                    /// </summary>
                    /// <param name="name">
                    /// Required. The resource name of the management DNS zone binding to delete. Resource names are
                    /// schemeless URIs that follow the conventions in
                    /// https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud/managementDnsZoneBindings/my-management-dns-zone-binding`
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>
                    /// Deletes a `ManagementDnsZoneBinding` resource. When a management DNS zone binding is deleted,
                    /// the corresponding consumer VPC network is no longer bound to the management DNS zone.
                    /// </summary>
                    public class DeleteRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the management DNS zone binding to delete. Resource names are
                        /// schemeless URIs that follow the conventions in
                        /// https://cloud.google.com/apis/design/resource_names. For example:
                        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud/managementDnsZoneBindings/my-management-dns-zone-binding`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must
                        /// retry your request, the server will know to ignore the request if it has already been
                        /// completed. The server guarantees that a request doesn't result in creation of duplicate
                        /// commitments for at least 60 minutes. For example, consider a situation where you make an
                        /// initial request and the request times out. If you make the request again with the same
                        /// request ID, the server can check if the original operation with the same request ID was
                        /// received, and if so, will ignore the second request. This prevents clients from accidentally
                        /// creating duplicate commitments. The request ID must be a valid UUID with the exception that
                        /// zero UUID is not supported (00000000-0000-0000-0000-000000000000).
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/privateClouds/[^/]+/managementDnsZoneBindings/[^/]+$",
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

                    /// <summary>Retrieves a 'ManagementDnsZoneBinding' resource by its resource name.</summary>
                    /// <param name="name">
                    /// Required. The resource name of the management DNS zone binding to retrieve. Resource names are
                    /// schemeless URIs that follow the conventions in
                    /// https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud/managementDnsZoneBindings/my-management-dns-zone-binding`
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Retrieves a 'ManagementDnsZoneBinding' resource by its resource name.</summary>
                    public class GetRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.ManagementDnsZoneBinding>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the management DNS zone binding to retrieve. Resource names
                        /// are schemeless URIs that follow the conventions in
                        /// https://cloud.google.com/apis/design/resource_names. For example:
                        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud/managementDnsZoneBindings/my-management-dns-zone-binding`
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/privateClouds/[^/]+/managementDnsZoneBindings/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists Consumer VPCs bound to Management DNS Zone of a given private cloud.</summary>
                    /// <param name="parent">
                    /// Required. The resource name of the private cloud to be queried for management DNS zone bindings.
                    /// Resource names are schemeless URIs that follow the conventions in
                    /// https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists Consumer VPCs bound to Management DNS Zone of a given private cloud.</summary>
                    public class ListRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.ListManagementDnsZoneBindingsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the private cloud to be queried for management DNS zone
                        /// bindings. Resource names are schemeless URIs that follow the conventions in
                        /// https://cloud.google.com/apis/design/resource_names. For example:
                        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// A filter expression that matches resources returned in the response. The expression must
                        /// specify the field name, a comparison operator, and the value that you want to use for
                        /// filtering. The value must be a string, a number, or a boolean. The comparison operator must
                        /// be `=`, `!=`, `&amp;gt;`, or `&amp;lt;`. For example, if you are filtering a list of
                        /// Management DNS Zone Bindings, you can exclude the ones named
                        /// `example-management-dns-zone-binding` by specifying `name !=
                        /// "example-management-dns-zone-binding"`. To filter on multiple expressions, provide each
                        /// separate expression within parentheses. For example:
                        /// ```
                        /// (name =
                        /// "example-management-dns-zone-binding") (createTime &amp;gt; "2021-04-12T08:15:10.40Z")
                        /// ```
                        /// By default, each expression is an `AND` expression. However, you can include `AND` and `OR`
                        /// expressions explicitly. For example:
                        /// ```
                        /// (name = "example-management-dns-zone-binding-1")
                        /// AND (createTime &amp;gt; "2021-04-12T08:15:10.40Z") OR (name =
                        /// "example-management-dns-zone-binding-2")
                        /// ```
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// Sorts list results by a certain order. By default, returned results are ordered by `name` in
                        /// ascending order. You can also sort results in descending order based on the `name` value
                        /// using `orderBy="name desc"`. Currently, only ordering by `name` is supported.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>
                        /// The maximum number of management DNS zone bindings to return in one page. The service may
                        /// return fewer than this value. The maximum value is coerced to 1000. The default value of
                        /// this field is 500.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// A page token, received from a previous `ListManagementDnsZoneBindings` call. Provide this to
                        /// retrieve the subsequent page. When paginating, all other parameters provided to
                        /// `ListManagementDnsZoneBindings` must match the call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/managementDnsZoneBindings";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/privateClouds/[^/]+$",
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

                    /// <summary>
                    /// Updates a `ManagementDnsZoneBinding` resource. Only fields specified in `update_mask` are
                    /// applied.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Output only. The resource name of this binding. Resource names are schemeless URIs that follow
                    /// the conventions in https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud/managementDnsZoneBindings/my-management-dns-zone-binding`
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.VMwareEngine.v1.Data.ManagementDnsZoneBinding body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>
                    /// Updates a `ManagementDnsZoneBinding` resource. Only fields specified in `update_mask` are
                    /// applied.
                    /// </summary>
                    public class PatchRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.VMwareEngine.v1.Data.ManagementDnsZoneBinding body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Output only. The resource name of this binding. Resource names are schemeless URIs that
                        /// follow the conventions in https://cloud.google.com/apis/design/resource_names. For example:
                        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud/managementDnsZoneBindings/my-management-dns-zone-binding`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must
                        /// retry your request, the server will know to ignore the request if it has already been
                        /// completed. The server guarantees that a request doesn't result in creation of duplicate
                        /// commitments for at least 60 minutes. For example, consider a situation where you make an
                        /// initial request and the request times out. If you make the request again with the same
                        /// request ID, the server can check if the original operation with the same request ID was
                        /// received, and if so, will ignore the second request. This prevents clients from accidentally
                        /// creating duplicate commitments. The request ID must be a valid UUID with the exception that
                        /// zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RequestId { get; set; }

                        /// <summary>
                        /// Required. Field mask is used to specify the fields to be overwritten in the
                        /// `ManagementDnsZoneBinding` resource by the update. The fields specified in the `update_mask`
                        /// are relative to the resource, not the full request. A field will be overwritten if it is in
                        /// the mask. If the user does not provide a mask then all fields will be overwritten.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.VMwareEngine.v1.Data.ManagementDnsZoneBinding Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/privateClouds/[^/]+/managementDnsZoneBindings/[^/]+$",
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
                        }
                    }

                    /// <summary>
                    /// Retries to create a `ManagementDnsZoneBinding` resource that is in failed state.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The resource name of the management DNS zone binding to repair. Resource names are
                    /// schemeless URIs that follow the conventions in
                    /// https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud/managementDnsZoneBindings/my-management-dns-zone-binding`
                    /// </param>
                    public virtual RepairRequest Repair(Google.Apis.VMwareEngine.v1.Data.RepairManagementDnsZoneBindingRequest body, string name)
                    {
                        return new RepairRequest(this.service, body, name);
                    }

                    /// <summary>
                    /// Retries to create a `ManagementDnsZoneBinding` resource that is in failed state.
                    /// </summary>
                    public class RepairRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Repair request.</summary>
                        public RepairRequest(Google.Apis.Services.IClientService service, Google.Apis.VMwareEngine.v1.Data.RepairManagementDnsZoneBindingRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the management DNS zone binding to repair. Resource names are
                        /// schemeless URIs that follow the conventions in
                        /// https://cloud.google.com/apis/design/resource_names. For example:
                        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud/managementDnsZoneBindings/my-management-dns-zone-binding`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.VMwareEngine.v1.Data.RepairManagementDnsZoneBindingRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "repair";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:repair";

                        /// <summary>Initializes Repair parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/privateClouds/[^/]+/managementDnsZoneBindings/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>Gets the Subnets resource.</summary>
                public virtual SubnetsResource Subnets { get; }

                /// <summary>The "subnets" collection of methods.</summary>
                public class SubnetsResource
                {
                    private const string Resource = "subnets";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public SubnetsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Gets details of a single subnet.</summary>
                    /// <param name="name">
                    /// Required. The resource name of the subnet to retrieve. Resource names are schemeless URIs that
                    /// follow the conventions in https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud/subnets/my-subnet`
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets details of a single subnet.</summary>
                    public class GetRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.Subnet>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the subnet to retrieve. Resource names are schemeless URIs
                        /// that follow the conventions in https://cloud.google.com/apis/design/resource_names. For
                        /// example:
                        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud/subnets/my-subnet`
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/privateClouds/[^/]+/subnets/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists subnets in a given private cloud.</summary>
                    /// <param name="parent">
                    /// Required. The resource name of the private cloud to be queried for subnets. Resource names are
                    /// schemeless URIs that follow the conventions in
                    /// https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists subnets in a given private cloud.</summary>
                    public class ListRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.ListSubnetsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the private cloud to be queried for subnets. Resource names
                        /// are schemeless URIs that follow the conventions in
                        /// https://cloud.google.com/apis/design/resource_names. For example:
                        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// The maximum number of subnets to return in one page. The service may return fewer than this
                        /// value. The maximum value is coerced to 1000. The default value of this field is 500.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// A page token, received from a previous `ListSubnetsRequest` call. Provide this to retrieve
                        /// the subsequent page. When paginating, all other parameters provided to `ListSubnetsRequest`
                        /// must match the call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/subnets";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/privateClouds/[^/]+$",
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
                    /// Updates the parameters of a single subnet. Only fields specified in `update_mask` are applied.
                    /// *Note*: This API is synchronous and always returns a successful `google.longrunning.Operation`
                    /// (LRO). The returned LRO will only have `done` and `response` fields.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Output only. Identifier. The resource name of this subnet. Resource names are schemeless URIs
                    /// that follow the conventions in https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud/subnets/my-subnet`
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.VMwareEngine.v1.Data.Subnet body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>
                    /// Updates the parameters of a single subnet. Only fields specified in `update_mask` are applied.
                    /// *Note*: This API is synchronous and always returns a successful `google.longrunning.Operation`
                    /// (LRO). The returned LRO will only have `done` and `response` fields.
                    /// </summary>
                    public class PatchRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.VMwareEngine.v1.Data.Subnet body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Output only. Identifier. The resource name of this subnet. Resource names are schemeless
                        /// URIs that follow the conventions in https://cloud.google.com/apis/design/resource_names. For
                        /// example:
                        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud/subnets/my-subnet`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Required. Field mask is used to specify the fields to be overwritten in the `Subnet`
                        /// resource by the update. The fields specified in the `update_mask` are relative to the
                        /// resource, not the full request. A field will be overwritten if it is in the mask. If the
                        /// user does not provide a mask then all fields will be overwritten.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.VMwareEngine.v1.Data.Subnet Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/privateClouds/[^/]+/subnets/[^/]+$",
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

                /// <summary>Gets the Upgrades resource.</summary>
                public virtual UpgradesResource Upgrades { get; }

                /// <summary>The "upgrades" collection of methods.</summary>
                public class UpgradesResource
                {
                    private const string Resource = "upgrades";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public UpgradesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Retrieves a private cloud `Upgrade` resource by its resource name.</summary>
                    /// <param name="name">
                    /// Required. The name of the `Upgrade` resource to be retrieved. Resource names are schemeless URIs
                    /// that follow the conventions in https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-project/locations/us-west1-a/privateClouds/my-cloud/upgrades/my-upgrade`
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Retrieves a private cloud `Upgrade` resource by its resource name.</summary>
                    public class GetRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.Upgrade>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the `Upgrade` resource to be retrieved. Resource names are schemeless
                        /// URIs that follow the conventions in https://cloud.google.com/apis/design/resource_names. For
                        /// example:
                        /// `projects/my-project/locations/us-west1-a/privateClouds/my-cloud/upgrades/my-upgrade`
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/privateClouds/[^/]+/upgrades/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists past, ongoing and upcoming `Upgrades` for the given private cloud.</summary>
                    /// <param name="parent">
                    /// Required. Query a list of `Upgrades` for the given private cloud resource name. Resource names
                    /// are schemeless URIs that follow the conventions in
                    /// https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-project/locations/us-west1-a/privateClouds/my-cloud`
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists past, ongoing and upcoming `Upgrades` for the given private cloud.</summary>
                    public class ListRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.ListUpgradesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Query a list of `Upgrades` for the given private cloud resource name. Resource
                        /// names are schemeless URIs that follow the conventions in
                        /// https://cloud.google.com/apis/design/resource_names. For example:
                        /// `projects/my-project/locations/us-west1-a/privateClouds/my-cloud`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// A filter expression that matches resources returned in the response. The expression must
                        /// specify the field name, a comparison operator, and the value that you want to use for
                        /// filtering. The value must be a string, a number, or a boolean. The comparison operator must
                        /// be `=`, `!=`, `&amp;gt;`, or `&amp;lt;`. For example, if you are filtering a list of
                        /// upgrades, you can exclude the ones named `example-upgrade1` by specifying `name !=
                        /// "example-upgrade1"`. You can also filter nested fields. To filter on multiple expressions,
                        /// provide each separate expression within parentheses. For example:
                        /// ```
                        /// (name =
                        /// "example-upgrade") (createTime &amp;gt; "2021-04-12T08:15:10.40Z")
                        /// ```
                        /// By default, each
                        /// expression is an `AND` expression. However, you can include `AND` and `OR` expressions
                        /// explicitly. For example:
                        /// ```
                        /// (name = "upgrade-1") AND (createTime &amp;gt;
                        /// "2021-04-12T08:15:10.40Z") OR (name = "upgrade-2")
                        /// ```
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// Sorts list results by a certain order. By default, returned results are ordered by `name` in
                        /// ascending order. You can also sort results in descending order based on the `name` value
                        /// using `orderBy="name desc"`. Currently, only ordering by `name` is supported.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>
                        /// The maximum number of `Upgrades` to return in one page. The service may return fewer
                        /// resources than this value. The maximum value is coerced to 1000. The default value of this
                        /// field is 500.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// A page token, received from a previous `ListUpgrades` call. Provide this to retrieve the
                        /// subsequent page. When paginating, all other parameters provided to `ListUpgrades` must match
                        /// the call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/upgrades";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/privateClouds/[^/]+$",
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

                    /// <summary>
                    /// Update the private cloud `Upgrade` resource. Only `schedule` field can updated. The schedule can
                    /// only be updated when the upgrade has not started and schedule edit window is open. Only fields
                    /// specified in `update_mask` are considered.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Output only. Identifier. The resource name of the private cloud `Upgrade`. Resource names are
                    /// schemeless URIs that follow the conventions in
                    /// https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-project/locations/us-west1-a/privateClouds/my-cloud/upgrades/my-upgrade`
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.VMwareEngine.v1.Data.Upgrade body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>
                    /// Update the private cloud `Upgrade` resource. Only `schedule` field can updated. The schedule can
                    /// only be updated when the upgrade has not started and schedule edit window is open. Only fields
                    /// specified in `update_mask` are considered.
                    /// </summary>
                    public class PatchRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.VMwareEngine.v1.Data.Upgrade body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Output only. Identifier. The resource name of the private cloud `Upgrade`. Resource names
                        /// are schemeless URIs that follow the conventions in
                        /// https://cloud.google.com/apis/design/resource_names. For example:
                        /// `projects/my-project/locations/us-west1-a/privateClouds/my-cloud/upgrades/my-upgrade`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must
                        /// retry your request, the server will know to ignore the request if it has already been
                        /// completed. The server guarantees that a request doesn't result in creation of duplicate
                        /// commitments for at least 60 minutes. For example, consider a situation where you make an
                        /// initial request and the request times out. If you make the request again with the same
                        /// request ID, the server can check if original operation with the same request ID was
                        /// received, and if so, will ignore the second request. This prevents clients from accidentally
                        /// creating duplicate commitments. The request ID must be a valid UUID with the exception that
                        /// zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RequestId { get; set; }

                        /// <summary>
                        /// Required. Field mask is used to specify the fields to be overwritten in the `Upgrade`
                        /// resource by the update. The fields specified in the `update_mask` are relative to the
                        /// resource, not the full request. A field will be overwritten if it is in the mask. If the
                        /// user does not provide a mask then all fields will be overwritten.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.VMwareEngine.v1.Data.Upgrade Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/privateClouds/[^/]+/upgrades/[^/]+$",
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
                        }
                    }
                }

                /// <summary>
                /// Creates a new `PrivateCloud` resource in a given project and location. Private clouds of type
                /// `STANDARD` and `TIME_LIMITED` are zonal resources, `STRETCHED` private clouds are regional. Creating
                /// a private cloud also creates a [management
                /// cluster](https://cloud.google.com/vmware-engine/docs/concepts-vmware-components) for that private
                /// cloud.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The resource name of the location to create the new private cloud in. Resource names are
                /// schemeless URIs that follow the conventions in https://cloud.google.com/apis/design/resource_names.
                /// For example: `projects/my-project/locations/us-central1-a`
                /// </param>
                public virtual CreateRequest Create(Google.Apis.VMwareEngine.v1.Data.PrivateCloud body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>
                /// Creates a new `PrivateCloud` resource in a given project and location. Private clouds of type
                /// `STANDARD` and `TIME_LIMITED` are zonal resources, `STRETCHED` private clouds are regional. Creating
                /// a private cloud also creates a [management
                /// cluster](https://cloud.google.com/vmware-engine/docs/concepts-vmware-components) for that private
                /// cloud.
                /// </summary>
                public class CreateRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.VMwareEngine.v1.Data.PrivateCloud body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the location to create the new private cloud in. Resource names
                    /// are schemeless URIs that follow the conventions in
                    /// https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-project/locations/us-central1-a`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The user-provided identifier of the private cloud to be created. This identifier must
                    /// be unique among each `PrivateCloud` within the parent and becomes the final token in the name
                    /// URI. The identifier must meet the following requirements: * Only contains 1-63 alphanumeric
                    /// characters and hyphens * Begins with an alphabetical character * Ends with a non-hyphen
                    /// character * Not formatted as a UUID * Complies with [RFC
                    /// 1034](https://datatracker.ietf.org/doc/html/rfc1034) (section 3.5)
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("privateCloudId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PrivateCloudId { get; set; }

                    /// <summary>
                    /// Optional. The request ID must be a valid UUID with the exception that zero UUID is not supported
                    /// (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// Optional. True if you want the request to be validated and not executed; false otherwise.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.VMwareEngine.v1.Data.PrivateCloud Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/privateClouds";

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
                        RequestParameters.Add("privateCloudId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "privateCloudId",
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

                /// <summary>
                /// Schedules a `PrivateCloud` resource for deletion. A `PrivateCloud` resource scheduled for deletion
                /// has `PrivateCloud.state` set to `DELETED` and `expireTime` set to the time when deletion is final
                /// and can no longer be reversed. The delete operation is marked as done as soon as the `PrivateCloud`
                /// is successfully scheduled for deletion (this also applies when `delayHours` is set to zero), and the
                /// operation is not kept in pending state until `PrivateCloud` is purged. `PrivateCloud` can be
                /// restored using `UndeletePrivateCloud` method before the `expireTime` elapses. When `expireTime` is
                /// reached, deletion is final and all private cloud resources are irreversibly removed and billing
                /// stops. During the final removal process, `PrivateCloud.state` is set to `PURGING`. `PrivateCloud`
                /// can be polled using standard `GET` method for the whole period of deletion and purging. It will not
                /// be returned only when it is completely purged.
                /// </summary>
                /// <param name="name">
                /// Required. The resource name of the private cloud to delete. Resource names are schemeless URIs that
                /// follow the conventions in https://cloud.google.com/apis/design/resource_names. For example:
                /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>
                /// Schedules a `PrivateCloud` resource for deletion. A `PrivateCloud` resource scheduled for deletion
                /// has `PrivateCloud.state` set to `DELETED` and `expireTime` set to the time when deletion is final
                /// and can no longer be reversed. The delete operation is marked as done as soon as the `PrivateCloud`
                /// is successfully scheduled for deletion (this also applies when `delayHours` is set to zero), and the
                /// operation is not kept in pending state until `PrivateCloud` is purged. `PrivateCloud` can be
                /// restored using `UndeletePrivateCloud` method before the `expireTime` elapses. When `expireTime` is
                /// reached, deletion is final and all private cloud resources are irreversibly removed and billing
                /// stops. During the final removal process, `PrivateCloud.state` is set to `PURGING`. `PrivateCloud`
                /// can be polled using standard `GET` method for the whole period of deletion and purging. It will not
                /// be returned only when it is completely purged.
                /// </summary>
                public class DeleteRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the private cloud to delete. Resource names are schemeless URIs
                    /// that follow the conventions in https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. Time delay of the deletion specified in hours. The default value is `3`. Specifying a
                    /// non-zero value for this field changes the value of `PrivateCloud.state` to `DELETED` and sets
                    /// `expire_time` to the planned deletion time. Deletion can be cancelled before `expire_time`
                    /// elapses using VmwareEngine.UndeletePrivateCloud. Specifying a value of `0` for this field
                    /// instead begins the deletion process and ceases billing immediately. During the final deletion
                    /// process, the value of `PrivateCloud.state` becomes `PURGING`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("delayHours", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> DelayHours { get; set; }

                    /// <summary>
                    /// Optional. If set to true, cascade delete is enabled and all children of this private cloud
                    /// resource are also deleted. When this flag is set to false, the private cloud will not be deleted
                    /// if there are any children other than the management cluster. The management cluster is always
                    /// deleted.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("force", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> Force { get; set; }

                    /// <summary>
                    /// Optional. The request ID must be a valid UUID with the exception that zero UUID is not supported
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/privateClouds/[^/]+$",
                        });
                        RequestParameters.Add("delayHours", new Google.Apis.Discovery.Parameter
                        {
                            Name = "delayHours",
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
                    }
                }

                /// <summary>Retrieves a `PrivateCloud` resource by its resource name.</summary>
                /// <param name="name">
                /// Required. The resource name of the private cloud to retrieve. Resource names are schemeless URIs
                /// that follow the conventions in https://cloud.google.com/apis/design/resource_names. For example:
                /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Retrieves a `PrivateCloud` resource by its resource name.</summary>
                public class GetRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.PrivateCloud>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the private cloud to retrieve. Resource names are schemeless URIs
                    /// that follow the conventions in https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/privateClouds/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets details of the `DnsForwarding` config.</summary>
                /// <param name="name">
                /// Required. The resource name of a `DnsForwarding` to retrieve. Resource names are schemeless URIs
                /// that follow the conventions in https://cloud.google.com/apis/design/resource_names. For example:
                /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud/dnsForwarding`
                /// </param>
                public virtual GetDnsForwardingRequest GetDnsForwarding(string name)
                {
                    return new GetDnsForwardingRequest(this.service, name);
                }

                /// <summary>Gets details of the `DnsForwarding` config.</summary>
                public class GetDnsForwardingRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.DnsForwarding>
                {
                    /// <summary>Constructs a new GetDnsForwarding request.</summary>
                    public GetDnsForwardingRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of a `DnsForwarding` to retrieve. Resource names are schemeless URIs
                    /// that follow the conventions in https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud/dnsForwarding`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "getDnsForwarding";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}";

                    /// <summary>Initializes GetDnsForwarding parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/privateClouds/[^/]+/dnsForwarding$",
                        });
                    }
                }

                /// <summary>
                /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and
                /// does not have a policy set.
                /// </summary>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual GetIamPolicyRequest GetIamPolicy(string resource)
                {
                    return new GetIamPolicyRequest(this.service, resource);
                }

                /// <summary>
                /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and
                /// does not have a policy set.
                /// </summary>
                public class GetIamPolicyRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.Policy>
                {
                    /// <summary>Constructs a new GetIamPolicy request.</summary>
                    public GetIamPolicyRequest(Google.Apis.Services.IClientService service, string resource) : base(service)
                    {
                        Resource = resource;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy is being requested. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>
                    /// Optional. The maximum policy version that will be used to format the policy. Valid values are 0,
                    /// 1, and 3. Requests specifying an invalid value will be rejected. Requests for policies with any
                    /// conditional role bindings must specify version 3. Policies with no conditional role bindings may
                    /// specify any valid value or leave the field unset. The policy in the response might use the
                    /// policy version that you specified, or it might use a lower policy version. For example, if you
                    /// specify version 3, but the policy has no conditional role bindings, the response uses version 1.
                    /// To learn which resources support conditions in their IAM policies, see the [IAM
                    /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("options.requestedPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> OptionsRequestedPolicyVersion { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "getIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+resource}:getIamPolicy";

                    /// <summary>Initializes GetIamPolicy parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                        {
                            Name = "resource",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/privateClouds/[^/]+$",
                        });
                        RequestParameters.Add("options.requestedPolicyVersion", new Google.Apis.Discovery.Parameter
                        {
                            Name = "options.requestedPolicyVersion",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Lists `PrivateCloud` resources in a given project and location.</summary>
                /// <param name="parent">
                /// Required. The resource name of the private cloud to be queried for clusters. Resource names are
                /// schemeless URIs that follow the conventions in https://cloud.google.com/apis/design/resource_names.
                /// For example: `projects/my-project/locations/us-central1-a`
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists `PrivateCloud` resources in a given project and location.</summary>
                public class ListRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.ListPrivateCloudsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the private cloud to be queried for clusters. Resource names are
                    /// schemeless URIs that follow the conventions in
                    /// https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-project/locations/us-central1-a`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// A filter expression that matches resources returned in the response. The expression must specify
                    /// the field name, a comparison operator, and the value that you want to use for filtering. The
                    /// value must be a string, a number, or a boolean. The comparison operator must be `=`, `!=`,
                    /// `&amp;gt;`, or `&amp;lt;`. For example, if you are filtering a list of private clouds, you can
                    /// exclude the ones named `example-pc` by specifying `name != "example-pc"`. You can also filter
                    /// nested fields. For example, you could specify `networkConfig.managementCidr = "192.168.0.0/24"`
                    /// to include private clouds only if they have a matching address in their network configuration.
                    /// To filter on multiple expressions, provide each separate expression within parentheses. For
                    /// example:
                    /// ```
                    /// (name = "example-pc") (createTime &amp;gt; "2021-04-12T08:15:10.40Z")
                    /// ```
                    /// By
                    /// default, each expression is an `AND` expression. However, you can include `AND` and `OR`
                    /// expressions explicitly. For example:
                    /// ```
                    /// (name = "private-cloud-1") AND (createTime &amp;gt;
                    /// "2021-04-12T08:15:10.40Z") OR (name = "private-cloud-2")
                    /// ```
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Sorts list results by a certain order. By default, returned results are ordered by `name` in
                    /// ascending order. You can also sort results in descending order based on the `name` value using
                    /// `orderBy="name desc"`. Currently, only ordering by `name` is supported.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// The maximum number of private clouds to return in one page. The service may return fewer than
                    /// this value. The maximum value is coerced to 1000. The default value of this field is 500.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A page token, received from a previous `ListPrivateClouds` call. Provide this to retrieve the
                    /// subsequent page. When paginating, all other parameters provided to `ListPrivateClouds` must
                    /// match the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/privateClouds";

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

                /// <summary>
                /// Modifies a `PrivateCloud` resource. Only the following fields can be updated: `description`. Only
                /// fields specified in `updateMask` are applied. During operation processing, the resource is
                /// temporarily in the `ACTIVE` state before the operation fully completes. For that period of time, you
                /// can't update the resource. Use the operation status to determine when the processing fully
                /// completes.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Output only. Identifier. The resource name of this private cloud. Resource names are schemeless URIs
                /// that follow the conventions in https://cloud.google.com/apis/design/resource_names. For example:
                /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.VMwareEngine.v1.Data.PrivateCloud body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>
                /// Modifies a `PrivateCloud` resource. Only the following fields can be updated: `description`. Only
                /// fields specified in `updateMask` are applied. During operation processing, the resource is
                /// temporarily in the `ACTIVE` state before the operation fully completes. For that period of time, you
                /// can't update the resource. Use the operation status to determine when the processing fully
                /// completes.
                /// </summary>
                public class PatchRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.VMwareEngine.v1.Data.PrivateCloud body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Output only. Identifier. The resource name of this private cloud. Resource names are schemeless
                    /// URIs that follow the conventions in https://cloud.google.com/apis/design/resource_names. For
                    /// example: `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. The request ID must be a valid UUID with the exception that zero UUID is not supported
                    /// (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// Required. Field mask is used to specify the fields to be overwritten in the `PrivateCloud`
                    /// resource by the update. The fields specified in `updateMask` are relative to the resource, not
                    /// the full request. A field will be overwritten if it is in the mask. If the user does not provide
                    /// a mask then all fields will be overwritten.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.VMwareEngine.v1.Data.PrivateCloud Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/privateClouds/[^/]+$",
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
                    }
                }

                /// <summary>
                /// Accelerates the deletion of a private cloud that is currently in soft deletion A `PrivateCloud`
                /// resource in soft deletion has `PrivateCloud.state` set to `SOFT_DELETED` and
                /// `PrivateCloud.expireTime` set to the time when deletion can no longer be reversed.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The resource name of the private cloud in softdeletion. Resource names are schemeless URIs
                /// that follow the conventions in https://cloud.google.com/apis/design/resource_names. For example:
                /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
                /// </param>
                public virtual PrivateCloudDeletionNowRequest PrivateCloudDeletionNow(Google.Apis.VMwareEngine.v1.Data.AcceleratePrivateCloudDeletionRequest body, string name)
                {
                    return new PrivateCloudDeletionNowRequest(this.service, body, name);
                }

                /// <summary>
                /// Accelerates the deletion of a private cloud that is currently in soft deletion A `PrivateCloud`
                /// resource in soft deletion has `PrivateCloud.state` set to `SOFT_DELETED` and
                /// `PrivateCloud.expireTime` set to the time when deletion can no longer be reversed.
                /// </summary>
                public class PrivateCloudDeletionNowRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.Operation>
                {
                    /// <summary>Constructs a new PrivateCloudDeletionNow request.</summary>
                    public PrivateCloudDeletionNowRequest(Google.Apis.Services.IClientService service, Google.Apis.VMwareEngine.v1.Data.AcceleratePrivateCloudDeletionRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the private cloud in softdeletion. Resource names are schemeless
                    /// URIs that follow the conventions in https://cloud.google.com/apis/design/resource_names. For
                    /// example: `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.VMwareEngine.v1.Data.AcceleratePrivateCloudDeletionRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "privateCloudDeletionNow";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:privateCloudDeletionNow";

                    /// <summary>Initializes PrivateCloudDeletionNow parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/privateClouds/[^/]+$",
                        });
                    }
                }

                /// <summary>Resets credentials of the NSX appliance.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="privateCloud">
                /// Required. The resource name of the private cloud to reset credentials for. Resource names are
                /// schemeless URIs that follow the conventions in https://cloud.google.com/apis/design/resource_names.
                /// For example: `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
                /// </param>
                public virtual ResetNsxCredentialsRequest ResetNsxCredentials(Google.Apis.VMwareEngine.v1.Data.ResetNsxCredentialsRequest body, string privateCloud)
                {
                    return new ResetNsxCredentialsRequest(this.service, body, privateCloud);
                }

                /// <summary>Resets credentials of the NSX appliance.</summary>
                public class ResetNsxCredentialsRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.Operation>
                {
                    /// <summary>Constructs a new ResetNsxCredentials request.</summary>
                    public ResetNsxCredentialsRequest(Google.Apis.Services.IClientService service, Google.Apis.VMwareEngine.v1.Data.ResetNsxCredentialsRequest body, string privateCloud) : base(service)
                    {
                        PrivateCloud = privateCloud;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the private cloud to reset credentials for. Resource names are
                    /// schemeless URIs that follow the conventions in
                    /// https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("privateCloud", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string PrivateCloud { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.VMwareEngine.v1.Data.ResetNsxCredentialsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "resetNsxCredentials";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+privateCloud}:resetNsxCredentials";

                    /// <summary>Initializes ResetNsxCredentials parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("privateCloud", new Google.Apis.Discovery.Parameter
                        {
                            Name = "privateCloud",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/privateClouds/[^/]+$",
                        });
                    }
                }

                /// <summary>Resets credentials of the Vcenter appliance.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="privateCloud">
                /// Required. The resource name of the private cloud to reset credentials for. Resource names are
                /// schemeless URIs that follow the conventions in https://cloud.google.com/apis/design/resource_names.
                /// For example: `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
                /// </param>
                public virtual ResetVcenterCredentialsRequest ResetVcenterCredentials(Google.Apis.VMwareEngine.v1.Data.ResetVcenterCredentialsRequest body, string privateCloud)
                {
                    return new ResetVcenterCredentialsRequest(this.service, body, privateCloud);
                }

                /// <summary>Resets credentials of the Vcenter appliance.</summary>
                public class ResetVcenterCredentialsRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.Operation>
                {
                    /// <summary>Constructs a new ResetVcenterCredentials request.</summary>
                    public ResetVcenterCredentialsRequest(Google.Apis.Services.IClientService service, Google.Apis.VMwareEngine.v1.Data.ResetVcenterCredentialsRequest body, string privateCloud) : base(service)
                    {
                        PrivateCloud = privateCloud;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the private cloud to reset credentials for. Resource names are
                    /// schemeless URIs that follow the conventions in
                    /// https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("privateCloud", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string PrivateCloud { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.VMwareEngine.v1.Data.ResetVcenterCredentialsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "resetVcenterCredentials";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+privateCloud}:resetVcenterCredentials";

                    /// <summary>Initializes ResetVcenterCredentials parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("privateCloud", new Google.Apis.Discovery.Parameter
                        {
                            Name = "privateCloud",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/privateClouds/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.VMwareEngine.v1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(this.service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                public class SetIamPolicyRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.VMwareEngine.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy is being specified. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.VMwareEngine.v1.Data.SetIamPolicyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+resource}:setIamPolicy";

                    /// <summary>Initializes SetIamPolicy parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                        {
                            Name = "resource",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/privateClouds/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets details of credentials for NSX appliance.</summary>
                /// <param name="privateCloud">
                /// Required. The resource name of the private cloud to be queried for credentials. Resource names are
                /// schemeless URIs that follow the conventions in https://cloud.google.com/apis/design/resource_names.
                /// For example: `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
                /// </param>
                public virtual ShowNsxCredentialsRequest ShowNsxCredentials(string privateCloud)
                {
                    return new ShowNsxCredentialsRequest(this.service, privateCloud);
                }

                /// <summary>Gets details of credentials for NSX appliance.</summary>
                public class ShowNsxCredentialsRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.Credentials>
                {
                    /// <summary>Constructs a new ShowNsxCredentials request.</summary>
                    public ShowNsxCredentialsRequest(Google.Apis.Services.IClientService service, string privateCloud) : base(service)
                    {
                        PrivateCloud = privateCloud;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the private cloud to be queried for credentials. Resource names
                    /// are schemeless URIs that follow the conventions in
                    /// https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("privateCloud", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string PrivateCloud { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "showNsxCredentials";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+privateCloud}:showNsxCredentials";

                    /// <summary>Initializes ShowNsxCredentials parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("privateCloud", new Google.Apis.Discovery.Parameter
                        {
                            Name = "privateCloud",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/privateClouds/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets details of credentials for Vcenter appliance.</summary>
                /// <param name="privateCloud">
                /// Required. The resource name of the private cloud to be queried for credentials. Resource names are
                /// schemeless URIs that follow the conventions in https://cloud.google.com/apis/design/resource_names.
                /// For example: `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
                /// </param>
                public virtual ShowVcenterCredentialsRequest ShowVcenterCredentials(string privateCloud)
                {
                    return new ShowVcenterCredentialsRequest(this.service, privateCloud);
                }

                /// <summary>Gets details of credentials for Vcenter appliance.</summary>
                public class ShowVcenterCredentialsRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.Credentials>
                {
                    /// <summary>Constructs a new ShowVcenterCredentials request.</summary>
                    public ShowVcenterCredentialsRequest(Google.Apis.Services.IClientService service, string privateCloud) : base(service)
                    {
                        PrivateCloud = privateCloud;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the private cloud to be queried for credentials. Resource names
                    /// are schemeless URIs that follow the conventions in
                    /// https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("privateCloud", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string PrivateCloud { get; private set; }

                    /// <summary>
                    /// Optional. The username of the user to be queried for credentials. The default value of this
                    /// field is CloudOwner@gve.local. The provided value must be one of the following:
                    /// CloudOwner@gve.local, solution-user-01@gve.local, solution-user-02@gve.local,
                    /// solution-user-03@gve.local, solution-user-04@gve.local, solution-user-05@gve.local,
                    /// zertoadmin@gve.local.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("username", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Username { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "showVcenterCredentials";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+privateCloud}:showVcenterCredentials";

                    /// <summary>Initializes ShowVcenterCredentials parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("privateCloud", new Google.Apis.Discovery.Parameter
                        {
                            Name = "privateCloud",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/privateClouds/[^/]+$",
                        });
                        RequestParameters.Add("username", new Google.Apis.Discovery.Parameter
                        {
                            Name = "username",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.VMwareEngine.v1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(this.service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                public class TestIamPermissionsRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.VMwareEngine.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.VMwareEngine.v1.Data.TestIamPermissionsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "testIamPermissions";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+resource}:testIamPermissions";

                    /// <summary>Initializes TestIamPermissions parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                        {
                            Name = "resource",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/privateClouds/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Restores a private cloud that was previously scheduled for deletion by `DeletePrivateCloud`. A
                /// `PrivateCloud` resource scheduled for deletion has `PrivateCloud.state` set to `DELETED` and
                /// `PrivateCloud.expireTime` set to the time when deletion can no longer be reversed.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The resource name of the private cloud scheduled for deletion. Resource names are
                /// schemeless URIs that follow the conventions in https://cloud.google.com/apis/design/resource_names.
                /// For example: `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
                /// </param>
                public virtual UndeleteRequest Undelete(Google.Apis.VMwareEngine.v1.Data.UndeletePrivateCloudRequest body, string name)
                {
                    return new UndeleteRequest(this.service, body, name);
                }

                /// <summary>
                /// Restores a private cloud that was previously scheduled for deletion by `DeletePrivateCloud`. A
                /// `PrivateCloud` resource scheduled for deletion has `PrivateCloud.state` set to `DELETED` and
                /// `PrivateCloud.expireTime` set to the time when deletion can no longer be reversed.
                /// </summary>
                public class UndeleteRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Undelete request.</summary>
                    public UndeleteRequest(Google.Apis.Services.IClientService service, Google.Apis.VMwareEngine.v1.Data.UndeletePrivateCloudRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the private cloud scheduled for deletion. Resource names are
                    /// schemeless URIs that follow the conventions in
                    /// https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.VMwareEngine.v1.Data.UndeletePrivateCloudRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "undelete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:undelete";

                    /// <summary>Initializes Undelete parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/privateClouds/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Updates the parameters of the `DnsForwarding` config, like associated domains. Only fields specified
                /// in `update_mask` are applied.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Output only. Identifier. The resource name of this DNS profile. Resource names are schemeless URIs
                /// that follow the conventions in https://cloud.google.com/apis/design/resource_names. For example:
                /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud/dnsForwarding`
                /// </param>
                public virtual UpdateDnsForwardingRequest UpdateDnsForwarding(Google.Apis.VMwareEngine.v1.Data.DnsForwarding body, string name)
                {
                    return new UpdateDnsForwardingRequest(this.service, body, name);
                }

                /// <summary>
                /// Updates the parameters of the `DnsForwarding` config, like associated domains. Only fields specified
                /// in `update_mask` are applied.
                /// </summary>
                public class UpdateDnsForwardingRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.Operation>
                {
                    /// <summary>Constructs a new UpdateDnsForwarding request.</summary>
                    public UpdateDnsForwardingRequest(Google.Apis.Services.IClientService service, Google.Apis.VMwareEngine.v1.Data.DnsForwarding body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Output only. Identifier. The resource name of this DNS profile. Resource names are schemeless
                    /// URIs that follow the conventions in https://cloud.google.com/apis/design/resource_names. For
                    /// example: `projects/my-project/locations/us-central1-a/privateClouds/my-cloud/dnsForwarding`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server will know to ignore the request if it has already been completed.
                    /// The server guarantees that a request doesn't result in creation of duplicate commitments for at
                    /// least 60 minutes. For example, consider a situation where you make an initial request and the
                    /// request times out. If you make the request again with the same request ID, the server can check
                    /// if original operation with the same request ID was received, and if so, will ignore the second
                    /// request. This prevents clients from accidentally creating duplicate commitments. The request ID
                    /// must be a valid UUID with the exception that zero UUID is not supported
                    /// (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// Required. Field mask is used to specify the fields to be overwritten in the `DnsForwarding`
                    /// resource by the update. The fields specified in the `update_mask` are relative to the resource,
                    /// not the full request. A field will be overwritten if it is in the mask. If the user does not
                    /// provide a mask then all fields will be overwritten.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.VMwareEngine.v1.Data.DnsForwarding Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "updateDnsForwarding";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}";

                    /// <summary>Initializes UpdateDnsForwarding parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/privateClouds/[^/]+/dnsForwarding$",
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
                    PeeringRoutes = new PeeringRoutesResource(service);
                }

                /// <summary>Gets the PeeringRoutes resource.</summary>
                public virtual PeeringRoutesResource PeeringRoutes { get; }

                /// <summary>The "peeringRoutes" collection of methods.</summary>
                public class PeeringRoutesResource
                {
                    private const string Resource = "peeringRoutes";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public PeeringRoutesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Lists the private connection routes exchanged over a peering connection.</summary>
                    /// <param name="parent">
                    /// Required. The resource name of the private connection to retrieve peering routes from. Resource
                    /// names are schemeless URIs that follow the conventions in
                    /// https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-project/locations/us-west1/privateConnections/my-connection`
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists the private connection routes exchanged over a peering connection.</summary>
                    public class ListRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.ListPrivateConnectionPeeringRoutesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the private connection to retrieve peering routes from.
                        /// Resource names are schemeless URIs that follow the conventions in
                        /// https://cloud.google.com/apis/design/resource_names. For example:
                        /// `projects/my-project/locations/us-west1/privateConnections/my-connection`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// The maximum number of peering routes to return in one page. The service may return fewer
                        /// than this value. The maximum value is coerced to 1000. The default value of this field is
                        /// 500.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// A page token, received from a previous `ListPrivateConnectionPeeringRoutes` call. Provide
                        /// this to retrieve the subsequent page. When paginating, all other parameters provided to
                        /// `ListPrivateConnectionPeeringRoutes` must match the call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/peeringRoutes";

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

                /// <summary>Creates a new private connection that can be used for accessing private Clouds.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The resource name of the location to create the new private connection in. Private
                /// connection is a regional resource. Resource names are schemeless URIs that follow the conventions in
                /// https://cloud.google.com/apis/design/resource_names. For example:
                /// `projects/my-project/locations/us-central1`
                /// </param>
                public virtual CreateRequest Create(Google.Apis.VMwareEngine.v1.Data.PrivateConnection body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new private connection that can be used for accessing private Clouds.</summary>
                public class CreateRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.VMwareEngine.v1.Data.PrivateConnection body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the location to create the new private connection in. Private
                    /// connection is a regional resource. Resource names are schemeless URIs that follow the
                    /// conventions in https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-project/locations/us-central1`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The user-provided identifier of the new private connection. This identifier must be
                    /// unique among private connection resources within the parent and becomes the final token in the
                    /// name URI. The identifier must meet the following requirements: * Only contains 1-63 alphanumeric
                    /// characters and hyphens * Begins with an alphabetical character * Ends with a non-hyphen
                    /// character * Not formatted as a UUID * Complies with [RFC
                    /// 1034](https://datatracker.ietf.org/doc/html/rfc1034) (section 3.5)
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("privateConnectionId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PrivateConnectionId { get; set; }

                    /// <summary>
                    /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server will know to ignore the request if it has already been completed.
                    /// The server guarantees that a request doesn't result in creation of duplicate commitments for at
                    /// least 60 minutes. For example, consider a situation where you make an initial request and the
                    /// request times out. If you make the request again with the same request ID, the server can check
                    /// if original operation with the same request ID was received, and if so, will ignore the second
                    /// request. This prevents clients from accidentally creating duplicate commitments. The request ID
                    /// must be a valid UUID with the exception that zero UUID is not supported
                    /// (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.VMwareEngine.v1.Data.PrivateConnection Body { get; set; }

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

                /// <summary>
                /// Deletes a `PrivateConnection` resource. When a private connection is deleted for a VMware Engine
                /// network, the connected network becomes inaccessible to that VMware Engine network.
                /// </summary>
                /// <param name="name">
                /// Required. The resource name of the private connection to be deleted. Resource names are schemeless
                /// URIs that follow the conventions in https://cloud.google.com/apis/design/resource_names. For
                /// example: `projects/my-project/locations/us-central1/privateConnections/my-connection`
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>
                /// Deletes a `PrivateConnection` resource. When a private connection is deleted for a VMware Engine
                /// network, the connected network becomes inaccessible to that VMware Engine network.
                /// </summary>
                public class DeleteRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the private connection to be deleted. Resource names are
                    /// schemeless URIs that follow the conventions in
                    /// https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-project/locations/us-central1/privateConnections/my-connection`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server will know to ignore the request if it has already been completed.
                    /// The server guarantees that a request doesn't result in creation of duplicate commitments for at
                    /// least 60 minutes. For example, consider a situation where you make an initial request and the
                    /// request times out. If you make the request again with the same request ID, the server can check
                    /// if original operation with the same request ID was received, and if so, will ignore the second
                    /// request. This prevents clients from accidentally creating duplicate commitments. The request ID
                    /// must be a valid UUID with the exception that zero UUID is not supported
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
                    }
                }

                /// <summary>
                /// Retrieves a `PrivateConnection` resource by its resource name. The resource contains details of the
                /// private connection, such as connected network, routing mode and state.
                /// </summary>
                /// <param name="name">
                /// Required. The resource name of the private connection to retrieve. Resource names are schemeless
                /// URIs that follow the conventions in https://cloud.google.com/apis/design/resource_names. For
                /// example: `projects/my-project/locations/us-central1/privateConnections/my-connection`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>
                /// Retrieves a `PrivateConnection` resource by its resource name. The resource contains details of the
                /// private connection, such as connected network, routing mode and state.
                /// </summary>
                public class GetRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.PrivateConnection>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the private connection to retrieve. Resource names are schemeless
                    /// URIs that follow the conventions in https://cloud.google.com/apis/design/resource_names. For
                    /// example: `projects/my-project/locations/us-central1/privateConnections/my-connection`
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/privateConnections/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists `PrivateConnection` resources in a given project and location.</summary>
                /// <param name="parent">
                /// Required. The resource name of the location to query for private connections. Resource names are
                /// schemeless URIs that follow the conventions in https://cloud.google.com/apis/design/resource_names.
                /// For example: `projects/my-project/locations/us-central1`
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists `PrivateConnection` resources in a given project and location.</summary>
                public class ListRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.ListPrivateConnectionsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the location to query for private connections. Resource names are
                    /// schemeless URIs that follow the conventions in
                    /// https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-project/locations/us-central1`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// A filter expression that matches resources returned in the response. The expression must specify
                    /// the field name, a comparison operator, and the value that you want to use for filtering. The
                    /// value must be a string, a number, or a boolean. The comparison operator must be `=`, `!=`,
                    /// `&amp;gt;`, or `&amp;lt;`. For example, if you are filtering a list of private connections, you
                    /// can exclude the ones named `example-connection` by specifying `name != "example-connection"`. To
                    /// filter on multiple expressions, provide each separate expression within parentheses. For
                    /// example:
                    /// ```
                    /// (name = "example-connection") (createTime &amp;gt; "2022-09-22T08:15:10.40Z")
                    /// ```
                    /// By default, each expression is an `AND` expression. However, you can include `AND` and `OR`
                    /// expressions explicitly. For example:
                    /// ```
                    /// (name = "example-connection-1") AND (createTime
                    /// &amp;gt; "2021-04-12T08:15:10.40Z") OR (name = "example-connection-2")
                    /// ```
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Sorts list results by a certain order. By default, returned results are ordered by `name` in
                    /// ascending order. You can also sort results in descending order based on the `name` value using
                    /// `orderBy="name desc"`. Currently, only ordering by `name` is supported.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// The maximum number of private connections to return in one page. The maximum value is coerced to
                    /// 1000. The default value of this field is 500.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A page token, received from a previous `ListPrivateConnections` call. Provide this to retrieve
                    /// the subsequent page. When paginating, all other parameters provided to `ListPrivateConnections`
                    /// must match the call that provided the page token.
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

                /// <summary>
                /// Modifies a `PrivateConnection` resource. Only `description` and `routing_mode` fields can be
                /// updated. Only fields specified in `updateMask` are applied.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Output only. The resource name of the private connection. Resource names are schemeless URIs that
                /// follow the conventions in https://cloud.google.com/apis/design/resource_names. For example:
                /// `projects/my-project/locations/us-central1/privateConnections/my-connection`
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.VMwareEngine.v1.Data.PrivateConnection body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>
                /// Modifies a `PrivateConnection` resource. Only `description` and `routing_mode` fields can be
                /// updated. Only fields specified in `updateMask` are applied.
                /// </summary>
                public class PatchRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.VMwareEngine.v1.Data.PrivateConnection body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Output only. The resource name of the private connection. Resource names are schemeless URIs
                    /// that follow the conventions in https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-project/locations/us-central1/privateConnections/my-connection`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server will know to ignore the request if it has already been completed.
                    /// The server guarantees that a request doesn't result in creation of duplicate commitments for at
                    /// least 60 minutes. For example, consider a situation where you make an initial request and the
                    /// request times out. If you make the request again with the same request ID, the server can check
                    /// if original operation with the same request ID was received, and if so, will ignore the second
                    /// request. This prevents clients from accidentally creating duplicate commitments. The request ID
                    /// must be a valid UUID with the exception that zero UUID is not supported
                    /// (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// Required. Field mask is used to specify the fields to be overwritten in the `PrivateConnection`
                    /// resource by the update. The fields specified in the `update_mask` are relative to the resource,
                    /// not the full request. A field will be overwritten if it is in the mask. If the user does not
                    /// provide a mask then all fields will be overwritten.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.VMwareEngine.v1.Data.PrivateConnection Body { get; set; }

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

            /// <summary>Gets the VmwareEngineNetworks resource.</summary>
            public virtual VmwareEngineNetworksResource VmwareEngineNetworks { get; }

            /// <summary>The "vmwareEngineNetworks" collection of methods.</summary>
            public class VmwareEngineNetworksResource
            {
                private const string Resource = "vmwareEngineNetworks";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public VmwareEngineNetworksResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a new VMware Engine network that can be used by a private cloud.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The resource name of the location to create the new VMware Engine network in. A VMware
                /// Engine network of type `LEGACY` is a regional resource, and a VMware Engine network of type
                /// `STANDARD` is a global resource. Resource names are schemeless URIs that follow the conventions in
                /// https://cloud.google.com/apis/design/resource_names. For example:
                /// `projects/my-project/locations/global`
                /// </param>
                public virtual CreateRequest Create(Google.Apis.VMwareEngine.v1.Data.VmwareEngineNetwork body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new VMware Engine network that can be used by a private cloud.</summary>
                public class CreateRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.VMwareEngine.v1.Data.VmwareEngineNetwork body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the location to create the new VMware Engine network in. A VMware
                    /// Engine network of type `LEGACY` is a regional resource, and a VMware Engine network of type
                    /// `STANDARD` is a global resource. Resource names are schemeless URIs that follow the conventions
                    /// in https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-project/locations/global`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server will know to ignore the request if it has already been completed.
                    /// The server guarantees that a request doesn't result in creation of duplicate commitments for at
                    /// least 60 minutes. For example, consider a situation where you make an initial request and the
                    /// request times out. If you make the request again with the same request ID, the server can check
                    /// if original operation with the same request ID was received, and if so, will ignore the second
                    /// request. This prevents clients from accidentally creating duplicate commitments. The request ID
                    /// must be a valid UUID with the exception that zero UUID is not supported
                    /// (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// Required. The user-provided identifier of the new VMware Engine network. This identifier must be
                    /// unique among VMware Engine network resources within the parent and becomes the final token in
                    /// the name URI. The identifier must meet the following requirements: * For networks of type
                    /// LEGACY, adheres to the format: `{region-id}-default`. Replace `{region-id}` with the region
                    /// where you want to create the VMware Engine network. For example, "us-central1-default". * Only
                    /// contains 1-63 alphanumeric characters and hyphens * Begins with an alphabetical character * Ends
                    /// with a non-hyphen character * Not formatted as a UUID * Complies with [RFC
                    /// 1034](https://datatracker.ietf.org/doc/html/rfc1034) (section 3.5)
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("vmwareEngineNetworkId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string VmwareEngineNetworkId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.VMwareEngine.v1.Data.VmwareEngineNetwork Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/vmwareEngineNetworks";

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
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("vmwareEngineNetworkId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "vmwareEngineNetworkId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Deletes a `VmwareEngineNetwork` resource. You can only delete a VMware Engine network after all
                /// resources that refer to it are deleted. For example, a private cloud, a network peering, and a
                /// network policy can all refer to the same VMware Engine network.
                /// </summary>
                /// <param name="name">
                /// Required. The resource name of the VMware Engine network to be deleted. Resource names are
                /// schemeless URIs that follow the conventions in https://cloud.google.com/apis/design/resource_names.
                /// For example: `projects/my-project/locations/global/vmwareEngineNetworks/my-network`
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>
                /// Deletes a `VmwareEngineNetwork` resource. You can only delete a VMware Engine network after all
                /// resources that refer to it are deleted. For example, a private cloud, a network peering, and a
                /// network policy can all refer to the same VMware Engine network.
                /// </summary>
                public class DeleteRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the VMware Engine network to be deleted. Resource names are
                    /// schemeless URIs that follow the conventions in
                    /// https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-project/locations/global/vmwareEngineNetworks/my-network`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. Checksum used to ensure that the user-provided value is up to date before the server
                    /// processes the request. The server compares provided checksum with the current checksum of the
                    /// resource. If the user-provided value is out of date, this request returns an `ABORTED` error.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Etag { get; set; }

                    /// <summary>
                    /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server will know to ignore the request if it has already been completed.
                    /// The server guarantees that a request doesn't result in creation of duplicate commitments for at
                    /// least 60 minutes. For example, consider a situation where you make an initial request and the
                    /// request times out. If you make the request again with the same request ID, the server can check
                    /// if original operation with the same request ID was received, and if so, will ignore the second
                    /// request. This prevents clients from accidentally creating duplicate commitments. The request ID
                    /// must be a valid UUID with the exception that zero UUID is not supported
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/vmwareEngineNetworks/[^/]+$",
                        });
                        RequestParameters.Add("etag", new Google.Apis.Discovery.Parameter
                        {
                            Name = "etag",
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

                /// <summary>
                /// Retrieves a `VmwareEngineNetwork` resource by its resource name. The resource contains details of
                /// the VMware Engine network, such as its VMware Engine network type, peered networks in a service
                /// project, and state (for example, `CREATING`, `ACTIVE`, `DELETING`).
                /// </summary>
                /// <param name="name">
                /// Required. The resource name of the VMware Engine network to retrieve. Resource names are schemeless
                /// URIs that follow the conventions in https://cloud.google.com/apis/design/resource_names. For
                /// example: `projects/my-project/locations/global/vmwareEngineNetworks/my-network`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>
                /// Retrieves a `VmwareEngineNetwork` resource by its resource name. The resource contains details of
                /// the VMware Engine network, such as its VMware Engine network type, peered networks in a service
                /// project, and state (for example, `CREATING`, `ACTIVE`, `DELETING`).
                /// </summary>
                public class GetRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.VmwareEngineNetwork>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the VMware Engine network to retrieve. Resource names are
                    /// schemeless URIs that follow the conventions in
                    /// https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-project/locations/global/vmwareEngineNetworks/my-network`
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/vmwareEngineNetworks/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists `VmwareEngineNetwork` resources in a given project and location.</summary>
                /// <param name="parent">
                /// Required. The resource name of the location to query for VMware Engine networks. Resource names are
                /// schemeless URIs that follow the conventions in https://cloud.google.com/apis/design/resource_names.
                /// For example: `projects/my-project/locations/global`
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists `VmwareEngineNetwork` resources in a given project and location.</summary>
                public class ListRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.ListVmwareEngineNetworksResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the location to query for VMware Engine networks. Resource names
                    /// are schemeless URIs that follow the conventions in
                    /// https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-project/locations/global`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// A filter expression that matches resources returned in the response. The expression must specify
                    /// the field name, a comparison operator, and the value that you want to use for filtering. The
                    /// value must be a string, a number, or a boolean. The comparison operator must be `=`, `!=`,
                    /// `&amp;gt;`, or `&amp;lt;`. For example, if you are filtering a list of network peerings, you can
                    /// exclude the ones named `example-network` by specifying `name != "example-network"`. To filter on
                    /// multiple expressions, provide each separate expression within parentheses. For example:
                    /// ```
                    /// (name = "example-network") (createTime &amp;gt; "2021-04-12T08:15:10.40Z")
                    /// ```
                    /// By default, each
                    /// expression is an `AND` expression. However, you can include `AND` and `OR` expressions
                    /// explicitly. For example:
                    /// ```
                    /// (name = "example-network-1") AND (createTime &amp;gt;
                    /// "2021-04-12T08:15:10.40Z") OR (name = "example-network-2")
                    /// ```
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Sorts list results by a certain order. By default, returned results are ordered by `name` in
                    /// ascending order. You can also sort results in descending order based on the `name` value using
                    /// `orderBy="name desc"`. Currently, only ordering by `name` is supported.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// The maximum number of results to return in one page. The maximum value is coerced to 1000. The
                    /// default value of this field is 500.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A page token, received from a previous `ListVmwareEngineNetworks` call. Provide this to retrieve
                    /// the subsequent page. When paginating, all other parameters provided to
                    /// `ListVmwareEngineNetworks` must match the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/vmwareEngineNetworks";

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

                /// <summary>
                /// Modifies a VMware Engine network resource. Only the following fields can be updated: `description`.
                /// Only fields specified in `updateMask` are applied.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Output only. Identifier. The resource name of the VMware Engine network. Resource names are
                /// schemeless URIs that follow the conventions in https://cloud.google.com/apis/design/resource_names.
                /// For example: `projects/my-project/locations/global/vmwareEngineNetworks/my-network`
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.VMwareEngine.v1.Data.VmwareEngineNetwork body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>
                /// Modifies a VMware Engine network resource. Only the following fields can be updated: `description`.
                /// Only fields specified in `updateMask` are applied.
                /// </summary>
                public class PatchRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.VMwareEngine.v1.Data.VmwareEngineNetwork body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Output only. Identifier. The resource name of the VMware Engine network. Resource names are
                    /// schemeless URIs that follow the conventions in
                    /// https://cloud.google.com/apis/design/resource_names. For example:
                    /// `projects/my-project/locations/global/vmwareEngineNetworks/my-network`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server will know to ignore the request if it has already been completed.
                    /// The server guarantees that a request doesn't result in creation of duplicate commitments for at
                    /// least 60 minutes. For example, consider a situation where you make an initial request and the
                    /// request times out. If you make the request again with the same request ID, the server can check
                    /// if original operation with the same request ID was received, and if so, will ignore the second
                    /// request. This prevents clients from accidentally creating duplicate commitments. The request ID
                    /// must be a valid UUID with the exception that zero UUID is not supported
                    /// (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// Required. Field mask is used to specify the fields to be overwritten in the VMware Engine
                    /// network resource by the update. The fields specified in the `update_mask` are relative to the
                    /// resource, not the full request. A field will be overwritten if it is in the mask. If the user
                    /// does not provide a mask then all fields will be overwritten. Only the following fields can be
                    /// updated: `description`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.VMwareEngine.v1.Data.VmwareEngineNetwork Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/vmwareEngineNetworks/[^/]+$",
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
                    }
                }
            }

            /// <summary>Gets information about a location.</summary>
            /// <param name="name">Resource name for the location.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets information about a location.</summary>
            public class GetRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.Location>
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

            /// <summary>
            /// Gets all the principals having bind permission on the intranet VPC associated with the consumer project
            /// granted by the Grant API. DnsBindPermission is a global resource and location can only be global.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the resource which stores the users/service accounts having the permission to bind
            /// to the corresponding intranet VPC of the consumer project. DnsBindPermission is a global resource.
            /// Resource names are schemeless URIs that follow the conventions in
            /// https://cloud.google.com/apis/design/resource_names. For example:
            /// `projects/my-project/locations/global/dnsBindPermission`
            /// </param>
            public virtual GetDnsBindPermissionRequest GetDnsBindPermission(string name)
            {
                return new GetDnsBindPermissionRequest(this.service, name);
            }

            /// <summary>
            /// Gets all the principals having bind permission on the intranet VPC associated with the consumer project
            /// granted by the Grant API. DnsBindPermission is a global resource and location can only be global.
            /// </summary>
            public class GetDnsBindPermissionRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.DnsBindPermission>
            {
                /// <summary>Constructs a new GetDnsBindPermission request.</summary>
                public GetDnsBindPermissionRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the resource which stores the users/service accounts having the permission to
                /// bind to the corresponding intranet VPC of the consumer project. DnsBindPermission is a global
                /// resource. Resource names are schemeless URIs that follow the conventions in
                /// https://cloud.google.com/apis/design/resource_names. For example:
                /// `projects/my-project/locations/global/dnsBindPermission`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getDnsBindPermission";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes GetDnsBindPermission parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/locations/[^/]+/dnsBindPermission$",
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
            public class ListRequest : VMwareEngineBaseServiceRequest<Google.Apis.VMwareEngine.v1.Data.ListLocationsResponse>
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
        }
    }
}
namespace Google.Apis.VMwareEngine.v1.Data
{
    /// <summary>Request message for VmwareEngine.AcceleratePrivateCloudDeletion</summary>
    public class AcceleratePrivateCloudDeletionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Checksum used to ensure that the user-provided value is up to date before the server processes the
        /// request. The server compares provided checksum with the current checksum of the resource. If the
        /// user-provided value is out of date, this request returns an `ABORTED` error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Optional. The request ID must be a valid UUID with the exception that zero UUID is not supported
        /// (00000000-0000-0000-0000-000000000000).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }
    }

    /// <summary>Announcement for the resources of Vmware Engine.</summary>
    public class Announcement : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Activity type of the announcement There can be only one active announcement for a given activity
        /// type and target resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activityType")]
        public virtual string ActivityType { get; set; }

        /// <summary>A Cluster resource name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cluster")]
        public virtual string Cluster { get; set; }

        /// <summary>
        /// Required. Code of the announcement. Indicates the presence of a VMware Engine related announcement and
        /// corresponds to a related message in the `description` field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>
        /// Output only. Creation time of this resource. It also serves as start time of notification.
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

        /// <summary>Output only. Description of the announcement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Output only. Additional structured details about this announcement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Output only. The resource name of the announcement. Resource names are schemeless URIs that follow the
        /// conventions in https://cloud.google.com/apis/design/resource_names. For example:
        /// `projects/my-project/locations/us-west1-a/announcements/my-announcement-id`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>A Private Cloud resource name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateCloud")]
        public virtual string PrivateCloud { get; set; }

        /// <summary>
        /// Output only. State of the resource. New values may be added to this enum when appropriate.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. Target Resource Type defines the type of the target for the announcement</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetResourceType")]
        public virtual string TargetResourceType { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Last update time of this resource.</summary>
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

    /// <summary>
    /// Specifies the audit configuration for a service. The configuration determines which permission types are logged,
    /// and what identities, if any, are exempted from logging. An AuditConfig must have one or more AuditLogConfigs. If
    /// there are AuditConfigs for both `allServices` and a specific service, the union of the two AuditConfigs is used
    /// for that service: the log_types specified in each AuditConfig are enabled, and the exempted_members in each
    /// AuditLogConfig are exempted. Example Policy with multiple AuditConfigs: { "audit_configs": [ { "service":
    /// "allServices", "audit_log_configs": [ { "log_type": "DATA_READ", "exempted_members": [ "user:jose@example.com" ]
    /// }, { "log_type": "DATA_WRITE" }, { "log_type": "ADMIN_READ" } ] }, { "service": "sampleservice.googleapis.com",
    /// "audit_log_configs": [ { "log_type": "DATA_READ" }, { "log_type": "DATA_WRITE", "exempted_members": [
    /// "user:aliya@example.com" ] } ] } ] } For sampleservice, this policy enables DATA_READ, DATA_WRITE and ADMIN_READ
    /// logging. It also exempts `jose@example.com` from DATA_READ logging, and `aliya@example.com` from DATA_WRITE
    /// logging.
    /// </summary>
    public class AuditConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The configuration for logging of each type of permission.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditLogConfigs")]
        public virtual System.Collections.Generic.IList<AuditLogConfig> AuditLogConfigs { get; set; }

        /// <summary>
        /// Specifies a service that will be enabled for audit logging. For example, `storage.googleapis.com`,
        /// `cloudsql.googleapis.com`. `allServices` is a special value that covers all services.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("service")]
        public virtual string Service { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Provides the configuration for logging a type of permissions. Example: { "audit_log_configs": [ { "log_type":
    /// "DATA_READ", "exempted_members": [ "user:jose@example.com" ] }, { "log_type": "DATA_WRITE" } ] } This enables
    /// 'DATA_READ' and 'DATA_WRITE' logging, while exempting jose@example.com from DATA_READ logging.
    /// </summary>
    public class AuditLogConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Specifies the identities that do not cause logging for this type of permission. Follows the same format of
        /// Binding.members.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exemptedMembers")]
        public virtual System.Collections.Generic.IList<string> ExemptedMembers { get; set; }

        /// <summary>The log type that this config enables.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logType")]
        public virtual string LogType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Autoscaling policy describes the behavior of the autoscaling with respect to the resource utilization. The
    /// scale-out operation is initiated if the utilization exceeds ANY of the respective thresholds. The scale-in
    /// operation is initiated if the utilization is below ALL of the respective thresholds.
    /// </summary>
    public class AutoscalingPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Utilization thresholds pertaining to amount of consumed memory.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consumedMemoryThresholds")]
        public virtual Thresholds ConsumedMemoryThresholds { get; set; }

        /// <summary>Optional. Utilization thresholds pertaining to CPU utilization.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpuThresholds")]
        public virtual Thresholds CpuThresholds { get; set; }

        /// <summary>Optional. Utilization thresholds pertaining to amount of granted memory.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("grantedMemoryThresholds")]
        public virtual Thresholds GrantedMemoryThresholds { get; set; }

        /// <summary>
        /// Required. The canonical identifier of the node type to add or remove. Corresponds to the `NodeType`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeTypeId")]
        public virtual string NodeTypeId { get; set; }

        /// <summary>
        /// Required. Number of nodes to add to a cluster during a scale-out operation. Must be divisible by 2 for
        /// stretched clusters. During a scale-in operation only one node (or 2 for stretched clusters) are removed in a
        /// single iteration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scaleOutSize")]
        public virtual System.Nullable<int> ScaleOutSize { get; set; }

        /// <summary>Optional. Utilization thresholds pertaining to amount of consumed storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageThresholds")]
        public virtual Thresholds StorageThresholds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Autoscaling settings define the rules used by VMware Engine to automatically scale-out and scale-in the clusters
    /// in a private cloud.
    /// </summary>
    public class AutoscalingSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The map with autoscaling policies applied to the cluster. The key is the identifier of the policy.
        /// It must meet the following requirements: * Only contains 1-63 alphanumeric characters and hyphens * Begins
        /// with an alphabetical character * Ends with a non-hyphen character * Not formatted as a UUID * Complies with
        /// [RFC 1034](https://datatracker.ietf.org/doc/html/rfc1034) (section 3.5) Currently there map must contain
        /// only one element that describes the autoscaling policy for compute nodes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoscalingPolicies")]
        public virtual System.Collections.Generic.IDictionary<string, AutoscalingPolicy> AutoscalingPolicies { get; set; }

        /// <summary>
        /// Optional. The minimum duration between consecutive autoscale operations. It starts once addition or removal
        /// of nodes is fully completed. Defaults to 30 minutes if not specified. Cool down period must be in whole
        /// minutes (for example, 30, 31, 50, 180 minutes).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("coolDownPeriod")]
        public virtual object CoolDownPeriod { get; set; }

        /// <summary>
        /// Optional. Maximum number of nodes of any type in a cluster. If not specified the default limits apply.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxClusterNodeCount")]
        public virtual System.Nullable<int> MaxClusterNodeCount { get; set; }

        /// <summary>
        /// Optional. Minimum number of nodes of any type in a cluster. If not specified the default limits apply.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minClusterNodeCount")]
        public virtual System.Nullable<int> MinClusterNodeCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Associates `members`, or principals, with a `role`.</summary>
    public class Binding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The condition that is associated with this binding. If the condition evaluates to `true`, then this binding
        /// applies to the current request. If the condition evaluates to `false`, then this binding does not apply to
        /// the current request. However, a different role binding might grant the same role to one or more of the
        /// principals in this binding. To learn which resources support conditions in their IAM policies, see the [IAM
        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual Expr Condition { get; set; }

        /// <summary>
        /// Specifies the principals requesting access for a Google Cloud resource. `members` can have the following
        /// values: * `allUsers`: A special identifier that represents anyone who is on the internet; with or without a
        /// Google account. * `allAuthenticatedUsers`: A special identifier that represents anyone who is authenticated
        /// with a Google account or a service account. Does not include identities that come from external identity
        /// providers (IdPs) through identity federation. * `user:{emailid}`: An email address that represents a
        /// specific Google account. For example, `alice@example.com` . * `serviceAccount:{emailid}`: An email address
        /// that represents a Google service account. For example, `my-other-app@appspot.gserviceaccount.com`. *
        /// `serviceAccount:{projectid}.svc.id.goog[{namespace}/{kubernetes-sa}]`: An identifier for a [Kubernetes
        /// service account](https://cloud.google.com/kubernetes-engine/docs/how-to/kubernetes-service-accounts). For
        /// example, `my-project.svc.id.goog[my-namespace/my-kubernetes-sa]`. * `group:{emailid}`: An email address that
        /// represents a Google group. For example, `admins@example.com`. * `domain:{domain}`: The G Suite domain
        /// (primary) that represents all the users of that domain. For example, `google.com` or `example.com`. *
        /// `principal://iam.googleapis.com/locations/global/workforcePools/{pool_id}/subject/{subject_attribute_value}`:
        /// A single identity in a workforce identity pool. *
        /// `principalSet://iam.googleapis.com/locations/global/workforcePools/{pool_id}/group/{group_id}`: All
        /// workforce identities in a group. *
        /// `principalSet://iam.googleapis.com/locations/global/workforcePools/{pool_id}/attribute.{attribute_name}/{attribute_value}`:
        /// All workforce identities with a specific attribute value. *
        /// `principalSet://iam.googleapis.com/locations/global/workforcePools/{pool_id}/*`: All identities in a
        /// workforce identity pool. *
        /// `principal://iam.googleapis.com/projects/{project_number}/locations/global/workloadIdentityPools/{pool_id}/subject/{subject_attribute_value}`:
        /// A single identity in a workload identity pool. *
        /// `principalSet://iam.googleapis.com/projects/{project_number}/locations/global/workloadIdentityPools/{pool_id}/group/{group_id}`:
        /// A workload identity pool group. *
        /// `principalSet://iam.googleapis.com/projects/{project_number}/locations/global/workloadIdentityPools/{pool_id}/attribute.{attribute_name}/{attribute_value}`:
        /// All identities in a workload identity pool with a certain attribute. *
        /// `principalSet://iam.googleapis.com/projects/{project_number}/locations/global/workloadIdentityPools/{pool_id}/*`:
        /// All identities in a workload identity pool. * `deleted:user:{emailid}?uid={uniqueid}`: An email address
        /// (plus unique identifier) representing a user that has been recently deleted. For example,
        /// `alice@example.com?uid=123456789012345678901`. If the user is recovered, this value reverts to
        /// `user:{emailid}` and the recovered user retains the role in the binding. *
        /// `deleted:serviceAccount:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing a
        /// service account that has been recently deleted. For example,
        /// `my-other-app@appspot.gserviceaccount.com?uid=123456789012345678901`. If the service account is undeleted,
        /// this value reverts to `serviceAccount:{emailid}` and the undeleted service account retains the role in the
        /// binding. * `deleted:group:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing
        /// a Google group that has been recently deleted. For example, `admins@example.com?uid=123456789012345678901`.
        /// If the group is recovered, this value reverts to `group:{emailid}` and the recovered group retains the role
        /// in the binding. *
        /// `deleted:principal://iam.googleapis.com/locations/global/workforcePools/{pool_id}/subject/{subject_attribute_value}`:
        /// Deleted single identity in a workforce identity pool. For example,
        /// `deleted:principal://iam.googleapis.com/locations/global/workforcePools/my-pool-id/subject/my-subject-attribute-value`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("members")]
        public virtual System.Collections.Generic.IList<string> Members { get; set; }

        /// <summary>
        /// Role that is assigned to the list of `members`, or principals. For example, `roles/viewer`, `roles/editor`,
        /// or `roles/owner`. For an overview of the IAM roles and permissions, see the [IAM
        /// documentation](https://cloud.google.com/iam/docs/roles-overview). For a list of the available pre-defined
        /// roles, see [here](https://cloud.google.com/iam/docs/understanding-roles).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A cluster in a private cloud.</summary>
    public class Cluster : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Configuration of the autoscaling applied to this cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoscalingSettings")]
        public virtual AutoscalingSettings AutoscalingSettings { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Creation time of this resource.</summary>
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
        /// Output only. True if the cluster is a management cluster; false otherwise. There can only be one management
        /// cluster in a private cloud and it has to be the first one.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("management")]
        public virtual System.Nullable<bool> Management { get; set; }

        /// <summary>
        /// Output only. Identifier. The resource name of this cluster. Resource names are schemeless URIs that follow
        /// the conventions in https://cloud.google.com/apis/design/resource_names. For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud/clusters/my-cluster`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. The map of cluster node types in this cluster, where the key is canonical identifier of the node
        /// type (corresponds to the `NodeType`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeTypeConfigs")]
        public virtual System.Collections.Generic.IDictionary<string, NodeTypeConfig> NodeTypeConfigs { get; set; }

        /// <summary>Output only. State of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Optional. Configuration of a stretched cluster. Required for clusters that belong to a STRETCHED private
        /// cloud.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stretchedClusterConfig")]
        public virtual StretchedClusterConfig StretchedClusterConfig { get; set; }

        /// <summary>Output only. System-generated unique identifier for the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Last update time of this resource.</summary>
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

    /// <summary>
    /// Constraints to be applied while editing a schedule. These constraints ensure that `Upgrade` specific
    /// requirements are met.
    /// </summary>
    public class Constraints : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Output Only. A list of intervals in which maintenance windows are not allowed. Any time window
        /// that overlaps with any of these intervals will be considered invalid.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disallowedIntervals")]
        public virtual System.Collections.Generic.IList<WeeklyTimeInterval> DisallowedIntervals { get; set; }

        /// <summary>
        /// Output only. Minimum number of hours must be allotted for the upgrade activities for each selected day. This
        /// is a minimum; the upgrade schedule can allot more hours for the given day.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minHoursDay")]
        public virtual System.Nullable<int> MinHoursDay { get; set; }

        /// <summary>
        /// Output only. The minimum number of weekly hours must be allotted for the upgrade activities. This is just a
        /// minimum; the schedule can assign more weekly hours.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minHoursWeek")]
        public virtual System.Nullable<int> MinHoursWeek { get; set; }

        /// <summary>
        /// Output only. Output Only. The user can only reschedule an upgrade that starts within this range.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rescheduleDateRange")]
        public virtual Interval RescheduleDateRange { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Credentials for a private cloud.</summary>
    public class Credentials : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Initial password.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual string Password { get; set; }

        /// <summary>Initial username.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// DnsBindPermission resource that contains the accounts having the consumer DNS bind permission on the
    /// corresponding intranet VPC of the consumer project.
    /// </summary>
    public class DnsBindPermission : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Output only. The name of the resource which stores the users/service accounts having the
        /// permission to bind to the corresponding intranet VPC of the consumer project. DnsBindPermission is a global
        /// resource and location can only be global. Resource names are schemeless URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names. For example:
        /// `projects/my-project/locations/global/dnsBindPermission`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. Users/Service accounts which have access for binding on the intranet VPC project corresponding
        /// to the consumer project.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("principals")]
        public virtual System.Collections.Generic.IList<Principal> Principals { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// DNS forwarding config. This config defines a list of domain to name server mappings, and is attached to the
    /// private cloud for custom domain resolution.
    /// </summary>
    public class DnsForwarding : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Creation time of this resource.</summary>
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

        /// <summary>Required. List of domain mappings to configure</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("forwardingRules")]
        public virtual System.Collections.Generic.IList<ForwardingRule> ForwardingRules { get; set; }

        /// <summary>
        /// Output only. Identifier. The resource name of this DNS profile. Resource names are schemeless URIs that
        /// follow the conventions in https://cloud.google.com/apis/design/resource_names. For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud/dnsForwarding`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Last update time of this resource.</summary>
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

    /// <summary>
    /// Represents a textual expression in the Common Expression Language (CEL) syntax. CEL is a C-like expression
    /// language. The syntax and semantics of CEL are documented at https://github.com/google/cel-spec. Example
    /// (Comparison): title: "Summary size limit" description: "Determines if a summary is less than 100 chars"
    /// expression: "document.summary.size() &amp;lt; 100" Example (Equality): title: "Requestor is owner" description:
    /// "Determines if requestor is the document owner" expression: "document.owner == request.auth.claims.email"
    /// Example (Logic): title: "Public documents" description: "Determine whether the document should be publicly
    /// visible" expression: "document.type != 'private' &amp;amp;&amp;amp; document.type != 'internal'" Example (Data
    /// Manipulation): title: "Notification string" description: "Create a notification string with a timestamp."
    /// expression: "'New message received at ' + string(document.create_time)" The exact variables and functions that
    /// may be referenced within an expression are determined by the service that evaluates it. See the service
    /// documentation for additional information.
    /// </summary>
    public class Expr : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Description of the expression. This is a longer text which describes the expression, e.g. when
        /// hovered over it in a UI.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Textual representation of an expression in Common Expression Language syntax.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expression")]
        public virtual string Expression { get; set; }

        /// <summary>
        /// Optional. String indicating the location of the expression for error reporting, e.g. a file name and a
        /// position in the file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>
        /// Optional. Title for the expression, i.e. a short string describing its purpose. This can be used e.g. in UIs
        /// which allow to enter the expression.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// External access firewall rules for filtering incoming traffic destined to `ExternalAddress` resources.
    /// </summary>
    public class ExternalAccessRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The action that the external access rule performs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual string Action { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Creation time of this resource.</summary>
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

        /// <summary>User-provided description for this external access rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// If destination ranges are specified, the external access rule applies only to the traffic that has a
        /// destination IP address in these ranges. The specified IP addresses must have reserved external IP addresses
        /// in the scope of the parent network policy. To match all external IP addresses in the scope of the parent
        /// network policy, specify `0.0.0.0/0`. To match a specific external IP address, specify it using the
        /// `IpRange.external_address` property.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationIpRanges")]
        public virtual System.Collections.Generic.IList<IpRange> DestinationIpRanges { get; set; }

        /// <summary>
        /// A list of destination ports to which the external access rule applies. This field is only applicable for the
        /// UDP or TCP protocol. Each entry must be either an integer or a range. For example: `["22"]`, `["80","443"]`,
        /// or `["12345-12349"]`. To match all destination ports, specify `["0-65535"]`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationPorts")]
        public virtual System.Collections.Generic.IList<string> DestinationPorts { get; set; }

        /// <summary>
        /// The IP protocol to which the external access rule applies. This value can be one of the following three
        /// protocol strings (not case-sensitive): `tcp`, `udp`, or `icmp`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipProtocol")]
        public virtual string IpProtocol { get; set; }

        /// <summary>
        /// Output only. The resource name of this external access rule. Resource names are schemeless URIs that follow
        /// the conventions in https://cloud.google.com/apis/design/resource_names. For example:
        /// `projects/my-project/locations/us-central1/networkPolicies/my-policy/externalAccessRules/my-rule`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// External access rule priority, which determines the external access rule to use when multiple rules apply.
        /// If multiple rules have the same priority, their ordering is non-deterministic. If specific ordering is
        /// required, assign unique priorities to enforce such ordering. The external access rule priority is an integer
        /// from 100 to 4096, both inclusive. Lower integers indicate higher precedence. For example, a rule with
        /// priority `100` has higher precedence than a rule with priority `101`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priority")]
        public virtual System.Nullable<int> Priority { get; set; }

        /// <summary>
        /// If source ranges are specified, the external access rule applies only to traffic that has a source IP
        /// address in these ranges. These ranges can either be expressed in the CIDR format or as an IP address. As
        /// only inbound rules are supported, `ExternalAddress` resources cannot be the source IP addresses of an
        /// external access rule. To match all source addresses, specify `0.0.0.0/0`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceIpRanges")]
        public virtual System.Collections.Generic.IList<IpRange> SourceIpRanges { get; set; }

        /// <summary>
        /// A list of source ports to which the external access rule applies. This field is only applicable for the UDP
        /// or TCP protocol. Each entry must be either an integer or a range. For example: `["22"]`, `["80","443"]`, or
        /// `["12345-12349"]`. To match all source ports, specify `["0-65535"]`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourcePorts")]
        public virtual System.Collections.Generic.IList<string> SourcePorts { get; set; }

        /// <summary>Output only. The state of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. System-generated unique identifier for the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Last update time of this resource.</summary>
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

    /// <summary>
    /// Represents an allocated external IP address and its corresponding internal IP address in a private cloud.
    /// </summary>
    public class ExternalAddress : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Creation time of this resource.</summary>
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

        /// <summary>User-provided description for this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Output only. The external IP address of a workload VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalIp")]
        public virtual string ExternalIp { get; set; }

        /// <summary>The internal IP address of a workload VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("internalIp")]
        public virtual string InternalIp { get; set; }

        /// <summary>
        /// Output only. Identifier. The resource name of this external IP address. Resource names are schemeless URIs
        /// that follow the conventions in https://cloud.google.com/apis/design/resource_names. For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud/externalAddresses/my-address`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The state of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. System-generated unique identifier for the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Last update time of this resource.</summary>
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

    /// <summary>Response message for VmwareEngine.FetchNetworkPolicyExternalAddresses</summary>
    public class FetchNetworkPolicyExternalAddressesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of external IP addresses assigned to VMware workload VMs within the scope of the given network
        /// policy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalAddresses")]
        public virtual System.Collections.Generic.IList<ExternalAddress> ExternalAddresses { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A forwarding rule is a mapping of a `domain` to `name_servers`. This mapping allows VMware Engine to resolve
    /// domains for attached private clouds by forwarding DNS requests for a given domain to the specified nameservers.
    /// </summary>
    public class ForwardingRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Domain used to resolve a `name_servers` list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domain")]
        public virtual string Domain { get; set; }

        /// <summary>Required. List of DNS servers to use for domain resolution</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nameServers")]
        public virtual System.Collections.Generic.IList<string> NameServers { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for VmwareEngine.GrantDnsBindPermission</summary>
    public class GrantDnsBindPermissionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The consumer provided user/service account which needs to be granted permission to bind with the
        /// intranet VPC corresponding to the consumer project.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("principal")]
        public virtual Principal Principal { get; set; }

        /// <summary>
        /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must retry your
        /// request, the server will know to ignore the request if it has already been completed. The server guarantees
        /// that a request doesn't result in creation of duplicate commitments for at least 60 minutes. For example,
        /// consider a situation where you make an initial request and the request times out. If you make the request
        /// again with the same request ID, the server can check if original operation with the same request ID was
        /// received, and if so, will ignore the second request. This prevents clients from accidentally creating
        /// duplicate commitments. The request ID must be a valid UUID with the exception that zero UUID is not
        /// supported (00000000-0000-0000-0000-000000000000).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details about a HCX Cloud Manager appliance.</summary>
    public class Hcx : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Fully qualified domain name of the appliance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fqdn")]
        public virtual string Fqdn { get; set; }

        /// <summary>Internal IP address of the appliance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("internalIp")]
        public virtual string InternalIp { get; set; }

        /// <summary>Output only. The state of the appliance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Version of the appliance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// HCX activation key. A default key is created during private cloud provisioning, but this behavior is subject to
    /// change and you should always verify active keys. Use VmwareEngine.ListHcxActivationKeys to retrieve existing
    /// keys and VmwareEngine.CreateHcxActivationKey to create new ones.
    /// </summary>
    public class HcxActivationKey : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. HCX activation key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activationKey")]
        public virtual string ActivationKey { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Creation time of HCX activation key.</summary>
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
        /// Output only. The resource name of this HcxActivationKey. Resource names are schemeless URIs that follow the
        /// conventions in https://cloud.google.com/apis/design/resource_names. For example:
        /// `projects/my-project/locations/us-central1/privateClouds/my-cloud/hcxActivationKeys/my-key`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. State of HCX activation key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. System-generated unique identifier for the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a time interval, encoded as a Timestamp start (inclusive) and a Timestamp end (exclusive). The start
    /// must be less than or equal to the end. When the start equals the end, the interval is empty (matches no time).
    /// When both start and end are unspecified, the interval matches any time.
    /// </summary>
    public class Interval : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _endTimeRaw;

        private object _endTime;

        /// <summary>
        /// Optional. Exclusive end of the interval. If specified, a Timestamp matching this interval will have to be
        /// before the end.
        /// </summary>
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

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>
        /// Optional. Inclusive start of the interval. If specified, a Timestamp matching this interval will have to be
        /// the same or after the start.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual string StartTimeRaw
        {
            get => _startTimeRaw;
            set
            {
                _startTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _startTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="StartTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use StartTimeDateTimeOffset instead.")]
        public virtual object StartTime
        {
            get => _startTime;
            set
            {
                _startTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _startTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="StartTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? StartTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(StartTimeRaw);
            set => StartTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An IP range provided in any one of the supported formats.</summary>
    public class IpRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The name of an `ExternalAddress` resource. The external address must have been reserved in the scope of this
        /// external access rule's parent network policy. Provide the external address name in the form of
        /// `projects/{project}/locations/{location}/privateClouds/{private_cloud}/externalAddresses/{external_address}`.
        /// For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud/externalAddresses/my-address`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalAddress")]
        public virtual string ExternalAddress { get; set; }

        /// <summary>A single IP address. For example: `10.0.0.5`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipAddress")]
        public virtual string IpAddress { get; set; }

        /// <summary>An IP address range in the CIDR format. For example: `10.0.0.0/24`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipAddressRange")]
        public virtual string IpAddressRange { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for VmwareEngine.ListAnnouncements</summary>
    public class ListAnnouncementsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of announcement runs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("announcements")]
        public virtual System.Collections.Generic.IList<Announcement> Announcements { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>list of unreachable locations</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for VmwareEngine.ListClusters</summary>
    public class ListClustersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of private cloud clusters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusters")]
        public virtual System.Collections.Generic.IList<Cluster> Clusters { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached when making an aggregated query using wildcards.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for VmwareEngine.ListExternalAccessRules</summary>
    public class ListExternalAccessRulesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of external access firewall rules.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalAccessRules")]
        public virtual System.Collections.Generic.IList<ExternalAccessRule> ExternalAccessRules { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached when making an aggregated query using wildcards.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for VmwareEngine.ListExternalAddresses</summary>
    public class ListExternalAddressesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of external IP addresses.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalAddresses")]
        public virtual System.Collections.Generic.IList<ExternalAddress> ExternalAddresses { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached when making an aggregated query using wildcards.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for VmwareEngine.ListHcxActivationKeys</summary>
    public class ListHcxActivationKeysResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of HCX activation keys.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hcxActivationKeys")]
        public virtual System.Collections.Generic.IList<HcxActivationKey> HcxActivationKeys { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached when making an aggregated query using wildcards.</summary>
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

    /// <summary>Response message for VmwareEngine.ListLoggingServers</summary>
    public class ListLoggingServersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of Logging Servers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loggingServers")]
        public virtual System.Collections.Generic.IList<LoggingServer> LoggingServers { get; set; }

        /// <summary>
        /// A token, which can be send as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached when making an aggregated query using wildcards.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for VmwareEngine.ListManagementDnsZoneBindings</summary>
    public class ListManagementDnsZoneBindingsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of management DNS zone bindings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managementDnsZoneBindings")]
        public virtual System.Collections.Generic.IList<ManagementDnsZoneBinding> ManagementDnsZoneBindings { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached when making an aggregated query using wildcards.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for VmwareEngine.ListNetworkPeerings</summary>
    public class ListNetworkPeeringsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of network peerings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkPeerings")]
        public virtual System.Collections.Generic.IList<NetworkPeering> NetworkPeerings { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Unreachable resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for VmwareEngine.ListNetworkPolicies</summary>
    public class ListNetworkPoliciesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of network policies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkPolicies")]
        public virtual System.Collections.Generic.IList<NetworkPolicy> NetworkPolicies { get; set; }

        /// <summary>
        /// A token, which can be send as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached when making an aggregated query using wildcards.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for VmwareEngine.ListNodeTypes</summary>
    public class ListNodeTypesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A list of Node Types.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeTypes")]
        public virtual System.Collections.Generic.IList<NodeType> NodeTypes { get; set; }

        /// <summary>Locations that could not be reached when making an aggregated query using wildcards.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for VmwareEngine.ListNodes</summary>
    public class ListNodesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The nodes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodes")]
        public virtual System.Collections.Generic.IList<Node> Nodes { get; set; }

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

    /// <summary>Response message for VmwareEngine.ListPeeringRoutes</summary>
    public class ListPeeringRoutesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A list of peering routes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("peeringRoutes")]
        public virtual System.Collections.Generic.IList<PeeringRoute> PeeringRoutes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for VmwareEngine.ListPrivateClouds</summary>
    public class ListPrivateCloudsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A list of private clouds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateClouds")]
        public virtual System.Collections.Generic.IList<PrivateCloud> PrivateClouds { get; set; }

        /// <summary>Locations that could not be reached when making an aggregated query using wildcards.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for VmwareEngine.ListPrivateConnectionPeeringRoutes</summary>
    public class ListPrivateConnectionPeeringRoutesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A list of peering routes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("peeringRoutes")]
        public virtual System.Collections.Generic.IList<PeeringRoute> PeeringRoutes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for VmwareEngine.ListPrivateConnections</summary>
    public class ListPrivateConnectionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A list of private connections.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateConnections")]
        public virtual System.Collections.Generic.IList<PrivateConnection> PrivateConnections { get; set; }

        /// <summary>Unreachable resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for VmwareEngine.ListSubnets</summary>
    public class ListSubnetsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A list of subnets.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subnets")]
        public virtual System.Collections.Generic.IList<Subnet> Subnets { get; set; }

        /// <summary>Locations that could not be reached when making an aggregated query using wildcards.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for VmwareEngine.ListUpgrades.</summary>
    public class ListUpgradesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of unreachable resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>A list of `Upgrades`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("upgrades")]
        public virtual System.Collections.Generic.IList<Upgrade> Upgrades { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for VmwareEngine.ListVmwareEngineNetworks</summary>
    public class ListVmwareEngineNetworksResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Unreachable resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>A list of VMware Engine networks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmwareEngineNetworks")]
        public virtual System.Collections.Generic.IList<VmwareEngineNetwork> VmwareEngineNetworks { get; set; }

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

    /// <summary>
    /// VmwareEngine specific metadata for the given google.cloud.location.Location. It is returned as a content of the
    /// `google.cloud.location.Location.metadata` field.
    /// </summary>
    public class LocationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Capabilities of this location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("capabilities")]
        public virtual System.Collections.Generic.IList<string> Capabilities { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Logging server to receive vCenter or ESXi logs.</summary>
    public class LoggingServer : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Creation time of this resource.</summary>
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

        /// <summary>Required. Fully-qualified domain name (FQDN) or IP Address of the logging server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostname")]
        public virtual string Hostname { get; set; }

        /// <summary>
        /// Output only. The resource name of this logging server. Resource names are schemeless URIs that follow the
        /// conventions in https://cloud.google.com/apis/design/resource_names. For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud/loggingServers/my-logging-server`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. Port number at which the logging server receives logs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("port")]
        public virtual System.Nullable<int> Port { get; set; }

        /// <summary>Required. Protocol used by vCenter to send logs to a logging server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protocol")]
        public virtual string Protocol { get; set; }

        /// <summary>
        /// Required. The type of component that produces logs that will be forwarded to this logging server.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceType")]
        public virtual string SourceType { get; set; }

        /// <summary>Output only. System-generated unique identifier for the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Last update time of this resource.</summary>
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

    /// <summary>Management cluster configuration.</summary>
    public class ManagementCluster : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The user-provided identifier of the new `Cluster`. The identifier must meet the following
        /// requirements: * Only contains 1-63 alphanumeric characters and hyphens * Begins with an alphabetical
        /// character * Ends with a non-hyphen character * Not formatted as a UUID * Complies with [RFC
        /// 1034](https://datatracker.ietf.org/doc/html/rfc1034) (section 3.5)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterId")]
        public virtual string ClusterId { get; set; }

        /// <summary>
        /// Required. The map of cluster node types in this cluster, where the key is canonical identifier of the node
        /// type (corresponds to the `NodeType`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeTypeConfigs")]
        public virtual System.Collections.Generic.IDictionary<string, NodeTypeConfig> NodeTypeConfigs { get; set; }

        /// <summary>Optional. Configuration of a stretched cluster. Required for STRETCHED private clouds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stretchedClusterConfig")]
        public virtual StretchedClusterConfig StretchedClusterConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a binding between a network and the management DNS zone. A management DNS zone is the Cloud DNS
    /// cross-project binding zone that VMware Engine creates for each private cloud. It contains FQDNs and
    /// corresponding IP addresses for the private cloud's ESXi hosts and management VM appliances like vCenter and NSX
    /// Manager.
    /// </summary>
    public class ManagementDnsZoneBinding : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Creation time of this resource.</summary>
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

        /// <summary>User-provided description for this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Output only. The resource name of this binding. Resource names are schemeless URIs that follow the
        /// conventions in https://cloud.google.com/apis/design/resource_names. For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud/managementDnsZoneBindings/my-management-dns-zone-binding`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The state of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. System-generated unique identifier for the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Last update time of this resource.</summary>
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

        /// <summary>
        /// Network to bind is a VMware Engine network. Specify the name in the following form for VMware engine
        /// network: `projects/{project}/locations/global/vmwareEngineNetworks/{vmware_engine_network_id}`. `{project}`
        /// can either be a project number or a project ID.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmwareEngineNetwork")]
        public virtual string VmwareEngineNetwork { get; set; }

        /// <summary>
        /// Network to bind is a standard consumer VPC. Specify the name in the following form for consumer VPC network:
        /// `projects/{project}/global/networks/{network_id}`. `{project}` can either be a project number or a project
        /// ID.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vpcNetwork")]
        public virtual string VpcNetwork { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Network configuration in the consumer project with which the peering has to be done.</summary>
    public class NetworkConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. DNS Server IP of the Private Cloud. All DNS queries can be forwarded to this address for name
        /// resolution of Private Cloud's management entities like vCenter, NSX-T Manager and ESXi hosts.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dnsServerIp")]
        public virtual string DnsServerIp { get; set; }

        /// <summary>Required. Management CIDR used by VMware management appliances.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managementCidr")]
        public virtual string ManagementCidr { get; set; }

        /// <summary>
        /// Output only. The IP address layout version of the management IP address range. Possible versions include: *
        /// `managementIpAddressLayoutVersion=1`: Indicates the legacy IP address layout used by some existing private
        /// clouds. This is no longer supported for new private clouds as it does not support all features. *
        /// `managementIpAddressLayoutVersion=2`: Indicates the latest IP address layout used by all newly created
        /// private clouds. This version supports all current features.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managementIpAddressLayoutVersion")]
        public virtual System.Nullable<int> ManagementIpAddressLayoutVersion { get; set; }

        /// <summary>
        /// Optional. The relative resource name of the VMware Engine network attached to the private cloud. Specify the
        /// name in the following form:
        /// `projects/{project}/locations/{location}/vmwareEngineNetworks/{vmware_engine_network_id}` where `{project}`
        /// can either be a project number or a project ID.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmwareEngineNetwork")]
        public virtual string VmwareEngineNetwork { get; set; }

        /// <summary>
        /// Output only. The canonical name of the VMware Engine network in the form:
        /// `projects/{project_number}/locations/{location}/vmwareEngineNetworks/{vmware_engine_network_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmwareEngineNetworkCanonical")]
        public virtual string VmwareEngineNetworkCanonical { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of a network peering.</summary>
    public class NetworkPeering : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Creation time of this resource.</summary>
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

        /// <summary>Optional. User-provided description for this network peering.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. True if full mesh connectivity is created and managed automatically between peered networks; false
        /// otherwise. Currently this field is always true because Google Compute Engine automatically creates and
        /// manages subnetwork routes between two VPC networks when peering state is 'ACTIVE'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exchangeSubnetRoutes")]
        public virtual System.Nullable<bool> ExchangeSubnetRoutes { get; set; }

        /// <summary>
        /// Optional. True if custom routes are exported to the peered network; false otherwise. The default value is
        /// true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exportCustomRoutes")]
        public virtual System.Nullable<bool> ExportCustomRoutes { get; set; }

        /// <summary>
        /// Optional. True if all subnet routes with a public IP address range are exported; false otherwise. The
        /// default value is true. IPv4 special-use ranges (https://en.wikipedia.org/wiki/IPv4#Special_addresses) are
        /// always exported to peers and are not controlled by this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exportCustomRoutesWithPublicIp")]
        public virtual System.Nullable<bool> ExportCustomRoutesWithPublicIp { get; set; }

        /// <summary>
        /// Optional. True if custom routes are imported from the peered network; false otherwise. The default value is
        /// true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("importCustomRoutes")]
        public virtual System.Nullable<bool> ImportCustomRoutes { get; set; }

        /// <summary>
        /// Optional. True if all subnet routes with public IP address range are imported; false otherwise. The default
        /// value is true. IPv4 special-use ranges (https://en.wikipedia.org/wiki/IPv4#Special_addresses) are always
        /// imported to peers and are not controlled by this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("importCustomRoutesWithPublicIp")]
        public virtual System.Nullable<bool> ImportCustomRoutesWithPublicIp { get; set; }

        /// <summary>
        /// Output only. Identifier. The resource name of the network peering. NetworkPeering is a global resource and
        /// location can only be global. Resource names are scheme-less URIs that follow the conventions in
        /// https://cloud.google.com/apis/design/resource_names. For example:
        /// `projects/my-project/locations/global/networkPeerings/my-peering`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. Maximum transmission unit (MTU) in bytes. The default value is `1500`. If a value of `0` is
        /// provided for this field, VMware Engine uses the default value instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("peerMtu")]
        public virtual System.Nullable<int> PeerMtu { get; set; }

        /// <summary>
        /// Required. The relative resource name of the network to peer with a standard VMware Engine network. The
        /// provided network can be a consumer VPC network or another standard VMware Engine network. If the
        /// `peer_network_type` is VMWARE_ENGINE_NETWORK, specify the name in the form:
        /// `projects/{project}/locations/global/vmwareEngineNetworks/{vmware_engine_network_id}`. Otherwise specify the
        /// name in the form: `projects/{project}/global/networks/{network_id}`, where `{project}` can either be a
        /// project number or a project ID.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("peerNetwork")]
        public virtual string PeerNetwork { get; set; }

        /// <summary>Required. The type of the network to peer with the VMware Engine network.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("peerNetworkType")]
        public virtual string PeerNetworkType { get; set; }

        /// <summary>
        /// Output only. State of the network peering. This field has a value of 'ACTIVE' when there's a matching
        /// configuration in the peer network. New values may be added to this enum when appropriate.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. Output Only. Details about the current state of the network peering.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateDetails")]
        public virtual string StateDetails { get; set; }

        /// <summary>Output only. System-generated unique identifier for the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Last update time of this resource.</summary>
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

        /// <summary>
        /// Required. The relative resource name of the VMware Engine network. Specify the name in the following form:
        /// `projects/{project}/locations/{location}/vmwareEngineNetworks/{vmware_engine_network_id}` where `{project}`
        /// can either be a project number or a project ID.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmwareEngineNetwork")]
        public virtual string VmwareEngineNetwork { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a network policy resource. Network policies are regional resources. You can use a network policy to
    /// enable or disable internet access and external IP access. Network policies are associated with a VMware Engine
    /// network, which might span across regions. For a given region, a network policy applies to all private clouds in
    /// the VMware Engine network associated with the policy.
    /// </summary>
    public class NetworkPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Creation time of this resource.</summary>
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

        /// <summary>Optional. User-provided description for this network policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Required. IP address range in CIDR notation used to create internet access and external IP access. An RFC
        /// 1918 CIDR block, with a "/26" prefix, is required. The range cannot overlap with any prefixes either in the
        /// consumer VPC network or in use by the private clouds attached to that VPC network.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("edgeServicesCidr")]
        public virtual string EdgeServicesCidr { get; set; }

        /// <summary>
        /// Network service that allows External IP addresses to be assigned to VMware workloads. This service can only
        /// be enabled when `internet_access` is also enabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalIp")]
        public virtual NetworkService ExternalIp { get; set; }

        /// <summary>Network service that allows VMware workloads to access the internet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("internetAccess")]
        public virtual NetworkService InternetAccess { get; set; }

        /// <summary>
        /// Output only. Identifier. The resource name of this network policy. Resource names are schemeless URIs that
        /// follow the conventions in https://cloud.google.com/apis/design/resource_names. For example:
        /// `projects/my-project/locations/us-central1/networkPolicies/my-network-policy`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. System-generated unique identifier for the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Last update time of this resource.</summary>
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

        /// <summary>
        /// Optional. The relative resource name of the VMware Engine network. Specify the name in the following form:
        /// `projects/{project}/locations/{location}/vmwareEngineNetworks/{vmware_engine_network_id}` where `{project}`
        /// can either be a project number or a project ID.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmwareEngineNetwork")]
        public virtual string VmwareEngineNetwork { get; set; }

        /// <summary>
        /// Output only. The canonical name of the VMware Engine network in the form:
        /// `projects/{project_number}/locations/{location}/vmwareEngineNetworks/{vmware_engine_network_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmwareEngineNetworkCanonical")]
        public virtual string VmwareEngineNetworkCanonical { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a network service that is managed by a `NetworkPolicy` resource. A network service provides a way to
    /// control an aspect of external access to VMware workloads. For example, whether the VMware workloads in the
    /// private clouds governed by a network policy can access or be accessed from the internet.
    /// </summary>
    public class NetworkService : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>True if the service is enabled; false otherwise.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>Output only. State of the service. New values may be added to this enum when appropriate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Node in a cluster.</summary>
    public class Node : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Customized number of cores</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customCoreCount")]
        public virtual System.Nullable<long> CustomCoreCount { get; set; }

        /// <summary>Output only. Fully qualified domain name of the node.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fqdn")]
        public virtual string Fqdn { get; set; }

        /// <summary>Output only. Internal IP address of the node.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("internalIp")]
        public virtual string InternalIp { get; set; }

        /// <summary>
        /// Output only. The resource name of this node. Resource names are schemeless URIs that follow the conventions
        /// in https://cloud.google.com/apis/design/resource_names. For example:
        /// projects/my-project/locations/us-central1-a/privateClouds/my-cloud/clusters/my-cluster/nodes/my-node
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The canonical identifier of the node type (corresponds to the `NodeType`). For example:
        /// standard-72.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeTypeId")]
        public virtual string NodeTypeId { get; set; }

        /// <summary>Output only. The state of the appliance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. The version number of the VMware ESXi management component in this cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes node type.</summary>
    public class NodeType : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. List of possible values of custom core count.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availableCustomCoreCounts")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> AvailableCustomCoreCounts { get; set; }

        /// <summary>Output only. Capabilities of this node type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("capabilities")]
        public virtual System.Collections.Generic.IList<string> Capabilities { get; set; }

        /// <summary>Output only. The amount of storage available, defined in GB.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskSizeGb")]
        public virtual System.Nullable<int> DiskSizeGb { get; set; }

        /// <summary>Output only. The friendly name for this node type. For example: ve1-standard-72</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Output only. Families of the node type. For node types to be in the same cluster they must share at least
        /// one element in the `families`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("families")]
        public virtual System.Collections.Generic.IList<string> Families { get; set; }

        /// <summary>Output only. The type of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Output only. The amount of physical memory available, defined in GB.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memoryGb")]
        public virtual System.Nullable<int> MemoryGb { get; set; }

        /// <summary>
        /// Output only. The resource name of this node type. Resource names are schemeless URIs that follow the
        /// conventions in https://cloud.google.com/apis/design/resource_names. For example:
        /// `projects/my-proj/locations/us-central1-a/nodeTypes/standard-72`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The canonical identifier of the node type (corresponds to the `NodeType`). For example:
        /// standard-72.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeTypeId")]
        public virtual string NodeTypeId { get; set; }

        /// <summary>Output only. The total number of CPU cores in a single node.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalCoreCount")]
        public virtual System.Nullable<int> TotalCoreCount { get; set; }

        /// <summary>Output only. The total number of virtual CPUs in a single node.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("virtualCpuCount")]
        public virtual System.Nullable<int> VirtualCpuCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about the type and number of nodes associated with the cluster.</summary>
    public class NodeTypeConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Customized number of cores available to each node of the type. This number must always be one of
        /// `nodeType.availableCustomCoreCounts`. If zero is provided max value from
        /// `nodeType.availableCustomCoreCounts` will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customCoreCount")]
        public virtual System.Nullable<int> CustomCoreCount { get; set; }

        /// <summary>Required. The number of nodes of this type in the cluster</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeCount")]
        public virtual System.Nullable<int> NodeCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details about a NSX Manager appliance.</summary>
    public class Nsx : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Fully qualified domain name of the appliance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fqdn")]
        public virtual string Fqdn { get; set; }

        /// <summary>Internal IP address of the appliance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("internalIp")]
        public virtual string InternalIp { get; set; }

        /// <summary>Output only. The state of the appliance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Version of the appliance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

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

    /// <summary>Represents the metadata of the long-running operation.</summary>
    public class OperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. API version used to start the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time the operation was created.</summary>
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

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>Output only. The time the operation finished running.</summary>
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

        /// <summary>
        /// Output only. True if the user has requested cancellation of the operation; false otherwise. Operations that
        /// have successfully been cancelled have Operation.error value with a google.rpc.Status.code of 1,
        /// corresponding to `Code.CANCELLED`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedCancellation")]
        public virtual System.Nullable<bool> RequestedCancellation { get; set; }

        /// <summary>Output only. Human-readable status of the operation, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusMessage")]
        public virtual string StatusMessage { get; set; }

        /// <summary>Output only. Server-defined resource path for the target of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual string Target { get; set; }

        /// <summary>Output only. Name of the verb executed by the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verb")]
        public virtual string Verb { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Exchanged network peering route.</summary>
    public class PeeringRoute : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Destination range of the peering route in CIDR notation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destRange")]
        public virtual string DestRange { get; set; }

        /// <summary>
        /// Output only. Direction of the routes exchanged with the peer network, from the VMware Engine network
        /// perspective: * Routes of direction `INCOMING` are imported from the peer network. * Routes of direction
        /// `OUTGOING` are exported from the intranet VPC network of the VMware Engine network.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("direction")]
        public virtual string Direction { get; set; }

        /// <summary>
        /// Output only. True if the peering route has been imported from a peered VPC network; false otherwise. The
        /// import happens if the field `NetworkPeering.importCustomRoutes` is true for this network,
        /// `NetworkPeering.exportCustomRoutes` is true for the peer VPC network, and the import does not result in a
        /// route conflict.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imported")]
        public virtual System.Nullable<bool> Imported { get; set; }

        /// <summary>
        /// Output only. Region containing the next hop of the peering route. This field only applies to dynamic routes
        /// in the peer VPC network.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextHopRegion")]
        public virtual string NextHopRegion { get; set; }

        /// <summary>Output only. The priority of the peering route.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priority")]
        public virtual System.Nullable<long> Priority { get; set; }

        /// <summary>Output only. Type of the route in the peer VPC network.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An Identity and Access Management (IAM) policy, which specifies access controls for Google Cloud resources. A
    /// `Policy` is a collection of `bindings`. A `binding` binds one or more `members`, or principals, to a single
    /// `role`. Principals can be user accounts, service accounts, Google groups, and domains (such as G Suite). A
    /// `role` is a named list of permissions; each `role` can be an IAM predefined role or a user-created custom role.
    /// For some types of Google Cloud resources, a `binding` can also specify a `condition`, which is a logical
    /// expression that allows access to a resource only if the expression evaluates to `true`. A condition can add
    /// constraints based on attributes of the request, the resource, or both. To learn which resources support
    /// conditions in their IAM policies, see the [IAM
    /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies). **JSON example:**
    /// ```
    /// {
    /// "bindings": [ { "role": "roles/resourcemanager.organizationAdmin", "members": [ "user:mike@example.com",
    /// "group:admins@example.com", "domain:google.com", "serviceAccount:my-project-id@appspot.gserviceaccount.com" ] },
    /// { "role": "roles/resourcemanager.organizationViewer", "members": [ "user:eve@example.com" ], "condition": {
    /// "title": "expirable access", "description": "Does not grant access after Sep 2020", "expression": "request.time
    /// &amp;lt; timestamp('2020-10-01T00:00:00.000Z')", } } ], "etag": "BwWWja0YfJA=", "version": 3 }
    /// ```
    /// **YAML
    /// example:**
    /// ```
    /// bindings: - members: - user:mike@example.com - group:admins@example.com - domain:google.com -
    /// serviceAccount:my-project-id@appspot.gserviceaccount.com role: roles/resourcemanager.organizationAdmin -
    /// members: - user:eve@example.com role: roles/resourcemanager.organizationViewer condition: title: expirable
    /// access description: Does not grant access after Sep 2020 expression: request.time &amp;lt;
    /// timestamp('2020-10-01T00:00:00.000Z') etag: BwWWja0YfJA= version: 3
    /// ```
    /// For a description of IAM and its
    /// features, see the [IAM documentation](https://cloud.google.com/iam/docs/).
    /// </summary>
    public class Policy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies cloud audit logging configuration for this policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditConfigs")]
        public virtual System.Collections.Generic.IList<AuditConfig> AuditConfigs { get; set; }

        /// <summary>
        /// Associates a list of `members`, or principals, with a `role`. Optionally, may specify a `condition` that
        /// determines how and when the `bindings` are applied. Each of the `bindings` must contain at least one
        /// principal. The `bindings` in a `Policy` can refer to up to 1,500 principals; up to 250 of these principals
        /// can be Google groups. Each occurrence of a principal counts towards these limits. For example, if the
        /// `bindings` grant 50 different roles to `user:alice@example.com`, and not to any other principal, then you
        /// can add another 1,450 principals to the `bindings` in the `Policy`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bindings")]
        public virtual System.Collections.Generic.IList<Binding> Bindings { get; set; }

        /// <summary>
        /// `etag` is used for optimistic concurrency control as a way to help prevent simultaneous updates of a policy
        /// from overwriting each other. It is strongly suggested that systems make use of the `etag` in the
        /// read-modify-write cycle to perform policy updates in order to avoid race conditions: An `etag` is returned
        /// in the response to `getIamPolicy`, and systems are expected to put that etag in the request to
        /// `setIamPolicy` to ensure that their change will be applied to the same version of the policy. **Important:**
        /// If you use IAM Conditions, you must include the `etag` field whenever you call `setIamPolicy`. If you omit
        /// this field, then IAM allows you to overwrite a version `3` policy with a version `1` policy, and all of the
        /// conditions in the version `3` policy are lost.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Specifies the format of the policy. Valid values are `0`, `1`, and `3`. Requests that specify an invalid
        /// value are rejected. Any operation that affects conditional role bindings must specify version `3`. This
        /// requirement applies to the following operations: * Getting a policy that includes a conditional role binding
        /// * Adding a conditional role binding to a policy * Changing a conditional role binding in a policy * Removing
        /// any role binding, with or without a condition, from a policy that includes conditions **Important:** If you
        /// use IAM Conditions, you must include the `etag` field whenever you call `setIamPolicy`. If you omit this
        /// field, then IAM allows you to overwrite a version `3` policy with a version `1` policy, and all of the
        /// conditions in the version `3` policy are lost. If a policy does not include any conditions, operations on
        /// that policy may specify any valid version or leave the field unset. To learn which resources support
        /// conditions in their IAM policies, see the [IAM
        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual System.Nullable<int> Version { get; set; }
    }

    /// <summary>
    /// Users/Service accounts which have access for DNS binding on the intranet VPC corresponding to the consumer
    /// project.
    /// </summary>
    public class Principal : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The service account which needs to be granted the permission.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>The user who needs to be granted permission.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("user")]
        public virtual string User { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a private cloud resource. Private clouds of type `STANDARD` and `TIME_LIMITED` are zonal resources,
    /// `STRETCHED` private clouds are regional.
    /// </summary>
    public class PrivateCloud : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Creation time of this resource.</summary>
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

        private string _deleteTimeRaw;

        private object _deleteTime;

        /// <summary>Output only. Time when the resource was scheduled for deletion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteTime")]
        public virtual string DeleteTimeRaw
        {
            get => _deleteTimeRaw;
            set
            {
                _deleteTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _deleteTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="DeleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use DeleteTimeDateTimeOffset instead.")]
        public virtual object DeleteTime
        {
            get => _deleteTime;
            set
            {
                _deleteTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _deleteTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="DeleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? DeleteTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(DeleteTimeRaw);
            set => DeleteTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>User-provided description for this private cloud.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        private string _expireTimeRaw;

        private object _expireTime;

        /// <summary>Output only. Time when the resource will be irreversibly deleted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expireTime")]
        public virtual string ExpireTimeRaw
        {
            get => _expireTimeRaw;
            set
            {
                _expireTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _expireTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ExpireTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ExpireTimeDateTimeOffset instead.")]
        public virtual object ExpireTime
        {
            get => _expireTime;
            set
            {
                _expireTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _expireTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ExpireTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ExpireTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ExpireTimeRaw);
            set => ExpireTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Output only. HCX appliance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hcx")]
        public virtual Hcx Hcx { get; set; }

        /// <summary>
        /// Required. Input only. The management cluster for this private cloud. This field is required during creation
        /// of the private cloud to provide details for the default cluster. The following fields can't be changed after
        /// private cloud creation: `ManagementCluster.clusterId`, `ManagementCluster.nodeTypeId`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managementCluster")]
        public virtual ManagementCluster ManagementCluster { get; set; }

        /// <summary>
        /// Output only. Identifier. The resource name of this private cloud. Resource names are schemeless URIs that
        /// follow the conventions in https://cloud.google.com/apis/design/resource_names. For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. Network configuration of the private cloud.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkConfig")]
        public virtual NetworkConfig NetworkConfig { get; set; }

        /// <summary>Output only. NSX appliance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nsx")]
        public virtual Nsx Nsx { get; set; }

        /// <summary>
        /// Output only. State of the resource. New values may be added to this enum when appropriate.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Optional. Type of the private cloud. Defaults to STANDARD.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>Output only. System-generated unique identifier for the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Last update time of this resource.</summary>
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

        /// <summary>Output only. Vcenter appliance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vcenter")]
        public virtual Vcenter Vcenter { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Private connection resource that provides connectivity for VMware Engine private clouds.</summary>
    public class PrivateConnection : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Creation time of this resource.</summary>
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

        /// <summary>Optional. User-provided description for this private connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Output only. The resource name of the private connection. Resource names are schemeless URIs that follow the
        /// conventions in https://cloud.google.com/apis/design/resource_names. For example:
        /// `projects/my-project/locations/us-central1/privateConnections/my-connection`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. VPC network peering id between given network VPC and VMwareEngineNetwork.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("peeringId")]
        public virtual string PeeringId { get; set; }

        /// <summary>Output only. Peering state between service network and VMware Engine network.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("peeringState")]
        public virtual string PeeringState { get; set; }

        /// <summary>
        /// Optional. Routing Mode. Default value is set to GLOBAL. For type = PRIVATE_SERVICE_ACCESS, this field can be
        /// set to GLOBAL or REGIONAL, for other types only GLOBAL is supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("routingMode")]
        public virtual string RoutingMode { get; set; }

        /// <summary>
        /// Required. Service network to create private connection. Specify the name in the following form:
        /// `projects/{project}/global/networks/{network_id}` For type = PRIVATE_SERVICE_ACCESS, this field represents
        /// servicenetworking VPC, e.g. projects/project-tp/global/networks/servicenetworking. For type =
        /// NETAPP_CLOUD_VOLUME, this field represents NetApp service VPC, e.g.
        /// projects/project-tp/global/networks/netapp-tenant-vpc. For type = DELL_POWERSCALE, this field represent Dell
        /// service VPC, e.g. projects/project-tp/global/networks/dell-tenant-vpc. For type= THIRD_PARTY_SERVICE, this
        /// field could represent a consumer VPC or any other producer VPC to which the VMware Engine Network needs to
        /// be connected, e.g. projects/project/global/networks/vpc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceNetwork")]
        public virtual string ServiceNetwork { get; set; }

        /// <summary>Output only. State of the private connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Required. Private connection type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>Output only. System-generated unique identifier for the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Last update time of this resource.</summary>
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

        /// <summary>
        /// Required. The relative resource name of Legacy VMware Engine network. Specify the name in the following
        /// form: `projects/{project}/locations/{location}/vmwareEngineNetworks/{vmware_engine_network_id}` where
        /// `{project}`, `{location}` will be same as specified in private connection resource name and
        /// `{vmware_engine_network_id}` will be in the form of `{location}`-default e.g.
        /// projects/project/locations/us-central1/vmwareEngineNetworks/us-central1-default.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmwareEngineNetwork")]
        public virtual string VmwareEngineNetwork { get; set; }

        /// <summary>
        /// Output only. The canonical name of the VMware Engine network in the form:
        /// `projects/{project_number}/locations/{location}/vmwareEngineNetworks/{vmware_engine_network_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmwareEngineNetworkCanonical")]
        public virtual string VmwareEngineNetworkCanonical { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for VmwareEngine.RepairManagementDnsZoneBindings</summary>
    public class RepairManagementDnsZoneBindingRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must retry your
        /// request, the server will know to ignore the request if it has already been completed. The server guarantees
        /// that a request doesn't result in creation of duplicate commitments for at least 60 minutes. For example,
        /// consider a situation where you make an initial request and the request times out. If you make the request
        /// again with the same request ID, the server can check if the original operation with the same request ID was
        /// received, and if so, will ignore the second request. This prevents clients from accidentally creating
        /// duplicate commitments. The request ID must be a valid UUID with the exception that zero UUID is not
        /// supported (00000000-0000-0000-0000-000000000000).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for VmwareEngine.ResetNsxCredentials</summary>
    public class ResetNsxCredentialsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must retry your
        /// request, the server will know to ignore the request if it has already been completed. The server guarantees
        /// that a request doesn't result in creation of duplicate commitments for at least 60 minutes. For example,
        /// consider a situation where you make an initial request and the request times out. If you make the request
        /// again with the same request ID, the server can check if original operation with the same request ID was
        /// received, and if so, will ignore the second request. This prevents clients from accidentally creating
        /// duplicate commitments. The request ID must be a valid UUID with the exception that zero UUID is not
        /// supported (00000000-0000-0000-0000-000000000000).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for VmwareEngine.ResetVcenterCredentials</summary>
    public class ResetVcenterCredentialsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must retry your
        /// request, the server will know to ignore the request if it has already been completed. The server guarantees
        /// that a request doesn't result in creation of duplicate commitments for at least 60 minutes. For example,
        /// consider a situation where you make an initial request and the request times out. If you make the request
        /// again with the same request ID, the server can check if original operation with the same request ID was
        /// received, and if so, will ignore the second request. This prevents clients from accidentally creating
        /// duplicate commitments. The request ID must be a valid UUID with the exception that zero UUID is not
        /// supported (00000000-0000-0000-0000-000000000000).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>
        /// Optional. The username of the user to be to reset the credentials. The default value of this field is
        /// CloudOwner@gve.local. The provided value should be one of the following: solution-user-01@gve.local,
        /// solution-user-02@gve.local, solution-user-03@gve.local, solution-user-04@gve.local,
        /// solution-user-05@gve.local, zertoadmin@gve.local.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for VmwareEngine.RevokeDnsBindPermission</summary>
    public class RevokeDnsBindPermissionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The consumer provided user/service account which needs to be granted permission to bind with the
        /// intranet VPC corresponding to the consumer project.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("principal")]
        public virtual Principal Principal { get; set; }

        /// <summary>
        /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must retry your
        /// request, the server will know to ignore the request if it has already been completed. The server guarantees
        /// that a request doesn't result in creation of duplicate commitments for at least 60 minutes. For example,
        /// consider a situation where you make an initial request and the request times out. If you make the request
        /// again with the same request ID, the server can check if original operation with the same request ID was
        /// received, and if so, will ignore the second request. This prevents clients from accidentally creating
        /// duplicate commitments. The request ID must be a valid UUID with the exception that zero UUID is not
        /// supported (00000000-0000-0000-0000-000000000000).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Schedule for the upgrade.</summary>
    public class Schedule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Output Only. Constraints applied to the schedule. These constraints should be applicable at the
        /// time of any rescheduling.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("constraints")]
        public virtual Constraints Constraints { get; set; }

        /// <summary>
        /// Output only. Output Only. The schedule is open for edits during this time interval or window.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("editWindow")]
        public virtual Interval EditWindow { get; set; }

        /// <summary>
        /// Output only. Output Only. Indicates who most recently edited the upgrade schedule. The value is updated
        /// whenever the upgrade is rescheduled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastEditor")]
        public virtual string LastEditor { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>Required. The scheduled start time for the upgrade.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual string StartTimeRaw
        {
            get => _startTimeRaw;
            set
            {
                _startTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _startTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="StartTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use StartTimeDateTimeOffset instead.")]
        public virtual object StartTime
        {
            get => _startTime;
            set
            {
                _startTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _startTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="StartTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? StartTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(StartTimeRaw);
            set => StartTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Required. Weekly time windows for upgrade activities. The server performs upgrade activities during these
        /// time windows to minimize disruptions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weeklyWindows")]
        public virtual System.Collections.Generic.IList<TimeWindow> WeeklyWindows { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for `SetIamPolicy` method.</summary>
    public class SetIamPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of the policy is limited to a few
        /// 10s of KB. An empty policy is a valid policy but certain Google Cloud services (such as Projects) might
        /// reject them.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual Policy Policy { get; set; }

        /// <summary>
        /// OPTIONAL: A FieldMask specifying which fields of the policy to modify. Only the fields in the mask will be
        /// modified. If no mask is provided, the following default mask is used: `paths: "bindings, etag"`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

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

    /// <summary>Configuration of a stretched cluster.</summary>
    public class StretchedClusterConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Zone that will remain operational when connection between the two zones is lost. Specify the
        /// resource name of a zone that belongs to the region of the private cloud. For example:
        /// `projects/{project}/locations/europe-west3-a` where `{project}` can either be a project number or a project
        /// ID.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("preferredLocation")]
        public virtual string PreferredLocation { get; set; }

        /// <summary>
        /// Required. Additional zone for a higher level of availability and load balancing. Specify the resource name
        /// of a zone that belongs to the region of the private cloud. For example:
        /// `projects/{project}/locations/europe-west3-b` where `{project}` can either be a project number or a project
        /// ID.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secondaryLocation")]
        public virtual string SecondaryLocation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Subnet in a private cloud. Either `management` subnets (such as vMotion) that are read-only, or `userDefined`,
    /// which can also be updated.
    /// </summary>
    public class Subnet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The IP address of the gateway of this subnet. Must fall within the IP prefix defined above.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gatewayIp")]
        public virtual string GatewayIp { get; set; }

        /// <summary>The IP address range of the subnet in CIDR format '10.0.0.0/24'.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipCidrRange")]
        public virtual string IpCidrRange { get; set; }

        /// <summary>
        /// Output only. Identifier. The resource name of this subnet. Resource names are schemeless URIs that follow
        /// the conventions in https://cloud.google.com/apis/design/resource_names. For example:
        /// `projects/my-project/locations/us-central1-a/privateClouds/my-cloud/subnets/my-subnet`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The state of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. The type of the subnet. For example "management" or "userDefined".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>Output only. VLAN ID of the VLAN on which the subnet is configured</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vlanId")]
        public virtual System.Nullable<int> VlanId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for `TestIamPermissions` method.</summary>
    public class TestIamPermissionsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The set of permissions to check for the `resource`. Permissions with wildcards (such as `*` or `storage.*`)
        /// are not allowed. For more information see [IAM
        /// Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<string> Permissions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for `TestIamPermissions` method.</summary>
    public class TestIamPermissionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A subset of `TestPermissionsRequest.permissions` that the caller is allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<string> Permissions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Thresholds define the utilization of resources triggering scale-out and scale-in operations.</summary>
    public class Thresholds : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The utilization triggering the scale-in operation in percent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scaleIn")]
        public virtual System.Nullable<int> ScaleIn { get; set; }

        /// <summary>Required. The utilization triggering the scale-out operation in percent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scaleOut")]
        public virtual System.Nullable<int> ScaleOut { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a time of day. The date and time zone are either not significant or are specified elsewhere. An API
    /// may choose to allow leap seconds. Related types are google.type.Date and `google.protobuf.Timestamp`.
    /// </summary>
    public class TimeOfDay : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Hours of a day in 24 hour format. Must be greater than or equal to 0 and typically must be less than or
        /// equal to 23. An API may choose to allow the value "24:00:00" for scenarios like business closing time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hours")]
        public virtual System.Nullable<int> Hours { get; set; }

        /// <summary>Minutes of an hour. Must be greater than or equal to 0 and less than or equal to 59.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minutes")]
        public virtual System.Nullable<int> Minutes { get; set; }

        /// <summary>
        /// Fractions of seconds, in nanoseconds. Must be greater than or equal to 0 and less than or equal to
        /// 999,999,999.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nanos")]
        public virtual System.Nullable<int> Nanos { get; set; }

        /// <summary>
        /// Seconds of a minute. Must be greater than or equal to 0 and typically must be less than or equal to 59. An
        /// API may allow the value 60 if it allows leap-seconds.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seconds")]
        public virtual System.Nullable<int> Seconds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the time window to perform upgrade activities.</summary>
    public class TimeWindow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Day of the week for this window.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dayOfWeek")]
        public virtual string DayOfWeek { get; set; }

        /// <summary>
        /// Required. The duration of the window. The max allowed duration for any window is 24 hours.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual object Duration { get; set; }

        /// <summary>Required. Time in UTC when the window starts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual TimeOfDay StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for VmwareEngine.UndeletePrivateCloud</summary>
    public class UndeletePrivateCloudRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The request ID must be a valid UUID with the exception that zero UUID is not supported
        /// (00000000-0000-0000-0000-000000000000).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes Private cloud Upgrade.</summary>
    public class Upgrade : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Output Only. The list of component upgrades.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("componentUpgrades")]
        public virtual System.Collections.Generic.IList<VmwareUpgradeComponent> ComponentUpgrades { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Output Only. Creation time of this resource.</summary>
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
        /// Output only. Output Only. The description of the upgrade. This is used to provide additional information
        /// about the private cloud upgrade, such as the upgrade's purpose, the changes included in the upgrade, or any
        /// other relevant information about the upgrade.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>Output only. Output Only. End time of the upgrade.</summary>
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

        /// <summary>
        /// Output only. Output Only. The estimated total duration of the upgrade. This information can be used to plan
        /// or schedule upgrades to minimize disruptions. Please note that the estimated duration is only an estimate.
        /// The actual upgrade duration may vary.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("estimatedDuration")]
        public virtual object EstimatedDuration { get; set; }

        /// <summary>
        /// The etag for the upgrade resource. If this is provided on update, it must match the server's etag.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Output only. Identifier. The resource name of the private cloud `Upgrade`. Resource names are schemeless
        /// URIs that follow the conventions in https://cloud.google.com/apis/design/resource_names. For example:
        /// `projects/my-project/locations/us-west1-a/privateClouds/my-cloud/upgrades/my-upgrade`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Schedule details for the upgrade.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schedule")]
        public virtual Schedule Schedule { get; set; }

        /// <summary>Output only. Output Only. The start version</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startVersion")]
        public virtual string StartVersion { get; set; }

        /// <summary>Output only. The current state of the upgrade.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. Output Only. The target version</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetVersion")]
        public virtual string TargetVersion { get; set; }

        /// <summary>Output only. Output Only. The type of upgrade.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>Output only. System-generated unique identifier for the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Output Only. Last update time of this resource.</summary>
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

        /// <summary>Output only. </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }
    }

    /// <summary>Details about a vCenter Server management appliance.</summary>
    public class Vcenter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Fully qualified domain name of the appliance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fqdn")]
        public virtual string Fqdn { get; set; }

        /// <summary>Internal IP address of the appliance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("internalIp")]
        public virtual string InternalIp { get; set; }

        /// <summary>Output only. The state of the appliance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Version of the appliance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>VMware Engine network resource that provides connectivity for VMware Engine private clouds.</summary>
    public class VmwareEngineNetwork : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Creation time of this resource.</summary>
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

        /// <summary>User-provided description for this VMware Engine network.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Checksum that may be sent on update and delete requests to ensure that the user-provided value is up to date
        /// before the server processes a request. The server computes checksums based on the value of other fields in
        /// the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Output only. Identifier. The resource name of the VMware Engine network. Resource names are schemeless URIs
        /// that follow the conventions in https://cloud.google.com/apis/design/resource_names. For example:
        /// `projects/my-project/locations/global/vmwareEngineNetworks/my-network`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. State of the VMware Engine network.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Required. VMware Engine network type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>Output only. System-generated unique identifier for the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Last update time of this resource.</summary>
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

        /// <summary>
        /// Output only. VMware Engine service VPC networks that provide connectivity from a private cloud to customer
        /// projects, the internet, and other Google Cloud services.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vpcNetworks")]
        public virtual System.Collections.Generic.IList<VpcNetwork> VpcNetworks { get; set; }
    }

    /// <summary>Per component upgrade resource</summary>
    public class VmwareUpgradeComponent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Type of component</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("componentType")]
        public virtual string ComponentType { get; set; }

        /// <summary>Output only. Component's upgrade state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a VMware Engine VPC network that is managed by a VMware Engine network resource.</summary>
    public class VpcNetwork : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The relative resource name of the service VPC network this VMware Engine network is attached
        /// to. For example: `projects/123123/global/networks/my-network`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("network")]
        public virtual string Network { get; set; }

        /// <summary>Output only. Type of VPC network (INTRANET, INTERNET, or GOOGLE_CLOUD)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a time interval, spanning across days of the week. Until local timezones are supported, this interval
    /// is in UTC.
    /// </summary>
    public class WeeklyTimeInterval : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The day on which the interval ends. Can be same as start day.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endDay")]
        public virtual string EndDay { get; set; }

        /// <summary>Output only. The time on the end day at which the interval ends.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual TimeOfDay EndTime { get; set; }

        /// <summary>Output only. The day on which the interval starts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startDay")]
        public virtual string StartDay { get; set; }

        /// <summary>Output only. The time on the start day at which the interval starts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual TimeOfDay StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
