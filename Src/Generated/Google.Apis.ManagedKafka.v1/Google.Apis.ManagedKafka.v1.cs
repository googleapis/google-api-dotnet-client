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

namespace Google.Apis.ManagedKafka.v1
{
    /// <summary>The ManagedKafka Service.</summary>
    public class ManagedKafkaService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public ManagedKafkaService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public ManagedKafkaService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://managedkafka.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://managedkafka.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "managedkafka";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Managed Service for Apache Kafka API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>
        /// Available OAuth 2.0 scope constants for use with the Managed Service for Apache Kafka API.
        /// </summary>
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

    /// <summary>A base abstract class for ManagedKafka requests.</summary>
    public abstract class ManagedKafkaBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new ManagedKafkaBaseServiceRequest instance.</summary>
        protected ManagedKafkaBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes ManagedKafka parameter list.</summary>
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
                Clusters = new ClustersResource(service);
                ConnectClusters = new ConnectClustersResource(service);
                Operations = new OperationsResource(service);
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
                    Acls = new AclsResource(service);
                    ConsumerGroups = new ConsumerGroupsResource(service);
                    Topics = new TopicsResource(service);
                }

                /// <summary>Gets the Acls resource.</summary>
                public virtual AclsResource Acls { get; }

                /// <summary>The "acls" collection of methods.</summary>
                public class AclsResource
                {
                    private const string Resource = "acls";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public AclsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Incremental update: Adds an acl entry to an acl. Creates the acl if it does not exist yet.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="acl">
                    /// Required. The name of the acl to add the acl entry to. Structured like:
                    /// `projects/{project}/locations/{location}/clusters/{cluster}/acls/{acl_id}`. The structure of
                    /// `acl_id` defines the Resource Pattern (resource_type, resource_name, pattern_type) of the acl.
                    /// See `Acl.name` for details.
                    /// </param>
                    public virtual AddAclEntryRequest AddAclEntry(Google.Apis.ManagedKafka.v1.Data.AclEntry body, string acl)
                    {
                        return new AddAclEntryRequest(this.service, body, acl);
                    }

                    /// <summary>
                    /// Incremental update: Adds an acl entry to an acl. Creates the acl if it does not exist yet.
                    /// </summary>
                    public class AddAclEntryRequest : ManagedKafkaBaseServiceRequest<Google.Apis.ManagedKafka.v1.Data.AddAclEntryResponse>
                    {
                        /// <summary>Constructs a new AddAclEntry request.</summary>
                        public AddAclEntryRequest(Google.Apis.Services.IClientService service, Google.Apis.ManagedKafka.v1.Data.AclEntry body, string acl) : base(service)
                        {
                            Acl = acl;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the acl to add the acl entry to. Structured like:
                        /// `projects/{project}/locations/{location}/clusters/{cluster}/acls/{acl_id}`. The structure of
                        /// `acl_id` defines the Resource Pattern (resource_type, resource_name, pattern_type) of the
                        /// acl. See `Acl.name` for details.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("acl", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Acl { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.ManagedKafka.v1.Data.AclEntry Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "addAclEntry";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+acl}:addAclEntry";

                        /// <summary>Initializes AddAclEntry parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("acl", new Google.Apis.Discovery.Parameter
                            {
                                Name = "acl",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+/acls/.*$",
                            });
                        }
                    }

                    /// <summary>Creates a new acl in the given project, location, and cluster.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The parent cluster in which to create the acl. Structured like
                    /// `projects/{project}/locations/{location}/clusters/{cluster}`.
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.ManagedKafka.v1.Data.Acl body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>Creates a new acl in the given project, location, and cluster.</summary>
                    public class CreateRequest : ManagedKafkaBaseServiceRequest<Google.Apis.ManagedKafka.v1.Data.Acl>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.ManagedKafka.v1.Data.Acl body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent cluster in which to create the acl. Structured like
                        /// `projects/{project}/locations/{location}/clusters/{cluster}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. The ID to use for the acl, which will become the final component of the acl's
                        /// name. The structure of `acl_id` defines the Resource Pattern (resource_type, resource_name,
                        /// pattern_type) of the acl. `acl_id` is structured like one of the following: For acls on the
                        /// cluster: `cluster` For acls on a single resource within the cluster: `topic/{resource_name}`
                        /// `consumerGroup/{resource_name}` `transactionalId/{resource_name}` For acls on all resources
                        /// that match a prefix: `topicPrefixed/{resource_name}` `consumerGroupPrefixed/{resource_name}`
                        /// `transactionalIdPrefixed/{resource_name}` For acls on all resources of a given type (i.e.
                        /// the wildcard literal "*"): `allTopics` (represents `topic/*`) `allConsumerGroups`
                        /// (represents `consumerGroup/*`) `allTransactionalIds` (represents `transactionalId/*`)
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("aclId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string AclId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.ManagedKafka.v1.Data.Acl Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/acls";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+$",
                            });
                            RequestParameters.Add("aclId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "aclId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Deletes an acl.</summary>
                    /// <param name="name">
                    /// Required. The name of the acl to delete. Structured like:
                    /// `projects/{project}/locations/{location}/clusters/{cluster}/acls/{acl_id}`. The structure of
                    /// `acl_id` defines the Resource Pattern (resource_type, resource_name, pattern_type) of the acl.
                    /// See `Acl.name` for details.
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Deletes an acl.</summary>
                    public class DeleteRequest : ManagedKafkaBaseServiceRequest<Google.Apis.ManagedKafka.v1.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the acl to delete. Structured like:
                        /// `projects/{project}/locations/{location}/clusters/{cluster}/acls/{acl_id}`. The structure of
                        /// `acl_id` defines the Resource Pattern (resource_type, resource_name, pattern_type) of the
                        /// acl. See `Acl.name` for details.
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+/acls/.*$",
                            });
                        }
                    }

                    /// <summary>Returns the properties of a single acl.</summary>
                    /// <param name="name">
                    /// Required. The name of the acl to return. Structured like:
                    /// `projects/{project}/locations/{location}/clusters/{cluster}/acls/{acl_id}`. The structure of
                    /// `acl_id` defines the Resource Pattern (resource_type, resource_name, pattern_type) of the acl.
                    /// See `Acl.name` for details.
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Returns the properties of a single acl.</summary>
                    public class GetRequest : ManagedKafkaBaseServiceRequest<Google.Apis.ManagedKafka.v1.Data.Acl>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the acl to return. Structured like:
                        /// `projects/{project}/locations/{location}/clusters/{cluster}/acls/{acl_id}`. The structure of
                        /// `acl_id` defines the Resource Pattern (resource_type, resource_name, pattern_type) of the
                        /// acl. See `Acl.name` for details.
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+/acls/.*$",
                            });
                        }
                    }

                    /// <summary>Lists the acls in a given cluster.</summary>
                    /// <param name="parent">
                    /// Required. The parent cluster whose acls are to be listed. Structured like
                    /// `projects/{project}/locations/{location}/clusters/{cluster}`.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists the acls in a given cluster.</summary>
                    public class ListRequest : ManagedKafkaBaseServiceRequest<Google.Apis.ManagedKafka.v1.Data.ListAclsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent cluster whose acls are to be listed. Structured like
                        /// `projects/{project}/locations/{location}/clusters/{cluster}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. The maximum number of acls to return. The service may return fewer than this
                        /// value. If unset or zero, all acls for the parent is returned.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. A page token, received from a previous `ListAcls` call. Provide this to retrieve
                        /// the subsequent page. When paginating, all other parameters provided to `ListAcls` must match
                        /// the call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/acls";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+$",
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

                    /// <summary>Updates the properties of a single acl.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Identifier. The name for the acl. Represents a single Resource Pattern. Structured like:
                    /// projects/{project}/locations/{location}/clusters/{cluster}/acls/{acl_id} The structure of
                    /// `acl_id` defines the Resource Pattern (resource_type, resource_name, pattern_type) of the acl.
                    /// `acl_id` is structured like one of the following: For acls on the cluster: `cluster` For acls on
                    /// a single resource within the cluster: `topic/{resource_name}` `consumerGroup/{resource_name}`
                    /// `transactionalId/{resource_name}` For acls on all resources that match a prefix:
                    /// `topicPrefixed/{resource_name}` `consumerGroupPrefixed/{resource_name}`
                    /// `transactionalIdPrefixed/{resource_name}` For acls on all resources of a given type (i.e. the
                    /// wildcard literal "*"): `allTopics` (represents `topic/*`) `allConsumerGroups` (represents
                    /// `consumerGroup/*`) `allTransactionalIds` (represents `transactionalId/*`)
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.ManagedKafka.v1.Data.Acl body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>Updates the properties of a single acl.</summary>
                    public class PatchRequest : ManagedKafkaBaseServiceRequest<Google.Apis.ManagedKafka.v1.Data.Acl>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.ManagedKafka.v1.Data.Acl body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Identifier. The name for the acl. Represents a single Resource Pattern. Structured like:
                        /// projects/{project}/locations/{location}/clusters/{cluster}/acls/{acl_id} The structure of
                        /// `acl_id` defines the Resource Pattern (resource_type, resource_name, pattern_type) of the
                        /// acl. `acl_id` is structured like one of the following: For acls on the cluster: `cluster`
                        /// For acls on a single resource within the cluster: `topic/{resource_name}`
                        /// `consumerGroup/{resource_name}` `transactionalId/{resource_name}` For acls on all resources
                        /// that match a prefix: `topicPrefixed/{resource_name}` `consumerGroupPrefixed/{resource_name}`
                        /// `transactionalIdPrefixed/{resource_name}` For acls on all resources of a given type (i.e.
                        /// the wildcard literal "*"): `allTopics` (represents `topic/*`) `allConsumerGroups`
                        /// (represents `consumerGroup/*`) `allTransactionalIds` (represents `transactionalId/*`)
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. Field mask is used to specify the fields to be overwritten in the Acl resource by
                        /// the update. The fields specified in the update_mask are relative to the resource, not the
                        /// full request. A field will be overwritten if it is in the mask.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.ManagedKafka.v1.Data.Acl Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+/acls/.*$",
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
                    /// Incremental update: Removes an acl entry from an acl. Deletes the acl if its acl entries become
                    /// empty (i.e. if the removed entry was the last one in the acl).
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="acl">
                    /// Required. The name of the acl to remove the acl entry from. Structured like:
                    /// `projects/{project}/locations/{location}/clusters/{cluster}/acls/{acl_id}`. The structure of
                    /// `acl_id` defines the Resource Pattern (resource_type, resource_name, pattern_type) of the acl.
                    /// See `Acl.name` for details.
                    /// </param>
                    public virtual RemoveAclEntryRequest RemoveAclEntry(Google.Apis.ManagedKafka.v1.Data.AclEntry body, string acl)
                    {
                        return new RemoveAclEntryRequest(this.service, body, acl);
                    }

                    /// <summary>
                    /// Incremental update: Removes an acl entry from an acl. Deletes the acl if its acl entries become
                    /// empty (i.e. if the removed entry was the last one in the acl).
                    /// </summary>
                    public class RemoveAclEntryRequest : ManagedKafkaBaseServiceRequest<Google.Apis.ManagedKafka.v1.Data.RemoveAclEntryResponse>
                    {
                        /// <summary>Constructs a new RemoveAclEntry request.</summary>
                        public RemoveAclEntryRequest(Google.Apis.Services.IClientService service, Google.Apis.ManagedKafka.v1.Data.AclEntry body, string acl) : base(service)
                        {
                            Acl = acl;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the acl to remove the acl entry from. Structured like:
                        /// `projects/{project}/locations/{location}/clusters/{cluster}/acls/{acl_id}`. The structure of
                        /// `acl_id` defines the Resource Pattern (resource_type, resource_name, pattern_type) of the
                        /// acl. See `Acl.name` for details.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("acl", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Acl { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.ManagedKafka.v1.Data.AclEntry Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "removeAclEntry";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+acl}:removeAclEntry";

                        /// <summary>Initializes RemoveAclEntry parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("acl", new Google.Apis.Discovery.Parameter
                            {
                                Name = "acl",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+/acls/.*$",
                            });
                        }
                    }
                }

                /// <summary>Gets the ConsumerGroups resource.</summary>
                public virtual ConsumerGroupsResource ConsumerGroups { get; }

                /// <summary>The "consumerGroups" collection of methods.</summary>
                public class ConsumerGroupsResource
                {
                    private const string Resource = "consumerGroups";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ConsumerGroupsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Deletes a single consumer group.</summary>
                    /// <param name="name">
                    /// Required. The name of the consumer group to delete.
                    /// `projects/{project}/locations/{location}/clusters/{cluster}/consumerGroups/{consumerGroup}`.
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Deletes a single consumer group.</summary>
                    public class DeleteRequest : ManagedKafkaBaseServiceRequest<Google.Apis.ManagedKafka.v1.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the consumer group to delete.
                        /// `projects/{project}/locations/{location}/clusters/{cluster}/consumerGroups/{consumerGroup}`.
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+/consumerGroups/.*$",
                            });
                        }
                    }

                    /// <summary>Returns the properties of a single consumer group.</summary>
                    /// <param name="name">
                    /// Required. The name of the consumer group whose configuration to return.
                    /// `projects/{project}/locations/{location}/clusters/{cluster}/consumerGroups/{consumerGroup}`.
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Returns the properties of a single consumer group.</summary>
                    public class GetRequest : ManagedKafkaBaseServiceRequest<Google.Apis.ManagedKafka.v1.Data.ConsumerGroup>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the consumer group whose configuration to return.
                        /// `projects/{project}/locations/{location}/clusters/{cluster}/consumerGroups/{consumerGroup}`.
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+/consumerGroups/.*$",
                            });
                        }
                    }

                    /// <summary>Lists the consumer groups in a given cluster.</summary>
                    /// <param name="parent">
                    /// Required. The parent cluster whose consumer groups are to be listed. Structured like
                    /// `projects/{project}/locations/{location}/clusters/{cluster}`.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists the consumer groups in a given cluster.</summary>
                    public class ListRequest : ManagedKafkaBaseServiceRequest<Google.Apis.ManagedKafka.v1.Data.ListConsumerGroupsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent cluster whose consumer groups are to be listed. Structured like
                        /// `projects/{project}/locations/{location}/clusters/{cluster}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. The maximum number of consumer groups to return. The service may return fewer than
                        /// this value. If unset or zero, all consumer groups for the parent is returned.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. A page token, received from a previous `ListConsumerGroups` call. Provide this to
                        /// retrieve the subsequent page. When paginating, all other parameters provided to
                        /// `ListConsumerGroups` must match the call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/consumerGroups";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+$",
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

                    /// <summary>Updates the properties of a single consumer group.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Identifier. The name of the consumer group. The `consumer_group` segment is used when connecting
                    /// directly to the cluster. Structured like:
                    /// projects/{project}/locations/{location}/clusters/{cluster}/consumerGroups/{consumer_group}
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.ManagedKafka.v1.Data.ConsumerGroup body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>Updates the properties of a single consumer group.</summary>
                    public class PatchRequest : ManagedKafkaBaseServiceRequest<Google.Apis.ManagedKafka.v1.Data.ConsumerGroup>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.ManagedKafka.v1.Data.ConsumerGroup body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Identifier. The name of the consumer group. The `consumer_group` segment is used when
                        /// connecting directly to the cluster. Structured like:
                        /// projects/{project}/locations/{location}/clusters/{cluster}/consumerGroups/{consumer_group}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Required. Field mask is used to specify the fields to be overwritten in the ConsumerGroup
                        /// resource by the update. The fields specified in the update_mask are relative to the
                        /// resource, not the full request. A field will be overwritten if it is in the mask. The mask
                        /// is required and a value of * will update all fields.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.ManagedKafka.v1.Data.ConsumerGroup Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+/consumerGroups/.*$",
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

                /// <summary>Gets the Topics resource.</summary>
                public virtual TopicsResource Topics { get; }

                /// <summary>The "topics" collection of methods.</summary>
                public class TopicsResource
                {
                    private const string Resource = "topics";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public TopicsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Creates a new topic in a given project and location.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The parent cluster in which to create the topic. Structured like
                    /// `projects/{project}/locations/{location}/clusters/{cluster}`.
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.ManagedKafka.v1.Data.Topic body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>Creates a new topic in a given project and location.</summary>
                    public class CreateRequest : ManagedKafkaBaseServiceRequest<Google.Apis.ManagedKafka.v1.Data.Topic>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.ManagedKafka.v1.Data.Topic body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent cluster in which to create the topic. Structured like
                        /// `projects/{project}/locations/{location}/clusters/{cluster}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. The ID to use for the topic, which will become the final component of the topic's
                        /// name. This value is structured like: `my-topic-name`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("topicId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string TopicId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.ManagedKafka.v1.Data.Topic Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/topics";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+$",
                            });
                            RequestParameters.Add("topicId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "topicId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Deletes a single topic.</summary>
                    /// <param name="name">
                    /// Required. The name of the topic to delete.
                    /// `projects/{project}/locations/{location}/clusters/{cluster}/topics/{topic}`.
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Deletes a single topic.</summary>
                    public class DeleteRequest : ManagedKafkaBaseServiceRequest<Google.Apis.ManagedKafka.v1.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the topic to delete.
                        /// `projects/{project}/locations/{location}/clusters/{cluster}/topics/{topic}`.
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+/topics/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Returns the properties of a single topic.</summary>
                    /// <param name="name">
                    /// Required. The name of the topic whose configuration to return. Structured like:
                    /// projects/{project}/locations/{location}/clusters/{cluster}/topics/{topic}.
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Returns the properties of a single topic.</summary>
                    public class GetRequest : ManagedKafkaBaseServiceRequest<Google.Apis.ManagedKafka.v1.Data.Topic>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the topic whose configuration to return. Structured like:
                        /// projects/{project}/locations/{location}/clusters/{cluster}/topics/{topic}.
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+/topics/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists the topics in a given cluster.</summary>
                    /// <param name="parent">
                    /// Required. The parent cluster whose topics are to be listed. Structured like
                    /// `projects/{project}/locations/{location}/clusters/{cluster}`.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists the topics in a given cluster.</summary>
                    public class ListRequest : ManagedKafkaBaseServiceRequest<Google.Apis.ManagedKafka.v1.Data.ListTopicsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent cluster whose topics are to be listed. Structured like
                        /// `projects/{project}/locations/{location}/clusters/{cluster}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. The maximum number of topics to return. The service may return fewer than this
                        /// value. If unset or zero, all topics for the parent is returned.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. A page token, received from a previous `ListTopics` call. Provide this to retrieve
                        /// the subsequent page. When paginating, all other parameters provided to `ListTopics` must
                        /// match the call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/topics";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+$",
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

                    /// <summary>Updates the properties of a single topic.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Identifier. The name of the topic. The `topic` segment is used when connecting directly to the
                    /// cluster. Structured like:
                    /// projects/{project}/locations/{location}/clusters/{cluster}/topics/{topic}
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.ManagedKafka.v1.Data.Topic body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>Updates the properties of a single topic.</summary>
                    public class PatchRequest : ManagedKafkaBaseServiceRequest<Google.Apis.ManagedKafka.v1.Data.Topic>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.ManagedKafka.v1.Data.Topic body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Identifier. The name of the topic. The `topic` segment is used when connecting directly to
                        /// the cluster. Structured like:
                        /// projects/{project}/locations/{location}/clusters/{cluster}/topics/{topic}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Required. Field mask is used to specify the fields to be overwritten in the Topic resource
                        /// by the update. The fields specified in the update_mask are relative to the resource, not the
                        /// full request. A field will be overwritten if it is in the mask. The mask is required and a
                        /// value of * will update all fields.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.ManagedKafka.v1.Data.Topic Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+/topics/[^/]+$",
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

                /// <summary>Creates a new cluster in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent region in which to create the cluster. Structured like
                /// `projects/{project}/locations/{location}`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.ManagedKafka.v1.Data.Cluster body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new cluster in a given project and location.</summary>
                public class CreateRequest : ManagedKafkaBaseServiceRequest<Google.Apis.ManagedKafka.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.ManagedKafka.v1.Data.Cluster body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent region in which to create the cluster. Structured like
                    /// `projects/{project}/locations/{location}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The ID to use for the cluster, which will become the final component of the cluster's
                    /// name. The ID must be 1-63 characters long, and match the regular expression
                    /// `[a-z]([-a-z0-9]*[a-z0-9])?` to comply with RFC 1035. This value is structured like:
                    /// `my-cluster-id`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("clusterId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ClusterId { get; set; }

                    /// <summary>
                    /// Optional. An optional request ID to identify requests. Specify a unique request ID to avoid
                    /// duplication of requests. If a request times out or fails, retrying with the same ID allows the
                    /// server to recognize the previous attempt. For at least 60 minutes, the server ignores duplicate
                    /// requests bearing the same ID. For example, consider a situation where you make an initial
                    /// request and the request times out. If you make the request again with the same request ID within
                    /// 60 minutes of the last request, the server checks if an original operation with the same request
                    /// ID was received. If so, the server ignores the second request. The request ID must be a valid
                    /// UUID. A zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.ManagedKafka.v1.Data.Cluster Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
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
                    }
                }

                /// <summary>Deletes a single cluster.</summary>
                /// <param name="name">Required. The name of the cluster to delete.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a single cluster.</summary>
                public class DeleteRequest : ManagedKafkaBaseServiceRequest<Google.Apis.ManagedKafka.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the cluster to delete.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. An optional request ID to identify requests. Specify a unique request ID to avoid
                    /// duplication of requests. If a request times out or fails, retrying with the same ID allows the
                    /// server to recognize the previous attempt. For at least 60 minutes, the server ignores duplicate
                    /// requests bearing the same ID. For example, consider a situation where you make an initial
                    /// request and the request times out. If you make the request again with the same request ID within
                    /// 60 minutes of the last request, the server checks if an original operation with the same request
                    /// ID was received. If so, the server ignores the second request. The request ID must be a valid
                    /// UUID. A zero UUID is not supported (00000000-0000-0000-0000-000000000000).
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+$",
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

                /// <summary>Returns the properties of a single cluster.</summary>
                /// <param name="name">Required. The name of the cluster whose configuration to return.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Returns the properties of a single cluster.</summary>
                public class GetRequest : ManagedKafkaBaseServiceRequest<Google.Apis.ManagedKafka.v1.Data.Cluster>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the cluster whose configuration to return.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists the clusters in a given project and location.</summary>
                /// <param name="parent">
                /// Required. The parent location whose clusters are to be listed. Structured like
                /// `projects/{project}/locations/{location}`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists the clusters in a given project and location.</summary>
                public class ListRequest : ManagedKafkaBaseServiceRequest<Google.Apis.ManagedKafka.v1.Data.ListClustersResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent location whose clusters are to be listed. Structured like
                    /// `projects/{project}/locations/{location}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Optional. Filter expression for the result.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Optional. Order by fields for the result.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Optional. The maximum number of clusters to return. The service may return fewer than this
                    /// value. If unspecified, server will pick an appropriate default.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A page token, received from a previous `ListClusters` call. Provide this to retrieve
                    /// the subsequent page. When paginating, all other parameters provided to `ListClusters` must match
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

                /// <summary>Updates the properties of a single cluster.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Identifier. The name of the cluster. Structured like:
                /// projects/{project_number}/locations/{location}/clusters/{cluster_id}
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.ManagedKafka.v1.Data.Cluster body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates the properties of a single cluster.</summary>
                public class PatchRequest : ManagedKafkaBaseServiceRequest<Google.Apis.ManagedKafka.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.ManagedKafka.v1.Data.Cluster body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Identifier. The name of the cluster. Structured like:
                    /// projects/{project_number}/locations/{location}/clusters/{cluster_id}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. An optional request ID to identify requests. Specify a unique request ID to avoid
                    /// duplication of requests. If a request times out or fails, retrying with the same ID allows the
                    /// server to recognize the previous attempt. For at least 60 minutes, the server ignores duplicate
                    /// requests bearing the same ID. For example, consider a situation where you make an initial
                    /// request and the request times out. If you make the request again with the same request ID within
                    /// 60 minutes of the last request, the server checks if an original operation with the same request
                    /// ID was received. If so, the server ignores the second request. The request ID must be a valid
                    /// UUID. A zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// Required. Field mask is used to specify the fields to be overwritten in the cluster resource by
                    /// the update. The fields specified in the update_mask are relative to the resource, not the full
                    /// request. A field will be overwritten if it is in the mask. The mask is required and a value of *
                    /// will update all fields.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.ManagedKafka.v1.Data.Cluster Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+$",
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

            /// <summary>Gets the ConnectClusters resource.</summary>
            public virtual ConnectClustersResource ConnectClusters { get; }

            /// <summary>The "connectClusters" collection of methods.</summary>
            public class ConnectClustersResource
            {
                private const string Resource = "connectClusters";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ConnectClustersResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Connectors = new ConnectorsResource(service);
                }

                /// <summary>Gets the Connectors resource.</summary>
                public virtual ConnectorsResource Connectors { get; }

                /// <summary>The "connectors" collection of methods.</summary>
                public class ConnectorsResource
                {
                    private const string Resource = "connectors";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ConnectorsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Creates a new connector in a given Connect cluster.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The parent Connect cluster in which to create the connector. Structured like
                    /// `projects/{project}/locations/{location}/connectClusters/{connect_cluster_id}`.
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.ManagedKafka.v1.Data.Connector body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>Creates a new connector in a given Connect cluster.</summary>
                    public class CreateRequest : ManagedKafkaBaseServiceRequest<Google.Apis.ManagedKafka.v1.Data.Connector>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.ManagedKafka.v1.Data.Connector body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent Connect cluster in which to create the connector. Structured like
                        /// `projects/{project}/locations/{location}/connectClusters/{connect_cluster_id}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. The ID to use for the connector, which will become the final component of the
                        /// connector's name. The ID must be 1-63 characters long, and match the regular expression
                        /// `[a-z]([-a-z0-9]*[a-z0-9])?` to comply with RFC 1035. This value is structured like:
                        /// `my-connector-id`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("connectorId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string ConnectorId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.ManagedKafka.v1.Data.Connector Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/connectors";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/connectClusters/[^/]+$",
                            });
                            RequestParameters.Add("connectorId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "connectorId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Deletes a connector.</summary>
                    /// <param name="name">
                    /// Required. The name of the connector to delete. Structured like:
                    /// projects/{project}/locations/{location}/connectClusters/{connectCluster}/connectors/{connector}
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Deletes a connector.</summary>
                    public class DeleteRequest : ManagedKafkaBaseServiceRequest<Google.Apis.ManagedKafka.v1.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the connector to delete. Structured like:
                        /// projects/{project}/locations/{location}/connectClusters/{connectCluster}/connectors/{connector}
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/connectClusters/[^/]+/connectors/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Returns the properties of a single connector.</summary>
                    /// <param name="name">
                    /// Required. The name of the connector whose configuration to return. Structured like:
                    /// projects/{project}/locations/{location}/connectClusters/{connectCluster}/connectors/{connector}
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Returns the properties of a single connector.</summary>
                    public class GetRequest : ManagedKafkaBaseServiceRequest<Google.Apis.ManagedKafka.v1.Data.Connector>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the connector whose configuration to return. Structured like:
                        /// projects/{project}/locations/{location}/connectClusters/{connectCluster}/connectors/{connector}
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/connectClusters/[^/]+/connectors/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists the connectors in a given Connect cluster.</summary>
                    /// <param name="parent">
                    /// Required. The parent Connect cluster whose connectors are to be listed. Structured like
                    /// `projects/{project}/locations/{location}/connectClusters/{connect_cluster_id}`.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists the connectors in a given Connect cluster.</summary>
                    public class ListRequest : ManagedKafkaBaseServiceRequest<Google.Apis.ManagedKafka.v1.Data.ListConnectorsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent Connect cluster whose connectors are to be listed. Structured like
                        /// `projects/{project}/locations/{location}/connectClusters/{connect_cluster_id}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. The maximum number of connectors to return. The service may return fewer than this
                        /// value. If unspecified, server will pick an appropriate default.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. A page token, received from a previous `ListConnectors` call. Provide this to
                        /// retrieve the subsequent page. When paginating, all other parameters provided to
                        /// `ListConnectors` must match the call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/connectors";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/connectClusters/[^/]+$",
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

                    /// <summary>Updates the properties of a connector.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Identifier. The name of the connector. Structured like:
                    /// projects/{project}/locations/{location}/connectClusters/{connect_cluster}/connectors/{connector}
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.ManagedKafka.v1.Data.Connector body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>Updates the properties of a connector.</summary>
                    public class PatchRequest : ManagedKafkaBaseServiceRequest<Google.Apis.ManagedKafka.v1.Data.Connector>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.ManagedKafka.v1.Data.Connector body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Identifier. The name of the connector. Structured like:
                        /// projects/{project}/locations/{location}/connectClusters/{connect_cluster}/connectors/{connector}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Required. Field mask is used to specify the fields to be overwritten in the cluster resource
                        /// by the update. The fields specified in the update_mask are relative to the resource, not the
                        /// full request. A field will be overwritten if it is in the mask. The mask is required and a
                        /// value of * will update all fields.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.ManagedKafka.v1.Data.Connector Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/connectClusters/[^/]+/connectors/[^/]+$",
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

                    /// <summary>Pauses the connector and its tasks.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The name of the connector to pause. Structured like:
                    /// projects/{project}/locations/{location}/connectClusters/{connectCluster}/connectors/{connector}
                    /// </param>
                    public virtual PauseRequest Pause(Google.Apis.ManagedKafka.v1.Data.PauseConnectorRequest body, string name)
                    {
                        return new PauseRequest(this.service, body, name);
                    }

                    /// <summary>Pauses the connector and its tasks.</summary>
                    public class PauseRequest : ManagedKafkaBaseServiceRequest<Google.Apis.ManagedKafka.v1.Data.PauseConnectorResponse>
                    {
                        /// <summary>Constructs a new Pause request.</summary>
                        public PauseRequest(Google.Apis.Services.IClientService service, Google.Apis.ManagedKafka.v1.Data.PauseConnectorRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the connector to pause. Structured like:
                        /// projects/{project}/locations/{location}/connectClusters/{connectCluster}/connectors/{connector}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.ManagedKafka.v1.Data.PauseConnectorRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "pause";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:pause";

                        /// <summary>Initializes Pause parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/connectClusters/[^/]+/connectors/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Restarts the connector.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The name of the connector to restart. Structured like:
                    /// projects/{project}/locations/{location}/connectClusters/{connectCluster}/connectors/{connector}
                    /// </param>
                    public virtual RestartRequest Restart(Google.Apis.ManagedKafka.v1.Data.RestartConnectorRequest body, string name)
                    {
                        return new RestartRequest(this.service, body, name);
                    }

                    /// <summary>Restarts the connector.</summary>
                    public class RestartRequest : ManagedKafkaBaseServiceRequest<Google.Apis.ManagedKafka.v1.Data.RestartConnectorResponse>
                    {
                        /// <summary>Constructs a new Restart request.</summary>
                        public RestartRequest(Google.Apis.Services.IClientService service, Google.Apis.ManagedKafka.v1.Data.RestartConnectorRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the connector to restart. Structured like:
                        /// projects/{project}/locations/{location}/connectClusters/{connectCluster}/connectors/{connector}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.ManagedKafka.v1.Data.RestartConnectorRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "restart";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:restart";

                        /// <summary>Initializes Restart parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/connectClusters/[^/]+/connectors/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Resumes the connector and its tasks.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The name of the connector to pause. Structured like:
                    /// projects/{project}/locations/{location}/connectClusters/{connectCluster}/connectors/{connector}
                    /// </param>
                    public virtual ResumeRequest Resume(Google.Apis.ManagedKafka.v1.Data.ResumeConnectorRequest body, string name)
                    {
                        return new ResumeRequest(this.service, body, name);
                    }

                    /// <summary>Resumes the connector and its tasks.</summary>
                    public class ResumeRequest : ManagedKafkaBaseServiceRequest<Google.Apis.ManagedKafka.v1.Data.ResumeConnectorResponse>
                    {
                        /// <summary>Constructs a new Resume request.</summary>
                        public ResumeRequest(Google.Apis.Services.IClientService service, Google.Apis.ManagedKafka.v1.Data.ResumeConnectorRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the connector to pause. Structured like:
                        /// projects/{project}/locations/{location}/connectClusters/{connectCluster}/connectors/{connector}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.ManagedKafka.v1.Data.ResumeConnectorRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "resume";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:resume";

                        /// <summary>Initializes Resume parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/connectClusters/[^/]+/connectors/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Stops the connector.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The name of the connector to stop. Structured like:
                    /// projects/{project}/locations/{location}/connectClusters/{connectCluster}/connectors/{connector}
                    /// </param>
                    public virtual StopRequest Stop(Google.Apis.ManagedKafka.v1.Data.StopConnectorRequest body, string name)
                    {
                        return new StopRequest(this.service, body, name);
                    }

                    /// <summary>Stops the connector.</summary>
                    public class StopRequest : ManagedKafkaBaseServiceRequest<Google.Apis.ManagedKafka.v1.Data.StopConnectorResponse>
                    {
                        /// <summary>Constructs a new Stop request.</summary>
                        public StopRequest(Google.Apis.Services.IClientService service, Google.Apis.ManagedKafka.v1.Data.StopConnectorRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the connector to stop. Structured like:
                        /// projects/{project}/locations/{location}/connectClusters/{connectCluster}/connectors/{connector}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.ManagedKafka.v1.Data.StopConnectorRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "stop";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:stop";

                        /// <summary>Initializes Stop parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/connectClusters/[^/]+/connectors/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>Creates a new Kafka Connect cluster in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent project/location in which to create the Kafka Connect cluster. Structured like
                /// `projects/{project}/locations/{location}/`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.ManagedKafka.v1.Data.ConnectCluster body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new Kafka Connect cluster in a given project and location.</summary>
                public class CreateRequest : ManagedKafkaBaseServiceRequest<Google.Apis.ManagedKafka.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.ManagedKafka.v1.Data.ConnectCluster body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent project/location in which to create the Kafka Connect cluster. Structured
                    /// like `projects/{project}/locations/{location}/`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The ID to use for the Connect cluster, which will become the final component of the
                    /// cluster's name. The ID must be 1-63 characters long, and match the regular expression
                    /// `[a-z]([-a-z0-9]*[a-z0-9])?` to comply with RFC 1035. This value is structured like:
                    /// `my-cluster-id`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("connectClusterId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ConnectClusterId { get; set; }

                    /// <summary>
                    /// Optional. An optional request ID to identify requests. Specify a unique request ID to avoid
                    /// duplication of requests. If a request times out or fails, retrying with the same ID allows the
                    /// server to recognize the previous attempt. For at least 60 minutes, the server ignores duplicate
                    /// requests bearing the same ID. For example, consider a situation where you make an initial
                    /// request and the request times out. If you make the request again with the same request ID within
                    /// 60 minutes of the last request, the server checks if an original operation with the same request
                    /// ID was received. If so, the server ignores the second request. The request ID must be a valid
                    /// UUID. A zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.ManagedKafka.v1.Data.ConnectCluster Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/connectClusters";

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
                        RequestParameters.Add("connectClusterId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "connectClusterId",
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

                /// <summary>Deletes a single Connect cluster.</summary>
                /// <param name="name">
                /// Required. The name of the Kafka Connect cluster to delete. Structured like
                /// `projects/{project}/locations/{location}/connectClusters/{connect_cluster_id}`.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a single Connect cluster.</summary>
                public class DeleteRequest : ManagedKafkaBaseServiceRequest<Google.Apis.ManagedKafka.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the Kafka Connect cluster to delete. Structured like
                    /// `projects/{project}/locations/{location}/connectClusters/{connect_cluster_id}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. An optional request ID to identify requests. Specify a unique request ID to avoid
                    /// duplication of requests. If a request times out or fails, retrying with the same ID allows the
                    /// server to recognize the previous attempt. For at least 60 minutes, the server ignores duplicate
                    /// requests bearing the same ID. For example, consider a situation where you make an initial
                    /// request and the request times out. If you make the request again with the same request ID within
                    /// 60 minutes of the last request, the server checks if an original operation with the same request
                    /// ID was received. If so, the server ignores the second request. The request ID must be a valid
                    /// UUID. A zero UUID is not supported (00000000-0000-0000-0000-000000000000).
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/connectClusters/[^/]+$",
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

                /// <summary>Returns the properties of a single Kafka Connect cluster.</summary>
                /// <param name="name">
                /// Required. The name of the Kafka Connect cluster whose configuration to return. Structured like
                /// `projects/{project}/locations/{location}/connectClusters/{connect_cluster_id}`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Returns the properties of a single Kafka Connect cluster.</summary>
                public class GetRequest : ManagedKafkaBaseServiceRequest<Google.Apis.ManagedKafka.v1.Data.ConnectCluster>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the Kafka Connect cluster whose configuration to return. Structured like
                    /// `projects/{project}/locations/{location}/connectClusters/{connect_cluster_id}`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/connectClusters/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists the Kafka Connect clusters in a given project and location.</summary>
                /// <param name="parent">
                /// Required. The parent project/location whose Connect clusters are to be listed. Structured like
                /// `projects/{project}/locations/{location}`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists the Kafka Connect clusters in a given project and location.</summary>
                public class ListRequest : ManagedKafkaBaseServiceRequest<Google.Apis.ManagedKafka.v1.Data.ListConnectClustersResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent project/location whose Connect clusters are to be listed. Structured like
                    /// `projects/{project}/locations/{location}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Optional. Filter expression for the result.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Optional. Order by fields for the result.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Optional. The maximum number of Connect clusters to return. The service may return fewer than
                    /// this value. If unspecified, server will pick an appropriate default.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A page token, received from a previous `ListConnectClusters` call. Provide this to
                    /// retrieve the subsequent page. When paginating, all other parameters provided to
                    /// `ListConnectClusters` must match the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/connectClusters";

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

                /// <summary>Updates the properties of a single Kafka Connect cluster.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Identifier. The name of the Kafka Connect cluster. Structured like:
                /// projects/{project_number}/locations/{location}/connectClusters/{connect_cluster_id}
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.ManagedKafka.v1.Data.ConnectCluster body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates the properties of a single Kafka Connect cluster.</summary>
                public class PatchRequest : ManagedKafkaBaseServiceRequest<Google.Apis.ManagedKafka.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.ManagedKafka.v1.Data.ConnectCluster body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Identifier. The name of the Kafka Connect cluster. Structured like:
                    /// projects/{project_number}/locations/{location}/connectClusters/{connect_cluster_id}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. An optional request ID to identify requests. Specify a unique request ID to avoid
                    /// duplication of requests. If a request times out or fails, retrying with the same ID allows the
                    /// server to recognize the previous attempt. For at least 60 minutes, the server ignores duplicate
                    /// requests bearing the same ID. For example, consider a situation where you make an initial
                    /// request and the request times out. If you make the request again with the same request ID within
                    /// 60 minutes of the last request, the server checks if an original operation with the same request
                    /// ID was received. If so, the server ignores the second request. The request ID must be a valid
                    /// UUID. A zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// Required. Field mask is used to specify the fields to be overwritten in the cluster resource by
                    /// the update. The fields specified in the update_mask are relative to the resource, not the full
                    /// request. A field will be overwritten if it is in the mask. The mask is required and a value of *
                    /// will update all fields.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.ManagedKafka.v1.Data.ConnectCluster Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/connectClusters/[^/]+$",
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
                /// Operation.error value with a google.rpc.Status.code of `1`, corresponding to `Code.CANCELLED`.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">The name of the operation resource to be cancelled.</param>
                public virtual CancelRequest Cancel(Google.Apis.ManagedKafka.v1.Data.CancelOperationRequest body, string name)
                {
                    return new CancelRequest(this.service, body, name);
                }

                /// <summary>
                /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to
                /// cancel the operation, but success is not guaranteed. If the server doesn't support this method, it
                /// returns `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other methods to
                /// check whether the cancellation succeeded or whether the operation completed despite cancellation. On
                /// successful cancellation, the operation is not deleted; instead, it becomes an operation with an
                /// Operation.error value with a google.rpc.Status.code of `1`, corresponding to `Code.CANCELLED`.
                /// </summary>
                public class CancelRequest : ManagedKafkaBaseServiceRequest<Google.Apis.ManagedKafka.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.ManagedKafka.v1.Data.CancelOperationRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to be cancelled.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.ManagedKafka.v1.Data.CancelOperationRequest Body { get; set; }

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
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>
                /// Deletes a long-running operation. This method indicates that the client is no longer interested in
                /// the operation result. It does not cancel the operation. If the server doesn't support this method,
                /// it returns `google.rpc.Code.UNIMPLEMENTED`.
                /// </summary>
                public class DeleteRequest : ManagedKafkaBaseServiceRequest<Google.Apis.ManagedKafka.v1.Data.Empty>
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
                public class GetRequest : ManagedKafkaBaseServiceRequest<Google.Apis.ManagedKafka.v1.Data.Operation>
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
                public class ListRequest : ManagedKafkaBaseServiceRequest<Google.Apis.ManagedKafka.v1.Data.ListOperationsResponse>
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

            /// <summary>Gets information about a location.</summary>
            /// <param name="name">Resource name for the location.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets information about a location.</summary>
            public class GetRequest : ManagedKafkaBaseServiceRequest<Google.Apis.ManagedKafka.v1.Data.Location>
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
                return new ListRequest(this.service, name);
            }

            /// <summary>Lists information about the supported locations for this service.</summary>
            public class ListRequest : ManagedKafkaBaseServiceRequest<Google.Apis.ManagedKafka.v1.Data.ListLocationsResponse>
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
namespace Google.Apis.ManagedKafka.v1.Data
{
    /// <summary>The configuration of access to the Kafka cluster.</summary>
    public class AccessConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Virtual Private Cloud (VPC) networks that must be granted direct access to the Kafka cluster.
        /// Minimum of 1 network is required. Maximum 10 networks can be specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkConfigs")]
        public virtual System.Collections.Generic.IList<NetworkConfig> NetworkConfigs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents the set of ACLs for a given Kafka Resource Pattern, which consists of resource_type, resource_name
    /// and pattern_type.
    /// </summary>
    public class Acl : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The ACL entries that apply to the resource pattern. The maximum number of allowed entries 100.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aclEntries")]
        public virtual System.Collections.Generic.IList<AclEntry> AclEntries { get; set; }

        /// <summary>
        /// Optional. `etag` is used for concurrency control. An `etag` is returned in the response to `GetAcl` and
        /// `CreateAcl`. Callers are required to put that etag in the request to `UpdateAcl` to ensure that their change
        /// will be applied to the same version of the acl that exists in the Kafka Cluster. A terminal 'T' character in
        /// the etag indicates that the AclEntries were truncated; more entries for the Acl exist on the Kafka Cluster,
        /// but can't be returned in the Acl due to repeated field limits.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Identifier. The name for the acl. Represents a single Resource Pattern. Structured like:
        /// projects/{project}/locations/{location}/clusters/{cluster}/acls/{acl_id} The structure of `acl_id` defines
        /// the Resource Pattern (resource_type, resource_name, pattern_type) of the acl. `acl_id` is structured like
        /// one of the following: For acls on the cluster: `cluster` For acls on a single resource within the cluster:
        /// `topic/{resource_name}` `consumerGroup/{resource_name}` `transactionalId/{resource_name}` For acls on all
        /// resources that match a prefix: `topicPrefixed/{resource_name}` `consumerGroupPrefixed/{resource_name}`
        /// `transactionalIdPrefixed/{resource_name}` For acls on all resources of a given type (i.e. the wildcard
        /// literal "*"): `allTopics` (represents `topic/*`) `allConsumerGroups` (represents `consumerGroup/*`)
        /// `allTransactionalIds` (represents `transactionalId/*`)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The ACL pattern type derived from the name. One of: LITERAL, PREFIXED.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("patternType")]
        public virtual string PatternType { get; set; }

        /// <summary>
        /// Output only. The ACL resource name derived from the name. For cluster resource_type, this is always
        /// "kafka-cluster". Can be the wildcard literal "*".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>
        /// Output only. The ACL resource type derived from the name. One of: CLUSTER, TOPIC, GROUP, TRANSACTIONAL_ID.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceType")]
        public virtual string ResourceType { get; set; }
    }

    /// <summary>Represents the access granted for a given Resource Pattern in an ACL.</summary>
    public class AclEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The host. Must be set to "*" for Managed Service for Apache Kafka.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("host")]
        public virtual string Host { get; set; }

        /// <summary>
        /// Required. The operation type. Allowed values are (case insensitive): ALL, READ, WRITE, CREATE, DELETE,
        /// ALTER, DESCRIBE, CLUSTER_ACTION, DESCRIBE_CONFIGS, ALTER_CONFIGS, and IDEMPOTENT_WRITE. See
        /// https://kafka.apache.org/documentation/#operations_resources_and_protocols for valid combinations of
        /// resource_type and operation for different Kafka API requests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operation")]
        public virtual string Operation { get; set; }

        /// <summary>Required. The permission type. Accepted values are (case insensitive): ALLOW, DENY.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissionType")]
        public virtual string PermissionType { get; set; }

        /// <summary>
        /// Required. The principal. Specified as Google Cloud account, with the Kafka StandardAuthorizer prefix
        /// "User:". For example: "User:test-kafka-client@test-project.iam.gserviceaccount.com". Can be the wildcard
        /// "User:*" to refer to all users.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("principal")]
        public virtual string Principal { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for AddAclEntry.</summary>
    public class AddAclEntryResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The updated acl.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("acl")]
        public virtual Acl Acl { get; set; }

        /// <summary>Whether the acl was created as a result of adding the acl entry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aclCreated")]
        public virtual System.Nullable<bool> AclCreated { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for Operations.CancelOperation.</summary>
    public class CancelOperationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A capacity configuration of a Kafka cluster.</summary>
    public class CapacityConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The memory to provision for the cluster in bytes. The CPU:memory ratio (vCPU:GiB) must be between
        /// 1:1 and 1:8. Minimum: 3221225472 (3 GiB).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memoryBytes")]
        public virtual System.Nullable<long> MemoryBytes { get; set; }

        /// <summary>Required. The number of vCPUs to provision for the cluster. Minimum: 3.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vcpuCount")]
        public virtual System.Nullable<long> VcpuCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An Apache Kafka cluster deployed in a location.</summary>
    public class Cluster : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Capacity configuration for the Kafka cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("capacityConfig")]
        public virtual CapacityConfig CapacityConfig { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time when the cluster was created.</summary>
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

        /// <summary>Required. Configuration properties for a Kafka cluster deployed to Google Cloud Platform.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcpConfig")]
        public virtual GcpConfig GcpConfig { get; set; }

        /// <summary>Optional. Labels as key value pairs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Identifier. The name of the cluster. Structured like:
        /// projects/{project_number}/locations/{location}/clusters/{cluster_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. Rebalance configuration for the Kafka cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rebalanceConfig")]
        public virtual RebalanceConfig RebalanceConfig { get; set; }

        /// <summary>Output only. Reserved for future use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzi")]
        public virtual System.Nullable<bool> SatisfiesPzi { get; set; }

        /// <summary>Output only. Reserved for future use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzs")]
        public virtual System.Nullable<bool> SatisfiesPzs { get; set; }

        /// <summary>Output only. The current state of the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time when the cluster was last updated.</summary>
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

    /// <summary>The configuration of access to the Kafka Connect cluster.</summary>
    public class ConnectAccessConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Virtual Private Cloud (VPC) networks that must be granted direct access to the Kafka Connect
        /// cluster. Minimum of 1 network is required. Maximum 10 networks can be specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkConfigs")]
        public virtual System.Collections.Generic.IList<ConnectNetworkConfig> NetworkConfigs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An Apache Kafka Connect cluster deployed in a location.</summary>
    public class ConnectCluster : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Capacity configuration for the Kafka Connect cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("capacityConfig")]
        public virtual CapacityConfig CapacityConfig { get; set; }

        /// <summary>
        /// Optional. Configurations for the worker that are overridden from the defaults. The key of the map is a Kafka
        /// Connect worker property name, for example: `exactly.once.source.support`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual System.Collections.Generic.IDictionary<string, string> Config { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time when the cluster was created.</summary>
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
        /// Required. Configuration properties for a Kafka Connect cluster deployed to Google Cloud Platform.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcpConfig")]
        public virtual ConnectGcpConfig GcpConfig { get; set; }

        /// <summary>
        /// Required. Immutable. The name of the Kafka cluster this Kafka Connect cluster is attached to. Structured
        /// like: projects/{project}/locations/{location}/clusters/{cluster}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kafkaCluster")]
        public virtual string KafkaCluster { get; set; }

        /// <summary>Optional. Labels as key value pairs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Identifier. The name of the Kafka Connect cluster. Structured like:
        /// projects/{project_number}/locations/{location}/connectClusters/{connect_cluster_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The current state of the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time when the cluster was last updated.</summary>
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

    /// <summary>Configuration properties for a Kafka Connect cluster deployed to Google Cloud Platform.</summary>
    public class ConnectGcpConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Access configuration for the Kafka Connect cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessConfig")]
        public virtual ConnectAccessConfig AccessConfig { get; set; }

        /// <summary>
        /// Optional. Secrets to load into workers. Exact SecretVersions from Secret Manager must be provided -- aliases
        /// are not supported. Up to 32 secrets may be loaded into one cluster. Format: projects//secrets//versions/
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secretPaths")]
        public virtual System.Collections.Generic.IList<string> SecretPaths { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The configuration of a Virtual Private Cloud (VPC) network that can access the Kafka Connect cluster.
    /// </summary>
    public class ConnectNetworkConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Additional subnets may be specified. They may be in another region, but must be in the same VPC
        /// network. The Connect workers can communicate with network endpoints in either the primary or additional
        /// subnets.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalSubnets")]
        public virtual System.Collections.Generic.IList<string> AdditionalSubnets { get; set; }

        /// <summary>
        /// Optional. Additional DNS domain names from the subnet's network to be made visible to the Connect Cluster.
        /// When using MirrorMaker2, it's necessary to add the bootstrap address's dns domain name of the target cluster
        /// to make it visible to the connector. For example:
        /// my-kafka-cluster.us-central1.managedkafka.my-project.cloud.goog
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dnsDomainNames")]
        public virtual System.Collections.Generic.IList<string> DnsDomainNames { get; set; }

        /// <summary>
        /// Required. VPC subnet to make available to the Kafka Connect cluster. Structured like:
        /// projects/{project}/regions/{region}/subnetworks/{subnet_id} It is used to create a Private Service Connect
        /// (PSC) interface for the Kafka Connect workers. It must be located in the same region as the Kafka Connect
        /// cluster. The CIDR range of the subnet must be within the IPv4 address ranges for private networks, as
        /// specified in RFC 1918. The primary subnet CIDR range must have a minimum size of /22 (1024 addresses).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primarySubnet")]
        public virtual string PrimarySubnet { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Kafka Connect connector in a given ConnectCluster.</summary>
    public class Connector : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Connector config as keys/values. The keys of the map are connector property names, for example:
        /// `connector.class`, `tasks.max`, `key.converter`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configs")]
        public virtual System.Collections.Generic.IDictionary<string, string> Configs { get; set; }

        /// <summary>
        /// Identifier. The name of the connector. Structured like:
        /// projects/{project}/locations/{location}/connectClusters/{connect_cluster}/connectors/{connector}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The current state of the connector.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Optional. Restarts the individual tasks of a Connector.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskRestartPolicy")]
        public virtual TaskRetryPolicy TaskRestartPolicy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Kafka consumer group in a given cluster.</summary>
    public class ConsumerGroup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Identifier. The name of the consumer group. The `consumer_group` segment is used when connecting directly to
        /// the cluster. Structured like:
        /// projects/{project}/locations/{location}/clusters/{cluster}/consumerGroups/{consumer_group}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. Metadata for this consumer group for all topics it has metadata for. The key of the map is a topic
        /// name, structured like: projects/{project}/locations/{location}/clusters/{cluster}/topics/{topic}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topics")]
        public virtual System.Collections.Generic.IDictionary<string, ConsumerTopicMetadata> Topics { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for a consumer group corresponding to a specific partition.</summary>
    public class ConsumerPartitionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The associated metadata for this partition, or empty if it does not exist.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual string Metadata { get; set; }

        /// <summary>Required. The current offset for this partition, or 0 if no offset has been committed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offset")]
        public virtual System.Nullable<long> Offset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for a consumer group corresponding to a specific topic.</summary>
    public class ConsumerTopicMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Metadata for this consumer group and topic for all partition indexes it has metadata for.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partitions")]
        public virtual System.Collections.Generic.IDictionary<string, ConsumerPartitionMetadata> Partitions { get; set; }

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

    /// <summary>Configuration properties for a Kafka cluster deployed to Google Cloud Platform.</summary>
    public class GcpConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Access configuration for the Kafka cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessConfig")]
        public virtual AccessConfig AccessConfig { get; set; }

        /// <summary>
        /// Optional. Immutable. The Cloud KMS Key name to use for encryption. The key must be located in the same
        /// region as the cluster and cannot be changed. Structured like:
        /// projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKey")]
        public virtual string KmsKey { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for ListAcls.</summary>
    public class ListAclsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of acls in the requested parent. The order of the acls is unspecified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("acls")]
        public virtual System.Collections.Generic.IList<Acl> Acls { get; set; }

        /// <summary>
        /// A token that can be sent as `page_token` to retrieve the next page of results. If this field is omitted,
        /// there are no more results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for ListClusters.</summary>
    public class ListClustersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of Clusters in the requested parent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusters")]
        public virtual System.Collections.Generic.IList<Cluster> Clusters { get; set; }

        /// <summary>
        /// A token that can be sent as `page_token` to retrieve the next page of results. If this field is omitted,
        /// there are no more results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for ListConnectClusters.</summary>
    public class ListConnectClustersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of Connect clusters in the requested parent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectClusters")]
        public virtual System.Collections.Generic.IList<ConnectCluster> ConnectClusters { get; set; }

        /// <summary>
        /// A token that can be sent as `page_token` to retrieve the next page of results. If this field is omitted,
        /// there are no more results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for ListConnectors.</summary>
    public class ListConnectorsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of connectors in the requested parent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectors")]
        public virtual System.Collections.Generic.IList<Connector> Connectors { get; set; }

        /// <summary>
        /// A token that can be sent as `page_token` to retrieve the next page of results. If this field is omitted,
        /// there are no more results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for ListConsumerGroups.</summary>
    public class ListConsumerGroupsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The list of consumer group in the requested parent. The order of the consumer groups is unspecified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consumerGroups")]
        public virtual System.Collections.Generic.IList<ConsumerGroup> ConsumerGroups { get; set; }

        /// <summary>
        /// A token that can be sent as `page_token` to retrieve the next page of results. If this field is omitted,
        /// there are no more results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

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

    /// <summary>Response for ListTopics.</summary>
    public class ListTopicsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token that can be sent as `page_token` to retrieve the next page of results. If this field is omitted,
        /// there are no more results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of topics in the requested parent. The order of the topics is unspecified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topics")]
        public virtual System.Collections.Generic.IList<Topic> Topics { get; set; }

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

    /// <summary>The configuration of a Virtual Private Cloud (VPC) network that can access the Kafka cluster.</summary>
    public class NetworkConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Name of the VPC subnet in which to create Private Service Connect (PSC) endpoints for the Kafka
        /// brokers and bootstrap address. Structured like: projects/{project}/regions/{region}/subnetworks/{subnet_id}
        /// The subnet must be located in the same region as the Kafka cluster. The project may differ. Multiple subnets
        /// from the same parent network must not be specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subnet")]
        public virtual string Subnet { get; set; }

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
        /// Output only. Identifies whether the user has requested cancellation of the operation. Operations that have
        /// been cancelled successfully have Operation.error value with a google.rpc.Status.code of 1, corresponding to
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

        /// <summary>Output only. Name of the verb executed by the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verb")]
        public virtual string Verb { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for PauseConnector.</summary>
    public class PauseConnectorRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for PauseConnector.</summary>
    public class PauseConnectorResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines rebalancing behavior of a Kafka cluster.</summary>
    public class RebalanceConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The rebalance behavior for the cluster. When not specified, defaults to `NO_REBALANCE`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mode")]
        public virtual string Mode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for RemoveAclEntry.</summary>
    public class RemoveAclEntryResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The updated acl. Returned if the removed acl entry was not the last entry in the acl.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("acl")]
        public virtual Acl Acl { get; set; }

        /// <summary>
        /// Returned with value true if the removed acl entry was the last entry in the acl, resulting in acl deletion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aclDeleted")]
        public virtual System.Nullable<bool> AclDeleted { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for RestartConnector.</summary>
    public class RestartConnectorRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for RestartConnector.</summary>
    public class RestartConnectorResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for ResumeConnector.</summary>
    public class ResumeConnectorRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for ResumeConnector.</summary>
    public class ResumeConnectorResponse : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>Request for StopConnector.</summary>
    public class StopConnectorRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for StopConnector.</summary>
    public class StopConnectorResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Task Retry Policy is implemented on a best-effort basis. Retry delay will be exponential based on provided
    /// minimum and maximum backoffs. https://en.wikipedia.org/wiki/Exponential_backoff. Note that the delay between
    /// consecutive task restarts may not always precisely match the configured settings. This can happen when the
    /// ConnectCluster is in rebalancing state or if the ConnectCluster is unresponsive etc. The default values for
    /// minimum and maximum backoffs are 60 seconds and 30 minutes respectively.
    /// </summary>
    public class TaskRetryPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The maximum amount of time to wait before retrying a failed task. This sets an upper bound for the
        /// backoff delay.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maximumBackoff")]
        public virtual object MaximumBackoff { get; set; }

        /// <summary>
        /// Optional. The minimum amount of time to wait before retrying a failed task. This sets a lower bound for the
        /// backoff delay.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minimumBackoff")]
        public virtual object MinimumBackoff { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Kafka topic in a given cluster.</summary>
    public class Topic : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Configurations for the topic that are overridden from the cluster defaults. The key of the map is
        /// a Kafka topic property name, for example: `cleanup.policy`, `compression.type`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configs")]
        public virtual System.Collections.Generic.IDictionary<string, string> Configs { get; set; }

        /// <summary>
        /// Identifier. The name of the topic. The `topic` segment is used when connecting directly to the cluster.
        /// Structured like: projects/{project}/locations/{location}/clusters/{cluster}/topics/{topic}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. The number of partitions this topic has. The partition count can only be increased, not decreased.
        /// Please note that if partitions are increased for a topic that has a key, the partitioning logic or the
        /// ordering of the messages will be affected.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partitionCount")]
        public virtual System.Nullable<int> PartitionCount { get; set; }

        /// <summary>
        /// Required. Immutable. The number of replicas of each partition. A replication factor of 3 is recommended for
        /// high availability.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replicationFactor")]
        public virtual System.Nullable<int> ReplicationFactor { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
