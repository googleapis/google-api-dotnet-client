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

namespace Google.Apis.Logging.v2
{
    /// <summary>The Logging Service.</summary>
    public class LoggingService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v2";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public LoggingService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public LoggingService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            BillingAccounts = new BillingAccountsResource(this);
            Entries = new EntriesResource(this);
            Exclusions = new ExclusionsResource(this);
            Folders = new FoldersResource(this);
            Locations = new LocationsResource(this);
            Logs = new LogsResource(this);
            MonitoredResourceDescriptors = new MonitoredResourceDescriptorsResource(this);
            Organizations = new OrganizationsResource(this);
            Projects = new ProjectsResource(this);
            Sinks = new SinksResource(this);
            V2 = new V2Resource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "logging";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://logging.googleapis.com/";
        #else
            "https://logging.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://logging.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Logging API.</summary>
        public class Scope
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>View your data across Google Cloud Platform services</summary>
            public static string CloudPlatformReadOnly = "https://www.googleapis.com/auth/cloud-platform.read-only";

            /// <summary>Administrate log data for your projects</summary>
            public static string LoggingAdmin = "https://www.googleapis.com/auth/logging.admin";

            /// <summary>View log data for your projects</summary>
            public static string LoggingRead = "https://www.googleapis.com/auth/logging.read";

            /// <summary>Submit log data for your projects</summary>
            public static string LoggingWrite = "https://www.googleapis.com/auth/logging.write";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Logging API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>View your data across Google Cloud Platform services</summary>
            public const string CloudPlatformReadOnly = "https://www.googleapis.com/auth/cloud-platform.read-only";

            /// <summary>Administrate log data for your projects</summary>
            public const string LoggingAdmin = "https://www.googleapis.com/auth/logging.admin";

            /// <summary>View log data for your projects</summary>
            public const string LoggingRead = "https://www.googleapis.com/auth/logging.read";

