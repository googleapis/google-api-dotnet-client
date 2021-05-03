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

namespace Google.Apis.BigQueryReservation.v1
{
    /// <summary>The BigQueryReservation Service.</summary>
    public class BigQueryReservationService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public BigQueryReservationService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public BigQueryReservationService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "bigqueryreservation";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://bigqueryreservation.googleapis.com/";
        #else
            "https://bigqueryreservation.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://bigqueryreservation.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the BigQuery Reservation API.</summary>
        public class Scope
        {
            /// <summary>View and manage your data in Google BigQuery</summary>
            public static string Bigquery = "https://www.googleapis.com/auth/bigquery";

            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the BigQuery Reservation API.</summary>
        public static class ScopeConstants
        {
            /// <summary>View and manage your data in Google BigQuery</summary>
            public const string Bigquery = "https://www.googleapis.com/auth/bigquery";

            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for BigQueryReservation requests.</summary>
    public abstract class BigQueryReservationBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new BigQueryReservationBaseServiceRequest instance.</summary>
        protected BigQueryReservationBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes BigQueryReservation parameter list.</summary>
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
                CapacityCommitments = new CapacityCommitmentsResource(service);
                Reservations = new ReservationsResource(service);
            }

            /// <summary>Gets the CapacityCommitments resource.</summary>
            public virtual CapacityCommitmentsResource CapacityCommitments { get; }

            /// <summary>The "capacityCommitments" collection of methods.</summary>
            public class CapacityCommitmentsResource
            {
                private const string Resource = "capacityCommitments";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public CapacityCommitmentsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a new capacity commitment resource.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. Resource name of the parent reservation. E.g., `projects/myproject/locations/US`
                /// </param>
                public virtual CreateRequest Create(Google.Apis.BigQueryReservation.v1.Data.CapacityCommitment body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Creates a new capacity commitment resource.</summary>
                public class CreateRequest : BigQueryReservationBaseServiceRequest<Google.Apis.BigQueryReservation.v1.Data.CapacityCommitment>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.BigQueryReservation.v1.Data.CapacityCommitment body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Resource name of the parent reservation. E.g., `projects/myproject/locations/US`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// The optional capacity commitment ID. Capacity commitment name will be generated automatically if
                    /// this field is empty. This field must only contain lower case alphanumeric characters or dash.
                    /// Max length is 64 characters. NOTE: this ID won't be kept if the capacity commitment is split or
                    /// merged.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("capacityCommitmentId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string CapacityCommitmentId { get; set; }

                    /// <summary>
                    /// If true, fail the request if another project in the organization has a capacity commitment.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("enforceSingleAdminProjectPerOrg", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> EnforceSingleAdminProjectPerOrg { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.BigQueryReservation.v1.Data.CapacityCommitment Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/capacityCommitments";

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
                        RequestParameters.Add("capacityCommitmentId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "capacityCommitmentId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("enforceSingleAdminProjectPerOrg", new Google.Apis.Discovery.Parameter
                        {
                            Name = "enforceSingleAdminProjectPerOrg",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Deletes a capacity commitment. Attempting to delete capacity commitment before its
                /// commitment_end_time will fail with the error code `google.rpc.Code.FAILED_PRECONDITION`.
                /// </summary>
                /// <param name="name">
                /// Required. Resource name of the capacity commitment to delete. E.g.,
                /// `projects/myproject/locations/US/capacityCommitments/123`
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>
                /// Deletes a capacity commitment. Attempting to delete capacity commitment before its
                /// commitment_end_time will fail with the error code `google.rpc.Code.FAILED_PRECONDITION`.
                /// </summary>
                public class DeleteRequest : BigQueryReservationBaseServiceRequest<Google.Apis.BigQueryReservation.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Resource name of the capacity commitment to delete. E.g.,
                    /// `projects/myproject/locations/US/capacityCommitments/123`
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/capacityCommitments/[^/]+$",
                        });
                    }
                }

