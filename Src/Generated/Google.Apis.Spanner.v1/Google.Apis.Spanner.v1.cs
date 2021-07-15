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

namespace Google.Apis.Spanner.v1
{
    /// <summary>The Spanner Service.</summary>
    public class SpannerService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public SpannerService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public SpannerService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
            Scans = new ScansResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "spanner";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://spanner.googleapis.com/";
        #else
            "https://spanner.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://spanner.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Spanner API.</summary>
        public class Scope
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>Administer your Spanner databases</summary>
            public static string SpannerAdmin = "https://www.googleapis.com/auth/spanner.admin";

            /// <summary>View and manage the contents of your Spanner databases</summary>
            public static string SpannerData = "https://www.googleapis.com/auth/spanner.data";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Spanner API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>Administer your Spanner databases</summary>
            public const string SpannerAdmin = "https://www.googleapis.com/auth/spanner.admin";

            /// <summary>View and manage the contents of your Spanner databases</summary>
            public const string SpannerData = "https://www.googleapis.com/auth/spanner.data";
        }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }

        /// <summary>Gets the Scans resource.</summary>
        public virtual ScansResource Scans { get; }
    }

    /// <summary>A base abstract class for Spanner requests.</summary>
    public abstract class SpannerBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new SpannerBaseServiceRequest instance.</summary>
        protected SpannerBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Spanner parameter list.</summary>
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
            InstanceConfigs = new InstanceConfigsResource(service);
            Instances = new InstancesResource(service);
        }

        /// <summary>Gets the InstanceConfigs resource.</summary>
        public virtual InstanceConfigsResource InstanceConfigs { get; }

        /// <summary>The "instanceConfigs" collection of methods.</summary>
        public class InstanceConfigsResource
        {
            private const string Resource = "instanceConfigs";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public InstanceConfigsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Gets information about a particular instance configuration.</summary>
            /// <param name="name">
            /// Required. The name of the requested instance configuration. Values are of the form
            /// `projects//instanceConfigs/`.
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets information about a particular instance configuration.</summary>
            public class GetRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.InstanceConfig>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the requested instance configuration. Values are of the form
                /// `projects//instanceConfigs/`.
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
                        Pattern = @"^projects/[^/]+/instanceConfigs/[^/]+$",
                    });
                }
            }

            /// <summary>Lists the supported instance configurations for a given project.</summary>
            /// <param name="parent">
            /// Required. The name of the project for which a list of supported instance configurations is requested.
            /// Values are of the form `projects/`.
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists the supported instance configurations for a given project.</summary>
            public class ListRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.ListInstanceConfigsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the project for which a list of supported instance configurations is
                /// requested. Values are of the form `projects/`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Number of instance configurations to be returned in the response. If 0 or less, defaults to the
                /// server's maximum allowed page size.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// If non-empty, `page_token` should contain a next_page_token from a previous
                /// ListInstanceConfigsResponse.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/instanceConfigs";

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
        }

        /// <summary>Gets the Instances resource.</summary>
        public virtual InstancesResource Instances { get; }

        /// <summary>The "instances" collection of methods.</summary>
        public class InstancesResource
        {
            private const string Resource = "instances";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public InstancesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                BackupOperations = new BackupOperationsResource(service);
                Backups = new BackupsResource(service);
                DatabaseOperations = new DatabaseOperationsResource(service);
                Databases = new DatabasesResource(service);
                Operations = new OperationsResource(service);
            }

            /// <summary>Gets the BackupOperations resource.</summary>
            public virtual BackupOperationsResource BackupOperations { get; }

            /// <summary>The "backupOperations" collection of methods.</summary>
            public class BackupOperationsResource
            {
                private const string Resource = "backupOperations";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public BackupOperationsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Lists the backup long-running operations in the given instance. A backup operation has a name of the
                /// form `projects//instances//backups//operations/`. The long-running operation metadata field type
                /// `metadata.type_url` describes the type of the metadata. Operations returned include those that have
                /// completed/failed/canceled within the last 7 days, and pending operations. Operations returned are
                /// ordered by `operation.metadata.value.progress.start_time` in descending order starting from the most
                /// recently started operation.
                /// </summary>
                /// <param name="parent">
                /// Required. The instance of the backup operations. Values are of the form `projects//instances/`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>
                /// Lists the backup long-running operations in the given instance. A backup operation has a name of the
                /// form `projects//instances//backups//operations/`. The long-running operation metadata field type
                /// `metadata.type_url` describes the type of the metadata. Operations returned include those that have
                /// completed/failed/canceled within the last 7 days, and pending operations. Operations returned are
                /// ordered by `operation.metadata.value.progress.start_time` in descending order starting from the most
                /// recently started operation.
                /// </summary>
                public class ListRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.ListBackupOperationsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The instance of the backup operations. Values are of the form `projects//instances/`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// An expression that filters the list of returned backup operations. A filter expression consists
                    /// of a field name, a comparison operator, and a value for filtering. The value must be a string, a
                    /// number, or a boolean. The comparison operator must be one of: `&amp;lt;`, `&amp;gt;`,
                    /// `&amp;lt;=`, `&amp;gt;=`, `!=`, `=`, or `:`. Colon `:` is the contains operator. Filter rules
                    /// are not case sensitive. The following fields in the operation are eligible for filtering: *
                    /// `name` - The name of the long-running operation * `done` - False if the operation is in
                    /// progress, else true. * `metadata.@type` - the type of metadata. For example, the type string for
                    /// CreateBackupMetadata is
                    /// `type.googleapis.com/google.spanner.admin.database.v1.CreateBackupMetadata`. * `metadata.` - any
                    /// field in metadata.value. * `error` - Error associated with the long-running operation. *
                    /// `response.@type` - the type of response. * `response.` - any field in response.value. You can
                    /// combine multiple expressions by enclosing each expression in parentheses. By default,
                    /// expressions are combined with AND logic, but you can specify AND, OR, and NOT logic explicitly.
                    /// Here are a few examples: * `done:true` - The operation is complete. * `metadata.database:prod` -
                    /// The database the backup was taken from has a name containing the string "prod". *
                    /// `(metadata.@type=type.googleapis.com/google.spanner.admin.database.v1.CreateBackupMetadata) AND`
                    /// \ `(metadata.name:howl) AND` \ `(metadata.progress.start_time &amp;lt; \"2018-03-28T14:50:00Z\")
                    /// AND` \ `(error:*)` - Returns operations where: * The operation's metadata type is
                    /// CreateBackupMetadata. * The backup name contains the string "howl". * The operation started
                    /// before 2018-03-28T14:50:00Z. * The operation resulted in an error.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Number of operations to be returned in the response. If 0 or less, defaults to the server's
                    /// maximum allowed page size.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// If non-empty, `page_token` should contain a next_page_token from a previous
                    /// ListBackupOperationsResponse to the same `parent` and with the same `filter`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/backupOperations";

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
                            Pattern = @"^projects/[^/]+/instances/[^/]+$",
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

            /// <summary>Gets the Backups resource.</summary>
            public virtual BackupsResource Backups { get; }

            /// <summary>The "backups" collection of methods.</summary>
            public class BackupsResource
            {
                private const string Resource = "backups";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public BackupsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Operations = new OperationsResource(service);
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
                    /// cancel the operation, but success is not guaranteed. If the server doesn't support this method,
                    /// it returns `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other
                    /// methods to check whether the cancellation succeeded or whether the operation completed despite
                    /// cancellation. On successful cancellation, the operation is not deleted; instead, it becomes an
                    /// operation with an Operation.error value with a google.rpc.Status.code of 1, corresponding to
                    /// `Code.CANCELLED`.
                    /// </summary>
                    /// <param name="name">The name of the operation resource to be cancelled.</param>
                    public virtual CancelRequest Cancel(string name)
                    {
                        return new CancelRequest(service, name);
                    }

                    /// <summary>
                    /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to
                    /// cancel the operation, but success is not guaranteed. If the server doesn't support this method,
                    /// it returns `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other
                    /// methods to check whether the cancellation succeeded or whether the operation completed despite
                    /// cancellation. On successful cancellation, the operation is not deleted; instead, it becomes an
                    /// operation with an Operation.error value with a google.rpc.Status.code of 1, corresponding to
                    /// `Code.CANCELLED`.
                    /// </summary>
                    public class CancelRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.Empty>
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
                                Pattern = @"^projects/[^/]+/instances/[^/]+/backups/[^/]+/operations/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Deletes a long-running operation. This method indicates that the client is no longer interested
                    /// in the operation result. It does not cancel the operation. If the server doesn't support this
                    /// method, it returns `google.rpc.Code.UNIMPLEMENTED`.
                    /// </summary>
                    /// <param name="name">The name of the operation resource to be deleted.</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>
                    /// Deletes a long-running operation. This method indicates that the client is no longer interested
                    /// in the operation result. It does not cancel the operation. If the server doesn't support this
                    /// method, it returns `google.rpc.Code.UNIMPLEMENTED`.
                    /// </summary>
                    public class DeleteRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.Empty>
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
                                Pattern = @"^projects/[^/]+/instances/[^/]+/backups/[^/]+/operations/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Gets the latest state of a long-running operation. Clients can use this method to poll the
                    /// operation result at intervals as recommended by the API service.
                    /// </summary>
                    /// <param name="name">The name of the operation resource.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>
                    /// Gets the latest state of a long-running operation. Clients can use this method to poll the
                    /// operation result at intervals as recommended by the API service.
                    /// </summary>
                    public class GetRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.Operation>
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
                                Pattern = @"^projects/[^/]+/instances/[^/]+/backups/[^/]+/operations/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Lists operations that match the specified filter in the request. If the server doesn't support
                    /// this method, it returns `UNIMPLEMENTED`. NOTE: the `name` binding allows API services to
                    /// override the binding to use different resource name schemes, such as `users/*/operations`. To
                    /// override the binding, API services can add a binding such as `"/v1/{name=users/*}/operations"`
                    /// to their service configuration. For backwards compatibility, the default name includes the
                    /// operations collection id, however overriding users must ensure the name binding is the parent
                    /// resource, without the operations collection id.
                    /// </summary>
                    /// <param name="name">The name of the operation's parent resource.</param>
                    public virtual ListRequest List(string name)
                    {
                        return new ListRequest(service, name);
                    }

                    /// <summary>
                    /// Lists operations that match the specified filter in the request. If the server doesn't support
                    /// this method, it returns `UNIMPLEMENTED`. NOTE: the `name` binding allows API services to
                    /// override the binding to use different resource name schemes, such as `users/*/operations`. To
                    /// override the binding, API services can add a binding such as `"/v1/{name=users/*}/operations"`
                    /// to their service configuration. For backwards compatibility, the default name includes the
                    /// operations collection id, however overriding users must ensure the name binding is the parent
                    /// resource, without the operations collection id.
                    /// </summary>
                    public class ListRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.ListOperationsResponse>
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
                        public override string RestPath => "v1/{+name}";

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
                                Pattern = @"^projects/[^/]+/instances/[^/]+/backups/[^/]+/operations$",
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
                /// Starts creating a new Cloud Spanner Backup. The returned backup long-running operation will have a
                /// name of the format `projects//instances//backups//operations/` and can be used to track creation of
                /// the backup. The metadata field type is CreateBackupMetadata. The response field type is Backup, if
                /// successful. Cancelling the returned operation will stop the creation and delete the backup. There
                /// can be only one pending backup creation per database. Backup creation of different databases can run
                /// concurrently.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The name of the instance in which the backup will be created. This must be the same
                /// instance that contains the database the backup will be created from. The backup will be stored in
                /// the location(s) specified in the instance configuration of this instance. Values are of the form
                /// `projects//instances/`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.Spanner.v1.Data.Backup body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>
                /// Starts creating a new Cloud Spanner Backup. The returned backup long-running operation will have a
                /// name of the format `projects//instances//backups//operations/` and can be used to track creation of
                /// the backup. The metadata field type is CreateBackupMetadata. The response field type is Backup, if
                /// successful. Cancelling the returned operation will stop the creation and delete the backup. There
                /// can be only one pending backup creation per database. Backup creation of different databases can run
                /// concurrently.
                /// </summary>
                public class CreateRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Spanner.v1.Data.Backup body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the instance in which the backup will be created. This must be the same
                    /// instance that contains the database the backup will be created from. The backup will be stored
                    /// in the location(s) specified in the instance configuration of this instance. Values are of the
                    /// form `projects//instances/`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The id of the backup to be created. The `backup_id` appended to `parent` forms the
                    /// full backup name of the form `projects//instances//backups/`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("backupId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string BackupId { get; set; }

                    /// <summary>Required. The encryption type of the backup.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("encryptionConfig.encryptionType", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<EncryptionConfigEncryptionTypeEnum> EncryptionConfigEncryptionType { get; set; }

                    /// <summary>Required. The encryption type of the backup.</summary>
                    public enum EncryptionConfigEncryptionTypeEnum
                    {
                        /// <summary>Unspecified. Do not use.</summary>
                        [Google.Apis.Util.StringValueAttribute("ENCRYPTION_TYPE_UNSPECIFIED")]
                        ENCRYPTIONTYPEUNSPECIFIED = 0,

                        /// <summary>
                        /// Use the same encryption configuration as the database. This is the default option when
                        /// encryption_config is empty. For example, if the database is using
                        /// `Customer_Managed_Encryption`, the backup will be using the same Cloud KMS key as the
                        /// database.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("USE_DATABASE_ENCRYPTION")]
                        USEDATABASEENCRYPTION = 1,

                        /// <summary>Use Google default encryption.</summary>
                        [Google.Apis.Util.StringValueAttribute("GOOGLE_DEFAULT_ENCRYPTION")]
                        GOOGLEDEFAULTENCRYPTION = 2,

                        /// <summary>
                        /// Use customer managed encryption. If specified, `kms_key_name` must contain a valid Cloud KMS
                        /// key.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("CUSTOMER_MANAGED_ENCRYPTION")]
                        CUSTOMERMANAGEDENCRYPTION = 3,
                    }

                    /// <summary>
                    /// Optional. The Cloud KMS key that will be used to protect the backup. This field should be set
                    /// only when encryption_type is `CUSTOMER_MANAGED_ENCRYPTION`. Values are of the form
                    /// `projects//locations//keyRings//cryptoKeys/`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("encryptionConfig.kmsKeyName", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string EncryptionConfigKmsKeyName { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Spanner.v1.Data.Backup Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/backups";

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
                            Pattern = @"^projects/[^/]+/instances/[^/]+$",
                        });
                        RequestParameters.Add("backupId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "backupId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("encryptionConfig.encryptionType", new Google.Apis.Discovery.Parameter
                        {
                            Name = "encryptionConfig.encryptionType",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("encryptionConfig.kmsKeyName", new Google.Apis.Discovery.Parameter
                        {
                            Name = "encryptionConfig.kmsKeyName",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a pending or completed Backup.</summary>
                /// <param name="name">
                /// Required. Name of the backup to delete. Values are of the form `projects//instances//backups/`.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>Deletes a pending or completed Backup.</summary>
                public class DeleteRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the backup to delete. Values are of the form `projects//instances//backups/`.
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
                            Pattern = @"^projects/[^/]+/instances/[^/]+/backups/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets metadata on a pending or completed Backup.</summary>
                /// <param name="name">
                /// Required. Name of the backup. Values are of the form `projects//instances//backups/`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Gets metadata on a pending or completed Backup.</summary>
                public class GetRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.Backup>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the backup. Values are of the form `projects//instances//backups/`.
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
                            Pattern = @"^projects/[^/]+/instances/[^/]+/backups/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Gets the access control policy for a database or backup resource. Returns an empty policy if a
                /// database or backup exists but does not have a policy set. Authorization requires
                /// `spanner.databases.getIamPolicy` permission on resource. For backups, authorization requires
                /// `spanner.backups.getIamPolicy` permission on resource.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The Cloud Spanner resource for which the policy is being retrieved. The format is
                /// `projects//instances/` for instance resources and `projects//instances//databases/` for database
                /// resources.
                /// </param>
                public virtual GetIamPolicyRequest GetIamPolicy(Google.Apis.Spanner.v1.Data.GetIamPolicyRequest body, string resource)
                {
                    return new GetIamPolicyRequest(service, body, resource);
                }

                /// <summary>
                /// Gets the access control policy for a database or backup resource. Returns an empty policy if a
                /// database or backup exists but does not have a policy set. Authorization requires
                /// `spanner.databases.getIamPolicy` permission on resource. For backups, authorization requires
                /// `spanner.backups.getIamPolicy` permission on resource.
                /// </summary>
                public class GetIamPolicyRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.Policy>
                {
                    /// <summary>Constructs a new GetIamPolicy request.</summary>
                    public GetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.Spanner.v1.Data.GetIamPolicyRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The Cloud Spanner resource for which the policy is being retrieved. The format is
                    /// `projects//instances/` for instance resources and `projects//instances//databases/` for database
                    /// resources.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Spanner.v1.Data.GetIamPolicyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "getIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

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
                            Pattern = @"^projects/[^/]+/instances/[^/]+/backups/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists completed and pending backups. Backups returned are ordered by `create_time` in descending
                /// order, starting from the most recent `create_time`.
                /// </summary>
                /// <param name="parent">
                /// Required. The instance to list backups from. Values are of the form `projects//instances/`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>
                /// Lists completed and pending backups. Backups returned are ordered by `create_time` in descending
                /// order, starting from the most recent `create_time`.
                /// </summary>
                public class ListRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.ListBackupsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The instance to list backups from. Values are of the form `projects//instances/`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// An expression that filters the list of returned backups. A filter expression consists of a field
                    /// name, a comparison operator, and a value for filtering. The value must be a string, a number, or
                    /// a boolean. The comparison operator must be one of: `&amp;lt;`, `&amp;gt;`, `&amp;lt;=`,
                    /// `&amp;gt;=`, `!=`, `=`, or `:`. Colon `:` is the contains operator. Filter rules are not case
                    /// sensitive. The following fields in the Backup are eligible for filtering: * `name` * `database`
                    /// * `state` * `create_time` (and values are of the format YYYY-MM-DDTHH:MM:SSZ) * `expire_time`
                    /// (and values are of the format YYYY-MM-DDTHH:MM:SSZ) * `version_time` (and values are of the
                    /// format YYYY-MM-DDTHH:MM:SSZ) * `size_bytes` You can combine multiple expressions by enclosing
                    /// each expression in parentheses. By default, expressions are combined with AND logic, but you can
                    /// specify AND, OR, and NOT logic explicitly. Here are a few examples: * `name:Howl` - The backup's
                    /// name contains the string "howl". * `database:prod` - The database's name contains the string
                    /// "prod". * `state:CREATING` - The backup is pending creation. * `state:READY` - The backup is
                    /// fully created and ready for use. * `(name:howl) AND (create_time &amp;lt;
                    /// \"2018-03-28T14:50:00Z\")` - The backup name contains the string "howl" and `create_time` of the
                    /// backup is before 2018-03-28T14:50:00Z. * `expire_time &amp;lt; \"2018-03-28T14:50:00Z\"` - The
                    /// backup `expire_time` is before 2018-03-28T14:50:00Z. * `size_bytes &amp;gt; 10000000000` - The
                    /// backup's size is greater than 10GB
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Number of backups to be returned in the response. If 0 or less, defaults to the server's maximum
                    /// allowed page size.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// If non-empty, `page_token` should contain a next_page_token from a previous ListBackupsResponse
                    /// to the same `parent` and with the same `filter`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/backups";

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
                            Pattern = @"^projects/[^/]+/instances/[^/]+$",
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

                /// <summary>Updates a pending or completed Backup.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Output only for the CreateBackup operation. Required for the UpdateBackup operation. A globally
                /// unique identifier for the backup which cannot be changed. Values are of the form
                /// `projects//instances//backups/a-z*[a-z0-9]` The final segment of the name must be between 2 and 60
                /// characters in length. The backup is stored in the location(s) specified in the instance
                /// configuration of the instance containing the backup, identified by the prefix of the backup name of
                /// the form `projects//instances/`.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.Spanner.v1.Data.Backup body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>Updates a pending or completed Backup.</summary>
                public class PatchRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.Backup>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Spanner.v1.Data.Backup body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Output only for the CreateBackup operation. Required for the UpdateBackup operation. A globally
                    /// unique identifier for the backup which cannot be changed. Values are of the form
                    /// `projects//instances//backups/a-z*[a-z0-9]` The final segment of the name must be between 2 and
                    /// 60 characters in length. The backup is stored in the location(s) specified in the instance
                    /// configuration of the instance containing the backup, identified by the prefix of the backup name
                    /// of the form `projects//instances/`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Required. A mask specifying which fields (e.g. `expire_time`) in the Backup resource should be
                    /// updated. This mask is relative to the Backup resource, not to the request message. The field
                    /// mask must always be specified; this prevents any future fields from being erased accidentally by
                    /// clients that do not know about them.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Spanner.v1.Data.Backup Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/instances/[^/]+/backups/[^/]+$",
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
                /// Sets the access control policy on a database or backup resource. Replaces any existing policy.
                /// Authorization requires `spanner.databases.setIamPolicy` permission on resource. For backups,
                /// authorization requires `spanner.backups.setIamPolicy` permission on resource.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The Cloud Spanner resource for which the policy is being set. The format is
                /// `projects//instances/` for instance resources and `projects//instances//databases/` for databases
                /// resources.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.Spanner.v1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on a database or backup resource. Replaces any existing policy.
                /// Authorization requires `spanner.databases.setIamPolicy` permission on resource. For backups,
                /// authorization requires `spanner.backups.setIamPolicy` permission on resource.
                /// </summary>
                public class SetIamPolicyRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.Spanner.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The Cloud Spanner resource for which the policy is being set. The format is
                    /// `projects//instances/` for instance resources and `projects//instances//databases/` for
                    /// databases resources.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Spanner.v1.Data.SetIamPolicyRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/instances/[^/]+/backups/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Returns permissions that the caller has on the specified database or backup resource. Attempting
                /// this RPC on a non-existent Cloud Spanner database will result in a NOT_FOUND error if the user has
                /// `spanner.databases.list` permission on the containing Cloud Spanner instance. Otherwise returns an
                /// empty set of permissions. Calling this method on a backup that does not exist will result in a
                /// NOT_FOUND error if the user has `spanner.backups.list` permission on the containing instance.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The Cloud Spanner resource for which permissions are being tested. The format is
                /// `projects//instances/` for instance resources and `projects//instances//databases/` for database
                /// resources.
                /// </param>
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.Spanner.v1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(service, body, resource);
                }

                /// <summary>
                /// Returns permissions that the caller has on the specified database or backup resource. Attempting
                /// this RPC on a non-existent Cloud Spanner database will result in a NOT_FOUND error if the user has
                /// `spanner.databases.list` permission on the containing Cloud Spanner instance. Otherwise returns an
                /// empty set of permissions. Calling this method on a backup that does not exist will result in a
                /// NOT_FOUND error if the user has `spanner.backups.list` permission on the containing instance.
                /// </summary>
                public class TestIamPermissionsRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.Spanner.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The Cloud Spanner resource for which permissions are being tested. The format is
                    /// `projects//instances/` for instance resources and `projects//instances//databases/` for database
                    /// resources.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Spanner.v1.Data.TestIamPermissionsRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/instances/[^/]+/backups/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the DatabaseOperations resource.</summary>
            public virtual DatabaseOperationsResource DatabaseOperations { get; }

            /// <summary>The "databaseOperations" collection of methods.</summary>
            public class DatabaseOperationsResource
            {
                private const string Resource = "databaseOperations";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public DatabaseOperationsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Lists database longrunning-operations. A database operation has a name of the form
                /// `projects//instances//databases//operations/`. The long-running operation metadata field type
                /// `metadata.type_url` describes the type of the metadata. Operations returned include those that have
                /// completed/failed/canceled within the last 7 days, and pending operations.
                /// </summary>
                /// <param name="parent">
                /// Required. The instance of the database operations. Values are of the form `projects//instances/`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>
                /// Lists database longrunning-operations. A database operation has a name of the form
                /// `projects//instances//databases//operations/`. The long-running operation metadata field type
                /// `metadata.type_url` describes the type of the metadata. Operations returned include those that have
                /// completed/failed/canceled within the last 7 days, and pending operations.
                /// </summary>
                public class ListRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.ListDatabaseOperationsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The instance of the database operations. Values are of the form
                    /// `projects//instances/`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// An expression that filters the list of returned operations. A filter expression consists of a
                    /// field name, a comparison operator, and a value for filtering. The value must be a string, a
                    /// number, or a boolean. The comparison operator must be one of: `&amp;lt;`, `&amp;gt;`,
                    /// `&amp;lt;=`, `&amp;gt;=`, `!=`, `=`, or `:`. Colon `:` is the contains operator. Filter rules
                    /// are not case sensitive. The following fields in the Operation are eligible for filtering: *
                    /// `name` - The name of the long-running operation * `done` - False if the operation is in
                    /// progress, else true. * `metadata.@type` - the type of metadata. For example, the type string for
                    /// RestoreDatabaseMetadata is
                    /// `type.googleapis.com/google.spanner.admin.database.v1.RestoreDatabaseMetadata`. * `metadata.` -
                    /// any field in metadata.value. * `error` - Error associated with the long-running operation. *
                    /// `response.@type` - the type of response. * `response.` - any field in response.value. You can
                    /// combine multiple expressions by enclosing each expression in parentheses. By default,
                    /// expressions are combined with AND logic. However, you can specify AND, OR, and NOT logic
                    /// explicitly. Here are a few examples: * `done:true` - The operation is complete. *
                    /// `(metadata.@type=type.googleapis.com/google.spanner.admin.database.v1.RestoreDatabaseMetadata)
                    /// AND` \ `(metadata.source_type:BACKUP) AND` \ `(metadata.backup_info.backup:backup_howl) AND` \
                    /// `(metadata.name:restored_howl) AND` \ `(metadata.progress.start_time &amp;lt;
                    /// \"2018-03-28T14:50:00Z\") AND` \ `(error:*)` - Return operations where: * The operation's
                    /// metadata type is RestoreDatabaseMetadata. * The database is restored from a backup. * The backup
                    /// name contains "backup_howl". * The restored database's name contains "restored_howl". * The
                    /// operation started before 2018-03-28T14:50:00Z. * The operation resulted in an error.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Number of operations to be returned in the response. If 0 or less, defaults to the server's
                    /// maximum allowed page size.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// If non-empty, `page_token` should contain a next_page_token from a previous
                    /// ListDatabaseOperationsResponse to the same `parent` and with the same `filter`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/databaseOperations";

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
                            Pattern = @"^projects/[^/]+/instances/[^/]+$",
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

            /// <summary>Gets the Databases resource.</summary>
            public virtual DatabasesResource Databases { get; }

            /// <summary>The "databases" collection of methods.</summary>
            public class DatabasesResource
            {
                private const string Resource = "databases";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public DatabasesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Operations = new OperationsResource(service);
                    Sessions = new SessionsResource(service);
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
                    /// cancel the operation, but success is not guaranteed. If the server doesn't support this method,
                    /// it returns `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other
                    /// methods to check whether the cancellation succeeded or whether the operation completed despite
                    /// cancellation. On successful cancellation, the operation is not deleted; instead, it becomes an
                    /// operation with an Operation.error value with a google.rpc.Status.code of 1, corresponding to
                    /// `Code.CANCELLED`.
                    /// </summary>
                    /// <param name="name">The name of the operation resource to be cancelled.</param>
                    public virtual CancelRequest Cancel(string name)
                    {
                        return new CancelRequest(service, name);
                    }

                    /// <summary>
                    /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to
                    /// cancel the operation, but success is not guaranteed. If the server doesn't support this method,
                    /// it returns `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other
                    /// methods to check whether the cancellation succeeded or whether the operation completed despite
                    /// cancellation. On successful cancellation, the operation is not deleted; instead, it becomes an
                    /// operation with an Operation.error value with a google.rpc.Status.code of 1, corresponding to
                    /// `Code.CANCELLED`.
                    /// </summary>
                    public class CancelRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.Empty>
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
                                Pattern = @"^projects/[^/]+/instances/[^/]+/databases/[^/]+/operations/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Deletes a long-running operation. This method indicates that the client is no longer interested
                    /// in the operation result. It does not cancel the operation. If the server doesn't support this
                    /// method, it returns `google.rpc.Code.UNIMPLEMENTED`.
                    /// </summary>
                    /// <param name="name">The name of the operation resource to be deleted.</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>
                    /// Deletes a long-running operation. This method indicates that the client is no longer interested
                    /// in the operation result. It does not cancel the operation. If the server doesn't support this
                    /// method, it returns `google.rpc.Code.UNIMPLEMENTED`.
                    /// </summary>
                    public class DeleteRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.Empty>
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
                                Pattern = @"^projects/[^/]+/instances/[^/]+/databases/[^/]+/operations/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Gets the latest state of a long-running operation. Clients can use this method to poll the
                    /// operation result at intervals as recommended by the API service.
                    /// </summary>
                    /// <param name="name">The name of the operation resource.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>
                    /// Gets the latest state of a long-running operation. Clients can use this method to poll the
                    /// operation result at intervals as recommended by the API service.
                    /// </summary>
                    public class GetRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.Operation>
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
                                Pattern = @"^projects/[^/]+/instances/[^/]+/databases/[^/]+/operations/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Lists operations that match the specified filter in the request. If the server doesn't support
                    /// this method, it returns `UNIMPLEMENTED`. NOTE: the `name` binding allows API services to
                    /// override the binding to use different resource name schemes, such as `users/*/operations`. To
                    /// override the binding, API services can add a binding such as `"/v1/{name=users/*}/operations"`
                    /// to their service configuration. For backwards compatibility, the default name includes the
                    /// operations collection id, however overriding users must ensure the name binding is the parent
                    /// resource, without the operations collection id.
                    /// </summary>
                    /// <param name="name">The name of the operation's parent resource.</param>
                    public virtual ListRequest List(string name)
                    {
                        return new ListRequest(service, name);
                    }

                    /// <summary>
                    /// Lists operations that match the specified filter in the request. If the server doesn't support
                    /// this method, it returns `UNIMPLEMENTED`. NOTE: the `name` binding allows API services to
                    /// override the binding to use different resource name schemes, such as `users/*/operations`. To
                    /// override the binding, API services can add a binding such as `"/v1/{name=users/*}/operations"`
                    /// to their service configuration. For backwards compatibility, the default name includes the
                    /// operations collection id, however overriding users must ensure the name binding is the parent
                    /// resource, without the operations collection id.
                    /// </summary>
                    public class ListRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.ListOperationsResponse>
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
                        public override string RestPath => "v1/{+name}";

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
                                Pattern = @"^projects/[^/]+/instances/[^/]+/databases/[^/]+/operations$",
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

                /// <summary>Gets the Sessions resource.</summary>
                public virtual SessionsResource Sessions { get; }

                /// <summary>The "sessions" collection of methods.</summary>
                public class SessionsResource
                {
                    private const string Resource = "sessions";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public SessionsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Creates multiple new sessions. This API can be used to initialize a session cache on the
                    /// clients. See https://goo.gl/TgSFN2 for best practices on session cache management.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="database">Required. The database in which the new sessions are created.</param>
                    public virtual BatchCreateRequest BatchCreate(Google.Apis.Spanner.v1.Data.BatchCreateSessionsRequest body, string database)
                    {
                        return new BatchCreateRequest(service, body, database);
                    }

                    /// <summary>
                    /// Creates multiple new sessions. This API can be used to initialize a session cache on the
                    /// clients. See https://goo.gl/TgSFN2 for best practices on session cache management.
                    /// </summary>
                    public class BatchCreateRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.BatchCreateSessionsResponse>
                    {
                        /// <summary>Constructs a new BatchCreate request.</summary>
                        public BatchCreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Spanner.v1.Data.BatchCreateSessionsRequest body, string database) : base(service)
                        {
                            Database = database;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The database in which the new sessions are created.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("database", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Database { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Spanner.v1.Data.BatchCreateSessionsRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "batchCreate";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+database}/sessions:batchCreate";

                        /// <summary>Initializes BatchCreate parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("database", new Google.Apis.Discovery.Parameter
                            {
                                Name = "database",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/instances/[^/]+/databases/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Begins a new transaction. This step can often be skipped: Read, ExecuteSql and Commit can begin
                    /// a new transaction as a side-effect.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="session">Required. The session in which the transaction runs.</param>
                    public virtual BeginTransactionRequest BeginTransaction(Google.Apis.Spanner.v1.Data.BeginTransactionRequest body, string session)
                    {
                        return new BeginTransactionRequest(service, body, session);
                    }

                    /// <summary>
                    /// Begins a new transaction. This step can often be skipped: Read, ExecuteSql and Commit can begin
                    /// a new transaction as a side-effect.
                    /// </summary>
                    public class BeginTransactionRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.Transaction>
                    {
                        /// <summary>Constructs a new BeginTransaction request.</summary>
                        public BeginTransactionRequest(Google.Apis.Services.IClientService service, Google.Apis.Spanner.v1.Data.BeginTransactionRequest body, string session) : base(service)
                        {
                            Session = session;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The session in which the transaction runs.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("session", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Session { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Spanner.v1.Data.BeginTransactionRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "beginTransaction";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+session}:beginTransaction";

                        /// <summary>Initializes BeginTransaction parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("session", new Google.Apis.Discovery.Parameter
                            {
                                Name = "session",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/instances/[^/]+/databases/[^/]+/sessions/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Commits a transaction. The request includes the mutations to be applied to rows in the database.
                    /// `Commit` might return an `ABORTED` error. This can occur at any time; commonly, the cause is
                    /// conflicts with concurrent transactions. However, it can also happen for a variety of other
                    /// reasons. If `Commit` returns `ABORTED`, the caller should re-attempt the transaction from the
                    /// beginning, re-using the same session. On very rare occasions, `Commit` might return `UNKNOWN`.
                    /// This can happen, for example, if the client job experiences a 1+ hour networking failure. At
                    /// that point, Cloud Spanner has lost track of the transaction outcome and we recommend that you
                    /// perform another read from the database to see the state of things as they are now.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="session">
                    /// Required. The session in which the transaction to be committed is running.
                    /// </param>
                    public virtual CommitRequest Commit(Google.Apis.Spanner.v1.Data.CommitRequest body, string session)
                    {
                        return new CommitRequest(service, body, session);
                    }

                    /// <summary>
                    /// Commits a transaction. The request includes the mutations to be applied to rows in the database.
                    /// `Commit` might return an `ABORTED` error. This can occur at any time; commonly, the cause is
                    /// conflicts with concurrent transactions. However, it can also happen for a variety of other
                    /// reasons. If `Commit` returns `ABORTED`, the caller should re-attempt the transaction from the
                    /// beginning, re-using the same session. On very rare occasions, `Commit` might return `UNKNOWN`.
                    /// This can happen, for example, if the client job experiences a 1+ hour networking failure. At
                    /// that point, Cloud Spanner has lost track of the transaction outcome and we recommend that you
                    /// perform another read from the database to see the state of things as they are now.
                    /// </summary>
                    public class CommitRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.CommitResponse>
                    {
                        /// <summary>Constructs a new Commit request.</summary>
                        public CommitRequest(Google.Apis.Services.IClientService service, Google.Apis.Spanner.v1.Data.CommitRequest body, string session) : base(service)
                        {
                            Session = session;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The session in which the transaction to be committed is running.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("session", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Session { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Spanner.v1.Data.CommitRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "commit";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+session}:commit";

                        /// <summary>Initializes Commit parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("session", new Google.Apis.Discovery.Parameter
                            {
                                Name = "session",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/instances/[^/]+/databases/[^/]+/sessions/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Creates a new session. A session can be used to perform transactions that read and/or modify
                    /// data in a Cloud Spanner database. Sessions are meant to be reused for many consecutive
                    /// transactions. Sessions can only execute one transaction at a time. To execute multiple
                    /// concurrent read-write/write-only transactions, create multiple sessions. Note that standalone
                    /// reads and queries use a transaction internally, and count toward the one transaction limit.
                    /// Active sessions use additional server resources, so it is a good idea to delete idle and
                    /// unneeded sessions. Aside from explicit deletes, Cloud Spanner may delete sessions for which no
                    /// operations are sent for more than an hour. If a session is deleted, requests to it return
                    /// `NOT_FOUND`. Idle sessions can be kept alive by sending a trivial SQL query periodically, e.g.,
                    /// `"SELECT 1"`.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="database">Required. The database in which the new session is created.</param>
                    public virtual CreateRequest Create(Google.Apis.Spanner.v1.Data.CreateSessionRequest body, string database)
                    {
                        return new CreateRequest(service, body, database);
                    }

                    /// <summary>
                    /// Creates a new session. A session can be used to perform transactions that read and/or modify
                    /// data in a Cloud Spanner database. Sessions are meant to be reused for many consecutive
                    /// transactions. Sessions can only execute one transaction at a time. To execute multiple
                    /// concurrent read-write/write-only transactions, create multiple sessions. Note that standalone
                    /// reads and queries use a transaction internally, and count toward the one transaction limit.
                    /// Active sessions use additional server resources, so it is a good idea to delete idle and
                    /// unneeded sessions. Aside from explicit deletes, Cloud Spanner may delete sessions for which no
                    /// operations are sent for more than an hour. If a session is deleted, requests to it return
                    /// `NOT_FOUND`. Idle sessions can be kept alive by sending a trivial SQL query periodically, e.g.,
                    /// `"SELECT 1"`.
                    /// </summary>
                    public class CreateRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.Session>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Spanner.v1.Data.CreateSessionRequest body, string database) : base(service)
                        {
                            Database = database;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The database in which the new session is created.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("database", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Database { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Spanner.v1.Data.CreateSessionRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+database}/sessions";

                        /// <summary>Initializes Create parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("database", new Google.Apis.Discovery.Parameter
                            {
                                Name = "database",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/instances/[^/]+/databases/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Ends a session, releasing server resources associated with it. This will asynchronously trigger
                    /// cancellation of any operations that are running with this session.
                    /// </summary>
                    /// <param name="name">Required. The name of the session to delete.</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>
                    /// Ends a session, releasing server resources associated with it. This will asynchronously trigger
                    /// cancellation of any operations that are running with this session.
                    /// </summary>
                    public class DeleteRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the session to delete.</summary>
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
                                Pattern = @"^projects/[^/]+/instances/[^/]+/databases/[^/]+/sessions/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Executes a batch of SQL DML statements. This method allows many statements to be run with lower
                    /// latency than submitting them sequentially with ExecuteSql. Statements are executed in sequential
                    /// order. A request can succeed even if a statement fails. The ExecuteBatchDmlResponse.status field
                    /// in the response provides information about the statement that failed. Clients must inspect this
                    /// field to determine whether an error occurred. Execution stops after the first failed statement;
                    /// the remaining statements are not executed.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="session">
                    /// Required. The session in which the DML statements should be performed.
                    /// </param>
                    public virtual ExecuteBatchDmlRequest ExecuteBatchDml(Google.Apis.Spanner.v1.Data.ExecuteBatchDmlRequest body, string session)
                    {
                        return new ExecuteBatchDmlRequest(service, body, session);
                    }

                    /// <summary>
                    /// Executes a batch of SQL DML statements. This method allows many statements to be run with lower
                    /// latency than submitting them sequentially with ExecuteSql. Statements are executed in sequential
                    /// order. A request can succeed even if a statement fails. The ExecuteBatchDmlResponse.status field
                    /// in the response provides information about the statement that failed. Clients must inspect this
                    /// field to determine whether an error occurred. Execution stops after the first failed statement;
                    /// the remaining statements are not executed.
                    /// </summary>
                    public class ExecuteBatchDmlRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.ExecuteBatchDmlResponse>
                    {
                        /// <summary>Constructs a new ExecuteBatchDml request.</summary>
                        public ExecuteBatchDmlRequest(Google.Apis.Services.IClientService service, Google.Apis.Spanner.v1.Data.ExecuteBatchDmlRequest body, string session) : base(service)
                        {
                            Session = session;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The session in which the DML statements should be performed.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("session", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Session { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Spanner.v1.Data.ExecuteBatchDmlRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "executeBatchDml";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+session}:executeBatchDml";

                        /// <summary>Initializes ExecuteBatchDml parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("session", new Google.Apis.Discovery.Parameter
                            {
                                Name = "session",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/instances/[^/]+/databases/[^/]+/sessions/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Executes an SQL statement, returning all results in a single reply. This method cannot be used
                    /// to return a result set larger than 10 MiB; if the query yields more data than that, the query
                    /// fails with a `FAILED_PRECONDITION` error. Operations inside read-write transactions might return
                    /// `ABORTED`. If this occurs, the application should restart the transaction from the beginning.
                    /// See Transaction for more details. Larger result sets can be fetched in streaming fashion by
                    /// calling ExecuteStreamingSql instead.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="session">Required. The session in which the SQL query should be performed.</param>
                    public virtual ExecuteSqlRequest ExecuteSql(Google.Apis.Spanner.v1.Data.ExecuteSqlRequest body, string session)
                    {
                        return new ExecuteSqlRequest(service, body, session);
                    }

                    /// <summary>
                    /// Executes an SQL statement, returning all results in a single reply. This method cannot be used
                    /// to return a result set larger than 10 MiB; if the query yields more data than that, the query
                    /// fails with a `FAILED_PRECONDITION` error. Operations inside read-write transactions might return
                    /// `ABORTED`. If this occurs, the application should restart the transaction from the beginning.
                    /// See Transaction for more details. Larger result sets can be fetched in streaming fashion by
                    /// calling ExecuteStreamingSql instead.
                    /// </summary>
                    public class ExecuteSqlRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.ResultSet>
                    {
                        /// <summary>Constructs a new ExecuteSql request.</summary>
                        public ExecuteSqlRequest(Google.Apis.Services.IClientService service, Google.Apis.Spanner.v1.Data.ExecuteSqlRequest body, string session) : base(service)
                        {
                            Session = session;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The session in which the SQL query should be performed.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("session", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Session { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Spanner.v1.Data.ExecuteSqlRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "executeSql";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+session}:executeSql";

                        /// <summary>Initializes ExecuteSql parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("session", new Google.Apis.Discovery.Parameter
                            {
                                Name = "session",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/instances/[^/]+/databases/[^/]+/sessions/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Like ExecuteSql, except returns the result set as a stream. Unlike ExecuteSql, there is no limit
                    /// on the size of the returned result set. However, no individual row in the result set can exceed
                    /// 100 MiB, and no column value can exceed 10 MiB.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="session">Required. The session in which the SQL query should be performed.</param>
                    public virtual ExecuteStreamingSqlRequest ExecuteStreamingSql(Google.Apis.Spanner.v1.Data.ExecuteSqlRequest body, string session)
                    {
                        return new ExecuteStreamingSqlRequest(service, body, session);
                    }

                    /// <summary>
                    /// Like ExecuteSql, except returns the result set as a stream. Unlike ExecuteSql, there is no limit
                    /// on the size of the returned result set. However, no individual row in the result set can exceed
                    /// 100 MiB, and no column value can exceed 10 MiB.
                    /// </summary>
                    public class ExecuteStreamingSqlRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.PartialResultSet>
                    {
                        /// <summary>Constructs a new ExecuteStreamingSql request.</summary>
                        public ExecuteStreamingSqlRequest(Google.Apis.Services.IClientService service, Google.Apis.Spanner.v1.Data.ExecuteSqlRequest body, string session) : base(service)
                        {
                            Session = session;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The session in which the SQL query should be performed.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("session", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Session { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Spanner.v1.Data.ExecuteSqlRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "executeStreamingSql";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+session}:executeStreamingSql";

                        /// <summary>Initializes ExecuteStreamingSql parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("session", new Google.Apis.Discovery.Parameter
                            {
                                Name = "session",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/instances/[^/]+/databases/[^/]+/sessions/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Gets a session. Returns `NOT_FOUND` if the session does not exist. This is mainly useful for
                    /// determining whether a session is still alive.
                    /// </summary>
                    /// <param name="name">Required. The name of the session to retrieve.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>
                    /// Gets a session. Returns `NOT_FOUND` if the session does not exist. This is mainly useful for
                    /// determining whether a session is still alive.
                    /// </summary>
                    public class GetRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.Session>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the session to retrieve.</summary>
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
                                Pattern = @"^projects/[^/]+/instances/[^/]+/databases/[^/]+/sessions/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists all sessions in a given database.</summary>
                    /// <param name="database">Required. The database in which to list sessions.</param>
                    public virtual ListRequest List(string database)
                    {
                        return new ListRequest(service, database);
                    }

                    /// <summary>Lists all sessions in a given database.</summary>
                    public class ListRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.ListSessionsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string database) : base(service)
                        {
                            Database = database;
                            InitParameters();
                        }

                        /// <summary>Required. The database in which to list sessions.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("database", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Database { get; private set; }

                        /// <summary>
                        /// An expression for filtering the results of the request. Filter rules are case insensitive.
                        /// The fields eligible for filtering are: * `labels.key` where key is the name of a label Some
                        /// examples of using filters are: * `labels.env:*` --&amp;gt; The session has the label "env".
                        /// * `labels.env:dev` --&amp;gt; The session has the label "env" and the value of the label
                        /// contains the string "dev".
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// Number of sessions to be returned in the response. If 0 or less, defaults to the server's
                        /// maximum allowed page size.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// If non-empty, `page_token` should contain a next_page_token from a previous
                        /// ListSessionsResponse.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+database}/sessions";

                        /// <summary>Initializes List parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("database", new Google.Apis.Discovery.Parameter
                            {
                                Name = "database",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/instances/[^/]+/databases/[^/]+$",
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
                    /// Creates a set of partition tokens that can be used to execute a query operation in parallel.
                    /// Each of the returned partition tokens can be used by ExecuteStreamingSql to specify a subset of
                    /// the query result to read. The same session and read-only transaction must be used by the
                    /// PartitionQueryRequest used to create the partition tokens and the ExecuteSqlRequests that use
                    /// the partition tokens. Partition tokens become invalid when the session used to create them is
                    /// deleted, is idle for too long, begins a new transaction, or becomes too old. When any of these
                    /// happen, it is not possible to resume the query, and the whole operation must be restarted from
                    /// the beginning.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="session">Required. The session used to create the partitions.</param>
                    public virtual PartitionQueryRequest PartitionQuery(Google.Apis.Spanner.v1.Data.PartitionQueryRequest body, string session)
                    {
                        return new PartitionQueryRequest(service, body, session);
                    }

                    /// <summary>
                    /// Creates a set of partition tokens that can be used to execute a query operation in parallel.
                    /// Each of the returned partition tokens can be used by ExecuteStreamingSql to specify a subset of
                    /// the query result to read. The same session and read-only transaction must be used by the
                    /// PartitionQueryRequest used to create the partition tokens and the ExecuteSqlRequests that use
                    /// the partition tokens. Partition tokens become invalid when the session used to create them is
                    /// deleted, is idle for too long, begins a new transaction, or becomes too old. When any of these
                    /// happen, it is not possible to resume the query, and the whole operation must be restarted from
                    /// the beginning.
                    /// </summary>
                    public class PartitionQueryRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.PartitionResponse>
                    {
                        /// <summary>Constructs a new PartitionQuery request.</summary>
                        public PartitionQueryRequest(Google.Apis.Services.IClientService service, Google.Apis.Spanner.v1.Data.PartitionQueryRequest body, string session) : base(service)
                        {
                            Session = session;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The session used to create the partitions.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("session", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Session { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Spanner.v1.Data.PartitionQueryRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "partitionQuery";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+session}:partitionQuery";

                        /// <summary>Initializes PartitionQuery parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("session", new Google.Apis.Discovery.Parameter
                            {
                                Name = "session",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/instances/[^/]+/databases/[^/]+/sessions/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Creates a set of partition tokens that can be used to execute a read operation in parallel. Each
                    /// of the returned partition tokens can be used by StreamingRead to specify a subset of the read
                    /// result to read. The same session and read-only transaction must be used by the
                    /// PartitionReadRequest used to create the partition tokens and the ReadRequests that use the
                    /// partition tokens. There are no ordering guarantees on rows returned among the returned partition
                    /// tokens, or even within each individual StreamingRead call issued with a partition_token.
                    /// Partition tokens become invalid when the session used to create them is deleted, is idle for too
                    /// long, begins a new transaction, or becomes too old. When any of these happen, it is not possible
                    /// to resume the read, and the whole operation must be restarted from the beginning.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="session">Required. The session used to create the partitions.</param>
                    public virtual PartitionReadRequest PartitionRead(Google.Apis.Spanner.v1.Data.PartitionReadRequest body, string session)
                    {
                        return new PartitionReadRequest(service, body, session);
                    }

                    /// <summary>
                    /// Creates a set of partition tokens that can be used to execute a read operation in parallel. Each
                    /// of the returned partition tokens can be used by StreamingRead to specify a subset of the read
                    /// result to read. The same session and read-only transaction must be used by the
                    /// PartitionReadRequest used to create the partition tokens and the ReadRequests that use the
                    /// partition tokens. There are no ordering guarantees on rows returned among the returned partition
                    /// tokens, or even within each individual StreamingRead call issued with a partition_token.
                    /// Partition tokens become invalid when the session used to create them is deleted, is idle for too
                    /// long, begins a new transaction, or becomes too old. When any of these happen, it is not possible
                    /// to resume the read, and the whole operation must be restarted from the beginning.
                    /// </summary>
                    public class PartitionReadRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.PartitionResponse>
                    {
                        /// <summary>Constructs a new PartitionRead request.</summary>
                        public PartitionReadRequest(Google.Apis.Services.IClientService service, Google.Apis.Spanner.v1.Data.PartitionReadRequest body, string session) : base(service)
                        {
                            Session = session;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The session used to create the partitions.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("session", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Session { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Spanner.v1.Data.PartitionReadRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "partitionRead";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+session}:partitionRead";

                        /// <summary>Initializes PartitionRead parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("session", new Google.Apis.Discovery.Parameter
                            {
                                Name = "session",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/instances/[^/]+/databases/[^/]+/sessions/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Reads rows from the database using key lookups and scans, as a simple key/value style
                    /// alternative to ExecuteSql. This method cannot be used to return a result set larger than 10 MiB;
                    /// if the read matches more data than that, the read fails with a `FAILED_PRECONDITION` error.
                    /// Reads inside read-write transactions might return `ABORTED`. If this occurs, the application
                    /// should restart the transaction from the beginning. See Transaction for more details. Larger
                    /// result sets can be yielded in streaming fashion by calling StreamingRead instead.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="session">Required. The session in which the read should be performed.</param>
                    public virtual ReadRequest Read(Google.Apis.Spanner.v1.Data.ReadRequest body, string session)
                    {
                        return new ReadRequest(service, body, session);
                    }

                    /// <summary>
                    /// Reads rows from the database using key lookups and scans, as a simple key/value style
                    /// alternative to ExecuteSql. This method cannot be used to return a result set larger than 10 MiB;
                    /// if the read matches more data than that, the read fails with a `FAILED_PRECONDITION` error.
                    /// Reads inside read-write transactions might return `ABORTED`. If this occurs, the application
                    /// should restart the transaction from the beginning. See Transaction for more details. Larger
                    /// result sets can be yielded in streaming fashion by calling StreamingRead instead.
                    /// </summary>
                    public class ReadRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.ResultSet>
                    {
                        /// <summary>Constructs a new Read request.</summary>
                        public ReadRequest(Google.Apis.Services.IClientService service, Google.Apis.Spanner.v1.Data.ReadRequest body, string session) : base(service)
                        {
                            Session = session;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The session in which the read should be performed.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("session", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Session { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Spanner.v1.Data.ReadRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "read";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+session}:read";

                        /// <summary>Initializes Read parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("session", new Google.Apis.Discovery.Parameter
                            {
                                Name = "session",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/instances/[^/]+/databases/[^/]+/sessions/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Rolls back a transaction, releasing any locks it holds. It is a good idea to call this for any
                    /// transaction that includes one or more Read or ExecuteSql requests and ultimately decides not to
                    /// commit. `Rollback` returns `OK` if it successfully aborts the transaction, the transaction was
                    /// already aborted, or the transaction is not found. `Rollback` never returns `ABORTED`.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="session">
                    /// Required. The session in which the transaction to roll back is running.
                    /// </param>
                    public virtual RollbackRequest Rollback(Google.Apis.Spanner.v1.Data.RollbackRequest body, string session)
                    {
                        return new RollbackRequest(service, body, session);
                    }

                    /// <summary>
                    /// Rolls back a transaction, releasing any locks it holds. It is a good idea to call this for any
                    /// transaction that includes one or more Read or ExecuteSql requests and ultimately decides not to
                    /// commit. `Rollback` returns `OK` if it successfully aborts the transaction, the transaction was
                    /// already aborted, or the transaction is not found. `Rollback` never returns `ABORTED`.
                    /// </summary>
                    public class RollbackRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.Empty>
                    {
                        /// <summary>Constructs a new Rollback request.</summary>
                        public RollbackRequest(Google.Apis.Services.IClientService service, Google.Apis.Spanner.v1.Data.RollbackRequest body, string session) : base(service)
                        {
                            Session = session;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The session in which the transaction to roll back is running.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("session", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Session { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Spanner.v1.Data.RollbackRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "rollback";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+session}:rollback";

                        /// <summary>Initializes Rollback parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("session", new Google.Apis.Discovery.Parameter
                            {
                                Name = "session",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/instances/[^/]+/databases/[^/]+/sessions/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Like Read, except returns the result set as a stream. Unlike Read, there is no limit on the size
                    /// of the returned result set. However, no individual row in the result set can exceed 100 MiB, and
                    /// no column value can exceed 10 MiB.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="session">Required. The session in which the read should be performed.</param>
                    public virtual StreamingReadRequest StreamingRead(Google.Apis.Spanner.v1.Data.ReadRequest body, string session)
                    {
                        return new StreamingReadRequest(service, body, session);
                    }

                    /// <summary>
                    /// Like Read, except returns the result set as a stream. Unlike Read, there is no limit on the size
                    /// of the returned result set. However, no individual row in the result set can exceed 100 MiB, and
                    /// no column value can exceed 10 MiB.
                    /// </summary>
                    public class StreamingReadRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.PartialResultSet>
                    {
                        /// <summary>Constructs a new StreamingRead request.</summary>
                        public StreamingReadRequest(Google.Apis.Services.IClientService service, Google.Apis.Spanner.v1.Data.ReadRequest body, string session) : base(service)
                        {
                            Session = session;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The session in which the read should be performed.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("session", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Session { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Spanner.v1.Data.ReadRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "streamingRead";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+session}:streamingRead";

                        /// <summary>Initializes StreamingRead parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("session", new Google.Apis.Discovery.Parameter
                            {
                                Name = "session",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/instances/[^/]+/databases/[^/]+/sessions/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>
                /// Creates a new Cloud Spanner database and starts to prepare it for serving. The returned long-running
                /// operation will have a name of the format `/operations/` and can be used to track preparation of the
                /// database. The metadata field type is CreateDatabaseMetadata. The response field type is Database, if
                /// successful.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The name of the instance that will serve the new database. Values are of the form
                /// `projects//instances/`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.Spanner.v1.Data.CreateDatabaseRequest body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>
                /// Creates a new Cloud Spanner database and starts to prepare it for serving. The returned long-running
                /// operation will have a name of the format `/operations/` and can be used to track preparation of the
                /// database. The metadata field type is CreateDatabaseMetadata. The response field type is Database, if
                /// successful.
                /// </summary>
                public class CreateRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Spanner.v1.Data.CreateDatabaseRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the instance that will serve the new database. Values are of the form
                    /// `projects//instances/`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Spanner.v1.Data.CreateDatabaseRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/databases";

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
                            Pattern = @"^projects/[^/]+/instances/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Drops (aka deletes) a Cloud Spanner database. Completed backups for the database will be retained
                /// according to their `expire_time`.
                /// </summary>
                /// <param name="database">Required. The database to be dropped.</param>
                public virtual DropDatabaseRequest DropDatabase(string database)
                {
                    return new DropDatabaseRequest(service, database);
                }

                /// <summary>
                /// Drops (aka deletes) a Cloud Spanner database. Completed backups for the database will be retained
                /// according to their `expire_time`.
                /// </summary>
                public class DropDatabaseRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.Empty>
                {
                    /// <summary>Constructs a new DropDatabase request.</summary>
                    public DropDatabaseRequest(Google.Apis.Services.IClientService service, string database) : base(service)
                    {
                        Database = database;
                        InitParameters();
                    }

                    /// <summary>Required. The database to be dropped.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("database", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Database { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "dropDatabase";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+database}";

                    /// <summary>Initializes DropDatabase parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("database", new Google.Apis.Discovery.Parameter
                        {
                            Name = "database",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/instances/[^/]+/databases/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets the state of a Cloud Spanner database.</summary>
                /// <param name="name">
                /// Required. The name of the requested database. Values are of the form
                /// `projects//instances//databases/`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Gets the state of a Cloud Spanner database.</summary>
                public class GetRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.Database>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the requested database. Values are of the form
                    /// `projects//instances//databases/`.
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
                            Pattern = @"^projects/[^/]+/instances/[^/]+/databases/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Returns the schema of a Cloud Spanner database as a list of formatted DDL statements. This method
                /// does not show pending schema updates, those may be queried using the Operations API.
                /// </summary>
                /// <param name="database">
                /// Required. The database whose schema we wish to get. Values are of the form
                /// `projects//instances//databases/`
                /// </param>
                public virtual GetDdlRequest GetDdl(string database)
                {
                    return new GetDdlRequest(service, database);
                }

                /// <summary>
                /// Returns the schema of a Cloud Spanner database as a list of formatted DDL statements. This method
                /// does not show pending schema updates, those may be queried using the Operations API.
                /// </summary>
                public class GetDdlRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.GetDatabaseDdlResponse>
                {
                    /// <summary>Constructs a new GetDdl request.</summary>
                    public GetDdlRequest(Google.Apis.Services.IClientService service, string database) : base(service)
                    {
                        Database = database;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The database whose schema we wish to get. Values are of the form
                    /// `projects//instances//databases/`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("database", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Database { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "getDdl";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+database}/ddl";

                    /// <summary>Initializes GetDdl parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("database", new Google.Apis.Discovery.Parameter
                        {
                            Name = "database",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/instances/[^/]+/databases/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Gets the access control policy for a database or backup resource. Returns an empty policy if a
                /// database or backup exists but does not have a policy set. Authorization requires
                /// `spanner.databases.getIamPolicy` permission on resource. For backups, authorization requires
                /// `spanner.backups.getIamPolicy` permission on resource.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The Cloud Spanner resource for which the policy is being retrieved. The format is
                /// `projects//instances/` for instance resources and `projects//instances//databases/` for database
                /// resources.
                /// </param>
                public virtual GetIamPolicyRequest GetIamPolicy(Google.Apis.Spanner.v1.Data.GetIamPolicyRequest body, string resource)
                {
                    return new GetIamPolicyRequest(service, body, resource);
                }

                /// <summary>
                /// Gets the access control policy for a database or backup resource. Returns an empty policy if a
                /// database or backup exists but does not have a policy set. Authorization requires
                /// `spanner.databases.getIamPolicy` permission on resource. For backups, authorization requires
                /// `spanner.backups.getIamPolicy` permission on resource.
                /// </summary>
                public class GetIamPolicyRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.Policy>
                {
                    /// <summary>Constructs a new GetIamPolicy request.</summary>
                    public GetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.Spanner.v1.Data.GetIamPolicyRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The Cloud Spanner resource for which the policy is being retrieved. The format is
                    /// `projects//instances/` for instance resources and `projects//instances//databases/` for database
                    /// resources.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Spanner.v1.Data.GetIamPolicyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "getIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

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
                            Pattern = @"^projects/[^/]+/instances/[^/]+/databases/[^/]+$",
                        });
                    }
                }

                /// <summary>Request a specific scan with Database-specific data for Cloud Key Visualizer.</summary>
                /// <param name="name">
                /// Required. The unique name of the scan containing the requested information, specific to the Database
                /// service implementing this interface.
                /// </param>
                public virtual GetScansRequest GetScans(string name)
                {
                    return new GetScansRequest(service, name);
                }

                /// <summary>Request a specific scan with Database-specific data for Cloud Key Visualizer.</summary>
                public class GetScansRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.Scan>
                {
                    /// <summary>Constructs a new GetScans request.</summary>
                    public GetScansRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The unique name of the scan containing the requested information, specific to the
                    /// Database service implementing this interface.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>The upper bound for the time range to retrieve Scan data for.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("endTime", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object EndTime { get; set; }

                    /// <summary>
                    /// These fields restrict the Database-specific information returned in the `Scan.data` field. If a
                    /// `View` is provided that does not include the `Scan.data` field, these are ignored. This range of
                    /// time must be entirely contained within the defined time range of the targeted scan. The lower
                    /// bound for the time range to retrieve Scan data for.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("startTime", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object StartTime { get; set; }

                    /// <summary>
                    /// Specifies which parts of the Scan should be returned in the response. Note, if left unspecified,
                    /// the FULL view is assumed.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<ViewEnum> View { get; set; }

                    /// <summary>
                    /// Specifies which parts of the Scan should be returned in the response. Note, if left unspecified,
                    /// the FULL view is assumed.
                    /// </summary>
                    public enum ViewEnum
                    {
                        /// <summary>Not specified, equivalent to SUMMARY.</summary>
                        [Google.Apis.Util.StringValueAttribute("VIEW_UNSPECIFIED")]
                        VIEWUNSPECIFIED = 0,

                        /// <summary>
                        /// Server responses only include `name`, `details`, `start_time` and `end_time`. The default
                        /// value. Note, the ListScans method may only use this view type, others view types are not
                        /// supported.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("SUMMARY")]
                        SUMMARY = 1,

                        /// <summary>
                        /// Full representation of the scan is returned in the server response, including `data`.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("FULL")]
                        FULL = 2,
                    }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "getScans";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}/scans";

                    /// <summary>Initializes GetScans parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/instances/[^/]+/databases/[^/]+$",
                        });
                        RequestParameters.Add("endTime", new Google.Apis.Discovery.Parameter
                        {
                            Name = "endTime",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("startTime", new Google.Apis.Discovery.Parameter
                        {
                            Name = "startTime",
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

                /// <summary>Lists Cloud Spanner databases.</summary>
                /// <param name="parent">
                /// Required. The instance whose databases should be listed. Values are of the form
                /// `projects//instances/`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists Cloud Spanner databases.</summary>
                public class ListRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.ListDatabasesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The instance whose databases should be listed. Values are of the form
                    /// `projects//instances/`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Number of databases to be returned in the response. If 0 or less, defaults to the server's
                    /// maximum allowed page size.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// If non-empty, `page_token` should contain a next_page_token from a previous
                    /// ListDatabasesResponse.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/databases";

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
                            Pattern = @"^projects/[^/]+/instances/[^/]+$",
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
                /// Create a new database by restoring from a completed backup. The new database must be in the same
                /// project and in an instance with the same instance configuration as the instance containing the
                /// backup. The returned database long-running operation has a name of the format
                /// `projects//instances//databases//operations/`, and can be used to track the progress of the
                /// operation, and to cancel it. The metadata field type is RestoreDatabaseMetadata. The response type
                /// is Database, if successful. Cancelling the returned operation will stop the restore and delete the
                /// database. There can be only one database being restored into an instance at a time. Once the restore
                /// operation completes, a new restore operation can be initiated, without waiting for the optimize
                /// operation associated with the first restore to complete.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The name of the instance in which to create the restored database. This instance must be
                /// in the same project and have the same instance configuration as the instance containing the source
                /// backup. Values are of the form `projects//instances/`.
                /// </param>
                public virtual RestoreRequest Restore(Google.Apis.Spanner.v1.Data.RestoreDatabaseRequest body, string parent)
                {
                    return new RestoreRequest(service, body, parent);
                }

                /// <summary>
                /// Create a new database by restoring from a completed backup. The new database must be in the same
                /// project and in an instance with the same instance configuration as the instance containing the
                /// backup. The returned database long-running operation has a name of the format
                /// `projects//instances//databases//operations/`, and can be used to track the progress of the
                /// operation, and to cancel it. The metadata field type is RestoreDatabaseMetadata. The response type
                /// is Database, if successful. Cancelling the returned operation will stop the restore and delete the
                /// database. There can be only one database being restored into an instance at a time. Once the restore
                /// operation completes, a new restore operation can be initiated, without waiting for the optimize
                /// operation associated with the first restore to complete.
                /// </summary>
                public class RestoreRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Restore request.</summary>
                    public RestoreRequest(Google.Apis.Services.IClientService service, Google.Apis.Spanner.v1.Data.RestoreDatabaseRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the instance in which to create the restored database. This instance must
                    /// be in the same project and have the same instance configuration as the instance containing the
                    /// source backup. Values are of the form `projects//instances/`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Spanner.v1.Data.RestoreDatabaseRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "restore";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/databases:restore";

                    /// <summary>Initializes Restore parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/instances/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Sets the access control policy on a database or backup resource. Replaces any existing policy.
                /// Authorization requires `spanner.databases.setIamPolicy` permission on resource. For backups,
                /// authorization requires `spanner.backups.setIamPolicy` permission on resource.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The Cloud Spanner resource for which the policy is being set. The format is
                /// `projects//instances/` for instance resources and `projects//instances//databases/` for databases
                /// resources.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.Spanner.v1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on a database or backup resource. Replaces any existing policy.
                /// Authorization requires `spanner.databases.setIamPolicy` permission on resource. For backups,
                /// authorization requires `spanner.backups.setIamPolicy` permission on resource.
                /// </summary>
                public class SetIamPolicyRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.Spanner.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The Cloud Spanner resource for which the policy is being set. The format is
                    /// `projects//instances/` for instance resources and `projects//instances//databases/` for
                    /// databases resources.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Spanner.v1.Data.SetIamPolicyRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/instances/[^/]+/databases/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Returns permissions that the caller has on the specified database or backup resource. Attempting
                /// this RPC on a non-existent Cloud Spanner database will result in a NOT_FOUND error if the user has
                /// `spanner.databases.list` permission on the containing Cloud Spanner instance. Otherwise returns an
                /// empty set of permissions. Calling this method on a backup that does not exist will result in a
                /// NOT_FOUND error if the user has `spanner.backups.list` permission on the containing instance.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The Cloud Spanner resource for which permissions are being tested. The format is
                /// `projects//instances/` for instance resources and `projects//instances//databases/` for database
                /// resources.
                /// </param>
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.Spanner.v1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(service, body, resource);
                }

                /// <summary>
                /// Returns permissions that the caller has on the specified database or backup resource. Attempting
                /// this RPC on a non-existent Cloud Spanner database will result in a NOT_FOUND error if the user has
                /// `spanner.databases.list` permission on the containing Cloud Spanner instance. Otherwise returns an
                /// empty set of permissions. Calling this method on a backup that does not exist will result in a
                /// NOT_FOUND error if the user has `spanner.backups.list` permission on the containing instance.
                /// </summary>
                public class TestIamPermissionsRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.Spanner.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The Cloud Spanner resource for which permissions are being tested. The format is
                    /// `projects//instances/` for instance resources and `projects//instances//databases/` for database
                    /// resources.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Spanner.v1.Data.TestIamPermissionsRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/instances/[^/]+/databases/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Updates the schema of a Cloud Spanner database by creating/altering/dropping tables, columns,
                /// indexes, etc. The returned long-running operation will have a name of the format `/operations/` and
                /// can be used to track execution of the schema change(s). The metadata field type is
                /// UpdateDatabaseDdlMetadata. The operation has no response.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="database">Required. The database to update.</param>
                public virtual UpdateDdlRequest UpdateDdl(Google.Apis.Spanner.v1.Data.UpdateDatabaseDdlRequest body, string database)
                {
                    return new UpdateDdlRequest(service, body, database);
                }

                /// <summary>
                /// Updates the schema of a Cloud Spanner database by creating/altering/dropping tables, columns,
                /// indexes, etc. The returned long-running operation will have a name of the format `/operations/` and
                /// can be used to track execution of the schema change(s). The metadata field type is
                /// UpdateDatabaseDdlMetadata. The operation has no response.
                /// </summary>
                public class UpdateDdlRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.Operation>
                {
                    /// <summary>Constructs a new UpdateDdl request.</summary>
                    public UpdateDdlRequest(Google.Apis.Services.IClientService service, Google.Apis.Spanner.v1.Data.UpdateDatabaseDdlRequest body, string database) : base(service)
                    {
                        Database = database;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The database to update.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("database", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Database { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Spanner.v1.Data.UpdateDatabaseDdlRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "updateDdl";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+database}/ddl";

                    /// <summary>Initializes UpdateDdl parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("database", new Google.Apis.Discovery.Parameter
                        {
                            Name = "database",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/instances/[^/]+/databases/[^/]+$",
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
                public class CancelRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.Empty>
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
                            Pattern = @"^projects/[^/]+/instances/[^/]+/operations/[^/]+$",
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
                public class DeleteRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.Empty>
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
                            Pattern = @"^projects/[^/]+/instances/[^/]+/operations/[^/]+$",
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
                public class GetRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.Operation>
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
                            Pattern = @"^projects/[^/]+/instances/[^/]+/operations/[^/]+$",
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
                public class ListRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.ListOperationsResponse>
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
                    public override string RestPath => "v1/{+name}";

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
                            Pattern = @"^projects/[^/]+/instances/[^/]+/operations$",
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
            /// Creates an instance and begins preparing it to begin serving. The returned long-running operation can be
            /// used to track the progress of preparing the new instance. The instance name is assigned by the caller.
            /// If the named instance already exists, `CreateInstance` returns `ALREADY_EXISTS`. Immediately upon
            /// completion of this request: * The instance is readable via the API, with all requested attributes but no
            /// allocated resources. Its state is `CREATING`. Until completion of the returned operation: * Cancelling
            /// the operation renders the instance immediately unreadable via the API. * The instance can be deleted. *
            /// All other attempts to modify the instance are rejected. Upon completion of the returned operation: *
            /// Billing for all successfully-allocated resources begins (some types may have lower than the requested
            /// levels). * Databases can be created in the instance. * The instance's allocated resource levels are
            /// readable via the API. * The instance's state becomes `READY`. The returned long-running operation will
            /// have a name of the format `/operations/` and can be used to track creation of the instance. The metadata
            /// field type is CreateInstanceMetadata. The response field type is Instance, if successful.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The name of the project in which to create the instance. Values are of the form `projects/`.
            /// </param>
            public virtual CreateRequest Create(Google.Apis.Spanner.v1.Data.CreateInstanceRequest body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>
            /// Creates an instance and begins preparing it to begin serving. The returned long-running operation can be
            /// used to track the progress of preparing the new instance. The instance name is assigned by the caller.
            /// If the named instance already exists, `CreateInstance` returns `ALREADY_EXISTS`. Immediately upon
            /// completion of this request: * The instance is readable via the API, with all requested attributes but no
            /// allocated resources. Its state is `CREATING`. Until completion of the returned operation: * Cancelling
            /// the operation renders the instance immediately unreadable via the API. * The instance can be deleted. *
            /// All other attempts to modify the instance are rejected. Upon completion of the returned operation: *
            /// Billing for all successfully-allocated resources begins (some types may have lower than the requested
            /// levels). * Databases can be created in the instance. * The instance's allocated resource levels are
            /// readable via the API. * The instance's state becomes `READY`. The returned long-running operation will
            /// have a name of the format `/operations/` and can be used to track creation of the instance. The metadata
            /// field type is CreateInstanceMetadata. The response field type is Instance, if successful.
            /// </summary>
            public class CreateRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.Operation>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Spanner.v1.Data.CreateInstanceRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the project in which to create the instance. Values are of the form
                /// `projects/`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Spanner.v1.Data.CreateInstanceRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/instances";

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
            /// Deletes an instance. Immediately upon completion of the request: * Billing ceases for all of the
            /// instance's reserved resources. Soon afterward: * The instance and *all of its databases* immediately and
            /// irrevocably disappear from the API. All data in the databases is permanently deleted.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the instance to be deleted. Values are of the form `projects//instances/`
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>
            /// Deletes an instance. Immediately upon completion of the request: * Billing ceases for all of the
            /// instance's reserved resources. Soon afterward: * The instance and *all of its databases* immediately and
            /// irrevocably disappear from the API. All data in the databases is permanently deleted.
            /// </summary>
            public class DeleteRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the instance to be deleted. Values are of the form `projects//instances/`
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
                        Pattern = @"^projects/[^/]+/instances/[^/]+$",
                    });
                }
            }

            /// <summary>Gets information about a particular instance.</summary>
            /// <param name="name">
            /// Required. The name of the requested instance. Values are of the form `projects//instances/`.
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets information about a particular instance.</summary>
            public class GetRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.Instance>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the requested instance. Values are of the form `projects//instances/`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// If field_mask is present, specifies the subset of Instance fields that should be returned. If
                /// absent, all Instance fields are returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("fieldMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object FieldMask { get; set; }

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
                        Pattern = @"^projects/[^/]+/instances/[^/]+$",
                    });
                    RequestParameters.Add("fieldMask", new Google.Apis.Discovery.Parameter
                    {
                        Name = "fieldMask",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Gets the access control policy for an instance resource. Returns an empty policy if an instance exists
            /// but does not have a policy set. Authorization requires `spanner.instances.getIamPolicy` on resource.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="resource">
            /// REQUIRED: The Cloud Spanner resource for which the policy is being retrieved. The format is
            /// `projects//instances/` for instance resources and `projects//instances//databases/` for database
            /// resources.
            /// </param>
            public virtual GetIamPolicyRequest GetIamPolicy(Google.Apis.Spanner.v1.Data.GetIamPolicyRequest body, string resource)
            {
                return new GetIamPolicyRequest(service, body, resource);
            }

            /// <summary>
            /// Gets the access control policy for an instance resource. Returns an empty policy if an instance exists
            /// but does not have a policy set. Authorization requires `spanner.instances.getIamPolicy` on resource.
            /// </summary>
            public class GetIamPolicyRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.Policy>
            {
                /// <summary>Constructs a new GetIamPolicy request.</summary>
                public GetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.Spanner.v1.Data.GetIamPolicyRequest body, string resource) : base(service)
                {
                    Resource = resource;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// REQUIRED: The Cloud Spanner resource for which the policy is being retrieved. The format is
                /// `projects//instances/` for instance resources and `projects//instances//databases/` for database
                /// resources.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Resource { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Spanner.v1.Data.GetIamPolicyRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getIamPolicy";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

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
                        Pattern = @"^projects/[^/]+/instances/[^/]+$",
                    });
                }
            }

            /// <summary>Lists all instances in the given project.</summary>
            /// <param name="parent">
            /// Required. The name of the project for which a list of instances is requested. Values are of the form
            /// `projects/`.
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists all instances in the given project.</summary>
            public class ListRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.ListInstancesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the project for which a list of instances is requested. Values are of the form
                /// `projects/`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// An expression for filtering the results of the request. Filter rules are case insensitive. The
                /// fields eligible for filtering are: * `name` * `display_name` * `labels.key` where key is the name of
                /// a label Some examples of using filters are: * `name:*` --&amp;gt; The instance has a name. *
                /// `name:Howl` --&amp;gt; The instance's name contains the string "howl". * `name:HOWL` --&amp;gt;
                /// Equivalent to above. * `NAME:howl` --&amp;gt; Equivalent to above. * `labels.env:*` --&amp;gt; The
                /// instance has the label "env". * `labels.env:dev` --&amp;gt; The instance has the label "env" and the
                /// value of the label contains the string "dev". * `name:howl labels.env:dev` --&amp;gt; The instance's
                /// name contains "howl" and it has the label "env" with its value containing "dev".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// Deadline used while retrieving metadata for instances. Instances whose metadata cannot be retrieved
                /// within this deadline will be added to unreachable in ListInstancesResponse.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("instanceDeadline", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object InstanceDeadline { get; set; }

                /// <summary>
                /// Number of instances to be returned in the response. If 0 or less, defaults to the server's maximum
                /// allowed page size.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// If non-empty, `page_token` should contain a next_page_token from a previous ListInstancesResponse.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/instances";

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
                    RequestParameters.Add("instanceDeadline", new Google.Apis.Discovery.Parameter
                    {
                        Name = "instanceDeadline",
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
            /// Updates an instance, and begins allocating or releasing resources as requested. The returned
            /// long-running operation can be used to track the progress of updating the instance. If the named instance
            /// does not exist, returns `NOT_FOUND`. Immediately upon completion of this request: * For resource types
            /// for which a decrease in the instance's allocation has been requested, billing is based on the
            /// newly-requested level. Until completion of the returned operation: * Cancelling the operation sets its
            /// metadata's cancel_time, and begins restoring resources to their pre-request values. The operation is
            /// guaranteed to succeed at undoing all resource changes, after which point it terminates with a
            /// `CANCELLED` status. * All other attempts to modify the instance are rejected. * Reading the instance via
            /// the API continues to give the pre-request resource levels. Upon completion of the returned operation: *
            /// Billing begins for all successfully-allocated resources (some types may have lower than the requested
            /// levels). * All newly-reserved resources are available for serving the instance's tables. * The
            /// instance's new resource levels are readable via the API. The returned long-running operation will have a
            /// name of the format `/operations/` and can be used to track the instance modification. The metadata field
            /// type is UpdateInstanceMetadata. The response field type is Instance, if successful. Authorization
            /// requires `spanner.instances.update` permission on resource name.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. A unique identifier for the instance, which cannot be changed after the instance is created.
            /// Values are of the form `projects//instances/a-z*[a-z0-9]`. The final segment of the name must be between
            /// 2 and 64 characters in length.
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.Spanner.v1.Data.UpdateInstanceRequest body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>
            /// Updates an instance, and begins allocating or releasing resources as requested. The returned
            /// long-running operation can be used to track the progress of updating the instance. If the named instance
            /// does not exist, returns `NOT_FOUND`. Immediately upon completion of this request: * For resource types
            /// for which a decrease in the instance's allocation has been requested, billing is based on the
            /// newly-requested level. Until completion of the returned operation: * Cancelling the operation sets its
            /// metadata's cancel_time, and begins restoring resources to their pre-request values. The operation is
            /// guaranteed to succeed at undoing all resource changes, after which point it terminates with a
            /// `CANCELLED` status. * All other attempts to modify the instance are rejected. * Reading the instance via
            /// the API continues to give the pre-request resource levels. Upon completion of the returned operation: *
            /// Billing begins for all successfully-allocated resources (some types may have lower than the requested
            /// levels). * All newly-reserved resources are available for serving the instance's tables. * The
            /// instance's new resource levels are readable via the API. The returned long-running operation will have a
            /// name of the format `/operations/` and can be used to track the instance modification. The metadata field
            /// type is UpdateInstanceMetadata. The response field type is Instance, if successful. Authorization
            /// requires `spanner.instances.update` permission on resource name.
            /// </summary>
            public class PatchRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.Operation>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Spanner.v1.Data.UpdateInstanceRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. A unique identifier for the instance, which cannot be changed after the instance is
                /// created. Values are of the form `projects//instances/a-z*[a-z0-9]`. The final segment of the name
                /// must be between 2 and 64 characters in length.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Spanner.v1.Data.UpdateInstanceRequest Body { get; set; }

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
                        Pattern = @"^projects/[^/]+/instances/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Sets the access control policy on an instance resource. Replaces any existing policy. Authorization
            /// requires `spanner.instances.setIamPolicy` on resource.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="resource">
            /// REQUIRED: The Cloud Spanner resource for which the policy is being set. The format is
            /// `projects//instances/` for instance resources and `projects//instances//databases/` for databases
            /// resources.
            /// </param>
            public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.Spanner.v1.Data.SetIamPolicyRequest body, string resource)
            {
                return new SetIamPolicyRequest(service, body, resource);
            }

            /// <summary>
            /// Sets the access control policy on an instance resource. Replaces any existing policy. Authorization
            /// requires `spanner.instances.setIamPolicy` on resource.
            /// </summary>
            public class SetIamPolicyRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.Policy>
            {
                /// <summary>Constructs a new SetIamPolicy request.</summary>
                public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.Spanner.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
                {
                    Resource = resource;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// REQUIRED: The Cloud Spanner resource for which the policy is being set. The format is
                /// `projects//instances/` for instance resources and `projects//instances//databases/` for databases
                /// resources.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Resource { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Spanner.v1.Data.SetIamPolicyRequest Body { get; set; }

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
                        Pattern = @"^projects/[^/]+/instances/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Returns permissions that the caller has on the specified instance resource. Attempting this RPC on a
            /// non-existent Cloud Spanner instance resource will result in a NOT_FOUND error if the user has
            /// `spanner.instances.list` permission on the containing Google Cloud Project. Otherwise returns an empty
            /// set of permissions.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="resource">
            /// REQUIRED: The Cloud Spanner resource for which permissions are being tested. The format is
            /// `projects//instances/` for instance resources and `projects//instances//databases/` for database
            /// resources.
            /// </param>
            public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.Spanner.v1.Data.TestIamPermissionsRequest body, string resource)
            {
                return new TestIamPermissionsRequest(service, body, resource);
            }

            /// <summary>
            /// Returns permissions that the caller has on the specified instance resource. Attempting this RPC on a
            /// non-existent Cloud Spanner instance resource will result in a NOT_FOUND error if the user has
            /// `spanner.instances.list` permission on the containing Google Cloud Project. Otherwise returns an empty
            /// set of permissions.
            /// </summary>
            public class TestIamPermissionsRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.TestIamPermissionsResponse>
            {
                /// <summary>Constructs a new TestIamPermissions request.</summary>
                public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.Spanner.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
                {
                    Resource = resource;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// REQUIRED: The Cloud Spanner resource for which permissions are being tested. The format is
                /// `projects//instances/` for instance resources and `projects//instances//databases/` for database
                /// resources.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Resource { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Spanner.v1.Data.TestIamPermissionsRequest Body { get; set; }

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
                        Pattern = @"^projects/[^/]+/instances/[^/]+$",
                    });
                }
            }
        }
    }

    /// <summary>The "scans" collection of methods.</summary>
    public class ScansResource
    {
        private const string Resource = "scans";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ScansResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Return available scans given a Database-specific resource name.</summary>
        /// <param name="parent">
        /// Required. The unique name of the parent resource, specific to the Database service implementing this
        /// interface.
        /// </param>
        public virtual ListRequest List(string parent)
        {
            return new ListRequest(service, parent);
        }

        /// <summary>Return available scans given a Database-specific resource name.</summary>
        public class ListRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.ListScansResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
            {
                Parent = parent;
                InitParameters();
            }

            /// <summary>
            /// Required. The unique name of the parent resource, specific to the Database service implementing this
            /// interface.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>
            /// A filter expression to restrict the results based on information present in the available Scan
            /// collection. The filter applies to all fields within the Scan message except for `data`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>The maximum number of items to return.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>The next_page_token value returned from a previous List request, if any.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// Specifies which parts of the Scan should be returned in the response. Note, only the SUMMARY view (the
            /// default) is currently supported for ListScans.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ViewEnum> View { get; set; }

            /// <summary>
            /// Specifies which parts of the Scan should be returned in the response. Note, only the SUMMARY view (the
            /// default) is currently supported for ListScans.
            /// </summary>
            public enum ViewEnum
            {
                /// <summary>Not specified, equivalent to SUMMARY.</summary>
                [Google.Apis.Util.StringValueAttribute("VIEW_UNSPECIFIED")]
                VIEWUNSPECIFIED = 0,

                /// <summary>
                /// Server responses only include `name`, `details`, `start_time` and `end_time`. The default value.
                /// Note, the ListScans method may only use this view type, others view types are not supported.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("SUMMARY")]
                SUMMARY = 1,

                /// <summary>
                /// Full representation of the scan is returned in the server response, including `data`.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("FULL")]
                FULL = 2,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+parent}";

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
                    Pattern = @"^scans$",
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
    }
}
namespace Google.Apis.Spanner.v1.Data
{
    /// <summary>A backup of a Cloud Spanner database.</summary>
    public class Backup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The time the CreateBackup request is received. If the request does not specify `version_time`,
        /// the `version_time` of the backup will be equivalent to the `create_time`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Required for the CreateBackup operation. Name of the database from which this backup was created. This needs
        /// to be in the same instance as the backup. Values are of the form `projects//instances//databases/`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("database")]
        public virtual string Database { get; set; }

        /// <summary>Output only. The encryption information for the backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionInfo")]
        public virtual EncryptionInfo EncryptionInfo { get; set; }

        /// <summary>
        /// Required for the CreateBackup operation. The expiration time of the backup, with microseconds granularity
        /// that must be at least 6 hours and at most 366 days from the time the CreateBackup request is processed. Once
        /// the `expire_time` has passed, the backup is eligible to be automatically deleted by Cloud Spanner to free
        /// the resources used by the backup.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expireTime")]
        public virtual object ExpireTime { get; set; }

        /// <summary>
        /// Output only for the CreateBackup operation. Required for the UpdateBackup operation. A globally unique
        /// identifier for the backup which cannot be changed. Values are of the form
        /// `projects//instances//backups/a-z*[a-z0-9]` The final segment of the name must be between 2 and 60
        /// characters in length. The backup is stored in the location(s) specified in the instance configuration of the
        /// instance containing the backup, identified by the prefix of the backup name of the form
        /// `projects//instances/`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The names of the restored databases that reference the backup. The database names are of the
        /// form `projects//instances//databases/`. Referencing databases may exist in different instances. The
        /// existence of any referencing database prevents the backup from being deleted. When a restored database from
        /// the backup enters the `READY` state, the reference to the backup is removed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referencingDatabases")]
        public virtual System.Collections.Generic.IList<string> ReferencingDatabases { get; set; }

        /// <summary>Output only. Size of the backup in bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeBytes")]
        public virtual System.Nullable<long> SizeBytes { get; set; }

        /// <summary>Output only. The current state of the backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// The backup will contain an externally consistent copy of the database at the timestamp specified by
        /// `version_time`. If `version_time` is not specified, the system will set `version_time` to the `create_time`
        /// of the backup.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionTime")]
        public virtual object VersionTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a backup.</summary>
    public class BackupInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backup")]
        public virtual string Backup { get; set; }

        /// <summary>The time the CreateBackup request was received.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Name of the database the backup was created from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceDatabase")]
        public virtual string SourceDatabase { get; set; }

        /// <summary>
        /// The backup contains an externally consistent copy of `source_database` at the timestamp specified by
        /// `version_time`. If the CreateBackup request did not specify `version_time`, the `version_time` of the backup
        /// is equivalent to the `create_time`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionTime")]
        public virtual object VersionTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for BatchCreateSessions.</summary>
    public class BatchCreateSessionsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The number of sessions to be created in this batch call. The API may return fewer than the
        /// requested number of sessions. If a specific number of sessions are desired, the client can make additional
        /// calls to BatchCreateSessions (adjusting session_count as necessary).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sessionCount")]
        public virtual System.Nullable<int> SessionCount { get; set; }

        /// <summary>Parameters to be applied to each created session.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sessionTemplate")]
        public virtual Session SessionTemplate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for BatchCreateSessions.</summary>
    public class BatchCreateSessionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The freshly created sessions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("session")]
        public virtual System.Collections.Generic.IList<Session> Session { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for BeginTransaction.</summary>
    public class BeginTransactionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Options for the new transaction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("options")]
        public virtual TransactionOptions Options { get; set; }

        /// <summary>
        /// Common options for this request. Priority is ignored for this request. Setting the priority in this
        /// request_options struct will not do anything. To set the priority for a transaction, set it on the reads and
        /// writes that are part of this transaction instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestOptions")]
        public virtual RequestOptions RequestOptions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Associates `members` with a `role`.</summary>
    public class Binding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The condition that is associated with this binding. If the condition evaluates to `true`, then this binding
        /// applies to the current request. If the condition evaluates to `false`, then this binding does not apply to
        /// the current request. However, a different role binding might grant the same role to one or more of the
        /// members in this binding. To learn which resources support conditions in their IAM policies, see the [IAM
        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual Expr Condition { get; set; }

        /// <summary>
        /// Specifies the identities requesting access for a Cloud Platform resource. `members` can have the following
        /// values: * `allUsers`: A special identifier that represents anyone who is on the internet; with or without a
        /// Google account. * `allAuthenticatedUsers`: A special identifier that represents anyone who is authenticated
        /// with a Google account or a service account. * `user:{emailid}`: An email address that represents a specific
        /// Google account. For example, `alice@example.com` . * `serviceAccount:{emailid}`: An email address that
        /// represents a service account. For example, `my-other-app@appspot.gserviceaccount.com`. * `group:{emailid}`:
        /// An email address that represents a Google group. For example, `admins@example.com`. *
        /// `deleted:user:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing a user that
        /// has been recently deleted. For example, `alice@example.com?uid=123456789012345678901`. If the user is
        /// recovered, this value reverts to `user:{emailid}` and the recovered user retains the role in the binding. *
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
        /// Role that is assigned to `members`. For example, `roles/viewer`, `roles/editor`, or `roles/owner`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata associated with a parent-child relationship appearing in a PlanNode.</summary>
    public class ChildLink : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The node to which the link points.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("childIndex")]
        public virtual System.Nullable<int> ChildIndex { get; set; }

        /// <summary>
        /// The type of the link. For example, in Hash Joins this could be used to distinguish between the build child
        /// and the probe child, or in the case of the child being an output variable, to represent the tag associated
        /// with the output variable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>
        /// Only present if the child node is SCALAR and corresponds to an output variable of the parent node. The field
        /// carries the name of the output variable. For example, a `TableScan` operator that reads rows from a table
        /// will have child links to the `SCALAR` nodes representing the output variables created for each column that
        /// is read by the operator. The corresponding `variable` fields will be set to the variable names assigned to
        /// the columns.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("variable")]
        public virtual string Variable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for Commit.</summary>
    public class CommitRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The mutations to be executed when this transaction commits. All mutations are applied atomically, in the
        /// order they appear in this list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mutations")]
        public virtual System.Collections.Generic.IList<Mutation> Mutations { get; set; }

        /// <summary>Common options for this request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestOptions")]
        public virtual RequestOptions RequestOptions { get; set; }

        /// <summary>
        /// If `true`, then statistics related to the transaction will be included in the CommitResponse. Default value
        /// is `false`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("returnCommitStats")]
        public virtual System.Nullable<bool> ReturnCommitStats { get; set; }

        /// <summary>
        /// Execute mutations in a temporary transaction. Note that unlike commit of a previously-started transaction,
        /// commit with a temporary transaction is non-idempotent. That is, if the `CommitRequest` is sent to Cloud
        /// Spanner more than once (for instance, due to retries in the application, or in the transport library), it is
        /// possible that the mutations are executed more than once. If this is undesirable, use BeginTransaction and
        /// Commit instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("singleUseTransaction")]
        public virtual TransactionOptions SingleUseTransaction { get; set; }

        /// <summary>Commit a previously-started transaction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transactionId")]
        public virtual string TransactionId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for Commit.</summary>
    public class CommitResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The statistics about this Commit. Not returned by default. For more information, see
        /// CommitRequest.return_commit_stats.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commitStats")]
        public virtual CommitStats CommitStats { get; set; }

        /// <summary>The Cloud Spanner timestamp at which the transaction committed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commitTimestamp")]
        public virtual object CommitTimestamp { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Additional statistics about a commit.</summary>
    public class CommitStats : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The total number of mutations for the transaction. Knowing the `mutation_count` value can help you maximize
        /// the number of mutations in a transaction and minimize the number of API round trips. You can also monitor
        /// this value to prevent transactions from exceeding the system
        /// [limit](https://cloud.google.com/spanner/quotas#limits_for_creating_reading_updating_and_deleting_data). If
        /// the number of mutations exceeds the limit, the server returns
        /// [INVALID_ARGUMENT](https://cloud.google.com/spanner/docs/reference/rest/v1/Code#ENUM_VALUES.INVALID_ARGUMENT).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mutationCount")]
        public virtual System.Nullable<long> MutationCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A message representing context for a KeyRangeInfo, including a label, value, unit, and severity.
    /// </summary>
    public class ContextValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The label for the context value. e.g. "latency".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual LocalizedString Label { get; set; }

        /// <summary>The severity of this context.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>The unit of the context value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unit")]
        public virtual string Unit { get; set; }

        /// <summary>The value for the context.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Nullable<float> Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata type for the operation returned by CreateBackup.</summary>
    public class CreateBackupMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The time at which cancellation of this operation was received. Operations.CancelOperation starts
        /// asynchronous cancellation on a long-running operation. The server makes a best effort to cancel the
        /// operation, but success is not guaranteed. Clients can use Operations.GetOperation or other methods to check
        /// whether the cancellation succeeded or whether the operation completed despite cancellation. On successful
        /// cancellation, the operation is not deleted; instead, it becomes an operation with an Operation.error value
        /// with a google.rpc.Status.code of 1, corresponding to `Code.CANCELLED`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cancelTime")]
        public virtual object CancelTime { get; set; }

        /// <summary>The name of the database the backup is created from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("database")]
        public virtual string Database { get; set; }

        /// <summary>The name of the backup being created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The progress of the CreateBackup operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progress")]
        public virtual OperationProgress Progress { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata type for the operation returned by CreateDatabase.</summary>
    public class CreateDatabaseMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The database being created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("database")]
        public virtual string Database { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for CreateDatabase.</summary>
    public class CreateDatabaseRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. A `CREATE DATABASE` statement, which specifies the ID of the new database. The database ID must
        /// conform to the regular expression `a-z*[a-z0-9]` and be between 2 and 30 characters in length. If the
        /// database ID is a reserved word or if it contains a hyphen, the database ID must be enclosed in backticks (``
        /// ` ``).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createStatement")]
        public virtual string CreateStatement { get; set; }

        /// <summary>
        /// Optional. The encryption configuration for the database. If this field is not specified, Cloud Spanner will
        /// encrypt/decrypt all data at rest using Google default encryption.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionConfig")]
        public virtual EncryptionConfig EncryptionConfig { get; set; }

        /// <summary>
        /// Optional. A list of DDL statements to run inside the newly created database. Statements can create tables,
        /// indexes, etc. These statements execute atomically with the creation of the database: if there is an error in
        /// any statement, the database is not created.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extraStatements")]
        public virtual System.Collections.Generic.IList<string> ExtraStatements { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata type for the operation returned by CreateInstance.</summary>
    public class CreateInstanceMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The time at which this operation was cancelled. If set, this operation is in the process of undoing itself
        /// (which is guaranteed to succeed) and cannot be cancelled again.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cancelTime")]
        public virtual object CancelTime { get; set; }

        /// <summary>The time at which this operation failed or was completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>The instance being created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instance")]
        public virtual Instance Instance { get; set; }

        /// <summary>The time at which the CreateInstance request was received.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for CreateInstance.</summary>
    public class CreateInstanceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The instance to create. The name may be omitted, but if specified must be `/instances/`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instance")]
        public virtual Instance Instance { get; set; }

        /// <summary>
        /// Required. The ID of the instance to create. Valid identifiers are of the form `a-z*[a-z0-9]` and must be
        /// between 2 and 64 characters in length.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceId")]
        public virtual string InstanceId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for CreateSession.</summary>
    public class CreateSessionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The session to create.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("session")]
        public virtual Session Session { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Cloud Spanner database.</summary>
    public class Database : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. If exists, the time at which the database creation started.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Output only. The read-write region which contains the database's leader replicas. This is the same as the
        /// value of default_leader database option set using DatabaseAdmin.CreateDatabase or
        /// DatabaseAdmin.UpdateDatabaseDdl. If not explicitly set, this is empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultLeader")]
        public virtual string DefaultLeader { get; set; }

        /// <summary>
        /// Output only. Earliest timestamp at which older versions of the data can be read. This value is continuously
        /// updated by Cloud Spanner and becomes stale the moment it is queried. If you are using this value to recover
        /// data, make sure to account for the time from the moment when the value is queried to the moment when you
        /// initiate the recovery.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("earliestVersionTime")]
        public virtual object EarliestVersionTime { get; set; }

        /// <summary>
        /// Output only. For databases that are using customer managed encryption, this field contains the encryption
        /// configuration for the database. For databases that are using Google default or other types of encryption,
        /// this field is empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionConfig")]
        public virtual EncryptionConfig EncryptionConfig { get; set; }

        /// <summary>
        /// Output only. For databases that are using customer managed encryption, this field contains the encryption
        /// information for the database, such as encryption state and the Cloud KMS key versions that are in use. For
        /// databases that are using Google default or other types of encryption, this field is empty. This field is
        /// propagated lazily from the backend. There might be a delay from when a key version is being used and when it
        /// appears in this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionInfo")]
        public virtual System.Collections.Generic.IList<EncryptionInfo> EncryptionInfo { get; set; }

        /// <summary>
        /// Required. The name of the database. Values are of the form `projects//instances//databases/`, where `` is as
        /// specified in the `CREATE DATABASE` statement. This name can be passed to other API methods to identify the
        /// database.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. Applicable only for restored databases. Contains information about the restore source.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restoreInfo")]
        public virtual RestoreInfo RestoreInfo { get; set; }

        /// <summary>Output only. The current database state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Output only. The period in which Cloud Spanner retains all versions of data for the database. This is the
        /// same as the value of version_retention_period database option set using UpdateDatabaseDdl. Defaults to 1
        /// hour, if not set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionRetentionPeriod")]
        public virtual string VersionRetentionPeriod { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Arguments to delete operations.</summary>
    public class Delete : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The primary keys of the rows within table to delete. The primary keys must be specified in the
        /// order in which they appear in the `PRIMARY KEY()` clause of the table's equivalent DDL statement (the DDL
        /// statement used to create the table). Delete is idempotent. The transaction will succeed even if some or all
        /// rows do not exist.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keySet")]
        public virtual KeySet KeySet { get; set; }

        /// <summary>Required. The table whose rows will be deleted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("table")]
        public virtual string Table { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A message representing a derived metric.</summary>
    public class DerivedMetric : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the denominator metric. e.g. "rows".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("denominator")]
        public virtual LocalizedString Denominator { get; set; }

        /// <summary>The name of the numerator metric. e.g. "latency".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numerator")]
        public virtual LocalizedString Numerator { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A message representing the key visualizer diagnostic messages.</summary>
    public class DiagnosticMessage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Information about this diagnostic information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("info")]
        public virtual LocalizedString Info { get; set; }

        /// <summary>The metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metric")]
        public virtual LocalizedString Metric { get; set; }

        /// <summary>
        /// Whether this message is specific only for the current metric. By default Diagnostics are shown for all
        /// metrics, regardless which metric is the currently selected metric in the UI. However occasionally a metric
        /// will generate so many messages that the resulting visual clutter becomes overwhelming. In this case setting
        /// this to true, will show the diagnostic messages for that metric only if it is the currently selected metric.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricSpecific")]
        public virtual System.Nullable<bool> MetricSpecific { get; set; }

        /// <summary>The severity of the diagnostic message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>The short message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shortMessage")]
        public virtual LocalizedString ShortMessage { get; set; }

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

    /// <summary>Encryption configuration for a Cloud Spanner database.</summary>
    public class EncryptionConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The Cloud KMS key to be used for encrypting and decrypting the database. Values are of the form
        /// `projects//locations//keyRings//cryptoKeys/`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeyName")]
        public virtual string KmsKeyName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Encryption information for a Cloud Spanner database or backup.</summary>
    public class EncryptionInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. If present, the status of a recent encrypt/decrypt call on underlying data for this database or
        /// backup. Regardless of status, data is always encrypted at rest.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionStatus")]
        public virtual Status EncryptionStatus { get; set; }

        /// <summary>Output only. The type of encryption.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionType")]
        public virtual string EncryptionType { get; set; }

        /// <summary>
        /// Output only. A Cloud KMS key version that is being used to protect the database or backup.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeyVersion")]
        public virtual string KmsKeyVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for ExecuteBatchDml.</summary>
    public class ExecuteBatchDmlRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Common options for this request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestOptions")]
        public virtual RequestOptions RequestOptions { get; set; }

        /// <summary>
        /// Required. A per-transaction sequence number used to identify this request. This field makes each request
        /// idempotent such that if the request is received multiple times, at most one will succeed. The sequence
        /// number must be monotonically increasing within the transaction. If a request arrives for the first time with
        /// an out-of-order sequence number, the transaction may be aborted. Replays of previously handled requests will
        /// yield the same response as the first execution.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seqno")]
        public virtual System.Nullable<long> Seqno { get; set; }

        /// <summary>
        /// Required. The list of statements to execute in this batch. Statements are executed serially, such that the
        /// effects of statement `i` are visible to statement `i+1`. Each statement must be a DML statement. Execution
        /// stops at the first failed statement; the remaining statements are not executed. Callers must provide at
        /// least one statement.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statements")]
        public virtual System.Collections.Generic.IList<Statement> Statements { get; set; }

        /// <summary>
        /// Required. The transaction to use. Must be a read-write transaction. To protect against replays, single-use
        /// transactions are not supported. The caller must either supply an existing transaction ID or begin a new
        /// transaction.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transaction")]
        public virtual TransactionSelector Transaction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The response for ExecuteBatchDml. Contains a list of ResultSet messages, one for each DML statement that has
    /// successfully executed, in the same order as the statements in the request. If a statement fails, the status in
    /// the response body identifies the cause of the failure. To check for DML statements that failed, use the
    /// following approach: 1. Check the status in the response message. The google.rpc.Code enum value `OK` indicates
    /// that all statements were executed successfully. 2. If the status was not `OK`, check the number of result sets
    /// in the response. If the response contains `N` ResultSet messages, then statement `N+1` in the request failed.
    /// Example 1: * Request: 5 DML statements, all executed successfully. * Response: 5 ResultSet messages, with the
    /// status `OK`. Example 2: * Request: 5 DML statements. The third statement has a syntax error. * Response: 2
    /// ResultSet messages, and a syntax error (`INVALID_ARGUMENT`) status. The number of ResultSet messages indicates
    /// that the third statement failed, and the fourth and fifth statements were not executed.
    /// </summary>
    public class ExecuteBatchDmlResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// One ResultSet for each statement in the request that ran successfully, in the same order as the statements
        /// in the request. Each ResultSet does not contain any rows. The ResultSetStats in each ResultSet contain the
        /// number of rows modified by the statement. Only the first ResultSet in the response contains valid
        /// ResultSetMetadata.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resultSets")]
        public virtual System.Collections.Generic.IList<ResultSet> ResultSets { get; set; }

        /// <summary>
        /// If all DML statements are executed successfully, the status is `OK`. Otherwise, the error status of the
        /// first failed statement.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual Status Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for ExecuteSql and ExecuteStreamingSql.</summary>
    public class ExecuteSqlRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// It is not always possible for Cloud Spanner to infer the right SQL type from a JSON value. For example,
        /// values of type `BYTES` and values of type `STRING` both appear in params as JSON strings. In these cases,
        /// `param_types` can be used to specify the exact SQL type for some or all of the SQL statement parameters. See
        /// the definition of Type for more information about SQL types.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paramTypes")]
        public virtual System.Collections.Generic.IDictionary<string, Type> ParamTypes { get; set; }

        /// <summary>
        /// Parameter names and values that bind to placeholders in the SQL string. A parameter placeholder consists of
        /// the `@` character followed by the parameter name (for example, `@firstName`). Parameter names must conform
        /// to the naming requirements of identifiers as specified at
        /// https://cloud.google.com/spanner/docs/lexical#identifiers. Parameters can appear anywhere that a literal
        /// value is expected. The same parameter name can be used more than once, for example: `"WHERE id &amp;gt;
        /// @msg_id AND id &amp;lt; @msg_id + 100"` It is an error to execute a SQL statement with unbound parameters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("params")]
        public virtual System.Collections.Generic.IDictionary<string, object> Params__ { get; set; }

        /// <summary>
        /// If present, results will be restricted to the specified partition previously created using PartitionQuery().
        /// There must be an exact match for the values of fields common to this message and the PartitionQueryRequest
        /// message used to create this partition_token.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partitionToken")]
        public virtual string PartitionToken { get; set; }

        /// <summary>
        /// Used to control the amount of debugging information returned in ResultSetStats. If partition_token is set,
        /// query_mode can only be set to QueryMode.NORMAL.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryMode")]
        public virtual string QueryMode { get; set; }

        /// <summary>Query optimizer configuration to use for the given query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryOptions")]
        public virtual QueryOptions QueryOptions { get; set; }

        /// <summary>Common options for this request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestOptions")]
        public virtual RequestOptions RequestOptions { get; set; }

        /// <summary>
        /// If this request is resuming a previously interrupted SQL statement execution, `resume_token` should be
        /// copied from the last PartialResultSet yielded before the interruption. Doing this enables the new SQL
        /// statement execution to resume where the last one left off. The rest of the request parameters must exactly
        /// match the request that yielded this token.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resumeToken")]
        public virtual string ResumeToken { get; set; }

        /// <summary>
        /// A per-transaction sequence number used to identify this request. This field makes each request idempotent
        /// such that if the request is received multiple times, at most one will succeed. The sequence number must be
        /// monotonically increasing within the transaction. If a request arrives for the first time with an
        /// out-of-order sequence number, the transaction may be aborted. Replays of previously handled requests will
        /// yield the same response as the first execution. Required for DML statements. Ignored for queries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seqno")]
        public virtual System.Nullable<long> Seqno { get; set; }

        /// <summary>Required. The SQL string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sql")]
        public virtual string Sql { get; set; }

        /// <summary>
        /// The transaction to use. For queries, if none is provided, the default is a temporary read-only transaction
        /// with strong concurrency. Standard DML statements require a read-write transaction. To protect against
        /// replays, single-use transactions are not supported. The caller must either supply an existing transaction ID
        /// or begin a new transaction. Partitioned DML requires an existing Partitioned DML transaction ID.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transaction")]
        public virtual TransactionSelector Transaction { get; set; }

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

    /// <summary>Message representing a single field of a struct.</summary>
    public class Field : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The name of the field. For reads, this is the column name. For SQL queries, it is the column alias (e.g.,
        /// `"Word"` in the query `"SELECT 'hello' AS Word"`), or the column name (e.g., `"ColName"` in the query
        /// `"SELECT ColName FROM Table"`). Some columns might have an empty name (e.g., `"SELECT UPPER(ColName)"`).
        /// Note that a query result can contain multiple fields with the same name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The type of the field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual Type Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for GetDatabaseDdl.</summary>
    public class GetDatabaseDdlResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of formatted DDL statements defining the schema of the database specified in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statements")]
        public virtual System.Collections.Generic.IList<string> Statements { get; set; }

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
        /// Optional. The policy format version to be returned. Valid values are 0, 1, and 3. Requests specifying an
        /// invalid value will be rejected. Requests for policies with any conditional bindings must specify version 3.
        /// Policies without any conditional bindings may specify any valid value or leave the field unset. To learn
        /// which resources support conditions in their IAM policies, see the [IAM
        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedPolicyVersion")]
        public virtual System.Nullable<int> RequestedPolicyVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A message representing a (sparse) collection of hot keys for specific key buckets.</summary>
    public class IndexedHotKey : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A (sparse) mapping from key bucket index to the index of the specific hot row key for that key bucket. The
        /// index of the hot row key can be translated to the actual row key via the
        /// ScanData.VisualizationData.indexed_keys repeated field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sparseHotKeys")]
        public virtual System.Collections.Generic.IDictionary<string, System.Nullable<int>> SparseHotKeys { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A message representing a (sparse) collection of KeyRangeInfos for specific key buckets.</summary>
    public class IndexedKeyRangeInfos : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A (sparse) mapping from key bucket index to the KeyRangeInfos for that key bucket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyRangeInfos")]
        public virtual System.Collections.Generic.IDictionary<string, KeyRangeInfos> KeyRangeInfos { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An isolated set of Cloud Spanner resources on which databases can be hosted.</summary>
    public class Instance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The name of the instance's configuration. Values are of the form `projects//instanceConfigs/`. See
        /// also InstanceConfig and ListInstanceConfigs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual string Config { get; set; }

        /// <summary>
        /// Required. The descriptive name for this instance as it appears in UIs. Must be unique per project and
        /// between 4 and 30 characters in length.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Deprecated. This field is not populated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpointUris")]
        public virtual System.Collections.Generic.IList<string> EndpointUris { get; set; }

        /// <summary>
        /// Cloud Labels are a flexible and lightweight mechanism for organizing cloud resources into groups that
        /// reflect a customer's organizational needs and deployment strategies. Cloud Labels can be used to filter
        /// collections of resources. They can be used to control how resource metrics are aggregated. And they can be
        /// used as arguments to policy management rules (e.g. route, firewall, load balancing, etc.). * Label keys must
        /// be between 1 and 63 characters long and must conform to the following regular expression:
        /// `[a-z]([-a-z0-9]*[a-z0-9])?`. * Label values must be between 0 and 63 characters long and must conform to
        /// the regular expression `([a-z]([-a-z0-9]*[a-z0-9])?)?`. * No more than 64 labels can be associated with a
        /// given resource. See https://goo.gl/xmQnxf for more information on and examples of labels. If you plan to use
        /// labels in your own code, please note that additional characters may be allowed in the future. And so you are
        /// advised to use an internal label representation, such as JSON, which doesn't rely upon specific characters
        /// being disallowed. For example, representing labels as the string: name + "_" + value would prove problematic
        /// if we were to allow "_" in a future release.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Required. A unique identifier for the instance, which cannot be changed after the instance is created.
        /// Values are of the form `projects//instances/a-z*[a-z0-9]`. The final segment of the name must be between 2
        /// and 64 characters in length.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The number of nodes allocated to this instance. This may be zero in API responses for instances that are not
        /// yet in state `READY`. See [the documentation](https://cloud.google.com/spanner/docs/instances#node_count)
        /// for more information about nodes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeCount")]
        public virtual System.Nullable<int> NodeCount { get; set; }

        /// <summary>
        /// The number of processing units allocated to this instance. At most one of processing_units or node_count
        /// should be present in the message. This may be zero in API responses for instances that are not yet in state
        /// `READY`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processingUnits")]
        public virtual System.Nullable<int> ProcessingUnits { get; set; }

        /// <summary>
        /// Output only. The current instance state. For CreateInstance, the state must be either omitted or set to
        /// `CREATING`. For UpdateInstance, the state must be either omitted or set to `READY`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A possible configuration for a Cloud Spanner instance. Configurations define the geographic placement of nodes
    /// and their replication.
    /// </summary>
    public class InstanceConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of this instance configuration as it appears in UIs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Allowed values of the “default_leader” schema option for databases in instances that use this instance
        /// configuration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("leaderOptions")]
        public virtual System.Collections.Generic.IList<string> LeaderOptions { get; set; }

        /// <summary>
        /// A unique identifier for the instance configuration. Values are of the form `projects//instanceConfigs/a-z*`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The geographic placement of nodes in this instance configuration and their replication properties.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replicas")]
        public virtual System.Collections.Generic.IList<ReplicaInfo> Replicas { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// KeyRange represents a range of rows in a table or index. A range has a start key and an end key. These keys can
    /// be open or closed, indicating if the range includes rows with that key. Keys are represented by lists, where the
    /// ith value in the list corresponds to the ith component of the table or index primary key. Individual values are
    /// encoded as described here. For example, consider the following table definition: CREATE TABLE UserEvents (
    /// UserName STRING(MAX), EventDate STRING(10) ) PRIMARY KEY(UserName, EventDate); The following keys name rows in
    /// this table: "Bob", "2014-09-23" Since the `UserEvents` table's `PRIMARY KEY` clause names two columns, each
    /// `UserEvents` key has two elements; the first is the `UserName`, and the second is the `EventDate`. Key ranges
    /// with multiple components are interpreted lexicographically by component using the table or index key's declared
    /// sort order. For example, the following range returns all events for user `"Bob"` that occurred in the year 2015:
    /// "start_closed": ["Bob", "2015-01-01"] "end_closed": ["Bob", "2015-12-31"] Start and end keys can omit trailing
    /// key components. This affects the inclusion and exclusion of rows that exactly match the provided key components:
    /// if the key is closed, then rows that exactly match the provided components are included; if the key is open,
    /// then rows that exactly match are not included. For example, the following range includes all events for `"Bob"`
    /// that occurred during and after the year 2000: "start_closed": ["Bob", "2000-01-01"] "end_closed": ["Bob"] The
    /// next example retrieves all events for `"Bob"`: "start_closed": ["Bob"] "end_closed": ["Bob"] To retrieve events
    /// before the year 2000: "start_closed": ["Bob"] "end_open": ["Bob", "2000-01-01"] The following range includes all
    /// rows in the table: "start_closed": [] "end_closed": [] This range returns all users whose `UserName` begins with
    /// any character from A to C: "start_closed": ["A"] "end_open": ["D"] This range returns all users whose `UserName`
    /// begins with B: "start_closed": ["B"] "end_open": ["C"] Key ranges honor column sort order. For example, suppose
    /// a table is defined as follows: CREATE TABLE DescendingSortedTable { Key INT64, ... ) PRIMARY KEY(Key DESC); The
    /// following range retrieves all rows with key values between 1 and 100 inclusive: "start_closed": ["100"]
    /// "end_closed": ["1"] Note that 100 is passed as the start, and 1 is passed as the end, because `Key` is a
    /// descending column in the schema.
    /// </summary>
    public class KeyRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If the end is closed, then the range includes all rows whose first `len(end_closed)` key columns exactly
        /// match `end_closed`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endClosed")]
        public virtual System.Collections.Generic.IList<object> EndClosed { get; set; }

        /// <summary>
        /// If the end is open, then the range excludes rows whose first `len(end_open)` key columns exactly match
        /// `end_open`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endOpen")]
        public virtual System.Collections.Generic.IList<object> EndOpen { get; set; }

        /// <summary>
        /// If the start is closed, then the range includes all rows whose first `len(start_closed)` key columns exactly
        /// match `start_closed`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startClosed")]
        public virtual System.Collections.Generic.IList<object> StartClosed { get; set; }

        /// <summary>
        /// If the start is open, then the range excludes rows whose first `len(start_open)` key columns exactly match
        /// `start_open`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startOpen")]
        public virtual System.Collections.Generic.IList<object> StartOpen { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A message representing information for a key range (possibly one key).</summary>
    public class KeyRangeInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of context values for this key range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contextValues")]
        public virtual System.Collections.Generic.IList<ContextValue> ContextValues { get; set; }

        /// <summary>The index of the end key in indexed_keys.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endKeyIndex")]
        public virtual System.Nullable<int> EndKeyIndex { get; set; }

        /// <summary>Information about this key range, for all metrics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("info")]
        public virtual LocalizedString Info { get; set; }

        /// <summary>The number of keys this range covers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keysCount")]
        public virtual System.Nullable<long> KeysCount { get; set; }

        /// <summary>The name of the metric. e.g. "latency".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metric")]
        public virtual LocalizedString Metric { get; set; }

        /// <summary>The index of the start key in indexed_keys.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startKeyIndex")]
        public virtual System.Nullable<int> StartKeyIndex { get; set; }

        /// <summary>The time offset. This is the time since the start of the time interval.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeOffset")]
        public virtual object TimeOffset { get; set; }

        /// <summary>
        /// The unit of the metric. This is an unstructured field and will be mapped as is to the user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unit")]
        public virtual LocalizedString Unit { get; set; }

        /// <summary>The value of the metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Nullable<float> Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A message representing a list of specific information for multiple key ranges.</summary>
    public class KeyRangeInfos : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list individual KeyRangeInfos.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("infos")]
        public virtual System.Collections.Generic.IList<KeyRangeInfo> Infos { get; set; }

        /// <summary>
        /// The total size of the list of all KeyRangeInfos. This may be larger than the number of repeated messages
        /// above. If that is the case, this number may be used to determine how many are not being shown.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalSize")]
        public virtual System.Nullable<int> TotalSize { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// `KeySet` defines a collection of Cloud Spanner keys and/or key ranges. All the keys are expected to be in the
    /// same table or index. The keys need not be sorted in any particular way. If the same key is specified multiple
    /// times in the set (for example if two ranges, two keys, or a key and a range overlap), Cloud Spanner behaves as
    /// if the key were only specified once.
    /// </summary>
    public class KeySet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// For convenience `all` can be set to `true` to indicate that this `KeySet` matches all keys in the table or
        /// index. Note that any keys specified in `keys` or `ranges` are only yielded once.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("all")]
        public virtual System.Nullable<bool> All { get; set; }

        /// <summary>
        /// A list of specific keys. Entries in `keys` should have exactly as many elements as there are columns in the
        /// primary or index key with which this `KeySet` is used. Individual key values are encoded as described here.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keys")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IList<object>> Keys { get; set; }

        /// <summary>A list of key ranges. See KeyRange for more information about key range specifications.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ranges")]
        public virtual System.Collections.Generic.IList<KeyRange> Ranges { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for ListBackupOperations.</summary>
    public class ListBackupOperationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// `next_page_token` can be sent in a subsequent ListBackupOperations call to fetch more of the matching
        /// metadata.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// The list of matching backup long-running operations. Each operation's name will be prefixed by the backup's
        /// name and the operation's metadata will be of type CreateBackupMetadata. Operations returned include those
        /// that are pending or have completed/failed/canceled within the last 7 days. Operations returned are ordered
        /// by `operation.metadata.value.progress.start_time` in descending order starting from the most recently
        /// started operation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operations")]
        public virtual System.Collections.Generic.IList<Operation> Operations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for ListBackups.</summary>
    public class ListBackupsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The list of matching backups. Backups returned are ordered by `create_time` in descending order, starting
        /// from the most recent `create_time`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backups")]
        public virtual System.Collections.Generic.IList<Backup> Backups { get; set; }

        /// <summary>
        /// `next_page_token` can be sent in a subsequent ListBackups call to fetch more of the matching backups.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for ListDatabaseOperations.</summary>
    public class ListDatabaseOperationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// `next_page_token` can be sent in a subsequent ListDatabaseOperations call to fetch more of the matching
        /// metadata.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// The list of matching database long-running operations. Each operation's name will be prefixed by the
        /// database's name. The operation's metadata field type `metadata.type_url` describes the type of the metadata.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operations")]
        public virtual System.Collections.Generic.IList<Operation> Operations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for ListDatabases.</summary>
    public class ListDatabasesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Databases that matched the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databases")]
        public virtual System.Collections.Generic.IList<Database> Databases { get; set; }

        /// <summary>
        /// `next_page_token` can be sent in a subsequent ListDatabases call to fetch more of the matching databases.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for ListInstanceConfigs.</summary>
    public class ListInstanceConfigsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of requested instance configurations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceConfigs")]
        public virtual System.Collections.Generic.IList<InstanceConfig> InstanceConfigs { get; set; }

        /// <summary>
        /// `next_page_token` can be sent in a subsequent ListInstanceConfigs call to fetch more of the matching
        /// instance configurations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for ListInstances.</summary>
    public class ListInstancesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of requested instances.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instances")]
        public virtual System.Collections.Generic.IList<Instance> Instances { get; set; }

        /// <summary>
        /// `next_page_token` can be sent in a subsequent ListInstances call to fetch more of the matching instances.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// The list of unreachable instances. It includes the names of instances whose metadata could not be retrieved
        /// within instance_deadline.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

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

    /// <summary>Response method from the ListScans method.</summary>
    public class ListScansResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Available scans based on the list query parameters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scans")]
        public virtual System.Collections.Generic.IList<Scan> Scans { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for ListSessions.</summary>
    public class ListSessionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// `next_page_token` can be sent in a subsequent ListSessions call to fetch more of the matching sessions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of requested sessions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sessions")]
        public virtual System.Collections.Generic.IList<Session> Sessions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A message representing a user-facing string whose value may need to be translated before being displayed.
    /// </summary>
    public class LocalizedString : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A map of arguments used when creating the localized message. Keys represent parameter names which may be
        /// used by the localized version when substituting dynamic values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("args")]
        public virtual System.Collections.Generic.IDictionary<string, string> Args { get; set; }

        /// <summary>
        /// The canonical English version of this message. If no token is provided or the front-end has no message
        /// associated with the token, this text will be displayed as-is.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>
        /// The token identifying the message, e.g. 'METRIC_READ_CPU'. This should be unique within the service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("token")]
        public virtual string Token { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A message representing the actual monitoring data, values for each key bucket over time, of a metric.
    /// </summary>
    public class Metric : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The aggregation function used to aggregate each key bucket</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aggregation")]
        public virtual string Aggregation { get; set; }

        /// <summary>The category of the metric, e.g. "Activity", "Alerts", "Reads", etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual LocalizedString Category { get; set; }

        /// <summary>The references to numerator and denominator metrics for a derived metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("derived")]
        public virtual DerivedMetric Derived { get; set; }

        /// <summary>The displayed label of the metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayLabel")]
        public virtual LocalizedString DisplayLabel { get; set; }

        /// <summary>Whether the metric has any non-zero data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasNonzeroData")]
        public virtual System.Nullable<bool> HasNonzeroData { get; set; }

        /// <summary>
        /// The value that is considered hot for the metric. On a per metric basis hotness signals high utilization and
        /// something that might potentially be a cause for concern by the end user. hot_value is used to calibrate and
        /// scale visual color scales.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hotValue")]
        public virtual System.Nullable<float> HotValue { get; set; }

        /// <summary>
        /// The (sparse) mapping from time index to an IndexedHotKey message, representing those time intervals for
        /// which there are hot keys.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indexedHotKeys")]
        public virtual System.Collections.Generic.IDictionary<string, IndexedHotKey> IndexedHotKeys { get; set; }

        /// <summary>
        /// The (sparse) mapping from time interval index to an IndexedKeyRangeInfos message, representing those time
        /// intervals for which there are informational messages concerning key ranges.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indexedKeyRangeInfos")]
        public virtual System.Collections.Generic.IDictionary<string, IndexedKeyRangeInfos> IndexedKeyRangeInfos { get; set; }

        /// <summary>Information about the metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("info")]
        public virtual LocalizedString Info { get; set; }

        /// <summary>The data for the metric as a matrix.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matrix")]
        public virtual MetricMatrix Matrix { get; set; }

        /// <summary>The unit of the metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unit")]
        public virtual LocalizedString Unit { get; set; }

        /// <summary>Whether the metric is visible to the end user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visible")]
        public virtual System.Nullable<bool> Visible { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A message representing a matrix of floats.</summary>
    public class MetricMatrix : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The rows of the matrix.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Collections.Generic.IList<MetricMatrixRow> Rows { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A message representing a row of a matrix of floats.</summary>
    public class MetricMatrixRow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The columns of the row.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cols")]
        public virtual System.Collections.Generic.IList<System.Nullable<float>> Cols { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A modification to one or more Cloud Spanner rows. Mutations can be applied to a Cloud Spanner database by
    /// sending them in a Commit call.
    /// </summary>
    public class Mutation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Delete rows from a table. Succeeds whether or not the named rows were present.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("delete")]
        public virtual Delete Delete { get; set; }

        /// <summary>
        /// Insert new rows in a table. If any of the rows already exist, the write or transaction fails with error
        /// `ALREADY_EXISTS`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insert")]
        public virtual Write Insert { get; set; }

        /// <summary>
        /// Like insert, except that if the row already exists, then its column values are overwritten with the ones
        /// provided. Any column values not explicitly written are preserved. When using insert_or_update, just as when
        /// using insert, all `NOT NULL` columns in the table must be given a value. This holds true even when the row
        /// already exists and will therefore actually be updated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insertOrUpdate")]
        public virtual Write InsertOrUpdate { get; set; }

        /// <summary>
        /// Like insert, except that if the row already exists, it is deleted, and the column values provided are
        /// inserted instead. Unlike insert_or_update, this means any values not explicitly written become `NULL`. In an
        /// interleaved table, if you create the child table with the `ON DELETE CASCADE` annotation, then replacing a
        /// parent row also deletes the child rows. Otherwise, you must delete the child rows before you replace the
        /// parent row.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replace")]
        public virtual Write Replace { get; set; }

        /// <summary>
        /// Update existing rows in a table. If any of the rows does not already exist, the transaction fails with error
        /// `NOT_FOUND`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("update")]
        public virtual Write Update { get; set; }

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

    /// <summary>Encapsulates progress related information for a Cloud Spanner long running operation.</summary>
    public class OperationProgress : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If set, the time at which this operation failed or was completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>Percent completion of the operation. Values are between 0 and 100 inclusive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressPercent")]
        public virtual System.Nullable<int> ProgressPercent { get; set; }

        /// <summary>Time the request was received.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata type for the long-running operation used to track the progress of optimizations performed on a newly
    /// restored database. This long-running operation is automatically created by the system after the successful
    /// completion of a database restore, and cannot be cancelled.
    /// </summary>
    public class OptimizeRestoredDatabaseMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the restored database being optimized.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The progress of the post-restore optimizations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progress")]
        public virtual OperationProgress Progress { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Partial results from a streaming read or SQL query. Streaming reads and SQL queries better tolerate large result
    /// sets, large rows, and large values, but are a little trickier to consume.
    /// </summary>
    public class PartialResultSet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If true, then the final value in values is chunked, and must be combined with more values from subsequent
        /// `PartialResultSet`s to obtain a complete field value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chunkedValue")]
        public virtual System.Nullable<bool> ChunkedValue { get; set; }

        /// <summary>
        /// Metadata about the result set, such as row type information. Only present in the first response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual ResultSetMetadata Metadata { get; set; }

        /// <summary>
        /// Streaming calls might be interrupted for a variety of reasons, such as TCP connection loss. If this occurs,
        /// the stream of results can be resumed by re-sending the original request and including `resume_token`. Note
        /// that executing any other transaction in the same session invalidates the token.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resumeToken")]
        public virtual string ResumeToken { get; set; }

        /// <summary>
        /// Query plan and execution statistics for the statement that produced this streaming result set. These can be
        /// requested by setting ExecuteSqlRequest.query_mode and are sent only once with the last response in the
        /// stream. This field will also be present in the last response for DML statements.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stats")]
        public virtual ResultSetStats Stats { get; set; }

        /// <summary>
        /// A streamed result set consists of a stream of values, which might be split into many `PartialResultSet`
        /// messages to accommodate large rows and/or large values. Every N complete values defines a row, where N is
        /// equal to the number of entries in metadata.row_type.fields. Most values are encoded based on type as
        /// described here. It is possible that the last value in values is "chunked", meaning that the rest of the
        /// value is sent in subsequent `PartialResultSet`(s). This is denoted by the chunked_value field. Two or more
        /// chunked values can be merged to form a complete value as follows: * `bool/number/null`: cannot be chunked *
        /// `string`: concatenate the strings * `list`: concatenate the lists. If the last element in a list is a
        /// `string`, `list`, or `object`, merge it with the first element in the next list by applying these rules
        /// recursively. * `object`: concatenate the (field name, field value) pairs. If a field name is duplicated,
        /// then apply these rules recursively to merge the field values. Some examples of merging: # Strings are
        /// concatenated. "foo", "bar" =&amp;gt; "foobar" # Lists of non-strings are concatenated. [2, 3], [4] =&amp;gt;
        /// [2, 3, 4] # Lists are concatenated, but the last and first elements are merged # because they are strings.
        /// ["a", "b"], ["c", "d"] =&amp;gt; ["a", "bc", "d"] # Lists are concatenated, but the last and first elements
        /// are merged # because they are lists. Recursively, the last and first elements # of the inner lists are
        /// merged because they are strings. ["a", ["b", "c"]], [["d"], "e"] =&amp;gt; ["a", ["b", "cd"], "e"] #
        /// Non-overlapping object fields are combined. {"a": "1"}, {"b": "2"} =&amp;gt; {"a": "1", "b": 2"} #
        /// Overlapping object fields are merged. {"a": "1"}, {"a": "2"} =&amp;gt; {"a": "12"} # Examples of merging
        /// objects containing lists of strings. {"a": ["1"]}, {"a": ["2"]} =&amp;gt; {"a": ["12"]} For a more complete
        /// example, suppose a streaming SQL query is yielding a result set whose rows contain a single string field.
        /// The following `PartialResultSet`s might be yielded: { "metadata": { ... } "values": ["Hello", "W"]
        /// "chunked_value": true "resume_token": "Af65..." } { "values": ["orl"] "chunked_value": true "resume_token":
        /// "Bqp2..." } { "values": ["d"] "resume_token": "Zx1B..." } This sequence of `PartialResultSet`s encodes two
        /// rows, one containing the field value `"Hello"`, and a second containing the field value `"World" = "W" +
        /// "orl" + "d"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<object> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information returned for each partition returned in a PartitionResponse.</summary>
    public class Partition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// This token can be passed to Read, StreamingRead, ExecuteSql, or ExecuteStreamingSql requests to restrict the
        /// results to those identified by this partition token.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partitionToken")]
        public virtual string PartitionToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Options for a PartitionQueryRequest and PartitionReadRequest.</summary>
    public class PartitionOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// **Note:** This hint is currently ignored by PartitionQuery and PartitionRead requests. The desired maximum
        /// number of partitions to return. For example, this may be set to the number of workers available. The default
        /// for this option is currently 10,000. The maximum value is currently 200,000. This is only a hint. The actual
        /// number of partitions returned may be smaller or larger than this maximum count request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxPartitions")]
        public virtual System.Nullable<long> MaxPartitions { get; set; }

        /// <summary>
        /// **Note:** This hint is currently ignored by PartitionQuery and PartitionRead requests. The desired data size
        /// for each partition generated. The default for this option is currently 1 GiB. This is only a hint. The
        /// actual size of each partition may be smaller or larger than this size request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partitionSizeBytes")]
        public virtual System.Nullable<long> PartitionSizeBytes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for PartitionQuery</summary>
    public class PartitionQueryRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// It is not always possible for Cloud Spanner to infer the right SQL type from a JSON value. For example,
        /// values of type `BYTES` and values of type `STRING` both appear in params as JSON strings. In these cases,
        /// `param_types` can be used to specify the exact SQL type for some or all of the SQL query parameters. See the
        /// definition of Type for more information about SQL types.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paramTypes")]
        public virtual System.Collections.Generic.IDictionary<string, Type> ParamTypes { get; set; }

        /// <summary>
        /// Parameter names and values that bind to placeholders in the SQL string. A parameter placeholder consists of
        /// the `@` character followed by the parameter name (for example, `@firstName`). Parameter names can contain
        /// letters, numbers, and underscores. Parameters can appear anywhere that a literal value is expected. The same
        /// parameter name can be used more than once, for example: `"WHERE id &amp;gt; @msg_id AND id &amp;lt; @msg_id
        /// + 100"` It is an error to execute a SQL statement with unbound parameters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("params")]
        public virtual System.Collections.Generic.IDictionary<string, object> Params__ { get; set; }

        /// <summary>Additional options that affect how many partitions are created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partitionOptions")]
        public virtual PartitionOptions PartitionOptions { get; set; }

        /// <summary>
        /// Required. The query request to generate partitions for. The request will fail if the query is not root
        /// partitionable. The query plan of a root partitionable query has a single distributed union operator. A
        /// distributed union operator conceptually divides one or more tables into multiple splits, remotely evaluates
        /// a subquery independently on each split, and then unions all results. This must not contain DML commands,
        /// such as INSERT, UPDATE, or DELETE. Use ExecuteStreamingSql with a PartitionedDml transaction for large,
        /// partition-friendly DML operations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sql")]
        public virtual string Sql { get; set; }

        /// <summary>
        /// Read only snapshot transactions are supported, read/write and single use transactions are not.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transaction")]
        public virtual TransactionSelector Transaction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for PartitionRead</summary>
    public class PartitionReadRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The columns of table to be returned for each row matching this request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columns")]
        public virtual System.Collections.Generic.IList<string> Columns { get; set; }

        /// <summary>
        /// If non-empty, the name of an index on table. This index is used instead of the table primary key when
        /// interpreting key_set and sorting result rows. See key_set for further information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("index")]
        public virtual string Index { get; set; }

        /// <summary>
        /// Required. `key_set` identifies the rows to be yielded. `key_set` names the primary keys of the rows in table
        /// to be yielded, unless index is present. If index is present, then key_set instead names index keys in index.
        /// It is not an error for the `key_set` to name rows that do not exist in the database. Read yields nothing for
        /// nonexistent rows.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keySet")]
        public virtual KeySet KeySet { get; set; }

        /// <summary>Additional options that affect how many partitions are created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partitionOptions")]
        public virtual PartitionOptions PartitionOptions { get; set; }

        /// <summary>Required. The name of the table in the database to be read.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("table")]
        public virtual string Table { get; set; }

        /// <summary>
        /// Read only snapshot transactions are supported, read/write and single use transactions are not.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transaction")]
        public virtual TransactionSelector Transaction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for PartitionQuery or PartitionRead</summary>
    public class PartitionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Partitions created by this request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partitions")]
        public virtual System.Collections.Generic.IList<Partition> Partitions { get; set; }

        /// <summary>Transaction created by this request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transaction")]
        public virtual Transaction Transaction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message type to initiate a Partitioned DML transaction.</summary>
    public class PartitionedDml : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Node information for nodes appearing in a QueryPlan.plan_nodes.</summary>
    public class PlanNode : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of child node `index`es and their relationship to this parent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("childLinks")]
        public virtual System.Collections.Generic.IList<ChildLink> ChildLinks { get; set; }

        /// <summary>The display name for the node.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// The execution statistics associated with the node, contained in a group of key-value pairs. Only present if
        /// the plan was returned as a result of a profile query. For example, number of executions, number of rows/time
        /// per execution etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionStats")]
        public virtual System.Collections.Generic.IDictionary<string, object> ExecutionStats { get; set; }

        /// <summary>The `PlanNode`'s index in node list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("index")]
        public virtual System.Nullable<int> Index { get; set; }

        /// <summary>
        /// Used to determine the type of node. May be needed for visualizing different kinds of nodes differently. For
        /// example, If the node is a SCALAR node, it will have a condensed representation which can be used to directly
        /// embed a description of the node in its parent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Attributes relevant to the node contained in a group of key-value pairs. For example, a Parameter Reference
        /// node could have the following information in its metadata: { "parameter_reference": "param1",
        /// "parameter_type": "array" }
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, object> Metadata { get; set; }

        /// <summary>Condensed representation for SCALAR nodes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shortRepresentation")]
        public virtual ShortRepresentation ShortRepresentation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An Identity and Access Management (IAM) policy, which specifies access controls for Google Cloud resources. A
    /// `Policy` is a collection of `bindings`. A `binding` binds one or more `members` to a single `role`. Members can
    /// be user accounts, service accounts, Google groups, and domains (such as G Suite). A `role` is a named list of
    /// permissions; each `role` can be an IAM predefined role or a user-created custom role. For some types of Google
    /// Cloud resources, a `binding` can also specify a `condition`, which is a logical expression that allows access to
    /// a resource only if the expression evaluates to `true`. A condition can add constraints based on attributes of
    /// the request, the resource, or both. To learn which resources support conditions in their IAM policies, see the
    /// [IAM documentation](https://cloud.google.com/iam/help/conditions/resource-policies). **JSON example:** {
    /// "bindings": [ { "role": "roles/resourcemanager.organizationAdmin", "members": [ "user:mike@example.com",
    /// "group:admins@example.com", "domain:google.com", "serviceAccount:my-project-id@appspot.gserviceaccount.com" ] },
    /// { "role": "roles/resourcemanager.organizationViewer", "members": [ "user:eve@example.com" ], "condition": {
    /// "title": "expirable access", "description": "Does not grant access after Sep 2020", "expression": "request.time
    /// &amp;lt; timestamp('2020-10-01T00:00:00.000Z')", } } ], "etag": "BwWWja0YfJA=", "version": 3 } **YAML example:**
    /// bindings: - members: - user:mike@example.com - group:admins@example.com - domain:google.com -
    /// serviceAccount:my-project-id@appspot.gserviceaccount.com role: roles/resourcemanager.organizationAdmin -
    /// members: - user:eve@example.com role: roles/resourcemanager.organizationViewer condition: title: expirable
    /// access description: Does not grant access after Sep 2020 expression: request.time &amp;lt;
    /// timestamp('2020-10-01T00:00:00.000Z') - etag: BwWWja0YfJA= - version: 3 For a description of IAM and its
    /// features, see the [IAM documentation](https://cloud.google.com/iam/docs/).
    /// </summary>
    public class Policy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Associates a list of `members` to a `role`. Optionally, may specify a `condition` that determines how and
        /// when the `bindings` are applied. Each of the `bindings` must contain at least one member.
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
    /// A message representing a key prefix node in the key prefix hierarchy. for eg. Bigtable keyspaces are
    /// lexicographically ordered mappings of keys to values. Keys often have a shared prefix structure where users use
    /// the keys to organize data. Eg ///employee In this case Keysight will possibly use one node for a company and
    /// reuse it for all employees that fall under the company. Doing so improves legibility in the UI.
    /// </summary>
    public class PrefixNode : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether this corresponds to a data_source name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSourceNode")]
        public virtual System.Nullable<bool> DataSourceNode { get; set; }

        /// <summary>The depth in the prefix hierarchy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("depth")]
        public virtual System.Nullable<int> Depth { get; set; }

        /// <summary>The index of the end key bucket of the range that this node spans.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endIndex")]
        public virtual System.Nullable<int> EndIndex { get; set; }

        /// <summary>The index of the start key bucket of the range that this node spans.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startIndex")]
        public virtual System.Nullable<int> StartIndex { get; set; }

        /// <summary>The string represented by the prefix node.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("word")]
        public virtual string Word { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Query optimizer configuration.</summary>
    public class QueryOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An option to control the selection of optimizer statistics package. This parameter allows individual queries
        /// to use a different query optimizer statistics package. Specifying `latest` as a value instructs Cloud
        /// Spanner to use the latest generated statistics package. If not specified, Cloud Spanner uses the statistics
        /// package set at the database level options, or the latest package if the database option is not set. The
        /// statistics package requested by the query has to be exempt from garbage collection. This can be achieved
        /// with the following DDL statement: ``` ALTER STATISTICS SET OPTIONS (allow_gc=false) ``` The list of
        /// available statistics packages can be queried from `INFORMATION_SCHEMA.SPANNER_STATISTICS`. Executing a SQL
        /// statement with an invalid optimizer statistics package or with a statistics package that allows garbage
        /// collection fails with an `INVALID_ARGUMENT` error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("optimizerStatisticsPackage")]
        public virtual string OptimizerStatisticsPackage { get; set; }

        /// <summary>
        /// An option to control the selection of optimizer version. This parameter allows individual queries to pick
        /// different query optimizer versions. Specifying `latest` as a value instructs Cloud Spanner to use the latest
        /// supported query optimizer version. If not specified, Cloud Spanner uses the optimizer version set at the
        /// database level options. Any other positive integer (from the list of supported optimizer versions) overrides
        /// the default optimizer version for query execution. The list of supported optimizer versions can be queried
        /// from SPANNER_SYS.SUPPORTED_OPTIMIZER_VERSIONS. Executing a SQL statement with an invalid optimizer version
        /// fails with an `INVALID_ARGUMENT` error. See
        /// https://cloud.google.com/spanner/docs/query-optimizer/manage-query-optimizer for more information on
        /// managing the query optimizer. The `optimizer_version` statement hint has precedence over this setting.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("optimizerVersion")]
        public virtual string OptimizerVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains an ordered list of nodes appearing in the query plan.</summary>
    public class QueryPlan : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The nodes in the query plan. Plan nodes are returned in pre-order starting with the plan root. Each
        /// PlanNode's `id` corresponds to its index in `plan_nodes`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("planNodes")]
        public virtual System.Collections.Generic.IList<PlanNode> PlanNodes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message type to initiate a read-only transaction.</summary>
    public class ReadOnly : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Executes all reads at a timestamp that is `exact_staleness` old. The timestamp is chosen soon after the read
        /// is started. Guarantees that all writes that have committed more than the specified number of seconds ago are
        /// visible. Because Cloud Spanner chooses the exact timestamp, this mode works even if the client's local clock
        /// is substantially skewed from Cloud Spanner commit timestamps. Useful for reading at nearby replicas without
        /// the distributed timestamp negotiation overhead of `max_staleness`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exactStaleness")]
        public virtual object ExactStaleness { get; set; }

        /// <summary>
        /// Read data at a timestamp &amp;gt;= `NOW - max_staleness` seconds. Guarantees that all writes that have
        /// committed more than the specified number of seconds ago are visible. Because Cloud Spanner chooses the exact
        /// timestamp, this mode works even if the client's local clock is substantially skewed from Cloud Spanner
        /// commit timestamps. Useful for reading the freshest data available at a nearby replica, while bounding the
        /// possible staleness if the local replica has fallen behind. Note that this option can only be used in
        /// single-use transactions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxStaleness")]
        public virtual object MaxStaleness { get; set; }

        /// <summary>
        /// Executes all reads at a timestamp &amp;gt;= `min_read_timestamp`. This is useful for requesting fresher data
        /// than some previous read, or data that is fresh enough to observe the effects of some previously committed
        /// transaction whose timestamp is known. Note that this option can only be used in single-use transactions. A
        /// timestamp in RFC3339 UTC \"Zulu\" format, accurate to nanoseconds. Example:
        /// `"2014-10-02T15:01:23.045123456Z"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minReadTimestamp")]
        public virtual object MinReadTimestamp { get; set; }

        /// <summary>
        /// Executes all reads at the given timestamp. Unlike other modes, reads at a specific timestamp are repeatable;
        /// the same read at the same timestamp always returns the same data. If the timestamp is in the future, the
        /// read will block until the specified timestamp, modulo the read's deadline. Useful for large scale consistent
        /// reads such as mapreduces, or for coordinating many reads against a consistent snapshot of the data. A
        /// timestamp in RFC3339 UTC \"Zulu\" format, accurate to nanoseconds. Example:
        /// `"2014-10-02T15:01:23.045123456Z"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readTimestamp")]
        public virtual object ReadTimestamp { get; set; }

        /// <summary>
        /// If true, the Cloud Spanner-selected read timestamp is included in the Transaction message that describes the
        /// transaction.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("returnReadTimestamp")]
        public virtual System.Nullable<bool> ReturnReadTimestamp { get; set; }

        /// <summary>Read at a timestamp where all previously committed transactions are visible.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("strong")]
        public virtual System.Nullable<bool> Strong { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for Read and StreamingRead.</summary>
    public class ReadRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The columns of table to be returned for each row matching this request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columns")]
        public virtual System.Collections.Generic.IList<string> Columns { get; set; }

        /// <summary>
        /// If non-empty, the name of an index on table. This index is used instead of the table primary key when
        /// interpreting key_set and sorting result rows. See key_set for further information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("index")]
        public virtual string Index { get; set; }

        /// <summary>
        /// Required. `key_set` identifies the rows to be yielded. `key_set` names the primary keys of the rows in table
        /// to be yielded, unless index is present. If index is present, then key_set instead names index keys in index.
        /// If the partition_token field is empty, rows are yielded in table primary key order (if index is empty) or
        /// index key order (if index is non-empty). If the partition_token field is not empty, rows will be yielded in
        /// an unspecified order. It is not an error for the `key_set` to name rows that do not exist in the database.
        /// Read yields nothing for nonexistent rows.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keySet")]
        public virtual KeySet KeySet { get; set; }

        /// <summary>
        /// If greater than zero, only the first `limit` rows are yielded. If `limit` is zero, the default is no limit.
        /// A limit cannot be specified if `partition_token` is set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("limit")]
        public virtual System.Nullable<long> Limit { get; set; }

        /// <summary>
        /// If present, results will be restricted to the specified partition previously created using PartitionRead().
        /// There must be an exact match for the values of fields common to this message and the PartitionReadRequest
        /// message used to create this partition_token.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partitionToken")]
        public virtual string PartitionToken { get; set; }

        /// <summary>Common options for this request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestOptions")]
        public virtual RequestOptions RequestOptions { get; set; }

        /// <summary>
        /// If this request is resuming a previously interrupted read, `resume_token` should be copied from the last
        /// PartialResultSet yielded before the interruption. Doing this enables the new read to resume where the last
        /// read left off. The rest of the request parameters must exactly match the request that yielded this token.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resumeToken")]
        public virtual string ResumeToken { get; set; }

        /// <summary>Required. The name of the table in the database to be read.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("table")]
        public virtual string Table { get; set; }

        /// <summary>
        /// The transaction to use. If none is provided, the default is a temporary read-only transaction with strong
        /// concurrency.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transaction")]
        public virtual TransactionSelector Transaction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Message type to initiate a read-write transaction. Currently this transaction type has no options.
    /// </summary>
    public class ReadWrite : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ReplicaInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If true, this location is designated as the default leader location where leader replicas are placed. See
        /// the [region types documentation](https://cloud.google.com/spanner/docs/instances#region_types) for more
        /// details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultLeaderLocation")]
        public virtual System.Nullable<bool> DefaultLeaderLocation { get; set; }

        /// <summary>The location of the serving resources, e.g. "us-central1".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>The type of replica.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Common request options for various APIs.</summary>
    public class RequestOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Priority for the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priority")]
        public virtual string Priority { get; set; }

        /// <summary>
        /// A per-request tag which can be applied to queries or reads, used for statistics collection. Both request_tag
        /// and transaction_tag can be specified for a read or query that belongs to a transaction. This field is
        /// ignored for requests where it's not applicable (e.g. CommitRequest). Legal characters for `request_tag`
        /// values are all printable characters (ASCII 32 - 126) and the length of a request_tag is limited to 50
        /// characters. Values that exceed this limit are truncated. Any leading underscore (_) characters will be
        /// removed from the string.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestTag")]
        public virtual string RequestTag { get; set; }

        /// <summary>
        /// A tag used for statistics collection about this transaction. Both request_tag and transaction_tag can be
        /// specified for a read or query that belongs to a transaction. The value of transaction_tag should be the same
        /// for all requests belonging to the same transaction. If this request doesn’t belong to any transaction,
        /// transaction_tag will be ignored. Legal characters for `transaction_tag` values are all printable characters
        /// (ASCII 32 - 126) and the length of a transaction_tag is limited to 50 characters. Values that exceed this
        /// limit are truncated. Any leading underscore (_) characters will be removed from the string.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transactionTag")]
        public virtual string TransactionTag { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Encryption configuration for the restored database.</summary>
    public class RestoreDatabaseEncryptionConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The encryption type of the restored database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionType")]
        public virtual string EncryptionType { get; set; }

        /// <summary>
        /// Optional. The Cloud KMS key that will be used to encrypt/decrypt the restored database. This field should be
        /// set only when encryption_type is `CUSTOMER_MANAGED_ENCRYPTION`. Values are of the form
        /// `projects//locations//keyRings//cryptoKeys/`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeyName")]
        public virtual string KmsKeyName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata type for the long-running operation returned by RestoreDatabase.</summary>
    public class RestoreDatabaseMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Information about the backup used to restore the database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupInfo")]
        public virtual BackupInfo BackupInfo { get; set; }

        /// <summary>
        /// The time at which cancellation of this operation was received. Operations.CancelOperation starts
        /// asynchronous cancellation on a long-running operation. The server makes a best effort to cancel the
        /// operation, but success is not guaranteed. Clients can use Operations.GetOperation or other methods to check
        /// whether the cancellation succeeded or whether the operation completed despite cancellation. On successful
        /// cancellation, the operation is not deleted; instead, it becomes an operation with an Operation.error value
        /// with a google.rpc.Status.code of 1, corresponding to `Code.CANCELLED`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cancelTime")]
        public virtual object CancelTime { get; set; }

        /// <summary>Name of the database being created and restored to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// If exists, the name of the long-running operation that will be used to track the post-restore optimization
        /// process to optimize the performance of the restored database, and remove the dependency on the restore
        /// source. The name is of the form `projects//instances//databases//operations/` where the is the name of
        /// database being created and restored to. The metadata type of the long-running operation is
        /// OptimizeRestoredDatabaseMetadata. This long-running operation will be automatically created by the system
        /// after the RestoreDatabase long-running operation completes successfully. This operation will not be created
        /// if the restore was not successful.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("optimizeDatabaseOperationName")]
        public virtual string OptimizeDatabaseOperationName { get; set; }

        /// <summary>The progress of the RestoreDatabase operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progress")]
        public virtual OperationProgress Progress { get; set; }

        /// <summary>The type of the restore source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceType")]
        public virtual string SourceType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for RestoreDatabase.</summary>
    public class RestoreDatabaseRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Name of the backup from which to restore. Values are of the form `projects//instances//backups/`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backup")]
        public virtual string Backup { get; set; }

        /// <summary>
        /// Required. The id of the database to create and restore to. This database must not already exist. The
        /// `database_id` appended to `parent` forms the full database name of the form
        /// `projects//instances//databases/`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseId")]
        public virtual string DatabaseId { get; set; }

        /// <summary>
        /// Optional. An encryption configuration describing the encryption type and key resources in Cloud KMS used to
        /// encrypt/decrypt the database to restore to. If this field is not specified, the restored database will use
        /// the same encryption configuration as the backup by default, namely encryption_type =
        /// `USE_CONFIG_DEFAULT_OR_BACKUP_ENCRYPTION`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionConfig")]
        public virtual RestoreDatabaseEncryptionConfig EncryptionConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about the database restore.</summary>
    public class RestoreInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Information about the backup used to restore the database. The backup may no longer exist.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupInfo")]
        public virtual BackupInfo BackupInfo { get; set; }

        /// <summary>The type of the restore source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceType")]
        public virtual string SourceType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Results from Read or ExecuteSql.</summary>
    public class ResultSet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Metadata about the result set, such as row type information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual ResultSetMetadata Metadata { get; set; }

        /// <summary>
        /// Each element in `rows` is a row whose format is defined by metadata.row_type. The ith element in each row
        /// matches the ith field in metadata.row_type. Elements are encoded based on type as described here.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IList<object>> Rows { get; set; }

        /// <summary>
        /// Query plan and execution statistics for the SQL statement that produced this result set. These can be
        /// requested by setting ExecuteSqlRequest.query_mode. DML statements always produce stats containing the number
        /// of rows modified, unless executed using the ExecuteSqlRequest.QueryMode.PLAN ExecuteSqlRequest.query_mode.
        /// Other fields may or may not be populated, based on the ExecuteSqlRequest.query_mode.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stats")]
        public virtual ResultSetStats Stats { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata about a ResultSet or PartialResultSet.</summary>
    public class ResultSetMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Indicates the field names and types for the rows in the result set. For example, a SQL query like `"SELECT
        /// UserId, UserName FROM Users"` could return a `row_type` value like: "fields": [ { "name": "UserId", "type":
        /// { "code": "INT64" } }, { "name": "UserName", "type": { "code": "STRING" } }, ]
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowType")]
        public virtual StructType RowType { get; set; }

        /// <summary>
        /// If the read or SQL query began a transaction as a side-effect, the information about the new transaction is
        /// yielded here.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transaction")]
        public virtual Transaction Transaction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Additional statistics about a ResultSet or PartialResultSet.</summary>
    public class ResultSetStats : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>QueryPlan for the query associated with this result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryPlan")]
        public virtual QueryPlan QueryPlan { get; set; }

        /// <summary>
        /// Aggregated statistics from the execution of the query. Only present when the query is profiled. For example,
        /// a query could return the statistics as follows: { "rows_returned": "3", "elapsed_time": "1.22 secs",
        /// "cpu_time": "1.19 secs" }
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryStats")]
        public virtual System.Collections.Generic.IDictionary<string, object> QueryStats { get; set; }

        /// <summary>Standard DML returns an exact count of rows that were modified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowCountExact")]
        public virtual System.Nullable<long> RowCountExact { get; set; }

        /// <summary>
        /// Partitioned DML does not offer exactly-once semantics, so it returns a lower bound of the rows modified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowCountLowerBound")]
        public virtual System.Nullable<long> RowCountLowerBound { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for Rollback.</summary>
    public class RollbackRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The transaction to roll back.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transactionId")]
        public virtual string TransactionId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Scan is a structure which describes Cloud Key Visualizer scan information.</summary>
    public class Scan : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Additional information provided by the implementer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual System.Collections.Generic.IDictionary<string, object> Details { get; set; }

        /// <summary>The upper bound for when the scan is defined.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>
        /// The unique name of the scan, specific to the Database service implementing this interface.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. Cloud Key Visualizer scan data. Note, this field is not available to the ListScans method.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scanData")]
        public virtual ScanData ScanData { get; set; }

        /// <summary>
        /// A range of time (inclusive) for when the scan is defined. The lower bound for when the scan is defined.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// ScanData contains Cloud Key Visualizer scan data used by the caller to construct a visualization.
    /// </summary>
    public class ScanData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Cloud Key Visualizer scan data. The range of time this information covers is captured via the above time
        /// range fields. Note, this field is not available to the ListScans method.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual VisualizationData Data { get; set; }

        /// <summary>The upper bound for when the contained data is defined.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>
        /// A range of time (inclusive) for when the contained data is defined. The lower bound for when the contained
        /// data is defined.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A session in the Cloud Spanner API.</summary>
    public class Session : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The approximate timestamp when the session is last used. It is typically earlier than the
        /// actual last use time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("approximateLastUseTime")]
        public virtual object ApproximateLastUseTime { get; set; }

        /// <summary>Output only. The timestamp when the session is created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// The labels for the session. * Label keys must be between 1 and 63 characters long and must conform to the
        /// following regular expression: `[a-z]([-a-z0-9]*[a-z0-9])?`. * Label values must be between 0 and 63
        /// characters long and must conform to the regular expression `([a-z]([-a-z0-9]*[a-z0-9])?)?`. * No more than
        /// 64 labels can be associated with a given session. See https://goo.gl/xmQnxf for more information on and
        /// examples of labels.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Output only. The name of the session. This is always system-assigned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for `SetIamPolicy` method.</summary>
    public class SetIamPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of the policy is limited to a few
        /// 10s of KB. An empty policy is a valid policy but certain Cloud Platform services (such as Projects) might
        /// reject them.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual Policy Policy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Condensed representation of a node and its subtree. Only present for `SCALAR` PlanNode(s).</summary>
    public class ShortRepresentation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A string representation of the expression subtree rooted at this node.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// A mapping of (subquery variable name) -&amp;gt; (subquery node id) for cases where the `description` string
        /// of this node references a `SCALAR` subquery contained in the expression subtree rooted at this node. The
        /// referenced `SCALAR` subquery may not necessarily be a direct child of this node.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subqueries")]
        public virtual System.Collections.Generic.IDictionary<string, System.Nullable<int>> Subqueries { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single DML statement.</summary>
    public class Statement : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// It is not always possible for Cloud Spanner to infer the right SQL type from a JSON value. For example,
        /// values of type `BYTES` and values of type `STRING` both appear in params as JSON strings. In these cases,
        /// `param_types` can be used to specify the exact SQL type for some or all of the SQL statement parameters. See
        /// the definition of Type for more information about SQL types.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paramTypes")]
        public virtual System.Collections.Generic.IDictionary<string, Type> ParamTypes { get; set; }

        /// <summary>
        /// Parameter names and values that bind to placeholders in the DML string. A parameter placeholder consists of
        /// the `@` character followed by the parameter name (for example, `@firstName`). Parameter names can contain
        /// letters, numbers, and underscores. Parameters can appear anywhere that a literal value is expected. The same
        /// parameter name can be used more than once, for example: `"WHERE id &amp;gt; @msg_id AND id &amp;lt; @msg_id
        /// + 100"` It is an error to execute a SQL statement with unbound parameters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("params")]
        public virtual System.Collections.Generic.IDictionary<string, object> Params__ { get; set; }

        /// <summary>Required. The DML string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sql")]
        public virtual string Sql { get; set; }

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

    /// <summary>`StructType` defines the fields of a STRUCT type.</summary>
    public class StructType : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The list of fields that make up this struct. Order is significant, because values of this struct type are
        /// represented as lists, where the order of field values matches the order of fields in the StructType. In
        /// turn, the order of fields matches the order of columns in a read request, or the order of fields in the
        /// `SELECT` clause of a query.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual System.Collections.Generic.IList<Field> Fields { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for `TestIamPermissions` method.</summary>
    public class TestIamPermissionsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// REQUIRED: The set of permissions to check for 'resource'. Permissions with wildcards (such as '*',
        /// 'spanner.*', 'spanner.instances.*') are not allowed.
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

    /// <summary>A transaction.</summary>
    public class Transaction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// `id` may be used to identify the transaction in subsequent Read, ExecuteSql, Commit, or Rollback calls.
        /// Single-use read-only transactions do not have IDs, because single-use transactions do not support multiple
        /// requests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// For snapshot read-only transactions, the read timestamp chosen for the transaction. Not returned by default:
        /// see TransactionOptions.ReadOnly.return_read_timestamp. A timestamp in RFC3339 UTC \"Zulu\" format, accurate
        /// to nanoseconds. Example: `"2014-10-02T15:01:23.045123456Z"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readTimestamp")]
        public virtual object ReadTimestamp { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Transactions: Each session can have at most one active transaction at a time (note that standalone reads and
    /// queries use a transaction internally and do count towards the one transaction limit). After the active
    /// transaction is completed, the session can immediately be re-used for the next transaction. It is not necessary
    /// to create a new session for each transaction. Transaction Modes: Cloud Spanner supports three transaction modes:
    /// 1. Locking read-write. This type of transaction is the only way to write data into Cloud Spanner. These
    /// transactions rely on pessimistic locking and, if necessary, two-phase commit. Locking read-write transactions
    /// may abort, requiring the application to retry. 2. Snapshot read-only. This transaction type provides guaranteed
    /// consistency across several reads, but does not allow writes. Snapshot read-only transactions can be configured
    /// to read at timestamps in the past. Snapshot read-only transactions do not need to be committed. 3. Partitioned
    /// DML. This type of transaction is used to execute a single Partitioned DML statement. Partitioned DML partitions
    /// the key space and runs the DML statement over each partition in parallel using separate, internal transactions
    /// that commit independently. Partitioned DML transactions do not need to be committed. For transactions that only
    /// read, snapshot read-only transactions provide simpler semantics and are almost always faster. In particular,
    /// read-only transactions do not take locks, so they do not conflict with read-write transactions. As a consequence
    /// of not taking locks, they also do not abort, so retry loops are not needed. Transactions may only read/write
    /// data in a single database. They may, however, read/write data in different tables within that database. Locking
    /// Read-Write Transactions: Locking transactions may be used to atomically read-modify-write data anywhere in a
    /// database. This type of transaction is externally consistent. Clients should attempt to minimize the amount of
    /// time a transaction is active. Faster transactions commit with higher probability and cause less contention.
    /// Cloud Spanner attempts to keep read locks active as long as the transaction continues to do reads, and the
    /// transaction has not been terminated by Commit or Rollback. Long periods of inactivity at the client may cause
    /// Cloud Spanner to release a transaction's locks and abort it. Conceptually, a read-write transaction consists of
    /// zero or more reads or SQL statements followed by Commit. At any time before Commit, the client can send a
    /// Rollback request to abort the transaction. Semantics: Cloud Spanner can commit the transaction if all read locks
    /// it acquired are still valid at commit time, and it is able to acquire write locks for all writes. Cloud Spanner
    /// can abort the transaction for any reason. If a commit attempt returns `ABORTED`, Cloud Spanner guarantees that
    /// the transaction has not modified any user data in Cloud Spanner. Unless the transaction commits, Cloud Spanner
    /// makes no guarantees about how long the transaction's locks were held for. It is an error to use Cloud Spanner
    /// locks for any sort of mutual exclusion other than between Cloud Spanner transactions themselves. Retrying
    /// Aborted Transactions: When a transaction aborts, the application can choose to retry the whole transaction
    /// again. To maximize the chances of successfully committing the retry, the client should execute the retry in the
    /// same session as the original attempt. The original session's lock priority increases with each consecutive
    /// abort, meaning that each attempt has a slightly better chance of success than the previous. Under some
    /// circumstances (e.g., many transactions attempting to modify the same row(s)), a transaction can abort many times
    /// in a short period before successfully committing. Thus, it is not a good idea to cap the number of retries a
    /// transaction can attempt; instead, it is better to limit the total amount of wall time spent retrying. Idle
    /// Transactions: A transaction is considered idle if it has no outstanding reads or SQL queries and has not started
    /// a read or SQL query within the last 10 seconds. Idle transactions can be aborted by Cloud Spanner so that they
    /// don't hold on to locks indefinitely. In that case, the commit will fail with error `ABORTED`. If this behavior
    /// is undesirable, periodically executing a simple SQL query in the transaction (e.g., `SELECT 1`) prevents the
    /// transaction from becoming idle. Snapshot Read-Only Transactions: Snapshot read-only transactions provides a
    /// simpler method than locking read-write transactions for doing several consistent reads. However, this type of
    /// transaction does not support writes. Snapshot transactions do not take locks. Instead, they work by choosing a
    /// Cloud Spanner timestamp, then executing all reads at that timestamp. Since they do not acquire locks, they do
    /// not block concurrent read-write transactions. Unlike locking read-write transactions, snapshot read-only
    /// transactions never abort. They can fail if the chosen read timestamp is garbage collected; however, the default
    /// garbage collection policy is generous enough that most applications do not need to worry about this in practice.
    /// Snapshot read-only transactions do not need to call Commit or Rollback (and in fact are not permitted to do so).
    /// To execute a snapshot transaction, the client specifies a timestamp bound, which tells Cloud Spanner how to
    /// choose a read timestamp. The types of timestamp bound are: - Strong (the default). - Bounded staleness. - Exact
    /// staleness. If the Cloud Spanner database to be read is geographically distributed, stale read-only transactions
    /// can execute more quickly than strong or read-write transaction, because they are able to execute far from the
    /// leader replica. Each type of timestamp bound is discussed in detail below. Strong: Strong reads are guaranteed
    /// to see the effects of all transactions that have committed before the start of the read. Furthermore, all rows
    /// yielded by a single read are consistent with each other -- if any part of the read observes a transaction, all
    /// parts of the read see the transaction. Strong reads are not repeatable: two consecutive strong read-only
    /// transactions might return inconsistent results if there are concurrent writes. If consistency across reads is
    /// required, the reads should be executed within a transaction or at an exact read timestamp. See
    /// TransactionOptions.ReadOnly.strong. Exact Staleness: These timestamp bounds execute reads at a user-specified
    /// timestamp. Reads at a timestamp are guaranteed to see a consistent prefix of the global transaction history:
    /// they observe modifications done by all transactions with a commit timestamp &amp;lt;= the read timestamp, and
    /// observe none of the modifications done by transactions with a larger commit timestamp. They will block until all
    /// conflicting transactions that may be assigned commit timestamps &amp;lt;= the read timestamp have finished. The
    /// timestamp can either be expressed as an absolute Cloud Spanner commit timestamp or a staleness relative to the
    /// current time. These modes do not require a "negotiation phase" to pick a timestamp. As a result, they execute
    /// slightly faster than the equivalent boundedly stale concurrency modes. On the other hand, boundedly stale reads
    /// usually return fresher results. See TransactionOptions.ReadOnly.read_timestamp and
    /// TransactionOptions.ReadOnly.exact_staleness. Bounded Staleness: Bounded staleness modes allow Cloud Spanner to
    /// pick the read timestamp, subject to a user-provided staleness bound. Cloud Spanner chooses the newest timestamp
    /// within the staleness bound that allows execution of the reads at the closest available replica without blocking.
    /// All rows yielded are consistent with each other -- if any part of the read observes a transaction, all parts of
    /// the read see the transaction. Boundedly stale reads are not repeatable: two stale reads, even if they use the
    /// same staleness bound, can execute at different timestamps and thus return inconsistent results. Boundedly stale
    /// reads execute in two phases: the first phase negotiates a timestamp among all replicas needed to serve the read.
    /// In the second phase, reads are executed at the negotiated timestamp. As a result of the two phase execution,
    /// bounded staleness reads are usually a little slower than comparable exact staleness reads. However, they are
    /// typically able to return fresher results, and are more likely to execute at the closest replica. Because the
    /// timestamp negotiation requires up-front knowledge of which rows will be read, it can only be used with
    /// single-use read-only transactions. See TransactionOptions.ReadOnly.max_staleness and
    /// TransactionOptions.ReadOnly.min_read_timestamp. Old Read Timestamps and Garbage Collection: Cloud Spanner
    /// continuously garbage collects deleted and overwritten data in the background to reclaim storage space. This
    /// process is known as "version GC". By default, version GC reclaims versions after they are one hour old. Because
    /// of this, Cloud Spanner cannot perform reads at read timestamps more than one hour in the past. This restriction
    /// also applies to in-progress reads and/or SQL queries whose timestamp become too old while executing. Reads and
    /// SQL queries with too-old read timestamps fail with the error `FAILED_PRECONDITION`. Partitioned DML
    /// Transactions: Partitioned DML transactions are used to execute DML statements with a different execution
    /// strategy that provides different, and often better, scalability properties for large, table-wide operations than
    /// DML in a ReadWrite transaction. Smaller scoped statements, such as an OLTP workload, should prefer using
    /// ReadWrite transactions. Partitioned DML partitions the keyspace and runs the DML statement on each partition in
    /// separate, internal transactions. These transactions commit automatically when complete, and run independently
    /// from one another. To reduce lock contention, this execution strategy only acquires read locks on rows that match
    /// the WHERE clause of the statement. Additionally, the smaller per-partition transactions hold locks for less
    /// time. That said, Partitioned DML is not a drop-in replacement for standard DML used in ReadWrite transactions. -
    /// The DML statement must be fully-partitionable. Specifically, the statement must be expressible as the union of
    /// many statements which each access only a single row of the table. - The statement is not applied atomically to
    /// all rows of the table. Rather, the statement is applied atomically to partitions of the table, in independent
    /// transactions. Secondary index rows are updated atomically with the base table rows. - Partitioned DML does not
    /// guarantee exactly-once execution semantics against a partition. The statement will be applied at least once to
    /// each partition. It is strongly recommended that the DML statement should be idempotent to avoid unexpected
    /// results. For instance, it is potentially dangerous to run a statement such as `UPDATE table SET column = column
    /// + 1` as it could be run multiple times against some rows. - The partitions are committed automatically - there
    /// is no support for Commit or Rollback. If the call returns an error, or if the client issuing the ExecuteSql call
    /// dies, it is possible that some rows had the statement executed on them successfully. It is also possible that
    /// statement was never executed against other rows. - Partitioned DML transactions may only contain the execution
    /// of a single DML statement via ExecuteSql or ExecuteStreamingSql. - If any error is encountered during the
    /// execution of the partitioned DML operation (for instance, a UNIQUE INDEX violation, division by zero, or a value
    /// that cannot be stored due to schema constraints), then the operation is stopped at that point and an error is
    /// returned. It is possible that at this point, some partitions have been committed (or even committed multiple
    /// times), and other partitions have not been run at all. Given the above, Partitioned DML is good fit for large,
    /// database-wide, operations that are idempotent, such as deleting old rows from a very large table.
    /// </summary>
    public class TransactionOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Partitioned DML transaction. Authorization to begin a Partitioned DML transaction requires
        /// `spanner.databases.beginPartitionedDmlTransaction` permission on the `session` resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partitionedDml")]
        public virtual PartitionedDml PartitionedDml { get; set; }

        /// <summary>
        /// Transaction will not write. Authorization to begin a read-only transaction requires
        /// `spanner.databases.beginReadOnlyTransaction` permission on the `session` resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readOnly")]
        public virtual ReadOnly ReadOnly__ { get; set; }

        /// <summary>
        /// Transaction may write. Authorization to begin a read-write transaction requires
        /// `spanner.databases.beginOrRollbackReadWriteTransaction` permission on the `session` resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readWrite")]
        public virtual ReadWrite ReadWrite { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// This message is used to select the transaction in which a Read or ExecuteSql call runs. See TransactionOptions
    /// for more information about transactions.
    /// </summary>
    public class TransactionSelector : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Begin a new transaction and execute this read or SQL query in it. The transaction ID of the new transaction
        /// is returned in ResultSetMetadata.transaction, which is a Transaction.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("begin")]
        public virtual TransactionOptions Begin { get; set; }

        /// <summary>Execute the read or SQL query in a previously-started transaction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Execute the read or SQL query in a temporary transaction. This is the most efficient way to execute a
        /// transaction that consists of a single SQL query.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("singleUse")]
        public virtual TransactionOptions SingleUse { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// `Type` indicates the type of a Cloud Spanner value, as might be stored in a table cell or returned from an SQL
    /// query.
    /// </summary>
    public class Type : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If code == ARRAY, then `array_element_type` is the type of the array elements.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("arrayElementType")]
        public virtual Type ArrayElementType { get; set; }

        /// <summary>Required. The TypeCode for this type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>If code == STRUCT, then `struct_type` provides type information for the struct's fields.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("structType")]
        public virtual StructType StructType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata type for the operation returned by UpdateDatabaseDdl.</summary>
    public class UpdateDatabaseDdlMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Reports the commit timestamps of all statements that have succeeded so far, where `commit_timestamps[i]` is
        /// the commit timestamp for the statement `statements[i]`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commitTimestamps")]
        public virtual System.Collections.Generic.IList<object> CommitTimestamps { get; set; }

        /// <summary>The database being modified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("database")]
        public virtual string Database { get; set; }

        /// <summary>
        /// The progress of the UpdateDatabaseDdl operations. Currently, only index creation statements will have a
        /// continuously updating progress. For non-index creation statements, `progress[i]` will have start time and
        /// end time populated with commit timestamp of operation, as well as a progress of 100% once the operation has
        /// completed. `progress[i]` is the operation progress for `statements[i]`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progress")]
        public virtual System.Collections.Generic.IList<OperationProgress> Progress { get; set; }

        /// <summary>
        /// For an update this list contains all the statements. For an individual statement, this list contains only
        /// that statement.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statements")]
        public virtual System.Collections.Generic.IList<string> Statements { get; set; }

        /// <summary>
        /// Output only. When true, indicates that the operation is throttled e.g due to resource constraints. When
        /// resources become available the operation will resume and this field will be false again.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("throttled")]
        public virtual System.Nullable<bool> Throttled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Enqueues the given DDL statements to be applied, in order but not necessarily all at once, to the database
    /// schema at some point (or points) in the future. The server checks that the statements are executable
    /// (syntactically valid, name tables that exist, etc.) before enqueueing them, but they may still fail upon later
    /// execution (e.g., if a statement from another batch of statements is applied first and it conflicts in some way,
    /// or if there is some data-related problem like a `NULL` value in a column to which `NOT NULL` would be added). If
    /// a statement fails, all subsequent statements in the batch are automatically cancelled. Each batch of statements
    /// is assigned a name which can be used with the Operations API to monitor progress. See the operation_id field for
    /// more details.
    /// </summary>
    public class UpdateDatabaseDdlRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If empty, the new update request is assigned an automatically-generated operation ID. Otherwise,
        /// `operation_id` is used to construct the name of the resulting Operation. Specifying an explicit operation ID
        /// simplifies determining whether the statements were executed in the event that the UpdateDatabaseDdl call is
        /// replayed, or the return value is otherwise lost: the database and `operation_id` fields can be combined to
        /// form the name of the resulting longrunning.Operation: `/operations/`. `operation_id` should be unique within
        /// the database, and must be a valid identifier: `a-z*`. Note that automatically-generated operation IDs always
        /// begin with an underscore. If the named operation already exists, UpdateDatabaseDdl returns `ALREADY_EXISTS`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationId")]
        public virtual string OperationId { get; set; }

        /// <summary>Required. DDL statements to be applied to the database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statements")]
        public virtual System.Collections.Generic.IList<string> Statements { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata type for the operation returned by UpdateInstance.</summary>
    public class UpdateInstanceMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The time at which this operation was cancelled. If set, this operation is in the process of undoing itself
        /// (which is guaranteed to succeed) and cannot be cancelled again.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cancelTime")]
        public virtual object CancelTime { get; set; }

        /// <summary>The time at which this operation failed or was completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>The desired end state of the update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instance")]
        public virtual Instance Instance { get; set; }

        /// <summary>The time at which UpdateInstance request was received.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for UpdateInstance.</summary>
    public class UpdateInstanceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. A mask specifying which fields in Instance should be updated. The field mask must always be
        /// specified; this prevents any future fields in Instance from being erased accidentally by clients that do not
        /// know about them.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldMask")]
        public virtual object FieldMask { get; set; }

        /// <summary>
        /// Required. The instance to update, which must always include the instance name. Otherwise, only fields
        /// mentioned in field_mask need be included.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instance")]
        public virtual Instance Instance { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class VisualizationData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The token signifying the end of a data_source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSourceEndToken")]
        public virtual string DataSourceEndToken { get; set; }

        /// <summary>The token delimiting a datasource name from the rest of a key in a data_source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSourceSeparatorToken")]
        public virtual string DataSourceSeparatorToken { get; set; }

        /// <summary>The list of messages (info, alerts, ...)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diagnosticMessages")]
        public virtual System.Collections.Generic.IList<DiagnosticMessage> DiagnosticMessages { get; set; }

        /// <summary>
        /// We discretize the entire keyspace into buckets. Assuming each bucket has an inclusive keyrange and covers
        /// keys from k(i) ... k(n). In this case k(n) would be an end key for a given range. end_key_string is the
        /// collection of all such end keys
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endKeyStrings")]
        public virtual System.Collections.Generic.IList<string> EndKeyStrings { get; set; }

        /// <summary>Whether this scan contains PII.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasPii")]
        public virtual System.Nullable<bool> HasPii { get; set; }

        /// <summary>
        /// Keys of key ranges that contribute significantly to a given metric Can be thought of as heavy hitters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indexedKeys")]
        public virtual System.Collections.Generic.IList<string> IndexedKeys { get; set; }

        /// <summary>The token delimiting the key prefixes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keySeparator")]
        public virtual string KeySeparator { get; set; }

        /// <summary>The unit for the key: e.g. 'key' or 'chunk'.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyUnit")]
        public virtual string KeyUnit { get; set; }

        /// <summary>The list of data objects for each metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
        public virtual System.Collections.Generic.IList<Metric> Metrics { get; set; }

        /// <summary>The list of extracted key prefix nodes used in the key prefix hierarchy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prefixNodes")]
        public virtual System.Collections.Generic.IList<PrefixNode> PrefixNodes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Arguments to insert, update, insert_or_update, and replace operations.</summary>
    public class Write : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The names of the columns in table to be written. The list of columns must contain enough columns to allow
        /// Cloud Spanner to derive values for all primary key columns in the row(s) to be modified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columns")]
        public virtual System.Collections.Generic.IList<string> Columns { get; set; }

        /// <summary>Required. The table whose rows will be written.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("table")]
        public virtual string Table { get; set; }

        /// <summary>
        /// The values to be written. `values` can contain more than one list of values. If it does, then multiple rows
        /// are written, one for each entry in `values`. Each list in `values` must have exactly as many entries as
        /// there are entries in columns above. Sending multiple lists is equivalent to sending multiple `Mutation`s,
        /// each containing one `values` entry and repeating table and columns. Individual values in each list are
        /// encoded as described here.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IList<object>> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
