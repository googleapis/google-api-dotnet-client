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

namespace Google.Apis.Pubsub.v1
{
    /// <summary>The Pubsub Service.</summary>
    public class PubsubService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public PubsubService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public PubsubService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://pubsub.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://pubsub.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "pubsub";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Pub/Sub API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>View and manage Pub/Sub topics and subscriptions</summary>
            public static string Pubsub = "https://www.googleapis.com/auth/pubsub";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Pub/Sub API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>View and manage Pub/Sub topics and subscriptions</summary>
            public const string Pubsub = "https://www.googleapis.com/auth/pubsub";
        }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for Pubsub requests.</summary>
    public abstract class PubsubBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new PubsubBaseServiceRequest instance.</summary>
        protected PubsubBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Pubsub parameter list.</summary>
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
            Schemas = new SchemasResource(service);
            Snapshots = new SnapshotsResource(service);
            Subscriptions = new SubscriptionsResource(service);
            Topics = new TopicsResource(service);
        }

        /// <summary>Gets the Schemas resource.</summary>
        public virtual SchemasResource Schemas { get; }

        /// <summary>The "schemas" collection of methods.</summary>
        public class SchemasResource
        {
            private const string Resource = "schemas";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public SchemasResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Commits a new schema revision to an existing schema.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The name of the schema we are revising. Format is `projects/{project}/schemas/{schema}`.
            /// </param>
            public virtual CommitRequest Commit(Google.Apis.Pubsub.v1.Data.CommitSchemaRequest body, string name)
            {
                return new CommitRequest(this.service, body, name);
            }

            /// <summary>Commits a new schema revision to an existing schema.</summary>
            public class CommitRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.Schema>
            {
                /// <summary>Constructs a new Commit request.</summary>
                public CommitRequest(Google.Apis.Services.IClientService service, Google.Apis.Pubsub.v1.Data.CommitSchemaRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the schema we are revising. Format is `projects/{project}/schemas/{schema}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Pubsub.v1.Data.CommitSchemaRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "commit";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:commit";

                /// <summary>Initializes Commit parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/schemas/[^/]+$",
                    });
                }
            }

            /// <summary>Creates a schema.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The name of the project in which to create the schema. Format is `projects/{project-id}`.
            /// </param>
            public virtual CreateRequest Create(Google.Apis.Pubsub.v1.Data.Schema body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>Creates a schema.</summary>
            public class CreateRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.Schema>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Pubsub.v1.Data.Schema body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the project in which to create the schema. Format is `projects/{project-id}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The ID to use for the schema, which will become the final component of the schema's resource name.
                /// See https://cloud.google.com/pubsub/docs/pubsub-basics#resource_names for resource name constraints.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("schemaId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string SchemaId { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Pubsub.v1.Data.Schema Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/schemas";

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
                    RequestParameters.Add("schemaId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "schemaId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Deletes a schema.</summary>
            /// <param name="name">
            /// Required. Name of the schema to delete. Format is `projects/{project}/schemas/{schema}`.
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>Deletes a schema.</summary>
            public class DeleteRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of the schema to delete. Format is `projects/{project}/schemas/{schema}`.
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
                        Pattern = @"^projects/[^/]+/schemas/[^/]+$",
                    });
                }
            }

            /// <summary>Deletes a specific schema revision.</summary>
            /// <param name="name">
            /// Required. The name of the schema revision to be deleted, with a revision ID explicitly included.
            /// Example: `projects/123/schemas/my-schema@c7cfa2a8`
            /// </param>
            public virtual DeleteRevisionRequest DeleteRevision(string name)
            {
                return new DeleteRevisionRequest(this.service, name);
            }

            /// <summary>Deletes a specific schema revision.</summary>
            public class DeleteRevisionRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.Schema>
            {
                /// <summary>Constructs a new DeleteRevision request.</summary>
                public DeleteRevisionRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the schema revision to be deleted, with a revision ID explicitly included.
                /// Example: `projects/123/schemas/my-schema@c7cfa2a8`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Optional. This field is deprecated and should not be used for specifying the revision ID. The
                /// revision ID should be specified via the `name` parameter.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("revisionId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string RevisionId { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "deleteRevision";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:deleteRevision";

                /// <summary>Initializes DeleteRevision parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/schemas/[^/]+$",
                    });
                    RequestParameters.Add("revisionId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "revisionId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Gets a schema.</summary>
            /// <param name="name">
            /// Required. The name of the schema to get. Format is `projects/{project}/schemas/{schema}`.
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets a schema.</summary>
            public class GetRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.Schema>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the schema to get. Format is `projects/{project}/schemas/{schema}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// The set of fields to return in the response. If not set, returns a Schema with all fields filled
                /// out. Set to `BASIC` to omit the `definition`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<ViewEnum> View { get; set; }

                /// <summary>
                /// The set of fields to return in the response. If not set, returns a Schema with all fields filled
                /// out. Set to `BASIC` to omit the `definition`.
                /// </summary>
                public enum ViewEnum
                {
                    /// <summary>The default / unset value. The API will default to the BASIC view.</summary>
                    [Google.Apis.Util.StringValueAttribute("SCHEMA_VIEW_UNSPECIFIED")]
                    SCHEMAVIEWUNSPECIFIED = 0,

                    /// <summary>Include the name and type of the schema, but not the definition.</summary>
                    [Google.Apis.Util.StringValueAttribute("BASIC")]
                    BASIC = 1,

                    /// <summary>Include all Schema object fields.</summary>
                    [Google.Apis.Util.StringValueAttribute("FULL")]
                    FULL = 2,
                }

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
                        Pattern = @"^projects/[^/]+/schemas/[^/]+$",
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

            /// <summary>
            /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and does
            /// not have a policy set.
            /// </summary>
            /// <param name="resource">
            /// REQUIRED: The resource for which the policy is being requested. See [Resource
            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
            /// </param>
            public virtual GetIamPolicyRequest GetIamPolicy(string resource)
            {
                return new GetIamPolicyRequest(this.service, resource);
            }

            /// <summary>
            /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and does
            /// not have a policy set.
            /// </summary>
            public class GetIamPolicyRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.Policy>
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
                /// Optional. The maximum policy version that will be used to format the policy. Valid values are 0, 1,
                /// and 3. Requests specifying an invalid value will be rejected. Requests for policies with any
                /// conditional role bindings must specify version 3. Policies with no conditional role bindings may
                /// specify any valid value or leave the field unset. The policy in the response might use the policy
                /// version that you specified, or it might use a lower policy version. For example, if you specify
                /// version 3, but the policy has no conditional role bindings, the response uses version 1. To learn
                /// which resources support conditions in their IAM policies, see the [IAM
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
                        Pattern = @"^projects/[^/]+/schemas/[^/]+$",
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

            /// <summary>Lists schemas in a project.</summary>
            /// <param name="parent">
            /// Required. The name of the project in which to list schemas. Format is `projects/{project-id}`.
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Lists schemas in a project.</summary>
            public class ListRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.ListSchemasResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the project in which to list schemas. Format is `projects/{project-id}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Maximum number of schemas to return.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// The value returned by the last `ListSchemasResponse`; indicates that this is a continuation of a
                /// prior `ListSchemas` call, and that the system should return the next page of data.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>
                /// The set of Schema fields to return in the response. If not set, returns Schemas with `name` and
                /// `type`, but not `definition`. Set to `FULL` to retrieve all fields.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<ViewEnum> View { get; set; }

                /// <summary>
                /// The set of Schema fields to return in the response. If not set, returns Schemas with `name` and
                /// `type`, but not `definition`. Set to `FULL` to retrieve all fields.
                /// </summary>
                public enum ViewEnum
                {
                    /// <summary>The default / unset value. The API will default to the BASIC view.</summary>
                    [Google.Apis.Util.StringValueAttribute("SCHEMA_VIEW_UNSPECIFIED")]
                    SCHEMAVIEWUNSPECIFIED = 0,

                    /// <summary>Include the name and type of the schema, but not the definition.</summary>
                    [Google.Apis.Util.StringValueAttribute("BASIC")]
                    BASIC = 1,

                    /// <summary>Include all Schema object fields.</summary>
                    [Google.Apis.Util.StringValueAttribute("FULL")]
                    FULL = 2,
                }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/schemas";

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

            /// <summary>Lists all schema revisions for the named schema.</summary>
            /// <param name="name">Required. The name of the schema to list revisions for.</param>
            public virtual ListRevisionsRequest ListRevisions(string name)
            {
                return new ListRevisionsRequest(this.service, name);
            }

            /// <summary>Lists all schema revisions for the named schema.</summary>
            public class ListRevisionsRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.ListSchemaRevisionsResponse>
            {
                /// <summary>Constructs a new ListRevisions request.</summary>
                public ListRevisionsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. The name of the schema to list revisions for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>The maximum number of revisions to return per page.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// The page token, received from a previous ListSchemaRevisions call. Provide this to retrieve the
                /// subsequent page.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>
                /// The set of Schema fields to return in the response. If not set, returns Schemas with `name` and
                /// `type`, but not `definition`. Set to `FULL` to retrieve all fields.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<ViewEnum> View { get; set; }

                /// <summary>
                /// The set of Schema fields to return in the response. If not set, returns Schemas with `name` and
                /// `type`, but not `definition`. Set to `FULL` to retrieve all fields.
                /// </summary>
                public enum ViewEnum
                {
                    /// <summary>The default / unset value. The API will default to the BASIC view.</summary>
                    [Google.Apis.Util.StringValueAttribute("SCHEMA_VIEW_UNSPECIFIED")]
                    SCHEMAVIEWUNSPECIFIED = 0,

                    /// <summary>Include the name and type of the schema, but not the definition.</summary>
                    [Google.Apis.Util.StringValueAttribute("BASIC")]
                    BASIC = 1,

                    /// <summary>Include all Schema object fields.</summary>
                    [Google.Apis.Util.StringValueAttribute("FULL")]
                    FULL = 2,
                }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "listRevisions";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:listRevisions";

                /// <summary>Initializes ListRevisions parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/schemas/[^/]+$",
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

            /// <summary>Creates a new schema revision that is a copy of the provided revision_id.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Required. The schema being rolled back with revision id.</param>
            public virtual RollbackRequest Rollback(Google.Apis.Pubsub.v1.Data.RollbackSchemaRequest body, string name)
            {
                return new RollbackRequest(this.service, body, name);
            }

            /// <summary>Creates a new schema revision that is a copy of the provided revision_id.</summary>
            public class RollbackRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.Schema>
            {
                /// <summary>Constructs a new Rollback request.</summary>
                public RollbackRequest(Google.Apis.Services.IClientService service, Google.Apis.Pubsub.v1.Data.RollbackSchemaRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The schema being rolled back with revision id.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Pubsub.v1.Data.RollbackSchemaRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "rollback";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:rollback";

                /// <summary>Initializes Rollback parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/schemas/[^/]+$",
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
            public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.Pubsub.v1.Data.SetIamPolicyRequest body, string resource)
            {
                return new SetIamPolicyRequest(this.service, body, resource);
            }

            /// <summary>
            /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
            /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
            /// </summary>
            public class SetIamPolicyRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.Policy>
            {
                /// <summary>Constructs a new SetIamPolicy request.</summary>
                public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.Pubsub.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                Google.Apis.Pubsub.v1.Data.SetIamPolicyRequest Body { get; set; }

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
                        Pattern = @"^projects/[^/]+/schemas/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Returns permissions that a caller has on the specified resource. If the resource does not exist, this
            /// will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is designed to be
            /// used for building permission-aware UIs and command-line tools, not for authorization checking. This
            /// operation may "fail open" without warning.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="resource">
            /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
            /// </param>
            public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.Pubsub.v1.Data.TestIamPermissionsRequest body, string resource)
            {
                return new TestIamPermissionsRequest(this.service, body, resource);
            }

            /// <summary>
            /// Returns permissions that a caller has on the specified resource. If the resource does not exist, this
            /// will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is designed to be
            /// used for building permission-aware UIs and command-line tools, not for authorization checking. This
            /// operation may "fail open" without warning.
            /// </summary>
            public class TestIamPermissionsRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.TestIamPermissionsResponse>
            {
                /// <summary>Constructs a new TestIamPermissions request.</summary>
                public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.Pubsub.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                Google.Apis.Pubsub.v1.Data.TestIamPermissionsRequest Body { get; set; }

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
                        Pattern = @"^projects/[^/]+/schemas/[^/]+$",
                    });
                }
            }

            /// <summary>Validates a schema.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The name of the project in which to validate schemas. Format is `projects/{project-id}`.
            /// </param>
            public virtual ValidateRequest Validate(Google.Apis.Pubsub.v1.Data.ValidateSchemaRequest body, string parent)
            {
                return new ValidateRequest(this.service, body, parent);
            }

            /// <summary>Validates a schema.</summary>
            public class ValidateRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.ValidateSchemaResponse>
            {
                /// <summary>Constructs a new Validate request.</summary>
                public ValidateRequest(Google.Apis.Services.IClientService service, Google.Apis.Pubsub.v1.Data.ValidateSchemaRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the project in which to validate schemas. Format is `projects/{project-id}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Pubsub.v1.Data.ValidateSchemaRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "validate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/schemas:validate";

                /// <summary>Initializes Validate parameter list.</summary>
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
                }
            }

            /// <summary>Validates a message against a schema.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The name of the project in which to validate schemas. Format is `projects/{project-id}`.
            /// </param>
            public virtual ValidateMessageRequest ValidateMessage(Google.Apis.Pubsub.v1.Data.ValidateMessageRequest body, string parent)
            {
                return new ValidateMessageRequest(this.service, body, parent);
            }

            /// <summary>Validates a message against a schema.</summary>
            public class ValidateMessageRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.ValidateMessageResponse>
            {
                /// <summary>Constructs a new ValidateMessage request.</summary>
                public ValidateMessageRequest(Google.Apis.Services.IClientService service, Google.Apis.Pubsub.v1.Data.ValidateMessageRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the project in which to validate schemas. Format is `projects/{project-id}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Pubsub.v1.Data.ValidateMessageRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "validateMessage";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/schemas:validateMessage";

                /// <summary>Initializes ValidateMessage parameter list.</summary>
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
                }
            }
        }

        /// <summary>Gets the Snapshots resource.</summary>
        public virtual SnapshotsResource Snapshots { get; }

        /// <summary>The "snapshots" collection of methods.</summary>
        public class SnapshotsResource
        {
            private const string Resource = "snapshots";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public SnapshotsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Creates a snapshot from the requested subscription. Snapshots are used in
            /// [Seek](https://cloud.google.com/pubsub/docs/replay-overview) operations, which allow you to manage
            /// message acknowledgments in bulk. That is, you can set the acknowledgment state of messages in an
            /// existing subscription to the state captured by a snapshot. If the snapshot already exists, returns
            /// `ALREADY_EXISTS`. If the requested subscription doesn't exist, returns `NOT_FOUND`. If the backlog in
            /// the subscription is too old -- and the resulting snapshot would expire in less than 1 hour -- then
            /// `FAILED_PRECONDITION` is returned. See also the `Snapshot.expire_time` field. If the name is not
            /// provided in the request, the server will assign a random name for this snapshot on the same project as
            /// the subscription, conforming to the [resource name format]
            /// (https://cloud.google.com/pubsub/docs/pubsub-basics#resource_names). The generated name is populated in
            /// the returned Snapshot object. Note that for REST API requests, you must specify a name in the request.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. User-provided name for this snapshot. If the name is not provided in the request, the server
            /// will assign a random name for this snapshot on the same project as the subscription. Note that for REST
            /// API requests, you must specify a name. See the [resource name
            /// rules](https://cloud.google.com/pubsub/docs/pubsub-basics#resource_names). Format is
            /// `projects/{project}/snapshots/{snap}`.
            /// </param>
            public virtual CreateRequest Create(Google.Apis.Pubsub.v1.Data.CreateSnapshotRequest body, string name)
            {
                return new CreateRequest(this.service, body, name);
            }

            /// <summary>
            /// Creates a snapshot from the requested subscription. Snapshots are used in
            /// [Seek](https://cloud.google.com/pubsub/docs/replay-overview) operations, which allow you to manage
            /// message acknowledgments in bulk. That is, you can set the acknowledgment state of messages in an
            /// existing subscription to the state captured by a snapshot. If the snapshot already exists, returns
            /// `ALREADY_EXISTS`. If the requested subscription doesn't exist, returns `NOT_FOUND`. If the backlog in
            /// the subscription is too old -- and the resulting snapshot would expire in less than 1 hour -- then
            /// `FAILED_PRECONDITION` is returned. See also the `Snapshot.expire_time` field. If the name is not
            /// provided in the request, the server will assign a random name for this snapshot on the same project as
            /// the subscription, conforming to the [resource name format]
            /// (https://cloud.google.com/pubsub/docs/pubsub-basics#resource_names). The generated name is populated in
            /// the returned Snapshot object. Note that for REST API requests, you must specify a name in the request.
            /// </summary>
            public class CreateRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.Snapshot>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Pubsub.v1.Data.CreateSnapshotRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. User-provided name for this snapshot. If the name is not provided in the request, the
                /// server will assign a random name for this snapshot on the same project as the subscription. Note
                /// that for REST API requests, you must specify a name. See the [resource name
                /// rules](https://cloud.google.com/pubsub/docs/pubsub-basics#resource_names). Format is
                /// `projects/{project}/snapshots/{snap}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Pubsub.v1.Data.CreateSnapshotRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/snapshots/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Removes an existing snapshot. Snapshots are used in [Seek]
            /// (https://cloud.google.com/pubsub/docs/replay-overview) operations, which allow you to manage message
            /// acknowledgments in bulk. That is, you can set the acknowledgment state of messages in an existing
            /// subscription to the state captured by a snapshot. When the snapshot is deleted, all messages retained in
            /// the snapshot are immediately dropped. After a snapshot is deleted, a new one may be created with the
            /// same name, but the new one has no association with the old snapshot or its subscription, unless the same
            /// subscription is specified.
            /// </summary>
            /// <param name="snapshot">
            /// Required. The name of the snapshot to delete. Format is `projects/{project}/snapshots/{snap}`.
            /// </param>
            public virtual DeleteRequest Delete(string snapshot)
            {
                return new DeleteRequest(this.service, snapshot);
            }

            /// <summary>
            /// Removes an existing snapshot. Snapshots are used in [Seek]
            /// (https://cloud.google.com/pubsub/docs/replay-overview) operations, which allow you to manage message
            /// acknowledgments in bulk. That is, you can set the acknowledgment state of messages in an existing
            /// subscription to the state captured by a snapshot. When the snapshot is deleted, all messages retained in
            /// the snapshot are immediately dropped. After a snapshot is deleted, a new one may be created with the
            /// same name, but the new one has no association with the old snapshot or its subscription, unless the same
            /// subscription is specified.
            /// </summary>
            public class DeleteRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string snapshot) : base(service)
                {
                    Snapshot = snapshot;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the snapshot to delete. Format is `projects/{project}/snapshots/{snap}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("snapshot", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Snapshot { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+snapshot}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("snapshot", new Google.Apis.Discovery.Parameter
                    {
                        Name = "snapshot",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/snapshots/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Gets the configuration details of a snapshot. Snapshots are used in
            /// [Seek](https://cloud.google.com/pubsub/docs/replay-overview) operations, which allow you to manage
            /// message acknowledgments in bulk. That is, you can set the acknowledgment state of messages in an
            /// existing subscription to the state captured by a snapshot.
            /// </summary>
            /// <param name="snapshot">
            /// Required. The name of the snapshot to get. Format is `projects/{project}/snapshots/{snap}`.
            /// </param>
            public virtual GetRequest Get(string snapshot)
            {
                return new GetRequest(this.service, snapshot);
            }

            /// <summary>
            /// Gets the configuration details of a snapshot. Snapshots are used in
            /// [Seek](https://cloud.google.com/pubsub/docs/replay-overview) operations, which allow you to manage
            /// message acknowledgments in bulk. That is, you can set the acknowledgment state of messages in an
            /// existing subscription to the state captured by a snapshot.
            /// </summary>
            public class GetRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.Snapshot>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string snapshot) : base(service)
                {
                    Snapshot = snapshot;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the snapshot to get. Format is `projects/{project}/snapshots/{snap}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("snapshot", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Snapshot { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+snapshot}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("snapshot", new Google.Apis.Discovery.Parameter
                    {
                        Name = "snapshot",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/snapshots/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and does
            /// not have a policy set.
            /// </summary>
            /// <param name="resource">
            /// REQUIRED: The resource for which the policy is being requested. See [Resource
            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
            /// </param>
            public virtual GetIamPolicyRequest GetIamPolicy(string resource)
            {
                return new GetIamPolicyRequest(this.service, resource);
            }

            /// <summary>
            /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and does
            /// not have a policy set.
            /// </summary>
            public class GetIamPolicyRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.Policy>
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
                /// Optional. The maximum policy version that will be used to format the policy. Valid values are 0, 1,
                /// and 3. Requests specifying an invalid value will be rejected. Requests for policies with any
                /// conditional role bindings must specify version 3. Policies with no conditional role bindings may
                /// specify any valid value or leave the field unset. The policy in the response might use the policy
                /// version that you specified, or it might use a lower policy version. For example, if you specify
                /// version 3, but the policy has no conditional role bindings, the response uses version 1. To learn
                /// which resources support conditions in their IAM policies, see the [IAM
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
                        Pattern = @"^projects/[^/]+/snapshots/[^/]+$",
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

            /// <summary>
            /// Lists the existing snapshots. Snapshots are used in [Seek](
            /// https://cloud.google.com/pubsub/docs/replay-overview) operations, which allow you to manage message
            /// acknowledgments in bulk. That is, you can set the acknowledgment state of messages in an existing
            /// subscription to the state captured by a snapshot.
            /// </summary>
            /// <param name="project">
            /// Required. The name of the project in which to list snapshots. Format is `projects/{project-id}`.
            /// </param>
            public virtual ListRequest List(string project)
            {
                return new ListRequest(this.service, project);
            }

            /// <summary>
            /// Lists the existing snapshots. Snapshots are used in [Seek](
            /// https://cloud.google.com/pubsub/docs/replay-overview) operations, which allow you to manage message
            /// acknowledgments in bulk. That is, you can set the acknowledgment state of messages in an existing
            /// subscription to the state captured by a snapshot.
            /// </summary>
            public class ListRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.ListSnapshotsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string project) : base(service)
                {
                    Project = project;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the project in which to list snapshots. Format is `projects/{project-id}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Project { get; private set; }

                /// <summary>Optional. Maximum number of snapshots to return.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. The value returned by the last `ListSnapshotsResponse`; indicates that this is a
                /// continuation of a prior `ListSnapshots` call, and that the system should return the next page of
                /// data.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+project}/snapshots";

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

            /// <summary>
            /// Updates an existing snapshot by updating the fields specified in the update mask. Snapshots are used in
            /// [Seek](https://cloud.google.com/pubsub/docs/replay-overview) operations, which allow you to manage
            /// message acknowledgments in bulk. That is, you can set the acknowledgment state of messages in an
            /// existing subscription to the state captured by a snapshot.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Optional. The name of the snapshot.</param>
            public virtual PatchRequest Patch(Google.Apis.Pubsub.v1.Data.UpdateSnapshotRequest body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>
            /// Updates an existing snapshot by updating the fields specified in the update mask. Snapshots are used in
            /// [Seek](https://cloud.google.com/pubsub/docs/replay-overview) operations, which allow you to manage
            /// message acknowledgments in bulk. That is, you can set the acknowledgment state of messages in an
            /// existing subscription to the state captured by a snapshot.
            /// </summary>
            public class PatchRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.Snapshot>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Pubsub.v1.Data.UpdateSnapshotRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Optional. The name of the snapshot.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Pubsub.v1.Data.UpdateSnapshotRequest Body { get; set; }

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
                        Pattern = @"^projects/[^/]+/snapshots/[^/]+$",
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
            public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.Pubsub.v1.Data.SetIamPolicyRequest body, string resource)
            {
                return new SetIamPolicyRequest(this.service, body, resource);
            }

            /// <summary>
            /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
            /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
            /// </summary>
            public class SetIamPolicyRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.Policy>
            {
                /// <summary>Constructs a new SetIamPolicy request.</summary>
                public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.Pubsub.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                Google.Apis.Pubsub.v1.Data.SetIamPolicyRequest Body { get; set; }

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
                        Pattern = @"^projects/[^/]+/snapshots/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Returns permissions that a caller has on the specified resource. If the resource does not exist, this
            /// will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is designed to be
            /// used for building permission-aware UIs and command-line tools, not for authorization checking. This
            /// operation may "fail open" without warning.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="resource">
            /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
            /// </param>
            public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.Pubsub.v1.Data.TestIamPermissionsRequest body, string resource)
            {
                return new TestIamPermissionsRequest(this.service, body, resource);
            }

            /// <summary>
            /// Returns permissions that a caller has on the specified resource. If the resource does not exist, this
            /// will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is designed to be
            /// used for building permission-aware UIs and command-line tools, not for authorization checking. This
            /// operation may "fail open" without warning.
            /// </summary>
            public class TestIamPermissionsRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.TestIamPermissionsResponse>
            {
                /// <summary>Constructs a new TestIamPermissions request.</summary>
                public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.Pubsub.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                Google.Apis.Pubsub.v1.Data.TestIamPermissionsRequest Body { get; set; }

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
                        Pattern = @"^projects/[^/]+/snapshots/[^/]+$",
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

            /// <summary>
            /// Acknowledges the messages associated with the `ack_ids` in the `AcknowledgeRequest`. The Pub/Sub system
            /// can remove the relevant messages from the subscription. Acknowledging a message whose ack deadline has
            /// expired may succeed, but such a message may be redelivered later. Acknowledging a message more than once
            /// will not result in an error.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="subscription">
            /// Required. The subscription whose message is being acknowledged. Format is
            /// `projects/{project}/subscriptions/{sub}`.
            /// </param>
            public virtual AcknowledgeRequest Acknowledge(Google.Apis.Pubsub.v1.Data.AcknowledgeRequest body, string subscription)
            {
                return new AcknowledgeRequest(this.service, body, subscription);
            }

            /// <summary>
            /// Acknowledges the messages associated with the `ack_ids` in the `AcknowledgeRequest`. The Pub/Sub system
            /// can remove the relevant messages from the subscription. Acknowledging a message whose ack deadline has
            /// expired may succeed, but such a message may be redelivered later. Acknowledging a message more than once
            /// will not result in an error.
            /// </summary>
            public class AcknowledgeRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.Empty>
            {
                /// <summary>Constructs a new Acknowledge request.</summary>
                public AcknowledgeRequest(Google.Apis.Services.IClientService service, Google.Apis.Pubsub.v1.Data.AcknowledgeRequest body, string subscription) : base(service)
                {
                    Subscription = subscription;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The subscription whose message is being acknowledged. Format is
                /// `projects/{project}/subscriptions/{sub}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("subscription", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Subscription { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Pubsub.v1.Data.AcknowledgeRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "acknowledge";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+subscription}:acknowledge";

                /// <summary>Initializes Acknowledge parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("subscription", new Google.Apis.Discovery.Parameter
                    {
                        Name = "subscription",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/subscriptions/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Creates a subscription to a given topic. See the [resource name rules]
            /// (https://cloud.google.com/pubsub/docs/pubsub-basics#resource_names). If the subscription already exists,
            /// returns `ALREADY_EXISTS`. If the corresponding topic doesn't exist, returns `NOT_FOUND`. If the name is
            /// not provided in the request, the server will assign a random name for this subscription on the same
            /// project as the topic, conforming to the [resource name format]
            /// (https://cloud.google.com/pubsub/docs/pubsub-basics#resource_names). The generated name is populated in
            /// the returned Subscription object. Note that for REST API requests, you must specify a name in the
            /// request.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The name of the subscription. It must have the format
            /// `"projects/{project}/subscriptions/{subscription}"`. `{subscription}` must start with a letter, and
            /// contain only letters (`[A-Za-z]`), numbers (`[0-9]`), dashes (`-`), underscores (`_`), periods (`.`),
            /// tildes (`~`), plus (`+`) or percent signs (`%`). It must be between 3 and 255 characters in length, and
            /// it must not start with `"goog"`.
            /// </param>
            public virtual CreateRequest Create(Google.Apis.Pubsub.v1.Data.Subscription body, string name)
            {
                return new CreateRequest(this.service, body, name);
            }

            /// <summary>
            /// Creates a subscription to a given topic. See the [resource name rules]
            /// (https://cloud.google.com/pubsub/docs/pubsub-basics#resource_names). If the subscription already exists,
            /// returns `ALREADY_EXISTS`. If the corresponding topic doesn't exist, returns `NOT_FOUND`. If the name is
            /// not provided in the request, the server will assign a random name for this subscription on the same
            /// project as the topic, conforming to the [resource name format]
            /// (https://cloud.google.com/pubsub/docs/pubsub-basics#resource_names). The generated name is populated in
            /// the returned Subscription object. Note that for REST API requests, you must specify a name in the
            /// request.
            /// </summary>
            public class CreateRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.Subscription>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Pubsub.v1.Data.Subscription body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the subscription. It must have the format
                /// `"projects/{project}/subscriptions/{subscription}"`. `{subscription}` must start with a letter, and
                /// contain only letters (`[A-Za-z]`), numbers (`[0-9]`), dashes (`-`), underscores (`_`), periods
                /// (`.`), tildes (`~`), plus (`+`) or percent signs (`%`). It must be between 3 and 255 characters in
                /// length, and it must not start with `"goog"`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Pubsub.v1.Data.Subscription Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/subscriptions/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Deletes an existing subscription. All messages retained in the subscription are immediately dropped.
            /// Calls to `Pull` after deletion will return `NOT_FOUND`. After a subscription is deleted, a new one may
            /// be created with the same name, but the new one has no association with the old subscription or its topic
            /// unless the same topic is specified.
            /// </summary>
            /// <param name="subscription">
            /// Required. The subscription to delete. Format is `projects/{project}/subscriptions/{sub}`.
            /// </param>
            public virtual DeleteRequest Delete(string subscription)
            {
                return new DeleteRequest(this.service, subscription);
            }

            /// <summary>
            /// Deletes an existing subscription. All messages retained in the subscription are immediately dropped.
            /// Calls to `Pull` after deletion will return `NOT_FOUND`. After a subscription is deleted, a new one may
            /// be created with the same name, but the new one has no association with the old subscription or its topic
            /// unless the same topic is specified.
            /// </summary>
            public class DeleteRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string subscription) : base(service)
                {
                    Subscription = subscription;
                    InitParameters();
                }

                /// <summary>
                /// Required. The subscription to delete. Format is `projects/{project}/subscriptions/{sub}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("subscription", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Subscription { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+subscription}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("subscription", new Google.Apis.Discovery.Parameter
                    {
                        Name = "subscription",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/subscriptions/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Detaches a subscription from this topic. All messages retained in the subscription are dropped.
            /// Subsequent `Pull` and `StreamingPull` requests will return FAILED_PRECONDITION. If the subscription is a
            /// push subscription, pushes to the endpoint will stop.
            /// </summary>
            /// <param name="subscription">
            /// Required. The subscription to detach. Format is `projects/{project}/subscriptions/{subscription}`.
            /// </param>
            public virtual DetachRequest Detach(string subscription)
            {
                return new DetachRequest(this.service, subscription);
            }

            /// <summary>
            /// Detaches a subscription from this topic. All messages retained in the subscription are dropped.
            /// Subsequent `Pull` and `StreamingPull` requests will return FAILED_PRECONDITION. If the subscription is a
            /// push subscription, pushes to the endpoint will stop.
            /// </summary>
            public class DetachRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.DetachSubscriptionResponse>
            {
                /// <summary>Constructs a new Detach request.</summary>
                public DetachRequest(Google.Apis.Services.IClientService service, string subscription) : base(service)
                {
                    Subscription = subscription;
                    InitParameters();
                }

                /// <summary>
                /// Required. The subscription to detach. Format is `projects/{project}/subscriptions/{subscription}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("subscription", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Subscription { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "detach";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+subscription}:detach";

                /// <summary>Initializes Detach parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("subscription", new Google.Apis.Discovery.Parameter
                    {
                        Name = "subscription",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/subscriptions/[^/]+$",
                    });
                }
            }

            /// <summary>Gets the configuration details of a subscription.</summary>
            /// <param name="subscription">
            /// Required. The name of the subscription to get. Format is `projects/{project}/subscriptions/{sub}`.
            /// </param>
            public virtual GetRequest Get(string subscription)
            {
                return new GetRequest(this.service, subscription);
            }

            /// <summary>Gets the configuration details of a subscription.</summary>
            public class GetRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.Subscription>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string subscription) : base(service)
                {
                    Subscription = subscription;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the subscription to get. Format is `projects/{project}/subscriptions/{sub}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("subscription", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Subscription { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+subscription}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("subscription", new Google.Apis.Discovery.Parameter
                    {
                        Name = "subscription",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/subscriptions/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and does
            /// not have a policy set.
            /// </summary>
            /// <param name="resource">
            /// REQUIRED: The resource for which the policy is being requested. See [Resource
            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
            /// </param>
            public virtual GetIamPolicyRequest GetIamPolicy(string resource)
            {
                return new GetIamPolicyRequest(this.service, resource);
            }

            /// <summary>
            /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and does
            /// not have a policy set.
            /// </summary>
            public class GetIamPolicyRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.Policy>
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
                /// Optional. The maximum policy version that will be used to format the policy. Valid values are 0, 1,
                /// and 3. Requests specifying an invalid value will be rejected. Requests for policies with any
                /// conditional role bindings must specify version 3. Policies with no conditional role bindings may
                /// specify any valid value or leave the field unset. The policy in the response might use the policy
                /// version that you specified, or it might use a lower policy version. For example, if you specify
                /// version 3, but the policy has no conditional role bindings, the response uses version 1. To learn
                /// which resources support conditions in their IAM policies, see the [IAM
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
                        Pattern = @"^projects/[^/]+/subscriptions/[^/]+$",
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

            /// <summary>Lists matching subscriptions.</summary>
            /// <param name="project">
            /// Required. The name of the project in which to list subscriptions. Format is `projects/{project-id}`.
            /// </param>
            public virtual ListRequest List(string project)
            {
                return new ListRequest(this.service, project);
            }

            /// <summary>Lists matching subscriptions.</summary>
            public class ListRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.ListSubscriptionsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string project) : base(service)
                {
                    Project = project;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the project in which to list subscriptions. Format is `projects/{project-id}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Project { get; private set; }

                /// <summary>Optional. Maximum number of subscriptions to return.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. The value returned by the last `ListSubscriptionsResponse`; indicates that this is a
                /// continuation of a prior `ListSubscriptions` call, and that the system should return the next page of
                /// data.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+project}/subscriptions";

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

            /// <summary>
            /// Modifies the ack deadline for a specific message. This method is useful to indicate that more time is
            /// needed to process a message by the subscriber, or to make the message available for redelivery if the
            /// processing was interrupted. Note that this does not modify the subscription-level `ackDeadlineSeconds`
            /// used for subsequent messages.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="subscription">
            /// Required. The name of the subscription. Format is `projects/{project}/subscriptions/{sub}`.
            /// </param>
            public virtual ModifyAckDeadlineRequest ModifyAckDeadline(Google.Apis.Pubsub.v1.Data.ModifyAckDeadlineRequest body, string subscription)
            {
                return new ModifyAckDeadlineRequest(this.service, body, subscription);
            }

            /// <summary>
            /// Modifies the ack deadline for a specific message. This method is useful to indicate that more time is
            /// needed to process a message by the subscriber, or to make the message available for redelivery if the
            /// processing was interrupted. Note that this does not modify the subscription-level `ackDeadlineSeconds`
            /// used for subsequent messages.
            /// </summary>
            public class ModifyAckDeadlineRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.Empty>
            {
                /// <summary>Constructs a new ModifyAckDeadline request.</summary>
                public ModifyAckDeadlineRequest(Google.Apis.Services.IClientService service, Google.Apis.Pubsub.v1.Data.ModifyAckDeadlineRequest body, string subscription) : base(service)
                {
                    Subscription = subscription;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the subscription. Format is `projects/{project}/subscriptions/{sub}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("subscription", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Subscription { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Pubsub.v1.Data.ModifyAckDeadlineRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "modifyAckDeadline";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+subscription}:modifyAckDeadline";

                /// <summary>Initializes ModifyAckDeadline parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("subscription", new Google.Apis.Discovery.Parameter
                    {
                        Name = "subscription",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/subscriptions/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Modifies the `PushConfig` for a specified subscription. This may be used to change a push subscription
            /// to a pull one (signified by an empty `PushConfig`) or vice versa, or change the endpoint URL and other
            /// attributes of a push subscription. Messages will accumulate for delivery continuously through the call
            /// regardless of changes to the `PushConfig`.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="subscription">
            /// Required. The name of the subscription. Format is `projects/{project}/subscriptions/{sub}`.
            /// </param>
            public virtual ModifyPushConfigRequest ModifyPushConfig(Google.Apis.Pubsub.v1.Data.ModifyPushConfigRequest body, string subscription)
            {
                return new ModifyPushConfigRequest(this.service, body, subscription);
            }

            /// <summary>
            /// Modifies the `PushConfig` for a specified subscription. This may be used to change a push subscription
            /// to a pull one (signified by an empty `PushConfig`) or vice versa, or change the endpoint URL and other
            /// attributes of a push subscription. Messages will accumulate for delivery continuously through the call
            /// regardless of changes to the `PushConfig`.
            /// </summary>
            public class ModifyPushConfigRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.Empty>
            {
                /// <summary>Constructs a new ModifyPushConfig request.</summary>
                public ModifyPushConfigRequest(Google.Apis.Services.IClientService service, Google.Apis.Pubsub.v1.Data.ModifyPushConfigRequest body, string subscription) : base(service)
                {
                    Subscription = subscription;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the subscription. Format is `projects/{project}/subscriptions/{sub}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("subscription", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Subscription { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Pubsub.v1.Data.ModifyPushConfigRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "modifyPushConfig";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+subscription}:modifyPushConfig";

                /// <summary>Initializes ModifyPushConfig parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("subscription", new Google.Apis.Discovery.Parameter
                    {
                        Name = "subscription",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/subscriptions/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Updates an existing subscription by updating the fields specified in the update mask. Note that certain
            /// properties of a subscription, such as its topic, are not modifiable.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The name of the subscription. It must have the format
            /// `"projects/{project}/subscriptions/{subscription}"`. `{subscription}` must start with a letter, and
            /// contain only letters (`[A-Za-z]`), numbers (`[0-9]`), dashes (`-`), underscores (`_`), periods (`.`),
            /// tildes (`~`), plus (`+`) or percent signs (`%`). It must be between 3 and 255 characters in length, and
            /// it must not start with `"goog"`.
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.Pubsub.v1.Data.UpdateSubscriptionRequest body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>
            /// Updates an existing subscription by updating the fields specified in the update mask. Note that certain
            /// properties of a subscription, such as its topic, are not modifiable.
            /// </summary>
            public class PatchRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.Subscription>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Pubsub.v1.Data.UpdateSubscriptionRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the subscription. It must have the format
                /// `"projects/{project}/subscriptions/{subscription}"`. `{subscription}` must start with a letter, and
                /// contain only letters (`[A-Za-z]`), numbers (`[0-9]`), dashes (`-`), underscores (`_`), periods
                /// (`.`), tildes (`~`), plus (`+`) or percent signs (`%`). It must be between 3 and 255 characters in
                /// length, and it must not start with `"goog"`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Pubsub.v1.Data.UpdateSubscriptionRequest Body { get; set; }

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
                        Pattern = @"^projects/[^/]+/subscriptions/[^/]+$",
                    });
                }
            }

            /// <summary>Pulls messages from the server.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="subscription">
            /// Required. The subscription from which messages should be pulled. Format is
            /// `projects/{project}/subscriptions/{sub}`.
            /// </param>
            public virtual PullRequest Pull(Google.Apis.Pubsub.v1.Data.PullRequest body, string subscription)
            {
                return new PullRequest(this.service, body, subscription);
            }

            /// <summary>Pulls messages from the server.</summary>
            public class PullRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.PullResponse>
            {
                /// <summary>Constructs a new Pull request.</summary>
                public PullRequest(Google.Apis.Services.IClientService service, Google.Apis.Pubsub.v1.Data.PullRequest body, string subscription) : base(service)
                {
                    Subscription = subscription;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The subscription from which messages should be pulled. Format is
                /// `projects/{project}/subscriptions/{sub}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("subscription", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Subscription { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Pubsub.v1.Data.PullRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "pull";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+subscription}:pull";

                /// <summary>Initializes Pull parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("subscription", new Google.Apis.Discovery.Parameter
                    {
                        Name = "subscription",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/subscriptions/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Seeks an existing subscription to a point in time or to a given snapshot, whichever is provided in the
            /// request. Snapshots are used in [Seek] (https://cloud.google.com/pubsub/docs/replay-overview) operations,
            /// which allow you to manage message acknowledgments in bulk. That is, you can set the acknowledgment state
            /// of messages in an existing subscription to the state captured by a snapshot. Note that both the
            /// subscription and the snapshot must be on the same topic.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="subscription">Required. The subscription to affect.</param>
            public virtual SeekRequest Seek(Google.Apis.Pubsub.v1.Data.SeekRequest body, string subscription)
            {
                return new SeekRequest(this.service, body, subscription);
            }

            /// <summary>
            /// Seeks an existing subscription to a point in time or to a given snapshot, whichever is provided in the
            /// request. Snapshots are used in [Seek] (https://cloud.google.com/pubsub/docs/replay-overview) operations,
            /// which allow you to manage message acknowledgments in bulk. That is, you can set the acknowledgment state
            /// of messages in an existing subscription to the state captured by a snapshot. Note that both the
            /// subscription and the snapshot must be on the same topic.
            /// </summary>
            public class SeekRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.SeekResponse>
            {
                /// <summary>Constructs a new Seek request.</summary>
                public SeekRequest(Google.Apis.Services.IClientService service, Google.Apis.Pubsub.v1.Data.SeekRequest body, string subscription) : base(service)
                {
                    Subscription = subscription;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The subscription to affect.</summary>
                [Google.Apis.Util.RequestParameterAttribute("subscription", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Subscription { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Pubsub.v1.Data.SeekRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "seek";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+subscription}:seek";

                /// <summary>Initializes Seek parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("subscription", new Google.Apis.Discovery.Parameter
                    {
                        Name = "subscription",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/subscriptions/[^/]+$",
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
            public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.Pubsub.v1.Data.SetIamPolicyRequest body, string resource)
            {
                return new SetIamPolicyRequest(this.service, body, resource);
            }

            /// <summary>
            /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
            /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
            /// </summary>
            public class SetIamPolicyRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.Policy>
            {
                /// <summary>Constructs a new SetIamPolicy request.</summary>
                public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.Pubsub.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                Google.Apis.Pubsub.v1.Data.SetIamPolicyRequest Body { get; set; }

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
                        Pattern = @"^projects/[^/]+/subscriptions/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Returns permissions that a caller has on the specified resource. If the resource does not exist, this
            /// will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is designed to be
            /// used for building permission-aware UIs and command-line tools, not for authorization checking. This
            /// operation may "fail open" without warning.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="resource">
            /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
            /// </param>
            public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.Pubsub.v1.Data.TestIamPermissionsRequest body, string resource)
            {
                return new TestIamPermissionsRequest(this.service, body, resource);
            }

            /// <summary>
            /// Returns permissions that a caller has on the specified resource. If the resource does not exist, this
            /// will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is designed to be
            /// used for building permission-aware UIs and command-line tools, not for authorization checking. This
            /// operation may "fail open" without warning.
            /// </summary>
            public class TestIamPermissionsRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.TestIamPermissionsResponse>
            {
                /// <summary>Constructs a new TestIamPermissions request.</summary>
                public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.Pubsub.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                Google.Apis.Pubsub.v1.Data.TestIamPermissionsRequest Body { get; set; }

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
                        Pattern = @"^projects/[^/]+/subscriptions/[^/]+$",
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
                Snapshots = new SnapshotsResource(service);
                Subscriptions = new SubscriptionsResource(service);
            }

            /// <summary>Gets the Snapshots resource.</summary>
            public virtual SnapshotsResource Snapshots { get; }

            /// <summary>The "snapshots" collection of methods.</summary>
            public class SnapshotsResource
            {
                private const string Resource = "snapshots";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public SnapshotsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Lists the names of the snapshots on this topic. Snapshots are used in
                /// [Seek](https://cloud.google.com/pubsub/docs/replay-overview) operations, which allow you to manage
                /// message acknowledgments in bulk. That is, you can set the acknowledgment state of messages in an
                /// existing subscription to the state captured by a snapshot.
                /// </summary>
                /// <param name="topic">
                /// Required. The name of the topic that snapshots are attached to. Format is
                /// `projects/{project}/topics/{topic}`.
                /// </param>
                public virtual ListRequest List(string topic)
                {
                    return new ListRequest(this.service, topic);
                }

                /// <summary>
                /// Lists the names of the snapshots on this topic. Snapshots are used in
                /// [Seek](https://cloud.google.com/pubsub/docs/replay-overview) operations, which allow you to manage
                /// message acknowledgments in bulk. That is, you can set the acknowledgment state of messages in an
                /// existing subscription to the state captured by a snapshot.
                /// </summary>
                public class ListRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.ListTopicSnapshotsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string topic) : base(service)
                    {
                        Topic = topic;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the topic that snapshots are attached to. Format is
                    /// `projects/{project}/topics/{topic}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("topic", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Topic { get; private set; }

                    /// <summary>Optional. Maximum number of snapshot names to return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. The value returned by the last `ListTopicSnapshotsResponse`; indicates that this is a
                    /// continuation of a prior `ListTopicSnapshots` call, and that the system should return the next
                    /// page of data.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+topic}/snapshots";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("topic", new Google.Apis.Discovery.Parameter
                        {
                            Name = "topic",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/topics/[^/]+$",
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

                /// <summary>Lists the names of the attached subscriptions on this topic.</summary>
                /// <param name="topic">
                /// Required. The name of the topic that subscriptions are attached to. Format is
                /// `projects/{project}/topics/{topic}`.
                /// </param>
                public virtual ListRequest List(string topic)
                {
                    return new ListRequest(this.service, topic);
                }

                /// <summary>Lists the names of the attached subscriptions on this topic.</summary>
                public class ListRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.ListTopicSubscriptionsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string topic) : base(service)
                    {
                        Topic = topic;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the topic that subscriptions are attached to. Format is
                    /// `projects/{project}/topics/{topic}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("topic", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Topic { get; private set; }

                    /// <summary>Optional. Maximum number of subscription names to return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. The value returned by the last `ListTopicSubscriptionsResponse`; indicates that this
                    /// is a continuation of a prior `ListTopicSubscriptions` call, and that the system should return
                    /// the next page of data.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+topic}/subscriptions";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("topic", new Google.Apis.Discovery.Parameter
                        {
                            Name = "topic",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/topics/[^/]+$",
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
            /// Creates the given topic with the given name. See the [resource name rules]
            /// (https://cloud.google.com/pubsub/docs/pubsub-basics#resource_names).
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The name of the topic. It must have the format `"projects/{project}/topics/{topic}"`.
            /// `{topic}` must start with a letter, and contain only letters (`[A-Za-z]`), numbers (`[0-9]`), dashes
            /// (`-`), underscores (`_`), periods (`.`), tildes (`~`), plus (`+`) or percent signs (`%`). It must be
            /// between 3 and 255 characters in length, and it must not start with `"goog"`.
            /// </param>
            public virtual CreateRequest Create(Google.Apis.Pubsub.v1.Data.Topic body, string name)
            {
                return new CreateRequest(this.service, body, name);
            }

            /// <summary>
            /// Creates the given topic with the given name. See the [resource name rules]
            /// (https://cloud.google.com/pubsub/docs/pubsub-basics#resource_names).
            /// </summary>
            public class CreateRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.Topic>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Pubsub.v1.Data.Topic body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the topic. It must have the format `"projects/{project}/topics/{topic}"`.
                /// `{topic}` must start with a letter, and contain only letters (`[A-Za-z]`), numbers (`[0-9]`), dashes
                /// (`-`), underscores (`_`), periods (`.`), tildes (`~`), plus (`+`) or percent signs (`%`). It must be
                /// between 3 and 255 characters in length, and it must not start with `"goog"`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Pubsub.v1.Data.Topic Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/topics/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Deletes the topic with the given name. Returns `NOT_FOUND` if the topic does not exist. After a topic is
            /// deleted, a new topic may be created with the same name; this is an entirely new topic with none of the
            /// old configuration or subscriptions. Existing subscriptions to this topic are not deleted, but their
            /// `topic` field is set to `_deleted-topic_`.
            /// </summary>
            /// <param name="topic">
            /// Required. Name of the topic to delete. Format is `projects/{project}/topics/{topic}`.
            /// </param>
            public virtual DeleteRequest Delete(string topic)
            {
                return new DeleteRequest(this.service, topic);
            }

            /// <summary>
            /// Deletes the topic with the given name. Returns `NOT_FOUND` if the topic does not exist. After a topic is
            /// deleted, a new topic may be created with the same name; this is an entirely new topic with none of the
            /// old configuration or subscriptions. Existing subscriptions to this topic are not deleted, but their
            /// `topic` field is set to `_deleted-topic_`.
            /// </summary>
            public class DeleteRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string topic) : base(service)
                {
                    Topic = topic;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of the topic to delete. Format is `projects/{project}/topics/{topic}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("topic", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Topic { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+topic}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("topic", new Google.Apis.Discovery.Parameter
                    {
                        Name = "topic",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/topics/[^/]+$",
                    });
                }
            }

            /// <summary>Gets the configuration of a topic.</summary>
            /// <param name="topic">
            /// Required. The name of the topic to get. Format is `projects/{project}/topics/{topic}`.
            /// </param>
            public virtual GetRequest Get(string topic)
            {
                return new GetRequest(this.service, topic);
            }

            /// <summary>Gets the configuration of a topic.</summary>
            public class GetRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.Topic>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string topic) : base(service)
                {
                    Topic = topic;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the topic to get. Format is `projects/{project}/topics/{topic}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("topic", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Topic { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+topic}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("topic", new Google.Apis.Discovery.Parameter
                    {
                        Name = "topic",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/topics/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and does
            /// not have a policy set.
            /// </summary>
            /// <param name="resource">
            /// REQUIRED: The resource for which the policy is being requested. See [Resource
            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
            /// </param>
            public virtual GetIamPolicyRequest GetIamPolicy(string resource)
            {
                return new GetIamPolicyRequest(this.service, resource);
            }

            /// <summary>
            /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and does
            /// not have a policy set.
            /// </summary>
            public class GetIamPolicyRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.Policy>
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
                /// Optional. The maximum policy version that will be used to format the policy. Valid values are 0, 1,
                /// and 3. Requests specifying an invalid value will be rejected. Requests for policies with any
                /// conditional role bindings must specify version 3. Policies with no conditional role bindings may
                /// specify any valid value or leave the field unset. The policy in the response might use the policy
                /// version that you specified, or it might use a lower policy version. For example, if you specify
                /// version 3, but the policy has no conditional role bindings, the response uses version 1. To learn
                /// which resources support conditions in their IAM policies, see the [IAM
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
                        Pattern = @"^projects/[^/]+/topics/[^/]+$",
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

            /// <summary>Lists matching topics.</summary>
            /// <param name="project">
            /// Required. The name of the project in which to list topics. Format is `projects/{project-id}`.
            /// </param>
            public virtual ListRequest List(string project)
            {
                return new ListRequest(this.service, project);
            }

            /// <summary>Lists matching topics.</summary>
            public class ListRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.ListTopicsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string project) : base(service)
                {
                    Project = project;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the project in which to list topics. Format is `projects/{project-id}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Project { get; private set; }

                /// <summary>Optional. Maximum number of topics to return.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. The value returned by the last `ListTopicsResponse`; indicates that this is a continuation
                /// of a prior `ListTopics` call, and that the system should return the next page of data.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+project}/topics";

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

            /// <summary>
            /// Updates an existing topic by updating the fields specified in the update mask. Note that certain
            /// properties of a topic are not modifiable.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The name of the topic. It must have the format `"projects/{project}/topics/{topic}"`.
            /// `{topic}` must start with a letter, and contain only letters (`[A-Za-z]`), numbers (`[0-9]`), dashes
            /// (`-`), underscores (`_`), periods (`.`), tildes (`~`), plus (`+`) or percent signs (`%`). It must be
            /// between 3 and 255 characters in length, and it must not start with `"goog"`.
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.Pubsub.v1.Data.UpdateTopicRequest body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>
            /// Updates an existing topic by updating the fields specified in the update mask. Note that certain
            /// properties of a topic are not modifiable.
            /// </summary>
            public class PatchRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.Topic>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Pubsub.v1.Data.UpdateTopicRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the topic. It must have the format `"projects/{project}/topics/{topic}"`.
                /// `{topic}` must start with a letter, and contain only letters (`[A-Za-z]`), numbers (`[0-9]`), dashes
                /// (`-`), underscores (`_`), periods (`.`), tildes (`~`), plus (`+`) or percent signs (`%`). It must be
                /// between 3 and 255 characters in length, and it must not start with `"goog"`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Pubsub.v1.Data.UpdateTopicRequest Body { get; set; }

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
                        Pattern = @"^projects/[^/]+/topics/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Adds one or more messages to the topic. Returns `NOT_FOUND` if the topic does not exist.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="topic">
            /// Required. The messages in the request will be published on this topic. Format is
            /// `projects/{project}/topics/{topic}`.
            /// </param>
            public virtual PublishRequest Publish(Google.Apis.Pubsub.v1.Data.PublishRequest body, string topic)
            {
                return new PublishRequest(this.service, body, topic);
            }

            /// <summary>
            /// Adds one or more messages to the topic. Returns `NOT_FOUND` if the topic does not exist.
            /// </summary>
            public class PublishRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.PublishResponse>
            {
                /// <summary>Constructs a new Publish request.</summary>
                public PublishRequest(Google.Apis.Services.IClientService service, Google.Apis.Pubsub.v1.Data.PublishRequest body, string topic) : base(service)
                {
                    Topic = topic;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The messages in the request will be published on this topic. Format is
                /// `projects/{project}/topics/{topic}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("topic", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Topic { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Pubsub.v1.Data.PublishRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "publish";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+topic}:publish";

                /// <summary>Initializes Publish parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("topic", new Google.Apis.Discovery.Parameter
                    {
                        Name = "topic",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/topics/[^/]+$",
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
            public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.Pubsub.v1.Data.SetIamPolicyRequest body, string resource)
            {
                return new SetIamPolicyRequest(this.service, body, resource);
            }

            /// <summary>
            /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
            /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
            /// </summary>
            public class SetIamPolicyRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.Policy>
            {
                /// <summary>Constructs a new SetIamPolicy request.</summary>
                public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.Pubsub.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                Google.Apis.Pubsub.v1.Data.SetIamPolicyRequest Body { get; set; }

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
                        Pattern = @"^projects/[^/]+/topics/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Returns permissions that a caller has on the specified resource. If the resource does not exist, this
            /// will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is designed to be
            /// used for building permission-aware UIs and command-line tools, not for authorization checking. This
            /// operation may "fail open" without warning.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="resource">
            /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
            /// </param>
            public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.Pubsub.v1.Data.TestIamPermissionsRequest body, string resource)
            {
                return new TestIamPermissionsRequest(this.service, body, resource);
            }

            /// <summary>
            /// Returns permissions that a caller has on the specified resource. If the resource does not exist, this
            /// will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is designed to be
            /// used for building permission-aware UIs and command-line tools, not for authorization checking. This
            /// operation may "fail open" without warning.
            /// </summary>
            public class TestIamPermissionsRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.TestIamPermissionsResponse>
            {
                /// <summary>Constructs a new TestIamPermissions request.</summary>
                public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.Pubsub.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                Google.Apis.Pubsub.v1.Data.TestIamPermissionsRequest Body { get; set; }

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
                        Pattern = @"^projects/[^/]+/topics/[^/]+$",
                    });
                }
            }
        }
    }
}
namespace Google.Apis.Pubsub.v1.Data
{
    /// <summary>Request for the Acknowledge method.</summary>
    public class AcknowledgeRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The acknowledgment ID for the messages being acknowledged that was returned by the Pub/Sub system
        /// in the `Pull` response. Must not be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ackIds")]
        public virtual System.Collections.Generic.IList<string> AckIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Information about an associated [Analytics Hub
    /// subscription](https://cloud.google.com/bigquery/docs/analytics-hub-manage-subscriptions).
    /// </summary>
    public class AnalyticsHubSubscriptionInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The name of the associated Analytics Hub listing resource. Pattern:
        /// "projects/{project}/locations/{location}/dataExchanges/{data_exchange}/listings/{listing}"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listing")]
        public virtual string Listing { get; set; }

        /// <summary>
        /// Optional. The name of the associated Analytics Hub subscription resource. Pattern:
        /// "projects/{project}/locations/{location}/subscriptions/{subscription}"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscription")]
        public virtual string Subscription { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configuration for writing message data in Avro format. Message payloads and metadata will be written to files as
    /// an Avro binary.
    /// </summary>
    public class AvroConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. When true, the output Cloud Storage file will be serialized using the topic schema, if it exists.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useTopicSchema")]
        public virtual System.Nullable<bool> UseTopicSchema { get; set; }

        /// <summary>
        /// Optional. When true, write the subscription name, message_id, publish_time, attributes, and ordering_key as
        /// additional fields in the output. The subscription name, message_id, and publish_time fields are put in their
        /// own fields while all other message properties other than data (for example, an ordering_key, if present) are
        /// added as entries in the attributes map.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("writeMetadata")]
        public virtual System.Nullable<bool> WriteMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configuration for reading Cloud Storage data in Avro binary format. The bytes of each object will be set to the
    /// `data` field of a Pub/Sub message.
    /// </summary>
    public class AvroFormat : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Ingestion settings for Amazon Kinesis Data Streams.</summary>
    public class AwsKinesis : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. AWS role ARN to be used for Federated Identity authentication with Kinesis. Check the Pub/Sub docs
        /// for how to set up this role and the required permissions that need to be attached to it.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("awsRoleArn")]
        public virtual string AwsRoleArn { get; set; }

        /// <summary>
        /// Required. The Kinesis consumer ARN to used for ingestion in Enhanced Fan-Out mode. The consumer must be
        /// already created and ready to be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consumerArn")]
        public virtual string ConsumerArn { get; set; }

        /// <summary>
        /// Required. The GCP service account to be used for Federated Identity authentication with Kinesis (via a
        /// `AssumeRoleWithWebIdentity` call for the provided role). The `aws_role_arn` must be set up with
        /// `accounts.google.com:sub` equals to this service account number.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcpServiceAccount")]
        public virtual string GcpServiceAccount { get; set; }

        /// <summary>
        /// Output only. An output-only field that indicates the state of the Kinesis ingestion source.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Required. The Kinesis stream ARN to ingest data from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("streamArn")]
        public virtual string StreamArn { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Ingestion settings for Amazon MSK.</summary>
    public class AwsMsk : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. AWS role ARN to be used for Federated Identity authentication with Amazon MSK. Check the Pub/Sub
        /// docs for how to set up this role and the required permissions that need to be attached to it.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("awsRoleArn")]
        public virtual string AwsRoleArn { get; set; }

        /// <summary>Required. The Amazon Resource Name (ARN) that uniquely identifies the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterArn")]
        public virtual string ClusterArn { get; set; }

        /// <summary>
        /// Required. The GCP service account to be used for Federated Identity authentication with Amazon MSK (via a
        /// `AssumeRoleWithWebIdentity` call for the provided role). The `aws_role_arn` must be set up with
        /// `accounts.google.com:sub` equals to this service account number.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcpServiceAccount")]
        public virtual string GcpServiceAccount { get; set; }

        /// <summary>
        /// Output only. An output-only field that indicates the state of the Amazon MSK ingestion source.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Required. The name of the topic in the Amazon MSK cluster that Pub/Sub will import from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topic")]
        public virtual string Topic { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Ingestion settings for Azure Event Hubs.</summary>
    public class AzureEventHubs : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The client id of the Azure application that is being used to authenticate Pub/Sub.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientId")]
        public virtual string ClientId { get; set; }

        /// <summary>Optional. The name of the Event Hub.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventHub")]
        public virtual string EventHub { get; set; }

        /// <summary>Optional. The GCP service account to be used for Federated Identity authentication.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcpServiceAccount")]
        public virtual string GcpServiceAccount { get; set; }

        /// <summary>Optional. The name of the Event Hubs namespace.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namespace")]
        public virtual string Namespace__ { get; set; }

        /// <summary>Optional. Name of the resource group within the azure subscription.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceGroup")]
        public virtual string ResourceGroup { get; set; }

        /// <summary>
        /// Output only. An output-only field that indicates the state of the Event Hubs ingestion source.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Optional. The Azure subscription id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscriptionId")]
        public virtual string SubscriptionId { get; set; }

        /// <summary>
        /// Optional. The tenant id of the Azure application that is being used to authenticate Pub/Sub.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tenantId")]
        public virtual string TenantId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for a BigQuery subscription.</summary>
    public class BigQueryConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. When true and use_topic_schema is true, any fields that are a part of the topic schema that are
        /// not part of the BigQuery table schema are dropped when writing to BigQuery. Otherwise, the schemas must be
        /// kept in sync and any messages with extra fields are not written and remain in the subscription's backlog.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dropUnknownFields")]
        public virtual System.Nullable<bool> DropUnknownFields { get; set; }

        /// <summary>
        /// Optional. The service account to use to write to BigQuery. The subscription creator or updater that
        /// specifies this field must have `iam.serviceAccounts.actAs` permission on the service account. If not
        /// specified, the Pub/Sub [service agent](https://cloud.google.com/iam/docs/service-agents),
        /// service-{project_number}@gcp-sa-pubsub.iam.gserviceaccount.com, is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccountEmail")]
        public virtual string ServiceAccountEmail { get; set; }

        /// <summary>
        /// Output only. An output-only field that indicates whether or not the subscription can receive messages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Optional. The name of the table to which to write data, of the form {projectId}.{datasetId}.{tableId}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("table")]
        public virtual string Table { get; set; }

        /// <summary>
        /// Optional. When true, use the BigQuery table's schema as the columns to write to in BigQuery.
        /// `use_table_schema` and `use_topic_schema` cannot be enabled at the same time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useTableSchema")]
        public virtual System.Nullable<bool> UseTableSchema { get; set; }

        /// <summary>
        /// Optional. When true, use the topic's schema as the columns to write to in BigQuery, if it exists.
        /// `use_topic_schema` and `use_table_schema` cannot be enabled at the same time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useTopicSchema")]
        public virtual System.Nullable<bool> UseTopicSchema { get; set; }

        /// <summary>
        /// Optional. When true, write the subscription name, message_id, publish_time, attributes, and ordering_key to
        /// additional columns in the table. The subscription name, message_id, and publish_time fields are put in their
        /// own columns while all other message properties (other than data) are written to a JSON object in the
        /// attributes column.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("writeMetadata")]
        public virtual System.Nullable<bool> WriteMetadata { get; set; }

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

    /// <summary>Ingestion settings for Cloud Storage.</summary>
    public class CloudStorage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Data from Cloud Storage will be interpreted in Avro format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("avroFormat")]
        public virtual AvroFormat AvroFormat { get; set; }

        /// <summary>
        /// Optional. Cloud Storage bucket. The bucket name must be without any prefix like "gs://". See the [bucket
        /// naming requirements] (https://cloud.google.com/storage/docs/buckets#naming).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucket")]
        public virtual string Bucket { get; set; }

        /// <summary>
        /// Optional. Glob pattern used to match objects that will be ingested. If unset, all objects will be ingested.
        /// See the [supported
        /// patterns](https://cloud.google.com/storage/docs/json_api/v1/objects/list#list-objects-and-prefixes-using-glob).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchGlob")]
        public virtual string MatchGlob { get; set; }

        private string _minimumObjectCreateTimeRaw;

        private object _minimumObjectCreateTime;

        /// <summary>Optional. Only objects with a larger or equal creation timestamp will be ingested.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minimumObjectCreateTime")]
        public virtual string MinimumObjectCreateTimeRaw
        {
            get => _minimumObjectCreateTimeRaw;
            set
            {
                _minimumObjectCreateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _minimumObjectCreateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="MinimumObjectCreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use MinimumObjectCreateTimeDateTimeOffset instead.")]
        public virtual object MinimumObjectCreateTime
        {
            get => _minimumObjectCreateTime;
            set
            {
                _minimumObjectCreateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _minimumObjectCreateTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="MinimumObjectCreateTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? MinimumObjectCreateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(MinimumObjectCreateTimeRaw);
            set => MinimumObjectCreateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Optional. It will be assumed data from Cloud Storage was written via [Cloud Storage
        /// subscriptions](https://cloud.google.com/pubsub/docs/cloudstorage).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pubsubAvroFormat")]
        public virtual PubSubAvroFormat PubsubAvroFormat { get; set; }

        /// <summary>
        /// Output only. An output-only field that indicates the state of the Cloud Storage ingestion source.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Optional. Data from Cloud Storage will be interpreted as text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textFormat")]
        public virtual TextFormat TextFormat { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for a Cloud Storage subscription.</summary>
    public class CloudStorageConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. If set, message data will be written to Cloud Storage in Avro format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("avroConfig")]
        public virtual AvroConfig AvroConfig { get; set; }

        /// <summary>
        /// Required. User-provided name for the Cloud Storage bucket. The bucket must be created by the user. The
        /// bucket name must be without any prefix like "gs://". See the [bucket naming requirements]
        /// (https://cloud.google.com/storage/docs/buckets#naming).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucket")]
        public virtual string Bucket { get; set; }

        /// <summary>
        /// Optional. User-provided format string specifying how to represent datetimes in Cloud Storage filenames. See
        /// the [datetime format
        /// guidance](https://cloud.google.com/pubsub/docs/create-cloudstorage-subscription#file_names).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filenameDatetimeFormat")]
        public virtual string FilenameDatetimeFormat { get; set; }

        /// <summary>
        /// Optional. User-provided prefix for Cloud Storage filename. See the [object naming
        /// requirements](https://cloud.google.com/storage/docs/objects#naming).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filenamePrefix")]
        public virtual string FilenamePrefix { get; set; }

        /// <summary>
        /// Optional. User-provided suffix for Cloud Storage filename. See the [object naming
        /// requirements](https://cloud.google.com/storage/docs/objects#naming). Must not end in "/".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filenameSuffix")]
        public virtual string FilenameSuffix { get; set; }

        /// <summary>
        /// Optional. The maximum bytes that can be written to a Cloud Storage file before a new file is created. Min 1
        /// KB, max 10 GiB. The max_bytes limit may be exceeded in cases where messages are larger than the limit.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxBytes")]
        public virtual System.Nullable<long> MaxBytes { get; set; }

        /// <summary>
        /// Optional. The maximum duration that can elapse before a new Cloud Storage file is created. Min 1 minute, max
        /// 10 minutes, default 5 minutes. May not exceed the subscription's acknowledgment deadline.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxDuration")]
        public virtual object MaxDuration { get; set; }

        /// <summary>
        /// Optional. The maximum number of messages that can be written to a Cloud Storage file before a new file is
        /// created. Min 1000 messages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxMessages")]
        public virtual System.Nullable<long> MaxMessages { get; set; }

        /// <summary>
        /// Optional. The service account to use to write to Cloud Storage. The subscription creator or updater that
        /// specifies this field must have `iam.serviceAccounts.actAs` permission on the service account. If not
        /// specified, the Pub/Sub [service agent](https://cloud.google.com/iam/docs/service-agents),
        /// service-{project_number}@gcp-sa-pubsub.iam.gserviceaccount.com, is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccountEmail")]
        public virtual string ServiceAccountEmail { get; set; }

        /// <summary>
        /// Output only. An output-only field that indicates whether or not the subscription can receive messages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Optional. If set, message data will be written to Cloud Storage in text format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textConfig")]
        public virtual TextConfig TextConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for CommitSchema method.</summary>
    public class CommitSchemaRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The schema revision to commit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schema")]
        public virtual Schema Schema { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Ingestion settings for Confluent Cloud.</summary>
    public class ConfluentCloud : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The address of the bootstrap server. The format is url:port.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bootstrapServer")]
        public virtual string BootstrapServer { get; set; }

        /// <summary>Required. The id of the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterId")]
        public virtual string ClusterId { get; set; }

        /// <summary>
        /// Required. The GCP service account to be used for Federated Identity authentication with `identity_pool_id`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcpServiceAccount")]
        public virtual string GcpServiceAccount { get; set; }

        /// <summary>
        /// Required. The id of the identity pool to be used for Federated Identity authentication with Confluent Cloud.
        /// See
        /// https://docs.confluent.io/cloud/current/security/authenticate/workload-identities/identity-providers/oauth/identity-pools.html#add-oauth-identity-pools.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("identityPoolId")]
        public virtual string IdentityPoolId { get; set; }

        /// <summary>
        /// Output only. An output-only field that indicates the state of the Confluent Cloud ingestion source.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Required. The name of the topic in the Confluent Cloud cluster that Pub/Sub will import from.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topic")]
        public virtual string Topic { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for the `CreateSnapshot` method.</summary>
    public class CreateSnapshotRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. See [Creating and managing labels](https://cloud.google.com/pubsub/docs/labels).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Required. The subscription whose backlog the snapshot retains. Specifically, the created snapshot is
        /// guaranteed to retain: (a) The existing backlog on the subscription. More precisely, this is defined as the
        /// messages in the subscription's backlog that are unacknowledged upon the successful completion of the
        /// `CreateSnapshot` request; as well as: (b) Any messages published to the subscription's topic following the
        /// successful completion of the CreateSnapshot request. Format is `projects/{project}/subscriptions/{sub}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscription")]
        public virtual string Subscription { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Dead lettering is done on a best effort basis. The same message might be dead lettered multiple times. If
    /// validation on any of the fields fails at subscription creation/updation, the create/update subscription request
    /// will fail.
    /// </summary>
    public class DeadLetterPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The name of the topic to which dead letter messages should be published. Format is
        /// `projects/{project}/topics/{topic}`.The Pub/Sub service account associated with the enclosing subscription's
        /// parent project (i.e., service-{project_number}@gcp-sa-pubsub.iam.gserviceaccount.com) must have permission
        /// to Publish() to this topic. The operation will fail if the topic does not exist. Users should ensure that
        /// there is a subscription attached to this topic since messages published to a topic with no subscriptions are
        /// lost.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deadLetterTopic")]
        public virtual string DeadLetterTopic { get; set; }

        /// <summary>
        /// Optional. The maximum number of delivery attempts for any message. The value must be between 5 and 100. The
        /// number of delivery attempts is defined as 1 + (the sum of number of NACKs and number of times the
        /// acknowledgment deadline has been exceeded for the message). A NACK is any call to ModifyAckDeadline with a 0
        /// deadline. Note that client libraries may automatically extend ack_deadlines. This field will be honored on a
        /// best effort basis. If this parameter is 0, a default value of 5 is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxDeliveryAttempts")]
        public virtual System.Nullable<int> MaxDeliveryAttempts { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for the DetachSubscription method. Reserved for future use.</summary>
    public class DetachSubscriptionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
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
    /// A policy that specifies the conditions for resource expiration (i.e., automatic resource deletion).
    /// </summary>
    public class ExpirationPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Specifies the "time-to-live" duration for an associated resource. The resource expires if it is
        /// not active for a period of `ttl`. The definition of "activity" depends on the type of the associated
        /// resource. The minimum and maximum allowed values for `ttl` depend on the type of the associated resource, as
        /// well. If `ttl` is not set, the associated resource never expires.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ttl")]
        public virtual object Ttl { get; set; }

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

    /// <summary>Settings for an ingestion data source on a topic.</summary>
    public class IngestionDataSourceSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Amazon Kinesis Data Streams.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("awsKinesis")]
        public virtual AwsKinesis AwsKinesis { get; set; }

        /// <summary>Optional. Amazon MSK.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("awsMsk")]
        public virtual AwsMsk AwsMsk { get; set; }

        /// <summary>Optional. Azure Event Hubs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("azureEventHubs")]
        public virtual AzureEventHubs AzureEventHubs { get; set; }

        /// <summary>Optional. Cloud Storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudStorage")]
        public virtual CloudStorage CloudStorage { get; set; }

        /// <summary>Optional. Confluent Cloud.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confluentCloud")]
        public virtual ConfluentCloud ConfluentCloud { get; set; }

        /// <summary>Optional. Platform Logs settings. If unset, no Platform Logs will be generated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("platformLogsSettings")]
        public virtual PlatformLogsSettings PlatformLogsSettings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>User-defined JavaScript function that can transform or filter a Pub/Sub message.</summary>
    public class JavaScriptUDF : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. JavaScript code that contains a function `function_name` with the below signature:
        /// ```
        /// /** *
        /// Transforms a Pub/Sub message. * @return {(Object)&amp;gt;|null)} - To * filter a message, return `null`. To
        /// transform a message return a map * with the following keys: * - (required) 'data' : {string} * - (optional)
        /// 'attributes' : {Object} * Returning empty `attributes` will remove all attributes from the * message. * *
        /// @param {(Object)&amp;gt;} Pub/Sub * message. Keys: * - (required) 'data' : {string} * - (required)
        /// 'attributes' : {Object} * * @param {Object} metadata - Pub/Sub message metadata. * Keys: * - (required)
        /// 'message_id' : {string} * - (optional) 'publish_time': {string} YYYY-MM-DDTHH:MM:SSZ format * - (optional)
        /// 'ordering_key': {string} */ function (message, metadata) { }
        /// ```
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>Required. Name of the JavasScript function that should applied to Pub/Sub messages.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("functionName")]
        public virtual string FunctionName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for the `ListSchemaRevisions` method.</summary>
    public class ListSchemaRevisionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token that can be sent as `page_token` to retrieve the next page. If this field is empty, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The revisions of the schema.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schemas")]
        public virtual System.Collections.Generic.IList<Schema> Schemas { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for the `ListSchemas` method.</summary>
    public class ListSchemasResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If not empty, indicates that there may be more schemas that match the request; this value should be passed
        /// in a new `ListSchemasRequest`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The resulting schemas.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schemas")]
        public virtual System.Collections.Generic.IList<Schema> Schemas { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for the `ListSnapshots` method.</summary>
    public class ListSnapshotsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. If not empty, indicates that there may be more snapshot that match the request; this value should
        /// be passed in a new `ListSnapshotsRequest`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Optional. The resulting snapshots.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snapshots")]
        public virtual System.Collections.Generic.IList<Snapshot> Snapshots { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for the `ListSubscriptions` method.</summary>
    public class ListSubscriptionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. If not empty, indicates that there may be more subscriptions that match the request; this value
        /// should be passed in a new `ListSubscriptionsRequest` to get more subscriptions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Optional. The subscriptions that match the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscriptions")]
        public virtual System.Collections.Generic.IList<Subscription> Subscriptions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for the `ListTopicSnapshots` method.</summary>
    public class ListTopicSnapshotsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. If not empty, indicates that there may be more snapshots that match the request; this value should
        /// be passed in a new `ListTopicSnapshotsRequest` to get more snapshots.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Optional. The names of the snapshots that match the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snapshots")]
        public virtual System.Collections.Generic.IList<string> Snapshots { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for the `ListTopicSubscriptions` method.</summary>
    public class ListTopicSubscriptionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. If not empty, indicates that there may be more subscriptions that match the request; this value
        /// should be passed in a new `ListTopicSubscriptionsRequest` to get more subscriptions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Optional. The names of subscriptions attached to the topic specified in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscriptions")]
        public virtual System.Collections.Generic.IList<string> Subscriptions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for the `ListTopics` method.</summary>
    public class ListTopicsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. If not empty, indicates that there may be more topics that match the request; this value should be
        /// passed in a new `ListTopicsRequest`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Optional. The resulting topics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topics")]
        public virtual System.Collections.Generic.IList<Topic> Topics { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A policy constraining the storage of messages published to the topic.</summary>
    public class MessageStoragePolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A list of IDs of Google Cloud regions where messages that are published to the topic may be
        /// persisted in storage. Messages published by publishers running in non-allowed Google Cloud regions (or
        /// running outside of Google Cloud altogether) are routed for storage in one of the allowed regions. An empty
        /// list means that no regions are allowed, and is not a valid configuration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedPersistenceRegions")]
        public virtual System.Collections.Generic.IList<string> AllowedPersistenceRegions { get; set; }

        /// <summary>
        /// Optional. If true, `allowed_persistence_regions` is also used to enforce in-transit guarantees for messages.
        /// That is, Pub/Sub will fail Publish operations on this topic and subscribe operations on any subscription
        /// attached to this topic in any region that is not in `allowed_persistence_regions`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enforceInTransit")]
        public virtual System.Nullable<bool> EnforceInTransit { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>All supported message transforms types.</summary>
    public class MessageTransform : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. If set to true, the transform is enabled. If false, the transform is disabled and will not be
        /// applied to messages. Defaults to `true`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>
        /// Optional. JavaScript User Defined Function. If multiple JavaScriptUDF's are specified on a resource, each
        /// must have a unique `function_name`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("javascriptUdf")]
        public virtual JavaScriptUDF JavascriptUdf { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for the ModifyAckDeadline method.</summary>
    public class ModifyAckDeadlineRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The new ack deadline with respect to the time this request was sent to the Pub/Sub system. For
        /// example, if the value is 10, the new ack deadline will expire 10 seconds after the `ModifyAckDeadline` call
        /// was made. Specifying zero might immediately make the message available for delivery to another subscriber
        /// client. This typically results in an increase in the rate of message redeliveries (that is, duplicates). The
        /// minimum deadline you can specify is 0 seconds. The maximum deadline you can specify in a single request is
        /// 600 seconds (10 minutes).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ackDeadlineSeconds")]
        public virtual System.Nullable<int> AckDeadlineSeconds { get; set; }

        /// <summary>Required. List of acknowledgment IDs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ackIds")]
        public virtual System.Collections.Generic.IList<string> AckIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for the ModifyPushConfig method.</summary>
    public class ModifyPushConfigRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The push configuration for future deliveries. An empty `pushConfig` indicates that the Pub/Sub
        /// system should stop pushing messages from the given subscription and allow messages to be pulled and
        /// acknowledged - effectively pausing the subscription if `Pull` or `StreamingPull` is not called.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pushConfig")]
        public virtual PushConfig PushConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Sets the `data` field as the HTTP body for delivery.</summary>
    public class NoWrapper : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. When true, writes the Pub/Sub message metadata to `x-goog-pubsub-:` headers of the HTTP request.
        /// Writes the Pub/Sub message attributes to `:` headers of the HTTP request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("writeMetadata")]
        public virtual System.Nullable<bool> WriteMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Contains information needed for generating an [OpenID Connect
    /// token](https://developers.google.com/identity/protocols/OpenIDConnect).
    /// </summary>
    public class OidcToken : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Audience to be used when generating OIDC token. The audience claim identifies the recipients that
        /// the JWT is intended for. The audience value is a single case-sensitive string. Having multiple values
        /// (array) for the audience field is not supported. More info about the OIDC JWT token audience here:
        /// https://tools.ietf.org/html/rfc7519#section-4.1.3 Note: if not specified, the Push endpoint URL will be
        /// used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audience")]
        public virtual string Audience { get; set; }

        /// <summary>
        /// Optional. [Service account email](https://cloud.google.com/iam/docs/service-accounts) used for generating
        /// the OIDC token. For more information on setting up authentication, see [Push
        /// subscriptions](https://cloud.google.com/pubsub/docs/push).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccountEmail")]
        public virtual string ServiceAccountEmail { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Settings for Platform Logs produced by Pub/Sub.</summary>
    public class PlatformLogsSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The minimum severity level of Platform Logs that will be written.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

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
    /// Configuration for reading Cloud Storage data written via [Cloud Storage
    /// subscriptions](https://cloud.google.com/pubsub/docs/cloudstorage). The data and attributes fields of the
    /// originally exported Pub/Sub message will be restored when publishing.
    /// </summary>
    public class PubSubAvroFormat : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for the Publish method.</summary>
    public class PublishRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The messages to publish.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messages")]
        public virtual System.Collections.Generic.IList<PubsubMessage> Messages { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for the `Publish` method.</summary>
    public class PublishResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The server-assigned ID of each published message, in the same order as the messages in the
        /// request. IDs are guaranteed to be unique within the topic.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageIds")]
        public virtual System.Collections.Generic.IList<string> MessageIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A message that is published by publishers and consumed by subscribers. The message must contain either a
    /// non-empty data field or at least one attribute. Note that client libraries represent this object differently
    /// depending on the language. See the corresponding [client library
    /// documentation](https://cloud.google.com/pubsub/docs/reference/libraries) for more information. See [quotas and
    /// limits] (https://cloud.google.com/pubsub/quotas) for more information about message limits.
    /// </summary>
    public class PubsubMessage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Attributes for this message. If this field is empty, the message must contain non-empty data. This
        /// can be used to filter messages on the subscription.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual System.Collections.Generic.IDictionary<string, string> Attributes { get; set; }

        /// <summary>
        /// Optional. The message data field. If this field is empty, the message must contain at least one attribute.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual string Data { get; set; }

        /// <summary>
        /// ID of this message, assigned by the server when the message is published. Guaranteed to be unique within the
        /// topic. This value may be read by a subscriber that receives a `PubsubMessage` via a `Pull` call or a push
        /// delivery. It must not be populated by the publisher in a `Publish` call.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageId")]
        public virtual string MessageId { get; set; }

        /// <summary>
        /// Optional. If non-empty, identifies related messages for which publish order should be respected. If a
        /// `Subscription` has `enable_message_ordering` set to `true`, messages published with the same non-empty
        /// `ordering_key` value will be delivered to subscribers in the order in which they are received by the Pub/Sub
        /// system. All `PubsubMessage`s published in a given `PublishRequest` must specify the same `ordering_key`
        /// value. For more information, see [ordering messages](https://cloud.google.com/pubsub/docs/ordering).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orderingKey")]
        public virtual string OrderingKey { get; set; }

        private string _publishTimeRaw;

        private object _publishTime;

        /// <summary>
        /// The time at which the message was published, populated by the server when it receives the `Publish` call. It
        /// must not be populated by the publisher in a `Publish` call.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publishTime")]
        public virtual string PublishTimeRaw
        {
            get => _publishTimeRaw;
            set
            {
                _publishTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _publishTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="PublishTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use PublishTimeDateTimeOffset instead.")]
        public virtual object PublishTime
        {
            get => _publishTime;
            set
            {
                _publishTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _publishTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="PublishTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? PublishTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(PublishTimeRaw);
            set => PublishTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The payload to the push endpoint is in the form of the JSON representation of a PubsubMessage
    /// (https://cloud.google.com/pubsub/docs/reference/rpc/google.pubsub.v1#pubsubmessage).
    /// </summary>
    public class PubsubWrapper : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for the `Pull` method.</summary>
    public class PullRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The maximum number of messages to return for this request. Must be a positive integer. The Pub/Sub
        /// system may return fewer than the number specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxMessages")]
        public virtual System.Nullable<int> MaxMessages { get; set; }

        /// <summary>
        /// Optional. If this field set to true, the system will respond immediately even if it there are no messages
        /// available to return in the `Pull` response. Otherwise, the system may wait (for a bounded amount of time)
        /// until at least one message is available, rather than returning no messages. Warning: setting this field to
        /// `true` is discouraged because it adversely impacts the performance of `Pull` operations. We recommend that
        /// users do not set this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("returnImmediately")]
        public virtual System.Nullable<bool> ReturnImmediately { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for the `Pull` method.</summary>
    public class PullResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Received Pub/Sub messages. The list will be empty if there are no more messages available in the
        /// backlog, or if no messages could be returned before the request timeout. For JSON, the response can be
        /// entirely empty. The Pub/Sub system may return fewer than the `maxMessages` requested even if there are more
        /// messages available in the backlog.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("receivedMessages")]
        public virtual System.Collections.Generic.IList<ReceivedMessage> ReceivedMessages { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for a push delivery endpoint.</summary>
    public class PushConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Endpoint configuration attributes that can be used to control different aspects of the message
        /// delivery. The only currently supported attribute is `x-goog-version`, which you can use to change the format
        /// of the pushed message. This attribute indicates the version of the data expected by the endpoint. This
        /// controls the shape of the pushed message (i.e., its fields and metadata). If not present during the
        /// `CreateSubscription` call, it will default to the version of the Pub/Sub API used to make such call. If not
        /// present in a `ModifyPushConfig` call, its value will not be changed. `GetSubscription` calls will always
        /// return a valid version, even if the subscription was created without this attribute. The only supported
        /// values for the `x-goog-version` attribute are: * `v1beta1`: uses the push format defined in the v1beta1
        /// Pub/Sub API. * `v1` or `v1beta2`: uses the push format defined in the v1 Pub/Sub API. For example:
        /// `attributes { "x-goog-version": "v1" }`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual System.Collections.Generic.IDictionary<string, string> Attributes { get; set; }

        /// <summary>Optional. When set, the payload to the push endpoint is not wrapped.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("noWrapper")]
        public virtual NoWrapper NoWrapper { get; set; }

        /// <summary>
        /// Optional. If specified, Pub/Sub will generate and attach an OIDC JWT token as an `Authorization` header in
        /// the HTTP request for every pushed message.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oidcToken")]
        public virtual OidcToken OidcToken { get; set; }

        /// <summary>
        /// Optional. When set, the payload to the push endpoint is in the form of the JSON representation of a
        /// PubsubMessage (https://cloud.google.com/pubsub/docs/reference/rpc/google.pubsub.v1#pubsubmessage).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pubsubWrapper")]
        public virtual PubsubWrapper PubsubWrapper { get; set; }

        /// <summary>
        /// Optional. A URL locating the endpoint to which messages should be pushed. For example, a Webhook endpoint
        /// might use `https://example.com/push`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pushEndpoint")]
        public virtual string PushEndpoint { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A message and its corresponding acknowledgment ID.</summary>
    public class ReceivedMessage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. This ID can be used to acknowledge the received message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ackId")]
        public virtual string AckId { get; set; }

        /// <summary>
        /// Optional. The approximate number of times that Pub/Sub has attempted to deliver the associated message to a
        /// subscriber. More precisely, this is 1 + (number of NACKs) + (number of ack_deadline exceeds) for this
        /// message. A NACK is any call to ModifyAckDeadline with a 0 deadline. An ack_deadline exceeds event is
        /// whenever a message is not acknowledged within ack_deadline. Note that ack_deadline is initially
        /// Subscription.ackDeadlineSeconds, but may get extended automatically by the client library. Upon the first
        /// delivery of a given message, `delivery_attempt` will have a value of 1. The value is calculated at best
        /// effort and is approximate. If a DeadLetterPolicy is not set on the subscription, this will be 0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deliveryAttempt")]
        public virtual System.Nullable<int> DeliveryAttempt { get; set; }

        /// <summary>Optional. The message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual PubsubMessage Message { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A policy that specifies how Pub/Sub retries message delivery. Retry delay will be exponential based on provided
    /// minimum and maximum backoffs. https://en.wikipedia.org/wiki/Exponential_backoff. RetryPolicy will be triggered
    /// on NACKs or acknowledgment deadline exceeded events for a given message. Retry Policy is implemented on a best
    /// effort basis. At times, the delay between consecutive deliveries may not match the configuration. That is, delay
    /// can be more or less than configured backoff.
    /// </summary>
    public class RetryPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The maximum delay between consecutive deliveries of a given message. Value should be between 0 and
        /// 600 seconds. Defaults to 600 seconds.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maximumBackoff")]
        public virtual object MaximumBackoff { get; set; }

        /// <summary>
        /// Optional. The minimum delay between consecutive deliveries of a given message. Value should be between 0 and
        /// 600 seconds. Defaults to 10 seconds.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minimumBackoff")]
        public virtual object MinimumBackoff { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for the `RollbackSchema` method.</summary>
    public class RollbackSchemaRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The revision ID to roll back to. It must be a revision of the same schema. Example: c7cfa2a8
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionId")]
        public virtual string RevisionId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A schema resource.</summary>
    public class Schema : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The definition of the schema. This should contain a string representing the full definition of the schema
        /// that is a valid schema definition of the type specified in `type`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("definition")]
        public virtual string Definition { get; set; }

        /// <summary>Required. Name of the schema. Format is `projects/{project}/schemas/{schema}`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _revisionCreateTimeRaw;

        private object _revisionCreateTime;

        /// <summary>Output only. The timestamp that the revision was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionCreateTime")]
        public virtual string RevisionCreateTimeRaw
        {
            get => _revisionCreateTimeRaw;
            set
            {
                _revisionCreateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _revisionCreateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="RevisionCreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use RevisionCreateTimeDateTimeOffset instead.")]
        public virtual object RevisionCreateTime
        {
            get => _revisionCreateTime;
            set
            {
                _revisionCreateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _revisionCreateTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="RevisionCreateTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? RevisionCreateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(RevisionCreateTimeRaw);
            set => RevisionCreateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Output only. Immutable. The revision ID of the schema.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionId")]
        public virtual string RevisionId { get; set; }

        /// <summary>The type of the schema definition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Settings for validating messages published against a schema.</summary>
    public class SchemaSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The encoding of messages validated against `schema`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encoding")]
        public virtual string Encoding { get; set; }

        /// <summary>
        /// Optional. The minimum (inclusive) revision allowed for validating messages. If empty or not present, allow
        /// any revision to be validated against last_revision or any revision created before.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstRevisionId")]
        public virtual string FirstRevisionId { get; set; }

        /// <summary>
        /// Optional. The maximum (inclusive) revision allowed for validating messages. If empty or not present, allow
        /// any revision to be validated against first_revision or any revision created after.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastRevisionId")]
        public virtual string LastRevisionId { get; set; }

        /// <summary>
        /// Required. The name of the schema that messages published should be validated against. Format is
        /// `projects/{project}/schemas/{schema}`. The value of this field will be `_deleted-schema_` if the schema has
        /// been deleted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schema")]
        public virtual string Schema { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for the `Seek` method.</summary>
    public class SeekRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The snapshot to seek to. The snapshot's topic must be the same as that of the provided
        /// subscription. Format is `projects/{project}/snapshots/{snap}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snapshot")]
        public virtual string Snapshot { get; set; }

        private string _timeRaw;

        private object _time;

        /// <summary>
        /// Optional. The time to seek to. Messages retained in the subscription that were published before this time
        /// are marked as acknowledged, and messages retained in the subscription that were published after this time
        /// are marked as unacknowledged. Note that this operation affects only those messages retained in the
        /// subscription (configured by the combination of `message_retention_duration` and `retain_acked_messages`).
        /// For example, if `time` corresponds to a point before the message retention window (or to a point before the
        /// system's notion of the subscription creation time), only retained messages will be marked as unacknowledged,
        /// and already-expunged messages will not be restored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("time")]
        public virtual string TimeRaw
        {
            get => _timeRaw;
            set
            {
                _time = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _timeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="TimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use TimeDateTimeOffset instead.")]
        public virtual object Time
        {
            get => _time;
            set
            {
                _timeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _time = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="TimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? TimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(TimeRaw);
            set => TimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for the `Seek` method (this response is empty).</summary>
    public class SeekResponse : Google.Apis.Requests.IDirectResponseSchema
    {
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

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A snapshot resource. Snapshots are used in [Seek](https://cloud.google.com/pubsub/docs/replay-overview)
    /// operations, which allow you to manage message acknowledgments in bulk. That is, you can set the acknowledgment
    /// state of messages in an existing subscription to the state captured by a snapshot.
    /// </summary>
    public class Snapshot : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _expireTimeRaw;

        private object _expireTime;

        /// <summary>
        /// Optional. The snapshot is guaranteed to exist up until this time. A newly-created snapshot expires no later
        /// than 7 days from the time of its creation. Its exact lifetime is determined at creation by the existing
        /// backlog in the source subscription. Specifically, the lifetime of the snapshot is `7 days - (age of oldest
        /// unacked message in the subscription)`. For example, consider a subscription whose oldest unacked message is
        /// 3 days old. If a snapshot is created from this subscription, the snapshot -- which will always capture this
        /// 3-day-old backlog as long as the snapshot exists -- will expire in 4 days. The service will refuse to create
        /// a snapshot that would expire in less than 1 hour after creation.
        /// </summary>
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

        /// <summary>
        /// Optional. See [Creating and managing labels] (https://cloud.google.com/pubsub/docs/labels).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Optional. The name of the snapshot.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. The name of the topic from which this snapshot is retaining messages.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topic")]
        public virtual string Topic { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A subscription resource. If none of `push_config`, `bigquery_config`, or `cloud_storage_config` is set, then the
    /// subscriber will pull and ack messages using API methods. At most one of these fields may be set.
    /// </summary>
    public class Subscription : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The approximate amount of time (on a best-effort basis) Pub/Sub waits for the subscriber to
        /// acknowledge receipt before resending the message. In the interval after the message is delivered and before
        /// it is acknowledged, it is considered to be _outstanding_. During that time period, the message will not be
        /// redelivered (on a best-effort basis). For pull subscriptions, this value is used as the initial value for
        /// the ack deadline. To override this value for a given message, call `ModifyAckDeadline` with the
        /// corresponding `ack_id` if using non-streaming pull or send the `ack_id` in a
        /// `StreamingModifyAckDeadlineRequest` if using streaming pull. The minimum custom deadline you can specify is
        /// 10 seconds. The maximum custom deadline you can specify is 600 seconds (10 minutes). If this parameter is 0,
        /// a default value of 10 seconds is used. For push delivery, this value is also used to set the request timeout
        /// for the call to the push endpoint. If the subscriber never acknowledges the message, the Pub/Sub system will
        /// eventually redeliver the message.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ackDeadlineSeconds")]
        public virtual System.Nullable<int> AckDeadlineSeconds { get; set; }

        /// <summary>
        /// Output only. Information about the associated Analytics Hub subscription. Only set if the subscritpion is
        /// created by Analytics Hub.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("analyticsHubSubscriptionInfo")]
        public virtual AnalyticsHubSubscriptionInfo AnalyticsHubSubscriptionInfo { get; set; }

        /// <summary>
        /// Optional. If delivery to BigQuery is used with this subscription, this field is used to configure it.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bigqueryConfig")]
        public virtual BigQueryConfig BigqueryConfig { get; set; }

        /// <summary>
        /// Optional. If delivery to Google Cloud Storage is used with this subscription, this field is used to
        /// configure it.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudStorageConfig")]
        public virtual CloudStorageConfig CloudStorageConfig { get; set; }

        /// <summary>
        /// Optional. A policy that specifies the conditions for dead lettering messages in this subscription. If
        /// dead_letter_policy is not set, dead lettering is disabled. The Pub/Sub service account associated with this
        /// subscriptions's parent project (i.e., service-{project_number}@gcp-sa-pubsub.iam.gserviceaccount.com) must
        /// have permission to Acknowledge() messages on this subscription.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deadLetterPolicy")]
        public virtual DeadLetterPolicy DeadLetterPolicy { get; set; }

        /// <summary>
        /// Optional. Indicates whether the subscription is detached from its topic. Detached subscriptions don't
        /// receive messages from their topic and don't retain any backlog. `Pull` and `StreamingPull` requests will
        /// return FAILED_PRECONDITION. If the subscription is a push subscription, pushes to the endpoint will not be
        /// made.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detached")]
        public virtual System.Nullable<bool> Detached { get; set; }

        /// <summary>
        /// Optional. If true, Pub/Sub provides the following guarantees for the delivery of a message with a given
        /// value of `message_id` on this subscription: * The message sent to a subscriber is guaranteed not to be
        /// resent before the message's acknowledgment deadline expires. * An acknowledged message will not be resent to
        /// a subscriber. Note that subscribers may still receive multiple copies of a message when
        /// `enable_exactly_once_delivery` is true if the message was published multiple times by a publisher client.
        /// These copies are considered distinct by Pub/Sub and have distinct `message_id` values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableExactlyOnceDelivery")]
        public virtual System.Nullable<bool> EnableExactlyOnceDelivery { get; set; }

        /// <summary>
        /// Optional. If true, messages published with the same `ordering_key` in `PubsubMessage` will be delivered to
        /// the subscribers in the order in which they are received by the Pub/Sub system. Otherwise, they may be
        /// delivered in any order.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableMessageOrdering")]
        public virtual System.Nullable<bool> EnableMessageOrdering { get; set; }

        /// <summary>
        /// Optional. A policy that specifies the conditions for this subscription's expiration. A subscription is
        /// considered active as long as any connected subscriber is successfully consuming messages from the
        /// subscription or is issuing operations on the subscription. If `expiration_policy` is not set, a *default
        /// policy* with `ttl` of 31 days will be used. The minimum allowed value for `expiration_policy.ttl` is 1 day.
        /// If `expiration_policy` is set, but `expiration_policy.ttl` is not set, the subscription never expires.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expirationPolicy")]
        public virtual ExpirationPolicy ExpirationPolicy { get; set; }

        /// <summary>
        /// Optional. An expression written in the Pub/Sub [filter
        /// language](https://cloud.google.com/pubsub/docs/filtering). If non-empty, then only `PubsubMessage`s whose
        /// `attributes` field matches the filter are delivered on this subscription. If empty, then no messages are
        /// filtered out.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>
        /// Optional. See [Creating and managing labels](https://cloud.google.com/pubsub/docs/labels).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Optional. How long to retain unacknowledged messages in the subscription's backlog, from the moment a
        /// message is published. If `retain_acked_messages` is true, then this also configures the retention of
        /// acknowledged messages, and thus configures how far back in time a `Seek` can be done. Defaults to 7 days.
        /// Cannot be more than 31 days or less than 10 minutes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageRetentionDuration")]
        public virtual object MessageRetentionDuration { get; set; }

        /// <summary>
        /// Optional. Transforms to be applied to messages before they are delivered to subscribers. Transforms are
        /// applied in the order specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageTransforms")]
        public virtual System.Collections.Generic.IList<MessageTransform> MessageTransforms { get; set; }

        /// <summary>
        /// Required. The name of the subscription. It must have the format
        /// `"projects/{project}/subscriptions/{subscription}"`. `{subscription}` must start with a letter, and contain
        /// only letters (`[A-Za-z]`), numbers (`[0-9]`), dashes (`-`), underscores (`_`), periods (`.`), tildes (`~`),
        /// plus (`+`) or percent signs (`%`). It must be between 3 and 255 characters in length, and it must not start
        /// with `"goog"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. If push delivery is used with this subscription, this field is used to configure it.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pushConfig")]
        public virtual PushConfig PushConfig { get; set; }

        /// <summary>
        /// Optional. Indicates whether to retain acknowledged messages. If true, then messages are not expunged from
        /// the subscription's backlog, even if they are acknowledged, until they fall out of the
        /// `message_retention_duration` window. This must be true if you would like to [`Seek` to a timestamp]
        /// (https://cloud.google.com/pubsub/docs/replay-overview#seek_to_a_time) in the past to replay
        /// previously-acknowledged messages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retainAckedMessages")]
        public virtual System.Nullable<bool> RetainAckedMessages { get; set; }

        /// <summary>
        /// Optional. A policy that specifies how Pub/Sub retries message delivery for this subscription. If not set,
        /// the default retry policy is applied. This generally implies that messages will be retried as soon as
        /// possible for healthy subscribers. RetryPolicy will be triggered on NACKs or acknowledgment deadline exceeded
        /// events for a given message.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retryPolicy")]
        public virtual RetryPolicy RetryPolicy { get; set; }

        /// <summary>
        /// Output only. An output-only field indicating whether or not the subscription can receive messages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Required. The name of the topic from which this subscription is receiving messages. Format is
        /// `projects/{project}/topics/{topic}`. The value of this field will be `_deleted-topic_` if the topic has been
        /// deleted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topic")]
        public virtual string Topic { get; set; }

        /// <summary>
        /// Output only. Indicates the minimum duration for which a message is retained after it is published to the
        /// subscription's topic. If this field is set, messages published to the subscription's topic in the last
        /// `topic_message_retention_duration` are always available to subscribers. See the `message_retention_duration`
        /// field in `Topic`. This field is set only in responses from the server; it is ignored if it is set in any
        /// requests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topicMessageRetentionDuration")]
        public virtual object TopicMessageRetentionDuration { get; set; }

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

    /// <summary>
    /// Configuration for writing message data in text format. Message payloads will be written to files as raw text,
    /// separated by a newline.
    /// </summary>
    public class TextConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configuration for reading Cloud Storage data in text format. Each line of text as specified by the delimiter
    /// will be set to the `data` field of a Pub/Sub message.
    /// </summary>
    public class TextFormat : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. When unset, '\n' is used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("delimiter")]
        public virtual string Delimiter { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A topic resource.</summary>
    public class Topic : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Settings for ingestion from a data source into this topic.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ingestionDataSourceSettings")]
        public virtual IngestionDataSourceSettings IngestionDataSourceSettings { get; set; }

        /// <summary>
        /// Optional. The resource name of the Cloud KMS CryptoKey to be used to protect access to messages published on
        /// this topic. The expected format is `projects/*/locations/*/keyRings/*/cryptoKeys/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeyName")]
        public virtual string KmsKeyName { get; set; }

        /// <summary>
        /// Optional. See [Creating and managing labels] (https://cloud.google.com/pubsub/docs/labels).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Optional. Indicates the minimum duration to retain a message after it is published to the topic. If this
        /// field is set, messages published to the topic in the last `message_retention_duration` are always available
        /// to subscribers. For instance, it allows any attached subscription to [seek to a
        /// timestamp](https://cloud.google.com/pubsub/docs/replay-overview#seek_to_a_time) that is up to
        /// `message_retention_duration` in the past. If this field is not set, message retention is controlled by
        /// settings on individual subscriptions. Cannot be more than 31 days or less than 10 minutes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageRetentionDuration")]
        public virtual object MessageRetentionDuration { get; set; }

        /// <summary>
        /// Optional. Policy constraining the set of Google Cloud Platform regions where messages published to the topic
        /// may be stored. If not present, then no constraints are in effect.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageStoragePolicy")]
        public virtual MessageStoragePolicy MessageStoragePolicy { get; set; }

        /// <summary>
        /// Optional. Transforms to be applied to messages published to the topic. Transforms are applied in the order
        /// specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageTransforms")]
        public virtual System.Collections.Generic.IList<MessageTransform> MessageTransforms { get; set; }

        /// <summary>
        /// Required. The name of the topic. It must have the format `"projects/{project}/topics/{topic}"`. `{topic}`
        /// must start with a letter, and contain only letters (`[A-Za-z]`), numbers (`[0-9]`), dashes (`-`),
        /// underscores (`_`), periods (`.`), tildes (`~`), plus (`+`) or percent signs (`%`). It must be between 3 and
        /// 255 characters in length, and it must not start with `"goog"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. Reserved for future use. This field is set only in responses from the server; it is ignored if it
        /// is set in any requests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzs")]
        public virtual System.Nullable<bool> SatisfiesPzs { get; set; }

        /// <summary>Optional. Settings for validating messages published against a schema.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schemaSettings")]
        public virtual SchemaSettings SchemaSettings { get; set; }

        /// <summary>Output only. An output-only field indicating the state of the topic.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for the UpdateSnapshot method.</summary>
    public class UpdateSnapshotRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The updated snapshot object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snapshot")]
        public virtual Snapshot Snapshot { get; set; }

        /// <summary>
        /// Required. Indicates which fields in the provided snapshot to update. Must be specified and non-empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for the UpdateSubscription method.</summary>
    public class UpdateSubscriptionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The updated subscription object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscription")]
        public virtual Subscription Subscription { get; set; }

        /// <summary>
        /// Required. Indicates which fields in the provided subscription to update. Must be specified and non-empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for the UpdateTopic method.</summary>
    public class UpdateTopicRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The updated topic object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topic")]
        public virtual Topic Topic { get; set; }

        /// <summary>
        /// Required. Indicates which fields in the provided topic to update. Must be specified and non-empty. Note that
        /// if `update_mask` contains "message_storage_policy" but the `message_storage_policy` is not set in the
        /// `topic` provided above, then the updated value is determined by the policy configured at the project or
        /// organization level.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for the `ValidateMessage` method.</summary>
    public class ValidateMessageRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The encoding expected for messages</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encoding")]
        public virtual string Encoding { get; set; }

        /// <summary>Message to validate against the provided `schema_spec`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>
        /// Name of the schema against which to validate. Format is `projects/{project}/schemas/{schema}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Ad-hoc schema against which to validate</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schema")]
        public virtual Schema Schema { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for the `ValidateMessage` method. Empty for now.</summary>
    public class ValidateMessageResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for the `ValidateSchema` method.</summary>
    public class ValidateSchemaRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The schema object to validate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schema")]
        public virtual Schema Schema { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for the `ValidateSchema` method. Empty for now.</summary>
    public class ValidateSchemaResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
