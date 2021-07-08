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

namespace Google.Apis.Assuredworkloads.v1
{
    /// <summary>The Assuredworkloads Service.</summary>
    public class AssuredworkloadsService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public AssuredworkloadsService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public AssuredworkloadsService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Organizations = new OrganizationsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "assuredworkloads";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://assuredworkloads.googleapis.com/";
        #else
            "https://assuredworkloads.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://assuredworkloads.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Assured Workloads API.</summary>
        public class Scope
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Assured Workloads API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Organizations resource.</summary>
        public virtual OrganizationsResource Organizations { get; }
    }

    /// <summary>A base abstract class for Assuredworkloads requests.</summary>
    public abstract class AssuredworkloadsBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new AssuredworkloadsBaseServiceRequest instance.</summary>
        protected AssuredworkloadsBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Assuredworkloads parameter list.</summary>
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
                Operations = new OperationsResource(service);
                Workloads = new WorkloadsResource(service);
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
                public class GetRequest : AssuredworkloadsBaseServiceRequest<Google.Apis.Assuredworkloads.v1.Data.GoogleLongrunningOperation>
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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+/operations/[^/]+$",
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
                public class ListRequest : AssuredworkloadsBaseServiceRequest<Google.Apis.Assuredworkloads.v1.Data.GoogleLongrunningListOperationsResponse>
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

            /// <summary>Gets the Workloads resource.</summary>
            public virtual WorkloadsResource Workloads { get; }

            /// <summary>The "workloads" collection of methods.</summary>
            public class WorkloadsResource
            {
                private const string Resource = "workloads";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public WorkloadsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates Assured Workload.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The resource name of the new Workload's parent. Must be of the form
                /// `organizations/{org_id}/locations/{location_id}`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.Assuredworkloads.v1.Data.GoogleCloudAssuredworkloadsV1Workload body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Creates Assured Workload.</summary>
                public class CreateRequest : AssuredworkloadsBaseServiceRequest<Google.Apis.Assuredworkloads.v1.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Assuredworkloads.v1.Data.GoogleCloudAssuredworkloadsV1Workload body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the new Workload's parent. Must be of the form
                    /// `organizations/{org_id}/locations/{location_id}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. A identifier associated with the workload and underlying projects which allows for the
                    /// break down of billing costs for a workload. The value provided for the identifier will add a
                    /// label to the workload and contained projects with the identifier as the value.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("externalId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ExternalId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Assuredworkloads.v1.Data.GoogleCloudAssuredworkloadsV1Workload Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/workloads";

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
                        RequestParameters.Add("externalId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "externalId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Deletes the workload. Make sure that workload's direct children are already in a deleted state,
                /// otherwise the request will fail with a FAILED_PRECONDITION error.
                /// </summary>
                /// <param name="name">
                /// Required. The `name` field is used to identify the workload. Format:
                /// organizations/{org_id}/locations/{location_id}/workloads/{workload_id}
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>
                /// Deletes the workload. Make sure that workload's direct children are already in a deleted state,
                /// otherwise the request will fail with a FAILED_PRECONDITION error.
                /// </summary>
                public class DeleteRequest : AssuredworkloadsBaseServiceRequest<Google.Apis.Assuredworkloads.v1.Data.GoogleProtobufEmpty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The `name` field is used to identify the workload. Format:
                    /// organizations/{org_id}/locations/{location_id}/workloads/{workload_id}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. The etag of the workload. If this is provided, it must match the server's etag.
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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+/workloads/[^/]+$",
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

                /// <summary>Gets Assured Workload associated with a CRM Node</summary>
                /// <param name="name">
                /// Required. The resource name of the Workload to fetch. This is the workloads's relative path in the
                /// API, formatted as "organizations/{organization_id}/locations/{location_id}/workloads/{workload_id}".
                /// For example, "organizations/123/locations/us-east1/workloads/assured-workload-1".
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Gets Assured Workload associated with a CRM Node</summary>
                public class GetRequest : AssuredworkloadsBaseServiceRequest<Google.Apis.Assuredworkloads.v1.Data.GoogleCloudAssuredworkloadsV1Workload>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the Workload to fetch. This is the workloads's relative path in
                    /// the API, formatted as
                    /// "organizations/{organization_id}/locations/{location_id}/workloads/{workload_id}". For example,
                    /// "organizations/123/locations/us-east1/workloads/assured-workload-1".
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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+/workloads/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists Assured Workloads under a CRM Node.</summary>
                /// <param name="parent">
                /// Required. Parent Resource to list workloads from. Must be of the form
                /// `organizations/{org_id}/locations/{location}`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists Assured Workloads under a CRM Node.</summary>
                public class ListRequest : AssuredworkloadsBaseServiceRequest<Google.Apis.Assuredworkloads.v1.Data.GoogleCloudAssuredworkloadsV1ListWorkloadsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Parent Resource to list workloads from. Must be of the form
                    /// `organizations/{org_id}/locations/{location}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// A custom filter for filtering by properties of a workload. At this time, only filtering by
                    /// labels is supported.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Page size.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Page token returned from previous request. Page token contains context from previous request.
                    /// Page token needs to be passed in the second and following requests.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/workloads";

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
                /// Updates an existing workload. Currently allows updating of workload display_name and labels. For
                /// force updates don't set etag field in the Workload. Only one update operation per workload can be in
                /// progress.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Optional. The resource name of the workload. Format:
                /// organizations/{organization}/locations/{location}/workloads/{workload} Read-only.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.Assuredworkloads.v1.Data.GoogleCloudAssuredworkloadsV1Workload body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>
                /// Updates an existing workload. Currently allows updating of workload display_name and labels. For
                /// force updates don't set etag field in the Workload. Only one update operation per workload can be in
                /// progress.
                /// </summary>
                public class PatchRequest : AssuredworkloadsBaseServiceRequest<Google.Apis.Assuredworkloads.v1.Data.GoogleCloudAssuredworkloadsV1Workload>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Assuredworkloads.v1.Data.GoogleCloudAssuredworkloadsV1Workload body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Optional. The resource name of the workload. Format:
                    /// organizations/{organization}/locations/{location}/workloads/{workload} Read-only.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Required. The list of fields to be updated.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Assuredworkloads.v1.Data.GoogleCloudAssuredworkloadsV1Workload Body { get; set; }

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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+/workloads/[^/]+$",
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
}
namespace Google.Apis.Assuredworkloads.v1.Data
{
    /// <summary>Operation metadata to give request details of CreateWorkload.</summary>
    public class GoogleCloudAssuredworkloadsV1CreateWorkloadOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Compliance controls that should be applied to the resources managed by the workload.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("complianceRegime")]
        public virtual string ComplianceRegime { get; set; }

        /// <summary>Optional. Time when the operation was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Optional. The display name of the workload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Optional. The parent of the workload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response of ListWorkloads endpoint.</summary>
    public class GoogleCloudAssuredworkloadsV1ListWorkloadsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The next page token. Return empty if reached the last page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of Workloads under a given parent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workloads")]
        public virtual System.Collections.Generic.IList<GoogleCloudAssuredworkloadsV1Workload> Workloads { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An Workload object for managing highly regulated workloads of cloud customers.</summary>
    public class GoogleCloudAssuredworkloadsV1Workload : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Input only. The billing account used for the resources which are direct children of workload. This
        /// billing account is initially associated with the resources created as part of Workload creation. After the
        /// initial creation of these resources, the customer can change the assigned billing account. The resource name
        /// has the form `billingAccounts/{billing_account_id}`. For example, `billingAccounts/012345-567890-ABCDEF`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("billingAccount")]
        public virtual string BillingAccount { get; set; }

        /// <summary>Required. Immutable. Compliance Regime associated with this workload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("complianceRegime")]
        public virtual string ComplianceRegime { get; set; }

        /// <summary>Output only. Immutable. The Workload creation timestamp.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Required. The user-assigned display name of the Workload. When present it must be between 4 to 30
        /// characters. Allowed characters are: lowercase and uppercase letters, numbers, hyphen, and spaces. Example:
        /// My Workload
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Optional. ETag of the workload, it is calculated on the basis of the Workload contents. It will be used in
        /// Update &amp;amp; Delete operations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Input only. Settings used to create a CMEK crypto key. When set a project with a KMS CMEK key is
        /// provisioned. This field is mandatory for a subset of Compliance Regimes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsSettings")]
        public virtual GoogleCloudAssuredworkloadsV1WorkloadKMSSettings KmsSettings { get; set; }

        /// <summary>Optional. Labels applied to the workload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Optional. The resource name of the workload. Format:
        /// organizations/{organization}/locations/{location}/workloads/{workload} Read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Input only. The parent resource for the resources managed by this Assured Workload. May be either an
        /// organization or a folder. Must be the same or a child of the Workload parent. If not specified all resources
        /// are created under the Workload parent. Formats: folders/{folder_id} organizations/{organization_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provisionedResourcesParent")]
        public virtual string ProvisionedResourcesParent { get; set; }

        /// <summary>
        /// Input only. Resource properties that are used to customize workload resources. These properties (such as
        /// custom project id) will be used to create workload resources if possible. This field is optional.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceSettings")]
        public virtual System.Collections.Generic.IList<GoogleCloudAssuredworkloadsV1WorkloadResourceSettings> ResourceSettings { get; set; }

        /// <summary>
        /// Output only. The resources associated with this workload. These resources will be created when creating the
        /// workload. If any of the projects already exist, the workload creation will fail. Always read only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<GoogleCloudAssuredworkloadsV1WorkloadResourceInfo> Resources { get; set; }
    }

    /// <summary>Settings specific to the Key Management Service.</summary>
    public class GoogleCloudAssuredworkloadsV1WorkloadKMSSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Input only. Immutable. The time at which the Key Management Service will automatically create a
        /// new version of the crypto key and mark it as the primary.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextRotationTime")]
        public virtual object NextRotationTime { get; set; }

        /// <summary>
        /// Required. Input only. Immutable. [next_rotation_time] will be advanced by this period when the Key
        /// Management Service automatically rotates a key. Must be at least 24 hours and at most 876,000 hours.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rotationPeriod")]
        public virtual object RotationPeriod { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represent the resources that are children of this Workload.</summary>
    public class GoogleCloudAssuredworkloadsV1WorkloadResourceInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Resource identifier. For a project this represents project_number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceId")]
        public virtual System.Nullable<long> ResourceId { get; set; }

        /// <summary>Indicates the type of resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceType")]
        public virtual string ResourceType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represent the custom settings for the resources to be created.</summary>
    public class GoogleCloudAssuredworkloadsV1WorkloadResourceSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// User-assigned resource display name. If not empty it will be used to create a resource with the specified
        /// name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Resource identifier. For a project this represents project_id. If the project is already taken, the workload
        /// creation will fail.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceId")]
        public virtual string ResourceId { get; set; }

        /// <summary>
        /// Indicates the type of resource. This field should be specified to correspond the id to the right project
        /// type (CONSUMER_PROJECT or ENCRYPTION_KEYS_PROJECT)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceType")]
        public virtual string ResourceType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Operation metadata to give request details of CreateWorkload.</summary>
    public class GoogleCloudAssuredworkloadsV1beta1CreateWorkloadOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Compliance controls that should be applied to the resources managed by the workload.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("complianceRegime")]
        public virtual string ComplianceRegime { get; set; }

        /// <summary>Optional. Time when the operation was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Optional. The display name of the workload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Optional. The parent of the workload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>
        /// Optional. Resource properties in the input that are used for creating/customizing workload resources.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceSettings")]
        public virtual System.Collections.Generic.IList<GoogleCloudAssuredworkloadsV1beta1WorkloadResourceSettings> ResourceSettings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An Workload object for managing highly regulated workloads of cloud customers.</summary>
    public class GoogleCloudAssuredworkloadsV1beta1Workload : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Input only. The billing account used for the resources which are direct children of workload. This billing
        /// account is initially associated with the resources created as part of Workload creation. After the initial
        /// creation of these resources, the customer can change the assigned billing account. The resource name has the
        /// form `billingAccounts/{billing_account_id}`. For example, `billingAccounts/012345-567890-ABCDEF`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("billingAccount")]
        public virtual string BillingAccount { get; set; }

        /// <summary>Required. Input only. Immutable. Settings specific to resources needed for CJIS.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cjisSettings")]
        public virtual GoogleCloudAssuredworkloadsV1beta1WorkloadCJISSettings CjisSettings { get; set; }

        /// <summary>Required. Immutable. Compliance Regime associated with this workload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("complianceRegime")]
        public virtual string ComplianceRegime { get; set; }

        /// <summary>Output only. Immutable. The Workload creation timestamp.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Required. The user-assigned display name of the Workload. When present it must be between 4 to 30
        /// characters. Allowed characters are: lowercase and uppercase letters, numbers, hyphen, and spaces. Example:
        /// My Workload
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Optional. ETag of the workload, it is calculated on the basis of the Workload contents. It will be used in
        /// Update &amp;amp; Delete operations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Required. Input only. Immutable. Settings specific to resources needed for FedRAMP High.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fedrampHighSettings")]
        public virtual GoogleCloudAssuredworkloadsV1beta1WorkloadFedrampHighSettings FedrampHighSettings { get; set; }

        /// <summary>
        /// Required. Input only. Immutable. Settings specific to resources needed for FedRAMP Moderate.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fedrampModerateSettings")]
        public virtual GoogleCloudAssuredworkloadsV1beta1WorkloadFedrampModerateSettings FedrampModerateSettings { get; set; }

        /// <summary>Required. Input only. Immutable. Settings specific to resources needed for IL4.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("il4Settings")]
        public virtual GoogleCloudAssuredworkloadsV1beta1WorkloadIL4Settings Il4Settings { get; set; }

        /// <summary>
        /// Input only. Settings used to create a CMEK crypto key. When set a project with a KMS CMEK key is
        /// provisioned. This field is mandatory for a subset of Compliance Regimes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsSettings")]
        public virtual GoogleCloudAssuredworkloadsV1beta1WorkloadKMSSettings KmsSettings { get; set; }

        /// <summary>Optional. Labels applied to the workload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Optional. The resource name of the workload. Format:
        /// organizations/{organization}/locations/{location}/workloads/{workload} Read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Input only. The parent resource for the resources managed by this Assured Workload. May be either an
        /// organization or a folder. Must be the same or a child of the Workload parent. If not specified all resources
        /// are created under the Workload parent. Formats: folders/{folder_id} organizations/{organization_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provisionedResourcesParent")]
        public virtual string ProvisionedResourcesParent { get; set; }

        /// <summary>
        /// Input only. Resource properties that are used to customize workload resources. These properties (such as
        /// custom project id) will be used to create workload resources if possible. This field is optional.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceSettings")]
        public virtual System.Collections.Generic.IList<GoogleCloudAssuredworkloadsV1beta1WorkloadResourceSettings> ResourceSettings { get; set; }

        /// <summary>
        /// Output only. The resources associated with this workload. These resources will be created when creating the
        /// workload. If any of the projects already exist, the workload creation will fail. Always read only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<GoogleCloudAssuredworkloadsV1beta1WorkloadResourceInfo> Resources { get; set; }
    }

    /// <summary>Settings specific to resources needed for CJIS.</summary>
    public class GoogleCloudAssuredworkloadsV1beta1WorkloadCJISSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Input only. Immutable. Settings used to create a CMEK crypto key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsSettings")]
        public virtual GoogleCloudAssuredworkloadsV1beta1WorkloadKMSSettings KmsSettings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Settings specific to resources needed for FedRAMP High.</summary>
    public class GoogleCloudAssuredworkloadsV1beta1WorkloadFedrampHighSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Input only. Immutable. Settings used to create a CMEK crypto key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsSettings")]
        public virtual GoogleCloudAssuredworkloadsV1beta1WorkloadKMSSettings KmsSettings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Settings specific to resources needed for FedRAMP Moderate.</summary>
    public class GoogleCloudAssuredworkloadsV1beta1WorkloadFedrampModerateSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Input only. Immutable. Settings used to create a CMEK crypto key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsSettings")]
        public virtual GoogleCloudAssuredworkloadsV1beta1WorkloadKMSSettings KmsSettings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Settings specific to resources needed for IL4.</summary>
    public class GoogleCloudAssuredworkloadsV1beta1WorkloadIL4Settings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Input only. Immutable. Settings used to create a CMEK crypto key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsSettings")]
        public virtual GoogleCloudAssuredworkloadsV1beta1WorkloadKMSSettings KmsSettings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Settings specific to the Key Management Service.</summary>
    public class GoogleCloudAssuredworkloadsV1beta1WorkloadKMSSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Input only. Immutable. The time at which the Key Management Service will automatically create a
        /// new version of the crypto key and mark it as the primary.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextRotationTime")]
        public virtual object NextRotationTime { get; set; }

        /// <summary>
        /// Required. Input only. Immutable. [next_rotation_time] will be advanced by this period when the Key
        /// Management Service automatically rotates a key. Must be at least 24 hours and at most 876,000 hours.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rotationPeriod")]
        public virtual object RotationPeriod { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represent the resources that are children of this Workload.</summary>
    public class GoogleCloudAssuredworkloadsV1beta1WorkloadResourceInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Resource identifier. For a project this represents project_number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceId")]
        public virtual System.Nullable<long> ResourceId { get; set; }

        /// <summary>Indicates the type of resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceType")]
        public virtual string ResourceType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represent the custom settings for the resources to be created.</summary>
    public class GoogleCloudAssuredworkloadsV1beta1WorkloadResourceSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// User-assigned resource display name. If not empty it will be used to create a resource with the specified
        /// name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Resource identifier. For a project this represents project_id. If the project is already taken, the workload
        /// creation will fail.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceId")]
        public virtual string ResourceId { get; set; }

        /// <summary>
        /// Indicates the type of resource. This field should be specified to correspond the id to the right project
        /// type (CONSUMER_PROJECT or ENCRYPTION_KEYS_PROJECT)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceType")]
        public virtual string ResourceType { get; set; }

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
    /// Bar(google.protobuf.Empty) returns (google.protobuf.Empty); } The JSON representation for `Empty` is empty JSON
    /// object `{}`.
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
