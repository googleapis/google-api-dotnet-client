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

namespace Google.Apis.Dns.v1beta2
{
    /// <summary>The Dns Service.</summary>
    public class DnsService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1beta2";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public DnsService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public DnsService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Changes = new ChangesResource(this);
            DnsKeys = new DnsKeysResource(this);
            ManagedZoneOperations = new ManagedZoneOperationsResource(this);
            ManagedZones = new ManagedZonesResource(this);
            Policies = new PoliciesResource(this);
            Projects = new ProjectsResource(this);
            ResourceRecordSets = new ResourceRecordSetsResource(this);
            ResponsePolicies = new ResponsePoliciesResource(this);
            ResponsePolicyRules = new ResponsePolicyRulesResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "dns";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://dns.googleapis.com/";
        #else
            "https://dns.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://dns.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud DNS API.</summary>
        public class Scope
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>View your data across Google Cloud Platform services</summary>
            public static string CloudPlatformReadOnly = "https://www.googleapis.com/auth/cloud-platform.read-only";

            /// <summary>View your DNS records hosted by Google Cloud DNS</summary>
            public static string NdevClouddnsReadonly = "https://www.googleapis.com/auth/ndev.clouddns.readonly";

            /// <summary>View and manage your DNS records hosted by Google Cloud DNS</summary>
            public static string NdevClouddnsReadwrite = "https://www.googleapis.com/auth/ndev.clouddns.readwrite";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud DNS API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>View your data across Google Cloud Platform services</summary>
            public const string CloudPlatformReadOnly = "https://www.googleapis.com/auth/cloud-platform.read-only";

            /// <summary>View your DNS records hosted by Google Cloud DNS</summary>
            public const string NdevClouddnsReadonly = "https://www.googleapis.com/auth/ndev.clouddns.readonly";