                /// <summary>Returns information about the capacity commitment.</summary>
                /// <param name="name">
                /// Required. Resource name of the capacity commitment to retrieve. E.g.,
                /// `projects/myproject/locations/US/capacityCommitments/123`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Returns information about the capacity commitment.</summary>
                public class GetRequest : BigQueryReservationBaseServiceRequest<Google.Apis.BigQueryReservation.v1.Data.CapacityCommitment>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Resource name of the capacity commitment to retrieve. E.g.,
                    /// `projects/myproject/locations/US/capacityCommitments/123`
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/capacityCommitments/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists all the capacity commitments for the admin project.</summary>
                /// <param name="parent">
                /// Required. Resource name of the parent reservation. E.g., `projects/myproject/locations/US`
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists all the capacity commitments for the admin project.</summary>
                public class ListRequest : BigQueryReservationBaseServiceRequest<Google.Apis.BigQueryReservation.v1.Data.ListCapacityCommitmentsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Resource name of the parent reservation. E.g., `projects/myproject/locations/US`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>The maximum number of items to return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>The next_page_token value returned from a previous List request, if any.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/capacityCommitments";

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
                /// Merges capacity commitments of the same plan into a single commitment. The resulting capacity
                /// commitment has the greater commitment_end_time out of the to-be-merged capacity commitments.
                /// Attempting to merge capacity commitments of different plan will fail with the error code
                /// `google.rpc.Code.FAILED_PRECONDITION`.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Parent resource that identifies admin project and location e.g., `projects/myproject/locations/us`
                /// </param>
                public virtual MergeRequest Merge(Google.Apis.BigQueryReservation.v1.Data.MergeCapacityCommitmentsRequest body, string parent)
                {
                    return new MergeRequest(service, body, parent);
                }

