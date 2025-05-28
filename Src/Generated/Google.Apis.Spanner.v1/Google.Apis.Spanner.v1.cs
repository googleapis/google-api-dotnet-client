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
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://spanner.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://spanner.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "spanner";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Spanner API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>Administer your Spanner databases</summary>
            public static string SpannerAdmin = "https://www.googleapis.com/auth/spanner.admin";

            /// <summary>View and manage the contents of your Spanner databases</summary>
            public static string SpannerData = "https://www.googleapis.com/auth/spanner.data";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Spanner API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
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
            InstanceConfigOperations = new InstanceConfigOperationsResource(service);
            InstanceConfigs = new InstanceConfigsResource(service);
            Instances = new InstancesResource(service);
        }

        /// <summary>Gets the InstanceConfigOperations resource.</summary>
        public virtual InstanceConfigOperationsResource InstanceConfigOperations { get; }

        /// <summary>The "instanceConfigOperations" collection of methods.</summary>
        public class InstanceConfigOperationsResource
        {
            private const string Resource = "instanceConfigOperations";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public InstanceConfigOperationsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Lists the user-managed instance configuration long-running operations in the given project. An instance
            /// configuration operation has a name of the form `projects//instanceConfigs//operations/`. The
            /// long-running operation metadata field type `metadata.type_url` describes the type of the metadata.
            /// Operations returned include those that have completed/failed/canceled within the last 7 days, and
            /// pending operations. Operations returned are ordered by `operation.metadata.value.start_time` in
            /// descending order starting from the most recently started operation.
            /// </summary>
            /// <param name="parent">
            /// Required. The project of the instance configuration operations. Values are of the form `projects/`.
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>
            /// Lists the user-managed instance configuration long-running operations in the given project. An instance
            /// configuration operation has a name of the form `projects//instanceConfigs//operations/`. The
            /// long-running operation metadata field type `metadata.type_url` describes the type of the metadata.
            /// Operations returned include those that have completed/failed/canceled within the last 7 days, and
            /// pending operations. Operations returned are ordered by `operation.metadata.value.start_time` in
            /// descending order starting from the most recently started operation.
            /// </summary>
            public class ListRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.ListInstanceConfigOperationsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The project of the instance configuration operations. Values are of the form `projects/`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// An expression that filters the list of returned operations. A filter expression consists of a field
                /// name, a comparison operator, and a value for filtering. The value must be a string, a number, or a
                /// boolean. The comparison operator must be one of: `&amp;lt;`, `&amp;gt;`, `&amp;lt;=`, `&amp;gt;=`,
                /// `!=`, `=`, or `:`. Colon `:` is the contains operator. Filter rules are not case sensitive. The
                /// following fields in the Operation are eligible for filtering: * `name` - The name of the
                /// long-running operation * `done` - False if the operation is in progress, else true. *
                /// `metadata.@type` - the type of metadata. For example, the type string for
                /// CreateInstanceConfigMetadata is
                /// `type.googleapis.com/google.spanner.admin.instance.v1.CreateInstanceConfigMetadata`. * `metadata.` -
                /// any field in metadata.value. `metadata.@type` must be specified first, if filtering on metadata
                /// fields. * `error` - Error associated with the long-running operation. * `response.@type` - the type
                /// of response. * `response.` - any field in response.value. You can combine multiple expressions by
                /// enclosing each expression in parentheses. By default, expressions are combined with AND logic.
                /// However, you can specify AND, OR, and NOT logic explicitly. Here are a few examples: * `done:true` -
                /// The operation is complete. * `(metadata.@type=` \
                /// `type.googleapis.com/google.spanner.admin.instance.v1.CreateInstanceConfigMetadata) AND` \
                /// `(metadata.instance_config.name:custom-config) AND` \ `(metadata.progress.start_time &amp;lt;
                /// \"2021-03-28T14:50:00Z\") AND` \ `(error:*)` - Return operations where: * The operation's metadata
                /// type is CreateInstanceConfigMetadata. * The instance configuration name contains "custom-config". *
                /// The operation started before 2021-03-28T14:50:00Z. * The operation resulted in an error.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// Number of operations to be returned in the response. If 0 or less, defaults to the server's maximum
                /// allowed page size.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// If non-empty, `page_token` should contain a next_page_token from a previous
                /// ListInstanceConfigOperationsResponse to the same `parent` and with the same `filter`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/instanceConfigOperations";

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
                Operations = new OperationsResource(service);
                SsdCaches = new SsdCachesResource(service);
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
                /// <param name="name">The name of the operation resource to be cancelled.</param>
                public virtual CancelRequest Cancel(string name)
                {
                    return new CancelRequest(this.service, name);
                }

                /// <summary>
                /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to
                /// cancel the operation, but success is not guaranteed. If the server doesn't support this method, it
                /// returns `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other methods to
                /// check whether the cancellation succeeded or whether the operation completed despite cancellation. On
                /// successful cancellation, the operation is not deleted; instead, it becomes an operation with an
                /// Operation.error value with a google.rpc.Status.code of `1`, corresponding to `Code.CANCELLED`.
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
                            Pattern = @"^projects/[^/]+/instanceConfigs/[^/]+/operations/[^/]+$",
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
                            Pattern = @"^projects/[^/]+/instanceConfigs/[^/]+/operations/[^/]+$",
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
                            Pattern = @"^projects/[^/]+/instanceConfigs/[^/]+/operations/[^/]+$",
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
                            Pattern = @"^projects/[^/]+/instanceConfigs/[^/]+/operations$",
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

            /// <summary>Gets the SsdCaches resource.</summary>
            public virtual SsdCachesResource SsdCaches { get; }

            /// <summary>The "ssdCaches" collection of methods.</summary>
            public class SsdCachesResource
            {
                private const string Resource = "ssdCaches";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public SsdCachesResource(Google.Apis.Services.IClientService service)
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
                    /// operation with an Operation.error value with a google.rpc.Status.code of `1`, corresponding to
                    /// `Code.CANCELLED`.
                    /// </summary>
                    /// <param name="name">The name of the operation resource to be cancelled.</param>
                    public virtual CancelRequest Cancel(string name)
                    {
                        return new CancelRequest(this.service, name);
                    }

                    /// <summary>
                    /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to
                    /// cancel the operation, but success is not guaranteed. If the server doesn't support this method,
                    /// it returns `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other
                    /// methods to check whether the cancellation succeeded or whether the operation completed despite
                    /// cancellation. On successful cancellation, the operation is not deleted; instead, it becomes an
                    /// operation with an Operation.error value with a google.rpc.Status.code of `1`, corresponding to
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
                                Pattern = @"^projects/[^/]+/instanceConfigs/[^/]+/ssdCaches/[^/]+/operations/[^/]+$",
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
                        return new DeleteRequest(this.service, name);
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
                                Pattern = @"^projects/[^/]+/instanceConfigs/[^/]+/ssdCaches/[^/]+/operations/[^/]+$",
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
                        return new GetRequest(this.service, name);
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
                                Pattern = @"^projects/[^/]+/instanceConfigs/[^/]+/ssdCaches/[^/]+/operations/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Lists operations that match the specified filter in the request. If the server doesn't support
                    /// this method, it returns `UNIMPLEMENTED`.
                    /// </summary>
                    /// <param name="name">The name of the operation's parent resource.</param>
                    public virtual ListRequest List(string name)
                    {
                        return new ListRequest(this.service, name);
                    }

                    /// <summary>
                    /// Lists operations that match the specified filter in the request. If the server doesn't support
                    /// this method, it returns `UNIMPLEMENTED`.
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
                                Pattern = @"^projects/[^/]+/instanceConfigs/[^/]+/ssdCaches/[^/]+/operations$",
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

            /// <summary>
            /// Creates an instance configuration and begins preparing it to be used. The returned long-running
            /// operation can be used to track the progress of preparing the new instance configuration. The instance
            /// configuration name is assigned by the caller. If the named instance configuration already exists,
            /// `CreateInstanceConfig` returns `ALREADY_EXISTS`. Immediately after the request returns: * The instance
            /// configuration is readable via the API, with all requested attributes. The instance configuration's
            /// reconciling field is set to true. Its state is `CREATING`. While the operation is pending: * Cancelling
            /// the operation renders the instance configuration immediately unreadable via the API. * Except for
            /// deleting the creating resource, all other attempts to modify the instance configuration are rejected.
            /// Upon completion of the returned operation: * Instances can be created using the instance configuration.
            /// * The instance configuration's reconciling field becomes false. Its state becomes `READY`. The returned
            /// long-running operation will have a name of the format `/operations/` and can be used to track creation
            /// of the instance configuration. The metadata field type is CreateInstanceConfigMetadata. The response
            /// field type is InstanceConfig, if successful. Authorization requires `spanner.instanceConfigs.create`
            /// permission on the resource parent.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The name of the project in which to create the instance configuration. Values are of the form
            /// `projects/`.
            /// </param>
            public virtual CreateRequest Create(Google.Apis.Spanner.v1.Data.CreateInstanceConfigRequest body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>
            /// Creates an instance configuration and begins preparing it to be used. The returned long-running
            /// operation can be used to track the progress of preparing the new instance configuration. The instance
            /// configuration name is assigned by the caller. If the named instance configuration already exists,
            /// `CreateInstanceConfig` returns `ALREADY_EXISTS`. Immediately after the request returns: * The instance
            /// configuration is readable via the API, with all requested attributes. The instance configuration's
            /// reconciling field is set to true. Its state is `CREATING`. While the operation is pending: * Cancelling
            /// the operation renders the instance configuration immediately unreadable via the API. * Except for
            /// deleting the creating resource, all other attempts to modify the instance configuration are rejected.
            /// Upon completion of the returned operation: * Instances can be created using the instance configuration.
            /// * The instance configuration's reconciling field becomes false. Its state becomes `READY`. The returned
            /// long-running operation will have a name of the format `/operations/` and can be used to track creation
            /// of the instance configuration. The metadata field type is CreateInstanceConfigMetadata. The response
            /// field type is InstanceConfig, if successful. Authorization requires `spanner.instanceConfigs.create`
            /// permission on the resource parent.
            /// </summary>
            public class CreateRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.Operation>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Spanner.v1.Data.CreateInstanceConfigRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the project in which to create the instance configuration. Values are of the
                /// form `projects/`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Spanner.v1.Data.CreateInstanceConfigRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/instanceConfigs";

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
            /// Deletes the instance configuration. Deletion is only allowed when no instances are using the
            /// configuration. If any instances are using the configuration, returns `FAILED_PRECONDITION`. Only
            /// user-managed configurations can be deleted. Authorization requires `spanner.instanceConfigs.delete`
            /// permission on the resource name.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the instance configuration to be deleted. Values are of the form
            /// `projects//instanceConfigs/`
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>
            /// Deletes the instance configuration. Deletion is only allowed when no instances are using the
            /// configuration. If any instances are using the configuration, returns `FAILED_PRECONDITION`. Only
            /// user-managed configurations can be deleted. Authorization requires `spanner.instanceConfigs.delete`
            /// permission on the resource name.
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
                /// Required. The name of the instance configuration to be deleted. Values are of the form
                /// `projects//instanceConfigs/`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Used for optimistic concurrency control as a way to help prevent simultaneous deletes of an instance
                /// configuration from overwriting each other. If not empty, the API only deletes the instance
                /// configuration when the etag provided matches the current status of the requested instance
                /// configuration. Otherwise, deletes the instance configuration without checking the current status of
                /// the requested instance configuration.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Etag { get; set; }

                /// <summary>
                /// An option to validate, but not actually execute, a request, and provide the same response.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> ValidateOnly { get; set; }

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
                        Pattern = @"^projects/[^/]+/instanceConfigs/[^/]+$",
                    });
                    RequestParameters.Add("etag", new Google.Apis.Discovery.Parameter
                    {
                        Name = "etag",
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

            /// <summary>Gets information about a particular instance configuration.</summary>
            /// <param name="name">
            /// Required. The name of the requested instance configuration. Values are of the form
            /// `projects//instanceConfigs/`.
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
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

            /// <summary>
            /// Lists the supported instance configurations for a given project. Returns both Google-managed
            /// configurations and user-managed configurations.
            /// </summary>
            /// <param name="parent">
            /// Required. The name of the project for which a list of supported instance configurations is requested.
            /// Values are of the form `projects/`.
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>
            /// Lists the supported instance configurations for a given project. Returns both Google-managed
            /// configurations and user-managed configurations.
            /// </summary>
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

            /// <summary>
            /// Updates an instance configuration. The returned long-running operation can be used to track the progress
            /// of updating the instance. If the named instance configuration does not exist, returns `NOT_FOUND`. Only
            /// user-managed configurations can be updated. Immediately after the request returns: * The instance
            /// configuration's reconciling field is set to true. While the operation is pending: * Cancelling the
            /// operation sets its metadata's cancel_time. The operation is guaranteed to succeed at undoing all
            /// changes, after which point it terminates with a `CANCELLED` status. * All other attempts to modify the
            /// instance configuration are rejected. * Reading the instance configuration via the API continues to give
            /// the pre-request values. Upon completion of the returned operation: * Creating instances using the
            /// instance configuration uses the new values. * The new values of the instance configuration are readable
            /// via the API. * The instance configuration's reconciling field becomes false. The returned long-running
            /// operation will have a name of the format `/operations/` and can be used to track the instance
            /// configuration modification. The metadata field type is UpdateInstanceConfigMetadata. The response field
            /// type is InstanceConfig, if successful. Authorization requires `spanner.instanceConfigs.update`
            /// permission on the resource name.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// A unique identifier for the instance configuration. Values are of the form
            /// `projects//instanceConfigs/a-z*`. User instance configuration must start with `custom-`.
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.Spanner.v1.Data.UpdateInstanceConfigRequest body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>
            /// Updates an instance configuration. The returned long-running operation can be used to track the progress
            /// of updating the instance. If the named instance configuration does not exist, returns `NOT_FOUND`. Only
            /// user-managed configurations can be updated. Immediately after the request returns: * The instance
            /// configuration's reconciling field is set to true. While the operation is pending: * Cancelling the
            /// operation sets its metadata's cancel_time. The operation is guaranteed to succeed at undoing all
            /// changes, after which point it terminates with a `CANCELLED` status. * All other attempts to modify the
            /// instance configuration are rejected. * Reading the instance configuration via the API continues to give
            /// the pre-request values. Upon completion of the returned operation: * Creating instances using the
            /// instance configuration uses the new values. * The new values of the instance configuration are readable
            /// via the API. * The instance configuration's reconciling field becomes false. The returned long-running
            /// operation will have a name of the format `/operations/` and can be used to track the instance
            /// configuration modification. The metadata field type is UpdateInstanceConfigMetadata. The response field
            /// type is InstanceConfig, if successful. Authorization requires `spanner.instanceConfigs.update`
            /// permission on the resource name.
            /// </summary>
            public class PatchRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.Operation>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Spanner.v1.Data.UpdateInstanceConfigRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// A unique identifier for the instance configuration. Values are of the form
                /// `projects//instanceConfigs/a-z*`. User instance configuration must start with `custom-`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Spanner.v1.Data.UpdateInstanceConfigRequest Body { get; set; }

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
                        Pattern = @"^projects/[^/]+/instanceConfigs/[^/]+$",
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
                InstancePartitionOperations = new InstancePartitionOperationsResource(service);
                InstancePartitions = new InstancePartitionsResource(service);
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
                    return new ListRequest(this.service, parent);
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
                    /// field in metadata.value. `metadata.@type` must be specified first if filtering on metadata
                    /// fields. * `error` - Error associated with the long-running operation. * `response.@type` - the
                    /// type of response. * `response.` - any field in response.value. You can combine multiple
                    /// expressions by enclosing each expression in parentheses. By default, expressions are combined
                    /// with AND logic, but you can specify AND, OR, and NOT logic explicitly. Here are a few examples:
                    /// * `done:true` - The operation is complete. *
                    /// `(metadata.@type=type.googleapis.com/google.spanner.admin.database.v1.CreateBackupMetadata) AND`
                    /// \ `metadata.database:prod` - Returns operations where: * The operation's metadata type is
                    /// CreateBackupMetadata. * The source database name of backup contains the string "prod". *
                    /// `(metadata.@type=type.googleapis.com/google.spanner.admin.database.v1.CreateBackupMetadata) AND`
                    /// \ `(metadata.name:howl) AND` \ `(metadata.progress.start_time &amp;lt; \"2018-03-28T14:50:00Z\")
                    /// AND` \ `(error:*)` - Returns operations where: * The operation's metadata type is
                    /// CreateBackupMetadata. * The backup name contains the string "howl". * The operation started
                    /// before 2018-03-28T14:50:00Z. * The operation resulted in an error. *
                    /// `(metadata.@type=type.googleapis.com/google.spanner.admin.database.v1.CopyBackupMetadata) AND` \
                    /// `(metadata.source_backup:test) AND` \ `(metadata.progress.start_time &amp;lt;
                    /// \"2022-01-18T14:50:00Z\") AND` \ `(error:*)` - Returns operations where: * The operation's
                    /// metadata type is CopyBackupMetadata. * The source backup name contains the string "test". * The
                    /// operation started before 2022-01-18T14:50:00Z. * The operation resulted in an error. *
                    /// `((metadata.@type=type.googleapis.com/google.spanner.admin.database.v1.CreateBackupMetadata)
                    /// AND` \ `(metadata.database:test_db)) OR` \
                    /// `((metadata.@type=type.googleapis.com/google.spanner.admin.database.v1.CopyBackupMetadata) AND`
                    /// \ `(metadata.source_backup:test_bkp)) AND` \ `(error:*)` - Returns operations where: * The
                    /// operation's metadata matches either of criteria: * The operation's metadata type is
                    /// CreateBackupMetadata AND the source database name of the backup contains the string "test_db" *
                    /// The operation's metadata type is CopyBackupMetadata AND the source backup name contains the
                    /// string "test_bkp" * The operation resulted in an error.
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
                    /// operation with an Operation.error value with a google.rpc.Status.code of `1`, corresponding to
                    /// `Code.CANCELLED`.
                    /// </summary>
                    /// <param name="name">The name of the operation resource to be cancelled.</param>
                    public virtual CancelRequest Cancel(string name)
                    {
                        return new CancelRequest(this.service, name);
                    }

                    /// <summary>
                    /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to
                    /// cancel the operation, but success is not guaranteed. If the server doesn't support this method,
                    /// it returns `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other
                    /// methods to check whether the cancellation succeeded or whether the operation completed despite
                    /// cancellation. On successful cancellation, the operation is not deleted; instead, it becomes an
                    /// operation with an Operation.error value with a google.rpc.Status.code of `1`, corresponding to
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
                        return new DeleteRequest(this.service, name);
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
                        return new GetRequest(this.service, name);
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
                    /// this method, it returns `UNIMPLEMENTED`.
                    /// </summary>
                    /// <param name="name">The name of the operation's parent resource.</param>
                    public virtual ListRequest List(string name)
                    {
                        return new ListRequest(this.service, name);
                    }

                    /// <summary>
                    /// Lists operations that match the specified filter in the request. If the server doesn't support
                    /// this method, it returns `UNIMPLEMENTED`.
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
                /// Starts copying a Cloud Spanner Backup. The returned backup long-running operation will have a name
                /// of the format `projects//instances//backups//operations/` and can be used to track copying of the
                /// backup. The operation is associated with the destination backup. The metadata field type is
                /// CopyBackupMetadata. The response field type is Backup, if successful. Cancelling the returned
                /// operation will stop the copying and delete the destination backup. Concurrent CopyBackup requests
                /// can run on the same source backup.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The name of the destination instance that will contain the backup copy. Values are of the
                /// form: `projects//instances/`.
                /// </param>
                public virtual CopyRequest Copy(Google.Apis.Spanner.v1.Data.CopyBackupRequest body, string parent)
                {
                    return new CopyRequest(this.service, body, parent);
                }

                /// <summary>
                /// Starts copying a Cloud Spanner Backup. The returned backup long-running operation will have a name
                /// of the format `projects//instances//backups//operations/` and can be used to track copying of the
                /// backup. The operation is associated with the destination backup. The metadata field type is
                /// CopyBackupMetadata. The response field type is Backup, if successful. Cancelling the returned
                /// operation will stop the copying and delete the destination backup. Concurrent CopyBackup requests
                /// can run on the same source backup.
                /// </summary>
                public class CopyRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Copy request.</summary>
                    public CopyRequest(Google.Apis.Services.IClientService service, Google.Apis.Spanner.v1.Data.CopyBackupRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the destination instance that will contain the backup copy. Values are of
                    /// the form: `projects//instances/`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Spanner.v1.Data.CopyBackupRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "copy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/backups:copy";

                    /// <summary>Initializes Copy parameter list.</summary>
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
                    return new CreateRequest(this.service, body, parent);
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

                    /// <summary>
                    /// Optional. Specifies the KMS configuration for the one or more keys used to protect the backup.
                    /// Values are of the form `projects//locations//keyRings//cryptoKeys/`. The keys referenced by
                    /// `kms_key_names` must fully cover all regions of the backup's instance configuration. Some
                    /// examples: * For regional (single-region) instance configurations, specify a regional location
                    /// KMS key. * For multi-region instance configurations of type `GOOGLE_MANAGED`, either specify a
                    /// multi-region location KMS key or multiple regional location KMS keys that cover all regions in
                    /// the instance configuration. * For an instance configuration of type `USER_MANAGED`, specify only
                    /// regional location KMS keys to cover each region in the instance configuration. Multi-region
                    /// location KMS keys aren't supported for `USER_MANAGED` type instance configurations.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("encryptionConfig.kmsKeyNames", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual Google.Apis.Util.Repeatable<string> EncryptionConfigKmsKeyNames { get; set; }

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
                        RequestParameters.Add("encryptionConfig.kmsKeyNames", new Google.Apis.Discovery.Parameter
                        {
                            Name = "encryptionConfig.kmsKeyNames",
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
                    return new DeleteRequest(this.service, name);
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
                    return new GetRequest(this.service, name);
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
                /// `spanner.backups.getIamPolicy` permission on resource. For backup schedules, authorization requires
                /// `spanner.backupSchedules.getIamPolicy` permission on resource.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The Cloud Spanner resource for which the policy is being retrieved. The format is
                /// `projects//instances/` for instance resources and `projects//instances//databases/` for database
                /// resources.
                /// </param>
                public virtual GetIamPolicyRequest GetIamPolicy(Google.Apis.Spanner.v1.Data.GetIamPolicyRequest body, string resource)
                {
                    return new GetIamPolicyRequest(this.service, body, resource);
                }

                /// <summary>
                /// Gets the access control policy for a database or backup resource. Returns an empty policy if a
                /// database or backup exists but does not have a policy set. Authorization requires
                /// `spanner.databases.getIamPolicy` permission on resource. For backups, authorization requires
                /// `spanner.backups.getIamPolicy` permission on resource. For backup schedules, authorization requires
                /// `spanner.backupSchedules.getIamPolicy` permission on resource.
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
                    return new ListRequest(this.service, parent);
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
                    /// format YYYY-MM-DDTHH:MM:SSZ) * `size_bytes` * `backup_schedules` You can combine multiple
                    /// expressions by enclosing each expression in parentheses. By default, expressions are combined
                    /// with AND logic, but you can specify AND, OR, and NOT logic explicitly. Here are a few examples:
                    /// * `name:Howl` - The backup's name contains the string "howl". * `database:prod` - The database's
                    /// name contains the string "prod". * `state:CREATING` - The backup is pending creation. *
                    /// `state:READY` - The backup is fully created and ready for use. * `(name:howl) AND (create_time
                    /// &amp;lt; \"2018-03-28T14:50:00Z\")` - The backup name contains the string "howl" and
                    /// `create_time` of the backup is before 2018-03-28T14:50:00Z. * `expire_time &amp;lt;
                    /// \"2018-03-28T14:50:00Z\"` - The backup `expire_time` is before 2018-03-28T14:50:00Z. *
                    /// `size_bytes &amp;gt; 10000000000` - The backup's size is greater than 10GB *
                    /// `backup_schedules:daily` - The backup is created from a schedule with "daily" in its name.
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
                    return new PatchRequest(this.service, body, name);
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
                /// authorization requires `spanner.backups.setIamPolicy` permission on resource. For backup schedules,
                /// authorization requires `spanner.backupSchedules.setIamPolicy` permission on resource.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The Cloud Spanner resource for which the policy is being set. The format is
                /// `projects//instances/` for instance resources and `projects//instances//databases/` for databases
                /// resources.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.Spanner.v1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(this.service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on a database or backup resource. Replaces any existing policy.
                /// Authorization requires `spanner.databases.setIamPolicy` permission on resource. For backups,
                /// authorization requires `spanner.backups.setIamPolicy` permission on resource. For backup schedules,
                /// authorization requires `spanner.backupSchedules.setIamPolicy` permission on resource.
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
                /// Calling this method on a backup schedule that does not exist will result in a NOT_FOUND error if the
                /// user has `spanner.backupSchedules.list` permission on the containing database.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The Cloud Spanner resource for which permissions are being tested. The format is
                /// `projects//instances/` for instance resources and `projects//instances//databases/` for database
                /// resources.
                /// </param>
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.Spanner.v1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(this.service, body, resource);
                }

                /// <summary>
                /// Returns permissions that the caller has on the specified database or backup resource. Attempting
                /// this RPC on a non-existent Cloud Spanner database will result in a NOT_FOUND error if the user has
                /// `spanner.databases.list` permission on the containing Cloud Spanner instance. Otherwise returns an
                /// empty set of permissions. Calling this method on a backup that does not exist will result in a
                /// NOT_FOUND error if the user has `spanner.backups.list` permission on the containing instance.
                /// Calling this method on a backup schedule that does not exist will result in a NOT_FOUND error if the
                /// user has `spanner.backupSchedules.list` permission on the containing database.
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
                    return new ListRequest(this.service, parent);
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
                    /// are not case sensitive. The following fields in the operation are eligible for filtering: *
                    /// `name` - The name of the long-running operation * `done` - False if the operation is in
                    /// progress, else true. * `metadata.@type` - the type of metadata. For example, the type string for
                    /// RestoreDatabaseMetadata is
                    /// `type.googleapis.com/google.spanner.admin.database.v1.RestoreDatabaseMetadata`. * `metadata.` -
                    /// any field in metadata.value. `metadata.@type` must be specified first, if filtering on metadata
                    /// fields. * `error` - Error associated with the long-running operation. * `response.@type` - the
                    /// type of response. * `response.` - any field in response.value. You can combine multiple
                    /// expressions by enclosing each expression in parentheses. By default, expressions are combined
                    /// with AND logic. However, you can specify AND, OR, and NOT logic explicitly. Here are a few
                    /// examples: * `done:true` - The operation is complete. *
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
                    BackupSchedules = new BackupSchedulesResource(service);
                    DatabaseRoles = new DatabaseRolesResource(service);
                    Operations = new OperationsResource(service);
                    Sessions = new SessionsResource(service);
                }

                /// <summary>Gets the BackupSchedules resource.</summary>
                public virtual BackupSchedulesResource BackupSchedules { get; }

                /// <summary>The "backupSchedules" collection of methods.</summary>
                public class BackupSchedulesResource
                {
                    private const string Resource = "backupSchedules";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public BackupSchedulesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Creates a new backup schedule.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The name of the database that this backup schedule applies to.
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.Spanner.v1.Data.BackupSchedule body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>Creates a new backup schedule.</summary>
                    public class CreateRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.BackupSchedule>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Spanner.v1.Data.BackupSchedule body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the database that this backup schedule applies to.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. The Id to use for the backup schedule. The `backup_schedule_id` appended to
                        /// `parent` forms the full backup schedule name of the form
                        /// `projects//instances//databases//backupSchedules/`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("backupScheduleId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string BackupScheduleId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Spanner.v1.Data.BackupSchedule Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/backupSchedules";

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
                                Pattern = @"^projects/[^/]+/instances/[^/]+/databases/[^/]+$",
                            });
                            RequestParameters.Add("backupScheduleId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "backupScheduleId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Deletes a backup schedule.</summary>
                    /// <param name="name">
                    /// Required. The name of the schedule to delete. Values are of the form
                    /// `projects//instances//databases//backupSchedules/`.
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Deletes a backup schedule.</summary>
                    public class DeleteRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the schedule to delete. Values are of the form
                        /// `projects//instances//databases//backupSchedules/`.
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
                                Pattern = @"^projects/[^/]+/instances/[^/]+/databases/[^/]+/backupSchedules/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets backup schedule for the input schedule name.</summary>
                    /// <param name="name">
                    /// Required. The name of the schedule to retrieve. Values are of the form
                    /// `projects//instances//databases//backupSchedules/`.
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets backup schedule for the input schedule name.</summary>
                    public class GetRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.BackupSchedule>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the schedule to retrieve. Values are of the form
                        /// `projects//instances//databases//backupSchedules/`.
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
                                Pattern = @"^projects/[^/]+/instances/[^/]+/databases/[^/]+/backupSchedules/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Gets the access control policy for a database or backup resource. Returns an empty policy if a
                    /// database or backup exists but does not have a policy set. Authorization requires
                    /// `spanner.databases.getIamPolicy` permission on resource. For backups, authorization requires
                    /// `spanner.backups.getIamPolicy` permission on resource. For backup schedules, authorization
                    /// requires `spanner.backupSchedules.getIamPolicy` permission on resource.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The Cloud Spanner resource for which the policy is being retrieved. The format is
                    /// `projects//instances/` for instance resources and `projects//instances//databases/` for database
                    /// resources.
                    /// </param>
                    public virtual GetIamPolicyRequest GetIamPolicy(Google.Apis.Spanner.v1.Data.GetIamPolicyRequest body, string resource)
                    {
                        return new GetIamPolicyRequest(this.service, body, resource);
                    }

                    /// <summary>
                    /// Gets the access control policy for a database or backup resource. Returns an empty policy if a
                    /// database or backup exists but does not have a policy set. Authorization requires
                    /// `spanner.databases.getIamPolicy` permission on resource. For backups, authorization requires
                    /// `spanner.backups.getIamPolicy` permission on resource. For backup schedules, authorization
                    /// requires `spanner.backupSchedules.getIamPolicy` permission on resource.
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
                        /// `projects//instances/` for instance resources and `projects//instances//databases/` for
                        /// database resources.
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
                                Pattern = @"^projects/[^/]+/instances/[^/]+/databases/[^/]+/backupSchedules/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists all the backup schedules for the database.</summary>
                    /// <param name="parent">
                    /// Required. Database is the parent resource whose backup schedules should be listed. Values are of
                    /// the form projects//instances//databases/
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists all the backup schedules for the database.</summary>
                    public class ListRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.ListBackupSchedulesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Database is the parent resource whose backup schedules should be listed. Values
                        /// are of the form projects//instances//databases/
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. Number of backup schedules to be returned in the response. If 0 or less, defaults
                        /// to the server's maximum allowed page size.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. If non-empty, `page_token` should contain a next_page_token from a previous
                        /// ListBackupSchedulesResponse to the same `parent`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/backupSchedules";

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
                                Pattern = @"^projects/[^/]+/instances/[^/]+/databases/[^/]+$",
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

                    /// <summary>Updates a backup schedule.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Identifier. Output only for the CreateBackupSchedule operation. Required for the
                    /// UpdateBackupSchedule operation. A globally unique identifier for the backup schedule which
                    /// cannot be changed. Values are of the form
                    /// `projects//instances//databases//backupSchedules/a-z*[a-z0-9]` The final segment of the name
                    /// must be between 2 and 60 characters in length.
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.Spanner.v1.Data.BackupSchedule body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>Updates a backup schedule.</summary>
                    public class PatchRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.BackupSchedule>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Spanner.v1.Data.BackupSchedule body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Identifier. Output only for the CreateBackupSchedule operation. Required for the
                        /// UpdateBackupSchedule operation. A globally unique identifier for the backup schedule which
                        /// cannot be changed. Values are of the form
                        /// `projects//instances//databases//backupSchedules/a-z*[a-z0-9]` The final segment of the name
                        /// must be between 2 and 60 characters in length.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Required. A mask specifying which fields in the BackupSchedule resource should be updated.
                        /// This mask is relative to the BackupSchedule resource, not to the request message. The field
                        /// mask must always be specified; this prevents any future fields from being erased
                        /// accidentally.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Spanner.v1.Data.BackupSchedule Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/instances/[^/]+/databases/[^/]+/backupSchedules/[^/]+$",
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
                    /// authorization requires `spanner.backups.setIamPolicy` permission on resource. For backup
                    /// schedules, authorization requires `spanner.backupSchedules.setIamPolicy` permission on resource.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The Cloud Spanner resource for which the policy is being set. The format is
                    /// `projects//instances/` for instance resources and `projects//instances//databases/` for
                    /// databases resources.
                    /// </param>
                    public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.Spanner.v1.Data.SetIamPolicyRequest body, string resource)
                    {
                        return new SetIamPolicyRequest(this.service, body, resource);
                    }

                    /// <summary>
                    /// Sets the access control policy on a database or backup resource. Replaces any existing policy.
                    /// Authorization requires `spanner.databases.setIamPolicy` permission on resource. For backups,
                    /// authorization requires `spanner.backups.setIamPolicy` permission on resource. For backup
                    /// schedules, authorization requires `spanner.backupSchedules.setIamPolicy` permission on resource.
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
                                Pattern = @"^projects/[^/]+/instances/[^/]+/databases/[^/]+/backupSchedules/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Returns permissions that the caller has on the specified database or backup resource. Attempting
                    /// this RPC on a non-existent Cloud Spanner database will result in a NOT_FOUND error if the user
                    /// has `spanner.databases.list` permission on the containing Cloud Spanner instance. Otherwise
                    /// returns an empty set of permissions. Calling this method on a backup that does not exist will
                    /// result in a NOT_FOUND error if the user has `spanner.backups.list` permission on the containing
                    /// instance. Calling this method on a backup schedule that does not exist will result in a
                    /// NOT_FOUND error if the user has `spanner.backupSchedules.list` permission on the containing
                    /// database.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The Cloud Spanner resource for which permissions are being tested. The format is
                    /// `projects//instances/` for instance resources and `projects//instances//databases/` for database
                    /// resources.
                    /// </param>
                    public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.Spanner.v1.Data.TestIamPermissionsRequest body, string resource)
                    {
                        return new TestIamPermissionsRequest(this.service, body, resource);
                    }

                    /// <summary>
                    /// Returns permissions that the caller has on the specified database or backup resource. Attempting
                    /// this RPC on a non-existent Cloud Spanner database will result in a NOT_FOUND error if the user
                    /// has `spanner.databases.list` permission on the containing Cloud Spanner instance. Otherwise
                    /// returns an empty set of permissions. Calling this method on a backup that does not exist will
                    /// result in a NOT_FOUND error if the user has `spanner.backups.list` permission on the containing
                    /// instance. Calling this method on a backup schedule that does not exist will result in a
                    /// NOT_FOUND error if the user has `spanner.backupSchedules.list` permission on the containing
                    /// database.
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
                        /// `projects//instances/` for instance resources and `projects//instances//databases/` for
                        /// database resources.
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
                                Pattern = @"^projects/[^/]+/instances/[^/]+/databases/[^/]+/backupSchedules/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>Gets the DatabaseRoles resource.</summary>
                public virtual DatabaseRolesResource DatabaseRoles { get; }

                /// <summary>The "databaseRoles" collection of methods.</summary>
                public class DatabaseRolesResource
                {
                    private const string Resource = "databaseRoles";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public DatabaseRolesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Lists Cloud Spanner database roles.</summary>
                    /// <param name="parent">
                    /// Required. The database whose roles should be listed. Values are of the form
                    /// `projects//instances//databases/`.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists Cloud Spanner database roles.</summary>
                    public class ListRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.ListDatabaseRolesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The database whose roles should be listed. Values are of the form
                        /// `projects//instances//databases/`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Number of database roles to be returned in the response. If 0 or less, defaults to the
                        /// server's maximum allowed page size.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// If non-empty, `page_token` should contain a next_page_token from a previous
                        /// ListDatabaseRolesResponse.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/databaseRoles";

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
                                Pattern = @"^projects/[^/]+/instances/[^/]+/databases/[^/]+$",
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
                    /// Returns permissions that the caller has on the specified database or backup resource. Attempting
                    /// this RPC on a non-existent Cloud Spanner database will result in a NOT_FOUND error if the user
                    /// has `spanner.databases.list` permission on the containing Cloud Spanner instance. Otherwise
                    /// returns an empty set of permissions. Calling this method on a backup that does not exist will
                    /// result in a NOT_FOUND error if the user has `spanner.backups.list` permission on the containing
                    /// instance. Calling this method on a backup schedule that does not exist will result in a
                    /// NOT_FOUND error if the user has `spanner.backupSchedules.list` permission on the containing
                    /// database.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The Cloud Spanner resource for which permissions are being tested. The format is
                    /// `projects//instances/` for instance resources and `projects//instances//databases/` for database
                    /// resources.
                    /// </param>
                    public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.Spanner.v1.Data.TestIamPermissionsRequest body, string resource)
                    {
                        return new TestIamPermissionsRequest(this.service, body, resource);
                    }

                    /// <summary>
                    /// Returns permissions that the caller has on the specified database or backup resource. Attempting
                    /// this RPC on a non-existent Cloud Spanner database will result in a NOT_FOUND error if the user
                    /// has `spanner.databases.list` permission on the containing Cloud Spanner instance. Otherwise
                    /// returns an empty set of permissions. Calling this method on a backup that does not exist will
                    /// result in a NOT_FOUND error if the user has `spanner.backups.list` permission on the containing
                    /// instance. Calling this method on a backup schedule that does not exist will result in a
                    /// NOT_FOUND error if the user has `spanner.backupSchedules.list` permission on the containing
                    /// database.
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
                        /// `projects//instances/` for instance resources and `projects//instances//databases/` for
                        /// database resources.
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
                                Pattern = @"^projects/[^/]+/instances/[^/]+/databases/[^/]+/databaseRoles/[^/]+$",
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
                    /// cancel the operation, but success is not guaranteed. If the server doesn't support this method,
                    /// it returns `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other
                    /// methods to check whether the cancellation succeeded or whether the operation completed despite
                    /// cancellation. On successful cancellation, the operation is not deleted; instead, it becomes an
                    /// operation with an Operation.error value with a google.rpc.Status.code of `1`, corresponding to
                    /// `Code.CANCELLED`.
                    /// </summary>
                    /// <param name="name">The name of the operation resource to be cancelled.</param>
                    public virtual CancelRequest Cancel(string name)
                    {
                        return new CancelRequest(this.service, name);
                    }

                    /// <summary>
                    /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to
                    /// cancel the operation, but success is not guaranteed. If the server doesn't support this method,
                    /// it returns `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other
                    /// methods to check whether the cancellation succeeded or whether the operation completed despite
                    /// cancellation. On successful cancellation, the operation is not deleted; instead, it becomes an
                    /// operation with an Operation.error value with a google.rpc.Status.code of `1`, corresponding to
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
                        return new DeleteRequest(this.service, name);
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
                        return new GetRequest(this.service, name);
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
                    /// this method, it returns `UNIMPLEMENTED`.
                    /// </summary>
                    /// <param name="name">The name of the operation's parent resource.</param>
                    public virtual ListRequest List(string name)
                    {
                        return new ListRequest(this.service, name);
                    }

                    /// <summary>
                    /// Lists operations that match the specified filter in the request. If the server doesn't support
                    /// this method, it returns `UNIMPLEMENTED`.
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
                    /// Handles a single message from the client and returns the result as a stream. The server will
                    /// interpret the message frame and respond with message frames to the client.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The database session in which the adapter request is processed.
                    /// </param>
                    public virtual AdaptMessageRequest AdaptMessage(Google.Apis.Spanner.v1.Data.AdaptMessageRequest body, string name)
                    {
                        return new AdaptMessageRequest(this.service, body, name);
                    }

                    /// <summary>
                    /// Handles a single message from the client and returns the result as a stream. The server will
                    /// interpret the message frame and respond with message frames to the client.
                    /// </summary>
                    public class AdaptMessageRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.AdaptMessageResponse>
                    {
                        /// <summary>Constructs a new AdaptMessage request.</summary>
                        public AdaptMessageRequest(Google.Apis.Services.IClientService service, Google.Apis.Spanner.v1.Data.AdaptMessageRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The database session in which the adapter request is processed.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Spanner.v1.Data.AdaptMessageRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "adaptMessage";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:adaptMessage";

                        /// <summary>Initializes AdaptMessage parameter list.</summary>
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
                    /// Creates a new session to be used for requests made by the adapter. A session identifies a
                    /// specific incarnation of a database resource and is meant to be reused across many `AdaptMessage`
                    /// calls.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">Required. The database in which the new session is created.</param>
                    public virtual AdapterRequest Adapter(Google.Apis.Spanner.v1.Data.AdapterSession body, string parent)
                    {
                        return new AdapterRequest(this.service, body, parent);
                    }

                    /// <summary>
                    /// Creates a new session to be used for requests made by the adapter. A session identifies a
                    /// specific incarnation of a database resource and is meant to be reused across many `AdaptMessage`
                    /// calls.
                    /// </summary>
                    public class AdapterRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.AdapterSession>
                    {
                        /// <summary>Constructs a new Adapter request.</summary>
                        public AdapterRequest(Google.Apis.Services.IClientService service, Google.Apis.Spanner.v1.Data.AdapterSession body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The database in which the new session is created.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Spanner.v1.Data.AdapterSession Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "adapter";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/sessions:adapter";

                        /// <summary>Initializes Adapter parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/instances/[^/]+/databases/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Creates multiple new sessions. This API can be used to initialize a session cache on the
                    /// clients. See https://goo.gl/TgSFN2 for best practices on session cache management.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="database">Required. The database in which the new sessions are created.</param>
                    public virtual BatchCreateRequest BatchCreate(Google.Apis.Spanner.v1.Data.BatchCreateSessionsRequest body, string database)
                    {
                        return new BatchCreateRequest(this.service, body, database);
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
                    /// Batches the supplied mutation groups in a collection of efficient transactions. All mutations in
                    /// a group are committed atomically. However, mutations across groups can be committed
                    /// non-atomically in an unspecified order and thus, they must be independent of each other. Partial
                    /// failure is possible, that is, some groups might have been committed successfully, while some
                    /// might have failed. The results of individual batches are streamed into the response as the
                    /// batches are applied. `BatchWrite` requests are not replay protected, meaning that each mutation
                    /// group can be applied more than once. Replays of non-idempotent mutations can have undesirable
                    /// effects. For example, replays of an insert mutation can produce an already exists error or if
                    /// you use generated or commit timestamp-based keys, it can result in additional rows being added
                    /// to the mutation's table. We recommend structuring your mutation groups to be idempotent to avoid
                    /// this issue.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="session">Required. The session in which the batch request is to be run.</param>
                    public virtual BatchWriteRequest BatchWrite(Google.Apis.Spanner.v1.Data.BatchWriteRequest body, string session)
                    {
                        return new BatchWriteRequest(this.service, body, session);
                    }

                    /// <summary>
                    /// Batches the supplied mutation groups in a collection of efficient transactions. All mutations in
                    /// a group are committed atomically. However, mutations across groups can be committed
                    /// non-atomically in an unspecified order and thus, they must be independent of each other. Partial
                    /// failure is possible, that is, some groups might have been committed successfully, while some
                    /// might have failed. The results of individual batches are streamed into the response as the
                    /// batches are applied. `BatchWrite` requests are not replay protected, meaning that each mutation
                    /// group can be applied more than once. Replays of non-idempotent mutations can have undesirable
                    /// effects. For example, replays of an insert mutation can produce an already exists error or if
                    /// you use generated or commit timestamp-based keys, it can result in additional rows being added
                    /// to the mutation's table. We recommend structuring your mutation groups to be idempotent to avoid
                    /// this issue.
                    /// </summary>
                    public class BatchWriteRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.BatchWriteResponse>
                    {
                        /// <summary>Constructs a new BatchWrite request.</summary>
                        public BatchWriteRequest(Google.Apis.Services.IClientService service, Google.Apis.Spanner.v1.Data.BatchWriteRequest body, string session) : base(service)
                        {
                            Session = session;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The session in which the batch request is to be run.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("session", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Session { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Spanner.v1.Data.BatchWriteRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "batchWrite";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+session}:batchWrite";

                        /// <summary>Initializes BatchWrite parameter list.</summary>
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
                    /// Begins a new transaction. This step can often be skipped: Read, ExecuteSql and Commit can begin
                    /// a new transaction as a side-effect.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="session">Required. The session in which the transaction runs.</param>
                    public virtual BeginTransactionRequest BeginTransaction(Google.Apis.Spanner.v1.Data.BeginTransactionRequest body, string session)
                    {
                        return new BeginTransactionRequest(this.service, body, session);
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
                    /// reasons. If `Commit` returns `ABORTED`, the caller should retry the transaction from the
                    /// beginning, reusing the same session. On very rare occasions, `Commit` might return `UNKNOWN`.
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
                        return new CommitRequest(this.service, body, session);
                    }

                    /// <summary>
                    /// Commits a transaction. The request includes the mutations to be applied to rows in the database.
                    /// `Commit` might return an `ABORTED` error. This can occur at any time; commonly, the cause is
                    /// conflicts with concurrent transactions. However, it can also happen for a variety of other
                    /// reasons. If `Commit` returns `ABORTED`, the caller should retry the transaction from the
                    /// beginning, reusing the same session. On very rare occasions, `Commit` might return `UNKNOWN`.
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
                    /// Active sessions use additional server resources, so it's a good idea to delete idle and unneeded
                    /// sessions. Aside from explicit deletes, Cloud Spanner can delete sessions when no operations are
                    /// sent for more than an hour. If a session is deleted, requests to it return `NOT_FOUND`. Idle
                    /// sessions can be kept alive by sending a trivial SQL query periodically, for example, `"SELECT
                    /// 1"`.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="database">Required. The database in which the new session is created.</param>
                    public virtual CreateRequest Create(Google.Apis.Spanner.v1.Data.CreateSessionRequest body, string database)
                    {
                        return new CreateRequest(this.service, body, database);
                    }

                    /// <summary>
                    /// Creates a new session. A session can be used to perform transactions that read and/or modify
                    /// data in a Cloud Spanner database. Sessions are meant to be reused for many consecutive
                    /// transactions. Sessions can only execute one transaction at a time. To execute multiple
                    /// concurrent read-write/write-only transactions, create multiple sessions. Note that standalone
                    /// reads and queries use a transaction internally, and count toward the one transaction limit.
                    /// Active sessions use additional server resources, so it's a good idea to delete idle and unneeded
                    /// sessions. Aside from explicit deletes, Cloud Spanner can delete sessions when no operations are
                    /// sent for more than an hour. If a session is deleted, requests to it return `NOT_FOUND`. Idle
                    /// sessions can be kept alive by sending a trivial SQL query periodically, for example, `"SELECT
                    /// 1"`.
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
                    /// Ends a session, releasing server resources associated with it. This asynchronously triggers the
                    /// cancellation of any operations that are running with this session.
                    /// </summary>
                    /// <param name="name">Required. The name of the session to delete.</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>
                    /// Ends a session, releasing server resources associated with it. This asynchronously triggers the
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
                        return new ExecuteBatchDmlRequest(this.service, body, session);
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
                    /// Executes an SQL statement, returning all results in a single reply. This method can't be used to
                    /// return a result set larger than 10 MiB; if the query yields more data than that, the query fails
                    /// with a `FAILED_PRECONDITION` error. Operations inside read-write transactions might return
                    /// `ABORTED`. If this occurs, the application should restart the transaction from the beginning.
                    /// See Transaction for more details. Larger result sets can be fetched in streaming fashion by
                    /// calling ExecuteStreamingSql instead. The query string can be SQL or [Graph Query Language
                    /// (GQL)](https://cloud.google.com/spanner/docs/reference/standard-sql/graph-intro).
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="session">Required. The session in which the SQL query should be performed.</param>
                    public virtual ExecuteSqlRequest ExecuteSql(Google.Apis.Spanner.v1.Data.ExecuteSqlRequest body, string session)
                    {
                        return new ExecuteSqlRequest(this.service, body, session);
                    }

                    /// <summary>
                    /// Executes an SQL statement, returning all results in a single reply. This method can't be used to
                    /// return a result set larger than 10 MiB; if the query yields more data than that, the query fails
                    /// with a `FAILED_PRECONDITION` error. Operations inside read-write transactions might return
                    /// `ABORTED`. If this occurs, the application should restart the transaction from the beginning.
                    /// See Transaction for more details. Larger result sets can be fetched in streaming fashion by
                    /// calling ExecuteStreamingSql instead. The query string can be SQL or [Graph Query Language
                    /// (GQL)](https://cloud.google.com/spanner/docs/reference/standard-sql/graph-intro).
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
                    /// 100 MiB, and no column value can exceed 10 MiB. The query string can be SQL or [Graph Query
                    /// Language (GQL)](https://cloud.google.com/spanner/docs/reference/standard-sql/graph-intro).
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="session">Required. The session in which the SQL query should be performed.</param>
                    public virtual ExecuteStreamingSqlRequest ExecuteStreamingSql(Google.Apis.Spanner.v1.Data.ExecuteSqlRequest body, string session)
                    {
                        return new ExecuteStreamingSqlRequest(this.service, body, session);
                    }

                    /// <summary>
                    /// Like ExecuteSql, except returns the result set as a stream. Unlike ExecuteSql, there is no limit
                    /// on the size of the returned result set. However, no individual row in the result set can exceed
                    /// 100 MiB, and no column value can exceed 10 MiB. The query string can be SQL or [Graph Query
                    /// Language (GQL)](https://cloud.google.com/spanner/docs/reference/standard-sql/graph-intro).
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
                    /// Gets a session. Returns `NOT_FOUND` if the session doesn't exist. This is mainly useful for
                    /// determining whether a session is still alive.
                    /// </summary>
                    /// <param name="name">Required. The name of the session to retrieve.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>
                    /// Gets a session. Returns `NOT_FOUND` if the session doesn't exist. This is mainly useful for
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
                        return new ListRequest(this.service, database);
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
                    /// `PartitionQueryRequest` used to create the partition tokens and the `ExecuteSqlRequests` that
                    /// use the partition tokens. Partition tokens become invalid when the session used to create them
                    /// is deleted, is idle for too long, begins a new transaction, or becomes too old. When any of
                    /// these happen, it isn't possible to resume the query, and the whole operation must be restarted
                    /// from the beginning.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="session">Required. The session used to create the partitions.</param>
                    public virtual PartitionQueryRequest PartitionQuery(Google.Apis.Spanner.v1.Data.PartitionQueryRequest body, string session)
                    {
                        return new PartitionQueryRequest(this.service, body, session);
                    }

                    /// <summary>
                    /// Creates a set of partition tokens that can be used to execute a query operation in parallel.
                    /// Each of the returned partition tokens can be used by ExecuteStreamingSql to specify a subset of
                    /// the query result to read. The same session and read-only transaction must be used by the
                    /// `PartitionQueryRequest` used to create the partition tokens and the `ExecuteSqlRequests` that
                    /// use the partition tokens. Partition tokens become invalid when the session used to create them
                    /// is deleted, is idle for too long, begins a new transaction, or becomes too old. When any of
                    /// these happen, it isn't possible to resume the query, and the whole operation must be restarted
                    /// from the beginning.
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
                    /// `PartitionReadRequest` used to create the partition tokens and the `ReadRequests` that use the
                    /// partition tokens. There are no ordering guarantees on rows returned among the returned partition
                    /// tokens, or even within each individual `StreamingRead` call issued with a `partition_token`.
                    /// Partition tokens become invalid when the session used to create them is deleted, is idle for too
                    /// long, begins a new transaction, or becomes too old. When any of these happen, it isn't possible
                    /// to resume the read, and the whole operation must be restarted from the beginning.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="session">Required. The session used to create the partitions.</param>
                    public virtual PartitionReadRequest PartitionRead(Google.Apis.Spanner.v1.Data.PartitionReadRequest body, string session)
                    {
                        return new PartitionReadRequest(this.service, body, session);
                    }

                    /// <summary>
                    /// Creates a set of partition tokens that can be used to execute a read operation in parallel. Each
                    /// of the returned partition tokens can be used by StreamingRead to specify a subset of the read
                    /// result to read. The same session and read-only transaction must be used by the
                    /// `PartitionReadRequest` used to create the partition tokens and the `ReadRequests` that use the
                    /// partition tokens. There are no ordering guarantees on rows returned among the returned partition
                    /// tokens, or even within each individual `StreamingRead` call issued with a `partition_token`.
                    /// Partition tokens become invalid when the session used to create them is deleted, is idle for too
                    /// long, begins a new transaction, or becomes too old. When any of these happen, it isn't possible
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
                    /// alternative to ExecuteSql. This method can't be used to return a result set larger than 10 MiB;
                    /// if the read matches more data than that, the read fails with a `FAILED_PRECONDITION` error.
                    /// Reads inside read-write transactions might return `ABORTED`. If this occurs, the application
                    /// should restart the transaction from the beginning. See Transaction for more details. Larger
                    /// result sets can be yielded in streaming fashion by calling StreamingRead instead.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="session">Required. The session in which the read should be performed.</param>
                    public virtual ReadRequest Read(Google.Apis.Spanner.v1.Data.ReadRequest body, string session)
                    {
                        return new ReadRequest(this.service, body, session);
                    }

                    /// <summary>
                    /// Reads rows from the database using key lookups and scans, as a simple key/value style
                    /// alternative to ExecuteSql. This method can't be used to return a result set larger than 10 MiB;
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
                    /// Rolls back a transaction, releasing any locks it holds. It's a good idea to call this for any
                    /// transaction that includes one or more Read or ExecuteSql requests and ultimately decides not to
                    /// commit. `Rollback` returns `OK` if it successfully aborts the transaction, the transaction was
                    /// already aborted, or the transaction isn't found. `Rollback` never returns `ABORTED`.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="session">
                    /// Required. The session in which the transaction to roll back is running.
                    /// </param>
                    public virtual RollbackRequest Rollback(Google.Apis.Spanner.v1.Data.RollbackRequest body, string session)
                    {
                        return new RollbackRequest(this.service, body, session);
                    }

                    /// <summary>
                    /// Rolls back a transaction, releasing any locks it holds. It's a good idea to call this for any
                    /// transaction that includes one or more Read or ExecuteSql requests and ultimately decides not to
                    /// commit. `Rollback` returns `OK` if it successfully aborts the transaction, the transaction was
                    /// already aborted, or the transaction isn't found. `Rollback` never returns `ABORTED`.
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
                        return new StreamingReadRequest(this.service, body, session);
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

                /// <summary>Adds split points to specified tables and indexes of a database.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="database">
                /// Required. The database on whose tables or indexes the split points are to be added. Values are of
                /// the form `projects//instances//databases/`.
                /// </param>
                public virtual AddSplitPointsRequest AddSplitPoints(Google.Apis.Spanner.v1.Data.AddSplitPointsRequest body, string database)
                {
                    return new AddSplitPointsRequest(this.service, body, database);
                }

                /// <summary>Adds split points to specified tables and indexes of a database.</summary>
                public class AddSplitPointsRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.AddSplitPointsResponse>
                {
                    /// <summary>Constructs a new AddSplitPoints request.</summary>
                    public AddSplitPointsRequest(Google.Apis.Services.IClientService service, Google.Apis.Spanner.v1.Data.AddSplitPointsRequest body, string database) : base(service)
                    {
                        Database = database;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The database on whose tables or indexes the split points are to be added. Values are
                    /// of the form `projects//instances//databases/`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("database", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Database { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Spanner.v1.Data.AddSplitPointsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "addSplitPoints";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+database}:addSplitPoints";

                    /// <summary>Initializes AddSplitPoints parameter list.</summary>
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
                /// `ChangeQuorum` is strictly restricted to databases that use dual-region instance configurations.
                /// Initiates a background operation to change the quorum of a database from dual-region mode to
                /// single-region mode or vice versa. The returned long-running operation has a name of the format
                /// `projects//instances//databases//operations/` and can be used to track execution of the
                /// `ChangeQuorum`. The metadata field type is ChangeQuorumMetadata. Authorization requires
                /// `spanner.databases.changequorum` permission on the resource database.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Name of the database in which to apply `ChangeQuorum`. Values are of the form
                /// `projects//instances//databases/`.
                /// </param>
                public virtual ChangequorumRequest Changequorum(Google.Apis.Spanner.v1.Data.ChangeQuorumRequest body, string name)
                {
                    return new ChangequorumRequest(this.service, body, name);
                }

                /// <summary>
                /// `ChangeQuorum` is strictly restricted to databases that use dual-region instance configurations.
                /// Initiates a background operation to change the quorum of a database from dual-region mode to
                /// single-region mode or vice versa. The returned long-running operation has a name of the format
                /// `projects//instances//databases//operations/` and can be used to track execution of the
                /// `ChangeQuorum`. The metadata field type is ChangeQuorumMetadata. Authorization requires
                /// `spanner.databases.changequorum` permission on the resource database.
                /// </summary>
                public class ChangequorumRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Changequorum request.</summary>
                    public ChangequorumRequest(Google.Apis.Services.IClientService service, Google.Apis.Spanner.v1.Data.ChangeQuorumRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the database in which to apply `ChangeQuorum`. Values are of the form
                    /// `projects//instances//databases/`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Spanner.v1.Data.ChangeQuorumRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "changequorum";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:changequorum";

                    /// <summary>Initializes Changequorum parameter list.</summary>
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
                /// Creates a new Spanner database and starts to prepare it for serving. The returned long-running
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
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>
                /// Creates a new Spanner database and starts to prepare it for serving. The returned long-running
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
                /// according to their `expire_time`. Note: Cloud Spanner might continue to accept requests for a few
                /// seconds after the database has been deleted.
                /// </summary>
                /// <param name="database">Required. The database to be dropped.</param>
                public virtual DropDatabaseRequest DropDatabase(string database)
                {
                    return new DropDatabaseRequest(this.service, database);
                }

                /// <summary>
                /// Drops (aka deletes) a Cloud Spanner database. Completed backups for the database will be retained
                /// according to their `expire_time`. Note: Cloud Spanner might continue to accept requests for a few
                /// seconds after the database has been deleted.
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
                    return new GetRequest(this.service, name);
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
                    return new GetDdlRequest(this.service, database);
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
                /// `spanner.backups.getIamPolicy` permission on resource. For backup schedules, authorization requires
                /// `spanner.backupSchedules.getIamPolicy` permission on resource.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The Cloud Spanner resource for which the policy is being retrieved. The format is
                /// `projects//instances/` for instance resources and `projects//instances//databases/` for database
                /// resources.
                /// </param>
                public virtual GetIamPolicyRequest GetIamPolicy(Google.Apis.Spanner.v1.Data.GetIamPolicyRequest body, string resource)
                {
                    return new GetIamPolicyRequest(this.service, body, resource);
                }

                /// <summary>
                /// Gets the access control policy for a database or backup resource. Returns an empty policy if a
                /// database or backup exists but does not have a policy set. Authorization requires
                /// `spanner.databases.getIamPolicy` permission on resource. For backups, authorization requires
                /// `spanner.backups.getIamPolicy` permission on resource. For backup schedules, authorization requires
                /// `spanner.backupSchedules.getIamPolicy` permission on resource.
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
                    return new GetScansRequest(this.service, name);
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

                    private object _endTime;

                    /// <summary>
                    /// String representation of <see cref="EndTimeDateTimeOffset"/>, formatted for inclusion in the
                    /// HTTP request.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("endTime", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string EndTimeRaw { get; private set; }

                    /// <summary><seealso cref="object"/> representation of <see cref="EndTimeRaw"/>.</summary>
                    [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use EndTimeDateTimeOffset instead.")]
                    public virtual object EndTime
                    {
                        get => _endTime;
                        set
                        {
                            EndTimeRaw = Google.Apis.Util.Utilities.ConvertToString(value);
                            _endTime = value;
                        }
                    }

                    public virtual System.DateTimeOffset? EndTimeDateTimeOffset
                    {
                        get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(EndTimeRaw);
                        set
                        {
                            EndTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
                            _endTime = value;
                        }
                    }

                    private object _startTime;

                    /// <summary>
                    /// String representation of <see cref="StartTimeDateTimeOffset"/>, formatted for inclusion in the
                    /// HTTP request.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("startTime", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string StartTimeRaw { get; private set; }

                    /// <summary><seealso cref="object"/> representation of <see cref="StartTimeRaw"/>.</summary>
                    [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use StartTimeDateTimeOffset instead.")]
                    public virtual object StartTime
                    {
                        get => _startTime;
                        set
                        {
                            StartTimeRaw = Google.Apis.Util.Utilities.ConvertToString(value);
                            _startTime = value;
                        }
                    }

                    public virtual System.DateTimeOffset? StartTimeDateTimeOffset
                    {
                        get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(StartTimeRaw);
                        set
                        {
                            StartTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
                            _startTime = value;
                        }
                    }

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
                    return new ListRequest(this.service, parent);
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
                /// Updates a Cloud Spanner database. The returned long-running operation can be used to track the
                /// progress of updating the database. If the named database does not exist, returns `NOT_FOUND`. While
                /// the operation is pending: * The database's reconciling field is set to true. * Cancelling the
                /// operation is best-effort. If the cancellation succeeds, the operation metadata's cancel_time is set,
                /// the updates are reverted, and the operation terminates with a `CANCELLED` status. * New
                /// UpdateDatabase requests will return a `FAILED_PRECONDITION` error until the pending operation is
                /// done (returns successfully or with error). * Reading the database via the API continues to give the
                /// pre-request values. Upon completion of the returned operation: * The new values are in effect and
                /// readable via the API. * The database's reconciling field becomes false. The returned long-running
                /// operation will have a name of the format `projects//instances//databases//operations/` and can be
                /// used to track the database modification. The metadata field type is UpdateDatabaseMetadata. The
                /// response field type is Database, if successful.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The name of the database. Values are of the form `projects//instances//databases/`, where
                /// `` is as specified in the `CREATE DATABASE` statement. This name can be passed to other API methods
                /// to identify the database.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.Spanner.v1.Data.Database body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>
                /// Updates a Cloud Spanner database. The returned long-running operation can be used to track the
                /// progress of updating the database. If the named database does not exist, returns `NOT_FOUND`. While
                /// the operation is pending: * The database's reconciling field is set to true. * Cancelling the
                /// operation is best-effort. If the cancellation succeeds, the operation metadata's cancel_time is set,
                /// the updates are reverted, and the operation terminates with a `CANCELLED` status. * New
                /// UpdateDatabase requests will return a `FAILED_PRECONDITION` error until the pending operation is
                /// done (returns successfully or with error). * Reading the database via the API continues to give the
                /// pre-request values. Upon completion of the returned operation: * The new values are in effect and
                /// readable via the API. * The database's reconciling field becomes false. The returned long-running
                /// operation will have a name of the format `projects//instances//databases//operations/` and can be
                /// used to track the database modification. The metadata field type is UpdateDatabaseMetadata. The
                /// response field type is Database, if successful.
                /// </summary>
                public class PatchRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Spanner.v1.Data.Database body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the database. Values are of the form `projects//instances//databases/`,
                    /// where `` is as specified in the `CREATE DATABASE` statement. This name can be passed to other
                    /// API methods to identify the database.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Required. The list of fields to update. Currently, only `enable_drop_protection` field can be
                    /// updated.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Spanner.v1.Data.Database Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/instances/[^/]+/databases/[^/]+$",
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
                    return new RestoreRequest(this.service, body, parent);
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
                /// authorization requires `spanner.backups.setIamPolicy` permission on resource. For backup schedules,
                /// authorization requires `spanner.backupSchedules.setIamPolicy` permission on resource.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The Cloud Spanner resource for which the policy is being set. The format is
                /// `projects//instances/` for instance resources and `projects//instances//databases/` for databases
                /// resources.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.Spanner.v1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(this.service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on a database or backup resource. Replaces any existing policy.
                /// Authorization requires `spanner.databases.setIamPolicy` permission on resource. For backups,
                /// authorization requires `spanner.backups.setIamPolicy` permission on resource. For backup schedules,
                /// authorization requires `spanner.backupSchedules.setIamPolicy` permission on resource.
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
                /// Calling this method on a backup schedule that does not exist will result in a NOT_FOUND error if the
                /// user has `spanner.backupSchedules.list` permission on the containing database.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The Cloud Spanner resource for which permissions are being tested. The format is
                /// `projects//instances/` for instance resources and `projects//instances//databases/` for database
                /// resources.
                /// </param>
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.Spanner.v1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(this.service, body, resource);
                }

                /// <summary>
                /// Returns permissions that the caller has on the specified database or backup resource. Attempting
                /// this RPC on a non-existent Cloud Spanner database will result in a NOT_FOUND error if the user has
                /// `spanner.databases.list` permission on the containing Cloud Spanner instance. Otherwise returns an
                /// empty set of permissions. Calling this method on a backup that does not exist will result in a
                /// NOT_FOUND error if the user has `spanner.backups.list` permission on the containing instance.
                /// Calling this method on a backup schedule that does not exist will result in a NOT_FOUND error if the
                /// user has `spanner.backupSchedules.list` permission on the containing database.
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
                    return new UpdateDdlRequest(this.service, body, database);
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

            /// <summary>Gets the InstancePartitionOperations resource.</summary>
            public virtual InstancePartitionOperationsResource InstancePartitionOperations { get; }

            /// <summary>The "instancePartitionOperations" collection of methods.</summary>
            public class InstancePartitionOperationsResource
            {
                private const string Resource = "instancePartitionOperations";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public InstancePartitionOperationsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Lists instance partition long-running operations in the given instance. An instance partition
                /// operation has a name of the form `projects//instances//instancePartitions//operations/`. The
                /// long-running operation metadata field type `metadata.type_url` describes the type of the metadata.
                /// Operations returned include those that have completed/failed/canceled within the last 7 days, and
                /// pending operations. Operations returned are ordered by `operation.metadata.value.start_time` in
                /// descending order starting from the most recently started operation. Authorization requires
                /// `spanner.instancePartitionOperations.list` permission on the resource parent.
                /// </summary>
                /// <param name="parent">
                /// Required. The parent instance of the instance partition operations. Values are of the form
                /// `projects//instances/`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>
                /// Lists instance partition long-running operations in the given instance. An instance partition
                /// operation has a name of the form `projects//instances//instancePartitions//operations/`. The
                /// long-running operation metadata field type `metadata.type_url` describes the type of the metadata.
                /// Operations returned include those that have completed/failed/canceled within the last 7 days, and
                /// pending operations. Operations returned are ordered by `operation.metadata.value.start_time` in
                /// descending order starting from the most recently started operation. Authorization requires
                /// `spanner.instancePartitionOperations.list` permission on the resource parent.
                /// </summary>
                public class ListRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.ListInstancePartitionOperationsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent instance of the instance partition operations. Values are of the form
                    /// `projects//instances/`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. An expression that filters the list of returned operations. A filter expression
                    /// consists of a field name, a comparison operator, and a value for filtering. The value must be a
                    /// string, a number, or a boolean. The comparison operator must be one of: `&amp;lt;`, `&amp;gt;`,
                    /// `&amp;lt;=`, `&amp;gt;=`, `!=`, `=`, or `:`. Colon `:` is the contains operator. Filter rules
                    /// are not case sensitive. The following fields in the Operation are eligible for filtering: *
                    /// `name` - The name of the long-running operation * `done` - False if the operation is in
                    /// progress, else true. * `metadata.@type` - the type of metadata. For example, the type string for
                    /// CreateInstancePartitionMetadata is
                    /// `type.googleapis.com/google.spanner.admin.instance.v1.CreateInstancePartitionMetadata`. *
                    /// `metadata.` - any field in metadata.value. `metadata.@type` must be specified first, if
                    /// filtering on metadata fields. * `error` - Error associated with the long-running operation. *
                    /// `response.@type` - the type of response. * `response.` - any field in response.value. You can
                    /// combine multiple expressions by enclosing each expression in parentheses. By default,
                    /// expressions are combined with AND logic. However, you can specify AND, OR, and NOT logic
                    /// explicitly. Here are a few examples: * `done:true` - The operation is complete. *
                    /// `(metadata.@type=` \
                    /// `type.googleapis.com/google.spanner.admin.instance.v1.CreateInstancePartitionMetadata) AND` \
                    /// `(metadata.instance_partition.name:custom-instance-partition) AND` \ `(metadata.start_time
                    /// &amp;lt; \"2021-03-28T14:50:00Z\") AND` \ `(error:*)` - Return operations where: * The
                    /// operation's metadata type is CreateInstancePartitionMetadata. * The instance partition name
                    /// contains "custom-instance-partition". * The operation started before 2021-03-28T14:50:00Z. * The
                    /// operation resulted in an error.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    private object _instancePartitionDeadline;

                    /// <summary>
                    /// String representation of <see cref="InstancePartitionDeadlineDateTimeOffset"/>, formatted for
                    /// inclusion in the HTTP request.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("instancePartitionDeadline", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string InstancePartitionDeadlineRaw { get; private set; }

                    /// <summary>
                    /// <seealso cref="object"/> representation of <see cref="InstancePartitionDeadlineRaw"/>.
                    /// </summary>
                    [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use InstancePartitionDeadlineDateTimeOffset instead.")]
                    public virtual object InstancePartitionDeadline
                    {
                        get => _instancePartitionDeadline;
                        set
                        {
                            InstancePartitionDeadlineRaw = Google.Apis.Util.Utilities.ConvertToString(value);
                            _instancePartitionDeadline = value;
                        }
                    }

                    public virtual System.DateTimeOffset? InstancePartitionDeadlineDateTimeOffset
                    {
                        get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(InstancePartitionDeadlineRaw);
                        set
                        {
                            InstancePartitionDeadlineRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
                            _instancePartitionDeadline = value;
                        }
                    }

                    /// <summary>
                    /// Optional. Number of operations to be returned in the response. If 0 or less, defaults to the
                    /// server's maximum allowed page size.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. If non-empty, `page_token` should contain a next_page_token from a previous
                    /// ListInstancePartitionOperationsResponse to the same `parent` and with the same `filter`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/instancePartitionOperations";

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
                        RequestParameters.Add("instancePartitionDeadline", new Google.Apis.Discovery.Parameter
                        {
                            Name = "instancePartitionDeadline",
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

            /// <summary>Gets the InstancePartitions resource.</summary>
            public virtual InstancePartitionsResource InstancePartitions { get; }

            /// <summary>The "instancePartitions" collection of methods.</summary>
            public class InstancePartitionsResource
            {
                private const string Resource = "instancePartitions";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public InstancePartitionsResource(Google.Apis.Services.IClientService service)
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
                    /// operation with an Operation.error value with a google.rpc.Status.code of `1`, corresponding to
                    /// `Code.CANCELLED`.
                    /// </summary>
                    /// <param name="name">The name of the operation resource to be cancelled.</param>
                    public virtual CancelRequest Cancel(string name)
                    {
                        return new CancelRequest(this.service, name);
                    }

                    /// <summary>
                    /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to
                    /// cancel the operation, but success is not guaranteed. If the server doesn't support this method,
                    /// it returns `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other
                    /// methods to check whether the cancellation succeeded or whether the operation completed despite
                    /// cancellation. On successful cancellation, the operation is not deleted; instead, it becomes an
                    /// operation with an Operation.error value with a google.rpc.Status.code of `1`, corresponding to
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
                                Pattern = @"^projects/[^/]+/instances/[^/]+/instancePartitions/[^/]+/operations/[^/]+$",
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
                        return new DeleteRequest(this.service, name);
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
                                Pattern = @"^projects/[^/]+/instances/[^/]+/instancePartitions/[^/]+/operations/[^/]+$",
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
                        return new GetRequest(this.service, name);
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
                                Pattern = @"^projects/[^/]+/instances/[^/]+/instancePartitions/[^/]+/operations/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Lists operations that match the specified filter in the request. If the server doesn't support
                    /// this method, it returns `UNIMPLEMENTED`.
                    /// </summary>
                    /// <param name="name">The name of the operation's parent resource.</param>
                    public virtual ListRequest List(string name)
                    {
                        return new ListRequest(this.service, name);
                    }

                    /// <summary>
                    /// Lists operations that match the specified filter in the request. If the server doesn't support
                    /// this method, it returns `UNIMPLEMENTED`.
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
                                Pattern = @"^projects/[^/]+/instances/[^/]+/instancePartitions/[^/]+/operations$",
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
                /// Creates an instance partition and begins preparing it to be used. The returned long-running
                /// operation can be used to track the progress of preparing the new instance partition. The instance
                /// partition name is assigned by the caller. If the named instance partition already exists,
                /// `CreateInstancePartition` returns `ALREADY_EXISTS`. Immediately upon completion of this request: *
                /// The instance partition is readable via the API, with all requested attributes but no allocated
                /// resources. Its state is `CREATING`. Until completion of the returned operation: * Cancelling the
                /// operation renders the instance partition immediately unreadable via the API. * The instance
                /// partition can be deleted. * All other attempts to modify the instance partition are rejected. Upon
                /// completion of the returned operation: * Billing for all successfully-allocated resources begins
                /// (some types may have lower than the requested levels). * Databases can start using this instance
                /// partition. * The instance partition's allocated resource levels are readable via the API. * The
                /// instance partition's state becomes `READY`. The returned long-running operation will have a name of
                /// the format `/operations/` and can be used to track creation of the instance partition. The metadata
                /// field type is CreateInstancePartitionMetadata. The response field type is InstancePartition, if
                /// successful.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The name of the instance in which to create the instance partition. Values are of the form
                /// `projects//instances/`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.Spanner.v1.Data.CreateInstancePartitionRequest body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>
                /// Creates an instance partition and begins preparing it to be used. The returned long-running
                /// operation can be used to track the progress of preparing the new instance partition. The instance
                /// partition name is assigned by the caller. If the named instance partition already exists,
                /// `CreateInstancePartition` returns `ALREADY_EXISTS`. Immediately upon completion of this request: *
                /// The instance partition is readable via the API, with all requested attributes but no allocated
                /// resources. Its state is `CREATING`. Until completion of the returned operation: * Cancelling the
                /// operation renders the instance partition immediately unreadable via the API. * The instance
                /// partition can be deleted. * All other attempts to modify the instance partition are rejected. Upon
                /// completion of the returned operation: * Billing for all successfully-allocated resources begins
                /// (some types may have lower than the requested levels). * Databases can start using this instance
                /// partition. * The instance partition's allocated resource levels are readable via the API. * The
                /// instance partition's state becomes `READY`. The returned long-running operation will have a name of
                /// the format `/operations/` and can be used to track creation of the instance partition. The metadata
                /// field type is CreateInstancePartitionMetadata. The response field type is InstancePartition, if
                /// successful.
                /// </summary>
                public class CreateRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Spanner.v1.Data.CreateInstancePartitionRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the instance in which to create the instance partition. Values are of the
                    /// form `projects//instances/`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Spanner.v1.Data.CreateInstancePartitionRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/instancePartitions";

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
                /// Deletes an existing instance partition. Requires that the instance partition is not used by any
                /// database or backup and is not the default instance partition of an instance. Authorization requires
                /// `spanner.instancePartitions.delete` permission on the resource name.
                /// </summary>
                /// <param name="name">
                /// Required. The name of the instance partition to be deleted. Values are of the form
                /// `projects/{project}/instances/{instance}/instancePartitions/{instance_partition}`
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>
                /// Deletes an existing instance partition. Requires that the instance partition is not used by any
                /// database or backup and is not the default instance partition of an instance. Authorization requires
                /// `spanner.instancePartitions.delete` permission on the resource name.
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
                    /// Required. The name of the instance partition to be deleted. Values are of the form
                    /// `projects/{project}/instances/{instance}/instancePartitions/{instance_partition}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. If not empty, the API only deletes the instance partition when the etag provided
                    /// matches the current status of the requested instance partition. Otherwise, deletes the instance
                    /// partition without checking the current status of the requested instance partition.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Etag { get; set; }

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
                            Pattern = @"^projects/[^/]+/instances/[^/]+/instancePartitions/[^/]+$",
                        });
                        RequestParameters.Add("etag", new Google.Apis.Discovery.Parameter
                        {
                            Name = "etag",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Gets information about a particular instance partition.</summary>
                /// <param name="name">
                /// Required. The name of the requested instance partition. Values are of the form
                /// `projects/{project}/instances/{instance}/instancePartitions/{instance_partition}`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets information about a particular instance partition.</summary>
                public class GetRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.InstancePartition>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the requested instance partition. Values are of the form
                    /// `projects/{project}/instances/{instance}/instancePartitions/{instance_partition}`.
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
                            Pattern = @"^projects/[^/]+/instances/[^/]+/instancePartitions/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists all instance partitions for the given instance.</summary>
                /// <param name="parent">
                /// Required. The instance whose instance partitions should be listed. Values are of the form
                /// `projects//instances/`. Use `{instance} = '-'` to list instance partitions for all Instances in a
                /// project, e.g., `projects/myproject/instances/-`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists all instance partitions for the given instance.</summary>
                public class ListRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.ListInstancePartitionsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The instance whose instance partitions should be listed. Values are of the form
                    /// `projects//instances/`. Use `{instance} = '-'` to list instance partitions for all Instances in
                    /// a project, e.g., `projects/myproject/instances/-`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    private object _instancePartitionDeadline;

                    /// <summary>
                    /// String representation of <see cref="InstancePartitionDeadlineDateTimeOffset"/>, formatted for
                    /// inclusion in the HTTP request.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("instancePartitionDeadline", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string InstancePartitionDeadlineRaw { get; private set; }

                    /// <summary>
                    /// <seealso cref="object"/> representation of <see cref="InstancePartitionDeadlineRaw"/>.
                    /// </summary>
                    [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use InstancePartitionDeadlineDateTimeOffset instead.")]
                    public virtual object InstancePartitionDeadline
                    {
                        get => _instancePartitionDeadline;
                        set
                        {
                            InstancePartitionDeadlineRaw = Google.Apis.Util.Utilities.ConvertToString(value);
                            _instancePartitionDeadline = value;
                        }
                    }

                    public virtual System.DateTimeOffset? InstancePartitionDeadlineDateTimeOffset
                    {
                        get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(InstancePartitionDeadlineRaw);
                        set
                        {
                            InstancePartitionDeadlineRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
                            _instancePartitionDeadline = value;
                        }
                    }

                    /// <summary>
                    /// Number of instance partitions to be returned in the response. If 0 or less, defaults to the
                    /// server's maximum allowed page size.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// If non-empty, `page_token` should contain a next_page_token from a previous
                    /// ListInstancePartitionsResponse.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/instancePartitions";

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
                        RequestParameters.Add("instancePartitionDeadline", new Google.Apis.Discovery.Parameter
                        {
                            Name = "instancePartitionDeadline",
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
                /// Updates an instance partition, and begins allocating or releasing resources as requested. The
                /// returned long-running operation can be used to track the progress of updating the instance
                /// partition. If the named instance partition does not exist, returns `NOT_FOUND`. Immediately upon
                /// completion of this request: * For resource types for which a decrease in the instance partition's
                /// allocation has been requested, billing is based on the newly-requested level. Until completion of
                /// the returned operation: * Cancelling the operation sets its metadata's cancel_time, and begins
                /// restoring resources to their pre-request values. The operation is guaranteed to succeed at undoing
                /// all resource changes, after which point it terminates with a `CANCELLED` status. * All other
                /// attempts to modify the instance partition are rejected. * Reading the instance partition via the API
                /// continues to give the pre-request resource levels. Upon completion of the returned operation: *
                /// Billing begins for all successfully-allocated resources (some types may have lower than the
                /// requested levels). * All newly-reserved resources are available for serving the instance partition's
                /// tables. * The instance partition's new resource levels are readable via the API. The returned
                /// long-running operation will have a name of the format `/operations/` and can be used to track the
                /// instance partition modification. The metadata field type is UpdateInstancePartitionMetadata. The
                /// response field type is InstancePartition, if successful. Authorization requires
                /// `spanner.instancePartitions.update` permission on the resource name.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. A unique identifier for the instance partition. Values are of the form
                /// `projects//instances//instancePartitions/a-z*[a-z0-9]`. The final segment of the name must be
                /// between 2 and 64 characters in length. An instance partition's name cannot be changed after the
                /// instance partition is created.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.Spanner.v1.Data.UpdateInstancePartitionRequest body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>
                /// Updates an instance partition, and begins allocating or releasing resources as requested. The
                /// returned long-running operation can be used to track the progress of updating the instance
                /// partition. If the named instance partition does not exist, returns `NOT_FOUND`. Immediately upon
                /// completion of this request: * For resource types for which a decrease in the instance partition's
                /// allocation has been requested, billing is based on the newly-requested level. Until completion of
                /// the returned operation: * Cancelling the operation sets its metadata's cancel_time, and begins
                /// restoring resources to their pre-request values. The operation is guaranteed to succeed at undoing
                /// all resource changes, after which point it terminates with a `CANCELLED` status. * All other
                /// attempts to modify the instance partition are rejected. * Reading the instance partition via the API
                /// continues to give the pre-request resource levels. Upon completion of the returned operation: *
                /// Billing begins for all successfully-allocated resources (some types may have lower than the
                /// requested levels). * All newly-reserved resources are available for serving the instance partition's
                /// tables. * The instance partition's new resource levels are readable via the API. The returned
                /// long-running operation will have a name of the format `/operations/` and can be used to track the
                /// instance partition modification. The metadata field type is UpdateInstancePartitionMetadata. The
                /// response field type is InstancePartition, if successful. Authorization requires
                /// `spanner.instancePartitions.update` permission on the resource name.
                /// </summary>
                public class PatchRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Spanner.v1.Data.UpdateInstancePartitionRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. A unique identifier for the instance partition. Values are of the form
                    /// `projects//instances//instancePartitions/a-z*[a-z0-9]`. The final segment of the name must be
                    /// between 2 and 64 characters in length. An instance partition's name cannot be changed after the
                    /// instance partition is created.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Spanner.v1.Data.UpdateInstancePartitionRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/instances/[^/]+/instancePartitions/[^/]+$",
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
                /// <param name="name">The name of the operation resource to be cancelled.</param>
                public virtual CancelRequest Cancel(string name)
                {
                    return new CancelRequest(this.service, name);
                }

                /// <summary>
                /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to
                /// cancel the operation, but success is not guaranteed. If the server doesn't support this method, it
                /// returns `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other methods to
                /// check whether the cancellation succeeded or whether the operation completed despite cancellation. On
                /// successful cancellation, the operation is not deleted; instead, it becomes an operation with an
                /// Operation.error value with a google.rpc.Status.code of `1`, corresponding to `Code.CANCELLED`.
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
                    return new DeleteRequest(this.service, name);
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
                    return new GetRequest(this.service, name);
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
                return new CreateRequest(this.service, body, parent);
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
                return new DeleteRequest(this.service, name);
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
                return new GetRequest(this.service, name);
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
                return new GetIamPolicyRequest(this.service, body, resource);
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
                return new ListRequest(this.service, parent);
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

                private object _instanceDeadline;

                /// <summary>
                /// String representation of <see cref="InstanceDeadlineDateTimeOffset"/>, formatted for inclusion in
                /// the HTTP request.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("instanceDeadline", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string InstanceDeadlineRaw { get; private set; }

                /// <summary><seealso cref="object"/> representation of <see cref="InstanceDeadlineRaw"/>.</summary>
                [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use InstanceDeadlineDateTimeOffset instead.")]
                public virtual object InstanceDeadline
                {
                    get => _instanceDeadline;
                    set
                    {
                        InstanceDeadlineRaw = Google.Apis.Util.Utilities.ConvertToString(value);
                        _instanceDeadline = value;
                    }
                }

                public virtual System.DateTimeOffset? InstanceDeadlineDateTimeOffset
                {
                    get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(InstanceDeadlineRaw);
                    set
                    {
                        InstanceDeadlineRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
                        _instanceDeadline = value;
                    }
                }

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
            /// Moves an instance to the target instance configuration. You can use the returned long-running operation
            /// to track the progress of moving the instance. `MoveInstance` returns `FAILED_PRECONDITION` if the
            /// instance meets any of the following criteria: * Is undergoing a move to a different instance
            /// configuration * Has backups * Has an ongoing update * Contains any CMEK-enabled databases * Is a free
            /// trial instance While the operation is pending: * All other attempts to modify the instance, including
            /// changes to its compute capacity, are rejected. * The following database and backup admin operations are
            /// rejected: * `DatabaseAdmin.CreateDatabase` * `DatabaseAdmin.UpdateDatabaseDdl` (disabled if
            /// default_leader is specified in the request.) * `DatabaseAdmin.RestoreDatabase` *
            /// `DatabaseAdmin.CreateBackup` * `DatabaseAdmin.CopyBackup` * Both the source and target instance
            /// configurations are subject to hourly compute and storage charges. * The instance might experience higher
            /// read-write latencies and a higher transaction abort rate. However, moving an instance doesn't cause any
            /// downtime. The returned long-running operation has a name of the format `/operations/` and can be used to
            /// track the move instance operation. The metadata field type is MoveInstanceMetadata. The response field
            /// type is Instance, if successful. Cancelling the operation sets its metadata's cancel_time. Cancellation
            /// is not immediate because it involves moving any data previously moved to the target instance
            /// configuration back to the original instance configuration. You can use this operation to track the
            /// progress of the cancellation. Upon successful completion of the cancellation, the operation terminates
            /// with `CANCELLED` status. If not cancelled, upon completion of the returned operation: * The instance
            /// successfully moves to the target instance configuration. * You are billed for compute and storage in
            /// target instance configuration. Authorization requires the `spanner.instances.update` permission on the
            /// resource instance. For more details, see [Move an
            /// instance](https://cloud.google.com/spanner/docs/move-instance).
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The instance to move. Values are of the form `projects//instances/`.
            /// </param>
            public virtual MoveRequest Move(Google.Apis.Spanner.v1.Data.MoveInstanceRequest body, string name)
            {
                return new MoveRequest(this.service, body, name);
            }

            /// <summary>
            /// Moves an instance to the target instance configuration. You can use the returned long-running operation
            /// to track the progress of moving the instance. `MoveInstance` returns `FAILED_PRECONDITION` if the
            /// instance meets any of the following criteria: * Is undergoing a move to a different instance
            /// configuration * Has backups * Has an ongoing update * Contains any CMEK-enabled databases * Is a free
            /// trial instance While the operation is pending: * All other attempts to modify the instance, including
            /// changes to its compute capacity, are rejected. * The following database and backup admin operations are
            /// rejected: * `DatabaseAdmin.CreateDatabase` * `DatabaseAdmin.UpdateDatabaseDdl` (disabled if
            /// default_leader is specified in the request.) * `DatabaseAdmin.RestoreDatabase` *
            /// `DatabaseAdmin.CreateBackup` * `DatabaseAdmin.CopyBackup` * Both the source and target instance
            /// configurations are subject to hourly compute and storage charges. * The instance might experience higher
            /// read-write latencies and a higher transaction abort rate. However, moving an instance doesn't cause any
            /// downtime. The returned long-running operation has a name of the format `/operations/` and can be used to
            /// track the move instance operation. The metadata field type is MoveInstanceMetadata. The response field
            /// type is Instance, if successful. Cancelling the operation sets its metadata's cancel_time. Cancellation
            /// is not immediate because it involves moving any data previously moved to the target instance
            /// configuration back to the original instance configuration. You can use this operation to track the
            /// progress of the cancellation. Upon successful completion of the cancellation, the operation terminates
            /// with `CANCELLED` status. If not cancelled, upon completion of the returned operation: * The instance
            /// successfully moves to the target instance configuration. * You are billed for compute and storage in
            /// target instance configuration. Authorization requires the `spanner.instances.update` permission on the
            /// resource instance. For more details, see [Move an
            /// instance](https://cloud.google.com/spanner/docs/move-instance).
            /// </summary>
            public class MoveRequest : SpannerBaseServiceRequest<Google.Apis.Spanner.v1.Data.Operation>
            {
                /// <summary>Constructs a new Move request.</summary>
                public MoveRequest(Google.Apis.Services.IClientService service, Google.Apis.Spanner.v1.Data.MoveInstanceRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The instance to move. Values are of the form `projects//instances/`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Spanner.v1.Data.MoveInstanceRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "move";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:move";

                /// <summary>Initializes Move parameter list.</summary>
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
            /// requires `spanner.instances.update` permission on the resource name.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. A unique identifier for the instance, which cannot be changed after the instance is created.
            /// Values are of the form `projects//instances/a-z*[a-z0-9]`. The final segment of the name must be between
            /// 2 and 64 characters in length.
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.Spanner.v1.Data.UpdateInstanceRequest body, string name)
            {
                return new PatchRequest(this.service, body, name);
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
            /// requires `spanner.instances.update` permission on the resource name.
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
                return new SetIamPolicyRequest(this.service, body, resource);
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
                return new TestIamPermissionsRequest(this.service, body, resource);
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
            return new ListRequest(this.service, parent);
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
    /// <summary>Message sent by the client to the adapter.</summary>
    public class AdaptMessageRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Opaque request state passed by the client to the server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attachments")]
        public virtual System.Collections.Generic.IDictionary<string, string> Attachments { get; set; }

        /// <summary>Optional. Uninterpreted bytes from the underlying wire protocol.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("payload")]
        public virtual string Payload { get; set; }

        /// <summary>Required. Identifier for the underlying wire protocol.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protocol")]
        public virtual string Protocol { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message sent by the adapter to the client.</summary>
    public class AdaptMessageResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Uninterpreted bytes from the underlying wire protocol.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("payload")]
        public virtual string Payload { get; set; }

        /// <summary>Optional. Opaque state updates to be applied by the client.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateUpdates")]
        public virtual System.Collections.Generic.IDictionary<string, string> StateUpdates { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A session in the Cloud Spanner Adapter API.</summary>
    public class AdapterSession : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifier. The name of the session. This is always system-assigned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for AddSplitPoints.</summary>
    public class AddSplitPointsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A user-supplied tag associated with the split points. For example, "initial_data_load",
        /// "special_event_1". Defaults to "CloudAddSplitPointsAPI" if not specified. The length of the tag must not
        /// exceed 50 characters, or else it is trimmed. Only valid UTF8 characters are allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("initiator")]
        public virtual string Initiator { get; set; }

        /// <summary>Required. The split points to add.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("splitPoints")]
        public virtual System.Collections.Generic.IList<SplitPoints> SplitPoints { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for AddSplitPoints.</summary>
    public class AddSplitPointsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// AsymmetricAutoscalingOption specifies the scaling of replicas identified by the given selection.
    /// </summary>
    public class AsymmetricAutoscalingOption : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Overrides applied to the top-level autoscaling configuration for the selected replicas.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("overrides")]
        public virtual AutoscalingConfigOverrides Overrides { get; set; }

        /// <summary>
        /// Required. Selects the replicas to which this AsymmetricAutoscalingOption applies. Only read-only replicas
        /// are supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replicaSelection")]
        public virtual InstanceReplicaSelection ReplicaSelection { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Autoscaling configuration for an instance.</summary>
    public class AutoscalingConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Optional asymmetric autoscaling options. Replicas matching the replica selection criteria will be
        /// autoscaled independently from other replicas. The autoscaler will scale the replicas based on the
        /// utilization of replicas identified by the replica selection. Replica selections should not overlap with each
        /// other. Other replicas (those do not match any replica selection) will be autoscaled together and will have
        /// the same compute capacity allocated to them.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("asymmetricAutoscalingOptions")]
        public virtual System.Collections.Generic.IList<AsymmetricAutoscalingOption> AsymmetricAutoscalingOptions { get; set; }

        /// <summary>Required. Autoscaling limits for an instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoscalingLimits")]
        public virtual AutoscalingLimits AutoscalingLimits { get; set; }

        /// <summary>Required. The autoscaling targets for an instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoscalingTargets")]
        public virtual AutoscalingTargets AutoscalingTargets { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Overrides the top-level autoscaling configuration for the replicas identified by `replica_selection`. All fields
    /// in this message are optional. Any unspecified fields will use the corresponding values from the top-level
    /// autoscaling configuration.
    /// </summary>
    public class AutoscalingConfigOverrides : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. If specified, overrides the min/max limit in the top-level autoscaling configuration for the
        /// selected replicas.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoscalingLimits")]
        public virtual AutoscalingLimits AutoscalingLimits { get; set; }

        /// <summary>
        /// Optional. If specified, overrides the autoscaling target high_priority_cpu_utilization_percent in the
        /// top-level autoscaling configuration for the selected replicas.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoscalingTargetHighPriorityCpuUtilizationPercent")]
        public virtual System.Nullable<int> AutoscalingTargetHighPriorityCpuUtilizationPercent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The autoscaling limits for the instance. Users can define the minimum and maximum compute capacity allocated to
    /// the instance, and the autoscaler will only scale within that range. Users can either use nodes or processing
    /// units to specify the limits, but should use the same unit to set both the min_limit and max_limit.
    /// </summary>
    public class AutoscalingLimits : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Maximum number of nodes allocated to the instance. If set, this number should be greater than or equal to
        /// min_nodes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxNodes")]
        public virtual System.Nullable<int> MaxNodes { get; set; }

        /// <summary>
        /// Maximum number of processing units allocated to the instance. If set, this number should be multiples of
        /// 1000 and be greater than or equal to min_processing_units.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxProcessingUnits")]
        public virtual System.Nullable<int> MaxProcessingUnits { get; set; }

        /// <summary>
        /// Minimum number of nodes allocated to the instance. If set, this number should be greater than or equal to 1.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minNodes")]
        public virtual System.Nullable<int> MinNodes { get; set; }

        /// <summary>
        /// Minimum number of processing units allocated to the instance. If set, this number should be multiples of
        /// 1000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minProcessingUnits")]
        public virtual System.Nullable<int> MinProcessingUnits { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The autoscaling targets for an instance.</summary>
    public class AutoscalingTargets : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The target high priority cpu utilization percentage that the autoscaler should be trying to
        /// achieve for the instance. This number is on a scale from 0 (no utilization) to 100 (full utilization). The
        /// valid range is [10, 90] inclusive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("highPriorityCpuUtilizationPercent")]
        public virtual System.Nullable<int> HighPriorityCpuUtilizationPercent { get; set; }

        /// <summary>
        /// Required. The target storage utilization percentage that the autoscaler should be trying to achieve for the
        /// instance. This number is on a scale from 0 (no utilization) to 100 (full utilization). The valid range is
        /// [10, 99] inclusive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageUtilizationPercent")]
        public virtual System.Nullable<int> StorageUtilizationPercent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A backup of a Cloud Spanner database.</summary>
    public class Backup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. List of backup schedule URIs that are associated with creating this backup. This is only
        /// applicable for scheduled backups, and is empty for on-demand backups. To optimize for storage, whenever
        /// possible, multiple schedules are collapsed together to create one backup. In such cases, this field captures
        /// the list of all backup schedule URIs that are associated with creating this backup. If collapsing is not
        /// done, then this field captures the single backup schedule URI associated with creating this backup.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupSchedules")]
        public virtual System.Collections.Generic.IList<string> BackupSchedules { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>
        /// Output only. The time the CreateBackup request is received. If the request does not specify `version_time`,
        /// the `version_time` of the backup will be equivalent to the `create_time`.
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

        /// <summary>
        /// Required for the CreateBackup operation. Name of the database from which this backup was created. This needs
        /// to be in the same instance as the backup. Values are of the form `projects//instances//databases/`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("database")]
        public virtual string Database { get; set; }

        /// <summary>Output only. The database dialect information for the backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseDialect")]
        public virtual string DatabaseDialect { get; set; }

        /// <summary>Output only. The encryption information for the backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionInfo")]
        public virtual EncryptionInfo EncryptionInfo { get; set; }

        /// <summary>
        /// Output only. The encryption information for the backup, whether it is protected by one or more KMS keys. The
        /// information includes all Cloud KMS key versions used to encrypt the backup. The `encryption_status` field
        /// inside of each `EncryptionInfo` is not populated. At least one of the key versions must be available for the
        /// backup to be restored. If a key version is revoked in the middle of a restore, the restore behavior is
        /// undefined.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionInformation")]
        public virtual System.Collections.Generic.IList<EncryptionInfo> EncryptionInformation { get; set; }

        /// <summary>
        /// Output only. For a backup in an incremental backup chain, this is the storage space needed to keep the data
        /// that has changed since the previous backup. For all other backups, this is always the size of the backup.
        /// This value may change if backups on the same chain get deleted or expired. This field can be used to
        /// calculate the total storage space used by a set of backups. For example, the total space used by all backups
        /// of a database can be computed by summing up this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exclusiveSizeBytes")]
        public virtual System.Nullable<long> ExclusiveSizeBytes { get; set; }

        private string _expireTimeRaw;

        private object _expireTime;

        /// <summary>
        /// Required for the CreateBackup operation. The expiration time of the backup, with microseconds granularity
        /// that must be at least 6 hours and at most 366 days from the time the CreateBackup request is processed. Once
        /// the `expire_time` has passed, the backup is eligible to be automatically deleted by Cloud Spanner to free
        /// the resources used by the backup.
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
        /// Output only. The number of bytes that will be freed by deleting this backup. This value will be zero if, for
        /// example, this backup is part of an incremental backup chain and younger backups in the chain require that we
        /// keep its data. For backups not in an incremental backup chain, this is always the size of the backup. This
        /// value may change if backups on the same chain get created, deleted or expired.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freeableSizeBytes")]
        public virtual System.Nullable<long> FreeableSizeBytes { get; set; }

        /// <summary>
        /// Output only. Populated only for backups in an incremental backup chain. Backups share the same chain id if
        /// and only if they belong to the same incremental backup chain. Use this field to determine which backups are
        /// part of the same incremental backup chain. The ordering of backups in the chain can be determined by
        /// ordering the backup `version_time`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("incrementalBackupChainId")]
        public virtual string IncrementalBackupChainId { get; set; }

        /// <summary>
        /// Output only. The instance partition(s) storing the backup. This is the same as the list of the instance
        /// partition(s) that the database had footprint in at the backup's `version_time`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instancePartitions")]
        public virtual System.Collections.Generic.IList<BackupInstancePartition> InstancePartitions { get; set; }

        private string _maxExpireTimeRaw;

        private object _maxExpireTime;

        /// <summary>
        /// Output only. The max allowed expiration time of the backup, with microseconds granularity. A backup's
        /// expiration time can be configured in multiple APIs: CreateBackup, UpdateBackup, CopyBackup. When updating or
        /// copying an existing backup, the expiration time specified must be less than `Backup.max_expire_time`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxExpireTime")]
        public virtual string MaxExpireTimeRaw
        {
            get => _maxExpireTimeRaw;
            set
            {
                _maxExpireTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _maxExpireTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="MaxExpireTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use MaxExpireTimeDateTimeOffset instead.")]
        public virtual object MaxExpireTime
        {
            get => _maxExpireTime;
            set
            {
                _maxExpireTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _maxExpireTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="MaxExpireTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? MaxExpireTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(MaxExpireTimeRaw);
            set => MaxExpireTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

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

        private string _oldestVersionTimeRaw;

        private object _oldestVersionTime;

        /// <summary>
        /// Output only. Data deleted at a time older than this is guaranteed not to be retained in order to support
        /// this backup. For a backup in an incremental backup chain, this is the version time of the oldest backup that
        /// exists or ever existed in the chain. For all other backups, this is the version time of the backup. This
        /// field can be used to understand what data is being retained by the backup system.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oldestVersionTime")]
        public virtual string OldestVersionTimeRaw
        {
            get => _oldestVersionTimeRaw;
            set
            {
                _oldestVersionTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _oldestVersionTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="OldestVersionTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use OldestVersionTimeDateTimeOffset instead.")]
        public virtual object OldestVersionTime
        {
            get => _oldestVersionTime;
            set
            {
                _oldestVersionTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _oldestVersionTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="OldestVersionTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? OldestVersionTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(OldestVersionTimeRaw);
            set => OldestVersionTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Output only. The names of the destination backups being created by copying this source backup. The backup
        /// names are of the form `projects//instances//backups/`. Referencing backups may exist in different instances.
        /// The existence of any referencing backup prevents the backup from being deleted. When the copy operation is
        /// done (either successfully completed or cancelled or the destination backup is deleted), the reference to the
        /// backup is removed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referencingBackups")]
        public virtual System.Collections.Generic.IList<string> ReferencingBackups { get; set; }

        /// <summary>
        /// Output only. The names of the restored databases that reference the backup. The database names are of the
        /// form `projects//instances//databases/`. Referencing databases may exist in different instances. The
        /// existence of any referencing database prevents the backup from being deleted. When a restored database from
        /// the backup enters the `READY` state, the reference to the backup is removed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referencingDatabases")]
        public virtual System.Collections.Generic.IList<string> ReferencingDatabases { get; set; }

        /// <summary>
        /// Output only. Size of the backup in bytes. For a backup in an incremental backup chain, this is the sum of
        /// the `exclusive_size_bytes` of itself and all older backups in the chain.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeBytes")]
        public virtual System.Nullable<long> SizeBytes { get; set; }

        /// <summary>Output only. The current state of the backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        private string _versionTimeRaw;

        private object _versionTime;

        /// <summary>
        /// The backup will contain an externally consistent copy of the database at the timestamp specified by
        /// `version_time`. If `version_time` is not specified, the system will set `version_time` to the `create_time`
        /// of the backup.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionTime")]
        public virtual string VersionTimeRaw
        {
            get => _versionTimeRaw;
            set
            {
                _versionTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _versionTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="VersionTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use VersionTimeDateTimeOffset instead.")]
        public virtual object VersionTime
        {
            get => _versionTime;
            set
            {
                _versionTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _versionTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="VersionTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? VersionTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(VersionTimeRaw);
            set => VersionTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a backup.</summary>
    public class BackupInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backup")]
        public virtual string Backup { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>The time the CreateBackup request was received.</summary>
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

        /// <summary>Name of the database the backup was created from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceDatabase")]
        public virtual string SourceDatabase { get; set; }

        private string _versionTimeRaw;

        private object _versionTime;

        /// <summary>
        /// The backup contains an externally consistent copy of `source_database` at the timestamp specified by
        /// `version_time`. If the CreateBackup request did not specify `version_time`, the `version_time` of the backup
        /// is equivalent to the `create_time`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionTime")]
        public virtual string VersionTimeRaw
        {
            get => _versionTimeRaw;
            set
            {
                _versionTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _versionTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="VersionTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use VersionTimeDateTimeOffset instead.")]
        public virtual object VersionTime
        {
            get => _versionTime;
            set
            {
                _versionTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _versionTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="VersionTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? VersionTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(VersionTimeRaw);
            set => VersionTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Instance partition information for the backup.</summary>
    public class BackupInstancePartition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A unique identifier for the instance partition. Values are of the form
        /// `projects//instances//instancePartitions/`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instancePartition")]
        public virtual string InstancePartition { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>BackupSchedule expresses the automated backup creation specification for a Spanner database.</summary>
    public class BackupSchedule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The encryption configuration that is used to encrypt the backup. If this field is not specified,
        /// the backup uses the same encryption configuration as the database.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionConfig")]
        public virtual CreateBackupEncryptionConfig EncryptionConfig { get; set; }

        /// <summary>The schedule creates only full backups.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullBackupSpec")]
        public virtual FullBackupSpec FullBackupSpec { get; set; }

        /// <summary>The schedule creates incremental backup chains.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("incrementalBackupSpec")]
        public virtual IncrementalBackupSpec IncrementalBackupSpec { get; set; }

        /// <summary>
        /// Identifier. Output only for the CreateBackupSchedule operation. Required for the UpdateBackupSchedule
        /// operation. A globally unique identifier for the backup schedule which cannot be changed. Values are of the
        /// form `projects//instances//databases//backupSchedules/a-z*[a-z0-9]` The final segment of the name must be
        /// between 2 and 60 characters in length.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. The retention duration of a backup that must be at least 6 hours and at most 366 days. The backup
        /// is eligible to be automatically deleted once the retention period has elapsed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retentionDuration")]
        public virtual object RetentionDuration { get; set; }

        /// <summary>Optional. The schedule specification based on which the backup creations are triggered.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spec")]
        public virtual BackupScheduleSpec Spec { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>
        /// Output only. The timestamp at which the schedule was last updated. If the schedule has never been updated,
        /// this field contains the timestamp when the schedule was first created.
        /// </summary>
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

    /// <summary>Defines specifications of the backup schedule.</summary>
    public class BackupScheduleSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Cron style schedule specification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cronSpec")]
        public virtual CrontabSpec CronSpec { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for BatchCreateSessions.</summary>
    public class BatchCreateSessionsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The number of sessions to be created in this batch call. The API can return fewer than the
        /// requested number of sessions. If a specific number of sessions are desired, the client can make additional
        /// calls to `BatchCreateSessions` (adjusting session_count as necessary).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sessionCount")]
        public virtual System.Nullable<int> SessionCount { get; set; }

        /// <summary>Parameters to apply to each created session.</summary>
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

    /// <summary>The request for BatchWrite.</summary>
    public class BatchWriteRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. When `exclude_txn_from_change_streams` is set to `true`: * Modifications from all transactions in
        /// this batch write operation are not be recorded in change streams with DDL option `allow_txn_exclusion=true`
        /// that are tracking columns modified by these transactions. * Modifications from all transactions in this
        /// batch write operation are recorded in change streams with DDL option `allow_txn_exclusion=false or not set`
        /// that are tracking columns modified by these transactions. When `exclude_txn_from_change_streams` is set to
        /// `false` or not set, Modifications from all transactions in this batch write operation are recorded in all
        /// change streams that are tracking columns modified by these transactions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludeTxnFromChangeStreams")]
        public virtual System.Nullable<bool> ExcludeTxnFromChangeStreams { get; set; }

        /// <summary>Required. The groups of mutations to be applied.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mutationGroups")]
        public virtual System.Collections.Generic.IList<MutationGroup> MutationGroups { get; set; }

        /// <summary>Common options for this request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestOptions")]
        public virtual RequestOptions RequestOptions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The result of applying a batch of mutations.</summary>
    public class BatchWriteResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _commitTimestampRaw;

        private object _commitTimestamp;

        /// <summary>
        /// The commit timestamp of the transaction that applied this batch. Present if `status` is `OK`, absent
        /// otherwise.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commitTimestamp")]
        public virtual string CommitTimestampRaw
        {
            get => _commitTimestampRaw;
            set
            {
                _commitTimestamp = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _commitTimestampRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CommitTimestampRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CommitTimestampDateTimeOffset instead.")]
        public virtual object CommitTimestamp
        {
            get => _commitTimestamp;
            set
            {
                _commitTimestampRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _commitTimestamp = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="CommitTimestampRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CommitTimestampDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CommitTimestampRaw);
            set => CommitTimestampRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// The mutation groups applied in this batch. The values index into the `mutation_groups` field in the
        /// corresponding `BatchWriteRequest`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indexes")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> Indexes { get; set; }

        /// <summary>An `OK` status indicates success. Any other status indicates a failure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual Status Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for BeginTransaction.</summary>
    public class BeginTransactionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Required for read-write transactions on a multiplexed session that commit mutations but don't
        /// perform any reads or queries. You must randomly select one of the mutations from the mutation set and send
        /// it as a part of this request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mutationKey")]
        public virtual Mutation MutationKey { get; set; }

        /// <summary>Required. Options for the new transaction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("options")]
        public virtual TransactionOptions Options { get; set; }

        /// <summary>
        /// Common options for this request. Priority is ignored for this request. Setting the priority in this
        /// `request_options` struct doesn't do anything. To set the priority for a transaction, set it on the reads and
        /// writes that are part of this transaction instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestOptions")]
        public virtual RequestOptions RequestOptions { get; set; }

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

    /// <summary>Metadata type for the long-running operation returned by ChangeQuorum.</summary>
    public class ChangeQuorumMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _endTimeRaw;

        private object _endTime;

        /// <summary>If set, the time at which this operation failed or was completed successfully.</summary>
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

        /// <summary>The request for ChangeQuorum.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("request")]
        public virtual ChangeQuorumRequest Request { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>Time the request was received.</summary>
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

    /// <summary>The request for ChangeQuorum.</summary>
    public class ChangeQuorumRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The etag is the hash of the `QuorumInfo`. The `ChangeQuorum` operation is only performed if the
        /// etag matches that of the `QuorumInfo` in the current database resource. Otherwise the API returns an
        /// `ABORTED` error. The etag is used for optimistic concurrency control as a way to help prevent simultaneous
        /// change quorum requests that could create a race condition.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Required. Name of the database in which to apply `ChangeQuorum`. Values are of the form
        /// `projects//instances//databases/`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. The type of this quorum.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quorumType")]
        public virtual QuorumType QuorumType { get; set; }
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
        /// Optional. The amount of latency this request is configured to incur in order to improve throughput. If this
        /// field isn't set, Spanner assumes requests are relatively latency sensitive and automatically determines an
        /// appropriate delay time. You can specify a commit delay value between 0 and 500 ms.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxCommitDelay")]
        public virtual object MaxCommitDelay { get; set; }

        /// <summary>
        /// The mutations to be executed when this transaction commits. All mutations are applied atomically, in the
        /// order they appear in this list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mutations")]
        public virtual System.Collections.Generic.IList<Mutation> Mutations { get; set; }

        /// <summary>
        /// Optional. If the read-write transaction was executed on a multiplexed session, then you must include the
        /// precommit token with the highest sequence number received in this transaction attempt. Failing to do so
        /// results in a `FailedPrecondition` error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("precommitToken")]
        public virtual MultiplexedSessionPrecommitToken PrecommitToken { get; set; }

        /// <summary>Common options for this request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestOptions")]
        public virtual RequestOptions RequestOptions { get; set; }

        /// <summary>
        /// If `true`, then statistics related to the transaction is included in the CommitResponse. Default value is
        /// `false`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("returnCommitStats")]
        public virtual System.Nullable<bool> ReturnCommitStats { get; set; }

        /// <summary>
        /// Execute mutations in a temporary transaction. Note that unlike commit of a previously-started transaction,
        /// commit with a temporary transaction is non-idempotent. That is, if the `CommitRequest` is sent to Cloud
        /// Spanner more than once (for instance, due to retries in the application, or in the transport library), it's
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
        /// The statistics about this `Commit`. Not returned by default. For more information, see
        /// CommitRequest.return_commit_stats.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commitStats")]
        public virtual CommitStats CommitStats { get; set; }

        private string _commitTimestampRaw;

        private object _commitTimestamp;

        /// <summary>The Cloud Spanner timestamp at which the transaction committed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commitTimestamp")]
        public virtual string CommitTimestampRaw
        {
            get => _commitTimestampRaw;
            set
            {
                _commitTimestamp = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _commitTimestampRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CommitTimestampRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CommitTimestampDateTimeOffset instead.")]
        public virtual object CommitTimestamp
        {
            get => _commitTimestamp;
            set
            {
                _commitTimestampRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _commitTimestamp = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="CommitTimestampRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CommitTimestampDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CommitTimestampRaw);
            set => CommitTimestampRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// If specified, transaction has not committed yet. You must retry the commit with the new precommit token.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("precommitToken")]
        public virtual MultiplexedSessionPrecommitToken PrecommitToken { get; set; }

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

    /// <summary>Encryption configuration for the copied backup.</summary>
    public class CopyBackupEncryptionConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The encryption type of the backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionType")]
        public virtual string EncryptionType { get; set; }

        /// <summary>
        /// Optional. The Cloud KMS key that will be used to protect the backup. This field should be set only when
        /// encryption_type is `CUSTOMER_MANAGED_ENCRYPTION`. Values are of the form
        /// `projects//locations//keyRings//cryptoKeys/`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeyName")]
        public virtual string KmsKeyName { get; set; }

        /// <summary>
        /// Optional. Specifies the KMS configuration for the one or more keys used to protect the backup. Values are of
        /// the form `projects//locations//keyRings//cryptoKeys/`. KMS keys specified can be in any order. The keys
        /// referenced by `kms_key_names` must fully cover all regions of the backup's instance configuration. Some
        /// examples: * For regional (single-region) instance configurations, specify a regional location KMS key. * For
        /// multi-region instance configurations of type `GOOGLE_MANAGED`, either specify a multi-region location KMS
        /// key or multiple regional location KMS keys that cover all regions in the instance configuration. * For an
        /// instance configuration of type `USER_MANAGED`, specify only regional location KMS keys to cover each region
        /// in the instance configuration. Multi-region location KMS keys aren't supported for `USER_MANAGED` type
        /// instance configurations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeyNames")]
        public virtual System.Collections.Generic.IList<string> KmsKeyNames { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata type for the operation returned by CopyBackup.</summary>
    public class CopyBackupMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _cancelTimeRaw;

        private object _cancelTime;

        /// <summary>
        /// The time at which cancellation of CopyBackup operation was received. Operations.CancelOperation starts
        /// asynchronous cancellation on a long-running operation. The server makes a best effort to cancel the
        /// operation, but success is not guaranteed. Clients can use Operations.GetOperation or other methods to check
        /// whether the cancellation succeeded or whether the operation completed despite cancellation. On successful
        /// cancellation, the operation is not deleted; instead, it becomes an operation with an Operation.error value
        /// with a google.rpc.Status.code of 1, corresponding to `Code.CANCELLED`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cancelTime")]
        public virtual string CancelTimeRaw
        {
            get => _cancelTimeRaw;
            set
            {
                _cancelTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _cancelTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CancelTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CancelTimeDateTimeOffset instead.")]
        public virtual object CancelTime
        {
            get => _cancelTime;
            set
            {
                _cancelTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _cancelTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CancelTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CancelTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CancelTimeRaw);
            set => CancelTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// The name of the backup being created through the copy operation. Values are of the form
        /// `projects//instances//backups/`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The progress of the CopyBackup operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progress")]
        public virtual OperationProgress Progress { get; set; }

        /// <summary>
        /// The name of the source backup that is being copied. Values are of the form `projects//instances//backups/`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceBackup")]
        public virtual string SourceBackup { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for CopyBackup.</summary>
    public class CopyBackupRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The id of the backup copy. The `backup_id` appended to `parent` forms the full backup_uri of the
        /// form `projects//instances//backups/`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupId")]
        public virtual string BackupId { get; set; }

        /// <summary>
        /// Optional. The encryption configuration used to encrypt the backup. If this field is not specified, the
        /// backup will use the same encryption configuration as the source backup by default, namely encryption_type =
        /// `USE_CONFIG_DEFAULT_OR_BACKUP_ENCRYPTION`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionConfig")]
        public virtual CopyBackupEncryptionConfig EncryptionConfig { get; set; }

        private string _expireTimeRaw;

        private object _expireTime;

        /// <summary>
        /// Required. The expiration time of the backup in microsecond granularity. The expiration time must be at least
        /// 6 hours and at most 366 days from the `create_time` of the source backup. Once the `expire_time` has passed,
        /// the backup is eligible to be automatically deleted by Cloud Spanner to free the resources used by the
        /// backup.
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
        /// Required. The source backup to be copied. The source backup needs to be in READY state for it to be copied.
        /// Once CopyBackup is in progress, the source backup cannot be deleted or cleaned up on expiration until
        /// CopyBackup is finished. Values are of the form: `projects//instances//backups/`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceBackup")]
        public virtual string SourceBackup { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Encryption configuration for the backup to create.</summary>
    public class CreateBackupEncryptionConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The encryption type of the backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionType")]
        public virtual string EncryptionType { get; set; }

        /// <summary>
        /// Optional. The Cloud KMS key that will be used to protect the backup. This field should be set only when
        /// encryption_type is `CUSTOMER_MANAGED_ENCRYPTION`. Values are of the form
        /// `projects//locations//keyRings//cryptoKeys/`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeyName")]
        public virtual string KmsKeyName { get; set; }

        /// <summary>
        /// Optional. Specifies the KMS configuration for the one or more keys used to protect the backup. Values are of
        /// the form `projects//locations//keyRings//cryptoKeys/`. The keys referenced by `kms_key_names` must fully
        /// cover all regions of the backup's instance configuration. Some examples: * For regional (single-region)
        /// instance configurations, specify a regional location KMS key. * For multi-region instance configurations of
        /// type `GOOGLE_MANAGED`, either specify a multi-region location KMS key or multiple regional location KMS keys
        /// that cover all regions in the instance configuration. * For an instance configuration of type
        /// `USER_MANAGED`, specify only regional location KMS keys to cover each region in the instance configuration.
        /// Multi-region location KMS keys aren't supported for `USER_MANAGED` type instance configurations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeyNames")]
        public virtual System.Collections.Generic.IList<string> KmsKeyNames { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata type for the operation returned by CreateBackup.</summary>
    public class CreateBackupMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _cancelTimeRaw;

        private object _cancelTime;

        /// <summary>
        /// The time at which cancellation of this operation was received. Operations.CancelOperation starts
        /// asynchronous cancellation on a long-running operation. The server makes a best effort to cancel the
        /// operation, but success is not guaranteed. Clients can use Operations.GetOperation or other methods to check
        /// whether the cancellation succeeded or whether the operation completed despite cancellation. On successful
        /// cancellation, the operation is not deleted; instead, it becomes an operation with an Operation.error value
        /// with a google.rpc.Status.code of 1, corresponding to `Code.CANCELLED`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cancelTime")]
        public virtual string CancelTimeRaw
        {
            get => _cancelTimeRaw;
            set
            {
                _cancelTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _cancelTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CancelTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CancelTimeDateTimeOffset instead.")]
        public virtual object CancelTime
        {
            get => _cancelTime;
            set
            {
                _cancelTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _cancelTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CancelTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CancelTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CancelTimeRaw);
            set => CancelTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

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

        /// <summary>Optional. The dialect of the Cloud Spanner Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseDialect")]
        public virtual string DatabaseDialect { get; set; }

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

        /// <summary>
        /// Optional. Proto descriptors used by `CREATE/ALTER PROTO BUNDLE` statements in 'extra_statements'. Contains a
        /// protobuf-serialized
        /// [`google.protobuf.FileDescriptorSet`](https://github.com/protocolbuffers/protobuf/blob/main/src/google/protobuf/descriptor.proto)
        /// descriptor set. To generate it, [install](https://grpc.io/docs/protoc-installation/) and run `protoc` with
        /// --include_imports and --descriptor_set_out. For example, to generate for moon/shot/app.proto, run
        /// ```
        /// $protoc --proto_path=/app_path --proto_path=/lib_path \ --include_imports \
        /// --descriptor_set_out=descriptors.data \ moon/shot/app.proto
        /// ```
        /// For more details, see protobuffer [self
        /// description](https://developers.google.com/protocol-buffers/docs/techniques#self-description).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protoDescriptors")]
        public virtual string ProtoDescriptors { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata type for the operation returned by CreateInstanceConfig.</summary>
    public class CreateInstanceConfigMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _cancelTimeRaw;

        private object _cancelTime;

        /// <summary>The time at which this operation was cancelled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cancelTime")]
        public virtual string CancelTimeRaw
        {
            get => _cancelTimeRaw;
            set
            {
                _cancelTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _cancelTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CancelTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CancelTimeDateTimeOffset instead.")]
        public virtual object CancelTime
        {
            get => _cancelTime;
            set
            {
                _cancelTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _cancelTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CancelTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CancelTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CancelTimeRaw);
            set => CancelTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The target instance configuration end state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceConfig")]
        public virtual InstanceConfig InstanceConfig { get; set; }

        /// <summary>The progress of the CreateInstanceConfig operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progress")]
        public virtual InstanceOperationProgress Progress { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for CreateInstanceConfig.</summary>
    public class CreateInstanceConfigRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The `InstanceConfig` proto of the configuration to create. `instance_config.name` must be
        /// `/instanceConfigs/`. `instance_config.base_config` must be a Google-managed configuration name, e.g.
        /// /instanceConfigs/us-east1, /instanceConfigs/nam3.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceConfig")]
        public virtual InstanceConfig InstanceConfig { get; set; }

        /// <summary>
        /// Required. The ID of the instance configuration to create. Valid identifiers are of the form
        /// `custom-[-a-z0-9]*[a-z0-9]` and must be between 2 and 64 characters in length. The `custom-` prefix is
        /// required to avoid name conflicts with Google-managed configurations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceConfigId")]
        public virtual string InstanceConfigId { get; set; }

        /// <summary>
        /// An option to validate, but not actually execute, a request, and provide the same response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validateOnly")]
        public virtual System.Nullable<bool> ValidateOnly { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata type for the operation returned by CreateInstance.</summary>
    public class CreateInstanceMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _cancelTimeRaw;

        private object _cancelTime;

        /// <summary>
        /// The time at which this operation was cancelled. If set, this operation is in the process of undoing itself
        /// (which is guaranteed to succeed) and cannot be cancelled again.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cancelTime")]
        public virtual string CancelTimeRaw
        {
            get => _cancelTimeRaw;
            set
            {
                _cancelTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _cancelTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CancelTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CancelTimeDateTimeOffset instead.")]
        public virtual object CancelTime
        {
            get => _cancelTime;
            set
            {
                _cancelTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _cancelTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CancelTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CancelTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CancelTimeRaw);
            set => CancelTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>The time at which this operation failed or was completed successfully.</summary>
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

        /// <summary>The expected fulfillment period of this create operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expectedFulfillmentPeriod")]
        public virtual string ExpectedFulfillmentPeriod { get; set; }

        /// <summary>The instance being created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instance")]
        public virtual Instance Instance { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>The time at which the CreateInstance request was received.</summary>
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

    /// <summary>Metadata type for the operation returned by CreateInstancePartition.</summary>
    public class CreateInstancePartitionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _cancelTimeRaw;

        private object _cancelTime;

        /// <summary>
        /// The time at which this operation was cancelled. If set, this operation is in the process of undoing itself
        /// (which is guaranteed to succeed) and cannot be cancelled again.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cancelTime")]
        public virtual string CancelTimeRaw
        {
            get => _cancelTimeRaw;
            set
            {
                _cancelTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _cancelTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CancelTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CancelTimeDateTimeOffset instead.")]
        public virtual object CancelTime
        {
            get => _cancelTime;
            set
            {
                _cancelTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _cancelTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CancelTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CancelTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CancelTimeRaw);
            set => CancelTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>The time at which this operation failed or was completed successfully.</summary>
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

        /// <summary>The instance partition being created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instancePartition")]
        public virtual InstancePartition InstancePartition { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>The time at which the CreateInstancePartition request was received.</summary>
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

    /// <summary>The request for CreateInstancePartition.</summary>
    public class CreateInstancePartitionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The instance partition to create. The instance_partition.name may be omitted, but if specified
        /// must be `/instancePartitions/`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instancePartition")]
        public virtual InstancePartition InstancePartition { get; set; }

        /// <summary>
        /// Required. The ID of the instance partition to create. Valid identifiers are of the form `a-z*[a-z0-9]` and
        /// must be between 2 and 64 characters in length.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instancePartitionId")]
        public virtual string InstancePartitionId { get; set; }

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

    /// <summary>
    /// CrontabSpec can be used to specify the version time and frequency at which the backup is created.
    /// </summary>
    public class CrontabSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Scheduled backups contain an externally consistent copy of the database at the version time
        /// specified in `schedule_spec.cron_spec`. However, Spanner might not initiate the creation of the scheduled
        /// backups at that version time. Spanner initiates the creation of scheduled backups within the time window
        /// bounded by the version_time specified in `schedule_spec.cron_spec` and version_time + `creation_window`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationWindow")]
        public virtual object CreationWindow { get; set; }

        /// <summary>
        /// Required. Textual representation of the crontab. User can customize the backup frequency and the backup
        /// version time using the cron expression. The version time must be in UTC timezone. The backup will contain an
        /// externally consistent copy of the database at the version time. Full backups must be scheduled a minimum of
        /// 12 hours apart and incremental backups must be scheduled a minimum of 4 hours apart. Examples of valid cron
        /// specifications: * `0 2/12 * * *` : every 12 hours at (2, 14) hours past midnight in UTC. * `0 2,14 * * *` :
        /// every 12 hours at (2, 14) hours past midnight in UTC. * `0 */4 * * *` : (incremental backups only) every 4
        /// hours at (0, 4, 8, 12, 16, 20) hours past midnight in UTC. * `0 2 * * *` : once a day at 2 past midnight in
        /// UTC. * `0 2 * * 0` : once a week every Sunday at 2 past midnight in UTC. * `0 2 8 * *` : once a month on 8th
        /// day at 2 past midnight in UTC.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>
        /// Output only. The time zone of the times in `CrontabSpec.text`. Currently, only UTC is supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual string TimeZone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Cloud Spanner database.</summary>
    public class Database : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. If exists, the time at which the database creation started.</summary>
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

        /// <summary>Output only. The dialect of the Cloud Spanner Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseDialect")]
        public virtual string DatabaseDialect { get; set; }

        /// <summary>
        /// Output only. The read-write region which contains the database's leader replicas. This is the same as the
        /// value of default_leader database option set using DatabaseAdmin.CreateDatabase or
        /// DatabaseAdmin.UpdateDatabaseDdl. If not explicitly set, this is empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultLeader")]
        public virtual string DefaultLeader { get; set; }

        private string _earliestVersionTimeRaw;

        private object _earliestVersionTime;

        /// <summary>
        /// Output only. Earliest timestamp at which older versions of the data can be read. This value is continuously
        /// updated by Cloud Spanner and becomes stale the moment it is queried. If you are using this value to recover
        /// data, make sure to account for the time from the moment when the value is queried to the moment when you
        /// initiate the recovery.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("earliestVersionTime")]
        public virtual string EarliestVersionTimeRaw
        {
            get => _earliestVersionTimeRaw;
            set
            {
                _earliestVersionTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _earliestVersionTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="EarliestVersionTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use EarliestVersionTimeDateTimeOffset instead.")]
        public virtual object EarliestVersionTime
        {
            get => _earliestVersionTime;
            set
            {
                _earliestVersionTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _earliestVersionTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="EarliestVersionTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? EarliestVersionTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(EarliestVersionTimeRaw);
            set => EarliestVersionTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Optional. Whether drop protection is enabled for this database. Defaults to false, if not set. For more
        /// details, please see how to [prevent accidental database
        /// deletion](https://cloud.google.com/spanner/docs/prevent-database-deletion).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableDropProtection")]
        public virtual System.Nullable<bool> EnableDropProtection { get; set; }

        /// <summary>
        /// Output only. For databases that are using customer managed encryption, this field contains the encryption
        /// configuration for the database. For databases that are using Google default or other types of encryption,
        /// this field is empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionConfig")]
        public virtual EncryptionConfig EncryptionConfig { get; set; }

        /// <summary>
        /// Output only. For databases that are using customer managed encryption, this field contains the encryption
        /// information for the database, such as all Cloud KMS key versions that are in use. The `encryption_status`
        /// field inside of each `EncryptionInfo` is not populated. For databases that are using Google default or other
        /// types of encryption, this field is empty. This field is propagated lazily from the backend. There might be a
        /// delay from when a key version is being used and when it appears in this field.
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
        /// Output only. Applicable only for databases that use dual-region instance configurations. Contains
        /// information about the quorum.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quorumInfo")]
        public virtual QuorumInfo QuorumInfo { get; set; }

        /// <summary>
        /// Output only. If true, the database is being updated. If false, there are no ongoing update operations for
        /// the database.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reconciling")]
        public virtual System.Nullable<bool> Reconciling { get; set; }

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

    /// <summary>The configuration for each database in the target instance configuration.</summary>
    public class DatabaseMoveConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The unique identifier of the database resource in the Instance. For example if the database uri is
        /// projects/foo/instances/bar/databases/baz, the id to supply here is baz.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseId")]
        public virtual string DatabaseId { get; set; }

        /// <summary>
        /// Optional. Encryption configuration to be used for the database in target configuration. Should be specified
        /// for every database which currently uses CMEK encryption. If a database currently uses GOOGLE_MANAGED
        /// encryption and a target encryption config is not specified, it defaults to GOOGLE_MANAGED. If a database
        /// currently uses Google-managed encryption and a target encryption config is specified, the request is
        /// rejected. If a database currently uses CMEK encryption, a target encryption config must be specified. You
        /// cannot move a CMEK database to a Google-managed encryption database by MoveInstance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionConfig")]
        public virtual InstanceEncryptionConfig EncryptionConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Cloud Spanner database role.</summary>
    public class DatabaseRole : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The name of the database role. Values are of the form
        /// `projects//instances//databases//databaseRoles/` where `` is as specified in the `CREATE ROLE` DDL
        /// statement.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Action information extracted from a DDL statement. This proto is used to display the brief info of the DDL
    /// statement for the operation UpdateDatabaseDdl.
    /// </summary>
    public class DdlStatementActionInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The action for the DDL statement, e.g. CREATE, ALTER, DROP, GRANT, etc. This field is a non-empty string.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual string Action { get; set; }

        /// <summary>
        /// The entity name(s) being operated on the DDL statement. E.g. 1. For statement "CREATE TABLE t1(...)",
        /// `entity_names` = ["t1"]. 2. For statement "GRANT ROLE r1, r2 ...", `entity_names` = ["r1", "r2"]. 3. For
        /// statement "ANALYZE", `entity_names` = [].
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityNames")]
        public virtual System.Collections.Generic.IList<string> EntityNames { get; set; }

        /// <summary>
        /// The entity type for the DDL statement, e.g. TABLE, INDEX, VIEW, etc. This field can be empty string for some
        /// DDL statement, e.g. for statement "ANALYZE", `entity_type` = "".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityType")]
        public virtual string EntityType { get; set; }

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
    /// The `DirectedReadOptions` can be used to indicate which replicas or regions should be used for non-transactional
    /// reads or queries. `DirectedReadOptions` can only be specified for a read-only transaction, otherwise the API
    /// returns an `INVALID_ARGUMENT` error.
    /// </summary>
    public class DirectedReadOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// `Exclude_replicas` indicates that specified replicas should be excluded from serving requests. Spanner
        /// doesn't route requests to the replicas in this list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludeReplicas")]
        public virtual ExcludeReplicas ExcludeReplicas { get; set; }

        /// <summary>
        /// `Include_replicas` indicates the order of replicas (as they appear in this list) to process the request. If
        /// `auto_failover_disabled` is set to `true` and all replicas are exhausted without finding a healthy replica,
        /// Spanner waits for a replica in the list to become available, requests might fail due to `DEADLINE_EXCEEDED`
        /// errors.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeReplicas")]
        public virtual IncludeReplicas IncludeReplicas { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message type for a dual-region quorum. Currently this type has no options.</summary>
    public class DualRegionQuorum : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>Encryption configuration for a Cloud Spanner database.</summary>
    public class EncryptionConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The Cloud KMS key to be used for encrypting and decrypting the database. Values are of the form
        /// `projects//locations//keyRings//cryptoKeys/`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeyName")]
        public virtual string KmsKeyName { get; set; }

        /// <summary>
        /// Specifies the KMS configuration for one or more keys used to encrypt the database. Values are of the form
        /// `projects//locations//keyRings//cryptoKeys/`. The keys referenced by `kms_key_names` must fully cover all
        /// regions of the database's instance configuration. Some examples: * For regional (single-region) instance
        /// configurations, specify a regional location KMS key. * For multi-region instance configurations of type
        /// `GOOGLE_MANAGED`, either specify a multi-region location KMS key or multiple regional location KMS keys that
        /// cover all regions in the instance configuration. * For an instance configuration of type `USER_MANAGED`,
        /// specify only regional location KMS keys to cover each region in the instance configuration. Multi-region
        /// location KMS keys aren't supported for `USER_MANAGED` type instance configurations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeyNames")]
        public virtual System.Collections.Generic.IList<string> KmsKeyNames { get; set; }

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

    /// <summary>
    /// An ExcludeReplicas contains a repeated set of ReplicaSelection that should be excluded from serving requests.
    /// </summary>
    public class ExcludeReplicas : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The directed read replica selector.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replicaSelections")]
        public virtual System.Collections.Generic.IList<ReplicaSelection> ReplicaSelections { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for ExecuteBatchDml.</summary>
    public class ExecuteBatchDmlRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. If set to `true`, this request marks the end of the transaction. After these statements execute,
        /// you must commit or abort the transaction. Attempts to execute any other requests against this transaction
        /// (including reads and queries) are rejected. Setting this option might cause some error reporting to be
        /// deferred until commit time (for example, validation of unique constraints). Given this, successful execution
        /// of statements shouldn't be assumed until a subsequent `Commit` call completes successfully.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastStatements")]
        public virtual System.Nullable<bool> LastStatements { get; set; }

        /// <summary>Common options for this request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestOptions")]
        public virtual RequestOptions RequestOptions { get; set; }

        /// <summary>
        /// Required. A per-transaction sequence number used to identify this request. This field makes each request
        /// idempotent such that if the request is received multiple times, at most one succeeds. The sequence number
        /// must be monotonically increasing within the transaction. If a request arrives for the first time with an
        /// out-of-order sequence number, the transaction might be aborted. Replays of previously handled requests yield
        /// the same response as the first execution.
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
        /// Optional. A precommit token is included if the read-write transaction is on a multiplexed session. Pass the
        /// precommit token with the highest sequence number from this transaction attempt should be passed to the
        /// Commit request for this transaction.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("precommitToken")]
        public virtual MultiplexedSessionPrecommitToken PrecommitToken { get; set; }

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
        /// If this is for a partitioned query and this field is set to `true`, the request is executed with Spanner
        /// Data Boost independent compute resources. If the field is set to `true` but the request doesn't set
        /// `partition_token`, the API returns an `INVALID_ARGUMENT` error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataBoostEnabled")]
        public virtual System.Nullable<bool> DataBoostEnabled { get; set; }

        /// <summary>Directed read options for this request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("directedReadOptions")]
        public virtual DirectedReadOptions DirectedReadOptions { get; set; }

        /// <summary>
        /// Optional. If set to `true`, this statement marks the end of the transaction. After this statement executes,
        /// you must commit or abort the transaction. Attempts to execute any other requests against this transaction
        /// (including reads and queries) are rejected. For DML statements, setting this option might cause some error
        /// reporting to be deferred until commit time (for example, validation of unique constraints). Given this,
        /// successful execution of a DML statement shouldn't be assumed until a subsequent `Commit` call completes
        /// successfully.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastStatement")]
        public virtual System.Nullable<bool> LastStatement { get; set; }

        /// <summary>
        /// It isn't always possible for Cloud Spanner to infer the right SQL type from a JSON value. For example,
        /// values of type `BYTES` and values of type `STRING` both appear in params as JSON strings. In these cases,
        /// you can use `param_types` to specify the exact SQL type for some or all of the SQL statement parameters. See
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
        /// @msg_id AND id &amp;lt; @msg_id + 100"` It's an error to execute a SQL statement with unbound parameters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("params")]
        public virtual System.Collections.Generic.IDictionary<string, object> Params__ { get; set; }

        /// <summary>
        /// If present, results are restricted to the specified partition previously created using `PartitionQuery`.
        /// There must be an exact match for the values of fields common to this message and the `PartitionQueryRequest`
        /// message used to create this `partition_token`.
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
        /// such that if the request is received multiple times, at most one succeeds. The sequence number must be
        /// monotonically increasing within the transaction. If a request arrives for the first time with an
        /// out-of-order sequence number, the transaction can be aborted. Replays of previously handled requests yield
        /// the same response as the first execution. Required for DML statements. Ignored for queries.
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

    /// <summary>
    /// Free instance specific metadata that is kept even after an instance has been upgraded for tracking purposes.
    /// </summary>
    public class FreeInstanceMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Specifies the expiration behavior of a free instance. The default of ExpireBehavior is
        /// `REMOVE_AFTER_GRACE_PERIOD`. This can be modified during or after creation, and before expiration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expireBehavior")]
        public virtual string ExpireBehavior { get; set; }

        private string _expireTimeRaw;

        private object _expireTime;

        /// <summary>
        /// Output only. Timestamp after which the instance will either be upgraded or scheduled for deletion after a
        /// grace period. ExpireBehavior is used to choose between upgrading or scheduling the free instance for
        /// deletion. This timestamp is set during the creation of a free instance.
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

        private string _upgradeTimeRaw;

        private object _upgradeTime;

        /// <summary>
        /// Output only. If present, the timestamp at which the free instance was upgraded to a provisioned instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("upgradeTime")]
        public virtual string UpgradeTimeRaw
        {
            get => _upgradeTimeRaw;
            set
            {
                _upgradeTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _upgradeTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="UpgradeTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use UpgradeTimeDateTimeOffset instead.")]
        public virtual object UpgradeTime
        {
            get => _upgradeTime;
            set
            {
                _upgradeTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _upgradeTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="UpgradeTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? UpgradeTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(UpgradeTimeRaw);
            set => UpgradeTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The specification for full backups. A full backup stores the entire contents of the database at a given version
    /// time.
    /// </summary>
    public class FullBackupSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for GetDatabaseDdl.</summary>
    public class GetDatabaseDdlResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Proto descriptors stored in the database. Contains a protobuf-serialized
        /// [google.protobuf.FileDescriptorSet](https://github.com/protocolbuffers/protobuf/blob/main/src/google/protobuf/descriptor.proto).
        /// For more details, see protobuffer [self
        /// description](https://developers.google.com/protocol-buffers/docs/techniques#self-description).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protoDescriptors")]
        public virtual string ProtoDescriptors { get; set; }

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
    /// An `IncludeReplicas` contains a repeated set of `ReplicaSelection` which indicates the order in which replicas
    /// should be considered.
    /// </summary>
    public class IncludeReplicas : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If `true`, Spanner doesn't route requests to a replica outside the &amp;lt;`include_replicas` list when all
        /// of the specified replicas are unavailable or unhealthy. Default value is `false`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoFailoverDisabled")]
        public virtual System.Nullable<bool> AutoFailoverDisabled { get; set; }

        /// <summary>The directed read replica selector.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replicaSelections")]
        public virtual System.Collections.Generic.IList<ReplicaSelection> ReplicaSelections { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The specification for incremental backup chains. An incremental backup stores the delta of changes between a
    /// previous backup and the database contents at a given version time. An incremental backup chain consists of a
    /// full backup and zero or more successive incremental backups. The first backup created for an incremental backup
    /// chain is always a full backup.
    /// </summary>
    public class IncrementalBackupSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Recommendation to add new indexes to run queries more efficiently.</summary>
    public class IndexAdvice : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. DDL statements to add new indexes that will improve the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ddl")]
        public virtual System.Collections.Generic.IList<string> Ddl { get; set; }

        /// <summary>
        /// Optional. Estimated latency improvement factor. For example if the query currently takes 500 ms to run and
        /// the estimated latency with new indexes is 100 ms this field will be 5.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("improvementFactor")]
        public virtual System.Nullable<double> ImprovementFactor { get; set; }

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
        /// Optional. The autoscaling configuration. Autoscaling is enabled if this field is set. When autoscaling is
        /// enabled, node_count and processing_units are treated as OUTPUT_ONLY fields and reflect the current compute
        /// capacity allocated to the instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoscalingConfig")]
        public virtual AutoscalingConfig AutoscalingConfig { get; set; }

        /// <summary>
        /// Required. The name of the instance's configuration. Values are of the form `projects//instanceConfigs/`. See
        /// also InstanceConfig and ListInstanceConfigs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual string Config { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time at which the instance was created.</summary>
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
        /// Optional. Controls the default backup schedule behavior for new databases within the instance. By default, a
        /// backup schedule is created automatically when a new database is created in a new instance. Note that the
        /// `AUTOMATIC` value isn't permitted for free instances, as backups and backup schedules aren't supported for
        /// free instances. In the `GetInstance` or `ListInstances` response, if the value of
        /// `default_backup_schedule_type` isn't set, or set to `NONE`, Spanner doesn't create a default backup schedule
        /// for new databases in the instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultBackupScheduleType")]
        public virtual string DefaultBackupScheduleType { get; set; }

        /// <summary>
        /// Required. The descriptive name for this instance as it appears in UIs. Must be unique per project and
        /// between 4 and 30 characters in length.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Optional. The `Edition` of the current instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("edition")]
        public virtual string Edition { get; set; }

        /// <summary>Deprecated. This field is not populated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpointUris")]
        public virtual System.Collections.Generic.IList<string> EndpointUris { get; set; }

        /// <summary>Free instance metadata. Only populated for free instances.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freeInstanceMetadata")]
        public virtual FreeInstanceMetadata FreeInstanceMetadata { get; set; }

        /// <summary>The `InstanceType` of the current instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceType")]
        public virtual string InstanceType { get; set; }

        /// <summary>
        /// Cloud Labels are a flexible and lightweight mechanism for organizing cloud resources into groups that
        /// reflect a customer's organizational needs and deployment strategies. Cloud Labels can be used to filter
        /// collections of resources. They can be used to control how resource metrics are aggregated. And they can be
        /// used as arguments to policy management rules (e.g. route, firewall, load balancing, etc.). * Label keys must
        /// be between 1 and 63 characters long and must conform to the following regular expression: `a-z{0,62}`. *
        /// Label values must be between 0 and 63 characters long and must conform to the regular expression
        /// `[a-z0-9_-]{0,63}`. * No more than 64 labels can be associated with a given resource. See
        /// https://goo.gl/xmQnxf for more information on and examples of labels. If you plan to use labels in your own
        /// code, please note that additional characters may be allowed in the future. And so you are advised to use an
        /// internal label representation, such as JSON, which doesn't rely upon specific characters being disallowed.
        /// For example, representing labels as the string: name + "_" + value would prove problematic if we were to
        /// allow "_" in a future release.
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
        /// The number of nodes allocated to this instance. At most, one of either `node_count` or `processing_units`
        /// should be present in the message. Users can set the `node_count` field to specify the target number of nodes
        /// allocated to the instance. If autoscaling is enabled, `node_count` is treated as an `OUTPUT_ONLY` field and
        /// reflects the current number of nodes allocated to the instance. This might be zero in API responses for
        /// instances that are not yet in the `READY` state. If the instance has varying node count across replicas
        /// (achieved by setting `asymmetric_autoscaling_options` in the autoscaling configuration), the `node_count`
        /// set here is the maximum node count across all replicas. For more information, see [Compute capacity, nodes,
        /// and processing units](https://cloud.google.com/spanner/docs/compute-capacity).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeCount")]
        public virtual System.Nullable<int> NodeCount { get; set; }

        /// <summary>
        /// The number of processing units allocated to this instance. At most, one of either `processing_units` or
        /// `node_count` should be present in the message. Users can set the `processing_units` field to specify the
        /// target number of processing units allocated to the instance. If autoscaling is enabled, `processing_units`
        /// is treated as an `OUTPUT_ONLY` field and reflects the current number of processing units allocated to the
        /// instance. This might be zero in API responses for instances that are not yet in the `READY` state. If the
        /// instance has varying processing units per replica (achieved by setting `asymmetric_autoscaling_options` in
        /// the autoscaling configuration), the `processing_units` set here is the maximum processing units across all
        /// replicas. For more information, see [Compute capacity, nodes and processing
        /// units](https://cloud.google.com/spanner/docs/compute-capacity).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processingUnits")]
        public virtual System.Nullable<int> ProcessingUnits { get; set; }

        /// <summary>
        /// Output only. Lists the compute capacity per ReplicaSelection. A replica selection identifies a set of
        /// replicas with common properties. Replicas identified by a ReplicaSelection are scaled with the same compute
        /// capacity.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replicaComputeCapacity")]
        public virtual System.Collections.Generic.IList<ReplicaComputeCapacity> ReplicaComputeCapacity { get; set; }

        /// <summary>
        /// Output only. The current instance state. For CreateInstance, the state must be either omitted or set to
        /// `CREATING`. For UpdateInstance, the state must be either omitted or set to `READY`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time at which the instance was most recently updated.</summary>
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
    /// A possible configuration for a Cloud Spanner instance. Configurations define the geographic placement of nodes
    /// and their replication.
    /// </summary>
    public class InstanceConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Base configuration name, e.g. projects//instanceConfigs/nam3, based on which this configuration is created.
        /// Only set for user-managed configurations. `base_config` must refer to a configuration of type
        /// `GOOGLE_MANAGED` in the same project as this configuration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseConfig")]
        public virtual string BaseConfig { get; set; }

        /// <summary>
        /// Output only. Whether this instance configuration is a Google-managed or user-managed configuration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configType")]
        public virtual string ConfigType { get; set; }

        /// <summary>The name of this instance configuration as it appears in UIs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// etag is used for optimistic concurrency control as a way to help prevent simultaneous updates of a instance
        /// configuration from overwriting each other. It is strongly suggested that systems make use of the etag in the
        /// read-modify-write cycle to perform instance configuration updates in order to avoid race conditions: An etag
        /// is returned in the response which contains instance configurations, and systems are expected to put that
        /// etag in the request to update instance configuration to ensure that their change is applied to the same
        /// version of the instance configuration. If no etag is provided in the call to update the instance
        /// configuration, then the existing instance configuration is overwritten blindly.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Output only. Describes whether free instances are available to be created in this instance configuration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freeInstanceAvailability")]
        public virtual string FreeInstanceAvailability { get; set; }

        /// <summary>
        /// Cloud Labels are a flexible and lightweight mechanism for organizing cloud resources into groups that
        /// reflect a customer's organizational needs and deployment strategies. Cloud Labels can be used to filter
        /// collections of resources. They can be used to control how resource metrics are aggregated. And they can be
        /// used as arguments to policy management rules (e.g. route, firewall, load balancing, etc.). * Label keys must
        /// be between 1 and 63 characters long and must conform to the following regular expression: `a-z{0,62}`. *
        /// Label values must be between 0 and 63 characters long and must conform to the regular expression
        /// `[a-z0-9_-]{0,63}`. * No more than 64 labels can be associated with a given resource. See
        /// https://goo.gl/xmQnxf for more information on and examples of labels. If you plan to use labels in your own
        /// code, please note that additional characters may be allowed in the future. Therefore, you are advised to use
        /// an internal label representation, such as JSON, which doesn't rely upon specific characters being
        /// disallowed. For example, representing labels as the string: name + "_" + value would prove problematic if we
        /// were to allow "_" in a future release.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Allowed values of the "default_leader" schema option for databases in instances that use this instance
        /// configuration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("leaderOptions")]
        public virtual System.Collections.Generic.IList<string> LeaderOptions { get; set; }

        /// <summary>
        /// A unique identifier for the instance configuration. Values are of the form `projects//instanceConfigs/a-z*`.
        /// User instance configuration must start with `custom-`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The available optional replicas to choose from for user-managed configurations. Populated for
        /// Google-managed configurations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("optionalReplicas")]
        public virtual System.Collections.Generic.IList<ReplicaInfo> OptionalReplicas { get; set; }

        /// <summary>Output only. The `QuorumType` of the instance configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quorumType")]
        public virtual string QuorumType { get; set; }

        /// <summary>
        /// Output only. If true, the instance configuration is being created or updated. If false, there are no ongoing
        /// operations for the instance configuration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reconciling")]
        public virtual System.Nullable<bool> Reconciling { get; set; }

        /// <summary>
        /// The geographic placement of nodes in this instance configuration and their replication properties. To create
        /// user-managed configurations, input `replicas` must include all replicas in `replicas` of the `base_config`
        /// and include one or more replicas in the `optional_replicas` of the `base_config`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replicas")]
        public virtual System.Collections.Generic.IList<ReplicaInfo> Replicas { get; set; }

        /// <summary>
        /// Output only. The current instance configuration state. Applicable only for `USER_MANAGED` configurations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. The storage limit in bytes per processing unit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageLimitPerProcessingUnit")]
        public virtual System.Nullable<long> StorageLimitPerProcessingUnit { get; set; }
    }

    /// <summary>Encryption configuration for a Cloud Spanner database.</summary>
    public class InstanceEncryptionConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. This field is maintained for backwards compatibility. For new callers, we recommend using
        /// `kms_key_names` to specify the KMS key. `kms_key_name` should only be used if the location of the KMS key
        /// matches the database instance’s configuration (location) exactly. E.g. The KMS location is in us-central1 or
        /// nam3 and the database instance is also in us-central1 or nam3. The Cloud KMS key to be used for encrypting
        /// and decrypting the database. Values are of the form `projects//locations//keyRings//cryptoKeys/`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeyName")]
        public virtual string KmsKeyName { get; set; }

        /// <summary>
        /// Optional. Specifies the KMS configuration for one or more keys used to encrypt the database. Values are of
        /// the form `projects//locations//keyRings//cryptoKeys/`. The keys referenced by `kms_key_names` must fully
        /// cover all regions of the database's instance configuration. Some examples: * For regional (single-region)
        /// instance configurations, specify a regional location KMS key. * For multi-region instance configurations of
        /// type `GOOGLE_MANAGED`, either specify a multi-region location KMS key or multiple regional location KMS keys
        /// that cover all regions in the instance configuration. * For an instance configuration of type
        /// `USER_MANAGED`, specify only regional location KMS keys to cover each region in the instance configuration.
        /// Multi-region location KMS keys aren't supported for `USER_MANAGED` type instance configurations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeyNames")]
        public virtual System.Collections.Generic.IList<string> KmsKeyNames { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Encapsulates progress related information for a Cloud Spanner long running instance operations.
    /// </summary>
    public class InstanceOperationProgress : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _endTimeRaw;

        private object _endTime;

        /// <summary>If set, the time at which this operation failed or was completed successfully.</summary>
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

        /// <summary>Percent completion of the operation. Values are between 0 and 100 inclusive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressPercent")]
        public virtual System.Nullable<int> ProgressPercent { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>Time the request was received.</summary>
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

    /// <summary>An isolated set of Cloud Spanner resources that databases can define placements on.</summary>
    public class InstancePartition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The name of the instance partition's configuration. Values are of the form
        /// `projects//instanceConfigs/`. See also InstanceConfig and ListInstanceConfigs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual string Config { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time at which the instance partition was created.</summary>
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
        /// Required. The descriptive name for this instance partition as it appears in UIs. Must be unique per project
        /// and between 4 and 30 characters in length.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Used for optimistic concurrency control as a way to help prevent simultaneous updates of a instance
        /// partition from overwriting each other. It is strongly suggested that systems make use of the etag in the
        /// read-modify-write cycle to perform instance partition updates in order to avoid race conditions: An etag is
        /// returned in the response which contains instance partitions, and systems are expected to put that etag in
        /// the request to update instance partitions to ensure that their change will be applied to the same version of
        /// the instance partition. If no etag is provided in the call to update instance partition, then the existing
        /// instance partition is overwritten blindly.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Required. A unique identifier for the instance partition. Values are of the form
        /// `projects//instances//instancePartitions/a-z*[a-z0-9]`. The final segment of the name must be between 2 and
        /// 64 characters in length. An instance partition's name cannot be changed after the instance partition is
        /// created.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The number of nodes allocated to this instance partition. Users can set the `node_count` field to specify
        /// the target number of nodes allocated to the instance partition. This may be zero in API responses for
        /// instance partitions that are not yet in state `READY`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeCount")]
        public virtual System.Nullable<int> NodeCount { get; set; }

        /// <summary>
        /// The number of processing units allocated to this instance partition. Users can set the `processing_units`
        /// field to specify the target number of processing units allocated to the instance partition. This might be
        /// zero in API responses for instance partitions that are not yet in the `READY` state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processingUnits")]
        public virtual System.Nullable<int> ProcessingUnits { get; set; }

        /// <summary>
        /// Output only. Deprecated: This field is not populated. Output only. The names of the backups that reference
        /// this instance partition. Referencing backups should share the parent instance. The existence of any
        /// referencing backup prevents the instance partition from being deleted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referencingBackups")]
        public virtual System.Collections.Generic.IList<string> ReferencingBackups { get; set; }

        /// <summary>
        /// Output only. The names of the databases that reference this instance partition. Referencing databases should
        /// share the parent instance. The existence of any referencing database prevents the instance partition from
        /// being deleted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referencingDatabases")]
        public virtual System.Collections.Generic.IList<string> ReferencingDatabases { get; set; }

        /// <summary>Output only. The current instance partition state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time at which the instance partition was most recently updated.</summary>
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
    }

    /// <summary>ReplicaSelection identifies replicas with common properties.</summary>
    public class InstanceReplicaSelection : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Name of the location of the replicas (e.g., "us-central1").</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A split key.</summary>
    public class Key : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The column values making up the split key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyParts")]
        public virtual System.Collections.Generic.IList<object> KeyParts { get; set; }

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
        /// name. The operation's metadata field type `metadata.type_url` describes the type of the metadata. Operations
        /// returned include those that are pending or have completed/failed/canceled within the last 7 days. Operations
        /// returned are ordered by `operation.metadata.value.progress.start_time` in descending order starting from the
        /// most recently started operation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operations")]
        public virtual System.Collections.Generic.IList<Operation> Operations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for ListBackupSchedules.</summary>
    public class ListBackupSchedulesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of backup schedules for a database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupSchedules")]
        public virtual System.Collections.Generic.IList<BackupSchedule> BackupSchedules { get; set; }

        /// <summary>
        /// `next_page_token` can be sent in a subsequent ListBackupSchedules call to fetch more of the schedules.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

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

    /// <summary>The response for ListDatabaseRoles.</summary>
    public class ListDatabaseRolesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Database roles that matched the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseRoles")]
        public virtual System.Collections.Generic.IList<DatabaseRole> DatabaseRoles { get; set; }

        /// <summary>
        /// `next_page_token` can be sent in a subsequent ListDatabaseRoles call to fetch more of the matching roles.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

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

    /// <summary>The response for ListInstanceConfigOperations.</summary>
    public class ListInstanceConfigOperationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// `next_page_token` can be sent in a subsequent ListInstanceConfigOperations call to fetch more of the
        /// matching metadata.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// The list of matching instance configuration long-running operations. Each operation's name will be prefixed
        /// by the name of the instance configuration. The operation's metadata field type `metadata.type_url` describes
        /// the type of the metadata.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operations")]
        public virtual System.Collections.Generic.IList<Operation> Operations { get; set; }

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

    /// <summary>The response for ListInstancePartitionOperations.</summary>
    public class ListInstancePartitionOperationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// `next_page_token` can be sent in a subsequent ListInstancePartitionOperations call to fetch more of the
        /// matching metadata.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// The list of matching instance partition long-running operations. Each operation's name will be prefixed by
        /// the instance partition's name. The operation's metadata field type `metadata.type_url` describes the type of
        /// the metadata.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operations")]
        public virtual System.Collections.Generic.IList<Operation> Operations { get; set; }

        /// <summary>
        /// The list of unreachable instance partitions. It includes the names of instance partitions whose operation
        /// metadata could not be retrieved within instance_partition_deadline.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachableInstancePartitions")]
        public virtual System.Collections.Generic.IList<string> UnreachableInstancePartitions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for ListInstancePartitions.</summary>
    public class ListInstancePartitionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of requested instancePartitions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instancePartitions")]
        public virtual System.Collections.Generic.IList<InstancePartition> InstancePartitions { get; set; }

        /// <summary>
        /// `next_page_token` can be sent in a subsequent ListInstancePartitions call to fetch more of the matching
        /// instance partitions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// The list of unreachable instances or instance partitions. It includes the names of instances or instance
        /// partitions whose metadata could not be retrieved within instance_partition_deadline.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

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

    /// <summary>The request for MoveInstance.</summary>
    public class MoveInstanceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The target instance configuration where to move the instance. Values are of the form
        /// `projects//instanceConfigs/`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetConfig")]
        public virtual string TargetConfig { get; set; }

        /// <summary>Optional. The configuration for each database in the target instance configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetDatabaseMoveConfigs")]
        public virtual System.Collections.Generic.IList<DatabaseMoveConfig> TargetDatabaseMoveConfigs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// When a read-write transaction is executed on a multiplexed session, this precommit token is sent back to the
    /// client as a part of the Transaction message in the BeginTransaction response and also as a part of the ResultSet
    /// and PartialResultSet responses.
    /// </summary>
    public class MultiplexedSessionPrecommitToken : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Opaque precommit token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("precommitToken")]
        public virtual string PrecommitToken { get; set; }

        /// <summary>
        /// An incrementing seq number is generated on every precommit token that is returned. Clients should remember
        /// the precommit token with the highest sequence number from the current transaction attempt.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seqNum")]
        public virtual System.Nullable<int> SeqNum { get; set; }

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

    /// <summary>
    /// A group of mutations to be committed together. Related mutations should be placed in a group. For example, two
    /// mutations inserting rows with the same primary key prefix in both parent and child tables are related.
    /// </summary>
    public class MutationGroup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The mutations in this group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mutations")]
        public virtual System.Collections.Generic.IList<Mutation> Mutations { get; set; }

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

    /// <summary>Encapsulates progress related information for a Cloud Spanner long running operation.</summary>
    public class OperationProgress : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _endTimeRaw;

        private object _endTime;

        /// <summary>If set, the time at which this operation failed or was completed successfully.</summary>
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

        /// <summary>Percent completion of the operation. Values are between 0 and 100 inclusive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressPercent")]
        public virtual System.Nullable<int> ProgressPercent { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>Time the request was received.</summary>
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
        /// Optional. Indicates whether this is the last `PartialResultSet` in the stream. The server might optionally
        /// set this field. Clients shouldn't rely on this field being set in all cases.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("last")]
        public virtual System.Nullable<bool> Last { get; set; }

        /// <summary>
        /// Metadata about the result set, such as row type information. Only present in the first response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual ResultSetMetadata Metadata { get; set; }

        /// <summary>
        /// Optional. A precommit token is included if the read-write transaction has multiplexed sessions enabled. Pass
        /// the precommit token with the highest sequence number from this transaction attempt to the Commit request for
        /// this transaction.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("precommitToken")]
        public virtual MultiplexedSessionPrecommitToken PrecommitToken { get; set; }

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
        /// stream. This field is also present in the last response for DML statements.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stats")]
        public virtual ResultSetStats Stats { get; set; }

        /// <summary>
        /// A streamed result set consists of a stream of values, which might be split into many `PartialResultSet`
        /// messages to accommodate large rows and/or large values. Every N complete values defines a row, where N is
        /// equal to the number of entries in metadata.row_type.fields. Most values are encoded based on type as
        /// described here. It's possible that the last value in values is "chunked", meaning that the rest of the value
        /// is sent in subsequent `PartialResultSet`(s). This is denoted by the chunked_value field. Two or more chunked
        /// values can be merged to form a complete value as follows: * `bool/number/null`: can't be chunked * `string`:
        /// concatenate the strings * `list`: concatenate the lists. If the last element in a list is a `string`,
        /// `list`, or `object`, merge it with the first element in the next list by applying these rules recursively. *
        /// `object`: concatenate the (field name, field value) pairs. If a field name is duplicated, then apply these
        /// rules recursively to merge the field values. Some examples of merging: Strings are concatenated. "foo",
        /// "bar" =&amp;gt; "foobar" Lists of non-strings are concatenated. [2, 3], [4] =&amp;gt; [2, 3, 4] Lists are
        /// concatenated, but the last and first elements are merged because they are strings. ["a", "b"], ["c", "d"]
        /// =&amp;gt; ["a", "bc", "d"] Lists are concatenated, but the last and first elements are merged because they
        /// are lists. Recursively, the last and first elements of the inner lists are merged because they are strings.
        /// ["a", ["b", "c"]], [["d"], "e"] =&amp;gt; ["a", ["b", "cd"], "e"] Non-overlapping object fields are
        /// combined. {"a": "1"}, {"b": "2"} =&amp;gt; {"a": "1", "b": 2"} Overlapping object fields are merged. {"a":
        /// "1"}, {"a": "2"} =&amp;gt; {"a": "12"} Examples of merging objects containing lists of strings. {"a":
        /// ["1"]}, {"a": ["2"]} =&amp;gt; {"a": ["12"]} For a more complete example, suppose a streaming SQL query is
        /// yielding a result set whose rows contain a single string field. The following `PartialResultSet`s might be
        /// yielded: { "metadata": { ... } "values": ["Hello", "W"] "chunked_value": true "resume_token": "Af65..." } {
        /// "values": ["orl"] "chunked_value": true } { "values": ["d"] "resume_token": "Zx1B..." } This sequence of
        /// `PartialResultSet`s encodes two rows, one containing the field value `"Hello"`, and a second containing the
        /// field value `"World" = "W" + "orl" + "d"`. Not all `PartialResultSet`s contain a `resume_token`. Execution
        /// can only be resumed from a previously yielded `resume_token`. For the above sequence of `PartialResultSet`s,
        /// resuming the query with `"resume_token": "Af65..."` yields results from the `PartialResultSet` with value
        /// "orl".
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
        /// This token can be passed to `Read`, `StreamingRead`, `ExecuteSql`, or `ExecuteStreamingSql` requests to
        /// restrict the results to those identified by this partition token.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partitionToken")]
        public virtual string PartitionToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Options for a `PartitionQueryRequest` and `PartitionReadRequest`.</summary>
    public class PartitionOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// **Note:** This hint is currently ignored by `PartitionQuery` and `PartitionRead` requests. The desired
        /// maximum number of partitions to return. For example, this might be set to the number of workers available.
        /// The default for this option is currently 10,000. The maximum value is currently 200,000. This is only a
        /// hint. The actual number of partitions returned can be smaller or larger than this maximum count request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxPartitions")]
        public virtual System.Nullable<long> MaxPartitions { get; set; }

        /// <summary>
        /// **Note:** This hint is currently ignored by `PartitionQuery` and `PartitionRead` requests. The desired data
        /// size for each partition generated. The default for this option is currently 1 GiB. This is only a hint. The
        /// actual size of each partition can be smaller or larger than this size request.
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
        /// It isn't always possible for Cloud Spanner to infer the right SQL type from a JSON value. For example,
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
        /// + 100"` It's an error to execute a SQL statement with unbound parameters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("params")]
        public virtual System.Collections.Generic.IDictionary<string, object> Params__ { get; set; }

        /// <summary>Additional options that affect how many partitions are created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partitionOptions")]
        public virtual PartitionOptions PartitionOptions { get; set; }

        /// <summary>
        /// Required. The query request to generate partitions for. The request fails if the query isn't root
        /// partitionable. For a query to be root partitionable, it needs to satisfy a few conditions. For example, if
        /// the query execution plan contains a distributed union operator, then it must be the first operator in the
        /// plan. For more information about other conditions, see [Read data in
        /// parallel](https://cloud.google.com/spanner/docs/reads#read_data_in_parallel). The query request must not
        /// contain DML commands, such as `INSERT`, `UPDATE`, or `DELETE`. Use `ExecuteStreamingSql` with a
        /// `PartitionedDml` transaction for large, partition-friendly DML operations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sql")]
        public virtual string Sql { get; set; }

        /// <summary>
        /// Read-only snapshot transactions are supported, read and write and single-use transactions are not.
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
        /// It isn't an error for the `key_set` to name rows that don't exist in the database. Read yields nothing for
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

    /// <summary>Output of query advisor analysis.</summary>
    public class QueryAdvisorResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Index Recommendation for a query. This is an optional field and the recommendation will only be
        /// available when the recommendation guarantees significant improvement in query performance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indexAdvice")]
        public virtual System.Collections.Generic.IList<IndexAdvice> IndexAdvice { get; set; }

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
        /// package set at the database level options, or the latest package if the database option isn't set. The
        /// statistics package requested by the query has to be exempt from garbage collection. This can be achieved
        /// with the following DDL statement:
        /// ```
        /// sql ALTER STATISTICS SET OPTIONS (allow_gc=false)
        /// ```
        /// The list of
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
        /// from `SPANNER_SYS.SUPPORTED_OPTIMIZER_VERSIONS`. Executing a SQL statement with an invalid optimizer version
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

        /// <summary>
        /// Optional. The advise/recommendations for a query. Currently this field will be serving index recommendations
        /// for a query.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryAdvice")]
        public virtual QueryAdvisorResult QueryAdvice { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about the dual-region quorum.</summary>
    public class QuorumInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The etag is used for optimistic concurrency control as a way to help prevent simultaneous
        /// `ChangeQuorum` requests that might create a race condition.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Output only. Whether this `ChangeQuorum` is Google or User initiated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("initiator")]
        public virtual string Initiator { get; set; }

        /// <summary>
        /// Output only. The type of this quorum. See QuorumType for more information about quorum type specifications.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quorumType")]
        public virtual QuorumType QuorumType { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>Output only. The timestamp when the request was triggered.</summary>
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
    }

    /// <summary>
    /// Information about the database quorum type. This only applies to dual-region instance configs.
    /// </summary>
    public class QuorumType : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Dual-region quorum type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dualRegion")]
        public virtual DualRegionQuorum DualRegion { get; set; }

        /// <summary>Single-region quorum type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("singleRegion")]
        public virtual SingleRegionQuorum SingleRegion { get; set; }

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

        private string _minReadTimestampRaw;

        private object _minReadTimestamp;

        /// <summary>
        /// Executes all reads at a timestamp &amp;gt;= `min_read_timestamp`. This is useful for requesting fresher data
        /// than some previous read, or data that is fresh enough to observe the effects of some previously committed
        /// transaction whose timestamp is known. Note that this option can only be used in single-use transactions. A
        /// timestamp in RFC3339 UTC \"Zulu\" format, accurate to nanoseconds. Example:
        /// `"2014-10-02T15:01:23.045123456Z"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minReadTimestamp")]
        public virtual string MinReadTimestampRaw
        {
            get => _minReadTimestampRaw;
            set
            {
                _minReadTimestamp = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _minReadTimestampRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="MinReadTimestampRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use MinReadTimestampDateTimeOffset instead.")]
        public virtual object MinReadTimestamp
        {
            get => _minReadTimestamp;
            set
            {
                _minReadTimestampRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _minReadTimestamp = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="MinReadTimestampRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? MinReadTimestampDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(MinReadTimestampRaw);
            set => MinReadTimestampRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _readTimestampRaw;

        private object _readTimestamp;

        /// <summary>
        /// Executes all reads at the given timestamp. Unlike other modes, reads at a specific timestamp are repeatable;
        /// the same read at the same timestamp always returns the same data. If the timestamp is in the future, the
        /// read is blocked until the specified timestamp, modulo the read's deadline. Useful for large scale consistent
        /// reads such as mapreduces, or for coordinating many reads against a consistent snapshot of the data. A
        /// timestamp in RFC3339 UTC \"Zulu\" format, accurate to nanoseconds. Example:
        /// `"2014-10-02T15:01:23.045123456Z"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readTimestamp")]
        public virtual string ReadTimestampRaw
        {
            get => _readTimestampRaw;
            set
            {
                _readTimestamp = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _readTimestampRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ReadTimestampRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ReadTimestampDateTimeOffset instead.")]
        public virtual object ReadTimestamp
        {
            get => _readTimestamp;
            set
            {
                _readTimestampRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _readTimestamp = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ReadTimestampRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ReadTimestampDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ReadTimestampRaw);
            set => ReadTimestampRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

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
        /// If this is for a partitioned read and this field is set to `true`, the request is executed with Spanner Data
        /// Boost independent compute resources. If the field is set to `true` but the request doesn't set
        /// `partition_token`, the API returns an `INVALID_ARGUMENT` error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataBoostEnabled")]
        public virtual System.Nullable<bool> DataBoostEnabled { get; set; }

        /// <summary>Directed read options for this request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("directedReadOptions")]
        public virtual DirectedReadOptions DirectedReadOptions { get; set; }

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
        /// index key order (if index is non-empty). If the partition_token field isn't empty, rows are yielded in an
        /// unspecified order. It isn't an error for the `key_set` to name rows that don't exist in the database. Read
        /// yields nothing for nonexistent rows.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keySet")]
        public virtual KeySet KeySet { get; set; }

        /// <summary>
        /// If greater than zero, only the first `limit` rows are yielded. If `limit` is zero, the default is no limit.
        /// A limit can't be specified if `partition_token` is set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("limit")]
        public virtual System.Nullable<long> Limit { get; set; }

        /// <summary>Optional. Lock Hint for the request, it can only be used with read-write transactions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lockHint")]
        public virtual string LockHint { get; set; }

        /// <summary>
        /// Optional. Order for the returned rows. By default, Spanner returns result rows in primary key order except
        /// for PartitionRead requests. For applications that don't require rows to be returned in primary key
        /// (`ORDER_BY_PRIMARY_KEY`) order, setting `ORDER_BY_NO_ORDER` option allows Spanner to optimize row retrieval,
        /// resulting in lower latencies in certain cases (for example, bulk point lookups).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orderBy")]
        public virtual string OrderBy { get; set; }

        /// <summary>
        /// If present, results are restricted to the specified partition previously created using `PartitionRead`.
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
        /// <summary>
        /// Optional. Clients should pass the transaction ID of the previous transaction attempt that was aborted if
        /// this transaction is being executed on a multiplexed session.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("multiplexedSessionPreviousTransactionId")]
        public virtual string MultiplexedSessionPreviousTransactionId { get; set; }

        /// <summary>Read lock mode for the transaction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readLockMode")]
        public virtual string ReadLockMode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// ReplicaComputeCapacity describes the amount of server resources that are allocated to each replica identified by
    /// the replica selection.
    /// </summary>
    public class ReplicaComputeCapacity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The number of nodes allocated to each replica. This may be zero in API responses for instances that are not
        /// yet in state `READY`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeCount")]
        public virtual System.Nullable<int> NodeCount { get; set; }

        /// <summary>
        /// The number of processing units allocated to each replica. This may be zero in API responses for instances
        /// that are not yet in state `READY`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processingUnits")]
        public virtual System.Nullable<int> ProcessingUnits { get; set; }

        /// <summary>
        /// Required. Identifies replicas by specified properties. All replicas in the selection have the same amount of
        /// compute capacity.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replicaSelection")]
        public virtual InstanceReplicaSelection ReplicaSelection { get; set; }

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

        /// <summary>The location of the serving resources, e.g., "us-central1".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>The type of replica.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The directed read replica selector. Callers must provide one or more of the following fields for replica
    /// selection: * `location` - The location must be one of the regions within the multi-region configuration of your
    /// database. * `type` - The type of the replica. Some examples of using replica_selectors are: *
    /// `location:us-east1` --&amp;gt; The "us-east1" replica(s) of any available type is used to process the request. *
    /// `type:READ_ONLY` --&amp;gt; The "READ_ONLY" type replica(s) in the nearest available location are used to
    /// process the request. * `location:us-east1 type:READ_ONLY` --&amp;gt; The "READ_ONLY" type replica(s) in location
    /// "us-east1" is used to process the request.
    /// </summary>
    public class ReplicaSelection : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The location or region of the serving requests, for example, "us-east1".</summary>
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
        /// A per-request tag which can be applied to queries or reads, used for statistics collection. Both
        /// `request_tag` and `transaction_tag` can be specified for a read or query that belongs to a transaction. This
        /// field is ignored for requests where it's not applicable (for example, `CommitRequest`). Legal characters for
        /// `request_tag` values are all printable characters (ASCII 32 - 126) and the length of a request_tag is
        /// limited to 50 characters. Values that exceed this limit are truncated. Any leading underscore (_) characters
        /// are removed from the string.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestTag")]
        public virtual string RequestTag { get; set; }

        /// <summary>
        /// A tag used for statistics collection about this transaction. Both `request_tag` and `transaction_tag` can be
        /// specified for a read or query that belongs to a transaction. The value of transaction_tag should be the same
        /// for all requests belonging to the same transaction. If this request doesn't belong to any transaction,
        /// `transaction_tag` is ignored. Legal characters for `transaction_tag` values are all printable characters
        /// (ASCII 32 - 126) and the length of a `transaction_tag` is limited to 50 characters. Values that exceed this
        /// limit are truncated. Any leading underscore (_) characters are removed from the string.
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

        /// <summary>
        /// Optional. Specifies the KMS configuration for one or more keys used to encrypt the database. Values have the
        /// form `projects//locations//keyRings//cryptoKeys/`. The keys referenced by `kms_key_names` must fully cover
        /// all regions of the database's instance configuration. Some examples: * For regional (single-region) instance
        /// configurations, specify a regional location KMS key. * For multi-region instance configurations of type
        /// `GOOGLE_MANAGED`, either specify a multi-region location KMS key or multiple regional location KMS keys that
        /// cover all regions in the instance configuration. * For an instance configuration of type `USER_MANAGED`,
        /// specify only regional location KMS keys to cover each region in the instance configuration. Multi-region
        /// location KMS keys aren't supported for `USER_MANAGED` type instance configurations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeyNames")]
        public virtual System.Collections.Generic.IList<string> KmsKeyNames { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata type for the long-running operation returned by RestoreDatabase.</summary>
    public class RestoreDatabaseMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Information about the backup used to restore the database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupInfo")]
        public virtual BackupInfo BackupInfo { get; set; }

        private string _cancelTimeRaw;

        private object _cancelTime;

        /// <summary>
        /// The time at which cancellation of this operation was received. Operations.CancelOperation starts
        /// asynchronous cancellation on a long-running operation. The server makes a best effort to cancel the
        /// operation, but success is not guaranteed. Clients can use Operations.GetOperation or other methods to check
        /// whether the cancellation succeeded or whether the operation completed despite cancellation. On successful
        /// cancellation, the operation is not deleted; instead, it becomes an operation with an Operation.error value
        /// with a google.rpc.Status.code of 1, corresponding to `Code.CANCELLED`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cancelTime")]
        public virtual string CancelTimeRaw
        {
            get => _cancelTimeRaw;
            set
            {
                _cancelTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _cancelTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CancelTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CancelTimeDateTimeOffset instead.")]
        public virtual object CancelTime
        {
            get => _cancelTime;
            set
            {
                _cancelTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _cancelTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CancelTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CancelTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CancelTimeRaw);
            set => CancelTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

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
        /// Optional. A precommit token is included if the read-write transaction is on a multiplexed session. Pass the
        /// precommit token with the highest sequence number from this transaction attempt to the Commit request for
        /// this transaction.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("precommitToken")]
        public virtual MultiplexedSessionPrecommitToken PrecommitToken { get; set; }

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
        /// Other fields might or might not be populated, based on the ExecuteSqlRequest.query_mode.
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

        /// <summary>
        /// A SQL query can be parameterized. In PLAN mode, these parameters can be undeclared. This indicates the field
        /// names and types for those undeclared parameters in the SQL query. For example, a SQL query like `"SELECT *
        /// FROM Users where UserId = @userId and UserName = @userName "` could return a `undeclared_parameters` value
        /// like: "fields": [ { "name": "UserId", "type": { "code": "INT64" } }, { "name": "UserName", "type": { "code":
        /// "STRING" } }, ]
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("undeclaredParameters")]
        public virtual StructType UndeclaredParameters { get; set; }

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
        /// Partitioned DML doesn't offer exactly-once semantics, so it returns a lower bound of the rows modified.
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

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>The upper bound for when the scan is defined.</summary>
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
        /// The unique name of the scan, specific to the Database service implementing this interface.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. Cloud Key Visualizer scan data. Note, this field is not available to the ListScans method.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scanData")]
        public virtual ScanData ScanData { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>
        /// A range of time (inclusive) for when the scan is defined. The lower bound for when the scan is defined.
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

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>The upper bound for when the contained data is defined.</summary>
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
        /// A range of time (inclusive) for when the contained data is defined. The lower bound for when the contained
        /// data is defined.
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

    /// <summary>A session in the Cloud Spanner API.</summary>
    public class Session : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _approximateLastUseTimeRaw;

        private object _approximateLastUseTime;

        /// <summary>
        /// Output only. The approximate timestamp when the session is last used. It's typically earlier than the actual
        /// last use time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("approximateLastUseTime")]
        public virtual string ApproximateLastUseTimeRaw
        {
            get => _approximateLastUseTimeRaw;
            set
            {
                _approximateLastUseTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _approximateLastUseTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ApproximateLastUseTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ApproximateLastUseTimeDateTimeOffset instead.")]
        public virtual object ApproximateLastUseTime
        {
            get => _approximateLastUseTime;
            set
            {
                _approximateLastUseTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _approximateLastUseTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="ApproximateLastUseTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ApproximateLastUseTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ApproximateLastUseTimeRaw);
            set => ApproximateLastUseTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The timestamp when the session is created.</summary>
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

        /// <summary>The database role which created this session.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creatorRole")]
        public virtual string CreatorRole { get; set; }

        /// <summary>
        /// The labels for the session. * Label keys must be between 1 and 63 characters long and must conform to the
        /// following regular expression: `[a-z]([-a-z0-9]*[a-z0-9])?`. * Label values must be between 0 and 63
        /// characters long and must conform to the regular expression `([a-z]([-a-z0-9]*[a-z0-9])?)?`. * No more than
        /// 64 labels can be associated with a given session. See https://goo.gl/xmQnxf for more information on and
        /// examples of labels.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Optional. If `true`, specifies a multiplexed session. Use a multiplexed session for multiple, concurrent
        /// read-only operations. Don't use them for read-write transactions, partitioned reads, or partitioned queries.
        /// Use `sessions.create` to create multiplexed sessions. Don't use BatchCreateSessions to create a multiplexed
        /// session. You can't delete or list multiplexed sessions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("multiplexed")]
        public virtual System.Nullable<bool> Multiplexed { get; set; }

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
        /// 10s of KB. An empty policy is a valid policy but certain Google Cloud services (such as Projects) might
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

    /// <summary>Message type for a single-region quorum.</summary>
    public class SingleRegionQuorum : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The location of the serving region, e.g. "us-central1". The location must be one of the regions
        /// within the dual-region instance configuration of your database. The list of valid locations is available
        /// using the GetInstanceConfig API. This should only be used if you plan to change quorum to the single-region
        /// quorum type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servingLocation")]
        public virtual string ServingLocation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The split points of a table or an index.</summary>
    public class SplitPoints : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _expireTimeRaw;

        private object _expireTime;

        /// <summary>
        /// Optional. The expiration timestamp of the split points. A timestamp in the past means immediate expiration.
        /// The maximum value can be 30 days in the future. Defaults to 10 days in the future if not specified.
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

        /// <summary>The index to split. If specified, the `table` field must refer to the index's base table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("index")]
        public virtual string Index { get; set; }

        /// <summary>Required. The list of split keys. In essence, the split boundaries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keys")]
        public virtual System.Collections.Generic.IList<Key> Keys { get; set; }

        /// <summary>The table to split.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("table")]
        public virtual string Table { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single DML statement.</summary>
    public class Statement : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// It isn't always possible for Cloud Spanner to infer the right SQL type from a JSON value. For example,
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
        /// + 100"` It's an error to execute a SQL statement with unbound parameters.
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
        /// A precommit token is included in the response of a BeginTransaction request if the read-write transaction is
        /// on a multiplexed session and a mutation_key was specified in the BeginTransaction. The precommit token with
        /// the highest sequence number from this transaction attempt should be passed to the Commit request for this
        /// transaction.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("precommitToken")]
        public virtual MultiplexedSessionPrecommitToken PrecommitToken { get; set; }

        private string _readTimestampRaw;

        private object _readTimestamp;

        /// <summary>
        /// For snapshot read-only transactions, the read timestamp chosen for the transaction. Not returned by default:
        /// see TransactionOptions.ReadOnly.return_read_timestamp. A timestamp in RFC3339 UTC \"Zulu\" format, accurate
        /// to nanoseconds. Example: `"2014-10-02T15:01:23.045123456Z"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readTimestamp")]
        public virtual string ReadTimestampRaw
        {
            get => _readTimestampRaw;
            set
            {
                _readTimestamp = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _readTimestampRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ReadTimestampRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ReadTimestampDateTimeOffset instead.")]
        public virtual object ReadTimestamp
        {
            get => _readTimestamp;
            set
            {
                _readTimestampRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _readTimestamp = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ReadTimestampRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ReadTimestampDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ReadTimestampRaw);
            set => ReadTimestampRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Transactions: Each session can have at most one active transaction at a time (note that standalone reads and
    /// queries use a transaction internally and do count towards the one transaction limit). After the active
    /// transaction is completed, the session can immediately be re-used for the next transaction. It is not necessary
    /// to create a new session for each transaction. Transaction modes: Cloud Spanner supports three transaction modes:
    /// 1. Locking read-write. This type of transaction is the only way to write data into Cloud Spanner. These
    /// transactions rely on pessimistic locking and, if necessary, two-phase commit. Locking read-write transactions
    /// may abort, requiring the application to retry. 2. Snapshot read-only. Snapshot read-only transactions provide
    /// guaranteed consistency across several reads, but do not allow writes. Snapshot read-only transactions can be
    /// configured to read at timestamps in the past, or configured to perform a strong read (where Spanner selects a
    /// timestamp such that the read is guaranteed to see the effects of all transactions that have committed before the
    /// start of the read). Snapshot read-only transactions do not need to be committed. Queries on change streams must
    /// be performed with the snapshot read-only transaction mode, specifying a strong read. See
    /// TransactionOptions.ReadOnly.strong for more details. 3. Partitioned DML. This type of transaction is used to
    /// execute a single Partitioned DML statement. Partitioned DML partitions the key space and runs the DML statement
    /// over each partition in parallel using separate, internal transactions that commit independently. Partitioned DML
    /// transactions do not need to be committed. For transactions that only read, snapshot read-only transactions
    /// provide simpler semantics and are almost always faster. In particular, read-only transactions do not take locks,
    /// so they do not conflict with read-write transactions. As a consequence of not taking locks, they also do not
    /// abort, so retry loops are not needed. Transactions may only read-write data in a single database. They may,
    /// however, read-write data in different tables within that database. Locking read-write transactions: Locking
    /// transactions may be used to atomically read-modify-write data anywhere in a database. This type of transaction
    /// is externally consistent. Clients should attempt to minimize the amount of time a transaction is active. Faster
    /// transactions commit with higher probability and cause less contention. Cloud Spanner attempts to keep read locks
    /// active as long as the transaction continues to do reads, and the transaction has not been terminated by Commit
    /// or Rollback. Long periods of inactivity at the client may cause Cloud Spanner to release a transaction's locks
    /// and abort it. Conceptually, a read-write transaction consists of zero or more reads or SQL statements followed
    /// by Commit. At any time before Commit, the client can send a Rollback request to abort the transaction.
    /// Semantics: Cloud Spanner can commit the transaction if all read locks it acquired are still valid at commit
    /// time, and it is able to acquire write locks for all writes. Cloud Spanner can abort the transaction for any
    /// reason. If a commit attempt returns `ABORTED`, Cloud Spanner guarantees that the transaction has not modified
    /// any user data in Cloud Spanner. Unless the transaction commits, Cloud Spanner makes no guarantees about how long
    /// the transaction's locks were held for. It is an error to use Cloud Spanner locks for any sort of mutual
    /// exclusion other than between Cloud Spanner transactions themselves. Retrying aborted transactions: When a
    /// transaction aborts, the application can choose to retry the whole transaction again. To maximize the chances of
    /// successfully committing the retry, the client should execute the retry in the same session as the original
    /// attempt. The original session's lock priority increases with each consecutive abort, meaning that each attempt
    /// has a slightly better chance of success than the previous. Note that the lock priority is preserved per session
    /// (not per transaction). Lock priority is set by the first read or write in the first attempt of a read-write
    /// transaction. If the application starts a new session to retry the whole transaction, the transaction loses its
    /// original lock priority. Moreover, the lock priority is only preserved if the transaction fails with an `ABORTED`
    /// error. Under some circumstances (for example, many transactions attempting to modify the same row(s)), a
    /// transaction can abort many times in a short period before successfully committing. Thus, it is not a good idea
    /// to cap the number of retries a transaction can attempt; instead, it is better to limit the total amount of time
    /// spent retrying. Idle transactions: A transaction is considered idle if it has no outstanding reads or SQL
    /// queries and has not started a read or SQL query within the last 10 seconds. Idle transactions can be aborted by
    /// Cloud Spanner so that they don't hold on to locks indefinitely. If an idle transaction is aborted, the commit
    /// fails with error `ABORTED`. If this behavior is undesirable, periodically executing a simple SQL query in the
    /// transaction (for example, `SELECT 1`) prevents the transaction from becoming idle. Snapshot read-only
    /// transactions: Snapshot read-only transactions provides a simpler method than locking read-write transactions for
    /// doing several consistent reads. However, this type of transaction does not support writes. Snapshot transactions
    /// do not take locks. Instead, they work by choosing a Cloud Spanner timestamp, then executing all reads at that
    /// timestamp. Since they do not acquire locks, they do not block concurrent read-write transactions. Unlike locking
    /// read-write transactions, snapshot read-only transactions never abort. They can fail if the chosen read timestamp
    /// is garbage collected; however, the default garbage collection policy is generous enough that most applications
    /// do not need to worry about this in practice. Snapshot read-only transactions do not need to call Commit or
    /// Rollback (and in fact are not permitted to do so). To execute a snapshot transaction, the client specifies a
    /// timestamp bound, which tells Cloud Spanner how to choose a read timestamp. The types of timestamp bound are: -
    /// Strong (the default). - Bounded staleness. - Exact staleness. If the Cloud Spanner database to be read is
    /// geographically distributed, stale read-only transactions can execute more quickly than strong or read-write
    /// transactions, because they are able to execute far from the leader replica. Each type of timestamp bound is
    /// discussed in detail below. Strong: Strong reads are guaranteed to see the effects of all transactions that have
    /// committed before the start of the read. Furthermore, all rows yielded by a single read are consistent with each
    /// other -- if any part of the read observes a transaction, all parts of the read see the transaction. Strong reads
    /// are not repeatable: two consecutive strong read-only transactions might return inconsistent results if there are
    /// concurrent writes. If consistency across reads is required, the reads should be executed within a transaction or
    /// at an exact read timestamp. Queries on change streams (see below for more details) must also specify the strong
    /// read timestamp bound. See TransactionOptions.ReadOnly.strong. Exact staleness: These timestamp bounds execute
    /// reads at a user-specified timestamp. Reads at a timestamp are guaranteed to see a consistent prefix of the
    /// global transaction history: they observe modifications done by all transactions with a commit timestamp less
    /// than or equal to the read timestamp, and observe none of the modifications done by transactions with a larger
    /// commit timestamp. They block until all conflicting transactions that can be assigned commit timestamps &amp;lt;=
    /// the read timestamp have finished. The timestamp can either be expressed as an absolute Cloud Spanner commit
    /// timestamp or a staleness relative to the current time. These modes do not require a "negotiation phase" to pick
    /// a timestamp. As a result, they execute slightly faster than the equivalent boundedly stale concurrency modes. On
    /// the other hand, boundedly stale reads usually return fresher results. See
    /// TransactionOptions.ReadOnly.read_timestamp and TransactionOptions.ReadOnly.exact_staleness. Bounded staleness:
    /// Bounded staleness modes allow Cloud Spanner to pick the read timestamp, subject to a user-provided staleness
    /// bound. Cloud Spanner chooses the newest timestamp within the staleness bound that allows execution of the reads
    /// at the closest available replica without blocking. All rows yielded are consistent with each other -- if any
    /// part of the read observes a transaction, all parts of the read see the transaction. Boundedly stale reads are
    /// not repeatable: two stale reads, even if they use the same staleness bound, can execute at different timestamps
    /// and thus return inconsistent results. Boundedly stale reads execute in two phases: the first phase negotiates a
    /// timestamp among all replicas needed to serve the read. In the second phase, reads are executed at the negotiated
    /// timestamp. As a result of the two phase execution, bounded staleness reads are usually a little slower than
    /// comparable exact staleness reads. However, they are typically able to return fresher results, and are more
    /// likely to execute at the closest replica. Because the timestamp negotiation requires up-front knowledge of which
    /// rows are read, it can only be used with single-use read-only transactions. See
    /// TransactionOptions.ReadOnly.max_staleness and TransactionOptions.ReadOnly.min_read_timestamp. Old read
    /// timestamps and garbage collection: Cloud Spanner continuously garbage collects deleted and overwritten data in
    /// the background to reclaim storage space. This process is known as "version GC". By default, version GC reclaims
    /// versions after they are one hour old. Because of this, Cloud Spanner can't perform reads at read timestamps more
    /// than one hour in the past. This restriction also applies to in-progress reads and/or SQL queries whose timestamp
    /// become too old while executing. Reads and SQL queries with too-old read timestamps fail with the error
    /// `FAILED_PRECONDITION`. You can configure and extend the `VERSION_RETENTION_PERIOD` of a database up to a period
    /// as long as one week, which allows Cloud Spanner to perform reads up to one week in the past. Querying change
    /// Streams: A Change Stream is a schema object that can be configured to watch data changes on the entire database,
    /// a set of tables, or a set of columns in a database. When a change stream is created, Spanner automatically
    /// defines a corresponding SQL Table-Valued Function (TVF) that can be used to query the change records in the
    /// associated change stream using the ExecuteStreamingSql API. The name of the TVF for a change stream is generated
    /// from the name of the change stream: READ_. All queries on change stream TVFs must be executed using the
    /// ExecuteStreamingSql API with a single-use read-only transaction with a strong read-only timestamp_bound. The
    /// change stream TVF allows users to specify the start_timestamp and end_timestamp for the time range of interest.
    /// All change records within the retention period is accessible using the strong read-only timestamp_bound. All
    /// other TransactionOptions are invalid for change stream queries. In addition, if
    /// TransactionOptions.read_only.return_read_timestamp is set to true, a special value of 2^63 - 2 is returned in
    /// the Transaction message that describes the transaction, instead of a valid read timestamp. This special value
    /// should be discarded and not used for any subsequent queries. Please see
    /// https://cloud.google.com/spanner/docs/change-streams for more details on how to query the change stream TVFs.
    /// Partitioned DML transactions: Partitioned DML transactions are used to execute DML statements with a different
    /// execution strategy that provides different, and often better, scalability properties for large, table-wide
    /// operations than DML in a ReadWrite transaction. Smaller scoped statements, such as an OLTP workload, should
    /// prefer using ReadWrite transactions. Partitioned DML partitions the keyspace and runs the DML statement on each
    /// partition in separate, internal transactions. These transactions commit automatically when complete, and run
    /// independently from one another. To reduce lock contention, this execution strategy only acquires read locks on
    /// rows that match the WHERE clause of the statement. Additionally, the smaller per-partition transactions hold
    /// locks for less time. That said, Partitioned DML is not a drop-in replacement for standard DML used in ReadWrite
    /// transactions. - The DML statement must be fully-partitionable. Specifically, the statement must be expressible
    /// as the union of many statements which each access only a single row of the table. - The statement is not applied
    /// atomically to all rows of the table. Rather, the statement is applied atomically to partitions of the table, in
    /// independent transactions. Secondary index rows are updated atomically with the base table rows. - Partitioned
    /// DML does not guarantee exactly-once execution semantics against a partition. The statement is applied at least
    /// once to each partition. It is strongly recommended that the DML statement should be idempotent to avoid
    /// unexpected results. For instance, it is potentially dangerous to run a statement such as `UPDATE table SET
    /// column = column + 1` as it could be run multiple times against some rows. - The partitions are committed
    /// automatically - there is no support for Commit or Rollback. If the call returns an error, or if the client
    /// issuing the ExecuteSql call dies, it is possible that some rows had the statement executed on them successfully.
    /// It is also possible that statement was never executed against other rows. - Partitioned DML transactions may
    /// only contain the execution of a single DML statement via ExecuteSql or ExecuteStreamingSql. - If any error is
    /// encountered during the execution of the partitioned DML operation (for instance, a UNIQUE INDEX violation,
    /// division by zero, or a value that can't be stored due to schema constraints), then the operation is stopped at
    /// that point and an error is returned. It is possible that at this point, some partitions have been committed (or
    /// even committed multiple times), and other partitions have not been run at all. Given the above, Partitioned DML
    /// is good fit for large, database-wide, operations that are idempotent, such as deleting old rows from a very
    /// large table.
    /// </summary>
    public class TransactionOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// When `exclude_txn_from_change_streams` is set to `true`, it prevents read or write transactions from being
        /// tracked in change streams. * If the DDL option `allow_txn_exclusion` is set to `true`, then the updates made
        /// within this transaction aren't recorded in the change stream. * If you don't set the DDL option
        /// `allow_txn_exclusion` or if it's set to `false`, then the updates made within this transaction are recorded
        /// in the change stream. When `exclude_txn_from_change_streams` is set to `false` or not set, modifications
        /// from this transaction are recorded in all change streams that are tracking columns modified by these
        /// transactions. The `exclude_txn_from_change_streams` option can only be specified for read-write or
        /// partitioned DML transactions, otherwise the API returns an `INVALID_ARGUMENT` error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludeTxnFromChangeStreams")]
        public virtual System.Nullable<bool> ExcludeTxnFromChangeStreams { get; set; }

        /// <summary>Isolation level for the transaction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isolationLevel")]
        public virtual string IsolationLevel { get; set; }

        /// <summary>
        /// Partitioned DML transaction. Authorization to begin a Partitioned DML transaction requires
        /// `spanner.databases.beginPartitionedDmlTransaction` permission on the `session` resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partitionedDml")]
        public virtual PartitionedDml PartitionedDml { get; set; }

        /// <summary>
        /// Transaction does not write. Authorization to begin a read-only transaction requires
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

        /// <summary>
        /// If code == PROTO or code == ENUM, then `proto_type_fqn` is the fully qualified name of the proto type
        /// representing the proto/enum definition.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protoTypeFqn")]
        public virtual string ProtoTypeFqn { get; set; }

        /// <summary>If code == STRUCT, then `struct_type` provides type information for the struct's fields.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("structType")]
        public virtual StructType StructType { get; set; }

        /// <summary>
        /// The TypeAnnotationCode that disambiguates SQL type that Spanner will use to represent values of this type
        /// during query processing. This is necessary for some type codes because a single TypeCode can be mapped to
        /// different SQL types depending on the SQL dialect. type_annotation typically is not needed to process the
        /// content of a value (it doesn't affect serialization) and clients can ignore it on the read path.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("typeAnnotation")]
        public virtual string TypeAnnotation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata type for the operation returned by UpdateDatabaseDdl.</summary>
    public class UpdateDatabaseDdlMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The brief action info for the DDL statements. `actions[i]` is the brief info for `statements[i]`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actions")]
        public virtual System.Collections.Generic.IList<DdlStatementActionInfo> Actions { get; set; }

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
        /// The progress of the UpdateDatabaseDdl operations. All DDL statements will have continuously updating
        /// progress, and `progress[i]` is the operation progress for `statements[i]`. Also, `progress[i]` will have
        /// start time and end time populated with commit timestamp of operation, as well as a progress of 100% once the
        /// operation has completed.
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
        /// Output only. When true, indicates that the operation is throttled e.g. due to resource constraints. When
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
        /// form the `name` of the resulting longrunning.Operation: `/operations/`. `operation_id` should be unique
        /// within the database, and must be a valid identifier: `a-z*`. Note that automatically-generated operation IDs
        /// always begin with an underscore. If the named operation already exists, UpdateDatabaseDdl returns
        /// `ALREADY_EXISTS`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationId")]
        public virtual string OperationId { get; set; }

        /// <summary>
        /// Optional. Proto descriptors used by CREATE/ALTER PROTO BUNDLE statements. Contains a protobuf-serialized
        /// [google.protobuf.FileDescriptorSet](https://github.com/protocolbuffers/protobuf/blob/main/src/google/protobuf/descriptor.proto).
        /// To generate it, [install](https://grpc.io/docs/protoc-installation/) and run `protoc` with --include_imports
        /// and --descriptor_set_out. For example, to generate for moon/shot/app.proto, run
        /// ```
        /// $protoc
        /// --proto_path=/app_path --proto_path=/lib_path \ --include_imports \ --descriptor_set_out=descriptors.data \
        /// moon/shot/app.proto
        /// ```
        /// For more details, see protobuffer [self
        /// description](https://developers.google.com/protocol-buffers/docs/techniques#self-description).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protoDescriptors")]
        public virtual string ProtoDescriptors { get; set; }

        /// <summary>Required. DDL statements to be applied to the database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statements")]
        public virtual System.Collections.Generic.IList<string> Statements { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata type for the operation returned by UpdateDatabase.</summary>
    public class UpdateDatabaseMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _cancelTimeRaw;

        private object _cancelTime;

        /// <summary>
        /// The time at which this operation was cancelled. If set, this operation is in the process of undoing itself
        /// (which is best-effort).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cancelTime")]
        public virtual string CancelTimeRaw
        {
            get => _cancelTimeRaw;
            set
            {
                _cancelTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _cancelTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CancelTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CancelTimeDateTimeOffset instead.")]
        public virtual object CancelTime
        {
            get => _cancelTime;
            set
            {
                _cancelTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _cancelTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CancelTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CancelTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CancelTimeRaw);
            set => CancelTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The progress of the UpdateDatabase operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progress")]
        public virtual OperationProgress Progress { get; set; }

        /// <summary>The request for UpdateDatabase.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("request")]
        public virtual UpdateDatabaseRequest Request { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for UpdateDatabase.</summary>
    public class UpdateDatabaseRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The database to update. The `name` field of the database is of the form
        /// `projects//instances//databases/`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("database")]
        public virtual Database Database { get; set; }

        /// <summary>
        /// Required. The list of fields to update. Currently, only `enable_drop_protection` field can be updated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata type for the operation returned by UpdateInstanceConfig.</summary>
    public class UpdateInstanceConfigMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _cancelTimeRaw;

        private object _cancelTime;

        /// <summary>The time at which this operation was cancelled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cancelTime")]
        public virtual string CancelTimeRaw
        {
            get => _cancelTimeRaw;
            set
            {
                _cancelTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _cancelTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CancelTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CancelTimeDateTimeOffset instead.")]
        public virtual object CancelTime
        {
            get => _cancelTime;
            set
            {
                _cancelTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _cancelTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CancelTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CancelTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CancelTimeRaw);
            set => CancelTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The desired instance configuration after updating.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceConfig")]
        public virtual InstanceConfig InstanceConfig { get; set; }

        /// <summary>The progress of the UpdateInstanceConfig operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progress")]
        public virtual InstanceOperationProgress Progress { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for UpdateInstanceConfig.</summary>
    public class UpdateInstanceConfigRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The user instance configuration to update, which must always include the instance configuration
        /// name. Otherwise, only fields mentioned in update_mask need be included. To prevent conflicts of concurrent
        /// updates, etag can be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceConfig")]
        public virtual InstanceConfig InstanceConfig { get; set; }

        /// <summary>
        /// Required. A mask specifying which fields in InstanceConfig should be updated. The field mask must always be
        /// specified; this prevents any future fields in InstanceConfig from being erased accidentally by clients that
        /// do not know about them. Only display_name and labels can be updated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>
        /// An option to validate, but not actually execute, a request, and provide the same response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validateOnly")]
        public virtual System.Nullable<bool> ValidateOnly { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata type for the operation returned by UpdateInstance.</summary>
    public class UpdateInstanceMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _cancelTimeRaw;

        private object _cancelTime;

        /// <summary>
        /// The time at which this operation was cancelled. If set, this operation is in the process of undoing itself
        /// (which is guaranteed to succeed) and cannot be cancelled again.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cancelTime")]
        public virtual string CancelTimeRaw
        {
            get => _cancelTimeRaw;
            set
            {
                _cancelTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _cancelTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CancelTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CancelTimeDateTimeOffset instead.")]
        public virtual object CancelTime
        {
            get => _cancelTime;
            set
            {
                _cancelTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _cancelTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CancelTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CancelTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CancelTimeRaw);
            set => CancelTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>The time at which this operation failed or was completed successfully.</summary>
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

        /// <summary>The expected fulfillment period of this update operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expectedFulfillmentPeriod")]
        public virtual string ExpectedFulfillmentPeriod { get; set; }

        /// <summary>The desired end state of the update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instance")]
        public virtual Instance Instance { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>The time at which UpdateInstance request was received.</summary>
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

    /// <summary>Metadata type for the operation returned by UpdateInstancePartition.</summary>
    public class UpdateInstancePartitionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _cancelTimeRaw;

        private object _cancelTime;

        /// <summary>
        /// The time at which this operation was cancelled. If set, this operation is in the process of undoing itself
        /// (which is guaranteed to succeed) and cannot be cancelled again.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cancelTime")]
        public virtual string CancelTimeRaw
        {
            get => _cancelTimeRaw;
            set
            {
                _cancelTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _cancelTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CancelTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CancelTimeDateTimeOffset instead.")]
        public virtual object CancelTime
        {
            get => _cancelTime;
            set
            {
                _cancelTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _cancelTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CancelTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CancelTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CancelTimeRaw);
            set => CancelTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>The time at which this operation failed or was completed successfully.</summary>
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

        /// <summary>The desired end state of the update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instancePartition")]
        public virtual InstancePartition InstancePartition { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>The time at which UpdateInstancePartition request was received.</summary>
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

    /// <summary>The request for UpdateInstancePartition.</summary>
    public class UpdateInstancePartitionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. A mask specifying which fields in InstancePartition should be updated. The field mask must always
        /// be specified; this prevents any future fields in InstancePartition from being erased accidentally by clients
        /// that do not know about them.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldMask")]
        public virtual object FieldMask { get; set; }

        /// <summary>
        /// Required. The instance partition to update, which must always include the instance partition name.
        /// Otherwise, only fields mentioned in field_mask need be included.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instancePartition")]
        public virtual InstancePartition InstancePartition { get; set; }

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
