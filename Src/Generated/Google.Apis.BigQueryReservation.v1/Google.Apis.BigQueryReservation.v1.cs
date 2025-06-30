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
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://bigqueryreservation.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://bigqueryreservation.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "bigqueryreservation";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the BigQuery Reservation API.</summary>
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

        /// <summary>Available OAuth 2.0 scope constants for use with the BigQuery Reservation API.</summary>
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
                ReservationGroups = new ReservationGroupsResource(service);
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
                    return new CreateRequest(this.service, body, parent);
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
                    /// this field is empty. This field must only contain lower case alphanumeric characters or dashes.
                    /// The first and last character cannot be a dash. Max length is 64 characters. NOTE: this ID won't
                    /// be kept if the capacity commitment is split or merged.
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
                    return new DeleteRequest(this.service, name);
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

                    /// <summary>
                    /// Can be used to force delete commitments even if assignments exist. Deleting commitments with
                    /// assignments may cause queries to fail if they no longer have access to slots.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/capacityCommitments/[^/]+$",
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

                /// <summary>Returns information about the capacity commitment.</summary>
                /// <param name="name">
                /// Required. Resource name of the capacity commitment to retrieve. E.g.,
                /// `projects/myproject/locations/US/capacityCommitments/123`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
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
                    return new ListRequest(this.service, parent);
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
                    return new MergeRequest(this.service, body, parent);
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
                /// `projects/myproject/locations/US/capacityCommitments/123` The commitment_id must only contain lower
                /// case alphanumeric characters or dashes. It must start with a letter and must not end with a dash.
                /// Its maximum length is 64 characters.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.BigQueryReservation.v1.Data.CapacityCommitment body, string name)
                {
                    return new PatchRequest(this.service, body, name);
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
                    /// `projects/myproject/locations/US/capacityCommitments/123` The commitment_id must only contain
                    /// lower case alphanumeric characters or dashes. It must start with a letter and must not end with
                    /// a dash. Its maximum length is 64 characters.
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
                /// delete the first one after the commitment end time passes.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The resource name e.g.,: `projects/myproject/locations/US/capacityCommitments/123`
                /// </param>
                public virtual SplitRequest Split(Google.Apis.BigQueryReservation.v1.Data.SplitCapacityCommitmentRequest body, string name)
                {
                    return new SplitRequest(this.service, body, name);
                }

                /// <summary>
                /// Splits capacity commitment to two commitments of the same plan and `commitment_end_time`. A common
                /// use case is to enable downgrading commitments. For example, in order to downgrade from 10000 slots
                /// to 8000, you might split a 10000 capacity commitment into commitments of 2000 and 8000. Then, you
                /// delete the first one after the commitment end time passes.
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

            /// <summary>Gets the ReservationGroups resource.</summary>
            public virtual ReservationGroupsResource ReservationGroups { get; }

            /// <summary>The "reservationGroups" collection of methods.</summary>
            public class ReservationGroupsResource
            {
                private const string Resource = "reservationGroups";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ReservationGroupsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a new reservation group.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. Project, location. E.g., `projects/myproject/locations/US`</param>
                public virtual CreateRequest Create(Google.Apis.BigQueryReservation.v1.Data.ReservationGroup body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new reservation group.</summary>
                public class CreateRequest : BigQueryReservationBaseServiceRequest<Google.Apis.BigQueryReservation.v1.Data.ReservationGroup>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.BigQueryReservation.v1.Data.ReservationGroup body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. Project, location. E.g., `projects/myproject/locations/US`</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The reservation group ID. It must only contain lower case alphanumeric characters or
                    /// dashes. It must start with a letter and must not end with a dash. Its maximum length is 64
                    /// characters.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("reservationGroupId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ReservationGroupId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.BigQueryReservation.v1.Data.ReservationGroup Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/reservationGroups";

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
                        RequestParameters.Add("reservationGroupId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "reservationGroupId",
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
                /// Required. Resource name of the reservation group to retrieve. E.g.,
                /// `projects/myproject/locations/US/reservationGroups/team1-prod`
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
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
                    /// Required. Resource name of the reservation group to retrieve. E.g.,
                    /// `projects/myproject/locations/US/reservationGroups/team1-prod`
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/reservationGroups/[^/]+$",
                        });
                    }
                }

                /// <summary>Returns information about the reservation group.</summary>
                /// <param name="name">
                /// Required. Resource name of the reservation group to retrieve. E.g.,
                /// `projects/myproject/locations/US/reservationGroups/team1-prod`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Returns information about the reservation group.</summary>
                public class GetRequest : BigQueryReservationBaseServiceRequest<Google.Apis.BigQueryReservation.v1.Data.ReservationGroup>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Resource name of the reservation group to retrieve. E.g.,
                    /// `projects/myproject/locations/US/reservationGroups/team1-prod`
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/reservationGroups/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists all the reservation groups for the project in the specified location.</summary>
                /// <param name="parent">
                /// Required. The parent resource name containing project and location, e.g.:
                /// `projects/myproject/locations/US`
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists all the reservation groups for the project in the specified location.</summary>
                public class ListRequest : BigQueryReservationBaseServiceRequest<Google.Apis.BigQueryReservation.v1.Data.ListReservationGroupsResponse>
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
                    public override string RestPath => "v1/{+parent}/reservationGroups";

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
                        return new CreateRequest(this.service, body, parent);
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
                        /// empty. This field must only contain lower case alphanumeric characters or dashes. Max length
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
                        return new DeleteRequest(this.service, name);
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
                    /// Gets the access control policy for a resource. May return: * A`NOT_FOUND` error if the resource
                    /// doesn't exist or you don't have the permission to view it. * An empty policy if the resource
                    /// exists but doesn't have a set policy. Supported resources are: - Reservations -
                    /// ReservationAssignments To call this method, you must have the following Google IAM permissions:
                    /// - `bigqueryreservation.reservations.getIamPolicy` to get policies on reservations.
                    /// </summary>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy is being requested. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </param>
                    public virtual GetIamPolicyRequest GetIamPolicy(string resource)
                    {
                        return new GetIamPolicyRequest(this.service, resource);
                    }

                    /// <summary>
                    /// Gets the access control policy for a resource. May return: * A`NOT_FOUND` error if the resource
                    /// doesn't exist or you don't have the permission to view it. * An empty policy if the resource
                    /// exists but doesn't have a set policy. Supported resources are: - Reservations -
                    /// ReservationAssignments To call this method, you must have the following Google IAM permissions:
                    /// - `bigqueryreservation.reservations.getIamPolicy` to get policies on reservations.
                    /// </summary>
                    public class GetIamPolicyRequest : BigQueryReservationBaseServiceRequest<Google.Apis.BigQueryReservation.v1.Data.Policy>
                    {
                        /// <summary>Constructs a new GetIamPolicy request.</summary>
                        public GetIamPolicyRequest(Google.Apis.Services.IClientService service, string resource) : base(service)
                        {
                            Resource = resource;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy is being requested. See [Resource
                        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for
                        /// this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>
                        /// Optional. The maximum policy version that will be used to format the policy. Valid values
                        /// are 0, 1, and 3. Requests specifying an invalid value will be rejected. Requests for
                        /// policies with any conditional role bindings must specify version 3. Policies with no
                        /// conditional role bindings may specify any valid value or leave the field unset. The policy
                        /// in the response might use the policy version that you specified, or it might use a lower
                        /// policy version. For example, if you specify version 3, but the policy has no conditional
                        /// role bindings, the response uses version 1. To learn which resources support conditions in
                        /// their IAM policies, see the [IAM
                        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("options.requestedPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> OptionsRequestedPolicyVersion { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "getIamPolicy";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/reservations/[^/]+/assignments/[^/]+$",
                            });
                            RequestParameters.Add("options.requestedPolicyVersion", new Google.Apis.Discovery.Parameter
                            {
                                Name = "options.requestedPolicyVersion",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
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
                        return new ListRequest(this.service, parent);
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
                        return new MoveRequest(this.service, body, name);
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

                    /// <summary>Updates an existing assignment. Only the `priority` field can be updated.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Output only. Name of the resource. E.g.:
                    /// `projects/myproject/locations/US/reservations/team1-prod/assignments/123`. The assignment_id
                    /// must only contain lower case alphanumeric characters or dashes and the max length is 64
                    /// characters.
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.BigQueryReservation.v1.Data.Assignment body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>Updates an existing assignment. Only the `priority` field can be updated.</summary>
                    public class PatchRequest : BigQueryReservationBaseServiceRequest<Google.Apis.BigQueryReservation.v1.Data.Assignment>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.BigQueryReservation.v1.Data.Assignment body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Output only. Name of the resource. E.g.:
                        /// `projects/myproject/locations/US/reservations/team1-prod/assignments/123`. The assignment_id
                        /// must only contain lower case alphanumeric characters or dashes and the max length is 64
                        /// characters.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Standard field mask for the set of fields to be updated.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.BigQueryReservation.v1.Data.Assignment Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/reservations/[^/]+/assignments/[^/]+$",
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
                    /// Sets an access control policy for a resource. Replaces any existing policy. Supported resources
                    /// are: - Reservations To call this method, you must have the following Google IAM permissions: -
                    /// `bigqueryreservation.reservations.setIamPolicy` to set policies on reservations.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy is being specified. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </param>
                    public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.BigQueryReservation.v1.Data.SetIamPolicyRequest body, string resource)
                    {
                        return new SetIamPolicyRequest(this.service, body, resource);
                    }

                    /// <summary>
                    /// Sets an access control policy for a resource. Replaces any existing policy. Supported resources
                    /// are: - Reservations To call this method, you must have the following Google IAM permissions: -
                    /// `bigqueryreservation.reservations.setIamPolicy` to set policies on reservations.
                    /// </summary>
                    public class SetIamPolicyRequest : BigQueryReservationBaseServiceRequest<Google.Apis.BigQueryReservation.v1.Data.Policy>
                    {
                        /// <summary>Constructs a new SetIamPolicy request.</summary>
                        public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.BigQueryReservation.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                        Google.Apis.BigQueryReservation.v1.Data.SetIamPolicyRequest Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/reservations/[^/]+/assignments/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Gets your permissions on a resource. Returns an empty set of permissions if the resource doesn't
                    /// exist. Supported resources are: - Reservations No Google IAM permissions are required to call
                    /// this method.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </param>
                    public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.BigQueryReservation.v1.Data.TestIamPermissionsRequest body, string resource)
                    {
                        return new TestIamPermissionsRequest(this.service, body, resource);
                    }

                    /// <summary>
                    /// Gets your permissions on a resource. Returns an empty set of permissions if the resource doesn't
                    /// exist. Supported resources are: - Reservations No Google IAM permissions are required to call
                    /// this method.
                    /// </summary>
                    public class TestIamPermissionsRequest : BigQueryReservationBaseServiceRequest<Google.Apis.BigQueryReservation.v1.Data.TestIamPermissionsResponse>
                    {
                        /// <summary>Constructs a new TestIamPermissions request.</summary>
                        public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.BigQueryReservation.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                        Google.Apis.BigQueryReservation.v1.Data.TestIamPermissionsRequest Body { get; set; }

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
                    return new CreateRequest(this.service, body, parent);
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
                    /// The reservation ID. It must only contain lower case alphanumeric characters or dashes. It must
                    /// start with a letter and must not end with a dash. Its maximum length is 64 characters.
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
                    return new DeleteRequest(this.service, name);
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

                /// <summary>
                /// Fail over a reservation to the secondary location. The operation should be done in the current
                /// secondary location, which will be promoted to the new primary location for the reservation.
                /// Attempting to failover a reservation in the current primary location will fail with the error code
                /// `google.rpc.Code.FAILED_PRECONDITION`.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Resource name of the reservation to failover. E.g.,
                /// `projects/myproject/locations/US/reservations/team1-prod`
                /// </param>
                public virtual FailoverReservationRequest FailoverReservation(Google.Apis.BigQueryReservation.v1.Data.FailoverReservationRequest body, string name)
                {
                    return new FailoverReservationRequest(this.service, body, name);
                }

                /// <summary>
                /// Fail over a reservation to the secondary location. The operation should be done in the current
                /// secondary location, which will be promoted to the new primary location for the reservation.
                /// Attempting to failover a reservation in the current primary location will fail with the error code
                /// `google.rpc.Code.FAILED_PRECONDITION`.
                /// </summary>
                public class FailoverReservationRequest : BigQueryReservationBaseServiceRequest<Google.Apis.BigQueryReservation.v1.Data.Reservation>
                {
                    /// <summary>Constructs a new FailoverReservation request.</summary>
                    public FailoverReservationRequest(Google.Apis.Services.IClientService service, Google.Apis.BigQueryReservation.v1.Data.FailoverReservationRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Resource name of the reservation to failover. E.g.,
                    /// `projects/myproject/locations/US/reservations/team1-prod`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.BigQueryReservation.v1.Data.FailoverReservationRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "failoverReservation";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:failoverReservation";

                    /// <summary>Initializes FailoverReservation parameter list.</summary>
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
                    return new GetRequest(this.service, name);
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

                /// <summary>
                /// Gets the access control policy for a resource. May return: * A`NOT_FOUND` error if the resource
                /// doesn't exist or you don't have the permission to view it. * An empty policy if the resource exists
                /// but doesn't have a set policy. Supported resources are: - Reservations - ReservationAssignments To
                /// call this method, you must have the following Google IAM permissions: -
                /// `bigqueryreservation.reservations.getIamPolicy` to get policies on reservations.
                /// </summary>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual GetIamPolicyRequest GetIamPolicy(string resource)
                {
                    return new GetIamPolicyRequest(this.service, resource);
                }

                /// <summary>
                /// Gets the access control policy for a resource. May return: * A`NOT_FOUND` error if the resource
                /// doesn't exist or you don't have the permission to view it. * An empty policy if the resource exists
                /// but doesn't have a set policy. Supported resources are: - Reservations - ReservationAssignments To
                /// call this method, you must have the following Google IAM permissions: -
                /// `bigqueryreservation.reservations.getIamPolicy` to get policies on reservations.
                /// </summary>
                public class GetIamPolicyRequest : BigQueryReservationBaseServiceRequest<Google.Apis.BigQueryReservation.v1.Data.Policy>
                {
                    /// <summary>Constructs a new GetIamPolicy request.</summary>
                    public GetIamPolicyRequest(Google.Apis.Services.IClientService service, string resource) : base(service)
                    {
                        Resource = resource;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy is being requested. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>
                    /// Optional. The maximum policy version that will be used to format the policy. Valid values are 0,
                    /// 1, and 3. Requests specifying an invalid value will be rejected. Requests for policies with any
                    /// conditional role bindings must specify version 3. Policies with no conditional role bindings may
                    /// specify any valid value or leave the field unset. The policy in the response might use the
                    /// policy version that you specified, or it might use a lower policy version. For example, if you
                    /// specify version 3, but the policy has no conditional role bindings, the response uses version 1.
                    /// To learn which resources support conditions in their IAM policies, see the [IAM
                    /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("options.requestedPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> OptionsRequestedPolicyVersion { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "getIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/reservations/[^/]+$",
                        });
                        RequestParameters.Add("options.requestedPolicyVersion", new Google.Apis.Discovery.Parameter
                        {
                            Name = "options.requestedPolicyVersion",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
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
                    return new ListRequest(this.service, parent);
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
                /// Identifier. The resource name of the reservation, e.g.,
                /// `projects/*/locations/*/reservations/team1-prod`. The reservation_id must only contain lower case
                /// alphanumeric characters or dashes. It must start with a letter and must not end with a dash. Its
                /// maximum length is 64 characters.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.BigQueryReservation.v1.Data.Reservation body, string name)
                {
                    return new PatchRequest(this.service, body, name);
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
                    /// Identifier. The resource name of the reservation, e.g.,
                    /// `projects/*/locations/*/reservations/team1-prod`. The reservation_id must only contain lower
                    /// case alphanumeric characters or dashes. It must start with a letter and must not end with a
                    /// dash. Its maximum length is 64 characters.
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

                /// <summary>
                /// Sets an access control policy for a resource. Replaces any existing policy. Supported resources are:
                /// - Reservations To call this method, you must have the following Google IAM permissions: -
                /// `bigqueryreservation.reservations.setIamPolicy` to set policies on reservations.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.BigQueryReservation.v1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(this.service, body, resource);
                }

                /// <summary>
                /// Sets an access control policy for a resource. Replaces any existing policy. Supported resources are:
                /// - Reservations To call this method, you must have the following Google IAM permissions: -
                /// `bigqueryreservation.reservations.setIamPolicy` to set policies on reservations.
                /// </summary>
                public class SetIamPolicyRequest : BigQueryReservationBaseServiceRequest<Google.Apis.BigQueryReservation.v1.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.BigQueryReservation.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                    Google.Apis.BigQueryReservation.v1.Data.SetIamPolicyRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/reservations/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Gets your permissions on a resource. Returns an empty set of permissions if the resource doesn't
                /// exist. Supported resources are: - Reservations No Google IAM permissions are required to call this
                /// method.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.BigQueryReservation.v1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(this.service, body, resource);
                }

                /// <summary>
                /// Gets your permissions on a resource. Returns an empty set of permissions if the resource doesn't
                /// exist. Supported resources are: - Reservations No Google IAM permissions are required to call this
                /// method.
                /// </summary>
                public class TestIamPermissionsRequest : BigQueryReservationBaseServiceRequest<Google.Apis.BigQueryReservation.v1.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.BigQueryReservation.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                    Google.Apis.BigQueryReservation.v1.Data.TestIamPermissionsRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/reservations/[^/]+$",
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
                return new GetBiReservationRequest(this.service, name);
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
                return new SearchAllAssignmentsRequest(this.service, parent);
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
            /// Deprecated: Looks up assignments for a specified resource for a particular region. If the request is
            /// about a project: 1. Assignments created on the project will be returned if they exist. 2. Otherwise
            /// assignments created on the closest ancestor will be returned. 3. Assignments for different JobTypes will
            /// all be returned. The same logic applies if the request is about a folder. If the request is about an
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
                return new SearchAssignmentsRequest(this.service, parent);
            }

            /// <summary>
            /// Deprecated: Looks up assignments for a specified resource for a particular region. If the request is
            /// about a project: 1. Assignments created on the project will be returned if they exist. 2. Otherwise
            /// assignments created on the closest ancestor will be returned. 3. Assignments for different JobTypes will
            /// all be returned. The same logic applies if the request is about a folder. If the request is about an
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
            /// Identifier. The resource name of the singleton BI reservation. Reservation names have the form
            /// `projects/{project_id}/locations/{location_id}/biReservation`.
            /// </param>
            public virtual UpdateBiReservationRequest UpdateBiReservation(Google.Apis.BigQueryReservation.v1.Data.BiReservation body, string name)
            {
                return new UpdateBiReservationRequest(this.service, body, name);
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
                /// Identifier. The resource name of the singleton BI reservation. Reservation names have the form
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
    /// An assignment allows a project to submit jobs of a certain type using slots from the specified reservation.
    /// </summary>
    public class Assignment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The resource which will use the reservation. E.g. `projects/myproject`, `folders/123`, or
        /// `organizations/456`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assignee")]
        public virtual string Assignee { get; set; }

        /// <summary>
        /// Optional. This field controls if "Gemini in BigQuery"
        /// (https://cloud.google.com/gemini/docs/bigquery/overview) features should be enabled for this reservation
        /// assignment, which is not on by default. "Gemini in BigQuery" has a distinct compliance posture from
        /// BigQuery. If this field is set to true, the assignment job type is QUERY, and the parent reservation edition
        /// is ENTERPRISE_PLUS, then the assignment will give the grantee project/organization access to "Gemini in
        /// BigQuery" features.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableGeminiInBigquery")]
        public virtual System.Nullable<bool> EnableGeminiInBigquery { get; set; }

        /// <summary>Optional. Which type of jobs will use the reservation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobType")]
        public virtual string JobType { get; set; }

        /// <summary>
        /// Output only. Name of the resource. E.g.:
        /// `projects/myproject/locations/US/reservations/team1-prod/assignments/123`. The assignment_id must only
        /// contain lower case alphanumeric characters or dashes and the max length is 64 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. State of the assignment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

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

    /// <summary>Auto scaling settings.</summary>
    public class Autoscale : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The slot capacity added to this reservation when autoscale happens. Will be between [0,
        /// max_slots]. Note: after users reduce max_slots, it may take a while before it can be propagated, so
        /// current_slots may stay in the original value and could be larger than max_slots for that brief period (less
        /// than one minute)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentSlots")]
        public virtual System.Nullable<long> CurrentSlots { get; set; }

        /// <summary>Optional. Number of slots to be scaled when needed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxSlots")]
        public virtual System.Nullable<long> MaxSlots { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a BI Reservation.</summary>
    public class BiReservation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Identifier. The resource name of the singleton BI reservation. Reservation names have the form
        /// `projects/{project_id}/locations/{location_id}/biReservation`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. Preferred tables to use BI capacity for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("preferredTables")]
        public virtual System.Collections.Generic.IList<TableReference> PreferredTables { get; set; }

        /// <summary>Optional. Size of a reservation, in bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("size")]
        public virtual System.Nullable<long> Size { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The last update timestamp of a reservation.</summary>
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

    /// <summary>
    /// Capacity commitment is a way to purchase compute capacity for BigQuery jobs (in the form of slots) with some
    /// committed period of usage. Annual commitments renew by default. Commitments can be removed after their
    /// commitment end time passes. In order to remove annual commitment, its plan needs to be changed to monthly or
    /// flex first. A capacity commitment resource exists as a child resource of the admin project.
    /// </summary>
    public class CapacityCommitment : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _commitmentEndTimeRaw;

        private object _commitmentEndTime;

        /// <summary>
        /// Output only. The end of the current commitment period. It is applicable only for ACTIVE capacity
        /// commitments. Note after renewal, commitment_end_time is the time the renewed commitment expires. So itwould
        /// be at a time after commitment_start_time + committed period, because we don't change commitment_start_time ,
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commitmentEndTime")]
        public virtual string CommitmentEndTimeRaw
        {
            get => _commitmentEndTimeRaw;
            set
            {
                _commitmentEndTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _commitmentEndTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CommitmentEndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CommitmentEndTimeDateTimeOffset instead.")]
        public virtual object CommitmentEndTime
        {
            get => _commitmentEndTime;
            set
            {
                _commitmentEndTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _commitmentEndTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="CommitmentEndTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CommitmentEndTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CommitmentEndTimeRaw);
            set => CommitmentEndTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _commitmentStartTimeRaw;

        private object _commitmentStartTime;

        /// <summary>
        /// Output only. The start of the current commitment period. It is applicable only for ACTIVE capacity
        /// commitments. Note after the commitment is renewed, commitment_start_time won't be changed. It refers to the
        /// start time of the original commitment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commitmentStartTime")]
        public virtual string CommitmentStartTimeRaw
        {
            get => _commitmentStartTimeRaw;
            set
            {
                _commitmentStartTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _commitmentStartTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CommitmentStartTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CommitmentStartTimeDateTimeOffset instead.")]
        public virtual object CommitmentStartTime
        {
            get => _commitmentStartTime;
            set
            {
                _commitmentStartTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _commitmentStartTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="CommitmentStartTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CommitmentStartTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CommitmentStartTimeRaw);
            set => CommitmentStartTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Optional. Edition of the capacity commitment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("edition")]
        public virtual string Edition { get; set; }

        /// <summary>Output only. For FAILED commitment plan, provides the reason of failure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failureStatus")]
        public virtual Status FailureStatus { get; set; }

        /// <summary>
        /// Output only. If true, the commitment is a flat-rate commitment, otherwise, it's an edition commitment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isFlatRate")]
        public virtual System.Nullable<bool> IsFlatRate { get; set; }

        /// <summary>
        /// Applicable only for commitments located within one of the BigQuery multi-regions (US or EU). If set to true,
        /// this commitment is placed in the organization's secondary region which is designated for disaster recovery
        /// purposes. If false, this commitment is placed in the organization's default region. NOTE: this is a preview
        /// feature. Project must be allow-listed in order to set this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("multiRegionAuxiliary")]
        public virtual System.Nullable<bool> MultiRegionAuxiliary { get; set; }

        /// <summary>
        /// Output only. The resource name of the capacity commitment, e.g.,
        /// `projects/myproject/locations/US/capacityCommitments/123` The commitment_id must only contain lower case
        /// alphanumeric characters or dashes. It must start with a letter and must not end with a dash. Its maximum
        /// length is 64 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. Capacity commitment commitment plan.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("plan")]
        public virtual string Plan { get; set; }

        /// <summary>
        /// Optional. The plan this capacity commitment is converted to after commitment_end_time passes. Once the plan
        /// is changed, committed period is extended according to commitment plan. Only applicable for ANNUAL and TRIAL
        /// commitments.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("renewalPlan")]
        public virtual string RenewalPlan { get; set; }

        /// <summary>Optional. Number of slots in this commitment.</summary>
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
    /// Bar(google.protobuf.Empty) returns (google.protobuf.Empty); }
    /// </summary>
    public class Empty : Google.Apis.Requests.IDirectResponseSchema
    {
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

    /// <summary>The request for ReservationService.FailoverReservation.</summary>
    public class FailoverReservationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. failover mode for the failover operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failoverMode")]
        public virtual string FailoverMode { get; set; }

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

    /// <summary>The response for ReservationService.ListReservationGroups.</summary>
    public class ListReservationGroupsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of reservations visible to the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reservationGroups")]
        public virtual System.Collections.Generic.IList<ReservationGroup> ReservationGroups { get; set; }

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
        /// Optional. The optional resulting capacity commitment ID. Capacity commitment name will be generated
        /// automatically if this field is empty. This field must only contain lower case alphanumeric characters or
        /// dashes. The first and last character cannot be a dash. Max length is 64 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("capacityCommitmentId")]
        public virtual string CapacityCommitmentId { get; set; }

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
        /// The optional assignment ID. A new assignment name is generated if this field is empty. This field can
        /// contain only lowercase alphanumeric characters or dashes. Max length is 64 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assignmentId")]
        public virtual string AssignmentId { get; set; }

        /// <summary>
        /// The new reservation ID, e.g.: `projects/myotherproject/locations/US/reservations/team2-prod`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationId")]
        public virtual string DestinationId { get; set; }

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

    /// <summary>Disaster Recovery(DR) replication status of the reservation.</summary>
    public class ReplicationStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The last error encountered while trying to replicate changes from the primary to the secondary.
        /// This field is only available if the replication has not succeeded since.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; }

        private string _lastErrorTimeRaw;

        private object _lastErrorTime;

        /// <summary>
        /// Output only. The time at which the last error was encountered while trying to replicate changes from the
        /// primary to the secondary. This field is only available if the replication has not succeeded since.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastErrorTime")]
        public virtual string LastErrorTimeRaw
        {
            get => _lastErrorTimeRaw;
            set
            {
                _lastErrorTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lastErrorTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LastErrorTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LastErrorTimeDateTimeOffset instead.")]
        public virtual object LastErrorTime
        {
            get => _lastErrorTime;
            set
            {
                _lastErrorTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lastErrorTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="LastErrorTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LastErrorTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LastErrorTimeRaw);
            set => LastErrorTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _lastReplicationTimeRaw;

        private object _lastReplicationTime;

        /// <summary>
        /// Output only. A timestamp corresponding to the last change on the primary that was successfully replicated to
        /// the secondary.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastReplicationTime")]
        public virtual string LastReplicationTimeRaw
        {
            get => _lastReplicationTimeRaw;
            set
            {
                _lastReplicationTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lastReplicationTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LastReplicationTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LastReplicationTimeDateTimeOffset instead.")]
        public virtual object LastReplicationTime
        {
            get => _lastReplicationTime;
            set
            {
                _lastReplicationTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lastReplicationTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="LastReplicationTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LastReplicationTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LastReplicationTimeRaw);
            set => LastReplicationTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _softFailoverStartTimeRaw;

        private object _softFailoverStartTime;

        /// <summary>
        /// Output only. The time at which a soft failover for the reservation and its associated datasets was
        /// initiated. After this field is set, all subsequent changes to the reservation will be rejected unless a hard
        /// failover overrides this operation. This field will be cleared once the failover is complete.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("softFailoverStartTime")]
        public virtual string SoftFailoverStartTimeRaw
        {
            get => _softFailoverStartTimeRaw;
            set
            {
                _softFailoverStartTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _softFailoverStartTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="SoftFailoverStartTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use SoftFailoverStartTimeDateTimeOffset instead.")]
        public virtual object SoftFailoverStartTime
        {
            get => _softFailoverStartTime;
            set
            {
                _softFailoverStartTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _softFailoverStartTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="SoftFailoverStartTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? SoftFailoverStartTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(SoftFailoverStartTimeRaw);
            set => SoftFailoverStartTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A reservation is a mechanism used to guarantee slots to users.</summary>
    public class Reservation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The configuration parameters for the auto scaling feature.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoscale")]
        public virtual Autoscale Autoscale { get; set; }

        /// <summary>
        /// Optional. Job concurrency target which sets a soft upper bound on the number of jobs that can run
        /// concurrently in this reservation. This is a soft target due to asynchronous nature of the system and various
        /// optimizations for small queries. Default value is 0 which means that concurrency target will be
        /// automatically computed by the system. NOTE: this field is exposed as target job concurrency in the
        /// Information Schema, DDL and BigQuery CLI.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("concurrency")]
        public virtual System.Nullable<long> Concurrency { get; set; }

        private string _creationTimeRaw;

        private object _creationTime;

        /// <summary>Output only. Creation time of the reservation.</summary>
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

        /// <summary>Optional. Edition of the reservation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("edition")]
        public virtual string Edition { get; set; }

        /// <summary>
        /// Optional. If false, any query or pipeline job using this reservation will use idle slots from other
        /// reservations within the same admin project. If true, a query or pipeline job using this reservation will
        /// execute with the slot capacity specified in the slot_capacity field at most.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ignoreIdleSlots")]
        public virtual System.Nullable<bool> IgnoreIdleSlots { get; set; }

        /// <summary>
        /// Optional. The labels associated with this reservation. You can use these to organize and group your
        /// reservations. You can set this property when you create or update a reservation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Optional. The overall max slots for the reservation, covering slot_capacity (baseline), idle slots (if
        /// ignore_idle_slots is false) and scaled slots. If present, the reservation won't use more than the specified
        /// number of slots, even if there is demand and supply (from idle slots). NOTE: capping a reservation's idle
        /// slot usage is best effort and its usage may exceed the max_slots value. However, in terms of
        /// autoscale.current_slots (which accounts for the additional added slots), it will never exceed the max_slots
        /// - baseline. This field must be set together with the scaling_mode enum value, otherwise the request will be
        /// rejected with error code `google.rpc.Code.INVALID_ARGUMENT`. If the max_slots and scaling_mode are set, the
        /// autoscale or autoscale.max_slots field must be unset. Otherwise the request will be rejected with error code
        /// `google.rpc.Code.INVALID_ARGUMENT`. However, the autoscale field may still be in the output. The
        /// autopscale.max_slots will always show as 0 and the autoscaler.current_slots will represent the current slots
        /// from autoscaler excluding idle slots. For example, if the max_slots is 1000 and scaling_mode is
        /// AUTOSCALE_ONLY, then in the output, the autoscaler.max_slots will be 0 and the autoscaler.current_slots may
        /// be any value between 0 and 1000. If the max_slots is 1000, scaling_mode is ALL_SLOTS, the baseline is 100
        /// and idle slots usage is 200, then in the output, the autoscaler.max_slots will be 0 and the
        /// autoscaler.current_slots will not be higher than 700. If the max_slots is 1000, scaling_mode is
        /// IDLE_SLOTS_ONLY, then in the output, the autoscaler field will be null. If the max_slots and scaling_mode
        /// are set, then the ignore_idle_slots field must be aligned with the scaling_mode enum value.(See details in
        /// ScalingMode comments). Otherwise the request will be rejected with error code
        /// `google.rpc.Code.INVALID_ARGUMENT`. Please note, the max_slots is for user to manage the part of slots
        /// greater than the baseline. Therefore, we don't allow users to set max_slots smaller or equal to the baseline
        /// as it will not be meaningful. If the field is present and slot_capacity&amp;gt;=max_slots, requests will be
        /// rejected with error code `google.rpc.Code.INVALID_ARGUMENT`. Please note that if max_slots is set to 0, we
        /// will treat it as unset. Customers can set max_slots to 0 and set scaling_mode to SCALING_MODE_UNSPECIFIED to
        /// disable the max_slots feature.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxSlots")]
        public virtual System.Nullable<long> MaxSlots { get; set; }

        /// <summary>
        /// Applicable only for reservations located within one of the BigQuery multi-regions (US or EU). If set to
        /// true, this reservation is placed in the organization's secondary region which is designated for disaster
        /// recovery purposes. If false, this reservation is placed in the organization's default region. NOTE: this is
        /// a preview feature. Project must be allow-listed in order to set this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("multiRegionAuxiliary")]
        public virtual System.Nullable<bool> MultiRegionAuxiliary { get; set; }

        /// <summary>
        /// Identifier. The resource name of the reservation, e.g., `projects/*/locations/*/reservations/team1-prod`.
        /// The reservation_id must only contain lower case alphanumeric characters or dashes. It must start with a
        /// letter and must not end with a dash. Its maximum length is 64 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The location where the reservation was originally created. This is set only during the failover
        /// reservation's creation. All billing charges for the failover reservation will be applied to this location.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalPrimaryLocation")]
        public virtual string OriginalPrimaryLocation { get; set; }

        /// <summary>
        /// Output only. The current location of the reservation's primary replica. This field is only set for
        /// reservations using the managed disaster recovery feature.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryLocation")]
        public virtual string PrimaryLocation { get; set; }

        /// <summary>
        /// Output only. The Disaster Recovery(DR) replication status of the reservation. This is only available for the
        /// primary replicas of DR/failover reservations and provides information about the both the staleness of the
        /// secondary and the last error encountered while trying to replicate changes from the primary to the
        /// secondary. If this field is blank, it means that the reservation is either not a DR reservation or the
        /// reservation is a DR secondary or that any replication operations on the reservation have succeeded.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replicationStatus")]
        public virtual ReplicationStatus ReplicationStatus { get; set; }

        /// <summary>
        /// Optional. The reservation group that this reservation belongs to. You can set this property when you create
        /// or update a reservation. Reservations do not need to belong to a reservation group. Format:
        /// projects/{project}/locations/{location}/reservationGroups/{reservation_group} or just {reservation_group}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reservationGroup")]
        public virtual string ReservationGroup { get; set; }

        /// <summary>
        /// Optional. The scaling mode for the reservation. If the field is present but max_slots is not present,
        /// requests will be rejected with error code `google.rpc.Code.INVALID_ARGUMENT`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scalingMode")]
        public virtual string ScalingMode { get; set; }

        /// <summary>
        /// Optional. The current location of the reservation's secondary replica. This field is only set for
        /// reservations using the managed disaster recovery feature. Users can set this in create reservation calls to
        /// create a failover reservation or in update reservation calls to convert a non-failover reservation to a
        /// failover reservation(or vice versa).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secondaryLocation")]
        public virtual string SecondaryLocation { get; set; }

        /// <summary>
        /// Optional. Baseline slots available to this reservation. A slot is a unit of computational power in BigQuery,
        /// and serves as the unit of parallelism. Queries using this reservation might use more slots during runtime if
        /// ignore_idle_slots is set to false, or autoscaling is enabled. The total slot_capacity of the reservation and
        /// its siblings may exceed the total slot_count of capacity commitments. In that case, the exceeding slots will
        /// be charged with the autoscale SKU. You can increase the number of baseline slots in a reservation every few
        /// minutes. If you want to decrease your baseline slots, you are limited to once an hour if you have recently
        /// changed your baseline slot capacity and your baseline slots exceed your committed slots. Otherwise, you can
        /// decrease your baseline slots every few minutes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("slotCapacity")]
        public virtual System.Nullable<long> SlotCapacity { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Last update time of the reservation.</summary>
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

    /// <summary>A reservation group is a container for reservations.</summary>
    public class ReservationGroup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Identifier. The resource name of the reservation group, e.g.,
        /// `projects/*/locations/*/reservationGroups/team1-prod`. The reservation_group_id must only contain lower case
        /// alphanumeric characters or dashes. It must start with a letter and must not end with a dash. Its maximum
        /// length is 64 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

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

    /// <summary>
    /// Fully qualified reference to BigQuery table. Internally stored as google.cloud.bi.v1.BqTableReference.
    /// </summary>
    public class TableReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The ID of the dataset in the above project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datasetId")]
        public virtual string DatasetId { get; set; }

        /// <summary>Optional. The assigned project ID of the project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>Optional. The ID of the table in the above dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableId")]
        public virtual string TableId { get; set; }

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
}
