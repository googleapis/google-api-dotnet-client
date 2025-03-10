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
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://dns.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://dns.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "dns";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud DNS API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>
            /// View your data across Google Cloud services and see the email address of your Google Account
            /// </summary>
            public static string CloudPlatformReadOnly = "https://www.googleapis.com/auth/cloud-platform.read-only";

            /// <summary>View your DNS records hosted by Google Cloud DNS</summary>
            public static string NdevClouddnsReadonly = "https://www.googleapis.com/auth/ndev.clouddns.readonly";

            /// <summary>View and manage your DNS records hosted by Google Cloud DNS</summary>
            public static string NdevClouddnsReadwrite = "https://www.googleapis.com/auth/ndev.clouddns.readwrite";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud DNS API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>
            /// View your data across Google Cloud services and see the email address of your Google Account
            /// </summary>
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
            return new CreateRequest(this.service, body, project, managedZone);
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
            return new GetRequest(this.service, project, managedZone, changeId);
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
            return new ListRequest(this.service, project, managedZone);
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
            return new GetRequest(this.service, project, managedZone, dnsKeyId);
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
            return new ListRequest(this.service, project, managedZone);
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
            return new GetRequest(this.service, project, managedZone, operation);
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
            return new ListRequest(this.service, project, managedZone);
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
            return new CreateRequest(this.service, body, project);
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
            return new DeleteRequest(this.service, project, managedZone);
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
            return new GetRequest(this.service, project, managedZone);
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

        /// <summary>
        /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and does not
        /// have a policy set.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested. See [Resource
        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
        /// </param>
        public virtual GetIamPolicyRequest GetIamPolicy(Google.Apis.Dns.v1beta2.Data.GoogleIamV1GetIamPolicyRequest body, string resource)
        {
            return new GetIamPolicyRequest(this.service, body, resource);
        }

        /// <summary>
        /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and does not
        /// have a policy set.
        /// </summary>
        public class GetIamPolicyRequest : DnsBaseServiceRequest<Google.Apis.Dns.v1beta2.Data.GoogleIamV1Policy>
        {
            /// <summary>Constructs a new GetIamPolicy request.</summary>
            public GetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.Dns.v1beta2.Data.GoogleIamV1GetIamPolicyRequest body, string resource) : base(service)
            {
                Resource = resource;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// REQUIRED: The resource for which the policy is being requested. See [Resource
            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Dns.v1beta2.Data.GoogleIamV1GetIamPolicyRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getIamPolicy";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "dns/v1beta2/{+resource}:getIamPolicy";

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
                    Pattern = @"^projects/[^/]+/managedZones/[^/]+$",
                });
            }
        }

        /// <summary>Enumerates ManagedZones that have been created but not yet deleted.</summary>
        /// <param name="project">Identifies the project addressed by this request.</param>
        public virtual ListRequest List(string project)
        {
            return new ListRequest(this.service, project);
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
            return new PatchRequest(this.service, body, project, managedZone);
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

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
        /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified. See [Resource
        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
        /// </param>
        public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.Dns.v1beta2.Data.GoogleIamV1SetIamPolicyRequest body, string resource)
        {
            return new SetIamPolicyRequest(this.service, body, resource);
        }

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
        /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
        /// </summary>
        public class SetIamPolicyRequest : DnsBaseServiceRequest<Google.Apis.Dns.v1beta2.Data.GoogleIamV1Policy>
        {
            /// <summary>Constructs a new SetIamPolicy request.</summary>
            public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.Dns.v1beta2.Data.GoogleIamV1SetIamPolicyRequest body, string resource) : base(service)
            {
                Resource = resource;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// REQUIRED: The resource for which the policy is being specified. See [Resource
            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Dns.v1beta2.Data.GoogleIamV1SetIamPolicyRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "setIamPolicy";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "dns/v1beta2/{+resource}:setIamPolicy";

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
                    Pattern = @"^projects/[^/]+/managedZones/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified resource. If the resource does not exist, this
        /// returns an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is designed to be used
        /// for building permission-aware UIs and command-line tools, not for authorization checking. This operation may
        /// "fail open" without warning.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
        /// </param>
        public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.Dns.v1beta2.Data.GoogleIamV1TestIamPermissionsRequest body, string resource)
        {
            return new TestIamPermissionsRequest(this.service, body, resource);
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified resource. If the resource does not exist, this
        /// returns an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is designed to be used
        /// for building permission-aware UIs and command-line tools, not for authorization checking. This operation may
        /// "fail open" without warning.
        /// </summary>
        public class TestIamPermissionsRequest : DnsBaseServiceRequest<Google.Apis.Dns.v1beta2.Data.GoogleIamV1TestIamPermissionsResponse>
        {
            /// <summary>Constructs a new TestIamPermissions request.</summary>
            public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.Dns.v1beta2.Data.GoogleIamV1TestIamPermissionsRequest body, string resource) : base(service)
            {
                Resource = resource;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Dns.v1beta2.Data.GoogleIamV1TestIamPermissionsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "testIamPermissions";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "dns/v1beta2/{+resource}:testIamPermissions";

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
                    Pattern = @"^projects/[^/]+/managedZones/[^/]+$",
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
            return new UpdateRequest(this.service, body, project, managedZone);
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
            return new CreateRequest(this.service, body, project);
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
            return new DeleteRequest(this.service, project, policy);
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
            return new GetRequest(this.service, project, policy);
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
            return new ListRequest(this.service, project);
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
            return new PatchRequest(this.service, body, project, policy);
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
            return new UpdateRequest(this.service, body, project, policy);
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
        }

        /// <summary>Fetches the representation of an existing Project.</summary>
        /// <param name="project">Identifies the project addressed by this request.</param>
        public virtual GetRequest Get(string project)
        {
            return new GetRequest(this.service, project);
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

        /// <summary>Creates a new ResourceRecordSet.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="project">Identifies the project addressed by this request.</param>
        /// <param name="managedZone">
        /// Identifies the managed zone addressed by this request. Can be the managed zone name or ID.
        /// </param>
        public virtual CreateRequest Create(Google.Apis.Dns.v1beta2.Data.ResourceRecordSet body, string project, string managedZone)
        {
            return new CreateRequest(this.service, body, project, managedZone);
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
            /// For mutating operation requests only. An optional identifier specified by the client. Must be unique for
            /// operation resources in the Operations collection.
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
            return new DeleteRequest(this.service, project, managedZone, name, type);
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
            return new GetRequest(this.service, project, managedZone, name, type);
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

        /// <summary>Enumerates ResourceRecordSets that you have created but not yet deleted.</summary>
        /// <param name="project">Identifies the project addressed by this request.</param>
        /// <param name="managedZone">
        /// Identifies the managed zone addressed by this request. Can be the managed zone name or ID.
        /// </param>
        public virtual ListRequest List(string project, string managedZone)
        {
            return new ListRequest(this.service, project, managedZone);
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
            return new PatchRequest(this.service, body, project, managedZone, name, type);
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
            /// For mutating operation requests only. An optional identifier specified by the client. Must be unique for
            /// operation resources in the Operations collection.
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
            return new CreateRequest(this.service, body, project);
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
            return new DeleteRequest(this.service, project, responsePolicy);
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
            return new GetRequest(this.service, project, responsePolicy);
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
            return new ListRequest(this.service, project);
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
        /// <param name="responsePolicy">User assigned name of the response policy addressed by this request.</param>
        public virtual PatchRequest Patch(Google.Apis.Dns.v1beta2.Data.ResponsePolicy body, string project, string responsePolicy)
        {
            return new PatchRequest(this.service, body, project, responsePolicy);
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

            /// <summary>User assigned name of the response policy addressed by this request.</summary>
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
            return new UpdateRequest(this.service, body, project, responsePolicy);
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
            return new CreateRequest(this.service, body, project, responsePolicy);
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
            return new DeleteRequest(this.service, project, responsePolicy, responsePolicyRule);
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
            return new GetRequest(this.service, project, responsePolicy, responsePolicyRule);
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
            return new ListRequest(this.service, project, responsePolicy);
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
            return new PatchRequest(this.service, body, project, responsePolicy, responsePolicyRule);
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
            return new UpdateRequest(this.service, body, project, responsePolicy, responsePolicyRule);
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
    /// A Change represents a set of `ResourceRecordSet` additions and deletions applied atomically to a ManagedZone.
    /// ResourceRecordSets within a ManagedZone are modified by creating a new Change element in the Changes collection.
    /// In turn the Changes collection also records the past modifications to the `ResourceRecordSets` in a
    /// `ManagedZone`. The current state of the `ManagedZone` is the sum effect of applying all `Change` elements in the
    /// `Changes` collection in sequence.
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

        /// <summary>Type of resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// This field indicates that more results are available beyond the last page displayed. To fetch the results,
        /// make another list request and use this value as your page token. This lets you retrieve the complete
        /// contents of a very large collection one page at a time. However, if the contents of the collection change
        /// between the first and last paginated list request, the set of all elements returned are an inconsistent view
        /// of the collection. You can't retrieve a consistent snapshot of a collection larger than the maximum page
        /// size.
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

        /// <summary>Type of resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// This field indicates that more results are available beyond the last page displayed. To fetch the results,
        /// make another list request and use this value as your page token. This lets you retrieve the complete
        /// contents of a very large collection one page at a time. However, if the contents of the collection change
        /// between the first and last paginated list request, the set of all elements returned are an inconsistent view
        /// of the collection. You can't retrieve a consistent snapshot of a collection larger than the maximum page
        /// size.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

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
    public class GoogleIamV1AuditConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The configuration for logging of each type of permission.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditLogConfigs")]
        public virtual System.Collections.Generic.IList<GoogleIamV1AuditLogConfig> AuditLogConfigs { get; set; }

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
    public class GoogleIamV1AuditLogConfig : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>Associates `members`, or principals, with a `role`.</summary>
    public class GoogleIamV1Binding : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>Request message for `GetIamPolicy` method.</summary>
    public class GoogleIamV1GetIamPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>OPTIONAL: A `GetPolicyOptions` object for specifying options to `GetIamPolicy`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("options")]
        public virtual GoogleIamV1GetPolicyOptions Options { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Encapsulates settings provided to GetIamPolicy.</summary>
    public class GoogleIamV1GetPolicyOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The maximum policy version that will be used to format the policy. Valid values are 0, 1, and 3.
        /// Requests specifying an invalid value will be rejected. Requests for policies with any conditional role
        /// bindings must specify version 3. Policies with no conditional role bindings may specify any valid value or
        /// leave the field unset. The policy in the response might use the policy version that you specified, or it
        /// might use a lower policy version. For example, if you specify version 3, but the policy has no conditional
        /// role bindings, the response uses version 1. To learn which resources support conditions in their IAM
        /// policies, see the [IAM documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedPolicyVersion")]
        public virtual System.Nullable<int> RequestedPolicyVersion { get; set; }

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
    public class GoogleIamV1Policy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies cloud audit logging configuration for this policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditConfigs")]
        public virtual System.Collections.Generic.IList<GoogleIamV1AuditConfig> AuditConfigs { get; set; }

        /// <summary>
        /// Associates a list of `members`, or principals, with a `role`. Optionally, may specify a `condition` that
        /// determines how and when the `bindings` are applied. Each of the `bindings` must contain at least one
        /// principal. The `bindings` in a `Policy` can refer to up to 1,500 principals; up to 250 of these principals
        /// can be Google groups. Each occurrence of a principal counts towards these limits. For example, if the
        /// `bindings` grant 50 different roles to `user:alice@example.com`, and not to any other principal, then you
        /// can add another 1,450 principals to the `bindings` in the `Policy`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bindings")]
        public virtual System.Collections.Generic.IList<GoogleIamV1Binding> Bindings { get; set; }

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

    /// <summary>Request message for `SetIamPolicy` method.</summary>
    public class GoogleIamV1SetIamPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of the policy is limited to a few
        /// 10s of KB. An empty policy is a valid policy but certain Google Cloud services (such as Projects) might
        /// reject them.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual GoogleIamV1Policy Policy { get; set; }

        /// <summary>
        /// OPTIONAL: A FieldMask specifying which fields of the policy to modify. Only the fields in the mask will be
        /// modified. If no mask is provided, the following default mask is used: `paths: "bindings, etag"`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for `TestIamPermissions` method.</summary>
    public class GoogleIamV1TestIamPermissionsRequest : Google.Apis.Requests.IDirectResponseSchema
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
    public class GoogleIamV1TestIamPermissionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A subset of `TestPermissionsRequest.permissions` that the caller is allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<string> Permissions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A zone is a subtree of the DNS namespace under one administrative responsibility. A ManagedZone is a resource
    /// that represents a DNS zone hosted by the Cloud DNS service.
    /// </summary>
    public class ManagedZone : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("cloudLoggingConfig")]
        public virtual ManagedZoneCloudLoggingConfig CloudLoggingConfig { get; set; }

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

    /// <summary>Cloud Logging configurations for publicly visible zones.</summary>
    public class ManagedZoneCloudLoggingConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If set, enable query logging for this ManagedZone. False by default, making logging opt-in.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableLogging")]
        public virtual System.Nullable<bool> EnableLogging { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

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
        /// Public preview as of November 2022.
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
        /// <summary>Type of resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// This field indicates that more results are available beyond the last page displayed. To fetch the results,
        /// make another list request and use this value as your page token. This lets you retrieve the complete
        /// contents of a very large collection one page at a time. However, if the contents of the collection change
        /// between the first and last paginated list request, the set of all elements returned are an inconsistent view
        /// of the collection. You can't retrieve a consistent snapshot of a collection larger than the maximum page
        /// size.
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
        /// `https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}`
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
        /// `https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}`
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
        /// `https://servicedirectory.googleapis.com/v1/projects/{project}/locations/{location}/namespaces/{namespace}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namespaceUrl")]
        public virtual string NamespaceUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ManagedZonesListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Type of resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The managed zone resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managedZones")]
        public virtual System.Collections.Generic.IList<ManagedZone> ManagedZones { get; set; }

        /// <summary>
        /// This field indicates that more results are available beyond the last page displayed. To fetch the results,
        /// make another list request and use this value as your page token. This lets you retrieve the complete
        /// contents of a very large collection one page at a time. However, if the contents of the collection change
        /// between the first and last paginated list request, the set of all elements returned are an inconsistent view
        /// of the collection. You can't retrieve a consistent snapshot of a collection larger than the maximum page
        /// size.
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
        /// <summary>Type of resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// This field indicates that more results are available beyond the last page displayed. To fetch the results,
        /// make another list request and use this value as your page token. This lets you retrieve the complete
        /// contents of a very large collection one page at a time. However, if the contents of the collection change
        /// between the first and last paginated list request, the set of all elements returned are an inconsistent view
        /// of the collection. You can't retrieve a consistent snapshot of a collection larger than the maximum page
        /// size.
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
        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual Policy Policy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class PoliciesUpdateResponse : Google.Apis.Requests.IDirectResponseSchema
    {
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

        /// <summary>Configurations related to DNS64 for this Policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dns64Config")]
        public virtual PolicyDns64Config Dns64Config { get; set; }

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

        /// <summary>IPv4 address to forward queries to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipv4Address")]
        public virtual string Ipv4Address { get; set; }

        /// <summary>
        /// IPv6 address to forward to. Does not accept both fields (ipv4 &amp;amp; ipv6) being populated. Public
        /// preview as of November 2022.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipv6Address")]
        public virtual string Ipv6Address { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>DNS64 policies</summary>
    public class PolicyDns64Config : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The scope to which DNS64 config will be applied to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public virtual PolicyDns64ConfigScope Scope { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class PolicyDns64ConfigScope : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Controls whether DNS64 is enabled globally at the network level.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allQueries")]
        public virtual System.Nullable<bool> AllQueries { get; set; }

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
    /// Projects can be created only in the APIs console.
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

        /// <summary>Maximum allowed number of GKE clusters per policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gkeClustersPerPolicy")]
        public virtual System.Nullable<int> GkeClustersPerPolicy { get; set; }

        /// <summary>Maximum allowed number of GKE clusters per response policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gkeClustersPerResponsePolicy")]
        public virtual System.Nullable<int> GkeClustersPerResponsePolicy { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("internetHealthChecksPerManagedZone")]
        public virtual System.Nullable<int> InternetHealthChecksPerManagedZone { get; set; }

        /// <summary>Maximum allowed number of items per routing policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemsPerRoutingPolicy")]
        public virtual System.Nullable<int> ItemsPerRoutingPolicy { get; set; }

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

        /// <summary>Maximum number of nameservers per delegation, meant to prevent abuse</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nameserversPerDelegation")]
        public virtual System.Nullable<int> NameserversPerDelegation { get; set; }

        /// <summary>Maximum allowed number of networks to which a privately scoped zone can be attached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networksPerManagedZone")]
        public virtual System.Nullable<int> NetworksPerManagedZone { get; set; }

        /// <summary>Maximum allowed number of networks per policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networksPerPolicy")]
        public virtual System.Nullable<int> NetworksPerPolicy { get; set; }

        /// <summary>Maximum allowed number of networks per response policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networksPerResponsePolicy")]
        public virtual System.Nullable<int> NetworksPerResponsePolicy { get; set; }

        /// <summary>
        /// Maximum allowed number of consumer peering zones per target network owned by this producer project
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("peeringZonesPerTargetNetwork")]
        public virtual System.Nullable<int> PeeringZonesPerTargetNetwork { get; set; }

        /// <summary>Maximum allowed number of policies per project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policies")]
        public virtual System.Nullable<int> Policies { get; set; }

        /// <summary>Maximum allowed number of ResourceRecords per ResourceRecordSet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceRecordsPerRrset")]
        public virtual System.Nullable<int> ResourceRecordsPerRrset { get; set; }

        /// <summary>Maximum allowed number of response policies per project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responsePolicies")]
        public virtual System.Nullable<int> ResponsePolicies { get; set; }

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

    /// <summary>
    /// A RRSetRoutingPolicy represents ResourceRecordSet data that is returned dynamically with the response varying
    /// based on configured properties such as geolocation or by weighted random selection.
    /// </summary>
    public class RRSetRoutingPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("geo")]
        public virtual RRSetRoutingPolicyGeoPolicy Geo { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("geoPolicy")]
        public virtual RRSetRoutingPolicyGeoPolicy GeoPolicy { get; set; }

        /// <summary>
        /// The fully qualified URL of the HealthCheck to use for this RRSetRoutingPolicy. Format this URL like
        /// `https://www.googleapis.com/compute/v1/projects/{project}/global/healthChecks/{healthCheck}`.
        /// https://cloud.google.com/compute/docs/reference/rest/v1/healthChecks
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("healthCheck")]
        public virtual string HealthCheck { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("primaryBackup")]
        public virtual RRSetRoutingPolicyPrimaryBackupPolicy PrimaryBackup { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("wrr")]
        public virtual RRSetRoutingPolicyWrrPolicy Wrr { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("wrrPolicy")]
        public virtual RRSetRoutingPolicyWrrPolicy WrrPolicy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configures a `RRSetRoutingPolicy` that routes based on the geo location of the querying user.</summary>
    public class RRSetRoutingPolicyGeoPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Without fencing, if health check fails for all configured items in the current geo bucket, we failover to
        /// the next nearest geo bucket. With fencing, if health checking is enabled, as long as some targets in the
        /// current geo bucket are healthy, we return only the healthy targets. However, if all targets are unhealthy,
        /// we don't failover to the next nearest bucket; instead, we return all the items in the current bucket even
        /// when all targets are unhealthy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableFencing")]
        public virtual System.Nullable<bool> EnableFencing { get; set; }

        /// <summary>
        /// The primary geo routing configuration. If there are multiple items with the same location, an error is
        /// returned instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<RRSetRoutingPolicyGeoPolicyGeoPolicyItem> Items { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ResourceRecordSet data for one geo location.</summary>
    public class RRSetRoutingPolicyGeoPolicyGeoPolicyItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// For A and AAAA types only. Endpoints to return in the query result only if they are healthy. These can be
        /// specified along with `rrdata` within this item.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("healthCheckedTargets")]
        public virtual RRSetRoutingPolicyHealthCheckTargets HealthCheckedTargets { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The geo-location granularity is a GCP region. This location string should correspond to a GCP region. e.g.
        /// "us-east1", "southamerica-east1", "asia-east1", etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("rrdatas")]
        public virtual System.Collections.Generic.IList<string> Rrdatas { get; set; }

        /// <summary>
        /// DNSSEC generated signatures for all the `rrdata` within this item. When using health-checked targets for
        /// DNSSEC-enabled zones, you can only use at most one health-checked IP address per item.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signatureRrdatas")]
        public virtual System.Collections.Generic.IList<string> SignatureRrdatas { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// HealthCheckTargets describes endpoints to health-check when responding to Routing Policy queries. Only the
    /// healthy endpoints will be included in the response. Set either `internal_load_balancer` or `external_endpoints`.
    /// Do not set both.
    /// </summary>
    public class RRSetRoutingPolicyHealthCheckTargets : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The Internet IP addresses to be health checked. The format matches the format of ResourceRecordSet.rrdata as
        /// defined in RFC 1035 (section 5) and RFC 1034 (section 3.6.1)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalEndpoints")]
        public virtual System.Collections.Generic.IList<string> ExternalEndpoints { get; set; }

        /// <summary>Configuration for internal load balancers to be health checked.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("internalLoadBalancers")]
        public virtual System.Collections.Generic.IList<RRSetRoutingPolicyLoadBalancerTarget> InternalLoadBalancers { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The configuration for an individual load balancer to health check.</summary>
    public class RRSetRoutingPolicyLoadBalancerTarget : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The frontend IP address of the load balancer to health check.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipAddress")]
        public virtual string IpAddress { get; set; }

        /// <summary>The protocol of the load balancer to health check.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipProtocol")]
        public virtual string IpProtocol { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The type of load balancer specified by this target. This value must match the configuration of the load
        /// balancer located at the LoadBalancerTarget's IP address, port, and region. Use the following: -
        /// *regionalL4ilb*: for a regional internal passthrough Network Load Balancer. - *regionalL7ilb*: for a
        /// regional internal Application Load Balancer. - *globalL7ilb*: for a global internal Application Load
        /// Balancer.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loadBalancerType")]
        public virtual string LoadBalancerType { get; set; }

        /// <summary>
        /// The fully qualified URL of the network that the load balancer is attached to. This should be formatted like
        /// `https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkUrl")]
        public virtual string NetworkUrl { get; set; }

        /// <summary>The configured port of the load balancer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("port")]
        public virtual string Port { get; set; }

        /// <summary>The project ID in which the load balancer is located.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("project")]
        public virtual string Project { get; set; }

        /// <summary>The region in which the load balancer is located.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual string Region { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configures a RRSetRoutingPolicy such that all queries are responded with the primary_targets if they are
    /// healthy. And if all of them are unhealthy, then we fallback to a geo localized policy.
    /// </summary>
    public class RRSetRoutingPolicyPrimaryBackupPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Backup targets provide a regional failover policy for the otherwise global primary targets. If serving state
        /// is set to `BACKUP`, this policy essentially becomes a geo routing policy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupGeoTargets")]
        public virtual RRSetRoutingPolicyGeoPolicy BackupGeoTargets { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Endpoints that are health checked before making the routing decision. Unhealthy endpoints are omitted from
        /// the results. If all endpoints are unhealthy, we serve a response based on the `backup_geo_targets`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryTargets")]
        public virtual RRSetRoutingPolicyHealthCheckTargets PrimaryTargets { get; set; }

        /// <summary>
        /// When serving state is `PRIMARY`, this field provides the option of sending a small percentage of the traffic
        /// to the backup targets.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trickleTraffic")]
        public virtual System.Nullable<double> TrickleTraffic { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configures a RRSetRoutingPolicy that routes in a weighted round robin fashion.</summary>
    public class RRSetRoutingPolicyWrrPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<RRSetRoutingPolicyWrrPolicyWrrPolicyItem> Items { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A routing block which contains the routing information for one WRR item.</summary>
    public class RRSetRoutingPolicyWrrPolicyWrrPolicyItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Endpoints that are health checked before making the routing decision. The unhealthy endpoints are omitted
        /// from the result. If all endpoints within a bucket are unhealthy, we choose a different bucket (sampled with
        /// respect to its weight) for responding. If DNSSEC is enabled for this zone, only one of `rrdata` or
        /// `health_checked_targets` can be set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("healthCheckedTargets")]
        public virtual RRSetRoutingPolicyHealthCheckTargets HealthCheckedTargets { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("rrdatas")]
        public virtual System.Collections.Generic.IList<string> Rrdatas { get; set; }

        /// <summary>
        /// DNSSEC generated signatures for all the `rrdata` within this item. When using health-checked targets for
        /// DNSSEC-enabled zones, you can only use at most one health-checked IP address per item.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signatureRrdatas")]
        public virtual System.Collections.Generic.IList<string> SignatureRrdatas { get; set; }

        /// <summary>
        /// The weight corresponding to this `WrrPolicyItem` object. When multiple `WrrPolicyItem` objects are
        /// configured, the probability of returning an `WrrPolicyItem` object's data is proportional to its weight
        /// relative to the sum of weights configured for all items. This weight must be non-negative.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weight")]
        public virtual System.Nullable<double> Weight { get; set; }

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

        /// <summary>
        /// Configures dynamic query responses based on either the geo location of the querying user or a weighted round
        /// robin based routing policy. A valid `ResourceRecordSet` contains only `rrdata` (for static resolution) or a
        /// `routing_policy` (for dynamic resolution).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("routingPolicy")]
        public virtual RRSetRoutingPolicy RoutingPolicy { get; set; }

        /// <summary>As defined in RFC 1035 (section 5) and RFC 1034 (section 3.6.1) -- see examples.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rrdatas")]
        public virtual System.Collections.Generic.IList<string> Rrdatas { get; set; }

        /// <summary>As defined in RFC 4034 (section 3.2).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signatureRrdatas")]
        public virtual System.Collections.Generic.IList<string> SignatureRrdatas { get; set; }

        /// <summary>Number of seconds that this `ResourceRecordSet` can be cached by resolvers.</summary>
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
        /// <summary>Type of resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// This field indicates that more results are available beyond the last page displayed. To fetch the results,
        /// make another list request and use this value as your page token. This lets you retrieve the complete
        /// contents of a very large collection one page at a time. However, if the contents of the collection change
        /// between the first and last paginated list request, the set of all elements returned are an inconsistent view
        /// of the collection. You can't retrieve a consistent snapshot of a collection larger than the maximum page
        /// size.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The resource record set resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rrsets")]
        public virtual System.Collections.Generic.IList<ResourceRecordSet> Rrsets { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ResponsePoliciesListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// This field indicates that more results are available beyond the last page displayed. To fetch the results,
        /// make another list request and use this value as your page token. This lets you retrieve the complete
        /// contents of a very large collection one page at a time. However, if the contents of the collection change
        /// between the first and last paginated list request, the set of all elements returned are an inconsistent view
        /// of the collection. You can't retrieve a consistent snapshot of a collection larger than the maximum page
        /// size.
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
        [Newtonsoft.Json.JsonPropertyAttribute("responsePolicy")]
        public virtual ResponsePolicy ResponsePolicy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ResponsePoliciesUpdateResponse : Google.Apis.Requests.IDirectResponseSchema
    {
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

        /// <summary>User labels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

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
        /// `https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}`
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
        /// <summary>
        /// This field indicates that more results are available beyond the last page displayed. To fetch the results,
        /// make another list request and use this value as your page token. This lets you retrieve the complete
        /// contents of a very large collection one page at a time. However, if the contents of the collection change
        /// between the first and last paginated list request, the set of all elements returned are an inconsistent view
        /// of the collection. You can't retrieve a consistent snapshot of a collection larger than the maximum page
        /// size.
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
        [Newtonsoft.Json.JsonPropertyAttribute("responsePolicyRule")]
        public virtual ResponsePolicyRule ResponsePolicyRule { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ResponsePolicyRulesUpdateResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("responsePolicyRule")]
        public virtual ResponsePolicyRule ResponsePolicyRule { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