                /// <summary>
                /// Merges capacity commitments of the same plan into a single commitment. The resulting capacity
                /// commitment has the greater commitment_end_time out of the to-be-merged capacity commitments.
                /// Attempting to merge capacity commitments of different plan will fail with the error code
                /// `google.rpc.Code.FAILED_PRECONDITION`.
                /// </summary>
                public class MergeRequest : BigQueryReservationBaseServiceRequest<Google.Apis.BigQueryReservation.v1.Data.CapacityCommitment>
                {
                    /// <summary>Constructs a new Merge request.</summary>
                    public MergeRequest(Google.Apis.Services.IClientService service, Google.Apis.BigQueryReservation.v1.Data.MergeCapacityCommitmentsRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Parent resource that identifies admin project and location e.g.,
                    /// `projects/myproject/locations/us`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.BigQueryReservation.v1.Data.MergeCapacityCommitmentsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "merge";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/capacityCommitments:merge";

                    /// <summary>Initializes Merge parameter list.</summary>
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

                /// <summary>
                /// Updates an existing capacity commitment. Only `plan` and `renewal_plan` fields can be updated. Plan
                /// can only be changed to a plan of a longer commitment period. Attempting to change to a plan with
                /// shorter commitment period will fail with the error code `google.rpc.Code.FAILED_PRECONDITION`.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Output only. The resource name of the capacity commitment, e.g.,
                /// `projects/myproject/locations/US/capacityCommitments/123`
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.BigQueryReservation.v1.Data.CapacityCommitment body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>
                /// Updates an existing capacity commitment. Only `plan` and `renewal_plan` fields can be updated. Plan
                /// can only be changed to a plan of a longer commitment period. Attempting to change to a plan with
                /// shorter commitment period will fail with the error code `google.rpc.Code.FAILED_PRECONDITION`.
                /// </summary>
                public class PatchRequest : BigQueryReservationBaseServiceRequest<Google.Apis.BigQueryReservation.v1.Data.CapacityCommitment>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.BigQueryReservation.v1.Data.CapacityCommitment body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Output only. The resource name of the capacity commitment, e.g.,
                    /// `projects/myproject/locations/US/capacityCommitments/123`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Standard field mask for the set of fields to be updated.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.BigQueryReservation.v1.Data.CapacityCommitment Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/capacityCommitments/[^/]+$",
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
                /// Splits capacity commitment to two commitments of the same plan and `commitment_end_time`. A common
                /// use case is to enable downgrading commitments. For example, in order to downgrade from 10000 slots
                /// to 8000, you might split a 10000 capacity commitment into commitments of 2000 and 8000. Then, you
                /// would change the plan of the first one to `FLEX` and then delete it.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The resource name e.g.,: `projects/myproject/locations/US/capacityCommitments/123`
                /// </param>
                public virtual SplitRequest Split(Google.Apis.BigQueryReservation.v1.Data.SplitCapacityCommitmentRequest body, string name)
                {
                    return new SplitRequest(service, body, name);
                }

                /// <summary>
                /// Splits capacity commitment to two commitments of the same plan and `commitment_end_time`. A common
                /// use case is to enable downgrading commitments. For example, in order to downgrade from 10000 slots
                /// to 8000, you might split a 10000 capacity commitment into commitments of 2000 and 8000. Then, you
                /// would change the plan of the first one to `FLEX` and then delete it.
                /// </summary>
                public class SplitRequest : BigQueryReservationBaseServiceRequest<Google.Apis.BigQueryReservation.v1.Data.SplitCapacityCommitmentResponse>
                {
                    /// <summary>Constructs a new Split request.</summary>
                    public SplitRequest(Google.Apis.Services.IClientService service, Google.Apis.BigQueryReservation.v1.Data.SplitCapacityCommitmentRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name e.g.,: `projects/myproject/locations/US/capacityCommitments/123`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.BigQueryReservation.v1.Data.SplitCapacityCommitmentRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "split";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:split";

                    /// <summary>Initializes Split parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/capacityCommitments/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the Reservations resource.</summary>
            public virtual ReservationsResource Reservations { get; }

            /// <summary>The "reservations" collection of methods.</summary>
            public class ReservationsResource
            {
                private const string Resource = "reservations";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ReservationsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Assignments = new AssignmentsResource(service);
                }

                /// <summary>Gets the Assignments resource.</summary>
                public virtual AssignmentsResource Assignments { get; }

                /// <summary>The "assignments" collection of methods.</summary>
                public class AssignmentsResource
                {
                    private const string Resource = "assignments";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public AssignmentsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Creates an assignment object which allows the given project to submit jobs of a certain type
                    /// using slots from the specified reservation. Currently a resource (project, folder, organization)
                    /// can only have one assignment per each (job_type, location) combination, and that reservation
                    /// will be used for all jobs of the matching type. Different assignments can be created on
                    /// different levels of the projects, folders or organization hierarchy. During query execution, the
                    /// assignment is looked up at the project, folder and organization levels in that order. The first
                    /// assignment found is applied to the query. When creating assignments, it does not matter if other
                    /// assignments exist at higher levels. Example: * The organization `organizationA` contains two
                    /// projects, `project1` and `project2`. * Assignments for all three entities (`organizationA`,
                    /// `project1`, and `project2`) could all be created and mapped to the same or different
                    /// reservations. "None" assignments represent an absence of the assignment. Projects assigned to
                    /// None use on-demand pricing. To create a "None" assignment, use "none" as a reservation_id in the
                    /// parent. Example parent: `projects/myproject/locations/US/reservations/none`. Returns
                    /// `google.rpc.Code.PERMISSION_DENIED` if user does not have 'bigquery.admin' permissions on the
                    /// project using the reservation and the project that owns this reservation. Returns
                    /// `google.rpc.Code.INVALID_ARGUMENT` when location of the assignment does not match location of
                    /// the reservation.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The parent resource name of the assignment E.g.
                    /// `projects/myproject/locations/US/reservations/team1-prod`
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.BigQueryReservation.v1.Data.Assignment body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>
                    /// Creates an assignment object which allows the given project to submit jobs of a certain type
                    /// using slots from the specified reservation. Currently a resource (project, folder, organization)
                    /// can only have one assignment per each (job_type, location) combination, and that reservation
                    /// will be used for all jobs of the matching type. Different assignments can be created on
                    /// different levels of the projects, folders or organization hierarchy. During query execution, the
                    /// assignment is looked up at the project, folder and organization levels in that order. The first
                    /// assignment found is applied to the query. When creating assignments, it does not matter if other
                    /// assignments exist at higher levels. Example: * The organization `organizationA` contains two
                    /// projects, `project1` and `project2`. * Assignments for all three entities (`organizationA`,
                    /// `project1`, and `project2`) could all be created and mapped to the same or different
                    /// reservations. "None" assignments represent an absence of the assignment. Projects assigned to
                    /// None use on-demand pricing. To create a "None" assignment, use "none" as a reservation_id in the
                    /// parent. Example parent: `projects/myproject/locations/US/reservations/none`. Returns
                    /// `google.rpc.Code.PERMISSION_DENIED` if user does not have 'bigquery.admin' permissions on the
                    /// project using the reservation and the project that owns this reservation. Returns
                    /// `google.rpc.Code.INVALID_ARGUMENT` when location of the assignment does not match location of
                    /// the reservation.
                    /// </summary>
                    public class CreateRequest : BigQueryReservationBaseServiceRequest<Google.Apis.BigQueryReservation.v1.Data.Assignment>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.BigQueryReservation.v1.Data.Assignment body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent resource name of the assignment E.g.
                        /// `projects/myproject/locations/US/reservations/team1-prod`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// The optional assignment ID. Assignment name will be generated automatically if this field is
                        /// empty. This field must only contain lower case alphanumeric characters or dash. Max length
                        /// is 64 characters.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("assignmentId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string AssignmentId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.BigQueryReservation.v1.Data.Assignment Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/assignments";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/reservations/[^/]+$",
                            });
                            RequestParameters.Add("assignmentId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "assignmentId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>
                    /// Deletes a assignment. No expansion will happen. Example: * Organization `organizationA` contains
                    /// two projects, `project1` and `project2`. * Reservation `res1` exists and was created previously.
                    /// * CreateAssignment was used previously to define the following associations between entities and
                    /// reservations: `` and `` In this example, deletion of the `` assignment won't affect the other
                    /// assignment ``. After said deletion, queries from `project1` will still use `res1` while queries
                    /// from `project2` will switch to use on-demand mode.
                    /// </summary>
                    /// <param name="name">
                    /// Required. Name of the resource, e.g.
                    /// `projects/myproject/locations/US/reservations/team1-prod/assignments/123`
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>
                    /// Deletes a assignment. No expansion will happen. Example: * Organization `organizationA` contains
                    /// two projects, `project1` and `project2`. * Reservation `res1` exists and was created previously.
                    /// * CreateAssignment was used previously to define the following associations between entities and
                    /// reservations: `` and `` In this example, deletion of the `` assignment won't affect the other
                    /// assignment ``. After said deletion, queries from `project1` will still use `res1` while queries
                    /// from `project2` will switch to use on-demand mode.
                    /// </summary>
                    public class DeleteRequest : BigQueryReservationBaseServiceRequest<Google.Apis.BigQueryReservation.v1.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Name of the resource, e.g.
                        /// `projects/myproject/locations/US/reservations/team1-prod/assignments/123`
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/reservations/[^/]+/assignments/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Lists assignments. Only explicitly created assignments will be returned. Example: * Organization
                    /// `organizationA` contains two projects, `project1` and `project2`. * Reservation `res1` exists
                    /// and was created previously. * CreateAssignment was used previously to define the following
                    /// associations between entities and reservations: `` and `` In this example, ListAssignments will
                    /// just return the above two assignments for reservation `res1`, and no expansion/merge will
                    /// happen. The wildcard "-" can be used for reservations in the request. In that case all
                    /// assignments belongs to the specified project and location will be listed. **Note** "-" cannot be
                    /// used for projects nor locations.
                    /// </summary>
                    /// <param name="parent">
                    /// Required. The parent resource name e.g.:
                    /// `projects/myproject/locations/US/reservations/team1-prod` Or:
                    /// `projects/myproject/locations/US/reservations/-`
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>
                    /// Lists assignments. Only explicitly created assignments will be returned. Example: * Organization
                    /// `organizationA` contains two projects, `project1` and `project2`. * Reservation `res1` exists
                    /// and was created previously. * CreateAssignment was used previously to define the following
                    /// associations between entities and reservations: `` and `` In this example, ListAssignments will
                    /// just return the above two assignments for reservation `res1`, and no expansion/merge will
                    /// happen. The wildcard "-" can be used for reservations in the request. In that case all
                    /// assignments belongs to the specified project and location will be listed. **Note** "-" cannot be
                    /// used for projects nor locations.
                    /// </summary>
                    public class ListRequest : BigQueryReservationBaseServiceRequest<Google.Apis.BigQueryReservation.v1.Data.ListAssignmentsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent resource name e.g.:
                        /// `projects/myproject/locations/US/reservations/team1-prod` Or:
                        /// `projects/myproject/locations/US/reservations/-`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>The maximum number of items to return per page.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>The next_page_token value returned from a previous List request, if any.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/assignments";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/reservations/[^/]+$",
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
                    /// Moves an assignment under a new reservation. This differs from removing an existing assignment
                    /// and recreating a new one by providing a transactional change that ensures an assignee always has
                    /// an associated reservation.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The resource name of the assignment, e.g.
                    /// `projects/myproject/locations/US/reservations/team1-prod/assignments/123`
                    /// </param>
                    public virtual MoveRequest Move(Google.Apis.BigQueryReservation.v1.Data.MoveAssignmentRequest body, string name)
                    {
                        return new MoveRequest(service, body, name);
                    }

                    /// <summary>
                    /// Moves an assignment under a new reservation. This differs from removing an existing assignment
                    /// and recreating a new one by providing a transactional change that ensures an assignee always has
                    /// an associated reservation.
                    /// </summary>
                    public class MoveRequest : BigQueryReservationBaseServiceRequest<Google.Apis.BigQueryReservation.v1.Data.Assignment>
                    {
                        /// <summary>Constructs a new Move request.</summary>
                        public MoveRequest(Google.Apis.Services.IClientService service, Google.Apis.BigQueryReservation.v1.Data.MoveAssignmentRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the assignment, e.g.
                        /// `projects/myproject/locations/US/reservations/team1-prod/assignments/123`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.BigQueryReservation.v1.Data.MoveAssignmentRequest Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/reservations/[^/]+/assignments/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>Creates a new reservation resource.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. Project, location. E.g., `projects/myproject/locations/US`</param>
                public virtual CreateRequest Create(Google.Apis.BigQueryReservation.v1.Data.Reservation body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Creates a new reservation resource.</summary>
                public class CreateRequest : BigQueryReservationBaseServiceRequest<Google.Apis.BigQueryReservation.v1.Data.Reservation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.BigQueryReservation.v1.Data.Reservation body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. Project, location. E.g., `projects/myproject/locations/US`</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// The reservation ID. This field must only contain lower case alphanumeric characters or dash. Max
                    /// length is 64 characters.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("reservationId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ReservationId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.BigQueryReservation.v1.Data.Reservation Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/reservations";

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
                        RequestParameters.Add("reservationId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "reservationId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Deletes a reservation. Returns `google.rpc.Code.FAILED_PRECONDITION` when reservation has
                /// assignments.
                /// </summary>
                /// <param name="name">
                /// Required. Resource name of the reservation to retrieve. E.g.,
                /// `projects/myproject/locations/US/reservations/team1-prod`
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>
                /// Deletes a reservation. Returns `google.rpc.Code.FAILED_PRECONDITION` when reservation has
                /// assignments.
                /// </summary>
                public class DeleteRequest : BigQueryReservationBaseServiceRequest<Google.Apis.BigQueryReservation.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Resource name of the reservation to retrieve. E.g.,
                    /// `projects/myproject/locations/US/reservations/team1-prod`
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/reservations/[^/]+$",
                        });
                    }
                }

                /// <summary>Returns information about the reservation.</summary>
                /// <param name="name">
                /// Required. Resource name of the reservation to retrieve. E.g.,
                /// `projects/myproject/locations/US/reservations/team1-prod`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Returns information about the reservation.</summary>
                public class GetRequest : BigQueryReservationBaseServiceRequest<Google.Apis.BigQueryReservation.v1.Data.Reservation>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Resource name of the reservation to retrieve. E.g.,
                    /// `projects/myproject/locations/US/reservations/team1-prod`
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/reservations/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists all the reservations for the project in the specified location.</summary>
                /// <param name="parent">
                /// Required. The parent resource name containing project and location, e.g.:
                /// `projects/myproject/locations/US`
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists all the reservations for the project in the specified location.</summary>
                public class ListRequest : BigQueryReservationBaseServiceRequest<Google.Apis.BigQueryReservation.v1.Data.ListReservationsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource name containing project and location, e.g.:
                    /// `projects/myproject/locations/US`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>The maximum number of items to return per page.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>The next_page_token value returned from a previous List request, if any.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/reservations";

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

                /// <summary>Updates an existing reservation resource.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The resource name of the reservation, e.g., `projects/*/locations/*/reservations/team1-prod`.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.BigQueryReservation.v1.Data.Reservation body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>Updates an existing reservation resource.</summary>
                public class PatchRequest : BigQueryReservationBaseServiceRequest<Google.Apis.BigQueryReservation.v1.Data.Reservation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.BigQueryReservation.v1.Data.Reservation body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The resource name of the reservation, e.g., `projects/*/locations/*/reservations/team1-prod`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Standard field mask for the set of fields to be updated.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.BigQueryReservation.v1.Data.Reservation Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/reservations/[^/]+$",
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

            /// <summary>Retrieves a BI reservation.</summary>
            /// <param name="name">
            /// Required. Name of the requested reservation, for example:
            /// `projects/{project_id}/locations/{location_id}/biReservation`
            /// </param>
            public virtual GetBiReservationRequest GetBiReservation(string name)
            {
                return new GetBiReservationRequest(service, name);
            }

            /// <summary>Retrieves a BI reservation.</summary>
            public class GetBiReservationRequest : BigQueryReservationBaseServiceRequest<Google.Apis.BigQueryReservation.v1.Data.BiReservation>
            {
                /// <summary>Constructs a new GetBiReservation request.</summary>
                public GetBiReservationRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of the requested reservation, for example:
                /// `projects/{project_id}/locations/{location_id}/biReservation`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getBiReservation";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes GetBiReservation parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/locations/[^/]+/biReservation$",
                    });
                }
            }