            /// <summary>Submit log data for your projects</summary>
            public const string LoggingWrite = "https://www.googleapis.com/auth/logging.write";
        }

        /// <summary>Gets the BillingAccounts resource.</summary>
        public virtual BillingAccountsResource BillingAccounts { get; }

        /// <summary>Gets the Entries resource.</summary>
        public virtual EntriesResource Entries { get; }

        /// <summary>Gets the Exclusions resource.</summary>
        public virtual ExclusionsResource Exclusions { get; }

        /// <summary>Gets the Folders resource.</summary>
        public virtual FoldersResource Folders { get; }

        /// <summary>Gets the Locations resource.</summary>
        public virtual LocationsResource Locations { get; }

        /// <summary>Gets the Logs resource.</summary>
        public virtual LogsResource Logs { get; }

        /// <summary>Gets the MonitoredResourceDescriptors resource.</summary>
        public virtual MonitoredResourceDescriptorsResource MonitoredResourceDescriptors { get; }

        /// <summary>Gets the Organizations resource.</summary>
        public virtual OrganizationsResource Organizations { get; }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }

        /// <summary>Gets the Sinks resource.</summary>
        public virtual SinksResource Sinks { get; }

        /// <summary>Gets the V2 resource.</summary>
        public virtual V2Resource V2 { get; }
    }

    /// <summary>A base abstract class for Logging requests.</summary>
    public abstract class LoggingBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new LoggingBaseServiceRequest instance.</summary>
        protected LoggingBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Logging parameter list.</summary>
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

    /// <summary>The "billingAccounts" collection of methods.</summary>
    public class BillingAccountsResource
    {
        private const string Resource = "billingAccounts";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public BillingAccountsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Buckets = new BucketsResource(service);
            Exclusions = new ExclusionsResource(service);
            Locations = new LocationsResource(service);
            Logs = new LogsResource(service);
            Operations = new OperationsResource(service);
            Sinks = new SinksResource(service);
        }

        /// <summary>Gets the Buckets resource.</summary>
        public virtual BucketsResource Buckets { get; }

        /// <summary>The "buckets" collection of methods.</summary>
        public class BucketsResource
        {
            private const string Resource = "buckets";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public BucketsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Views = new ViewsResource(service);
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

                /// <summary>Gets a view.</summary>
                /// <param name="name">
                /// Required. The resource name of the policy:
                /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]" Example:
                /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id/views/my-view-id".
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Gets a view.</summary>
                public class GetRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogView>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the policy:
                    /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]" Example:
                    /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id/views/my-view-id".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^billingAccounts/[^/]+/buckets/[^/]+/views/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets a bucket.</summary>
            /// <param name="name">
            /// Required. The resource name of the bucket:
            /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
            /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
            /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
            /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]" Example:
            /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id".
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets a bucket.</summary>
            public class GetRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogBucket>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the bucket:
                /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]" Example:
                /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}";

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
                        Pattern = @"^billingAccounts/[^/]+/buckets/[^/]+$",
                    });
                }
            }
        }

        /// <summary>Gets the Exclusions resource.</summary>
        public virtual ExclusionsResource Exclusions { get; }

        /// <summary>The "exclusions" collection of methods.</summary>
        public class ExclusionsResource
        {
            private const string Resource = "exclusions";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ExclusionsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Creates a new exclusion in a specified parent resource. Only log entries belonging to that resource can
            /// be excluded. You can have up to 10 exclusions in a resource.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The parent resource in which to create the exclusion: "projects/[PROJECT_ID]"
            /// "organizations/[ORGANIZATION_ID]" "billingAccounts/[BILLING_ACCOUNT_ID]" "folders/[FOLDER_ID]" Examples:
            /// "projects/my-logging-project", "organizations/123456789".
            /// </param>
            public virtual CreateRequest Create(Google.Apis.Logging.v2.Data.LogExclusion body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>
            /// Creates a new exclusion in a specified parent resource. Only log entries belonging to that resource can
            /// be excluded. You can have up to 10 exclusions in a resource.
            /// </summary>
            public class CreateRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogExclusion>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Logging.v2.Data.LogExclusion body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent resource in which to create the exclusion: "projects/[PROJECT_ID]"
                /// "organizations/[ORGANIZATION_ID]" "billingAccounts/[BILLING_ACCOUNT_ID]" "folders/[FOLDER_ID]"
                /// Examples: "projects/my-logging-project", "organizations/123456789".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Logging.v2.Data.LogExclusion Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/exclusions";

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
                        Pattern = @"^billingAccounts/[^/]+$",
                    });
                }
            }

            /// <summary>Deletes an exclusion.</summary>
            /// <param name="name">
            /// Required. The resource name of an existing exclusion to delete:
            /// "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
            /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
            /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
            /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]" Example:
            /// "projects/my-project-id/exclusions/my-exclusion-id".
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>Deletes an exclusion.</summary>
            public class DeleteRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of an existing exclusion to delete:
                /// "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
                /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
                /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
                /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]" Example:
                /// "projects/my-project-id/exclusions/my-exclusion-id".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}";

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
                        Pattern = @"^billingAccounts/[^/]+/exclusions/[^/]+$",
                    });
                }
            }

            /// <summary>Gets the description of an exclusion.</summary>
            /// <param name="name">
            /// Required. The resource name of an existing exclusion: "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
            /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
            /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
            /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]" Example:
            /// "projects/my-project-id/exclusions/my-exclusion-id".
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets the description of an exclusion.</summary>
            public class GetRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogExclusion>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of an existing exclusion:
                /// "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
                /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
                /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
                /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]" Example:
                /// "projects/my-project-id/exclusions/my-exclusion-id".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}";

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
                        Pattern = @"^billingAccounts/[^/]+/exclusions/[^/]+$",
                    });
                }
            }

            /// <summary>Lists all the exclusions in a parent resource.</summary>
            /// <param name="parent">
            /// Required. The parent resource whose exclusions are to be listed. "projects/[PROJECT_ID]"
            /// "organizations/[ORGANIZATION_ID]" "billingAccounts/[BILLING_ACCOUNT_ID]" "folders/[FOLDER_ID]"
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists all the exclusions in a parent resource.</summary>
            public class ListRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.ListExclusionsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent resource whose exclusions are to be listed. "projects/[PROJECT_ID]"
                /// "organizations/[ORGANIZATION_ID]" "billingAccounts/[BILLING_ACCOUNT_ID]" "folders/[FOLDER_ID]"
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. The maximum number of results to return from this request. Non-positive values are
                /// ignored. The presence of nextPageToken in the response indicates that more results might be
                /// available.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. If present, then retrieve the next batch of results from the preceding call to this
                /// method. pageToken must be the value of nextPageToken from the previous response. The values of other
                /// method parameters should be identical to those in the previous call.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/exclusions";

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
                        Pattern = @"^billingAccounts/[^/]+$",
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

            /// <summary>Changes one or more properties of an existing exclusion.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The resource name of the exclusion to update:
            /// "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
            /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
            /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
            /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]" Example:
            /// "projects/my-project-id/exclusions/my-exclusion-id".
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.Logging.v2.Data.LogExclusion body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>Changes one or more properties of an existing exclusion.</summary>
            public class PatchRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogExclusion>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Logging.v2.Data.LogExclusion body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the exclusion to update:
                /// "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
                /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
                /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
                /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]" Example:
                /// "projects/my-project-id/exclusions/my-exclusion-id".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Required. A non-empty list of fields to change in the existing exclusion. New values for the fields
                /// are taken from the corresponding fields in the LogExclusion included in this request. Fields not
                /// mentioned in update_mask are not changed and are ignored in the request.For example, to change the
                /// filter and description of an exclusion, specify an update_mask of "filter,description".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Logging.v2.Data.LogExclusion Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}";

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
                        Pattern = @"^billingAccounts/[^/]+/exclusions/[^/]+$",
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
                Buckets = new BucketsResource(service);
                Operations = new OperationsResource(service);
            }

            /// <summary>Gets the Buckets resource.</summary>
            public virtual BucketsResource Buckets { get; }

            /// <summary>The "buckets" collection of methods.</summary>
            public class BucketsResource
            {
                private const string Resource = "buckets";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public BucketsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Views = new ViewsResource(service);
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

                    /// <summary>
                    /// Creates a view over logs in a bucket. A bucket may contain a maximum of 50 views.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The bucket in which to create the view
                    /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]" Example:
                    /// "projects/my-logging-project/locations/my-location/buckets/my-bucket"
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.Logging.v2.Data.LogView body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>
                    /// Creates a view over logs in a bucket. A bucket may contain a maximum of 50 views.
                    /// </summary>
                    public class CreateRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogView>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Logging.v2.Data.LogView body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The bucket in which to create the view
                        /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]" Example:
                        /// "projects/my-logging-project/locations/my-location/buckets/my-bucket"
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Required. The id to use for this view.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("viewId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string ViewId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Logging.v2.Data.LogView Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+parent}/views";

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
                                Pattern = @"^billingAccounts/[^/]+/locations/[^/]+/buckets/[^/]+$",
                            });
                            RequestParameters.Add("viewId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "viewId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Deletes a view from a bucket.</summary>
                    /// <param name="name">
                    /// Required. The full resource name of the view to delete:
                    /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]" Example:
                    /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id/views/my-view-id".
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>Deletes a view from a bucket.</summary>
                    public class DeleteRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The full resource name of the view to delete:
                        /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]" Example:
                        /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id/views/my-view-id".
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+name}";

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
                                Pattern = @"^billingAccounts/[^/]+/locations/[^/]+/buckets/[^/]+/views/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists views on a bucket.</summary>
                    /// <param name="parent">
                    /// Required. The bucket whose views are to be listed:
                    /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Lists views on a bucket.</summary>
                    public class ListRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.ListViewsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The bucket whose views are to be listed:
                        /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. The maximum number of results to return from this request. Non-positive values are
                        /// ignored. The presence of nextPageToken in the response indicates that more results might be
                        /// available.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. If present, then retrieve the next batch of results from the preceding call to
                        /// this method. pageToken must be the value of nextPageToken from the previous response. The
                        /// values of other method parameters should be identical to those in the previous call.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+parent}/views";

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
                                Pattern = @"^billingAccounts/[^/]+/locations/[^/]+/buckets/[^/]+$",
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
                    /// Updates a view. This method replaces the following fields in the existing view with values from
                    /// the new view: filter.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The full resource name of the view to update
                    /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]" Example:
                    /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id/views/my-view-id".
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.Logging.v2.Data.LogView body, string name)
                    {
                        return new PatchRequest(service, body, name);
                    }

                    /// <summary>
                    /// Updates a view. This method replaces the following fields in the existing view with values from
                    /// the new view: filter.
                    /// </summary>
                    public class PatchRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogView>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Logging.v2.Data.LogView body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The full resource name of the view to update
                        /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]" Example:
                        /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id/views/my-view-id".
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. Field mask that specifies the fields in view that need an update. A field will be
                        /// overwritten if, and only if, it is in the update mask. name and output only fields cannot be
                        /// updated.For a detailed FieldMask definition, see
                        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#google.protobuf.FieldMaskExample:
                        /// updateMask=filter.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Logging.v2.Data.LogView Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "patch";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PATCH";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+name}";

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
                                Pattern = @"^billingAccounts/[^/]+/locations/[^/]+/buckets/[^/]+/views/[^/]+$",
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
                /// Creates a bucket that can be used to store log entries. Once a bucket has been created, the region
                /// cannot be changed.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The resource in which to create the bucket:
                /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]" Example:
                /// "projects/my-logging-project/locations/global"
                /// </param>
                public virtual CreateRequest Create(Google.Apis.Logging.v2.Data.LogBucket body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>
                /// Creates a bucket that can be used to store log entries. Once a bucket has been created, the region
                /// cannot be changed.
                /// </summary>
                public class CreateRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogBucket>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Logging.v2.Data.LogBucket body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource in which to create the bucket:
                    /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]" Example:
                    /// "projects/my-logging-project/locations/global"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. A client-assigned identifier such as "my-bucket". Identifiers are limited to 100
                    /// characters and can include only letters, digits, underscores, hyphens, and periods.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("bucketId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string BucketId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Logging.v2.Data.LogBucket Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/buckets";

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
                            Pattern = @"^billingAccounts/[^/]+/locations/[^/]+$",
                        });
                        RequestParameters.Add("bucketId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "bucketId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Deletes a bucket. Moves the bucket to the DELETE_REQUESTED state. After 7 days, the bucket will be
                /// purged and all logs in the bucket will be permanently deleted.
                /// </summary>
                /// <param name="name">
                /// Required. The full resource name of the bucket to delete.
                /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]" Example:
                /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id".
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>
                /// Deletes a bucket. Moves the bucket to the DELETE_REQUESTED state. After 7 days, the bucket will be
                /// purged and all logs in the bucket will be permanently deleted.
                /// </summary>
                public class DeleteRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The full resource name of the bucket to delete.
                    /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                    /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                    /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                    /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]" Example:
                    /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^billingAccounts/[^/]+/locations/[^/]+/buckets/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists buckets.</summary>
                /// <param name="parent">
                /// Required. The parent resource whose buckets are to be listed:
                /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]"
                /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]"
                /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]"
                /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]" Note: The locations portion of the resource must be
                /// specified, but supplying the character - in place of LOCATION_ID will return all buckets.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists buckets.</summary>
                public class ListRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.ListBucketsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource whose buckets are to be listed:
                    /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]"
                    /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]"
                    /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]"
                    /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]" Note: The locations portion of the resource must
                    /// be specified, but supplying the character - in place of LOCATION_ID will return all buckets.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. The maximum number of results to return from this request. Non-positive values are
                    /// ignored. The presence of nextPageToken in the response indicates that more results might be
                    /// available.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. If present, then retrieve the next batch of results from the preceding call to this
                    /// method. pageToken must be the value of nextPageToken from the previous response. The values of
                    /// other method parameters should be identical to those in the previous call.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/buckets";

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
                            Pattern = @"^billingAccounts/[^/]+/locations/[^/]+$",
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
                /// Updates a bucket. This method replaces the following fields in the existing bucket with values from
                /// the new bucket: retention_periodIf the retention period is decreased and the bucket is locked,
                /// FAILED_PRECONDITION will be returned.If the bucket has a LifecycleState of DELETE_REQUESTED,
                /// FAILED_PRECONDITION will be returned.A buckets region may not be modified after it is created.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The full resource name of the bucket to update.
                /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]" Example:
                /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id". Also requires permission
                /// "resourcemanager.projects.updateLiens" to set the locked property
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.Logging.v2.Data.LogBucket body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>
                /// Updates a bucket. This method replaces the following fields in the existing bucket with values from
                /// the new bucket: retention_periodIf the retention period is decreased and the bucket is locked,
                /// FAILED_PRECONDITION will be returned.If the bucket has a LifecycleState of DELETE_REQUESTED,
                /// FAILED_PRECONDITION will be returned.A buckets region may not be modified after it is created.
                /// </summary>
                public class PatchRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogBucket>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Logging.v2.Data.LogBucket body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The full resource name of the bucket to update.
                    /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                    /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                    /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                    /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]" Example:
                    /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id". Also requires permission
                    /// "resourcemanager.projects.updateLiens" to set the locked property
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Required. Field mask that specifies the fields in bucket that need an update. A bucket field
                    /// will be overwritten if, and only if, it is in the update mask. name and output only fields
                    /// cannot be updated.For a detailed FieldMask definition, see
                    /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#google.protobuf.FieldMaskExample:
                    /// updateMask=retention_days.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Logging.v2.Data.LogBucket Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^billingAccounts/[^/]+/locations/[^/]+/buckets/[^/]+$",
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
                /// Undeletes a bucket. A bucket that has been deleted may be undeleted within the grace period of 7
                /// days.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The full resource name of the bucket to undelete.
                /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]" Example:
                /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id".
                /// </param>
                public virtual UndeleteRequest Undelete(Google.Apis.Logging.v2.Data.UndeleteBucketRequest body, string name)
                {
                    return new UndeleteRequest(service, body, name);
                }

                /// <summary>
                /// Undeletes a bucket. A bucket that has been deleted may be undeleted within the grace period of 7
                /// days.
                /// </summary>
                public class UndeleteRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.Empty>
                {
                    /// <summary>Constructs a new Undelete request.</summary>
                    public UndeleteRequest(Google.Apis.Services.IClientService service, Google.Apis.Logging.v2.Data.UndeleteBucketRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The full resource name of the bucket to undelete.
                    /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                    /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                    /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                    /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]" Example:
                    /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Logging.v2.Data.UndeleteBucketRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "undelete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}:undelete";

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
                            Pattern = @"^billingAccounts/[^/]+/locations/[^/]+/buckets/[^/]+$",
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
                /// returns google.rpc.Code.UNIMPLEMENTED. Clients can use Operations.GetOperation or other methods to
                /// check whether the cancellation succeeded or whether the operation completed despite cancellation. On
                /// successful cancellation, the operation is not deleted; instead, it becomes an operation with an
                /// Operation.error value with a google.rpc.Status.code of 1, corresponding to Code.CANCELLED.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">The name of the operation resource to be cancelled.</param>
                public virtual CancelRequest Cancel(Google.Apis.Logging.v2.Data.CancelOperationRequest body, string name)
                {
                    return new CancelRequest(service, body, name);
                }

                /// <summary>
                /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to
                /// cancel the operation, but success is not guaranteed. If the server doesn't support this method, it
                /// returns google.rpc.Code.UNIMPLEMENTED. Clients can use Operations.GetOperation or other methods to
                /// check whether the cancellation succeeded or whether the operation completed despite cancellation. On
                /// successful cancellation, the operation is not deleted; instead, it becomes an operation with an
                /// Operation.error value with a google.rpc.Status.code of 1, corresponding to Code.CANCELLED.
                /// </summary>
                public class CancelRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.Empty>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.Logging.v2.Data.CancelOperationRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to be cancelled.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Logging.v2.Data.CancelOperationRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "cancel";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}:cancel";

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
                            Pattern = @"^billingAccounts/[^/]+/locations/[^/]+/operations/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists operations that match the specified filter in the request. If the server doesn't support this
                /// method, it returns UNIMPLEMENTED.NOTE: the name binding allows API services to override the binding
                /// to use different resource name schemes, such as users/*/operations. To override the binding, API
                /// services can add a binding such as "/v1/{name=users/*}/operations" to their service configuration.
                /// For backwards compatibility, the default name includes the operations collection id, however
                /// overriding users must ensure the name binding is the parent resource, without the operations
                /// collection id.
                /// </summary>
                /// <param name="name">The name of the operation's parent resource.</param>
                public virtual ListRequest List(string name)
                {
                    return new ListRequest(service, name);
                }

                /// <summary>
                /// Lists operations that match the specified filter in the request. If the server doesn't support this
                /// method, it returns UNIMPLEMENTED.NOTE: the name binding allows API services to override the binding
                /// to use different resource name schemes, such as users/*/operations. To override the binding, API
                /// services can add a binding such as "/v1/{name=users/*}/operations" to their service configuration.
                /// For backwards compatibility, the default name includes the operations collection id, however
                /// overriding users must ensure the name binding is the parent resource, without the operations
                /// collection id.
                /// </summary>
                public class ListRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.ListOperationsResponse>
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
                    public override string RestPath => "v2/{+name}/operations";

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
                            Pattern = @"^billingAccounts/[^/]+/locations/[^/]+$",
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
                return new GetRequest(service, name);
            }

            /// <summary>Gets information about a location.</summary>
            public class GetRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.Location>
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
                public override string RestPath => "v2/{+name}";

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
                        Pattern = @"^billingAccounts/[^/]+/locations/[^/]+$",
                    });
                }
            }

            /// <summary>Lists information about the supported locations for this service.</summary>
            /// <param name="name">The resource that owns the locations collection, if applicable.</param>
            public virtual ListRequest List(string name)
            {
                return new ListRequest(service, name);
            }

            /// <summary>Lists information about the supported locations for this service.</summary>
            public class ListRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.ListLocationsResponse>
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
                /// A filter to narrow down results to a preferred subset. The filtering language accepts strings like
                /// "displayName=tokyo", and is documented in more detail in AIP-160 (https://google.aip.dev/160).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// The maximum number of results to return. If not set, the service selects a default.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A page token received from the next_page_token field in the response. Send that page token to
                /// receive the subsequent page.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}/locations";

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
                        Pattern = @"^billingAccounts/[^/]+$",
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

        /// <summary>Gets the Logs resource.</summary>
        public virtual LogsResource Logs { get; }

        /// <summary>The "logs" collection of methods.</summary>
        public class LogsResource
        {
            private const string Resource = "logs";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public LogsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Deletes all the log entries in a log for the _Default Log Bucket. The log reappears if it receives new
            /// entries. Log entries written shortly before the delete operation might not be deleted. Entries received
            /// after the delete operation with a timestamp before the operation will be deleted.
            /// </summary>
            /// <param name="logName">
            /// Required. The resource name of the log to delete: projects/[PROJECT_ID]/logs/[LOG_ID]
            /// organizations/[ORGANIZATION_ID]/logs/[LOG_ID] billingAccounts/[BILLING_ACCOUNT_ID]/logs/[LOG_ID]
            /// folders/[FOLDER_ID]/logs/[LOG_ID][LOG_ID] must be URL-encoded. For example,
            /// "projects/my-project-id/logs/syslog", "organizations/123/logs/cloudaudit.googleapis.com%2Factivity".For
            /// more information about log names, see LogEntry.
            /// </param>
            public virtual DeleteRequest Delete(string logName)
            {
                return new DeleteRequest(service, logName);
            }

            /// <summary>
            /// Deletes all the log entries in a log for the _Default Log Bucket. The log reappears if it receives new
            /// entries. Log entries written shortly before the delete operation might not be deleted. Entries received
            /// after the delete operation with a timestamp before the operation will be deleted.
            /// </summary>
            public class DeleteRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string logName) : base(service)
                {
                    LogName = logName;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the log to delete: projects/[PROJECT_ID]/logs/[LOG_ID]
                /// organizations/[ORGANIZATION_ID]/logs/[LOG_ID] billingAccounts/[BILLING_ACCOUNT_ID]/logs/[LOG_ID]
                /// folders/[FOLDER_ID]/logs/[LOG_ID][LOG_ID] must be URL-encoded. For example,
                /// "projects/my-project-id/logs/syslog",
                /// "organizations/123/logs/cloudaudit.googleapis.com%2Factivity".For more information about log names,
                /// see LogEntry.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("logName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string LogName { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+logName}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("logName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "logName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^billingAccounts/[^/]+/logs/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Lists the logs in projects, organizations, folders, or billing accounts. Only logs that have entries are
            /// listed.
            /// </summary>
            /// <param name="parent">
            /// Required. The resource name that owns the logs: projects/[PROJECT_ID] organizations/[ORGANIZATION_ID]
            /// billingAccounts/[BILLING_ACCOUNT_ID] folders/[FOLDER_ID]
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>
            /// Lists the logs in projects, organizations, folders, or billing accounts. Only logs that have entries are
            /// listed.
            /// </summary>
            public class ListRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.ListLogsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name that owns the logs: projects/[PROJECT_ID]
                /// organizations/[ORGANIZATION_ID] billingAccounts/[BILLING_ACCOUNT_ID] folders/[FOLDER_ID]
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. The maximum number of results to return from this request. Non-positive values are
                /// ignored. The presence of nextPageToken in the response indicates that more results might be
                /// available.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. If present, then retrieve the next batch of results from the preceding call to this
                /// method. pageToken must be the value of nextPageToken from the previous response. The values of other
                /// method parameters should be identical to those in the previous call.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>
                /// Optional. The resource name that owns the logs:
                /// projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]
                /// organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]
                /// billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]
                /// folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]To support legacy
                /// queries, it could also be: projects/[PROJECT_ID] organizations/[ORGANIZATION_ID]
                /// billingAccounts/[BILLING_ACCOUNT_ID] folders/[FOLDER_ID]
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("resourceNames", Google.Apis.Util.RequestParameterType.Query)]
                public virtual Google.Apis.Util.Repeatable<string> ResourceNames { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/logs";

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
                        Pattern = @"^billingAccounts/[^/]+$",
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
                    RequestParameters.Add("resourceNames", new Google.Apis.Discovery.Parameter
                    {
                        Name = "resourceNames",
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
            public class GetRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.Operation>
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
                public override string RestPath => "v2/{+name}";

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
                        Pattern = @"^billingAccounts/[^/]+/operations/[^/]+$",
                    });
                }
            }
        }

        /// <summary>Gets the Sinks resource.</summary>
        public virtual SinksResource Sinks { get; }

        /// <summary>The "sinks" collection of methods.</summary>
        public class SinksResource
        {
            private const string Resource = "sinks";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public SinksResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Creates a sink that exports specified log entries to a destination. The export of newly-ingested log
            /// entries begins immediately, unless the sink's writer_identity is not permitted to write to the
            /// destination. A sink can export log entries only from the resource owning the sink.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The resource in which to create the sink: "projects/[PROJECT_ID]"
            /// "organizations/[ORGANIZATION_ID]" "billingAccounts/[BILLING_ACCOUNT_ID]" "folders/[FOLDER_ID]" Examples:
            /// "projects/my-logging-project", "organizations/123456789".
            /// </param>
            public virtual CreateRequest Create(Google.Apis.Logging.v2.Data.LogSink body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>
            /// Creates a sink that exports specified log entries to a destination. The export of newly-ingested log
            /// entries begins immediately, unless the sink's writer_identity is not permitted to write to the
            /// destination. A sink can export log entries only from the resource owning the sink.
            /// </summary>
            public class CreateRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogSink>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Logging.v2.Data.LogSink body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource in which to create the sink: "projects/[PROJECT_ID]"
                /// "organizations/[ORGANIZATION_ID]" "billingAccounts/[BILLING_ACCOUNT_ID]" "folders/[FOLDER_ID]"
                /// Examples: "projects/my-logging-project", "organizations/123456789".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. Determines the kind of IAM identity returned as writer_identity in the new sink. If this
                /// value is omitted or set to false, and if the sink's parent is a project, then the value returned as
                /// writer_identity is the same group or service account used by Logging before the addition of writer
                /// identities to this API. The sink's destination must be in the same project as the sink itself.If
                /// this field is set to true, or if the sink is owned by a non-project resource such as an
                /// organization, then the value of writer_identity will be a unique service account used only for
                /// exports from the new sink. For more information, see writer_identity in LogSink.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("uniqueWriterIdentity", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> UniqueWriterIdentity { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Logging.v2.Data.LogSink Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/sinks";

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
                        Pattern = @"^billingAccounts/[^/]+$",
                    });
                    RequestParameters.Add("uniqueWriterIdentity", new Google.Apis.Discovery.Parameter
                    {
                        Name = "uniqueWriterIdentity",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Deletes a sink. If the sink has a unique writer_identity, then that service account is also deleted.
            /// </summary>
            /// <param name="sinkName">
            /// Required. The full resource name of the sink to delete, including the parent resource and the sink
            /// identifier: "projects/[PROJECT_ID]/sinks/[SINK_ID]" "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
            /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]" "folders/[FOLDER_ID]/sinks/[SINK_ID]" Example:
            /// "projects/my-project-id/sinks/my-sink-id".
            /// </param>
            public virtual DeleteRequest Delete(string sinkName)
            {
                return new DeleteRequest(service, sinkName);
            }

            /// <summary>
            /// Deletes a sink. If the sink has a unique writer_identity, then that service account is also deleted.
            /// </summary>
            public class DeleteRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string sinkName) : base(service)
                {
                    SinkName = sinkName;
                    InitParameters();
                }

                /// <summary>
                /// Required. The full resource name of the sink to delete, including the parent resource and the sink
                /// identifier: "projects/[PROJECT_ID]/sinks/[SINK_ID]"
                /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
                /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]" "folders/[FOLDER_ID]/sinks/[SINK_ID]"
                /// Example: "projects/my-project-id/sinks/my-sink-id".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("sinkName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string SinkName { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+sinkName}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("sinkName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "sinkName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^billingAccounts/[^/]+/sinks/[^/]+$",
                    });
                }
            }

            /// <summary>Gets a sink.</summary>
            /// <param name="sinkName">
            /// Required. The resource name of the sink: "projects/[PROJECT_ID]/sinks/[SINK_ID]"
            /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]" "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
            /// "folders/[FOLDER_ID]/sinks/[SINK_ID]" Example: "projects/my-project-id/sinks/my-sink-id".
            /// </param>
            public virtual GetRequest Get(string sinkName)
            {
                return new GetRequest(service, sinkName);
            }

            /// <summary>Gets a sink.</summary>
            public class GetRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogSink>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string sinkName) : base(service)
                {
                    SinkName = sinkName;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the sink: "projects/[PROJECT_ID]/sinks/[SINK_ID]"
                /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
                /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]" "folders/[FOLDER_ID]/sinks/[SINK_ID]"
                /// Example: "projects/my-project-id/sinks/my-sink-id".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("sinkName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string SinkName { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+sinkName}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("sinkName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "sinkName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^billingAccounts/[^/]+/sinks/[^/]+$",
                    });
                }
            }

            /// <summary>Lists sinks.</summary>
            /// <param name="parent">
            /// Required. The parent resource whose sinks are to be listed: "projects/[PROJECT_ID]"
            /// "organizations/[ORGANIZATION_ID]" "billingAccounts/[BILLING_ACCOUNT_ID]" "folders/[FOLDER_ID]"
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists sinks.</summary>
            public class ListRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.ListSinksResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent resource whose sinks are to be listed: "projects/[PROJECT_ID]"
                /// "organizations/[ORGANIZATION_ID]" "billingAccounts/[BILLING_ACCOUNT_ID]" "folders/[FOLDER_ID]"
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. The maximum number of results to return from this request. Non-positive values are
                /// ignored. The presence of nextPageToken in the response indicates that more results might be
                /// available.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. If present, then retrieve the next batch of results from the preceding call to this
                /// method. pageToken must be the value of nextPageToken from the previous response. The values of other
                /// method parameters should be identical to those in the previous call.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/sinks";

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
                        Pattern = @"^billingAccounts/[^/]+$",
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
            /// Updates a sink. This method replaces the following fields in the existing sink with values from the new
            /// sink: destination, and filter.The updated sink might also have a new writer_identity; see the
            /// unique_writer_identity field.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="sinkName">
            /// Required. The full resource name of the sink to update, including the parent resource and the sink
            /// identifier: "projects/[PROJECT_ID]/sinks/[SINK_ID]" "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
            /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]" "folders/[FOLDER_ID]/sinks/[SINK_ID]" Example:
            /// "projects/my-project-id/sinks/my-sink-id".
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.Logging.v2.Data.LogSink body, string sinkName)
            {
                return new PatchRequest(service, body, sinkName);
            }

            /// <summary>
            /// Updates a sink. This method replaces the following fields in the existing sink with values from the new
            /// sink: destination, and filter.The updated sink might also have a new writer_identity; see the
            /// unique_writer_identity field.
            /// </summary>
            public class PatchRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogSink>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Logging.v2.Data.LogSink body, string sinkName) : base(service)
                {
                    SinkName = sinkName;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The full resource name of the sink to update, including the parent resource and the sink
                /// identifier: "projects/[PROJECT_ID]/sinks/[SINK_ID]"
                /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
                /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]" "folders/[FOLDER_ID]/sinks/[SINK_ID]"
                /// Example: "projects/my-project-id/sinks/my-sink-id".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("sinkName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string SinkName { get; private set; }

                /// <summary>
                /// Optional. See sinks.create for a description of this field. When updating a sink, the effect of this
                /// field on the value of writer_identity in the updated sink depends on both the old and new values of
                /// this field: If the old and new values of this field are both false or both true, then there is no
                /// change to the sink's writer_identity. If the old value is false and the new value is true, then
                /// writer_identity is changed to a unique service account. It is an error if the old value is true and
                /// the new value is set to false or defaulted to false.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("uniqueWriterIdentity", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> UniqueWriterIdentity { get; set; }

                /// <summary>
                /// Optional. Field mask that specifies the fields in sink that need an update. A sink field will be
                /// overwritten if, and only if, it is in the update mask. name and output only fields cannot be
                /// updated.An empty updateMask is temporarily treated as using the following mask for backwards
                /// compatibility purposes: destination,filter,includeChildren At some point in the future, behavior
                /// will be removed and specifying an empty updateMask will be an error.For a detailed FieldMask
                /// definition, see
                /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#google.protobuf.FieldMaskExample:
                /// updateMask=filter.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Logging.v2.Data.LogSink Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+sinkName}";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("sinkName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "sinkName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^billingAccounts/[^/]+/sinks/[^/]+$",
                    });
                    RequestParameters.Add("uniqueWriterIdentity", new Google.Apis.Discovery.Parameter
                    {
                        Name = "uniqueWriterIdentity",
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
            /// Updates a sink. This method replaces the following fields in the existing sink with values from the new
            /// sink: destination, and filter.The updated sink might also have a new writer_identity; see the
            /// unique_writer_identity field.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="sinkName">
            /// Required. The full resource name of the sink to update, including the parent resource and the sink
            /// identifier: "projects/[PROJECT_ID]/sinks/[SINK_ID]" "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
            /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]" "folders/[FOLDER_ID]/sinks/[SINK_ID]" Example:
            /// "projects/my-project-id/sinks/my-sink-id".
            /// </param>
            public virtual UpdateRequest Update(Google.Apis.Logging.v2.Data.LogSink body, string sinkName)
            {
                return new UpdateRequest(service, body, sinkName);
            }

            /// <summary>
            /// Updates a sink. This method replaces the following fields in the existing sink with values from the new
            /// sink: destination, and filter.The updated sink might also have a new writer_identity; see the
            /// unique_writer_identity field.
            /// </summary>
            public class UpdateRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogSink>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Logging.v2.Data.LogSink body, string sinkName) : base(service)
                {
                    SinkName = sinkName;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The full resource name of the sink to update, including the parent resource and the sink
                /// identifier: "projects/[PROJECT_ID]/sinks/[SINK_ID]"
                /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
                /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]" "folders/[FOLDER_ID]/sinks/[SINK_ID]"
                /// Example: "projects/my-project-id/sinks/my-sink-id".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("sinkName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string SinkName { get; private set; }

                /// <summary>
                /// Optional. See sinks.create for a description of this field. When updating a sink, the effect of this
                /// field on the value of writer_identity in the updated sink depends on both the old and new values of
                /// this field: If the old and new values of this field are both false or both true, then there is no
                /// change to the sink's writer_identity. If the old value is false and the new value is true, then
                /// writer_identity is changed to a unique service account. It is an error if the old value is true and
                /// the new value is set to false or defaulted to false.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("uniqueWriterIdentity", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> UniqueWriterIdentity { get; set; }

                /// <summary>
                /// Optional. Field mask that specifies the fields in sink that need an update. A sink field will be
                /// overwritten if, and only if, it is in the update mask. name and output only fields cannot be
                /// updated.An empty updateMask is temporarily treated as using the following mask for backwards
                /// compatibility purposes: destination,filter,includeChildren At some point in the future, behavior
                /// will be removed and specifying an empty updateMask will be an error.For a detailed FieldMask
                /// definition, see
                /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#google.protobuf.FieldMaskExample:
                /// updateMask=filter.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Logging.v2.Data.LogSink Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "update";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+sinkName}";

                /// <summary>Initializes Update parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("sinkName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "sinkName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^billingAccounts/[^/]+/sinks/[^/]+$",
                    });
                    RequestParameters.Add("uniqueWriterIdentity", new Google.Apis.Discovery.Parameter
                    {
                        Name = "uniqueWriterIdentity",
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
    }

    /// <summary>The "entries" collection of methods.</summary>
    public class EntriesResource
    {
        private const string Resource = "entries";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public EntriesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Copies a set of log entries from a logging bucket to a Cloud Storage bucket.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual CopyRequest Copy(Google.Apis.Logging.v2.Data.CopyLogEntriesRequest body)
        {
            return new CopyRequest(service, body);
        }

        /// <summary>Copies a set of log entries from a logging bucket to a Cloud Storage bucket.</summary>
        public class CopyRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.Operation>
        {
            /// <summary>Constructs a new Copy request.</summary>
            public CopyRequest(Google.Apis.Services.IClientService service, Google.Apis.Logging.v2.Data.CopyLogEntriesRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Logging.v2.Data.CopyLogEntriesRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "copy";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/entries:copy";

            /// <summary>Initializes Copy parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Lists log entries. Use this method to retrieve log entries that originated from a
        /// project/folder/organization/billing account. For ways to export log entries, see Exporting Logs
        /// (https://cloud.google.com/logging/docs/export).
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual ListRequest List(Google.Apis.Logging.v2.Data.ListLogEntriesRequest body)
        {
            return new ListRequest(service, body);
        }

        /// <summary>
        /// Lists log entries. Use this method to retrieve log entries that originated from a
        /// project/folder/organization/billing account. For ways to export log entries, see Exporting Logs
        /// (https://cloud.google.com/logging/docs/export).
        /// </summary>
        public class ListRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.ListLogEntriesResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, Google.Apis.Logging.v2.Data.ListLogEntriesRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Logging.v2.Data.ListLogEntriesRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/entries:list";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Streaming read of log entries as they are ingested. Until the stream is terminated, it will continue reading
        /// logs.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual TailRequest Tail(Google.Apis.Logging.v2.Data.TailLogEntriesRequest body)
        {
            return new TailRequest(service, body);
        }

        /// <summary>
        /// Streaming read of log entries as they are ingested. Until the stream is terminated, it will continue reading
        /// logs.
        /// </summary>
        public class TailRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.TailLogEntriesResponse>
        {
            /// <summary>Constructs a new Tail request.</summary>
            public TailRequest(Google.Apis.Services.IClientService service, Google.Apis.Logging.v2.Data.TailLogEntriesRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Logging.v2.Data.TailLogEntriesRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "tail";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/entries:tail";

            /// <summary>Initializes Tail parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Writes log entries to Logging. This API method is the only way to send log entries to Logging. This method
        /// is used, directly or indirectly, by the Logging agent (fluentd) and all logging libraries configured to use
        /// Logging. A single request may contain log entries for a maximum of 1000 different resources (projects,
        /// organizations, billing accounts or folders)
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual WriteRequest Write(Google.Apis.Logging.v2.Data.WriteLogEntriesRequest body)
        {
            return new WriteRequest(service, body);
        }

        /// <summary>
        /// Writes log entries to Logging. This API method is the only way to send log entries to Logging. This method
        /// is used, directly or indirectly, by the Logging agent (fluentd) and all logging libraries configured to use
        /// Logging. A single request may contain log entries for a maximum of 1000 different resources (projects,
        /// organizations, billing accounts or folders)
        /// </summary>
        public class WriteRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.WriteLogEntriesResponse>
        {
            /// <summary>Constructs a new Write request.</summary>
            public WriteRequest(Google.Apis.Services.IClientService service, Google.Apis.Logging.v2.Data.WriteLogEntriesRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Logging.v2.Data.WriteLogEntriesRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "write";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/entries:write";

            /// <summary>Initializes Write parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }

    /// <summary>The "exclusions" collection of methods.</summary>
    public class ExclusionsResource
    {
        private const string Resource = "exclusions";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ExclusionsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Creates a new exclusion in a specified parent resource. Only log entries belonging to that resource can be
        /// excluded. You can have up to 10 exclusions in a resource.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="parent">
        /// Required. The parent resource in which to create the exclusion: "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]" "billingAccounts/[BILLING_ACCOUNT_ID]" "folders/[FOLDER_ID]" Examples:
        /// "projects/my-logging-project", "organizations/123456789".
        /// </param>
        public virtual CreateRequest Create(Google.Apis.Logging.v2.Data.LogExclusion body, string parent)
        {
            return new CreateRequest(service, body, parent);
        }

        /// <summary>
        /// Creates a new exclusion in a specified parent resource. Only log entries belonging to that resource can be
        /// excluded. You can have up to 10 exclusions in a resource.
        /// </summary>
        public class CreateRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogExclusion>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Logging.v2.Data.LogExclusion body, string parent) : base(service)
            {
                Parent = parent;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. The parent resource in which to create the exclusion: "projects/[PROJECT_ID]"
            /// "organizations/[ORGANIZATION_ID]" "billingAccounts/[BILLING_ACCOUNT_ID]" "folders/[FOLDER_ID]" Examples:
            /// "projects/my-logging-project", "organizations/123456789".
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Logging.v2.Data.LogExclusion Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/{+parent}/exclusions";

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
                    Pattern = @"^[^/]+/[^/]+$",
                });
            }
        }

        /// <summary>Deletes an exclusion.</summary>
        /// <param name="name">
        /// Required. The resource name of an existing exclusion to delete:
        /// "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]" Example:
        /// "projects/my-project-id/exclusions/my-exclusion-id".
        /// </param>
        public virtual DeleteRequest Delete(string name)
        {
            return new DeleteRequest(service, name);
        }

        /// <summary>Deletes an exclusion.</summary>
        public class DeleteRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.Empty>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The resource name of an existing exclusion to delete:
            /// "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
            /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
            /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
            /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]" Example:
            /// "projects/my-project-id/exclusions/my-exclusion-id".
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/{+name}";

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
                    Pattern = @"^[^/]+/[^/]+/exclusions/[^/]+$",
                });
            }
        }

        /// <summary>Gets the description of an exclusion.</summary>
        /// <param name="name">
        /// Required. The resource name of an existing exclusion: "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]" Example:
        /// "projects/my-project-id/exclusions/my-exclusion-id".
        /// </param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(service, name);
        }

        /// <summary>Gets the description of an exclusion.</summary>
        public class GetRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogExclusion>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The resource name of an existing exclusion: "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
            /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
            /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
            /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]" Example:
            /// "projects/my-project-id/exclusions/my-exclusion-id".
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/{+name}";

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
                    Pattern = @"^[^/]+/[^/]+/exclusions/[^/]+$",
                });
            }
        }

        /// <summary>Lists all the exclusions in a parent resource.</summary>
        /// <param name="parent">
        /// Required. The parent resource whose exclusions are to be listed. "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]" "billingAccounts/[BILLING_ACCOUNT_ID]" "folders/[FOLDER_ID]"
        /// </param>
        public virtual ListRequest List(string parent)
        {
            return new ListRequest(service, parent);
        }

        /// <summary>Lists all the exclusions in a parent resource.</summary>
        public class ListRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.ListExclusionsResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
            {
                Parent = parent;
                InitParameters();
            }

            /// <summary>
            /// Required. The parent resource whose exclusions are to be listed. "projects/[PROJECT_ID]"
            /// "organizations/[ORGANIZATION_ID]" "billingAccounts/[BILLING_ACCOUNT_ID]" "folders/[FOLDER_ID]"
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>
            /// Optional. The maximum number of results to return from this request. Non-positive values are ignored.
            /// The presence of nextPageToken in the response indicates that more results might be available.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// Optional. If present, then retrieve the next batch of results from the preceding call to this method.
            /// pageToken must be the value of nextPageToken from the previous response. The values of other method
            /// parameters should be identical to those in the previous call.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/{+parent}/exclusions";

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
                    Pattern = @"^[^/]+/[^/]+$",
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

        /// <summary>Changes one or more properties of an existing exclusion.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// Required. The resource name of the exclusion to update: "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]" Example:
        /// "projects/my-project-id/exclusions/my-exclusion-id".
        /// </param>
        public virtual PatchRequest Patch(Google.Apis.Logging.v2.Data.LogExclusion body, string name)
        {
            return new PatchRequest(service, body, name);
        }

        /// <summary>Changes one or more properties of an existing exclusion.</summary>
        public class PatchRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogExclusion>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Logging.v2.Data.LogExclusion body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. The resource name of the exclusion to update:
            /// "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
            /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
            /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
            /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]" Example:
            /// "projects/my-project-id/exclusions/my-exclusion-id".
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>
            /// Required. A non-empty list of fields to change in the existing exclusion. New values for the fields are
            /// taken from the corresponding fields in the LogExclusion included in this request. Fields not mentioned
            /// in update_mask are not changed and are ignored in the request.For example, to change the filter and
            /// description of an exclusion, specify an update_mask of "filter,description".
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Logging.v2.Data.LogExclusion Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/{+name}";

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
                    Pattern = @"^[^/]+/[^/]+/exclusions/[^/]+$",
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

    /// <summary>The "folders" collection of methods.</summary>
    public class FoldersResource
    {
        private const string Resource = "folders";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public FoldersResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Exclusions = new ExclusionsResource(service);
            Locations = new LocationsResource(service);
            Logs = new LogsResource(service);
            Sinks = new SinksResource(service);
        }

        /// <summary>Gets the Exclusions resource.</summary>
        public virtual ExclusionsResource Exclusions { get; }

        /// <summary>The "exclusions" collection of methods.</summary>
        public class ExclusionsResource
        {
            private const string Resource = "exclusions";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ExclusionsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Creates a new exclusion in a specified parent resource. Only log entries belonging to that resource can
            /// be excluded. You can have up to 10 exclusions in a resource.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The parent resource in which to create the exclusion: "projects/[PROJECT_ID]"
            /// "organizations/[ORGANIZATION_ID]" "billingAccounts/[BILLING_ACCOUNT_ID]" "folders/[FOLDER_ID]" Examples:
            /// "projects/my-logging-project", "organizations/123456789".
            /// </param>
            public virtual CreateRequest Create(Google.Apis.Logging.v2.Data.LogExclusion body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>
            /// Creates a new exclusion in a specified parent resource. Only log entries belonging to that resource can
            /// be excluded. You can have up to 10 exclusions in a resource.
            /// </summary>
            public class CreateRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogExclusion>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Logging.v2.Data.LogExclusion body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent resource in which to create the exclusion: "projects/[PROJECT_ID]"
                /// "organizations/[ORGANIZATION_ID]" "billingAccounts/[BILLING_ACCOUNT_ID]" "folders/[FOLDER_ID]"
                /// Examples: "projects/my-logging-project", "organizations/123456789".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Logging.v2.Data.LogExclusion Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/exclusions";

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
                        Pattern = @"^folders/[^/]+$",
                    });
                }
            }

            /// <summary>Deletes an exclusion.</summary>
            /// <param name="name">
            /// Required. The resource name of an existing exclusion to delete:
            /// "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
            /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
            /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
            /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]" Example:
            /// "projects/my-project-id/exclusions/my-exclusion-id".
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>Deletes an exclusion.</summary>
            public class DeleteRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of an existing exclusion to delete:
                /// "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
                /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
                /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
                /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]" Example:
                /// "projects/my-project-id/exclusions/my-exclusion-id".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}";

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
                        Pattern = @"^folders/[^/]+/exclusions/[^/]+$",
                    });
                }
            }

            /// <summary>Gets the description of an exclusion.</summary>
            /// <param name="name">
            /// Required. The resource name of an existing exclusion: "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
            /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
            /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
            /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]" Example:
            /// "projects/my-project-id/exclusions/my-exclusion-id".
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets the description of an exclusion.</summary>
            public class GetRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogExclusion>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of an existing exclusion:
                /// "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
                /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
                /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
                /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]" Example:
                /// "projects/my-project-id/exclusions/my-exclusion-id".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}";

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
                        Pattern = @"^folders/[^/]+/exclusions/[^/]+$",
                    });
                }
            }

            /// <summary>Lists all the exclusions in a parent resource.</summary>
            /// <param name="parent">
            /// Required. The parent resource whose exclusions are to be listed. "projects/[PROJECT_ID]"
            /// "organizations/[ORGANIZATION_ID]" "billingAccounts/[BILLING_ACCOUNT_ID]" "folders/[FOLDER_ID]"
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists all the exclusions in a parent resource.</summary>
            public class ListRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.ListExclusionsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent resource whose exclusions are to be listed. "projects/[PROJECT_ID]"
                /// "organizations/[ORGANIZATION_ID]" "billingAccounts/[BILLING_ACCOUNT_ID]" "folders/[FOLDER_ID]"
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. The maximum number of results to return from this request. Non-positive values are
                /// ignored. The presence of nextPageToken in the response indicates that more results might be
                /// available.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. If present, then retrieve the next batch of results from the preceding call to this
                /// method. pageToken must be the value of nextPageToken from the previous response. The values of other
                /// method parameters should be identical to those in the previous call.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/exclusions";

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
                        Pattern = @"^folders/[^/]+$",
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

            /// <summary>Changes one or more properties of an existing exclusion.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The resource name of the exclusion to update:
            /// "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
            /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
            /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
            /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]" Example:
            /// "projects/my-project-id/exclusions/my-exclusion-id".
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.Logging.v2.Data.LogExclusion body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>Changes one or more properties of an existing exclusion.</summary>
            public class PatchRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogExclusion>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Logging.v2.Data.LogExclusion body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the exclusion to update:
                /// "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
                /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
                /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
                /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]" Example:
                /// "projects/my-project-id/exclusions/my-exclusion-id".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Required. A non-empty list of fields to change in the existing exclusion. New values for the fields
                /// are taken from the corresponding fields in the LogExclusion included in this request. Fields not
                /// mentioned in update_mask are not changed and are ignored in the request.For example, to change the
                /// filter and description of an exclusion, specify an update_mask of "filter,description".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Logging.v2.Data.LogExclusion Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}";

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
                        Pattern = @"^folders/[^/]+/exclusions/[^/]+$",
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
                Buckets = new BucketsResource(service);
                Operations = new OperationsResource(service);
            }

            /// <summary>Gets the Buckets resource.</summary>
            public virtual BucketsResource Buckets { get; }

            /// <summary>The "buckets" collection of methods.</summary>
            public class BucketsResource
            {
                private const string Resource = "buckets";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public BucketsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Views = new ViewsResource(service);
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

                    /// <summary>
                    /// Creates a view over logs in a bucket. A bucket may contain a maximum of 50 views.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The bucket in which to create the view
                    /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]" Example:
                    /// "projects/my-logging-project/locations/my-location/buckets/my-bucket"
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.Logging.v2.Data.LogView body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>
                    /// Creates a view over logs in a bucket. A bucket may contain a maximum of 50 views.
                    /// </summary>
                    public class CreateRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogView>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Logging.v2.Data.LogView body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The bucket in which to create the view
                        /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]" Example:
                        /// "projects/my-logging-project/locations/my-location/buckets/my-bucket"
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Required. The id to use for this view.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("viewId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string ViewId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Logging.v2.Data.LogView Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+parent}/views";

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
                                Pattern = @"^folders/[^/]+/locations/[^/]+/buckets/[^/]+$",
                            });
                            RequestParameters.Add("viewId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "viewId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Deletes a view from a bucket.</summary>
                    /// <param name="name">
                    /// Required. The full resource name of the view to delete:
                    /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]" Example:
                    /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id/views/my-view-id".
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>Deletes a view from a bucket.</summary>
                    public class DeleteRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The full resource name of the view to delete:
                        /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]" Example:
                        /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id/views/my-view-id".
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+name}";

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
                                Pattern = @"^folders/[^/]+/locations/[^/]+/buckets/[^/]+/views/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets a view.</summary>
                    /// <param name="name">
                    /// Required. The resource name of the policy:
                    /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]" Example:
                    /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id/views/my-view-id".
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Gets a view.</summary>
                    public class GetRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogView>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the policy:
                        /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]" Example:
                        /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id/views/my-view-id".
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+name}";

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
                                Pattern = @"^folders/[^/]+/locations/[^/]+/buckets/[^/]+/views/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists views on a bucket.</summary>
                    /// <param name="parent">
                    /// Required. The bucket whose views are to be listed:
                    /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Lists views on a bucket.</summary>
                    public class ListRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.ListViewsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The bucket whose views are to be listed:
                        /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. The maximum number of results to return from this request. Non-positive values are
                        /// ignored. The presence of nextPageToken in the response indicates that more results might be
                        /// available.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. If present, then retrieve the next batch of results from the preceding call to
                        /// this method. pageToken must be the value of nextPageToken from the previous response. The
                        /// values of other method parameters should be identical to those in the previous call.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+parent}/views";

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
                                Pattern = @"^folders/[^/]+/locations/[^/]+/buckets/[^/]+$",
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
                    /// Updates a view. This method replaces the following fields in the existing view with values from
                    /// the new view: filter.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The full resource name of the view to update
                    /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]" Example:
                    /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id/views/my-view-id".
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.Logging.v2.Data.LogView body, string name)
                    {
                        return new PatchRequest(service, body, name);
                    }

                    /// <summary>
                    /// Updates a view. This method replaces the following fields in the existing view with values from
                    /// the new view: filter.
                    /// </summary>
                    public class PatchRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogView>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Logging.v2.Data.LogView body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The full resource name of the view to update
                        /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]" Example:
                        /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id/views/my-view-id".
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. Field mask that specifies the fields in view that need an update. A field will be
                        /// overwritten if, and only if, it is in the update mask. name and output only fields cannot be
                        /// updated.For a detailed FieldMask definition, see
                        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#google.protobuf.FieldMaskExample:
                        /// updateMask=filter.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Logging.v2.Data.LogView Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "patch";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PATCH";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+name}";

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
                                Pattern = @"^folders/[^/]+/locations/[^/]+/buckets/[^/]+/views/[^/]+$",
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
                /// Creates a bucket that can be used to store log entries. Once a bucket has been created, the region
                /// cannot be changed.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The resource in which to create the bucket:
                /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]" Example:
                /// "projects/my-logging-project/locations/global"
                /// </param>
                public virtual CreateRequest Create(Google.Apis.Logging.v2.Data.LogBucket body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>
                /// Creates a bucket that can be used to store log entries. Once a bucket has been created, the region
                /// cannot be changed.
                /// </summary>
                public class CreateRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogBucket>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Logging.v2.Data.LogBucket body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource in which to create the bucket:
                    /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]" Example:
                    /// "projects/my-logging-project/locations/global"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. A client-assigned identifier such as "my-bucket". Identifiers are limited to 100
                    /// characters and can include only letters, digits, underscores, hyphens, and periods.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("bucketId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string BucketId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Logging.v2.Data.LogBucket Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/buckets";

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
                            Pattern = @"^folders/[^/]+/locations/[^/]+$",
                        });
                        RequestParameters.Add("bucketId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "bucketId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Deletes a bucket. Moves the bucket to the DELETE_REQUESTED state. After 7 days, the bucket will be
                /// purged and all logs in the bucket will be permanently deleted.
                /// </summary>
                /// <param name="name">
                /// Required. The full resource name of the bucket to delete.
                /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]" Example:
                /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id".
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>
                /// Deletes a bucket. Moves the bucket to the DELETE_REQUESTED state. After 7 days, the bucket will be
                /// purged and all logs in the bucket will be permanently deleted.
                /// </summary>
                public class DeleteRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The full resource name of the bucket to delete.
                    /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                    /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                    /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                    /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]" Example:
                    /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^folders/[^/]+/locations/[^/]+/buckets/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets a bucket.</summary>
                /// <param name="name">
                /// Required. The resource name of the bucket:
                /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]" Example:
                /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id".
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Gets a bucket.</summary>
                public class GetRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogBucket>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the bucket:
                    /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                    /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                    /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                    /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]" Example:
                    /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^folders/[^/]+/locations/[^/]+/buckets/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists buckets.</summary>
                /// <param name="parent">
                /// Required. The parent resource whose buckets are to be listed:
                /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]"
                /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]"
                /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]"
                /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]" Note: The locations portion of the resource must be
                /// specified, but supplying the character - in place of LOCATION_ID will return all buckets.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists buckets.</summary>
                public class ListRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.ListBucketsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource whose buckets are to be listed:
                    /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]"
                    /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]"
                    /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]"
                    /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]" Note: The locations portion of the resource must
                    /// be specified, but supplying the character - in place of LOCATION_ID will return all buckets.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. The maximum number of results to return from this request. Non-positive values are
                    /// ignored. The presence of nextPageToken in the response indicates that more results might be
                    /// available.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. If present, then retrieve the next batch of results from the preceding call to this
                    /// method. pageToken must be the value of nextPageToken from the previous response. The values of
                    /// other method parameters should be identical to those in the previous call.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/buckets";

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
                            Pattern = @"^folders/[^/]+/locations/[^/]+$",
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
                /// Updates a bucket. This method replaces the following fields in the existing bucket with values from
                /// the new bucket: retention_periodIf the retention period is decreased and the bucket is locked,
                /// FAILED_PRECONDITION will be returned.If the bucket has a LifecycleState of DELETE_REQUESTED,
                /// FAILED_PRECONDITION will be returned.A buckets region may not be modified after it is created.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The full resource name of the bucket to update.
                /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]" Example:
                /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id". Also requires permission
                /// "resourcemanager.projects.updateLiens" to set the locked property
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.Logging.v2.Data.LogBucket body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>
                /// Updates a bucket. This method replaces the following fields in the existing bucket with values from
                /// the new bucket: retention_periodIf the retention period is decreased and the bucket is locked,
                /// FAILED_PRECONDITION will be returned.If the bucket has a LifecycleState of DELETE_REQUESTED,
                /// FAILED_PRECONDITION will be returned.A buckets region may not be modified after it is created.
                /// </summary>
                public class PatchRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogBucket>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Logging.v2.Data.LogBucket body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The full resource name of the bucket to update.
                    /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                    /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                    /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                    /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]" Example:
                    /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id". Also requires permission
                    /// "resourcemanager.projects.updateLiens" to set the locked property
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Required. Field mask that specifies the fields in bucket that need an update. A bucket field
                    /// will be overwritten if, and only if, it is in the update mask. name and output only fields
                    /// cannot be updated.For a detailed FieldMask definition, see
                    /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#google.protobuf.FieldMaskExample:
                    /// updateMask=retention_days.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Logging.v2.Data.LogBucket Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^folders/[^/]+/locations/[^/]+/buckets/[^/]+$",
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
                /// Undeletes a bucket. A bucket that has been deleted may be undeleted within the grace period of 7
                /// days.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The full resource name of the bucket to undelete.
                /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]" Example:
                /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id".
                /// </param>
                public virtual UndeleteRequest Undelete(Google.Apis.Logging.v2.Data.UndeleteBucketRequest body, string name)
                {
                    return new UndeleteRequest(service, body, name);
                }

                /// <summary>
                /// Undeletes a bucket. A bucket that has been deleted may be undeleted within the grace period of 7
                /// days.
                /// </summary>
                public class UndeleteRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.Empty>
                {
                    /// <summary>Constructs a new Undelete request.</summary>
                    public UndeleteRequest(Google.Apis.Services.IClientService service, Google.Apis.Logging.v2.Data.UndeleteBucketRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The full resource name of the bucket to undelete.
                    /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                    /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                    /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                    /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]" Example:
                    /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Logging.v2.Data.UndeleteBucketRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "undelete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}:undelete";

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
                            Pattern = @"^folders/[^/]+/locations/[^/]+/buckets/[^/]+$",
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
                /// returns google.rpc.Code.UNIMPLEMENTED. Clients can use Operations.GetOperation or other methods to
                /// check whether the cancellation succeeded or whether the operation completed despite cancellation. On
                /// successful cancellation, the operation is not deleted; instead, it becomes an operation with an
                /// Operation.error value with a google.rpc.Status.code of 1, corresponding to Code.CANCELLED.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">The name of the operation resource to be cancelled.</param>
                public virtual CancelRequest Cancel(Google.Apis.Logging.v2.Data.CancelOperationRequest body, string name)
                {
                    return new CancelRequest(service, body, name);
                }

                /// <summary>
                /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to
                /// cancel the operation, but success is not guaranteed. If the server doesn't support this method, it
                /// returns google.rpc.Code.UNIMPLEMENTED. Clients can use Operations.GetOperation or other methods to
                /// check whether the cancellation succeeded or whether the operation completed despite cancellation. On
                /// successful cancellation, the operation is not deleted; instead, it becomes an operation with an
                /// Operation.error value with a google.rpc.Status.code of 1, corresponding to Code.CANCELLED.
                /// </summary>
                public class CancelRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.Empty>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.Logging.v2.Data.CancelOperationRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to be cancelled.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Logging.v2.Data.CancelOperationRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "cancel";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}:cancel";

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
                            Pattern = @"^folders/[^/]+/locations/[^/]+/operations/[^/]+$",
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
                public class GetRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.Operation>
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
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^folders/[^/]+/locations/[^/]+/operations/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists operations that match the specified filter in the request. If the server doesn't support this
                /// method, it returns UNIMPLEMENTED.NOTE: the name binding allows API services to override the binding
                /// to use different resource name schemes, such as users/*/operations. To override the binding, API
                /// services can add a binding such as "/v1/{name=users/*}/operations" to their service configuration.
                /// For backwards compatibility, the default name includes the operations collection id, however
                /// overriding users must ensure the name binding is the parent resource, without the operations
                /// collection id.
                /// </summary>
                /// <param name="name">The name of the operation's parent resource.</param>
                public virtual ListRequest List(string name)
                {
                    return new ListRequest(service, name);
                }

                /// <summary>
                /// Lists operations that match the specified filter in the request. If the server doesn't support this
                /// method, it returns UNIMPLEMENTED.NOTE: the name binding allows API services to override the binding
                /// to use different resource name schemes, such as users/*/operations. To override the binding, API
                /// services can add a binding such as "/v1/{name=users/*}/operations" to their service configuration.
                /// For backwards compatibility, the default name includes the operations collection id, however
                /// overriding users must ensure the name binding is the parent resource, without the operations
                /// collection id.
                /// </summary>
                public class ListRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.ListOperationsResponse>
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
                    public override string RestPath => "v2/{+name}/operations";

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
                            Pattern = @"^folders/[^/]+/locations/[^/]+$",
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
                return new GetRequest(service, name);
            }

            /// <summary>Gets information about a location.</summary>
            public class GetRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.Location>
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
                public override string RestPath => "v2/{+name}";

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
                        Pattern = @"^folders/[^/]+/locations/[^/]+$",
                    });
                }
            }

            /// <summary>Lists information about the supported locations for this service.</summary>
            /// <param name="name">The resource that owns the locations collection, if applicable.</param>
            public virtual ListRequest List(string name)
            {
                return new ListRequest(service, name);
            }

            /// <summary>Lists information about the supported locations for this service.</summary>
            public class ListRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.ListLocationsResponse>
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
                /// A filter to narrow down results to a preferred subset. The filtering language accepts strings like
                /// "displayName=tokyo", and is documented in more detail in AIP-160 (https://google.aip.dev/160).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// The maximum number of results to return. If not set, the service selects a default.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A page token received from the next_page_token field in the response. Send that page token to
                /// receive the subsequent page.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}/locations";

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
                        Pattern = @"^folders/[^/]+$",
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

        /// <summary>Gets the Logs resource.</summary>
        public virtual LogsResource Logs { get; }

        /// <summary>The "logs" collection of methods.</summary>
        public class LogsResource
        {
            private const string Resource = "logs";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public LogsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Deletes all the log entries in a log for the _Default Log Bucket. The log reappears if it receives new
            /// entries. Log entries written shortly before the delete operation might not be deleted. Entries received
            /// after the delete operation with a timestamp before the operation will be deleted.
            /// </summary>
            /// <param name="logName">
            /// Required. The resource name of the log to delete: projects/[PROJECT_ID]/logs/[LOG_ID]
            /// organizations/[ORGANIZATION_ID]/logs/[LOG_ID] billingAccounts/[BILLING_ACCOUNT_ID]/logs/[LOG_ID]
            /// folders/[FOLDER_ID]/logs/[LOG_ID][LOG_ID] must be URL-encoded. For example,
            /// "projects/my-project-id/logs/syslog", "organizations/123/logs/cloudaudit.googleapis.com%2Factivity".For
            /// more information about log names, see LogEntry.
            /// </param>
            public virtual DeleteRequest Delete(string logName)
            {
                return new DeleteRequest(service, logName);
            }

            /// <summary>
            /// Deletes all the log entries in a log for the _Default Log Bucket. The log reappears if it receives new
            /// entries. Log entries written shortly before the delete operation might not be deleted. Entries received
            /// after the delete operation with a timestamp before the operation will be deleted.
            /// </summary>
            public class DeleteRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string logName) : base(service)
                {
                    LogName = logName;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the log to delete: projects/[PROJECT_ID]/logs/[LOG_ID]
                /// organizations/[ORGANIZATION_ID]/logs/[LOG_ID] billingAccounts/[BILLING_ACCOUNT_ID]/logs/[LOG_ID]
                /// folders/[FOLDER_ID]/logs/[LOG_ID][LOG_ID] must be URL-encoded. For example,
                /// "projects/my-project-id/logs/syslog",
                /// "organizations/123/logs/cloudaudit.googleapis.com%2Factivity".For more information about log names,
                /// see LogEntry.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("logName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string LogName { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+logName}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("logName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "logName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^folders/[^/]+/logs/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Lists the logs in projects, organizations, folders, or billing accounts. Only logs that have entries are
            /// listed.
            /// </summary>
            /// <param name="parent">
            /// Required. The resource name that owns the logs: projects/[PROJECT_ID] organizations/[ORGANIZATION_ID]
            /// billingAccounts/[BILLING_ACCOUNT_ID] folders/[FOLDER_ID]
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>
            /// Lists the logs in projects, organizations, folders, or billing accounts. Only logs that have entries are
            /// listed.
            /// </summary>
            public class ListRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.ListLogsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name that owns the logs: projects/[PROJECT_ID]
                /// organizations/[ORGANIZATION_ID] billingAccounts/[BILLING_ACCOUNT_ID] folders/[FOLDER_ID]
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. The maximum number of results to return from this request. Non-positive values are
                /// ignored. The presence of nextPageToken in the response indicates that more results might be
                /// available.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. If present, then retrieve the next batch of results from the preceding call to this
                /// method. pageToken must be the value of nextPageToken from the previous response. The values of other
                /// method parameters should be identical to those in the previous call.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>
                /// Optional. The resource name that owns the logs:
                /// projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]
                /// organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]
                /// billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]
                /// folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]To support legacy
                /// queries, it could also be: projects/[PROJECT_ID] organizations/[ORGANIZATION_ID]
                /// billingAccounts/[BILLING_ACCOUNT_ID] folders/[FOLDER_ID]
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("resourceNames", Google.Apis.Util.RequestParameterType.Query)]
                public virtual Google.Apis.Util.Repeatable<string> ResourceNames { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/logs";

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
                        Pattern = @"^folders/[^/]+$",
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
                    RequestParameters.Add("resourceNames", new Google.Apis.Discovery.Parameter
                    {
                        Name = "resourceNames",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the Sinks resource.</summary>
        public virtual SinksResource Sinks { get; }

        /// <summary>The "sinks" collection of methods.</summary>
        public class SinksResource
        {
            private const string Resource = "sinks";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public SinksResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Creates a sink that exports specified log entries to a destination. The export of newly-ingested log
            /// entries begins immediately, unless the sink's writer_identity is not permitted to write to the
            /// destination. A sink can export log entries only from the resource owning the sink.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The resource in which to create the sink: "projects/[PROJECT_ID]"
            /// "organizations/[ORGANIZATION_ID]" "billingAccounts/[BILLING_ACCOUNT_ID]" "folders/[FOLDER_ID]" Examples:
            /// "projects/my-logging-project", "organizations/123456789".
            /// </param>
            public virtual CreateRequest Create(Google.Apis.Logging.v2.Data.LogSink body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>
            /// Creates a sink that exports specified log entries to a destination. The export of newly-ingested log
            /// entries begins immediately, unless the sink's writer_identity is not permitted to write to the
            /// destination. A sink can export log entries only from the resource owning the sink.
            /// </summary>
            public class CreateRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogSink>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Logging.v2.Data.LogSink body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource in which to create the sink: "projects/[PROJECT_ID]"
                /// "organizations/[ORGANIZATION_ID]" "billingAccounts/[BILLING_ACCOUNT_ID]" "folders/[FOLDER_ID]"
                /// Examples: "projects/my-logging-project", "organizations/123456789".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. Determines the kind of IAM identity returned as writer_identity in the new sink. If this
                /// value is omitted or set to false, and if the sink's parent is a project, then the value returned as
                /// writer_identity is the same group or service account used by Logging before the addition of writer
                /// identities to this API. The sink's destination must be in the same project as the sink itself.If
                /// this field is set to true, or if the sink is owned by a non-project resource such as an
                /// organization, then the value of writer_identity will be a unique service account used only for
                /// exports from the new sink. For more information, see writer_identity in LogSink.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("uniqueWriterIdentity", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> UniqueWriterIdentity { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Logging.v2.Data.LogSink Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/sinks";

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
                        Pattern = @"^folders/[^/]+$",
                    });
                    RequestParameters.Add("uniqueWriterIdentity", new Google.Apis.Discovery.Parameter
                    {
                        Name = "uniqueWriterIdentity",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Deletes a sink. If the sink has a unique writer_identity, then that service account is also deleted.
            /// </summary>
            /// <param name="sinkName">
            /// Required. The full resource name of the sink to delete, including the parent resource and the sink
            /// identifier: "projects/[PROJECT_ID]/sinks/[SINK_ID]" "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
            /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]" "folders/[FOLDER_ID]/sinks/[SINK_ID]" Example:
            /// "projects/my-project-id/sinks/my-sink-id".
            /// </param>
            public virtual DeleteRequest Delete(string sinkName)
            {
                return new DeleteRequest(service, sinkName);
            }

            /// <summary>
            /// Deletes a sink. If the sink has a unique writer_identity, then that service account is also deleted.
            /// </summary>
            public class DeleteRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string sinkName) : base(service)
                {
                    SinkName = sinkName;
                    InitParameters();
                }

                /// <summary>
                /// Required. The full resource name of the sink to delete, including the parent resource and the sink
                /// identifier: "projects/[PROJECT_ID]/sinks/[SINK_ID]"
                /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
                /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]" "folders/[FOLDER_ID]/sinks/[SINK_ID]"
                /// Example: "projects/my-project-id/sinks/my-sink-id".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("sinkName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string SinkName { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+sinkName}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("sinkName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "sinkName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^folders/[^/]+/sinks/[^/]+$",
                    });
                }
            }

            /// <summary>Gets a sink.</summary>
            /// <param name="sinkName">
            /// Required. The resource name of the sink: "projects/[PROJECT_ID]/sinks/[SINK_ID]"
            /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]" "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
            /// "folders/[FOLDER_ID]/sinks/[SINK_ID]" Example: "projects/my-project-id/sinks/my-sink-id".
            /// </param>
            public virtual GetRequest Get(string sinkName)
            {
                return new GetRequest(service, sinkName);
            }

            /// <summary>Gets a sink.</summary>
            public class GetRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogSink>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string sinkName) : base(service)
                {
                    SinkName = sinkName;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the sink: "projects/[PROJECT_ID]/sinks/[SINK_ID]"
                /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
                /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]" "folders/[FOLDER_ID]/sinks/[SINK_ID]"
                /// Example: "projects/my-project-id/sinks/my-sink-id".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("sinkName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string SinkName { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+sinkName}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("sinkName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "sinkName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^folders/[^/]+/sinks/[^/]+$",
                    });
                }
            }

            /// <summary>Lists sinks.</summary>
            /// <param name="parent">
            /// Required. The parent resource whose sinks are to be listed: "projects/[PROJECT_ID]"
            /// "organizations/[ORGANIZATION_ID]" "billingAccounts/[BILLING_ACCOUNT_ID]" "folders/[FOLDER_ID]"
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists sinks.</summary>
            public class ListRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.ListSinksResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent resource whose sinks are to be listed: "projects/[PROJECT_ID]"
                /// "organizations/[ORGANIZATION_ID]" "billingAccounts/[BILLING_ACCOUNT_ID]" "folders/[FOLDER_ID]"
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. The maximum number of results to return from this request. Non-positive values are
                /// ignored. The presence of nextPageToken in the response indicates that more results might be
                /// available.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. If present, then retrieve the next batch of results from the preceding call to this
                /// method. pageToken must be the value of nextPageToken from the previous response. The values of other
                /// method parameters should be identical to those in the previous call.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/sinks";

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
                        Pattern = @"^folders/[^/]+$",
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
            /// Updates a sink. This method replaces the following fields in the existing sink with values from the new
            /// sink: destination, and filter.The updated sink might also have a new writer_identity; see the
            /// unique_writer_identity field.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="sinkName">
            /// Required. The full resource name of the sink to update, including the parent resource and the sink
            /// identifier: "projects/[PROJECT_ID]/sinks/[SINK_ID]" "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
            /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]" "folders/[FOLDER_ID]/sinks/[SINK_ID]" Example:
            /// "projects/my-project-id/sinks/my-sink-id".
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.Logging.v2.Data.LogSink body, string sinkName)
            {
                return new PatchRequest(service, body, sinkName);
            }

            /// <summary>
            /// Updates a sink. This method replaces the following fields in the existing sink with values from the new
            /// sink: destination, and filter.The updated sink might also have a new writer_identity; see the
            /// unique_writer_identity field.
            /// </summary>
            public class PatchRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogSink>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Logging.v2.Data.LogSink body, string sinkName) : base(service)
                {
                    SinkName = sinkName;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The full resource name of the sink to update, including the parent resource and the sink
                /// identifier: "projects/[PROJECT_ID]/sinks/[SINK_ID]"
                /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
                /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]" "folders/[FOLDER_ID]/sinks/[SINK_ID]"
                /// Example: "projects/my-project-id/sinks/my-sink-id".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("sinkName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string SinkName { get; private set; }

                /// <summary>
                /// Optional. See sinks.create for a description of this field. When updating a sink, the effect of this
                /// field on the value of writer_identity in the updated sink depends on both the old and new values of
                /// this field: If the old and new values of this field are both false or both true, then there is no
                /// change to the sink's writer_identity. If the old value is false and the new value is true, then
                /// writer_identity is changed to a unique service account. It is an error if the old value is true and
                /// the new value is set to false or defaulted to false.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("uniqueWriterIdentity", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> UniqueWriterIdentity { get; set; }

                /// <summary>
                /// Optional. Field mask that specifies the fields in sink that need an update. A sink field will be
                /// overwritten if, and only if, it is in the update mask. name and output only fields cannot be
                /// updated.An empty updateMask is temporarily treated as using the following mask for backwards
                /// compatibility purposes: destination,filter,includeChildren At some point in the future, behavior
                /// will be removed and specifying an empty updateMask will be an error.For a detailed FieldMask
                /// definition, see
                /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#google.protobuf.FieldMaskExample:
                /// updateMask=filter.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Logging.v2.Data.LogSink Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+sinkName}";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("sinkName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "sinkName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^folders/[^/]+/sinks/[^/]+$",
                    });
                    RequestParameters.Add("uniqueWriterIdentity", new Google.Apis.Discovery.Parameter
                    {
                        Name = "uniqueWriterIdentity",
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
            /// Updates a sink. This method replaces the following fields in the existing sink with values from the new
            /// sink: destination, and filter.The updated sink might also have a new writer_identity; see the
            /// unique_writer_identity field.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="sinkName">
            /// Required. The full resource name of the sink to update, including the parent resource and the sink
            /// identifier: "projects/[PROJECT_ID]/sinks/[SINK_ID]" "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
            /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]" "folders/[FOLDER_ID]/sinks/[SINK_ID]" Example:
            /// "projects/my-project-id/sinks/my-sink-id".
            /// </param>
            public virtual UpdateRequest Update(Google.Apis.Logging.v2.Data.LogSink body, string sinkName)
            {
                return new UpdateRequest(service, body, sinkName);
            }

            /// <summary>
            /// Updates a sink. This method replaces the following fields in the existing sink with values from the new
            /// sink: destination, and filter.The updated sink might also have a new writer_identity; see the
            /// unique_writer_identity field.
            /// </summary>
            public class UpdateRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogSink>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Logging.v2.Data.LogSink body, string sinkName) : base(service)
                {
                    SinkName = sinkName;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The full resource name of the sink to update, including the parent resource and the sink
                /// identifier: "projects/[PROJECT_ID]/sinks/[SINK_ID]"
                /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
                /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]" "folders/[FOLDER_ID]/sinks/[SINK_ID]"
                /// Example: "projects/my-project-id/sinks/my-sink-id".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("sinkName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string SinkName { get; private set; }

                /// <summary>
                /// Optional. See sinks.create for a description of this field. When updating a sink, the effect of this
                /// field on the value of writer_identity in the updated sink depends on both the old and new values of
                /// this field: If the old and new values of this field are both false or both true, then there is no
                /// change to the sink's writer_identity. If the old value is false and the new value is true, then
                /// writer_identity is changed to a unique service account. It is an error if the old value is true and
                /// the new value is set to false or defaulted to false.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("uniqueWriterIdentity", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> UniqueWriterIdentity { get; set; }

                /// <summary>
                /// Optional. Field mask that specifies the fields in sink that need an update. A sink field will be
                /// overwritten if, and only if, it is in the update mask. name and output only fields cannot be
                /// updated.An empty updateMask is temporarily treated as using the following mask for backwards
                /// compatibility purposes: destination,filter,includeChildren At some point in the future, behavior
                /// will be removed and specifying an empty updateMask will be an error.For a detailed FieldMask
                /// definition, see
                /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#google.protobuf.FieldMaskExample:
                /// updateMask=filter.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Logging.v2.Data.LogSink Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "update";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+sinkName}";

                /// <summary>Initializes Update parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("sinkName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "sinkName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^folders/[^/]+/sinks/[^/]+$",
                    });
                    RequestParameters.Add("uniqueWriterIdentity", new Google.Apis.Discovery.Parameter
                    {
                        Name = "uniqueWriterIdentity",
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
    }

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
            Buckets = new BucketsResource(service);
            Operations = new OperationsResource(service);
        }

        /// <summary>Gets the Buckets resource.</summary>
        public virtual BucketsResource Buckets { get; }

        /// <summary>The "buckets" collection of methods.</summary>
        public class BucketsResource
        {
            private const string Resource = "buckets";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public BucketsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Views = new ViewsResource(service);
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

                /// <summary>Creates a view over logs in a bucket. A bucket may contain a maximum of 50 views.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The bucket in which to create the view
                /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]" Example:
                /// "projects/my-logging-project/locations/my-location/buckets/my-bucket"
                /// </param>
                public virtual CreateRequest Create(Google.Apis.Logging.v2.Data.LogView body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Creates a view over logs in a bucket. A bucket may contain a maximum of 50 views.</summary>
                public class CreateRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogView>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Logging.v2.Data.LogView body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The bucket in which to create the view
                    /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]" Example:
                    /// "projects/my-logging-project/locations/my-location/buckets/my-bucket"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Required. The id to use for this view.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("viewId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ViewId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Logging.v2.Data.LogView Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/views";

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
                            Pattern = @"^[^/]+/[^/]+/locations/[^/]+/buckets/[^/]+$",
                        });
                        RequestParameters.Add("viewId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "viewId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a view from a bucket.</summary>
                /// <param name="name">
                /// Required. The full resource name of the view to delete:
                /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]" Example:
                /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id/views/my-view-id".
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>Deletes a view from a bucket.</summary>
                public class DeleteRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The full resource name of the view to delete:
                    /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]" Example:
                    /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id/views/my-view-id".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^[^/]+/[^/]+/locations/[^/]+/buckets/[^/]+/views/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets a view.</summary>
                /// <param name="name">
                /// Required. The resource name of the policy:
                /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]" Example:
                /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id/views/my-view-id".
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Gets a view.</summary>
                public class GetRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogView>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the policy:
                    /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]" Example:
                    /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id/views/my-view-id".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^[^/]+/[^/]+/locations/[^/]+/buckets/[^/]+/views/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists views on a bucket.</summary>
                /// <param name="parent">
                /// Required. The bucket whose views are to be listed:
                /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists views on a bucket.</summary>
                public class ListRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.ListViewsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The bucket whose views are to be listed:
                    /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. The maximum number of results to return from this request. Non-positive values are
                    /// ignored. The presence of nextPageToken in the response indicates that more results might be
                    /// available.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. If present, then retrieve the next batch of results from the preceding call to this
                    /// method. pageToken must be the value of nextPageToken from the previous response. The values of
                    /// other method parameters should be identical to those in the previous call.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/views";

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
                            Pattern = @"^[^/]+/[^/]+/locations/[^/]+/buckets/[^/]+$",
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
                /// Updates a view. This method replaces the following fields in the existing view with values from the
                /// new view: filter.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The full resource name of the view to update
                /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]" Example:
                /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id/views/my-view-id".
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.Logging.v2.Data.LogView body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>
                /// Updates a view. This method replaces the following fields in the existing view with values from the
                /// new view: filter.
                /// </summary>
                public class PatchRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogView>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Logging.v2.Data.LogView body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The full resource name of the view to update
                    /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]" Example:
                    /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id/views/my-view-id".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. Field mask that specifies the fields in view that need an update. A field will be
                    /// overwritten if, and only if, it is in the update mask. name and output only fields cannot be
                    /// updated.For a detailed FieldMask definition, see
                    /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#google.protobuf.FieldMaskExample:
                    /// updateMask=filter.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Logging.v2.Data.LogView Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^[^/]+/[^/]+/locations/[^/]+/buckets/[^/]+/views/[^/]+$",
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
            /// Creates a bucket that can be used to store log entries. Once a bucket has been created, the region
            /// cannot be changed.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The resource in which to create the bucket: "projects/[PROJECT_ID]/locations/[LOCATION_ID]"
            /// Example: "projects/my-logging-project/locations/global"
            /// </param>
            public virtual CreateRequest Create(Google.Apis.Logging.v2.Data.LogBucket body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>
            /// Creates a bucket that can be used to store log entries. Once a bucket has been created, the region
            /// cannot be changed.
            /// </summary>
            public class CreateRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogBucket>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Logging.v2.Data.LogBucket body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource in which to create the bucket:
                /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]" Example:
                /// "projects/my-logging-project/locations/global"
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Required. A client-assigned identifier such as "my-bucket". Identifiers are limited to 100
                /// characters and can include only letters, digits, underscores, hyphens, and periods.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("bucketId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string BucketId { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Logging.v2.Data.LogBucket Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/buckets";

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
                        Pattern = @"^[^/]+/[^/]+/locations/[^/]+$",
                    });
                    RequestParameters.Add("bucketId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "bucketId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Deletes a bucket. Moves the bucket to the DELETE_REQUESTED state. After 7 days, the bucket will be
            /// purged and all logs in the bucket will be permanently deleted.
            /// </summary>
            /// <param name="name">
            /// Required. The full resource name of the bucket to delete.
            /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
            /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
            /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
            /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]" Example:
            /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id".
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>
            /// Deletes a bucket. Moves the bucket to the DELETE_REQUESTED state. After 7 days, the bucket will be
            /// purged and all logs in the bucket will be permanently deleted.
            /// </summary>
            public class DeleteRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The full resource name of the bucket to delete.
                /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]" Example:
                /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}";

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
                        Pattern = @"^[^/]+/[^/]+/locations/[^/]+/buckets/[^/]+$",
                    });
                }
            }

            /// <summary>Gets a bucket.</summary>
            /// <param name="name">
            /// Required. The resource name of the bucket:
            /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
            /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
            /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
            /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]" Example:
            /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id".
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets a bucket.</summary>
            public class GetRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogBucket>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the bucket:
                /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]" Example:
                /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}";

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
                        Pattern = @"^[^/]+/[^/]+/locations/[^/]+/buckets/[^/]+$",
                    });
                }
            }

            /// <summary>Lists buckets.</summary>
            /// <param name="parent">
            /// Required. The parent resource whose buckets are to be listed:
            /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]"
            /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]"
            /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]"
            /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]" Note: The locations portion of the resource must be
            /// specified, but supplying the character - in place of LOCATION_ID will return all buckets.
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists buckets.</summary>
            public class ListRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.ListBucketsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent resource whose buckets are to be listed:
                /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]"
                /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]"
                /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]"
                /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]" Note: The locations portion of the resource must be
                /// specified, but supplying the character - in place of LOCATION_ID will return all buckets.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. The maximum number of results to return from this request. Non-positive values are
                /// ignored. The presence of nextPageToken in the response indicates that more results might be
                /// available.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. If present, then retrieve the next batch of results from the preceding call to this
                /// method. pageToken must be the value of nextPageToken from the previous response. The values of other
                /// method parameters should be identical to those in the previous call.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/buckets";

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
                        Pattern = @"^[^/]+/[^/]+/locations/[^/]+$",
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
            /// Updates a bucket. This method replaces the following fields in the existing bucket with values from the
            /// new bucket: retention_periodIf the retention period is decreased and the bucket is locked,
            /// FAILED_PRECONDITION will be returned.If the bucket has a LifecycleState of DELETE_REQUESTED,
            /// FAILED_PRECONDITION will be returned.A buckets region may not be modified after it is created.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The full resource name of the bucket to update.
            /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
            /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
            /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
            /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]" Example:
            /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id". Also requires permission
            /// "resourcemanager.projects.updateLiens" to set the locked property
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.Logging.v2.Data.LogBucket body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>
            /// Updates a bucket. This method replaces the following fields in the existing bucket with values from the
            /// new bucket: retention_periodIf the retention period is decreased and the bucket is locked,
            /// FAILED_PRECONDITION will be returned.If the bucket has a LifecycleState of DELETE_REQUESTED,
            /// FAILED_PRECONDITION will be returned.A buckets region may not be modified after it is created.
            /// </summary>
            public class PatchRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogBucket>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Logging.v2.Data.LogBucket body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The full resource name of the bucket to update.
                /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]" Example:
                /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id". Also requires permission
                /// "resourcemanager.projects.updateLiens" to set the locked property
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Required. Field mask that specifies the fields in bucket that need an update. A bucket field will be
                /// overwritten if, and only if, it is in the update mask. name and output only fields cannot be
                /// updated.For a detailed FieldMask definition, see
                /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#google.protobuf.FieldMaskExample:
                /// updateMask=retention_days.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Logging.v2.Data.LogBucket Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}";

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
                        Pattern = @"^[^/]+/[^/]+/locations/[^/]+/buckets/[^/]+$",
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
            /// Undeletes a bucket. A bucket that has been deleted may be undeleted within the grace period of 7 days.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The full resource name of the bucket to undelete.
            /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
            /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
            /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
            /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]" Example:
            /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id".
            /// </param>
            public virtual UndeleteRequest Undelete(Google.Apis.Logging.v2.Data.UndeleteBucketRequest body, string name)
            {
                return new UndeleteRequest(service, body, name);
            }

            /// <summary>
            /// Undeletes a bucket. A bucket that has been deleted may be undeleted within the grace period of 7 days.
            /// </summary>
            public class UndeleteRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.Empty>
            {
                /// <summary>Constructs a new Undelete request.</summary>
                public UndeleteRequest(Google.Apis.Services.IClientService service, Google.Apis.Logging.v2.Data.UndeleteBucketRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The full resource name of the bucket to undelete.
                /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]" Example:
                /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Logging.v2.Data.UndeleteBucketRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "undelete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}:undelete";

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
                        Pattern = @"^[^/]+/[^/]+/locations/[^/]+/buckets/[^/]+$",
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
            /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to cancel
            /// the operation, but success is not guaranteed. If the server doesn't support this method, it returns
            /// google.rpc.Code.UNIMPLEMENTED. Clients can use Operations.GetOperation or other methods to check whether
            /// the cancellation succeeded or whether the operation completed despite cancellation. On successful
            /// cancellation, the operation is not deleted; instead, it becomes an operation with an Operation.error
            /// value with a google.rpc.Status.code of 1, corresponding to Code.CANCELLED.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">The name of the operation resource to be cancelled.</param>
            public virtual CancelRequest Cancel(Google.Apis.Logging.v2.Data.CancelOperationRequest body, string name)
            {
                return new CancelRequest(service, body, name);
            }

            /// <summary>
            /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to cancel
            /// the operation, but success is not guaranteed. If the server doesn't support this method, it returns
            /// google.rpc.Code.UNIMPLEMENTED. Clients can use Operations.GetOperation or other methods to check whether
            /// the cancellation succeeded or whether the operation completed despite cancellation. On successful
            /// cancellation, the operation is not deleted; instead, it becomes an operation with an Operation.error
            /// value with a google.rpc.Status.code of 1, corresponding to Code.CANCELLED.
            /// </summary>
            public class CancelRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.Empty>
            {
                /// <summary>Constructs a new Cancel request.</summary>
                public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.Logging.v2.Data.CancelOperationRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>The name of the operation resource to be cancelled.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Logging.v2.Data.CancelOperationRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "cancel";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}:cancel";

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
                        Pattern = @"^[^/]+/[^/]+/locations/[^/]+/operations/[^/]+$",
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
            public class GetRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.Operation>
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
                public override string RestPath => "v2/{+name}";

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
                        Pattern = @"^[^/]+/[^/]+/locations/[^/]+/operations/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Lists operations that match the specified filter in the request. If the server doesn't support this
            /// method, it returns UNIMPLEMENTED.NOTE: the name binding allows API services to override the binding to
            /// use different resource name schemes, such as users/*/operations. To override the binding, API services
            /// can add a binding such as "/v1/{name=users/*}/operations" to their service configuration. For backwards
            /// compatibility, the default name includes the operations collection id, however overriding users must
            /// ensure the name binding is the parent resource, without the operations collection id.
            /// </summary>
            /// <param name="name">The name of the operation's parent resource.</param>
            public virtual ListRequest List(string name)
            {
                return new ListRequest(service, name);
            }

            /// <summary>
            /// Lists operations that match the specified filter in the request. If the server doesn't support this
            /// method, it returns UNIMPLEMENTED.NOTE: the name binding allows API services to override the binding to
            /// use different resource name schemes, such as users/*/operations. To override the binding, API services
            /// can add a binding such as "/v1/{name=users/*}/operations" to their service configuration. For backwards
            /// compatibility, the default name includes the operations collection id, however overriding users must
            /// ensure the name binding is the parent resource, without the operations collection id.
            /// </summary>
            public class ListRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.ListOperationsResponse>
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
                public override string RestPath => "v2/{+name}/operations";

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
                        Pattern = @"^[^/]+/[^/]+/locations/[^/]+$",
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
            return new GetRequest(service, name);
        }

        /// <summary>Gets information about a location.</summary>
        public class GetRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.Location>
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
            public override string RestPath => "v2/{+name}";

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
                    Pattern = @"^[^/]+/[^/]+/locations/[^/]+$",
                });
            }
        }

        /// <summary>Lists information about the supported locations for this service.</summary>
        /// <param name="name">The resource that owns the locations collection, if applicable.</param>
        public virtual ListRequest List(string name)
        {
            return new ListRequest(service, name);
        }

        /// <summary>Lists information about the supported locations for this service.</summary>
        public class ListRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.ListLocationsResponse>
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
            /// A filter to narrow down results to a preferred subset. The filtering language accepts strings like
            /// "displayName=tokyo", and is documented in more detail in AIP-160 (https://google.aip.dev/160).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>The maximum number of results to return. If not set, the service selects a default.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// A page token received from the next_page_token field in the response. Send that page token to receive
            /// the subsequent page.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/{+name}/locations";

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
                    Pattern = @"^[^/]+/[^/]+$",
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

    /// <summary>The "logs" collection of methods.</summary>
    public class LogsResource
    {
        private const string Resource = "logs";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public LogsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Deletes all the log entries in a log for the _Default Log Bucket. The log reappears if it receives new
        /// entries. Log entries written shortly before the delete operation might not be deleted. Entries received
        /// after the delete operation with a timestamp before the operation will be deleted.
        /// </summary>
        /// <param name="logName">
        /// Required. The resource name of the log to delete: projects/[PROJECT_ID]/logs/[LOG_ID]
        /// organizations/[ORGANIZATION_ID]/logs/[LOG_ID] billingAccounts/[BILLING_ACCOUNT_ID]/logs/[LOG_ID]
        /// folders/[FOLDER_ID]/logs/[LOG_ID][LOG_ID] must be URL-encoded. For example,
        /// "projects/my-project-id/logs/syslog", "organizations/123/logs/cloudaudit.googleapis.com%2Factivity".For more
        /// information about log names, see LogEntry.
        /// </param>
        public virtual DeleteRequest Delete(string logName)
        {
            return new DeleteRequest(service, logName);
        }

        /// <summary>
        /// Deletes all the log entries in a log for the _Default Log Bucket. The log reappears if it receives new
        /// entries. Log entries written shortly before the delete operation might not be deleted. Entries received
        /// after the delete operation with a timestamp before the operation will be deleted.
        /// </summary>
        public class DeleteRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.Empty>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string logName) : base(service)
            {
                LogName = logName;
                InitParameters();
            }

            /// <summary>
            /// Required. The resource name of the log to delete: projects/[PROJECT_ID]/logs/[LOG_ID]
            /// organizations/[ORGANIZATION_ID]/logs/[LOG_ID] billingAccounts/[BILLING_ACCOUNT_ID]/logs/[LOG_ID]
            /// folders/[FOLDER_ID]/logs/[LOG_ID][LOG_ID] must be URL-encoded. For example,
            /// "projects/my-project-id/logs/syslog", "organizations/123/logs/cloudaudit.googleapis.com%2Factivity".For
            /// more information about log names, see LogEntry.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("logName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string LogName { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/{+logName}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("logName", new Google.Apis.Discovery.Parameter
                {
                    Name = "logName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+/[^/]+/logs/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Lists the logs in projects, organizations, folders, or billing accounts. Only logs that have entries are
        /// listed.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name that owns the logs: projects/[PROJECT_ID] organizations/[ORGANIZATION_ID]
        /// billingAccounts/[BILLING_ACCOUNT_ID] folders/[FOLDER_ID]
        /// </param>
        public virtual ListRequest List(string parent)
        {
            return new ListRequest(service, parent);
        }

        /// <summary>
        /// Lists the logs in projects, organizations, folders, or billing accounts. Only logs that have entries are
        /// listed.
        /// </summary>
        public class ListRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.ListLogsResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
            {
                Parent = parent;
                InitParameters();
            }

            /// <summary>
            /// Required. The resource name that owns the logs: projects/[PROJECT_ID] organizations/[ORGANIZATION_ID]
            /// billingAccounts/[BILLING_ACCOUNT_ID] folders/[FOLDER_ID]
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>
            /// Optional. The maximum number of results to return from this request. Non-positive values are ignored.
            /// The presence of nextPageToken in the response indicates that more results might be available.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// Optional. If present, then retrieve the next batch of results from the preceding call to this method.
            /// pageToken must be the value of nextPageToken from the previous response. The values of other method
            /// parameters should be identical to those in the previous call.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// Optional. The resource name that owns the logs:
            /// projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]
            /// organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]
            /// billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]
            /// folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]To support legacy
            /// queries, it could also be: projects/[PROJECT_ID] organizations/[ORGANIZATION_ID]
            /// billingAccounts/[BILLING_ACCOUNT_ID] folders/[FOLDER_ID]
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceNames", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> ResourceNames { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/{+parent}/logs";

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
                    Pattern = @"^[^/]+/[^/]+$",
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
                RequestParameters.Add("resourceNames", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceNames",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "monitoredResourceDescriptors" collection of methods.</summary>
    public class MonitoredResourceDescriptorsResource
    {
        private const string Resource = "monitoredResourceDescriptors";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public MonitoredResourceDescriptorsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Lists the descriptors for monitored resource types used by Logging.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>Lists the descriptors for monitored resource types used by Logging.</summary>
        public class ListRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.ListMonitoredResourceDescriptorsResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Optional. The maximum number of results to return from this request. Non-positive values are ignored.
            /// The presence of nextPageToken in the response indicates that more results might be available.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// Optional. If present, then retrieve the next batch of results from the preceding call to this method.
            /// pageToken must be the value of nextPageToken from the previous response. The values of other method
            /// parameters should be identical to those in the previous call.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/monitoredResourceDescriptors";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
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

    /// <summary>The "organizations" collection of methods.</summary>
    public class OrganizationsResource
    {
        private const string Resource = "organizations";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public OrganizationsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Exclusions = new ExclusionsResource(service);
            Locations = new LocationsResource(service);
            Logs = new LogsResource(service);
            Sinks = new SinksResource(service);
        }

        /// <summary>Gets the Exclusions resource.</summary>
        public virtual ExclusionsResource Exclusions { get; }

        /// <summary>The "exclusions" collection of methods.</summary>
        public class ExclusionsResource
        {
            private const string Resource = "exclusions";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ExclusionsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Creates a new exclusion in a specified parent resource. Only log entries belonging to that resource can
            /// be excluded. You can have up to 10 exclusions in a resource.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The parent resource in which to create the exclusion: "projects/[PROJECT_ID]"
            /// "organizations/[ORGANIZATION_ID]" "billingAccounts/[BILLING_ACCOUNT_ID]" "folders/[FOLDER_ID]" Examples:
            /// "projects/my-logging-project", "organizations/123456789".
            /// </param>
            public virtual CreateRequest Create(Google.Apis.Logging.v2.Data.LogExclusion body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>
            /// Creates a new exclusion in a specified parent resource. Only log entries belonging to that resource can
            /// be excluded. You can have up to 10 exclusions in a resource.
            /// </summary>
            public class CreateRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogExclusion>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Logging.v2.Data.LogExclusion body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent resource in which to create the exclusion: "projects/[PROJECT_ID]"
                /// "organizations/[ORGANIZATION_ID]" "billingAccounts/[BILLING_ACCOUNT_ID]" "folders/[FOLDER_ID]"
                /// Examples: "projects/my-logging-project", "organizations/123456789".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Logging.v2.Data.LogExclusion Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/exclusions";

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
                        Pattern = @"^organizations/[^/]+$",
                    });
                }
            }

            /// <summary>Deletes an exclusion.</summary>
            /// <param name="name">
            /// Required. The resource name of an existing exclusion to delete:
            /// "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
            /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
            /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
            /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]" Example:
            /// "projects/my-project-id/exclusions/my-exclusion-id".
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>Deletes an exclusion.</summary>
            public class DeleteRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of an existing exclusion to delete:
                /// "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
                /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
                /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
                /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]" Example:
                /// "projects/my-project-id/exclusions/my-exclusion-id".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}";

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
                        Pattern = @"^organizations/[^/]+/exclusions/[^/]+$",
                    });
                }
            }

            /// <summary>Gets the description of an exclusion.</summary>
            /// <param name="name">
            /// Required. The resource name of an existing exclusion: "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
            /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
            /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
            /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]" Example:
            /// "projects/my-project-id/exclusions/my-exclusion-id".
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets the description of an exclusion.</summary>
            public class GetRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogExclusion>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of an existing exclusion:
                /// "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
                /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
                /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
                /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]" Example:
                /// "projects/my-project-id/exclusions/my-exclusion-id".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}";

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
                        Pattern = @"^organizations/[^/]+/exclusions/[^/]+$",
                    });
                }
            }

            /// <summary>Lists all the exclusions in a parent resource.</summary>
            /// <param name="parent">
            /// Required. The parent resource whose exclusions are to be listed. "projects/[PROJECT_ID]"
            /// "organizations/[ORGANIZATION_ID]" "billingAccounts/[BILLING_ACCOUNT_ID]" "folders/[FOLDER_ID]"
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists all the exclusions in a parent resource.</summary>
            public class ListRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.ListExclusionsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent resource whose exclusions are to be listed. "projects/[PROJECT_ID]"
                /// "organizations/[ORGANIZATION_ID]" "billingAccounts/[BILLING_ACCOUNT_ID]" "folders/[FOLDER_ID]"
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. The maximum number of results to return from this request. Non-positive values are
                /// ignored. The presence of nextPageToken in the response indicates that more results might be
                /// available.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. If present, then retrieve the next batch of results from the preceding call to this
                /// method. pageToken must be the value of nextPageToken from the previous response. The values of other
                /// method parameters should be identical to those in the previous call.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/exclusions";

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
                        Pattern = @"^organizations/[^/]+$",
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

            /// <summary>Changes one or more properties of an existing exclusion.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The resource name of the exclusion to update:
            /// "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
            /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
            /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
            /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]" Example:
            /// "projects/my-project-id/exclusions/my-exclusion-id".
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.Logging.v2.Data.LogExclusion body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>Changes one or more properties of an existing exclusion.</summary>
            public class PatchRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogExclusion>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Logging.v2.Data.LogExclusion body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the exclusion to update:
                /// "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
                /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
                /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
                /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]" Example:
                /// "projects/my-project-id/exclusions/my-exclusion-id".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Required. A non-empty list of fields to change in the existing exclusion. New values for the fields
                /// are taken from the corresponding fields in the LogExclusion included in this request. Fields not
                /// mentioned in update_mask are not changed and are ignored in the request.For example, to change the
                /// filter and description of an exclusion, specify an update_mask of "filter,description".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Logging.v2.Data.LogExclusion Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}";

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
                        Pattern = @"^organizations/[^/]+/exclusions/[^/]+$",
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
                Buckets = new BucketsResource(service);
                Operations = new OperationsResource(service);
            }

            /// <summary>Gets the Buckets resource.</summary>
            public virtual BucketsResource Buckets { get; }

            /// <summary>The "buckets" collection of methods.</summary>
            public class BucketsResource
            {
                private const string Resource = "buckets";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public BucketsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Views = new ViewsResource(service);
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

                    /// <summary>
                    /// Creates a view over logs in a bucket. A bucket may contain a maximum of 50 views.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The bucket in which to create the view
                    /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]" Example:
                    /// "projects/my-logging-project/locations/my-location/buckets/my-bucket"
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.Logging.v2.Data.LogView body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>
                    /// Creates a view over logs in a bucket. A bucket may contain a maximum of 50 views.
                    /// </summary>
                    public class CreateRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogView>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Logging.v2.Data.LogView body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The bucket in which to create the view
                        /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]" Example:
                        /// "projects/my-logging-project/locations/my-location/buckets/my-bucket"
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Required. The id to use for this view.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("viewId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string ViewId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Logging.v2.Data.LogView Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+parent}/views";

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
                                Pattern = @"^organizations/[^/]+/locations/[^/]+/buckets/[^/]+$",
                            });
                            RequestParameters.Add("viewId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "viewId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Deletes a view from a bucket.</summary>
                    /// <param name="name">
                    /// Required. The full resource name of the view to delete:
                    /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]" Example:
                    /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id/views/my-view-id".
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>Deletes a view from a bucket.</summary>
                    public class DeleteRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The full resource name of the view to delete:
                        /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]" Example:
                        /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id/views/my-view-id".
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+name}";

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
                                Pattern = @"^organizations/[^/]+/locations/[^/]+/buckets/[^/]+/views/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets a view.</summary>
                    /// <param name="name">
                    /// Required. The resource name of the policy:
                    /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]" Example:
                    /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id/views/my-view-id".
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Gets a view.</summary>
                    public class GetRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogView>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the policy:
                        /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]" Example:
                        /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id/views/my-view-id".
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+name}";

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
                                Pattern = @"^organizations/[^/]+/locations/[^/]+/buckets/[^/]+/views/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists views on a bucket.</summary>
                    /// <param name="parent">
                    /// Required. The bucket whose views are to be listed:
                    /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Lists views on a bucket.</summary>
                    public class ListRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.ListViewsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The bucket whose views are to be listed:
                        /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. The maximum number of results to return from this request. Non-positive values are
                        /// ignored. The presence of nextPageToken in the response indicates that more results might be
                        /// available.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. If present, then retrieve the next batch of results from the preceding call to
                        /// this method. pageToken must be the value of nextPageToken from the previous response. The
                        /// values of other method parameters should be identical to those in the previous call.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+parent}/views";

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
                                Pattern = @"^organizations/[^/]+/locations/[^/]+/buckets/[^/]+$",
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
                    /// Updates a view. This method replaces the following fields in the existing view with values from
                    /// the new view: filter.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The full resource name of the view to update
                    /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]" Example:
                    /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id/views/my-view-id".
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.Logging.v2.Data.LogView body, string name)
                    {
                        return new PatchRequest(service, body, name);
                    }

                    /// <summary>
                    /// Updates a view. This method replaces the following fields in the existing view with values from
                    /// the new view: filter.
                    /// </summary>
                    public class PatchRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogView>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Logging.v2.Data.LogView body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The full resource name of the view to update
                        /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]" Example:
                        /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id/views/my-view-id".
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. Field mask that specifies the fields in view that need an update. A field will be
                        /// overwritten if, and only if, it is in the update mask. name and output only fields cannot be
                        /// updated.For a detailed FieldMask definition, see
                        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#google.protobuf.FieldMaskExample:
                        /// updateMask=filter.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Logging.v2.Data.LogView Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "patch";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PATCH";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+name}";

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
                                Pattern = @"^organizations/[^/]+/locations/[^/]+/buckets/[^/]+/views/[^/]+$",
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
                /// Creates a bucket that can be used to store log entries. Once a bucket has been created, the region
                /// cannot be changed.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The resource in which to create the bucket:
                /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]" Example:
                /// "projects/my-logging-project/locations/global"
                /// </param>
                public virtual CreateRequest Create(Google.Apis.Logging.v2.Data.LogBucket body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>
                /// Creates a bucket that can be used to store log entries. Once a bucket has been created, the region
                /// cannot be changed.
                /// </summary>
                public class CreateRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogBucket>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Logging.v2.Data.LogBucket body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource in which to create the bucket:
                    /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]" Example:
                    /// "projects/my-logging-project/locations/global"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. A client-assigned identifier such as "my-bucket". Identifiers are limited to 100
                    /// characters and can include only letters, digits, underscores, hyphens, and periods.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("bucketId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string BucketId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Logging.v2.Data.LogBucket Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/buckets";

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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+$",
                        });
                        RequestParameters.Add("bucketId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "bucketId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Deletes a bucket. Moves the bucket to the DELETE_REQUESTED state. After 7 days, the bucket will be
                /// purged and all logs in the bucket will be permanently deleted.
                /// </summary>
                /// <param name="name">
                /// Required. The full resource name of the bucket to delete.
                /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]" Example:
                /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id".
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>
                /// Deletes a bucket. Moves the bucket to the DELETE_REQUESTED state. After 7 days, the bucket will be
                /// purged and all logs in the bucket will be permanently deleted.
                /// </summary>
                public class DeleteRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The full resource name of the bucket to delete.
                    /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                    /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                    /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                    /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]" Example:
                    /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+/buckets/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets a bucket.</summary>
                /// <param name="name">
                /// Required. The resource name of the bucket:
                /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]" Example:
                /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id".
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Gets a bucket.</summary>
                public class GetRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogBucket>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the bucket:
                    /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                    /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                    /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                    /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]" Example:
                    /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+/buckets/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists buckets.</summary>
                /// <param name="parent">
                /// Required. The parent resource whose buckets are to be listed:
                /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]"
                /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]"
                /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]"
                /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]" Note: The locations portion of the resource must be
                /// specified, but supplying the character - in place of LOCATION_ID will return all buckets.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists buckets.</summary>
                public class ListRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.ListBucketsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource whose buckets are to be listed:
                    /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]"
                    /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]"
                    /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]"
                    /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]" Note: The locations portion of the resource must
                    /// be specified, but supplying the character - in place of LOCATION_ID will return all buckets.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. The maximum number of results to return from this request. Non-positive values are
                    /// ignored. The presence of nextPageToken in the response indicates that more results might be
                    /// available.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. If present, then retrieve the next batch of results from the preceding call to this
                    /// method. pageToken must be the value of nextPageToken from the previous response. The values of
                    /// other method parameters should be identical to those in the previous call.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/buckets";

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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+$",
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
                /// Updates a bucket. This method replaces the following fields in the existing bucket with values from
                /// the new bucket: retention_periodIf the retention period is decreased and the bucket is locked,
                /// FAILED_PRECONDITION will be returned.If the bucket has a LifecycleState of DELETE_REQUESTED,
                /// FAILED_PRECONDITION will be returned.A buckets region may not be modified after it is created.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The full resource name of the bucket to update.
                /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]" Example:
                /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id". Also requires permission
                /// "resourcemanager.projects.updateLiens" to set the locked property
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.Logging.v2.Data.LogBucket body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>
                /// Updates a bucket. This method replaces the following fields in the existing bucket with values from
                /// the new bucket: retention_periodIf the retention period is decreased and the bucket is locked,
                /// FAILED_PRECONDITION will be returned.If the bucket has a LifecycleState of DELETE_REQUESTED,
                /// FAILED_PRECONDITION will be returned.A buckets region may not be modified after it is created.
                /// </summary>
                public class PatchRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogBucket>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Logging.v2.Data.LogBucket body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The full resource name of the bucket to update.
                    /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                    /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                    /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                    /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]" Example:
                    /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id". Also requires permission
                    /// "resourcemanager.projects.updateLiens" to set the locked property
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Required. Field mask that specifies the fields in bucket that need an update. A bucket field
                    /// will be overwritten if, and only if, it is in the update mask. name and output only fields
                    /// cannot be updated.For a detailed FieldMask definition, see
                    /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#google.protobuf.FieldMaskExample:
                    /// updateMask=retention_days.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Logging.v2.Data.LogBucket Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+/buckets/[^/]+$",
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
                /// Undeletes a bucket. A bucket that has been deleted may be undeleted within the grace period of 7
                /// days.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The full resource name of the bucket to undelete.
                /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]" Example:
                /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id".
                /// </param>
                public virtual UndeleteRequest Undelete(Google.Apis.Logging.v2.Data.UndeleteBucketRequest body, string name)
                {
                    return new UndeleteRequest(service, body, name);
                }

                /// <summary>
                /// Undeletes a bucket. A bucket that has been deleted may be undeleted within the grace period of 7
                /// days.
                /// </summary>
                public class UndeleteRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.Empty>
                {
                    /// <summary>Constructs a new Undelete request.</summary>
                    public UndeleteRequest(Google.Apis.Services.IClientService service, Google.Apis.Logging.v2.Data.UndeleteBucketRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The full resource name of the bucket to undelete.
                    /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                    /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                    /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                    /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]" Example:
                    /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Logging.v2.Data.UndeleteBucketRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "undelete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}:undelete";

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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+/buckets/[^/]+$",
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
                /// returns google.rpc.Code.UNIMPLEMENTED. Clients can use Operations.GetOperation or other methods to
                /// check whether the cancellation succeeded or whether the operation completed despite cancellation. On
                /// successful cancellation, the operation is not deleted; instead, it becomes an operation with an
                /// Operation.error value with a google.rpc.Status.code of 1, corresponding to Code.CANCELLED.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">The name of the operation resource to be cancelled.</param>
                public virtual CancelRequest Cancel(Google.Apis.Logging.v2.Data.CancelOperationRequest body, string name)
                {
                    return new CancelRequest(service, body, name);
                }

                /// <summary>
                /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to
                /// cancel the operation, but success is not guaranteed. If the server doesn't support this method, it
                /// returns google.rpc.Code.UNIMPLEMENTED. Clients can use Operations.GetOperation or other methods to
                /// check whether the cancellation succeeded or whether the operation completed despite cancellation. On
                /// successful cancellation, the operation is not deleted; instead, it becomes an operation with an
                /// Operation.error value with a google.rpc.Status.code of 1, corresponding to Code.CANCELLED.
                /// </summary>
                public class CancelRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.Empty>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.Logging.v2.Data.CancelOperationRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to be cancelled.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Logging.v2.Data.CancelOperationRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "cancel";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}:cancel";

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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+/operations/[^/]+$",
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
                public class GetRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.Operation>
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
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+/operations/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists operations that match the specified filter in the request. If the server doesn't support this
                /// method, it returns UNIMPLEMENTED.NOTE: the name binding allows API services to override the binding
                /// to use different resource name schemes, such as users/*/operations. To override the binding, API
                /// services can add a binding such as "/v1/{name=users/*}/operations" to their service configuration.
                /// For backwards compatibility, the default name includes the operations collection id, however
                /// overriding users must ensure the name binding is the parent resource, without the operations
                /// collection id.
                /// </summary>
                /// <param name="name">The name of the operation's parent resource.</param>
                public virtual ListRequest List(string name)
                {
                    return new ListRequest(service, name);
                }

                /// <summary>
                /// Lists operations that match the specified filter in the request. If the server doesn't support this
                /// method, it returns UNIMPLEMENTED.NOTE: the name binding allows API services to override the binding
                /// to use different resource name schemes, such as users/*/operations. To override the binding, API
                /// services can add a binding such as "/v1/{name=users/*}/operations" to their service configuration.
                /// For backwards compatibility, the default name includes the operations collection id, however
                /// overriding users must ensure the name binding is the parent resource, without the operations
                /// collection id.
                /// </summary>
                public class ListRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.ListOperationsResponse>
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
                    public override string RestPath => "v2/{+name}/operations";

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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+$",
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
                return new GetRequest(service, name);
            }

            /// <summary>Gets information about a location.</summary>
            public class GetRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.Location>
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
                public override string RestPath => "v2/{+name}";

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
                        Pattern = @"^organizations/[^/]+/locations/[^/]+$",
                    });
                }
            }

            /// <summary>Lists information about the supported locations for this service.</summary>
            /// <param name="name">The resource that owns the locations collection, if applicable.</param>
            public virtual ListRequest List(string name)
            {
                return new ListRequest(service, name);
            }

            /// <summary>Lists information about the supported locations for this service.</summary>
            public class ListRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.ListLocationsResponse>
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
                /// A filter to narrow down results to a preferred subset. The filtering language accepts strings like
                /// "displayName=tokyo", and is documented in more detail in AIP-160 (https://google.aip.dev/160).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// The maximum number of results to return. If not set, the service selects a default.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A page token received from the next_page_token field in the response. Send that page token to
                /// receive the subsequent page.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}/locations";

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
                        Pattern = @"^organizations/[^/]+$",
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

        /// <summary>Gets the Logs resource.</summary>
        public virtual LogsResource Logs { get; }

        /// <summary>The "logs" collection of methods.</summary>
        public class LogsResource
        {
            private const string Resource = "logs";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public LogsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Deletes all the log entries in a log for the _Default Log Bucket. The log reappears if it receives new
            /// entries. Log entries written shortly before the delete operation might not be deleted. Entries received
            /// after the delete operation with a timestamp before the operation will be deleted.
            /// </summary>
            /// <param name="logName">
            /// Required. The resource name of the log to delete: projects/[PROJECT_ID]/logs/[LOG_ID]
            /// organizations/[ORGANIZATION_ID]/logs/[LOG_ID] billingAccounts/[BILLING_ACCOUNT_ID]/logs/[LOG_ID]
            /// folders/[FOLDER_ID]/logs/[LOG_ID][LOG_ID] must be URL-encoded. For example,
            /// "projects/my-project-id/logs/syslog", "organizations/123/logs/cloudaudit.googleapis.com%2Factivity".For
            /// more information about log names, see LogEntry.
            /// </param>
            public virtual DeleteRequest Delete(string logName)
            {
                return new DeleteRequest(service, logName);
            }

            /// <summary>
            /// Deletes all the log entries in a log for the _Default Log Bucket. The log reappears if it receives new
            /// entries. Log entries written shortly before the delete operation might not be deleted. Entries received
            /// after the delete operation with a timestamp before the operation will be deleted.
            /// </summary>
            public class DeleteRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string logName) : base(service)
                {
                    LogName = logName;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the log to delete: projects/[PROJECT_ID]/logs/[LOG_ID]
                /// organizations/[ORGANIZATION_ID]/logs/[LOG_ID] billingAccounts/[BILLING_ACCOUNT_ID]/logs/[LOG_ID]
                /// folders/[FOLDER_ID]/logs/[LOG_ID][LOG_ID] must be URL-encoded. For example,
                /// "projects/my-project-id/logs/syslog",
                /// "organizations/123/logs/cloudaudit.googleapis.com%2Factivity".For more information about log names,
                /// see LogEntry.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("logName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string LogName { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+logName}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("logName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "logName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^organizations/[^/]+/logs/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Lists the logs in projects, organizations, folders, or billing accounts. Only logs that have entries are
            /// listed.
            /// </summary>
            /// <param name="parent">
            /// Required. The resource name that owns the logs: projects/[PROJECT_ID] organizations/[ORGANIZATION_ID]
            /// billingAccounts/[BILLING_ACCOUNT_ID] folders/[FOLDER_ID]
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>
            /// Lists the logs in projects, organizations, folders, or billing accounts. Only logs that have entries are
            /// listed.
            /// </summary>
            public class ListRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.ListLogsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name that owns the logs: projects/[PROJECT_ID]
                /// organizations/[ORGANIZATION_ID] billingAccounts/[BILLING_ACCOUNT_ID] folders/[FOLDER_ID]
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. The maximum number of results to return from this request. Non-positive values are
                /// ignored. The presence of nextPageToken in the response indicates that more results might be
                /// available.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. If present, then retrieve the next batch of results from the preceding call to this
                /// method. pageToken must be the value of nextPageToken from the previous response. The values of other
                /// method parameters should be identical to those in the previous call.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>
                /// Optional. The resource name that owns the logs:
                /// projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]
                /// organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]
                /// billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]
                /// folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]To support legacy
                /// queries, it could also be: projects/[PROJECT_ID] organizations/[ORGANIZATION_ID]
                /// billingAccounts/[BILLING_ACCOUNT_ID] folders/[FOLDER_ID]
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("resourceNames", Google.Apis.Util.RequestParameterType.Query)]
                public virtual Google.Apis.Util.Repeatable<string> ResourceNames { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/logs";

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
                        Pattern = @"^organizations/[^/]+$",
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
                    RequestParameters.Add("resourceNames", new Google.Apis.Discovery.Parameter
                    {
                        Name = "resourceNames",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the Sinks resource.</summary>
        public virtual SinksResource Sinks { get; }

        /// <summary>The "sinks" collection of methods.</summary>
        public class SinksResource
        {
            private const string Resource = "sinks";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public SinksResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Creates a sink that exports specified log entries to a destination. The export of newly-ingested log
            /// entries begins immediately, unless the sink's writer_identity is not permitted to write to the
            /// destination. A sink can export log entries only from the resource owning the sink.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The resource in which to create the sink: "projects/[PROJECT_ID]"
            /// "organizations/[ORGANIZATION_ID]" "billingAccounts/[BILLING_ACCOUNT_ID]" "folders/[FOLDER_ID]" Examples:
            /// "projects/my-logging-project", "organizations/123456789".
            /// </param>
            public virtual CreateRequest Create(Google.Apis.Logging.v2.Data.LogSink body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>
            /// Creates a sink that exports specified log entries to a destination. The export of newly-ingested log
            /// entries begins immediately, unless the sink's writer_identity is not permitted to write to the
            /// destination. A sink can export log entries only from the resource owning the sink.
            /// </summary>
            public class CreateRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogSink>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Logging.v2.Data.LogSink body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource in which to create the sink: "projects/[PROJECT_ID]"
                /// "organizations/[ORGANIZATION_ID]" "billingAccounts/[BILLING_ACCOUNT_ID]" "folders/[FOLDER_ID]"
                /// Examples: "projects/my-logging-project", "organizations/123456789".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. Determines the kind of IAM identity returned as writer_identity in the new sink. If this
                /// value is omitted or set to false, and if the sink's parent is a project, then the value returned as
                /// writer_identity is the same group or service account used by Logging before the addition of writer
                /// identities to this API. The sink's destination must be in the same project as the sink itself.If
                /// this field is set to true, or if the sink is owned by a non-project resource such as an
                /// organization, then the value of writer_identity will be a unique service account used only for
                /// exports from the new sink. For more information, see writer_identity in LogSink.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("uniqueWriterIdentity", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> UniqueWriterIdentity { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Logging.v2.Data.LogSink Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/sinks";

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
                        Pattern = @"^organizations/[^/]+$",
                    });
                    RequestParameters.Add("uniqueWriterIdentity", new Google.Apis.Discovery.Parameter
                    {
                        Name = "uniqueWriterIdentity",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Deletes a sink. If the sink has a unique writer_identity, then that service account is also deleted.
            /// </summary>
            /// <param name="sinkName">
            /// Required. The full resource name of the sink to delete, including the parent resource and the sink
            /// identifier: "projects/[PROJECT_ID]/sinks/[SINK_ID]" "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
            /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]" "folders/[FOLDER_ID]/sinks/[SINK_ID]" Example:
            /// "projects/my-project-id/sinks/my-sink-id".
            /// </param>
            public virtual DeleteRequest Delete(string sinkName)
            {
                return new DeleteRequest(service, sinkName);
            }

            /// <summary>
            /// Deletes a sink. If the sink has a unique writer_identity, then that service account is also deleted.
            /// </summary>
            public class DeleteRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string sinkName) : base(service)
                {
                    SinkName = sinkName;
                    InitParameters();
                }

                /// <summary>
                /// Required. The full resource name of the sink to delete, including the parent resource and the sink
                /// identifier: "projects/[PROJECT_ID]/sinks/[SINK_ID]"
                /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
                /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]" "folders/[FOLDER_ID]/sinks/[SINK_ID]"
                /// Example: "projects/my-project-id/sinks/my-sink-id".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("sinkName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string SinkName { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+sinkName}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("sinkName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "sinkName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^organizations/[^/]+/sinks/[^/]+$",
                    });
                }
            }

            /// <summary>Gets a sink.</summary>
            /// <param name="sinkName">
            /// Required. The resource name of the sink: "projects/[PROJECT_ID]/sinks/[SINK_ID]"
            /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]" "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
            /// "folders/[FOLDER_ID]/sinks/[SINK_ID]" Example: "projects/my-project-id/sinks/my-sink-id".
            /// </param>
            public virtual GetRequest Get(string sinkName)
            {
                return new GetRequest(service, sinkName);
            }

            /// <summary>Gets a sink.</summary>
            public class GetRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogSink>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string sinkName) : base(service)
                {
                    SinkName = sinkName;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the sink: "projects/[PROJECT_ID]/sinks/[SINK_ID]"
                /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
                /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]" "folders/[FOLDER_ID]/sinks/[SINK_ID]"
                /// Example: "projects/my-project-id/sinks/my-sink-id".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("sinkName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string SinkName { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+sinkName}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("sinkName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "sinkName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^organizations/[^/]+/sinks/[^/]+$",
                    });
                }
            }

            /// <summary>Lists sinks.</summary>
            /// <param name="parent">
            /// Required. The parent resource whose sinks are to be listed: "projects/[PROJECT_ID]"
            /// "organizations/[ORGANIZATION_ID]" "billingAccounts/[BILLING_ACCOUNT_ID]" "folders/[FOLDER_ID]"
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists sinks.</summary>
            public class ListRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.ListSinksResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent resource whose sinks are to be listed: "projects/[PROJECT_ID]"
                /// "organizations/[ORGANIZATION_ID]" "billingAccounts/[BILLING_ACCOUNT_ID]" "folders/[FOLDER_ID]"
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. The maximum number of results to return from this request. Non-positive values are
                /// ignored. The presence of nextPageToken in the response indicates that more results might be
                /// available.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. If present, then retrieve the next batch of results from the preceding call to this
                /// method. pageToken must be the value of nextPageToken from the previous response. The values of other
                /// method parameters should be identical to those in the previous call.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/sinks";

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
                        Pattern = @"^organizations/[^/]+$",
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
            /// Updates a sink. This method replaces the following fields in the existing sink with values from the new
            /// sink: destination, and filter.The updated sink might also have a new writer_identity; see the
            /// unique_writer_identity field.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="sinkName">
            /// Required. The full resource name of the sink to update, including the parent resource and the sink
            /// identifier: "projects/[PROJECT_ID]/sinks/[SINK_ID]" "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
            /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]" "folders/[FOLDER_ID]/sinks/[SINK_ID]" Example:
            /// "projects/my-project-id/sinks/my-sink-id".
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.Logging.v2.Data.LogSink body, string sinkName)
            {
                return new PatchRequest(service, body, sinkName);
            }

            /// <summary>
            /// Updates a sink. This method replaces the following fields in the existing sink with values from the new
            /// sink: destination, and filter.The updated sink might also have a new writer_identity; see the
            /// unique_writer_identity field.
            /// </summary>
            public class PatchRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogSink>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Logging.v2.Data.LogSink body, string sinkName) : base(service)
                {
                    SinkName = sinkName;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The full resource name of the sink to update, including the parent resource and the sink
                /// identifier: "projects/[PROJECT_ID]/sinks/[SINK_ID]"
                /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
                /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]" "folders/[FOLDER_ID]/sinks/[SINK_ID]"
                /// Example: "projects/my-project-id/sinks/my-sink-id".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("sinkName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string SinkName { get; private set; }

                /// <summary>
                /// Optional. See sinks.create for a description of this field. When updating a sink, the effect of this
                /// field on the value of writer_identity in the updated sink depends on both the old and new values of
                /// this field: If the old and new values of this field are both false or both true, then there is no
                /// change to the sink's writer_identity. If the old value is false and the new value is true, then
                /// writer_identity is changed to a unique service account. It is an error if the old value is true and
                /// the new value is set to false or defaulted to false.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("uniqueWriterIdentity", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> UniqueWriterIdentity { get; set; }

                /// <summary>
                /// Optional. Field mask that specifies the fields in sink that need an update. A sink field will be
                /// overwritten if, and only if, it is in the update mask. name and output only fields cannot be
                /// updated.An empty updateMask is temporarily treated as using the following mask for backwards
                /// compatibility purposes: destination,filter,includeChildren At some point in the future, behavior
                /// will be removed and specifying an empty updateMask will be an error.For a detailed FieldMask
                /// definition, see
                /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#google.protobuf.FieldMaskExample:
                /// updateMask=filter.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Logging.v2.Data.LogSink Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+sinkName}";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("sinkName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "sinkName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^organizations/[^/]+/sinks/[^/]+$",
                    });
                    RequestParameters.Add("uniqueWriterIdentity", new Google.Apis.Discovery.Parameter
                    {
                        Name = "uniqueWriterIdentity",
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
            /// Updates a sink. This method replaces the following fields in the existing sink with values from the new
            /// sink: destination, and filter.The updated sink might also have a new writer_identity; see the
            /// unique_writer_identity field.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="sinkName">
            /// Required. The full resource name of the sink to update, including the parent resource and the sink
            /// identifier: "projects/[PROJECT_ID]/sinks/[SINK_ID]" "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
            /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]" "folders/[FOLDER_ID]/sinks/[SINK_ID]" Example:
            /// "projects/my-project-id/sinks/my-sink-id".
            /// </param>
            public virtual UpdateRequest Update(Google.Apis.Logging.v2.Data.LogSink body, string sinkName)
            {
                return new UpdateRequest(service, body, sinkName);
            }

            /// <summary>
            /// Updates a sink. This method replaces the following fields in the existing sink with values from the new
            /// sink: destination, and filter.The updated sink might also have a new writer_identity; see the
            /// unique_writer_identity field.
            /// </summary>
            public class UpdateRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogSink>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Logging.v2.Data.LogSink body, string sinkName) : base(service)
                {
                    SinkName = sinkName;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The full resource name of the sink to update, including the parent resource and the sink
                /// identifier: "projects/[PROJECT_ID]/sinks/[SINK_ID]"
                /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
                /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]" "folders/[FOLDER_ID]/sinks/[SINK_ID]"
                /// Example: "projects/my-project-id/sinks/my-sink-id".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("sinkName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string SinkName { get; private set; }

                /// <summary>
                /// Optional. See sinks.create for a description of this field. When updating a sink, the effect of this
                /// field on the value of writer_identity in the updated sink depends on both the old and new values of
                /// this field: If the old and new values of this field are both false or both true, then there is no
                /// change to the sink's writer_identity. If the old value is false and the new value is true, then
                /// writer_identity is changed to a unique service account. It is an error if the old value is true and
                /// the new value is set to false or defaulted to false.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("uniqueWriterIdentity", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> UniqueWriterIdentity { get; set; }

                /// <summary>
                /// Optional. Field mask that specifies the fields in sink that need an update. A sink field will be
                /// overwritten if, and only if, it is in the update mask. name and output only fields cannot be
                /// updated.An empty updateMask is temporarily treated as using the following mask for backwards
                /// compatibility purposes: destination,filter,includeChildren At some point in the future, behavior
                /// will be removed and specifying an empty updateMask will be an error.For a detailed FieldMask
                /// definition, see
                /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#google.protobuf.FieldMaskExample:
                /// updateMask=filter.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Logging.v2.Data.LogSink Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "update";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+sinkName}";

                /// <summary>Initializes Update parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("sinkName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "sinkName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^organizations/[^/]+/sinks/[^/]+$",
                    });
                    RequestParameters.Add("uniqueWriterIdentity", new Google.Apis.Discovery.Parameter
                    {
                        Name = "uniqueWriterIdentity",
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
        /// Gets the Logs Router CMEK settings for the given resource.Note: CMEK for the Logs Router can currently only
        /// be configured for GCP organizations. Once configured, it applies to all projects and folders in the GCP
        /// organization.See Enabling CMEK for Logs Router
        /// (https://cloud.google.com/logging/docs/routing/managed-encryption) for more information.
        /// </summary>
        /// <param name="name">
        /// Required. The resource for which to retrieve CMEK settings. "projects/[PROJECT_ID]/cmekSettings"
        /// "organizations/[ORGANIZATION_ID]/cmekSettings" "billingAccounts/[BILLING_ACCOUNT_ID]/cmekSettings"
        /// "folders/[FOLDER_ID]/cmekSettings" Example: "organizations/12345/cmekSettings".Note: CMEK for the Logs
        /// Router can currently only be configured for GCP organizations. Once configured, it applies to all projects
        /// and folders in the GCP organization.
        /// </param>
        public virtual GetCmekSettingsRequest GetCmekSettings(string name)
        {
            return new GetCmekSettingsRequest(service, name);
        }

        /// <summary>
        /// Gets the Logs Router CMEK settings for the given resource.Note: CMEK for the Logs Router can currently only
        /// be configured for GCP organizations. Once configured, it applies to all projects and folders in the GCP
        /// organization.See Enabling CMEK for Logs Router
        /// (https://cloud.google.com/logging/docs/routing/managed-encryption) for more information.
        /// </summary>
        public class GetCmekSettingsRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.CmekSettings>
        {
            /// <summary>Constructs a new GetCmekSettings request.</summary>
            public GetCmekSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The resource for which to retrieve CMEK settings. "projects/[PROJECT_ID]/cmekSettings"
            /// "organizations/[ORGANIZATION_ID]/cmekSettings" "billingAccounts/[BILLING_ACCOUNT_ID]/cmekSettings"
            /// "folders/[FOLDER_ID]/cmekSettings" Example: "organizations/12345/cmekSettings".Note: CMEK for the Logs
            /// Router can currently only be configured for GCP organizations. Once configured, it applies to all
            /// projects and folders in the GCP organization.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getCmekSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/{+name}/cmekSettings";

            /// <summary>Initializes GetCmekSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^organizations/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Updates the Logs Router CMEK settings for the given resource.Note: CMEK for the Logs Router can currently
        /// only be configured for GCP organizations. Once configured, it applies to all projects and folders in the GCP
        /// organization.UpdateCmekSettings will fail if 1) kms_key_name is invalid, or 2) the associated service
        /// account does not have the required roles/cloudkms.cryptoKeyEncrypterDecrypter role assigned for the key, or
        /// 3) access to the key is disabled.See Enabling CMEK for Logs Router
        /// (https://cloud.google.com/logging/docs/routing/managed-encryption) for more information.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// Required. The resource name for the CMEK settings to update. "projects/[PROJECT_ID]/cmekSettings"
        /// "organizations/[ORGANIZATION_ID]/cmekSettings" "billingAccounts/[BILLING_ACCOUNT_ID]/cmekSettings"
        /// "folders/[FOLDER_ID]/cmekSettings" Example: "organizations/12345/cmekSettings".Note: CMEK for the Logs
        /// Router can currently only be configured for GCP organizations. Once configured, it applies to all projects
        /// and folders in the GCP organization.
        /// </param>
        public virtual UpdateCmekSettingsRequest UpdateCmekSettings(Google.Apis.Logging.v2.Data.CmekSettings body, string name)
        {
            return new UpdateCmekSettingsRequest(service, body, name);
        }

        /// <summary>
        /// Updates the Logs Router CMEK settings for the given resource.Note: CMEK for the Logs Router can currently
        /// only be configured for GCP organizations. Once configured, it applies to all projects and folders in the GCP
        /// organization.UpdateCmekSettings will fail if 1) kms_key_name is invalid, or 2) the associated service
        /// account does not have the required roles/cloudkms.cryptoKeyEncrypterDecrypter role assigned for the key, or
        /// 3) access to the key is disabled.See Enabling CMEK for Logs Router
        /// (https://cloud.google.com/logging/docs/routing/managed-encryption) for more information.
        /// </summary>
        public class UpdateCmekSettingsRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.CmekSettings>
        {
            /// <summary>Constructs a new UpdateCmekSettings request.</summary>
            public UpdateCmekSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.Logging.v2.Data.CmekSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. The resource name for the CMEK settings to update. "projects/[PROJECT_ID]/cmekSettings"
            /// "organizations/[ORGANIZATION_ID]/cmekSettings" "billingAccounts/[BILLING_ACCOUNT_ID]/cmekSettings"
            /// "folders/[FOLDER_ID]/cmekSettings" Example: "organizations/12345/cmekSettings".Note: CMEK for the Logs
            /// Router can currently only be configured for GCP organizations. Once configured, it applies to all
            /// projects and folders in the GCP organization.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>
            /// Optional. Field mask identifying which fields from cmek_settings should be updated. A field will be
            /// overwritten if and only if it is in the update mask. Output only fields cannot be updated.See FieldMask
            /// for more information.Example: "updateMask=kmsKeyName"
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Logging.v2.Data.CmekSettings Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateCmekSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/{+name}/cmekSettings";

            /// <summary>Initializes UpdateCmekSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^organizations/[^/]+$",
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
            Exclusions = new ExclusionsResource(service);
            Locations = new LocationsResource(service);
            Logs = new LogsResource(service);
            Metrics = new MetricsResource(service);
            Sinks = new SinksResource(service);
        }

        /// <summary>Gets the Exclusions resource.</summary>
        public virtual ExclusionsResource Exclusions { get; }

        /// <summary>The "exclusions" collection of methods.</summary>
        public class ExclusionsResource
        {
            private const string Resource = "exclusions";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ExclusionsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Creates a new exclusion in a specified parent resource. Only log entries belonging to that resource can
            /// be excluded. You can have up to 10 exclusions in a resource.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The parent resource in which to create the exclusion: "projects/[PROJECT_ID]"
            /// "organizations/[ORGANIZATION_ID]" "billingAccounts/[BILLING_ACCOUNT_ID]" "folders/[FOLDER_ID]" Examples:
            /// "projects/my-logging-project", "organizations/123456789".
            /// </param>
            public virtual CreateRequest Create(Google.Apis.Logging.v2.Data.LogExclusion body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>
            /// Creates a new exclusion in a specified parent resource. Only log entries belonging to that resource can
            /// be excluded. You can have up to 10 exclusions in a resource.
            /// </summary>
            public class CreateRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogExclusion>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Logging.v2.Data.LogExclusion body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent resource in which to create the exclusion: "projects/[PROJECT_ID]"
                /// "organizations/[ORGANIZATION_ID]" "billingAccounts/[BILLING_ACCOUNT_ID]" "folders/[FOLDER_ID]"
                /// Examples: "projects/my-logging-project", "organizations/123456789".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Logging.v2.Data.LogExclusion Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/exclusions";

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

            /// <summary>Deletes an exclusion.</summary>
            /// <param name="name">
            /// Required. The resource name of an existing exclusion to delete:
            /// "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
            /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
            /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
            /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]" Example:
            /// "projects/my-project-id/exclusions/my-exclusion-id".
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>Deletes an exclusion.</summary>
            public class DeleteRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of an existing exclusion to delete:
                /// "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
                /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
                /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
                /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]" Example:
                /// "projects/my-project-id/exclusions/my-exclusion-id".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}";

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
                        Pattern = @"^projects/[^/]+/exclusions/[^/]+$",
                    });
                }
            }

            /// <summary>Gets the description of an exclusion.</summary>
            /// <param name="name">
            /// Required. The resource name of an existing exclusion: "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
            /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
            /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
            /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]" Example:
            /// "projects/my-project-id/exclusions/my-exclusion-id".
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets the description of an exclusion.</summary>
            public class GetRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogExclusion>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of an existing exclusion:
                /// "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
                /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
                /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
                /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]" Example:
                /// "projects/my-project-id/exclusions/my-exclusion-id".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}";

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
                        Pattern = @"^projects/[^/]+/exclusions/[^/]+$",
                    });
                }
            }

            /// <summary>Lists all the exclusions in a parent resource.</summary>
            /// <param name="parent">
            /// Required. The parent resource whose exclusions are to be listed. "projects/[PROJECT_ID]"
            /// "organizations/[ORGANIZATION_ID]" "billingAccounts/[BILLING_ACCOUNT_ID]" "folders/[FOLDER_ID]"
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists all the exclusions in a parent resource.</summary>
            public class ListRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.ListExclusionsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent resource whose exclusions are to be listed. "projects/[PROJECT_ID]"
                /// "organizations/[ORGANIZATION_ID]" "billingAccounts/[BILLING_ACCOUNT_ID]" "folders/[FOLDER_ID]"
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. The maximum number of results to return from this request. Non-positive values are
                /// ignored. The presence of nextPageToken in the response indicates that more results might be
                /// available.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. If present, then retrieve the next batch of results from the preceding call to this
                /// method. pageToken must be the value of nextPageToken from the previous response. The values of other
                /// method parameters should be identical to those in the previous call.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/exclusions";

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

            /// <summary>Changes one or more properties of an existing exclusion.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The resource name of the exclusion to update:
            /// "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
            /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
            /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
            /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]" Example:
            /// "projects/my-project-id/exclusions/my-exclusion-id".
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.Logging.v2.Data.LogExclusion body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>Changes one or more properties of an existing exclusion.</summary>
            public class PatchRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogExclusion>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Logging.v2.Data.LogExclusion body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the exclusion to update:
                /// "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
                /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
                /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
                /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]" Example:
                /// "projects/my-project-id/exclusions/my-exclusion-id".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Required. A non-empty list of fields to change in the existing exclusion. New values for the fields
                /// are taken from the corresponding fields in the LogExclusion included in this request. Fields not
                /// mentioned in update_mask are not changed and are ignored in the request.For example, to change the
                /// filter and description of an exclusion, specify an update_mask of "filter,description".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Logging.v2.Data.LogExclusion Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}";

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
                        Pattern = @"^projects/[^/]+/exclusions/[^/]+$",
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
                Buckets = new BucketsResource(service);
                Operations = new OperationsResource(service);
            }

            /// <summary>Gets the Buckets resource.</summary>
            public virtual BucketsResource Buckets { get; }

            /// <summary>The "buckets" collection of methods.</summary>
            public class BucketsResource
            {
                private const string Resource = "buckets";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public BucketsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Views = new ViewsResource(service);
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

                    /// <summary>
                    /// Creates a view over logs in a bucket. A bucket may contain a maximum of 50 views.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The bucket in which to create the view
                    /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]" Example:
                    /// "projects/my-logging-project/locations/my-location/buckets/my-bucket"
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.Logging.v2.Data.LogView body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>
                    /// Creates a view over logs in a bucket. A bucket may contain a maximum of 50 views.
                    /// </summary>
                    public class CreateRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogView>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Logging.v2.Data.LogView body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The bucket in which to create the view
                        /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]" Example:
                        /// "projects/my-logging-project/locations/my-location/buckets/my-bucket"
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Required. The id to use for this view.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("viewId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string ViewId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Logging.v2.Data.LogView Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+parent}/views";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/buckets/[^/]+$",
                            });
                            RequestParameters.Add("viewId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "viewId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Deletes a view from a bucket.</summary>
                    /// <param name="name">
                    /// Required. The full resource name of the view to delete:
                    /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]" Example:
                    /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id/views/my-view-id".
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>Deletes a view from a bucket.</summary>
                    public class DeleteRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The full resource name of the view to delete:
                        /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]" Example:
                        /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id/views/my-view-id".
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/buckets/[^/]+/views/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets a view.</summary>
                    /// <param name="name">
                    /// Required. The resource name of the policy:
                    /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]" Example:
                    /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id/views/my-view-id".
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Gets a view.</summary>
                    public class GetRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogView>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the policy:
                        /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]" Example:
                        /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id/views/my-view-id".
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/buckets/[^/]+/views/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists views on a bucket.</summary>
                    /// <param name="parent">
                    /// Required. The bucket whose views are to be listed:
                    /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Lists views on a bucket.</summary>
                    public class ListRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.ListViewsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The bucket whose views are to be listed:
                        /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. The maximum number of results to return from this request. Non-positive values are
                        /// ignored. The presence of nextPageToken in the response indicates that more results might be
                        /// available.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. If present, then retrieve the next batch of results from the preceding call to
                        /// this method. pageToken must be the value of nextPageToken from the previous response. The
                        /// values of other method parameters should be identical to those in the previous call.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+parent}/views";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/buckets/[^/]+$",
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
                    /// Updates a view. This method replaces the following fields in the existing view with values from
                    /// the new view: filter.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The full resource name of the view to update
                    /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]" Example:
                    /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id/views/my-view-id".
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.Logging.v2.Data.LogView body, string name)
                    {
                        return new PatchRequest(service, body, name);
                    }

                    /// <summary>
                    /// Updates a view. This method replaces the following fields in the existing view with values from
                    /// the new view: filter.
                    /// </summary>
                    public class PatchRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogView>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Logging.v2.Data.LogView body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The full resource name of the view to update
                        /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]" Example:
                        /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id/views/my-view-id".
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. Field mask that specifies the fields in view that need an update. A field will be
                        /// overwritten if, and only if, it is in the update mask. name and output only fields cannot be
                        /// updated.For a detailed FieldMask definition, see
                        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#google.protobuf.FieldMaskExample:
                        /// updateMask=filter.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Logging.v2.Data.LogView Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "patch";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PATCH";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/buckets/[^/]+/views/[^/]+$",
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
                /// Creates a bucket that can be used to store log entries. Once a bucket has been created, the region
                /// cannot be changed.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The resource in which to create the bucket:
                /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]" Example:
                /// "projects/my-logging-project/locations/global"
                /// </param>
                public virtual CreateRequest Create(Google.Apis.Logging.v2.Data.LogBucket body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>
                /// Creates a bucket that can be used to store log entries. Once a bucket has been created, the region
                /// cannot be changed.
                /// </summary>
                public class CreateRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogBucket>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Logging.v2.Data.LogBucket body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource in which to create the bucket:
                    /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]" Example:
                    /// "projects/my-logging-project/locations/global"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. A client-assigned identifier such as "my-bucket". Identifiers are limited to 100
                    /// characters and can include only letters, digits, underscores, hyphens, and periods.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("bucketId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string BucketId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Logging.v2.Data.LogBucket Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/buckets";

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
                        RequestParameters.Add("bucketId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "bucketId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Deletes a bucket. Moves the bucket to the DELETE_REQUESTED state. After 7 days, the bucket will be
                /// purged and all logs in the bucket will be permanently deleted.
                /// </summary>
                /// <param name="name">
                /// Required. The full resource name of the bucket to delete.
                /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]" Example:
                /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id".
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>
                /// Deletes a bucket. Moves the bucket to the DELETE_REQUESTED state. After 7 days, the bucket will be
                /// purged and all logs in the bucket will be permanently deleted.
                /// </summary>
                public class DeleteRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The full resource name of the bucket to delete.
                    /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                    /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                    /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                    /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]" Example:
                    /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/buckets/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets a bucket.</summary>
                /// <param name="name">
                /// Required. The resource name of the bucket:
                /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]" Example:
                /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id".
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Gets a bucket.</summary>
                public class GetRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogBucket>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the bucket:
                    /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                    /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                    /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                    /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]" Example:
                    /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/buckets/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists buckets.</summary>
                /// <param name="parent">
                /// Required. The parent resource whose buckets are to be listed:
                /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]"
                /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]"
                /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]"
                /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]" Note: The locations portion of the resource must be
                /// specified, but supplying the character - in place of LOCATION_ID will return all buckets.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists buckets.</summary>
                public class ListRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.ListBucketsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource whose buckets are to be listed:
                    /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]"
                    /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]"
                    /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]"
                    /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]" Note: The locations portion of the resource must
                    /// be specified, but supplying the character - in place of LOCATION_ID will return all buckets.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. The maximum number of results to return from this request. Non-positive values are
                    /// ignored. The presence of nextPageToken in the response indicates that more results might be
                    /// available.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. If present, then retrieve the next batch of results from the preceding call to this
                    /// method. pageToken must be the value of nextPageToken from the previous response. The values of
                    /// other method parameters should be identical to those in the previous call.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/buckets";

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

                /// <summary>
                /// Updates a bucket. This method replaces the following fields in the existing bucket with values from
                /// the new bucket: retention_periodIf the retention period is decreased and the bucket is locked,
                /// FAILED_PRECONDITION will be returned.If the bucket has a LifecycleState of DELETE_REQUESTED,
                /// FAILED_PRECONDITION will be returned.A buckets region may not be modified after it is created.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The full resource name of the bucket to update.
                /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]" Example:
                /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id". Also requires permission
                /// "resourcemanager.projects.updateLiens" to set the locked property
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.Logging.v2.Data.LogBucket body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>
                /// Updates a bucket. This method replaces the following fields in the existing bucket with values from
                /// the new bucket: retention_periodIf the retention period is decreased and the bucket is locked,
                /// FAILED_PRECONDITION will be returned.If the bucket has a LifecycleState of DELETE_REQUESTED,
                /// FAILED_PRECONDITION will be returned.A buckets region may not be modified after it is created.
                /// </summary>
                public class PatchRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogBucket>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Logging.v2.Data.LogBucket body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The full resource name of the bucket to update.
                    /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                    /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                    /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                    /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]" Example:
                    /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id". Also requires permission
                    /// "resourcemanager.projects.updateLiens" to set the locked property
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Required. Field mask that specifies the fields in bucket that need an update. A bucket field
                    /// will be overwritten if, and only if, it is in the update mask. name and output only fields
                    /// cannot be updated.For a detailed FieldMask definition, see
                    /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#google.protobuf.FieldMaskExample:
                    /// updateMask=retention_days.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Logging.v2.Data.LogBucket Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/buckets/[^/]+$",
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
                /// Undeletes a bucket. A bucket that has been deleted may be undeleted within the grace period of 7
                /// days.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The full resource name of the bucket to undelete.
                /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]" Example:
                /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id".
                /// </param>
                public virtual UndeleteRequest Undelete(Google.Apis.Logging.v2.Data.UndeleteBucketRequest body, string name)
                {
                    return new UndeleteRequest(service, body, name);
                }

                /// <summary>
                /// Undeletes a bucket. A bucket that has been deleted may be undeleted within the grace period of 7
                /// days.
                /// </summary>
                public class UndeleteRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.Empty>
                {
                    /// <summary>Constructs a new Undelete request.</summary>
                    public UndeleteRequest(Google.Apis.Services.IClientService service, Google.Apis.Logging.v2.Data.UndeleteBucketRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The full resource name of the bucket to undelete.
                    /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                    /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                    /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
                    /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]" Example:
                    /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Logging.v2.Data.UndeleteBucketRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "undelete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}:undelete";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/buckets/[^/]+$",
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
                /// returns google.rpc.Code.UNIMPLEMENTED. Clients can use Operations.GetOperation or other methods to
                /// check whether the cancellation succeeded or whether the operation completed despite cancellation. On
                /// successful cancellation, the operation is not deleted; instead, it becomes an operation with an
                /// Operation.error value with a google.rpc.Status.code of 1, corresponding to Code.CANCELLED.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">The name of the operation resource to be cancelled.</param>
                public virtual CancelRequest Cancel(Google.Apis.Logging.v2.Data.CancelOperationRequest body, string name)
                {
                    return new CancelRequest(service, body, name);
                }

                /// <summary>
                /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to
                /// cancel the operation, but success is not guaranteed. If the server doesn't support this method, it
                /// returns google.rpc.Code.UNIMPLEMENTED. Clients can use Operations.GetOperation or other methods to
                /// check whether the cancellation succeeded or whether the operation completed despite cancellation. On
                /// successful cancellation, the operation is not deleted; instead, it becomes an operation with an
                /// Operation.error value with a google.rpc.Status.code of 1, corresponding to Code.CANCELLED.
                /// </summary>
                public class CancelRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.Empty>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.Logging.v2.Data.CancelOperationRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to be cancelled.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Logging.v2.Data.CancelOperationRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "cancel";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}:cancel";

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
                public class GetRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.Operation>
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
                    public override string RestPath => "v2/{+name}";

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
                /// method, it returns UNIMPLEMENTED.NOTE: the name binding allows API services to override the binding
                /// to use different resource name schemes, such as users/*/operations. To override the binding, API
                /// services can add a binding such as "/v1/{name=users/*}/operations" to their service configuration.
                /// For backwards compatibility, the default name includes the operations collection id, however
                /// overriding users must ensure the name binding is the parent resource, without the operations
                /// collection id.
                /// </summary>
                /// <param name="name">The name of the operation's parent resource.</param>
                public virtual ListRequest List(string name)
                {
                    return new ListRequest(service, name);
                }

                /// <summary>
                /// Lists operations that match the specified filter in the request. If the server doesn't support this
                /// method, it returns UNIMPLEMENTED.NOTE: the name binding allows API services to override the binding
                /// to use different resource name schemes, such as users/*/operations. To override the binding, API
                /// services can add a binding such as "/v1/{name=users/*}/operations" to their service configuration.
                /// For backwards compatibility, the default name includes the operations collection id, however
                /// overriding users must ensure the name binding is the parent resource, without the operations
                /// collection id.
                /// </summary>
                public class ListRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.ListOperationsResponse>
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
                    public override string RestPath => "v2/{+name}/operations";

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
                return new GetRequest(service, name);
            }

            /// <summary>Gets information about a location.</summary>
            public class GetRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.Location>
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
                public override string RestPath => "v2/{+name}";

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
                return new ListRequest(service, name);
            }

            /// <summary>Lists information about the supported locations for this service.</summary>
            public class ListRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.ListLocationsResponse>
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
                /// A filter to narrow down results to a preferred subset. The filtering language accepts strings like
                /// "displayName=tokyo", and is documented in more detail in AIP-160 (https://google.aip.dev/160).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// The maximum number of results to return. If not set, the service selects a default.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A page token received from the next_page_token field in the response. Send that page token to
                /// receive the subsequent page.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}/locations";

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

        /// <summary>Gets the Logs resource.</summary>
        public virtual LogsResource Logs { get; }

        /// <summary>The "logs" collection of methods.</summary>
        public class LogsResource
        {
            private const string Resource = "logs";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public LogsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Deletes all the log entries in a log for the _Default Log Bucket. The log reappears if it receives new
            /// entries. Log entries written shortly before the delete operation might not be deleted. Entries received
            /// after the delete operation with a timestamp before the operation will be deleted.
            /// </summary>
            /// <param name="logName">
            /// Required. The resource name of the log to delete: projects/[PROJECT_ID]/logs/[LOG_ID]
            /// organizations/[ORGANIZATION_ID]/logs/[LOG_ID] billingAccounts/[BILLING_ACCOUNT_ID]/logs/[LOG_ID]
            /// folders/[FOLDER_ID]/logs/[LOG_ID][LOG_ID] must be URL-encoded. For example,
            /// "projects/my-project-id/logs/syslog", "organizations/123/logs/cloudaudit.googleapis.com%2Factivity".For
            /// more information about log names, see LogEntry.
            /// </param>
            public virtual DeleteRequest Delete(string logName)
            {
                return new DeleteRequest(service, logName);
            }

            /// <summary>
            /// Deletes all the log entries in a log for the _Default Log Bucket. The log reappears if it receives new
            /// entries. Log entries written shortly before the delete operation might not be deleted. Entries received
            /// after the delete operation with a timestamp before the operation will be deleted.
            /// </summary>
            public class DeleteRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string logName) : base(service)
                {
                    LogName = logName;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the log to delete: projects/[PROJECT_ID]/logs/[LOG_ID]
                /// organizations/[ORGANIZATION_ID]/logs/[LOG_ID] billingAccounts/[BILLING_ACCOUNT_ID]/logs/[LOG_ID]
                /// folders/[FOLDER_ID]/logs/[LOG_ID][LOG_ID] must be URL-encoded. For example,
                /// "projects/my-project-id/logs/syslog",
                /// "organizations/123/logs/cloudaudit.googleapis.com%2Factivity".For more information about log names,
                /// see LogEntry.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("logName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string LogName { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+logName}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("logName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "logName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/logs/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Lists the logs in projects, organizations, folders, or billing accounts. Only logs that have entries are
            /// listed.
            /// </summary>
            /// <param name="parent">
            /// Required. The resource name that owns the logs: projects/[PROJECT_ID] organizations/[ORGANIZATION_ID]
            /// billingAccounts/[BILLING_ACCOUNT_ID] folders/[FOLDER_ID]
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>
            /// Lists the logs in projects, organizations, folders, or billing accounts. Only logs that have entries are
            /// listed.
            /// </summary>
            public class ListRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.ListLogsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name that owns the logs: projects/[PROJECT_ID]
                /// organizations/[ORGANIZATION_ID] billingAccounts/[BILLING_ACCOUNT_ID] folders/[FOLDER_ID]
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. The maximum number of results to return from this request. Non-positive values are
                /// ignored. The presence of nextPageToken in the response indicates that more results might be
                /// available.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. If present, then retrieve the next batch of results from the preceding call to this
                /// method. pageToken must be the value of nextPageToken from the previous response. The values of other
                /// method parameters should be identical to those in the previous call.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>
                /// Optional. The resource name that owns the logs:
                /// projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]
                /// organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]
                /// billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]
                /// folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]To support legacy
                /// queries, it could also be: projects/[PROJECT_ID] organizations/[ORGANIZATION_ID]
                /// billingAccounts/[BILLING_ACCOUNT_ID] folders/[FOLDER_ID]
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("resourceNames", Google.Apis.Util.RequestParameterType.Query)]
                public virtual Google.Apis.Util.Repeatable<string> ResourceNames { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/logs";

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
                    RequestParameters.Add("resourceNames", new Google.Apis.Discovery.Parameter
                    {
                        Name = "resourceNames",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the Metrics resource.</summary>
        public virtual MetricsResource Metrics { get; }

        /// <summary>The "metrics" collection of methods.</summary>
        public class MetricsResource
        {
            private const string Resource = "metrics";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public MetricsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Creates a logs-based metric.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The resource name of the project in which to create the metric: "projects/[PROJECT_ID]" The
            /// new metric must be provided in the request.
            /// </param>
            public virtual CreateRequest Create(Google.Apis.Logging.v2.Data.LogMetric body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>Creates a logs-based metric.</summary>
            public class CreateRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogMetric>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Logging.v2.Data.LogMetric body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the project in which to create the metric: "projects/[PROJECT_ID]"
                /// The new metric must be provided in the request.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Logging.v2.Data.LogMetric Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/metrics";

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

            /// <summary>Deletes a logs-based metric.</summary>
            /// <param name="metricName">
            /// Required. The resource name of the metric to delete: "projects/[PROJECT_ID]/metrics/[METRIC_ID]"
            /// </param>
            public virtual DeleteRequest Delete(string metricName)
            {
                return new DeleteRequest(service, metricName);
            }

            /// <summary>Deletes a logs-based metric.</summary>
            public class DeleteRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string metricName) : base(service)
                {
                    MetricName = metricName;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the metric to delete: "projects/[PROJECT_ID]/metrics/[METRIC_ID]"
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("metricName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string MetricName { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+metricName}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("metricName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "metricName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/metrics/[^/]+$",
                    });
                }
            }

            /// <summary>Gets a logs-based metric.</summary>
            /// <param name="metricName">
            /// Required. The resource name of the desired metric: "projects/[PROJECT_ID]/metrics/[METRIC_ID]"
            /// </param>
            public virtual GetRequest Get(string metricName)
            {
                return new GetRequest(service, metricName);
            }

            /// <summary>Gets a logs-based metric.</summary>
            public class GetRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogMetric>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string metricName) : base(service)
                {
                    MetricName = metricName;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the desired metric: "projects/[PROJECT_ID]/metrics/[METRIC_ID]"
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("metricName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string MetricName { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+metricName}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("metricName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "metricName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/metrics/[^/]+$",
                    });
                }
            }

            /// <summary>Lists logs-based metrics.</summary>
            /// <param name="parent">
            /// Required. The name of the project containing the metrics: "projects/[PROJECT_ID]"
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists logs-based metrics.</summary>
            public class ListRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.ListLogMetricsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the project containing the metrics: "projects/[PROJECT_ID]"
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. The maximum number of results to return from this request. Non-positive values are
                /// ignored. The presence of nextPageToken in the response indicates that more results might be
                /// available.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. If present, then retrieve the next batch of results from the preceding call to this
                /// method. pageToken must be the value of nextPageToken from the previous response. The values of other
                /// method parameters should be identical to those in the previous call.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/metrics";

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

            /// <summary>Creates or updates a logs-based metric.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="metricName">
            /// Required. The resource name of the metric to update: "projects/[PROJECT_ID]/metrics/[METRIC_ID]" The
            /// updated metric must be provided in the request and it's name field must be the same as [METRIC_ID] If
            /// the metric does not exist in [PROJECT_ID], then a new metric is created.
            /// </param>
            public virtual UpdateRequest Update(Google.Apis.Logging.v2.Data.LogMetric body, string metricName)
            {
                return new UpdateRequest(service, body, metricName);
            }

            /// <summary>Creates or updates a logs-based metric.</summary>
            public class UpdateRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogMetric>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Logging.v2.Data.LogMetric body, string metricName) : base(service)
                {
                    MetricName = metricName;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the metric to update: "projects/[PROJECT_ID]/metrics/[METRIC_ID]" The
                /// updated metric must be provided in the request and it's name field must be the same as [METRIC_ID]
                /// If the metric does not exist in [PROJECT_ID], then a new metric is created.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("metricName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string MetricName { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Logging.v2.Data.LogMetric Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "update";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+metricName}";

                /// <summary>Initializes Update parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("metricName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "metricName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/metrics/[^/]+$",
                    });
                }
            }
        }

        /// <summary>Gets the Sinks resource.</summary>
        public virtual SinksResource Sinks { get; }

        /// <summary>The "sinks" collection of methods.</summary>
        public class SinksResource
        {
            private const string Resource = "sinks";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public SinksResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Creates a sink that exports specified log entries to a destination. The export of newly-ingested log
            /// entries begins immediately, unless the sink's writer_identity is not permitted to write to the
            /// destination. A sink can export log entries only from the resource owning the sink.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The resource in which to create the sink: "projects/[PROJECT_ID]"
            /// "organizations/[ORGANIZATION_ID]" "billingAccounts/[BILLING_ACCOUNT_ID]" "folders/[FOLDER_ID]" Examples:
            /// "projects/my-logging-project", "organizations/123456789".
            /// </param>
            public virtual CreateRequest Create(Google.Apis.Logging.v2.Data.LogSink body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>
            /// Creates a sink that exports specified log entries to a destination. The export of newly-ingested log
            /// entries begins immediately, unless the sink's writer_identity is not permitted to write to the
            /// destination. A sink can export log entries only from the resource owning the sink.
            /// </summary>
            public class CreateRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogSink>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Logging.v2.Data.LogSink body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource in which to create the sink: "projects/[PROJECT_ID]"
                /// "organizations/[ORGANIZATION_ID]" "billingAccounts/[BILLING_ACCOUNT_ID]" "folders/[FOLDER_ID]"
                /// Examples: "projects/my-logging-project", "organizations/123456789".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. Determines the kind of IAM identity returned as writer_identity in the new sink. If this
                /// value is omitted or set to false, and if the sink's parent is a project, then the value returned as
                /// writer_identity is the same group or service account used by Logging before the addition of writer
                /// identities to this API. The sink's destination must be in the same project as the sink itself.If
                /// this field is set to true, or if the sink is owned by a non-project resource such as an
                /// organization, then the value of writer_identity will be a unique service account used only for
                /// exports from the new sink. For more information, see writer_identity in LogSink.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("uniqueWriterIdentity", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> UniqueWriterIdentity { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Logging.v2.Data.LogSink Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/sinks";

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
                    RequestParameters.Add("uniqueWriterIdentity", new Google.Apis.Discovery.Parameter
                    {
                        Name = "uniqueWriterIdentity",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Deletes a sink. If the sink has a unique writer_identity, then that service account is also deleted.
            /// </summary>
            /// <param name="sinkName">
            /// Required. The full resource name of the sink to delete, including the parent resource and the sink
            /// identifier: "projects/[PROJECT_ID]/sinks/[SINK_ID]" "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
            /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]" "folders/[FOLDER_ID]/sinks/[SINK_ID]" Example:
            /// "projects/my-project-id/sinks/my-sink-id".
            /// </param>
            public virtual DeleteRequest Delete(string sinkName)
            {
                return new DeleteRequest(service, sinkName);
            }

            /// <summary>
            /// Deletes a sink. If the sink has a unique writer_identity, then that service account is also deleted.
            /// </summary>
            public class DeleteRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string sinkName) : base(service)
                {
                    SinkName = sinkName;
                    InitParameters();
                }

                /// <summary>
                /// Required. The full resource name of the sink to delete, including the parent resource and the sink
                /// identifier: "projects/[PROJECT_ID]/sinks/[SINK_ID]"
                /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
                /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]" "folders/[FOLDER_ID]/sinks/[SINK_ID]"
                /// Example: "projects/my-project-id/sinks/my-sink-id".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("sinkName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string SinkName { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+sinkName}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("sinkName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "sinkName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/sinks/[^/]+$",
                    });
                }
            }

            /// <summary>Gets a sink.</summary>
            /// <param name="sinkName">
            /// Required. The resource name of the sink: "projects/[PROJECT_ID]/sinks/[SINK_ID]"
            /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]" "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
            /// "folders/[FOLDER_ID]/sinks/[SINK_ID]" Example: "projects/my-project-id/sinks/my-sink-id".
            /// </param>
            public virtual GetRequest Get(string sinkName)
            {
                return new GetRequest(service, sinkName);
            }

            /// <summary>Gets a sink.</summary>
            public class GetRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogSink>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string sinkName) : base(service)
                {
                    SinkName = sinkName;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the sink: "projects/[PROJECT_ID]/sinks/[SINK_ID]"
                /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
                /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]" "folders/[FOLDER_ID]/sinks/[SINK_ID]"
                /// Example: "projects/my-project-id/sinks/my-sink-id".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("sinkName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string SinkName { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+sinkName}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("sinkName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "sinkName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/sinks/[^/]+$",
                    });
                }
            }

            /// <summary>Lists sinks.</summary>
            /// <param name="parent">
            /// Required. The parent resource whose sinks are to be listed: "projects/[PROJECT_ID]"
            /// "organizations/[ORGANIZATION_ID]" "billingAccounts/[BILLING_ACCOUNT_ID]" "folders/[FOLDER_ID]"
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists sinks.</summary>
            public class ListRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.ListSinksResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent resource whose sinks are to be listed: "projects/[PROJECT_ID]"
                /// "organizations/[ORGANIZATION_ID]" "billingAccounts/[BILLING_ACCOUNT_ID]" "folders/[FOLDER_ID]"
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. The maximum number of results to return from this request. Non-positive values are
                /// ignored. The presence of nextPageToken in the response indicates that more results might be
                /// available.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. If present, then retrieve the next batch of results from the preceding call to this
                /// method. pageToken must be the value of nextPageToken from the previous response. The values of other
                /// method parameters should be identical to those in the previous call.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/sinks";

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
            /// Updates a sink. This method replaces the following fields in the existing sink with values from the new
            /// sink: destination, and filter.The updated sink might also have a new writer_identity; see the
            /// unique_writer_identity field.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="sinkName">
            /// Required. The full resource name of the sink to update, including the parent resource and the sink
            /// identifier: "projects/[PROJECT_ID]/sinks/[SINK_ID]" "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
            /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]" "folders/[FOLDER_ID]/sinks/[SINK_ID]" Example:
            /// "projects/my-project-id/sinks/my-sink-id".
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.Logging.v2.Data.LogSink body, string sinkName)
            {
                return new PatchRequest(service, body, sinkName);
            }

            /// <summary>
            /// Updates a sink. This method replaces the following fields in the existing sink with values from the new
            /// sink: destination, and filter.The updated sink might also have a new writer_identity; see the
            /// unique_writer_identity field.
            /// </summary>
            public class PatchRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogSink>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Logging.v2.Data.LogSink body, string sinkName) : base(service)
                {
                    SinkName = sinkName;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The full resource name of the sink to update, including the parent resource and the sink
                /// identifier: "projects/[PROJECT_ID]/sinks/[SINK_ID]"
                /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
                /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]" "folders/[FOLDER_ID]/sinks/[SINK_ID]"
                /// Example: "projects/my-project-id/sinks/my-sink-id".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("sinkName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string SinkName { get; private set; }

                /// <summary>
                /// Optional. See sinks.create for a description of this field. When updating a sink, the effect of this
                /// field on the value of writer_identity in the updated sink depends on both the old and new values of
                /// this field: If the old and new values of this field are both false or both true, then there is no
                /// change to the sink's writer_identity. If the old value is false and the new value is true, then
                /// writer_identity is changed to a unique service account. It is an error if the old value is true and
                /// the new value is set to false or defaulted to false.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("uniqueWriterIdentity", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> UniqueWriterIdentity { get; set; }

                /// <summary>
                /// Optional. Field mask that specifies the fields in sink that need an update. A sink field will be
                /// overwritten if, and only if, it is in the update mask. name and output only fields cannot be
                /// updated.An empty updateMask is temporarily treated as using the following mask for backwards
                /// compatibility purposes: destination,filter,includeChildren At some point in the future, behavior
                /// will be removed and specifying an empty updateMask will be an error.For a detailed FieldMask
                /// definition, see
                /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#google.protobuf.FieldMaskExample:
                /// updateMask=filter.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Logging.v2.Data.LogSink Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+sinkName}";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("sinkName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "sinkName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/sinks/[^/]+$",
                    });
                    RequestParameters.Add("uniqueWriterIdentity", new Google.Apis.Discovery.Parameter
                    {
                        Name = "uniqueWriterIdentity",
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
            /// Updates a sink. This method replaces the following fields in the existing sink with values from the new
            /// sink: destination, and filter.The updated sink might also have a new writer_identity; see the
            /// unique_writer_identity field.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="sinkName">
            /// Required. The full resource name of the sink to update, including the parent resource and the sink
            /// identifier: "projects/[PROJECT_ID]/sinks/[SINK_ID]" "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
            /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]" "folders/[FOLDER_ID]/sinks/[SINK_ID]" Example:
            /// "projects/my-project-id/sinks/my-sink-id".
            /// </param>
            public virtual UpdateRequest Update(Google.Apis.Logging.v2.Data.LogSink body, string sinkName)
            {
                return new UpdateRequest(service, body, sinkName);
            }

            /// <summary>
            /// Updates a sink. This method replaces the following fields in the existing sink with values from the new
            /// sink: destination, and filter.The updated sink might also have a new writer_identity; see the
            /// unique_writer_identity field.
            /// </summary>
            public class UpdateRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogSink>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Logging.v2.Data.LogSink body, string sinkName) : base(service)
                {
                    SinkName = sinkName;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The full resource name of the sink to update, including the parent resource and the sink
                /// identifier: "projects/[PROJECT_ID]/sinks/[SINK_ID]"
                /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
                /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]" "folders/[FOLDER_ID]/sinks/[SINK_ID]"
                /// Example: "projects/my-project-id/sinks/my-sink-id".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("sinkName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string SinkName { get; private set; }

                /// <summary>
                /// Optional. See sinks.create for a description of this field. When updating a sink, the effect of this
                /// field on the value of writer_identity in the updated sink depends on both the old and new values of
                /// this field: If the old and new values of this field are both false or both true, then there is no
                /// change to the sink's writer_identity. If the old value is false and the new value is true, then
                /// writer_identity is changed to a unique service account. It is an error if the old value is true and
                /// the new value is set to false or defaulted to false.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("uniqueWriterIdentity", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> UniqueWriterIdentity { get; set; }

                /// <summary>
                /// Optional. Field mask that specifies the fields in sink that need an update. A sink field will be
                /// overwritten if, and only if, it is in the update mask. name and output only fields cannot be
                /// updated.An empty updateMask is temporarily treated as using the following mask for backwards
                /// compatibility purposes: destination,filter,includeChildren At some point in the future, behavior
                /// will be removed and specifying an empty updateMask will be an error.For a detailed FieldMask
                /// definition, see
                /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#google.protobuf.FieldMaskExample:
                /// updateMask=filter.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Logging.v2.Data.LogSink Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "update";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+sinkName}";

                /// <summary>Initializes Update parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("sinkName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "sinkName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/sinks/[^/]+$",
                    });
                    RequestParameters.Add("uniqueWriterIdentity", new Google.Apis.Discovery.Parameter
                    {
                        Name = "uniqueWriterIdentity",
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
    }

    /// <summary>The "sinks" collection of methods.</summary>
    public class SinksResource
    {
        private const string Resource = "sinks";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public SinksResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Creates a sink that exports specified log entries to a destination. The export of newly-ingested log entries
        /// begins immediately, unless the sink's writer_identity is not permitted to write to the destination. A sink
        /// can export log entries only from the resource owning the sink.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="parent">
        /// Required. The resource in which to create the sink: "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]" "billingAccounts/[BILLING_ACCOUNT_ID]" "folders/[FOLDER_ID]" Examples:
        /// "projects/my-logging-project", "organizations/123456789".
        /// </param>
        public virtual CreateRequest Create(Google.Apis.Logging.v2.Data.LogSink body, string parent)
        {
            return new CreateRequest(service, body, parent);
        }

        /// <summary>
        /// Creates a sink that exports specified log entries to a destination. The export of newly-ingested log entries
        /// begins immediately, unless the sink's writer_identity is not permitted to write to the destination. A sink
        /// can export log entries only from the resource owning the sink.
        /// </summary>
        public class CreateRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogSink>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Logging.v2.Data.LogSink body, string parent) : base(service)
            {
                Parent = parent;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. The resource in which to create the sink: "projects/[PROJECT_ID]"
            /// "organizations/[ORGANIZATION_ID]" "billingAccounts/[BILLING_ACCOUNT_ID]" "folders/[FOLDER_ID]" Examples:
            /// "projects/my-logging-project", "organizations/123456789".
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>
            /// Optional. Determines the kind of IAM identity returned as writer_identity in the new sink. If this value
            /// is omitted or set to false, and if the sink's parent is a project, then the value returned as
            /// writer_identity is the same group or service account used by Logging before the addition of writer
            /// identities to this API. The sink's destination must be in the same project as the sink itself.If this
            /// field is set to true, or if the sink is owned by a non-project resource such as an organization, then
            /// the value of writer_identity will be a unique service account used only for exports from the new sink.
            /// For more information, see writer_identity in LogSink.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("uniqueWriterIdentity", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> UniqueWriterIdentity { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Logging.v2.Data.LogSink Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/{+parent}/sinks";

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
                    Pattern = @"^[^/]+/[^/]+$",
                });
                RequestParameters.Add("uniqueWriterIdentity", new Google.Apis.Discovery.Parameter
                {
                    Name = "uniqueWriterIdentity",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Deletes a sink. If the sink has a unique writer_identity, then that service account is also deleted.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The full resource name of the sink to delete, including the parent resource and the sink
        /// identifier: "projects/[PROJECT_ID]/sinks/[SINK_ID]" "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]" "folders/[FOLDER_ID]/sinks/[SINK_ID]" Example:
        /// "projects/my-project-id/sinks/my-sink-id".
        /// </param>
        public virtual DeleteRequest Delete(string sinkName)
        {
            return new DeleteRequest(service, sinkName);
        }

        /// <summary>
        /// Deletes a sink. If the sink has a unique writer_identity, then that service account is also deleted.
        /// </summary>
        public class DeleteRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.Empty>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string sinkName) : base(service)
            {
                SinkName = sinkName;
                InitParameters();
            }

            /// <summary>
            /// Required. The full resource name of the sink to delete, including the parent resource and the sink
            /// identifier: "projects/[PROJECT_ID]/sinks/[SINK_ID]" "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
            /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]" "folders/[FOLDER_ID]/sinks/[SINK_ID]" Example:
            /// "projects/my-project-id/sinks/my-sink-id".
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("sinkName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string SinkName { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/{+sinkName}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("sinkName", new Google.Apis.Discovery.Parameter
                {
                    Name = "sinkName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+/[^/]+/sinks/[^/]+$",
                });
            }
        }

        /// <summary>Gets a sink.</summary>
        /// <param name="sinkName">
        /// Required. The resource name of the sink: "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]" "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        /// "folders/[FOLDER_ID]/sinks/[SINK_ID]" Example: "projects/my-project-id/sinks/my-sink-id".
        /// </param>
        public virtual GetRequest Get(string sinkName)
        {
            return new GetRequest(service, sinkName);
        }

        /// <summary>Gets a sink.</summary>
        public class GetRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogSink>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string sinkName) : base(service)
            {
                SinkName = sinkName;
                InitParameters();
            }

            /// <summary>
            /// Required. The resource name of the sink: "projects/[PROJECT_ID]/sinks/[SINK_ID]"
            /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]" "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
            /// "folders/[FOLDER_ID]/sinks/[SINK_ID]" Example: "projects/my-project-id/sinks/my-sink-id".
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("sinkName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string SinkName { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/{+sinkName}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("sinkName", new Google.Apis.Discovery.Parameter
                {
                    Name = "sinkName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+/[^/]+/sinks/[^/]+$",
                });
            }
        }

        /// <summary>Lists sinks.</summary>
        /// <param name="parent">
        /// Required. The parent resource whose sinks are to be listed: "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]" "billingAccounts/[BILLING_ACCOUNT_ID]" "folders/[FOLDER_ID]"
        /// </param>
        public virtual ListRequest List(string parent)
        {
            return new ListRequest(service, parent);
        }

        /// <summary>Lists sinks.</summary>
        public class ListRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.ListSinksResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
            {
                Parent = parent;
                InitParameters();
            }

            /// <summary>
            /// Required. The parent resource whose sinks are to be listed: "projects/[PROJECT_ID]"
            /// "organizations/[ORGANIZATION_ID]" "billingAccounts/[BILLING_ACCOUNT_ID]" "folders/[FOLDER_ID]"
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>
            /// Optional. The maximum number of results to return from this request. Non-positive values are ignored.
            /// The presence of nextPageToken in the response indicates that more results might be available.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// Optional. If present, then retrieve the next batch of results from the preceding call to this method.
            /// pageToken must be the value of nextPageToken from the previous response. The values of other method
            /// parameters should be identical to those in the previous call.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/{+parent}/sinks";

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
                    Pattern = @"^[^/]+/[^/]+$",
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
        /// Updates a sink. This method replaces the following fields in the existing sink with values from the new
        /// sink: destination, and filter.The updated sink might also have a new writer_identity; see the
        /// unique_writer_identity field.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="sinkName">
        /// Required. The full resource name of the sink to update, including the parent resource and the sink
        /// identifier: "projects/[PROJECT_ID]/sinks/[SINK_ID]" "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]" "folders/[FOLDER_ID]/sinks/[SINK_ID]" Example:
        /// "projects/my-project-id/sinks/my-sink-id".
        /// </param>
        public virtual UpdateRequest Update(Google.Apis.Logging.v2.Data.LogSink body, string sinkName)
        {
            return new UpdateRequest(service, body, sinkName);
        }

        /// <summary>
        /// Updates a sink. This method replaces the following fields in the existing sink with values from the new
        /// sink: destination, and filter.The updated sink might also have a new writer_identity; see the
        /// unique_writer_identity field.
        /// </summary>
        public class UpdateRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.LogSink>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Logging.v2.Data.LogSink body, string sinkName) : base(service)
            {
                SinkName = sinkName;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. The full resource name of the sink to update, including the parent resource and the sink
            /// identifier: "projects/[PROJECT_ID]/sinks/[SINK_ID]" "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
            /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]" "folders/[FOLDER_ID]/sinks/[SINK_ID]" Example:
            /// "projects/my-project-id/sinks/my-sink-id".
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("sinkName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string SinkName { get; private set; }

            /// <summary>
            /// Optional. See sinks.create for a description of this field. When updating a sink, the effect of this
            /// field on the value of writer_identity in the updated sink depends on both the old and new values of this
            /// field: If the old and new values of this field are both false or both true, then there is no change to
            /// the sink's writer_identity. If the old value is false and the new value is true, then writer_identity is
            /// changed to a unique service account. It is an error if the old value is true and the new value is set to
            /// false or defaulted to false.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("uniqueWriterIdentity", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> UniqueWriterIdentity { get; set; }

            /// <summary>
            /// Optional. Field mask that specifies the fields in sink that need an update. A sink field will be
            /// overwritten if, and only if, it is in the update mask. name and output only fields cannot be updated.An
            /// empty updateMask is temporarily treated as using the following mask for backwards compatibility
            /// purposes: destination,filter,includeChildren At some point in the future, behavior will be removed and
            /// specifying an empty updateMask will be an error.For a detailed FieldMask definition, see
            /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#google.protobuf.FieldMaskExample:
            /// updateMask=filter.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Logging.v2.Data.LogSink Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/{+sinkName}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("sinkName", new Google.Apis.Discovery.Parameter
                {
                    Name = "sinkName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+/[^/]+/sinks/[^/]+$",
                });
                RequestParameters.Add("uniqueWriterIdentity", new Google.Apis.Discovery.Parameter
                {
                    Name = "uniqueWriterIdentity",
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

    /// <summary>The "v2" collection of methods.</summary>
    public class V2Resource
    {
        private const string Resource = "v2";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public V2Resource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Gets the Logs Router CMEK settings for the given resource.Note: CMEK for the Logs Router can currently only
        /// be configured for GCP organizations. Once configured, it applies to all projects and folders in the GCP
        /// organization.See Enabling CMEK for Logs Router
        /// (https://cloud.google.com/logging/docs/routing/managed-encryption) for more information.
        /// </summary>
        /// <param name="name">
        /// Required. The resource for which to retrieve CMEK settings. "projects/[PROJECT_ID]/cmekSettings"
        /// "organizations/[ORGANIZATION_ID]/cmekSettings" "billingAccounts/[BILLING_ACCOUNT_ID]/cmekSettings"
        /// "folders/[FOLDER_ID]/cmekSettings" Example: "organizations/12345/cmekSettings".Note: CMEK for the Logs
        /// Router can currently only be configured for GCP organizations. Once configured, it applies to all projects
        /// and folders in the GCP organization.
        /// </param>
        public virtual GetCmekSettingsRequest GetCmekSettings(string name)
        {
            return new GetCmekSettingsRequest(service, name);
        }

        /// <summary>
        /// Gets the Logs Router CMEK settings for the given resource.Note: CMEK for the Logs Router can currently only
        /// be configured for GCP organizations. Once configured, it applies to all projects and folders in the GCP
        /// organization.See Enabling CMEK for Logs Router
        /// (https://cloud.google.com/logging/docs/routing/managed-encryption) for more information.
        /// </summary>
        public class GetCmekSettingsRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.CmekSettings>
        {
            /// <summary>Constructs a new GetCmekSettings request.</summary>
            public GetCmekSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The resource for which to retrieve CMEK settings. "projects/[PROJECT_ID]/cmekSettings"
            /// "organizations/[ORGANIZATION_ID]/cmekSettings" "billingAccounts/[BILLING_ACCOUNT_ID]/cmekSettings"
            /// "folders/[FOLDER_ID]/cmekSettings" Example: "organizations/12345/cmekSettings".Note: CMEK for the Logs
            /// Router can currently only be configured for GCP organizations. Once configured, it applies to all
            /// projects and folders in the GCP organization.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getCmekSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/{+name}/cmekSettings";

            /// <summary>Initializes GetCmekSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Updates the Logs Router CMEK settings for the given resource.Note: CMEK for the Logs Router can currently
        /// only be configured for GCP organizations. Once configured, it applies to all projects and folders in the GCP
        /// organization.UpdateCmekSettings will fail if 1) kms_key_name is invalid, or 2) the associated service
        /// account does not have the required roles/cloudkms.cryptoKeyEncrypterDecrypter role assigned for the key, or
        /// 3) access to the key is disabled.See Enabling CMEK for Logs Router
        /// (https://cloud.google.com/logging/docs/routing/managed-encryption) for more information.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// Required. The resource name for the CMEK settings to update. "projects/[PROJECT_ID]/cmekSettings"
        /// "organizations/[ORGANIZATION_ID]/cmekSettings" "billingAccounts/[BILLING_ACCOUNT_ID]/cmekSettings"
        /// "folders/[FOLDER_ID]/cmekSettings" Example: "organizations/12345/cmekSettings".Note: CMEK for the Logs
        /// Router can currently only be configured for GCP organizations. Once configured, it applies to all projects
        /// and folders in the GCP organization.
        /// </param>
        public virtual UpdateCmekSettingsRequest UpdateCmekSettings(Google.Apis.Logging.v2.Data.CmekSettings body, string name)
        {
            return new UpdateCmekSettingsRequest(service, body, name);
        }

        /// <summary>
        /// Updates the Logs Router CMEK settings for the given resource.Note: CMEK for the Logs Router can currently
        /// only be configured for GCP organizations. Once configured, it applies to all projects and folders in the GCP
        /// organization.UpdateCmekSettings will fail if 1) kms_key_name is invalid, or 2) the associated service
        /// account does not have the required roles/cloudkms.cryptoKeyEncrypterDecrypter role assigned for the key, or
        /// 3) access to the key is disabled.See Enabling CMEK for Logs Router
        /// (https://cloud.google.com/logging/docs/routing/managed-encryption) for more information.
        /// </summary>
        public class UpdateCmekSettingsRequest : LoggingBaseServiceRequest<Google.Apis.Logging.v2.Data.CmekSettings>
        {
            /// <summary>Constructs a new UpdateCmekSettings request.</summary>
            public UpdateCmekSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.Logging.v2.Data.CmekSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. The resource name for the CMEK settings to update. "projects/[PROJECT_ID]/cmekSettings"
            /// "organizations/[ORGANIZATION_ID]/cmekSettings" "billingAccounts/[BILLING_ACCOUNT_ID]/cmekSettings"
            /// "folders/[FOLDER_ID]/cmekSettings" Example: "organizations/12345/cmekSettings".Note: CMEK for the Logs
            /// Router can currently only be configured for GCP organizations. Once configured, it applies to all
            /// projects and folders in the GCP organization.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>
            /// Optional. Field mask identifying which fields from cmek_settings should be updated. A field will be
            /// overwritten if and only if it is in the update mask. Output only fields cannot be updated.See FieldMask
            /// for more information.Example: "updateMask=kmsKeyName"
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Logging.v2.Data.CmekSettings Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateCmekSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/{+name}/cmekSettings";

            /// <summary>Initializes UpdateCmekSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+/[^/]+$",
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
namespace Google.Apis.Logging.v2.Data
{
    /// <summary>Options that change functionality of a sink exporting data to BigQuery.</summary>
    public class BigQueryOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Whether to use BigQuery's partition tables
        /// (https://cloud.google.com/bigquery/docs/partitioned-tables). By default, Logging creates dated tables based
        /// on the log entries' timestamps, e.g. syslog_20170523. With partitioned tables the date suffix is no longer
        /// present and special query syntax (https://cloud.google.com/bigquery/docs/querying-partitioned-tables) has to
        /// be used instead. In both cases, tables are sharded based on UTC timezone.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("usePartitionedTables")]
        public virtual System.Nullable<bool> UsePartitionedTables { get; set; }

        /// <summary>
        /// Output only. True if new timestamp column based partitioning is in use, false if legacy ingestion-time
        /// partitioning is in use. All new sinks will have this field set true and will use timestamp column based
        /// partitioning. If use_partitioned_tables is false, this value has no meaning and will be false. Legacy sinks
        /// using partitioned tables will have this field set to false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("usesTimestampColumnPartitioning")]
        public virtual System.Nullable<bool> UsesTimestampColumnPartitioning { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// BucketOptions describes the bucket boundaries used to create a histogram for the distribution. The buckets can
    /// be in a linear sequence, an exponential sequence, or each bucket can be specified explicitly. BucketOptions does
    /// not include the number of values in each bucket.A bucket has an inclusive lower bound and exclusive upper bound
    /// for the values that are counted for that bucket. The upper bound of a bucket must be strictly greater than the
    /// lower bound. The sequence of N buckets for a distribution consists of an underflow bucket (number 0), zero or
    /// more finite buckets (number 1 through N - 2) and an overflow bucket (number N - 1). The buckets are contiguous:
    /// the lower bound of bucket i (i &amp;gt; 0) is the same as the upper bound of bucket i - 1. The buckets span the
    /// whole range of finite values: lower bound of the underflow bucket is -infinity and the upper bound of the
    /// overflow bucket is +infinity. The finite buckets are so-called because both bounds are finite.
    /// </summary>
    public class BucketOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The explicit buckets.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("explicitBuckets")]
        public virtual Explicit ExplicitBuckets { get; set; }

        /// <summary>The exponential buckets.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exponentialBuckets")]
        public virtual Exponential ExponentialBuckets { get; set; }

        /// <summary>The linear bucket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linearBuckets")]
        public virtual Linear LinearBuckets { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for Operations.CancelOperation.</summary>
    public class CancelOperationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Describes the customer-managed encryption key (CMEK) settings associated with a project, folder, organization,
    /// billing account, or flexible resource.Note: CMEK for the Logs Router can currently only be configured for GCP
    /// organizations. Once configured, it applies to all projects and folders in the GCP organization.See Enabling CMEK
    /// for Logs Router (https://cloud.google.com/logging/docs/routing/managed-encryption) for more information.
    /// </summary>
    public class CmekSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The resource name for the configured Cloud KMS key.KMS key name format:
        /// "projects/PROJECT_ID/locations/LOCATION/keyRings/KEYRING/cryptoKeys/KEY"For example:
        /// "projects/my-project-id/locations/my-region/keyRings/key-ring-name/cryptoKeys/key-name"To enable CMEK for
        /// the Logs Router, set this field to a valid kms_key_name for which the associated service account has the
        /// required roles/cloudkms.cryptoKeyEncrypterDecrypter role assigned for the key.The Cloud KMS key used by the
        /// Log Router can be updated by changing the kms_key_name to a new valid key name. Encryption operations that
        /// are in progress will be completed with the key that was in use when they started. Decryption operations will
        /// be completed using the key that was used at the time of encryption unless access to that key has been
        /// revoked.To disable CMEK for the Logs Router, set this field to an empty string.See Enabling CMEK for Logs
        /// Router (https://cloud.google.com/logging/docs/routing/managed-encryption) for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeyName")]
        public virtual string KmsKeyName { get; set; }

        /// <summary>Output only. The resource name of the CMEK settings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The service account that will be used by the Logs Router to access your Cloud KMS key.Before
        /// enabling CMEK for Logs Router, you must first assign the role roles/cloudkms.cryptoKeyEncrypterDecrypter to
        /// the service account that the Logs Router will use to access your Cloud KMS key. Use GetCmekSettings to
        /// obtain the service account ID.See Enabling CMEK for Logs Router
        /// (https://cloud.google.com/logging/docs/routing/managed-encryption) for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccountId")]
        public virtual string ServiceAccountId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for CopyLogEntries long running operations.</summary>
    public class CopyLogEntriesMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifies whether the user has requested cancellation of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cancellationRequested")]
        public virtual System.Nullable<bool> CancellationRequested { get; set; }

        /// <summary>The end time of an operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>Estimated progress of the operation (0 - 100%).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progress")]
        public virtual System.Nullable<int> Progress { get; set; }

        /// <summary>CopyLogEntries RPC request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("request")]
        public virtual CopyLogEntriesRequest Request { get; set; }

        /// <summary>The create time of an operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>State of an operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// The IAM identity of a service account that must be granted access to the destination. If the service account
        /// is not granted permission to the destination within an hour, the operation will be cancelled. Example:
        /// "serviceAccount:foo@bar.com"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("writerIdentity")]
        public virtual string WriterIdentity { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The parameters to CopyLogEntries.</summary>
    public class CopyLogEntriesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Destination to which to copy logs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destination")]
        public virtual string Destination { get; set; }

        /// <summary>
        /// Optional. A filter specifying which log entries to copy. The filter must be no more than 20k characters. An
        /// empty filter matches all log entries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>
        /// Required. Bucket from which to copy logs. e.g.
        /// "projects/my-project/locations/my-location/buckets/my-source-bucket
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response type for CopyLogEntries long running operations.</summary>
    public class CopyLogEntriesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of log entries copied.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logEntriesCopiedCount")]
        public virtual System.Nullable<long> LogEntriesCopiedCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A generic empty message that you can re-use to avoid defining duplicated empty messages in your APIs. A typical
    /// example is to use it as the request or the response type of an API method. For instance: service Foo { rpc
    /// Bar(google.protobuf.Empty) returns (google.protobuf.Empty); } The JSON representation for Empty is empty JSON
    /// object {}.
    /// </summary>
    public class Empty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Specifies a set of buckets with arbitrary widths.There are size(bounds) + 1 (= N) buckets. Bucket i has the
    /// following boundaries:Upper bound (0 &amp;lt;= i &amp;lt; N-1): boundsi Lower bound (1 &amp;lt;= i &amp;lt; N);
    /// boundsi - 1The bounds field must contain at least one element. If bounds has only one element, then there are no
    /// finite buckets, and that single element is the common boundary of the overflow and underflow buckets.
    /// </summary>
    public class Explicit : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The values must be monotonically increasing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bounds")]
        public virtual System.Collections.Generic.IList<System.Nullable<double>> Bounds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Specifies an exponential sequence of buckets that have a width that is proportional to the value of the lower
    /// bound. Each bucket represents a constant relative uncertainty on a specific value in the bucket.There are
    /// num_finite_buckets + 2 (= N) buckets. Bucket i has the following boundaries:Upper bound (0 &amp;lt;= i &amp;lt;
    /// N-1): scale * (growth_factor ^ i). Lower bound (1 &amp;lt;= i &amp;lt; N): scale * (growth_factor ^ (i - 1)).
    /// </summary>
    public class Exponential : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Must be greater than 1.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("growthFactor")]
        public virtual System.Nullable<double> GrowthFactor { get; set; }

        /// <summary>Must be greater than 0.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numFiniteBuckets")]
        public virtual System.Nullable<int> NumFiniteBuckets { get; set; }

        /// <summary>Must be greater than 0.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scale")]
        public virtual System.Nullable<double> Scale { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A common proto for logging HTTP requests. Only contains semantics defined by the HTTP specification.
    /// Product-specific logging information MUST be defined in a separate message.
    /// </summary>
    public class HttpRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The number of HTTP response bytes inserted into cache. Set only when a cache fill was attempted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cacheFillBytes")]
        public virtual System.Nullable<long> CacheFillBytes { get; set; }

        /// <summary>Whether or not an entity was served from cache (with or without validation).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cacheHit")]
        public virtual System.Nullable<bool> CacheHit { get; set; }

        /// <summary>Whether or not a cache lookup was attempted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cacheLookup")]
        public virtual System.Nullable<bool> CacheLookup { get; set; }

        /// <summary>
        /// Whether or not the response was validated with the origin server before being served from cache. This field
        /// is only meaningful if cache_hit is True.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cacheValidatedWithOriginServer")]
        public virtual System.Nullable<bool> CacheValidatedWithOriginServer { get; set; }

        /// <summary>
        /// The request processing latency on the server, from the time the request was received until the response was
        /// sent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latency")]
        public virtual object Latency { get; set; }

        /// <summary>Protocol used for the request. Examples: "HTTP/1.1", "HTTP/2", "websocket"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protocol")]
        public virtual string Protocol { get; set; }

        /// <summary>
        /// The referer URL of the request, as defined in HTTP/1.1 Header Field Definitions
        /// (http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referer")]
        public virtual string Referer { get; set; }

        /// <summary>
        /// The IP address (IPv4 or IPv6) of the client that issued the HTTP request. This field can include port
        /// information. Examples: "192.168.1.1", "10.0.0.1:80", "FE80::0202:B3FF:FE1E:8329".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("remoteIp")]
        public virtual string RemoteIp { get; set; }

        /// <summary>The request method. Examples: "GET", "HEAD", "PUT", "POST".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestMethod")]
        public virtual string RequestMethod { get; set; }

        /// <summary>
        /// The size of the HTTP request message in bytes, including the request headers and the request body.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestSize")]
        public virtual System.Nullable<long> RequestSize { get; set; }

        /// <summary>
        /// The scheme (http, https), the host name, the path and the query portion of the URL that was requested.
        /// Example: "http://example.com/some/info?color=red".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestUrl")]
        public virtual string RequestUrl { get; set; }

        /// <summary>
        /// The size of the HTTP response message sent back to the client, in bytes, including the response headers and
        /// the response body.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseSize")]
        public virtual System.Nullable<long> ResponseSize { get; set; }

        /// <summary>
        /// The IP address (IPv4 or IPv6) of the origin server that the request was sent to. This field can include port
        /// information. Examples: "192.168.1.1", "10.0.0.1:80", "FE80::0202:B3FF:FE1E:8329".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serverIp")]
        public virtual string ServerIp { get; set; }

        /// <summary>The response code indicating the status of response. Examples: 200, 404.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual System.Nullable<int> Status { get; set; }

        /// <summary>
        /// The user agent sent by the client. Example: "Mozilla/4.0 (compatible; MSIE 6.0; Windows 98; Q312461; .NET
        /// CLR 1.0.3705)".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userAgent")]
        public virtual string UserAgent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A description of a label.</summary>
    public class LabelDescriptor : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A human-readable description for the label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The label key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>The type of data that can be assigned to the label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueType")]
        public virtual string ValueType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Specifies a linear sequence of buckets that all have the same width (except overflow and underflow). Each bucket
    /// represents a constant absolute uncertainty on the specific value in the bucket.There are num_finite_buckets + 2
    /// (= N) buckets. Bucket i has the following boundaries:Upper bound (0 &amp;lt;= i &amp;lt; N-1): offset + (width *
    /// i). Lower bound (1 &amp;lt;= i &amp;lt; N): offset + (width * (i - 1)).
    /// </summary>
    public class Linear : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Must be greater than 0.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numFiniteBuckets")]
        public virtual System.Nullable<int> NumFiniteBuckets { get; set; }

        /// <summary>Lower bound of the first bucket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offset")]
        public virtual System.Nullable<double> Offset { get; set; }

        /// <summary>Must be greater than 0.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("width")]
        public virtual System.Nullable<double> Width { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response from ListBuckets.</summary>
    public class ListBucketsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of buckets.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buckets")]
        public virtual System.Collections.Generic.IList<LogBucket> Buckets { get; set; }

        /// <summary>
        /// If there might be more results than appear in this response, then nextPageToken is included. To get the next
        /// set of results, call the same method again using the value of nextPageToken as pageToken.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Result returned from ListExclusions.</summary>
    public class ListExclusionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of exclusions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exclusions")]
        public virtual System.Collections.Generic.IList<LogExclusion> Exclusions { get; set; }

        /// <summary>
        /// If there might be more results than appear in this response, then nextPageToken is included. To get the next
        /// set of results, call the same method again using the value of nextPageToken as pageToken.
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

    /// <summary>The parameters to ListLogEntries.</summary>
    public class ListLogEntriesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A filter that chooses which log entries to return. See Advanced Logs Queries
        /// (https://cloud.google.com/logging/docs/view/advanced-queries). Only log entries that match the filter are
        /// returned. An empty filter matches all log entries in the resources listed in resource_names. Referencing a
        /// parent resource that is not listed in resource_names will cause the filter to return no results. The maximum
        /// length of the filter is 20000 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>
        /// Optional. How the results should be sorted. Presently, the only permitted values are "timestamp asc"
        /// (default) and "timestamp desc". The first option returns entries in order of increasing values of
        /// LogEntry.timestamp (oldest first), and the second option returns entries in order of decreasing timestamps
        /// (newest first). Entries with equal timestamps are returned in order of their insert_id values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orderBy")]
        public virtual string OrderBy { get; set; }

        /// <summary>
        /// Optional. The maximum number of results to return from this request. Default is 50. If the value is negative
        /// or exceeds 1000, the request is rejected. The presence of next_page_token in the response indicates that
        /// more results might be available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSize")]
        public virtual System.Nullable<int> PageSize { get; set; }

        /// <summary>
        /// Optional. If present, then retrieve the next batch of results from the preceding call to this method.
        /// page_token must be the value of next_page_token from the previous response. The values of other method
        /// parameters should be identical to those in the previous call.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageToken")]
        public virtual string PageToken { get; set; }

        /// <summary>
        /// Optional. Deprecated. Use resource_names instead. One or more project identifiers or project numbers from
        /// which to retrieve log entries. Example: "my-project-1A".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectIds")]
        public virtual System.Collections.Generic.IList<string> ProjectIds { get; set; }

        /// <summary>
        /// Required. Names of one or more parent resources from which to retrieve log entries: projects/[PROJECT_ID]
        /// organizations/[ORGANIZATION_ID] billingAccounts/[BILLING_ACCOUNT_ID] folders/[FOLDER_ID]May alternatively be
        /// one or more views: projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]
        /// organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]
        /// billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]
        /// folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]Projects listed in the
        /// project_ids field are added to this list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceNames")]
        public virtual System.Collections.Generic.IList<string> ResourceNames { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Result returned from ListLogEntries.</summary>
    public class ListLogEntriesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of log entries. If entries is empty, nextPageToken may still be returned, indicating that more
        /// entries may exist. See nextPageToken for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entries")]
        public virtual System.Collections.Generic.IList<LogEntry> Entries { get; set; }

        /// <summary>
        /// If there might be more results than those appearing in this response, then nextPageToken is included. To get
        /// the next set of results, call this method again using the value of nextPageToken as pageToken.If a value for
        /// next_page_token appears and the entries field is empty, it means that the search found no log entries so far
        /// but it did not have time to search all the possible log entries. Retry the method with this value for
        /// page_token to continue the search. Alternatively, consider speeding up the search by changing your filter to
        /// specify a single log name or resource type, or to narrow the time range of the search.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Result returned from ListLogMetrics.</summary>
    public class ListLogMetricsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of logs-based metrics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
        public virtual System.Collections.Generic.IList<LogMetric> Metrics { get; set; }

        /// <summary>
        /// If there might be more results than appear in this response, then nextPageToken is included. To get the next
        /// set of results, call this method again using the value of nextPageToken as pageToken.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Result returned from ListLogs.</summary>
    public class ListLogsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of log names. For example, "projects/my-project/logs/syslog" or
        /// "organizations/123/logs/cloudresourcemanager.googleapis.com%2Factivity".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logNames")]
        public virtual System.Collections.Generic.IList<string> LogNames { get; set; }

        /// <summary>
        /// If there might be more results than those appearing in this response, then nextPageToken is included. To get
        /// the next set of results, call this method again using the value of nextPageToken as pageToken.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Result returned from ListMonitoredResourceDescriptors.</summary>
    public class ListMonitoredResourceDescriptorsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If there might be more results than those appearing in this response, then nextPageToken is included. To get
        /// the next set of results, call this method again using the value of nextPageToken as pageToken.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A list of resource descriptors.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceDescriptors")]
        public virtual System.Collections.Generic.IList<MonitoredResourceDescriptor> ResourceDescriptors { get; set; }

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

    /// <summary>Result returned from ListSinks.</summary>
    public class ListSinksResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If there might be more results than appear in this response, then nextPageToken is included. To get the next
        /// set of results, call the same method again using the value of nextPageToken as pageToken.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A list of sinks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sinks")]
        public virtual System.Collections.Generic.IList<LogSink> Sinks { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response from ListViews.</summary>
    public class ListViewsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If there might be more results than appear in this response, then nextPageToken is included. To get the next
        /// set of results, call the same method again using the value of nextPageToken as pageToken.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A list of views.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("views")]
        public virtual System.Collections.Generic.IList<LogView> Views { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A resource that represents Google Cloud Platform location.</summary>
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

        /// <summary>The canonical id for this location. For example: "us-east1".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationId")]
        public virtual string LocationId { get; set; }

        /// <summary>Service-specific metadata. For example the available capacity at the given location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, object> Metadata { get; set; }

        /// <summary>
        /// Resource name for the location, which may vary between implementations. For example:
        /// "projects/example-project/locations/us-east1"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes a repository of logs.</summary>
    public class LogBucket : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The creation timestamp of the bucket. This is not set for any of the default buckets.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Describes this bucket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Output only. The bucket lifecycle state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lifecycleState")]
        public virtual string LifecycleState { get; set; }

        /// <summary>
        /// Whether the bucket has been locked. The retention period on a locked bucket may not be changed. Locked
        /// buckets may only be deleted if they are empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locked")]
        public virtual System.Nullable<bool> Locked { get; set; }

        /// <summary>
        /// Output only. The resource name of the bucket. For example:
        /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id" The supported locations are: global,
        /// us-central1, us-east1, us-west1, asia-east1, europe-west1.For the location of global it is unspecified where
        /// logs are actually stored. Once a bucket has been created, the location can not be changed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Log entry field paths that are denied access in this bucket. The following fields and their children are
        /// eligible: textPayload, jsonPayload, protoPayload, httpRequest, labels, sourceLocation. Restricting a
        /// repeated field will restrict all values. Adding a parent will block all child fields e.g. foo.bar will block
        /// foo.bar.baz.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restrictedFields")]
        public virtual System.Collections.Generic.IList<string> RestrictedFields { get; set; }

        /// <summary>
        /// Logs will be retained by default for this amount of time, after which they will automatically be deleted.
        /// The minimum retention period is 1 day. If this value is set to zero at bucket creation time, the default
        /// time of 30 days will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retentionDays")]
        public virtual System.Nullable<int> RetentionDays { get; set; }

        /// <summary>Output only. The last update timestamp of the bucket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An individual entry in a log.</summary>
    public class LogEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Information about the HTTP request associated with this log entry, if applicable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpRequest")]
        public virtual HttpRequest HttpRequest { get; set; }

        /// <summary>
        /// Optional. A unique identifier for the log entry. If you provide a value, then Logging considers other log
        /// entries in the same project, with the same timestamp, and with the same insert_id to be duplicates which are
        /// removed in a single query result. However, there are no guarantees of de-duplication in the export of
        /// logs.If the insert_id is omitted when writing a log entry, the Logging API assigns its own unique identifier
        /// in this field.In queries, the insert_id is also used to order log entries that have the same log_name and
        /// timestamp values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insertId")]
        public virtual string InsertId { get; set; }

        /// <summary>The log entry payload, represented as a structure that is expressed as a JSON object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jsonPayload")]
        public virtual System.Collections.Generic.IDictionary<string, object> JsonPayload { get; set; }

        /// <summary>
        /// Optional. A map of key, value pairs that provides additional information about the log entry. The labels can
        /// be user-defined or system-defined.User-defined labels are arbitrary key, value pairs that you can use to
        /// classify logs.System-defined labels are defined by GCP services for platform logs. They have two components
        /// - a service namespace component and the attribute name. For example:
        /// compute.googleapis.com/resource_name.Cloud Logging truncates label keys that exceed 512 B and label values
        /// that exceed 64 KB upon their associated log entry being written. The truncation is indicated by an ellipsis
        /// at the end of the character string.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Required. The resource name of the log to which this log entry belongs:
        /// "projects/[PROJECT_ID]/logs/[LOG_ID]" "organizations/[ORGANIZATION_ID]/logs/[LOG_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/logs/[LOG_ID]" "folders/[FOLDER_ID]/logs/[LOG_ID]" A project number
        /// may be used in place of PROJECT_ID. The project number is translated to its corresponding PROJECT_ID
        /// internally and the log_name field will contain PROJECT_ID in queries and exports.[LOG_ID] must be
        /// URL-encoded within log_name. Example:
        /// "organizations/1234567890/logs/cloudresourcemanager.googleapis.com%2Factivity".[LOG_ID] must be less than
        /// 512 characters long and can only include the following characters: upper and lower case alphanumeric
        /// characters, forward-slash, underscore, hyphen, and period.For backward compatibility, if log_name begins
        /// with a forward-slash, such as /projects/..., then the log entry is ingested as usual, but the forward-slash
        /// is removed. Listing the log entry will not show the leading slash and filtering for a log name with a
        /// leading slash will never return any results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logName")]
        public virtual string LogName { get; set; }

        /// <summary>
        /// Output only. Deprecated. This field is not used by Logging. Any value written to it is cleared.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual MonitoredResourceMetadata Metadata { get; set; }

        /// <summary>Optional. Information about an operation associated with the log entry, if applicable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operation")]
        public virtual LogEntryOperation Operation { get; set; }

        /// <summary>
        /// The log entry payload, represented as a protocol buffer. Some Google Cloud Platform services use this field
        /// for their log entry payloads.The following protocol buffer types are supported; user-defined types are not
        /// supported:"type.googleapis.com/google.cloud.audit.AuditLog"
        /// "type.googleapis.com/google.appengine.logging.v1.RequestLog"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protoPayload")]
        public virtual System.Collections.Generic.IDictionary<string, object> ProtoPayload { get; set; }

        /// <summary>Output only. The time the log entry was received by Logging.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("receiveTimestamp")]
        public virtual object ReceiveTimestamp { get; set; }

        /// <summary>
        /// Required. The monitored resource that produced this log entry.Example: a log entry that reports a database
        /// error would be associated with the monitored resource designating the particular database that reported the
        /// error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual MonitoredResource Resource { get; set; }

        /// <summary>Optional. The severity of the log entry. The default value is LogSeverity.DEFAULT.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>Optional. Source code location information associated with the log entry, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceLocation")]
        public virtual LogEntrySourceLocation SourceLocation { get; set; }

        /// <summary>
        /// Optional. The span ID within the trace associated with the log entry.For Trace spans, this is the same
        /// format that the Trace API v2 uses: a 16-character hexadecimal encoding of an 8-byte array, such as
        /// 000000000000004a.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spanId")]
        public virtual string SpanId { get; set; }

        /// <summary>The log entry payload, represented as a Unicode string (UTF-8).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textPayload")]
        public virtual string TextPayload { get; set; }

        /// <summary>
        /// Optional. The time the event described by the log entry occurred. This time is used to compute the log
        /// entry's age and to enforce the logs retention period. If this field is omitted in a new log entry, then
        /// Logging assigns it the current time. Timestamps have nanosecond accuracy, but trailing zeros in the
        /// fractional seconds might be omitted when the timestamp is displayed.Incoming log entries must have
        /// timestamps that don't exceed the logs retention period
        /// (https://cloud.google.com/logging/quotas#logs_retention_periods) in the past, and that don't exceed 24 hours
        /// in the future. Log entries outside those time boundaries aren't ingested by Logging.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timestamp")]
        public virtual object Timestamp { get; set; }

        /// <summary>
        /// Optional. Resource name of the trace associated with the log entry, if any. If it contains a relative
        /// resource name, the name is assumed to be relative to //tracing.googleapis.com. Example:
        /// projects/my-projectid/traces/06796866738c859f2f19b7cfb3214824
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trace")]
        public virtual string Trace { get; set; }

        /// <summary>
        /// Optional. The sampling decision of the trace associated with the log entry.True means that the trace
        /// resource name in the trace field was sampled for storage in a trace backend. False means that the trace was
        /// not sampled for storage when this log entry was written, or the sampling decision was unknown at the time. A
        /// non-sampled trace value is still useful as a request correlation identifier. The default is False.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("traceSampled")]
        public virtual System.Nullable<bool> TraceSampled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Additional information about a potentially long-running operation with which a log entry is associated.
    /// </summary>
    public class LogEntryOperation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Set this to True if this is the first log entry in the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("first")]
        public virtual System.Nullable<bool> First { get; set; }

        /// <summary>
        /// Optional. An arbitrary operation identifier. Log entries with the same identifier are assumed to be part of
        /// the same operation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Optional. Set this to True if this is the last log entry in the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("last")]
        public virtual System.Nullable<bool> Last { get; set; }

        /// <summary>
        /// Optional. An arbitrary producer identifier. The combination of id and producer must be globally unique.
        /// Examples for producer: "MyDivision.MyBigCompany.com", "github.com/MyProject/MyApplication".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("producer")]
        public virtual string Producer { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Additional information about the source code location that produced the log entry.</summary>
    public class LogEntrySourceLocation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Source file name. Depending on the runtime environment, this might be a simple name or a
        /// fully-qualified name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("file")]
        public virtual string File { get; set; }

        /// <summary>
        /// Optional. Human-readable name of the function or method being invoked, with optional context such as the
        /// class or package name. This information may be used in contexts such as the logs viewer, where a file and
        /// line number are less meaningful. The format can vary by language. For example: qual.if.ied.Class.method
        /// (Java), dir/package.func (Go), function (Python).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("function")]
        public virtual string Function { get; set; }

        /// <summary>Optional. Line within the source file. 1-based; 0 indicates no line number available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("line")]
        public virtual System.Nullable<long> Line { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Specifies a set of log entries that are not to be stored in Logging. If your GCP resource receives a large
    /// volume of logs, you can use exclusions to reduce your chargeable logs. Exclusions are processed after log sinks,
    /// so you can export log entries before they are excluded. Note that organization-level and folder-level exclusions
    /// don't apply to child resources, and that you can't exclude audit log entries.
    /// </summary>
    public class LogExclusion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The creation timestamp of the exclusion.This field may not be present for older exclusions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Optional. A description of this exclusion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. If set to True, then this exclusion is disabled and it does not exclude any log entries. You can
        /// update an exclusion to change the value of this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabled")]
        public virtual System.Nullable<bool> Disabled { get; set; }

        /// <summary>
        /// Required. An advanced logs filter (https://cloud.google.com/logging/docs/view/advanced-queries) that matches
        /// the log entries to be excluded. By using the sample function
        /// (https://cloud.google.com/logging/docs/view/advanced-queries#sample), you can exclude less than 100% of the
        /// matching log entries. For example, the following query matches 99% of low-severity log entries from Google
        /// Cloud Storage buckets:"resource.type=gcs_bucket severity&amp;lt;ERROR sample(insertId, 0.99)"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>
        /// Required. A client-assigned identifier, such as "load-balancer-exclusion". Identifiers are limited to 100
        /// characters and can include only letters, digits, underscores, hyphens, and periods. First character has to
        /// be alphanumeric.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The last update timestamp of the exclusion.This field may not be present for older exclusions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Application log line emitted while processing a request.</summary>
    public class LogLine : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>App-provided log message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logMessage")]
        public virtual string LogMessage { get; set; }

        /// <summary>Severity of this log entry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>Where in the source code this log message was written.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceLocation")]
        public virtual SourceLocation SourceLocation { get; set; }

        /// <summary>Approximate time when this log entry was made.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("time")]
        public virtual object Time { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Describes a logs-based metric. The value of the metric is the number of log entries that match a logs filter in
    /// a given time interval.Logs-based metrics can also be used to extract values from logs and create a distribution
    /// of the values. The distribution records the statistics of the extracted values along with an optional histogram
    /// of the values as specified by the bucket options.
    /// </summary>
    public class LogMetric : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The bucket_options are required when the logs-based metric is using a DISTRIBUTION value type and
        /// it describes the bucket boundaries used to create a histogram of the extracted values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucketOptions")]
        public virtual BucketOptions BucketOptions { get; set; }

        /// <summary>
        /// Output only. The creation timestamp of the metric.This field may not be present for older metrics.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Optional. A description of this metric, which is used in documentation. The maximum length of the
        /// description is 8000 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. If set to True, then this metric is disabled and it does not generate any points.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabled")]
        public virtual System.Nullable<bool> Disabled { get; set; }

        /// <summary>
        /// Required. An advanced logs filter (https://cloud.google.com/logging/docs/view/advanced_filters) which is
        /// used to match log entries. Example: "resource.type=gae_app AND severity&amp;gt;=ERROR" The maximum length of
        /// the filter is 20000 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>
        /// Optional. A map from a label key string to an extractor expression which is used to extract data from a log
        /// entry field and assign as the label value. Each label key specified in the LabelDescriptor must have an
        /// associated extractor expression in this map. The syntax of the extractor expression is the same as for the
        /// value_extractor field.The extracted value is converted to the type defined in the label descriptor. If the
        /// either the extraction or the type conversion fails, the label will have a default value. The default value
        /// for a string label is an empty string, for an integer label its 0, and for a boolean label its false.Note
        /// that there are upper bounds on the maximum number of labels and the number of active time series that are
        /// allowed in a project.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelExtractors")]
        public virtual System.Collections.Generic.IDictionary<string, string> LabelExtractors { get; set; }

        /// <summary>
        /// Optional. The metric descriptor associated with the logs-based metric. If unspecified, it uses a default
        /// metric descriptor with a DELTA metric kind, INT64 value type, with no labels and a unit of "1". Such a
        /// metric counts the number of log entries matching the filter expression.The name, type, and description
        /// fields in the metric_descriptor are output only, and is constructed using the name and description field in
        /// the LogMetric.To create a logs-based metric that records a distribution of log values, a DELTA metric kind
        /// with a DISTRIBUTION value type must be used along with a value_extractor expression in the LogMetric.Each
        /// label in the metric descriptor must have a matching label name as the key and an extractor expression as the
        /// value in the label_extractors map.The metric_kind and value_type fields in the metric_descriptor cannot be
        /// updated once initially configured. New labels can be added in the metric_descriptor, but existing labels
        /// cannot be modified except for their description.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricDescriptor")]
        public virtual MetricDescriptor MetricDescriptor { get; set; }

        /// <summary>
        /// Required. The client-assigned metric identifier. Examples: "error_count", "nginx/requests".Metric
        /// identifiers are limited to 100 characters and can include only the following characters: A-Z, a-z, 0-9, and
        /// the special characters _-.,+!*',()%/. The forward-slash character (/) denotes a hierarchy of name pieces,
        /// and it cannot be the first character of the name.The metric identifier in this field must not be URL-encoded
        /// (https://en.wikipedia.org/wiki/Percent-encoding). However, when the metric identifier appears as the
        /// [METRIC_ID] part of a metric_name API parameter, then the metric identifier must be URL-encoded. Example:
        /// "projects/my-project/metrics/nginx%2Frequests".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The last update timestamp of the metric.This field may not be present for older metrics.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>
        /// Optional. A value_extractor is required when using a distribution logs-based metric to extract the values to
        /// record from a log entry. Two functions are supported for value extraction: EXTRACT(field) or
        /// REGEXP_EXTRACT(field, regex). The argument are: 1. field: The name of the log entry field from which the
        /// value is to be extracted. 2. regex: A regular expression using the Google RE2 syntax
        /// (https://github.com/google/re2/wiki/Syntax) with a single capture group to extract data from the specified
        /// log entry field. The value of the field is converted to a string before applying the regex. It is an error
        /// to specify a regex that does not include exactly one capture group.The result of the extraction must be
        /// convertible to a double type, as the distribution always records double values. If either the extraction or
        /// the conversion to double fails, then those values are not recorded in the distribution.Example:
        /// REGEXP_EXTRACT(jsonPayload.request, ".*quantity=(\d+).*")
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueExtractor")]
        public virtual string ValueExtractor { get; set; }

        /// <summary>
        /// Deprecated. The API version that created or updated this metric. The v2 format is used by default and cannot
        /// be changed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Describes a sink used to export log entries to one of the following destinations in any project: a Cloud Storage
    /// bucket, a BigQuery dataset, a Cloud Pub/Sub topic or a Cloud Logging Bucket. A logs filter controls which log
    /// entries are exported. The sink must be created within a project, organization, billing account, or folder.
    /// </summary>
    public class LogSink : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Options that affect sinks exporting data to BigQuery.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bigqueryOptions")]
        public virtual BigQueryOptions BigqueryOptions { get; set; }

        /// <summary>
        /// Output only. The creation timestamp of the sink.This field may not be present for older sinks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Optional. A description of this sink. The maximum length of the description is 8000 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Required. The export destination: "storage.googleapis.com/[GCS_BUCKET]"
        /// "bigquery.googleapis.com/projects/[PROJECT_ID]/datasets/[DATASET]"
        /// "pubsub.googleapis.com/projects/[PROJECT_ID]/topics/[TOPIC_ID]" The sink's writer_identity, set when the
        /// sink is created, must have permission to write to the destination or else the log entries are not exported.
        /// For more information, see Exporting Logs with Sinks
        /// (https://cloud.google.com/logging/docs/api/tasks/exporting-logs).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destination")]
        public virtual string Destination { get; set; }

        /// <summary>
        /// Optional. If set to True, then this sink is disabled and it does not export any log entries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabled")]
        public virtual System.Nullable<bool> Disabled { get; set; }

        /// <summary>
        /// Optional. Log entries that match any of the exclusion filters will not be exported. If a log entry is
        /// matched by both filter and one of exclusion_filters it will not be exported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exclusions")]
        public virtual System.Collections.Generic.IList<LogExclusion> Exclusions { get; set; }

        /// <summary>
        /// Optional. An advanced logs filter (https://cloud.google.com/logging/docs/view/advanced-queries). The only
        /// exported log entries are those that are in the resource owning the sink and that match the filter. For
        /// example: logName="projects/[PROJECT_ID]/logs/[LOG_ID]" AND severity&amp;gt;=ERROR
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>
        /// Optional. This field applies only to sinks owned by organizations and folders. If the field is false, the
        /// default, only the logs owned by the sink's parent resource are available for export. If the field is true,
        /// then logs from all the projects, folders, and billing accounts contained in the sink's parent resource are
        /// also available for export. Whether a particular log entry from the children is exported depends on the
        /// sink's filter expression. For example, if this field is true, then the filter resource.type=gce_instance
        /// would export all Compute Engine VM instance log entries from all projects in the sink's parent. To only
        /// export entries from certain child projects, filter on the project part of the log name:
        /// logName:("projects/test-project1/" OR "projects/test-project2/") AND resource.type=gce_instance
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeChildren")]
        public virtual System.Nullable<bool> IncludeChildren { get; set; }

        /// <summary>
        /// Required. The client-assigned sink identifier, unique within the project. Example:
        /// "my-syslog-errors-to-pubsub". Sink identifiers are limited to 100 characters and can include only the
        /// following characters: upper and lower-case alphanumeric characters, underscores, hyphens, and periods. First
        /// character has to be alphanumeric.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Deprecated. This field is unused.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputVersionFormat")]
        public virtual string OutputVersionFormat { get; set; }

        /// <summary>
        /// Output only. The last update timestamp of the sink.This field may not be present for older sinks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>
        /// Output only. An IAM identity—a service account or group—under which Logging writes the exported log entries
        /// to the sink's destination. This field is set by sinks.create and sinks.update based on the value of
        /// unique_writer_identity in those methods.Until you grant this identity write-access to the destination, log
        /// entry exports from this sink will fail. For more information, see Granting Access for a Resource
        /// (https://cloud.google.com/iam/docs/granting-roles-to-service-accounts#granting_access_to_a_service_account_for_a_resource).
        /// Consult the destination service's documentation to determine the appropriate IAM roles to assign to the
        /// identity.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("writerIdentity")]
        public virtual string WriterIdentity { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes a view over logs in a bucket.</summary>
    public class LogView : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The creation timestamp of the view.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Describes this view.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Filter that restricts which log entries in a bucket are visible in this view. Filters are restricted to be a
        /// logical AND of ==/!= of any of the following: originating project/folder/organization/billing account.
        /// resource type log id Example: SOURCE("projects/myproject") AND resource.type = "gce_instance" AND
        /// LOG_ID("stdout")
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>
        /// The resource name of the view. For example
        /// "projects/my-project-id/locations/my-location/buckets/my-bucket-id/views/my-view
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The last update timestamp of the view.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Defines a metric type and its schema. Once a metric descriptor is created, deleting or altering it stops data
    /// collection and makes the metric type's existing data unusable.
    /// </summary>
    public class MetricDescriptor : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A detailed description of the metric, which can be used in documentation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// A concise name for the metric, which can be displayed in user interfaces. Use sentence case without an
        /// ending period, for example "Request count". This field is optional but it is recommended to be set for any
        /// metrics associated with user-visible concepts, such as Quota.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// The set of labels that can be used to describe a specific instance of this metric type. For example, the
        /// appengine.googleapis.com/http/server/response_latencies metric type has a label for the HTTP response code,
        /// response_code, so you can look at latencies for successful responses or just for responses that failed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IList<LabelDescriptor> Labels { get; set; }

        /// <summary>Optional. The launch stage of the metric definition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("launchStage")]
        public virtual string LaunchStage { get; set; }

        /// <summary>Optional. Metadata which can be used to guide usage of the metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual MetricDescriptorMetadata Metadata { get; set; }

        /// <summary>
        /// Whether the metric records instantaneous values, changes to a value, etc. Some combinations of metric_kind
        /// and value_type might not be supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricKind")]
        public virtual string MetricKind { get; set; }

        /// <summary>
        /// Read-only. If present, then a time series, which is identified partially by a metric type and a
        /// MonitoredResourceDescriptor, that is associated with this metric type can only be associated with one of the
        /// monitored resource types listed here.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("monitoredResourceTypes")]
        public virtual System.Collections.Generic.IList<string> MonitoredResourceTypes { get; set; }

        /// <summary>The resource name of the metric descriptor.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The metric type, including its DNS name prefix. The type is not URL-encoded. All user-defined metric types
        /// have the DNS name custom.googleapis.com or external.googleapis.com. Metric types should use a natural
        /// hierarchical grouping. For example: "custom.googleapis.com/invoice/paid/amount"
        /// "external.googleapis.com/prometheus/up" "appengine.googleapis.com/http/server/response_latencies"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>
        /// The units in which the metric value is reported. It is only applicable if the value_type is INT64, DOUBLE,
        /// or DISTRIBUTION. The unit defines the representation of the stored metric values.Different systems might
        /// scale the values to be more easily displayed (so a value of 0.02kBy might be displayed as 20By, and a value
        /// of 3523kBy might be displayed as 3.5MBy). However, if the unit is kBy, then the value of the metric is
        /// always in thousands of bytes, no matter how it might be displayed.If you want a custom metric to record the
        /// exact number of CPU-seconds used by a job, you can create an INT64 CUMULATIVE metric whose unit is s{CPU}
        /// (or equivalently 1s{CPU} or just s). If the job uses 12,005 CPU-seconds, then the value is written as
        /// 12005.Alternatively, if you want a custom metric to record data in a more granular way, you can create a
        /// DOUBLE CUMULATIVE metric whose unit is ks{CPU}, and then write the value 12.005 (which is 12005/1000), or
        /// use Kis{CPU} and write 11.723 (which is 12005/1024).The supported units are a subset of The Unified Code for
        /// Units of Measure (https://unitsofmeasure.org/ucum.html) standard:Basic units (UNIT) bit bit By byte s second
        /// min minute h hour d day 1 dimensionlessPrefixes (PREFIX) k kilo (10^3) M mega (10^6) G giga (10^9) T tera
        /// (10^12) P peta (10^15) E exa (10^18) Z zetta (10^21) Y yotta (10^24) m milli (10^-3) u micro (10^-6) n nano
        /// (10^-9) p pico (10^-12) f femto (10^-15) a atto (10^-18) z zepto (10^-21) y yocto (10^-24) Ki kibi (2^10) Mi
        /// mebi (2^20) Gi gibi (2^30) Ti tebi (2^40) Pi pebi (2^50)GrammarThe grammar also includes these connectors: /
        /// division or ratio (as an infix operator). For examples, kBy/{email} or MiBy/10ms (although you should almost
        /// never have /s in a metric unit; rates should always be computed at query time from the underlying cumulative
        /// or delta value). . multiplication or composition (as an infix operator). For examples, GBy.d or
        /// k{watt}.h.The grammar for a unit is as follows: Expression = Component { "." Component } { "/" Component } ;
        /// Component = ( [ PREFIX ] UNIT | "%" ) [ Annotation ] | Annotation | "1" ; Annotation = "{" NAME "}" ; Notes:
        /// Annotation is just a comment if it follows a UNIT. If the annotation is used alone, then the unit is
        /// equivalent to 1. For examples, {request}/s == 1/s, By{transmitted}/s == By/s. NAME is a sequence of
        /// non-blank printable ASCII characters not containing { or }. 1 represents a unitary dimensionless unit
        /// (https://en.wikipedia.org/wiki/Dimensionless_quantity) of 1, such as in 1/s. It is typically used when none
        /// of the basic units are appropriate. For example, "new users per day" can be represented as 1/d or
        /// {new-users}/d (and a metric value 5 would mean "5 new users). Alternatively, "thousands of page views per
        /// day" would be represented as 1000/d or k1/d or k{page_views}/d (and a metric value of 5.3 would mean "5300
        /// page views per day"). % represents dimensionless value of 1/100, and annotates values giving a percentage
        /// (so the metric values are typically in the range of 0..100, and a metric value 3 means "3 percent"). 10^2.%
        /// indicates a metric contains a ratio, typically in the range 0..1, that will be multiplied by 100 and
        /// displayed as a percentage (so a metric value 0.03 means "3 percent").
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unit")]
        public virtual string Unit { get; set; }

        /// <summary>
        /// Whether the measurement is an integer, a floating-point number, etc. Some combinations of metric_kind and
        /// value_type might not be supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueType")]
        public virtual string ValueType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Additional annotations that can be used to guide the usage of a metric.</summary>
    public class MetricDescriptorMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The delay of data points caused by ingestion. Data points older than this age are guaranteed to be ingested
        /// and available to be read, excluding data loss due to errors.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ingestDelay")]
        public virtual object IngestDelay { get; set; }

        /// <summary>Deprecated. Must use the MetricDescriptor.launch_stage instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("launchStage")]
        public virtual string LaunchStage { get; set; }

        /// <summary>
        /// The sampling period of metric data points. For metrics which are written periodically, consecutive data
        /// points are stored at this time interval, excluding data loss due to errors. Metrics with a higher
        /// granularity have a smaller sampling period.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("samplePeriod")]
        public virtual object SamplePeriod { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An object representing a resource that can be used for monitoring, logging, billing, or other purposes. Examples
    /// include virtual machine instances, databases, and storage devices such as disks. The type field identifies a
    /// MonitoredResourceDescriptor object that describes the resource's schema. Information in the labels field
    /// identifies the actual resource and its attributes according to the schema. For example, a particular Compute
    /// Engine VM instance could be represented by the following object, because the MonitoredResourceDescriptor for
    /// "gce_instance" has labels "instance_id" and "zone": { "type": "gce_instance", "labels": { "instance_id":
    /// "12345678901234", "zone": "us-central1-a" }}
    /// </summary>
    public class MonitoredResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Values for all of the labels listed in the associated monitored resource descriptor. For example,
        /// Compute Engine VM instances use the labels "project_id", "instance_id", and "zone".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Required. The monitored resource type. This field must match the type field of a MonitoredResourceDescriptor
        /// object. For example, the type of a Compute Engine VM instance is gce_instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An object that describes the schema of a MonitoredResource object using a type name and a set of labels. For
    /// example, the monitored resource descriptor for Google Compute Engine VM instances has a type of "gce_instance"
    /// and specifies the use of the labels "instance_id" and "zone" to identify particular VM instances.Different APIs
    /// can support different monitored resource types. APIs generally provide a list method that returns the monitored
    /// resource descriptors used by the API.
    /// </summary>
    public class MonitoredResourceDescriptor : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A detailed description of the monitored resource type that might be used in documentation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. A concise name for the monitored resource type that might be displayed in user interfaces. It
        /// should be a Title Cased Noun Phrase, without any article or other determiners. For example, "Google Cloud
        /// SQL Database".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Required. A set of labels used to describe instances of this monitored resource type. For example, an
        /// individual Google Cloud SQL database is identified by values for the labels "database_id" and "zone".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IList<LabelDescriptor> Labels { get; set; }

        /// <summary>Optional. The launch stage of the monitored resource definition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("launchStage")]
        public virtual string LaunchStage { get; set; }

        /// <summary>
        /// Optional. The resource name of the monitored resource descriptor:
        /// "projects/{project_id}/monitoredResourceDescriptors/{type}" where {type} is the value of the type field in
        /// this object and {project_id} is a project ID that provides API-specific context for accessing the type. APIs
        /// that do not use project information can use the resource name format "monitoredResourceDescriptors/{type}".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. The monitored resource type. For example, the type "cloudsql_database" represents databases in
        /// Google Cloud SQL.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Auxiliary metadata for a MonitoredResource object. MonitoredResource objects contain the minimum set of
    /// information to uniquely identify a monitored resource instance. There is some other useful auxiliary metadata.
    /// Monitoring and Logging use an ingestion pipeline to extract metadata for cloud resources of all types, and store
    /// the metadata in this message.
    /// </summary>
    public class MonitoredResourceMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Values for predefined system metadata labels. System labels are a kind of metadata extracted by
        /// Google, including "machine_image", "vpc", "subnet_id", "security_group", "name", etc. System label values
        /// can be only strings, Boolean values, or a list of strings. For example: { "name": "my-test-instance",
        /// "security_group": ["a", "b", "c"], "spot_instance": false }
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("systemLabels")]
        public virtual System.Collections.Generic.IDictionary<string, object> SystemLabels { get; set; }

        /// <summary>Output only. A map of user-defined metadata labels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userLabels")]
        public virtual System.Collections.Generic.IDictionary<string, string> UserLabels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This resource represents a long-running operation that is the result of a network API call.</summary>
    public class Operation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If the value is false, it means the operation is still in progress. If true, the operation is completed, and
        /// either error or response is available.
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
        /// use the default HTTP mapping, the name should be a resource name ending with operations/{unique_id}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The normal response of the operation in case of success. If the original method returns no data on success,
        /// such as Delete, the response is google.protobuf.Empty. If the original method is standard Get/Create/Update,
        /// the response should be the resource. For other methods, the response should have the type XxxResponse, where
        /// Xxx is the original method name. For example, if the original method name is TakeSnapshot(), the inferred
        /// response type is TakeSnapshotResponse.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("response")]
        public virtual System.Collections.Generic.IDictionary<string, object> Response { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Complete log information about a single HTTP request to an App Engine application.</summary>
    public class RequestLog : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>App Engine release version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appEngineRelease")]
        public virtual string AppEngineRelease { get; set; }

        /// <summary>Application that handled this request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appId")]
        public virtual string AppId { get; set; }

        /// <summary>An indication of the relative cost of serving this request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cost")]
        public virtual System.Nullable<double> Cost { get; set; }

        /// <summary>Time when the request finished.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>Whether this request is finished or active.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finished")]
        public virtual System.Nullable<bool> Finished { get; set; }

        /// <summary>
        /// Whether this is the first RequestLog entry for this request. If an active request has several RequestLog
        /// entries written to Stackdriver Logging, then this field will be set for one of them.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("first")]
        public virtual System.Nullable<bool> First { get; set; }

        /// <summary>Internet host and port number of the resource being requested.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("host")]
        public virtual string Host { get; set; }

        /// <summary>HTTP version of request. Example: "HTTP/1.1".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpVersion")]
        public virtual string HttpVersion { get; set; }

        /// <summary>An identifier for the instance that handled the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceId")]
        public virtual string InstanceId { get; set; }

        /// <summary>
        /// If the instance processing this request belongs to a manually scaled module, then this is the 0-based index
        /// of the instance. Otherwise, this value is -1.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceIndex")]
        public virtual System.Nullable<int> InstanceIndex { get; set; }

        /// <summary>Origin IP address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ip")]
        public virtual string Ip { get; set; }

        /// <summary>Latency of the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latency")]
        public virtual object Latency { get; set; }

        /// <summary>A list of log lines emitted by the application while serving this request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("line")]
        public virtual System.Collections.Generic.IList<LogLine> Line { get; set; }

        /// <summary>Number of CPU megacycles used to process request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("megaCycles")]
        public virtual System.Nullable<long> MegaCycles { get; set; }

        /// <summary>Request method. Example: "GET", "HEAD", "PUT", "POST", "DELETE".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("method")]
        public virtual string Method { get; set; }

        /// <summary>Module of the application that handled this request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("moduleId")]
        public virtual string ModuleId { get; set; }

        /// <summary>
        /// The logged-in user who made the request.Most likely, this is the part of the user's email before the @ sign.
        /// The field value is the same for different requests from the same user, but different users can have similar
        /// names. This information is also available to the application via the App Engine Users API.This field will be
        /// populated starting with App Engine 1.9.21.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nickname")]
        public virtual string Nickname { get; set; }

        /// <summary>Time this request spent in the pending request queue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pendingTime")]
        public virtual object PendingTime { get; set; }

        /// <summary>Referrer URL of request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referrer")]
        public virtual string Referrer { get; set; }

        /// <summary>
        /// Globally unique identifier for a request, which is based on the request start time. Request IDs for requests
        /// which started later will compare greater as strings than those for requests which started earlier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>
        /// Contains the path and query portion of the URL that was requested. For example, if the URL was
        /// "http://example.com/app?name=val", the resource would be "/app?name=val". The fragment identifier, which is
        /// identified by the # character, is not included.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual string Resource { get; set; }

        /// <summary>Size in bytes sent back to client by request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseSize")]
        public virtual System.Nullable<long> ResponseSize { get; set; }

        /// <summary>
        /// Source code for the application that handled this request. There can be more than one source reference per
        /// deployed application if source code is distributed among multiple repositories.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceReference")]
        public virtual System.Collections.Generic.IList<SourceReference> SourceReference { get; set; }

        /// <summary>Time when the request started.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>HTTP response status code. Example: 200, 404.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual System.Nullable<int> Status { get; set; }

        /// <summary>Task name of the request, in the case of an offline request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskName")]
        public virtual string TaskName { get; set; }

        /// <summary>Queue name of the request, in the case of an offline request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskQueueName")]
        public virtual string TaskQueueName { get; set; }

        /// <summary>Stackdriver Trace identifier for this request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("traceId")]
        public virtual string TraceId { get; set; }

        /// <summary>If true, the value in the 'trace_id' field was sampled for storage in a trace backend.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("traceSampled")]
        public virtual System.Nullable<bool> TraceSampled { get; set; }

        /// <summary>File or class that handled the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("urlMapEntry")]
        public virtual string UrlMapEntry { get; set; }

        /// <summary>User agent that made the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userAgent")]
        public virtual string UserAgent { get; set; }

        /// <summary>Version of the application that handled this request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionId")]
        public virtual string VersionId { get; set; }

        /// <summary>Whether this was a loading request for the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wasLoadingRequest")]
        public virtual System.Nullable<bool> WasLoadingRequest { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies a location in a source code file.</summary>
    public class SourceLocation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Source file name. Depending on the runtime environment, this might be a simple name or a fully-qualified
        /// name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("file")]
        public virtual string File { get; set; }

        /// <summary>
        /// Human-readable name of the function or method being invoked, with optional context such as the class or
        /// package name. This information is used in contexts such as the logs viewer, where a file and line number are
        /// less meaningful. The format can vary by language. For example: qual.if.ied.Class.method (Java),
        /// dir/package.func (Go), function (Python).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("functionName")]
        public virtual string FunctionName { get; set; }

        /// <summary>Line within the source file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("line")]
        public virtual System.Nullable<long> Line { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A reference to a particular snapshot of the source tree used to build and deploy an application.
    /// </summary>
    public class SourceReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A URI string identifying the repository. Example:
        /// "https://github.com/GoogleCloudPlatform/kubernetes.git"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repository")]
        public virtual string Repository { get; set; }

        /// <summary>
        /// The canonical and persistent identifier of the deployed revision. Example (git):
        /// "0035781c50ec7aa23385dc841529ce8a4b70db1b"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionId")]
        public virtual string RevisionId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The Status type defines a logical error model that is suitable for different programming environments, including
    /// REST APIs and RPC APIs. It is used by gRPC (https://github.com/grpc). Each Status message contains three pieces
    /// of data: error code, error message, and error details.You can find out more about this error model and how to
    /// work with it in the API Design Guide (https://cloud.google.com/apis/design/errors).
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

    /// <summary>Information about entries that were omitted from the session.</summary>
    public class SuppressionInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The reason that entries were omitted from the session.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>A lower bound on the count of entries omitted due to reason.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suppressedCount")]
        public virtual System.Nullable<int> SuppressedCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The parameters to TailLogEntries.</summary>
    public class TailLogEntriesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The amount of time to buffer log entries at the server before being returned to prevent out of
        /// order results due to late arriving log entries. Valid values are between 0-60000 milliseconds. Defaults to
        /// 2000 milliseconds.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bufferWindow")]
        public virtual object BufferWindow { get; set; }

        /// <summary>
        /// Optional. A filter that chooses which log entries to return. See Advanced Logs Filters
        /// (https://cloud.google.com/logging/docs/view/advanced_filters). Only log entries that match the filter are
        /// returned. An empty filter matches all log entries in the resources listed in resource_names. Referencing a
        /// parent resource that is not in resource_names will cause the filter to return no results. The maximum length
        /// of the filter is 20000 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>
        /// Required. Name of a parent resource from which to retrieve log entries: projects/[PROJECT_ID]
        /// organizations/[ORGANIZATION_ID] billingAccounts/[BILLING_ACCOUNT_ID] folders/[FOLDER_ID]May alternatively be
        /// one or more views: projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]
        /// organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]
        /// billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]
        /// folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceNames")]
        public virtual System.Collections.Generic.IList<string> ResourceNames { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Result returned from TailLogEntries.</summary>
    public class TailLogEntriesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of log entries. Each response in the stream will order entries with increasing values of
        /// LogEntry.timestamp. Ordering is not guaranteed between separate responses.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entries")]
        public virtual System.Collections.Generic.IList<LogEntry> Entries { get; set; }

        /// <summary>
        /// If entries that otherwise would have been included in the session were not sent back to the client, counts
        /// of relevant entries omitted from the session with the reason that they were not included. There will be at
        /// most one of each reason per response. The counts represent the number of suppressed entries since the last
        /// streamed response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suppressionInfo")]
        public virtual System.Collections.Generic.IList<SuppressionInfo> SuppressionInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The parameters to UndeleteBucket.</summary>
    public class UndeleteBucketRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The parameters to WriteLogEntries.</summary>
    public class WriteLogEntriesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. If true, the request should expect normal response, but the entries won't be persisted nor
        /// exported. Useful for checking whether the logging API endpoints are working properly before sending valuable
        /// data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dryRun")]
        public virtual System.Nullable<bool> DryRun { get; set; }

        /// <summary>
        /// Required. The log entries to send to Logging. The order of log entries in this list does not matter. Values
        /// supplied in this method's log_name, resource, and labels fields are copied into those log entries in this
        /// list that do not include values for their corresponding fields. For more information, see the LogEntry
        /// type.If the timestamp or insert_id fields are missing in log entries, then this method supplies the current
        /// time or a unique identifier, respectively. The supplied values are chosen so that, among the log entries
        /// that did not supply their own values, the entries earlier in the list will sort before the entries later in
        /// the list. See the entries.list method.Log entries with timestamps that are more than the logs retention
        /// period (https://cloud.google.com/logging/quotas) in the past or more than 24 hours in the future will not be
        /// available when calling entries.list. However, those log entries can still be exported with LogSinks
        /// (https://cloud.google.com/logging/docs/api/tasks/exporting-logs).To improve throughput and to avoid
        /// exceeding the quota limit (https://cloud.google.com/logging/quotas) for calls to entries.write, you should
        /// try to include several log entries in this list, rather than calling this method for each individual log
        /// entry.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entries")]
        public virtual System.Collections.Generic.IList<LogEntry> Entries { get; set; }

        /// <summary>
        /// Optional. Default labels that are added to the labels field of all log entries in entries. If a log entry
        /// already has a label with the same key as a label in this parameter, then the log entry's label is not
        /// changed. See LogEntry.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Optional. A default log resource name that is assigned to all log entries in entries that do not specify a
        /// value for log_name: projects/[PROJECT_ID]/logs/[LOG_ID] organizations/[ORGANIZATION_ID]/logs/[LOG_ID]
        /// billingAccounts/[BILLING_ACCOUNT_ID]/logs/[LOG_ID] folders/[FOLDER_ID]/logs/[LOG_ID][LOG_ID] must be
        /// URL-encoded. For example: "projects/my-project-id/logs/syslog"
        /// "organizations/123/logs/cloudaudit.googleapis.com%2Factivity" The permission logging.logEntries.create is
        /// needed on each project, organization, billing account, or folder that is receiving new log entries, whether
        /// the resource is specified in logName or in an individual log entry.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logName")]
        public virtual string LogName { get; set; }

        /// <summary>
        /// Optional. Whether valid entries should be written even if some other entries fail due to INVALID_ARGUMENT or
        /// PERMISSION_DENIED errors. If any entry is not written, then the response status is the error associated with
        /// one of the failed entries and the response includes error details keyed by the entries' zero-based index in
        /// the entries.write method.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partialSuccess")]
        public virtual System.Nullable<bool> PartialSuccess { get; set; }

        /// <summary>
        /// Optional. A default monitored resource object that is assigned to all log entries in entries that do not
        /// specify a value for resource. Example: { "type": "gce_instance", "labels": { "zone": "us-central1-a",
        /// "instance_id": "00000000000000000000" }} See LogEntry.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual MonitoredResource Resource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Result returned from WriteLogEntries.</summary>
    public class WriteLogEntriesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
