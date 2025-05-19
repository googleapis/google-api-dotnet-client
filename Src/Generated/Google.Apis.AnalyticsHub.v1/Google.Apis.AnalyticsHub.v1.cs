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

namespace Google.Apis.AnalyticsHub.v1
{
    /// <summary>The AnalyticsHub Service.</summary>
    public class AnalyticsHubService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public AnalyticsHubService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public AnalyticsHubService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Organizations = new OrganizationsResource(this);
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://analyticshub.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://analyticshub.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "analyticshub";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Analytics Hub API.</summary>
        public class Scope
        {
            /// <summary>
            /// View and manage your data in Google BigQuery and see the email address for your Google Account
            /// </summary>
            public static string Bigquery = "https://www.googleapis.com/auth/bigquery";

            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Analytics Hub API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// View and manage your data in Google BigQuery and see the email address for your Google Account
            /// </summary>
            public const string Bigquery = "https://www.googleapis.com/auth/bigquery";

            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Organizations resource.</summary>
        public virtual OrganizationsResource Organizations { get; }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for AnalyticsHub requests.</summary>
    public abstract class AnalyticsHubBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new AnalyticsHubBaseServiceRequest instance.</summary>
        protected AnalyticsHubBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes AnalyticsHub parameter list.</summary>
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
                DataExchanges = new DataExchangesResource(service);
            }

            /// <summary>Gets the DataExchanges resource.</summary>
            public virtual DataExchangesResource DataExchanges { get; }

            /// <summary>The "dataExchanges" collection of methods.</summary>
            public class DataExchangesResource
            {
                private const string Resource = "dataExchanges";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public DataExchangesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Lists all data exchanges from projects in a given organization and location.</summary>
                /// <param name="organization">
                /// Required. The organization resource path of the projects containing DataExchanges. e.g.
                /// `organizations/myorg/locations/us`.
                /// </param>
                public virtual ListRequest List(string organization)
                {
                    return new ListRequest(this.service, organization);
                }

                /// <summary>Lists all data exchanges from projects in a given organization and location.</summary>
                public class ListRequest : AnalyticsHubBaseServiceRequest<Google.Apis.AnalyticsHub.v1.Data.ListOrgDataExchangesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string organization) : base(service)
                    {
                        Organization = organization;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The organization resource path of the projects containing DataExchanges. e.g.
                    /// `organizations/myorg/locations/us`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("organization", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Organization { get; private set; }

                    /// <summary>
                    /// The maximum number of results to return in a single response page. Leverage the page tokens to
                    /// iterate through the entire collection.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>Page token, returned by a previous call, to request the next page of results.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+organization}/dataExchanges";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("organization", new Google.Apis.Discovery.Parameter
                        {
                            Name = "organization",
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
                DataExchanges = new DataExchangesResource(service);
                Subscriptions = new SubscriptionsResource(service);
            }

            /// <summary>Gets the DataExchanges resource.</summary>
            public virtual DataExchangesResource DataExchanges { get; }

            /// <summary>The "dataExchanges" collection of methods.</summary>
            public class DataExchangesResource
            {
                private const string Resource = "dataExchanges";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public DataExchangesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Listings = new ListingsResource(service);
                }

                /// <summary>Gets the Listings resource.</summary>
                public virtual ListingsResource Listings { get; }