            /// <summary>
            /// Looks up assignments for a specified resource for a particular region. If the request is about a
            /// project: 1. Assignments created on the project will be returned if they exist. 2. Otherwise assignments
            /// created on the closest ancestor will be returned. 3. Assignments for different JobTypes will all be
            /// returned. The same logic applies if the request is about a folder. If the request is about an
            /// organization, then assignments created on the organization will be returned (organization doesn't have
            /// ancestors). Comparing to ListAssignments, there are some behavior differences: 1. permission on the
            /// assignee will be verified in this API. 2. Hierarchy lookup (project-&amp;gt;folder-&amp;gt;organization)
            /// happens in this API. 3. Parent here is `projects/*/locations/*`, instead of
            /// `projects/*/locations/*reservations/*`.
            /// </summary>
            /// <param name="parent">
            /// Required. The resource name with location (project name could be the wildcard '-'), e.g.:
            /// `projects/-/locations/US`.
            /// </param>
            public virtual SearchAllAssignmentsRequest SearchAllAssignments(string parent)
            {
                return new SearchAllAssignmentsRequest(service, parent);
            }

            /// <summary>
            /// Looks up assignments for a specified resource for a particular region. If the request is about a
            /// project: 1. Assignments created on the project will be returned if they exist. 2. Otherwise assignments
            /// created on the closest ancestor will be returned. 3. Assignments for different JobTypes will all be
            /// returned. The same logic applies if the request is about a folder. If the request is about an
            /// organization, then assignments created on the organization will be returned (organization doesn't have
            /// ancestors). Comparing to ListAssignments, there are some behavior differences: 1. permission on the
            /// assignee will be verified in this API. 2. Hierarchy lookup (project-&amp;gt;folder-&amp;gt;organization)
            /// happens in this API. 3. Parent here is `projects/*/locations/*`, instead of
            /// `projects/*/locations/*reservations/*`.
            /// </summary>
            public class SearchAllAssignmentsRequest : BigQueryReservationBaseServiceRequest<Google.Apis.BigQueryReservation.v1.Data.SearchAllAssignmentsResponse>
            {
                /// <summary>Constructs a new SearchAllAssignments request.</summary>
                public SearchAllAssignmentsRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name with location (project name could be the wildcard '-'), e.g.:
                /// `projects/-/locations/US`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>The maximum number of items to return per page.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>The next_page_token value returned from a previous List request, if any.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>
                /// Please specify resource name as assignee in the query. Examples: * `assignee=projects/myproject` *
                /// `assignee=folders/123` * `assignee=organizations/456`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("query", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Query { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "searchAllAssignments";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}:searchAllAssignments";

