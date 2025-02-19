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

namespace Google.Apis.Datastore.v1beta1
{
    /// <summary>The Datastore Service.</summary>
    public class DatastoreService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1beta1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public DatastoreService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public DatastoreService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://datastore.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://datastore.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "datastore";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Datastore API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>View and manage your Google Cloud Datastore data</summary>
            public static string Datastore = "https://www.googleapis.com/auth/datastore";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Datastore API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>View and manage your Google Cloud Datastore data</summary>
            public const string Datastore = "https://www.googleapis.com/auth/datastore";
        }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for Datastore requests.</summary>
    public abstract class DatastoreBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new DatastoreBaseServiceRequest instance.</summary>
        protected DatastoreBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Datastore parameter list.</summary>
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
        }

        /// <summary>
        /// Exports a copy of all or a subset of entities from Google Cloud Datastore to another storage system, such as
        /// Google Cloud Storage. Recent updates to entities may not be reflected in the export. The export occurs in
        /// the background and its progress can be monitored and managed via the Operation resource that is created. The
        /// output of an export may only be used once the associated operation is done. If an export operation is
        /// cancelled before completion it may leave partial data behind in Google Cloud Storage.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="projectId">Project ID against which to make the request.</param>
        public virtual ExportRequest Export(Google.Apis.Datastore.v1beta1.Data.GoogleDatastoreAdminV1beta1ExportEntitiesRequest body, string projectId)
        {
            return new ExportRequest(this.service, body, projectId);
        }

        /// <summary>
        /// Exports a copy of all or a subset of entities from Google Cloud Datastore to another storage system, such as
        /// Google Cloud Storage. Recent updates to entities may not be reflected in the export. The export occurs in
        /// the background and its progress can be monitored and managed via the Operation resource that is created. The
        /// output of an export may only be used once the associated operation is done. If an export operation is
        /// cancelled before completion it may leave partial data behind in Google Cloud Storage.
        /// </summary>
        public class ExportRequest : DatastoreBaseServiceRequest<Google.Apis.Datastore.v1beta1.Data.GoogleLongrunningOperation>
        {
            /// <summary>Constructs a new Export request.</summary>
            public ExportRequest(Google.Apis.Services.IClientService service, Google.Apis.Datastore.v1beta1.Data.GoogleDatastoreAdminV1beta1ExportEntitiesRequest body, string projectId) : base(service)
            {
                ProjectId = projectId;
                Body = body;
                InitParameters();
            }

            /// <summary>Project ID against which to make the request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Datastore.v1beta1.Data.GoogleDatastoreAdminV1beta1ExportEntitiesRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "export";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta1/projects/{projectId}:export";

            /// <summary>Initializes Export parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                {
                    Name = "projectId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Imports entities into Google Cloud Datastore. Existing entities with the same key are overwritten. The
        /// import occurs in the background and its progress can be monitored and managed via the Operation resource
        /// that is created. If an ImportEntities operation is cancelled, it is possible that a subset of the data has
        /// already been imported to Cloud Datastore.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="projectId">Project ID against which to make the request.</param>
        public virtual ImportRequest Import(Google.Apis.Datastore.v1beta1.Data.GoogleDatastoreAdminV1beta1ImportEntitiesRequest body, string projectId)
        {
            return new ImportRequest(this.service, body, projectId);
        }

        /// <summary>
        /// Imports entities into Google Cloud Datastore. Existing entities with the same key are overwritten. The
        /// import occurs in the background and its progress can be monitored and managed via the Operation resource
        /// that is created. If an ImportEntities operation is cancelled, it is possible that a subset of the data has
        /// already been imported to Cloud Datastore.
        /// </summary>
        public class ImportRequest : DatastoreBaseServiceRequest<Google.Apis.Datastore.v1beta1.Data.GoogleLongrunningOperation>
        {
            /// <summary>Constructs a new Import request.</summary>
            public ImportRequest(Google.Apis.Services.IClientService service, Google.Apis.Datastore.v1beta1.Data.GoogleDatastoreAdminV1beta1ImportEntitiesRequest body, string projectId) : base(service)
            {
                ProjectId = projectId;
                Body = body;
                InitParameters();
            }

            /// <summary>Project ID against which to make the request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Datastore.v1beta1.Data.GoogleDatastoreAdminV1beta1ImportEntitiesRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "import";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta1/projects/{projectId}:import";

            /// <summary>Initializes Import parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                {
                    Name = "projectId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }
}
namespace Google.Apis.Datastore.v1beta1.Data
{
    /// <summary>Metadata common to all Datastore Admin operations.</summary>
    public class GoogleDatastoreAdminV1CommonMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _endTimeRaw;

        private object _endTime;

        /// <summary>The time the operation ended, either successfully or otherwise.</summary>
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
        /// The client-assigned labels which were provided when the operation was created. May also include additional
        /// labels.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>The type of the operation. Can be used as a filter in ListOperationsRequest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationType")]
        public virtual string OperationType { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>The time that work began on the operation.</summary>
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

        /// <summary>The current state of the Operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata for Datastore to Firestore migration operations. The DatastoreFirestoreMigration operation is not
    /// started by the end-user via an explicit "creation" method. This is an intentional deviation from the LRO design
    /// pattern. This singleton resource can be accessed at:
    /// "projects/{project_id}/operations/datastore-firestore-migration"
    /// </summary>
    public class GoogleDatastoreAdminV1DatastoreFirestoreMigrationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The current state of migration from Cloud Datastore to Cloud Firestore in Datastore mode.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("migrationState")]
        public virtual string MigrationState { get; set; }

        /// <summary>The current step of migration from Cloud Datastore to Cloud Firestore in Datastore mode.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("migrationStep")]
        public virtual string MigrationStep { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Identifies a subset of entities in a project. This is specified as combinations of kinds and namespaces (either
    /// or both of which may be all, as described in the following examples). Example usage: Entire project: kinds=[],
    /// namespace_ids=[] Kinds Foo and Bar in all namespaces: kinds=['Foo', 'Bar'], namespace_ids=[] Kinds Foo and Bar
    /// only in the default namespace: kinds=['Foo', 'Bar'], namespace_ids=[''] Kinds Foo and Bar in both the default
    /// and Baz namespaces: kinds=['Foo', 'Bar'], namespace_ids=['', 'Baz'] The entire Baz namespace: kinds=[],
    /// namespace_ids=['Baz']
    /// </summary>
    public class GoogleDatastoreAdminV1EntityFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If empty, then this represents all kinds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kinds")]
        public virtual System.Collections.Generic.IList<string> Kinds { get; set; }

        /// <summary>
        /// An empty list represents all namespaces. This is the preferred usage for projects that don't use namespaces.
        /// An empty string element represents the default namespace. This should be used if the project has data in
        /// non-default namespaces, but doesn't want to include them. Each namespace in this list must be unique.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namespaceIds")]
        public virtual System.Collections.Generic.IList<string> NamespaceIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for ExportEntities operations.</summary>
    public class GoogleDatastoreAdminV1ExportEntitiesMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Metadata common to all Datastore Admin operations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("common")]
        public virtual GoogleDatastoreAdminV1CommonMetadata Common { get; set; }

        /// <summary>Description of which entities are being exported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityFilter")]
        public virtual GoogleDatastoreAdminV1EntityFilter EntityFilter { get; set; }

        /// <summary>
        /// Location for the export metadata and data files. This will be the same value as the
        /// google.datastore.admin.v1.ExportEntitiesRequest.output_url_prefix field. The final output location is
        /// provided in google.datastore.admin.v1.ExportEntitiesResponse.output_url.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputUrlPrefix")]
        public virtual string OutputUrlPrefix { get; set; }

        /// <summary>An estimate of the number of bytes processed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressBytes")]
        public virtual GoogleDatastoreAdminV1Progress ProgressBytes { get; set; }

        /// <summary>An estimate of the number of entities processed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressEntities")]
        public virtual GoogleDatastoreAdminV1Progress ProgressEntities { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for google.datastore.admin.v1.DatastoreAdmin.ExportEntities.</summary>
    public class GoogleDatastoreAdminV1ExportEntitiesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Location of the output metadata file. This can be used to begin an import into Cloud Datastore (this project
        /// or another project). See google.datastore.admin.v1.ImportEntitiesRequest.input_url. Only present if the
        /// operation completed successfully.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputUrl")]
        public virtual string OutputUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for ImportEntities operations.</summary>
    public class GoogleDatastoreAdminV1ImportEntitiesMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Metadata common to all Datastore Admin operations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("common")]
        public virtual GoogleDatastoreAdminV1CommonMetadata Common { get; set; }

        /// <summary>Description of which entities are being imported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityFilter")]
        public virtual GoogleDatastoreAdminV1EntityFilter EntityFilter { get; set; }

        /// <summary>
        /// The location of the import metadata file. This will be the same value as the
        /// google.datastore.admin.v1.ExportEntitiesResponse.output_url field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputUrl")]
        public virtual string InputUrl { get; set; }

        /// <summary>An estimate of the number of bytes processed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressBytes")]
        public virtual GoogleDatastoreAdminV1Progress ProgressBytes { get; set; }

        /// <summary>An estimate of the number of entities processed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressEntities")]
        public virtual GoogleDatastoreAdminV1Progress ProgressEntities { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for Index operations.</summary>
    public class GoogleDatastoreAdminV1IndexOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Metadata common to all Datastore Admin operations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("common")]
        public virtual GoogleDatastoreAdminV1CommonMetadata Common { get; set; }

        /// <summary>The index resource ID that this operation is acting on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indexId")]
        public virtual string IndexId { get; set; }

        /// <summary>An estimate of the number of entities processed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressEntities")]
        public virtual GoogleDatastoreAdminV1Progress ProgressEntities { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An event signifying the start of a new step in a [migration from Cloud Datastore to Cloud Firestore in Datastore
    /// mode](https://cloud.google.com/datastore/docs/upgrade-to-firestore).
    /// </summary>
    public class GoogleDatastoreAdminV1MigrationProgressEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Details for the `PREPARE` step.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prepareStepDetails")]
        public virtual GoogleDatastoreAdminV1PrepareStepDetails PrepareStepDetails { get; set; }

        /// <summary>Details for the `REDIRECT_WRITES` step.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("redirectWritesStepDetails")]
        public virtual GoogleDatastoreAdminV1RedirectWritesStepDetails RedirectWritesStepDetails { get; set; }

        /// <summary>
        /// The step that is starting. An event with step set to `START` indicates that the migration has been reverted
        /// back to the initial pre-migration state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("step")]
        public virtual string Step { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An event signifying a change in state of a [migration from Cloud Datastore to Cloud Firestore in Datastore
    /// mode](https://cloud.google.com/datastore/docs/upgrade-to-firestore).
    /// </summary>
    public class GoogleDatastoreAdminV1MigrationStateEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The new state of the migration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details for the `PREPARE` step.</summary>
    public class GoogleDatastoreAdminV1PrepareStepDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The concurrency mode this database will use when it reaches the `REDIRECT_WRITES` step.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("concurrencyMode")]
        public virtual string ConcurrencyMode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Measures the progress of a particular metric.</summary>
    public class GoogleDatastoreAdminV1Progress : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The amount of work that has been completed. Note that this may be greater than work_estimated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workCompleted")]
        public virtual System.Nullable<long> WorkCompleted { get; set; }

        /// <summary>
        /// An estimate of how much work needs to be performed. May be zero if the work estimate is unavailable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workEstimated")]
        public virtual System.Nullable<long> WorkEstimated { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details for the `REDIRECT_WRITES` step.</summary>
    public class GoogleDatastoreAdminV1RedirectWritesStepDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The concurrency mode for this database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("concurrencyMode")]
        public virtual string ConcurrencyMode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata common to all Datastore Admin operations.</summary>
    public class GoogleDatastoreAdminV1beta1CommonMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _endTimeRaw;

        private object _endTime;

        /// <summary>The time the operation ended, either successfully or otherwise.</summary>
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
        /// The client-assigned labels which were provided when the operation was created. May also include additional
        /// labels.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>The type of the operation. Can be used as a filter in ListOperationsRequest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationType")]
        public virtual string OperationType { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>The time that work began on the operation.</summary>
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

        /// <summary>The current state of the Operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Identifies a subset of entities in a project. This is specified as combinations of kinds and namespaces (either
    /// or both of which may be all, as described in the following examples). Example usage: Entire project: kinds=[],
    /// namespace_ids=[] Kinds Foo and Bar in all namespaces: kinds=['Foo', 'Bar'], namespace_ids=[] Kinds Foo and Bar
    /// only in the default namespace: kinds=['Foo', 'Bar'], namespace_ids=[''] Kinds Foo and Bar in both the default
    /// and Baz namespaces: kinds=['Foo', 'Bar'], namespace_ids=['', 'Baz'] The entire Baz namespace: kinds=[],
    /// namespace_ids=['Baz']
    /// </summary>
    public class GoogleDatastoreAdminV1beta1EntityFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If empty, then this represents all kinds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kinds")]
        public virtual System.Collections.Generic.IList<string> Kinds { get; set; }

        /// <summary>
        /// An empty list represents all namespaces. This is the preferred usage for projects that don't use namespaces.
        /// An empty string element represents the default namespace. This should be used if the project has data in
        /// non-default namespaces, but doesn't want to include them. Each namespace in this list must be unique.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namespaceIds")]
        public virtual System.Collections.Generic.IList<string> NamespaceIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for ExportEntities operations.</summary>
    public class GoogleDatastoreAdminV1beta1ExportEntitiesMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Metadata common to all Datastore Admin operations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("common")]
        public virtual GoogleDatastoreAdminV1beta1CommonMetadata Common { get; set; }

        /// <summary>Description of which entities are being exported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityFilter")]
        public virtual GoogleDatastoreAdminV1beta1EntityFilter EntityFilter { get; set; }

        /// <summary>
        /// Location for the export metadata and data files. This will be the same value as the
        /// google.datastore.admin.v1beta1.ExportEntitiesRequest.output_url_prefix field. The final output location is
        /// provided in google.datastore.admin.v1beta1.ExportEntitiesResponse.output_url.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputUrlPrefix")]
        public virtual string OutputUrlPrefix { get; set; }

        /// <summary>An estimate of the number of bytes processed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressBytes")]
        public virtual GoogleDatastoreAdminV1beta1Progress ProgressBytes { get; set; }

        /// <summary>An estimate of the number of entities processed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressEntities")]
        public virtual GoogleDatastoreAdminV1beta1Progress ProgressEntities { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for google.datastore.admin.v1beta1.DatastoreAdmin.ExportEntities.</summary>
    public class GoogleDatastoreAdminV1beta1ExportEntitiesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Description of what data from the project is included in the export.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityFilter")]
        public virtual GoogleDatastoreAdminV1beta1EntityFilter EntityFilter { get; set; }

        /// <summary>Client-assigned labels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Location for the export metadata and data files. The full resource URL of the external storage location.
        /// Currently, only Google Cloud Storage is supported. So output_url_prefix should be of the form:
        /// `gs://BUCKET_NAME[/NAMESPACE_PATH]`, where `BUCKET_NAME` is the name of the Cloud Storage bucket and
        /// `NAMESPACE_PATH` is an optional Cloud Storage namespace path (this is not a Cloud Datastore namespace). For
        /// more information about Cloud Storage namespace paths, see [Object name
        /// considerations](https://cloud.google.com/storage/docs/naming#object-considerations). The resulting files
        /// will be nested deeper than the specified URL prefix. The final output URL will be provided in the
        /// google.datastore.admin.v1beta1.ExportEntitiesResponse.output_url field. That value should be used for
        /// subsequent ImportEntities operations. By nesting the data files deeper, the same Cloud Storage bucket can be
        /// used in multiple ExportEntities operations without conflict.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputUrlPrefix")]
        public virtual string OutputUrlPrefix { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for google.datastore.admin.v1beta1.DatastoreAdmin.ExportEntities.</summary>
    public class GoogleDatastoreAdminV1beta1ExportEntitiesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Location of the output metadata file. This can be used to begin an import into Cloud Datastore (this project
        /// or another project). See google.datastore.admin.v1beta1.ImportEntitiesRequest.input_url. Only present if the
        /// operation completed successfully.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputUrl")]
        public virtual string OutputUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for ImportEntities operations.</summary>
    public class GoogleDatastoreAdminV1beta1ImportEntitiesMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Metadata common to all Datastore Admin operations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("common")]
        public virtual GoogleDatastoreAdminV1beta1CommonMetadata Common { get; set; }

        /// <summary>Description of which entities are being imported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityFilter")]
        public virtual GoogleDatastoreAdminV1beta1EntityFilter EntityFilter { get; set; }

        /// <summary>
        /// The location of the import metadata file. This will be the same value as the
        /// google.datastore.admin.v1beta1.ExportEntitiesResponse.output_url field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputUrl")]
        public virtual string InputUrl { get; set; }

        /// <summary>An estimate of the number of bytes processed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressBytes")]
        public virtual GoogleDatastoreAdminV1beta1Progress ProgressBytes { get; set; }

        /// <summary>An estimate of the number of entities processed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressEntities")]
        public virtual GoogleDatastoreAdminV1beta1Progress ProgressEntities { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for google.datastore.admin.v1beta1.DatastoreAdmin.ImportEntities.</summary>
    public class GoogleDatastoreAdminV1beta1ImportEntitiesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optionally specify which kinds/namespaces are to be imported. If provided, the list must be a subset of the
        /// EntityFilter used in creating the export, otherwise a FAILED_PRECONDITION error will be returned. If no
        /// filter is specified then all entities from the export are imported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityFilter")]
        public virtual GoogleDatastoreAdminV1beta1EntityFilter EntityFilter { get; set; }

        /// <summary>
        /// The full resource URL of the external storage location. Currently, only Google Cloud Storage is supported.
        /// So input_url should be of the form: `gs://BUCKET_NAME[/NAMESPACE_PATH]/OVERALL_EXPORT_METADATA_FILE`, where
        /// `BUCKET_NAME` is the name of the Cloud Storage bucket, `NAMESPACE_PATH` is an optional Cloud Storage
        /// namespace path (this is not a Cloud Datastore namespace), and `OVERALL_EXPORT_METADATA_FILE` is the metadata
        /// file written by the ExportEntities operation. For more information about Cloud Storage namespace paths, see
        /// [Object name considerations](https://cloud.google.com/storage/docs/naming#object-considerations). For more
        /// information, see google.datastore.admin.v1beta1.ExportEntitiesResponse.output_url.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputUrl")]
        public virtual string InputUrl { get; set; }

        /// <summary>Client-assigned labels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Measures the progress of a particular metric.</summary>
    public class GoogleDatastoreAdminV1beta1Progress : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The amount of work that has been completed. Note that this may be greater than work_estimated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workCompleted")]
        public virtual System.Nullable<long> WorkCompleted { get; set; }

        /// <summary>
        /// An estimate of how much work needs to be performed. May be zero if the work estimate is unavailable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workEstimated")]
        public virtual System.Nullable<long> WorkEstimated { get; set; }

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
}