                /// <summary>The "listings" collection of methods.</summary>
                public class ListingsResource
                {
                    private const string Resource = "listings";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ListingsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Creates a new listing.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The parent resource path of the listing. e.g.
                    /// `projects/myproject/locations/us/dataExchanges/123`.
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.AnalyticsHub.v1.Data.Listing body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>Creates a new listing.</summary>
                    public class CreateRequest : AnalyticsHubBaseServiceRequest<Google.Apis.AnalyticsHub.v1.Data.Listing>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.AnalyticsHub.v1.Data.Listing body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent resource path of the listing. e.g.
                        /// `projects/myproject/locations/us/dataExchanges/123`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. The ID of the listing to create. Must contain only Unicode letters, numbers (0-9),
                        /// underscores (_). Max length: 100 bytes.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("listingId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string ListingId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.AnalyticsHub.v1.Data.Listing Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/listings";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/dataExchanges/[^/]+$",
                            });
                            RequestParameters.Add("listingId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "listingId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Deletes a listing.</summary>
                    /// <param name="name">
                    /// Required. Resource name of the listing to delete. e.g.
                    /// `projects/myproject/locations/us/dataExchanges/123/listings/456`.
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Deletes a listing.</summary>
                    public class DeleteRequest : AnalyticsHubBaseServiceRequest<Google.Apis.AnalyticsHub.v1.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Resource name of the listing to delete. e.g.
                        /// `projects/myproject/locations/us/dataExchanges/123/listings/456`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. If the listing is commercial then this field must be set to true, otherwise a
                        /// failure is thrown. This acts as a safety guard to avoid deleting commercial listings
                        /// accidentally.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("deleteCommercial", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> DeleteCommercial { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/dataExchanges/[^/]+/listings/[^/]+$",
                            });
                            RequestParameters.Add("deleteCommercial", new Google.Apis.Discovery.Parameter
                            {
                                Name = "deleteCommercial",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Gets the details of a listing.</summary>
                    /// <param name="name">
                    /// Required. The resource name of the listing. e.g.
                    /// `projects/myproject/locations/us/dataExchanges/123/listings/456`.
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets the details of a listing.</summary>
                    public class GetRequest : AnalyticsHubBaseServiceRequest<Google.Apis.AnalyticsHub.v1.Data.Listing>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the listing. e.g.
                        /// `projects/myproject/locations/us/dataExchanges/123/listings/456`.
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/dataExchanges/[^/]+/listings/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets the IAM policy.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy is being requested. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </param>
                    public virtual GetIamPolicyRequest GetIamPolicy(Google.Apis.AnalyticsHub.v1.Data.GetIamPolicyRequest body, string resource)
                    {
                        return new GetIamPolicyRequest(this.service, body, resource);
                    }

                    /// <summary>Gets the IAM policy.</summary>
                    public class GetIamPolicyRequest : AnalyticsHubBaseServiceRequest<Google.Apis.AnalyticsHub.v1.Data.Policy>
                    {
                        /// <summary>Constructs a new GetIamPolicy request.</summary>
                        public GetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.AnalyticsHub.v1.Data.GetIamPolicyRequest body, string resource) : base(service)
                        {
                            Resource = resource;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy is being requested. See [Resource
                        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for
                        /// this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.AnalyticsHub.v1.Data.GetIamPolicyRequest Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/dataExchanges/[^/]+/listings/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists all listings in a given project and location.</summary>
                    /// <param name="parent">
                    /// Required. The parent resource path of the listing. e.g.
                    /// `projects/myproject/locations/us/dataExchanges/123`.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists all listings in a given project and location.</summary>
                    public class ListRequest : AnalyticsHubBaseServiceRequest<Google.Apis.AnalyticsHub.v1.Data.ListListingsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent resource path of the listing. e.g.
                        /// `projects/myproject/locations/us/dataExchanges/123`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// The maximum number of results to return in a single response page. Leverage the page tokens
                        /// to iterate through the entire collection.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Page token, returned by a previous call, to request the next page of results.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/listings";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/dataExchanges/[^/]+$",
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

                    /// <summary>Lists all subscriptions on a given Data Exchange or Listing.</summary>
                    /// <param name="resource">
                    /// Required. Resource name of the requested target. This resource may be either a Listing or a
                    /// DataExchange. e.g. projects/123/locations/us/dataExchanges/456 OR e.g.
                    /// projects/123/locations/us/dataExchanges/456/listings/789
                    /// </param>
                    public virtual ListSubscriptionsRequest ListSubscriptions(string resource)
                    {
                        return new ListSubscriptionsRequest(this.service, resource);
                    }

                    /// <summary>Lists all subscriptions on a given Data Exchange or Listing.</summary>
                    public class ListSubscriptionsRequest : AnalyticsHubBaseServiceRequest<Google.Apis.AnalyticsHub.v1.Data.ListSharedResourceSubscriptionsResponse>
                    {
                        /// <summary>Constructs a new ListSubscriptions request.</summary>
                        public ListSubscriptionsRequest(Google.Apis.Services.IClientService service, string resource) : base(service)
                        {
                            Resource = resource;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Resource name of the requested target. This resource may be either a Listing or a
                        /// DataExchange. e.g. projects/123/locations/us/dataExchanges/456 OR e.g.
                        /// projects/123/locations/us/dataExchanges/456/listings/789
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>
                        /// If selected, includes deleted subscriptions in the response (up to 63 days after deletion).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("includeDeletedSubscriptions", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> IncludeDeletedSubscriptions { get; set; }

                        /// <summary>The maximum number of results to return in a single response page.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>Page token, returned by a previous call.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "listSubscriptions";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+resource}:listSubscriptions";

                        /// <summary>Initializes ListSubscriptions parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                            {
                                Name = "resource",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/dataExchanges/[^/]+/listings/[^/]+$",
                            });
                            RequestParameters.Add("includeDeletedSubscriptions", new Google.Apis.Discovery.Parameter
                            {
                                Name = "includeDeletedSubscriptions",
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

                    /// <summary>Updates an existing listing.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Output only. The resource name of the listing. e.g.
                    /// `projects/myproject/locations/us/dataExchanges/123/listings/456`
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.AnalyticsHub.v1.Data.Listing body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>Updates an existing listing.</summary>
                    public class PatchRequest : AnalyticsHubBaseServiceRequest<Google.Apis.AnalyticsHub.v1.Data.Listing>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.AnalyticsHub.v1.Data.Listing body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Output only. The resource name of the listing. e.g.
                        /// `projects/myproject/locations/us/dataExchanges/123/listings/456`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Required. Field mask specifies the fields to update in the listing resource. The fields
                        /// specified in the `updateMask` are relative to the resource and are not a full request.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.AnalyticsHub.v1.Data.Listing Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/dataExchanges/[^/]+/listings/[^/]+$",
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

                    /// <summary>Sets the IAM policy.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy is being specified. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </param>
                    public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.AnalyticsHub.v1.Data.SetIamPolicyRequest body, string resource)
                    {
                        return new SetIamPolicyRequest(this.service, body, resource);
                    }

                    /// <summary>Sets the IAM policy.</summary>
                    public class SetIamPolicyRequest : AnalyticsHubBaseServiceRequest<Google.Apis.AnalyticsHub.v1.Data.Policy>
                    {
                        /// <summary>Constructs a new SetIamPolicy request.</summary>
                        public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.AnalyticsHub.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
                        {
                            Resource = resource;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy is being specified. See [Resource
                        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for
                        /// this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.AnalyticsHub.v1.Data.SetIamPolicyRequest Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/dataExchanges/[^/]+/listings/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Subscribes to a listing. Currently, with Analytics Hub, you can create listings that reference
                    /// only BigQuery datasets. Upon subscription to a listing for a BigQuery dataset, Analytics Hub
                    /// creates a linked dataset in the subscriber's project.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. Resource name of the listing that you want to subscribe to. e.g.
                    /// `projects/myproject/locations/us/dataExchanges/123/listings/456`.
                    /// </param>
                    public virtual SubscribeRequest Subscribe(Google.Apis.AnalyticsHub.v1.Data.SubscribeListingRequest body, string name)
                    {
                        return new SubscribeRequest(this.service, body, name);
                    }

                    /// <summary>
                    /// Subscribes to a listing. Currently, with Analytics Hub, you can create listings that reference
                    /// only BigQuery datasets. Upon subscription to a listing for a BigQuery dataset, Analytics Hub
                    /// creates a linked dataset in the subscriber's project.
                    /// </summary>
                    public class SubscribeRequest : AnalyticsHubBaseServiceRequest<Google.Apis.AnalyticsHub.v1.Data.SubscribeListingResponse>
                    {
                        /// <summary>Constructs a new Subscribe request.</summary>
                        public SubscribeRequest(Google.Apis.Services.IClientService service, Google.Apis.AnalyticsHub.v1.Data.SubscribeListingRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Resource name of the listing that you want to subscribe to. e.g.
                        /// `projects/myproject/locations/us/dataExchanges/123/listings/456`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.AnalyticsHub.v1.Data.SubscribeListingRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "subscribe";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:subscribe";

                        /// <summary>Initializes Subscribe parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/dataExchanges/[^/]+/listings/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Returns the permissions that a caller has.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </param>
                    public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.AnalyticsHub.v1.Data.TestIamPermissionsRequest body, string resource)
                    {
                        return new TestIamPermissionsRequest(this.service, body, resource);
                    }

                    /// <summary>Returns the permissions that a caller has.</summary>
                    public class TestIamPermissionsRequest : AnalyticsHubBaseServiceRequest<Google.Apis.AnalyticsHub.v1.Data.TestIamPermissionsResponse>
                    {
                        /// <summary>Constructs a new TestIamPermissions request.</summary>
                        public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.AnalyticsHub.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
                        {
                            Resource = resource;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for
                        /// this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.AnalyticsHub.v1.Data.TestIamPermissionsRequest Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/dataExchanges/[^/]+/listings/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>Creates a new data exchange.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource path of the data exchange. e.g. `projects/myproject/locations/us`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.AnalyticsHub.v1.Data.DataExchange body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new data exchange.</summary>
                public class CreateRequest : AnalyticsHubBaseServiceRequest<Google.Apis.AnalyticsHub.v1.Data.DataExchange>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.AnalyticsHub.v1.Data.DataExchange body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource path of the data exchange. e.g. `projects/myproject/locations/us`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The ID of the data exchange. Must contain only Unicode letters, numbers (0-9),
                    /// underscores (_). Max length: 100 bytes.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("dataExchangeId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string DataExchangeId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AnalyticsHub.v1.Data.DataExchange Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/dataExchanges";

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
                        RequestParameters.Add("dataExchangeId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "dataExchangeId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes an existing data exchange.</summary>
                /// <param name="name">
                /// Required. The full name of the data exchange resource that you want to delete. For example,
                /// `projects/myproject/locations/us/dataExchanges/123`.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes an existing data exchange.</summary>
                public class DeleteRequest : AnalyticsHubBaseServiceRequest<Google.Apis.AnalyticsHub.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The full name of the data exchange resource that you want to delete. For example,
                    /// `projects/myproject/locations/us/dataExchanges/123`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/dataExchanges/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets the details of a data exchange.</summary>
                /// <param name="name">
                /// Required. The resource name of the data exchange. e.g.
                /// `projects/myproject/locations/us/dataExchanges/123`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets the details of a data exchange.</summary>
                public class GetRequest : AnalyticsHubBaseServiceRequest<Google.Apis.AnalyticsHub.v1.Data.DataExchange>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the data exchange. e.g.
                    /// `projects/myproject/locations/us/dataExchanges/123`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/dataExchanges/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets the IAM policy.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual GetIamPolicyRequest GetIamPolicy(Google.Apis.AnalyticsHub.v1.Data.GetIamPolicyRequest body, string resource)
                {
                    return new GetIamPolicyRequest(this.service, body, resource);
                }

                /// <summary>Gets the IAM policy.</summary>
                public class GetIamPolicyRequest : AnalyticsHubBaseServiceRequest<Google.Apis.AnalyticsHub.v1.Data.Policy>
                {
                    /// <summary>Constructs a new GetIamPolicy request.</summary>
                    public GetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.AnalyticsHub.v1.Data.GetIamPolicyRequest body, string resource) : base(service)
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
                    Google.Apis.AnalyticsHub.v1.Data.GetIamPolicyRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/dataExchanges/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists all data exchanges in a given project and location.</summary>
                /// <param name="parent">
                /// Required. The parent resource path of the data exchanges. e.g. `projects/myproject/locations/us`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists all data exchanges in a given project and location.</summary>
                public class ListRequest : AnalyticsHubBaseServiceRequest<Google.Apis.AnalyticsHub.v1.Data.ListDataExchangesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource path of the data exchanges. e.g.
                    /// `projects/myproject/locations/us`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// The maximum number of results to return in a single response page. Leverage the page tokens to
                    /// iterate through the entire collection.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>Page token, returned by a previous call, to request the next page of results.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/dataExchanges";

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

                /// <summary>Lists all subscriptions on a given Data Exchange or Listing.</summary>
                /// <param name="resource">
                /// Required. Resource name of the requested target. This resource may be either a Listing or a
                /// DataExchange. e.g. projects/123/locations/us/dataExchanges/456 OR e.g.
                /// projects/123/locations/us/dataExchanges/456/listings/789
                /// </param>
                public virtual ListSubscriptionsRequest ListSubscriptions(string resource)
                {
                    return new ListSubscriptionsRequest(this.service, resource);
                }

                /// <summary>Lists all subscriptions on a given Data Exchange or Listing.</summary>
                public class ListSubscriptionsRequest : AnalyticsHubBaseServiceRequest<Google.Apis.AnalyticsHub.v1.Data.ListSharedResourceSubscriptionsResponse>
                {
                    /// <summary>Constructs a new ListSubscriptions request.</summary>
                    public ListSubscriptionsRequest(Google.Apis.Services.IClientService service, string resource) : base(service)
                    {
                        Resource = resource;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Resource name of the requested target. This resource may be either a Listing or a
                    /// DataExchange. e.g. projects/123/locations/us/dataExchanges/456 OR e.g.
                    /// projects/123/locations/us/dataExchanges/456/listings/789
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>
                    /// If selected, includes deleted subscriptions in the response (up to 63 days after deletion).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("includeDeletedSubscriptions", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> IncludeDeletedSubscriptions { get; set; }

                    /// <summary>The maximum number of results to return in a single response page.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>Page token, returned by a previous call.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "listSubscriptions";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+resource}:listSubscriptions";

                    /// <summary>Initializes ListSubscriptions parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                        {
                            Name = "resource",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/dataExchanges/[^/]+$",
                        });
                        RequestParameters.Add("includeDeletedSubscriptions", new Google.Apis.Discovery.Parameter
                        {
                            Name = "includeDeletedSubscriptions",
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

                /// <summary>Updates an existing data exchange.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Output only. The resource name of the data exchange. e.g.
                /// `projects/myproject/locations/us/dataExchanges/123`.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.AnalyticsHub.v1.Data.DataExchange body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates an existing data exchange.</summary>
                public class PatchRequest : AnalyticsHubBaseServiceRequest<Google.Apis.AnalyticsHub.v1.Data.DataExchange>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.AnalyticsHub.v1.Data.DataExchange body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Output only. The resource name of the data exchange. e.g.
                    /// `projects/myproject/locations/us/dataExchanges/123`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Required. Field mask specifies the fields to update in the data exchange resource. The fields
                    /// specified in the `updateMask` are relative to the resource and are not a full request.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AnalyticsHub.v1.Data.DataExchange Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/dataExchanges/[^/]+$",
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

                /// <summary>Sets the IAM policy.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.AnalyticsHub.v1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(this.service, body, resource);
                }

                /// <summary>Sets the IAM policy.</summary>
                public class SetIamPolicyRequest : AnalyticsHubBaseServiceRequest<Google.Apis.AnalyticsHub.v1.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.AnalyticsHub.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                    Google.Apis.AnalyticsHub.v1.Data.SetIamPolicyRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/dataExchanges/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Creates a Subscription to a Data Clean Room. This is a long-running operation as it will create one
                /// or more linked datasets. Throws a Bad Request error if the Data Exchange does not contain any
                /// listings.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Resource name of the Data Exchange. e.g.
                /// `projects/publisherproject/locations/us/dataExchanges/123`
                /// </param>
                public virtual SubscribeRequest Subscribe(Google.Apis.AnalyticsHub.v1.Data.SubscribeDataExchangeRequest body, string name)
                {
                    return new SubscribeRequest(this.service, body, name);
                }

                /// <summary>
                /// Creates a Subscription to a Data Clean Room. This is a long-running operation as it will create one
                /// or more linked datasets. Throws a Bad Request error if the Data Exchange does not contain any
                /// listings.
                /// </summary>
                public class SubscribeRequest : AnalyticsHubBaseServiceRequest<Google.Apis.AnalyticsHub.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Subscribe request.</summary>
                    public SubscribeRequest(Google.Apis.Services.IClientService service, Google.Apis.AnalyticsHub.v1.Data.SubscribeDataExchangeRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Resource name of the Data Exchange. e.g.
                    /// `projects/publisherproject/locations/us/dataExchanges/123`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AnalyticsHub.v1.Data.SubscribeDataExchangeRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "subscribe";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:subscribe";

                    /// <summary>Initializes Subscribe parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/dataExchanges/[^/]+$",
                        });
                    }
                }

                /// <summary>Returns the permissions that a caller has.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.AnalyticsHub.v1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(this.service, body, resource);
                }

                /// <summary>Returns the permissions that a caller has.</summary>
                public class TestIamPermissionsRequest : AnalyticsHubBaseServiceRequest<Google.Apis.AnalyticsHub.v1.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.AnalyticsHub.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                    Google.Apis.AnalyticsHub.v1.Data.TestIamPermissionsRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/dataExchanges/[^/]+$",
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

                /// <summary>Deletes a subscription.</summary>
                /// <param name="name">
                /// Required. Resource name of the subscription to delete. e.g.
                /// projects/123/locations/us/subscriptions/456
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a subscription.</summary>
                public class DeleteRequest : AnalyticsHubBaseServiceRequest<Google.Apis.AnalyticsHub.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Resource name of the subscription to delete. e.g.
                    /// projects/123/locations/us/subscriptions/456
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/subscriptions/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets the details of a Subscription.</summary>
                /// <param name="name">
                /// Required. Resource name of the subscription. e.g. projects/123/locations/us/subscriptions/456
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets the details of a Subscription.</summary>
                public class GetRequest : AnalyticsHubBaseServiceRequest<Google.Apis.AnalyticsHub.v1.Data.Subscription>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Resource name of the subscription. e.g. projects/123/locations/us/subscriptions/456
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/subscriptions/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets the IAM policy.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual GetIamPolicyRequest GetIamPolicy(Google.Apis.AnalyticsHub.v1.Data.GetIamPolicyRequest body, string resource)
                {
                    return new GetIamPolicyRequest(this.service, body, resource);
                }

                /// <summary>Gets the IAM policy.</summary>
                public class GetIamPolicyRequest : AnalyticsHubBaseServiceRequest<Google.Apis.AnalyticsHub.v1.Data.Policy>
                {
                    /// <summary>Constructs a new GetIamPolicy request.</summary>
                    public GetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.AnalyticsHub.v1.Data.GetIamPolicyRequest body, string resource) : base(service)
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
                    Google.Apis.AnalyticsHub.v1.Data.GetIamPolicyRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/subscriptions/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists all subscriptions in a given project and location.</summary>
                /// <param name="parent">
                /// Required. The parent resource path of the subscription. e.g. projects/myproject/locations/us
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists all subscriptions in a given project and location.</summary>
                public class ListRequest : AnalyticsHubBaseServiceRequest<Google.Apis.AnalyticsHub.v1.Data.ListSubscriptionsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource path of the subscription. e.g. projects/myproject/locations/us
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// An expression for filtering the results of the request. Eligible fields for filtering are: +
                    /// `listing` + `data_exchange` Alternatively, a literal wrapped in double quotes may be provided.
                    /// This will be checked for an exact match against both fields above. In all cases, the full Data
                    /// Exchange or Listing resource name must be provided. Some example of using filters: +
                    /// data_exchange="projects/myproject/locations/us/dataExchanges/123" +
                    /// listing="projects/123/locations/us/dataExchanges/456/listings/789" +
                    /// "projects/myproject/locations/us/dataExchanges/123"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>The maximum number of results to return in a single response page.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>Page token, returned by a previous call.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/subscriptions";

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

                /// <summary>
                /// Refreshes a Subscription to a Data Exchange. A Data Exchange can become stale when a publisher adds
                /// or removes data. This is a long-running operation as it may create many linked datasets.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Resource name of the Subscription to refresh. e.g.
                /// `projects/subscriberproject/locations/us/subscriptions/123`
                /// </param>
                public virtual RefreshRequest Refresh(Google.Apis.AnalyticsHub.v1.Data.RefreshSubscriptionRequest body, string name)
                {
                    return new RefreshRequest(this.service, body, name);
                }

                /// <summary>
                /// Refreshes a Subscription to a Data Exchange. A Data Exchange can become stale when a publisher adds
                /// or removes data. This is a long-running operation as it may create many linked datasets.
                /// </summary>
                public class RefreshRequest : AnalyticsHubBaseServiceRequest<Google.Apis.AnalyticsHub.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Refresh request.</summary>
                    public RefreshRequest(Google.Apis.Services.IClientService service, Google.Apis.AnalyticsHub.v1.Data.RefreshSubscriptionRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Resource name of the Subscription to refresh. e.g.
                    /// `projects/subscriberproject/locations/us/subscriptions/123`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AnalyticsHub.v1.Data.RefreshSubscriptionRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "refresh";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:refresh";

                    /// <summary>Initializes Refresh parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/subscriptions/[^/]+$",
                        });
                    }
                }

                /// <summary>Revokes a given subscription.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Resource name of the subscription to revoke. e.g.
                /// projects/123/locations/us/subscriptions/456
                /// </param>
                public virtual RevokeRequest Revoke(Google.Apis.AnalyticsHub.v1.Data.RevokeSubscriptionRequest body, string name)
                {
                    return new RevokeRequest(this.service, body, name);
                }

                /// <summary>Revokes a given subscription.</summary>
                public class RevokeRequest : AnalyticsHubBaseServiceRequest<Google.Apis.AnalyticsHub.v1.Data.RevokeSubscriptionResponse>
                {
                    /// <summary>Constructs a new Revoke request.</summary>
                    public RevokeRequest(Google.Apis.Services.IClientService service, Google.Apis.AnalyticsHub.v1.Data.RevokeSubscriptionRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Resource name of the subscription to revoke. e.g.
                    /// projects/123/locations/us/subscriptions/456
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AnalyticsHub.v1.Data.RevokeSubscriptionRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "revoke";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:revoke";

                    /// <summary>Initializes Revoke parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/subscriptions/[^/]+$",
                        });
                    }
                }

                /// <summary>Sets the IAM policy.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.AnalyticsHub.v1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(this.service, body, resource);
                }

                /// <summary>Sets the IAM policy.</summary>
                public class SetIamPolicyRequest : AnalyticsHubBaseServiceRequest<Google.Apis.AnalyticsHub.v1.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.AnalyticsHub.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                    Google.Apis.AnalyticsHub.v1.Data.SetIamPolicyRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/subscriptions/[^/]+$",
                        });
                    }
                }
            }
        }
    }
}
namespace Google.Apis.AnalyticsHub.v1.Data
{
    /// <summary>
    /// Specifies the audit configuration for a service. The configuration determines which permission types are logged,
    /// and what identities, if any, are exempted from logging. An AuditConfig must have one or more AuditLogConfigs. If
    /// there are AuditConfigs for both `allServices` and a specific service, the union of the two AuditConfigs is used
    /// for that service: the log_types specified in each AuditConfig are enabled, and the exempted_members in each
    /// AuditLogConfig are exempted. Example Policy with multiple AuditConfigs: { "audit_configs": [ { "service":
    /// "allServices", "audit_log_configs": [ { "log_type": "DATA_READ", "exempted_members": [ "user:jose@example.com" ]
    /// }, { "log_type": "DATA_WRITE" }, { "log_type": "ADMIN_READ" } ] }, { "service": "sampleservice.googleapis.com",
    /// "audit_log_configs": [ { "log_type": "DATA_READ" }, { "log_type": "DATA_WRITE", "exempted_members": [
    /// "user:aliya@example.com" ] } ] } ] } For sampleservice, this policy enables DATA_READ, DATA_WRITE and ADMIN_READ
    /// logging. It also exempts `jose@example.com` from DATA_READ logging, and `aliya@example.com` from DATA_WRITE
    /// logging.
    /// </summary>
    public class AuditConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The configuration for logging of each type of permission.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditLogConfigs")]
        public virtual System.Collections.Generic.IList<AuditLogConfig> AuditLogConfigs { get; set; }

