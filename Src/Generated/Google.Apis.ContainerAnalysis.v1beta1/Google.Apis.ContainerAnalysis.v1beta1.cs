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

namespace Google.Apis.ContainerAnalysis.v1beta1
{
    /// <summary>The ContainerAnalysis Service.</summary>
    public class ContainerAnalysisService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1beta1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public ContainerAnalysisService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public ContainerAnalysisService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "containeranalysis";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://containeranalysis.googleapis.com/";
        #else
            "https://containeranalysis.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://containeranalysis.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Container Analysis API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Container Analysis API.</summary>
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

    /// <summary>A base abstract class for ContainerAnalysis requests.</summary>
    public abstract class ContainerAnalysisBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new ContainerAnalysisBaseServiceRequest instance.</summary>
        protected ContainerAnalysisBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes ContainerAnalysis parameter list.</summary>
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
            Notes = new NotesResource(service);
            Occurrences = new OccurrencesResource(service);
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
                Occurrences = new OccurrencesResource(service);
            }

            /// <summary>Gets the Occurrences resource.</summary>
            public virtual OccurrencesResource Occurrences { get; }

            /// <summary>The "occurrences" collection of methods.</summary>
            public class OccurrencesResource
            {
                private const string Resource = "occurrences";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public OccurrencesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Lists occurrences referencing the specified note. Provider projects can use this method to get all
                /// occurrences across consumer projects referencing the specified note.
                /// </summary>
                /// <param name="name">
                /// Required. The name of the note to list occurrences for in the form of
                /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
                /// </param>
                public virtual ListRequest List(string name)
                {
                    return new ListRequest(service, name);
                }

                /// <summary>
                /// Lists occurrences referencing the specified note. Provider projects can use this method to get all
                /// occurrences across consumer projects referencing the specified note.
                /// </summary>
                public class ListRequest : ContainerAnalysisBaseServiceRequest<Google.Apis.ContainerAnalysis.v1beta1.Data.ListNoteOccurrencesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the note to list occurrences for in the form of
                    /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>The filter expression.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Number of occurrences to return in the list.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>Token to provide to skip to a particular spot in the list.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+name}/occurrences";

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
                            Pattern = @"^projects/[^/]+/notes/[^/]+$",
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

            /// <summary>Creates new notes in batch.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The name of the project in the form of `projects/[PROJECT_ID]`, under which the notes are to
            /// be created.
            /// </param>
            public virtual BatchCreateRequest BatchCreate(Google.Apis.ContainerAnalysis.v1beta1.Data.BatchCreateNotesRequest body, string parent)
            {
                return new BatchCreateRequest(service, body, parent);
            }

            /// <summary>Creates new notes in batch.</summary>
            public class BatchCreateRequest : ContainerAnalysisBaseServiceRequest<Google.Apis.ContainerAnalysis.v1beta1.Data.BatchCreateNotesResponse>
            {
                /// <summary>Constructs a new BatchCreate request.</summary>
                public BatchCreateRequest(Google.Apis.Services.IClientService service, Google.Apis.ContainerAnalysis.v1beta1.Data.BatchCreateNotesRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the project in the form of `projects/[PROJECT_ID]`, under which the notes are
                /// to be created.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.ContainerAnalysis.v1beta1.Data.BatchCreateNotesRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "batchCreate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+parent}/notes:batchCreate";

                /// <summary>Initializes BatchCreate parameter list.</summary>
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

            /// <summary>Creates a new note.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The name of the project in the form of `projects/[PROJECT_ID]`, under which the note is to be
            /// created.
            /// </param>
            public virtual CreateRequest Create(Google.Apis.ContainerAnalysis.v1beta1.Data.Note body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>Creates a new note.</summary>
            public class CreateRequest : ContainerAnalysisBaseServiceRequest<Google.Apis.ContainerAnalysis.v1beta1.Data.Note>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.ContainerAnalysis.v1beta1.Data.Note body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the project in the form of `projects/[PROJECT_ID]`, under which the note is to
                /// be created.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Required. The ID to use for this note.</summary>
                [Google.Apis.Util.RequestParameterAttribute("noteId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string NoteId { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.ContainerAnalysis.v1beta1.Data.Note Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+parent}/notes";

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
                    RequestParameters.Add("noteId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "noteId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Deletes the specified note.</summary>
            /// <param name="name">
            /// Required. The name of the note in the form of `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>Deletes the specified note.</summary>
            public class DeleteRequest : ContainerAnalysisBaseServiceRequest<Google.Apis.ContainerAnalysis.v1beta1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the note in the form of `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
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
                        Pattern = @"^projects/[^/]+/notes/[^/]+$",
                    });
                }
            }

            /// <summary>Gets the specified note.</summary>
            /// <param name="name">
            /// Required. The name of the note in the form of `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets the specified note.</summary>
            public class GetRequest : ContainerAnalysisBaseServiceRequest<Google.Apis.ContainerAnalysis.v1beta1.Data.Note>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the note in the form of `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
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
                        Pattern = @"^projects/[^/]+/notes/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Gets the access control policy for a note or an occurrence resource. Requires
            /// `containeranalysis.notes.setIamPolicy` or `containeranalysis.occurrences.setIamPolicy` permission if the
            /// resource is a note or occurrence, respectively. The resource takes the format
            /// `projects/[PROJECT_ID]/notes/[NOTE_ID]` for notes and
            /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for occurrences.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="resource">
            /// REQUIRED: The resource for which the policy is being requested. See [Resource
            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
            /// </param>
            public virtual GetIamPolicyRequest GetIamPolicy(Google.Apis.ContainerAnalysis.v1beta1.Data.GetIamPolicyRequest body, string resource)
            {
                return new GetIamPolicyRequest(service, body, resource);
            }

            /// <summary>
            /// Gets the access control policy for a note or an occurrence resource. Requires
            /// `containeranalysis.notes.setIamPolicy` or `containeranalysis.occurrences.setIamPolicy` permission if the
            /// resource is a note or occurrence, respectively. The resource takes the format
            /// `projects/[PROJECT_ID]/notes/[NOTE_ID]` for notes and
            /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for occurrences.
            /// </summary>
            public class GetIamPolicyRequest : ContainerAnalysisBaseServiceRequest<Google.Apis.ContainerAnalysis.v1beta1.Data.Policy>
            {
                /// <summary>Constructs a new GetIamPolicy request.</summary>
                public GetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.ContainerAnalysis.v1beta1.Data.GetIamPolicyRequest body, string resource) : base(service)
                {
                    Resource = resource;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// REQUIRED: The resource for which the policy is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Resource { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.ContainerAnalysis.v1beta1.Data.GetIamPolicyRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getIamPolicy";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+resource}:getIamPolicy";

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
                        Pattern = @"^projects/[^/]+/notes/[^/]+$",
                    });
                }
            }

            /// <summary>Lists notes for the specified project.</summary>
            /// <param name="parent">
            /// Required. The name of the project to list notes for in the form of `projects/[PROJECT_ID]`.
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists notes for the specified project.</summary>
            public class ListRequest : ContainerAnalysisBaseServiceRequest<Google.Apis.ContainerAnalysis.v1beta1.Data.ListNotesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the project to list notes for in the form of `projects/[PROJECT_ID]`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>The filter expression.</summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// Number of notes to return in the list. Must be positive. Max allowed page size is 1000. If not
                /// specified, page size defaults to 20.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>Token to provide to skip to a particular spot in the list.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+parent}/notes";

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

            /// <summary>Updates the specified note.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The name of the note in the form of `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.ContainerAnalysis.v1beta1.Data.Note body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>Updates the specified note.</summary>
            public class PatchRequest : ContainerAnalysisBaseServiceRequest<Google.Apis.ContainerAnalysis.v1beta1.Data.Note>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.ContainerAnalysis.v1beta1.Data.Note body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the note in the form of `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>The fields to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.ContainerAnalysis.v1beta1.Data.Note Body { get; set; }

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
                        Pattern = @"^projects/[^/]+/notes/[^/]+$",
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
            /// Sets the access control policy on the specified note or occurrence. Requires
            /// `containeranalysis.notes.setIamPolicy` or `containeranalysis.occurrences.setIamPolicy` permission if the
            /// resource is a note or an occurrence, respectively. The resource takes the format
            /// `projects/[PROJECT_ID]/notes/[NOTE_ID]` for notes and
            /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for occurrences.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="resource">
            /// REQUIRED: The resource for which the policy is being specified. See [Resource
            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
            /// </param>
            public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.ContainerAnalysis.v1beta1.Data.SetIamPolicyRequest body, string resource)
            {
                return new SetIamPolicyRequest(service, body, resource);
            }

            /// <summary>
            /// Sets the access control policy on the specified note or occurrence. Requires
            /// `containeranalysis.notes.setIamPolicy` or `containeranalysis.occurrences.setIamPolicy` permission if the
            /// resource is a note or an occurrence, respectively. The resource takes the format
            /// `projects/[PROJECT_ID]/notes/[NOTE_ID]` for notes and
            /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for occurrences.
            /// </summary>
            public class SetIamPolicyRequest : ContainerAnalysisBaseServiceRequest<Google.Apis.ContainerAnalysis.v1beta1.Data.Policy>
            {
                /// <summary>Constructs a new SetIamPolicy request.</summary>
                public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.ContainerAnalysis.v1beta1.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                Google.Apis.ContainerAnalysis.v1beta1.Data.SetIamPolicyRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "setIamPolicy";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+resource}:setIamPolicy";

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
                        Pattern = @"^projects/[^/]+/notes/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Returns the permissions that a caller has on the specified note or occurrence. Requires list permission
            /// on the project (for example, `containeranalysis.notes.list`). The resource takes the format
            /// `projects/[PROJECT_ID]/notes/[NOTE_ID]` for notes and
            /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for occurrences.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="resource">
            /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
            /// </param>
            public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.ContainerAnalysis.v1beta1.Data.TestIamPermissionsRequest body, string resource)
            {
                return new TestIamPermissionsRequest(service, body, resource);
            }

            /// <summary>
            /// Returns the permissions that a caller has on the specified note or occurrence. Requires list permission
            /// on the project (for example, `containeranalysis.notes.list`). The resource takes the format
            /// `projects/[PROJECT_ID]/notes/[NOTE_ID]` for notes and
            /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for occurrences.
            /// </summary>
            public class TestIamPermissionsRequest : ContainerAnalysisBaseServiceRequest<Google.Apis.ContainerAnalysis.v1beta1.Data.TestIamPermissionsResponse>
            {
                /// <summary>Constructs a new TestIamPermissions request.</summary>
                public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.ContainerAnalysis.v1beta1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                Google.Apis.ContainerAnalysis.v1beta1.Data.TestIamPermissionsRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "testIamPermissions";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+resource}:testIamPermissions";

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
                        Pattern = @"^projects/[^/]+/notes/[^/]+$",
                    });
                }
            }
        }

        /// <summary>Gets the Occurrences resource.</summary>
        public virtual OccurrencesResource Occurrences { get; }

        /// <summary>The "occurrences" collection of methods.</summary>
        public class OccurrencesResource
        {
            private const string Resource = "occurrences";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public OccurrencesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Creates new occurrences in batch.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The name of the project in the form of `projects/[PROJECT_ID]`, under which the occurrences
            /// are to be created.
            /// </param>
            public virtual BatchCreateRequest BatchCreate(Google.Apis.ContainerAnalysis.v1beta1.Data.BatchCreateOccurrencesRequest body, string parent)
            {
                return new BatchCreateRequest(service, body, parent);
            }

            /// <summary>Creates new occurrences in batch.</summary>
            public class BatchCreateRequest : ContainerAnalysisBaseServiceRequest<Google.Apis.ContainerAnalysis.v1beta1.Data.BatchCreateOccurrencesResponse>
            {
                /// <summary>Constructs a new BatchCreate request.</summary>
                public BatchCreateRequest(Google.Apis.Services.IClientService service, Google.Apis.ContainerAnalysis.v1beta1.Data.BatchCreateOccurrencesRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the project in the form of `projects/[PROJECT_ID]`, under which the
                /// occurrences are to be created.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.ContainerAnalysis.v1beta1.Data.BatchCreateOccurrencesRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "batchCreate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+parent}/occurrences:batchCreate";

                /// <summary>Initializes BatchCreate parameter list.</summary>
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

            /// <summary>Creates a new occurrence.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The name of the project in the form of `projects/[PROJECT_ID]`, under which the occurrence is
            /// to be created.
            /// </param>
            public virtual CreateRequest Create(Google.Apis.ContainerAnalysis.v1beta1.Data.Occurrence body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>Creates a new occurrence.</summary>
            public class CreateRequest : ContainerAnalysisBaseServiceRequest<Google.Apis.ContainerAnalysis.v1beta1.Data.Occurrence>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.ContainerAnalysis.v1beta1.Data.Occurrence body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the project in the form of `projects/[PROJECT_ID]`, under which the occurrence
                /// is to be created.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.ContainerAnalysis.v1beta1.Data.Occurrence Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+parent}/occurrences";

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
                }
            }

            /// <summary>
            /// Deletes the specified occurrence. For example, use this method to delete an occurrence when the
            /// occurrence is no longer applicable for the given resource.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the occurrence in the form of `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>
            /// Deletes the specified occurrence. For example, use this method to delete an occurrence when the
            /// occurrence is no longer applicable for the given resource.
            /// </summary>
            public class DeleteRequest : ContainerAnalysisBaseServiceRequest<Google.Apis.ContainerAnalysis.v1beta1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the occurrence in the form of
                /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
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
                        Pattern = @"^projects/[^/]+/occurrences/[^/]+$",
                    });
                }
            }

            /// <summary>Gets the specified occurrence.</summary>
            /// <param name="name">
            /// Required. The name of the occurrence in the form of `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets the specified occurrence.</summary>
            public class GetRequest : ContainerAnalysisBaseServiceRequest<Google.Apis.ContainerAnalysis.v1beta1.Data.Occurrence>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the occurrence in the form of
                /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
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
                        Pattern = @"^projects/[^/]+/occurrences/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Gets the access control policy for a note or an occurrence resource. Requires
            /// `containeranalysis.notes.setIamPolicy` or `containeranalysis.occurrences.setIamPolicy` permission if the
            /// resource is a note or occurrence, respectively. The resource takes the format
            /// `projects/[PROJECT_ID]/notes/[NOTE_ID]` for notes and
            /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for occurrences.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="resource">
            /// REQUIRED: The resource for which the policy is being requested. See [Resource
            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
            /// </param>
            public virtual GetIamPolicyRequest GetIamPolicy(Google.Apis.ContainerAnalysis.v1beta1.Data.GetIamPolicyRequest body, string resource)
            {
                return new GetIamPolicyRequest(service, body, resource);
            }

            /// <summary>
            /// Gets the access control policy for a note or an occurrence resource. Requires
            /// `containeranalysis.notes.setIamPolicy` or `containeranalysis.occurrences.setIamPolicy` permission if the
            /// resource is a note or occurrence, respectively. The resource takes the format
            /// `projects/[PROJECT_ID]/notes/[NOTE_ID]` for notes and
            /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for occurrences.
            /// </summary>
            public class GetIamPolicyRequest : ContainerAnalysisBaseServiceRequest<Google.Apis.ContainerAnalysis.v1beta1.Data.Policy>
            {
                /// <summary>Constructs a new GetIamPolicy request.</summary>
                public GetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.ContainerAnalysis.v1beta1.Data.GetIamPolicyRequest body, string resource) : base(service)
                {
                    Resource = resource;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// REQUIRED: The resource for which the policy is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Resource { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.ContainerAnalysis.v1beta1.Data.GetIamPolicyRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getIamPolicy";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+resource}:getIamPolicy";

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
                        Pattern = @"^projects/[^/]+/occurrences/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Gets the note attached to the specified occurrence. Consumer projects can use this method to get a note
            /// that belongs to a provider project.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the occurrence in the form of `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
            /// </param>
            public virtual GetNotesRequest GetNotes(string name)
            {
                return new GetNotesRequest(service, name);
            }

            /// <summary>
            /// Gets the note attached to the specified occurrence. Consumer projects can use this method to get a note
            /// that belongs to a provider project.
            /// </summary>
            public class GetNotesRequest : ContainerAnalysisBaseServiceRequest<Google.Apis.ContainerAnalysis.v1beta1.Data.Note>
            {
                /// <summary>Constructs a new GetNotes request.</summary>
                public GetNotesRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the occurrence in the form of
                /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getNotes";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}/notes";

                /// <summary>Initializes GetNotes parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/occurrences/[^/]+$",
                    });
                }
            }

            /// <summary>Gets a summary of the number and severity of occurrences.</summary>
            /// <param name="parent">
            /// Required. The name of the project to get a vulnerability summary for in the form of
            /// `projects/[PROJECT_ID]`.
            /// </param>
            public virtual GetVulnerabilitySummaryRequest GetVulnerabilitySummary(string parent)
            {
                return new GetVulnerabilitySummaryRequest(service, parent);
            }

            /// <summary>Gets a summary of the number and severity of occurrences.</summary>
            public class GetVulnerabilitySummaryRequest : ContainerAnalysisBaseServiceRequest<Google.Apis.ContainerAnalysis.v1beta1.Data.VulnerabilityOccurrencesSummary>
            {
                /// <summary>Constructs a new GetVulnerabilitySummary request.</summary>
                public GetVulnerabilitySummaryRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the project to get a vulnerability summary for in the form of
                /// `projects/[PROJECT_ID]`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>The filter expression.</summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getVulnerabilitySummary";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+parent}/occurrences:vulnerabilitySummary";

                /// <summary>Initializes GetVulnerabilitySummary parameter list.</summary>
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

            /// <summary>Lists occurrences for the specified project.</summary>
            /// <param name="parent">
            /// Required. The name of the project to list occurrences for in the form of `projects/[PROJECT_ID]`.
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists occurrences for the specified project.</summary>
            public class ListRequest : ContainerAnalysisBaseServiceRequest<Google.Apis.ContainerAnalysis.v1beta1.Data.ListOccurrencesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the project to list occurrences for in the form of `projects/[PROJECT_ID]`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>The filter expression.</summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// Number of occurrences to return in the list. Must be positive. Max allowed page size is 1000. If not
                /// specified, page size defaults to 20.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>Token to provide to skip to a particular spot in the list.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+parent}/occurrences";

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

            /// <summary>Updates the specified occurrence.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The name of the occurrence in the form of `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.ContainerAnalysis.v1beta1.Data.Occurrence body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>Updates the specified occurrence.</summary>
            public class PatchRequest : ContainerAnalysisBaseServiceRequest<Google.Apis.ContainerAnalysis.v1beta1.Data.Occurrence>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.ContainerAnalysis.v1beta1.Data.Occurrence body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the occurrence in the form of
                /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>The fields to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.ContainerAnalysis.v1beta1.Data.Occurrence Body { get; set; }

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
                        Pattern = @"^projects/[^/]+/occurrences/[^/]+$",
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
            /// Sets the access control policy on the specified note or occurrence. Requires
            /// `containeranalysis.notes.setIamPolicy` or `containeranalysis.occurrences.setIamPolicy` permission if the
            /// resource is a note or an occurrence, respectively. The resource takes the format
            /// `projects/[PROJECT_ID]/notes/[NOTE_ID]` for notes and
            /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for occurrences.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="resource">
            /// REQUIRED: The resource for which the policy is being specified. See [Resource
            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
            /// </param>
            public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.ContainerAnalysis.v1beta1.Data.SetIamPolicyRequest body, string resource)
            {
                return new SetIamPolicyRequest(service, body, resource);
            }

            /// <summary>
            /// Sets the access control policy on the specified note or occurrence. Requires
            /// `containeranalysis.notes.setIamPolicy` or `containeranalysis.occurrences.setIamPolicy` permission if the
            /// resource is a note or an occurrence, respectively. The resource takes the format
            /// `projects/[PROJECT_ID]/notes/[NOTE_ID]` for notes and
            /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for occurrences.
            /// </summary>
            public class SetIamPolicyRequest : ContainerAnalysisBaseServiceRequest<Google.Apis.ContainerAnalysis.v1beta1.Data.Policy>
            {
                /// <summary>Constructs a new SetIamPolicy request.</summary>
                public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.ContainerAnalysis.v1beta1.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                Google.Apis.ContainerAnalysis.v1beta1.Data.SetIamPolicyRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "setIamPolicy";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+resource}:setIamPolicy";

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
                        Pattern = @"^projects/[^/]+/occurrences/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Returns the permissions that a caller has on the specified note or occurrence. Requires list permission
            /// on the project (for example, `containeranalysis.notes.list`). The resource takes the format
            /// `projects/[PROJECT_ID]/notes/[NOTE_ID]` for notes and
            /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for occurrences.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="resource">
            /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
            /// </param>
            public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.ContainerAnalysis.v1beta1.Data.TestIamPermissionsRequest body, string resource)
            {
                return new TestIamPermissionsRequest(service, body, resource);
            }

            /// <summary>
            /// Returns the permissions that a caller has on the specified note or occurrence. Requires list permission
            /// on the project (for example, `containeranalysis.notes.list`). The resource takes the format
            /// `projects/[PROJECT_ID]/notes/[NOTE_ID]` for notes and
            /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for occurrences.
            /// </summary>
            public class TestIamPermissionsRequest : ContainerAnalysisBaseServiceRequest<Google.Apis.ContainerAnalysis.v1beta1.Data.TestIamPermissionsResponse>
            {
                /// <summary>Constructs a new TestIamPermissions request.</summary>
                public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.ContainerAnalysis.v1beta1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                Google.Apis.ContainerAnalysis.v1beta1.Data.TestIamPermissionsRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "testIamPermissions";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+resource}:testIamPermissions";

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
                        Pattern = @"^projects/[^/]+/occurrences/[^/]+$",
                    });
                }
            }
        }
    }
}
namespace Google.Apis.ContainerAnalysis.v1beta1.Data
{
    /// <summary>An alias to a repo revision.</summary>
    public class AliasContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The alias kind.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The alias name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Indicates which analysis completed successfully. Multiple types of analysis can be performed on a single
    /// resource.
    /// </summary>
    public class AnalysisCompleted : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("analysisType")]
        public virtual System.Collections.Generic.IList<string> AnalysisType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Artifact describes a build product.</summary>
    public class Artifact : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Hash or checksum value of a binary, or Docker Registry 2.0 digest of a container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("checksum")]
        public virtual string Checksum { get; set; }

        /// <summary>
        /// Artifact ID, if any; for container images, this will be a URL by digest like
        /// `gcr.io/projectID/imagename@sha256:123456`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Related artifact names. This may be the path to a binary or jar file, or in the case of a container build,
        /// the name used to push the container image to Google Container Registry, as presented to `docker push`. Note
        /// that a single Artifact ID can have multiple names, for example if two tags are applied to one image.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("names")]
        public virtual System.Collections.Generic.IList<string> Names { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines a hash object for use in Materials and Products.</summary>
    public class ArtifactHashes : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("sha256")]
        public virtual string Sha256 { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines an object to declare an in-toto artifact rule</summary>
    public class ArtifactRule : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("artifactRule")]
        public virtual System.Collections.Generic.IList<string> ArtifactRuleValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Occurrence that represents a single "attestation". The authenticity of an attestation can be verified using the
    /// attached signature. If the verifier trusts the public key of the signer, then verifying the signature is
    /// sufficient to establish trust. In this circumstance, the authority to which this attestation is attached is
    /// primarily useful for look-up (how to find this attestation if you already know the authority and artifact to be
    /// verified) and intent (which authority was this attestation intended to sign for).
    /// </summary>
    public class Attestation : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("genericSignedAttestation")]
        public virtual GenericSignedAttestation GenericSignedAttestation { get; set; }

        /// <summary>A PGP signed attestation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pgpSignedAttestation")]
        public virtual PgpSignedAttestation PgpSignedAttestation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Note kind that represents a logical attestation "role" or "authority". For example, an organization might have
    /// one `Authority` for "QA" and one for "build". This note is intended to act strictly as a grouping mechanism for
    /// the attached occurrences (Attestations). This grouping mechanism also provides a security boundary, since IAM
    /// ACLs gate the ability for a principle to attach an occurrence to a given note. It also provides a single point
    /// of lookup to find all attached attestation occurrences, even if they don't all live in the same project.
    /// </summary>
    public class Authority : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Hint hints at the purpose of the attestation authority.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hint")]
        public virtual Hint Hint { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Basis describes the base image portion (Note) of the DockerImage relationship. Linked occurrences are derived
    /// from this or an equivalent image via: FROM Or an equivalent reference, e.g. a tag of the resource_url.
    /// </summary>
    public class Basis : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Immutable. The fingerprint of the base image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fingerprint")]
        public virtual Fingerprint Fingerprint { get; set; }

        /// <summary>
        /// Required. Immutable. The resource_url for the resource representing the basis of associated occurrence
        /// images.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceUrl")]
        public virtual string ResourceUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to create notes in batch.</summary>
    public class BatchCreateNotesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The notes to create, the key is expected to be the note ID. Max allowed length is 1000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notes")]
        public virtual System.Collections.Generic.IDictionary<string, Note> Notes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for creating notes in batch.</summary>
    public class BatchCreateNotesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The notes that were created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notes")]
        public virtual System.Collections.Generic.IList<Note> Notes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to create occurrences in batch.</summary>
    public class BatchCreateOccurrencesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The occurrences to create. Max allowed length is 1000.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("occurrences")]
        public virtual System.Collections.Generic.IList<Occurrence> Occurrences { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for creating occurrences in batch.</summary>
    public class BatchCreateOccurrencesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The occurrences that were created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("occurrences")]
        public virtual System.Collections.Generic.IList<Occurrence> Occurrences { get; set; }

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
        /// represents a Google group. For example, `admins@example.com`. * `deleted:user:{emailid}?uid={uniqueid}`: An
        /// email address (plus unique identifier) representing a user that has been recently deleted. For example,
        /// `alice@example.com?uid=123456789012345678901`. If the user is recovered, this value reverts to
        /// `user:{emailid}` and the recovered user retains the role in the binding. *
        /// `deleted:serviceAccount:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing a
        /// service account that has been recently deleted. For example,
        /// `my-other-app@appspot.gserviceaccount.com?uid=123456789012345678901`. If the service account is undeleted,
        /// this value reverts to `serviceAccount:{emailid}` and the undeleted service account retains the role in the
        /// binding. * `deleted:group:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing
        /// a Google group that has been recently deleted. For example, `admins@example.com?uid=123456789012345678901`.
        /// If the group is recovered, this value reverts to `group:{emailid}` and the recovered group retains the role
        /// in the binding. * `domain:{domain}`: The G Suite domain (primary) that represents all the users of that
        /// domain. For example, `google.com` or `example.com`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("members")]
        public virtual System.Collections.Generic.IList<string> Members { get; set; }

        /// <summary>
        /// Role that is assigned to the list of `members`, or principals. For example, `roles/viewer`, `roles/editor`,
        /// or `roles/owner`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Note holding the version of the provider's builder and the signature of the provenance message in the build
    /// details occurrence.
    /// </summary>
    public class Build : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Immutable. Version of the builder which produced this build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("builderVersion")]
        public virtual string BuilderVersion { get; set; }

        /// <summary>
        /// Signature of the build in occurrences pointing to this build note containing build details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signature")]
        public virtual BuildSignature Signature { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Provenance of a build. Contains all information needed to verify the full details about the build from source to
    /// completion.
    /// </summary>
    public class BuildProvenance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Special options applied to this build. This is a catch-all field where build providers can enter any desired
        /// additional details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildOptions")]
        public virtual System.Collections.Generic.IDictionary<string, string> BuildOptions { get; set; }

        /// <summary>Version string of the builder at the time this build was executed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("builderVersion")]
        public virtual string BuilderVersion { get; set; }

        /// <summary>Output of the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("builtArtifacts")]
        public virtual System.Collections.Generic.IList<Artifact> BuiltArtifacts { get; set; }

        /// <summary>Commands requested by the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commands")]
        public virtual System.Collections.Generic.IList<Command> Commands { get; set; }

        /// <summary>Time at which the build was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// E-mail address of the user who initiated this build. Note that this was the user's e-mail address at the
        /// time the build was initiated; this address may not represent the same end-user for all time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creator")]
        public virtual string Creator { get; set; }

        /// <summary>Time at which execution of the build was finished.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>Required. Unique identifier of the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>URI where any logs for this provenance were written.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logsUri")]
        public virtual string LogsUri { get; set; }

        /// <summary>ID of the project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>Details of the Source input to the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceProvenance")]
        public virtual Source SourceProvenance { get; set; }

        /// <summary>Time at which execution of the build was started.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>Trigger identifier if the build was triggered automatically; empty if not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("triggerId")]
        public virtual string TriggerId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message encapsulating the signature of the verified build.</summary>
    public class BuildSignature : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An ID for the key used to sign. This could be either an ID for the key stored in `public_key` (such as the
        /// ID or fingerprint for a PGP key, or the CN for a cert), or a reference to an external key (such as a
        /// reference to a key in Cloud Key Management Service).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyId")]
        public virtual string KeyId { get; set; }

        /// <summary>The type of the key, either stored in `public_key` or referenced in `key_id`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyType")]
        public virtual string KeyType { get; set; }

        /// <summary>
        /// Public key of the builder which can be used to verify that the related findings are valid and unchanged. If
        /// `key_type` is empty, this defaults to PEM encoded public keys. This field may be empty if `key_id`
        /// references an external key. For Cloud Build based signatures, this is a PEM encoded public key. To verify
        /// the Cloud Build signature, place the contents of this field into a file (public.pem). The signature field is
        /// base64-decoded into its binary representation in signature.bin, and the provenance bytes from `BuildDetails`
        /// are base64-decoded into a binary representation in signed.bin. OpenSSL can then verify the signature:
        /// `openssl sha256 -verify public.pem -signature signature.bin signed.bin`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicKey")]
        public virtual string PublicKey { get; set; }

        /// <summary>Required. Signature of the related `BuildProvenance`. In JSON, this is base-64 encoded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signature")]
        public virtual string Signature { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A step in the build pipeline. Next ID: 20</summary>
    public class BuildStep : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Allow this build step to fail without failing the entire build if and only if the exit code is one of the
        /// specified codes. If allow_failure is also specified, this field will take precedence.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowExitCodes")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> AllowExitCodes { get; set; }

        /// <summary>
        /// Allow this build step to fail without failing the entire build. If false, the entire build will fail if this
        /// step fails. Otherwise, the build will succeed, but this step will still have a failure status. Error
        /// information will be reported in the failure_detail field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowFailure")]
        public virtual System.Nullable<bool> AllowFailure { get; set; }

        /// <summary>
        /// A list of arguments that will be presented to the step when it is started. If the image used to run the
        /// step's container has an entrypoint, the `args` are used as arguments to that entrypoint. If the image does
        /// not define an entrypoint, the first element in args is used as the entrypoint, and the remainder will be
        /// used as arguments.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("args")]
        public virtual System.Collections.Generic.IList<string> Args { get; set; }

        /// <summary>
        /// Working directory to use when running this step's container. If this value is a relative path, it is
        /// relative to the build's working directory. If this value is absolute, it may be outside the build's working
        /// directory, in which case the contents of the path may not be persisted across build step executions, unless
        /// a `volume` for that path is specified. If the build specifies a `RepoSource` with `dir` and a step with a
        /// `dir`, which specifies an absolute path, the `RepoSource` `dir` is ignored for the step's execution.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dir")]
        public virtual string Dir { get; set; }

        /// <summary>
        /// Entrypoint to be used instead of the build step image's default entrypoint. If unset, the image's default
        /// entrypoint is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entrypoint")]
        public virtual string Entrypoint { get; set; }

        /// <summary>
        /// A list of environment variable definitions to be used when running a step. The elements are of the form
        /// "KEY=VALUE" for the environment variable "KEY" being given the value "VALUE".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("env")]
        public virtual System.Collections.Generic.IList<string> Env { get; set; }

        /// <summary>Output only. Return code from running the step.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exitCode")]
        public virtual System.Nullable<int> ExitCode { get; set; }

        /// <summary>
        /// Unique identifier for this build step, used in `wait_for` to reference this build step as a dependency.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Required. The name of the container image that will run this particular build step. If the image is
        /// available in the host's Docker daemon's cache, it will be run directly. If not, the host will attempt to
        /// pull the image first, using the builder service account's credentials if necessary. The Docker daemon's
        /// cache will already have the latest versions of all of the officially supported build steps
        /// ([https://github.com/GoogleCloudPlatform/cloud-builders](https://github.com/GoogleCloudPlatform/cloud-builders)).
        /// The Docker daemon will also have cached many of the layers for some popular images, like "ubuntu", "debian",
        /// but they will be refreshed at the time you attempt to use them. If you built an image in a previous build
        /// step, it will be stored in the host's Docker daemon's cache and is available to use as the name for a later
        /// build step.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Stores timing information for pulling this build step's builder image only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pullTiming")]
        public virtual TimeSpan PullTiming { get; set; }

        /// <summary>
        /// A shell script to be executed in the step. When script is provided, the user cannot specify the entrypoint
        /// or args.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("script")]
        public virtual string Script { get; set; }

        /// <summary>
        /// A list of environment variables which are encrypted using a Cloud Key Management Service crypto key. These
        /// values must be specified in the build's `Secret`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secretEnv")]
        public virtual System.Collections.Generic.IList<string> SecretEnv { get; set; }

        /// <summary>
        /// Output only. Status of the build step. At this time, build step status is only updated on build completion;
        /// step status is not updated in real-time as the build progresses.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>
        /// Time limit for executing this build step. If not defined, the step has no time limit and will be allowed to
        /// continue to run until either it completes or the build itself times out.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeout")]
        public virtual object Timeout { get; set; }

        /// <summary>Output only. Stores timing information for executing this build step.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timing")]
        public virtual TimeSpan Timing { get; set; }

        /// <summary>
        /// List of volumes to mount into the build step. Each volume is created as an empty volume prior to execution
        /// of the build step. Upon completion of the build, volumes and their contents are discarded. Using a named
        /// volume in only one step is not valid as it is indicative of a build request with an incorrect configuration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumes")]
        public virtual System.Collections.Generic.IList<Volume> Volumes { get; set; }

        /// <summary>
        /// The ID(s) of the step(s) that this build step depends on. This build step will not start until all the build
        /// steps in `wait_for` have completed successfully. If `wait_for` is empty, this build step will start when all
        /// previous build steps in the `Build.Steps` list have completed successfully.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("waitFor")]
        public virtual System.Collections.Generic.IList<string> WaitFor { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Defines an object for the byproducts field in in-toto links. The suggested fields are "stderr", "stdout", and
    /// "return-value".
    /// </summary>
    public class ByProducts : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("customValues")]
        public virtual System.Collections.Generic.IDictionary<string, string> CustomValues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Common Vulnerability Scoring System. This message is compatible with CVSS v2 and v3. For CVSS v2 details, see
    /// https://www.first.org/cvss/v2/guide CVSS v2 calculator: https://nvd.nist.gov/vuln-metrics/cvss/v2-calculator For
    /// CVSS v3 details, see https://www.first.org/cvss/specification-document CVSS v3 calculator:
    /// https://nvd.nist.gov/vuln-metrics/cvss/v3-calculator
    /// </summary>
    public class CVSS : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Defined in CVSS v3, CVSS v2</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attackComplexity")]
        public virtual string AttackComplexity { get; set; }

        /// <summary>
        /// Base Metrics Represents the intrinsic characteristics of a vulnerability that are constant over time and
        /// across user environments. Defined in CVSS v3, CVSS v2
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attackVector")]
        public virtual string AttackVector { get; set; }

        /// <summary>Defined in CVSS v2</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authentication")]
        public virtual string Authentication { get; set; }

        /// <summary>Defined in CVSS v3, CVSS v2</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availabilityImpact")]
        public virtual string AvailabilityImpact { get; set; }

        /// <summary>The base score is a function of the base metric scores.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseScore")]
        public virtual System.Nullable<float> BaseScore { get; set; }

        /// <summary>Defined in CVSS v3, CVSS v2</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidentialityImpact")]
        public virtual string ConfidentialityImpact { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("exploitabilityScore")]
        public virtual System.Nullable<float> ExploitabilityScore { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("impactScore")]
        public virtual System.Nullable<float> ImpactScore { get; set; }

        /// <summary>Defined in CVSS v3, CVSS v2</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("integrityImpact")]
        public virtual string IntegrityImpact { get; set; }

        /// <summary>Defined in CVSS v3</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privilegesRequired")]
        public virtual string PrivilegesRequired { get; set; }

        /// <summary>Defined in CVSS v3</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public virtual string Scope { get; set; }

        /// <summary>Defined in CVSS v3</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userInteraction")]
        public virtual string UserInteraction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Deprecated. Common Vulnerability Scoring System version 3. For details, see
    /// https://www.first.org/cvss/specification-document
    /// </summary>
    public class CVSSv3 : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("attackComplexity")]
        public virtual string AttackComplexity { get; set; }

        /// <summary>
        /// Base Metrics Represents the intrinsic characteristics of a vulnerability that are constant over time and
        /// across user environments.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attackVector")]
        public virtual string AttackVector { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("availabilityImpact")]
        public virtual string AvailabilityImpact { get; set; }

        /// <summary>The base score is a function of the base metric scores.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseScore")]
        public virtual System.Nullable<float> BaseScore { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("confidentialityImpact")]
        public virtual string ConfidentialityImpact { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("exploitabilityScore")]
        public virtual System.Nullable<float> ExploitabilityScore { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("impactScore")]
        public virtual System.Nullable<float> ImpactScore { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("integrityImpact")]
        public virtual string IntegrityImpact { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("privilegesRequired")]
        public virtual string PrivilegesRequired { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public virtual string Scope { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("userInteraction")]
        public virtual string UserInteraction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A CloudRepoSourceContext denotes a particular revision in a Google Cloud Source Repo.</summary>
    public class CloudRepoSourceContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An alias, which may be a branch or tag.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aliasContext")]
        public virtual AliasContext AliasContext { get; set; }

        /// <summary>The ID of the repo.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repoId")]
        public virtual RepoId RepoId { get; set; }

        /// <summary>A revision ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionId")]
        public virtual string RevisionId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Command describes a step performed as part of the build pipeline.</summary>
    public class Command : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Command-line arguments used when executing this command.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("args")]
        public virtual System.Collections.Generic.IList<string> Args { get; set; }

        /// <summary>Working directory (relative to project source root) used when running this command.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dir")]
        public virtual string Dir { get; set; }

        /// <summary>Environment variables set before running this command.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("env")]
        public virtual System.Collections.Generic.IList<string> Env { get; set; }

        /// <summary>
        /// Optional unique identifier for this command, used in wait_for to reference this command as a dependency.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Required. Name of the command, as presented on the command line, or if the command is packaged as a Docker
        /// container, as presented to `docker pull`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ID(s) of the command(s) that this command depends on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("waitFor")]
        public virtual System.Collections.Generic.IList<string> WaitFor { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ApprovalConfig describes configuration for manual approval of a build.</summary>
    public class ContaineranalysisGoogleDevtoolsCloudbuildV1ApprovalConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether or not approval is needed. If this is set on a build, it will become pending when created, and will
        /// need to be explicitly approved to start.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("approvalRequired")]
        public virtual System.Nullable<bool> ApprovalRequired { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// ApprovalResult describes the decision and associated metadata of a manual approval of a build.
    /// </summary>
    public class ContaineranalysisGoogleDevtoolsCloudbuildV1ApprovalResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The time when the approval decision was made.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("approvalTime")]
        public virtual object ApprovalTime { get; set; }

        /// <summary>
        /// Output only. Email of the user that called the ApproveBuild API to approve or reject a build at the time
        /// that the API was called.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("approverAccount")]
        public virtual string ApproverAccount { get; set; }

        /// <summary>Optional. An optional comment for this manual approval result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("comment")]
        public virtual string Comment { get; set; }

        /// <summary>Required. The decision of this manual approval.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("decision")]
        public virtual string Decision { get; set; }

        /// <summary>
        /// Optional. An optional URL tied to this manual approval result. This field is essentially the same as
        /// comment, except that it will be rendered by the UI differently. An example use case is a link to an external
        /// job that approved this Build.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Artifacts produced by a build that should be uploaded upon successful completion of all build steps.
    /// </summary>
    public class ContaineranalysisGoogleDevtoolsCloudbuildV1Artifacts : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of images to be pushed upon the successful completion of all build steps. The images will be pushed
        /// using the builder service account's credentials. The digests of the pushed images will be stored in the
        /// Build resource's results field. If any of the images fail to be pushed, the build is marked FAILURE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("images")]
        public virtual System.Collections.Generic.IList<string> Images { get; set; }

        /// <summary>
        /// A list of Maven artifacts to be uploaded to Artifact Registry upon successful completion of all build steps.
        /// Artifacts in the workspace matching specified paths globs will be uploaded to the specified Artifact
        /// Registry repository using the builder service account's credentials. If any artifacts fail to be pushed, the
        /// build is marked FAILURE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mavenArtifacts")]
        public virtual System.Collections.Generic.IList<ContaineranalysisGoogleDevtoolsCloudbuildV1ArtifactsMavenArtifact> MavenArtifacts { get; set; }

        /// <summary>
        /// A list of objects to be uploaded to Cloud Storage upon successful completion of all build steps. Files in
        /// the workspace matching specified paths globs will be uploaded to the specified Cloud Storage location using
        /// the builder service account's credentials. The location and generation of the uploaded objects will be
        /// stored in the Build resource's results field. If any objects fail to be pushed, the build is marked FAILURE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objects")]
        public virtual ContaineranalysisGoogleDevtoolsCloudbuildV1ArtifactsArtifactObjects Objects { get; set; }

        /// <summary>
        /// A list of Python packages to be uploaded to Artifact Registry upon successful completion of all build steps.
        /// The build service account credentials will be used to perform the upload. If any objects fail to be pushed,
        /// the build is marked FAILURE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pythonPackages")]
        public virtual System.Collections.Generic.IList<ContaineranalysisGoogleDevtoolsCloudbuildV1ArtifactsPythonPackage> PythonPackages { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Files in the workspace to upload to Cloud Storage upon successful completion of all build steps.
    /// </summary>
    public class ContaineranalysisGoogleDevtoolsCloudbuildV1ArtifactsArtifactObjects : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Cloud Storage bucket and optional object path, in the form "gs://bucket/path/to/somewhere/". (see [Bucket
        /// Name Requirements](https://cloud.google.com/storage/docs/bucket-naming#requirements)). Files in the
        /// workspace matching any path pattern will be uploaded to Cloud Storage with this location as a prefix.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>Path globs used to match files in the build's workspace.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paths")]
        public virtual System.Collections.Generic.IList<string> Paths { get; set; }

        /// <summary>Output only. Stores timing information for pushing all artifact objects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timing")]
        public virtual ContaineranalysisGoogleDevtoolsCloudbuildV1TimeSpan Timing { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A Maven artifact to upload to Artifact Registry upon successful completion of all build steps.
    /// </summary>
    public class ContaineranalysisGoogleDevtoolsCloudbuildV1ArtifactsMavenArtifact : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Maven `artifactId` value used when uploading the artifact to Artifact Registry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("artifactId")]
        public virtual string ArtifactId { get; set; }

        /// <summary>Maven `groupId` value used when uploading the artifact to Artifact Registry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupId")]
        public virtual string GroupId { get; set; }

        /// <summary>
        /// Path to an artifact in the build's workspace to be uploaded to Artifact Registry. This can be either an
        /// absolute path, e.g. /workspace/my-app/target/my-app-1.0.SNAPSHOT.jar or a relative path from /workspace,
        /// e.g. my-app/target/my-app-1.0.SNAPSHOT.jar.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>
        /// Artifact Registry repository, in the form "https://$REGION-maven.pkg.dev/$PROJECT/$REPOSITORY" Artifact in
        /// the workspace specified by path will be uploaded to Artifact Registry with this location as a prefix.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repository")]
        public virtual string Repository { get; set; }

        /// <summary>Maven `version` value used when uploading the artifact to Artifact Registry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Python package to upload to Artifact Registry upon successful completion of all build steps. A package can
    /// encapsulate multiple objects to be uploaded to a single repository.
    /// </summary>
    public class ContaineranalysisGoogleDevtoolsCloudbuildV1ArtifactsPythonPackage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Path globs used to match files in the build's workspace. For Python/ Twine, this is usually `dist/*`, and
        /// sometimes additionally an `.asc` file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paths")]
        public virtual System.Collections.Generic.IList<string> Paths { get; set; }

        /// <summary>
        /// Artifact Registry repository, in the form "https://$REGION-python.pkg.dev/$PROJECT/$REPOSITORY" Files in the
        /// workspace matching any path pattern will be uploaded to Artifact Registry with this location as a prefix.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repository")]
        public virtual string Repository { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A build resource in the Cloud Build API. At a high level, a `Build` describes where to find source code, how to
    /// build it (for example, the builder image to run on the source), and where to store the built artifacts. Fields
    /// can include the following variables, which will be expanded when the build is created: - $PROJECT_ID: the
    /// project ID of the build. - $PROJECT_NUMBER: the project number of the build. - $LOCATION: the location/region of
    /// the build. - $BUILD_ID: the autogenerated ID of the build. - $REPO_NAME: the source repository name specified by
    /// RepoSource. - $BRANCH_NAME: the branch name specified by RepoSource. - $TAG_NAME: the tag name specified by
    /// RepoSource. - $REVISION_ID or $COMMIT_SHA: the commit SHA specified by RepoSource or resolved from the specified
    /// branch or tag. - $SHORT_SHA: first 7 characters of $REVISION_ID or $COMMIT_SHA.
    /// </summary>
    public class ContaineranalysisGoogleDevtoolsCloudbuildV1Build : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Describes this build's approval configuration, status, and result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("approval")]
        public virtual ContaineranalysisGoogleDevtoolsCloudbuildV1BuildApproval Approval { get; set; }

        /// <summary>
        /// Artifacts produced by the build that should be uploaded upon successful completion of all build steps.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("artifacts")]
        public virtual ContaineranalysisGoogleDevtoolsCloudbuildV1Artifacts Artifacts { get; set; }

        /// <summary>Secrets and secret environment variables.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availableSecrets")]
        public virtual ContaineranalysisGoogleDevtoolsCloudbuildV1Secrets AvailableSecrets { get; set; }

        /// <summary>
        /// Output only. The ID of the `BuildTrigger` that triggered this build, if it was triggered automatically.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildTriggerId")]
        public virtual string BuildTriggerId { get; set; }

        /// <summary>Output only. Time at which the request to create the build was received.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. Contains information about the build when status=FAILURE.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failureInfo")]
        public virtual ContaineranalysisGoogleDevtoolsCloudbuildV1BuildFailureInfo FailureInfo { get; set; }

        /// <summary>
        /// Output only. Time at which execution of the build was finished. The difference between finish_time and
        /// start_time is the duration of the build's execution.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finishTime")]
        public virtual object FinishTime { get; set; }

        /// <summary>Output only. Unique identifier of the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// A list of images to be pushed upon the successful completion of all build steps. The images are pushed using
        /// the builder service account's credentials. The digests of the pushed images will be stored in the `Build`
        /// resource's results field. If any of the images fail to be pushed, the build status is marked `FAILURE`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("images")]
        public virtual System.Collections.Generic.IList<string> Images { get; set; }

        /// <summary>Output only. URL to logs for this build in Google Cloud Console.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logUrl")]
        public virtual string LogUrl { get; set; }

        /// <summary>
        /// Google Cloud Storage bucket where logs should be written (see [Bucket Name
        /// Requirements](https://cloud.google.com/storage/docs/bucket-naming#requirements)). Logs file names will be of
        /// the format `${logs_bucket}/log-${build_id}.txt`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logsBucket")]
        public virtual string LogsBucket { get; set; }

        /// <summary>
        /// Output only. The 'Build' name with format: `projects/{project}/locations/{location}/builds/{build}`, where
        /// {build} is a unique identifier generated by the service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Special options for this build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("options")]
        public virtual ContaineranalysisGoogleDevtoolsCloudbuildV1BuildOptions Options { get; set; }

        /// <summary>Output only. ID of the project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>
        /// TTL in queue for this build. If provided and the build is enqueued longer than this value, the build will
        /// expire and the build status will be `EXPIRED`. The TTL starts ticking from create_time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queueTtl")]
        public virtual object QueueTtl { get; set; }

        /// <summary>Output only. Results of the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("results")]
        public virtual ContaineranalysisGoogleDevtoolsCloudbuildV1Results Results { get; set; }

        /// <summary>
        /// Secrets to decrypt using Cloud Key Management Service. Note: Secret Manager is the recommended technique for
        /// managing sensitive data with Cloud Build. Use `available_secrets` to configure builds to access secrets from
        /// Secret Manager. For instructions, see: https://cloud.google.com/cloud-build/docs/securing-builds/use-secrets
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secrets")]
        public virtual System.Collections.Generic.IList<ContaineranalysisGoogleDevtoolsCloudbuildV1Secret> Secrets { get; set; }

        /// <summary>
        /// IAM service account whose credentials will be used at build runtime. Must be of the format
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`. ACCOUNT can be email address or uniqueId of the service
        /// account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>The location of the source files to build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual ContaineranalysisGoogleDevtoolsCloudbuildV1Source Source { get; set; }

        /// <summary>Output only. A permanent fixed identifier for source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceProvenance")]
        public virtual ContaineranalysisGoogleDevtoolsCloudbuildV1SourceProvenance SourceProvenance { get; set; }

        /// <summary>Output only. Time at which execution of the build was started.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>Output only. Status of the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>Output only. Customer-readable message about the current status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusDetail")]
        public virtual string StatusDetail { get; set; }

        /// <summary>Required. The operations to be performed on the workspace.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("steps")]
        public virtual System.Collections.Generic.IList<ContaineranalysisGoogleDevtoolsCloudbuildV1BuildStep> Steps { get; set; }

        /// <summary>Substitutions data for `Build` resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("substitutions")]
        public virtual System.Collections.Generic.IDictionary<string, string> Substitutions { get; set; }

        /// <summary>Tags for annotation of a `Build`. These are not docker tags.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>
        /// Amount of time that this build should be allowed to run, to second granularity. If this amount of time
        /// elapses, work on the build will cease and the build status will be `TIMEOUT`. `timeout` starts ticking from
        /// `startTime`. Default time is ten minutes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeout")]
        public virtual object Timeout { get; set; }

        /// <summary>
        /// Output only. Stores timing information for phases of the build. Valid keys are: * BUILD: time to execute all
        /// build steps. * PUSH: time to push all artifacts including docker images and non docker artifacts. *
        /// FETCHSOURCE: time to fetch source. * SETUPBUILD: time to set up build. If the build does not specify source
        /// or images, these keys will not be included.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timing")]
        public virtual System.Collections.Generic.IDictionary<string, ContaineranalysisGoogleDevtoolsCloudbuildV1TimeSpan> Timing { get; set; }

        /// <summary>Output only. Non-fatal problems encountered during the execution of the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warnings")]
        public virtual System.Collections.Generic.IList<ContaineranalysisGoogleDevtoolsCloudbuildV1BuildWarning> Warnings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>BuildApproval describes a build's approval configuration, state, and result.</summary>
    public class ContaineranalysisGoogleDevtoolsCloudbuildV1BuildApproval : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Configuration for manual approval of this build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual ContaineranalysisGoogleDevtoolsCloudbuildV1ApprovalConfig Config { get; set; }

        /// <summary>Output only. Result of manual approval for this Build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("result")]
        public virtual ContaineranalysisGoogleDevtoolsCloudbuildV1ApprovalResult Result { get; set; }

        /// <summary>Output only. The state of this build's approval.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A fatal problem encountered during the execution of the build.</summary>
    public class ContaineranalysisGoogleDevtoolsCloudbuildV1BuildFailureInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Explains the failure issue in more detail using hard-coded text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detail")]
        public virtual string Detail { get; set; }

        /// <summary>The name of the failure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Optional arguments to enable specific features of builds.</summary>
    public class ContaineranalysisGoogleDevtoolsCloudbuildV1BuildOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Requested disk size for the VM that runs the build. Note that this is *NOT* "disk free"; some of the space
        /// will be used by the operating system and build utilities. Also note that this is the minimum disk size that
        /// will be allocated for the build -- the build may run with a larger disk than requested. At present, the
        /// maximum disk size is 2000GB; builds that request more than the maximum are rejected with an error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskSizeGb")]
        public virtual System.Nullable<long> DiskSizeGb { get; set; }

        /// <summary>
        /// Option to specify whether or not to apply bash style string operations to the substitutions. NOTE: this is
        /// always enabled for triggered builds and cannot be overridden in the build configuration file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dynamicSubstitutions")]
        public virtual System.Nullable<bool> DynamicSubstitutions { get; set; }

        /// <summary>
        /// A list of global environment variable definitions that will exist for all build steps in this build. If a
        /// variable is defined in both globally and in a build step, the variable will use the build step value. The
        /// elements are of the form "KEY=VALUE" for the environment variable "KEY" being given the value "VALUE".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("env")]
        public virtual System.Collections.Generic.IList<string> Env { get; set; }

        /// <summary>Option to define build log streaming behavior to Google Cloud Storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logStreamingOption")]
        public virtual string LogStreamingOption { get; set; }

        /// <summary>Option to specify the logging mode, which determines if and where build logs are stored.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logging")]
        public virtual string Logging { get; set; }

        /// <summary>Compute Engine machine type on which to run the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineType")]
        public virtual string MachineType { get; set; }

        /// <summary>
        /// Optional. Specification for execution on a `WorkerPool`. See [running builds in a private
        /// pool](https://cloud.google.com/build/docs/private-pools/run-builds-in-private-pool) for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pool")]
        public virtual ContaineranalysisGoogleDevtoolsCloudbuildV1BuildOptionsPoolOption Pool { get; set; }

        /// <summary>Requested verifiability options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedVerifyOption")]
        public virtual string RequestedVerifyOption { get; set; }

        /// <summary>
        /// A list of global environment variables, which are encrypted using a Cloud Key Management Service crypto key.
        /// These values must be specified in the build's `Secret`. These variables will be available to all build steps
        /// in this build.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secretEnv")]
        public virtual System.Collections.Generic.IList<string> SecretEnv { get; set; }

        /// <summary>Requested hash for SourceProvenance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceProvenanceHash")]
        public virtual System.Collections.Generic.IList<string> SourceProvenanceHash { get; set; }

        /// <summary>
        /// Option to specify behavior when there is an error in the substitution checks. NOTE: this is always set to
        /// ALLOW_LOOSE for triggered builds and cannot be overridden in the build configuration file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("substitutionOption")]
        public virtual string SubstitutionOption { get; set; }

        /// <summary>
        /// Global list of volumes to mount for ALL build steps Each volume is created as an empty volume prior to
        /// starting the build process. Upon completion of the build, volumes and their contents are discarded. Global
        /// volume names and paths cannot conflict with the volumes defined a build step. Using a global volume in a
        /// build with only one step is not valid as it is indicative of a build request with an incorrect
        /// configuration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumes")]
        public virtual System.Collections.Generic.IList<ContaineranalysisGoogleDevtoolsCloudbuildV1Volume> Volumes { get; set; }

        /// <summary>This field deprecated; please use `pool.name` instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workerPool")]
        public virtual string WorkerPool { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Details about how a build should be executed on a `WorkerPool`. See [running builds in a private
    /// pool](https://cloud.google.com/build/docs/private-pools/run-builds-in-private-pool) for more information.
    /// </summary>
    public class ContaineranalysisGoogleDevtoolsCloudbuildV1BuildOptionsPoolOption : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The `WorkerPool` resource to execute the build on. You must have `cloudbuild.workerpools.use` on the project
        /// hosting the WorkerPool. Format projects/{project}/locations/{location}/workerPools/{workerPoolId}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A step in the build pipeline.</summary>
    public class ContaineranalysisGoogleDevtoolsCloudbuildV1BuildStep : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Allow this build step to fail without failing the entire build if and only if the exit code is one of the
        /// specified codes. If allow_failure is also specified, this field will take precedence.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowExitCodes")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> AllowExitCodes { get; set; }

        /// <summary>
        /// Allow this build step to fail without failing the entire build. If false, the entire build will fail if this
        /// step fails. Otherwise, the build will succeed, but this step will still have a failure status. Error
        /// information will be reported in the failure_detail field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowFailure")]
        public virtual System.Nullable<bool> AllowFailure { get; set; }

        /// <summary>
        /// A list of arguments that will be presented to the step when it is started. If the image used to run the
        /// step's container has an entrypoint, the `args` are used as arguments to that entrypoint. If the image does
        /// not define an entrypoint, the first element in args is used as the entrypoint, and the remainder will be
        /// used as arguments.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("args")]
        public virtual System.Collections.Generic.IList<string> Args { get; set; }

        /// <summary>
        /// Working directory to use when running this step's container. If this value is a relative path, it is
        /// relative to the build's working directory. If this value is absolute, it may be outside the build's working
        /// directory, in which case the contents of the path may not be persisted across build step executions, unless
        /// a `volume` for that path is specified. If the build specifies a `RepoSource` with `dir` and a step with a
        /// `dir`, which specifies an absolute path, the `RepoSource` `dir` is ignored for the step's execution.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dir")]
        public virtual string Dir { get; set; }

        /// <summary>
        /// Entrypoint to be used instead of the build step image's default entrypoint. If unset, the image's default
        /// entrypoint is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entrypoint")]
        public virtual string Entrypoint { get; set; }

        /// <summary>
        /// A list of environment variable definitions to be used when running a step. The elements are of the form
        /// "KEY=VALUE" for the environment variable "KEY" being given the value "VALUE".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("env")]
        public virtual System.Collections.Generic.IList<string> Env { get; set; }

        /// <summary>Output only. Return code from running the step.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exitCode")]
        public virtual System.Nullable<int> ExitCode { get; set; }

        /// <summary>
        /// Unique identifier for this build step, used in `wait_for` to reference this build step as a dependency.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Required. The name of the container image that will run this particular build step. If the image is
        /// available in the host's Docker daemon's cache, it will be run directly. If not, the host will attempt to
        /// pull the image first, using the builder service account's credentials if necessary. The Docker daemon's
        /// cache will already have the latest versions of all of the officially supported build steps
        /// ([https://github.com/GoogleCloudPlatform/cloud-builders](https://github.com/GoogleCloudPlatform/cloud-builders)).
        /// The Docker daemon will also have cached many of the layers for some popular images, like "ubuntu", "debian",
        /// but they will be refreshed at the time you attempt to use them. If you built an image in a previous build
        /// step, it will be stored in the host's Docker daemon's cache and is available to use as the name for a later
        /// build step.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Stores timing information for pulling this build step's builder image only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pullTiming")]
        public virtual ContaineranalysisGoogleDevtoolsCloudbuildV1TimeSpan PullTiming { get; set; }

        /// <summary>
        /// A shell script to be executed in the step. When script is provided, the user cannot specify the entrypoint
        /// or args.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("script")]
        public virtual string Script { get; set; }

        /// <summary>
        /// A list of environment variables which are encrypted using a Cloud Key Management Service crypto key. These
        /// values must be specified in the build's `Secret`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secretEnv")]
        public virtual System.Collections.Generic.IList<string> SecretEnv { get; set; }

        /// <summary>
        /// Output only. Status of the build step. At this time, build step status is only updated on build completion;
        /// step status is not updated in real-time as the build progresses.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>
        /// Time limit for executing this build step. If not defined, the step has no time limit and will be allowed to
        /// continue to run until either it completes or the build itself times out.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeout")]
        public virtual object Timeout { get; set; }

        /// <summary>Output only. Stores timing information for executing this build step.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timing")]
        public virtual ContaineranalysisGoogleDevtoolsCloudbuildV1TimeSpan Timing { get; set; }

        /// <summary>
        /// List of volumes to mount into the build step. Each volume is created as an empty volume prior to execution
        /// of the build step. Upon completion of the build, volumes and their contents are discarded. Using a named
        /// volume in only one step is not valid as it is indicative of a build request with an incorrect configuration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumes")]
        public virtual System.Collections.Generic.IList<ContaineranalysisGoogleDevtoolsCloudbuildV1Volume> Volumes { get; set; }

        /// <summary>
        /// The ID(s) of the step(s) that this build step depends on. This build step will not start until all the build
        /// steps in `wait_for` have completed successfully. If `wait_for` is empty, this build step will start when all
        /// previous build steps in the `Build.Steps` list have completed successfully.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("waitFor")]
        public virtual System.Collections.Generic.IList<string> WaitFor { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A non-fatal problem encountered during the execution of the build.</summary>
    public class ContaineranalysisGoogleDevtoolsCloudbuildV1BuildWarning : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The priority for this warning.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priority")]
        public virtual string Priority { get; set; }

        /// <summary>Explanation of the warning generated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An image built by the pipeline.</summary>
    public class ContaineranalysisGoogleDevtoolsCloudbuildV1BuiltImage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Docker Registry 2.0 digest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("digest")]
        public virtual string Digest { get; set; }

        /// <summary>
        /// Name used to push the container image to Google Container Registry, as presented to `docker push`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Stores timing information for pushing the specified image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pushTiming")]
        public virtual ContaineranalysisGoogleDevtoolsCloudbuildV1TimeSpan PushTiming { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Container message for hashes of byte content of files, used in SourceProvenance messages to verify integrity of
    /// source input to the build.
    /// </summary>
    public class ContaineranalysisGoogleDevtoolsCloudbuildV1FileHashes : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Collection of file hashes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileHash")]
        public virtual System.Collections.Generic.IList<ContaineranalysisGoogleDevtoolsCloudbuildV1Hash> FileHash { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Container message for hash values.</summary>
    public class ContaineranalysisGoogleDevtoolsCloudbuildV1Hash : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of hash that was performed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The hash value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Pairs a set of secret environment variables mapped to encrypted values with the Cloud KMS key to use to decrypt
    /// the value.
    /// </summary>
    public class ContaineranalysisGoogleDevtoolsCloudbuildV1InlineSecret : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Map of environment variable name to its encrypted value. Secret environment variables must be unique across
        /// all of a build's secrets, and must be used by at least one build step. Values can be at most 64 KB in size.
        /// There can be at most 100 secret values across all of a build's secrets.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("envMap")]
        public virtual System.Collections.Generic.IDictionary<string, string> EnvMap { get; set; }

        /// <summary>
        /// Resource name of Cloud KMS crypto key to decrypt the encrypted value. In format:
        /// projects/*/locations/*/keyRings/*/cryptoKeys/*
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeyName")]
        public virtual string KmsKeyName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Location of the source in a Google Cloud Source Repository.</summary>
    public class ContaineranalysisGoogleDevtoolsCloudbuildV1RepoSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Regex matching branches to build. The syntax of the regular expressions accepted is the syntax accepted by
        /// RE2 and described at https://github.com/google/re2/wiki/Syntax
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("branchName")]
        public virtual string BranchName { get; set; }

        /// <summary>Explicit commit SHA to build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commitSha")]
        public virtual string CommitSha { get; set; }

        /// <summary>
        /// Directory, relative to the source root, in which to run the build. This must be a relative path. If a step's
        /// `dir` is specified and is an absolute path, this value is ignored for that step's execution.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dir")]
        public virtual string Dir { get; set; }

        /// <summary>Only trigger a build if the revision regex does NOT match the revision regex.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("invertRegex")]
        public virtual System.Nullable<bool> InvertRegex { get; set; }

        /// <summary>
        /// ID of the project that owns the Cloud Source Repository. If omitted, the project ID requesting the build is
        /// assumed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>Name of the Cloud Source Repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repoName")]
        public virtual string RepoName { get; set; }

        /// <summary>Substitutions to use in a triggered build. Should only be used with RunBuildTrigger</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("substitutions")]
        public virtual System.Collections.Generic.IDictionary<string, string> Substitutions { get; set; }

        /// <summary>
        /// Regex matching tags to build. The syntax of the regular expressions accepted is the syntax accepted by RE2
        /// and described at https://github.com/google/re2/wiki/Syntax
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tagName")]
        public virtual string TagName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Artifacts created by the build pipeline.</summary>
    public class ContaineranalysisGoogleDevtoolsCloudbuildV1Results : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Path to the artifact manifest for non-container artifacts uploaded to Cloud Storage. Only populated when
        /// artifacts are uploaded to Cloud Storage.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("artifactManifest")]
        public virtual string ArtifactManifest { get; set; }

        /// <summary>Time to push all non-container artifacts to Cloud Storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("artifactTiming")]
        public virtual ContaineranalysisGoogleDevtoolsCloudbuildV1TimeSpan ArtifactTiming { get; set; }

        /// <summary>List of build step digests, in the order corresponding to build step indices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildStepImages")]
        public virtual System.Collections.Generic.IList<string> BuildStepImages { get; set; }

        /// <summary>
        /// List of build step outputs, produced by builder images, in the order corresponding to build step indices.
        /// [Cloud Builders](https://cloud.google.com/cloud-build/docs/cloud-builders) can produce this output by
        /// writing to `$BUILDER_OUTPUT/output`. Only the first 4KB of data is stored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildStepOutputs")]
        public virtual System.Collections.Generic.IList<string> BuildStepOutputs { get; set; }

        /// <summary>Container images that were built as a part of the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("images")]
        public virtual System.Collections.Generic.IList<ContaineranalysisGoogleDevtoolsCloudbuildV1BuiltImage> Images { get; set; }

        /// <summary>Maven artifacts uploaded to Artifact Registry at the end of the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mavenArtifacts")]
        public virtual System.Collections.Generic.IList<ContaineranalysisGoogleDevtoolsCloudbuildV1UploadedMavenArtifact> MavenArtifacts { get; set; }

        /// <summary>
        /// Number of non-container artifacts uploaded to Cloud Storage. Only populated when artifacts are uploaded to
        /// Cloud Storage.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numArtifacts")]
        public virtual System.Nullable<long> NumArtifacts { get; set; }

        /// <summary>Python artifacts uploaded to Artifact Registry at the end of the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pythonPackages")]
        public virtual System.Collections.Generic.IList<ContaineranalysisGoogleDevtoolsCloudbuildV1UploadedPythonPackage> PythonPackages { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Pairs a set of secret environment variables containing encrypted values with the Cloud KMS key to use to decrypt
    /// the value. Note: Use `kmsKeyName` with `available_secrets` instead of using `kmsKeyName` with `secret`. For
    /// instructions see: https://cloud.google.com/cloud-build/docs/securing-builds/use-encrypted-credentials.
    /// </summary>
    public class ContaineranalysisGoogleDevtoolsCloudbuildV1Secret : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Cloud KMS key name to use to decrypt these envs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeyName")]
        public virtual string KmsKeyName { get; set; }

        /// <summary>
        /// Map of environment variable name to its encrypted value. Secret environment variables must be unique across
        /// all of a build's secrets, and must be used by at least one build step. Values can be at most 64 KB in size.
        /// There can be at most 100 secret values across all of a build's secrets.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secretEnv")]
        public virtual System.Collections.Generic.IDictionary<string, string> SecretEnv { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Pairs a secret environment variable with a SecretVersion in Secret Manager.</summary>
    public class ContaineranalysisGoogleDevtoolsCloudbuildV1SecretManagerSecret : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Environment variable name to associate with the secret. Secret environment variables must be unique across
        /// all of a build's secrets, and must be used by at least one build step.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("env")]
        public virtual string Env { get; set; }

        /// <summary>Resource name of the SecretVersion. In format: projects/*/secrets/*/versions/*</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionName")]
        public virtual string VersionName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Secrets and secret environment variables.</summary>
    public class ContaineranalysisGoogleDevtoolsCloudbuildV1Secrets : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Secrets encrypted with KMS key and the associated secret environment variable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inline")]
        public virtual System.Collections.Generic.IList<ContaineranalysisGoogleDevtoolsCloudbuildV1InlineSecret> Inline { get; set; }

        /// <summary>Secrets in Secret Manager and associated secret environment variable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secretManager")]
        public virtual System.Collections.Generic.IList<ContaineranalysisGoogleDevtoolsCloudbuildV1SecretManagerSecret> SecretManager { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Location of the source in a supported storage service.</summary>
    public class ContaineranalysisGoogleDevtoolsCloudbuildV1Source : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If provided, get the source from this location in a Cloud Source Repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repoSource")]
        public virtual ContaineranalysisGoogleDevtoolsCloudbuildV1RepoSource RepoSource { get; set; }

        /// <summary>If provided, get the source from this location in Google Cloud Storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageSource")]
        public virtual ContaineranalysisGoogleDevtoolsCloudbuildV1StorageSource StorageSource { get; set; }

        /// <summary>
        /// If provided, get the source from this manifest in Google Cloud Storage. This feature is in Preview; see
        /// description [here](https://github.com/GoogleCloudPlatform/cloud-builders/tree/master/gcs-fetcher).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageSourceManifest")]
        public virtual ContaineranalysisGoogleDevtoolsCloudbuildV1StorageSourceManifest StorageSourceManifest { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Provenance of the source. Ways to find the original source, or verify that some source was used for this build.
    /// </summary>
    public class ContaineranalysisGoogleDevtoolsCloudbuildV1SourceProvenance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Hash(es) of the build source, which can be used to verify that the original source integrity
        /// was maintained in the build. Note that `FileHashes` will only be populated if `BuildOptions` has requested a
        /// `SourceProvenanceHash`. The keys to this map are file paths used as build source and the values contain the
        /// hash values for those files. If the build source came in a single package such as a gzipped tarfile
        /// (`.tar.gz`), the `FileHash` will be for the single path to that file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileHashes")]
        public virtual System.Collections.Generic.IDictionary<string, ContaineranalysisGoogleDevtoolsCloudbuildV1FileHashes> FileHashes { get; set; }

        /// <summary>A copy of the build's `source.repo_source`, if exists, with any revisions resolved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resolvedRepoSource")]
        public virtual ContaineranalysisGoogleDevtoolsCloudbuildV1RepoSource ResolvedRepoSource { get; set; }

        /// <summary>A copy of the build's `source.storage_source`, if exists, with any generations resolved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resolvedStorageSource")]
        public virtual ContaineranalysisGoogleDevtoolsCloudbuildV1StorageSource ResolvedStorageSource { get; set; }

        /// <summary>
        /// A copy of the build's `source.storage_source_manifest`, if exists, with any revisions resolved. This feature
        /// is in Preview.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resolvedStorageSourceManifest")]
        public virtual ContaineranalysisGoogleDevtoolsCloudbuildV1StorageSourceManifest ResolvedStorageSourceManifest { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Location of the source in an archive file in Google Cloud Storage.</summary>
    public class ContaineranalysisGoogleDevtoolsCloudbuildV1StorageSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Google Cloud Storage bucket containing the source (see [Bucket Name
        /// Requirements](https://cloud.google.com/storage/docs/bucket-naming#requirements)).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucket")]
        public virtual string Bucket { get; set; }

        /// <summary>
        /// Google Cloud Storage generation for the object. If the generation is omitted, the latest generation will be
        /// used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generation")]
        public virtual System.Nullable<long> Generation { get; set; }

        /// <summary>
        /// Google Cloud Storage object containing the source. This object must be a zipped (`.zip`) or gzipped archive
        /// file (`.tar.gz`) containing source to build.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("object")]
        public virtual string Object__ { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Location of the source manifest in Google Cloud Storage. This feature is in Preview; see description
    /// [here](https://github.com/GoogleCloudPlatform/cloud-builders/tree/master/gcs-fetcher).
    /// </summary>
    public class ContaineranalysisGoogleDevtoolsCloudbuildV1StorageSourceManifest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Google Cloud Storage bucket containing the source manifest (see [Bucket Name
        /// Requirements](https://cloud.google.com/storage/docs/bucket-naming#requirements)).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucket")]
        public virtual string Bucket { get; set; }

        /// <summary>
        /// Google Cloud Storage generation for the object. If the generation is omitted, the latest generation will be
        /// used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generation")]
        public virtual System.Nullable<long> Generation { get; set; }

        /// <summary>
        /// Google Cloud Storage object containing the source manifest. This object must be a JSON file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("object")]
        public virtual string Object__ { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Start and end times for a build execution phase.</summary>
    public class ContaineranalysisGoogleDevtoolsCloudbuildV1TimeSpan : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>End of time span.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>Start of time span.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Maven artifact uploaded using the MavenArtifact directive.</summary>
    public class ContaineranalysisGoogleDevtoolsCloudbuildV1UploadedMavenArtifact : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Hash types and values of the Maven Artifact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileHashes")]
        public virtual ContaineranalysisGoogleDevtoolsCloudbuildV1FileHashes FileHashes { get; set; }

        /// <summary>Output only. Stores timing information for pushing the specified artifact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pushTiming")]
        public virtual ContaineranalysisGoogleDevtoolsCloudbuildV1TimeSpan PushTiming { get; set; }

        /// <summary>URI of the uploaded artifact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Artifact uploaded using the PythonPackage directive.</summary>
    public class ContaineranalysisGoogleDevtoolsCloudbuildV1UploadedPythonPackage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Hash types and values of the Python Artifact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileHashes")]
        public virtual ContaineranalysisGoogleDevtoolsCloudbuildV1FileHashes FileHashes { get; set; }

        /// <summary>Output only. Stores timing information for pushing the specified artifact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pushTiming")]
        public virtual ContaineranalysisGoogleDevtoolsCloudbuildV1TimeSpan PushTiming { get; set; }

        /// <summary>URI of the uploaded artifact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Volume describes a Docker container volume which is mounted into build steps in order to persist files across
    /// build step execution.
    /// </summary>
    public class ContaineranalysisGoogleDevtoolsCloudbuildV1Volume : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Name of the volume to mount. Volume names must be unique per build step and must be valid names for Docker
        /// volumes. Each named volume must be used by at least two build steps.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Path at which to mount the volume. Paths must be absolute and cannot conflict with other volume paths on the
        /// same build step or with certain reserved volume paths.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An artifact that can be deployed in some runtime.</summary>
    public class Deployable : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Resource URI for the artifact being deployed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceUri")]
        public virtual System.Collections.Generic.IList<string> ResourceUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The period during which some deployable was active in a runtime.</summary>
    public class Deployment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Address of the runtime element hosting this deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("address")]
        public virtual string Address { get; set; }

        /// <summary>Configuration used to create this deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual string Config { get; set; }

        /// <summary>Required. Beginning of the lifetime of this deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deployTime")]
        public virtual object DeployTime { get; set; }

        /// <summary>Platform hosting this deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("platform")]
        public virtual string Platform { get; set; }

        /// <summary>
        /// Output only. Resource URI for the artifact being deployed taken from the deployable field with the same
        /// name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceUri")]
        public virtual System.Collections.Generic.IList<string> ResourceUri { get; set; }

        /// <summary>End of the lifetime of this deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("undeployTime")]
        public virtual object UndeployTime { get; set; }

        /// <summary>Identity of the user that triggered this deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userEmail")]
        public virtual string UserEmail { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Derived describes the derived image portion (Occurrence) of the DockerImage relationship. This image would be
    /// produced from a Dockerfile with FROM .
    /// </summary>
    public class Derived : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. This contains the base image URL for the derived image occurrence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseResourceUrl")]
        public virtual string BaseResourceUrl { get; set; }

        /// <summary>
        /// Output only. The number of layers by which this image differs from the associated image basis.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("distance")]
        public virtual System.Nullable<int> Distance { get; set; }

        /// <summary>Required. The fingerprint of the derived image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fingerprint")]
        public virtual Fingerprint Fingerprint { get; set; }

        /// <summary>
        /// This contains layer-specific metadata, if populated it has length "distance" and is ordered with [distance]
        /// being the layer immediately following the base image and [1] being the final layer.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layerInfo")]
        public virtual System.Collections.Generic.IList<Layer> LayerInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Identifies all appearances of this vulnerability in the package for a specific distro/location. For example:
    /// glibc in cpe:/o:debian:debian_linux:8 for versions 2.1 - 2.2
    /// </summary>
    public class Detail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The CPE URI in [cpe format](https://cpe.mitre.org/specification/) in which the vulnerability
        /// manifests. Examples include distro or storage location for vulnerable jar.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpeUri")]
        public virtual string CpeUri { get; set; }

        /// <summary>A vendor-specific description of this note.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The fix for this specific package version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fixedLocation")]
        public virtual VulnerabilityLocation FixedLocation { get; set; }

        /// <summary>
        /// Whether this detail is obsolete. Occurrences are expected not to point to obsolete details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isObsolete")]
        public virtual System.Nullable<bool> IsObsolete { get; set; }

        /// <summary>The max version of the package in which the vulnerability exists.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxAffectedVersion")]
        public virtual Version MaxAffectedVersion { get; set; }

        /// <summary>The min version of the package in which the vulnerability exists.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minAffectedVersion")]
        public virtual Version MinAffectedVersion { get; set; }

        /// <summary>Required. The name of the package where the vulnerability was found.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("package")]
        public virtual string Package { get; set; }

        /// <summary>The type of package; whether native or non native(ruby gems, node.js packages etc).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageType")]
        public virtual string PackageType { get; set; }

        /// <summary>The severity (eg: distro assigned severity) for this vulnerability.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severityName")]
        public virtual string SeverityName { get; set; }

        /// <summary>The source from which the information in this Detail was obtained.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual string Source { get; set; }

        /// <summary>
        /// The time this information was last changed at the source. This is an upstream timestamp from the underlying
        /// information source - e.g. Ubuntu security tracker.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceUpdateTime")]
        public virtual object SourceUpdateTime { get; set; }

        /// <summary>The name of the vendor of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vendor")]
        public virtual string Vendor { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of an attestation occurrence.</summary>
    public class Details : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Attestation for the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attestation")]
        public virtual Attestation Attestation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Digest information.</summary>
    public class Digest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>`SHA1`, `SHA512` etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("algo")]
        public virtual string Algo { get; set; }

        /// <summary>Value of the digest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("digestBytes")]
        public virtual string DigestBytes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Provides information about the analysis status of a discovered resource.</summary>
    public class Discovered : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("analysisCompleted")]
        public virtual AnalysisCompleted AnalysisCompleted { get; set; }

        /// <summary>
        /// Indicates any errors encountered during analysis of a resource. There could be 0 or more of these errors.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("analysisError")]
        public virtual System.Collections.Generic.IList<Status> AnalysisError { get; set; }

        /// <summary>The status of discovery for the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("analysisStatus")]
        public virtual string AnalysisStatus { get; set; }

        /// <summary>
        /// When an error is encountered this will contain a LocalizedMessage under details to show to the user. The
        /// LocalizedMessage is output only and populated by the API.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("analysisStatusError")]
        public virtual Status AnalysisStatusError { get; set; }

        /// <summary>Whether the resource is continuously analyzed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("continuousAnalysis")]
        public virtual string ContinuousAnalysis { get; set; }

        /// <summary>The last time continuous analysis was done for this resource. Deprecated, do not use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastAnalysisTime")]
        public virtual object LastAnalysisTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A note that indicates a type of analysis a provider would perform. This note exists in a provider's project. A
    /// `Discovery` occurrence is created in a consumer's project at the start of analysis.
    /// </summary>
    public class Discovery : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Immutable. The kind of analysis that is handled by this discovery.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("analysisKind")]
        public virtual string AnalysisKind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// This represents a particular channel of distribution for a given package. E.g., Debian's jessie-backports dpkg
    /// mirror.
    /// </summary>
    public class Distribution : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The CPU architecture for which packages in this distribution channel were built.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("architecture")]
        public virtual string Architecture { get; set; }

        /// <summary>
        /// Required. The cpe_uri in [CPE format](https://cpe.mitre.org/specification/) denoting the package manager
        /// version distributing a package.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpeUri")]
        public virtual string CpeUri { get; set; }

        /// <summary>The distribution channel-specific description of this package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The latest available version of this package in this distribution channel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latestVersion")]
        public virtual Version LatestVersion { get; set; }

        /// <summary>A freeform string denoting the maintainer of this package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maintainer")]
        public virtual string Maintainer { get; set; }

        /// <summary>The distribution channel-specific homepage for this package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// DocumentNote represents an SPDX Document Creation Information section:
    /// https://spdx.github.io/spdx-spec/2-document-creation-information/
    /// </summary>
    public class DocumentNote : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Compliance with the SPDX specification includes populating the SPDX fields therein with data related to such
        /// fields ("SPDX-Metadata")
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataLicence")]
        public virtual string DataLicence { get; set; }

        /// <summary>
        /// Provide a reference number that can be used to understand how to parse and interpret the rest of the file
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spdxVersion")]
        public virtual string SpdxVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// DocumentOccurrence represents an SPDX Document Creation Information section:
    /// https://spdx.github.io/spdx-spec/2-document-creation-information/
    /// </summary>
    public class DocumentOccurrence : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Identify when the SPDX file was originally created. The date is to be specified according to combined date
        /// and time in UTC format as specified in ISO 8601 standard
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// A field for creators of the SPDX file to provide general comments about the creation of the SPDX file or any
        /// other relevant comment not included in the other fields
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creatorComment")]
        public virtual string CreatorComment { get; set; }

        /// <summary>
        /// Identify who (or what, in the case of a tool) created the SPDX file. If the SPDX file was created by an
        /// individual, indicate the person's name
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creators")]
        public virtual System.Collections.Generic.IList<string> Creators { get; set; }

        /// <summary>
        /// A field for creators of the SPDX file content to provide comments to the consumers of the SPDX document
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentComment")]
        public virtual string DocumentComment { get; set; }

        /// <summary>Identify any external SPDX documents referenced within this SPDX document</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalDocumentRefs")]
        public virtual System.Collections.Generic.IList<string> ExternalDocumentRefs { get; set; }

        /// <summary>
        /// Identify the current SPDX document which may be referenced in relationships by other files, packages
        /// internally and documents externally
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// A field for creators of the SPDX file to provide the version of the SPDX License List used when the SPDX
        /// file was created
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("licenseListVersion")]
        public virtual string LicenseListVersion { get; set; }

        /// <summary>
        /// Provide an SPDX document specific namespace as a unique absolute Uniform Resource Identifier (URI) as
        /// specified in RFC-3986, with the exception of the ‘#’ delimiter
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namespace")]
        public virtual string Namespace__ { get; set; }

        /// <summary>Identify name of this document as designated by creator</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

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
    /// MUST match https://github.com/secure-systems-lab/dsse/blob/master/envelope.proto. An authenticated message of
    /// arbitrary type.
    /// </summary>
    public class Envelope : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("payload")]
        public virtual string Payload { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("payloadType")]
        public virtual string PayloadType { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("signatures")]
        public virtual System.Collections.Generic.IList<EnvelopeSignature> Signatures { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnvelopeSignature : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("keyid")]
        public virtual string Keyid { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("sig")]
        public virtual string Sig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Defines an object for the environment field in in-toto links. The suggested fields are "variables",
    /// "filesystem", and "workdir".
    /// </summary>
    public class Environment : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("customValues")]
        public virtual System.Collections.Generic.IDictionary<string, string> CustomValues { get; set; }

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
    /// An External Reference allows a Package to reference an external source of additional information, metadata,
    /// enumerations, asset identifiers, or downloadable content believed to be relevant to the Package
    /// </summary>
    public class ExternalRef : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An External Reference allows a Package to reference an external source of additional information, metadata,
        /// enumerations, asset identifiers, or downloadable content believed to be relevant to the Package
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual string Category { get; set; }

        /// <summary>Human-readable information about the purpose and target of the reference</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("comment")]
        public virtual string Comment { get; set; }

        /// <summary>
        /// The unique string with no spaces necessary to access the package-specific information, metadata, or content
        /// within the target location
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locator")]
        public virtual string Locator { get; set; }

        /// <summary>Type of category (e.g. 'npm' for the PACKAGE_MANAGER category)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Container message for hashes of byte content of files, used in source messages to verify integrity of source
    /// input to the build.
    /// </summary>
    public class FileHashes : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Collection of file hashes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileHash")]
        public virtual System.Collections.Generic.IList<Hash> FileHash { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// FileNote represents an SPDX File Information section: https://spdx.github.io/spdx-spec/4-file-information/
    /// </summary>
    public class FileNote : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Provide a unique identifier to match analysis information on each specific file in a package
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("checksum")]
        public virtual System.Collections.Generic.IList<string> Checksum { get; set; }

        /// <summary>This field provides information about the type of file identified</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileType")]
        public virtual string FileType { get; set; }

        /// <summary>
        /// Identify the full path and filename that corresponds to the file information in this section
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// FileOccurrence represents an SPDX File Information section: https://spdx.github.io/spdx-spec/4-file-information/
    /// </summary>
    public class FileOccurrence : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// This field provides a place for the SPDX data creator to record, at the file level, acknowledgements that
        /// may be needed to be communicated in some contexts
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributions")]
        public virtual System.Collections.Generic.IList<string> Attributions { get; set; }

        /// <summary>
        /// This field provides a place for the SPDX file creator to record any general comments about the file
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("comment")]
        public virtual string Comment { get; set; }

        /// <summary>This field provides a place for the SPDX file creator to record file contributors</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contributors")]
        public virtual System.Collections.Generic.IList<string> Contributors { get; set; }

        /// <summary>Identify the copyright holder of the file, as well as any dates present</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("copyright")]
        public virtual string Copyright { get; set; }

        /// <summary>This field contains the license information actually found in the file, if any</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filesLicenseInfo")]
        public virtual System.Collections.Generic.IList<string> FilesLicenseInfo { get; set; }

        /// <summary>
        /// Uniquely identify any element in an SPDX document which may be referenced by other elements
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// This field contains the license the SPDX file creator has concluded as governing the file or alternative
        /// values if the governing license cannot be determined
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("licenseConcluded")]
        public virtual License LicenseConcluded { get; set; }

        /// <summary>
        /// This field provides a place for the SPDX file creator to record license notices or other such related
        /// notices found in the file
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notice")]
        public virtual string Notice { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A set of properties that uniquely identify a given Docker image.</summary>
    public class Fingerprint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The layer ID of the final layer in the Docker image's v1 representation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("v1Name")]
        public virtual string V1Name { get; set; }

        /// <summary>Required. The ordered list of v2 blobs that represent a given image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("v2Blob")]
        public virtual System.Collections.Generic.IList<string> V2Blob { get; set; }

        /// <summary>
        /// Output only. The name of the image's v2 blobs computed via: [bottom] := v2_blobbottom := sha256(v2_blob[N] +
        /// " " + v2_name[N+1]) Only the name of the final blob is kept.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("v2Name")]
        public virtual string V2Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Per resource and severity counts of fixable and total vulnerabilities.</summary>
    public class FixableTotalByDigest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of fixable vulnerabilities associated with this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fixableCount")]
        public virtual System.Nullable<long> FixableCount { get; set; }

        /// <summary>The affected resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual Resource Resource { get; set; }

        /// <summary>The severity for this count. SEVERITY_UNSPECIFIED indicates total across all severities.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>The total number of vulnerabilities associated with this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalCount")]
        public virtual System.Nullable<long> TotalCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An attestation wrapper that uses the Grafeas `Signature` message. This attestation must define the
    /// `serialized_payload` that the `signatures` verify and any metadata necessary to interpret that plaintext. The
    /// signatures should always be over the `serialized_payload` bytestring.
    /// </summary>
    public class GenericSignedAttestation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Type (for example schema) of the attestation payload that was signed. The verifier must ensure that the
        /// provided type is one that the verifier supports, and that the attestation payload is a valid instantiation
        /// of that type (for example by validating a JSON schema).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentType")]
        public virtual string ContentType { get; set; }

        /// <summary>
        /// The serialized payload that is verified by one or more `signatures`. The encoding and semantic meaning of
        /// this payload must match what is set in `content_type`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serializedPayload")]
        public virtual string SerializedPayload { get; set; }

        /// <summary>
        /// One or more signatures over `serialized_payload`. Verifier implementations should consider this attestation
        /// message verified if at least one `signature` verifies `serialized_payload`. See `Signature` in common.proto
        /// for more details on signature structure and verification.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signatures")]
        public virtual System.Collections.Generic.IList<Signature> Signatures { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A SourceContext referring to a Gerrit project.</summary>
    public class GerritSourceContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An alias, which may be a branch or tag.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aliasContext")]
        public virtual AliasContext AliasContext { get; set; }

        /// <summary>
        /// The full project name within the host. Projects may be nested, so "project/subproject" is a valid project
        /// name. The "repo name" is the hostURI/project.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gerritProject")]
        public virtual string GerritProject { get; set; }

        /// <summary>The URI of a running Gerrit instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostUri")]
        public virtual string HostUri { get; set; }

        /// <summary>A revision (commit) ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionId")]
        public virtual string RevisionId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for `GetIamPolicy` method.</summary>
    public class GetIamPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>OPTIONAL: A `GetPolicyOptions` object for specifying options to `GetIamPolicy`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("options")]
        public virtual GetPolicyOptions Options { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Encapsulates settings provided to GetIamPolicy.</summary>
    public class GetPolicyOptions : Google.Apis.Requests.IDirectResponseSchema
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
    /// A GitSourceContext denotes a particular revision in a third party Git repository (e.g., GitHub).
    /// </summary>
    public class GitSourceContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Git commit hash.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionId")]
        public virtual string RevisionId { get; set; }

        /// <summary>Git repository URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata for all operations used and required for all operations that created by Container Analysis Providers
    /// </summary>
    public class GoogleDevtoolsContaineranalysisV1alpha1OperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The time this operation was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. The time that this operation was marked completed or failed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of a build occurrence.</summary>
    public class GrafeasV1beta1BuildDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The actual provenance for the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provenance")]
        public virtual BuildProvenance Provenance { get; set; }

        /// <summary>
        /// Serialized JSON representation of the provenance, used in generating the build signature in the
        /// corresponding build note. After verifying the signature, `provenance_bytes` can be unmarshalled and compared
        /// to the provenance to confirm that it is unchanged. A base64-encoded string representation of the provenance
        /// bytes is used for the signature in order to interoperate with openssl which expects this format for
        /// signature verification. The serialized form is captured both to avoid ambiguity in how the provenance is
        /// marshalled to json as well to prevent incompatibilities with future changes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provenanceBytes")]
        public virtual string ProvenanceBytes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of a deployment occurrence.</summary>
    public class GrafeasV1beta1DeploymentDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Deployment history for the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deployment")]
        public virtual Deployment Deployment { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of a discovery occurrence.</summary>
    public class GrafeasV1beta1DiscoveryDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Analysis status for the discovered resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("discovered")]
        public virtual Discovered Discovered { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of an image occurrence.</summary>
    public class GrafeasV1beta1ImageDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Immutable. The child image derived from the base image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("derivedImage")]
        public virtual Derived DerivedImage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GrafeasV1beta1IntotoArtifact : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("hashes")]
        public virtual ArtifactHashes Hashes { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("resourceUri")]
        public virtual string ResourceUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// This corresponds to a signed in-toto link - it is made up of one or more signatures and the in-toto link itself.
    /// This is used for occurrences of a Grafeas in-toto note.
    /// </summary>
    public class GrafeasV1beta1IntotoDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("signatures")]
        public virtual System.Collections.Generic.IList<GrafeasV1beta1IntotoSignature> Signatures { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("signed")]
        public virtual Link Signed { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A signature object consists of the KeyID used and the signature itself.</summary>
    public class GrafeasV1beta1IntotoSignature : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("keyid")]
        public virtual string Keyid { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("sig")]
        public virtual string Sig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of a package occurrence.</summary>
    public class GrafeasV1beta1PackageDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Where the package was installed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("installation")]
        public virtual Installation Installation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of a vulnerability Occurrence.</summary>
    public class GrafeasV1beta1VulnerabilityDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The CVSS score of this vulnerability. CVSS score is on a scale of 0-10 where 0 indicates low
        /// severity and 10 indicates high severity.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cvssScore")]
        public virtual System.Nullable<float> CvssScore { get; set; }

        /// <summary>Output only. CVSS version used to populate cvss_score and severity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cvssVersion")]
        public virtual string CvssVersion { get; set; }

        /// <summary>
        /// The distro assigned severity for this vulnerability when it is available, and note provider assigned
        /// severity when distro has not yet assigned a severity for this vulnerability. When there are multiple
        /// PackageIssues for this vulnerability, they can have different effective severities because some might be
        /// provided by the distro while others are provided by the language ecosystem for a language pack. For this
        /// reason, it is advised to use the effective severity on the PackageIssue level. In the case where multiple
        /// PackageIssues have differing effective severities, this field should be the highest severity for any of the
        /// PackageIssues.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("effectiveSeverity")]
        public virtual string EffectiveSeverity { get; set; }

        /// <summary>Output only. A detailed description of this vulnerability.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("longDescription")]
        public virtual string LongDescription { get; set; }

        /// <summary>
        /// Required. The set of affected locations and their fixes (if available) within the associated resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageIssue")]
        public virtual System.Collections.Generic.IList<PackageIssue> PackageIssue { get; set; }

        /// <summary>Output only. URLs related to this vulnerability.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relatedUrls")]
        public virtual System.Collections.Generic.IList<RelatedUrl> RelatedUrls { get; set; }

        /// <summary>Output only. The note provider assigned Severity of the vulnerability.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>Output only. A one sentence description of this vulnerability.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shortDescription")]
        public virtual string ShortDescription { get; set; }

        /// <summary>The type of package; whether native or non native(ruby gems, node.js packages etc)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Container message for hash values.</summary>
    public class Hash : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The type of hash that was performed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>Required. The hash value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// This submessage provides human-readable hints about the purpose of the authority. Because the name of a note
    /// acts as its resource reference, it is important to disambiguate the canonical name of the Note (which might be a
    /// UUID for security purposes) from "readable" names more suitable for debug output. Note that these hints should
    /// not be used to look up authorities in security sensitive contexts, such as when looking up attestations to
    /// verify.
    /// </summary>
    public class Hint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The human readable name of this attestation authority, for example "qa".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("humanReadableName")]
        public virtual string HumanReadableName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// This contains the fields corresponding to the definition of a software supply chain step in an in-toto layout.
    /// This information goes into a Grafeas note.
    /// </summary>
    public class InToto : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>This field contains the expected command used to perform the step.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expectedCommand")]
        public virtual System.Collections.Generic.IList<string> ExpectedCommand { get; set; }

        /// <summary>
        /// The following fields contain in-toto artifact rules identifying the artifacts that enter this supply chain
        /// step, and exit the supply chain step, i.e. materials and products of the step.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expectedMaterials")]
        public virtual System.Collections.Generic.IList<ArtifactRule> ExpectedMaterials { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("expectedProducts")]
        public virtual System.Collections.Generic.IList<ArtifactRule> ExpectedProducts { get; set; }

        /// <summary>
        /// This field contains the public keys that can be used to verify the signatures on the step metadata.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signingKeys")]
        public virtual System.Collections.Generic.IList<SigningKey> SigningKeys { get; set; }

        /// <summary>This field identifies the name of the step in the supply chain.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stepName")]
        public virtual string StepName { get; set; }

        /// <summary>
        /// This field contains a value that indicates the minimum number of keys that need to be used to sign the
        /// step's in-toto link.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threshold")]
        public virtual System.Nullable<long> Threshold { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This represents how a particular software package may be installed on a system.</summary>
    public class Installation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The CPU architecture for which packages in this distribution channel were built. Architecture
        /// will be blank for language packages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("architecture")]
        public virtual string Architecture { get; set; }

        /// <summary>
        /// Output only. The cpe_uri in [CPE format](https://cpe.mitre.org/specification/) denoting the package manager
        /// version distributing a package. The cpe_uri will be blank for language packages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpeUri")]
        public virtual string CpeUri { get; set; }

        /// <summary>Licenses that have been declared by the authors of the package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("license")]
        public virtual License License { get; set; }

        /// <summary>All of the places within the filesystem versions of this package have been found.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual System.Collections.Generic.IList<Location> Location { get; set; }

        /// <summary>Required. Output only. The name of the installed package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The type of package; whether native or non native (e.g., ruby gems, node.js packages, etc.).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageType")]
        public virtual string PackageType { get; set; }

        /// <summary>Output only. The version of the package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual Version Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class KnowledgeBase : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The KB name (generally of the form KB[0-9]+ i.e. KB123456).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// A link to the KB in the Windows update catalog - https://www.catalog.update.microsoft.com/
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Layer holds metadata specific to a layer of a Docker image.</summary>
    public class Layer : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The recovered arguments to the Dockerfile directive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("arguments")]
        public virtual string Arguments { get; set; }

        /// <summary>Required. The recovered Dockerfile directive used to construct this layer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("directive")]
        public virtual string Directive { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>License information.</summary>
    public class License : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Comments</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("comments")]
        public virtual string Comments { get; set; }

        /// <summary>
        /// Often a single license can be used to represent the licensing terms. Sometimes it is necessary to include a
        /// choice of one or more licenses or some combination of license identifiers. Examples: "LGPL-2.1-only OR MIT",
        /// "LGPL-2.1-only AND MIT", "GPL-2.0-or-later WITH Bison-exception-2.2".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expression")]
        public virtual string Expression { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This corresponds to an in-toto link.</summary>
    public class Link : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// ByProducts are data generated as part of a software supply chain step, but are not the actual result of the
        /// step.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("byproducts")]
        public virtual ByProducts Byproducts { get; set; }

        /// <summary>
        /// This field contains the full command executed for the step. This can also be empty if links are generated
        /// for operations that aren't directly mapped to a specific command. Each term in the command is an independent
        /// string in the list. An example of a command in the in-toto metadata field is: "command": ["git", "clone",
        /// "https://github.com/in-toto/demo-project.git"]
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("command")]
        public virtual System.Collections.Generic.IList<string> Command { get; set; }

        /// <summary>
        /// This is a field that can be used to capture information about the environment. It is suggested for this
        /// field to contain information that details environment variables, filesystem information, and the present
        /// working directory. The recommended structure of this field is: "environment": { "custom_values": {
        /// "variables": "", "filesystem": "", "workdir": "", "": "..." } }
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("environment")]
        public virtual Environment Environment { get; set; }

        /// <summary>
        /// Materials are the supply chain artifacts that go into the step and are used for the operation performed. The
        /// key of the map is the path of the artifact and the structure contains the recorded hash information. An
        /// example is: "materials": [ { "resource_uri": "foo/bar", "hashes": { "sha256": "ebebf...", : } } ]
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("materials")]
        public virtual System.Collections.Generic.IList<GrafeasV1beta1IntotoArtifact> Materials { get; set; }

        /// <summary>
        /// Products are the supply chain artifacts generated as a result of the step. The structure is identical to
        /// that of materials.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("products")]
        public virtual System.Collections.Generic.IList<GrafeasV1beta1IntotoArtifact> Products { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for listing occurrences for a note.</summary>
    public class ListNoteOccurrencesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Token to provide to skip to a particular spot in the list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The occurrences attached to the specified note.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("occurrences")]
        public virtual System.Collections.Generic.IList<Occurrence> Occurrences { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for listing notes.</summary>
    public class ListNotesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The next pagination token in the list response. It should be used as `page_token` for the following request.
        /// An empty value means no more results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The notes requested.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notes")]
        public virtual System.Collections.Generic.IList<Note> Notes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for listing occurrences.</summary>
    public class ListOccurrencesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The next pagination token in the list response. It should be used as `page_token` for the following request.
        /// An empty value means no more results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The occurrences requested.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("occurrences")]
        public virtual System.Collections.Generic.IList<Occurrence> Occurrences { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An occurrence of a particular package installation found within a system's filesystem. E.g., glibc was found in
    /// `/var/lib/dpkg/status`.
    /// </summary>
    public class Location : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Deprecated. The CPE URI in [CPE format](https://cpe.mitre.org/specification/) denoting the package manager
        /// version distributing a package.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpeUri")]
        public virtual string CpeUri { get; set; }

        /// <summary>The path from which we gathered that this package/version is installed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>Deprecated. The version installed at this location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual Version Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A type of analysis that can be done for a resource.</summary>
    public class Note : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A note describing an attestation role.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attestationAuthority")]
        public virtual Authority AttestationAuthority { get; set; }

        /// <summary>A note describing a base image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseImage")]
        public virtual Basis BaseImage { get; set; }

        /// <summary>A note describing build provenance for a verifiable build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("build")]
        public virtual Build Build { get; set; }

        /// <summary>
        /// Output only. The time this note was created. This field can be used as a filter in list requests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>A note describing something that can be deployed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deployable")]
        public virtual Deployable Deployable { get; set; }

        /// <summary>A note describing the initial analysis of a resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("discovery")]
        public virtual Discovery Discovery { get; set; }

        /// <summary>Time of expiration for this note. Empty if note does not expire.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expirationTime")]
        public virtual object ExpirationTime { get; set; }

        /// <summary>A note describing an in-toto link.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intoto")]
        public virtual InToto Intoto { get; set; }

        /// <summary>Output only. The type of analysis. This field can be used as a filter in list requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>A detailed description of this note.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("longDescription")]
        public virtual string LongDescription { get; set; }

        /// <summary>
        /// Output only. The name of the note in the form of `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>A note describing a package hosted by various package managers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("package")]
        public virtual Package Package { get; set; }

        /// <summary>Other notes related to this note.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relatedNoteNames")]
        public virtual System.Collections.Generic.IList<string> RelatedNoteNames { get; set; }

        /// <summary>URLs associated with this note.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relatedUrl")]
        public virtual System.Collections.Generic.IList<RelatedUrl> RelatedUrl { get; set; }

        /// <summary>A note describing a software bill of materials.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sbom")]
        public virtual DocumentNote Sbom { get; set; }

        /// <summary>A one sentence description of this note.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shortDescription")]
        public virtual string ShortDescription { get; set; }

        /// <summary>A note describing an SPDX File.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spdxFile")]
        public virtual FileNote SpdxFile { get; set; }

        /// <summary>A note describing an SPDX Package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spdxPackage")]
        public virtual PackageInfoNote SpdxPackage { get; set; }

        /// <summary>A note describing an SPDX File.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spdxRelationship")]
        public virtual RelationshipNote SpdxRelationship { get; set; }

        /// <summary>
        /// Output only. The time this note was last updated. This field can be used as a filter in list requests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>A note describing a package vulnerability.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vulnerability")]
        public virtual Vulnerability Vulnerability { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An instance of an analysis type that has been found on a resource.</summary>
    public class Occurrence : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Describes an attestation of an artifact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attestation")]
        public virtual Details Attestation { get; set; }

        /// <summary>Describes a verifiable build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("build")]
        public virtual GrafeasV1beta1BuildDetails Build { get; set; }

        /// <summary>Output only. The time this occurrence was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Describes the deployment of an artifact on a runtime.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deployment")]
        public virtual GrafeasV1beta1DeploymentDetails Deployment { get; set; }

        /// <summary>Describes how this resource derives from the basis in the associated note.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("derivedImage")]
        public virtual GrafeasV1beta1ImageDetails DerivedImage { get; set; }

        /// <summary>Describes when a resource was discovered.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("discovered")]
        public virtual GrafeasV1beta1DiscoveryDetails Discovered { get; set; }

        /// <summary>https://github.com/secure-systems-lab/dsse</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("envelope")]
        public virtual Envelope Envelope { get; set; }

        /// <summary>Describes the installation of a package on the linked resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("installation")]
        public virtual GrafeasV1beta1PackageDetails Installation { get; set; }

        /// <summary>Describes a specific in-toto link.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intoto")]
        public virtual GrafeasV1beta1IntotoDetails Intoto { get; set; }

        /// <summary>
        /// Output only. This explicitly denotes which of the occurrence details are specified. This field can be used
        /// as a filter in list requests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Output only. The name of the occurrence in the form of `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. Immutable. The analysis note associated with this occurrence, in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`. This field can be used as a filter in list requests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("noteName")]
        public virtual string NoteName { get; set; }

        /// <summary>A description of actions that can be taken to remedy the note.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("remediation")]
        public virtual string Remediation { get; set; }

        /// <summary>Required. Immutable. The resource for which the occurrence applies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual Resource Resource { get; set; }

        /// <summary>Describes a specific software bill of materials document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sbom")]
        public virtual DocumentOccurrence Sbom { get; set; }

        /// <summary>Describes a specific SPDX File.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spdxFile")]
        public virtual FileOccurrence SpdxFile { get; set; }

        /// <summary>Describes a specific SPDX Package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spdxPackage")]
        public virtual PackageInfoOccurrence SpdxPackage { get; set; }

        /// <summary>Describes a specific SPDX Relationship.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spdxRelationship")]
        public virtual RelationshipOccurrence SpdxRelationship { get; set; }

        /// <summary>Output only. The time this occurrence was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>Describes a security vulnerability.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vulnerability")]
        public virtual GrafeasV1beta1VulnerabilityDetails Vulnerability { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Package represents a particular package version.</summary>
    public class Package : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The CPU architecture for which packages in this distribution channel were built. Architecture will be blank
        /// for language packages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("architecture")]
        public virtual string Architecture { get; set; }

        /// <summary>
        /// The cpe_uri in [CPE format](https://cpe.mitre.org/specification/) denoting the package manager version
        /// distributing a package. The cpe_uri will be blank for language packages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpeUri")]
        public virtual string CpeUri { get; set; }

        /// <summary>The description of this package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Hash value, typically a file digest, that allows unique identification a specific package.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("digest")]
        public virtual System.Collections.Generic.IList<Digest> Digest { get; set; }

        /// <summary>The various channels by which a package is distributed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("distribution")]
        public virtual System.Collections.Generic.IList<Distribution> Distribution { get; set; }

        /// <summary>Licenses that have been declared by the authors of the package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("license")]
        public virtual License License { get; set; }

        /// <summary>A freeform text denoting the maintainer of this package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maintainer")]
        public virtual string Maintainer { get; set; }

        /// <summary>Required. Immutable. The name of the package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The type of package; whether native or non native (e.g., ruby gems, node.js packages, etc.).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageType")]
        public virtual string PackageType { get; set; }

        /// <summary>The homepage for this package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The version of the package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual Version Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// PackageInfoNote represents an SPDX Package Information section:
    /// https://spdx.github.io/spdx-spec/3-package-information/
    /// </summary>
    public class PackageInfoNote : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Indicates whether the file content of this package has been available for or subjected to analysis when
        /// creating the SPDX document
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("analyzed")]
        public virtual System.Nullable<bool> Analyzed { get; set; }

        /// <summary>
        /// A place for the SPDX data creator to record, at the package level, acknowledgements that may be needed to be
        /// communicated in some contexts
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attribution")]
        public virtual string Attribution { get; set; }

        /// <summary>
        /// Provide an independently reproducible mechanism that permits unique identification of a specific package
        /// that correlates to the data in this SPDX file
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("checksum")]
        public virtual string Checksum { get; set; }

        /// <summary>Identify the copyright holders of the package, as well as any dates present</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("copyright")]
        public virtual string Copyright { get; set; }

        /// <summary>A more detailed description of the package</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detailedDescription")]
        public virtual string DetailedDescription { get; set; }

        /// <summary>
        /// This section identifies the download Universal Resource Locator (URL), or a specific location within a
        /// version control system (VCS) for the package at the time that the SPDX file was created
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("downloadLocation")]
        public virtual string DownloadLocation { get; set; }

        /// <summary>ExternalRef</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalRefs")]
        public virtual System.Collections.Generic.IList<ExternalRef> ExternalRefs { get; set; }

        /// <summary>
        /// Contain the license the SPDX file creator has concluded as governing the This field is to contain a list of
        /// all licenses found in the package. The relationship between licenses (i.e., conjunctive, disjunctive) is not
        /// specified in this field – it is simply a listing of all licenses found
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filesLicenseInfo")]
        public virtual System.Collections.Generic.IList<string> FilesLicenseInfo { get; set; }

        /// <summary>
        /// Provide a place for the SPDX file creator to record a web site that serves as the package's home page
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("homePage")]
        public virtual string HomePage { get; set; }

        /// <summary>List the licenses that have been declared by the authors of the package</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("licenseDeclared")]
        public virtual License LicenseDeclared { get; set; }

        /// <summary>
        /// If the package identified in the SPDX file originated from a different person or organization than
        /// identified as Package Supplier, this field identifies from where or whom the package originally came
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originator")]
        public virtual string Originator { get; set; }

        /// <summary>The type of package: OS, MAVEN, GO, GO_STDLIB, etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageType")]
        public virtual string PackageType { get; set; }

        /// <summary>A short description of the package</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("summaryDescription")]
        public virtual string SummaryDescription { get; set; }

        /// <summary>
        /// Identify the actual distribution source for the package/directory identified in the SPDX file
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supplier")]
        public virtual string Supplier { get; set; }

        /// <summary>Identify the full name of the package as given by the Package Originator</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>
        /// This field provides an independently reproducible mechanism identifying specific contents of a package based
        /// on the actual files (except the SPDX file itself, if it is included in the package) that make up each
        /// package and that correlates to the data in this SPDX file
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verificationCode")]
        public virtual string VerificationCode { get; set; }

        /// <summary>Identify the version of the package</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// PackageInfoOccurrence represents an SPDX Package Information section:
    /// https://spdx.github.io/spdx-spec/3-package-information/
    /// </summary>
    public class PackageInfoOccurrence : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A place for the SPDX file creator to record any general comments about the package being described
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("comment")]
        public virtual string Comment { get; set; }

        /// <summary>
        /// Provide the actual file name of the package, or path of the directory being treated as a package
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filename")]
        public virtual string Filename { get; set; }

        /// <summary>
        /// Output only. Provide a place for the SPDX file creator to record a web site that serves as the package's
        /// home page
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("homePage")]
        public virtual string HomePage { get; set; }

        /// <summary>
        /// Uniquely identify any element in an SPDX document which may be referenced by other elements
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>package or alternative values, if the governing license cannot be determined</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("licenseConcluded")]
        public virtual License LicenseConcluded { get; set; }

        /// <summary>Output only. The type of package: OS, MAVEN, GO, GO_STDLIB, etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageType")]
        public virtual string PackageType { get; set; }

        /// <summary>
        /// Provide a place for the SPDX file creator to record any relevant background information or additional
        /// comments about the origin of the package
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceInfo")]
        public virtual string SourceInfo { get; set; }

        /// <summary>Output only. A short description of the package</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("summaryDescription")]
        public virtual string SummaryDescription { get; set; }

        /// <summary>Output only. Identify the full name of the package as given by the Package Originator</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>Output only. Identify the version of the package</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// This message wraps a location affected by a vulnerability and its associated fix (if one is available).
    /// </summary>
    public class PackageIssue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The location of the vulnerability.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("affectedLocation")]
        public virtual VulnerabilityLocation AffectedLocation { get; set; }

        /// <summary>
        /// Output only. The distro or language system assigned severity for this vulnerability when that is available
        /// and note provider assigned severity when it is not available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("effectiveSeverity")]
        public virtual string EffectiveSeverity { get; set; }

        /// <summary>The location of the available fix for vulnerability.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fixedLocation")]
        public virtual VulnerabilityLocation FixedLocation { get; set; }

        /// <summary>The type of package (e.g. OS, MAVEN, GO).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageType")]
        public virtual string PackageType { get; set; }

        /// <summary>
        /// Deprecated, use Details.effective_severity instead The severity (e.g., distro assigned severity) for this
        /// vulnerability.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severityName")]
        public virtual string SeverityName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An attestation wrapper with a PGP-compatible signature. This message only supports `ATTACHED` signatures, where
    /// the payload that is signed is included alongside the signature itself in the same file.
    /// </summary>
    public class PgpSignedAttestation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Type (for example schema) of the attestation payload that was signed. The verifier must ensure that the
        /// provided type is one that the verifier supports, and that the attestation payload is a valid instantiation
        /// of that type (for example by validating a JSON schema).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentType")]
        public virtual string ContentType { get; set; }

        /// <summary>
        /// The cryptographic fingerprint of the key used to generate the signature, as output by, e.g. `gpg
        /// --list-keys`. This should be the version 4, full 160-bit fingerprint, expressed as a 40 character
        /// hexadecimal string. See https://tools.ietf.org/html/rfc4880#section-12.2 for details. Implementations may
        /// choose to acknowledge "LONG", "SHORT", or other abbreviated key IDs, but only the full fingerprint is
        /// guaranteed to work. In gpg, the full fingerprint can be retrieved from the `fpr` field returned when calling
        /// --list-keys with --with-colons. For example: ``` gpg --with-colons --with-fingerprint --force-v4-certs \
        /// --list-keys attester@example.com tru::1:1513631572:0:3:1:5 pub:......
        /// fpr:::::::::24FF6481B76AC91E66A00AC657A93A81EF3AE6FB: ``` Above, the fingerprint is
        /// `24FF6481B76AC91E66A00AC657A93A81EF3AE6FB`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pgpKeyId")]
        public virtual string PgpKeyId { get; set; }

        /// <summary>
        /// Required. The raw content of the signature, as output by GNU Privacy Guard (GPG) or equivalent. Since this
        /// message only supports attached signatures, the payload that was signed must be attached. While the signature
        /// format supported is dependent on the verification implementation, currently only ASCII-armored (`--armor` to
        /// gpg), non-clearsigned (`--sign` rather than `--clearsign` to gpg) are supported. Concretely, `gpg --sign
        /// --armor --output=signature.gpg payload.json` will create the signature content expected in this field in
        /// `signature.gpg` for the `payload.json` attestation payload.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signature")]
        public virtual string Signature { get; set; }

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
    /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies). **JSON example:** { "bindings":
    /// [ { "role": "roles/resourcemanager.organizationAdmin", "members": [ "user:mike@example.com",
    /// "group:admins@example.com", "domain:google.com", "serviceAccount:my-project-id@appspot.gserviceaccount.com" ] },
    /// { "role": "roles/resourcemanager.organizationViewer", "members": [ "user:eve@example.com" ], "condition": {
    /// "title": "expirable access", "description": "Does not grant access after Sep 2020", "expression": "request.time
    /// &amp;lt; timestamp('2020-10-01T00:00:00.000Z')", } } ], "etag": "BwWWja0YfJA=", "version": 3 } **YAML example:**
    /// bindings: - members: - user:mike@example.com - group:admins@example.com - domain:google.com -
    /// serviceAccount:my-project-id@appspot.gserviceaccount.com role: roles/resourcemanager.organizationAdmin -
    /// members: - user:eve@example.com role: roles/resourcemanager.organizationViewer condition: title: expirable
    /// access description: Does not grant access after Sep 2020 expression: request.time &amp;lt;
    /// timestamp('2020-10-01T00:00:00.000Z') etag: BwWWja0YfJA= version: 3 For a description of IAM and its features,
    /// see the [IAM documentation](https://cloud.google.com/iam/docs/).
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
    /// Selects a repo using a Google Cloud Platform project ID (e.g., winged-cargo-31) and a repo name within that
    /// project.
    /// </summary>
    public class ProjectRepoId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>The name of the repo. Leave empty for the default repo.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repoName")]
        public virtual string RepoName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for any related URL information.</summary>
    public class RelatedUrl : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Label to describe usage of the URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; }

        /// <summary>Specific URL associated with the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// RelationshipNote represents an SPDX Relationship section:
    /// https://spdx.github.io/spdx-spec/7-relationships-between-SPDX-elements/
    /// </summary>
    public class RelationshipNote : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of relationship between the source and target SPDX elements</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// RelationshipOccurrence represents an SPDX Relationship section:
    /// https://spdx.github.io/spdx-spec/7-relationships-between-SPDX-elements/
    /// </summary>
    public class RelationshipOccurrence : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A place for the SPDX file creator to record any general comments about the relationship</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("comment")]
        public virtual string Comment { get; set; }

        /// <summary>Also referred to as SPDXRef-A The source SPDX element (file, package, etc)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual string Source { get; set; }

        /// <summary>
        /// Also referred to as SPDXRef-B The target SPDC element (file, package, etc) In cases where there are "known
        /// unknowns", the use of the keyword NOASSERTION can be used The keywords NONE can be used to indicate that an
        /// SPDX element (package/file/snippet) has no other elements connected by some relationship to it
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual string Target { get; set; }

        /// <summary>Output only. The type of relationship between the source and target SPDX elements</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A unique identifier for a Cloud Repo.</summary>
    public class RepoId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A combination of a project ID and a repo name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectRepoId")]
        public virtual ProjectRepoId ProjectRepoId { get; set; }

        /// <summary>A server-assigned, globally unique identifier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An entity that can have metadata. For example, a Docker image.</summary>
    public class Resource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Deprecated, do not use. Use uri instead. The hash of the resource content. For example, the Docker digest.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentHash")]
        public virtual Hash ContentHash { get; set; }

        /// <summary>
        /// Deprecated, do not use. Use uri instead. The name of the resource. For example, the name of a Docker image -
        /// "Debian".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. The unique URI of the resource. For example, `https://gcr.io/project/image@sha256:foo` for a
        /// Docker image.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

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
    /// Verifiers (e.g. Kritis implementations) MUST verify signatures with respect to the trust anchors defined in
    /// policy (e.g. a Kritis policy). Typically this means that the verifier has been configured with a map from
    /// `public_key_id` to public key material (and any required parameters, e.g. signing algorithm). In particular,
    /// verification implementations MUST NOT treat the signature `public_key_id` as anything more than a key lookup
    /// hint. The `public_key_id` DOES NOT validate or authenticate a public key; it only provides a mechanism for
    /// quickly selecting a public key ALREADY CONFIGURED on the verifier through a trusted channel. Verification
    /// implementations MUST reject signatures in any of the following circumstances: * The `public_key_id` is not
    /// recognized by the verifier. * The public key that `public_key_id` refers to does not verify the signature with
    /// respect to the payload. The `signature` contents SHOULD NOT be "attached" (where the payload is included with
    /// the serialized `signature` bytes). Verifiers MUST ignore any "attached" payload and only verify signatures with
    /// respect to explicitly provided payload (e.g. a `payload` field on the proto message that holds this Signature,
    /// or the canonical serialization of the proto message that holds this signature).
    /// </summary>
    public class Signature : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The identifier for the public key that verifies this signature. * The `public_key_id` is required. * The
        /// `public_key_id` SHOULD be an RFC3986 conformant URI. * When possible, the `public_key_id` SHOULD be an
        /// immutable reference, such as a cryptographic digest. Examples of valid `public_key_id`s: OpenPGP V4 public
        /// key fingerprint: * "openpgp4fpr:74FAF3B861BDA0870C7B6DEF607E48D2A663AEEA" See
        /// https://www.iana.org/assignments/uri-schemes/prov/openpgp4fpr for more details on this scheme. RFC6920
        /// digest-named SubjectPublicKeyInfo (digest of the DER serialization): *
        /// "ni:///sha-256;cD9o9Cq6LG3jD0iKXqEi_vdjJGecm_iXkbqVoScViaU" *
        /// "nih:///sha-256;703f68f42aba2c6de30f488a5ea122fef76324679c9bf89791ba95a1271589a5"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicKeyId")]
        public virtual string PublicKeyId { get; set; }

        /// <summary>
        /// The content of the signature, an opaque bytestring. The payload that this signature verifies MUST be
        /// unambiguously provided with the Signature during verification. A wrapper message might provide the payload
        /// explicitly. Alternatively, a message might have a canonical serialization that can always be unambiguously
        /// computed to derive the payload.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signature")]
        public virtual string SignatureValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// This defines the format used to record keys used in the software supply chain. An in-toto link is attested using
    /// one or more keys defined in the in-toto layout. An example of this is: { "key_id":
    /// "776a00e29f3559e0141b3b096f696abc6cfb0c657ab40f441132b345b0...", "key_type": "rsa", "public_key_value":
    /// "-----BEGIN PUBLIC KEY-----\nMIIBojANBgkqhkiG9w0B...", "key_scheme": "rsassa-pss-sha256" } The format for
    /// in-toto's key definition can be found in section 4.2 of the in-toto specification.
    /// </summary>
    public class SigningKey : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>key_id is an identifier for the signing key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyId")]
        public virtual string KeyId { get; set; }

        /// <summary>This field contains the corresponding signature scheme. Eg: "rsassa-pss-sha256".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyScheme")]
        public virtual string KeyScheme { get; set; }

        /// <summary>This field identifies the specific signing method. Eg: "rsa", "ed25519", and "ecdsa".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyType")]
        public virtual string KeyType { get; set; }

        /// <summary>This field contains the actual public key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicKeyValue")]
        public virtual string PublicKeyValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Source describes the location of the source used for the build.</summary>
    public class Source : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If provided, some of the source code used for the build may be found in these locations, in the case where
        /// the source repository had multiple remotes or submodules. This list will not include the context specified
        /// in the context field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalContexts")]
        public virtual System.Collections.Generic.IList<SourceContext> AdditionalContexts { get; set; }

        /// <summary>If provided, the input binary artifacts for the build came from this location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("artifactStorageSourceUri")]
        public virtual string ArtifactStorageSourceUri { get; set; }

        /// <summary>If provided, the source code used for the build came from this location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("context")]
        public virtual SourceContext Context { get; set; }

        /// <summary>
        /// Hash(es) of the build source, which can be used to verify that the original source integrity was maintained
        /// in the build. The keys to this map are file paths used as build source and the values contain the hash
        /// values for those files. If the build source came in a single package such as a gzipped tarfile (.tar.gz),
        /// the FileHash will be for the single path to that file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileHashes")]
        public virtual System.Collections.Generic.IDictionary<string, FileHashes> FileHashes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A SourceContext is a reference to a tree of files. A SourceContext together with a path point to a unique
    /// revision of a single file or directory.
    /// </summary>
    public class SourceContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A SourceContext referring to a revision in a Google Cloud Source Repo.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudRepo")]
        public virtual CloudRepoSourceContext CloudRepo { get; set; }

        /// <summary>A SourceContext referring to a Gerrit project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gerrit")]
        public virtual GerritSourceContext Gerrit { get; set; }

        /// <summary>A SourceContext referring to any third party Git repo (e.g., GitHub).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("git")]
        public virtual GitSourceContext Git { get; set; }

        /// <summary>Labels with user defined metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

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

    /// <summary>Start and end times for a build execution phase. Next ID: 3</summary>
    public class TimeSpan : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>End of time span.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>Start of time span.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Version contains structured information about the version of a package.</summary>
    public class Version : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Used to correct mistakes in the version numbering scheme.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("epoch")]
        public virtual System.Nullable<int> Epoch { get; set; }

        /// <summary>
        /// Whether this version is specifying part of an inclusive range. Grafeas does not have the capability to
        /// specify version ranges; instead we have fields that specify start version and end versions. At times this is
        /// insufficient - we also need to specify whether the version is included in the range or is excluded from the
        /// range. This boolean is expected to be set to true when the version is included in a range.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inclusive")]
        public virtual System.Nullable<bool> Inclusive { get; set; }

        /// <summary>Required. Distinguishes between sentinel MIN/MAX versions and normal versions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Required only when version kind is NORMAL. The main part of the version name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The iteration of the package build from the above version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revision")]
        public virtual string Revision { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Volume describes a Docker container volume which is mounted into build steps in order to persist files across
    /// build step execution. Next ID: 3
    /// </summary>
    public class Volume : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Name of the volume to mount. Volume names must be unique per build step and must be valid names for Docker
        /// volumes. Each named volume must be used by at least two build steps.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Path at which to mount the volume. Paths must be absolute and cannot conflict with other volume paths on the
        /// same build step or with certain reserved volume paths.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Vulnerability provides metadata about a security vulnerability in a Note.</summary>
    public class Vulnerability : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The CVSS score for this vulnerability.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cvssScore")]
        public virtual System.Nullable<float> CvssScore { get; set; }

        /// <summary>The full description of the CVSS for version 2.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cvssV2")]
        public virtual CVSS CvssV2 { get; set; }

        /// <summary>The full description of the CVSS for version 3.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cvssV3")]
        public virtual CVSSv3 CvssV3 { get; set; }

        /// <summary>CVSS version used to populate cvss_score and severity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cvssVersion")]
        public virtual string CvssVersion { get; set; }

        /// <summary>A list of CWE for this vulnerability. For details, see: https://cwe.mitre.org/index.html</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cwe")]
        public virtual System.Collections.Generic.IList<string> Cwe { get; set; }

        /// <summary>
        /// All information about the package to specifically identify this vulnerability. One entry per (version range
        /// and cpe_uri) the package vulnerability has manifested in.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual System.Collections.Generic.IList<Detail> Details { get; set; }

        /// <summary>Note provider assigned impact of the vulnerability.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>
        /// The time this information was last changed at the source. This is an upstream timestamp from the underlying
        /// information source - e.g. Ubuntu security tracker.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceUpdateTime")]
        public virtual object SourceUpdateTime { get; set; }

        /// <summary>
        /// Windows details get their own format because the information format and model don't match a normal detail.
        /// Specifically Windows updates are done as patches, thus Windows vulnerabilities really are a missing package,
        /// rather than a package being at an incorrect version.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("windowsDetails")]
        public virtual System.Collections.Generic.IList<WindowsDetail> WindowsDetails { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The location of the vulnerability.</summary>
    public class VulnerabilityLocation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The CPE URI in [cpe format](https://cpe.mitre.org/specification/) format. Examples include distro
        /// or storage location for vulnerable jar.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpeUri")]
        public virtual string CpeUri { get; set; }

        /// <summary>Required. The package being described.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("package")]
        public virtual string Package { get; set; }

        /// <summary>Required. The version of the package being described.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual Version Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A summary of how many vulnerability occurrences there are per resource and severity type.</summary>
    public class VulnerabilityOccurrencesSummary : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A listing by resource of the number of fixable and total vulnerabilities.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("counts")]
        public virtual System.Collections.Generic.IList<FixableTotalByDigest> Counts { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class WindowsDetail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The CPE URI in [cpe format](https://cpe.mitre.org/specification/) in which the vulnerability
        /// manifests. Examples include distro or storage location for vulnerable jar.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpeUri")]
        public virtual string CpeUri { get; set; }

        /// <summary>The description of the vulnerability.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Required. The names of the KBs which have hotfixes to mitigate this vulnerability. Note that there may be
        /// multiple hotfixes (and thus multiple KBs) that mitigate a given vulnerability. Currently any listed kb's
        /// presence is considered a fix.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fixingKbs")]
        public virtual System.Collections.Generic.IList<KnowledgeBase> FixingKbs { get; set; }

        /// <summary>Required. The name of the vulnerability.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
