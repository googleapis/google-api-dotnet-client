// Copyright 2023 Google LLC
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

namespace Google.Apis.Contactcenterinsights.v1
{
    /// <summary>The Contactcenterinsights Service.</summary>
    public class ContactcenterinsightsService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public ContactcenterinsightsService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public ContactcenterinsightsService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "contactcenterinsights";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri => BaseUriOverride ?? "https://contactcenterinsights.googleapis.com/";

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://contactcenterinsights.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Contact Center AI Insights API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Contact Center AI Insights API.</summary>
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

    /// <summary>A base abstract class for Contactcenterinsights requests.</summary>
    public abstract class ContactcenterinsightsBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new ContactcenterinsightsBaseServiceRequest instance.</summary>
        protected ContactcenterinsightsBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Contactcenterinsights parameter list.</summary>
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
                Conversations = new ConversationsResource(service);
                Insightsdata = new InsightsdataResource(service);
                IssueModels = new IssueModelsResource(service);
                Operations = new OperationsResource(service);
                PhraseMatchers = new PhraseMatchersResource(service);
                Views = new ViewsResource(service);
            }

            /// <summary>Gets the Conversations resource.</summary>
            public virtual ConversationsResource Conversations { get; }

            /// <summary>The "conversations" collection of methods.</summary>
            public class ConversationsResource
            {
                private const string Resource = "conversations";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ConversationsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Analyses = new AnalysesResource(service);
                }

                /// <summary>Gets the Analyses resource.</summary>
                public virtual AnalysesResource Analyses { get; }

                /// <summary>The "analyses" collection of methods.</summary>
                public class AnalysesResource
                {
                    private const string Resource = "analyses";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public AnalysesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Creates an analysis. The long running operation is done when the analysis has completed.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">Required. The parent resource of the analysis.</param>
                    public virtual CreateRequest Create(Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1Analysis body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>
                    /// Creates an analysis. The long running operation is done when the analysis has completed.
                    /// </summary>
                    public class CreateRequest : ContactcenterinsightsBaseServiceRequest<Google.Apis.Contactcenterinsights.v1.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1Analysis body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The parent resource of the analysis.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1Analysis Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/analyses";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/conversations/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Deletes an analysis.</summary>
                    /// <param name="name">Required. The name of the analysis to delete.</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>Deletes an analysis.</summary>
                    public class DeleteRequest : ContactcenterinsightsBaseServiceRequest<Google.Apis.Contactcenterinsights.v1.Data.GoogleProtobufEmpty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the analysis to delete.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/conversations/[^/]+/analyses/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets an analysis.</summary>
                    /// <param name="name">Required. The name of the analysis to get.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Gets an analysis.</summary>
                    public class GetRequest : ContactcenterinsightsBaseServiceRequest<Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1Analysis>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the analysis to get.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/conversations/[^/]+/analyses/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists analyses.</summary>
                    /// <param name="parent">Required. The parent resource of the analyses.</param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Lists analyses.</summary>
                    public class ListRequest : ContactcenterinsightsBaseServiceRequest<Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1ListAnalysesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>Required. The parent resource of the analyses.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// A filter to reduce results to a specific subset. Useful for querying conversations with
                        /// specific properties.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// The maximum number of analyses to return in the response. If this value is zero, the service
                        /// will select a default size. A call might return fewer objects than requested. A non-empty
                        /// `next_page_token` in the response indicates that more data is available.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// The value returned by the last `ListAnalysesResponse`; indicates that this is a continuation
                        /// of a prior `ListAnalyses` call and the system should return the next page of data.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/analyses";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/conversations/[^/]+$",
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

                /// <summary>Analyzes multiple conversations in a single request.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. The parent resource to create analyses in.</param>
                public virtual BulkAnalyzeRequest BulkAnalyze(Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1BulkAnalyzeConversationsRequest body, string parent)
                {
                    return new BulkAnalyzeRequest(service, body, parent);
                }

                /// <summary>Analyzes multiple conversations in a single request.</summary>
                public class BulkAnalyzeRequest : ContactcenterinsightsBaseServiceRequest<Google.Apis.Contactcenterinsights.v1.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new BulkAnalyze request.</summary>
                    public BulkAnalyzeRequest(Google.Apis.Services.IClientService service, Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1BulkAnalyzeConversationsRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The parent resource to create analyses in.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1BulkAnalyzeConversationsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "bulkAnalyze";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/conversations:bulkAnalyze";

                    /// <summary>Initializes BulkAnalyze parameter list.</summary>
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

                /// <summary>Gets conversation statistics.</summary>
                /// <param name="location">Required. The location of the conversations.</param>
                public virtual CalculateStatsRequest CalculateStats(string location)
                {
                    return new CalculateStatsRequest(service, location);
                }

                /// <summary>Gets conversation statistics.</summary>
                public class CalculateStatsRequest : ContactcenterinsightsBaseServiceRequest<Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1CalculateStatsResponse>
                {
                    /// <summary>Constructs a new CalculateStats request.</summary>
                    public CalculateStatsRequest(Google.Apis.Services.IClientService service, string location) : base(service)
                    {
                        Location = location;
                        InitParameters();
                    }

                    /// <summary>Required. The location of the conversations.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("location", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Location { get; private set; }

                    /// <summary>
                    /// A filter to reduce results to a specific subset. This field is useful for getting statistics
                    /// about conversations with specific properties.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "calculateStats";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+location}/conversations:calculateStats";

                    /// <summary>Initializes CalculateStats parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("location", new Google.Apis.Discovery.Parameter
                        {
                            Name = "location",
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
                    }
                }

                /// <summary>Creates a conversation.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. The parent resource of the conversation.</param>
                public virtual CreateRequest Create(Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1Conversation body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Creates a conversation.</summary>
                public class CreateRequest : ContactcenterinsightsBaseServiceRequest<Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1Conversation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1Conversation body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The parent resource of the conversation.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// A unique ID for the new conversation. This ID will become the final component of the
                    /// conversation's resource name. If no ID is specified, a server-generated ID will be used. This
                    /// value should be 4-64 characters and must match the regular expression `^[a-z0-9-]{4,64}$`. Valid
                    /// characters are `a-z-`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("conversationId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ConversationId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1Conversation Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/conversations";

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
                        RequestParameters.Add("conversationId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "conversationId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a conversation.</summary>
                /// <param name="name">Required. The name of the conversation to delete.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>Deletes a conversation.</summary>
                public class DeleteRequest : ContactcenterinsightsBaseServiceRequest<Google.Apis.Contactcenterinsights.v1.Data.GoogleProtobufEmpty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the conversation to delete.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// If set to true, all of this conversation's analyses will also be deleted. Otherwise, the request
                    /// will only succeed if the conversation has no analyses.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("force", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> Force { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/conversations/[^/]+$",
                        });
                        RequestParameters.Add("force", new Google.Apis.Discovery.Parameter
                        {
                            Name = "force",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Gets a conversation.</summary>
                /// <param name="name">Required. The name of the conversation to get.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Gets a conversation.</summary>
                public class GetRequest : ContactcenterinsightsBaseServiceRequest<Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1Conversation>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the conversation to get.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>The level of details of the conversation. Default is `FULL`.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<ViewEnum> View { get; set; }

                    /// <summary>The level of details of the conversation. Default is `FULL`.</summary>
                    public enum ViewEnum
                    {
                        /// <summary>
                        /// The conversation view is not specified. * Defaults to `FULL` in `GetConversationRequest`. *
                        /// Defaults to `BASIC` in `ListConversationsRequest`.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("CONVERSATION_VIEW_UNSPECIFIED")]
                        CONVERSATIONVIEWUNSPECIFIED = 0,

                        /// <summary>Populates all fields in the conversation.</summary>
                        [Google.Apis.Util.StringValueAttribute("FULL")]
                        FULL = 2,

                        /// <summary>Populates all fields in the conversation except the transcript.</summary>
                        [Google.Apis.Util.StringValueAttribute("BASIC")]
                        BASIC = 1,
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/conversations/[^/]+$",
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

                /// <summary>Imports conversations and processes them according to the user's configuration.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. The parent resource for new conversations.</param>
                public virtual IngestRequest Ingest(Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1IngestConversationsRequest body, string parent)
                {
                    return new IngestRequest(service, body, parent);
                }

                /// <summary>Imports conversations and processes them according to the user's configuration.</summary>
                public class IngestRequest : ContactcenterinsightsBaseServiceRequest<Google.Apis.Contactcenterinsights.v1.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Ingest request.</summary>
                    public IngestRequest(Google.Apis.Services.IClientService service, Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1IngestConversationsRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The parent resource for new conversations.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1IngestConversationsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "ingest";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/conversations:ingest";

                    /// <summary>Initializes Ingest parameter list.</summary>
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

                /// <summary>Lists conversations.</summary>
                /// <param name="parent">Required. The parent resource of the conversation.</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists conversations.</summary>
                public class ListRequest : ContactcenterinsightsBaseServiceRequest<Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1ListConversationsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. The parent resource of the conversation.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// A filter to reduce results to a specific subset. Useful for querying conversations with specific
                    /// properties.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// The maximum number of conversations to return in the response. A valid page size ranges from 0
                    /// to 1,000 inclusive. If the page size is zero or unspecified, a default page size of 100 will be
                    /// chosen. Note that a call might return fewer results than the requested page size.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// The value returned by the last `ListConversationsResponse`. This value indicates that this is a
                    /// continuation of a prior `ListConversations` call and that the system should return the next page
                    /// of data.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>The level of details of the conversation. Default is `BASIC`.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<ViewEnum> View { get; set; }

                    /// <summary>The level of details of the conversation. Default is `BASIC`.</summary>
                    public enum ViewEnum
                    {
                        /// <summary>
                        /// The conversation view is not specified. * Defaults to `FULL` in `GetConversationRequest`. *
                        /// Defaults to `BASIC` in `ListConversationsRequest`.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("CONVERSATION_VIEW_UNSPECIFIED")]
                        CONVERSATIONVIEWUNSPECIFIED = 0,

                        /// <summary>Populates all fields in the conversation.</summary>
                        [Google.Apis.Util.StringValueAttribute("FULL")]
                        FULL = 2,

                        /// <summary>Populates all fields in the conversation except the transcript.</summary>
                        [Google.Apis.Util.StringValueAttribute("BASIC")]
                        BASIC = 1,
                    }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/conversations";

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

                /// <summary>Updates a conversation.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Immutable. The resource name of the conversation. Format:
                /// projects/{project}/locations/{location}/conversations/{conversation}
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1Conversation body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>Updates a conversation.</summary>
                public class PatchRequest : ContactcenterinsightsBaseServiceRequest<Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1Conversation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1Conversation body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Immutable. The resource name of the conversation. Format:
                    /// projects/{project}/locations/{location}/conversations/{conversation}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>The list of fields to be updated.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1Conversation Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/conversations/[^/]+$",
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

            /// <summary>Gets the Insightsdata resource.</summary>
            public virtual InsightsdataResource Insightsdata { get; }

            /// <summary>The "insightsdata" collection of methods.</summary>
            public class InsightsdataResource
            {
                private const string Resource = "insightsdata";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public InsightsdataResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Export insights data to a destination defined in the request body.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. The parent resource to export data from.</param>
                public virtual ExportRequest Export(Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1ExportInsightsDataRequest body, string parent)
                {
                    return new ExportRequest(service, body, parent);
                }

                /// <summary>Export insights data to a destination defined in the request body.</summary>
                public class ExportRequest : ContactcenterinsightsBaseServiceRequest<Google.Apis.Contactcenterinsights.v1.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Export request.</summary>
                    public ExportRequest(Google.Apis.Services.IClientService service, Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1ExportInsightsDataRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The parent resource to export data from.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1ExportInsightsDataRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "export";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/insightsdata:export";

                    /// <summary>Initializes Export parameter list.</summary>
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
            }

            /// <summary>Gets the IssueModels resource.</summary>
            public virtual IssueModelsResource IssueModels { get; }

            /// <summary>The "issueModels" collection of methods.</summary>
            public class IssueModelsResource
            {
                private const string Resource = "issueModels";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public IssueModelsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Issues = new IssuesResource(service);
                }

                /// <summary>Gets the Issues resource.</summary>
                public virtual IssuesResource Issues { get; }

                /// <summary>The "issues" collection of methods.</summary>
                public class IssuesResource
                {
                    private const string Resource = "issues";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public IssuesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Deletes an issue.</summary>
                    /// <param name="name">Required. The name of the issue to delete.</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>Deletes an issue.</summary>
                    public class DeleteRequest : ContactcenterinsightsBaseServiceRequest<Google.Apis.Contactcenterinsights.v1.Data.GoogleProtobufEmpty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the issue to delete.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/issueModels/[^/]+/issues/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets an issue.</summary>
                    /// <param name="name">Required. The name of the issue to get.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Gets an issue.</summary>
                    public class GetRequest : ContactcenterinsightsBaseServiceRequest<Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1Issue>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the issue to get.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/issueModels/[^/]+/issues/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists issues.</summary>
                    /// <param name="parent">Required. The parent resource of the issue.</param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Lists issues.</summary>
                    public class ListRequest : ContactcenterinsightsBaseServiceRequest<Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1ListIssuesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>Required. The parent resource of the issue.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/issues";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/issueModels/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Updates an issue.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Immutable. The resource name of the issue. Format:
                    /// projects/{project}/locations/{location}/issueModels/{issue_model}/issues/{issue}
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1Issue body, string name)
                    {
                        return new PatchRequest(service, body, name);
                    }

                    /// <summary>Updates an issue.</summary>
                    public class PatchRequest : ContactcenterinsightsBaseServiceRequest<Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1Issue>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1Issue body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Immutable. The resource name of the issue. Format:
                        /// projects/{project}/locations/{location}/issueModels/{issue_model}/issues/{issue}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>The list of fields to be updated.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1Issue Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/issueModels/[^/]+/issues/[^/]+$",
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

                /// <summary>Gets an issue model's statistics.</summary>
                /// <param name="issueModel">Required. The resource name of the issue model to query against.</param>
                public virtual CalculateIssueModelStatsRequest CalculateIssueModelStats(string issueModel)
                {
                    return new CalculateIssueModelStatsRequest(service, issueModel);
                }

                /// <summary>Gets an issue model's statistics.</summary>
                public class CalculateIssueModelStatsRequest : ContactcenterinsightsBaseServiceRequest<Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1CalculateIssueModelStatsResponse>
                {
                    /// <summary>Constructs a new CalculateIssueModelStats request.</summary>
                    public CalculateIssueModelStatsRequest(Google.Apis.Services.IClientService service, string issueModel) : base(service)
                    {
                        IssueModel = issueModel;
                        InitParameters();
                    }

                    /// <summary>Required. The resource name of the issue model to query against.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("issueModel", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string IssueModel { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "calculateIssueModelStats";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+issueModel}:calculateIssueModelStats";

                    /// <summary>Initializes CalculateIssueModelStats parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("issueModel", new Google.Apis.Discovery.Parameter
                        {
                            Name = "issueModel",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/issueModels/[^/]+$",
                        });
                    }
                }

                /// <summary>Creates an issue model.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. The parent resource of the issue model.</param>
                public virtual CreateRequest Create(Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1IssueModel body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Creates an issue model.</summary>
                public class CreateRequest : ContactcenterinsightsBaseServiceRequest<Google.Apis.Contactcenterinsights.v1.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1IssueModel body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The parent resource of the issue model.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1IssueModel Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/issueModels";

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
                    }
                }

                /// <summary>Deletes an issue model.</summary>
                /// <param name="name">Required. The name of the issue model to delete.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>Deletes an issue model.</summary>
                public class DeleteRequest : ContactcenterinsightsBaseServiceRequest<Google.Apis.Contactcenterinsights.v1.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the issue model to delete.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/issueModels/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Deploys an issue model. Returns an error if a model is already deployed. An issue model can only be
                /// used in analysis after it has been deployed.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Required. The issue model to deploy.</param>
                public virtual DeployRequest Deploy(Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1DeployIssueModelRequest body, string name)
                {
                    return new DeployRequest(service, body, name);
                }

                /// <summary>
                /// Deploys an issue model. Returns an error if a model is already deployed. An issue model can only be
                /// used in analysis after it has been deployed.
                /// </summary>
                public class DeployRequest : ContactcenterinsightsBaseServiceRequest<Google.Apis.Contactcenterinsights.v1.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Deploy request.</summary>
                    public DeployRequest(Google.Apis.Services.IClientService service, Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1DeployIssueModelRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The issue model to deploy.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1DeployIssueModelRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "deploy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:deploy";

                    /// <summary>Initializes Deploy parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/issueModels/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets an issue model.</summary>
                /// <param name="name">Required. The name of the issue model to get.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Gets an issue model.</summary>
                public class GetRequest : ContactcenterinsightsBaseServiceRequest<Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1IssueModel>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the issue model to get.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/issueModels/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists issue models.</summary>
                /// <param name="parent">Required. The parent resource of the issue model.</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists issue models.</summary>
                public class ListRequest : ContactcenterinsightsBaseServiceRequest<Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1ListIssueModelsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. The parent resource of the issue model.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/issueModels";

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
                    }
                }

                /// <summary>Updates an issue model.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Immutable. The resource name of the issue model. Format:
                /// projects/{project}/locations/{location}/issueModels/{issue_model}
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1IssueModel body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>Updates an issue model.</summary>
                public class PatchRequest : ContactcenterinsightsBaseServiceRequest<Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1IssueModel>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1IssueModel body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Immutable. The resource name of the issue model. Format:
                    /// projects/{project}/locations/{location}/issueModels/{issue_model}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>The list of fields to be updated.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1IssueModel Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/issueModels/[^/]+$",
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
                /// Undeploys an issue model. An issue model can not be used in analysis after it has been undeployed.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Required. The issue model to undeploy.</param>
                public virtual UndeployRequest Undeploy(Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1UndeployIssueModelRequest body, string name)
                {
                    return new UndeployRequest(service, body, name);
                }

                /// <summary>
                /// Undeploys an issue model. An issue model can not be used in analysis after it has been undeployed.
                /// </summary>
                public class UndeployRequest : ContactcenterinsightsBaseServiceRequest<Google.Apis.Contactcenterinsights.v1.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Undeploy request.</summary>
                    public UndeployRequest(Google.Apis.Services.IClientService service, Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1UndeployIssueModelRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The issue model to undeploy.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1UndeployIssueModelRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "undeploy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:undeploy";

                    /// <summary>Initializes Undeploy parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/issueModels/[^/]+$",
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
                /// <param name="name">The name of the operation resource to be cancelled.</param>
                public virtual CancelRequest Cancel(string name)
                {
                    return new CancelRequest(service, name);
                }

                /// <summary>
                /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to
                /// cancel the operation, but success is not guaranteed. If the server doesn't support this method, it
                /// returns `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other methods to
                /// check whether the cancellation succeeded or whether the operation completed despite cancellation. On
                /// successful cancellation, the operation is not deleted; instead, it becomes an operation with an
                /// Operation.error value with a google.rpc.Status.code of 1, corresponding to `Code.CANCELLED`.
                /// </summary>
                public class CancelRequest : ContactcenterinsightsBaseServiceRequest<Google.Apis.Contactcenterinsights.v1.Data.GoogleProtobufEmpty>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to be cancelled.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

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
                public class GetRequest : ContactcenterinsightsBaseServiceRequest<Google.Apis.Contactcenterinsights.v1.Data.GoogleLongrunningOperation>
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
                public class ListRequest : ContactcenterinsightsBaseServiceRequest<Google.Apis.Contactcenterinsights.v1.Data.GoogleLongrunningListOperationsResponse>
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

            /// <summary>Gets the PhraseMatchers resource.</summary>
            public virtual PhraseMatchersResource PhraseMatchers { get; }

            /// <summary>The "phraseMatchers" collection of methods.</summary>
            public class PhraseMatchersResource
            {
                private const string Resource = "phraseMatchers";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public PhraseMatchersResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a phrase matcher.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource of the phrase matcher. Required. The location to create a phrase
                /// matcher for. Format: `projects//locations/` or `projects//locations/`
                /// </param>
                public virtual CreateRequest Create(Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1PhraseMatcher body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Creates a phrase matcher.</summary>
                public class CreateRequest : ContactcenterinsightsBaseServiceRequest<Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1PhraseMatcher>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1PhraseMatcher body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource of the phrase matcher. Required. The location to create a phrase
                    /// matcher for. Format: `projects//locations/` or `projects//locations/`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1PhraseMatcher Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/phraseMatchers";

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
                    }
                }

                /// <summary>Deletes a phrase matcher.</summary>
                /// <param name="name">Required. The name of the phrase matcher to delete.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>Deletes a phrase matcher.</summary>
                public class DeleteRequest : ContactcenterinsightsBaseServiceRequest<Google.Apis.Contactcenterinsights.v1.Data.GoogleProtobufEmpty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the phrase matcher to delete.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/phraseMatchers/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets a phrase matcher.</summary>
                /// <param name="name">Required. The name of the phrase matcher to get.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Gets a phrase matcher.</summary>
                public class GetRequest : ContactcenterinsightsBaseServiceRequest<Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1PhraseMatcher>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the phrase matcher to get.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/phraseMatchers/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists phrase matchers.</summary>
                /// <param name="parent">Required. The parent resource of the phrase matcher.</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists phrase matchers.</summary>
                public class ListRequest : ContactcenterinsightsBaseServiceRequest<Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1ListPhraseMatchersResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. The parent resource of the phrase matcher.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// A filter to reduce results to a specific subset. Useful for querying phrase matchers with
                    /// specific properties.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// The maximum number of phrase matchers to return in the response. If this value is zero, the
                    /// service will select a default size. A call might return fewer objects than requested. A
                    /// non-empty `next_page_token` in the response indicates that more data is available.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// The value returned by the last `ListPhraseMatchersResponse`. This value indicates that this is a
                    /// continuation of a prior `ListPhraseMatchers` call and that the system should return the next
                    /// page of data.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/phraseMatchers";

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

                /// <summary>Updates a phrase matcher.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The resource name of the phrase matcher. Format:
                /// projects/{project}/locations/{location}/phraseMatchers/{phrase_matcher}
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1PhraseMatcher body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>Updates a phrase matcher.</summary>
                public class PatchRequest : ContactcenterinsightsBaseServiceRequest<Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1PhraseMatcher>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1PhraseMatcher body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The resource name of the phrase matcher. Format:
                    /// projects/{project}/locations/{location}/phraseMatchers/{phrase_matcher}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>The list of fields to be updated.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1PhraseMatcher Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/phraseMatchers/[^/]+$",
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

            /// <summary>Gets the Views resource.</summary>
            public virtual ViewsResource Views { get; }

            /// <summary>The "views" collection of methods.</summary>
            public class ViewsResource
            {
                private const string Resource = "views";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ViewsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a view.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource of the view. Required. The location to create a view for. Format:
                /// `projects//locations/` or `projects//locations/`
                /// </param>
                public virtual CreateRequest Create(Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1View body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Creates a view.</summary>
                public class CreateRequest : ContactcenterinsightsBaseServiceRequest<Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1View>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1View body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource of the view. Required. The location to create a view for. Format:
                    /// `projects//locations/` or `projects//locations/`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1View Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/views";

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
                    }
                }

                /// <summary>Deletes a view.</summary>
                /// <param name="name">Required. The name of the view to delete.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>Deletes a view.</summary>
                public class DeleteRequest : ContactcenterinsightsBaseServiceRequest<Google.Apis.Contactcenterinsights.v1.Data.GoogleProtobufEmpty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the view to delete.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/views/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets a view.</summary>
                /// <param name="name">Required. The name of the view to get.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Gets a view.</summary>
                public class GetRequest : ContactcenterinsightsBaseServiceRequest<Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1View>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the view to get.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/views/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists views.</summary>
                /// <param name="parent">Required. The parent resource of the views.</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists views.</summary>
                public class ListRequest : ContactcenterinsightsBaseServiceRequest<Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1ListViewsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. The parent resource of the views.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// The maximum number of views to return in the response. If this value is zero, the service will
                    /// select a default size. A call may return fewer objects than requested. A non-empty
                    /// `next_page_token` in the response indicates that more data is available.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// The value returned by the last `ListViewsResponse`; indicates that this is a continuation of a
                    /// prior `ListViews` call and the system should return the next page of data.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/views";

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

                /// <summary>Updates a view.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Immutable. The resource name of the view. Format:
                /// projects/{project}/locations/{location}/views/{view}
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1View body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>Updates a view.</summary>
                public class PatchRequest : ContactcenterinsightsBaseServiceRequest<Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1View>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1View body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Immutable. The resource name of the view. Format:
                    /// projects/{project}/locations/{location}/views/{view}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>The list of fields to be updated.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1View Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/views/[^/]+$",
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

            /// <summary>Gets project-level settings.</summary>
            /// <param name="name">Required. The name of the settings resource to get.</param>
            public virtual GetSettingsRequest GetSettings(string name)
            {
                return new GetSettingsRequest(service, name);
            }

            /// <summary>Gets project-level settings.</summary>
            public class GetSettingsRequest : ContactcenterinsightsBaseServiceRequest<Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1Settings>
            {
                /// <summary>Constructs a new GetSettings request.</summary>
                public GetSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. The name of the settings resource to get.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getSettings";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes GetSettings parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/locations/[^/]+/settings$",
                    });
                }
            }

            /// <summary>Updates project-level settings.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Immutable. The resource name of the settings resource. Format:
            /// projects/{project}/locations/{location}/settings
            /// </param>
            public virtual UpdateSettingsRequest UpdateSettings(Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1Settings body, string name)
            {
                return new UpdateSettingsRequest(service, body, name);
            }

            /// <summary>Updates project-level settings.</summary>
            public class UpdateSettingsRequest : ContactcenterinsightsBaseServiceRequest<Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1Settings>
            {
                /// <summary>Constructs a new UpdateSettings request.</summary>
                public UpdateSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1Settings body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Immutable. The resource name of the settings resource. Format:
                /// projects/{project}/locations/{location}/settings
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Required. The list of fields to be updated.</summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Contactcenterinsights.v1.Data.GoogleCloudContactcenterinsightsV1Settings Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "updateSettings";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes UpdateSettings parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/locations/[^/]+/settings$",
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
namespace Google.Apis.Contactcenterinsights.v1.Data
{
    /// <summary>The analysis resource.</summary>
    public class GoogleCloudContactcenterinsightsV1Analysis : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The result of the analysis, which is populated when the analysis finishes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("analysisResult")]
        public virtual GoogleCloudContactcenterinsightsV1AnalysisResult AnalysisResult { get; set; }

        /// <summary>
        /// To select the annotators to run and the phrase matchers to use (if any). If not specified, all annotators
        /// will be run.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotatorSelector")]
        public virtual GoogleCloudContactcenterinsightsV1AnnotatorSelector AnnotatorSelector { get; set; }

        /// <summary>
        /// Output only. The time at which the analysis was created, which occurs when the long-running operation
        /// completes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Immutable. The resource name of the analysis. Format:
        /// projects/{project}/locations/{location}/conversations/{conversation}/analyses/{analysis}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The time at which the analysis was requested.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestTime")]
        public virtual object RequestTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The result of an analysis.</summary>
    public class GoogleCloudContactcenterinsightsV1AnalysisResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Call-specific metadata created by the analysis.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("callAnalysisMetadata")]
        public virtual GoogleCloudContactcenterinsightsV1AnalysisResultCallAnalysisMetadata CallAnalysisMetadata { get; set; }

        /// <summary>The time at which the analysis ended.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Call-specific metadata created during analysis.</summary>
    public class GoogleCloudContactcenterinsightsV1AnalysisResultCallAnalysisMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of call annotations that apply to this call.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudContactcenterinsightsV1CallAnnotation> Annotations { get; set; }

        /// <summary>All the entities in the call.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entities")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudContactcenterinsightsV1Entity> Entities { get; set; }

        /// <summary>All the matched intents in the call.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intents")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudContactcenterinsightsV1Intent> Intents { get; set; }

        /// <summary>Overall conversation-level issue modeling result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issueModelResult")]
        public virtual GoogleCloudContactcenterinsightsV1IssueModelResult IssueModelResult { get; set; }

        /// <summary>All the matched phrase matchers in the call.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phraseMatchers")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudContactcenterinsightsV1PhraseMatchData> PhraseMatchers { get; set; }

        /// <summary>Overall conversation-level sentiment for each channel of the call.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sentiments")]
        public virtual System.Collections.Generic.IList<GoogleCloudContactcenterinsightsV1ConversationLevelSentiment> Sentiments { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A point in a conversation that marks the start or the end of an annotation.</summary>
    public class GoogleCloudContactcenterinsightsV1AnnotationBoundary : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The index in the sequence of transcribed pieces of the conversation where the boundary is located. This
        /// index starts at zero.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transcriptIndex")]
        public virtual System.Nullable<int> TranscriptIndex { get; set; }

        /// <summary>
        /// The word index of this boundary with respect to the first word in the transcript piece. This index starts at
        /// zero.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wordIndex")]
        public virtual System.Nullable<int> WordIndex { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Selector of all available annotators and phrase matchers to run.</summary>
    public class GoogleCloudContactcenterinsightsV1AnnotatorSelector : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The issue model to run. If not provided, the most recently deployed topic model will be used. The provided
        /// issue model will only be used for inference if the issue model is deployed and if run_issue_model_annotator
        /// is set to true. If more than one issue model is provided, only the first provided issue model will be used
        /// for inference.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issueModels")]
        public virtual System.Collections.Generic.IList<string> IssueModels { get; set; }

        /// <summary>
        /// The list of phrase matchers to run. If not provided, all active phrase matchers will be used. If inactive
        /// phrase matchers are provided, they will not be used. Phrase matchers will be run only if
        /// run_phrase_matcher_annotator is set to true. Format:
        /// projects/{project}/locations/{location}/phraseMatchers/{phrase_matcher}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phraseMatchers")]
        public virtual System.Collections.Generic.IList<string> PhraseMatchers { get; set; }

        /// <summary>Whether to run the entity annotator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runEntityAnnotator")]
        public virtual System.Nullable<bool> RunEntityAnnotator { get; set; }

        /// <summary>Whether to run the intent annotator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runIntentAnnotator")]
        public virtual System.Nullable<bool> RunIntentAnnotator { get; set; }

        /// <summary>Whether to run the interruption annotator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runInterruptionAnnotator")]
        public virtual System.Nullable<bool> RunInterruptionAnnotator { get; set; }

        /// <summary>
        /// Whether to run the issue model annotator. A model should have already been deployed for this to take effect.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runIssueModelAnnotator")]
        public virtual System.Nullable<bool> RunIssueModelAnnotator { get; set; }

        /// <summary>Whether to run the active phrase matcher annotator(s).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runPhraseMatcherAnnotator")]
        public virtual System.Nullable<bool> RunPhraseMatcherAnnotator { get; set; }

        /// <summary>Whether to run the sentiment annotator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runSentimentAnnotator")]
        public virtual System.Nullable<bool> RunSentimentAnnotator { get; set; }

        /// <summary>Whether to run the silence annotator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runSilenceAnnotator")]
        public virtual System.Nullable<bool> RunSilenceAnnotator { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The feedback that the customer has about a certain answer in the conversation.</summary>
    public class GoogleCloudContactcenterinsightsV1AnswerFeedback : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicates whether an answer or item was clicked by the human agent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clicked")]
        public virtual System.Nullable<bool> Clicked { get; set; }

        /// <summary>The correctness level of an answer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("correctnessLevel")]
        public virtual string CorrectnessLevel { get; set; }

        /// <summary>
        /// Indicates whether an answer or item was displayed to the human agent in the agent desktop UI.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayed")]
        public virtual System.Nullable<bool> Displayed { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Agent Assist Article Suggestion data.</summary>
    public class GoogleCloudContactcenterinsightsV1ArticleSuggestionData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The system's confidence score that this article is a good match for this conversation, ranging from 0.0
        /// (completely uncertain) to 1.0 (completely certain).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidenceScore")]
        public virtual System.Nullable<float> ConfidenceScore { get; set; }

        /// <summary>
        /// Map that contains metadata about the Article Suggestion and the document that it originates from.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The name of the answer record. Format: projects/{project}/locations/{location}/answerRecords/{answer_record}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryRecord")]
        public virtual string QueryRecord { get; set; }

        /// <summary>
        /// The knowledge document that this answer was extracted from. Format:
        /// projects/{project}/knowledgeBases/{knowledge_base}/documents/{document}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual string Source { get; set; }

        /// <summary>Article title.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>Article URI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The metadata for a bulk analyze conversations operation.</summary>
    public class GoogleCloudContactcenterinsightsV1BulkAnalyzeConversationsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of requested analyses that have completed successfully so far.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completedAnalysesCount")]
        public virtual System.Nullable<int> CompletedAnalysesCount { get; set; }

        /// <summary>The time the operation was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>The time the operation finished running.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>The number of requested analyses that have failed so far.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failedAnalysesCount")]
        public virtual System.Nullable<int> FailedAnalysesCount { get; set; }

        /// <summary>The original request for bulk analyze.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("request")]
        public virtual GoogleCloudContactcenterinsightsV1BulkAnalyzeConversationsRequest Request { get; set; }

        /// <summary>
        /// Total number of analyses requested. Computed by the number of conversations returned by `filter` multiplied
        /// by `analysis_percentage` in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalRequestedAnalysesCount")]
        public virtual System.Nullable<int> TotalRequestedAnalysesCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request to analyze conversations in bulk.</summary>
    public class GoogleCloudContactcenterinsightsV1BulkAnalyzeConversationsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Percentage of selected conversation to analyze, between [0, 100].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("analysisPercentage")]
        public virtual System.Nullable<float> AnalysisPercentage { get; set; }

        /// <summary>
        /// To select the annotators to run and the phrase matchers to use (if any). If not specified, all annotators
        /// will be run.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotatorSelector")]
        public virtual GoogleCloudContactcenterinsightsV1AnnotatorSelector AnnotatorSelector { get; set; }

        /// <summary>Required. Filter used to select the subset of conversations to analyze.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>Required. The parent resource to create analyses in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for a bulk analyze conversations operation.</summary>
    public class GoogleCloudContactcenterinsightsV1BulkAnalyzeConversationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Count of failed analyses.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failedAnalysisCount")]
        public virtual System.Nullable<int> FailedAnalysisCount { get; set; }

        /// <summary>Count of successful analyses.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("successfulAnalysisCount")]
        public virtual System.Nullable<int> SuccessfulAnalysisCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response of querying an issue model's statistics.</summary>
    public class GoogleCloudContactcenterinsightsV1CalculateIssueModelStatsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The latest label statistics for the queried issue model. Includes results on both training data and data
        /// labeled after deployment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentStats")]
        public virtual GoogleCloudContactcenterinsightsV1IssueModelLabelStats CurrentStats { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for calculating conversation statistics.</summary>
    public class GoogleCloudContactcenterinsightsV1CalculateStatsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The average duration of all conversations. The average is calculated using only conversations that have a
        /// time duration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("averageDuration")]
        public virtual object AverageDuration { get; set; }

        /// <summary>The average number of turns per conversation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("averageTurnCount")]
        public virtual System.Nullable<int> AverageTurnCount { get; set; }

        /// <summary>The total number of conversations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conversationCount")]
        public virtual System.Nullable<int> ConversationCount { get; set; }

        /// <summary>
        /// A time series representing the count of conversations created over time that match that requested filter
        /// criteria.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conversationCountTimeSeries")]
        public virtual GoogleCloudContactcenterinsightsV1CalculateStatsResponseTimeSeries ConversationCountTimeSeries { get; set; }

        /// <summary>
        /// A map associating each custom highlighter resource name with its respective number of matches in the set of
        /// conversations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customHighlighterMatches")]
        public virtual System.Collections.Generic.IDictionary<string, System.Nullable<int>> CustomHighlighterMatches { get; set; }

        /// <summary>
        /// A map associating each issue resource name with its respective number of matches in the set of
        /// conversations. Key has the format: `projects//locations//issueModels//issues/` Deprecated, use
        /// `issue_matches_stats` field instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issueMatches")]
        public virtual System.Collections.Generic.IDictionary<string, System.Nullable<int>> IssueMatches { get; set; }

        /// <summary>
        /// A map associating each issue resource name with its respective number of matches in the set of
        /// conversations. Key has the format: `projects//locations//issueModels//issues/`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issueMatchesStats")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudContactcenterinsightsV1IssueModelLabelStatsIssueStats> IssueMatchesStats { get; set; }

        /// <summary>
        /// A map associating each smart highlighter display name with its respective number of matches in the set of
        /// conversations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("smartHighlighterMatches")]
        public virtual System.Collections.Generic.IDictionary<string, System.Nullable<int>> SmartHighlighterMatches { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A time series representing conversations over time.</summary>
    public class GoogleCloudContactcenterinsightsV1CalculateStatsResponseTimeSeries : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The duration of each interval.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intervalDuration")]
        public virtual object IntervalDuration { get; set; }

        /// <summary>
        /// An ordered list of intervals from earliest to latest, where each interval represents the number of
        /// conversations that transpired during the time window.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("points")]
        public virtual System.Collections.Generic.IList<GoogleCloudContactcenterinsightsV1CalculateStatsResponseTimeSeriesInterval> Points { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single interval in a time series.</summary>
    public class GoogleCloudContactcenterinsightsV1CalculateStatsResponseTimeSeriesInterval : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of conversations created in this interval.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conversationCount")]
        public virtual System.Nullable<int> ConversationCount { get; set; }

        /// <summary>The start time of this interval.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A piece of metadata that applies to a window of a call.</summary>
    public class GoogleCloudContactcenterinsightsV1CallAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The boundary in the conversation where the annotation ends, inclusive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationEndBoundary")]
        public virtual GoogleCloudContactcenterinsightsV1AnnotationBoundary AnnotationEndBoundary { get; set; }

        /// <summary>The boundary in the conversation where the annotation starts, inclusive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationStartBoundary")]
        public virtual GoogleCloudContactcenterinsightsV1AnnotationBoundary AnnotationStartBoundary { get; set; }

        /// <summary>
        /// The channel of the audio where the annotation occurs. For single-channel audio, this field is not populated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channelTag")]
        public virtual System.Nullable<int> ChannelTag { get; set; }

        /// <summary>Data specifying an entity mention.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityMentionData")]
        public virtual GoogleCloudContactcenterinsightsV1EntityMentionData EntityMentionData { get; set; }

        /// <summary>Data specifying a hold.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("holdData")]
        public virtual GoogleCloudContactcenterinsightsV1HoldData HoldData { get; set; }

        /// <summary>Data specifying an intent match.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intentMatchData")]
        public virtual GoogleCloudContactcenterinsightsV1IntentMatchData IntentMatchData { get; set; }

        /// <summary>Data specifying an interruption.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("interruptionData")]
        public virtual GoogleCloudContactcenterinsightsV1InterruptionData InterruptionData { get; set; }

        /// <summary>Data specifying an issue match.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issueMatchData")]
        public virtual GoogleCloudContactcenterinsightsV1IssueMatchData IssueMatchData { get; set; }

        /// <summary>Data specifying a phrase match.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phraseMatchData")]
        public virtual GoogleCloudContactcenterinsightsV1PhraseMatchData PhraseMatchData { get; set; }

        /// <summary>Data specifying sentiment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sentimentData")]
        public virtual GoogleCloudContactcenterinsightsV1SentimentData SentimentData { get; set; }

        /// <summary>Data specifying silence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("silenceData")]
        public virtual GoogleCloudContactcenterinsightsV1SilenceData SilenceData { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The conversation resource.</summary>
    public class GoogleCloudContactcenterinsightsV1Conversation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An opaque, user-specified string representing the human agent who handled the conversation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("agentId")]
        public virtual string AgentId { get; set; }

        /// <summary>Call-specific metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("callMetadata")]
        public virtual GoogleCloudContactcenterinsightsV1ConversationCallMetadata CallMetadata { get; set; }

        /// <summary>Output only. The time at which the conversation was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>The source of the audio and transcription for the conversation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSource")]
        public virtual GoogleCloudContactcenterinsightsV1ConversationDataSource DataSource { get; set; }

        /// <summary>
        /// Output only. All the matched Dialogflow intents in the call. The key corresponds to a Dialogflow intent,
        /// format: projects/{project}/agent/{agent}/intents/{intent}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dialogflowIntents")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudContactcenterinsightsV1DialogflowIntent> DialogflowIntents { get; set; }

        /// <summary>Output only. The duration of the conversation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual object Duration { get; set; }

        /// <summary>
        /// The time at which this conversation should expire. After this time, the conversation data and any associated
        /// analyses will be deleted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expireTime")]
        public virtual object ExpireTime { get; set; }

        /// <summary>
        /// A map for the user to specify any custom fields. A maximum of 20 labels per conversation is allowed, with a
        /// maximum of 256 characters per entry.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>A user-specified language code for the conversation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>Output only. The conversation's latest analysis, if one exists.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latestAnalysis")]
        public virtual GoogleCloudContactcenterinsightsV1Analysis LatestAnalysis { get; set; }

        /// <summary>Immutable. The conversation medium, if unspecified will default to PHONE_CALL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("medium")]
        public virtual string Medium { get; set; }

        /// <summary>
        /// Immutable. The resource name of the conversation. Format:
        /// projects/{project}/locations/{location}/conversations/{conversation}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Obfuscated user ID which the customer sent to us.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("obfuscatedUserId")]
        public virtual string ObfuscatedUserId { get; set; }

        /// <summary>
        /// Output only. The annotations that were generated during the customer and agent interaction.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runtimeAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudContactcenterinsightsV1RuntimeAnnotation> RuntimeAnnotations { get; set; }

        /// <summary>The time at which the conversation started.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>Output only. The conversation transcript.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transcript")]
        public virtual GoogleCloudContactcenterinsightsV1ConversationTranscript Transcript { get; set; }

        /// <summary>
        /// Input only. The TTL for this resource. If specified, then this TTL will be used to calculate the expire
        /// time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ttl")]
        public virtual object Ttl { get; set; }

        /// <summary>Output only. The number of turns in the conversation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("turnCount")]
        public virtual System.Nullable<int> TurnCount { get; set; }

        /// <summary>Output only. The most recent time at which the conversation was updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Call-specific metadata.</summary>
    public class GoogleCloudContactcenterinsightsV1ConversationCallMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The audio channel that contains the agent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("agentChannel")]
        public virtual System.Nullable<int> AgentChannel { get; set; }

        /// <summary>The audio channel that contains the customer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerChannel")]
        public virtual System.Nullable<int> CustomerChannel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The conversation source, which is a combination of transcript and audio.</summary>
    public class GoogleCloudContactcenterinsightsV1ConversationDataSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The source when the conversation comes from Dialogflow.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dialogflowSource")]
        public virtual GoogleCloudContactcenterinsightsV1DialogflowSource DialogflowSource { get; set; }

        /// <summary>A Cloud Storage location specification for the audio and transcript.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsSource")]
        public virtual GoogleCloudContactcenterinsightsV1GcsSource GcsSource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>One channel of conversation-level sentiment data.</summary>
    public class GoogleCloudContactcenterinsightsV1ConversationLevelSentiment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The channel of the audio that the data applies to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channelTag")]
        public virtual System.Nullable<int> ChannelTag { get; set; }

        /// <summary>Data specifying sentiment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sentimentData")]
        public virtual GoogleCloudContactcenterinsightsV1SentimentData SentimentData { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The call participant speaking for a given utterance.</summary>
    public class GoogleCloudContactcenterinsightsV1ConversationParticipant : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Deprecated. Use `dialogflow_participant_name` instead. The name of the Dialogflow participant. Format:
        /// projects/{project}/locations/{location}/conversations/{conversation}/participants/{participant}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dialogflowParticipant")]
        public virtual string DialogflowParticipant { get; set; }

        /// <summary>
        /// The name of the participant provided by Dialogflow. Format:
        /// projects/{project}/locations/{location}/conversations/{conversation}/participants/{participant}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dialogflowParticipantName")]
        public virtual string DialogflowParticipantName { get; set; }

        /// <summary>Obfuscated user ID from Dialogflow.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("obfuscatedExternalUserId")]
        public virtual string ObfuscatedExternalUserId { get; set; }

        /// <summary>The role of the participant.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>A user-specified ID representing the participant.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userId")]
        public virtual string UserId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A message representing the transcript of a conversation.</summary>
    public class GoogleCloudContactcenterinsightsV1ConversationTranscript : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of sequential transcript segments that comprise the conversation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transcriptSegments")]
        public virtual System.Collections.Generic.IList<GoogleCloudContactcenterinsightsV1ConversationTranscriptTranscriptSegment> TranscriptSegments { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A segment of a full transcript.</summary>
    public class GoogleCloudContactcenterinsightsV1ConversationTranscriptTranscriptSegment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// For conversations derived from multi-channel audio, this is the channel number corresponding to the audio
        /// from that channel. For audioChannelCount = N, its output values can range from '1' to 'N'. A channel tag of
        /// 0 indicates that the audio is mono.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channelTag")]
        public virtual System.Nullable<int> ChannelTag { get; set; }

        /// <summary>
        /// A confidence estimate between 0.0 and 1.0 of the fidelity of this segment. A default value of 0.0 indicates
        /// that the value is unset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>CCAI metadata relating to the current transcript segment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dialogflowSegmentMetadata")]
        public virtual GoogleCloudContactcenterinsightsV1ConversationTranscriptTranscriptSegmentDialogflowSegmentMetadata DialogflowSegmentMetadata { get; set; }

        /// <summary>
        /// The language code of this segment as a [BCP-47](https://www.rfc-editor.org/rfc/bcp/bcp47.txt) language tag.
        /// Example: "en-US".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>The time that the message occurred, if provided.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageTime")]
        public virtual object MessageTime { get; set; }

        /// <summary>The participant of this segment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segmentParticipant")]
        public virtual GoogleCloudContactcenterinsightsV1ConversationParticipant SegmentParticipant { get; set; }

        /// <summary>The sentiment for this transcript segment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sentiment")]
        public virtual GoogleCloudContactcenterinsightsV1SentimentData Sentiment { get; set; }

        /// <summary>The text of this segment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>A list of the word-specific information for each word in the segment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("words")]
        public virtual System.Collections.Generic.IList<GoogleCloudContactcenterinsightsV1ConversationTranscriptTranscriptSegmentWordInfo> Words { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata from Dialogflow relating to the current transcript segment.</summary>
    public class GoogleCloudContactcenterinsightsV1ConversationTranscriptTranscriptSegmentDialogflowSegmentMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether the transcript segment was covered under the configured smart reply allowlist in Agent Assist.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("smartReplyAllowlistCovered")]
        public virtual System.Nullable<bool> SmartReplyAllowlistCovered { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Word-level info for words in a transcript.</summary>
    public class GoogleCloudContactcenterinsightsV1ConversationTranscriptTranscriptSegmentWordInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A confidence estimate between 0.0 and 1.0 of the fidelity of this word. A default value of 0.0 indicates
        /// that the value is unset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>Time offset of the end of this word relative to the beginning of the total conversation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endOffset")]
        public virtual object EndOffset { get; set; }

        /// <summary>
        /// Time offset of the start of this word relative to the beginning of the total conversation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startOffset")]
        public virtual object StartOffset { get; set; }

        /// <summary>The word itself. Includes punctuation marks that surround the word.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("word")]
        public virtual string Word { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for a create analysis operation.</summary>
    public class GoogleCloudContactcenterinsightsV1CreateAnalysisOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The annotator selector used for the analysis (if any).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotatorSelector")]
        public virtual GoogleCloudContactcenterinsightsV1AnnotatorSelector AnnotatorSelector { get; set; }

        /// <summary>Output only. The Conversation that this Analysis Operation belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conversation")]
        public virtual string Conversation { get; set; }

        /// <summary>Output only. The time the operation was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. The time the operation finished running.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for creating an issue model.</summary>
    public class GoogleCloudContactcenterinsightsV1CreateIssueModelMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The time the operation was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. The time the operation finished running.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>The original request for creation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("request")]
        public virtual GoogleCloudContactcenterinsightsV1CreateIssueModelRequest Request { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request to create an issue model.</summary>
    public class GoogleCloudContactcenterinsightsV1CreateIssueModelRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The issue model to create.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issueModel")]
        public virtual GoogleCloudContactcenterinsightsV1IssueModel IssueModel { get; set; }

        /// <summary>Required. The parent resource of the issue model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for deleting an issue model.</summary>
    public class GoogleCloudContactcenterinsightsV1DeleteIssueModelMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The time the operation was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. The time the operation finished running.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>The original request for deletion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("request")]
        public virtual GoogleCloudContactcenterinsightsV1DeleteIssueModelRequest Request { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request to delete an issue model.</summary>
    public class GoogleCloudContactcenterinsightsV1DeleteIssueModelRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The name of the issue model to delete.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for deploying an issue model.</summary>
    public class GoogleCloudContactcenterinsightsV1DeployIssueModelMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The time the operation was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. The time the operation finished running.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>The original request for deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("request")]
        public virtual GoogleCloudContactcenterinsightsV1DeployIssueModelRequest Request { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request to deploy an issue model.</summary>
    public class GoogleCloudContactcenterinsightsV1DeployIssueModelRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The issue model to deploy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response to deploy an issue model.</summary>
    public class GoogleCloudContactcenterinsightsV1DeployIssueModelResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The data for a Dialogflow intent. Represents a detected intent in the conversation, e.g. MAKES_PROMISE.
    /// </summary>
    public class GoogleCloudContactcenterinsightsV1DialogflowIntent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The human-readable name of the intent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Dialogflow interaction data.</summary>
    public class GoogleCloudContactcenterinsightsV1DialogflowInteractionData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The confidence of the match ranging from 0.0 (completely uncertain) to 1.0 (completely certain).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>
        /// The Dialogflow intent resource path. Format: projects/{project}/agent/{agent}/intents/{intent}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dialogflowIntentId")]
        public virtual string DialogflowIntentId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Dialogflow source of conversation data.</summary>
    public class GoogleCloudContactcenterinsightsV1DialogflowSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Cloud Storage URI that points to a file that contains the conversation audio.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audioUri")]
        public virtual string AudioUri { get; set; }

        /// <summary>
        /// Output only. The name of the Dialogflow conversation that this conversation resource is derived from.
        /// Format: projects/{project}/locations/{location}/conversations/{conversation}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dialogflowConversation")]
        public virtual string DialogflowConversation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The data for an entity annotation. Represents a phrase in the conversation that is a known entity, such as a
    /// person, an organization, or location.
    /// </summary>
    public class GoogleCloudContactcenterinsightsV1Entity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The representative name for the entity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Metadata associated with the entity. For most entity types, the metadata is a Wikipedia URL
        /// (`wikipedia_url`) and Knowledge Graph MID (`mid`), if they are available. For the metadata associated with
        /// other entity types, see the Type table below.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The salience score associated with the entity in the [0, 1.0] range. The salience score for an entity
        /// provides information about the importance or centrality of that entity to the entire document text. Scores
        /// closer to 0 are less salient, while scores closer to 1.0 are highly salient.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("salience")]
        public virtual System.Nullable<float> Salience { get; set; }

        /// <summary>The aggregate sentiment expressed for this entity in the conversation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sentiment")]
        public virtual GoogleCloudContactcenterinsightsV1SentimentData Sentiment { get; set; }

        /// <summary>The entity type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The data for an entity mention annotation. This represents a mention of an `Entity` in the conversation.
    /// </summary>
    public class GoogleCloudContactcenterinsightsV1EntityMentionData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The key of this entity in conversation entities. Can be used to retrieve the exact `Entity` this mention is
        /// attached to.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityUniqueId")]
        public virtual string EntityUniqueId { get; set; }

        /// <summary>Sentiment expressed for this mention of the entity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sentiment")]
        public virtual GoogleCloudContactcenterinsightsV1SentimentData Sentiment { get; set; }

        /// <summary>The type of the entity mention.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Exact match configuration.</summary>
    public class GoogleCloudContactcenterinsightsV1ExactMatchConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether to consider case sensitivity when performing an exact match.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caseSensitive")]
        public virtual System.Nullable<bool> CaseSensitive { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for an export insights operation.</summary>
    public class GoogleCloudContactcenterinsightsV1ExportInsightsDataMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The time the operation was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. The time the operation finished running.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>
        /// Partial errors during export operation that might cause the operation output to be incomplete.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partialErrors")]
        public virtual System.Collections.Generic.IList<GoogleRpcStatus> PartialErrors { get; set; }

        /// <summary>The original request for export.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("request")]
        public virtual GoogleCloudContactcenterinsightsV1ExportInsightsDataRequest Request { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request to export insights.</summary>
    public class GoogleCloudContactcenterinsightsV1ExportInsightsDataRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specified if sink is a BigQuery table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bigQueryDestination")]
        public virtual GoogleCloudContactcenterinsightsV1ExportInsightsDataRequestBigQueryDestination BigQueryDestination { get; set; }

        /// <summary>
        /// A filter to reduce results to a specific subset. Useful for exporting conversations with specific
        /// properties.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>
        /// A fully qualified KMS key name for BigQuery tables protected by CMEK. Format:
        /// projects/{project}/locations/{location}/keyRings/{keyring}/cryptoKeys/{key}/cryptoKeyVersions/{version}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKey")]
        public virtual string KmsKey { get; set; }

        /// <summary>Required. The parent resource to export data from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>Options for what to do if the destination table already exists.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("writeDisposition")]
        public virtual string WriteDisposition { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A BigQuery Table Reference.</summary>
    public class GoogleCloudContactcenterinsightsV1ExportInsightsDataRequestBigQueryDestination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The name of the BigQuery dataset that the snapshot result should be exported to. If this dataset
        /// does not exist, the export call returns an INVALID_ARGUMENT error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataset")]
        public virtual string Dataset { get; set; }

        /// <summary>
        /// A project ID or number. If specified, then export will attempt to write data to this project instead of the
        /// resource project. Otherwise, the resource project will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>
        /// The BigQuery table name to which the insights data should be written. If this table does not exist, the
        /// export call returns an INVALID_ARGUMENT error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("table")]
        public virtual string Table { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for an export insights operation.</summary>
    public class GoogleCloudContactcenterinsightsV1ExportInsightsDataResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Agent Assist frequently-asked-question answer data.</summary>
    public class GoogleCloudContactcenterinsightsV1FaqAnswerData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The piece of text from the `source` knowledge base document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("answer")]
        public virtual string Answer { get; set; }

        /// <summary>
        /// The system's confidence score that this answer is a good match for this conversation, ranging from 0.0
        /// (completely uncertain) to 1.0 (completely certain).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidenceScore")]
        public virtual System.Nullable<float> ConfidenceScore { get; set; }

        /// <summary>Map that contains metadata about the FAQ answer and the document that it originates from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The name of the answer record. Format: projects/{project}/locations/{location}/answerRecords/{answer_record}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryRecord")]
        public virtual string QueryRecord { get; set; }

        /// <summary>The corresponding FAQ question.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("question")]
        public virtual string Question { get; set; }

        /// <summary>
        /// The knowledge document that this answer was extracted from. Format:
        /// projects/{project}/knowledgeBases/{knowledge_base}/documents/{document}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual string Source { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Cloud Storage source of conversation data.</summary>
    public class GoogleCloudContactcenterinsightsV1GcsSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Cloud Storage URI that points to a file that contains the conversation audio.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audioUri")]
        public virtual string AudioUri { get; set; }

        /// <summary>
        /// Immutable. Cloud Storage URI that points to a file that contains the conversation transcript.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transcriptUri")]
        public virtual string TranscriptUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The data for a hold annotation.</summary>
    public class GoogleCloudContactcenterinsightsV1HoldData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The metadata for an IngestConversations operation.</summary>
    public class GoogleCloudContactcenterinsightsV1IngestConversationsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The time the operation was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. The time the operation finished running.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>
        /// Output only. Partial errors during ingest operation that might cause the operation output to be incomplete.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partialErrors")]
        public virtual System.Collections.Generic.IList<GoogleRpcStatus> PartialErrors { get; set; }

        /// <summary>Output only. The original request for ingest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("request")]
        public virtual GoogleCloudContactcenterinsightsV1IngestConversationsRequest Request { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request to ingest conversations.</summary>
    public class GoogleCloudContactcenterinsightsV1IngestConversationsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Configuration that applies to all conversations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conversationConfig")]
        public virtual GoogleCloudContactcenterinsightsV1IngestConversationsRequestConversationConfig ConversationConfig { get; set; }

        /// <summary>A cloud storage bucket source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsSource")]
        public virtual GoogleCloudContactcenterinsightsV1IngestConversationsRequestGcsSource GcsSource { get; set; }

        /// <summary>Required. The parent resource for new conversations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>Configuration for when `source` contains conversation transcripts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transcriptObjectConfig")]
        public virtual GoogleCloudContactcenterinsightsV1IngestConversationsRequestTranscriptObjectConfig TranscriptObjectConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration that applies to all conversations.</summary>
    public class GoogleCloudContactcenterinsightsV1IngestConversationsRequestConversationConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An opaque, user-specified string representing the human agent who handled the conversations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("agentId")]
        public virtual string AgentId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for Cloud Storage bucket sources.</summary>
    public class GoogleCloudContactcenterinsightsV1IngestConversationsRequestGcsSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The Cloud Storage bucket containing source objects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucketUri")]
        public virtual string BucketUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for processing transcript objects.</summary>
    public class GoogleCloudContactcenterinsightsV1IngestConversationsRequestTranscriptObjectConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The medium transcript objects represent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("medium")]
        public virtual string Medium { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response to an IngestConversations operation.</summary>
    public class GoogleCloudContactcenterinsightsV1IngestConversationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The data for an intent. Represents a detected intent in the conversation, for example MAKES_PROMISE.
    /// </summary>
    public class GoogleCloudContactcenterinsightsV1Intent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The human-readable name of the intent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The unique identifier of the intent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The data for an intent match. Represents an intent match for a text segment in the conversation. A text segment
    /// can be part of a sentence, a complete sentence, or an utterance with multiple sentences.
    /// </summary>
    public class GoogleCloudContactcenterinsightsV1IntentMatchData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The id of the matched intent. Can be used to retrieve the corresponding intent information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intentUniqueId")]
        public virtual string IntentUniqueId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The data for an interruption annotation.</summary>
    public class GoogleCloudContactcenterinsightsV1InterruptionData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The issue resource.</summary>
    public class GoogleCloudContactcenterinsightsV1Issue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The time at which this issue was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>The representative name for the issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Immutable. The resource name of the issue. Format:
        /// projects/{project}/locations/{location}/issueModels/{issue_model}/issues/{issue}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. Resource names of the sample representative utterances that match to this issue.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sampleUtterances")]
        public virtual System.Collections.Generic.IList<string> SampleUtterances { get; set; }

        /// <summary>Output only. The most recent time that this issue was updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about the issue.</summary>
    public class GoogleCloudContactcenterinsightsV1IssueAssignment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Immutable. Display name of the assigned issue. This field is set at time of analyis and immutable since
        /// then.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Resource name of the assigned issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issue")]
        public virtual string Issue { get; set; }

        /// <summary>Score indicating the likelihood of the issue assignment. currently bounded on [0,1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual System.Nullable<double> Score { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The data for an issue match annotation.</summary>
    public class GoogleCloudContactcenterinsightsV1IssueMatchData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Information about the issue's assignment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issueAssignment")]
        public virtual GoogleCloudContactcenterinsightsV1IssueAssignment IssueAssignment { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The issue model resource.</summary>
    public class GoogleCloudContactcenterinsightsV1IssueModel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The time at which this issue model was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>The representative name for the issue model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Configs for the input data that used to create the issue model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputDataConfig")]
        public virtual GoogleCloudContactcenterinsightsV1IssueModelInputDataConfig InputDataConfig { get; set; }

        /// <summary>Output only. Number of issues in this issue model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issueCount")]
        public virtual System.Nullable<long> IssueCount { get; set; }

        /// <summary>
        /// Immutable. The resource name of the issue model. Format:
        /// projects/{project}/locations/{location}/issueModels/{issue_model}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. State of the model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. Immutable. The issue model's label statistics on its training data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trainingStats")]
        public virtual GoogleCloudContactcenterinsightsV1IssueModelLabelStats TrainingStats { get; set; }

        /// <summary>Output only. The most recent time at which the issue model was updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configs for the input data used to create the issue model.</summary>
    public class GoogleCloudContactcenterinsightsV1IssueModelInputDataConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A filter to reduce the conversations used for training the model to a specific subset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>
        /// Medium of conversations used in training data. This field is being deprecated. To specify the medium to be
        /// used in training a new issue model, set the `medium` field on `filter`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("medium")]
        public virtual string Medium { get; set; }

        /// <summary>Output only. Number of conversations used in training. Output only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trainingConversationsCount")]
        public virtual System.Nullable<long> TrainingConversationsCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Aggregated statistics about an issue model.</summary>
    public class GoogleCloudContactcenterinsightsV1IssueModelLabelStats : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of conversations the issue model has analyzed at this point in time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("analyzedConversationsCount")]
        public virtual System.Nullable<long> AnalyzedConversationsCount { get; set; }

        /// <summary>Statistics on each issue. Key is the issue's resource name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issueStats")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudContactcenterinsightsV1IssueModelLabelStatsIssueStats> IssueStats { get; set; }

        /// <summary>Number of analyzed conversations for which no issue was applicable at this point in time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unclassifiedConversationsCount")]
        public virtual System.Nullable<long> UnclassifiedConversationsCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Aggregated statistics about an issue.</summary>
    public class GoogleCloudContactcenterinsightsV1IssueModelLabelStatsIssueStats : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Display name of the issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Issue resource. Format: projects/{project}/locations/{location}/issueModels/{issue_model}/issues/{issue}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issue")]
        public virtual string Issue { get; set; }

        /// <summary>Number of conversations attached to the issue at this point in time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labeledConversationsCount")]
        public virtual System.Nullable<long> LabeledConversationsCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Issue Modeling result on a conversation.</summary>
    public class GoogleCloudContactcenterinsightsV1IssueModelResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Issue model that generates the result. Format:
        /// projects/{project}/locations/{location}/issueModels/{issue_model}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issueModel")]
        public virtual string IssueModel { get; set; }

        /// <summary>All the matched issues.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issues")]
        public virtual System.Collections.Generic.IList<GoogleCloudContactcenterinsightsV1IssueAssignment> Issues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response to list analyses.</summary>
    public class GoogleCloudContactcenterinsightsV1ListAnalysesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The analyses that match the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("analyses")]
        public virtual System.Collections.Generic.IList<GoogleCloudContactcenterinsightsV1Analysis> Analyses { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response of listing conversations.</summary>
    public class GoogleCloudContactcenterinsightsV1ListConversationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The conversations that match the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conversations")]
        public virtual System.Collections.Generic.IList<GoogleCloudContactcenterinsightsV1Conversation> Conversations { get; set; }

        /// <summary>
        /// A token which can be sent as `page_token` to retrieve the next page. If this field is set, it means there is
        /// another page available. If it is not set, it means no other pages are available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response of listing issue models.</summary>
    public class GoogleCloudContactcenterinsightsV1ListIssueModelsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The issue models that match the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issueModels")]
        public virtual System.Collections.Generic.IList<GoogleCloudContactcenterinsightsV1IssueModel> IssueModels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response of listing issues.</summary>
    public class GoogleCloudContactcenterinsightsV1ListIssuesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The issues that match the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issues")]
        public virtual System.Collections.Generic.IList<GoogleCloudContactcenterinsightsV1Issue> Issues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response of listing phrase matchers.</summary>
    public class GoogleCloudContactcenterinsightsV1ListPhraseMatchersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The phrase matchers that match the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phraseMatchers")]
        public virtual System.Collections.Generic.IList<GoogleCloudContactcenterinsightsV1PhraseMatcher> PhraseMatchers { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response of listing views.</summary>
    public class GoogleCloudContactcenterinsightsV1ListViewsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The views that match the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("views")]
        public virtual System.Collections.Generic.IList<GoogleCloudContactcenterinsightsV1View> Views { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The data for a matched phrase matcher. Represents information identifying a phrase matcher for a given match.
    /// </summary>
    public class GoogleCloudContactcenterinsightsV1PhraseMatchData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The human-readable name of the phrase matcher.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The unique identifier (the resource name) of the phrase matcher.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phraseMatcher")]
        public virtual string PhraseMatcher { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The data for a phrase match rule.</summary>
    public class GoogleCloudContactcenterinsightsV1PhraseMatchRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Provides additional information about the rule that specifies how to apply the rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual GoogleCloudContactcenterinsightsV1PhraseMatchRuleConfig Config { get; set; }

        /// <summary>
        /// Specifies whether the phrase must be missing from the transcript segment or present in the transcript
        /// segment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("negated")]
        public virtual System.Nullable<bool> Negated { get; set; }

        /// <summary>Required. The phrase to be matched.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual string Query { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration information of a phrase match rule.</summary>
    public class GoogleCloudContactcenterinsightsV1PhraseMatchRuleConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The configuration for the exact match rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exactMatchConfig")]
        public virtual GoogleCloudContactcenterinsightsV1ExactMatchConfig ExactMatchConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A message representing a rule in the phrase matcher.</summary>
    public class GoogleCloudContactcenterinsightsV1PhraseMatchRuleGroup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of phase match rules that are included in this group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phraseMatchRules")]
        public virtual System.Collections.Generic.IList<GoogleCloudContactcenterinsightsV1PhraseMatchRule> PhraseMatchRules { get; set; }

        /// <summary>Required. The type of this phrase match rule group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The phrase matcher resource.</summary>
    public class GoogleCloudContactcenterinsightsV1PhraseMatcher : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The most recent time at which the activation status was updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activationUpdateTime")]
        public virtual object ActivationUpdateTime { get; set; }

        /// <summary>Applies the phrase matcher only when it is active.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("active")]
        public virtual System.Nullable<bool> Active { get; set; }

        /// <summary>The human-readable name of the phrase matcher.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// The resource name of the phrase matcher. Format:
        /// projects/{project}/locations/{location}/phraseMatchers/{phrase_matcher}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>A list of phase match rule groups that are included in this matcher.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phraseMatchRuleGroups")]
        public virtual System.Collections.Generic.IList<GoogleCloudContactcenterinsightsV1PhraseMatchRuleGroup> PhraseMatchRuleGroups { get; set; }

        /// <summary>
        /// Output only. The timestamp of when the revision was created. It is also the create time when a new matcher
        /// is added.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionCreateTime")]
        public virtual object RevisionCreateTime { get; set; }

        /// <summary>
        /// Output only. Immutable. The revision ID of the phrase matcher. A new revision is committed whenever the
        /// matcher is changed, except when it is activated or deactivated. A server generated random ID will be used.
        /// Example: locations/global/phraseMatchers/my-first-matcher@1234567
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionId")]
        public virtual string RevisionId { get; set; }

        /// <summary>
        /// The role whose utterances the phrase matcher should be matched against. If the role is ROLE_UNSPECIFIED it
        /// will be matched against any utterances in the transcript.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roleMatch")]
        public virtual string RoleMatch { get; set; }

        /// <summary>Required. The type of this phrase matcher.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>Output only. The most recent time at which the phrase matcher was updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>
        /// The customized version tag to use for the phrase matcher. If not specified, it will default to
        /// `revision_id`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionTag")]
        public virtual string VersionTag { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An annotation that was generated during the customer and agent interaction.</summary>
    public class GoogleCloudContactcenterinsightsV1RuntimeAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The unique identifier of the annotation. Format:
        /// projects/{project}/locations/{location}/conversationDatasets/{dataset}/conversationDataItems/{data_item}/conversationAnnotations/{annotation}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationId")]
        public virtual string AnnotationId { get; set; }

        /// <summary>The feedback that the customer has about the answer in `data`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("answerFeedback")]
        public virtual GoogleCloudContactcenterinsightsV1AnswerFeedback AnswerFeedback { get; set; }

        /// <summary>Agent Assist Article Suggestion data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("articleSuggestion")]
        public virtual GoogleCloudContactcenterinsightsV1ArticleSuggestionData ArticleSuggestion { get; set; }

        /// <summary>The time at which this annotation was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Dialogflow interaction data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dialogflowInteraction")]
        public virtual GoogleCloudContactcenterinsightsV1DialogflowInteractionData DialogflowInteraction { get; set; }

        /// <summary>The boundary in the conversation where the annotation ends, inclusive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endBoundary")]
        public virtual GoogleCloudContactcenterinsightsV1AnnotationBoundary EndBoundary { get; set; }

        /// <summary>Agent Assist FAQ answer data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("faqAnswer")]
        public virtual GoogleCloudContactcenterinsightsV1FaqAnswerData FaqAnswer { get; set; }

        /// <summary>Agent Assist Smart Compose suggestion data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("smartComposeSuggestion")]
        public virtual GoogleCloudContactcenterinsightsV1SmartComposeSuggestionData SmartComposeSuggestion { get; set; }

        /// <summary>Agent Assist Smart Reply data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("smartReply")]
        public virtual GoogleCloudContactcenterinsightsV1SmartReplyData SmartReply { get; set; }

        /// <summary>The boundary in the conversation where the annotation starts, inclusive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startBoundary")]
        public virtual GoogleCloudContactcenterinsightsV1AnnotationBoundary StartBoundary { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The data for a sentiment annotation.</summary>
    public class GoogleCloudContactcenterinsightsV1SentimentData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A non-negative number from 0 to infinity which represents the abolute magnitude of sentiment regardless of
        /// score.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("magnitude")]
        public virtual System.Nullable<float> Magnitude { get; set; }

        /// <summary>The sentiment score between -1.0 (negative) and 1.0 (positive).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual System.Nullable<float> Score { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The settings resource.</summary>
    public class GoogleCloudContactcenterinsightsV1Settings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Default analysis settings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("analysisConfig")]
        public virtual GoogleCloudContactcenterinsightsV1SettingsAnalysisConfig AnalysisConfig { get; set; }

        /// <summary>
        /// The default TTL for newly-created conversations. If a conversation has a specified expiration, that value
        /// will be used instead. Changing this value will not change the expiration of existing conversations.
        /// Conversations with no expire time persist until they are deleted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conversationTtl")]
        public virtual object ConversationTtl { get; set; }

        /// <summary>Output only. The time at which the settings was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// A language code to be applied to each transcript segment unless the segment already specifies a language
        /// code. Language code defaults to "en-US" if it is neither specified on the segment nor here.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>
        /// Immutable. The resource name of the settings resource. Format:
        /// projects/{project}/locations/{location}/settings
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// A map that maps a notification trigger to a Pub/Sub topic. Each time a specified trigger occurs, Insights
        /// will notify the corresponding Pub/Sub topic. Keys are notification triggers. Supported keys are: *
        /// "all-triggers": Notify each time any of the supported triggers occurs. * "create-analysis": Notify each time
        /// an analysis is created. * "create-conversation": Notify each time a conversation is created. *
        /// "export-insights-data": Notify each time an export is complete. * "update-conversation": Notify each time a
        /// conversation is updated via UpdateConversation. Values are Pub/Sub topics. The format of each Pub/Sub topic
        /// is: projects/{project}/topics/{topic}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pubsubNotificationSettings")]
        public virtual System.Collections.Generic.IDictionary<string, string> PubsubNotificationSettings { get; set; }

        /// <summary>Output only. The time at which the settings were last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Default configuration when creating Analyses in Insights.</summary>
    public class GoogleCloudContactcenterinsightsV1SettingsAnalysisConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// To select the annotators to run and the phrase matchers to use (if any). If not specified, all annotators
        /// will be run.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotatorSelector")]
        public virtual GoogleCloudContactcenterinsightsV1AnnotatorSelector AnnotatorSelector { get; set; }

        /// <summary>
        /// Percentage of conversations created using Dialogflow runtime integration to analyze automatically, between
        /// [0, 100].
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runtimeIntegrationAnalysisPercentage")]
        public virtual System.Nullable<double> RuntimeIntegrationAnalysisPercentage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The data for a silence annotation.</summary>
    public class GoogleCloudContactcenterinsightsV1SilenceData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Agent Assist Smart Compose suggestion data.</summary>
    public class GoogleCloudContactcenterinsightsV1SmartComposeSuggestionData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The system's confidence score that this suggestion is a good match for this conversation, ranging from 0.0
        /// (completely uncertain) to 1.0 (completely certain).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidenceScore")]
        public virtual System.Nullable<double> ConfidenceScore { get; set; }

        /// <summary>
        /// Map that contains metadata about the Smart Compose suggestion and the document from which it originates.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The name of the answer record. Format: projects/{project}/locations/{location}/answerRecords/{answer_record}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryRecord")]
        public virtual string QueryRecord { get; set; }

        /// <summary>The content of the suggestion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestion")]
        public virtual string Suggestion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Agent Assist Smart Reply data.</summary>
    public class GoogleCloudContactcenterinsightsV1SmartReplyData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The system's confidence score that this reply is a good match for this conversation, ranging from 0.0
        /// (completely uncertain) to 1.0 (completely certain).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidenceScore")]
        public virtual System.Nullable<double> ConfidenceScore { get; set; }

        /// <summary>
        /// Map that contains metadata about the Smart Reply and the document from which it originates.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The name of the answer record. Format: projects/{project}/locations/{location}/answerRecords/{answer_record}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryRecord")]
        public virtual string QueryRecord { get; set; }

        /// <summary>The content of the reply.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reply")]
        public virtual string Reply { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for undeploying an issue model.</summary>
    public class GoogleCloudContactcenterinsightsV1UndeployIssueModelMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The time the operation was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. The time the operation finished running.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>The original request for undeployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("request")]
        public virtual GoogleCloudContactcenterinsightsV1UndeployIssueModelRequest Request { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request to undeploy an issue model.</summary>
    public class GoogleCloudContactcenterinsightsV1UndeployIssueModelRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The issue model to undeploy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response to undeploy an issue model.</summary>
    public class GoogleCloudContactcenterinsightsV1UndeployIssueModelResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The View resource.</summary>
    public class GoogleCloudContactcenterinsightsV1View : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The time at which this view was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>The human-readable display name of the view.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Immutable. The resource name of the view. Format: projects/{project}/locations/{location}/views/{view}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The most recent time at which the view was updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>String with specific view properties, must be non-empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Selector of all available annotators and phrase matchers to run.</summary>
    public class GoogleCloudContactcenterinsightsV1alpha1AnnotatorSelector : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The issue model to run. If not provided, the most recently deployed topic model will be used. The provided
        /// issue model will only be used for inference if the issue model is deployed and if run_issue_model_annotator
        /// is set to true. If more than one issue model is provided, only the first provided issue model will be used
        /// for inference.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issueModels")]
        public virtual System.Collections.Generic.IList<string> IssueModels { get; set; }

        /// <summary>
        /// The list of phrase matchers to run. If not provided, all active phrase matchers will be used. If inactive
        /// phrase matchers are provided, they will not be used. Phrase matchers will be run only if
        /// run_phrase_matcher_annotator is set to true. Format:
        /// projects/{project}/locations/{location}/phraseMatchers/{phrase_matcher}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phraseMatchers")]
        public virtual System.Collections.Generic.IList<string> PhraseMatchers { get; set; }

        /// <summary>Whether to run the entity annotator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runEntityAnnotator")]
        public virtual System.Nullable<bool> RunEntityAnnotator { get; set; }

        /// <summary>Whether to run the intent annotator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runIntentAnnotator")]
        public virtual System.Nullable<bool> RunIntentAnnotator { get; set; }

        /// <summary>Whether to run the interruption annotator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runInterruptionAnnotator")]
        public virtual System.Nullable<bool> RunInterruptionAnnotator { get; set; }

        /// <summary>
        /// Whether to run the issue model annotator. A model should have already been deployed for this to take effect.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runIssueModelAnnotator")]
        public virtual System.Nullable<bool> RunIssueModelAnnotator { get; set; }

        /// <summary>Whether to run the active phrase matcher annotator(s).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runPhraseMatcherAnnotator")]
        public virtual System.Nullable<bool> RunPhraseMatcherAnnotator { get; set; }

        /// <summary>Whether to run the sentiment annotator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runSentimentAnnotator")]
        public virtual System.Nullable<bool> RunSentimentAnnotator { get; set; }

        /// <summary>Whether to run the silence annotator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runSilenceAnnotator")]
        public virtual System.Nullable<bool> RunSilenceAnnotator { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The metadata for a bulk analyze conversations operation.</summary>
    public class GoogleCloudContactcenterinsightsV1alpha1BulkAnalyzeConversationsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of requested analyses that have completed successfully so far.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completedAnalysesCount")]
        public virtual System.Nullable<int> CompletedAnalysesCount { get; set; }

        /// <summary>The time the operation was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>The time the operation finished running.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>The number of requested analyses that have failed so far.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failedAnalysesCount")]
        public virtual System.Nullable<int> FailedAnalysesCount { get; set; }

        /// <summary>The original request for bulk analyze.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("request")]
        public virtual GoogleCloudContactcenterinsightsV1alpha1BulkAnalyzeConversationsRequest Request { get; set; }

        /// <summary>
        /// Total number of analyses requested. Computed by the number of conversations returned by `filter` multiplied
        /// by `analysis_percentage` in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalRequestedAnalysesCount")]
        public virtual System.Nullable<int> TotalRequestedAnalysesCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request to analyze conversations in bulk.</summary>
    public class GoogleCloudContactcenterinsightsV1alpha1BulkAnalyzeConversationsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Percentage of selected conversation to analyze, between [0, 100].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("analysisPercentage")]
        public virtual System.Nullable<float> AnalysisPercentage { get; set; }

        /// <summary>
        /// To select the annotators to run and the phrase matchers to use (if any). If not specified, all annotators
        /// will be run.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotatorSelector")]
        public virtual GoogleCloudContactcenterinsightsV1alpha1AnnotatorSelector AnnotatorSelector { get; set; }

        /// <summary>Required. Filter used to select the subset of conversations to analyze.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>Required. The parent resource to create analyses in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for a bulk analyze conversations operation.</summary>
    public class GoogleCloudContactcenterinsightsV1alpha1BulkAnalyzeConversationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Count of failed analyses.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failedAnalysisCount")]
        public virtual System.Nullable<int> FailedAnalysisCount { get; set; }

        /// <summary>Count of successful analyses.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("successfulAnalysisCount")]
        public virtual System.Nullable<int> SuccessfulAnalysisCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for a create analysis operation.</summary>
    public class GoogleCloudContactcenterinsightsV1alpha1CreateAnalysisOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The annotator selector used for the analysis (if any).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotatorSelector")]
        public virtual GoogleCloudContactcenterinsightsV1alpha1AnnotatorSelector AnnotatorSelector { get; set; }

        /// <summary>Output only. The Conversation that this Analysis Operation belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conversation")]
        public virtual string Conversation { get; set; }

        /// <summary>Output only. The time the operation was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. The time the operation finished running.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for creating an issue model.</summary>
    public class GoogleCloudContactcenterinsightsV1alpha1CreateIssueModelMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The time the operation was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. The time the operation finished running.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>The original request for creation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("request")]
        public virtual GoogleCloudContactcenterinsightsV1alpha1CreateIssueModelRequest Request { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request to create an issue model.</summary>
    public class GoogleCloudContactcenterinsightsV1alpha1CreateIssueModelRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The issue model to create.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issueModel")]
        public virtual GoogleCloudContactcenterinsightsV1alpha1IssueModel IssueModel { get; set; }

        /// <summary>Required. The parent resource of the issue model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for deleting an issue model.</summary>
    public class GoogleCloudContactcenterinsightsV1alpha1DeleteIssueModelMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The time the operation was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. The time the operation finished running.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>The original request for deletion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("request")]
        public virtual GoogleCloudContactcenterinsightsV1alpha1DeleteIssueModelRequest Request { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request to delete an issue model.</summary>
    public class GoogleCloudContactcenterinsightsV1alpha1DeleteIssueModelRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The name of the issue model to delete.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for deploying an issue model.</summary>
    public class GoogleCloudContactcenterinsightsV1alpha1DeployIssueModelMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The time the operation was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. The time the operation finished running.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>The original request for deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("request")]
        public virtual GoogleCloudContactcenterinsightsV1alpha1DeployIssueModelRequest Request { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request to deploy an issue model.</summary>
    public class GoogleCloudContactcenterinsightsV1alpha1DeployIssueModelRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The issue model to deploy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response to deploy an issue model.</summary>
    public class GoogleCloudContactcenterinsightsV1alpha1DeployIssueModelResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for an export insights operation.</summary>
    public class GoogleCloudContactcenterinsightsV1alpha1ExportInsightsDataMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The time the operation was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. The time the operation finished running.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>
        /// Partial errors during export operation that might cause the operation output to be incomplete.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partialErrors")]
        public virtual System.Collections.Generic.IList<GoogleRpcStatus> PartialErrors { get; set; }

        /// <summary>The original request for export.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("request")]
        public virtual GoogleCloudContactcenterinsightsV1alpha1ExportInsightsDataRequest Request { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request to export insights.</summary>
    public class GoogleCloudContactcenterinsightsV1alpha1ExportInsightsDataRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specified if sink is a BigQuery table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bigQueryDestination")]
        public virtual GoogleCloudContactcenterinsightsV1alpha1ExportInsightsDataRequestBigQueryDestination BigQueryDestination { get; set; }

        /// <summary>
        /// A filter to reduce results to a specific subset. Useful for exporting conversations with specific
        /// properties.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>
        /// A fully qualified KMS key name for BigQuery tables protected by CMEK. Format:
        /// projects/{project}/locations/{location}/keyRings/{keyring}/cryptoKeys/{key}/cryptoKeyVersions/{version}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKey")]
        public virtual string KmsKey { get; set; }

        /// <summary>Required. The parent resource to export data from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>Options for what to do if the destination table already exists.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("writeDisposition")]
        public virtual string WriteDisposition { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A BigQuery Table Reference.</summary>
    public class GoogleCloudContactcenterinsightsV1alpha1ExportInsightsDataRequestBigQueryDestination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The name of the BigQuery dataset that the snapshot result should be exported to. If this dataset
        /// does not exist, the export call returns an INVALID_ARGUMENT error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataset")]
        public virtual string Dataset { get; set; }

        /// <summary>
        /// A project ID or number. If specified, then export will attempt to write data to this project instead of the
        /// resource project. Otherwise, the resource project will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>
        /// The BigQuery table name to which the insights data should be written. If this table does not exist, the
        /// export call returns an INVALID_ARGUMENT error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("table")]
        public virtual string Table { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for an export insights operation.</summary>
    public class GoogleCloudContactcenterinsightsV1alpha1ExportInsightsDataResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The metadata for an IngestConversations operation.</summary>
    public class GoogleCloudContactcenterinsightsV1alpha1IngestConversationsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The time the operation was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. The time the operation finished running.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>
        /// Output only. Partial errors during ingest operation that might cause the operation output to be incomplete.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partialErrors")]
        public virtual System.Collections.Generic.IList<GoogleRpcStatus> PartialErrors { get; set; }

        /// <summary>Output only. The original request for ingest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("request")]
        public virtual GoogleCloudContactcenterinsightsV1alpha1IngestConversationsRequest Request { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request to ingest conversations.</summary>
    public class GoogleCloudContactcenterinsightsV1alpha1IngestConversationsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Configuration that applies to all conversations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conversationConfig")]
        public virtual GoogleCloudContactcenterinsightsV1alpha1IngestConversationsRequestConversationConfig ConversationConfig { get; set; }

        /// <summary>A cloud storage bucket source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsSource")]
        public virtual GoogleCloudContactcenterinsightsV1alpha1IngestConversationsRequestGcsSource GcsSource { get; set; }

        /// <summary>Required. The parent resource for new conversations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>Configuration for when `source` contains conversation transcripts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transcriptObjectConfig")]
        public virtual GoogleCloudContactcenterinsightsV1alpha1IngestConversationsRequestTranscriptObjectConfig TranscriptObjectConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration that applies to all conversations.</summary>
    public class GoogleCloudContactcenterinsightsV1alpha1IngestConversationsRequestConversationConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An opaque, user-specified string representing the human agent who handled the conversations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("agentId")]
        public virtual string AgentId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for Cloud Storage bucket sources.</summary>
    public class GoogleCloudContactcenterinsightsV1alpha1IngestConversationsRequestGcsSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The Cloud Storage bucket containing source objects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucketUri")]
        public virtual string BucketUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for processing transcript objects.</summary>
    public class GoogleCloudContactcenterinsightsV1alpha1IngestConversationsRequestTranscriptObjectConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The medium transcript objects represent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("medium")]
        public virtual string Medium { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response to an IngestConversations operation.</summary>
    public class GoogleCloudContactcenterinsightsV1alpha1IngestConversationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The issue model resource.</summary>
    public class GoogleCloudContactcenterinsightsV1alpha1IssueModel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The time at which this issue model was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>The representative name for the issue model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Configs for the input data that used to create the issue model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputDataConfig")]
        public virtual GoogleCloudContactcenterinsightsV1alpha1IssueModelInputDataConfig InputDataConfig { get; set; }

        /// <summary>Output only. Number of issues in this issue model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issueCount")]
        public virtual System.Nullable<long> IssueCount { get; set; }

        /// <summary>
        /// Immutable. The resource name of the issue model. Format:
        /// projects/{project}/locations/{location}/issueModels/{issue_model}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. State of the model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. Immutable. The issue model's label statistics on its training data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trainingStats")]
        public virtual GoogleCloudContactcenterinsightsV1alpha1IssueModelLabelStats TrainingStats { get; set; }

        /// <summary>Output only. The most recent time at which the issue model was updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configs for the input data used to create the issue model.</summary>
    public class GoogleCloudContactcenterinsightsV1alpha1IssueModelInputDataConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A filter to reduce the conversations used for training the model to a specific subset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>
        /// Medium of conversations used in training data. This field is being deprecated. To specify the medium to be
        /// used in training a new issue model, set the `medium` field on `filter`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("medium")]
        public virtual string Medium { get; set; }

        /// <summary>Output only. Number of conversations used in training. Output only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trainingConversationsCount")]
        public virtual System.Nullable<long> TrainingConversationsCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Aggregated statistics about an issue model.</summary>
    public class GoogleCloudContactcenterinsightsV1alpha1IssueModelLabelStats : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of conversations the issue model has analyzed at this point in time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("analyzedConversationsCount")]
        public virtual System.Nullable<long> AnalyzedConversationsCount { get; set; }

        /// <summary>Statistics on each issue. Key is the issue's resource name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issueStats")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudContactcenterinsightsV1alpha1IssueModelLabelStatsIssueStats> IssueStats { get; set; }

        /// <summary>Number of analyzed conversations for which no issue was applicable at this point in time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unclassifiedConversationsCount")]
        public virtual System.Nullable<long> UnclassifiedConversationsCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Aggregated statistics about an issue.</summary>
    public class GoogleCloudContactcenterinsightsV1alpha1IssueModelLabelStatsIssueStats : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Display name of the issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Issue resource. Format: projects/{project}/locations/{location}/issueModels/{issue_model}/issues/{issue}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issue")]
        public virtual string Issue { get; set; }

        /// <summary>Number of conversations attached to the issue at this point in time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labeledConversationsCount")]
        public virtual System.Nullable<long> LabeledConversationsCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for undeploying an issue model.</summary>
    public class GoogleCloudContactcenterinsightsV1alpha1UndeployIssueModelMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The time the operation was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. The time the operation finished running.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>The original request for undeployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("request")]
        public virtual GoogleCloudContactcenterinsightsV1alpha1UndeployIssueModelRequest Request { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request to undeploy an issue model.</summary>
    public class GoogleCloudContactcenterinsightsV1alpha1UndeployIssueModelRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The issue model to undeploy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response to undeploy an issue model.</summary>
    public class GoogleCloudContactcenterinsightsV1alpha1UndeployIssueModelResponse : Google.Apis.Requests.IDirectResponseSchema
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