        /// <summary>
        /// Specifies a service that will be enabled for audit logging. For example, `storage.googleapis.com`,
        /// `cloudsql.googleapis.com`. `allServices` is a special value that covers all services.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("service")]
        public virtual string Service { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Provides the configuration for logging a type of permissions. Example: { "audit_log_configs": [ { "log_type":
    /// "DATA_READ", "exempted_members": [ "user:jose@example.com" ] }, { "log_type": "DATA_WRITE" } ] } This enables
    /// 'DATA_READ' and 'DATA_WRITE' logging, while exempting jose@example.com from DATA_READ logging.
    /// </summary>
    public class AuditLogConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Specifies the identities that do not cause logging for this type of permission. Follows the same format of
        /// Binding.members.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exemptedMembers")]
        public virtual System.Collections.Generic.IList<string> ExemptedMembers { get; set; }

        /// <summary>The log type that this config enables.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logType")]
        public virtual string LogType { get; set; }

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

    /// <summary>
    /// A reference to a shared dataset. It is an existing BigQuery dataset with a collection of objects such as tables
    /// and views that you want to share with subscribers. When subscriber's subscribe to a listing, Analytics Hub
    /// creates a linked dataset in the subscriber's project. A Linked dataset is an opaque, read-only BigQuery dataset
    /// that serves as a _symbolic link_ to a shared dataset.
    /// </summary>
    public class BigQueryDatasetSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Resource name of the dataset source for this listing. e.g. `projects/myproject/datasets/123`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataset")]
        public virtual string Dataset { get; set; }

        /// <summary>
        /// Optional. If set, restricted export policy will be propagated and enforced on the linked dataset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restrictedExportPolicy")]
        public virtual RestrictedExportPolicy RestrictedExportPolicy { get; set; }

        /// <summary>
        /// Optional. Resource in this dataset that is selectively shared. This field is required for data clean room
        /// exchanges.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selectedResources")]
        public virtual System.Collections.Generic.IList<SelectedResource> SelectedResources { get; set; }

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
        /// Optional. File batching settings. If no max_duration setting is specified, a max_duration of 5 minutes will
        /// be set by default. max_duration is required regardless of whether other file batching settings are
        /// specified. The maximum duration that can elapse before a new Cloud Storage file is created. Min 1 minute,
        /// max 10 minutes, default 5 minutes. May not exceed the subscription's acknowledgement deadline.
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

        /// <summary>Optional. If set, message data will be written to Cloud Storage in text format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textConfig")]
        public virtual TextConfig TextConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A data exchange is a container that lets you share data. Along with the descriptive information about the data
    /// exchange, it contains listings that reference shared datasets.
    /// </summary>
    public class DataExchange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Description of the data exchange. The description must not contain Unicode non-characters as well
        /// as C0 and C1 control codes except tabs (HT), new lines (LF), carriage returns (CR), and page breaks (FF).
        /// Default value is an empty string. Max length: 2000 bytes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. Type of discovery on the discovery page for all the listings under this exchange. Updating this
        /// field also updates (overwrites) the discovery_type field for all the listings under this exchange.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("discoveryType")]
        public virtual string DiscoveryType { get; set; }

        /// <summary>
        /// Required. Human-readable display name of the data exchange. The display name must contain only Unicode
        /// letters, numbers (0-9), underscores (_), dashes (-), spaces ( ), ampersands (&amp;amp;) and must not start
        /// or end with spaces. Default value is an empty string. Max length: 63 bytes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Optional. Documentation describing the data exchange.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentation")]
        public virtual string Documentation { get; set; }

        /// <summary>
        /// Optional. Base64 encoded image representing the data exchange. Max Size: 3.0MiB Expected image dimensions
        /// are 512x512 pixels, however the API only performs validation on size of the encoded data. Note: For byte
        /// fields, the content of the fields are base64-encoded (which increases the size of the data by 33-36%) when
        /// using JSON on the wire.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("icon")]
        public virtual string Icon { get; set; }

        /// <summary>Output only. Number of listings contained in the data exchange.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listingCount")]
        public virtual System.Nullable<int> ListingCount { get; set; }

        /// <summary>
        /// Optional. By default, false. If true, the DataExchange has an email sharing mandate enabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logLinkedDatasetQueryUserEmail")]
        public virtual System.Nullable<bool> LogLinkedDatasetQueryUserEmail { get; set; }

        /// <summary>
        /// Output only. The resource name of the data exchange. e.g.
        /// `projects/myproject/locations/us/dataExchanges/123`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. Email or URL of the primary point of contact of the data exchange. Max Length: 1000 bytes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryContact")]
        public virtual string PrimaryContact { get; set; }

        /// <summary>Optional. Configurable data sharing environment option for a data exchange.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sharingEnvironmentConfig")]
        public virtual SharingEnvironmentConfig SharingEnvironmentConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains details of the data provider.</summary>
    public class DataProvider : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Name of the data provider.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. Email or URL of the data provider. Max Length: 1000 bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryContact")]
        public virtual string PrimaryContact { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Data Clean Room (DCR), used for privacy-safe and secured data sharing.</summary>
    public class DcrExchangeConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. If True, when subscribing to this DCR, it will create only one linked dataset containing all
        /// resources shared within the cleanroom. If False, when subscribing to this DCR, it will create 1 linked
        /// dataset per listing. This is not configurable, and by default, all new DCRs will have the restriction set to
        /// True.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("singleLinkedDatasetPerCleanroom")]
        public virtual System.Nullable<bool> SingleLinkedDatasetPerCleanroom { get; set; }

        /// <summary>
        /// Output only. If True, this DCR restricts the contributors to sharing only a single resource in a Listing.
        /// And no two resources should have the same IDs. So if a contributor adds a view with a conflicting name, the
        /// CreateListing API will reject the request. if False, the data contributor can publish an entire dataset (as
        /// before). This is not configurable, and by default, all new DCRs will have the restriction set to True.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("singleSelectedResourceSharingRestriction")]
        public virtual System.Nullable<bool> SingleSelectedResourceSharingRestriction { get; set; }

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
        /// acknowledgement deadline has been exceeded for the message). A NACK is any call to ModifyAckDeadline with a
        /// 0 deadline. Note that client libraries may automatically extend ack_deadlines. This field will be honored on
        /// a best effort basis. If this parameter is 0, a default value of 5 is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxDeliveryAttempts")]
        public virtual System.Nullable<int> MaxDeliveryAttempts { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Default Analytics Hub data exchange, used for secured data sharing.</summary>
    public class DefaultExchangeConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines the destination bigquery dataset.</summary>
    public class DestinationDataset : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. A reference that identifies the destination dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datasetReference")]
        public virtual DestinationDatasetReference DatasetReference { get; set; }

        /// <summary>Optional. A user-friendly description of the dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Optional. A descriptive name for the dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("friendlyName")]
        public virtual string FriendlyName { get; set; }

        /// <summary>
        /// Optional. The labels associated with this dataset. You can use these to organize and group your datasets.
        /// You can set this property when inserting or updating a dataset. See
        /// https://cloud.google.com/resource-manager/docs/creating-managing-labels for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Required. The geographic location where the dataset should reside. See
        /// https://cloud.google.com/bigquery/docs/locations for supported locations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class DestinationDatasetReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. A unique ID for this dataset, without the project name. The ID must contain only letters (a-z,
        /// A-Z), numbers (0-9), or underscores (_). The maximum length is 1,024 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datasetId")]
        public virtual string DatasetId { get; set; }

        /// <summary>Required. The ID of the project containing this dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines the destination Pub/Sub subscription.</summary>
    public class DestinationPubSubSubscription : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Destination Pub/Sub subscription resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pubsubSubscription")]
        public virtual GooglePubsubV1Subscription PubsubSubscription { get; set; }

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
    /// Commercial info contains the information about the commercial data products associated with the listing.
    /// </summary>
    public class GoogleCloudBigqueryAnalyticshubV1ListingCommercialInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Details of the Marketplace Data Product associated with the Listing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudMarketplace")]
        public virtual GoogleCloudBigqueryAnalyticshubV1ListingCommercialInfoGoogleCloudMarketplaceInfo CloudMarketplace { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies the details of the Marketplace Data Product associated with the Listing.</summary>
    public class GoogleCloudBigqueryAnalyticshubV1ListingCommercialInfoGoogleCloudMarketplaceInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Commercial state of the Marketplace Data Product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commercialState")]
        public virtual string CommercialState { get; set; }

        /// <summary>
        /// Output only. Resource name of the commercial service associated with the Marketplace Data Product. e.g.
        /// example.com
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("service")]
        public virtual string Service { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Commercial info metadata for this subscription.</summary>
    public class GoogleCloudBigqueryAnalyticshubV1SubscriptionCommercialInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. This is set when the subscription is commercialised via Cloud Marketplace.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudMarketplace")]
        public virtual GoogleCloudBigqueryAnalyticshubV1SubscriptionCommercialInfoGoogleCloudMarketplaceInfo CloudMarketplace { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Cloud Marketplace commercial metadata for this subscription.</summary>
    public class GoogleCloudBigqueryAnalyticshubV1SubscriptionCommercialInfoGoogleCloudMarketplaceInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Resource name of the Marketplace Order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("order")]
        public virtual string Order { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Defines the destination Pub/Sub subscription. If none of `push_config`, `bigquery_config`,
    /// `cloud_storage_config`, `pubsub_export_config`, or `pubsublite_export_config` is set, then the subscriber will
    /// pull and ack messages using API methods. At most one of these fields may be set.
    /// </summary>
    public class GooglePubsubV1Subscription : Google.Apis.Requests.IDirectResponseSchema
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
        /// resent before the message's acknowledgement deadline expires. * An acknowledged message will not be resent
        /// to a subscriber. Note that subscribers may still receive multiple copies of a message when
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

        /// <summary>Required. Name of the subscription. Format is `projects/{project}/subscriptions/{sub}`.</summary>
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
        /// possible for healthy subscribers. RetryPolicy will be triggered on NACKs or acknowledgement deadline
        /// exceeded events for a given message.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retryPolicy")]
        public virtual RetryPolicy RetryPolicy { get; set; }

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

    /// <summary>Reference to a linked resource tracked by this Subscription.</summary>
    public class LinkedResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Name of the linked dataset, e.g. projects/subscriberproject/datasets/linked_dataset
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkedDataset")]
        public virtual string LinkedDataset { get; set; }

        /// <summary>
        /// Output only. Name of the Pub/Sub subscription, e.g.
        /// projects/subscriberproject/subscriptions/subscriptions/sub_id
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkedPubsubSubscription")]
        public virtual string LinkedPubsubSubscription { get; set; }

        /// <summary>Output only. Listing for which linked resource is created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listing")]
        public virtual string Listing { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for response to the list of data exchanges.</summary>
    public class ListDataExchangesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of data exchanges.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataExchanges")]
        public virtual System.Collections.Generic.IList<DataExchange> DataExchanges { get; set; }

        /// <summary>A token to request the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for response to the list of Listings.</summary>
    public class ListListingsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of Listing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listings")]
        public virtual System.Collections.Generic.IList<Listing> Listings { get; set; }

        /// <summary>A token to request the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for response to listing data exchanges in an organization and location.</summary>
    public class ListOrgDataExchangesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of data exchanges.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataExchanges")]
        public virtual System.Collections.Generic.IList<DataExchange> DataExchanges { get; set; }

        /// <summary>A token to request the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for response to the listing of shared resource subscriptions.</summary>
    public class ListSharedResourceSubscriptionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Next page token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of subscriptions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sharedResourceSubscriptions")]
        public virtual System.Collections.Generic.IList<Subscription> SharedResourceSubscriptions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for response to the listing of subscriptions.</summary>
    public class ListSubscriptionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Next page token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of subscriptions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscriptions")]
        public virtual System.Collections.Generic.IList<Subscription> Subscriptions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A listing is what gets published into a data exchange that a subscriber can subscribe to. It contains a
    /// reference to the data source along with descriptive information that will help subscribers find and subscribe
    /// the data.
    /// </summary>
    public class Listing : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. If true, the listing is only available to get the resource metadata. Listing is non subscribable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowOnlyMetadataSharing")]
        public virtual System.Nullable<bool> AllowOnlyMetadataSharing { get; set; }

        /// <summary>Shared dataset i.e. BigQuery dataset source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bigqueryDataset")]
        public virtual BigQueryDatasetSource BigqueryDataset { get; set; }

        /// <summary>Optional. Categories of the listing. Up to two categories are allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categories")]
        public virtual System.Collections.Generic.IList<string> Categories { get; set; }

        /// <summary>
        /// Output only. Commercial info contains the information about the commercial data products associated with the
        /// listing.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commercialInfo")]
        public virtual GoogleCloudBigqueryAnalyticshubV1ListingCommercialInfo CommercialInfo { get; set; }

        /// <summary>Optional. Details of the data provider who owns the source data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataProvider")]
        public virtual DataProvider DataProvider { get; set; }

        /// <summary>
        /// Optional. Short description of the listing. The description must not contain Unicode non-characters and C0
        /// and C1 control codes except tabs (HT), new lines (LF), carriage returns (CR), and page breaks (FF). Default
        /// value is an empty string. Max length: 2000 bytes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Optional. Type of discovery of the listing on the discovery page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("discoveryType")]
        public virtual string DiscoveryType { get; set; }

        /// <summary>
        /// Required. Human-readable display name of the listing. The display name must contain only Unicode letters,
        /// numbers (0-9), underscores (_), dashes (-), spaces ( ), ampersands (&amp;amp;) and can't start or end with
        /// spaces. Default value is an empty string. Max length: 63 bytes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Optional. Documentation describing the listing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentation")]
        public virtual string Documentation { get; set; }

        /// <summary>
        /// Optional. Base64 encoded image representing the listing. Max Size: 3.0MiB Expected image dimensions are
        /// 512x512 pixels, however the API only performs validation on size of the encoded data. Note: For byte fields,
        /// the contents of the field are base64-encoded (which increases the size of the data by 33-36%) when using
        /// JSON on the wire.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("icon")]
        public virtual string Icon { get; set; }

        /// <summary>Optional. By default, false. If true, the Listing has an email sharing mandate enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logLinkedDatasetQueryUserEmail")]
        public virtual System.Nullable<bool> LogLinkedDatasetQueryUserEmail { get; set; }

        /// <summary>
        /// Output only. The resource name of the listing. e.g.
        /// `projects/myproject/locations/us/dataExchanges/123/listings/456`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. Email or URL of the primary point of contact of the listing. Max Length: 1000 bytes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryContact")]
        public virtual string PrimaryContact { get; set; }

        /// <summary>
        /// Optional. Details of the publisher who owns the listing and who can share the source data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publisher")]
        public virtual Publisher Publisher { get; set; }

        /// <summary>Pub/Sub topic source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pubsubTopic")]
        public virtual PubSubTopicSource PubsubTopic { get; set; }

        /// <summary>
        /// Optional. Email or URL of the request access of the listing. Subscribers can use this reference to request
        /// access. Max Length: 1000 bytes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestAccess")]
        public virtual string RequestAccess { get; set; }

        /// <summary>Output only. Listing shared asset type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceType")]
        public virtual string ResourceType { get; set; }

        /// <summary>
        /// Optional. If set, restricted export configuration will be propagated and enforced on the linked dataset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restrictedExportConfig")]
        public virtual RestrictedExportConfig RestrictedExportConfig { get; set; }

        /// <summary>Output only. Current state of the listing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>All supported message transforms types.</summary>
    public class MessageTransform : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. If true, the transform is disabled and will not be applied to messages. Defaults to `false`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabled")]
        public virtual System.Nullable<bool> Disabled { get; set; }

        /// <summary>Optional. This field is deprecated, use the `disabled` field to disable transforms.</summary>
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

    /// <summary>Represents the metadata of a long-running operation in Analytics Hub.</summary>
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
        /// successfully been cancelled have Operation.error value with a google.rpc.Status.code of 1, corresponding to
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
        /// <summary>Specifies cloud audit logging configuration for this policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditConfigs")]
        public virtual System.Collections.Generic.IList<AuditConfig> AuditConfigs { get; set; }

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

    /// <summary>Pub/Sub topic source.</summary>
    public class PubSubTopicSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Region hint on where the data might be published. Data affinity regions are modifiable. See
        /// https://cloud.google.com/about/locations for full listing of possible Cloud regions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataAffinityRegions")]
        public virtual System.Collections.Generic.IList<string> DataAffinityRegions { get; set; }

        /// <summary>
        /// Required. Resource name of the Pub/Sub topic source for this listing. e.g. projects/myproject/topics/topicId
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topic")]
        public virtual string Topic { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains details of the listing publisher.</summary>
    public class Publisher : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Name of the listing publisher.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. Email or URL of the listing publisher. Max Length: 1000 bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryContact")]
        public virtual string PrimaryContact { get; set; }

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

    /// <summary>Message for refreshing a subscription.</summary>
    public class RefreshSubscriptionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for response when you refresh a subscription.</summary>
    public class RefreshSubscriptionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The refreshed subscription resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscription")]
        public virtual Subscription Subscription { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Restricted export config, used to configure restricted export on linked dataset.</summary>
    public class RestrictedExportConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. If true, enable restricted export.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>
        /// Output only. If true, restrict direct table access(read api/tabledata.list) on linked table.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restrictDirectTableAccess")]
        public virtual System.Nullable<bool> RestrictDirectTableAccess { get; set; }

        /// <summary>
        /// Optional. If true, restrict export of query result derived from restricted linked dataset table.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restrictQueryResult")]
        public virtual System.Nullable<bool> RestrictQueryResult { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Restricted export policy used to configure restricted export on linked dataset.</summary>
    public class RestrictedExportPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. If true, enable restricted export.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>
        /// Optional. If true, restrict direct table access (read api/tabledata.list) on linked table.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restrictDirectTableAccess")]
        public virtual System.Nullable<bool> RestrictDirectTableAccess { get; set; }

        /// <summary>
        /// Optional. If true, restrict export of query result derived from restricted linked dataset table.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restrictQueryResult")]
        public virtual System.Nullable<bool> RestrictQueryResult { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A policy that specifies how Pub/Sub retries message delivery. Retry delay will be exponential based on provided
    /// minimum and maximum backoffs. https://en.wikipedia.org/wiki/Exponential_backoff. RetryPolicy will be triggered
    /// on NACKs or acknowledgement deadline exceeded events for a given message. Retry Policy is implemented on a best
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

    /// <summary>Message for revoking a subscription.</summary>
    public class RevokeSubscriptionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. If the subscription is commercial then this field must be set to true, otherwise a failure is
        /// thrown. This acts as a safety guard to avoid revoking commercial subscriptions accidentally.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revokeCommercial")]
        public virtual System.Nullable<bool> RevokeCommercial { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for response when you revoke a subscription. Empty for now.</summary>
    public class RevokeSubscriptionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Resource in this dataset that is selectively shared.</summary>
    public class SelectedResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Format: For routine: `projects/{projectId}/datasets/{datasetId}/routines/{routineId}`
        /// Example:"projects/test_project/datasets/test_dataset/routines/test_routine"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("routine")]
        public virtual string Routine { get; set; }

        /// <summary>
        /// Optional. Format: For table: `projects/{projectId}/datasets/{datasetId}/tables/{tableId}`
        /// Example:"projects/test_project/datasets/test_dataset/tables/test_table"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("table")]
        public virtual string Table { get; set; }

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

        /// <summary>
        /// OPTIONAL: A FieldMask specifying which fields of the policy to modify. Only the fields in the mask will be
        /// modified. If no mask is provided, the following default mask is used: `paths: "bindings, etag"`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Sharing environment is a behavior model for sharing data within a data exchange. This option is configurable for
    /// a data exchange.
    /// </summary>
    public class SharingEnvironmentConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Data Clean Room (DCR), used for privacy-safe and secured data sharing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dcrExchangeConfig")]
        public virtual DcrExchangeConfig DcrExchangeConfig { get; set; }

        /// <summary>Default Analytics Hub data exchange, used for secured data sharing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultExchangeConfig")]
        public virtual DefaultExchangeConfig DefaultExchangeConfig { get; set; }

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

    /// <summary>Message for subscribing to a Data Exchange.</summary>
    public class SubscribeDataExchangeRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The parent resource path of the Subscription. e.g. `projects/subscriberproject/locations/us`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destination")]
        public virtual string Destination { get; set; }

        /// <summary>Optional. BigQuery destination dataset to create for the subscriber.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationDataset")]
        public virtual DestinationDataset DestinationDataset { get; set; }

        /// <summary>Email of the subscriber.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscriberContact")]
        public virtual string SubscriberContact { get; set; }

        /// <summary>Required. Name of the subscription to create. e.g. `subscription1`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscription")]
        public virtual string Subscription { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for response when you subscribe to a Data Exchange.</summary>
    public class SubscribeDataExchangeResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Subscription object created from this subscribe action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscription")]
        public virtual Subscription Subscription { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for subscribing to a listing.</summary>
    public class SubscribeListingRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Input only. BigQuery destination dataset to create for the subscriber.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationDataset")]
        public virtual DestinationDataset DestinationDataset { get; set; }

        /// <summary>Input only. Destination Pub/Sub subscription to create for the subscriber.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationPubsubSubscription")]
        public virtual DestinationPubSubSubscription DestinationPubsubSubscription { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for response when you subscribe to a listing.</summary>
    public class SubscribeListingResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Subscription object created from this subscribe action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscription")]
        public virtual Subscription Subscription { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A subscription represents a subscribers' access to a particular set of published data. It contains references to
    /// associated listings, data exchanges, and linked datasets.
    /// </summary>
    public class Subscription : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. This is set if this is a commercial subscription i.e. if this subscription was created from
        /// subscribing to a commercial listing.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commercialInfo")]
        public virtual GoogleCloudBigqueryAnalyticshubV1SubscriptionCommercialInfo CommercialInfo { get; set; }

        private string _creationTimeRaw;

        private object _creationTime;

        /// <summary>Output only. Timestamp when the subscription was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationTime")]
        public virtual string CreationTimeRaw
        {
            get => _creationTimeRaw;
            set
            {
                _creationTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _creationTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CreationTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreationTimeDateTimeOffset instead.")]
        public virtual object CreationTime
        {
            get => _creationTime;
            set
            {
                _creationTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _creationTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CreationTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreationTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CreationTimeRaw);
            set => CreationTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Output only. Resource name of the source Data Exchange. e.g. projects/123/locations/us/dataExchanges/456
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataExchange")]
        public virtual string DataExchange { get; set; }

        /// <summary>Optional. BigQuery destination dataset to create for the subscriber.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationDataset")]
        public virtual DestinationDataset DestinationDataset { get; set; }

        private string _lastModifyTimeRaw;

        private object _lastModifyTime;

        /// <summary>Output only. Timestamp when the subscription was last modified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastModifyTime")]
        public virtual string LastModifyTimeRaw
        {
            get => _lastModifyTimeRaw;
            set
            {
                _lastModifyTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lastModifyTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LastModifyTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LastModifyTimeDateTimeOffset instead.")]
        public virtual object LastModifyTime
        {
            get => _lastModifyTime;
            set
            {
                _lastModifyTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lastModifyTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="LastModifyTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LastModifyTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LastModifyTimeRaw);
            set => LastModifyTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Output only. Map of listing resource names to associated linked resource, e.g.
        /// projects/123/locations/us/dataExchanges/456/listings/789 -&amp;gt; projects/123/datasets/my_dataset For
        /// listing-level subscriptions, this is a map of size 1. Only contains values if state == STATE_ACTIVE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkedDatasetMap")]
        public virtual System.Collections.Generic.IDictionary<string, LinkedResource> LinkedDatasetMap { get; set; }

        /// <summary>
        /// Output only. Linked resources created in the subscription. Only contains values if state = STATE_ACTIVE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkedResources")]
        public virtual System.Collections.Generic.IList<LinkedResource> LinkedResources { get; set; }

        /// <summary>
        /// Output only. Resource name of the source Listing. e.g.
        /// projects/123/locations/us/dataExchanges/456/listings/789
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listing")]
        public virtual string Listing { get; set; }

        /// <summary>
        /// Output only. By default, false. If true, the Subscriber agreed to the email sharing mandate that is enabled
        /// for DataExchange/Listing.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logLinkedDatasetQueryUserEmail")]
        public virtual System.Nullable<bool> LogLinkedDatasetQueryUserEmail { get; set; }

        /// <summary>
        /// Output only. The resource name of the subscription. e.g.
        /// `projects/myproject/locations/us/subscriptions/123`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Display name of the project of this subscription.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("organizationDisplayName")]
        public virtual string OrganizationDisplayName { get; set; }

        /// <summary>Output only. Organization of the project this subscription belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("organizationId")]
        public virtual string OrganizationId { get; set; }

        /// <summary>Output only. Listing shared asset type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceType")]
        public virtual string ResourceType { get; set; }

        /// <summary>Output only. Current state of the subscription.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. Email of the subscriber.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscriberContact")]
        public virtual string SubscriberContact { get; set; }

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
}