                /// <summary>Initializes SearchAllAssignments parameter list.</summary>
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
                    RequestParameters.Add("query", new Google.Apis.Discovery.Parameter
                    {
                        Name = "query",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Looks up assignments for a specified resource for a particular region. If the request is about a
            /// project: 1. Assignments created on the project will be returned if they exist. 2. Otherwise assignments
            /// created on the closest ancestor will be returned. 3. Assignments for different JobTypes will all be
            /// returned. The same logic applies if the request is about a folder. If the request is about an
            /// organization, then assignments created on the organization will be returned (organization doesn't have
            /// ancestors). Comparing to ListAssignments, there are some behavior differences: 1. permission on the
            /// assignee will be verified in this API. 2. Hierarchy lookup (project-&amp;gt;folder-&amp;gt;organization)
            /// happens in this API. 3. Parent here is `projects/*/locations/*`, instead of
            /// `projects/*/locations/*reservations/*`. **Note** "-" cannot be used for projects nor locations.
            /// </summary>
            /// <param name="parent">
            /// Required. The resource name of the admin project(containing project and location), e.g.:
            /// `projects/myproject/locations/US`.
            /// </param>
            public virtual SearchAssignmentsRequest SearchAssignments(string parent)
            {
                return new SearchAssignmentsRequest(service, parent);
            }

            /// <summary>
            /// Looks up assignments for a specified resource for a particular region. If the request is about a
            /// project: 1. Assignments created on the project will be returned if they exist. 2. Otherwise assignments
            /// created on the closest ancestor will be returned. 3. Assignments for different JobTypes will all be
            /// returned. The same logic applies if the request is about a folder. If the request is about an
            /// organization, then assignments created on the organization will be returned (organization doesn't have
            /// ancestors). Comparing to ListAssignments, there are some behavior differences: 1. permission on the
            /// assignee will be verified in this API. 2. Hierarchy lookup (project-&amp;gt;folder-&amp;gt;organization)
            /// happens in this API. 3. Parent here is `projects/*/locations/*`, instead of
            /// `projects/*/locations/*reservations/*`. **Note** "-" cannot be used for projects nor locations.
            /// </summary>
            public class SearchAssignmentsRequest : BigQueryReservationBaseServiceRequest<Google.Apis.BigQueryReservation.v1.Data.SearchAssignmentsResponse>
            {
                /// <summary>Constructs a new SearchAssignments request.</summary>
                public SearchAssignmentsRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the admin project(containing project and location), e.g.:
                /// `projects/myproject/locations/US`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>The maximum number of items to return per page.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>The next_page_token value returned from a previous List request, if any.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>
                /// Please specify resource name as assignee in the query. Examples: * `assignee=projects/myproject` *
                /// `assignee=folders/123` * `assignee=organizations/456`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("query", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Query { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "searchAssignments";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}:searchAssignments";

                /// <summary>Initializes SearchAssignments parameter list.</summary>
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
                    RequestParameters.Add("query", new Google.Apis.Discovery.Parameter
                    {
                        Name = "query",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Updates a BI reservation. Only fields specified in the `field_mask` are updated. A singleton BI
            /// reservation always exists with default size 0. In order to reserve BI capacity it needs to be updated to
            /// an amount greater than 0. In order to release BI capacity reservation size must be set to 0.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// The resource name of the singleton BI reservation. Reservation names have the form
            /// `projects/{project_id}/locations/{location_id}/biReservation`.
            /// </param>
            public virtual UpdateBiReservationRequest UpdateBiReservation(Google.Apis.BigQueryReservation.v1.Data.BiReservation body, string name)
            {
                return new UpdateBiReservationRequest(service, body, name);
            }

            /// <summary>
            /// Updates a BI reservation. Only fields specified in the `field_mask` are updated. A singleton BI
            /// reservation always exists with default size 0. In order to reserve BI capacity it needs to be updated to
            /// an amount greater than 0. In order to release BI capacity reservation size must be set to 0.
            /// </summary>
            public class UpdateBiReservationRequest : BigQueryReservationBaseServiceRequest<Google.Apis.BigQueryReservation.v1.Data.BiReservation>
            {
                /// <summary>Constructs a new UpdateBiReservation request.</summary>
                public UpdateBiReservationRequest(Google.Apis.Services.IClientService service, Google.Apis.BigQueryReservation.v1.Data.BiReservation body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The resource name of the singleton BI reservation. Reservation names have the form
                /// `projects/{project_id}/locations/{location_id}/biReservation`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>A list of fields to be updated in this request.</summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.BigQueryReservation.v1.Data.BiReservation Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "updateBiReservation";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes UpdateBiReservation parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/locations/[^/]+/biReservation$",
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
namespace Google.Apis.BigQueryReservation.v1.Data
{
    /// <summary>
    /// A Assignment allows a project to submit jobs of a certain type using slots from the specified reservation.
    /// </summary>
    public class Assignment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The resource which will use the reservation. E.g. `projects/myproject`, `folders/123`, or
        /// `organizations/456`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assignee")]
        public virtual string Assignee { get; set; }

        /// <summary>Which type of jobs will use the reservation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobType")]
        public virtual string JobType { get; set; }

        /// <summary>
        /// Output only. Name of the resource. E.g.:
        /// `projects/myproject/locations/US/reservations/team1-prod/assignments/123`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. State of the assignment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a BI Reservation.</summary>
    public class BiReservation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The resource name of the singleton BI reservation. Reservation names have the form
        /// `projects/{project_id}/locations/{location_id}/biReservation`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Size of a reservation, in bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("size")]
        public virtual System.Nullable<long> Size { get; set; }

        /// <summary>Output only. The last update timestamp of a reservation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Capacity commitment is a way to purchase compute capacity for BigQuery jobs (in the form of slots) with some
    /// committed period of usage. Annual commitments renew by default. Commitments can be removed after their
    /// commitment end time passes. In order to remove annual commitment, its plan needs to be changed to monthly or
    /// flex first. A capacity commitment resource exists as a child resource of the admin project.
    /// </summary>
    public class CapacityCommitment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The end of the current commitment period. It is applicable only for ACTIVE capacity
        /// commitments.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commitmentEndTime")]
        public virtual object CommitmentEndTime { get; set; }

        /// <summary>
        /// Output only. The start of the current commitment period. It is applicable only for ACTIVE capacity
        /// commitments.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commitmentStartTime")]
        public virtual object CommitmentStartTime { get; set; }

        /// <summary>Output only. For FAILED commitment plan, provides the reason of failure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failureStatus")]
        public virtual Status FailureStatus { get; set; }

        /// <summary>
        /// Output only. The resource name of the capacity commitment, e.g.,
        /// `projects/myproject/locations/US/capacityCommitments/123`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Capacity commitment commitment plan.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("plan")]
        public virtual string Plan { get; set; }

        /// <summary>
        /// The plan this capacity commitment is converted to after commitment_end_time passes. Once the plan is
        /// changed, committed period is extended according to commitment plan. Only applicable for ANNUAL and TRIAL
        /// commitments.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("renewalPlan")]
        public virtual string RenewalPlan { get; set; }

        /// <summary>Number of slots in this commitment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("slotCount")]
        public virtual System.Nullable<long> SlotCount { get; set; }

        /// <summary>Output only. State of the commitment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

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

    /// <summary>The response for ReservationService.ListAssignments.</summary>
    public class ListAssignmentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of assignments visible to the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assignments")]
        public virtual System.Collections.Generic.IList<Assignment> Assignments { get; set; }

        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for ReservationService.ListCapacityCommitments.</summary>
    public class ListCapacityCommitmentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of capacity commitments visible to the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("capacityCommitments")]
        public virtual System.Collections.Generic.IList<CapacityCommitment> CapacityCommitments { get; set; }

        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for ReservationService.ListReservations.</summary>
    public class ListReservationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of reservations visible to the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reservations")]
        public virtual System.Collections.Generic.IList<Reservation> Reservations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for ReservationService.MergeCapacityCommitments.</summary>
    public class MergeCapacityCommitmentsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Ids of capacity commitments to merge. These capacity commitments must exist under admin project and location
        /// specified in the parent. ID is the last portion of capacity commitment name e.g., 'abc' for
        /// projects/myproject/locations/US/capacityCommitments/abc
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("capacityCommitmentIds")]
        public virtual System.Collections.Generic.IList<string> CapacityCommitmentIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The request for ReservationService.MoveAssignment. **Note**: "bigquery.reservationAssignments.create" permission
    /// is required on the destination_id. **Note**: "bigquery.reservationAssignments.create" and
    /// "bigquery.reservationAssignments.delete" permission are required on the related assignee.
    /// </summary>
    public class MoveAssignmentRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The new reservation ID, e.g.: `projects/myotherproject/locations/US/reservations/team2-prod`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationId")]
        public virtual string DestinationId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A reservation is a mechanism used to guarantee slots to users.</summary>
    public class Reservation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Creation time of the reservation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationTime")]
        public virtual object CreationTime { get; set; }

        /// <summary>
        /// If false, any query or pipeline job using this reservation will use idle slots from other reservations
        /// within the same admin project. If true, a query or pipeline job using this reservation will execute with the
        /// slot capacity specified above at most.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ignoreIdleSlots")]
        public virtual System.Nullable<bool> IgnoreIdleSlots { get; set; }

        /// <summary>
        /// The resource name of the reservation, e.g., `projects/*/locations/*/reservations/team1-prod`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Minimum slots available to this reservation. A slot is a unit of computational power in BigQuery, and serves
        /// as the unit of parallelism. Queries using this reservation might use more slots during runtime if
        /// ignore_idle_slots is set to false. If the new reservation's slot capacity exceed the parent's slot capacity
        /// or if total slot capacity of the new reservation and its siblings exceeds the parent's slot capacity, the
        /// request will fail with `google.rpc.Code.RESOURCE_EXHAUSTED`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("slotCapacity")]
        public virtual System.Nullable<long> SlotCapacity { get; set; }

        /// <summary>Output only. Last update time of the reservation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for ReservationService.SearchAllAssignments.</summary>
    public class SearchAllAssignmentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of assignments visible to the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assignments")]
        public virtual System.Collections.Generic.IList<Assignment> Assignments { get; set; }

        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for ReservationService.SearchAssignments.</summary>
    public class SearchAssignmentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of assignments visible to the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assignments")]
        public virtual System.Collections.Generic.IList<Assignment> Assignments { get; set; }

        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for ReservationService.SplitCapacityCommitment.</summary>
    public class SplitCapacityCommitmentRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of slots in the capacity commitment after the split.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("slotCount")]
        public virtual System.Nullable<long> SlotCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for ReservationService.SplitCapacityCommitment.</summary>
    public class SplitCapacityCommitmentResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>First capacity commitment, result of a split.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("first")]
        public virtual CapacityCommitment First { get; set; }

        /// <summary>Second capacity commitment, result of a split.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("second")]
        public virtual CapacityCommitment Second { get; set; }

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
