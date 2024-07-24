// Copyright 2024 Google LLC
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

namespace Google.Apis.CloudControlsPartnerService.v1
{
    /// <summary>The CloudControlsPartnerService Service.</summary>
    public class CloudControlsPartnerServiceService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CloudControlsPartnerServiceService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CloudControlsPartnerServiceService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Organizations = new OrganizationsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://cloudcontrolspartner.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://cloudcontrolspartner.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "cloudcontrolspartner";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Controls Partner API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Controls Partner API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Organizations resource.</summary>
        public virtual OrganizationsResource Organizations { get; }
    }

    /// <summary>A base abstract class for CloudControlsPartnerService requests.</summary>
    public abstract class CloudControlsPartnerServiceBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new CloudControlsPartnerServiceBaseServiceRequest instance.</summary>
        protected CloudControlsPartnerServiceBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes CloudControlsPartnerService parameter list.</summary>
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
                Customers = new CustomersResource(service);
            }

            /// <summary>Gets the Customers resource.</summary>
            public virtual CustomersResource Customers { get; }

            /// <summary>The "customers" collection of methods.</summary>
            public class CustomersResource
            {
                private const string Resource = "customers";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public CustomersResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Workloads = new WorkloadsResource(service);
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
                        AccessApprovalRequests = new AccessApprovalRequestsResource(service);
                        Violations = new ViolationsResource(service);
                    }

                    /// <summary>Gets the AccessApprovalRequests resource.</summary>
                    public virtual AccessApprovalRequestsResource AccessApprovalRequests { get; }

                    /// <summary>The "accessApprovalRequests" collection of methods.</summary>
                    public class AccessApprovalRequestsResource
                    {
                        private const string Resource = "accessApprovalRequests";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public AccessApprovalRequestsResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                        }

                        /// <summary>
                        /// Deprecated: Only returns access approval requests directly associated with an assured
                        /// workload folder.
                        /// </summary>
                        /// <param name="parent">
                        /// Required. Parent resource Format:
                        /// `organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}`
                        /// </param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(this.service, parent);
                        }

                        /// <summary>
                        /// Deprecated: Only returns access approval requests directly associated with an assured
                        /// workload folder.
                        /// </summary>
                        public class ListRequest : CloudControlsPartnerServiceBaseServiceRequest<Google.Apis.CloudControlsPartnerService.v1.Data.ListAccessApprovalRequestsResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. Parent resource Format:
                            /// `organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}`
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>Optional. Filtering results.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string Filter { get; set; }

                            /// <summary>Optional. Hint for how to order the results.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string OrderBy { get; set; }

                            /// <summary>
                            /// Optional. The maximum number of access requests to return. The service may return fewer
                            /// than this value. If unspecified, at most 500 access requests will be returned.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>
                            /// Optional. A page token, received from a previous `ListAccessApprovalRequests` call.
                            /// Provide this to retrieve the subsequent page.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/accessApprovalRequests";

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
                                    Pattern = @"^organizations/[^/]+/locations/[^/]+/customers/[^/]+/workloads/[^/]+$",
                                });
                                RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "filter",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                                RequestParameters.Add("orderBy", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "orderBy",
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

                    /// <summary>Gets the Violations resource.</summary>
                    public virtual ViolationsResource Violations { get; }

                    /// <summary>The "violations" collection of methods.</summary>
                    public class ViolationsResource
                    {
                        private const string Resource = "violations";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public ViolationsResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                        }

                        /// <summary>Gets details of a single Violation.</summary>
                        /// <param name="name">
                        /// Required. Format:
                        /// `organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}/violations/{violation}`
                        /// </param>
                        public virtual GetRequest Get(string name)
                        {
                            return new GetRequest(this.service, name);
                        }

                        /// <summary>Gets details of a single Violation.</summary>
                        public class GetRequest : CloudControlsPartnerServiceBaseServiceRequest<Google.Apis.CloudControlsPartnerService.v1.Data.Violation>
                        {
                            /// <summary>Constructs a new Get request.</summary>
                            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. Format:
                            /// `organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}/violations/{violation}`
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
                                    Pattern = @"^organizations/[^/]+/locations/[^/]+/customers/[^/]+/workloads/[^/]+/violations/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Lists Violations for a workload Callers may also choose to read across multiple Customers or
                        /// for a single customer as per [AIP-159](https://google.aip.dev/159) by using '-' (the hyphen
                        /// or dash character) as a wildcard character instead of {customer} &amp;amp; {workload}.
                        /// Format:
                        /// `organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}`
                        /// </summary>
                        /// <param name="parent">
                        /// Required. Parent resource Format
                        /// `organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}`
                        /// </param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(this.service, parent);
                        }

                        /// <summary>
                        /// Lists Violations for a workload Callers may also choose to read across multiple Customers or
                        /// for a single customer as per [AIP-159](https://google.aip.dev/159) by using '-' (the hyphen
                        /// or dash character) as a wildcard character instead of {customer} &amp;amp; {workload}.
                        /// Format:
                        /// `organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}`
                        /// </summary>
                        public class ListRequest : CloudControlsPartnerServiceBaseServiceRequest<Google.Apis.CloudControlsPartnerService.v1.Data.ListViolationsResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. Parent resource Format
                            /// `organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}`
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>Optional. Filtering results</summary>
                            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string Filter { get; set; }

                            private object _intervalEndTime;

                            /// <summary>
                            /// String representation of <see cref="IntervalEndTimeDateTimeOffset"/>, formatted for
                            /// inclusion in the HTTP request.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("interval.endTime", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string IntervalEndTimeRaw { get; private set; }

                            /// <summary>
                            /// <seealso cref="object"/> representation of <see cref="IntervalEndTimeRaw"/>.
                            /// </summary>
                            [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use IntervalEndTimeDateTimeOffset instead.")]
                            public virtual object IntervalEndTime
                            {
                                get => _intervalEndTime;
                                set
                                {
                                    IntervalEndTimeRaw = Google.Apis.Util.Utilities.ConvertToString(value);
                                    _intervalEndTime = value;
                                }
                            }

                            public virtual System.DateTimeOffset? IntervalEndTimeDateTimeOffset
                            {
                                get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(IntervalEndTimeRaw);
                                set
                                {
                                    IntervalEndTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
                                    _intervalEndTime = value;
                                }
                            }

                            private object _intervalStartTime;

                            /// <summary>
                            /// String representation of <see cref="IntervalStartTimeDateTimeOffset"/>, formatted for
                            /// inclusion in the HTTP request.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("interval.startTime", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string IntervalStartTimeRaw { get; private set; }

                            /// <summary>
                            /// <seealso cref="object"/> representation of <see cref="IntervalStartTimeRaw"/>.
                            /// </summary>
                            [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use IntervalStartTimeDateTimeOffset instead.")]
                            public virtual object IntervalStartTime
                            {
                                get => _intervalStartTime;
                                set
                                {
                                    IntervalStartTimeRaw = Google.Apis.Util.Utilities.ConvertToString(value);
                                    _intervalStartTime = value;
                                }
                            }

                            public virtual System.DateTimeOffset? IntervalStartTimeDateTimeOffset
                            {
                                get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(IntervalStartTimeRaw);
                                set
                                {
                                    IntervalStartTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
                                    _intervalStartTime = value;
                                }
                            }

                            /// <summary>Optional. Hint for how to order the results</summary>
                            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string OrderBy { get; set; }

                            /// <summary>
                            /// Optional. The maximum number of customers row to return. The service may return fewer
                            /// than this value. If unspecified, at most 10 customers will be returned.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>
                            /// Optional. A page token, received from a previous `ListViolations` call. Provide this to
                            /// retrieve the subsequent page.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/violations";

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
                                    Pattern = @"^organizations/[^/]+/locations/[^/]+/customers/[^/]+/workloads/[^/]+$",
                                });
                                RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "filter",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                                RequestParameters.Add("interval.endTime", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "interval.endTime",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                                RequestParameters.Add("interval.startTime", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "interval.startTime",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                                RequestParameters.Add("orderBy", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "orderBy",
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

                    /// <summary>Gets details of a single workload</summary>
                    /// <param name="name">
                    /// Required. Format:
                    /// `organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}`
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets details of a single workload</summary>
                    public class GetRequest : CloudControlsPartnerServiceBaseServiceRequest<Google.Apis.CloudControlsPartnerService.v1.Data.Workload>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Format:
                        /// `organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}`
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
                                Pattern = @"^organizations/[^/]+/locations/[^/]+/customers/[^/]+/workloads/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets the EKM connections associated with a workload</summary>
                    /// <param name="name">
                    /// Required. Format:
                    /// `organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}/ekmConnections`
                    /// </param>
                    public virtual GetEkmConnectionsRequest GetEkmConnections(string name)
                    {
                        return new GetEkmConnectionsRequest(this.service, name);
                    }

                    /// <summary>Gets the EKM connections associated with a workload</summary>
                    public class GetEkmConnectionsRequest : CloudControlsPartnerServiceBaseServiceRequest<Google.Apis.CloudControlsPartnerService.v1.Data.EkmConnections>
                    {
                        /// <summary>Constructs a new GetEkmConnections request.</summary>
                        public GetEkmConnectionsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Format:
                        /// `organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}/ekmConnections`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "getEkmConnections";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}";

                        /// <summary>Initializes GetEkmConnections parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^organizations/[^/]+/locations/[^/]+/customers/[^/]+/workloads/[^/]+/ekmConnections$",
                            });
                        }
                    }

                    /// <summary>Gets the partner permissions granted for a workload</summary>
                    /// <param name="name">
                    /// Required. Name of the resource to get in the format:
                    /// `organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}/partnerPermissions`
                    /// </param>
                    public virtual GetPartnerPermissionsRequest GetPartnerPermissions(string name)
                    {
                        return new GetPartnerPermissionsRequest(this.service, name);
                    }

                    /// <summary>Gets the partner permissions granted for a workload</summary>
                    public class GetPartnerPermissionsRequest : CloudControlsPartnerServiceBaseServiceRequest<Google.Apis.CloudControlsPartnerService.v1.Data.PartnerPermissions>
                    {
                        /// <summary>Constructs a new GetPartnerPermissions request.</summary>
                        public GetPartnerPermissionsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Name of the resource to get in the format:
                        /// `organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}/partnerPermissions`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "getPartnerPermissions";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}";

                        /// <summary>Initializes GetPartnerPermissions parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^organizations/[^/]+/locations/[^/]+/customers/[^/]+/workloads/[^/]+/partnerPermissions$",
                            });
                        }
                    }

                    /// <summary>Lists customer workloads for a given customer org id</summary>
                    /// <param name="parent">
                    /// Required. Parent resource Format:
                    /// `organizations/{organization}/locations/{location}/customers/{customer}`
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists customer workloads for a given customer org id</summary>
                    public class ListRequest : CloudControlsPartnerServiceBaseServiceRequest<Google.Apis.CloudControlsPartnerService.v1.Data.ListWorkloadsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Parent resource Format:
                        /// `organizations/{organization}/locations/{location}/customers/{customer}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Optional. Filtering results.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>Optional. Hint for how to order the results.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>
                        /// The maximum number of workloads to return. The service may return fewer than this value. If
                        /// unspecified, at most 500 workloads will be returned.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// A page token, received from a previous `ListWorkloads` call. Provide this to retrieve the
                        /// subsequent page.
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
                                Pattern = @"^organizations/[^/]+/locations/[^/]+/customers/[^/]+$",
                            });
                            RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                            {
                                Name = "filter",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("orderBy", new Google.Apis.Discovery.Parameter
                            {
                                Name = "orderBy",
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

                /// <summary>Gets details of a single customer</summary>
                /// <param name="name">
                /// Required. Format: `organizations/{organization}/locations/{location}/customers/{customer}`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of a single customer</summary>
                public class GetRequest : CloudControlsPartnerServiceBaseServiceRequest<Google.Apis.CloudControlsPartnerService.v1.Data.Customer>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Format: `organizations/{organization}/locations/{location}/customers/{customer}`
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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+/customers/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists customers of a partner identified by its Google Cloud organization ID</summary>
                /// <param name="parent">
                /// Required. Parent resource Format: `organizations/{organization}/locations/{location}`
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists customers of a partner identified by its Google Cloud organization ID</summary>
                public class ListRequest : CloudControlsPartnerServiceBaseServiceRequest<Google.Apis.CloudControlsPartnerService.v1.Data.ListCustomersResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Parent resource Format: `organizations/{organization}/locations/{location}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Optional. Filtering results</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Optional. Hint for how to order the results</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// The maximum number of Customers to return. The service may return fewer than this value. If
                    /// unspecified, at most 500 Customers will be returned.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A page token, received from a previous `ListCustomers` call. Provide this to retrieve the
                    /// subsequent page.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/customers";

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
                        RequestParameters.Add("orderBy", new Google.Apis.Discovery.Parameter
                        {
                            Name = "orderBy",
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

            /// <summary>Get details of a Partner.</summary>
            /// <param name="name">Required. Format: `organizations/{organization}/locations/{location}/partner`</param>
            public virtual GetPartnerRequest GetPartner(string name)
            {
                return new GetPartnerRequest(this.service, name);
            }

            /// <summary>Get details of a Partner.</summary>
            public class GetPartnerRequest : CloudControlsPartnerServiceBaseServiceRequest<Google.Apis.CloudControlsPartnerService.v1.Data.Partner>
            {
                /// <summary>Constructs a new GetPartner request.</summary>
                public GetPartnerRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. Format: `organizations/{organization}/locations/{location}/partner`</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getPartner";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes GetPartner parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^organizations/[^/]+/locations/[^/]+/partner$",
                    });
                }
            }
        }
    }
}
namespace Google.Apis.CloudControlsPartnerService.v1.Data
{
    /// <summary>Details about the Access request.</summary>
    public class AccessApprovalRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Identifier. Format:
        /// `organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}/accessApprovalRequests/{access_approval_request}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _requestTimeRaw;

        private object _requestTime;

        /// <summary>The time at which approval was requested.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestTime")]
        public virtual string RequestTimeRaw
        {
            get => _requestTimeRaw;
            set
            {
                _requestTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _requestTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="RequestTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use RequestTimeDateTimeOffset instead.")]
        public virtual object RequestTime
        {
            get => _requestTime;
            set
            {
                _requestTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _requestTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="RequestTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? RequestTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(RequestTimeRaw);
            set => RequestTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _requestedExpirationTimeRaw;

        private object _requestedExpirationTime;

        /// <summary>
        /// The requested expiration for the approval. If the request is approved, access will be granted from the time
        /// of approval until the expiration time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedExpirationTime")]
        public virtual string RequestedExpirationTimeRaw
        {
            get => _requestedExpirationTimeRaw;
            set
            {
                _requestedExpirationTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _requestedExpirationTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="RequestedExpirationTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use RequestedExpirationTimeDateTimeOffset instead.")]
        public virtual object RequestedExpirationTime
        {
            get => _requestedExpirationTime;
            set
            {
                _requestedExpirationTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _requestedExpirationTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="RequestedExpirationTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? RequestedExpirationTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(RequestedExpirationTimeRaw);
            set => RequestedExpirationTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The justification for which approval is being requested.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedReason")]
        public virtual AccessReason RequestedReason { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Reason for the access.</summary>
    public class AccessReason : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>More detail about certain reason types. See comments for each type above.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detail")]
        public virtual string Detail { get; set; }

        /// <summary>Type of access justification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Information around the error that occurred if the connection state is anything other than available or
    /// unspecified
    /// </summary>
    public class ConnectionError : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The error domain for the error</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorDomain")]
        public virtual string ErrorDomain { get; set; }

        /// <summary>The error message for the error</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorMessage")]
        public virtual string ErrorMessage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Remediation instructions to resolve violation via cloud console</summary>
    public class Console : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Additional urls for more information about steps</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalLinks")]
        public virtual System.Collections.Generic.IList<string> AdditionalLinks { get; set; }

        /// <summary>Link to console page where violations can be resolved</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consoleUris")]
        public virtual System.Collections.Generic.IList<string> ConsoleUris { get; set; }

        /// <summary>Steps to resolve violation via cloud console</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("steps")]
        public virtual System.Collections.Generic.IList<string> Steps { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains metadata around a Cloud Controls Partner Customer</summary>
    public class Customer : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Container for customer onboarding steps</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerOnboardingState")]
        public virtual CustomerOnboardingState CustomerOnboardingState { get; set; }

        /// <summary>Output only. The customer organization's display name. E.g. "google.com".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Output only. Indicates whether a customer is fully onboarded</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isOnboarded")]
        public virtual System.Nullable<bool> IsOnboarded { get; set; }

        /// <summary>
        /// Identifier. Format: `organizations/{organization}/locations/{location}/customers/{customer}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Container for customer onboarding steps</summary>
    public class CustomerOnboardingState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of customer onboarding steps</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onboardingSteps")]
        public virtual System.Collections.Generic.IList<CustomerOnboardingStep> OnboardingSteps { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Container for customer onboarding information</summary>
    public class CustomerOnboardingStep : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Current state of the step</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completionState")]
        public virtual string CompletionState { get; set; }

        private string _completionTimeRaw;

        private object _completionTime;

        /// <summary>The completion time of the onboarding step</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completionTime")]
        public virtual string CompletionTimeRaw
        {
            get => _completionTimeRaw;
            set
            {
                _completionTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _completionTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CompletionTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CompletionTimeDateTimeOffset instead.")]
        public virtual object CompletionTime
        {
            get => _completionTime;
            set
            {
                _completionTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _completionTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="CompletionTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CompletionTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CompletionTimeRaw);
            set => CompletionTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>The starting time of the onboarding step</summary>
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

        /// <summary>The onboarding step</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("step")]
        public virtual string Step { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details about the EKM connection</summary>
    public class EkmConnection : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The connection error that occurred if any</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectionError")]
        public virtual ConnectionError ConnectionError { get; set; }

        /// <summary>
        /// Resource name of the EKM connection in the format:
        /// projects/{project}/locations/{location}/ekmConnections/{ekm_connection}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectionName")]
        public virtual string ConnectionName { get; set; }

        /// <summary>Output only. The connection state</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectionState")]
        public virtual string ConnectionState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The EKM connections associated with a workload</summary>
    public class EkmConnections : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The EKM connections associated with the workload</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ekmConnections")]
        public virtual System.Collections.Generic.IList<EkmConnection> EkmConnectionsValue { get; set; }

        /// <summary>
        /// Identifier. Format:
        /// `organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}/ekmConnections`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Holds information needed by Mudbray to use partner EKMs for workloads.</summary>
    public class EkmMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Endpoint for sending requests to the EKM for key provisioning during Assured Workload creation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ekmEndpointUri")]
        public virtual string EkmEndpointUri { get; set; }

        /// <summary>The Cloud EKM partner.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ekmSolution")]
        public virtual string EkmSolution { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Remediation instructions to resolve violation via gcloud cli</summary>
    public class Gcloud : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Additional urls for more information about steps</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalLinks")]
        public virtual System.Collections.Generic.IList<string> AdditionalLinks { get; set; }

        /// <summary>Gcloud command to resolve violation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcloudCommands")]
        public virtual System.Collections.Generic.IList<string> GcloudCommands { get; set; }

        /// <summary>Steps to resolve violation via gcloud cli</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("steps")]
        public virtual System.Collections.Generic.IList<string> Steps { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Instructions to remediate violation</summary>
    public class Instructions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Remediation instructions to resolve violation via cloud console</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consoleInstructions")]
        public virtual Console ConsoleInstructions { get; set; }

        /// <summary>Remediation instructions to resolve violation via gcloud cli</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcloudInstructions")]
        public virtual Gcloud GcloudInstructions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for list access requests.</summary>
    public class ListAccessApprovalRequestsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of access approval requests</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessApprovalRequests")]
        public virtual System.Collections.Generic.IList<AccessApprovalRequest> AccessApprovalRequests { get; set; }

        /// <summary>
        /// A token that can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for list customer Customers requests</summary>
    public class ListCustomersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of customers</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customers")]
        public virtual System.Collections.Generic.IList<Customer> Customers { get; set; }

        /// <summary>
        /// A token that can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for list customer violation requests</summary>
    public class ListViolationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token that can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// Workloads that could not be reached due to permission errors or any other error. Ref:
        /// https://google.aip.dev/217
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>List of violation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("violations")]
        public virtual System.Collections.Generic.IList<Violation> Violations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for list customer workloads requests.</summary>
    public class ListWorkloadsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token that can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>List of customer workloads</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workloads")]
        public virtual System.Collections.Generic.IList<Workload> Workloads { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the metadata of the long-running operation.</summary>
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
        /// been cancelled successfully have Operation.error value with a google.rpc.Status.code of 1, corresponding to
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

    /// <summary>Message describing Partner resource</summary>
    public class Partner : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Time the resource was created</summary>
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

        /// <summary>List of Google Cloud supported EKM partners supported by the partner</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ekmSolutions")]
        public virtual System.Collections.Generic.IList<EkmMetadata> EkmSolutions { get; set; }

        /// <summary>
        /// Identifier. The resource name of the partner. Format:
        /// `organizations/{organization}/locations/{location}/partner` Example:
        /// "organizations/123456/locations/us-central1/partner"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// List of Google Cloud regions that the partner sells services to customers. Valid Google Cloud regions found
        /// here: https://cloud.google.com/compute/docs/regions-zones
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operatedCloudRegions")]
        public virtual System.Collections.Generic.IList<string> OperatedCloudRegions { get; set; }

        /// <summary>
        /// Google Cloud project ID in the partner's Google Cloud organization for receiving enhanced Logs for Partners.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partnerProjectId")]
        public virtual string PartnerProjectId { get; set; }

        /// <summary>List of SKUs the partner is offering</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skus")]
        public virtual System.Collections.Generic.IList<Sku> Skus { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The last time the resource was updated</summary>
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

    /// <summary>The permissions granted to the partner for a workload</summary>
    public class PartnerPermissions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Identifier. Format:
        /// `organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}/partnerPermissions`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The partner permissions granted for the workload</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partnerPermissions")]
        public virtual System.Collections.Generic.IList<string> PartnerPermissionsValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents remediation guidance to resolve compliance violation for AssuredWorkload</summary>
    public class Remediation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Values that can resolve the violation For example: for list org policy violations, this will either be the
        /// list of allowed or denied values
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compliantValues")]
        public virtual System.Collections.Generic.IList<string> CompliantValues { get; set; }

        /// <summary>Required. Remediation instructions to resolve violations</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instructions")]
        public virtual Instructions Instructions { get; set; }

        /// <summary>Output only. Remediation type based on the type of org policy values violated</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("remediationType")]
        public virtual string RemediationType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the SKU a partner owns inside Google Cloud to sell to customers.</summary>
    public class Sku : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Display name of the product identified by the SKU. A partner may want to show partner branded names for
        /// their offerings such as local sovereign cloud solutions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Argentum product SKU, that is associated with the partner offerings to customers used by Syntro for billing
        /// purposes. SKUs can represent resold Google products or support services.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of resource Violation</summary>
    public class Violation : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _beginTimeRaw;

        private object _beginTime;

        /// <summary>Output only. Time of the event which triggered the Violation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("beginTime")]
        public virtual string BeginTimeRaw
        {
            get => _beginTimeRaw;
            set
            {
                _beginTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _beginTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="BeginTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use BeginTimeDateTimeOffset instead.")]
        public virtual object BeginTime
        {
            get => _beginTime;
            set
            {
                _beginTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _beginTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="BeginTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? BeginTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(BeginTimeRaw);
            set => BeginTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Output only. Category under which this violation is mapped. e.g. Location, Service Usage, Access,
        /// Encryption, etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual string Category { get; set; }

        /// <summary>
        /// Output only. Description for the Violation. e.g. OrgPolicy gcp.resourceLocations has non compliant value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The folder_id of the violation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("folderId")]
        public virtual System.Nullable<long> FolderId { get; set; }

        /// <summary>
        /// Identifier. Format:
        /// `organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}/violations/{violation}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. Immutable. Name of the OrgPolicy which was modified with non-compliant change and resulted this
        /// violation. Format: `projects/{project_number}/policies/{constraint_name}`
        /// `folders/{folder_id}/policies/{constraint_name}`
        /// `organizations/{organization_id}/policies/{constraint_name}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nonCompliantOrgPolicy")]
        public virtual string NonCompliantOrgPolicy { get; set; }

        /// <summary>Output only. Compliance violation remediation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("remediation")]
        public virtual Remediation Remediation { get; set; }

        private string _resolveTimeRaw;

        private object _resolveTime;

        /// <summary>
        /// Output only. Time of the event which fixed the Violation. If the violation is ACTIVE this will be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resolveTime")]
        public virtual string ResolveTimeRaw
        {
            get => _resolveTimeRaw;
            set
            {
                _resolveTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _resolveTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ResolveTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ResolveTimeDateTimeOffset instead.")]
        public virtual object ResolveTime
        {
            get => _resolveTime;
            set
            {
                _resolveTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _resolveTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ResolveTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ResolveTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ResolveTimeRaw);
            set => ResolveTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Output only. State of the violation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The last time when the Violation record was updated.</summary>
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
    /// Contains metadata around the [Workload
    /// resource](https://cloud.google.com/assured-workloads/docs/reference/rest/Shared.Types/Workload) in the Assured
    /// Workloads API.
    /// </summary>
    public class Workload : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Time the resource was created.</summary>
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

        /// <summary>Output only. The name of container folder of the assured workload</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("folder")]
        public virtual string Folder { get; set; }

        /// <summary>Output only. Folder id this workload is associated with</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("folderId")]
        public virtual System.Nullable<long> FolderId { get; set; }

        /// <summary>Indicates whether a workload is fully onboarded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isOnboarded")]
        public virtual System.Nullable<bool> IsOnboarded { get; set; }

        /// <summary>The project id of the key management project for the workload</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyManagementProjectId")]
        public virtual string KeyManagementProjectId { get; set; }

        /// <summary>The Google Cloud location of the workload</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>
        /// Identifier. Format:
        /// `organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Partner associated with this workload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partner")]
        public virtual string Partner { get; set; }

        /// <summary>Container for workload onboarding steps.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workloadOnboardingState")]
        public virtual WorkloadOnboardingState WorkloadOnboardingState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Container for workload onboarding steps.</summary>
    public class WorkloadOnboardingState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of workload onboarding steps.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onboardingSteps")]
        public virtual System.Collections.Generic.IList<WorkloadOnboardingStep> OnboardingSteps { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Container for workload onboarding information.</summary>
    public class WorkloadOnboardingStep : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The completion state of the onboarding step.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completionState")]
        public virtual string CompletionState { get; set; }

        private string _completionTimeRaw;

        private object _completionTime;

        /// <summary>The completion time of the onboarding step.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completionTime")]
        public virtual string CompletionTimeRaw
        {
            get => _completionTimeRaw;
            set
            {
                _completionTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _completionTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CompletionTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CompletionTimeDateTimeOffset instead.")]
        public virtual object CompletionTime
        {
            get => _completionTime;
            set
            {
                _completionTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _completionTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="CompletionTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CompletionTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CompletionTimeRaw);
            set => CompletionTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>The starting time of the onboarding step.</summary>
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

        /// <summary>The onboarding step.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("step")]
        public virtual string Step { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
