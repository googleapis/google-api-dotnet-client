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

namespace Google.Apis.FirebaseRealtimeDatabase.v1beta
{
    /// <summary>The FirebaseRealtimeDatabase Service.</summary>
    public class FirebaseRealtimeDatabaseService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1beta";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public FirebaseRealtimeDatabaseService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public FirebaseRealtimeDatabaseService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "firebasedatabase";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://firebasedatabase.googleapis.com/";
        #else
            "https://firebasedatabase.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://firebasedatabase.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Firebase Realtime Database Management API.</summary>
        public class Scope
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>View your data across Google Cloud Platform services</summary>
            public static string CloudPlatformReadOnly = "https://www.googleapis.com/auth/cloud-platform.read-only";

            /// <summary>View and administer all your Firebase data and settings</summary>
            public static string Firebase = "https://www.googleapis.com/auth/firebase";

            /// <summary>View all your Firebase data and settings</summary>
            public static string FirebaseReadonly = "https://www.googleapis.com/auth/firebase.readonly";
        }

        /// <summary>
        /// Available OAuth 2.0 scope constants for use with the Firebase Realtime Database Management API.
        /// </summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>View your data across Google Cloud Platform services</summary>
            public const string CloudPlatformReadOnly = "https://www.googleapis.com/auth/cloud-platform.read-only";

            /// <summary>View and administer all your Firebase data and settings</summary>
            public const string Firebase = "https://www.googleapis.com/auth/firebase";

            /// <summary>View all your Firebase data and settings</summary>
            public const string FirebaseReadonly = "https://www.googleapis.com/auth/firebase.readonly";
        }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for FirebaseRealtimeDatabase requests.</summary>
    public abstract class FirebaseRealtimeDatabaseBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new FirebaseRealtimeDatabaseBaseServiceRequest instance.</summary>
        protected FirebaseRealtimeDatabaseBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes FirebaseRealtimeDatabase parameter list.</summary>
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
                Instances = new InstancesResource(service);
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
                }

                /// <summary>
                /// Requests that a new DatabaseInstance be created. The state of a successfully created
                /// DatabaseInstance is ACTIVE. Only available for projects on the Blaze plan. Projects can be upgraded
                /// using the Cloud Billing API
                /// https://cloud.google.com/billing/reference/rest/v1/projects/updateBillingInfo. Note that it might
                /// take a few minutes for billing enablement state to propagate to Firebase systems.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// The parent project for which to create a database instance, in the form:
                /// `projects/{project-number}/locations/{location-id}`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.FirebaseRealtimeDatabase.v1beta.Data.DatabaseInstance body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>
                /// Requests that a new DatabaseInstance be created. The state of a successfully created
                /// DatabaseInstance is ACTIVE. Only available for projects on the Blaze plan. Projects can be upgraded
                /// using the Cloud Billing API
                /// https://cloud.google.com/billing/reference/rest/v1/projects/updateBillingInfo. Note that it might
                /// take a few minutes for billing enablement state to propagate to Firebase systems.
                /// </summary>
                public class CreateRequest : FirebaseRealtimeDatabaseBaseServiceRequest<Google.Apis.FirebaseRealtimeDatabase.v1beta.Data.DatabaseInstance>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseRealtimeDatabase.v1beta.Data.DatabaseInstance body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The parent project for which to create a database instance, in the form:
                    /// `projects/{project-number}/locations/{location-id}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>The globally unique identifier of the database instance.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("databaseId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string DatabaseId { get; set; }

                    /// <summary>When set to true, the request will be validated but not submitted.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.FirebaseRealtimeDatabase.v1beta.Data.DatabaseInstance Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+parent}/instances";

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
                        RequestParameters.Add("databaseId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "databaseId",
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

                /// <summary>
                /// Marks a DatabaseInstance to be deleted. The DatabaseInstance will be purged within 30 days. The
                /// default database cannot be deleted. IDs for deleted database instances may never be recovered or
                /// re-used. The Database may only be deleted if it is already in a DISABLED state.
                /// </summary>
                /// <param name="name">
                /// The fully qualified resource name of the database instance, in the form:
                /// `projects/{project-number}/locations/{location-id}/instances/{database-id}`
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>
                /// Marks a DatabaseInstance to be deleted. The DatabaseInstance will be purged within 30 days. The
                /// default database cannot be deleted. IDs for deleted database instances may never be recovered or
                /// re-used. The Database may only be deleted if it is already in a DISABLED state.
                /// </summary>
                public class DeleteRequest : FirebaseRealtimeDatabaseBaseServiceRequest<Google.Apis.FirebaseRealtimeDatabase.v1beta.Data.DatabaseInstance>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// The fully qualified resource name of the database instance, in the form:
                    /// `projects/{project-number}/locations/{location-id}/instances/{database-id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Disables a DatabaseInstance. The database can be re-enabled later using ReenableDatabaseInstance.
                /// When a database is disabled, all reads and writes are denied, including view access in the Firebase
                /// console.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The fully qualified resource name of the database instance, in the form:
                /// `projects/{project-number}/locations/{location-id}/instances/{database-id}`
                /// </param>
                public virtual DisableRequest Disable(Google.Apis.FirebaseRealtimeDatabase.v1beta.Data.DisableDatabaseInstanceRequest body, string name)
                {
                    return new DisableRequest(service, body, name);
                }

                /// <summary>
                /// Disables a DatabaseInstance. The database can be re-enabled later using ReenableDatabaseInstance.
                /// When a database is disabled, all reads and writes are denied, including view access in the Firebase
                /// console.
                /// </summary>
                public class DisableRequest : FirebaseRealtimeDatabaseBaseServiceRequest<Google.Apis.FirebaseRealtimeDatabase.v1beta.Data.DatabaseInstance>
                {
                    /// <summary>Constructs a new Disable request.</summary>
                    public DisableRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseRealtimeDatabase.v1beta.Data.DisableDatabaseInstanceRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The fully qualified resource name of the database instance, in the form:
                    /// `projects/{project-number}/locations/{location-id}/instances/{database-id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.FirebaseRealtimeDatabase.v1beta.Data.DisableDatabaseInstanceRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "disable";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+name}:disable";

                    /// <summary>Initializes Disable parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets the DatabaseInstance identified by the specified resource name.</summary>
                /// <param name="name">
                /// The fully qualified resource name of the database instance, in the form:
                /// `projects/{project-number}/locations/{location-id}/instances/{database-id}`. `database-id` is a
                /// globally unique identifier across all parent collections. For convenience, this method allows you to
                /// supply `-` as a wildcard character in place of specific collections under `projects` and
                /// `locations`. The resulting wildcarding form of the method is:
                /// `projects/-/locations/-/instances/{database-id}`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Gets the DatabaseInstance identified by the specified resource name.</summary>
                public class GetRequest : FirebaseRealtimeDatabaseBaseServiceRequest<Google.Apis.FirebaseRealtimeDatabase.v1beta.Data.DatabaseInstance>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// The fully qualified resource name of the database instance, in the form:
                    /// `projects/{project-number}/locations/{location-id}/instances/{database-id}`. `database-id` is a
                    /// globally unique identifier across all parent collections. For convenience, this method allows
                    /// you to supply `-` as a wildcard character in place of specific collections under `projects` and
                    /// `locations`. The resulting wildcarding form of the method is:
                    /// `projects/-/locations/-/instances/{database-id}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists each DatabaseInstance associated with the specified parent project. The list items are
                /// returned in no particular order, but will be a consistent view of the database instances when
                /// additional requests are made with a `pageToken`. The resulting list contains instances in any STATE.
                /// The list results may be stale by a few seconds. Use GetDatabaseInstance for consistent reads.
                /// </summary>
                /// <param name="parent">
                /// The parent project for which to list database instances, in the form:
                /// `projects/{project-number}/locations/{location-id}` To list across all locations, use a parent in
                /// the form: `projects/{project-number}/locations/-`
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>
                /// Lists each DatabaseInstance associated with the specified parent project. The list items are
                /// returned in no particular order, but will be a consistent view of the database instances when
                /// additional requests are made with a `pageToken`. The resulting list contains instances in any STATE.
                /// The list results may be stale by a few seconds. Use GetDatabaseInstance for consistent reads.
                /// </summary>
                public class ListRequest : FirebaseRealtimeDatabaseBaseServiceRequest<Google.Apis.FirebaseRealtimeDatabase.v1beta.Data.ListDatabaseInstancesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// The parent project for which to list database instances, in the form:
                    /// `projects/{project-number}/locations/{location-id}` To list across all locations, use a parent
                    /// in the form: `projects/{project-number}/locations/-`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// The maximum number of database instances to return in the response. The server may return fewer
                    /// than this at its discretion. If no value is specified (or too large a value is specified), then
                    /// the server will impose its own limit.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Token returned from a previous call to `ListDatabaseInstances` indicating where in the set of
                    /// database instances to resume listing.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+parent}/instances";

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
                /// Enables a DatabaseInstance. The database must have been disabled previously using
                /// DisableDatabaseInstance. The state of a successfully reenabled DatabaseInstance is ACTIVE.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The fully qualified resource name of the database instance, in the form:
                /// `projects/{project-number}/locations/{location-id}/instances/{database-id}`
                /// </param>
                public virtual ReenableRequest Reenable(Google.Apis.FirebaseRealtimeDatabase.v1beta.Data.ReenableDatabaseInstanceRequest body, string name)
                {
                    return new ReenableRequest(service, body, name);
                }

                /// <summary>
                /// Enables a DatabaseInstance. The database must have been disabled previously using
                /// DisableDatabaseInstance. The state of a successfully reenabled DatabaseInstance is ACTIVE.
                /// </summary>
                public class ReenableRequest : FirebaseRealtimeDatabaseBaseServiceRequest<Google.Apis.FirebaseRealtimeDatabase.v1beta.Data.DatabaseInstance>
                {
                    /// <summary>Constructs a new Reenable request.</summary>
                    public ReenableRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseRealtimeDatabase.v1beta.Data.ReenableDatabaseInstanceRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The fully qualified resource name of the database instance, in the form:
                    /// `projects/{project-number}/locations/{location-id}/instances/{database-id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.FirebaseRealtimeDatabase.v1beta.Data.ReenableDatabaseInstanceRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "reenable";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+name}:reenable";

                    /// <summary>Initializes Reenable parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
                        });
                    }
                }
            }
        }
    }
}
namespace Google.Apis.FirebaseRealtimeDatabase.v1beta.Data
{
    /// <summary>
    /// Representation of a Realtime Database instance. Details on interacting with contents of a DatabaseInstance can
    /// be found at: https://firebase.google.com/docs/database/rest/start.
    /// </summary>
    public class DatabaseInstance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Immutable. The globally unique hostname of the database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseUrl")]
        public virtual string DatabaseUrl { get; set; }

        /// <summary>
        /// The fully qualified resource name of the database instance, in the form:
        /// `projects/{project-number}/locations/{location-id}/instances/{database-id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The resource name of the project this instance belongs to. For example: `projects/{project-number}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("project")]
        public virtual string Project { get; set; }

        /// <summary>The database's lifecycle state. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// The database instance type. On creation only USER_DATABASE is allowed, which is also the default when
        /// omitted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request sent to the DisableDatabaseInstance method.</summary>
    public class DisableDatabaseInstanceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response from the ListDatabaseInstances method.</summary>
    public class ListDatabaseInstancesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of each DatabaseInstance that is in the parent Firebase project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instances")]
        public virtual System.Collections.Generic.IList<DatabaseInstance> Instances { get; set; }

        /// <summary>
        /// If the result list is too large to fit in a single response, then a token is returned. If the string is
        /// empty, then this response is the last page of results. This token can be used in a subsequent call to
        /// `ListDatabaseInstances` to find the next group of database instances. Page tokens are short-lived and should
        /// not be persisted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request sent to the ReenableDatabaseInstance method.</summary>
    public class ReenableDatabaseInstanceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