            /// <summary>View and manage your DNS records hosted by Google Cloud DNS</summary>
            public const string NdevClouddnsReadwrite = "https://www.googleapis.com/auth/ndev.clouddns.readwrite";
        }

        /// <summary>Gets the Changes resource.</summary>
        public virtual ChangesResource Changes { get; }

        /// <summary>Gets the DnsKeys resource.</summary>
        public virtual DnsKeysResource DnsKeys { get; }

        /// <summary>Gets the ManagedZoneOperations resource.</summary>
        public virtual ManagedZoneOperationsResource ManagedZoneOperations { get; }

        /// <summary>Gets the ManagedZones resource.</summary>
        public virtual ManagedZonesResource ManagedZones { get; }

        /// <summary>Gets the Policies resource.</summary>
        public virtual PoliciesResource Policies { get; }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }

        /// <summary>Gets the ResourceRecordSets resource.</summary>
        public virtual ResourceRecordSetsResource ResourceRecordSets { get; }

        /// <summary>Gets the ResponsePolicies resource.</summary>
        public virtual ResponsePoliciesResource ResponsePolicies { get; }

        /// <summary>Gets the ResponsePolicyRules resource.</summary>
        public virtual ResponsePolicyRulesResource ResponsePolicyRules { get; }
    }

    /// <summary>A base abstract class for Dns requests.</summary>
    public abstract class DnsBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new DnsBaseServiceRequest instance.</summary>
        protected DnsBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Dns parameter list.</summary>
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

        /// <summary>Atomically updates the ResourceRecordSet collection.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="project">Identifies the project addressed by this request.</param>
        /// <param name="managedZone">
        /// Identifies the managed zone addressed by this request. Can be the managed zone name or ID.
        /// </param>
        public virtual CreateRequest Create(Google.Apis.Dns.v1beta2.Data.Change body, string project, string managedZone)
        {
            return new CreateRequest(service, body, project, managedZone);
        }

        /// <summary>Atomically updates the ResourceRecordSet collection.</summary>
        public class CreateRequest : DnsBaseServiceRequest<Google.Apis.Dns.v1beta2.Data.Change>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Dns.v1beta2.Data.Change body, string project, string managedZone) : base(service)
            {
                Project = project;
                ManagedZone = managedZone;
                Body = body;
                InitParameters();
            }

            /// <summary>Identifies the project addressed by this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>
            /// Identifies the managed zone addressed by this request. Can be the managed zone name or ID.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("managedZone", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ManagedZone { get; private set; }

            /// <summary>
            /// For mutating operation requests only. An optional identifier specified by the client. Must be unique for
            /// operation resources in the Operations collection.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("clientOperationId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ClientOperationId { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Dns.v1beta2.Data.Change Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "dns/v1beta2/projects/{project}/managedZones/{managedZone}/changes";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("managedZone", new Google.Apis.Discovery.Parameter
                {
                    Name = "managedZone",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("clientOperationId", new Google.Apis.Discovery.Parameter
                {
                    Name = "clientOperationId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Fetches the representation of an existing Change.</summary>
        /// <param name="project">Identifies the project addressed by this request.</param>
        /// <param name="managedZone">
        /// Identifies the managed zone addressed by this request. Can be the managed zone name or ID.
        /// </param>
        /// <param name="changeId">
        /// The identifier of the requested change, from a previous ResourceRecordSetsChangeResponse.
        /// </param>
        public virtual GetRequest Get(string project, string managedZone, string changeId)
        {
            return new GetRequest(service, project, managedZone, changeId);
        }

        /// <summary>Fetches the representation of an existing Change.</summary>
        public class GetRequest : DnsBaseServiceRequest<Google.Apis.Dns.v1beta2.Data.Change>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string project, string managedZone, string changeId) : base(service)
            {
                Project = project;
                ManagedZone = managedZone;
                ChangeId = changeId;
                InitParameters();
            }

            /// <summary>Identifies the project addressed by this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>
            /// Identifies the managed zone addressed by this request. Can be the managed zone name or ID.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("managedZone", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ManagedZone { get; private set; }

            /// <summary>
            /// The identifier of the requested change, from a previous ResourceRecordSetsChangeResponse.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("changeId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ChangeId { get; private set; }

            /// <summary>
            /// For mutating operation requests only. An optional identifier specified by the client. Must be unique for
            /// operation resources in the Operations collection.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("clientOperationId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ClientOperationId { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "dns/v1beta2/projects/{project}/managedZones/{managedZone}/changes/{changeId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("managedZone", new Google.Apis.Discovery.Parameter
                {
                    Name = "managedZone",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("changeId", new Google.Apis.Discovery.Parameter
                {
                    Name = "changeId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("clientOperationId", new Google.Apis.Discovery.Parameter
                {
                    Name = "clientOperationId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Enumerates Changes to a ResourceRecordSet collection.</summary>
        /// <param name="project">Identifies the project addressed by this request.</param>
        /// <param name="managedZone">
        /// Identifies the managed zone addressed by this request. Can be the managed zone name or ID.
        /// </param>
        public virtual ListRequest List(string project, string managedZone)
        {
            return new ListRequest(service, project, managedZone);
        }

        /// <summary>Enumerates Changes to a ResourceRecordSet collection.</summary>
        public class ListRequest : DnsBaseServiceRequest<Google.Apis.Dns.v1beta2.Data.ChangesListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string project, string managedZone) : base(service)
            {
                Project = project;
                ManagedZone = managedZone;
                InitParameters();
            }

            /// <summary>Identifies the project addressed by this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>
            /// Identifies the managed zone addressed by this request. Can be the managed zone name or ID.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("managedZone", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ManagedZone { get; private set; }

            /// <summary>
            /// Optional. Maximum number of results to be returned. If unspecified, the server decides how many results
            /// to return.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>
            /// Optional. A tag returned by a previous list request that was truncated. Use this parameter to continue a
            /// previous list request.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Sorting criterion. The only supported value is change sequence.</summary>
            [Google.Apis.Util.RequestParameterAttribute("sortBy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<SortByEnum> SortBy { get; set; }

            /// <summary>Sorting criterion. The only supported value is change sequence.</summary>
            public enum SortByEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("changeSequence")]
                ChangeSequence = 0,
            }

            /// <summary>Sorting order direction: 'ascending' or 'descending'.</summary>
            [Google.Apis.Util.RequestParameterAttribute("sortOrder", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string SortOrder { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "dns/v1beta2/projects/{project}/managedZones/{managedZone}/changes";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("managedZone", new Google.Apis.Discovery.Parameter
                {
                    Name = "managedZone",
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
                RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageToken",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("sortBy", new Google.Apis.Discovery.Parameter
                {
                    Name = "sortBy",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "changeSequence",
                    Pattern = null,
                });
                RequestParameters.Add("sortOrder", new Google.Apis.Discovery.Parameter
                {
                    Name = "sortOrder",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "dnsKeys" collection of methods.</summary>
    public class DnsKeysResource
    {
        private const string Resource = "dnsKeys";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public DnsKeysResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Fetches the representation of an existing DnsKey.</summary>
        /// <param name="project">Identifies the project addressed by this request.</param>
        /// <param name="managedZone">
        /// Identifies the managed zone addressed by this request. Can be the managed zone name or ID.
        /// </param>
        /// <param name="dnsKeyId">The identifier of the requested DnsKey.</param>
        public virtual GetRequest Get(string project, string managedZone, string dnsKeyId)
        {
            return new GetRequest(service, project, managedZone, dnsKeyId);
        }

        /// <summary>Fetches the representation of an existing DnsKey.</summary>
        public class GetRequest : DnsBaseServiceRequest<Google.Apis.Dns.v1beta2.Data.DnsKey>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string project, string managedZone, string dnsKeyId) : base(service)
            {
                Project = project;
                ManagedZone = managedZone;
                DnsKeyId = dnsKeyId;
                InitParameters();
            }

            /// <summary>Identifies the project addressed by this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>
            /// Identifies the managed zone addressed by this request. Can be the managed zone name or ID.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("managedZone", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ManagedZone { get; private set; }

            /// <summary>The identifier of the requested DnsKey.</summary>
            [Google.Apis.Util.RequestParameterAttribute("dnsKeyId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DnsKeyId { get; private set; }

            /// <summary>
            /// For mutating operation requests only. An optional identifier specified by the client. Must be unique for
            /// operation resources in the Operations collection.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("clientOperationId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ClientOperationId { get; set; }

            /// <summary>
            /// An optional comma-separated list of digest types to compute and display for key signing keys. If
            /// omitted, the recommended digest type is computed and displayed.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("digestType", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string DigestType { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "dns/v1beta2/projects/{project}/managedZones/{managedZone}/dnsKeys/{dnsKeyId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("managedZone", new Google.Apis.Discovery.Parameter
                {
                    Name = "managedZone",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("dnsKeyId", new Google.Apis.Discovery.Parameter
                {
                    Name = "dnsKeyId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("clientOperationId", new Google.Apis.Discovery.Parameter
                {
                    Name = "clientOperationId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("digestType", new Google.Apis.Discovery.Parameter
                {
                    Name = "digestType",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Enumerates DnsKeys to a ResourceRecordSet collection.</summary>
        /// <param name="project">Identifies the project addressed by this request.</param>
        /// <param name="managedZone">
        /// Identifies the managed zone addressed by this request. Can be the managed zone name or ID.
        /// </param>
        public virtual ListRequest List(string project, string managedZone)
        {
            return new ListRequest(service, project, managedZone);
        }

        /// <summary>Enumerates DnsKeys to a ResourceRecordSet collection.</summary>
        public class ListRequest : DnsBaseServiceRequest<Google.Apis.Dns.v1beta2.Data.DnsKeysListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string project, string managedZone) : base(service)
            {
                Project = project;
                ManagedZone = managedZone;
                InitParameters();
            }

            /// <summary>Identifies the project addressed by this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>
            /// Identifies the managed zone addressed by this request. Can be the managed zone name or ID.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("managedZone", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ManagedZone { get; private set; }

            /// <summary>
            /// An optional comma-separated list of digest types to compute and display for key signing keys. If
            /// omitted, the recommended digest type is computed and displayed.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("digestType", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string DigestType { get; set; }

            /// <summary>
            /// Optional. Maximum number of results to be returned. If unspecified, the server decides how many results
            /// to return.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>
            /// Optional. A tag returned by a previous list request that was truncated. Use this parameter to continue a
            /// previous list request.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "dns/v1beta2/projects/{project}/managedZones/{managedZone}/dnsKeys";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("managedZone", new Google.Apis.Discovery.Parameter
                {
                    Name = "managedZone",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("digestType", new Google.Apis.Discovery.Parameter
                {
                    Name = "digestType",
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
            }
        }
    }

    /// <summary>The "managedZoneOperations" collection of methods.</summary>
    public class ManagedZoneOperationsResource
    {
        private const string Resource = "managedZoneOperations";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ManagedZoneOperationsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Fetches the representation of an existing Operation.</summary>
        /// <param name="project">Identifies the project addressed by this request.</param>
        /// <param name="managedZone">Identifies the managed zone addressed by this request.</param>
        /// <param name="operation">Identifies the operation addressed by this request (ID of the operation).</param>
        public virtual GetRequest Get(string project, string managedZone, string operation)
        {
            return new GetRequest(service, project, managedZone, operation);
        }

        /// <summary>Fetches the representation of an existing Operation.</summary>
        public class GetRequest : DnsBaseServiceRequest<Google.Apis.Dns.v1beta2.Data.Operation>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string project, string managedZone, string operation) : base(service)
            {
                Project = project;
                ManagedZone = managedZone;
                Operation = operation;
                InitParameters();
            }

            /// <summary>Identifies the project addressed by this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Identifies the managed zone addressed by this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("managedZone", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ManagedZone { get; private set; }

            /// <summary>Identifies the operation addressed by this request (ID of the operation).</summary>
            [Google.Apis.Util.RequestParameterAttribute("operation", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Operation { get; private set; }

            /// <summary>
            /// For mutating operation requests only. An optional identifier specified by the client. Must be unique for
            /// operation resources in the Operations collection.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("clientOperationId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ClientOperationId { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "dns/v1beta2/projects/{project}/managedZones/{managedZone}/operations/{operation}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("managedZone", new Google.Apis.Discovery.Parameter
                {
                    Name = "managedZone",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("operation", new Google.Apis.Discovery.Parameter
                {
                    Name = "operation",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("clientOperationId", new Google.Apis.Discovery.Parameter
                {
                    Name = "clientOperationId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Enumerates Operations for the given ManagedZone.</summary>
        /// <param name="project">Identifies the project addressed by this request.</param>
        /// <param name="managedZone">Identifies the managed zone addressed by this request.</param>
        public virtual ListRequest List(string project, string managedZone)
        {
            return new ListRequest(service, project, managedZone);
        }

        /// <summary>Enumerates Operations for the given ManagedZone.</summary>
        public class ListRequest : DnsBaseServiceRequest<Google.Apis.Dns.v1beta2.Data.ManagedZoneOperationsListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string project, string managedZone) : base(service)
            {
                Project = project;
                ManagedZone = managedZone;
                InitParameters();
            }

            /// <summary>Identifies the project addressed by this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Identifies the managed zone addressed by this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("managedZone", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ManagedZone { get; private set; }

            /// <summary>
            /// Optional. Maximum number of results to be returned. If unspecified, the server decides how many results
            /// to return.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>
            /// Optional. A tag returned by a previous list request that was truncated. Use this parameter to continue a
            /// previous list request.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Sorting criterion. The only supported values are START_TIME and ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("sortBy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<SortByEnum> SortBy { get; set; }

            /// <summary>Sorting criterion. The only supported values are START_TIME and ID.</summary>
            public enum SortByEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("startTime")]
                StartTime = 0,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("id")]
                Id = 1,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "dns/v1beta2/projects/{project}/managedZones/{managedZone}/operations";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("managedZone", new Google.Apis.Discovery.Parameter
                {
                    Name = "managedZone",
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
                RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageToken",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("sortBy", new Google.Apis.Discovery.Parameter
                {
                    Name = "sortBy",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "startTime",
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "managedZones" collection of methods.</summary>
    public class ManagedZonesResource
    {
        private const string Resource = "managedZones";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ManagedZonesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Creates a new ManagedZone.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="project">Identifies the project addressed by this request.</param>
        public virtual CreateRequest Create(Google.Apis.Dns.v1beta2.Data.ManagedZone body, string project)
        {
            return new CreateRequest(service, body, project);
        }

        /// <summary>Creates a new ManagedZone.</summary>
        public class CreateRequest : DnsBaseServiceRequest<Google.Apis.Dns.v1beta2.Data.ManagedZone>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Dns.v1beta2.Data.ManagedZone body, string project) : base(service)
            {
                Project = project;
                Body = body;
                InitParameters();
            }

            /// <summary>Identifies the project addressed by this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>
            /// For mutating operation requests only. An optional identifier specified by the client. Must be unique for
            /// operation resources in the Operations collection.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("clientOperationId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ClientOperationId { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Dns.v1beta2.Data.ManagedZone Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "dns/v1beta2/projects/{project}/managedZones";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("clientOperationId", new Google.Apis.Discovery.Parameter
                {
                    Name = "clientOperationId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Deletes a previously created ManagedZone.</summary>
        /// <param name="project">Identifies the project addressed by this request.</param>
        /// <param name="managedZone">
        /// Identifies the managed zone addressed by this request. Can be the managed zone name or ID.
        /// </param>
        public virtual DeleteRequest Delete(string project, string managedZone)
        {
            return new DeleteRequest(service, project, managedZone);
        }

        /// <summary>Deletes a previously created ManagedZone.</summary>
        public class DeleteRequest : DnsBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string project, string managedZone) : base(service)
            {
                Project = project;
                ManagedZone = managedZone;
                InitParameters();
            }

            /// <summary>Identifies the project addressed by this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>
            /// Identifies the managed zone addressed by this request. Can be the managed zone name or ID.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("managedZone", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ManagedZone { get; private set; }

            /// <summary>
            /// For mutating operation requests only. An optional identifier specified by the client. Must be unique for
            /// operation resources in the Operations collection.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("clientOperationId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ClientOperationId { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "dns/v1beta2/projects/{project}/managedZones/{managedZone}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("managedZone", new Google.Apis.Discovery.Parameter
                {
                    Name = "managedZone",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("clientOperationId", new Google.Apis.Discovery.Parameter
                {
                    Name = "clientOperationId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Fetches the representation of an existing ManagedZone.</summary>
        /// <param name="project">Identifies the project addressed by this request.</param>
        /// <param name="managedZone">
        /// Identifies the managed zone addressed by this request. Can be the managed zone name or ID.
        /// </param>
        public virtual GetRequest Get(string project, string managedZone)
        {
            return new GetRequest(service, project, managedZone);
        }

        /// <summary>Fetches the representation of an existing ManagedZone.</summary>
        public class GetRequest : DnsBaseServiceRequest<Google.Apis.Dns.v1beta2.Data.ManagedZone>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string project, string managedZone) : base(service)
            {
                Project = project;
                ManagedZone = managedZone;
                InitParameters();
            }

            /// <summary>Identifies the project addressed by this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>
            /// Identifies the managed zone addressed by this request. Can be the managed zone name or ID.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("managedZone", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ManagedZone { get; private set; }

            /// <summary>
            /// For mutating operation requests only. An optional identifier specified by the client. Must be unique for
            /// operation resources in the Operations collection.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("clientOperationId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ClientOperationId { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "dns/v1beta2/projects/{project}/managedZones/{managedZone}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("managedZone", new Google.Apis.Discovery.Parameter
                {
                    Name = "managedZone",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("clientOperationId", new Google.Apis.Discovery.Parameter
                {
                    Name = "clientOperationId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Enumerates ManagedZones that have been created but not yet deleted.</summary>
        /// <param name="project">Identifies the project addressed by this request.</param>
        public virtual ListRequest List(string project)
        {
            return new ListRequest(service, project);
        }

        /// <summary>Enumerates ManagedZones that have been created but not yet deleted.</summary>
        public class ListRequest : DnsBaseServiceRequest<Google.Apis.Dns.v1beta2.Data.ManagedZonesListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string project) : base(service)
            {
                Project = project;
                InitParameters();
            }

            /// <summary>Identifies the project addressed by this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Restricts the list to return only zones with this domain name.</summary>
            [Google.Apis.Util.RequestParameterAttribute("dnsName", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string DnsName { get; set; }

            /// <summary>
            /// Optional. Maximum number of results to be returned. If unspecified, the server decides how many results
            /// to return.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>
            /// Optional. A tag returned by a previous list request that was truncated. Use this parameter to continue a
            /// previous list request.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "dns/v1beta2/projects/{project}/managedZones";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("dnsName", new Google.Apis.Discovery.Parameter
                {
                    Name = "dnsName",
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
            }
        }

        /// <summary>Applies a partial update to an existing ManagedZone.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="project">Identifies the project addressed by this request.</param>
        /// <param name="managedZone">
        /// Identifies the managed zone addressed by this request. Can be the managed zone name or ID.
        /// </param>
        public virtual PatchRequest Patch(Google.Apis.Dns.v1beta2.Data.ManagedZone body, string project, string managedZone)
        {
            return new PatchRequest(service, body, project, managedZone);
        }

        /// <summary>Applies a partial update to an existing ManagedZone.</summary>
        public class PatchRequest : DnsBaseServiceRequest<Google.Apis.Dns.v1beta2.Data.Operation>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Dns.v1beta2.Data.ManagedZone body, string project, string managedZone) : base(service)
            {
                Project = project;
                ManagedZone = managedZone;
                Body = body;
                InitParameters();
            }

            /// <summary>Identifies the project addressed by this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>
            /// Identifies the managed zone addressed by this request. Can be the managed zone name or ID.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("managedZone", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ManagedZone { get; private set; }

            /// <summary>
            /// For mutating operation requests only. An optional identifier specified by the client. Must be unique for
            /// operation resources in the Operations collection.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("clientOperationId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ClientOperationId { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Dns.v1beta2.Data.ManagedZone Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "dns/v1beta2/projects/{project}/managedZones/{managedZone}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("managedZone", new Google.Apis.Discovery.Parameter
                {
                    Name = "managedZone",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("clientOperationId", new Google.Apis.Discovery.Parameter
                {
                    Name = "clientOperationId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates an existing ManagedZone.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="project">Identifies the project addressed by this request.</param>
        /// <param name="managedZone">
        /// Identifies the managed zone addressed by this request. Can be the managed zone name or ID.
        /// </param>
        public virtual UpdateRequest Update(Google.Apis.Dns.v1beta2.Data.ManagedZone body, string project, string managedZone)
        {
            return new UpdateRequest(service, body, project, managedZone);
        }

        /// <summary>Updates an existing ManagedZone.</summary>
        public class UpdateRequest : DnsBaseServiceRequest<Google.Apis.Dns.v1beta2.Data.Operation>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Dns.v1beta2.Data.ManagedZone body, string project, string managedZone) : base(service)
            {
                Project = project;
                ManagedZone = managedZone;
                Body = body;
                InitParameters();
            }

            /// <summary>Identifies the project addressed by this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>
            /// Identifies the managed zone addressed by this request. Can be the managed zone name or ID.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("managedZone", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ManagedZone { get; private set; }

            /// <summary>
            /// For mutating operation requests only. An optional identifier specified by the client. Must be unique for
            /// operation resources in the Operations collection.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("clientOperationId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ClientOperationId { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Dns.v1beta2.Data.ManagedZone Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "dns/v1beta2/projects/{project}/managedZones/{managedZone}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("managedZone", new Google.Apis.Discovery.Parameter
                {
                    Name = "managedZone",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("clientOperationId", new Google.Apis.Discovery.Parameter
                {
                    Name = "clientOperationId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "policies" collection of methods.</summary>
    public class PoliciesResource
    {
        private const string Resource = "policies";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public PoliciesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Creates a new Policy.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="project">Identifies the project addressed by this request.</param>
        public virtual CreateRequest Create(Google.Apis.Dns.v1beta2.Data.Policy body, string project)
        {
            return new CreateRequest(service, body, project);
        }

        /// <summary>Creates a new Policy.</summary>
        public class CreateRequest : DnsBaseServiceRequest<Google.Apis.Dns.v1beta2.Data.Policy>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Dns.v1beta2.Data.Policy body, string project) : base(service)
            {
                Project = project;
                Body = body;
                InitParameters();
            }

            /// <summary>Identifies the project addressed by this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>
            /// For mutating operation requests only. An optional identifier specified by the client. Must be unique for
            /// operation resources in the Operations collection.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("clientOperationId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ClientOperationId { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Dns.v1beta2.Data.Policy Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "dns/v1beta2/projects/{project}/policies";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("clientOperationId", new Google.Apis.Discovery.Parameter
                {
                    Name = "clientOperationId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Deletes a previously created Policy. Fails if the policy is still being referenced by a network.
        /// </summary>
        /// <param name="project">Identifies the project addressed by this request.</param>
        /// <param name="policy">User given friendly name of the policy addressed by this request.</param>
        public virtual DeleteRequest Delete(string project, string policy)
        {
            return new DeleteRequest(service, project, policy);
        }

        /// <summary>
        /// Deletes a previously created Policy. Fails if the policy is still being referenced by a network.
        /// </summary>
        public class DeleteRequest : DnsBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string project, string policy) : base(service)
            {
                Project = project;
                Policy = policy;
                InitParameters();
            }

            /// <summary>Identifies the project addressed by this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>User given friendly name of the policy addressed by this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("policy", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Policy { get; private set; }

            /// <summary>
            /// For mutating operation requests only. An optional identifier specified by the client. Must be unique for
            /// operation resources in the Operations collection.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("clientOperationId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ClientOperationId { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "dns/v1beta2/projects/{project}/policies/{policy}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("policy", new Google.Apis.Discovery.Parameter
                {
                    Name = "policy",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("clientOperationId", new Google.Apis.Discovery.Parameter
                {
                    Name = "clientOperationId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Fetches the representation of an existing Policy.</summary>
        /// <param name="project">Identifies the project addressed by this request.</param>
        /// <param name="policy">User given friendly name of the policy addressed by this request.</param>
        public virtual GetRequest Get(string project, string policy)
        {
            return new GetRequest(service, project, policy);
        }

        /// <summary>Fetches the representation of an existing Policy.</summary>
        public class GetRequest : DnsBaseServiceRequest<Google.Apis.Dns.v1beta2.Data.Policy>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string project, string policy) : base(service)
            {
                Project = project;
                Policy = policy;
                InitParameters();
            }

            /// <summary>Identifies the project addressed by this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>User given friendly name of the policy addressed by this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("policy", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Policy { get; private set; }

            /// <summary>
            /// For mutating operation requests only. An optional identifier specified by the client. Must be unique for
            /// operation resources in the Operations collection.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("clientOperationId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ClientOperationId { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "dns/v1beta2/projects/{project}/policies/{policy}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("policy", new Google.Apis.Discovery.Parameter
                {
                    Name = "policy",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("clientOperationId", new Google.Apis.Discovery.Parameter
                {
                    Name = "clientOperationId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Enumerates all Policies associated with a project.</summary>
        /// <param name="project">Identifies the project addressed by this request.</param>
        public virtual ListRequest List(string project)
        {
            return new ListRequest(service, project);
        }

        /// <summary>Enumerates all Policies associated with a project.</summary>
        public class ListRequest : DnsBaseServiceRequest<Google.Apis.Dns.v1beta2.Data.PoliciesListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string project) : base(service)
            {
                Project = project;
                InitParameters();
            }

            /// <summary>Identifies the project addressed by this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>
            /// Optional. Maximum number of results to be returned. If unspecified, the server decides how many results
            /// to return.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>
            /// Optional. A tag returned by a previous list request that was truncated. Use this parameter to continue a
            /// previous list request.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "dns/v1beta2/projects/{project}/policies";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
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

        /// <summary>Applies a partial update to an existing Policy.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="project">Identifies the project addressed by this request.</param>
        /// <param name="policy">User given friendly name of the policy addressed by this request.</param>
        public virtual PatchRequest Patch(Google.Apis.Dns.v1beta2.Data.Policy body, string project, string policy)
        {
            return new PatchRequest(service, body, project, policy);
        }

        /// <summary>Applies a partial update to an existing Policy.</summary>
        public class PatchRequest : DnsBaseServiceRequest<Google.Apis.Dns.v1beta2.Data.PoliciesPatchResponse>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Dns.v1beta2.Data.Policy body, string project, string policy) : base(service)
            {
                Project = project;
                Policy = policy;
                Body = body;
                InitParameters();
            }

            /// <summary>Identifies the project addressed by this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>User given friendly name of the policy addressed by this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("policy", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Policy { get; private set; }

            /// <summary>
            /// For mutating operation requests only. An optional identifier specified by the client. Must be unique for
            /// operation resources in the Operations collection.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("clientOperationId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ClientOperationId { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Dns.v1beta2.Data.Policy Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "dns/v1beta2/projects/{project}/policies/{policy}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("policy", new Google.Apis.Discovery.Parameter
                {
                    Name = "policy",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("clientOperationId", new Google.Apis.Discovery.Parameter
                {
                    Name = "clientOperationId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates an existing Policy.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="project">Identifies the project addressed by this request.</param>
        /// <param name="policy">User given friendly name of the policy addressed by this request.</param>
        public virtual UpdateRequest Update(Google.Apis.Dns.v1beta2.Data.Policy body, string project, string policy)
        {
            return new UpdateRequest(service, body, project, policy);
        }

        /// <summary>Updates an existing Policy.</summary>
        public class UpdateRequest : DnsBaseServiceRequest<Google.Apis.Dns.v1beta2.Data.PoliciesUpdateResponse>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Dns.v1beta2.Data.Policy body, string project, string policy) : base(service)
            {
                Project = project;
                Policy = policy;
                Body = body;
                InitParameters();
            }

            /// <summary>Identifies the project addressed by this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>User given friendly name of the policy addressed by this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("policy", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Policy { get; private set; }

            /// <summary>
            /// For mutating operation requests only. An optional identifier specified by the client. Must be unique for
            /// operation resources in the Operations collection.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("clientOperationId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ClientOperationId { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Dns.v1beta2.Data.Policy Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "dns/v1beta2/projects/{project}/policies/{policy}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("policy", new Google.Apis.Discovery.Parameter
                {
                    Name = "policy",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("clientOperationId", new Google.Apis.Discovery.Parameter
                {
                    Name = "clientOperationId",
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
            ManagedZones = new ManagedZonesResource(service);
        }

        /// <summary>Gets the ManagedZones resource.</summary>
        public virtual ManagedZonesResource ManagedZones { get; }

        /// <summary>The "managedZones" collection of methods.</summary>
        public class ManagedZonesResource
        {
            private const string Resource = "managedZones";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ManagedZonesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Rrsets = new RrsetsResource(service);
            }

            /// <summary>Gets the Rrsets resource.</summary>
            public virtual RrsetsResource Rrsets { get; }

            /// <summary>The "rrsets" collection of methods.</summary>
            public class RrsetsResource
            {
                private const string Resource = "rrsets";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public RrsetsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a new ResourceRecordSet.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="project">Identifies the project addressed by this request.</param>
                /// <param name="managedZone">
                /// Identifies the managed zone addressed by this request. Can be the managed zone name or ID.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.Dns.v1beta2.Data.ResourceRecordSet body, string project, string managedZone)
                {
                    return new CreateRequest(service, body, project, managedZone);
                }

                /// <summary>Creates a new ResourceRecordSet.</summary>
                public class CreateRequest : DnsBaseServiceRequest<Google.Apis.Dns.v1beta2.Data.ResourceRecordSet>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Dns.v1beta2.Data.ResourceRecordSet body, string project, string managedZone) : base(service)
                    {
                        Project = project;
                        ManagedZone = managedZone;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Identifies the project addressed by this request.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Project { get; private set; }

                    /// <summary>
                    /// Identifies the managed zone addressed by this request. Can be the managed zone name or ID.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("managedZone", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ManagedZone { get; private set; }

                    /// <summary>
                    /// For mutating operation requests only. An optional identifier specified by the client. Must be
                    /// unique for operation resources in the Operations collection.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("clientOperationId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ClientOperationId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Dns.v1beta2.Data.ResourceRecordSet Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "dns/v1beta2/projects/{project}/managedZones/{managedZone}/rrsets";

                    /// <summary>Initializes Create parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                        {
                            Name = "project",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("managedZone", new Google.Apis.Discovery.Parameter
                        {
                            Name = "managedZone",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("clientOperationId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "clientOperationId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a previously created ResourceRecordSet.</summary>
                /// <param name="project">Identifies the project addressed by this request.</param>
                /// <param name="managedZone">
                /// Identifies the managed zone addressed by this request. Can be the managed zone name or ID.
                /// </param>
                /// <param name="name">Fully qualified domain name.</param>
                /// <param name="type">RRSet type.</param>
                public virtual DeleteRequest Delete(string project, string managedZone, string name, string type)
                {
                    return new DeleteRequest(service, project, managedZone, name, type);
                }

                /// <summary>Deletes a previously created ResourceRecordSet.</summary>
                public class DeleteRequest : DnsBaseServiceRequest<string>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string project, string managedZone, string name, string type) : base(service)
                    {
                        Project = project;
                        ManagedZone = managedZone;
                        Name = name;
                        Type = type;
                        InitParameters();
                    }

                    /// <summary>Identifies the project addressed by this request.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Project { get; private set; }

                    /// <summary>
                    /// Identifies the managed zone addressed by this request. Can be the managed zone name or ID.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("managedZone", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ManagedZone { get; private set; }

                    /// <summary>Fully qualified domain name.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>RRSet type.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("type", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Type { get; private set; }

                    /// <summary>
                    /// For mutating operation requests only. An optional identifier specified by the client. Must be
                    /// unique for operation resources in the Operations collection.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("clientOperationId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ClientOperationId { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "dns/v1beta2/projects/{project}/managedZones/{managedZone}/rrsets/{name}/{type}";

                    /// <summary>Initializes Delete parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                        {
                            Name = "project",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("managedZone", new Google.Apis.Discovery.Parameter
                        {
                            Name = "managedZone",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("type", new Google.Apis.Discovery.Parameter
                        {
                            Name = "type",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("clientOperationId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "clientOperationId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Fetches the representation of an existing ResourceRecordSet.</summary>
                /// <param name="project">Identifies the project addressed by this request.</param>
                /// <param name="managedZone">
                /// Identifies the managed zone addressed by this request. Can be the managed zone name or ID.
                /// </param>
                /// <param name="name">Fully qualified domain name.</param>
                /// <param name="type">RRSet type.</param>
                public virtual GetRequest Get(string project, string managedZone, string name, string type)
                {
                    return new GetRequest(service, project, managedZone, name, type);
                }

                /// <summary>Fetches the representation of an existing ResourceRecordSet.</summary>
                public class GetRequest : DnsBaseServiceRequest<Google.Apis.Dns.v1beta2.Data.ResourceRecordSet>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string project, string managedZone, string name, string type) : base(service)
                    {
                        Project = project;
                        ManagedZone = managedZone;
                        Name = name;
                        Type = type;
                        InitParameters();
                    }

                    /// <summary>Identifies the project addressed by this request.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Project { get; private set; }

                    /// <summary>
                    /// Identifies the managed zone addressed by this request. Can be the managed zone name or ID.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("managedZone", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ManagedZone { get; private set; }

                    /// <summary>Fully qualified domain name.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>RRSet type.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("type", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Type { get; private set; }

                    /// <summary>
                    /// For mutating operation requests only. An optional identifier specified by the client. Must be
                    /// unique for operation resources in the Operations collection.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("clientOperationId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ClientOperationId { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "dns/v1beta2/projects/{project}/managedZones/{managedZone}/rrsets/{name}/{type}";

                    /// <summary>Initializes Get parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                        {
                            Name = "project",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("managedZone", new Google.Apis.Discovery.Parameter
                        {
                            Name = "managedZone",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("type", new Google.Apis.Discovery.Parameter
                        {
                            Name = "type",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("clientOperationId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "clientOperationId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Applies a partial update to an existing ResourceRecordSet.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="project">Identifies the project addressed by this request.</param>
                /// <param name="managedZone">
                /// Identifies the managed zone addressed by this request. Can be the managed zone name or ID.
                /// </param>
                /// <param name="name">Fully qualified domain name.</param>
                /// <param name="type">RRSet type.</param>
                public virtual PatchRequest Patch(Google.Apis.Dns.v1beta2.Data.ResourceRecordSet body, string project, string managedZone, string name, string type)
                {
                    return new PatchRequest(service, body, project, managedZone, name, type);
                }

                /// <summary>Applies a partial update to an existing ResourceRecordSet.</summary>
                public class PatchRequest : DnsBaseServiceRequest<Google.Apis.Dns.v1beta2.Data.ResourceRecordSet>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Dns.v1beta2.Data.ResourceRecordSet body, string project, string managedZone, string name, string type) : base(service)
                    {
                        Project = project;
                        ManagedZone = managedZone;
                        Name = name;
                        Type = type;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Identifies the project addressed by this request.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Project { get; private set; }

                    /// <summary>
                    /// Identifies the managed zone addressed by this request. Can be the managed zone name or ID.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("managedZone", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ManagedZone { get; private set; }

                    /// <summary>Fully qualified domain name.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>RRSet type.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("type", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Type { get; private set; }

                    /// <summary>
                    /// For mutating operation requests only. An optional identifier specified by the client. Must be
                    /// unique for operation resources in the Operations collection.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("clientOperationId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ClientOperationId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Dns.v1beta2.Data.ResourceRecordSet Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "dns/v1beta2/projects/{project}/managedZones/{managedZone}/rrsets/{name}/{type}";

                    /// <summary>Initializes Patch parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                        {
                            Name = "project",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("managedZone", new Google.Apis.Discovery.Parameter
                        {
                            Name = "managedZone",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("type", new Google.Apis.Discovery.Parameter
                        {
                            Name = "type",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("clientOperationId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "clientOperationId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
            }
        }

        /// <summary>Fetches the representation of an existing Project.</summary>
        /// <param name="project">Identifies the project addressed by this request.</param>
        public virtual GetRequest Get(string project)
        {
            return new GetRequest(service, project);
        }

        /// <summary>Fetches the representation of an existing Project.</summary>
        public class GetRequest : DnsBaseServiceRequest<Google.Apis.Dns.v1beta2.Data.Project>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string project) : base(service)
            {
                Project = project;
                InitParameters();
            }

            /// <summary>Identifies the project addressed by this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>
            /// For mutating operation requests only. An optional identifier specified by the client. Must be unique for
            /// operation resources in the Operations collection.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("clientOperationId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ClientOperationId { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "dns/v1beta2/projects/{project}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("clientOperationId", new Google.Apis.Discovery.Parameter
                {
                    Name = "clientOperationId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "resourceRecordSets" collection of methods.</summary>
    public class ResourceRecordSetsResource
    {
        private const string Resource = "resourceRecordSets";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ResourceRecordSetsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Enumerates ResourceRecordSets that you have created but not yet deleted.</summary>
        /// <param name="project">Identifies the project addressed by this request.</param>
        /// <param name="managedZone">
        /// Identifies the managed zone addressed by this request. Can be the managed zone name or ID.
        /// </param>
        public virtual ListRequest List(string project, string managedZone)
        {
            return new ListRequest(service, project, managedZone);
        }

        /// <summary>Enumerates ResourceRecordSets that you have created but not yet deleted.</summary>
        public class ListRequest : DnsBaseServiceRequest<Google.Apis.Dns.v1beta2.Data.ResourceRecordSetsListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string project, string managedZone) : base(service)
            {
                Project = project;
                ManagedZone = managedZone;
                InitParameters();
            }

            /// <summary>Identifies the project addressed by this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>
            /// Identifies the managed zone addressed by this request. Can be the managed zone name or ID.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("managedZone", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ManagedZone { get; private set; }

            /// <summary>
            /// Optional. Maximum number of results to be returned. If unspecified, the server decides how many results
            /// to return.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>Restricts the list to return only records with this fully qualified domain name.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Name { get; set; }

            /// <summary>
            /// Optional. A tag returned by a previous list request that was truncated. Use this parameter to continue a
            /// previous list request.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// Restricts the list to return only records of this type. If present, the "name" parameter must also be
            /// present.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("type", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Type { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "dns/v1beta2/projects/{project}/managedZones/{managedZone}/rrsets";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("managedZone", new Google.Apis.Discovery.Parameter
                {
                    Name = "managedZone",
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
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
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

    /// <summary>The "responsePolicies" collection of methods.</summary>
    public class ResponsePoliciesResource
    {
        private const string Resource = "responsePolicies";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ResponsePoliciesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Creates a new Response Policy</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="project">Identifies the project addressed by this request.</param>
        public virtual CreateRequest Create(Google.Apis.Dns.v1beta2.Data.ResponsePolicy body, string project)
        {
            return new CreateRequest(service, body, project);
        }

        /// <summary>Creates a new Response Policy</summary>
        public class CreateRequest : DnsBaseServiceRequest<Google.Apis.Dns.v1beta2.Data.ResponsePolicy>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Dns.v1beta2.Data.ResponsePolicy body, string project) : base(service)
            {
                Project = project;
                Body = body;
                InitParameters();
            }

            /// <summary>Identifies the project addressed by this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>
            /// For mutating operation requests only. An optional identifier specified by the client. Must be unique for
            /// operation resources in the Operations collection.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("clientOperationId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ClientOperationId { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Dns.v1beta2.Data.ResponsePolicy Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "dns/v1beta2/projects/{project}/responsePolicies";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("clientOperationId", new Google.Apis.Discovery.Parameter
                {
                    Name = "clientOperationId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Deletes a previously created Response Policy. Fails if the response policy is non-empty or still being
        /// referenced by a network.
        /// </summary>
        /// <param name="project">Identifies the project addressed by this request.</param>
        /// <param name="responsePolicy">User assigned name of the Response Policy addressed by this request.</param>
        public virtual DeleteRequest Delete(string project, string responsePolicy)
        {
            return new DeleteRequest(service, project, responsePolicy);
        }

        /// <summary>
        /// Deletes a previously created Response Policy. Fails if the response policy is non-empty or still being
        /// referenced by a network.
        /// </summary>
        public class DeleteRequest : DnsBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string project, string responsePolicy) : base(service)
            {
                Project = project;
                ResponsePolicy = responsePolicy;
                InitParameters();
            }

            /// <summary>Identifies the project addressed by this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>User assigned name of the Response Policy addressed by this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("responsePolicy", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResponsePolicy { get; private set; }

            /// <summary>
            /// For mutating operation requests only. An optional identifier specified by the client. Must be unique for
            /// operation resources in the Operations collection.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("clientOperationId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ClientOperationId { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "dns/v1beta2/projects/{project}/responsePolicies/{responsePolicy}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("responsePolicy", new Google.Apis.Discovery.Parameter
                {
                    Name = "responsePolicy",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("clientOperationId", new Google.Apis.Discovery.Parameter
                {
                    Name = "clientOperationId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Fetches the representation of an existing Response Policy.</summary>
        /// <param name="project">Identifies the project addressed by this request.</param>
        /// <param name="responsePolicy">User assigned name of the Response Policy addressed by this request.</param>
        public virtual GetRequest Get(string project, string responsePolicy)
        {
            return new GetRequest(service, project, responsePolicy);
        }

        /// <summary>Fetches the representation of an existing Response Policy.</summary>
        public class GetRequest : DnsBaseServiceRequest<Google.Apis.Dns.v1beta2.Data.ResponsePolicy>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string project, string responsePolicy) : base(service)
            {
                Project = project;
                ResponsePolicy = responsePolicy;
                InitParameters();
            }

            /// <summary>Identifies the project addressed by this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>User assigned name of the Response Policy addressed by this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("responsePolicy", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResponsePolicy { get; private set; }

            /// <summary>
            /// For mutating operation requests only. An optional identifier specified by the client. Must be unique for
            /// operation resources in the Operations collection.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("clientOperationId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ClientOperationId { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "dns/v1beta2/projects/{project}/responsePolicies/{responsePolicy}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("responsePolicy", new Google.Apis.Discovery.Parameter
                {
                    Name = "responsePolicy",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("clientOperationId", new Google.Apis.Discovery.Parameter
                {
                    Name = "clientOperationId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Enumerates all Response Policies associated with a project.</summary>
        /// <param name="project">Identifies the project addressed by this request.</param>
        public virtual ListRequest List(string project)
        {
            return new ListRequest(service, project);
        }

        /// <summary>Enumerates all Response Policies associated with a project.</summary>
        public class ListRequest : DnsBaseServiceRequest<Google.Apis.Dns.v1beta2.Data.ResponsePoliciesListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string project) : base(service)
            {
                Project = project;
                InitParameters();
            }

            /// <summary>Identifies the project addressed by this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>
            /// Optional. Maximum number of results to be returned. If unspecified, the server decides how many results
            /// to return.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>
            /// Optional. A tag returned by a previous list request that was truncated. Use this parameter to continue a
            /// previous list request.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "dns/v1beta2/projects/{project}/responsePolicies";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
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

        /// <summary>Applies a partial update to an existing Response Policy.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="project">Identifies the project addressed by this request.</param>
        /// <param name="responsePolicy">User assigned name of the Respones Policy addressed by this request.</param>
        public virtual PatchRequest Patch(Google.Apis.Dns.v1beta2.Data.ResponsePolicy body, string project, string responsePolicy)
        {
            return new PatchRequest(service, body, project, responsePolicy);
        }

        /// <summary>Applies a partial update to an existing Response Policy.</summary>
        public class PatchRequest : DnsBaseServiceRequest<Google.Apis.Dns.v1beta2.Data.ResponsePoliciesPatchResponse>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Dns.v1beta2.Data.ResponsePolicy body, string project, string responsePolicy) : base(service)
            {
                Project = project;
                ResponsePolicy = responsePolicy;
                Body = body;
                InitParameters();
            }

            /// <summary>Identifies the project addressed by this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>User assigned name of the Respones Policy addressed by this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("responsePolicy", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResponsePolicy { get; private set; }

            /// <summary>
            /// For mutating operation requests only. An optional identifier specified by the client. Must be unique for
            /// operation resources in the Operations collection.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("clientOperationId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ClientOperationId { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Dns.v1beta2.Data.ResponsePolicy Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "dns/v1beta2/projects/{project}/responsePolicies/{responsePolicy}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("responsePolicy", new Google.Apis.Discovery.Parameter
                {
                    Name = "responsePolicy",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("clientOperationId", new Google.Apis.Discovery.Parameter
                {
                    Name = "clientOperationId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates an existing Response Policy.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="project">Identifies the project addressed by this request.</param>
        /// <param name="responsePolicy">User assigned name of the Response Policy addressed by this request.</param>
        public virtual UpdateRequest Update(Google.Apis.Dns.v1beta2.Data.ResponsePolicy body, string project, string responsePolicy)
        {
            return new UpdateRequest(service, body, project, responsePolicy);
        }

        /// <summary>Updates an existing Response Policy.</summary>
        public class UpdateRequest : DnsBaseServiceRequest<Google.Apis.Dns.v1beta2.Data.ResponsePoliciesUpdateResponse>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Dns.v1beta2.Data.ResponsePolicy body, string project, string responsePolicy) : base(service)
            {
                Project = project;
                ResponsePolicy = responsePolicy;
                Body = body;
                InitParameters();
            }

            /// <summary>Identifies the project addressed by this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>User assigned name of the Response Policy addressed by this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("responsePolicy", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResponsePolicy { get; private set; }

            /// <summary>
            /// For mutating operation requests only. An optional identifier specified by the client. Must be unique for
            /// operation resources in the Operations collection.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("clientOperationId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ClientOperationId { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Dns.v1beta2.Data.ResponsePolicy Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "dns/v1beta2/projects/{project}/responsePolicies/{responsePolicy}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("responsePolicy", new Google.Apis.Discovery.Parameter
                {
                    Name = "responsePolicy",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("clientOperationId", new Google.Apis.Discovery.Parameter
                {
                    Name = "clientOperationId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "responsePolicyRules" collection of methods.</summary>
    public class ResponsePolicyRulesResource
    {
        private const string Resource = "responsePolicyRules";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ResponsePolicyRulesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Creates a new Response Policy Rule.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="project">Identifies the project addressed by this request.</param>
        /// <param name="responsePolicy">
        /// User assigned name of the Response Policy containing the Response Policy Rule.
        /// </param>
        public virtual CreateRequest Create(Google.Apis.Dns.v1beta2.Data.ResponsePolicyRule body, string project, string responsePolicy)
        {
            return new CreateRequest(service, body, project, responsePolicy);
        }

        /// <summary>Creates a new Response Policy Rule.</summary>
        public class CreateRequest : DnsBaseServiceRequest<Google.Apis.Dns.v1beta2.Data.ResponsePolicyRule>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Dns.v1beta2.Data.ResponsePolicyRule body, string project, string responsePolicy) : base(service)
            {
                Project = project;
                ResponsePolicy = responsePolicy;
                Body = body;
                InitParameters();
            }

            /// <summary>Identifies the project addressed by this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>User assigned name of the Response Policy containing the Response Policy Rule.</summary>
            [Google.Apis.Util.RequestParameterAttribute("responsePolicy", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResponsePolicy { get; private set; }

            /// <summary>
            /// For mutating operation requests only. An optional identifier specified by the client. Must be unique for
            /// operation resources in the Operations collection.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("clientOperationId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ClientOperationId { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Dns.v1beta2.Data.ResponsePolicyRule Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "dns/v1beta2/projects/{project}/responsePolicies/{responsePolicy}/rules";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("responsePolicy", new Google.Apis.Discovery.Parameter
                {
                    Name = "responsePolicy",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("clientOperationId", new Google.Apis.Discovery.Parameter
                {
                    Name = "clientOperationId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Deletes a previously created Response Policy Rule.</summary>
        /// <param name="project">Identifies the project addressed by this request.</param>
        /// <param name="responsePolicy">
        /// User assigned name of the Response Policy containing the Response Policy Rule.
        /// </param>
        /// <param name="responsePolicyRule">
        /// User assigned name of the Response Policy Rule addressed by this request.
        /// </param>
        public virtual DeleteRequest Delete(string project, string responsePolicy, string responsePolicyRule)
        {
            return new DeleteRequest(service, project, responsePolicy, responsePolicyRule);
        }

        /// <summary>Deletes a previously created Response Policy Rule.</summary>
        public class DeleteRequest : DnsBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string project, string responsePolicy, string responsePolicyRule) : base(service)
            {
                Project = project;
                ResponsePolicy = responsePolicy;
                ResponsePolicyRule = responsePolicyRule;
                InitParameters();
            }

            /// <summary>Identifies the project addressed by this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>User assigned name of the Response Policy containing the Response Policy Rule.</summary>
            [Google.Apis.Util.RequestParameterAttribute("responsePolicy", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResponsePolicy { get; private set; }

            /// <summary>User assigned name of the Response Policy Rule addressed by this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("responsePolicyRule", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResponsePolicyRule { get; private set; }

            /// <summary>
            /// For mutating operation requests only. An optional identifier specified by the client. Must be unique for
            /// operation resources in the Operations collection.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("clientOperationId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ClientOperationId { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "dns/v1beta2/projects/{project}/responsePolicies/{responsePolicy}/rules/{responsePolicyRule}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("responsePolicy", new Google.Apis.Discovery.Parameter
                {
                    Name = "responsePolicy",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("responsePolicyRule", new Google.Apis.Discovery.Parameter
                {
                    Name = "responsePolicyRule",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("clientOperationId", new Google.Apis.Discovery.Parameter
                {
                    Name = "clientOperationId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Fetches the representation of an existing Response Policy Rule.</summary>
        /// <param name="project">Identifies the project addressed by this request.</param>
        /// <param name="responsePolicy">
        /// User assigned name of the Response Policy containing the Response Policy Rule.
        /// </param>
        /// <param name="responsePolicyRule">
        /// User assigned name of the Response Policy Rule addressed by this request.
        /// </param>
        public virtual GetRequest Get(string project, string responsePolicy, string responsePolicyRule)
        {
            return new GetRequest(service, project, responsePolicy, responsePolicyRule);
        }

        /// <summary>Fetches the representation of an existing Response Policy Rule.</summary>
        public class GetRequest : DnsBaseServiceRequest<Google.Apis.Dns.v1beta2.Data.ResponsePolicyRule>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string project, string responsePolicy, string responsePolicyRule) : base(service)
            {
                Project = project;
                ResponsePolicy = responsePolicy;
                ResponsePolicyRule = responsePolicyRule;
                InitParameters();
            }

            /// <summary>Identifies the project addressed by this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>User assigned name of the Response Policy containing the Response Policy Rule.</summary>
            [Google.Apis.Util.RequestParameterAttribute("responsePolicy", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResponsePolicy { get; private set; }

            /// <summary>User assigned name of the Response Policy Rule addressed by this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("responsePolicyRule", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResponsePolicyRule { get; private set; }

            /// <summary>
            /// For mutating operation requests only. An optional identifier specified by the client. Must be unique for
            /// operation resources in the Operations collection.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("clientOperationId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ClientOperationId { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "dns/v1beta2/projects/{project}/responsePolicies/{responsePolicy}/rules/{responsePolicyRule}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("responsePolicy", new Google.Apis.Discovery.Parameter
                {
                    Name = "responsePolicy",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("responsePolicyRule", new Google.Apis.Discovery.Parameter
                {
                    Name = "responsePolicyRule",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("clientOperationId", new Google.Apis.Discovery.Parameter
                {
                    Name = "clientOperationId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Enumerates all Response Policy Rules associated with a project.</summary>
        /// <param name="project">Identifies the project addressed by this request.</param>
        /// <param name="responsePolicy">User assigned name of the Response Policy to list.</param>
        public virtual ListRequest List(string project, string responsePolicy)
        {
            return new ListRequest(service, project, responsePolicy);
        }

        /// <summary>Enumerates all Response Policy Rules associated with a project.</summary>
        public class ListRequest : DnsBaseServiceRequest<Google.Apis.Dns.v1beta2.Data.ResponsePolicyRulesListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string project, string responsePolicy) : base(service)
            {
                Project = project;
                ResponsePolicy = responsePolicy;
                InitParameters();
            }

            /// <summary>Identifies the project addressed by this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>User assigned name of the Response Policy to list.</summary>
            [Google.Apis.Util.RequestParameterAttribute("responsePolicy", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResponsePolicy { get; private set; }

            /// <summary>
            /// Optional. Maximum number of results to be returned. If unspecified, the server decides how many results
            /// to return.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>
            /// Optional. A tag returned by a previous list request that was truncated. Use this parameter to continue a
            /// previous list request.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "dns/v1beta2/projects/{project}/responsePolicies/{responsePolicy}/rules";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("responsePolicy", new Google.Apis.Discovery.Parameter
                {
                    Name = "responsePolicy",
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

        /// <summary>Applies a partial update to an existing Response Policy Rule.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="project">Identifies the project addressed by this request.</param>
        /// <param name="responsePolicy">
        /// User assigned name of the Response Policy containing the Response Policy Rule.
        /// </param>
        /// <param name="responsePolicyRule">
        /// User assigned name of the Response Policy Rule addressed by this request.
        /// </param>
        public virtual PatchRequest Patch(Google.Apis.Dns.v1beta2.Data.ResponsePolicyRule body, string project, string responsePolicy, string responsePolicyRule)
        {
            return new PatchRequest(service, body, project, responsePolicy, responsePolicyRule);
        }

        /// <summary>Applies a partial update to an existing Response Policy Rule.</summary>
        public class PatchRequest : DnsBaseServiceRequest<Google.Apis.Dns.v1beta2.Data.ResponsePolicyRulesPatchResponse>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Dns.v1beta2.Data.ResponsePolicyRule body, string project, string responsePolicy, string responsePolicyRule) : base(service)
            {
                Project = project;
                ResponsePolicy = responsePolicy;
                ResponsePolicyRule = responsePolicyRule;
                Body = body;
                InitParameters();
            }

            /// <summary>Identifies the project addressed by this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>User assigned name of the Response Policy containing the Response Policy Rule.</summary>
            [Google.Apis.Util.RequestParameterAttribute("responsePolicy", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResponsePolicy { get; private set; }

            /// <summary>User assigned name of the Response Policy Rule addressed by this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("responsePolicyRule", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResponsePolicyRule { get; private set; }

            /// <summary>
            /// For mutating operation requests only. An optional identifier specified by the client. Must be unique for
            /// operation resources in the Operations collection.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("clientOperationId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ClientOperationId { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Dns.v1beta2.Data.ResponsePolicyRule Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "dns/v1beta2/projects/{project}/responsePolicies/{responsePolicy}/rules/{responsePolicyRule}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("responsePolicy", new Google.Apis.Discovery.Parameter
                {
                    Name = "responsePolicy",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("responsePolicyRule", new Google.Apis.Discovery.Parameter
                {
                    Name = "responsePolicyRule",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("clientOperationId", new Google.Apis.Discovery.Parameter
                {
                    Name = "clientOperationId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates an existing Response Policy Rule.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="project">Identifies the project addressed by this request.</param>
        /// <param name="responsePolicy">
        /// User assigned name of the Response Policy containing the Response Policy Rule.
        /// </param>
        /// <param name="responsePolicyRule">
        /// User assigned name of the Response Policy Rule addressed by this request.
        /// </param>
        public virtual UpdateRequest Update(Google.Apis.Dns.v1beta2.Data.ResponsePolicyRule body, string project, string responsePolicy, string responsePolicyRule)
        {
            return new UpdateRequest(service, body, project, responsePolicy, responsePolicyRule);
        }

        /// <summary>Updates an existing Response Policy Rule.</summary>
        public class UpdateRequest : DnsBaseServiceRequest<Google.Apis.Dns.v1beta2.Data.ResponsePolicyRulesUpdateResponse>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Dns.v1beta2.Data.ResponsePolicyRule body, string project, string responsePolicy, string responsePolicyRule) : base(service)
            {
                Project = project;
                ResponsePolicy = responsePolicy;
                ResponsePolicyRule = responsePolicyRule;
                Body = body;
                InitParameters();
            }

            /// <summary>Identifies the project addressed by this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>User assigned name of the Response Policy containing the Response Policy Rule.</summary>
            [Google.Apis.Util.RequestParameterAttribute("responsePolicy", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResponsePolicy { get; private set; }

            /// <summary>User assigned name of the Response Policy Rule addressed by this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("responsePolicyRule", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResponsePolicyRule { get; private set; }

            /// <summary>
            /// For mutating operation requests only. An optional identifier specified by the client. Must be unique for
            /// operation resources in the Operations collection.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("clientOperationId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ClientOperationId { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Dns.v1beta2.Data.ResponsePolicyRule Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "dns/v1beta2/projects/{project}/responsePolicies/{responsePolicy}/rules/{responsePolicyRule}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("responsePolicy", new Google.Apis.Discovery.Parameter
                {
                    Name = "responsePolicy",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("responsePolicyRule", new Google.Apis.Discovery.Parameter
                {
                    Name = "responsePolicyRule",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("clientOperationId", new Google.Apis.Discovery.Parameter
                {
                    Name = "clientOperationId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }
}
namespace Google.Apis.Dns.v1beta2.Data
{
    /// <summary>
    /// A Change represents a set of ResourceRecordSet additions and deletions applied atomically to a ManagedZone.
    /// ResourceRecordSets within a ManagedZone are modified by creating a new Change element in the Changes collection.
    /// In turn the Changes collection also records the past modifications to the ResourceRecordSets in a ManagedZone.
    /// The current state of the ManagedZone is the sum effect of applying all Change elements in the Changes collection
    /// in sequence.
    /// </summary>
    public class Change : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Which ResourceRecordSets to add?</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additions")]
        public virtual System.Collections.Generic.IList<ResourceRecordSet> Additions { get; set; }

        /// <summary>Which ResourceRecordSets to remove? Must match existing data exactly.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deletions")]
        public virtual System.Collections.Generic.IList<ResourceRecordSet> Deletions { get; set; }

        /// <summary>Unique identifier for the resource; defined by the server (output only).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>If the DNS queries for the zone will be served.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isServing")]
        public virtual System.Nullable<bool> IsServing { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The time that this operation was started by the server (output only). This is in RFC3339 text format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual string StartTime { get; set; }

        /// <summary>
        /// Status of the operation (output only). A status of "done" means that the request to update the authoritative
        /// servers has been sent, but the servers might not be updated yet.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response to a request to enumerate Changes to a ResourceRecordSets collection.</summary>
    public class ChangesListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The requested changes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("changes")]
        public virtual System.Collections.Generic.IList<Change> Changes { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("header")]
        public virtual ResponseHeader Header { get; set; }

        /// <summary>Type of resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The presence of this field indicates that there exist more results following your last page of results in
        /// pagination order. To fetch them, make another list request using this value as your pagination token. This
        /// lets you retrieve the complete contents of even very large collections one page at a time. However, if the
        /// contents of the collection change between the first and last paginated list request, the set of all elements
        /// returned are an inconsistent view of the collection. You cannot retrieve a "snapshot" of collections larger
        /// than the maximum page size.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A DNSSEC key pair.</summary>
    public class DnsKey : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// String mnemonic specifying the DNSSEC algorithm of this key. Immutable after creation time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("algorithm")]
        public virtual string Algorithm { get; set; }

        /// <summary>
        /// The time that this resource was created in the control plane. This is in RFC3339 text format. Output only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationTime")]
        public virtual string CreationTime { get; set; }

        /// <summary>
        /// A mutable string of at most 1024 characters associated with this resource for the user's convenience. Has no
        /// effect on the resource's function.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Cryptographic hashes of the DNSKEY resource record associated with this DnsKey. These digests are needed to
        /// construct a DS record that points at this DNS key. Output only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("digests")]
        public virtual System.Collections.Generic.IList<DnsKeyDigest> Digests { get; set; }

        /// <summary>Unique identifier for the resource; defined by the server (output only).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Active keys are used to sign subsequent changes to the ManagedZone. Inactive keys are still present as
        /// DNSKEY Resource Records for the use of resolvers validating existing signatures.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isActive")]
        public virtual System.Nullable<bool> IsActive { get; set; }

        /// <summary>Length of the key in bits. Specified at creation time, and then immutable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyLength")]
        public virtual System.Nullable<long> KeyLength { get; set; }

        /// <summary>
        /// The key tag is a non-cryptographic hash of the a DNSKEY resource record associated with this DnsKey. The key
        /// tag can be used to identify a DNSKEY more quickly (but it is not a unique identifier). In particular, the
        /// key tag is used in a parent zone's DS record to point at the DNSKEY in this child ManagedZone. The key tag
        /// is a number in the range [0, 65535] and the algorithm to calculate it is specified in RFC4034 Appendix B.
        /// Output only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyTag")]
        public virtual System.Nullable<int> KeyTag { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Base64 encoded public half of this key. Output only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicKey")]
        public virtual string PublicKey { get; set; }

        /// <summary>
        /// One of "KEY_SIGNING" or "ZONE_SIGNING". Keys of type KEY_SIGNING have the Secure Entry Point flag set and,
        /// when active, are used to sign only resource record sets of type DNSKEY. Otherwise, the Secure Entry Point
        /// flag is cleared, and this key is used to sign only resource record sets of other types. Immutable after
        /// creation time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class DnsKeyDigest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The base-16 encoded bytes of this digest. Suitable for use in a DS resource record.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("digest")]
        public virtual string Digest { get; set; }

        /// <summary>Specifies the algorithm used to calculate this digest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Parameters for DnsKey key generation. Used for generating initial keys for a new ManagedZone and as default when
    /// adding a new DnsKey.
    /// </summary>
    public class DnsKeySpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>String mnemonic specifying the DNSSEC algorithm of this key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("algorithm")]
        public virtual string Algorithm { get; set; }

        /// <summary>Length of the keys in bits.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyLength")]
        public virtual System.Nullable<long> KeyLength { get; set; }

        /// <summary>
        /// Specifies whether this is a key signing key (KSK) or a zone signing key (ZSK). Key signing keys have the
        /// Secure Entry Point flag set and, when active, are only used to sign resource record sets of type DNSKEY.
        /// Zone signing keys do not have the Secure Entry Point flag set and are used to sign all other types of
        /// resource record sets.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyType")]
        public virtual string KeyType { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response to a request to enumerate DnsKeys in a ManagedZone.</summary>
    public class DnsKeysListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The requested resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dnsKeys")]
        public virtual System.Collections.Generic.IList<DnsKey> DnsKeys { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("header")]
        public virtual ResponseHeader Header { get; set; }

        /// <summary>Type of resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The presence of this field indicates that there exist more results following your last page of results in
        /// pagination order. To fetch them, make another list request using this value as your pagination token. In
        /// this way you can retrieve the complete contents of even very large collections one page at a time. However,
        /// if the contents of the collection change between the first and last paginated list request, the set of all
        /// elements returned are an inconsistent view of the collection. There is no way to retrieve a "snapshot" of
        /// collections larger than the maximum page size.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A zone is a subtree of the DNS namespace under one administrative responsibility. A ManagedZone is a resource
    /// that represents a DNS zone hosted by the Cloud DNS service.
    /// </summary>
    public class ManagedZone : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The time that this resource was created on the server. This is in RFC3339 text format. Output only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationTime")]
        public virtual string CreationTime { get; set; }

        /// <summary>
        /// A mutable string of at most 1024 characters associated with this resource for the user's convenience. Has no
        /// effect on the managed zone's function.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The DNS name of this managed zone, for instance "example.com.".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dnsName")]
        public virtual string DnsName { get; set; }

        /// <summary>DNSSEC configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dnssecConfig")]
        public virtual ManagedZoneDnsSecConfig DnssecConfig { get; set; }

        /// <summary>
        /// The presence for this field indicates that outbound forwarding is enabled for this zone. The value of this
        /// field contains the set of destinations to forward to.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("forwardingConfig")]
        public virtual ManagedZoneForwardingConfig ForwardingConfig { get; set; }

        /// <summary>Unique identifier for the resource; defined by the server (output only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<ulong> Id { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>User labels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// User assigned name for this resource. Must be unique within the project. The name must be 1-63 characters
        /// long, must begin with a letter, end with a letter or digit, and only contain lowercase letters, digits or
        /// dashes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optionally specifies the NameServerSet for this ManagedZone. A NameServerSet is a set of DNS name servers
        /// that all host the same ManagedZones. Most users leave this field unset. If you need to use this field,
        /// contact your account team.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nameServerSet")]
        public virtual string NameServerSet { get; set; }

        /// <summary>
        /// Delegate your managed_zone to these virtual name servers; defined by the server (output only)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nameServers")]
        public virtual System.Collections.Generic.IList<string> NameServers { get; set; }

        /// <summary>
        /// The presence of this field indicates that DNS Peering is enabled for this zone. The value of this field
        /// contains the network to peer with.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("peeringConfig")]
        public virtual ManagedZonePeeringConfig PeeringConfig { get; set; }

        /// <summary>
        /// For privately visible zones, the set of Virtual Private Cloud resources that the zone is visible from.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateVisibilityConfig")]
        public virtual ManagedZonePrivateVisibilityConfig PrivateVisibilityConfig { get; set; }

        /// <summary>
        /// The presence of this field indicates that this is a managed reverse lookup zone and Cloud DNS resolves
        /// reverse lookup queries using automatically configured records for VPC resources. This only applies to
        /// networks listed under private_visibility_config.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reverseLookupConfig")]
        public virtual ManagedZoneReverseLookupConfig ReverseLookupConfig { get; set; }

        /// <summary>
        /// This field links to the associated service directory namespace. Do not set this field for public zones or
        /// forwarding zones.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceDirectoryConfig")]
        public virtual ManagedZoneServiceDirectoryConfig ServiceDirectoryConfig { get; set; }

        /// <summary>
        /// The zone's visibility: public zones are exposed to the Internet, while private zones are visible only to
        /// Virtual Private Cloud resources.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visibility")]
        public virtual string Visibility { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ManagedZoneDnsSecConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Specifies parameters for generating initial DnsKeys for this ManagedZone. Can only be changed while the
        /// state is OFF.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultKeySpecs")]
        public virtual System.Collections.Generic.IList<DnsKeySpec> DefaultKeySpecs { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Specifies the mechanism for authenticated denial-of-existence responses. Can only be changed while the state
        /// is OFF.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nonExistence")]
        public virtual string NonExistence { get; set; }

        /// <summary>Specifies whether DNSSEC is enabled, and what mode it is in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ManagedZoneForwardingConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// List of target name servers to forward to. Cloud DNS selects the best available name server if more than one
        /// target is given.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetNameServers")]
        public virtual System.Collections.Generic.IList<ManagedZoneForwardingConfigNameServerTarget> TargetNameServers { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ManagedZoneForwardingConfigNameServerTarget : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Forwarding path for this NameServerTarget. If unset or set to DEFAULT, Cloud DNS makes forwarding decisions
        /// based on IP address ranges; that is, RFC1918 addresses go to the VPC network, non-RFC1918 addresses go to
        /// the internet. When set to PRIVATE, Cloud DNS always sends queries through the VPC network for this target.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("forwardingPath")]
        public virtual string ForwardingPath { get; set; }

        /// <summary>IPv4 address of a target name server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipv4Address")]
        public virtual string Ipv4Address { get; set; }

        /// <summary>
        /// IPv6 address of a target name server. Does not accept both fields (ipv4 &amp;amp; ipv6) being populated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipv6Address")]
        public virtual string Ipv6Address { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ManagedZoneOperationsListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("header")]
        public virtual ResponseHeader Header { get; set; }

        /// <summary>Type of resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The presence of this field indicates that there exist more results following your last page of results in
        /// pagination order. To fetch them, make another list request using this value as your page token. This lets
        /// you retrieve the complete contents of even very large collections one page at a time. However, if the
        /// contents of the collection change between the first and last paginated list request, the set of all elements
        /// returned are an inconsistent view of the collection. You cannot retrieve a consistent snapshot of a
        /// collection larger than the maximum page size.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The operation resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operations")]
        public virtual System.Collections.Generic.IList<Operation> Operations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ManagedZonePeeringConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The network with which to peer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetNetwork")]
        public virtual ManagedZonePeeringConfigTargetNetwork TargetNetwork { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ManagedZonePeeringConfigTargetNetwork : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The time at which the zone was deactivated, in RFC 3339 date-time format. An empty string indicates that the
        /// peering connection is active. The producer network can deactivate a zone. The zone is automatically
        /// deactivated if the producer network that the zone targeted is deleted. Output only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deactivateTime")]
        public virtual string DeactivateTime { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The fully qualified URL of the VPC network to forward queries to. This should be formatted like
        /// https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkUrl")]
        public virtual string NetworkUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ManagedZonePrivateVisibilityConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of Google Kubernetes Engine clusters that can see this zone.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gkeClusters")]
        public virtual System.Collections.Generic.IList<ManagedZonePrivateVisibilityConfigGKECluster> GkeClusters { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The list of VPC networks that can see this zone.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networks")]
        public virtual System.Collections.Generic.IList<ManagedZonePrivateVisibilityConfigNetwork> Networks { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ManagedZonePrivateVisibilityConfigGKECluster : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The resource name of the cluster to bind this ManagedZone to. This should be specified in the format like:
        /// projects/*/locations/*/clusters/*. This is referenced from GKE projects.locations.clusters.get API:
        /// https://cloud.google.com/kubernetes-engine/docs/reference/rest/v1/projects.locations.clusters/get
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gkeClusterName")]
        public virtual string GkeClusterName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ManagedZonePrivateVisibilityConfigNetwork : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The fully qualified URL of the VPC network to bind to. Format this URL like
        /// https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkUrl")]
        public virtual string NetworkUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ManagedZoneReverseLookupConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains information about Service Directory-backed zones.</summary>
    public class ManagedZoneServiceDirectoryConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Contains information about the namespace associated with the zone.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namespace")]
        public virtual ManagedZoneServiceDirectoryConfigNamespace Namespace__ { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ManagedZoneServiceDirectoryConfigNamespace : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The time that the namespace backing this zone was deleted; an empty string if it still exists. This is in
        /// RFC3339 text format. Output only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deletionTime")]
        public virtual string DeletionTime { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The fully qualified URL of the namespace associated with the zone. Format must be
        /// https://servicedirectory.googleapis.com/v1/projects/{project}/locations/{location}/namespaces/{namespace}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namespaceUrl")]
        public virtual string NamespaceUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ManagedZonesListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("header")]
        public virtual ResponseHeader Header { get; set; }

        /// <summary>Type of resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The managed zone resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managedZones")]
        public virtual System.Collections.Generic.IList<ManagedZone> ManagedZones { get; set; }

        /// <summary>
        /// The presence of this field indicates that there exist more results following your last page of results in
        /// pagination order. To fetch them, make another list request using this value as your page token. This lets
        /// you the complete contents of even very large collections one page at a time. However, if the contents of the
        /// collection change between the first and last paginated list request, the set of all elements returned are an
        /// inconsistent view of the collection. You cannot retrieve a consistent snapshot of a collection larger than
        /// the maximum page size.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An operation represents a successful mutation performed on a Cloud DNS resource. Operations provide: - An audit
    /// log of server resource mutations. - A way to recover/retry API calls in the case where the response is never
    /// received by the caller. Use the caller specified client_operation_id.
    /// </summary>
    public class Operation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Only populated if the operation targeted a DnsKey (output only).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dnsKeyContext")]
        public virtual OperationDnsKeyContext DnsKeyContext { get; set; }

        /// <summary>
        /// Unique identifier for the resource. This is the client_operation_id if the client specified it when the
        /// mutation was initiated, otherwise, it is generated by the server. The name must be 1-63 characters long and
        /// match the regular expression [-a-z0-9]? (output only)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The time that this operation was started by the server. This is in RFC3339 text format (output only).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual string StartTime { get; set; }

        /// <summary>
        /// Status of the operation. Can be one of the following: "PENDING" or "DONE" (output only). A status of "DONE"
        /// means that the request to update the authoritative servers has been sent, but the servers might not be
        /// updated yet.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>Type of the operation. Operations include insert, update, and delete (output only).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>
        /// User who requested the operation, for example: user@example.com. cloud-dns-system for operations
        /// automatically done by the system. (output only)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("user")]
        public virtual string User { get; set; }

        /// <summary>Only populated if the operation targeted a ManagedZone (output only).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zoneContext")]
        public virtual OperationManagedZoneContext ZoneContext { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class OperationDnsKeyContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The post-operation DnsKey resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newValue")]
        public virtual DnsKey NewValue { get; set; }

        /// <summary>The pre-operation DnsKey resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oldValue")]
        public virtual DnsKey OldValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class OperationManagedZoneContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The post-operation ManagedZone resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newValue")]
        public virtual ManagedZone NewValue { get; set; }

        /// <summary>The pre-operation ManagedZone resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oldValue")]
        public virtual ManagedZone OldValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class PoliciesListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("header")]
        public virtual ResponseHeader Header { get; set; }

        /// <summary>Type of resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The presence of this field indicates that there exist more results following your last page of results in
        /// pagination order. To fetch them, make another list request using this value as your page token. This lets
        /// you the complete contents of even very large collections one page at a time. However, if the contents of the
        /// collection change between the first and last paginated list request, the set of all elements returned are an
        /// inconsistent view of the collection. You cannot retrieve a consistent snapshot of a collection larger than
        /// the maximum page size.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The policy resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policies")]
        public virtual System.Collections.Generic.IList<Policy> Policies { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class PoliciesPatchResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("header")]
        public virtual ResponseHeader Header { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual Policy Policy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class PoliciesUpdateResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("header")]
        public virtual ResponseHeader Header { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual Policy Policy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A policy is a collection of DNS rules applied to one or more Virtual Private Cloud resources.</summary>
    public class Policy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Sets an alternative name server for the associated networks. When specified, all DNS queries are forwarded
        /// to a name server that you choose. Names such as .internal are not available when an alternative name server
        /// is specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alternativeNameServerConfig")]
        public virtual PolicyAlternativeNameServerConfig AlternativeNameServerConfig { get; set; }

        /// <summary>
        /// A mutable string of at most 1024 characters associated with this resource for the user's convenience. Has no
        /// effect on the policy's function.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Allows networks bound to this policy to receive DNS queries sent by VMs or applications over VPN
        /// connections. When enabled, a virtual IP address is allocated from each of the subnetworks that are bound to
        /// this policy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableInboundForwarding")]
        public virtual System.Nullable<bool> EnableInboundForwarding { get; set; }

        /// <summary>
        /// Controls whether logging is enabled for the networks bound to this policy. Defaults to no logging if not
        /// set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableLogging")]
        public virtual System.Nullable<bool> EnableLogging { get; set; }

        /// <summary>Unique identifier for the resource; defined by the server (output only).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<ulong> Id { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>User-assigned name for this policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>List of network names specifying networks to which this policy is applied.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networks")]
        public virtual System.Collections.Generic.IList<PolicyNetwork> Networks { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class PolicyAlternativeNameServerConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Sets an alternative name server for the associated networks. When specified, all DNS queries are forwarded
        /// to a name server that you choose. Names such as .internal are not available when an alternative name server
        /// is specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetNameServers")]
        public virtual System.Collections.Generic.IList<PolicyAlternativeNameServerConfigTargetNameServer> TargetNameServers { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class PolicyAlternativeNameServerConfigTargetNameServer : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Forwarding path for this TargetNameServer. If unset or set to DEFAULT, Cloud DNS makes forwarding decisions
        /// based on address ranges; that is, RFC1918 addresses go to the VPC network, non-RFC1918 addresses go to the
        /// internet. When set to PRIVATE, Cloud DNS always sends queries through the VPC network for this target.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("forwardingPath")]
        public virtual string ForwardingPath { get; set; }

        /// <summary>IPv4 address to forward to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipv4Address")]
        public virtual string Ipv4Address { get; set; }

        /// <summary>
        /// IPv6 address to forward to. Does not accept both fields (ipv4 &amp;amp; ipv6) being populated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipv6Address")]
        public virtual string Ipv6Address { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class PolicyNetwork : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The fully qualified URL of the VPC network to bind to. This should be formatted like
        /// https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkUrl")]
        public virtual string NetworkUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A project resource. The project is a top level container for resources including Cloud DNS ManagedZones.
    /// Projects can be created only in the APIs console. Next tag: 7.
    /// </summary>
    public class Project : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>User assigned unique identifier for the resource (output only).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Unique numeric identifier for the resource; defined by the server (output only).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("number")]
        public virtual System.Nullable<ulong> Number { get; set; }

        /// <summary>Quotas assigned to this project (output only).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quota")]
        public virtual Quota Quota { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Limits associated with a Project.</summary>
    public class Quota : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Maximum allowed number of DnsKeys per ManagedZone.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dnsKeysPerManagedZone")]
        public virtual System.Nullable<int> DnsKeysPerManagedZone { get; set; }

        /// <summary>Maximum allowed number of GKE clusters to which a privately scoped zone can be attached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gkeClustersPerManagedZone")]
        public virtual System.Nullable<int> GkeClustersPerManagedZone { get; set; }

        /// <summary>Maximum allowed number of GKE clusters per response policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gkeClustersPerResponsePolicy")]
        public virtual System.Nullable<int> GkeClustersPerResponsePolicy { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Maximum allowed number of managed zones in the project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managedZones")]
        public virtual System.Nullable<int> ManagedZones { get; set; }

        /// <summary>Maximum allowed number of managed zones which can be attached to a GKE cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managedZonesPerGkeCluster")]
        public virtual System.Nullable<int> ManagedZonesPerGkeCluster { get; set; }

        /// <summary>Maximum allowed number of managed zones which can be attached to a network.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managedZonesPerNetwork")]
        public virtual System.Nullable<int> ManagedZonesPerNetwork { get; set; }

        /// <summary>Maximum allowed number of networks to which a privately scoped zone can be attached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networksPerManagedZone")]
        public virtual System.Nullable<int> NetworksPerManagedZone { get; set; }

        /// <summary>Maximum allowed number of networks per policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networksPerPolicy")]
        public virtual System.Nullable<int> NetworksPerPolicy { get; set; }

        /// <summary>Maximum allowed number of policies per project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policies")]
        public virtual System.Nullable<int> Policies { get; set; }

        /// <summary>Maximum allowed number of ResourceRecords per ResourceRecordSet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceRecordsPerRrset")]
        public virtual System.Nullable<int> ResourceRecordsPerRrset { get; set; }

        /// <summary>Maximum allowed number of rules per response policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responsePolicyRulesPerResponsePolicy")]
        public virtual System.Nullable<int> ResponsePolicyRulesPerResponsePolicy { get; set; }

        /// <summary>Maximum allowed number of ResourceRecordSets to add per ChangesCreateRequest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rrsetAdditionsPerChange")]
        public virtual System.Nullable<int> RrsetAdditionsPerChange { get; set; }

        /// <summary>Maximum allowed number of ResourceRecordSets to delete per ChangesCreateRequest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rrsetDeletionsPerChange")]
        public virtual System.Nullable<int> RrsetDeletionsPerChange { get; set; }

        /// <summary>Maximum allowed number of ResourceRecordSets per zone in the project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rrsetsPerManagedZone")]
        public virtual System.Nullable<int> RrsetsPerManagedZone { get; set; }

        /// <summary>Maximum allowed number of target name servers per managed forwarding zone.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetNameServersPerManagedZone")]
        public virtual System.Nullable<int> TargetNameServersPerManagedZone { get; set; }

        /// <summary>Maximum allowed number of alternative target name servers per policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetNameServersPerPolicy")]
        public virtual System.Nullable<int> TargetNameServersPerPolicy { get; set; }

        /// <summary>Maximum allowed size for total rrdata in one ChangesCreateRequest in bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalRrdataSizePerChange")]
        public virtual System.Nullable<int> TotalRrdataSizePerChange { get; set; }

        /// <summary>DNSSEC algorithm and key length types that can be used for DnsKeys.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("whitelistedKeySpecs")]
        public virtual System.Collections.Generic.IList<DnsKeySpec> WhitelistedKeySpecs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A unit of data that is returned by the DNS servers.</summary>
    public class ResourceRecordSet : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>For example, www.example.com.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>As defined in RFC 1035 (section 5) and RFC 1034 (section 3.6.1) -- see examples.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rrdatas")]
        public virtual System.Collections.Generic.IList<string> Rrdatas { get; set; }

        /// <summary>As defined in RFC 4034 (section 3.2).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signatureRrdatas")]
        public virtual System.Collections.Generic.IList<string> SignatureRrdatas { get; set; }

        /// <summary>Number of seconds that this ResourceRecordSet can be cached by resolvers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ttl")]
        public virtual System.Nullable<int> Ttl { get; set; }

        /// <summary>The identifier of a supported record type. See the list of Supported DNS record types.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ResourceRecordSetsListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("header")]
        public virtual ResponseHeader Header { get; set; }

        /// <summary>Type of resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The presence of this field indicates that there exist more results following your last page of results in
        /// pagination order. To fetch them, make another list request using this value as your pagination token. This
        /// lets you retrieve complete contents of even larger collections, one page at a time. However, if the contents
        /// of the collection change between the first and last paginated list request, the set of elements returned are
        /// an inconsistent view of the collection. You cannot retrieve a consistent snapshot of a collection larger
        /// than the maximum page size.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The resource record set resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rrsets")]
        public virtual System.Collections.Generic.IList<ResourceRecordSet> Rrsets { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Elements common to every response.</summary>
    public class ResponseHeader : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// For mutating operation requests that completed successfully. This is the client_operation_id if the client
        /// specified it, otherwise it is generated by the server (output only).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationId")]
        public virtual string OperationId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ResponsePoliciesListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("header")]
        public virtual ResponseHeader Header { get; set; }

        /// <summary>
        /// The presence of this field indicates that there exist more results following your last page of results in
        /// pagination order. To fetch them, make another list request using this value as your page token. This lets
        /// you the complete contents of even very large collections one page at a time. However, if the contents of the
        /// collection change between the first and last paginated list request, the set of all elements returned are an
        /// inconsistent view of the collection. You cannot retrieve a consistent snapshot of a collection larger than
        /// the maximum page size.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The Response Policy resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responsePolicies")]
        public virtual System.Collections.Generic.IList<ResponsePolicy> ResponsePolicies { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ResponsePoliciesPatchResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("header")]
        public virtual ResponseHeader Header { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("responsePolicy")]
        public virtual ResponsePolicy ResponsePolicy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ResponsePoliciesUpdateResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("header")]
        public virtual ResponseHeader Header { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("responsePolicy")]
        public virtual ResponsePolicy ResponsePolicy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A Response Policy is a collection of selectors that apply to queries made against one or more Virtual Private
    /// Cloud networks.
    /// </summary>
    public class ResponsePolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>User-provided description for this Response Policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The list of Google Kubernetes Engine clusters to which this response policy is applied.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gkeClusters")]
        public virtual System.Collections.Generic.IList<ResponsePolicyGKECluster> GkeClusters { get; set; }

        /// <summary>Unique identifier for the resource; defined by the server (output only).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<long> Id { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>List of network names specifying networks to which this policy is applied.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networks")]
        public virtual System.Collections.Generic.IList<ResponsePolicyNetwork> Networks { get; set; }

        /// <summary>User assigned name for this Response Policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responsePolicyName")]
        public virtual string ResponsePolicyName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ResponsePolicyGKECluster : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The resource name of the cluster to bind this response policy to. This should be specified in the format
        /// like: projects/*/locations/*/clusters/*. This is referenced from GKE projects.locations.clusters.get API:
        /// https://cloud.google.com/kubernetes-engine/docs/reference/rest/v1/projects.locations.clusters/get
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gkeClusterName")]
        public virtual string GkeClusterName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ResponsePolicyNetwork : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The fully qualified URL of the VPC network to bind to. This should be formatted like
        /// https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkUrl")]
        public virtual string NetworkUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A Response Policy Rule is a selector that applies its behavior to queries that match the selector. Selectors are
    /// DNS names, which may be wildcards or exact matches. Each DNS query subject to a Response Policy matches at most
    /// one ResponsePolicyRule, as identified by the dns_name field with the longest matching suffix.
    /// </summary>
    public class ResponsePolicyRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Answer this query with a behavior rather than DNS data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("behavior")]
        public virtual string Behavior { get; set; }

        /// <summary>
        /// The DNS name (wildcard or exact) to apply this rule to. Must be unique within the Response Policy Rule.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dnsName")]
        public virtual string DnsName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Answer this query directly with DNS data. These ResourceRecordSets override any other DNS behavior for the
        /// matched name; in particular they override private zones, the public internet, and GCP internal DNS. No SOA
        /// nor NS types are allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localData")]
        public virtual ResponsePolicyRuleLocalData LocalData { get; set; }

        /// <summary>An identifier for this rule. Must be unique with the ResponsePolicy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ruleName")]
        public virtual string RuleName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ResponsePolicyRuleLocalData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// All resource record sets for this selector, one per resource record type. The name must match the dns_name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localDatas")]
        public virtual System.Collections.Generic.IList<ResourceRecordSet> LocalDatas { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ResponsePolicyRulesListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("header")]
        public virtual ResponseHeader Header { get; set; }

        /// <summary>
        /// The presence of this field indicates that there exist more results following your last page of results in
        /// pagination order. To fetch them, make another list request using this value as your page token. This lets
        /// you the complete contents of even very large collections one page at a time. However, if the contents of the
        /// collection change between the first and last paginated list request, the set of all elements returned are an
        /// inconsistent view of the collection. You cannot retrieve a consistent snapshot of a collection larger than
        /// the maximum page size.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The Response Policy Rule resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responsePolicyRules")]
        public virtual System.Collections.Generic.IList<ResponsePolicyRule> ResponsePolicyRules { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ResponsePolicyRulesPatchResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("header")]
        public virtual ResponseHeader Header { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("responsePolicyRule")]
        public virtual ResponsePolicyRule ResponsePolicyRule { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ResponsePolicyRulesUpdateResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("header")]
        public virtual ResponseHeader Header { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("responsePolicyRule")]
        public virtual ResponsePolicyRule ResponsePolicyRule { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
